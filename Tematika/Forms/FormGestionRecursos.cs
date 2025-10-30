using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Styles;
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class FormGestionRecursos : Form
    {
        // Servicios para manejar la lógica de negocio
        private readonly DocenteMateriaService _docenteMateriaService = new DocenteMateriaService();
        private readonly RecursoService _recursoService = new RecursoService();
        private readonly TemaService _temaService = new TemaService();
        private readonly MateriaService _materiaService = new MateriaService();

        // Variable para almacenar el ID del recurso actualmente seleccionado
        private int? recursoSeleccionadoId = null;

        // Controla si se muestran recursos activos o inactivos
        private bool mostrarActivos = true;

        public FormGestionRecursos()
        {
            InitializeComponent();

            // Se ejecuta cuando se carga el formulario
            Load += FormGestionRecursos_Load;

            // Eventos de la grilla
            DGVRecursos.CellClick += DGVRecursos_CellClick;

            // Eventos de los botones
            BGuardarRecurso.Click += BGuardarRecurso_Click;
            BModificarRecurso.Click += BModificarRecurso_Click;
            BEliminarRecurso.Click += BEliminarRecurso_Click;
            BCancelarRecurso.Click += BCancelarRecurso_Click;
            BRecursosActivos.Click += BRecursosActivos_Click;
            BRecursosInactivos.Click += BRecursosInactivos_Click;
            BRuta.Click += BRuta_Click;

            // Eventos de combos
            CBMateriaRecurso.SelectedIndexChanged += CBMateriaRecurso_SelectedIndexChanged;
            CBFiltrarMateria.SelectedIndexChanged += CBFiltrarMateria_SelectedIndexChanged;
            CBFiltrarTema.SelectedIndexChanged += CBFiltrarTema_SelectedIndexChanged;

            // Evento del buscador para filtrar la grilla en tiempo real
            TBBuscadorRecurso.TextChanged += (s, e) =>
            {
                GridUtils.FiltrarFilasPorTexto(DGVRecursos, TBBuscadorRecurso.Text);
            };

            // Validaciones para que ciertos campos acepten solo letras
            TBTituloRecurso.KeyPress += (s, e) => Validaciones.ValidarSoloLetras(e);
            TBTexto.KeyPress += (s, e) => Validaciones.ValidarSoloLetras(e);

            // Configuración de combos para solo seleccionar valores predefinidos
            CBTipoRecurso.DropDownStyle = ComboBoxStyle.DropDownList;
            CBMateriaRecurso.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTemaRecurso.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormGestionRecursos_Load(object sender, EventArgs e)
        {
            // Aplicar estilo al encabezado del panel
            EstiloEncabezado.Aplicar(panelEncabezadoR, LTituloRecursos);

            // Color de fondo del panel de recursos
            panelRecurso.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            // Configuración del combo "Eliminado" (para marcar recursos como eliminados o no)
            CBEliminado.Items.Clear();
            CBEliminado.Items.Add("No");
            CBEliminado.Items.Add("Sí");
            CBEliminado.SelectedIndex = 0;

            labelEliminado.Visible = false;
            CBEliminado.Visible = false;

            // Tipo de recurso por defecto
            CBTipoRecurso.SelectedIndex = 0;

            // Cargar combos de materias y temas
            CargarMateriasCombo(CBMateriaRecurso);
            CargarMateriasCombo(CBFiltrarMateria);

            ReiniciarCombo<Tema>(CBTemaRecurso, "Seleccionar tema...");
            ReiniciarCombo<Tema>(CBFiltrarTema, "Seleccionar tema...");

            // Cargar los recursos en la grilla
            CargarRecursos();
        }

        // Carga materias en un ComboBox
        private void CargarMateriasCombo(ComboBox combo)
        {
            var materias = _materiaService.ListarMaterias()
                .Where(m => !m.Eliminado) // Solo materias activas
                .OrderBy(m => m.Nombre)
                .ToList();

            // Filtrar materias según perfil del usuario (docente)
            if (SesionManager.SesionActiva && SesionManager.UsuarioActual!.IdPerfil == 2)
            {
                var asignadas = _docenteMateriaService.ListarAsignaciones()
                    .Where(dm => dm.IdUsuario == SesionManager.UsuarioActual.IdUsuario)
                    .Select(dm => dm.IdMateria)
                    .Distinct()
                    .ToList();

                materias = materias.Where(m => asignadas.Contains(m.IdMateria)).ToList();
            }

            // Insertar opción por defecto
            materias.Insert(0, new Materia { IdMateria = 0, Nombre = "Seleccionar materia..." });

            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdMateria";
            combo.DataSource = materias;
        }

        // Carga temas en un ComboBox según la materia seleccionada
        private void CargarTemasCombo(ComboBox combo, int idMateria)
        {
            var temas = _temaService.ListarTemas()
                .Where(t => t.IdMateria == idMateria && !t.Eliminado)
                .OrderBy(t => t.Nombre)
                .ToList();

            temas.Insert(0, new Tema { IdTema = 0, Nombre = "Seleccionar tema..." });

            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdTema";
            combo.DataSource = temas;
        }

        // Reinicia un combo con un placeholder
        private void ReiniciarCombo<T>(ComboBox combo, string placeholder) where T : new()
        {
            var tipo = typeof(T);
            var item = Activator.CreateInstance<T>();

            if (tipo == typeof(Materia))
                ((Materia)(object)item).IdMateria = 0;
            else if (tipo == typeof(Tema))
                ((Tema)(object)item).IdTema = 0;

            tipo.GetProperty("Nombre")?.SetValue(item, placeholder);

            combo.DataSource = new List<T> { item };
            combo.DisplayMember = "Nombre";
            combo.ValueMember = tipo == typeof(Materia) ? "IdMateria" : "IdTema";
            combo.SelectedIndex = 0;
        }

        // Evento al cambiar la materia del recurso (carga temas correspondientes)
        private void CBMateriaRecurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBMateriaRecurso.SelectedValue is int idMateria && idMateria != 0)
                CargarTemasCombo(CBTemaRecurso, idMateria);
            else
                ReiniciarCombo<Tema>(CBTemaRecurso, "Seleccionar tema...");
        }

        // Evento al cambiar la materia en filtros
        private void CBFiltrarMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFiltrarMateria.SelectedValue is int idMateria && idMateria != 0)
                CargarTemasCombo(CBFiltrarTema, idMateria);
            else
                ReiniciarCombo<Tema>(CBFiltrarTema, "Seleccionar tema...");
        }

        // Evento al cambiar el tema en filtros
        private void CBFiltrarTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFiltrarTema.SelectedValue is int idTema && idTema != 0)
            {
                var recursos = _recursoService.ListarRecursos()
                    .Where(r => r.IdTema == idTema && r.Eliminado != mostrarActivos)
                    .ToList();

                DGVRecursos.Rows.Clear();

                foreach (var r in recursos)
                {
                    var tema = _temaService.ObtenerTema(r.IdTema);
                    DGVRecursos.Rows.Add(r.IdRecurso, r.Titulo, r.Texto, r.Ruta, r.Url, r.Tipo, tema?.Nombre ?? "Sin tema");
                }
            }
        }

        // Carga todos los recursos según el estado (activo/inactivo)
        private void CargarRecursos()
        {
            var recursos = _recursoService.ListarRecursos()
                .Where(r => r.Eliminado != mostrarActivos)
                .ToList();

            // Filtrar recursos para docentes
            if (SesionManager.SesionActiva && SesionManager.UsuarioActual!.IdPerfil == 2)
            {
                var materiasAsignadas = _docenteMateriaService.ListarAsignaciones()
                    .Where(dm => dm.IdUsuario == SesionManager.UsuarioActual.IdUsuario)
                    .Select(dm => dm.IdMateria)
                    .Distinct()
                    .ToList();

                var temasPermitidos = _temaService.ListarTemas()
                    .Where(t => materiasAsignadas.Contains(t.IdMateria) && !t.Eliminado)
                    .Select(t => t.IdTema)
                    .ToList();

                recursos = recursos.Where(r => temasPermitidos.Contains(r.IdTema)).ToList();
            }

            // Limpiar grilla y cargar recursos
            DGVRecursos.Rows.Clear();
            foreach (var r in recursos)
            {
                var tema = _temaService.ObtenerTema(r.IdTema);
                DGVRecursos.Rows.Add(r.IdRecurso, r.Titulo, r.Texto, r.Ruta, r.Url, r.Tipo, tema?.Nombre ?? "Sin tema");
            }

            // Configuración de botones
            BGuardarRecurso.Visible = true;
            BModificarRecurso.Visible = false;
            BEliminarRecurso.Visible = false;
            labelEliminado.Visible = false;
            CBEliminado.Visible = false;
        }

        // Evento al hacer clic en la grilla
        private void DGVRecursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Si se hizo clic en el botón "Ver" del recurso
            if (DGVRecursos.Columns[e.ColumnIndex].Name == "colAcciones")
            {
                var fila = DGVRecursos.Rows[e.RowIndex];
                var idRecurso = Convert.ToInt32(fila.Cells["IdRecurso"].Value);
                var recurso = _recursoService.ObtenerRecurso(idRecurso);
                if (recurso == null) return;

                var visualizador = new FormVisualizadorRecurso(recurso);

                // Deshabilitar interacción
                visualizador.btnMarcarFavorito.Enabled = false;
                visualizador.btnMarcarFavorito.BackColor = Color.Gray;
                visualizador.btnGuardarValoracion.Enabled = false;
                visualizador.btnGuardarValoracion.BackColor = Color.Gray;
                visualizador.comboBox1.Enabled = false;
                visualizador.comboBox1.BackColor = Color.Gray;
                visualizador.btnGuardarNota.Enabled = false;
                visualizador.btnGuardarNota.BackColor = Color.Gray;

                if (SesionManager.SesionActiva && SesionManager.UsuarioActual!.IdPerfil != 2)
                {
                    visualizador.button1.Enabled = false;
                    visualizador.button1.BackColor = Color.Gray;
                }

                visualizador.Show();
                return;
            }

            // Cargar datos del recurso para edición
            var filaEdicion = DGVRecursos.Rows[e.RowIndex];
            recursoSeleccionadoId = Convert.ToInt32(filaEdicion.Cells["IdRecurso"].Value);
            var recursoEdit = _recursoService.ObtenerRecurso(recursoSeleccionadoId.Value);
            if (recursoEdit == null) return;

            TBTituloRecurso.Text = recursoEdit.Titulo;
            TBTexto.Text = recursoEdit.Texto;
            TBRuta.Text = recursoEdit.Ruta;
            TBUrl.Text = recursoEdit.Url;
            CBTipoRecurso.SelectedItem = recursoEdit.Tipo;

            var tema = _temaService.ObtenerTema(recursoEdit.IdTema);
            if (tema != null)
            {
                // Selecciona la materia correspondiente al tema
                CBMateriaRecurso.SelectedValue = tema.IdMateria;

                // Carga los temas de esa materia
                CargarTemasCombo(CBTemaRecurso, tema.IdMateria);
                CBTemaRecurso.SelectedValue = recursoEdit.IdTema;
            }

            CBEliminado.SelectedItem = recursoEdit.Eliminado ? "Sí" : "No";

            // Muestra botones de edición
            BGuardarRecurso.Visible = false;
            BModificarRecurso.Visible = true;
            BEliminarRecurso.Visible = true;
            labelEliminado.Visible = true;
            CBEliminado.Visible = true;


            if (recursoEdit.Eliminado)
            {
                BEliminarRecurso.Visible = false;
            }
        }

        // Guardar nuevo recurso
        private void BGuardarRecurso_Click(object sender, EventArgs e)
        {
            var controlesObligatorios = new List<Control> { TBTituloRecurso, CBTipoRecurso, CBTemaRecurso };

            if (!Validaciones.ValidarControlesObligatorios(controlesObligatorios))
                return;

            if ((int)CBTemaRecurso.SelectedValue == 0)
            {
                MessageBox.Show("Debe seleccionar un tema válido.");
                CBTemaRecurso.Focus();
                return;
            }

            var recurso = new Recurso
            {
                Titulo = TBTituloRecurso.Text,
                Tipo = CBTipoRecurso.SelectedItem?.ToString() ?? "",
                IdTema = (int)CBTemaRecurso.SelectedValue,
                Texto = string.IsNullOrWhiteSpace(TBTexto.Text) ? null : TBTexto.Text,
                Ruta = string.IsNullOrWhiteSpace(TBRuta.Text) ? null : TBRuta.Text,
                Url = string.IsNullOrWhiteSpace(TBUrl.Text) ? null : TBUrl.Text,
                Eliminado = CBEliminado.SelectedItem?.ToString() == "Sí"
            };

            var error = _recursoService.CrearRecurso(recurso);
            if (error != null)
            {
                MessageBox.Show(error, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Recurso guardado correctamente.");
            CargarRecursos();
            LimpiarCampos();
        }

        // Modificar recurso existente
        private void BModificarRecurso_Click(object sender, EventArgs e)
        {
            if (recursoSeleccionadoId == null) return;

            var controlesObligatorios = new List<Control> { TBTituloRecurso, CBTipoRecurso, CBTemaRecurso };
            if (!Validaciones.ValidarControlesObligatorios(controlesObligatorios)) return;

            if ((int)CBTemaRecurso.SelectedValue == 0)
            {
                MessageBox.Show("Debe seleccionar un tema válido.");
                CBTemaRecurso.Focus();
                return;
            }

            var recurso = new Recurso
            {
                IdRecurso = recursoSeleccionadoId.Value,
                Titulo = TBTituloRecurso.Text,
                Tipo = CBTipoRecurso.SelectedItem?.ToString() ?? "",
                IdTema = (int)CBTemaRecurso.SelectedValue,
                Texto = string.IsNullOrWhiteSpace(TBTexto.Text) ? null : TBTexto.Text,
                Ruta = string.IsNullOrWhiteSpace(TBRuta.Text) ? null : TBRuta.Text,
                Url = string.IsNullOrWhiteSpace(TBUrl.Text) ? null : TBUrl.Text,
                Eliminado = CBEliminado.SelectedItem?.ToString() == "Sí"
            };

            var error = _recursoService.ActualizarRecurso(recurso);
            if (error != null)
            {
                MessageBox.Show(error, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Recurso modificado correctamente.");
            CargarRecursos();
            LimpiarCampos();


        }
        // Evento que se dispara al hacer clic en el botón "Eliminar Recurso"
        private void BEliminarRecurso_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado algún recurso; si no, muestra advertencia
            if (recursoSeleccionadoId == null)
            {
                MessageBox.Show("Debe seleccionar un recurso para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pregunta al usuario si realmente desea eliminar el recurso
            var confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este recurso?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            // Si el usuario confirma la eliminación
            if (confirmacion == DialogResult.Yes)
            {
                // Llama al servicio para eliminar el recurso
                _recursoService.EliminarRecurso(recursoSeleccionadoId.Value);

                // Mensaje de éxito
                MessageBox.Show("Recurso eliminado correctamente.");

                // Recarga la lista de recursos para reflejar los cambios
                CargarRecursos();

                // Limpia los campos del formulario
                LimpiarCampos();
            }
        }

        // Evento del botón "Cancelar", limpia los campos del formulario
        private void BCancelarRecurso_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Evento que muestra únicamente los recursos activos en la grilla
        private void BRecursosActivos_Click(object sender, EventArgs e)
        {
            mostrarActivos = true;  // Indica que se deben mostrar recursos activos
            CargarRecursos();        // Recarga la lista de recursos según el estado
        }

        // Evento que muestra únicamente los recursos inactivos en la grilla
        private void BRecursosInactivos_Click(object sender, EventArgs e)
        {
            mostrarActivos = false; // Indica que se deben mostrar recursos inactivos
            CargarRecursos();        // Recarga la lista de recursos según el estado
        }

        // Evento que abre un diálogo para seleccionar un archivo y asignarlo al recurso
        private void BRuta_Click(object sender, EventArgs e)
        {
            using var dialogo = new OpenFileDialog();

            // Filtro de archivos permitidos
            dialogo.Filter = "Archivos permitidos|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.txt";
            dialogo.Title = "Seleccionar archivo de recurso";

            // Si el usuario selecciona un archivo
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                string origen = dialogo.FileName;               // Ruta del archivo seleccionado
                string nombreArchivo = Path.GetFileName(origen);// Nombre del archivo

                // Obtiene la ruta del proyecto y crea la carpeta "Recursos" si no existe
                string rutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                string carpetaDestino = Path.Combine(rutaProyecto, "Recursos");
                Directory.CreateDirectory(carpetaDestino);

                // Copia el archivo seleccionado a la carpeta "Recursos" del proyecto
                string destino = Path.Combine(carpetaDestino, nombreArchivo);
                File.Copy(origen, destino, overwrite: true);

                // Muestra la ruta relativa en el textbox correspondiente
                TBRuta.Text = Path.Combine("Recursos", nombreArchivo).Replace("\\", "/");
            }
        }

        // Función para limpiar todos los campos del formulario y reiniciar combos y botones
        private void LimpiarCampos()
        {
            TBTituloRecurso.Clear();       // Limpia el título
            TBTexto.Clear();               // Limpia el texto
            TBRuta.Clear();                // Limpia la ruta
            TBUrl.Clear();                 // Limpia la URL
            CBTipoRecurso.SelectedIndex = 0;   // Selecciona el primer tipo de recurso
            CBMateriaRecurso.SelectedIndex = 0; // Selecciona la primera materia
            ReiniciarCombo<Tema>(CBTemaRecurso, "Seleccionar tema..."); // Reinicia combo de temas
            CBEliminado.SelectedIndex = 0; // Marca "No eliminado"
            recursoSeleccionadoId = null;  // Resetea el ID del recurso seleccionado

            // Recarga los combos de materias
            CargarMateriasCombo(CBMateriaRecurso);
            CargarMateriasCombo(CBFiltrarMateria);

            // Ajusta visibilidad de botones según el estado inicial
            BGuardarRecurso.Visible = true;
            BModificarRecurso.Visible = false;
            BEliminarRecurso.Visible = false;
            labelEliminado.Visible = false;
            CBEliminado.Visible = false;
        }

        // Evento generado automáticamente por el diseñador, actualmente no usado
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Evento generado automáticamente por el diseñador, actualmente no usado
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
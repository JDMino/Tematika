namespace Tematika.Forms.Cards
{
    partial class RecursoCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            labelTituloCard = new Label();
            labelTipoRecurso = new Label();
            buttonVerRecurso = new Button();
            labelTemaRecurso = new Label();
            labelVisitasRecurso = new Label();
            labelValoracionRecurso = new Label();
            SuspendLayout();
            // 
            // labelTituloCard
            // 
            labelTituloCard.AutoSize = true;
            labelTituloCard.Location = new Point(3, 7);
            labelTituloCard.Name = "labelTituloCard";
            labelTituloCard.Size = new Size(83, 15);
            labelTituloCard.TabIndex = 0;
            labelTituloCard.Text = "Titulo Recurso";
            // 
            // labelTipoRecurso
            // 
            labelTipoRecurso.AutoSize = true;
            labelTipoRecurso.Location = new Point(108, 7);
            labelTipoRecurso.Name = "labelTipoRecurso";
            labelTipoRecurso.Size = new Size(92, 15);
            labelTipoRecurso.TabIndex = 1;
            labelTipoRecurso.Text = "Tipo de Recurso";
            // 
            // buttonVerRecurso
            // 
            buttonVerRecurso.Location = new Point(3, 124);
            buttonVerRecurso.Name = "buttonVerRecurso";
            buttonVerRecurso.Size = new Size(194, 23);
            buttonVerRecurso.TabIndex = 2;
            buttonVerRecurso.Text = "Ver Recurso";
            buttonVerRecurso.UseVisualStyleBackColor = true;
            // 
            // labelTemaRecurso
            // 
            labelTemaRecurso.AutoSize = true;
            labelTemaRecurso.Location = new Point(3, 62);
            labelTemaRecurso.Name = "labelTemaRecurso";
            labelTemaRecurso.Size = new Size(39, 15);
            labelTemaRecurso.TabIndex = 3;
            labelTemaRecurso.Text = "Tema:";
            labelTemaRecurso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelVisitasRecurso
            // 
            labelVisitasRecurso.AutoSize = true;
            labelVisitasRecurso.Location = new Point(4, 77);
            labelVisitasRecurso.Name = "labelVisitasRecurso";
            labelVisitasRecurso.Size = new Size(43, 15);
            labelVisitasRecurso.TabIndex = 4;
            labelVisitasRecurso.Text = "Visitas:";
            labelVisitasRecurso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelValoracionRecurso
            // 
            labelValoracionRecurso.AutoSize = true;
            labelValoracionRecurso.Location = new Point(4, 92);
            labelValoracionRecurso.Name = "labelValoracionRecurso";
            labelValoracionRecurso.Size = new Size(65, 15);
            labelValoracionRecurso.TabIndex = 5;
            labelValoracionRecurso.Text = "Valoración:";
            labelValoracionRecurso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RecursoCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(labelValoracionRecurso);
            Controls.Add(labelVisitasRecurso);
            Controls.Add(labelTemaRecurso);
            Controls.Add(buttonVerRecurso);
            Controls.Add(labelTipoRecurso);
            Controls.Add(labelTituloCard);
            Margin = new Padding(10);
            Name = "RecursoCard";
            Size = new Size(200, 150);
            Load += RecursoCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTituloCard;
        private Label labelTipoRecurso;
        private Button buttonVerRecurso;
        private Label labelTemaRecurso;
        private Label labelVisitasRecurso;
        private Label labelValoracionRecurso;
    }
}

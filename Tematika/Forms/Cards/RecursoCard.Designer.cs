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
            labelTituloCard.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloCard.ForeColor = SystemColors.ActiveCaptionText;
            labelTituloCard.Location = new Point(3, 9);
            labelTituloCard.Name = "labelTituloCard";
            labelTituloCard.Size = new Size(119, 23);
            labelTituloCard.TabIndex = 0;
            labelTituloCard.Text = "Titulo Recurso";
            // 
            // labelTipoRecurso
            // 
            labelTipoRecurso.AutoSize = true;
            labelTipoRecurso.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipoRecurso.Location = new Point(5, 209);
            labelTipoRecurso.Name = "labelTipoRecurso";
            labelTipoRecurso.Size = new Size(133, 23);
            labelTipoRecurso.TabIndex = 1;
            labelTipoRecurso.Text = "Tipo de Recurso";
            // 
            // buttonVerRecurso
            // 
            buttonVerRecurso.BackColor = Color.Lavender;
            buttonVerRecurso.FlatAppearance.BorderSize = 0;
            buttonVerRecurso.FlatStyle = FlatStyle.Flat;
            buttonVerRecurso.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVerRecurso.ForeColor = SystemColors.ActiveCaptionText;
            buttonVerRecurso.Location = new Point(103, 162);
            buttonVerRecurso.Margin = new Padding(3, 4, 3, 4);
            buttonVerRecurso.Name = "buttonVerRecurso";
            buttonVerRecurso.Size = new Size(124, 31);
            buttonVerRecurso.TabIndex = 2;
            buttonVerRecurso.Text = "Ver Recurso";
            buttonVerRecurso.UseVisualStyleBackColor = false;
            buttonVerRecurso.Click += buttonVerRecurso_Click;
            // 
            // labelTemaRecurso
            // 
            labelTemaRecurso.AutoSize = true;
            labelTemaRecurso.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelTemaRecurso.ForeColor = SystemColors.ActiveCaptionText;
            labelTemaRecurso.Location = new Point(3, 85);
            labelTemaRecurso.Name = "labelTemaRecurso";
            labelTemaRecurso.Size = new Size(54, 23);
            labelTemaRecurso.TabIndex = 3;
            labelTemaRecurso.Text = "Tema:";
            labelTemaRecurso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelVisitasRecurso
            // 
            labelVisitasRecurso.AutoSize = true;
            labelVisitasRecurso.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelVisitasRecurso.ForeColor = SystemColors.ActiveCaptionText;
            labelVisitasRecurso.Location = new Point(5, 105);
            labelVisitasRecurso.Name = "labelVisitasRecurso";
            labelVisitasRecurso.Size = new Size(62, 23);
            labelVisitasRecurso.TabIndex = 4;
            labelVisitasRecurso.Text = "Visitas:";
            labelVisitasRecurso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelValoracionRecurso
            // 
            labelValoracionRecurso.AutoSize = true;
            labelValoracionRecurso.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelValoracionRecurso.ForeColor = SystemColors.ActiveCaptionText;
            labelValoracionRecurso.Location = new Point(5, 125);
            labelValoracionRecurso.Name = "labelValoracionRecurso";
            labelValoracionRecurso.Size = new Size(94, 23);
            labelValoracionRecurso.TabIndex = 5;
            labelValoracionRecurso.Text = "Valoración:";
            labelValoracionRecurso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RecursoCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(labelValoracionRecurso);
            Controls.Add(labelVisitasRecurso);
            Controls.Add(labelTemaRecurso);
            Controls.Add(buttonVerRecurso);
            Controls.Add(labelTipoRecurso);
            Controls.Add(labelTituloCard);
            Margin = new Padding(11, 13, 11, 13);
            Name = "RecursoCard";
            Size = new Size(352, 242);
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

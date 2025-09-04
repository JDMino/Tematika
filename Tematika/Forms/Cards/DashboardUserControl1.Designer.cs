namespace Tematika.Forms.Cards
{
    partial class DashboardUserControl1
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
            LInfoCard = new Label();
            LTituloCard = new Label();
            SuspendLayout();
            // 
            // LInfoCard
            // 
            LInfoCard.AutoSize = true;
            LInfoCard.Location = new Point(43, 23);
            LInfoCard.Name = "LInfoCard";
            LInfoCard.Size = new Size(41, 20);
            LInfoCard.TabIndex = 0;
            LInfoCard.Text = "Hola";
            LInfoCard.Click += LInfoCard_Click;
            // 
            // LTituloCard
            // 
            LTituloCard.Location = new Point(43, 82);
            LTituloCard.Name = "LTituloCard";
            LTituloCard.Size = new Size(104, 20);
            LTituloCard.TabIndex = 1;
            LTituloCard.Text = "Hola 2";
            // 
            // DashboardUserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            Controls.Add(LTituloCard);
            Controls.Add(LInfoCard);
            Name = "DashboardUserControl1";
            Load += DashboardUserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LInfoCard;
        private Label LTituloCard;
    }
}

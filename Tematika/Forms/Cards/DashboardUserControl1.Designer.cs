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
            panelDashboardUserControl = new TableLayoutPanel();
            panelDashboardUserControl.SuspendLayout();
            SuspendLayout();
            // 
            // LInfoCard
            // 
            LInfoCard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LInfoCard.AutoSize = true;
            LInfoCard.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LInfoCard.ForeColor = Color.White;
            LInfoCard.Location = new Point(3, 44);
            LInfoCard.Name = "LInfoCard";
            LInfoCard.Size = new Size(144, 31);
            LInfoCard.TabIndex = 0;
            LInfoCard.Text = "label1";
            LInfoCard.TextAlign = ContentAlignment.TopCenter;
            LInfoCard.Click += LInfoCard_Click;
            // 
            // LTituloCard
            // 
            LTituloCard.Dock = DockStyle.Fill;
            LTituloCard.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloCard.ForeColor = Color.White;
            LTituloCard.Location = new Point(3, 75);
            LTituloCard.Name = "LTituloCard";
            LTituloCard.Size = new Size(144, 75);
            LTituloCard.TabIndex = 1;
            LTituloCard.Text = "label 2";
            LTituloCard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDashboardUserControl
            // 
            panelDashboardUserControl.ColumnCount = 1;
            panelDashboardUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelDashboardUserControl.Controls.Add(LInfoCard, 0, 0);
            panelDashboardUserControl.Controls.Add(LTituloCard, 0, 1);
            panelDashboardUserControl.Dock = DockStyle.Fill;
            panelDashboardUserControl.Location = new Point(0, 0);
            panelDashboardUserControl.Name = "panelDashboardUserControl";
            panelDashboardUserControl.RowCount = 2;
            panelDashboardUserControl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelDashboardUserControl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelDashboardUserControl.Size = new Size(150, 150);
            panelDashboardUserControl.TabIndex = 2;
            // 
            // DashboardUserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            Controls.Add(panelDashboardUserControl);
            Name = "DashboardUserControl1";
            Load += DashboardUserControl1_Load;
            panelDashboardUserControl.ResumeLayout(false);
            panelDashboardUserControl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LInfoCard;
        private Label LTituloCard;
        private TableLayoutPanel panelDashboardUserControl;
    }
}

namespace ColaTransferenciasBancarias
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblOrigen = new Label();
            lblDestino = new Label();
            lblMonto = new Label();
            lblCantidad = new Label();
            txtId = new TextBox();
            txtOrigen = new TextBox();
            txtDestino = new TextBox();
            txtMonto = new TextBox();
            btnRegistrar = new Button();
            btnProcesar = new Button();
            lstTransferencias = new ListBox();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(60, 68);
            lblId.Name = "lblId";
            lblId.Size = new Size(105, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID de transferencia";
            lblId.Click += label1_Click;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(411, 68);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(98, 15);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Cuenta de origen";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(60, 141);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(103, 15);
            lblDestino.TabIndex = 2;
            lblDestino.Text = "Cuenta de destino";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(411, 141);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(65, 15);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto (S/)";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(64, 389);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(77, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Pendientes: 0";
            lblCantidad.Click += label1_Click_1;
            // 
            // txtId
            // 
            txtId.Location = new Point(64, 86);
            txtId.Name = "txtId";
            txtId.Size = new Size(267, 23);
            txtId.TabIndex = 5;
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(411, 86);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(285, 23);
            txtOrigen.TabIndex = 6;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(64, 159);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(271, 23);
            txtDestino.TabIndex = 7;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(411, 159);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(285, 23);
            txtMonto.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(124, 218);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(173, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar transferencia";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(401, 218);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(132, 23);
            btnProcesar.TabIndex = 10;
            btnProcesar.Text = "Procesar siguiente";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // lstTransferencias
            // 
            lstTransferencias.FormattingEnabled = true;
            lstTransferencias.Location = new Point(64, 265);
            lstTransferencias.Name = "lstTransferencias";
            lstTransferencias.Size = new Size(271, 94);
            lstTransferencias.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstTransferencias);
            Controls.Add(btnProcesar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtMonto);
            Controls.Add(txtDestino);
            Controls.Add(txtOrigen);
            Controls.Add(txtId);
            Controls.Add(lblCantidad);
            Controls.Add(lblMonto);
            Controls.Add(lblDestino);
            Controls.Add(lblOrigen);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "Gestión de transferencias bancarias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblOrigen;
        private Label lblDestino;
        private Label lblMonto;
        private Label lblCantidad;
        private TextBox txtId;
        private TextBox txtOrigen;
        private TextBox txtDestino;
        private TextBox txtMonto;
        private Button btnRegistrar;
        private Button btnProcesar;
        private ListBox lstTransferencias;
    }
}

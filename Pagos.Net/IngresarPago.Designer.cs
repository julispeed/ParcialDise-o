namespace Pagos.Net
{
    partial class IngresarPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pingpago = new System.Windows.Forms.Panel();
            this.BVolver = new System.Windows.Forms.Button();
            this.BIngresar = new System.Windows.Forms.Button();
            this.RBTarj = new System.Windows.Forms.RadioButton();
            this.RBTrans = new System.Windows.Forms.RadioButton();
            this.RBEfectivo = new System.Windows.Forms.RadioButton();
            this.Lfecha = new System.Windows.Forms.Label();
            this.DTFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.MTNumPago = new System.Windows.Forms.MaskedTextBox();
            this.MTImporte = new System.Windows.Forms.MaskedTextBox();
            this.LImporte = new System.Windows.Forms.Label();
            this.Ptrans = new System.Windows.Forms.Panel();
            this.MTCUIT = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MTCVU = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MTNumOp = new System.Windows.Forms.MaskedTextBox();
            this.LnumOp = new System.Windows.Forms.Label();
            this.PTarjeta = new System.Windows.Forms.Panel();
            this.CHacreditado = new System.Windows.Forms.CheckBox();
            this.CBFinanciacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBBanco = new System.Windows.Forms.TextBox();
            this.TBServicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lfds = new System.Windows.Forms.Label();
            this.MTNumCupon = new System.Windows.Forms.MaskedTextBox();
            this.Lnumcupon = new System.Windows.Forms.Label();
            this.Pingpago.SuspendLayout();
            this.Ptrans.SuspendLayout();
            this.PTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pingpago
            // 
            this.Pingpago.BackColor = System.Drawing.Color.Red;
            this.Pingpago.Controls.Add(this.BVolver);
            this.Pingpago.Controls.Add(this.BIngresar);
            this.Pingpago.Controls.Add(this.RBTarj);
            this.Pingpago.Controls.Add(this.RBTrans);
            this.Pingpago.Controls.Add(this.RBEfectivo);
            this.Pingpago.Controls.Add(this.Lfecha);
            this.Pingpago.Controls.Add(this.DTFechaPago);
            this.Pingpago.Controls.Add(this.label1);
            this.Pingpago.Controls.Add(this.MTNumPago);
            this.Pingpago.Controls.Add(this.MTImporte);
            this.Pingpago.Controls.Add(this.LImporte);
            this.Pingpago.Location = new System.Drawing.Point(12, 12);
            this.Pingpago.Name = "Pingpago";
            this.Pingpago.Size = new System.Drawing.Size(515, 154);
            this.Pingpago.TabIndex = 0;
            // 
            // BVolver
            // 
            this.BVolver.Location = new System.Drawing.Point(23, 63);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(75, 23);
            this.BVolver.TabIndex = 7;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = true;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // BIngresar
            // 
            this.BIngresar.Location = new System.Drawing.Point(195, 24);
            this.BIngresar.Name = "BIngresar";
            this.BIngresar.Size = new System.Drawing.Size(75, 23);
            this.BIngresar.TabIndex = 9;
            this.BIngresar.Text = "Ingresar";
            this.BIngresar.UseVisualStyleBackColor = true;
            this.BIngresar.Click += new System.EventHandler(this.BIngresar_Click);
            // 
            // RBTarj
            // 
            this.RBTarj.AutoSize = true;
            this.RBTarj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RBTarj.Location = new System.Drawing.Point(376, 120);
            this.RBTarj.Name = "RBTarj";
            this.RBTarj.Size = new System.Drawing.Size(58, 17);
            this.RBTarj.TabIndex = 8;
            this.RBTarj.Text = "Tarjeta";
            this.RBTarj.UseVisualStyleBackColor = false;
            this.RBTarj.CheckedChanged += new System.EventHandler(this.RBTarj_CheckedChanged);
            // 
            // RBTrans
            // 
            this.RBTrans.AutoSize = true;
            this.RBTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RBTrans.Location = new System.Drawing.Point(195, 120);
            this.RBTrans.Name = "RBTrans";
            this.RBTrans.Size = new System.Drawing.Size(90, 17);
            this.RBTrans.TabIndex = 7;
            this.RBTrans.Text = "Transferencia";
            this.RBTrans.UseVisualStyleBackColor = false;
            this.RBTrans.CheckedChanged += new System.EventHandler(this.RBTrans_CheckedChanged);
            // 
            // RBEfectivo
            // 
            this.RBEfectivo.AutoSize = true;
            this.RBEfectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RBEfectivo.Checked = true;
            this.RBEfectivo.Location = new System.Drawing.Point(23, 120);
            this.RBEfectivo.Name = "RBEfectivo";
            this.RBEfectivo.Size = new System.Drawing.Size(64, 17);
            this.RBEfectivo.TabIndex = 6;
            this.RBEfectivo.TabStop = true;
            this.RBEfectivo.Text = "Efectivo";
            this.RBEfectivo.UseVisualStyleBackColor = false;
            this.RBEfectivo.CheckedChanged += new System.EventHandler(this.RBEfectivo_CheckedChanged);
            // 
            // Lfecha
            // 
            this.Lfecha.AutoSize = true;
            this.Lfecha.BackColor = System.Drawing.Color.White;
            this.Lfecha.Location = new System.Drawing.Point(141, 73);
            this.Lfecha.Name = "Lfecha";
            this.Lfecha.Size = new System.Drawing.Size(80, 13);
            this.Lfecha.TabIndex = 5;
            this.Lfecha.Text = "Fecha de Pago";
            // 
            // DTFechaPago
            // 
            this.DTFechaPago.Location = new System.Drawing.Point(240, 67);
            this.DTFechaPago.Name = "DTFechaPago";
            this.DTFechaPago.Size = new System.Drawing.Size(200, 20);
            this.DTFechaPago.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(312, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero Pago";
            // 
            // MTNumPago
            // 
            this.MTNumPago.Location = new System.Drawing.Point(400, 21);
            this.MTNumPago.Mask = "99990";
            this.MTNumPago.Name = "MTNumPago";
            this.MTNumPago.Size = new System.Drawing.Size(40, 20);
            this.MTNumPago.TabIndex = 2;
            // 
            // MTImporte
            // 
            this.MTImporte.Location = new System.Drawing.Point(68, 21);
            this.MTImporte.Mask = "9999990.90";
            this.MTImporte.Name = "MTImporte";
            this.MTImporte.Size = new System.Drawing.Size(70, 20);
            this.MTImporte.TabIndex = 1;
            // 
            // LImporte
            // 
            this.LImporte.AutoSize = true;
            this.LImporte.BackColor = System.Drawing.Color.White;
            this.LImporte.Location = new System.Drawing.Point(20, 24);
            this.LImporte.Name = "LImporte";
            this.LImporte.Size = new System.Drawing.Size(42, 13);
            this.LImporte.TabIndex = 0;
            this.LImporte.Text = "Importe";
            // 
            // Ptrans
            // 
            this.Ptrans.BackColor = System.Drawing.Color.Purple;
            this.Ptrans.Controls.Add(this.MTCUIT);
            this.Ptrans.Controls.Add(this.label3);
            this.Ptrans.Controls.Add(this.MTCVU);
            this.Ptrans.Controls.Add(this.label2);
            this.Ptrans.Controls.Add(this.MTNumOp);
            this.Ptrans.Controls.Add(this.LnumOp);
            this.Ptrans.Location = new System.Drawing.Point(12, 172);
            this.Ptrans.Name = "Ptrans";
            this.Ptrans.Size = new System.Drawing.Size(231, 218);
            this.Ptrans.TabIndex = 1;
            this.Ptrans.Visible = false;
            // 
            // MTCUIT
            // 
            this.MTCUIT.Location = new System.Drawing.Point(67, 163);
            this.MTCUIT.Mask = "00-00000000-0";
            this.MTCUIT.Name = "MTCUIT";
            this.MTCUIT.Size = new System.Drawing.Size(88, 20);
            this.MTCUIT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CUIT Origen";
            // 
            // MTCVU
            // 
            this.MTCVU.Location = new System.Drawing.Point(43, 91);
            this.MTCVU.Mask = "0000000000000000000000";
            this.MTCVU.Name = "MTCVU";
            this.MTCVU.Size = new System.Drawing.Size(136, 20);
            this.MTCVU.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CBU/CVU Origen";
            // 
            // MTNumOp
            // 
            this.MTNumOp.Location = new System.Drawing.Point(57, 27);
            this.MTNumOp.Mask = "00000000000000000000";
            this.MTNumOp.Name = "MTNumOp";
            this.MTNumOp.Size = new System.Drawing.Size(130, 20);
            this.MTNumOp.TabIndex = 1;
            // 
            // LnumOp
            // 
            this.LnumOp.AutoSize = true;
            this.LnumOp.Location = new System.Drawing.Point(64, 11);
            this.LnumOp.Name = "LnumOp";
            this.LnumOp.Size = new System.Drawing.Size(111, 13);
            this.LnumOp.TabIndex = 0;
            this.LnumOp.Text = "Numero de Operacion";
            // 
            // PTarjeta
            // 
            this.PTarjeta.BackColor = System.Drawing.Color.Lime;
            this.PTarjeta.Controls.Add(this.CHacreditado);
            this.PTarjeta.Controls.Add(this.CBFinanciacion);
            this.PTarjeta.Controls.Add(this.label5);
            this.PTarjeta.Controls.Add(this.TBBanco);
            this.PTarjeta.Controls.Add(this.TBServicio);
            this.PTarjeta.Controls.Add(this.label4);
            this.PTarjeta.Controls.Add(this.Lfds);
            this.PTarjeta.Controls.Add(this.MTNumCupon);
            this.PTarjeta.Controls.Add(this.Lnumcupon);
            this.PTarjeta.Location = new System.Drawing.Point(310, 172);
            this.PTarjeta.Name = "PTarjeta";
            this.PTarjeta.Size = new System.Drawing.Size(217, 218);
            this.PTarjeta.TabIndex = 6;
            this.PTarjeta.Visible = false;
            // 
            // CHacreditado
            // 
            this.CHacreditado.AutoSize = true;
            this.CHacreditado.Location = new System.Drawing.Point(73, 190);
            this.CHacreditado.Name = "CHacreditado";
            this.CHacreditado.Size = new System.Drawing.Size(77, 17);
            this.CHacreditado.TabIndex = 12;
            this.CHacreditado.Text = "Acreditado";
            this.CHacreditado.UseVisualStyleBackColor = true;
            // 
            // CBFinanciacion
            // 
            this.CBFinanciacion.FormattingEnabled = true;
            this.CBFinanciacion.Items.AddRange(new object[] {
            "DEBITO",
            "CREDITO"});
            this.CBFinanciacion.Location = new System.Drawing.Point(55, 163);
            this.CBFinanciacion.Name = "CBFinanciacion";
            this.CBFinanciacion.Size = new System.Drawing.Size(121, 21);
            this.CBFinanciacion.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Financiacion";
            // 
            // TBBanco
            // 
            this.TBBanco.Location = new System.Drawing.Point(55, 66);
            this.TBBanco.Name = "TBBanco";
            this.TBBanco.Size = new System.Drawing.Size(118, 20);
            this.TBBanco.TabIndex = 8;
            // 
            // TBServicio
            // 
            this.TBServicio.Location = new System.Drawing.Point(55, 110);
            this.TBServicio.Name = "TBServicio";
            this.TBServicio.Size = new System.Drawing.Size(118, 20);
            this.TBServicio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Servicio";
            // 
            // Lfds
            // 
            this.Lfds.AutoSize = true;
            this.Lfds.Location = new System.Drawing.Point(89, 50);
            this.Lfds.Name = "Lfds";
            this.Lfds.Size = new System.Drawing.Size(38, 13);
            this.Lfds.TabIndex = 2;
            this.Lfds.Text = "Banco";
            // 
            // MTNumCupon
            // 
            this.MTNumCupon.Location = new System.Drawing.Point(92, 27);
            this.MTNumCupon.Mask = "99990";
            this.MTNumCupon.Name = "MTNumCupon";
            this.MTNumCupon.Size = new System.Drawing.Size(39, 20);
            this.MTNumCupon.TabIndex = 1;
            // 
            // Lnumcupon
            // 
            this.Lnumcupon.AutoSize = true;
            this.Lnumcupon.Location = new System.Drawing.Point(64, 11);
            this.Lnumcupon.Name = "Lnumcupon";
            this.Lnumcupon.Size = new System.Drawing.Size(92, 13);
            this.Lnumcupon.TabIndex = 0;
            this.Lnumcupon.Text = "Numero de cupón";
            // 
            // IngresarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(539, 399);
            this.Controls.Add(this.PTarjeta);
            this.Controls.Add(this.Ptrans);
            this.Controls.Add(this.Pingpago);
            this.Name = "IngresarPago";
            this.Text = "IngresarPago";
            this.Pingpago.ResumeLayout(false);
            this.Pingpago.PerformLayout();
            this.Ptrans.ResumeLayout(false);
            this.Ptrans.PerformLayout();
            this.PTarjeta.ResumeLayout(false);
            this.PTarjeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pingpago;
        private System.Windows.Forms.Label Lfecha;
        private System.Windows.Forms.DateTimePicker DTFechaPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MTNumPago;
        private System.Windows.Forms.MaskedTextBox MTImporte;
        private System.Windows.Forms.Label LImporte;
        private System.Windows.Forms.RadioButton RBTarj;
        private System.Windows.Forms.RadioButton RBTrans;
        private System.Windows.Forms.RadioButton RBEfectivo;
        private System.Windows.Forms.Panel Ptrans;
        private System.Windows.Forms.MaskedTextBox MTCVU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MTNumOp;
        private System.Windows.Forms.Label LnumOp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MTCUIT;
        private System.Windows.Forms.Panel PTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lfds;
        private System.Windows.Forms.MaskedTextBox MTNumCupon;
        private System.Windows.Forms.Label Lnumcupon;
        private System.Windows.Forms.TextBox TBServicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBBanco;
        private System.Windows.Forms.Button BIngresar;
        private System.Windows.Forms.ComboBox CBFinanciacion;
        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.CheckBox CHacreditado;
    }
}
namespace PryTP1
{
    partial class frmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpboxGastosP = new System.Windows.Forms.GroupBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblEscritura = new System.Windows.Forms.Label();
            this.lblRentas = new System.Windows.Forms.Label();
            this.txtboxEscritura = new System.Windows.Forms.TextBox();
            this.txtboxIVA = new System.Windows.Forms.TextBox();
            this.txtboxRentas = new System.Windows.Forms.TextBox();
            this.lblRecargoPiso = new System.Windows.Forms.Label();
            this.txtboxRecargo = new System.Windows.Forms.TextBox();
            this.lblMontoT = new System.Windows.Forms.Label();
            this.txtboxMontoT = new System.Windows.Forms.TextBox();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.ColumnaP4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaP3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaP12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNroPiso = new System.Windows.Forms.Label();
            this.cmbNroPiso = new System.Windows.Forms.ComboBox();
            this.grpboxAberturas = new System.Windows.Forms.GroupBox();
            this.rbMadera = new System.Windows.Forms.RadioButton();
            this.rbAluminio = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grpboxTipoPiso = new System.Windows.Forms.GroupBox();
            this.rbPorcelanato = new System.Windows.Forms.RadioButton();
            this.rbAlisado = new System.Windows.Forms.RadioButton();
            this.rbFlotante = new System.Windows.Forms.RadioButton();
            this.grpboxDepto = new System.Windows.Forms.GroupBox();
            this.rbDeptoA = new System.Windows.Forms.RadioButton();
            this.rbDeptoB = new System.Windows.Forms.RadioButton();
            this.rbDeptoC = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblNroDepto = new System.Windows.Forms.Label();
            this.txtboxNroDepto = new System.Windows.Forms.TextBox();
            this.flpPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpboxGastosP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.grpboxAberturas.SuspendLayout();
            this.grpboxTipoPiso.SuspendLayout();
            this.grpboxDepto.SuspendLayout();
            this.flpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtboxNroDepto);
            this.splitContainer1.Panel1.Controls.Add(this.lblNroDepto);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditar);
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminar);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregar);
            this.splitContainer1.Panel1.Controls.Add(this.grpboxDepto);
            this.splitContainer1.Panel1.Controls.Add(this.grpboxTipoPiso);
            this.splitContainer1.Panel1.Controls.Add(this.btnCalcular);
            this.splitContainer1.Panel1.Controls.Add(this.grpboxAberturas);
            this.splitContainer1.Panel1.Controls.Add(this.cmbNroPiso);
            this.splitContainer1.Panel1.Controls.Add(this.lblNroPiso);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.splitContainer1.Panel2.Controls.Add(this.dgvCarrito);
            this.splitContainer1.Panel2.Controls.Add(this.txtboxMontoT);
            this.splitContainer1.Panel2.Controls.Add(this.lblMontoT);
            this.splitContainer1.Panel2.Controls.Add(this.grpboxGastosP);
            this.splitContainer1.Size = new System.Drawing.Size(645, 494);
            this.splitContainer1.SplitterDistance = 320;
            this.splitContainer1.TabIndex = 6;
            // 
            // grpboxGastosP
            // 
            this.grpboxGastosP.Controls.Add(this.txtboxRecargo);
            this.grpboxGastosP.Controls.Add(this.lblRecargoPiso);
            this.grpboxGastosP.Controls.Add(this.txtboxRentas);
            this.grpboxGastosP.Controls.Add(this.txtboxIVA);
            this.grpboxGastosP.Controls.Add(this.txtboxEscritura);
            this.grpboxGastosP.Controls.Add(this.lblRentas);
            this.grpboxGastosP.Controls.Add(this.lblEscritura);
            this.grpboxGastosP.Controls.Add(this.lblIVA);
            this.grpboxGastosP.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxGastosP.ForeColor = System.Drawing.Color.LightYellow;
            this.grpboxGastosP.Location = new System.Drawing.Point(13, 261);
            this.grpboxGastosP.Name = "grpboxGastosP";
            this.grpboxGastosP.Size = new System.Drawing.Size(293, 158);
            this.grpboxGastosP.TabIndex = 0;
            this.grpboxGastosP.TabStop = false;
            this.grpboxGastosP.Text = "Gastos parciales";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.Color.LightYellow;
            this.lblIVA.Location = new System.Drawing.Point(17, 60);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(98, 23);
            this.lblIVA.TabIndex = 5;
            this.lblIVA.Text = "IVA (10.5%)";
            // 
            // lblEscritura
            // 
            this.lblEscritura.AutoSize = true;
            this.lblEscritura.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscritura.ForeColor = System.Drawing.Color.LightYellow;
            this.lblEscritura.Location = new System.Drawing.Point(17, 32);
            this.lblEscritura.Name = "lblEscritura";
            this.lblEscritura.Size = new System.Drawing.Size(118, 23);
            this.lblEscritura.TabIndex = 4;
            this.lblEscritura.Text = "Escritura (9%)";
            // 
            // lblRentas
            // 
            this.lblRentas.AutoSize = true;
            this.lblRentas.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentas.ForeColor = System.Drawing.Color.LightYellow;
            this.lblRentas.Location = new System.Drawing.Point(17, 88);
            this.lblRentas.Name = "lblRentas";
            this.lblRentas.Size = new System.Drawing.Size(114, 23);
            this.lblRentas.TabIndex = 6;
            this.lblRentas.Text = "Rentas (2.1%)";
            // 
            // txtboxEscritura
            // 
            this.txtboxEscritura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEscritura.Location = new System.Drawing.Point(182, 32);
            this.txtboxEscritura.Name = "txtboxEscritura";
            this.txtboxEscritura.Size = new System.Drawing.Size(95, 22);
            this.txtboxEscritura.TabIndex = 11;
            this.txtboxEscritura.Text = "0";
            this.txtboxEscritura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxIVA
            // 
            this.txtboxIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxIVA.Location = new System.Drawing.Point(182, 60);
            this.txtboxIVA.Name = "txtboxIVA";
            this.txtboxIVA.Size = new System.Drawing.Size(95, 22);
            this.txtboxIVA.TabIndex = 12;
            this.txtboxIVA.Text = "0";
            this.txtboxIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxRentas
            // 
            this.txtboxRentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxRentas.Location = new System.Drawing.Point(182, 88);
            this.txtboxRentas.Name = "txtboxRentas";
            this.txtboxRentas.Size = new System.Drawing.Size(95, 22);
            this.txtboxRentas.TabIndex = 13;
            this.txtboxRentas.Text = "0";
            this.txtboxRentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRecargoPiso
            // 
            this.lblRecargoPiso.AutoSize = true;
            this.lblRecargoPiso.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecargoPiso.ForeColor = System.Drawing.Color.LightYellow;
            this.lblRecargoPiso.Location = new System.Drawing.Point(17, 116);
            this.lblRecargoPiso.Name = "lblRecargoPiso";
            this.lblRecargoPiso.Size = new System.Drawing.Size(159, 23);
            this.lblRecargoPiso.TabIndex = 14;
            this.lblRecargoPiso.Text = "Recargo  (5% al 7%)";
            // 
            // txtboxRecargo
            // 
            this.txtboxRecargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxRecargo.Location = new System.Drawing.Point(182, 116);
            this.txtboxRecargo.Name = "txtboxRecargo";
            this.txtboxRecargo.Size = new System.Drawing.Size(95, 22);
            this.txtboxRecargo.TabIndex = 17;
            this.txtboxRecargo.Text = "0";
            this.txtboxRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMontoT
            // 
            this.lblMontoT.AutoSize = true;
            this.lblMontoT.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoT.ForeColor = System.Drawing.Color.LightYellow;
            this.lblMontoT.Location = new System.Drawing.Point(30, 431);
            this.lblMontoT.Name = "lblMontoT";
            this.lblMontoT.Size = new System.Drawing.Size(107, 23);
            this.lblMontoT.TabIndex = 4;
            this.lblMontoT.Text = "Monto total";
            // 
            // txtboxMontoT
            // 
            this.txtboxMontoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMontoT.Location = new System.Drawing.Point(169, 433);
            this.txtboxMontoT.Name = "txtboxMontoT";
            this.txtboxMontoT.Size = new System.Drawing.Size(121, 22);
            this.txtboxMontoT.TabIndex = 14;
            this.txtboxMontoT.Text = "0";
            this.txtboxMontoT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvCarrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaP1,
            this.ColumnaP12,
            this.ColumnaP3,
            this.ColumnaP4});
            this.dgvCarrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvCarrito.Location = new System.Drawing.Point(3, 3);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersWidth = 16;
            this.dgvCarrito.Size = new System.Drawing.Size(318, 252);
            this.dgvCarrito.TabIndex = 15;
            // 
            // ColumnaP4
            // 
            this.ColumnaP4.HeaderText = "Abertura";
            this.ColumnaP4.Name = "ColumnaP4";
            this.ColumnaP4.Width = 75;
            // 
            // ColumnaP3
            // 
            this.ColumnaP3.HeaderText = "Material del piso";
            this.ColumnaP3.Name = "ColumnaP3";
            this.ColumnaP3.Width = 75;
            // 
            // ColumnaP12
            // 
            this.ColumnaP12.HeaderText = "Tipo ";
            this.ColumnaP12.Name = "ColumnaP12";
            this.ColumnaP12.Width = 75;
            // 
            // ColumnaP1
            // 
            this.ColumnaP1.HeaderText = "Piso ";
            this.ColumnaP1.Name = "ColumnaP1";
            this.ColumnaP1.Width = 75;
            // 
            // lblNroPiso
            // 
            this.lblNroPiso.AutoSize = true;
            this.lblNroPiso.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroPiso.ForeColor = System.Drawing.Color.LightYellow;
            this.lblNroPiso.Location = new System.Drawing.Point(22, 359);
            this.lblNroPiso.Name = "lblNroPiso";
            this.lblNroPiso.Size = new System.Drawing.Size(142, 23);
            this.lblNroPiso.TabIndex = 3;
            this.lblNroPiso.Text = "Numero de piso:";
            // 
            // cmbNroPiso
            // 
            this.cmbNroPiso.FormattingEnabled = true;
            this.cmbNroPiso.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbNroPiso.Location = new System.Drawing.Point(167, 363);
            this.cmbNroPiso.Name = "cmbNroPiso";
            this.cmbNroPiso.Size = new System.Drawing.Size(130, 21);
            this.cmbNroPiso.TabIndex = 4;
            // 
            // grpboxAberturas
            // 
            this.grpboxAberturas.Controls.Add(this.rbAluminio);
            this.grpboxAberturas.Controls.Add(this.rbMadera);
            this.grpboxAberturas.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxAberturas.ForeColor = System.Drawing.Color.LightYellow;
            this.grpboxAberturas.Location = new System.Drawing.Point(22, 261);
            this.grpboxAberturas.Name = "grpboxAberturas";
            this.grpboxAberturas.Size = new System.Drawing.Size(275, 91);
            this.grpboxAberturas.TabIndex = 2;
            this.grpboxAberturas.TabStop = false;
            this.grpboxAberturas.Text = "Tipo de aberturas";
            // 
            // rbMadera
            // 
            this.rbMadera.AutoSize = true;
            this.rbMadera.Location = new System.Drawing.Point(7, 27);
            this.rbMadera.Name = "rbMadera";
            this.rbMadera.Size = new System.Drawing.Size(174, 27);
            this.rbMadera.TabIndex = 0;
            this.rbMadera.TabStop = true;
            this.rbMadera.Text = "Madera ( $46*m² )";
            this.rbMadera.UseVisualStyleBackColor = true;
            // 
            // rbAluminio
            // 
            this.rbAluminio.AutoSize = true;
            this.rbAluminio.Location = new System.Drawing.Point(7, 56);
            this.rbAluminio.Name = "rbAluminio";
            this.rbAluminio.Size = new System.Drawing.Size(182, 27);
            this.rbAluminio.TabIndex = 2;
            this.rbAluminio.TabStop = true;
            this.rbAluminio.Text = "Aluminio ( $25*m² )";
            this.rbAluminio.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnCalcular.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Navy;
            this.btnCalcular.Location = new System.Drawing.Point(167, 390);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(130, 29);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // grpboxTipoPiso
            // 
            this.grpboxTipoPiso.Controls.Add(this.rbFlotante);
            this.grpboxTipoPiso.Controls.Add(this.rbAlisado);
            this.grpboxTipoPiso.Controls.Add(this.rbPorcelanato);
            this.grpboxTipoPiso.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxTipoPiso.ForeColor = System.Drawing.Color.LightYellow;
            this.grpboxTipoPiso.Location = new System.Drawing.Point(22, 132);
            this.grpboxTipoPiso.Name = "grpboxTipoPiso";
            this.grpboxTipoPiso.Size = new System.Drawing.Size(275, 123);
            this.grpboxTipoPiso.TabIndex = 1;
            this.grpboxTipoPiso.TabStop = false;
            this.grpboxTipoPiso.Text = "Tipo de piso";
            // 
            // rbPorcelanato
            // 
            this.rbPorcelanato.AutoSize = true;
            this.rbPorcelanato.Location = new System.Drawing.Point(7, 27);
            this.rbPorcelanato.Name = "rbPorcelanato";
            this.rbPorcelanato.Size = new System.Drawing.Size(207, 27);
            this.rbPorcelanato.TabIndex = 0;
            this.rbPorcelanato.TabStop = true;
            this.rbPorcelanato.Text = "Porcelanato ( $32*m² )";
            this.rbPorcelanato.UseVisualStyleBackColor = true;
            // 
            // rbAlisado
            // 
            this.rbAlisado.AutoSize = true;
            this.rbAlisado.Location = new System.Drawing.Point(7, 85);
            this.rbAlisado.Name = "rbAlisado";
            this.rbAlisado.Size = new System.Drawing.Size(186, 27);
            this.rbAlisado.TabIndex = 1;
            this.rbAlisado.TabStop = true;
            this.rbAlisado.Text = "Alisado ( $21.21*m² )";
            this.rbAlisado.UseVisualStyleBackColor = true;
            // 
            // rbFlotante
            // 
            this.rbFlotante.AutoSize = true;
            this.rbFlotante.Location = new System.Drawing.Point(7, 56);
            this.rbFlotante.Name = "rbFlotante";
            this.rbFlotante.Size = new System.Drawing.Size(194, 27);
            this.rbFlotante.TabIndex = 2;
            this.rbFlotante.TabStop = true;
            this.rbFlotante.Text = "Flotante ( $26.5*m² )";
            this.rbFlotante.UseVisualStyleBackColor = true;
            // 
            // grpboxDepto
            // 
            this.grpboxDepto.Controls.Add(this.rbDeptoC);
            this.grpboxDepto.Controls.Add(this.rbDeptoB);
            this.grpboxDepto.Controls.Add(this.rbDeptoA);
            this.grpboxDepto.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxDepto.ForeColor = System.Drawing.Color.LightYellow;
            this.grpboxDepto.Location = new System.Drawing.Point(22, 3);
            this.grpboxDepto.Name = "grpboxDepto";
            this.grpboxDepto.Size = new System.Drawing.Size(275, 123);
            this.grpboxDepto.TabIndex = 0;
            this.grpboxDepto.TabStop = false;
            this.grpboxDepto.Text = "Tipo de departamento";
            // 
            // rbDeptoA
            // 
            this.rbDeptoA.AutoSize = true;
            this.rbDeptoA.Checked = true;
            this.rbDeptoA.Location = new System.Drawing.Point(7, 27);
            this.rbDeptoA.Name = "rbDeptoA";
            this.rbDeptoA.Size = new System.Drawing.Size(268, 27);
            this.rbDeptoA.TabIndex = 0;
            this.rbDeptoA.TabStop = true;
            this.rbDeptoA.Text = "Tipo A (85 m² + 21 m² cochera)";
            this.rbDeptoA.UseVisualStyleBackColor = true;
            // 
            // rbDeptoB
            // 
            this.rbDeptoB.AutoSize = true;
            this.rbDeptoB.Location = new System.Drawing.Point(7, 56);
            this.rbDeptoB.Name = "rbDeptoB";
            this.rbDeptoB.Size = new System.Drawing.Size(138, 27);
            this.rbDeptoB.TabIndex = 1;
            this.rbDeptoB.Text = "Tipo B (52 m²)";
            this.rbDeptoB.UseVisualStyleBackColor = true;
            // 
            // rbDeptoC
            // 
            this.rbDeptoC.AutoSize = true;
            this.rbDeptoC.Location = new System.Drawing.Point(7, 85);
            this.rbDeptoC.Name = "rbDeptoC";
            this.rbDeptoC.Size = new System.Drawing.Size(139, 27);
            this.rbDeptoC.TabIndex = 2;
            this.rbDeptoC.Text = "Tipo C (35 m²)";
            this.rbDeptoC.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Yellow;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAgregar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.Location = new System.Drawing.Point(22, 390);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 29);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnEliminar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Blue;
            this.btnEliminar.Location = new System.Drawing.Point(22, 425);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 29);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gold;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnEditar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEditar.Location = new System.Drawing.Point(167, 425);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 29);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // lblNroDepto
            // 
            this.lblNroDepto.AutoSize = true;
            this.lblNroDepto.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDepto.ForeColor = System.Drawing.Color.LightYellow;
            this.lblNroDepto.Location = new System.Drawing.Point(22, 457);
            this.lblNroDepto.Name = "lblNroDepto";
            this.lblNroDepto.Size = new System.Drawing.Size(232, 23);
            this.lblNroDepto.TabIndex = 9;
            this.lblNroDepto.Text = "Numero de departamentos:";
            // 
            // txtboxNroDepto
            // 
            this.txtboxNroDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNroDepto.Location = new System.Drawing.Point(260, 461);
            this.txtboxNroDepto.Name = "txtboxNroDepto";
            this.txtboxNroDepto.Size = new System.Drawing.Size(37, 22);
            this.txtboxNroDepto.TabIndex = 10;
            this.txtboxNroDepto.Text = "0";
            this.txtboxNroDepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flpPrincipal
            // 
            this.flpPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.flpPrincipal.Controls.Add(this.splitContainer1);
            this.flpPrincipal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPrincipal.Location = new System.Drawing.Point(12, 12);
            this.flpPrincipal.Name = "flpPrincipal";
            this.flpPrincipal.Size = new System.Drawing.Size(651, 501);
            this.flpPrincipal.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(675, 525);
            this.Controls.Add(this.flpPrincipal);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmPrincipal";
            this.Text = "CARC";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpboxGastosP.ResumeLayout(false);
            this.grpboxGastosP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.grpboxAberturas.ResumeLayout(false);
            this.grpboxAberturas.PerformLayout();
            this.grpboxTipoPiso.ResumeLayout(false);
            this.grpboxTipoPiso.PerformLayout();
            this.grpboxDepto.ResumeLayout(false);
            this.grpboxDepto.PerformLayout();
            this.flpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtboxNroDepto;
        private System.Windows.Forms.Label lblNroDepto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpboxDepto;
        private System.Windows.Forms.RadioButton rbDeptoC;
        private System.Windows.Forms.RadioButton rbDeptoB;
        private System.Windows.Forms.RadioButton rbDeptoA;
        private System.Windows.Forms.GroupBox grpboxTipoPiso;
        private System.Windows.Forms.RadioButton rbFlotante;
        private System.Windows.Forms.RadioButton rbAlisado;
        private System.Windows.Forms.RadioButton rbPorcelanato;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grpboxAberturas;
        private System.Windows.Forms.RadioButton rbAluminio;
        private System.Windows.Forms.RadioButton rbMadera;
        private System.Windows.Forms.ComboBox cmbNroPiso;
        private System.Windows.Forms.Label lblNroPiso;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaP12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaP3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaP4;
        private System.Windows.Forms.TextBox txtboxMontoT;
        private System.Windows.Forms.Label lblMontoT;
        private System.Windows.Forms.GroupBox grpboxGastosP;
        private System.Windows.Forms.TextBox txtboxRecargo;
        private System.Windows.Forms.Label lblRecargoPiso;
        private System.Windows.Forms.TextBox txtboxRentas;
        private System.Windows.Forms.TextBox txtboxIVA;
        private System.Windows.Forms.TextBox txtboxEscritura;
        private System.Windows.Forms.Label lblRentas;
        private System.Windows.Forms.Label lblEscritura;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.FlowLayoutPanel flpPrincipal;
    }
}


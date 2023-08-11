﻿namespace Control_Ventas
{
    partial class FCOCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LBcantClientes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnImprimir = new FontAwesome.Sharp.IconButton();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.BtnUltimo = new FontAwesome.Sharp.IconButton();
            this.BtnSiguiente = new FontAwesome.Sharp.IconButton();
            this.BtnAnterior = new FontAwesome.Sharp.IconButton();
            this.BtnPrimero = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBusquedaCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDatos
            // 
            this.DGVDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDatos.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVDatos.Location = new System.Drawing.Point(0, 71);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDatos.Size = new System.Drawing.Size(948, 428);
            this.DGVDatos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Clientes";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscar.Location = new System.Drawing.Point(628, 29);
            this.tbBuscar.Multiline = true;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(253, 20);
            this.tbBuscar.TabIndex = 0;
            this.tbBuscar.TextChanged += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.BtnImprimir);
            this.panel3.Controls.Add(this.BtnSalir);
            this.panel3.Controls.Add(this.BtnUltimo);
            this.panel3.Controls.Add(this.BtnSiguiente);
            this.panel3.Controls.Add(this.BtnAnterior);
            this.panel3.Controls.Add(this.BtnPrimero);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 499);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 64);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.LBcantClientes);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(414, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 29);
            this.panel4.TabIndex = 8;
            // 
            // LBcantClientes
            // 
            this.LBcantClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBcantClientes.AutoSize = true;
            this.LBcantClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBcantClientes.ForeColor = System.Drawing.SystemColors.Window;
            this.LBcantClientes.Location = new System.Drawing.Point(169, 5);
            this.LBcantClientes.Name = "LBcantClientes";
            this.LBcantClientes.Size = new System.Drawing.Size(17, 18);
            this.LBcantClientes.TabIndex = 1;
            this.LBcantClientes.Text = "0";
            this.LBcantClientes.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de Clientes:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.cbBusquedaCliente);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.tbBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 71);
            this.panel2.TabIndex = 6;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImprimir.FlatAppearance.BorderSize = 0;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.Color.White;
            this.BtnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnImprimir.IconColor = System.Drawing.Color.White;
            this.BtnImprimir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnImprimir.IconSize = 24;
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.Location = new System.Drawing.Point(735, 24);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(118, 29);
            this.BtnImprimir.TabIndex = 7;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.BtnSalir.IconColor = System.Drawing.Color.White;
            this.BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnSalir.IconSize = 24;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(847, 24);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(77, 29);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnUltimo.FlatAppearance.BorderSize = 0;
            this.BtnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUltimo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUltimo.ForeColor = System.Drawing.Color.White;
            this.BtnUltimo.IconChar = FontAwesome.Sharp.IconChar.ForwardStep;
            this.BtnUltimo.IconColor = System.Drawing.Color.White;
            this.BtnUltimo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnUltimo.IconSize = 22;
            this.BtnUltimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUltimo.Location = new System.Drawing.Point(295, 24);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(86, 29);
            this.BtnUltimo.TabIndex = 5;
            this.BtnUltimo.Text = "Ultimo";
            this.BtnUltimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUltimo.UseVisualStyleBackColor = true;
            this.BtnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSiguiente.FlatAppearance.BorderSize = 0;
            this.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSiguiente.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguiente.ForeColor = System.Drawing.Color.White;
            this.BtnSiguiente.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.BtnSiguiente.IconColor = System.Drawing.Color.White;
            this.BtnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnSiguiente.IconSize = 24;
            this.BtnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSiguiente.Location = new System.Drawing.Point(196, 23);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(107, 29);
            this.BtnSiguiente.TabIndex = 4;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAnterior.FlatAppearance.BorderSize = 0;
            this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnterior.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnterior.ForeColor = System.Drawing.Color.White;
            this.BtnAnterior.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            this.BtnAnterior.IconColor = System.Drawing.Color.White;
            this.BtnAnterior.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnAnterior.IconSize = 22;
            this.BtnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnterior.Location = new System.Drawing.Point(5, 24);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(93, 29);
            this.BtnAnterior.TabIndex = 2;
            this.BtnAnterior.Text = "Primero";
            this.BtnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnPrimero
            // 
            this.BtnPrimero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnPrimero.FlatAppearance.BorderSize = 0;
            this.BtnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrimero.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrimero.ForeColor = System.Drawing.Color.White;
            this.BtnPrimero.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.BtnPrimero.IconColor = System.Drawing.Color.White;
            this.BtnPrimero.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnPrimero.IconSize = 24;
            this.BtnPrimero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrimero.Location = new System.Drawing.Point(92, 23);
            this.BtnPrimero.Name = "BtnPrimero";
            this.BtnPrimero.Size = new System.Drawing.Size(98, 29);
            this.BtnPrimero.TabIndex = 3;
            this.BtnPrimero.Text = "Anterior";
            this.BtnPrimero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrimero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrimero.UseVisualStyleBackColor = true;
            this.BtnPrimero.Click += new System.EventHandler(this.BtnPrimero_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 18;
            this.iconButton1.Location = new System.Drawing.Point(887, 26);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(37, 23);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(411, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Buscar por:";
            // 
            // cbBusquedaCliente
            // 
            this.cbBusquedaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBusquedaCliente.FormattingEnabled = true;
            this.cbBusquedaCliente.Location = new System.Drawing.Point(501, 28);
            this.cbBusquedaCliente.Name = "cbBusquedaCliente";
            this.cbBusquedaCliente.Size = new System.Drawing.Size(121, 21);
            this.cbBusquedaCliente.TabIndex = 4;
            // 
            // FCOCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 563);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FCOCliente";
            this.Text = "FCOCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FCOCliente_FormClosing);
            this.Load += new System.EventHandler(this.FCOCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox tbBuscar;
        private FontAwesome.Sharp.IconButton BtnImprimir;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LBcantClientes;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BtnUltimo;
        private FontAwesome.Sharp.IconButton BtnSiguiente;
        private FontAwesome.Sharp.IconButton BtnAnterior;
        private FontAwesome.Sharp.IconButton BtnPrimero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBusquedaCliente;
    }
}
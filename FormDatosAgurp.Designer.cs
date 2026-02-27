namespace Estadistica
{
    partial class FormDatosAgurp
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bttnAñade = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.chartResultA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bttnCV = new System.Windows.Forms.Button();
            this.bttnMedia = new System.Windows.Forms.Button();
            this.bttnDV = new System.Windows.Forms.Button();
            this.bttnModa = new System.Windows.Forms.Button();
            this.bttnMediana = new System.Windows.Forms.Button();
            this.bttnElimae = new System.Windows.Forms.Button();
            this.bttnCalcular = new System.Windows.Forms.Button();
            this.bttnNuevo = new System.Windows.Forms.Button();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblx = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.mscraX = new System.Windows.Forms.MaskedTextBox();
            this.mscraFre = new System.Windows.Forms.MaskedTextBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartResultA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnAñade
            // 
            this.bttnAñade.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bttnAñade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAñade.FlatAppearance.BorderSize = 0;
            this.bttnAñade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttnAñade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bttnAñade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAñade.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAñade.ForeColor = System.Drawing.Color.Black;
            this.bttnAñade.Location = new System.Drawing.Point(162, 104);
            this.bttnAñade.Name = "bttnAñade";
            this.bttnAñade.Size = new System.Drawing.Size(90, 45);
            this.bttnAñade.TabIndex = 1;
            this.bttnAñade.Text = "Añadir";
            this.bttnAñade.UseVisualStyleBackColor = false;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResultado.Location = new System.Drawing.Point(498, 24);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(133, 28);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Visible = false;
            // 
            // txtRes
            // 
            this.txtRes.BackColor = System.Drawing.Color.White;
            this.txtRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRes.Enabled = false;
            this.txtRes.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRes.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtRes.Location = new System.Drawing.Point(637, 24);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(147, 26);
            this.txtRes.TabIndex = 5;
            this.txtRes.Visible = false;
            // 
            // chartResultA
            // 
            this.chartResultA.BackColor = System.Drawing.Color.Transparent;
            this.chartResultA.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chartResultA.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartResultA.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartResultA.BorderSkin.PageColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chartResultA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResultA.Legends.Add(legend1);
            this.chartResultA.Location = new System.Drawing.Point(490, 84);
            this.chartResultA.Name = "chartResultA";
            this.chartResultA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chartResultA.Size = new System.Drawing.Size(438, 361);
            this.chartResultA.TabIndex = 6;
            this.chartResultA.Visible = false;
            // 
            // bttnCV
            // 
            this.bttnCV.BackColor = System.Drawing.Color.Transparent;
            this.bttnCV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bttnCV.FlatAppearance.BorderSize = 0;
            this.bttnCV.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bttnCV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttnCV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttnCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCV.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnCV.Location = new System.Drawing.Point(12, 345);
            this.bttnCV.Name = "bttnCV";
            this.bttnCV.Size = new System.Drawing.Size(104, 62);
            this.bttnCV.TabIndex = 16;
            this.bttnCV.Text = "CV";
            this.bttnCV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnCV.UseVisualStyleBackColor = false;
            this.bttnCV.Click += new System.EventHandler(this.bttnCV_Click);
            // 
            // bttnMedia
            // 
            this.bttnMedia.BackColor = System.Drawing.Color.Transparent;
            this.bttnMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnMedia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bttnMedia.FlatAppearance.BorderSize = 0;
            this.bttnMedia.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bttnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMedia.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMedia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnMedia.Location = new System.Drawing.Point(12, 12);
            this.bttnMedia.Name = "bttnMedia";
            this.bttnMedia.Size = new System.Drawing.Size(104, 62);
            this.bttnMedia.TabIndex = 12;
            this.bttnMedia.Tag = "bttnMedia";
            this.bttnMedia.Text = "Media";
            this.bttnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnMedia.UseVisualStyleBackColor = false;
            this.bttnMedia.Click += new System.EventHandler(this.bttnCV_Click);
            // 
            // bttnDV
            // 
            this.bttnDV.BackColor = System.Drawing.Color.Transparent;
            this.bttnDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnDV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bttnDV.FlatAppearance.BorderSize = 0;
            this.bttnDV.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bttnDV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttnDV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttnDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDV.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnDV.Location = new System.Drawing.Point(12, 264);
            this.bttnDV.Name = "bttnDV";
            this.bttnDV.Size = new System.Drawing.Size(104, 62);
            this.bttnDV.TabIndex = 15;
            this.bttnDV.Text = "DV";
            this.bttnDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnDV.UseVisualStyleBackColor = false;
            this.bttnDV.Click += new System.EventHandler(this.bttnCV_Click);
            // 
            // bttnModa
            // 
            this.bttnModa.BackColor = System.Drawing.Color.Transparent;
            this.bttnModa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnModa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bttnModa.FlatAppearance.BorderSize = 0;
            this.bttnModa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bttnModa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttnModa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttnModa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnModa.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnModa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnModa.Location = new System.Drawing.Point(12, 102);
            this.bttnModa.Name = "bttnModa";
            this.bttnModa.Size = new System.Drawing.Size(104, 62);
            this.bttnModa.TabIndex = 13;
            this.bttnModa.Text = "Moda";
            this.bttnModa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnModa.UseVisualStyleBackColor = false;
            this.bttnModa.Click += new System.EventHandler(this.bttnCV_Click);
            // 
            // bttnMediana
            // 
            this.bttnMediana.BackColor = System.Drawing.Color.Transparent;
            this.bttnMediana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnMediana.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bttnMediana.FlatAppearance.BorderSize = 0;
            this.bttnMediana.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bttnMediana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttnMediana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttnMediana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMediana.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMediana.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnMediana.Location = new System.Drawing.Point(12, 187);
            this.bttnMediana.Name = "bttnMediana";
            this.bttnMediana.Size = new System.Drawing.Size(104, 62);
            this.bttnMediana.TabIndex = 14;
            this.bttnMediana.Text = "Mediana";
            this.bttnMediana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnMediana.UseVisualStyleBackColor = false;
            this.bttnMediana.Click += new System.EventHandler(this.bttnCV_Click);
            // 
            // bttnElimae
            // 
            this.bttnElimae.BackColor = System.Drawing.Color.IndianRed;
            this.bttnElimae.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnElimae.FlatAppearance.BorderSize = 0;
            this.bttnElimae.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.bttnElimae.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.bttnElimae.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnElimae.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnElimae.ForeColor = System.Drawing.Color.Black;
            this.bttnElimae.Location = new System.Drawing.Point(258, 104);
            this.bttnElimae.Name = "bttnElimae";
            this.bttnElimae.Size = new System.Drawing.Size(90, 45);
            this.bttnElimae.TabIndex = 17;
            this.bttnElimae.Text = "Eliminar";
            this.bttnElimae.UseVisualStyleBackColor = false;
            this.bttnElimae.Visible = false;
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.BackColor = System.Drawing.Color.Orange;
            this.bttnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCalcular.FlatAppearance.BorderSize = 0;
            this.bttnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bttnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(189)))), ((int)(((byte)(90)))));
            this.bttnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCalcular.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCalcular.ForeColor = System.Drawing.Color.Black;
            this.bttnCalcular.Location = new System.Drawing.Point(354, 104);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(91, 45);
            this.bttnCalcular.TabIndex = 18;
            this.bttnCalcular.Text = "Calcular";
            this.bttnCalcular.UseVisualStyleBackColor = false;
            this.bttnCalcular.Visible = false;
            this.bttnCalcular.Click += new System.EventHandler(this.bttnCalcular_Click);
            // 
            // bttnNuevo
            // 
            this.bttnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(90)))));
            this.bttnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnNuevo.FlatAppearance.BorderSize = 0;
            this.bttnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bttnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNuevo.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNuevo.ForeColor = System.Drawing.Color.Black;
            this.bttnNuevo.Location = new System.Drawing.Point(838, 12);
            this.bttnNuevo.Name = "bttnNuevo";
            this.bttnNuevo.Size = new System.Drawing.Size(91, 45);
            this.bttnNuevo.TabIndex = 19;
            this.bttnNuevo.Text = "Nuevo";
            this.bttnNuevo.UseVisualStyleBackColor = false;
            this.bttnNuevo.Visible = false;
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
            this.dtgDatos.AllowUserToResizeColumns = false;
            this.dtgDatos.AllowUserToResizeRows = false;
            this.dtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDatos.EnableHeadersVisualStyles = false;
            this.dtgDatos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgDatos.Location = new System.Drawing.Point(162, 171);
            this.dtgDatos.MultiSelect = false;
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDatos.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatos.Size = new System.Drawing.Size(283, 288);
            this.dtgDatos.TabIndex = 5;
            this.dtgDatos.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "Frecuencia";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // lblx
            // 
            this.lblx.BackColor = System.Drawing.Color.Transparent;
            this.lblx.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx.ForeColor = System.Drawing.SystemColors.Control;
            this.lblx.Location = new System.Drawing.Point(161, 13);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(99, 28);
            this.lblx.TabIndex = 20;
            this.lblx.Text = "X:";
            // 
            // lblF
            // 
            this.lblF.BackColor = System.Drawing.Color.Transparent;
            this.lblF.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.ForeColor = System.Drawing.SystemColors.Control;
            this.lblF.Location = new System.Drawing.Point(311, 13);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(138, 28);
            this.lblF.TabIndex = 22;
            this.lblF.Text = "Frecuencia:";
            // 
            // mscraX
            // 
            this.mscraX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mscraX.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mscraX.HidePromptOnLeave = true;
            this.mscraX.Location = new System.Drawing.Point(166, 44);
            this.mscraX.Mask = "99999";
            this.mscraX.Name = "mscraX";
            this.mscraX.Size = new System.Drawing.Size(126, 30);
            this.mscraX.TabIndex = 24;
            this.mscraX.ValidatingType = typeof(int);
            this.mscraX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mscraFre_MouseClick);
            // 
            // mscraFre
            // 
            this.mscraFre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mscraFre.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mscraFre.HidePromptOnLeave = true;
            this.mscraFre.Location = new System.Drawing.Point(316, 44);
            this.mscraFre.Mask = "99999";
            this.mscraFre.Name = "mscraFre";
            this.mscraFre.Size = new System.Drawing.Size(129, 30);
            this.mscraFre.TabIndex = 25;
            this.mscraFre.ValidatingType = typeof(int);
            this.mscraFre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mscraFre_MouseClick);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // FormDatosAgurp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Estadistica.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 497);
            this.Controls.Add(this.mscraFre);
            this.Controls.Add(this.mscraX);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.bttnNuevo);
            this.Controls.Add(this.bttnCalcular);
            this.Controls.Add(this.bttnElimae);
            this.Controls.Add(this.bttnCV);
            this.Controls.Add(this.bttnMedia);
            this.Controls.Add(this.bttnDV);
            this.Controls.Add(this.bttnModa);
            this.Controls.Add(this.bttnMediana);
            this.Controls.Add(this.chartResultA);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.bttnAñade);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatosAgurp";
            this.Text = "FormDatosAgurp";
            ((System.ComponentModel.ISupportInitialize)(this.chartResultA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnAñade;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResultA;
        private System.Windows.Forms.Button bttnCV;
        private System.Windows.Forms.Button bttnMedia;
        private System.Windows.Forms.Button bttnDV;
        private System.Windows.Forms.Button bttnModa;
        private System.Windows.Forms.Button bttnMediana;
        private System.Windows.Forms.Button bttnElimae;
        private System.Windows.Forms.Button bttnCalcular;
        private System.Windows.Forms.Button bttnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.MaskedTextBox mscraX;
        private System.Windows.Forms.MaskedTextBox mscraFre;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.DataGridView dtgDatos;
    }
}
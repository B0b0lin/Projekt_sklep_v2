namespace Projekt_sklep_gui
{
    partial class StanKasy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.magazynTableAdapter = new Projekt_sklep_gui.MagazynDataSetTableAdapters.MagazynTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.KoniecDniaBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MagazynBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sprzedazBtn = new System.Windows.Forms.Button();
            this.magazynBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynDataSet = new Projekt_sklep_gui.MagazynDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UtargList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AllUtargList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UtargList)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllUtargList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Orange;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(322, 94);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1762, 48);
            this.panel5.TabIndex = 25;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(498, 34);
            this.label13.TabIndex = 9;
            this.label13.Text = "Stan kasy - sprawdz obecny stan kasy oraz utarg";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // magazynTableAdapter
            // 
            this.magazynTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1710, 94);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 50F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, -14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 118);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klub Gamingowy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.KoniecDniaBtn);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.MagazynBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.sprzedazBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 884);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitBtn.FlatAppearance.BorderSize = 3;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(47, 806);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(215, 42);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Zakończ pracę";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // KoniecDniaBtn
            // 
            this.KoniecDniaBtn.BackColor = System.Drawing.Color.White;
            this.KoniecDniaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.KoniecDniaBtn.FlatAppearance.BorderSize = 3;
            this.KoniecDniaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KoniecDniaBtn.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KoniecDniaBtn.ForeColor = System.Drawing.Color.Black;
            this.KoniecDniaBtn.Location = new System.Drawing.Point(47, 307);
            this.KoniecDniaBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.KoniecDniaBtn.Name = "KoniecDniaBtn";
            this.KoniecDniaBtn.Size = new System.Drawing.Size(215, 42);
            this.KoniecDniaBtn.TabIndex = 4;
            this.KoniecDniaBtn.Text = "Koniec Dnia";
            this.KoniecDniaBtn.UseVisualStyleBackColor = false;
            this.KoniecDniaBtn.Click += new System.EventHandler(this.KoniecDniaBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(47, 236);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Stan Kasy";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MagazynBtn
            // 
            this.MagazynBtn.BackColor = System.Drawing.Color.White;
            this.MagazynBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MagazynBtn.FlatAppearance.BorderSize = 3;
            this.MagazynBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MagazynBtn.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MagazynBtn.ForeColor = System.Drawing.Color.Black;
            this.MagazynBtn.Location = new System.Drawing.Point(47, 164);
            this.MagazynBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MagazynBtn.Name = "MagazynBtn";
            this.MagazynBtn.Size = new System.Drawing.Size(215, 42);
            this.MagazynBtn.TabIndex = 3;
            this.MagazynBtn.Text = "Magazyn";
            this.MagazynBtn.UseVisualStyleBackColor = false;
            this.MagazynBtn.Click += new System.EventHandler(this.MagazynBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista akcji";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sprzedazBtn
            // 
            this.sprzedazBtn.BackColor = System.Drawing.Color.White;
            this.sprzedazBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sprzedazBtn.FlatAppearance.BorderSize = 3;
            this.sprzedazBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sprzedazBtn.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sprzedazBtn.ForeColor = System.Drawing.Color.Black;
            this.sprzedazBtn.Location = new System.Drawing.Point(47, 93);
            this.sprzedazBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sprzedazBtn.Name = "sprzedazBtn";
            this.sprzedazBtn.Size = new System.Drawing.Size(215, 42);
            this.sprzedazBtn.TabIndex = 2;
            this.sprzedazBtn.Text = "Sprzedaż";
            this.sprzedazBtn.UseVisualStyleBackColor = false;
            this.sprzedazBtn.Click += new System.EventHandler(this.sprzedazBtn_Click);
            // 
            // magazynBindingSource
            // 
            this.magazynBindingSource.DataMember = "Magazyn";
            this.magazynBindingSource.DataSource = this.magazynDataSet;
            this.magazynBindingSource.CurrentChanged += new System.EventHandler(this.magazynBindingSource_CurrentChanged);
            // 
            // magazynDataSet
            // 
            this.magazynDataSet.DataSetName = "MagazynDataSet";
            this.magazynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.UtargList);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(322, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(708, 836);
            this.panel3.TabIndex = 26;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // UtargList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.UtargList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UtargList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UtargList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UtargList.ColumnHeadersHeight = 25;
            this.UtargList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UtargList.DefaultCellStyle = dataGridViewCellStyle3;
            this.UtargList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.UtargList.Location = new System.Drawing.Point(12, 44);
            this.UtargList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UtargList.Name = "UtargList";
            this.UtargList.ReadOnly = true;
            this.UtargList.RowHeadersVisible = false;
            this.UtargList.RowHeadersWidth = 51;
            this.UtargList.RowTemplate.Height = 24;
            this.UtargList.Size = new System.Drawing.Size(664, 755);
            this.UtargList.StandardTab = true;
            this.UtargList.TabIndex = 18;
            this.UtargList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange;
            this.UtargList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.UtargList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UtargList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UtargList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UtargList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UtargList.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UtargList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.UtargList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.UtargList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UtargList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UtargList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.UtargList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UtargList.ThemeStyle.HeaderStyle.Height = 25;
            this.UtargList.ThemeStyle.ReadOnly = true;
            this.UtargList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            this.UtargList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UtargList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UtargList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.UtargList.ThemeStyle.RowsStyle.Height = 24;
            this.UtargList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.UtargList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.UtargList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UtargList_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Utarg - Dzisiaj";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.AllUtargList);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(1030, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(708, 836);
            this.panel4.TabIndex = 27;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // AllUtargList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.AllUtargList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AllUtargList.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllUtargList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AllUtargList.ColumnHeadersHeight = 25;
            this.AllUtargList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllUtargList.DefaultCellStyle = dataGridViewCellStyle6;
            this.AllUtargList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.AllUtargList.Location = new System.Drawing.Point(12, 44);
            this.AllUtargList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AllUtargList.Name = "AllUtargList";
            this.AllUtargList.ReadOnly = true;
            this.AllUtargList.RowHeadersVisible = false;
            this.AllUtargList.RowHeadersWidth = 51;
            this.AllUtargList.RowTemplate.Height = 24;
            this.AllUtargList.Size = new System.Drawing.Size(636, 755);
            this.AllUtargList.StandardTab = true;
            this.AllUtargList.TabIndex = 19;
            this.AllUtargList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange;
            this.AllUtargList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.AllUtargList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AllUtargList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AllUtargList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AllUtargList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AllUtargList.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.AllUtargList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.AllUtargList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.AllUtargList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AllUtargList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AllUtargList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.AllUtargList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AllUtargList.ThemeStyle.HeaderStyle.Height = 25;
            this.AllUtargList.ThemeStyle.ReadOnly = true;
            this.AllUtargList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            this.AllUtargList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AllUtargList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AllUtargList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AllUtargList.ThemeStyle.RowsStyle.Height = 24;
            this.AllUtargList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.AllUtargList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.AllUtargList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllUtargList_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ogólna ilość zarobionych pieniędzy";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // StanKasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 978);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StanKasy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StanKasy";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UtargList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllUtargList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private MagazynDataSetTableAdapters.MagazynTableAdapter magazynTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button KoniecDniaBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button MagazynBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sprzedazBtn;
        private System.Windows.Forms.BindingSource magazynBindingSource;
        private MagazynDataSet magazynDataSet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView UtargList;
        private Guna.UI2.WinForms.Guna2DataGridView AllUtargList;
    }
}
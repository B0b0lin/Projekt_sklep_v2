namespace Projekt_sklep_gui
{
    partial class Magazyn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.KoniecDniaBtn = new System.Windows.Forms.Button();
            this.StanKasyBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sprzedazBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nazwaDodawanieStanu = new System.Windows.Forms.ComboBox();
            this.magazynBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynDataSet = new Projekt_sklep_gui.MagazynDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.IloscDodawanieStanu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DodajStanBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newPriceNettoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.newQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.MagazynList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.UsunNazwa = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.usunBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nazwaEdytowanie = new System.Windows.Forms.ComboBox();
            this.kategoriaEdycja = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CenaEdycja = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.iloscEdycja = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.EdytowanieBtn = new System.Windows.Forms.Button();
            this.magazynTableAdapter = new Projekt_sklep_gui.MagazynDataSetTableAdapters.MagazynTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MagazynList)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 50F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(301, -14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 118);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klub Gamingowy";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.KoniecDniaBtn);
            this.panel2.Controls.Add(this.StanKasyBtn);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.sprzedazBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 884);
            this.panel2.TabIndex = 1;
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
            // StanKasyBtn
            // 
            this.StanKasyBtn.BackColor = System.Drawing.Color.White;
            this.StanKasyBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StanKasyBtn.FlatAppearance.BorderSize = 3;
            this.StanKasyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StanKasyBtn.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StanKasyBtn.ForeColor = System.Drawing.Color.Black;
            this.StanKasyBtn.Location = new System.Drawing.Point(47, 236);
            this.StanKasyBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StanKasyBtn.Name = "StanKasyBtn";
            this.StanKasyBtn.Size = new System.Drawing.Size(215, 42);
            this.StanKasyBtn.TabIndex = 3;
            this.StanKasyBtn.Text = "Stan Kasy";
            this.StanKasyBtn.UseVisualStyleBackColor = false;
            this.StanKasyBtn.Click += new System.EventHandler(this.StanKasyBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(47, 164);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Magazyn";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(35, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista akcji";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1218, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aktualne stany magazynowe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dodaj stan do istniejącego produktu";
            // 
            // nazwaDodawanieStanu
            // 
            this.nazwaDodawanieStanu.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaDodawanieStanu.FormattingEnabled = true;
            this.nazwaDodawanieStanu.Location = new System.Drawing.Point(24, 87);
            this.nazwaDodawanieStanu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nazwaDodawanieStanu.Name = "nazwaDodawanieStanu";
            this.nazwaDodawanieStanu.Size = new System.Drawing.Size(377, 36);
            this.nazwaDodawanieStanu.TabIndex = 5;
            // 
            // magazynBindingSource
            // 
            this.magazynBindingSource.DataMember = "Magazyn";
            this.magazynBindingSource.DataSource = this.magazynDataSet;
            // 
            // magazynDataSet
            // 
            this.magazynDataSet.DataSetName = "MagazynDataSet";
            this.magazynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nazwa produktu";
            // 
            // IloscDodawanieStanu
            // 
            this.IloscDodawanieStanu.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IloscDodawanieStanu.Location = new System.Drawing.Point(24, 187);
            this.IloscDodawanieStanu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IloscDodawanieStanu.Name = "IloscDodawanieStanu";
            this.IloscDodawanieStanu.Size = new System.Drawing.Size(377, 28);
            this.IloscDodawanieStanu.TabIndex = 7;
            this.IloscDodawanieStanu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dodawana ilość";
            // 
            // DodajStanBtn
            // 
            this.DodajStanBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.DodajStanBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DodajStanBtn.FlatAppearance.BorderSize = 3;
            this.DodajStanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DodajStanBtn.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajStanBtn.ForeColor = System.Drawing.Color.Black;
            this.DodajStanBtn.Location = new System.Drawing.Point(104, 249);
            this.DodajStanBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DodajStanBtn.Name = "DodajStanBtn";
            this.DodajStanBtn.Size = new System.Drawing.Size(215, 42);
            this.DodajStanBtn.TabIndex = 6;
            this.DodajStanBtn.Text = "Dodaj stan";
            this.DodajStanBtn.UseVisualStyleBackColor = false;
            this.DodajStanBtn.Click += new System.EventHandler(this.DodajStanBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.nazwaDodawanieStanu);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.IloscDodawanieStanu);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.DodajStanBtn);
            this.panel3.Location = new System.Drawing.Point(322, 142);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 316);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.categoryCombo);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.newPriceNettoTextBox);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.newProductNameTextBox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.newQuantityTextBox);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.addBtn);
            this.panel4.Location = new System.Drawing.Point(322, 458);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(432, 524);
            this.panel4.TabIndex = 14;
            // 
            // categoryCombo
            // 
            this.categoryCombo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Items.AddRange(new object[] {
            "Napoje",
            "Akcesoria",
            "Usluga"});
            this.categoryCombo.Location = new System.Drawing.Point(24, 192);
            this.categoryCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(377, 36);
            this.categoryCombo.TabIndex = 9;
            this.categoryCombo.SelectedIndexChanged += new System.EventHandler(this.categoryCombo_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(19, 155);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "Kategoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 307);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 12;
            // 
            // newPriceNettoTextBox
            // 
            this.newPriceNettoTextBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newPriceNettoTextBox.ForeColor = System.Drawing.Color.Black;
            this.newPriceNettoTextBox.Location = new System.Drawing.Point(26, 390);
            this.newPriceNettoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newPriceNettoTextBox.Name = "newPriceNettoTextBox";
            this.newPriceNettoTextBox.Size = new System.Drawing.Size(377, 28);
            this.newPriceNettoTextBox.TabIndex = 11;
            this.newPriceNettoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnlyForPrice);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cena Netto produktu ";
            // 
            // newProductNameTextBox
            // 
            this.newProductNameTextBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newProductNameTextBox.Location = new System.Drawing.Point(26, 105);
            this.newProductNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newProductNameTextBox.Name = "newProductNameTextBox";
            this.newProductNameTextBox.Size = new System.Drawing.Size(377, 28);
            this.newProductNameTextBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(284, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Dodaj nowy produkt do magazynu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(20, 68);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nazwa nowego produktu";
            // 
            // newQuantityTextBox
            // 
            this.newQuantityTextBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newQuantityTextBox.Location = new System.Drawing.Point(26, 296);
            this.newQuantityTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newQuantityTextBox.Name = "newQuantityTextBox";
            this.newQuantityTextBox.Size = new System.Drawing.Size(377, 28);
            this.newQuantityTextBox.TabIndex = 7;
            this.newQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(20, 259);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Deklarowana ilość";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addBtn.FlatAppearance.BorderSize = 3;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(105, 441);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(215, 42);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Dodaj Produkt";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Orange;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(322, 94);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1762, 48);
            this.panel5.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(264, 34);
            this.label13.TabIndex = 9;
            this.label13.Text = "Zarządzanie magazynem";
            // 
            // MagazynList
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.MagazynList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MagazynList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.MagazynList.ColumnHeadersHeight = 25;
            this.MagazynList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MagazynList.DefaultCellStyle = dataGridViewCellStyle12;
            this.MagazynList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.MagazynList.Location = new System.Drawing.Point(1223, 187);
            this.MagazynList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MagazynList.Name = "MagazynList";
            this.MagazynList.ReadOnly = true;
            this.MagazynList.RowHeadersVisible = false;
            this.MagazynList.RowHeadersWidth = 51;
            this.MagazynList.RowTemplate.Height = 24;
            this.MagazynList.Size = new System.Drawing.Size(444, 771);
            this.MagazynList.StandardTab = true;
            this.MagazynList.TabIndex = 17;
            this.MagazynList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange;
            this.MagazynList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.MagazynList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MagazynList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MagazynList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MagazynList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MagazynList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MagazynList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.MagazynList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.MagazynList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MagazynList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MagazynList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.MagazynList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MagazynList.ThemeStyle.HeaderStyle.Height = 25;
            this.MagazynList.ThemeStyle.ReadOnly = true;
            this.MagazynList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            this.MagazynList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MagazynList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MagazynList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MagazynList.ThemeStyle.RowsStyle.Height = 24;
            this.MagazynList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.MagazynList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.UsunNazwa);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.usunBtn);
            this.panel6.Location = new System.Drawing.Point(754, 142);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(432, 238);
            this.panel6.TabIndex = 14;
            // 
            // UsunNazwa
            // 
            this.UsunNazwa.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsunNazwa.FormattingEnabled = true;
            this.UsunNazwa.Location = new System.Drawing.Point(25, 86);
            this.UsunNazwa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsunNazwa.Name = "UsunNazwa";
            this.UsunNazwa.Size = new System.Drawing.Size(377, 36);
            this.UsunNazwa.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(20, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "Usuń produkt";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(20, 49);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 25);
            this.label15.TabIndex = 6;
            this.label15.Text = "Nazwa produktu";
            // 
            // usunBtn
            // 
            this.usunBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.usunBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.usunBtn.FlatAppearance.BorderSize = 3;
            this.usunBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usunBtn.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunBtn.ForeColor = System.Drawing.Color.Black;
            this.usunBtn.Location = new System.Drawing.Point(105, 162);
            this.usunBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usunBtn.Name = "usunBtn";
            this.usunBtn.Size = new System.Drawing.Size(215, 42);
            this.usunBtn.TabIndex = 6;
            this.usunBtn.Text = "Usuń";
            this.usunBtn.UseVisualStyleBackColor = false;
            this.usunBtn.Click += new System.EventHandler(this.usunBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.nazwaEdytowanie);
            this.panel7.Controls.Add(this.kategoriaEdycja);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.CenaEdycja);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.iloscEdycja);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Controls.Add(this.EdytowanieBtn);
            this.panel7.Location = new System.Drawing.Point(754, 380);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(432, 602);
            this.panel7.TabIndex = 15;
            // 
            // nazwaEdytowanie
            // 
            this.nazwaEdytowanie.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaEdytowanie.FormattingEnabled = true;
            this.nazwaEdytowanie.Location = new System.Drawing.Point(25, 105);
            this.nazwaEdytowanie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nazwaEdytowanie.Name = "nazwaEdytowanie";
            this.nazwaEdytowanie.Size = new System.Drawing.Size(377, 36);
            this.nazwaEdytowanie.TabIndex = 9;
            this.nazwaEdytowanie.TextChanged += new System.EventHandler(this.nazwaEdytowanie_TextChanged);
            // 
            // kategoriaEdycja
            // 
            this.kategoriaEdycja.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kategoriaEdycja.FormattingEnabled = true;
            this.kategoriaEdycja.Items.AddRange(new object[] {
            "Napoje",
            "Akcesoria"});
            this.kategoriaEdycja.Location = new System.Drawing.Point(27, 223);
            this.kategoriaEdycja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kategoriaEdycja.Name = "kategoriaEdycja";
            this.kategoriaEdycja.Size = new System.Drawing.Size(377, 36);
            this.kategoriaEdycja.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(20, 186);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 25);
            this.label17.TabIndex = 13;
            this.label17.Text = "Nowa Kategoria";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(33, 307);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 25);
            this.label18.TabIndex = 12;
            // 
            // CenaEdycja
            // 
            this.CenaEdycja.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CenaEdycja.ForeColor = System.Drawing.Color.Black;
            this.CenaEdycja.Location = new System.Drawing.Point(27, 414);
            this.CenaEdycja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CenaEdycja.Name = "CenaEdycja";
            this.CenaEdycja.Size = new System.Drawing.Size(377, 28);
            this.CenaEdycja.TabIndex = 11;
            this.CenaEdycja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnlyForPrice);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(21, 377);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 25);
            this.label19.TabIndex = 10;
            this.label19.Text = "Nowa Cena netto";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(20, 19);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 25);
            this.label20.TabIndex = 4;
            this.label20.Text = "Edytuj Produkt";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(20, 68);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(190, 25);
            this.label21.TabIndex = 6;
            this.label21.Text = "Wybierz produkt do edycji";
            // 
            // iloscEdycja
            // 
            this.iloscEdycja.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscEdycja.Location = new System.Drawing.Point(27, 320);
            this.iloscEdycja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iloscEdycja.Name = "iloscEdycja";
            this.iloscEdycja.Size = new System.Drawing.Size(377, 28);
            this.iloscEdycja.TabIndex = 7;
            this.iloscEdycja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(21, 283);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(183, 25);
            this.label22.TabIndex = 8;
            this.label22.Text = "Nowa Ilość magazynowa";
            // 
            // EdytowanieBtn
            // 
            this.EdytowanieBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.EdytowanieBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EdytowanieBtn.FlatAppearance.BorderSize = 3;
            this.EdytowanieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EdytowanieBtn.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdytowanieBtn.ForeColor = System.Drawing.Color.Black;
            this.EdytowanieBtn.Location = new System.Drawing.Point(105, 489);
            this.EdytowanieBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EdytowanieBtn.Name = "EdytowanieBtn";
            this.EdytowanieBtn.Size = new System.Drawing.Size(215, 42);
            this.EdytowanieBtn.TabIndex = 6;
            this.EdytowanieBtn.Text = "Uaktualnij produkt";
            this.EdytowanieBtn.UseVisualStyleBackColor = false;
            this.EdytowanieBtn.Click += new System.EventHandler(this.EdytowanieBtn_Click);
            // 
            // magazynTableAdapter
            // 
            this.magazynTableAdapter.ClearBeforeFill = true;
            // 
            // Magazyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 978);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.MagazynList);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Magazyn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Magazyn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MagazynList)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sprzedazBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button KoniecDniaBtn;
        private System.Windows.Forms.Button StanKasyBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox nazwaDodawanieStanu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IloscDodawanieStanu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DodajStanBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox newQuantityTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox newProductNameTextBox;
        private System.Windows.Forms.TextBox newPriceNettoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2DataGridView MagazynList;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button usunBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox kategoriaEdycja;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox CenaEdycja;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox iloscEdycja;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button EdytowanieBtn;
        private MagazynDataSet magazynDataSet;
        private System.Windows.Forms.BindingSource magazynBindingSource;
        private MagazynDataSetTableAdapters.MagazynTableAdapter magazynTableAdapter;
        private System.Windows.Forms.ComboBox nazwaEdytowanie;
        private System.Windows.Forms.ComboBox UsunNazwa;
    }
}
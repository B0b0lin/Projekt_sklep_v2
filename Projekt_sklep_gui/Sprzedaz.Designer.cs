namespace Projekt_sklep_gui
{
    partial class Sprzedaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sprzedaz));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.magazynTableAdapter = new Projekt_sklep_gui.MagazynDataSetTableAdapters.MagazynTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.magazynBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynDataSet = new Projekt_sklep_gui.MagazynDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.KoniecDniaBtn = new System.Windows.Forms.Button();
            this.StanKasyBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sprzedazBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UsunBtn = new System.Windows.Forms.Button();
            this.zmienBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.UsunKoszykKombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ZmienKoszukCombo = new System.Windows.Forms.ComboBox();
            this.iloscZmien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.anulacja_btn = new System.Windows.Forms.Button();
            this.Zaplata_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sumaKoszyk = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.KoszykGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.wejsciaGryBtn = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NapojeBTN = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AkcesoriaBTN = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.itemsGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DodajDoKoszykaBTN = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sprzedajComboBox = new System.Windows.Forms.ComboBox();
            this.iloscSprzedaj = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoszykGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wejsciaGryBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NapojeBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AkcesoriaBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Orange;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(322, 94);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1135, 48);
            this.panel5.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(315, 34);
            this.label13.TabIndex = 9;
            this.label13.Text = "Sprzedarz przedmiotów i usług";
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
            this.panel2.TabIndex = 26;
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
            this.button2.BackColor = System.Drawing.Color.White;
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // 
            // sprzedazBtn
            // 
            this.sprzedazBtn.BackColor = System.Drawing.Color.Orange;
            this.sprzedazBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sprzedazBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
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
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Chocolate;
            this.panel3.Controls.Add(this.UsunBtn);
            this.panel3.Controls.Add(this.zmienBtn);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.UsunKoszykKombo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.ZmienKoszukCombo);
            this.panel3.Controls.Add(this.iloscZmien);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.anulacja_btn);
            this.panel3.Controls.Add(this.Zaplata_btn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1433, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 884);
            this.panel3.TabIndex = 27;
            // 
            // UsunBtn
            // 
            this.UsunBtn.BackColor = System.Drawing.Color.White;
            this.UsunBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UsunBtn.FlatAppearance.BorderSize = 3;
            this.UsunBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UsunBtn.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsunBtn.ForeColor = System.Drawing.Color.Black;
            this.UsunBtn.Location = new System.Drawing.Point(38, 824);
            this.UsunBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsunBtn.Name = "UsunBtn";
            this.UsunBtn.Size = new System.Drawing.Size(215, 42);
            this.UsunBtn.TabIndex = 39;
            this.UsunBtn.Text = "Usuń";
            this.UsunBtn.UseVisualStyleBackColor = false;
            this.UsunBtn.Click += new System.EventHandler(this.UsunBtn_Click);
            // 
            // zmienBtn
            // 
            this.zmienBtn.BackColor = System.Drawing.Color.White;
            this.zmienBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zmienBtn.FlatAppearance.BorderSize = 3;
            this.zmienBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zmienBtn.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zmienBtn.ForeColor = System.Drawing.Color.Black;
            this.zmienBtn.Location = new System.Drawing.Point(38, 672);
            this.zmienBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zmienBtn.Name = "zmienBtn";
            this.zmienBtn.Size = new System.Drawing.Size(215, 42);
            this.zmienBtn.TabIndex = 38;
            this.zmienBtn.Text = "Zmień";
            this.zmienBtn.UseVisualStyleBackColor = false;
            this.zmienBtn.Click += new System.EventHandler(this.zmienBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 539);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 28);
            this.label7.TabIndex = 37;
            this.label7.Text = "Wybierz produkt do zmiany";
            // 
            // UsunKoszykKombo
            // 
            this.UsunKoszykKombo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsunKoszykKombo.FormattingEnabled = true;
            this.UsunKoszykKombo.Location = new System.Drawing.Point(49, 782);
            this.UsunKoszykKombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsunKoszykKombo.Name = "UsunKoszykKombo";
            this.UsunKoszykKombo.Size = new System.Drawing.Size(190, 36);
            this.UsunKoszykKombo.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 745);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 34);
            this.label6.TabIndex = 35;
            this.label6.Text = "Usuń Produkt z koszyka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 607);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 28);
            this.label5.TabIndex = 34;
            this.label5.Text = "Podaj nową ilość produktu";
            // 
            // ZmienKoszukCombo
            // 
            this.ZmienKoszukCombo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZmienKoszukCombo.FormattingEnabled = true;
            this.ZmienKoszukCombo.Location = new System.Drawing.Point(49, 570);
            this.ZmienKoszukCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ZmienKoszukCombo.Name = "ZmienKoszukCombo";
            this.ZmienKoszukCombo.Size = new System.Drawing.Size(190, 36);
            this.ZmienKoszukCombo.TabIndex = 32;
            this.ZmienKoszukCombo.TextChanged += new System.EventHandler(this.ZmienKoszukCombo_TextChanged);
            // 
            // iloscZmien
            // 
            this.iloscZmien.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscZmien.Location = new System.Drawing.Point(49, 638);
            this.iloscZmien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iloscZmien.Name = "iloscZmien";
            this.iloscZmien.Size = new System.Drawing.Size(190, 28);
            this.iloscZmien.TabIndex = 33;
            this.iloscZmien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 503);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 37);
            this.label4.TabIndex = 31;
            this.label4.Text = "Zmień ilość produktu";
            // 
            // anulacja_btn
            // 
            this.anulacja_btn.BackColor = System.Drawing.Color.White;
            this.anulacja_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.anulacja_btn.FlatAppearance.BorderSize = 3;
            this.anulacja_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.anulacja_btn.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.anulacja_btn.ForeColor = System.Drawing.Color.Black;
            this.anulacja_btn.Location = new System.Drawing.Point(30, 447);
            this.anulacja_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.anulacja_btn.Name = "anulacja_btn";
            this.anulacja_btn.Size = new System.Drawing.Size(215, 42);
            this.anulacja_btn.TabIndex = 30;
            this.anulacja_btn.Text = "Anuluj zakupy";
            this.anulacja_btn.UseVisualStyleBackColor = false;
            this.anulacja_btn.Click += new System.EventHandler(this.anulacja_btn_Click);
            // 
            // Zaplata_btn
            // 
            this.Zaplata_btn.BackColor = System.Drawing.Color.White;
            this.Zaplata_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Zaplata_btn.FlatAppearance.BorderSize = 3;
            this.Zaplata_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Zaplata_btn.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zaplata_btn.ForeColor = System.Drawing.Color.Black;
            this.Zaplata_btn.Location = new System.Drawing.Point(30, 399);
            this.Zaplata_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Zaplata_btn.Name = "Zaplata_btn";
            this.Zaplata_btn.Size = new System.Drawing.Size(215, 42);
            this.Zaplata_btn.TabIndex = 29;
            this.Zaplata_btn.Text = "Zapłata";
            this.Zaplata_btn.UseVisualStyleBackColor = false;
            this.Zaplata_btn.Click += new System.EventHandler(this.Zaplata_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, -4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Koszyk";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.sumaKoszyk);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.KoszykGridView);
            this.panel4.Location = new System.Drawing.Point(3, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 334);
            this.panel4.TabIndex = 28;
            // 
            // sumaKoszyk
            // 
            this.sumaKoszyk.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sumaKoszyk.Location = new System.Drawing.Point(90, 293);
            this.sumaKoszyk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sumaKoszyk.Name = "sumaKoszyk";
            this.sumaKoszyk.ReadOnly = true;
            this.sumaKoszyk.Size = new System.Drawing.Size(169, 28);
            this.sumaKoszyk.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(10, 290);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 34);
            this.label15.TabIndex = 40;
            this.label15.Text = "Suma:";
            // 
            // KoszykGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.KoszykGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KoszykGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.KoszykGridView.ColumnHeadersHeight = 25;
            this.KoszykGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KoszykGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.KoszykGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.KoszykGridView.Location = new System.Drawing.Point(14, 15);
            this.KoszykGridView.Margin = new System.Windows.Forms.Padding(25);
            this.KoszykGridView.Name = "KoszykGridView";
            this.KoszykGridView.ReadOnly = true;
            this.KoszykGridView.RowHeadersVisible = false;
            this.KoszykGridView.RowTemplate.Height = 24;
            this.KoszykGridView.Size = new System.Drawing.Size(248, 263);
            this.KoszykGridView.TabIndex = 0;
            this.KoszykGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange;
            this.KoszykGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.KoszykGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.KoszykGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.KoszykGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.KoszykGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.KoszykGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.KoszykGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.KoszykGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.KoszykGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.KoszykGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KoszykGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.KoszykGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.KoszykGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.KoszykGridView.ThemeStyle.ReadOnly = true;
            this.KoszykGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            this.KoszykGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.KoszykGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KoszykGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.KoszykGridView.ThemeStyle.RowsStyle.Height = 24;
            this.KoszykGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.KoszykGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // wejsciaGryBtn
            // 
            this.wejsciaGryBtn.BackColor = System.Drawing.Color.Transparent;
            this.wejsciaGryBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wejsciaGryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wejsciaGryBtn.Image = ((System.Drawing.Image)(resources.GetObject("wejsciaGryBtn.Image")));
            this.wejsciaGryBtn.Location = new System.Drawing.Point(384, 208);
            this.wejsciaGryBtn.Name = "wejsciaGryBtn";
            this.wejsciaGryBtn.Size = new System.Drawing.Size(142, 130);
            this.wejsciaGryBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wejsciaGryBtn.TabIndex = 28;
            this.wejsciaGryBtn.TabStop = false;
            this.wejsciaGryBtn.Click += new System.EventHandler(this.wejsciaGryBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(360, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 48);
            this.label8.TabIndex = 6;
            this.label8.Text = "Wejścia Gry";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(780, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 48);
            this.label9.TabIndex = 29;
            this.label9.Text = "Napoje";
            // 
            // NapojeBTN
            // 
            this.NapojeBTN.BackColor = System.Drawing.Color.Transparent;
            this.NapojeBTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NapojeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NapojeBTN.Image = ((System.Drawing.Image)(resources.GetObject("NapojeBTN.Image")));
            this.NapojeBTN.Location = new System.Drawing.Point(771, 208);
            this.NapojeBTN.Name = "NapojeBTN";
            this.NapojeBTN.Size = new System.Drawing.Size(142, 130);
            this.NapojeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NapojeBTN.TabIndex = 30;
            this.NapojeBTN.TabStop = false;
            this.NapojeBTN.Click += new System.EventHandler(this.NapojeBTN_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1149, 157);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 48);
            this.label10.TabIndex = 31;
            this.label10.Text = "Akcesoria";
            // 
            // AkcesoriaBTN
            // 
            this.AkcesoriaBTN.BackColor = System.Drawing.Color.Transparent;
            this.AkcesoriaBTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AkcesoriaBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AkcesoriaBTN.Image = ((System.Drawing.Image)(resources.GetObject("AkcesoriaBTN.Image")));
            this.AkcesoriaBTN.Location = new System.Drawing.Point(1157, 208);
            this.AkcesoriaBTN.Name = "AkcesoriaBTN";
            this.AkcesoriaBTN.Size = new System.Drawing.Size(142, 130);
            this.AkcesoriaBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AkcesoriaBTN.TabIndex = 32;
            this.AkcesoriaBTN.TabStop = false;
            this.AkcesoriaBTN.Click += new System.EventHandler(this.AkcesoriaBTN_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Orange;
            this.panel6.Location = new System.Drawing.Point(322, 370);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1135, 18);
            this.panel6.TabIndex = 26;
            // 
            // itemsGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.itemsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.itemsGridView.ColumnHeadersHeight = 25;
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.itemsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.itemsGridView.Location = new System.Drawing.Point(29, 25);
            this.itemsGridView.Margin = new System.Windows.Forms.Padding(25);
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.ReadOnly = true;
            this.itemsGridView.RowHeadersVisible = false;
            this.itemsGridView.RowTemplate.Height = 24;
            this.itemsGridView.Size = new System.Drawing.Size(551, 518);
            this.itemsGridView.TabIndex = 33;
            this.itemsGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange;
            this.itemsGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.itemsGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.itemsGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.itemsGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.itemsGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.itemsGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.itemsGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.itemsGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.itemsGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.itemsGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.itemsGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.itemsGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.itemsGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.itemsGridView.ThemeStyle.ReadOnly = true;
            this.itemsGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            this.itemsGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.itemsGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.itemsGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.itemsGridView.ThemeStyle.RowsStyle.Height = 24;
            this.itemsGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.itemsGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.DodajDoKoszykaBTN);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.sprzedajComboBox);
            this.panel7.Controls.Add(this.iloscSprzedaj);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.itemsGridView);
            this.panel7.Location = new System.Drawing.Point(322, 388);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1111, 590);
            this.panel7.TabIndex = 34;
            // 
            // DodajDoKoszykaBTN
            // 
            this.DodajDoKoszykaBTN.BackColor = System.Drawing.Color.White;
            this.DodajDoKoszykaBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DodajDoKoszykaBTN.FlatAppearance.BorderSize = 3;
            this.DodajDoKoszykaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DodajDoKoszykaBTN.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajDoKoszykaBTN.ForeColor = System.Drawing.Color.Black;
            this.DodajDoKoszykaBTN.Location = new System.Drawing.Point(746, 238);
            this.DodajDoKoszykaBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DodajDoKoszykaBTN.Name = "DodajDoKoszykaBTN";
            this.DodajDoKoszykaBTN.Size = new System.Drawing.Size(215, 42);
            this.DodajDoKoszykaBTN.TabIndex = 44;
            this.DodajDoKoszykaBTN.Text = "Dodaj do koszyka";
            this.DodajDoKoszykaBTN.UseVisualStyleBackColor = false;
            this.DodajDoKoszykaBTN.Click += new System.EventHandler(this.DodajDoKoszykaBTN_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(721, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(256, 28);
            this.label11.TabIndex = 43;
            this.label11.Text = "Wybierz produkt do sprzedarzy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(702, 160);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(306, 28);
            this.label12.TabIndex = 42;
            this.label12.Text = "Podaj ilość sprzedawanego produktu";
            // 
            // sprzedajComboBox
            // 
            this.sprzedajComboBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sprzedajComboBox.FormattingEnabled = true;
            this.sprzedajComboBox.Location = new System.Drawing.Point(755, 112);
            this.sprzedajComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sprzedajComboBox.Name = "sprzedajComboBox";
            this.sprzedajComboBox.Size = new System.Drawing.Size(190, 36);
            this.sprzedajComboBox.TabIndex = 40;
            // 
            // iloscSprzedaj
            // 
            this.iloscSprzedaj.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscSprzedaj.Location = new System.Drawing.Point(757, 191);
            this.iloscSprzedaj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iloscSprzedaj.Name = "iloscSprzedaj";
            this.iloscSprzedaj.Size = new System.Drawing.Size(190, 28);
            this.iloscSprzedaj.TabIndex = 41;
            this.iloscSprzedaj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(748, 35);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(213, 37);
            this.label14.TabIndex = 39;
            this.label14.Text = "Sprzedaj produkt";
            // 
            // Sprzedaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1710, 978);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AkcesoriaBTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NapojeBTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wejsciaGryBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sprzedaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprzedaz";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KoszykGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wejsciaGryBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NapojeBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AkcesoriaBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private MagazynDataSetTableAdapters.MagazynTableAdapter magazynTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource magazynBindingSource;
        private MagazynDataSet magazynDataSet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button KoniecDniaBtn;
        private System.Windows.Forms.Button StanKasyBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sprzedazBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView KoszykGridView;
        private System.Windows.Forms.Button Zaplata_btn;
        private System.Windows.Forms.Button anulacja_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ZmienKoszukCombo;
        private System.Windows.Forms.TextBox iloscZmien;
        private System.Windows.Forms.ComboBox UsunKoszykKombo;
        private System.Windows.Forms.Button UsunBtn;
        private System.Windows.Forms.Button zmienBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox wejsciaGryBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox NapojeBTN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox AkcesoriaBTN;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2DataGridView itemsGridView;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button DodajDoKoszykaBTN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox sprzedajComboBox;
        private System.Windows.Forms.TextBox iloscSprzedaj;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox sumaKoszyk;
        private System.Windows.Forms.Label label15;
    }
}
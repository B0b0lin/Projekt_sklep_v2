namespace Projekt_sklep_gui
{
    partial class KoniecDnia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UtargList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.magazynDataSet = new Projekt_sklep_gui.MagazynDataSet();
            this.magazynBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exitBtn = new System.Windows.Forms.Button();
            this.KoniecDniaBtn = new System.Windows.Forms.Button();
            this.StanKasyBtn = new System.Windows.Forms.Button();
            this.MagazynBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sprzedazBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.magazynTableAdapter = new Projekt_sklep_gui.MagazynDataSetTableAdapters.MagazynTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DrukujRaportBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UtargList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(702, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Całkowity utarg dzisiejszy dzień";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.DrukujRaportBtn);
            this.panel3.Controls.Add(this.UtargList);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(322, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1388, 836);
            this.panel3.TabIndex = 31;
            // 
            // UtargList
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.UtargList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.UtargList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UtargList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.UtargList.ColumnHeadersHeight = 25;
            this.UtargList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UtargList.DefaultCellStyle = dataGridViewCellStyle15;
            this.UtargList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.UtargList.Location = new System.Drawing.Point(707, 49);
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
            // 
            // magazynDataSet
            // 
            this.magazynDataSet.DataSetName = "MagazynDataSet";
            this.magazynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magazynBindingSource
            // 
            this.magazynBindingSource.DataMember = "Magazyn";
            this.magazynBindingSource.DataSource = this.magazynDataSet;
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
            this.KoniecDniaBtn.BackColor = System.Drawing.Color.Orange;
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
            this.panel1.TabIndex = 28;
            // 
            // magazynTableAdapter
            // 
            this.magazynTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(462, 34);
            this.label13.TabIndex = 9;
            this.label13.Text = "Koniec Dnia - Zakończ dzień i wydrukuj raport";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Orange;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(322, 94);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1762, 48);
            this.panel5.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.KoniecDniaBtn);
            this.panel2.Controls.Add(this.StanKasyBtn);
            this.panel2.Controls.Add(this.MagazynBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.sprzedazBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 884);
            this.panel2.TabIndex = 29;
            // 
            // DrukujRaportBtn
            // 
            this.DrukujRaportBtn.BackColor = System.Drawing.Color.Orange;
            this.DrukujRaportBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DrukujRaportBtn.FlatAppearance.BorderSize = 3;
            this.DrukujRaportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DrukujRaportBtn.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DrukujRaportBtn.ForeColor = System.Drawing.Color.Black;
            this.DrukujRaportBtn.Location = new System.Drawing.Point(166, 124);
            this.DrukujRaportBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DrukujRaportBtn.Name = "DrukujRaportBtn";
            this.DrukujRaportBtn.Size = new System.Drawing.Size(290, 69);
            this.DrukujRaportBtn.TabIndex = 6;
            this.DrukujRaportBtn.Text = "Drukuj raport";
            this.DrukujRaportBtn.UseVisualStyleBackColor = false;
            this.DrukujRaportBtn.Click += new System.EventHandler(this.DrukujRaportBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(148, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 56);
            this.label4.TabIndex = 19;
            this.label4.Text = "Aby zakończyć dzien wciśnij przycisk\r\noraz postępuj zgodnie z instrukcjami";
            // 
            // KoniecDnia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 978);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KoniecDnia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KoniecDnia";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UtargList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView UtargList;
        private MagazynDataSet magazynDataSet;
        private System.Windows.Forms.BindingSource magazynBindingSource;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button KoniecDniaBtn;
        private System.Windows.Forms.Button StanKasyBtn;
        private System.Windows.Forms.Button MagazynBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sprzedazBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MagazynDataSetTableAdapters.MagazynTableAdapter magazynTableAdapter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DrukujRaportBtn;
    }
}
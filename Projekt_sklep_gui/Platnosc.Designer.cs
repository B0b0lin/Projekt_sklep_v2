namespace Projekt_sklep_gui
{
    partial class Platnosc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Karta = new System.Windows.Forms.Button();
            this.Gotowka = new System.Windows.Forms.Button();
            this.Anuluj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 570);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.Anuluj);
            this.panel2.Controls.Add(this.Gotowka);
            this.panel2.Controls.Add(this.Karta);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 546);
            this.panel2.TabIndex = 0;
            // 
            // Karta
            // 
            this.Karta.BackColor = System.Drawing.Color.Orange;
            this.Karta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Karta.FlatAppearance.BorderSize = 3;
            this.Karta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Karta.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold);
            this.Karta.ForeColor = System.Drawing.Color.Black;
            this.Karta.Location = new System.Drawing.Point(4, 5);
            this.Karta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Karta.Name = "Karta";
            this.Karta.Size = new System.Drawing.Size(409, 78);
            this.Karta.TabIndex = 4;
            this.Karta.Text = "Karta";
            this.Karta.UseVisualStyleBackColor = false;
            this.Karta.Click += new System.EventHandler(this.Karta_Click);
            // 
            // Gotowka
            // 
            this.Gotowka.BackColor = System.Drawing.Color.Orange;
            this.Gotowka.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Gotowka.FlatAppearance.BorderSize = 3;
            this.Gotowka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Gotowka.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold);
            this.Gotowka.ForeColor = System.Drawing.Color.Black;
            this.Gotowka.Location = new System.Drawing.Point(4, 87);
            this.Gotowka.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Gotowka.Name = "Gotowka";
            this.Gotowka.Size = new System.Drawing.Size(409, 78);
            this.Gotowka.TabIndex = 5;
            this.Gotowka.Text = "Gotówka";
            this.Gotowka.UseVisualStyleBackColor = false;
            this.Gotowka.Click += new System.EventHandler(this.Gotowka_Click);
            // 
            // Anuluj
            // 
            this.Anuluj.BackColor = System.Drawing.Color.Firebrick;
            this.Anuluj.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Anuluj.FlatAppearance.BorderSize = 3;
            this.Anuluj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Anuluj.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Anuluj.ForeColor = System.Drawing.Color.Black;
            this.Anuluj.Location = new System.Drawing.Point(4, 461);
            this.Anuluj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(409, 78);
            this.Anuluj.TabIndex = 6;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = false;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // Platnosc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(441, 570);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Platnosc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platnosc";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Anuluj;
        private System.Windows.Forms.Button Gotowka;
        private System.Windows.Forms.Button Karta;
    }
}
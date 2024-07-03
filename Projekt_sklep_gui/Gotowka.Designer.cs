namespace Projekt_sklep_gui
{
    partial class Gotowka
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ZatwierdzBtn = new System.Windows.Forms.Button();
            this.ResztaText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KwotaKientText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NaleznoscText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.ZatwierdzBtn);
            this.panel2.Controls.Add(this.ResztaText);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.KwotaKientText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.NaleznoscText);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 546);
            this.panel2.TabIndex = 0;
            // 
            // ZatwierdzBtn
            // 
            this.ZatwierdzBtn.BackColor = System.Drawing.Color.Orange;
            this.ZatwierdzBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ZatwierdzBtn.FlatAppearance.BorderSize = 3;
            this.ZatwierdzBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZatwierdzBtn.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold);
            this.ZatwierdzBtn.ForeColor = System.Drawing.Color.Black;
            this.ZatwierdzBtn.Location = new System.Drawing.Point(4, 465);
            this.ZatwierdzBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ZatwierdzBtn.Name = "ZatwierdzBtn";
            this.ZatwierdzBtn.Size = new System.Drawing.Size(409, 78);
            this.ZatwierdzBtn.TabIndex = 17;
            this.ZatwierdzBtn.Text = "Zatwierdź";
            this.ZatwierdzBtn.UseVisualStyleBackColor = false;
            this.ZatwierdzBtn.Click += new System.EventHandler(this.ZatwierdzBtn_Click);
            // 
            // ResztaText
            // 
            this.ResztaText.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResztaText.Location = new System.Drawing.Point(221, 267);
            this.ResztaText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResztaText.Name = "ResztaText";
            this.ResztaText.ReadOnly = true;
            this.ResztaText.Size = new System.Drawing.Size(156, 39);
            this.ResztaText.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "Reszta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kwota klienta";
            // 
            // KwotaKientText
            // 
            this.KwotaKientText.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KwotaKientText.Location = new System.Drawing.Point(221, 196);
            this.KwotaKientText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.KwotaKientText.Name = "KwotaKientText";
            this.KwotaKientText.Size = new System.Drawing.Size(156, 39);
            this.KwotaKientText.TabIndex = 13;
            this.KwotaKientText.TextChanged += new System.EventHandler(this.ResztaSum);
            this.KwotaKientText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Należność";
            // 
            // NaleznoscText
            // 
            this.NaleznoscText.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaleznoscText.Location = new System.Drawing.Point(221, 120);
            this.NaleznoscText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NaleznoscText.Name = "NaleznoscText";
            this.NaleznoscText.ReadOnly = true;
            this.NaleznoscText.Size = new System.Drawing.Size(156, 39);
            this.NaleznoscText.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(29, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(359, 34);
            this.label13.TabIndex = 10;
            this.label13.Text = "Płatność gotówką wprowadź kwotę";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 570);
            this.panel1.TabIndex = 2;
            // 
            // Gotowka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 570);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gotowka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gotowka";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ResztaText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KwotaKientText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NaleznoscText;
        private System.Windows.Forms.Button ZatwierdzBtn;
    }
}
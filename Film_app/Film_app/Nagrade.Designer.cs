namespace Film_app
{
    partial class Nagrade
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
            this.Tablica = new System.Windows.Forms.DataGridView();
            this.Izbriši_button = new System.Windows.Forms.Button();
            this.Ažuriraj_button = new System.Windows.Forms.Button();
            this.Dodaj_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Godina_dodjele_text = new System.Windows.Forms.TextBox();
            this.Kategorija_text = new System.Windows.Forms.TextBox();
            this.Organizacija_text = new System.Windows.Forms.TextBox();
            this.Film_ID_text = new System.Windows.Forms.TextBox();
            this.Nagrada_ID_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Produkcijska_kuća_film_button = new System.Windows.Forms.Button();
            this.Produkcijska_kuća_button = new System.Windows.Forms.Button();
            this.Film_čovjek_button = new System.Windows.Forms.Button();
            this.Čovjek_button = new System.Windows.Forms.Button();
            this.Hrvatski_button = new System.Windows.Forms.Button();
            this.Strani_button = new System.Windows.Forms.Button();
            this.Film_button = new System.Windows.Forms.Button();
            this.Tablica2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tablica)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tablica2)).BeginInit();
            this.SuspendLayout();
            // 
            // Tablica
            // 
            this.Tablica.BackgroundColor = System.Drawing.Color.White;
            this.Tablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablica.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tablica.Location = new System.Drawing.Point(683, 84);
            this.Tablica.Name = "Tablica";
            this.Tablica.ReadOnly = true;
            this.Tablica.RowHeadersWidth = 51;
            this.Tablica.RowTemplate.Height = 24;
            this.Tablica.Size = new System.Drawing.Size(679, 363);
            this.Tablica.TabIndex = 63;
            this.Tablica.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tablica_RowHeaderMouseClick);
            // 
            // Izbriši_button
            // 
            this.Izbriši_button.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Izbriši_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izbriši_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Izbriši_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Izbriši_button.Location = new System.Drawing.Point(494, 416);
            this.Izbriši_button.Name = "Izbriši_button";
            this.Izbriši_button.Size = new System.Drawing.Size(77, 30);
            this.Izbriši_button.TabIndex = 62;
            this.Izbriši_button.Text = "Izbriši";
            this.Izbriši_button.UseVisualStyleBackColor = false;
            this.Izbriši_button.Click += new System.EventHandler(this.Izbriši_button_Click);
            // 
            // Ažuriraj_button
            // 
            this.Ažuriraj_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Ažuriraj_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ažuriraj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ažuriraj_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ažuriraj_button.Location = new System.Drawing.Point(391, 416);
            this.Ažuriraj_button.Name = "Ažuriraj_button";
            this.Ažuriraj_button.Size = new System.Drawing.Size(88, 30);
            this.Ažuriraj_button.TabIndex = 61;
            this.Ažuriraj_button.Text = "Ažuriraj";
            this.Ažuriraj_button.UseVisualStyleBackColor = false;
            this.Ažuriraj_button.Click += new System.EventHandler(this.Ažuriraj_button_Click);
            // 
            // Dodaj_button
            // 
            this.Dodaj_button.BackColor = System.Drawing.Color.DarkRed;
            this.Dodaj_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dodaj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodaj_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dodaj_button.Location = new System.Drawing.Point(297, 416);
            this.Dodaj_button.Name = "Dodaj_button";
            this.Dodaj_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dodaj_button.Size = new System.Drawing.Size(79, 30);
            this.Dodaj_button.TabIndex = 60;
            this.Dodaj_button.Text = "Dodaj";
            this.Dodaj_button.UseVisualStyleBackColor = false;
            this.Dodaj_button.Click += new System.EventHandler(this.Dodaj_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(723, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 39);
            this.label6.TabIndex = 59;
            this.label6.Text = "Nagrade";
            // 
            // Godina_dodjele_text
            // 
            this.Godina_dodjele_text.Location = new System.Drawing.Point(398, 331);
            this.Godina_dodjele_text.Name = "Godina_dodjele_text";
            this.Godina_dodjele_text.Size = new System.Drawing.Size(171, 22);
            this.Godina_dodjele_text.TabIndex = 58;
            // 
            // Kategorija_text
            // 
            this.Kategorija_text.Location = new System.Drawing.Point(398, 272);
            this.Kategorija_text.Name = "Kategorija_text";
            this.Kategorija_text.Size = new System.Drawing.Size(171, 22);
            this.Kategorija_text.TabIndex = 57;
            // 
            // Organizacija_text
            // 
            this.Organizacija_text.Location = new System.Drawing.Point(398, 210);
            this.Organizacija_text.Name = "Organizacija_text";
            this.Organizacija_text.Size = new System.Drawing.Size(171, 22);
            this.Organizacija_text.TabIndex = 56;
            // 
            // Film_ID_text
            // 
            this.Film_ID_text.Location = new System.Drawing.Point(398, 150);
            this.Film_ID_text.Name = "Film_ID_text";
            this.Film_ID_text.Size = new System.Drawing.Size(171, 22);
            this.Film_ID_text.TabIndex = 55;
            // 
            // Nagrada_ID_text
            // 
            this.Nagrada_ID_text.BackColor = System.Drawing.Color.Silver;
            this.Nagrada_ID_text.Location = new System.Drawing.Point(398, 84);
            this.Nagrada_ID_text.Name = "Nagrada_ID_text";
            this.Nagrada_ID_text.ReadOnly = true;
            this.Nagrada_ID_text.Size = new System.Drawing.Size(171, 22);
            this.Nagrada_ID_text.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Godina dodjele";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Organizacija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Film_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nagrada_ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.Produkcijska_kuća_film_button);
            this.panel1.Controls.Add(this.Produkcijska_kuća_button);
            this.panel1.Controls.Add(this.Film_čovjek_button);
            this.panel1.Controls.Add(this.Čovjek_button);
            this.panel1.Controls.Add(this.Hrvatski_button);
            this.panel1.Controls.Add(this.Strani_button);
            this.panel1.Controls.Add(this.Film_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 710);
            this.panel1.TabIndex = 48;
            // 
            // Produkcijska_kuća_film_button
            // 
            this.Produkcijska_kuća_film_button.FlatAppearance.BorderSize = 0;
            this.Produkcijska_kuća_film_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Produkcijska_kuća_film_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Produkcijska_kuća_film_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Produkcijska_kuća_film_button.Location = new System.Drawing.Point(22, 397);
            this.Produkcijska_kuća_film_button.Name = "Produkcijska_kuća_film_button";
            this.Produkcijska_kuća_film_button.Size = new System.Drawing.Size(161, 50);
            this.Produkcijska_kuća_film_button.TabIndex = 6;
            this.Produkcijska_kuća_film_button.Text = "Produkcijska kuća-film";
            this.Produkcijska_kuća_film_button.UseVisualStyleBackColor = true;
            this.Produkcijska_kuća_film_button.Click += new System.EventHandler(this.Produkcijska_kuća_film_button_Click);
            // 
            // Produkcijska_kuća_button
            // 
            this.Produkcijska_kuća_button.FlatAppearance.BorderSize = 0;
            this.Produkcijska_kuća_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Produkcijska_kuća_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Produkcijska_kuća_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Produkcijska_kuća_button.Location = new System.Drawing.Point(31, 327);
            this.Produkcijska_kuća_button.Name = "Produkcijska_kuća_button";
            this.Produkcijska_kuća_button.Size = new System.Drawing.Size(133, 48);
            this.Produkcijska_kuća_button.TabIndex = 5;
            this.Produkcijska_kuća_button.Text = "Produkcijska kuća";
            this.Produkcijska_kuća_button.UseVisualStyleBackColor = true;
            this.Produkcijska_kuća_button.Click += new System.EventHandler(this.Produkcijska_kuća_button_Click);
            // 
            // Film_čovjek_button
            // 
            this.Film_čovjek_button.FlatAppearance.BorderSize = 0;
            this.Film_čovjek_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Film_čovjek_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Film_čovjek_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Film_čovjek_button.Location = new System.Drawing.Point(32, 264);
            this.Film_čovjek_button.Name = "Film_čovjek_button";
            this.Film_čovjek_button.Size = new System.Drawing.Size(133, 37);
            this.Film_čovjek_button.TabIndex = 4;
            this.Film_čovjek_button.Text = "Film-čovjek";
            this.Film_čovjek_button.UseVisualStyleBackColor = true;
            this.Film_čovjek_button.Click += new System.EventHandler(this.Film_čovjek_button_Click);
            // 
            // Čovjek_button
            // 
            this.Čovjek_button.FlatAppearance.BorderSize = 0;
            this.Čovjek_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Čovjek_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Čovjek_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Čovjek_button.Location = new System.Drawing.Point(31, 202);
            this.Čovjek_button.Name = "Čovjek_button";
            this.Čovjek_button.Size = new System.Drawing.Size(133, 37);
            this.Čovjek_button.TabIndex = 3;
            this.Čovjek_button.Text = "Čovjek";
            this.Čovjek_button.UseVisualStyleBackColor = true;
            this.Čovjek_button.Click += new System.EventHandler(this.Čovjek_button_Click);
            // 
            // Hrvatski_button
            // 
            this.Hrvatski_button.FlatAppearance.BorderSize = 0;
            this.Hrvatski_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hrvatski_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Hrvatski_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Hrvatski_button.Location = new System.Drawing.Point(31, 140);
            this.Hrvatski_button.Name = "Hrvatski_button";
            this.Hrvatski_button.Size = new System.Drawing.Size(133, 37);
            this.Hrvatski_button.TabIndex = 2;
            this.Hrvatski_button.Text = "Hrvatski film";
            this.Hrvatski_button.UseVisualStyleBackColor = true;
            this.Hrvatski_button.Click += new System.EventHandler(this.Hrvatski_button_Click);
            // 
            // Strani_button
            // 
            this.Strani_button.FlatAppearance.BorderSize = 0;
            this.Strani_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Strani_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Strani_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Strani_button.Location = new System.Drawing.Point(31, 83);
            this.Strani_button.Name = "Strani_button";
            this.Strani_button.Size = new System.Drawing.Size(133, 37);
            this.Strani_button.TabIndex = 1;
            this.Strani_button.Text = "Strani film";
            this.Strani_button.UseVisualStyleBackColor = true;
            this.Strani_button.Click += new System.EventHandler(this.Strani_button_Click);
            // 
            // Film_button
            // 
            this.Film_button.FlatAppearance.BorderSize = 0;
            this.Film_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Film_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.Film_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Film_button.Location = new System.Drawing.Point(32, 24);
            this.Film_button.Name = "Film_button";
            this.Film_button.Size = new System.Drawing.Size(133, 37);
            this.Film_button.TabIndex = 0;
            this.Film_button.Text = "Film";
            this.Film_button.UseVisualStyleBackColor = true;
            this.Film_button.Click += new System.EventHandler(this.Film_button_Click);
            // 
            // Tablica2
            // 
            this.Tablica2.BackgroundColor = System.Drawing.Color.White;
            this.Tablica2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablica2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tablica2.Location = new System.Drawing.Point(451, 539);
            this.Tablica2.Name = "Tablica2";
            this.Tablica2.ReadOnly = true;
            this.Tablica2.RowHeadersWidth = 51;
            this.Tablica2.RowTemplate.Height = 24;
            this.Tablica2.Size = new System.Drawing.Size(667, 171);
            this.Tablica2.TabIndex = 66;
            this.Tablica2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tablica2_RowHeaderMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(696, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 67;
            this.label7.Text = "Tablica za filmove";
            // 
            // Nagrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 710);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Tablica2);
            this.Controls.Add(this.Tablica);
            this.Controls.Add(this.Izbriši_button);
            this.Controls.Add(this.Ažuriraj_button);
            this.Controls.Add(this.Dodaj_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Godina_dodjele_text);
            this.Controls.Add(this.Kategorija_text);
            this.Controls.Add(this.Organizacija_text);
            this.Controls.Add(this.Film_ID_text);
            this.Controls.Add(this.Nagrada_ID_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Nagrade";
            this.Text = "Nagrade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nagrade_FormClosing);
            this.Load += new System.EventHandler(this.Nagrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tablica)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tablica2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tablica;
        private System.Windows.Forms.Button Izbriši_button;
        private System.Windows.Forms.Button Ažuriraj_button;
        private System.Windows.Forms.Button Dodaj_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Godina_dodjele_text;
        private System.Windows.Forms.TextBox Kategorija_text;
        private System.Windows.Forms.TextBox Organizacija_text;
        private System.Windows.Forms.TextBox Film_ID_text;
        private System.Windows.Forms.TextBox Nagrada_ID_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Produkcijska_kuća_film_button;
        private System.Windows.Forms.Button Produkcijska_kuća_button;
        private System.Windows.Forms.Button Film_čovjek_button;
        private System.Windows.Forms.Button Čovjek_button;
        private System.Windows.Forms.Button Hrvatski_button;
        private System.Windows.Forms.Button Strani_button;
        private System.Windows.Forms.Button Film_button;
        private System.Windows.Forms.DataGridView Tablica2;
        private System.Windows.Forms.Label label7;
    }
}
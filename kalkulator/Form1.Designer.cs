﻿namespace kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbzarobki = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbwydatki = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tvzarobki = new System.Windows.Forms.TreeView();
            this.tvwydatki = new System.Windows.Forms.TreeView();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb.ForeColor = System.Drawing.Color.HotPink;
            this.pb.Location = new System.Drawing.Point(166, 38);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(368, 62);
            this.pb.TabIndex = 1;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(159, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "dochody";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "wydatki";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(47, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 4;
            // 
            // cbzarobki
            // 
            this.cbzarobki.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbzarobki.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbzarobki.FormattingEnabled = true;
            this.cbzarobki.ItemHeight = 23;
            this.cbzarobki.Location = new System.Drawing.Point(153, 196);
            this.cbzarobki.Name = "cbzarobki";
            this.cbzarobki.Size = new System.Drawing.Size(150, 31);
            this.cbzarobki.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.AcceptsTab = true;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(380, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 30);
            this.textBox2.TabIndex = 11;
            // 
            // cbwydatki
            // 
            this.cbwydatki.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbwydatki.DropDownWidth = 150;
            this.cbwydatki.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbwydatki.FormattingEnabled = true;
            this.cbwydatki.Location = new System.Drawing.Point(486, 196);
            this.cbwydatki.Name = "cbwydatki";
            this.cbwydatki.Size = new System.Drawing.Size(146, 31);
            this.cbwydatki.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(122, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(441, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "dodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tvzarobki
            // 
            this.tvzarobki.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvzarobki.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvzarobki.Location = new System.Drawing.Point(47, 308);
            this.tvzarobki.Name = "tvzarobki";
            this.tvzarobki.Size = new System.Drawing.Size(283, 225);
            this.tvzarobki.TabIndex = 15;
            // 
            // tvwydatki
            // 
            this.tvwydatki.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvwydatki.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwydatki.Location = new System.Drawing.Point(380, 308);
            this.tvwydatki.Name = "tvwydatki";
            this.tvwydatki.Size = new System.Drawing.Size(283, 225);
            this.tvwydatki.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(272, 550);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 84);
            this.button3.TabIndex = 17;
            this.button3.Text = "raport";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(743, 646);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tvwydatki);
            this.Controls.Add(this.tvzarobki);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbwydatki);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cbzarobki);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbzarobki;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbwydatki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView tvzarobki;
        private System.Windows.Forms.TreeView tvwydatki;
        private System.Windows.Forms.Button button3;
    }
}


namespace fantasysports
{
    partial class Form10
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Wettbewerb_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Spieltag_lbl = new System.Windows.Forms.Label();
            this.Spieltag_Combo = new System.Windows.Forms.ComboBox();
            this.finish_lbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "URL Eingabe:";
            // 
            // Wettbewerb_combo
            // 
            this.Wettbewerb_combo.FormattingEnabled = true;
            this.Wettbewerb_combo.Items.AddRange(new object[] {
            "Premier League"});
            this.Wettbewerb_combo.Location = new System.Drawing.Point(91, 133);
            this.Wettbewerb_combo.Name = "Wettbewerb_combo";
            this.Wettbewerb_combo.Size = new System.Drawing.Size(121, 21);
            this.Wettbewerb_combo.TabIndex = 8;
            this.Wettbewerb_combo.SelectedIndexChanged += new System.EventHandler(this.Wettbewerb_combo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Wettbewerb:";
            // 
            // Spieltag_lbl
            // 
            this.Spieltag_lbl.AutoSize = true;
            this.Spieltag_lbl.Location = new System.Drawing.Point(267, 136);
            this.Spieltag_lbl.Name = "Spieltag_lbl";
            this.Spieltag_lbl.Size = new System.Drawing.Size(45, 13);
            this.Spieltag_lbl.TabIndex = 11;
            this.Spieltag_lbl.Text = "Spieltag";
            this.Spieltag_lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // Spieltag_Combo
            // 
            this.Spieltag_Combo.FormattingEnabled = true;
            this.Spieltag_Combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38"});
            this.Spieltag_Combo.Location = new System.Drawing.Point(358, 133);
            this.Spieltag_Combo.Name = "Spieltag_Combo";
            this.Spieltag_Combo.Size = new System.Drawing.Size(121, 21);
            this.Spieltag_Combo.TabIndex = 10;
            // 
            // finish_lbl
            // 
            this.finish_lbl.AutoSize = true;
            this.finish_lbl.Location = new System.Drawing.Point(88, 198);
            this.finish_lbl.Name = "finish_lbl";
            this.finish_lbl.Size = new System.Drawing.Size(0, 13);
            this.finish_lbl.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.finish_lbl);
            this.Controls.Add(this.Spieltag_lbl);
            this.Controls.Add(this.Spieltag_Combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Wettbewerb_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Wettbewerb_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Spieltag_lbl;
        private System.Windows.Forms.ComboBox Spieltag_Combo;
        private System.Windows.Forms.Label finish_lbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
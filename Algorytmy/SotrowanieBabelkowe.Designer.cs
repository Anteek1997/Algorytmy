namespace Algorytmy
{
    partial class SotrowanieBabelkowe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SotrowanieBabelkowe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.sort = new System.Windows.Forms.Label();
            this.wprowadz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sort1 = new System.Windows.Forms.Label();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.posortowane = new System.Windows.Forms.Label();
            this.wypisane = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sortowanie Bąbelkowe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wprowadź Liczby Do Posortowania:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.maskedTextBox1.Location = new System.Drawing.Point(326, 73);
            this.maskedTextBox1.Mask = "0 0 0 0 0 0 ";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox1.Size = new System.Drawing.Size(215, 24);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // sort
            // 
            this.sort.AutoSize = true;
            this.sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sort.Location = new System.Drawing.Point(113, 106);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(0, 39);
            this.sort.TabIndex = 3;
            // 
            // wprowadz
            // 
            this.wprowadz.Location = new System.Drawing.Point(547, 75);
            this.wprowadz.Name = "wprowadz";
            this.wprowadz.Size = new System.Drawing.Size(82, 23);
            this.wprowadz.TabIndex = 4;
            this.wprowadz.Text = "Wypisz";
            this.wprowadz.UseVisualStyleBackColor = true;
            this.wprowadz.Click += new System.EventHandler(this.wprowadz_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Posortuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sort1
            // 
            this.sort1.AutoSize = true;
            this.sort1.Location = new System.Drawing.Point(161, 119);
            this.sort1.Name = "sort1";
            this.sort1.Size = new System.Drawing.Size(0, 13);
            this.sort1.TabIndex = 25;
            // 
            // textBox_Input
            // 
            this.textBox_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Input.Location = new System.Drawing.Point(120, 9);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(100, 20);
            this.textBox_Input.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Liczby Posortowane:";
            // 
            // posortowane
            // 
            this.posortowane.AutoSize = true;
            this.posortowane.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.posortowane.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.posortowane.Location = new System.Drawing.Point(199, 149);
            this.posortowane.Name = "posortowane";
            this.posortowane.Size = new System.Drawing.Size(0, 24);
            this.posortowane.TabIndex = 9;
            // 
            // wypisane
            // 
            this.wypisane.AutoSize = true;
            this.wypisane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.wypisane.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wypisane.Location = new System.Drawing.Point(173, 114);
            this.wypisane.Name = "wypisane";
            this.wypisane.Size = new System.Drawing.Size(0, 24);
            this.wypisane.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Wybrane Liczby:";
            // 
            // zamknij
            // 
            this.zamknij.Location = new System.Drawing.Point(510, 114);
            this.zamknij.Name = "zamknij";
            this.zamknij.Size = new System.Drawing.Size(128, 58);
            this.zamknij.TabIndex = 28;
            this.zamknij.Text = "Zamknij";
            this.zamknij.UseVisualStyleBackColor = true;
            this.zamknij.Click += new System.EventHandler(this.zamknij_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 186);
            this.Controls.Add(this.zamknij);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wypisane);
            this.Controls.Add(this.posortowane);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sort1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wprowadz);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Input);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Sortowanie bąbelkowe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label sort;
        private System.Windows.Forms.Button wprowadz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sort1;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label posortowane;
        private System.Windows.Forms.Label wypisane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button zamknij;
    }
}
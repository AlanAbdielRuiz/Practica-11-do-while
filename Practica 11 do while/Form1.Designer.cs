namespace Practica_11_do_while
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 87);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "f(x)=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 55);
            label2.Name = "label2";
            label2.Size = new Size(25, 32);
            label2.TabIndex = 1;
            label2.Text = "x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 87);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "_______________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(325, 102);
            label4.Name = "label4";
            label4.Size = new Size(63, 32);
            label4.TabIndex = 3;
            label4.Text = "1+x²";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(161, 185);
            label5.Name = "label5";
            label5.Size = new Size(25, 32);
            label5.TabIndex = 4;
            label5.Text = "x";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(414, 185);
            label6.Name = "label6";
            label6.Size = new Size(47, 32);
            label6.TabIndex = 5;
            label6.Text = "f(x)";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(118, 220);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(118, 193);
            listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new Point(385, 220);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(118, 193);
            listBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(609, 216);
            button1.Name = "button1";
            button1.Size = new Size(134, 32);
            button1.TabIndex = 8;
            button1.Text = "For";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(609, 254);
            button2.Name = "button2";
            button2.Size = new Size(134, 40);
            button2.TabIndex = 9;
            button2.Text = "While";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 192);
            button3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(609, 300);
            button3.Name = "button3";
            button3.Size = new Size(134, 37);
            button3.TabIndex = 10;
            button3.Text = "do...while";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.Location = new Point(609, 343);
            button4.Name = "button4";
            button4.Size = new Size(134, 33);
            button4.TabIndex = 11;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ecuacion 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}

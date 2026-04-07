namespace AutomateFredkin
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(750, 750);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(768, 12);
            label1.Name = "label1";
            label1.Size = new Size(140, 35);
            label1.TabIndex = 1;
            label1.Text = "Nr. culori:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            textBox1.Location = new Point(768, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 41);
            textBox1.TabIndex = 2;
            textBox1.Text = "2";
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(768, 112);
            button1.Name = "button1";
            button1.Size = new Size(140, 44);
            button1.TabIndex = 3;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(768, 162);
            button2.Name = "button2";
            button2.Size = new Size(140, 47);
            button2.TabIndex = 4;
            button2.Text = "Toggle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 773);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}

namespace Test1.View4
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 70);
            label1.Name = "label1";
            label1.Size = new Size(299, 128);
            label1.TabIndex = 1;
            label1.Text = "라벨1";
            // 
            // button3
            // 
            button3.Location = new Point(57, 538);
            button3.Name = "button3";
            button3.Size = new Size(286, 103);
            button3.TabIndex = 3;
            button3.Text = "공격";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(79, 229);
            label2.Name = "label2";
            label2.Size = new Size(299, 128);
            label2.TabIndex = 4;
            label2.Text = "라벨1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(79, 390);
            label3.Name = "label3";
            label3.Size = new Size(299, 128);
            label3.TabIndex = 5;
            label3.Text = "라벨1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(590, 114);
            button1.Name = "button1";
            button1.Size = new Size(369, 302);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(577, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 678);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button3;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private TextBox textBox1;
    }
}
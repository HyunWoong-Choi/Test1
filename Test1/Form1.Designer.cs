namespace Test1
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 48F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkGoldenrod;
            button1.Location = new Point(410, 72);
            button1.Name = "button1";
            button1.Size = new Size(402, 126);
            button1.TabIndex = 0;
            button1.Text = "케릭터생성";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // button2
            // 
            button2.Location = new Point(848, 72);
            button2.Name = "button2";
            button2.Size = new Size(234, 126);
            button2.TabIndex = 2;
            button2.Text = "불러오기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(616, 277);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 562);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
    }
}
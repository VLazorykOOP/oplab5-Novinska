namespace WinFormsApp2
{
    partial class Form1
    {
        // Автоматично створений код конструктора коментується або видаляється
        /*
        public Form1()
        {
            InitializeComponent();
        }
        */

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button1 = new Button();
            Order = new TextBox();
            Length = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 77);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 470);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(685, 27);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 1;
            button1.Text = "Draw";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Order
            // 
            Order.Location = new Point(193, 27);
            Order.Name = "Order";
            Order.Size = new Size(125, 27);
            Order.TabIndex = 2;
            // 
            // Length
            // 
            Length.Location = new Point(554, 27);
            Length.Name = "Length";
            Length.Size = new Size(125, 27);
            Length.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 30);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 4;
            label1.Text = "Order:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 30);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 5;
            label2.Text = "Length:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Length);
            Controls.Add(Order);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Fractal Fern";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private TextBox Order;
        private TextBox Length;
        private Label label1;
        private Label label2;
    }
}

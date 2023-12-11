namespace FulBank
{
    partial class Virement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Virement));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            amount = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(232, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 369);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 463);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 3;
            label1.Text = "JE FAIS UN VIREMENT DE :";
            // 
            // amount
            // 
            amount.Location = new Point(322, 493);
            amount.Name = "amount";
            amount.Size = new Size(149, 23);
            amount.TabIndex = 4;
            amount.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 536);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 5;
            label2.Text = "DEPUIS LE COMPTE :";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox2.Location = new Point(216, 668);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(395, 148);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 689);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 7;
            label3.Text = "VERS LE COMPTE :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(57, 151, 255);
            button1.Location = new Point(554, 685);
            button1.Name = "button1";
            button1.Size = new Size(35, 23);
            button1.TabIndex = 8;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(57, 151, 255);
            button2.Location = new Point(328, 858);
            button2.Name = "button2";
            button2.Size = new Size(157, 55);
            button2.TabIndex = 9;
            button2.Text = "Confirmer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 724);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 11;
            label4.Text = "Choisir un bénéficiaire";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(337, 753);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 574);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 13;
            label5.Text = "Compte principal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 607);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 14;
            label6.Text = "Philippe Seillon";
            // 
            // Virement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 1006);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(amount);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Virement";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox amount;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
    }
}
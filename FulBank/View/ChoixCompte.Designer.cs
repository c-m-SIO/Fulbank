namespace FulBank
{
    partial class ChoixCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixCompte));
            pictureBox1 = new PictureBox();
            vScrollBar1 = new VScrollBar();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelTypeCompte = new Label();
            labelSolde = new Label();
            label7 = new Label();
            label8 = new Label();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(233, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 344);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(742, 436);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(21, 566);
            vScrollBar1.TabIndex = 10;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Location = new Point(72, 436);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(667, 566);
            flowLayoutPanel1.TabIndex = 31;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelTypeCompte);
            groupBox1.Controls.Add(labelSolde);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(661, 162);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "RIB";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.ForeColor = Color.FromArgb(22, 43, 99);
            label1.Location = new Point(439, 59);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 7;
            label1.Text = "Mr.BROC +250€";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.ForeColor = Color.FromArgb(34, 67, 153);
            label2.Location = new Point(18, 31);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "COMPTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Location = new Point(18, 91);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "SOLDE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.ForeColor = Color.FromArgb(22, 43, 99);
            label4.Location = new Point(439, 31);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 4;
            label4.Text = "OPÉRATION";
            // 
            // labelTypeCompte
            // 
            labelTypeCompte.AutoSize = true;
            labelTypeCompte.BackColor = Color.Gainsboro;
            labelTypeCompte.ForeColor = Color.FromArgb(36, 151, 222);
            labelTypeCompte.Location = new Point(18, 59);
            labelTypeCompte.Name = "labelTypeCompte";
            labelTypeCompte.Size = new Size(57, 15);
            labelTypeCompte.TabIndex = 5;
            labelTypeCompte.Text = "ÉPARGNE";
            // 
            // labelSolde
            // 
            labelSolde.AutoSize = true;
            labelSolde.BackColor = Color.Gainsboro;
            labelSolde.Location = new Point(18, 121);
            labelSolde.Name = "labelSolde";
            labelSolde.Size = new Size(43, 15);
            labelSolde.TabIndex = 6;
            labelSolde.Text = "25000€";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.ForeColor = Color.FromArgb(22, 43, 99);
            label7.Location = new Point(439, 91);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 8;
            label7.Text = "Mr.RICHARD -100€";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.ForeColor = Color.FromArgb(22, 43, 99);
            label8.Location = new Point(439, 121);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 9;
            label8.Text = "Mme.MARTIN -500€";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // ChoixCompte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(829, 1066);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(vScrollBar1);
            Controls.Add(pictureBox1);
            Name = "ChoixCompte";
            Text = " ";
            Load += ChoixCompte_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private VScrollBar vScrollBar1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelTypeCompte;
        private Label labelSolde;
        private Label label7;
        private Label label8;
        private MySqlConnector.MySqlCommand mySqlCommand1;
    }
}
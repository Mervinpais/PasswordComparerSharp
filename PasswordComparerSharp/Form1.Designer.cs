namespace PasswordComparerSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            openCSV_BTN = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            strictFilterYesRBTN = new RadioButton();
            strictFilterNoRBTN = new RadioButton();
            label4 = new Label();
            fileLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(520, 45);
            label1.TabIndex = 0;
            label1.Text = "Password Comparer Sharp (PCS)";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.DarkGray;
            flowLayoutPanel1.Location = new Point(12, 138);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1702, 704);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // openCSV_BTN
            // 
            openCSV_BTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            openCSV_BTN.BackColor = Color.FromArgb(64, 64, 64);
            openCSV_BTN.FlatStyle = FlatStyle.Popup;
            openCSV_BTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openCSV_BTN.ForeColor = Color.White;
            openCSV_BTN.Location = new Point(1246, 51);
            openCSV_BTN.Name = "openCSV_BTN";
            openCSV_BTN.Size = new Size(468, 76);
            openCSV_BTN.TabIndex = 2;
            openCSV_BTN.Text = "Open CSV File";
            openCSV_BTN.UseVisualStyleBackColor = false;
            openCSV_BTN.Click += openCSV_BTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(646, 60);
            label2.TabIndex = 3;
            label2.Text = "Passwords that are weak, based on Red-Green, \r\nwith Red being VERY ENDANGERED while Green is just \"Ok enough\"";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.BackColor = Color.FromArgb(64, 64, 64);
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            comboBox1.Location = new Point(1377, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(58, 38);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "0";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.TextUpdate += comboBox1_TextUpdate;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(1246, 10);
            label3.Name = "label3";
            label3.Size = new Size(125, 30);
            label3.TabIndex = 5;
            label3.Text = "Threat Level";
            // 
            // strictFilterYesRBTN
            // 
            strictFilterYesRBTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            strictFilterYesRBTN.AutoSize = true;
            strictFilterYesRBTN.BackColor = Color.Transparent;
            strictFilterYesRBTN.ForeColor = Color.White;
            strictFilterYesRBTN.Location = new Point(1580, 8);
            strictFilterYesRBTN.Name = "strictFilterYesRBTN";
            strictFilterYesRBTN.Size = new Size(68, 34);
            strictFilterYesRBTN.TabIndex = 6;
            strictFilterYesRBTN.Text = "Yes";
            strictFilterYesRBTN.UseVisualStyleBackColor = false;
            strictFilterYesRBTN.CheckedChanged += strictFilterYesRBTN_CheckedChanged;
            // 
            // strictFilterNoRBTN
            // 
            strictFilterNoRBTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            strictFilterNoRBTN.AutoSize = true;
            strictFilterNoRBTN.BackColor = Color.Transparent;
            strictFilterNoRBTN.Checked = true;
            strictFilterNoRBTN.ForeColor = Color.White;
            strictFilterNoRBTN.Location = new Point(1654, 8);
            strictFilterNoRBTN.Name = "strictFilterNoRBTN";
            strictFilterNoRBTN.Size = new Size(66, 34);
            strictFilterNoRBTN.TabIndex = 7;
            strictFilterNoRBTN.TabStop = true;
            strictFilterNoRBTN.Text = "No";
            strictFilterNoRBTN.UseVisualStyleBackColor = false;
            strictFilterNoRBTN.CheckedChanged += strictFilterNoRBTN_CheckedChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(1455, 10);
            label4.Name = "label4";
            label4.Size = new Size(119, 30);
            label4.TabIndex = 8;
            label4.Text = "Strict Filter?";
            // 
            // fileLabel
            // 
            fileLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            fileLabel.AutoSize = true;
            fileLabel.BackColor = Color.Transparent;
            fileLabel.ForeColor = Color.White;
            fileLabel.Location = new Point(12, 846);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(49, 30);
            fileLabel.TabIndex = 9;
            fileLabel.Text = "File:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1726, 885);
            Controls.Add(fileLabel);
            Controls.Add(label4);
            Controls.Add(strictFilterNoRBTN);
            Controls.Add(strictFilterYesRBTN);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(openCSV_BTN);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button openCSV_BTN;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private RadioButton strictFilterYesRBTN;
        private RadioButton strictFilterNoRBTN;
        private Label label4;
        private Label fileLabel;
    }
}

namespace pHCalculatorApp
{
    partial class MainForm
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
            MolarityTextBox = new TextBox();
            CalculateButton = new Button();
            ResultLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // MolarityTextBox
            // 
            MolarityTextBox.Location = new Point(31, 132);
            MolarityTextBox.Name = "MolarityTextBox";
            MolarityTextBox.Size = new Size(315, 27);
            MolarityTextBox.TabIndex = 0;
            MolarityTextBox.TextChanged += MolarityTextBox_TextChanged;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.FromArgb(255, 192, 128);
            CalculateButton.ForeColor = Color.Black;
            CalculateButton.ImageAlign = ContentAlignment.MiddleRight;
            CalculateButton.Location = new Point(117, 187);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(145, 52);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "press";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(56, 281);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(65, 20);
            ResultLabel.TabIndex = 2;
            ResultLabel.Text = "สรุปค่าph";
            ResultLabel.Click += ResultLabel_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.CausesValidation = false;
            label1.Cursor = Cursors.IBeam;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(309, 40);
            label1.TabIndex = 3;
            label1.Text = "คำนวณหาph สูงต่ำ ของน้ำ";
            label1.ClientSizeChanged += label1_Click;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 109);
            label2.Name = "label2";
            label2.Size = new Size(231, 20);
            label2.TabIndex = 4;
            label2.Text = "กรอกค่าความเข้มข้นของน้ำ(molarity)";
            label2.Click += label2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 451);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ResultLabel);
            Controls.Add(CalculateButton);
            Controls.Add(MolarityTextBox);
            Name = "MainForm";
            Text = "pHCalculatorApp";
            ResumeLayout(false);
            PerformLayout();
        }

        private void MolarityTextBox_TextChanged(object sender, EventArgs e)
        {
            // ทำงานเมื่อข้อความใน MolarityTextBox เปลี่ยน
        }


        private void ResultLabel_Click(object sender, EventArgs e)
        {
            // ทำงานเมื่อ Label ResultLabel ถูกคลิก
        }

        #endregion

        private TextBox MolarityTextBox;
        private Button CalculateButton;
        private Label ResultLabel;
        private Label label1;
        private Label label2;
    }
}
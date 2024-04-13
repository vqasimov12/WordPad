namespace WinFormsApp1
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
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            colorDialog1 = new ColorDialog();
            FontList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SizeList = new ListBox();
            bold = new Button();
            Italic = new Button();
            Underlined = new Button();
            Left = new Button();
            Center = new Button();
            Right = new Button();
            btnColor = new Button();
            Load = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(5, 94);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(971, 348);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FontList
            // 
            FontList.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FontList.FormattingEnabled = true;
            FontList.ItemHeight = 23;
            FontList.Location = new Point(12, 55);
            FontList.Name = "FontList";
            FontList.Size = new Size(126, 27);
            FontList.TabIndex = 0;
            FontList.SelectedValueChanged += FontList_SelectedValueChanged;
            FontList.MouseEnter += FontList_MouseEnter;
            FontList.MouseLeave += FontList_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 1;
            label1.Text = "Font";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(170, 19);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 2;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(281, 19);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 3;
            label3.Text = "Font Style";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(442, 19);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 4;
            label4.Text = "Alignment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(584, 19);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 5;
            label5.Text = "Color";
            // 
            // SizeList
            // 
            SizeList.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SizeList.FormattingEnabled = true;
            SizeList.ItemHeight = 23;
            SizeList.Location = new Point(160, 55);
            SizeList.Name = "SizeList";
            SizeList.Size = new Size(80, 27);
            SizeList.TabIndex = 6;
            SizeList.SelectedValueChanged += SizeList_SelectedValueChanged;
            SizeList.MouseEnter += SizeList_MouseEnter;
            SizeList.MouseLeave += SizeList_MouseLeave;
            // 
            // bold
            // 
            bold.Image = Properties.Resources._1;
            bold.Location = new Point(281, 55);
            bold.Name = "bold";
            bold.Size = new Size(36, 27);
            bold.TabIndex = 8;
            bold.UseVisualStyleBackColor = true;
            bold.Click += bold_Click;
            // 
            // Italic
            // 
            Italic.Image = Properties.Resources._2;
            Italic.Location = new Point(323, 55);
            Italic.Name = "Italic";
            Italic.Size = new Size(36, 27);
            Italic.TabIndex = 9;
            Italic.UseVisualStyleBackColor = true;
            Italic.Click += Italic_Click;
            // 
            // Underlined
            // 
            Underlined.Image = Properties.Resources._3;
            Underlined.Location = new Point(365, 55);
            Underlined.Name = "Underlined";
            Underlined.Size = new Size(36, 27);
            Underlined.TabIndex = 10;
            Underlined.UseVisualStyleBackColor = true;
            Underlined.Click += Underlined_Click;
            // 
            // Left
            // 
            Left.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Left.Location = new Point(432, 55);
            Left.Name = "Left";
            Left.Size = new Size(36, 27);
            Left.TabIndex = 11;
            Left.Text = "L";
            Left.UseVisualStyleBackColor = true;
            Left.Click += Left_Click;
            // 
            // Center
            // 
            Center.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Center.Location = new Point(474, 55);
            Center.Name = "Center";
            Center.Size = new Size(36, 27);
            Center.TabIndex = 12;
            Center.Text = "C";
            Center.UseVisualStyleBackColor = true;
            Center.Click += Center_Click;
            // 
            // Right
            // 
            Right.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Right.Location = new Point(516, 55);
            Right.Name = "Right";
            Right.Size = new Size(36, 27);
            Right.TabIndex = 13;
            Right.Text = "R";
            Right.UseVisualStyleBackColor = true;
            Right.Click += Right_Click;
            // 
            // btnColor
            // 
            btnColor.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnColor.Location = new Point(584, 55);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(83, 27);
            btnColor.TabIndex = 14;
            btnColor.Text = "Color";
            btnColor.TextAlign = ContentAlignment.TopCenter;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // Load
            // 
            Load.BackColor = SystemColors.ControlLightLight;
            Load.FlatStyle = FlatStyle.Popup;
            Load.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Load.Location = new Point(746, 42);
            Load.Name = "Load";
            Load.Size = new Size(94, 28);
            Load.TabIndex = 17;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = false;
            Load.Click += Load_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlLightLight;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(877, 42);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 28);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(983, 450);
            Controls.Add(btnSave);
            Controls.Add(Load);
            Controls.Add(FontList);
            Controls.Add(btnColor);
            Controls.Add(Right);
            Controls.Add(Center);
            Controls.Add(label1);
            Controls.Add(Left);
            Controls.Add(Underlined);
            Controls.Add(label2);
            Controls.Add(Italic);
            Controls.Add(label3);
            Controls.Add(bold);
            Controls.Add(label4);
            Controls.Add(SizeList);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "WordPad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ColorDialog colorDialog1;
        private ListBox FontList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox SizeList;
        private Button bold;
        private Button Italic;
        private Button Underlined;
        private Button Left;
        private Button Center;
        private Button Right;
        private Button btnColor;
        private Button Load;
        private Button btnSave;
    }
}
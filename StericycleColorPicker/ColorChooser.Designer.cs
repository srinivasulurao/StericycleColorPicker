namespace StericycleColorPicker
{
    partial class ColorChooser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundColorChooser = new System.Windows.Forms.Button();
            this.BackgroundColor = new System.Windows.Forms.TextBox();
            this.TextColor = new System.Windows.Forms.TextBox();
            this.RequiredColor = new System.Windows.Forms.TextBox();
            this.TextColorChoose = new System.Windows.Forms.Button();
            this.RequiredColorChooser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundColorChooser
            // 
            this.backgroundColorChooser.Location = new System.Drawing.Point(360, 4);
            this.backgroundColorChooser.Name = "backgroundColorChooser";
            this.backgroundColorChooser.Size = new System.Drawing.Size(57, 23);
            this.backgroundColorChooser.TabIndex = 0;
            this.backgroundColorChooser.Text = "Choose";
            this.backgroundColorChooser.UseVisualStyleBackColor = true;
            this.backgroundColorChooser.Click += new System.EventHandler(this.BackgroundColorChooser_Click);
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.Location = new System.Drawing.Point(111, 7);
            this.BackgroundColor.Name = "BackgroundColor";
            this.BackgroundColor.Size = new System.Drawing.Size(244, 20);
            this.BackgroundColor.TabIndex = 1;
            this.BackgroundColor.TextChanged += new System.EventHandler(this.BackgroundColor_TextChanged);
            // 
            // TextColor
            // 
            this.TextColor.Location = new System.Drawing.Point(112, 36);
            this.TextColor.Name = "TextColor";
            this.TextColor.Size = new System.Drawing.Size(243, 20);
            this.TextColor.TabIndex = 2;
            // 
            // RequiredColor
            // 
            this.RequiredColor.Location = new System.Drawing.Point(111, 62);
            this.RequiredColor.Name = "RequiredColor";
            this.RequiredColor.Size = new System.Drawing.Size(244, 20);
            this.RequiredColor.TabIndex = 3;
            // 
            // TextColorChoose
            // 
            this.TextColorChoose.Location = new System.Drawing.Point(361, 33);
            this.TextColorChoose.Name = "TextColorChoose";
            this.TextColorChoose.Size = new System.Drawing.Size(56, 23);
            this.TextColorChoose.TabIndex = 4;
            this.TextColorChoose.Text = "Choose";
            this.TextColorChoose.UseVisualStyleBackColor = true;
            this.TextColorChoose.Click += new System.EventHandler(this.TextColorChooser_Click);
            // 
            // RequiredColorChooser
            // 
            this.RequiredColorChooser.Location = new System.Drawing.Point(361, 62);
            this.RequiredColorChooser.Name = "RequiredColorChooser";
            this.RequiredColorChooser.Size = new System.Drawing.Size(56, 23);
            this.RequiredColorChooser.TabIndex = 6;
            this.RequiredColorChooser.Text = "Choose";
            this.RequiredColorChooser.UseVisualStyleBackColor = true;
            this.RequiredColorChooser.Click += new System.EventHandler(this.RequiredColorChooser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Background Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Text Color";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Required Color";
            // 
            // ColorChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RequiredColorChooser);
            this.Controls.Add(this.TextColorChoose);
            this.Controls.Add(this.RequiredColor);
            this.Controls.Add(this.TextColor);
            this.Controls.Add(this.BackgroundColor);
            this.Controls.Add(this.backgroundColorChooser);
            this.Name = "ColorChooser";
            this.Size = new System.Drawing.Size(457, 91);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backgroundColorChooser;
        public System.Windows.Forms.TextBox BackgroundColor;
        public System.Windows.Forms.TextBox TextColor;
        public System.Windows.Forms.TextBox RequiredColor;
        private System.Windows.Forms.Button TextColorChoose;
        private System.Windows.Forms.Button RequiredColorChooser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

namespace Skybox
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblOffsetX = new System.Windows.Forms.Label();
            this.numericUpDownOffsetX = new System.Windows.Forms.NumericUpDown();
            this.lblOffsetY = new System.Windows.Forms.Label();
            this.numericUpDownOffsetY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetY)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(12, 42);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 600);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 13);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(93, 13);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblOffsetX
            // 
            this.lblOffsetX.AutoSize = true;
            this.lblOffsetX.Location = new System.Drawing.Point(572, 18);
            this.lblOffsetX.Name = "lblOffsetX";
            this.lblOffsetX.Size = new System.Drawing.Size(45, 13);
            this.lblOffsetX.TabIndex = 6;
            this.lblOffsetX.Text = "OffsetX:";
            // 
            // numericUpDownOffsetX
            // 
            this.numericUpDownOffsetX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownOffsetX.Location = new System.Drawing.Point(623, 16);
            this.numericUpDownOffsetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownOffsetX.Name = "numericUpDownOffsetX";
            this.numericUpDownOffsetX.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownOffsetX.TabIndex = 5;
            this.numericUpDownOffsetX.ValueChanged += new System.EventHandler(this.NumericUpDownOffsetX_ValueChanged);
            // 
            // lblOffsetY
            // 
            this.lblOffsetY.AutoSize = true;
            this.lblOffsetY.Location = new System.Drawing.Point(694, 18);
            this.lblOffsetY.Name = "lblOffsetY";
            this.lblOffsetY.Size = new System.Drawing.Size(45, 13);
            this.lblOffsetY.TabIndex = 8;
            this.lblOffsetY.Text = "OffsetY:";
            // 
            // numericUpDownOffsetY
            // 
            this.numericUpDownOffsetY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownOffsetY.Location = new System.Drawing.Point(745, 16);
            this.numericUpDownOffsetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownOffsetY.Name = "numericUpDownOffsetY";
            this.numericUpDownOffsetY.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownOffsetY.TabIndex = 7;
            this.numericUpDownOffsetY.ValueChanged += new System.EventHandler(this.NumericUpDownOffsetY_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 661);
            this.Controls.Add(this.lblOffsetY);
            this.Controls.Add(this.numericUpDownOffsetY);
            this.Controls.Add(this.lblOffsetX);
            this.Controls.Add(this.numericUpDownOffsetX);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(840, 700);
            this.MinimumSize = new System.Drawing.Size(840, 700);
            this.Name = "MainForm";
            this.Text = "Skybox Textures";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblOffsetX;
        private System.Windows.Forms.NumericUpDown numericUpDownOffsetX;
        private System.Windows.Forms.Label lblOffsetY;
        private System.Windows.Forms.NumericUpDown numericUpDownOffsetY;
    }
}


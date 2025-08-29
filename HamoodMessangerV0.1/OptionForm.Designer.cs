namespace HamoodMessangerV0._1
{
    partial class OptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            AddImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)AddImage).BeginInit();
            SuspendLayout();
            // 
            // AddImage
            // 
            AddImage.Image = (Image)resources.GetObject("AddImage.Image");
            AddImage.Location = new Point(48, 43);
            AddImage.Name = "AddImage";
            AddImage.Size = new Size(68, 62);
            AddImage.TabIndex = 0;
            AddImage.TabStop = false;
            AddImage.Click += AddImage_Click;
            // 
            // OptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(664, 400);
            Controls.Add(AddImage);
            Name = "OptionForm";
            Text = "OptionForm";
            ((System.ComponentModel.ISupportInitialize)AddImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox AddImage;
    }
}
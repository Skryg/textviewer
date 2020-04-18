namespace TextViever
{
    partial class Prompter
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
            this.textShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textShow
            // 
            this.textShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textShow.Location = new System.Drawing.Point(0, 0);
            this.textShow.Name = "textShow";
            this.textShow.Size = new System.Drawing.Size(425, 198);
            this.textShow.TabIndex = 0;
            this.textShow.Text = "Text";
            this.textShow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Prompter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(425, 198);
            this.Controls.Add(this.textShow);
            this.Name = "Prompter";
            this.ShowIcon = false;
            this.Text = "Prompter";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textShow;
    }
}
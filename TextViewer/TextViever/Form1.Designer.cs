namespace TextViever
{
    partial class TextViewer
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileList = new System.Windows.Forms.ListBox();
            this.importBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.dataSet1 = new System.Data.DataSet();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(22, 22);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(156, 147);
            this.fileList.TabIndex = 0;
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(22, 175);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(75, 23);
            this.importBtn.TabIndex = 1;
            this.importBtn.Text = "Importuj";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(22, 240);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(156, 29);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Usuń zaznaczony";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(22, 204);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(156, 30);
            this.openBtn.TabIndex = 3;
            this.openBtn.Text = "Otwórz zaznaczony";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(103, 175);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(75, 23);
            this.settingsBtn.TabIndex = 4;
            this.settingsBtn.Text = "Ustawienia";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TextViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 291);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.fileList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TextViewer";
            this.ShowIcon = false;
            this.Text = "TextViewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


namespace Pierre_Philosophale
{
    partial class Form1
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
            this.openExcelFile = new System.Windows.Forms.OpenFileDialog();
            this.generateBuildingsJSON = new System.Windows.Forms.Button();
            this.saveJSON = new System.Windows.Forms.SaveFileDialog();
            this.generateSortsJSON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openExcelFile
            // 
            this.openExcelFile.FileName = "monFichierXLSX";
            this.openExcelFile.Filter = "Fichiers Excel|*.xlsx";
            // 
            // generateBuildingsJSON
            // 
            this.generateBuildingsJSON.Location = new System.Drawing.Point(65, 41);
            this.generateBuildingsJSON.Name = "generateBuildingsJSON";
            this.generateBuildingsJSON.Size = new System.Drawing.Size(159, 23);
            this.generateBuildingsJSON.TabIndex = 0;
            this.generateBuildingsJSON.Text = "Générer Buildings JSON...";
            this.generateBuildingsJSON.UseVisualStyleBackColor = true;
            this.generateBuildingsJSON.Click += new System.EventHandler(this.generateBuildingsJSON_Click);
            // 
            // generateSortsJSON
            // 
            this.generateSortsJSON.Location = new System.Drawing.Point(65, 84);
            this.generateSortsJSON.Name = "generateSortsJSON";
            this.generateSortsJSON.Size = new System.Drawing.Size(159, 23);
            this.generateSortsJSON.TabIndex = 1;
            this.generateSortsJSON.Text = "Générer Sorts JSON...";
            this.generateSortsJSON.UseVisualStyleBackColor = true;
            this.generateSortsJSON.Click += new System.EventHandler(this.generateSortsJSON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.generateSortsJSON);
            this.Controls.Add(this.generateBuildingsJSON);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pierre Philosophale";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openExcelFile;
        private System.Windows.Forms.Button generateBuildingsJSON;
        private System.Windows.Forms.SaveFileDialog saveJSON;
        private System.Windows.Forms.Button generateSortsJSON;
    }
}


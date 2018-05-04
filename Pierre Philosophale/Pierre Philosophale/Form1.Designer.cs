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
            this.generateElementsJSON = new System.Windows.Forms.Button();
            this.elements = new System.Windows.Forms.TextBox();
            this.nbCardsPerElement = new System.Windows.Forms.NumericUpDown();
            this.nbCardsPerCombinaison = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvlMaxCombis = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.generateCombinaisonsJSON = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbCardsPerElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbCardsPerCombinaison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvlMaxCombis)).BeginInit();
            this.SuspendLayout();
            // 
            // openExcelFile
            // 
            this.openExcelFile.FileName = "monFichierXLSX";
            this.openExcelFile.Filter = "Fichiers Excel|*.xlsx";
            // 
            // generateBuildingsJSON
            // 
            this.generateBuildingsJSON.Location = new System.Drawing.Point(65, 17);
            this.generateBuildingsJSON.Name = "generateBuildingsJSON";
            this.generateBuildingsJSON.Size = new System.Drawing.Size(159, 23);
            this.generateBuildingsJSON.TabIndex = 0;
            this.generateBuildingsJSON.Text = "Générer Buildings JSON...";
            this.generateBuildingsJSON.UseVisualStyleBackColor = true;
            this.generateBuildingsJSON.Click += new System.EventHandler(this.generateBuildingsJSON_Click);
            // 
            // generateSortsJSON
            // 
            this.generateSortsJSON.Location = new System.Drawing.Point(65, 60);
            this.generateSortsJSON.Name = "generateSortsJSON";
            this.generateSortsJSON.Size = new System.Drawing.Size(159, 23);
            this.generateSortsJSON.TabIndex = 1;
            this.generateSortsJSON.Text = "Générer Sorts JSON...";
            this.generateSortsJSON.UseVisualStyleBackColor = true;
            this.generateSortsJSON.Click += new System.EventHandler(this.generateSortsJSON_Click);
            // 
            // generateElementsJSON
            // 
            this.generateElementsJSON.Location = new System.Drawing.Point(55, 326);
            this.generateElementsJSON.Name = "generateElementsJSON";
            this.generateElementsJSON.Size = new System.Drawing.Size(176, 45);
            this.generateElementsJSON.TabIndex = 2;
            this.generateElementsJSON.Text = "Générer Éléments JSON...";
            this.generateElementsJSON.UseVisualStyleBackColor = true;
            this.generateElementsJSON.Click += new System.EventHandler(this.generateElementsJSON_Click);
            // 
            // elements
            // 
            this.elements.Location = new System.Drawing.Point(65, 108);
            this.elements.Multiline = true;
            this.elements.Name = "elements";
            this.elements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.elements.Size = new System.Drawing.Size(159, 120);
            this.elements.TabIndex = 3;
            this.elements.Text = "Eau\r\nFeu\r\nAir\r\nTerre\r\nÉlectricité";
            // 
            // nbCardsPerElement
            // 
            this.nbCardsPerElement.Location = new System.Drawing.Point(135, 234);
            this.nbCardsPerElement.Name = "nbCardsPerElement";
            this.nbCardsPerElement.Size = new System.Drawing.Size(75, 20);
            this.nbCardsPerElement.TabIndex = 4;
            this.nbCardsPerElement.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nbCardsPerCombinaison
            // 
            this.nbCardsPerCombinaison.Location = new System.Drawing.Point(135, 260);
            this.nbCardsPerCombinaison.Name = "nbCardsPerCombinaison";
            this.nbCardsPerCombinaison.Size = new System.Drawing.Size(75, 20);
            this.nbCardsPerCombinaison.TabIndex = 5;
            this.nbCardsPerCombinaison.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Élém. Ex.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Combis Ex.";
            // 
            // lvlMaxCombis
            // 
            this.lvlMaxCombis.Location = new System.Drawing.Point(159, 292);
            this.lvlMaxCombis.Name = "lvlMaxCombis";
            this.lvlMaxCombis.Size = new System.Drawing.Size(51, 20);
            this.lvlMaxCombis.TabIndex = 8;
            this.lvlMaxCombis.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lvl Max. Combis";
            // 
            // generateCombinaisonsJSON
            // 
            this.generateCombinaisonsJSON.Location = new System.Drawing.Point(55, 376);
            this.generateCombinaisonsJSON.Name = "generateCombinaisonsJSON";
            this.generateCombinaisonsJSON.Size = new System.Drawing.Size(176, 45);
            this.generateCombinaisonsJSON.TabIndex = 10;
            this.generateCombinaisonsJSON.Text = "Générer Combinaisons JSON...";
            this.generateCombinaisonsJSON.UseVisualStyleBackColor = true;
            this.generateCombinaisonsJSON.Click += new System.EventHandler(this.generateCombinaisonsJSON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 435);
            this.Controls.Add(this.generateCombinaisonsJSON);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvlMaxCombis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbCardsPerCombinaison);
            this.Controls.Add(this.nbCardsPerElement);
            this.Controls.Add(this.elements);
            this.Controls.Add(this.generateElementsJSON);
            this.Controls.Add(this.generateSortsJSON);
            this.Controls.Add(this.generateBuildingsJSON);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pierre Philosophale";
            ((System.ComponentModel.ISupportInitialize)(this.nbCardsPerElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbCardsPerCombinaison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvlMaxCombis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openExcelFile;
        private System.Windows.Forms.Button generateBuildingsJSON;
        private System.Windows.Forms.SaveFileDialog saveJSON;
        private System.Windows.Forms.Button generateSortsJSON;
        private System.Windows.Forms.Button generateElementsJSON;
        private System.Windows.Forms.TextBox elements;
        private System.Windows.Forms.NumericUpDown nbCardsPerElement;
        private System.Windows.Forms.NumericUpDown nbCardsPerCombinaison;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lvlMaxCombis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generateCombinaisonsJSON;
    }
}


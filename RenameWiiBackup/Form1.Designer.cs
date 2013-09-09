using System.Windows.Forms;
using System.Drawing;
using System;
namespace RenameWiiBackup
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Button btnBrowseFile;

        private Button btnBrowserFolder;

        private Button btnRename;

        private Label label1;

        private Label label2;

        private TextBox tbFile;

        private TextBox tbFolder;

        private FolderBrowserDialog folderBrowserDialog1;

        private OpenFileDialog openFileDialog1;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form1";

            this.btnBrowseFile = new Button();
            this.btnBrowserFolder = new Button();
            this.btnRename = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.tbFile = new TextBox();
            this.tbFolder = new TextBox();
            this.folderBrowserDialog1 = new FolderBrowserDialog();
            this.openFileDialog1 = new OpenFileDialog();
            base.SuspendLayout();
            this.btnBrowseFile.Font = new Font("Calibri", 14.25f);
            this.btnBrowseFile.Location = new Point(578, 12);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new Size(45, 43);
            this.btnBrowseFile.TabIndex = 0;
            this.btnBrowseFile.Text = "...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new EventHandler(this.btnBrowseFile_Click);
            this.btnBrowserFolder.Font = new Font("Calibri", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnBrowserFolder.Location = new Point(578, 61);
            this.btnBrowserFolder.Name = "btnBrowserFolder";
            this.btnBrowserFolder.Size = new Size(45, 43);
            this.btnBrowserFolder.TabIndex = 1;
            this.btnBrowserFolder.Text = "...";
            this.btnBrowserFolder.UseVisualStyleBackColor = true;
            this.btnBrowserFolder.Click += new EventHandler(this.btnBrowserFolder_Click);
            this.btnRename.Font = new Font("Calibri", 14.25f);
            this.btnRename.Location = new Point(275, 117);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new Size(122, 55);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "Launch";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new EventHandler(this.btnRename_Click);
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Calibri", 14.25f);
            this.label1.Location = new Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new Size(151, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fichier de titles.txt";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Calibri", 14.25f);
            this.label2.Location = new Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new Size(182, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Répertoire des backup";
            this.tbFile.Font = new Font("Calibri", 14.25f);
            this.tbFile.Location = new Point(169, 19);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new Size(403, 31);
            this.tbFile.TabIndex = 5;
            this.tbFolder.Font = new Font("Calibri", 14.25f);
            this.tbFolder.Location = new Point(200, 68);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.ReadOnly = true;
            this.tbFolder.Size = new Size(372, 31);
            this.tbFolder.TabIndex = 6;
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Fichier de titre|titles.txt";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
//            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(635, 184);
            base.Controls.Add(this.tbFolder);
            base.Controls.Add(this.tbFile);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.btnRename);
            base.Controls.Add(this.btnBrowserFolder);
            base.Controls.Add(this.btnBrowseFile);
            base.Name = "Form1";
            this.Text = "Rename Wii Backup";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
    }
}


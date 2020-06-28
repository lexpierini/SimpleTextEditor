namespace SimpleTextEditor
{
    partial class TextEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soulignéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centréToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.droiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrintFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCropText = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopyText = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPasteText = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLeftAlign = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCentralize = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRightAlign = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.imprimerToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.imprimerToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // couToolStripMenuItem
            // 
            this.couToolStripMenuItem.Name = "couToolStripMenuItem";
            this.couToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.couToolStripMenuItem.Text = "Couper";
            this.couToolStripMenuItem.Click += new System.EventHandler(this.couToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grasToolStripMenuItem,
            this.italiqueToolStripMenuItem,
            this.soulignéToolStripMenuItem,
            this.alignementToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // grasToolStripMenuItem
            // 
            this.grasToolStripMenuItem.Name = "grasToolStripMenuItem";
            this.grasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grasToolStripMenuItem.Text = "Gras";
            this.grasToolStripMenuItem.Click += new System.EventHandler(this.grasToolStripMenuItem_Click);
            // 
            // italiqueToolStripMenuItem
            // 
            this.italiqueToolStripMenuItem.Name = "italiqueToolStripMenuItem";
            this.italiqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.italiqueToolStripMenuItem.Text = "Italique";
            this.italiqueToolStripMenuItem.Click += new System.EventHandler(this.italiqueToolStripMenuItem_Click);
            // 
            // soulignéToolStripMenuItem
            // 
            this.soulignéToolStripMenuItem.Name = "soulignéToolStripMenuItem";
            this.soulignéToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.soulignéToolStripMenuItem.Text = "Souligné";
            this.soulignéToolStripMenuItem.Click += new System.EventHandler(this.soulignéToolStripMenuItem_Click);
            // 
            // alignementToolStripMenuItem
            // 
            this.alignementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaucheToolStripMenuItem,
            this.centréToolStripMenuItem,
            this.droiteToolStripMenuItem});
            this.alignementToolStripMenuItem.Name = "alignementToolStripMenuItem";
            this.alignementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alignementToolStripMenuItem.Text = "Alignement";
            // 
            // gaucheToolStripMenuItem
            // 
            this.gaucheToolStripMenuItem.Name = "gaucheToolStripMenuItem";
            this.gaucheToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gaucheToolStripMenuItem.Text = "Gauche";
            this.gaucheToolStripMenuItem.Click += new System.EventHandler(this.gaucheToolStripMenuItem_Click);
            // 
            // centréToolStripMenuItem
            // 
            this.centréToolStripMenuItem.Name = "centréToolStripMenuItem";
            this.centréToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.centréToolStripMenuItem.Text = "Centré";
            // 
            // droiteToolStripMenuItem
            // 
            this.droiteToolStripMenuItem.Name = "droiteToolStripMenuItem";
            this.droiteToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.droiteToolStripMenuItem.Text = "Droite";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.àProposToolStripMenuItem.Text = "À propos";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewFile,
            this.toolStripButtonOpenFile,
            this.toolStripButtonSaveFile,
            this.toolStripButtonPrintFile,
            this.toolStripSeparator1,
            this.toolStripButtonCropText,
            this.toolStripButtonCopyText,
            this.toolStripButtonPasteText,
            this.toolStripSeparator2,
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripButtonUnderline,
            this.toolStripSeparator3,
            this.toolStripButtonLeftAlign,
            this.toolStripButtonCentralize,
            this.toolStripButtonRightAlign});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNewFile
            // 
            this.toolStripButtonNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewFile.Image = global::SimpleTextEditor.Properties.Resources.new_file_icon;
            this.toolStripButtonNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewFile.Name = "toolStripButtonNewFile";
            this.toolStripButtonNewFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewFile.Text = "Nouveau";
            this.toolStripButtonNewFile.Click += new System.EventHandler(this.toolStripButtonNewFile_Click);
            // 
            // toolStripButtonOpenFile
            // 
            this.toolStripButtonOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenFile.Image = global::SimpleTextEditor.Properties.Resources.open_file_icon;
            this.toolStripButtonOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFile.Name = "toolStripButtonOpenFile";
            this.toolStripButtonOpenFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpenFile.Text = "Ouvrir";
            this.toolStripButtonOpenFile.Click += new System.EventHandler(this.toolStripButtonOpenFile_Click);
            // 
            // toolStripButtonSaveFile
            // 
            this.toolStripButtonSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveFile.Image = global::SimpleTextEditor.Properties.Resources.save_icon;
            this.toolStripButtonSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveFile.Name = "toolStripButtonSaveFile";
            this.toolStripButtonSaveFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveFile.Text = "Enregistrer";
            this.toolStripButtonSaveFile.Click += new System.EventHandler(this.toolStripButtonSaveFile_Click);
            // 
            // toolStripButtonPrintFile
            // 
            this.toolStripButtonPrintFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrintFile.Image = global::SimpleTextEditor.Properties.Resources.print_icon;
            this.toolStripButtonPrintFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrintFile.Name = "toolStripButtonPrintFile";
            this.toolStripButtonPrintFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrintFile.Text = "Imprimer";
            this.toolStripButtonPrintFile.Click += new System.EventHandler(this.toolStripButtonPrintFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCropText
            // 
            this.toolStripButtonCropText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCropText.Image = global::SimpleTextEditor.Properties.Resources.cut_icon;
            this.toolStripButtonCropText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCropText.Name = "toolStripButtonCropText";
            this.toolStripButtonCropText.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCropText.Text = "Couper";
            this.toolStripButtonCropText.Click += new System.EventHandler(this.toolStripButtonCropText_Click);
            // 
            // toolStripButtonCopyText
            // 
            this.toolStripButtonCopyText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopyText.Image = global::SimpleTextEditor.Properties.Resources.copy_icon;
            this.toolStripButtonCopyText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopyText.Name = "toolStripButtonCopyText";
            this.toolStripButtonCopyText.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCopyText.Text = "Copier";
            this.toolStripButtonCopyText.Click += new System.EventHandler(this.toolStripButtonCopyText_Click);
            // 
            // toolStripButtonPasteText
            // 
            this.toolStripButtonPasteText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPasteText.Image = global::SimpleTextEditor.Properties.Resources.paste_icon;
            this.toolStripButtonPasteText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPasteText.Name = "toolStripButtonPasteText";
            this.toolStripButtonPasteText.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPasteText.Text = "Coller";
            this.toolStripButtonPasteText.Click += new System.EventHandler(this.toolStripButtonPasteText_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBold.Image = global::SimpleTextEditor.Properties.Resources.bold_icon;
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBold.Text = "Gras";
            this.toolStripButtonBold.Click += new System.EventHandler(this.toolStripButtonBold_Click);
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonItalic.Image = global::SimpleTextEditor.Properties.Resources.italic_icon;
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonItalic.Text = "Italique";
            this.toolStripButtonItalic.Click += new System.EventHandler(this.toolStripButtonItalic_Click);
            // 
            // toolStripButtonUnderline
            // 
            this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUnderline.Image = global::SimpleTextEditor.Properties.Resources.underline_icon;
            this.toolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            this.toolStripButtonUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUnderline.Text = "Souligné";
            this.toolStripButtonUnderline.Click += new System.EventHandler(this.toolStripButtonUnderline_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonLeftAlign
            // 
            this.toolStripButtonLeftAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLeftAlign.Image = global::SimpleTextEditor.Properties.Resources.left_text_alignment__2_;
            this.toolStripButtonLeftAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLeftAlign.Name = "toolStripButtonLeftAlign";
            this.toolStripButtonLeftAlign.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLeftAlign.Text = "Aligner à gauche";
            this.toolStripButtonLeftAlign.Click += new System.EventHandler(this.toolStripButtonLeftAlign_Click);
            // 
            // toolStripButtonCentralize
            // 
            this.toolStripButtonCentralize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCentralize.Image = global::SimpleTextEditor.Properties.Resources.central_text_alignment__2_;
            this.toolStripButtonCentralize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCentralize.Name = "toolStripButtonCentralize";
            this.toolStripButtonCentralize.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCentralize.Text = "Centrer";
            // 
            // toolStripButtonRightAlign
            // 
            this.toolStripButtonRightAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRightAlign.Image = global::SimpleTextEditor.Properties.Resources.right_text_alignment__2_;
            this.toolStripButtonRightAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRightAlign.Name = "toolStripButtonRightAlign";
            this.toolStripButtonRightAlign.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRightAlign.Text = "Aligner à doite";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 386);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "(*.txt)|*.txt";
            this.openFileDialog1.InitialDirectory = "Documents";
            this.openFileDialog1.Title = "Ouvrir";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "file";
            this.saveFileDialog1.Filter = "(*.txt)|*.txt";
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Éditeur de texte";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soulignéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alignementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaucheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centréToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem droiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrintFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCropText;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopyText;
        private System.Windows.Forms.ToolStripButton toolStripButtonPasteText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonBold;
        private System.Windows.Forms.ToolStripButton toolStripButtonItalic;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonLeftAlign;
        private System.Windows.Forms.ToolStripButton toolStripButtonCentralize;
        private System.Windows.Forms.ToolStripButton toolStripButtonRightAlign;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}


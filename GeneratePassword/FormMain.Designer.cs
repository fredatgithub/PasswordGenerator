namespace GeneratePassword
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.enregistrersousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aperçuavantimpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.sélectionnertoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.personnaliserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sommaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.labelPassordLength = new System.Windows.Forms.Label();
      this.comboBoxPasswordLength = new System.Windows.Forms.ComboBox();
      this.checkBoxIncludeSymbols = new System.Windows.Forms.CheckBox();
      this.buttonGeneratePassword = new System.Windows.Forms.Button();
      this.textBoxPasswordGenerated = new System.Windows.Forms.TextBox();
      this.buttonCopyToClipBoard = new System.Windows.Forms.Button();
      this.labelIncludeSymbols = new System.Windows.Forms.Label();
      this.labelIncludeNumbers = new System.Windows.Forms.Label();
      this.checkBoxIncludeNumbers = new System.Windows.Forms.CheckBox();
      this.labelIncludeLowerCase = new System.Windows.Forms.Label();
      this.checkBoxIncludeLowerCase = new System.Windows.Forms.CheckBox();
      this.labelIncludeUpperCase = new System.Windows.Forms.Label();
      this.checkBoxIncludeUpperCase = new System.Windows.Forms.CheckBox();
      this.labelExcludeSimilarCharacters = new System.Windows.Forms.Label();
      this.checkBoxExcludeSimilarCharacters = new System.Windows.Forms.CheckBox();
      this.labelExcludeAmbiguousCharacters = new System.Windows.Forms.Label();
      this.checkBoxExcludeAmbiguousCharacters = new System.Windows.Forms.CheckBox();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.aideToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(580, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fichierToolStripMenuItem
      // 
      this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.toolStripSeparator,
            this.enregistrerToolStripMenuItem,
            this.enregistrersousToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimerToolStripMenuItem,
            this.aperçuavantimpressionToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
      this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.fichierToolStripMenuItem.Text = "&Fichier";
      // 
      // nouveauToolStripMenuItem
      // 
      this.nouveauToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem.Image")));
      this.nouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
      this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.nouveauToolStripMenuItem.Text = "&Nouveau";
      // 
      // ouvrirToolStripMenuItem
      // 
      this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
      this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
      this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
      // 
      // enregistrerToolStripMenuItem
      // 
      this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
      this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
      this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
      // 
      // enregistrersousToolStripMenuItem
      // 
      this.enregistrersousToolStripMenuItem.Name = "enregistrersousToolStripMenuItem";
      this.enregistrersousToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.enregistrersousToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
      // 
      // imprimerToolStripMenuItem
      // 
      this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
      this.imprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
      this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.imprimerToolStripMenuItem.Text = "&Imprimer";
      // 
      // aperçuavantimpressionToolStripMenuItem
      // 
      this.aperçuavantimpressionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem.Image")));
      this.aperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.aperçuavantimpressionToolStripMenuItem.Name = "aperçuavantimpressionToolStripMenuItem";
      this.aperçuavantimpressionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.aperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
      // 
      // quitterToolStripMenuItem
      // 
      this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
      this.quitterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.quitterToolStripMenuItem.Text = "&Quitter";
      this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
      // 
      // editionToolStripMenuItem
      // 
      this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem,
            this.rétablirToolStripMenuItem,
            this.toolStripSeparator3,
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.toolStripSeparator4,
            this.sélectionnertoutToolStripMenuItem});
      this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
      this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.editionToolStripMenuItem.Text = "&Edition";
      // 
      // annulerToolStripMenuItem
      // 
      this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
      this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.annulerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.annulerToolStripMenuItem.Text = "&Annuler";
      // 
      // rétablirToolStripMenuItem
      // 
      this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
      this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.rétablirToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
      // 
      // couperToolStripMenuItem
      // 
      this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
      this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
      this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.couperToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.couperToolStripMenuItem.Text = "&Couper";
      // 
      // copierToolStripMenuItem
      // 
      this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
      this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
      this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copierToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.copierToolStripMenuItem.Text = "Co&pier";
      // 
      // collerToolStripMenuItem
      // 
      this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
      this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
      this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.collerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.collerToolStripMenuItem.Text = "Co&ller";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
      // 
      // sélectionnertoutToolStripMenuItem
      // 
      this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
      this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
      // 
      // outilsToolStripMenuItem
      // 
      this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnaliserToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
      this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.outilsToolStripMenuItem.Text = "&Outils";
      // 
      // personnaliserToolStripMenuItem
      // 
      this.personnaliserToolStripMenuItem.Name = "personnaliserToolStripMenuItem";
      this.personnaliserToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.personnaliserToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // aideToolStripMenuItem
      // 
      this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sommaireToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.toolStripSeparator5,
            this.àproposdeToolStripMenuItem});
      this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
      this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.aideToolStripMenuItem.Text = "&Aide";
      // 
      // sommaireToolStripMenuItem
      // 
      this.sommaireToolStripMenuItem.Name = "sommaireToolStripMenuItem";
      this.sommaireToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.sommaireToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // rechercherToolStripMenuItem
      // 
      this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
      this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.rechercherToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
      // 
      // àproposdeToolStripMenuItem
      // 
      this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
      this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.àproposdeToolStripMenuItem.Text = "À &propos de...";
      // 
      // labelPassordLength
      // 
      this.labelPassordLength.AutoSize = true;
      this.labelPassordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelPassordLength.Location = new System.Drawing.Point(21, 46);
      this.labelPassordLength.Name = "labelPassordLength";
      this.labelPassordLength.Size = new System.Drawing.Size(178, 17);
      this.labelPassordLength.TabIndex = 1;
      this.labelPassordLength.Text = "Longeur du mot de passe :";
      // 
      // comboBoxPasswordLength
      // 
      this.comboBoxPasswordLength.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.comboBoxPasswordLength.FormattingEnabled = true;
      this.comboBoxPasswordLength.Location = new System.Drawing.Point(255, 43);
      this.comboBoxPasswordLength.Name = "comboBoxPasswordLength";
      this.comboBoxPasswordLength.Size = new System.Drawing.Size(121, 21);
      this.comboBoxPasswordLength.TabIndex = 2;
      // 
      // checkBoxIncludeSymbols
      // 
      this.checkBoxIncludeSymbols.AutoSize = true;
      this.checkBoxIncludeSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxIncludeSymbols.Location = new System.Drawing.Point(255, 86);
      this.checkBoxIncludeSymbols.Name = "checkBoxIncludeSymbols";
      this.checkBoxIncludeSymbols.Size = new System.Drawing.Size(168, 21);
      this.checkBoxIncludeSymbols.TabIndex = 3;
      this.checkBoxIncludeSymbols.Text = "( par exemple, @#$%)";
      this.checkBoxIncludeSymbols.UseVisualStyleBackColor = true;
      // 
      // buttonGeneratePassword
      // 
      this.buttonGeneratePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonGeneratePassword.Location = new System.Drawing.Point(255, 210);
      this.buttonGeneratePassword.Name = "buttonGeneratePassword";
      this.buttonGeneratePassword.Size = new System.Drawing.Size(185, 25);
      this.buttonGeneratePassword.TabIndex = 4;
      this.buttonGeneratePassword.Text = "Créer un mot de passe";
      this.buttonGeneratePassword.UseVisualStyleBackColor = true;
      this.buttonGeneratePassword.Click += new System.EventHandler(this.ButtonGeneratePassword_Click);
      // 
      // textBoxPasswordGenerated
      // 
      this.textBoxPasswordGenerated.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxPasswordGenerated.Location = new System.Drawing.Point(24, 239);
      this.textBoxPasswordGenerated.Name = "textBoxPasswordGenerated";
      this.textBoxPasswordGenerated.Size = new System.Drawing.Size(505, 29);
      this.textBoxPasswordGenerated.TabIndex = 5;
      // 
      // buttonCopyToClipBoard
      // 
      this.buttonCopyToClipBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonCopyToClipBoard.Location = new System.Drawing.Point(255, 271);
      this.buttonCopyToClipBoard.Name = "buttonCopyToClipBoard";
      this.buttonCopyToClipBoard.Size = new System.Drawing.Size(206, 25);
      this.buttonCopyToClipBoard.TabIndex = 6;
      this.buttonCopyToClipBoard.Text = "Copier dans le presse papier";
      this.buttonCopyToClipBoard.UseVisualStyleBackColor = true;
      this.buttonCopyToClipBoard.Click += new System.EventHandler(this.ButtonCopyToClipBoard_Click);
      // 
      // labelIncludeSymbols
      // 
      this.labelIncludeSymbols.AutoSize = true;
      this.labelIncludeSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelIncludeSymbols.Location = new System.Drawing.Point(21, 86);
      this.labelIncludeSymbols.Name = "labelIncludeSymbols";
      this.labelIncludeSymbols.Size = new System.Drawing.Size(148, 17);
      this.labelIncludeSymbols.TabIndex = 7;
      this.labelIncludeSymbols.Text = "Inclure des symboles :";
      // 
      // labelIncludeNumbers
      // 
      this.labelIncludeNumbers.AutoSize = true;
      this.labelIncludeNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelIncludeNumbers.Location = new System.Drawing.Point(21, 107);
      this.labelIncludeNumbers.Name = "labelIncludeNumbers";
      this.labelIncludeNumbers.Size = new System.Drawing.Size(144, 17);
      this.labelIncludeNumbers.TabIndex = 9;
      this.labelIncludeNumbers.Text = "Inclure des nombres :";
      // 
      // checkBoxIncludeNumbers
      // 
      this.checkBoxIncludeNumbers.AutoSize = true;
      this.checkBoxIncludeNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxIncludeNumbers.Location = new System.Drawing.Point(255, 107);
      this.checkBoxIncludeNumbers.Name = "checkBoxIncludeNumbers";
      this.checkBoxIncludeNumbers.Size = new System.Drawing.Size(206, 21);
      this.checkBoxIncludeNumbers.TabIndex = 8;
      this.checkBoxIncludeNumbers.Text = "( par exemple, 1234567890)";
      this.checkBoxIncludeNumbers.UseVisualStyleBackColor = true;
      // 
      // labelIncludeLowerCase
      // 
      this.labelIncludeLowerCase.AutoSize = true;
      this.labelIncludeLowerCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelIncludeLowerCase.Location = new System.Drawing.Point(21, 128);
      this.labelIncludeLowerCase.Name = "labelIncludeLowerCase";
      this.labelIncludeLowerCase.Size = new System.Drawing.Size(230, 17);
      this.labelIncludeLowerCase.TabIndex = 11;
      this.labelIncludeLowerCase.Text = "Inclure des caractères minuscules :";
      // 
      // checkBoxIncludeLowerCase
      // 
      this.checkBoxIncludeLowerCase.AutoSize = true;
      this.checkBoxIncludeLowerCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxIncludeLowerCase.Location = new System.Drawing.Point(255, 128);
      this.checkBoxIncludeLowerCase.Name = "checkBoxIncludeLowerCase";
      this.checkBoxIncludeLowerCase.Size = new System.Drawing.Size(185, 21);
      this.checkBoxIncludeLowerCase.TabIndex = 10;
      this.checkBoxIncludeLowerCase.Text = "( par exemple, abcdefgh)";
      this.checkBoxIncludeLowerCase.UseVisualStyleBackColor = true;
      // 
      // labelIncludeUpperCase
      // 
      this.labelIncludeUpperCase.AutoSize = true;
      this.labelIncludeUpperCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelIncludeUpperCase.Location = new System.Drawing.Point(21, 145);
      this.labelIncludeUpperCase.Name = "labelIncludeUpperCase";
      this.labelIncludeUpperCase.Size = new System.Drawing.Size(230, 17);
      this.labelIncludeUpperCase.TabIndex = 13;
      this.labelIncludeUpperCase.Text = "Inclure des caractères majuscules :";
      // 
      // checkBoxIncludeUpperCase
      // 
      this.checkBoxIncludeUpperCase.AutoSize = true;
      this.checkBoxIncludeUpperCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxIncludeUpperCase.Location = new System.Drawing.Point(255, 145);
      this.checkBoxIncludeUpperCase.Name = "checkBoxIncludeUpperCase";
      this.checkBoxIncludeUpperCase.Size = new System.Drawing.Size(201, 21);
      this.checkBoxIncludeUpperCase.TabIndex = 12;
      this.checkBoxIncludeUpperCase.Text = "( par exemple, ABCDEFGH)";
      this.checkBoxIncludeUpperCase.UseVisualStyleBackColor = true;
      // 
      // labelExcludeSimilarCharacters
      // 
      this.labelExcludeSimilarCharacters.AutoSize = true;
      this.labelExcludeSimilarCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelExcludeSimilarCharacters.Location = new System.Drawing.Point(21, 162);
      this.labelExcludeSimilarCharacters.Name = "labelExcludeSimilarCharacters";
      this.labelExcludeSimilarCharacters.Size = new System.Drawing.Size(217, 17);
      this.labelExcludeSimilarCharacters.TabIndex = 15;
      this.labelExcludeSimilarCharacters.Text = "Exclure les caractères similaires :";
      // 
      // checkBoxExcludeSimilarCharacters
      // 
      this.checkBoxExcludeSimilarCharacters.AutoSize = true;
      this.checkBoxExcludeSimilarCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxExcludeSimilarCharacters.Location = new System.Drawing.Point(255, 162);
      this.checkBoxExcludeSimilarCharacters.Name = "checkBoxExcludeSimilarCharacters";
      this.checkBoxExcludeSimilarCharacters.Size = new System.Drawing.Size(223, 21);
      this.checkBoxExcludeSimilarCharacters.TabIndex = 14;
      this.checkBoxExcludeSimilarCharacters.Text = "( par exemple, i, l, 1, L, o, O, 0)";
      this.checkBoxExcludeSimilarCharacters.UseVisualStyleBackColor = true;
      // 
      // labelExcludeAmbiguousCharacters
      // 
      this.labelExcludeAmbiguousCharacters.AutoSize = true;
      this.labelExcludeAmbiguousCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelExcludeAmbiguousCharacters.Location = new System.Drawing.Point(21, 179);
      this.labelExcludeAmbiguousCharacters.Name = "labelExcludeAmbiguousCharacters";
      this.labelExcludeAmbiguousCharacters.Size = new System.Drawing.Size(212, 17);
      this.labelExcludeAmbiguousCharacters.TabIndex = 17;
      this.labelExcludeAmbiguousCharacters.Text = "Exclure les caractères ambigus :";
      // 
      // checkBoxExcludeAmbiguousCharacters
      // 
      this.checkBoxExcludeAmbiguousCharacters.AutoSize = true;
      this.checkBoxExcludeAmbiguousCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxExcludeAmbiguousCharacters.Location = new System.Drawing.Point(255, 179);
      this.checkBoxExcludeAmbiguousCharacters.Name = "checkBoxExcludeAmbiguousCharacters";
      this.checkBoxExcludeAmbiguousCharacters.Size = new System.Drawing.Size(274, 21);
      this.checkBoxExcludeAmbiguousCharacters.TabIndex = 16;
      this.checkBoxExcludeAmbiguousCharacters.Text = "( par exemple, { } [ ] ( ) / \\ \' \" ~ , ; : . < >)";
      this.checkBoxExcludeAmbiguousCharacters.UseVisualStyleBackColor = true;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(580, 341);
      this.Controls.Add(this.labelExcludeAmbiguousCharacters);
      this.Controls.Add(this.checkBoxExcludeAmbiguousCharacters);
      this.Controls.Add(this.labelExcludeSimilarCharacters);
      this.Controls.Add(this.checkBoxExcludeSimilarCharacters);
      this.Controls.Add(this.labelIncludeUpperCase);
      this.Controls.Add(this.checkBoxIncludeUpperCase);
      this.Controls.Add(this.labelIncludeLowerCase);
      this.Controls.Add(this.checkBoxIncludeLowerCase);
      this.Controls.Add(this.labelIncludeNumbers);
      this.Controls.Add(this.checkBoxIncludeNumbers);
      this.Controls.Add(this.labelIncludeSymbols);
      this.Controls.Add(this.buttonCopyToClipBoard);
      this.Controls.Add(this.textBoxPasswordGenerated);
      this.Controls.Add(this.buttonGeneratePassword);
      this.Controls.Add(this.checkBoxIncludeSymbols);
      this.Controls.Add(this.comboBoxPasswordLength);
      this.Controls.Add(this.labelPassordLength);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FormMain";
      this.Text = "Password Generator";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem enregistrersousToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aperçuavantimpressionToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem sélectionnertoutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem personnaliserToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sommaireToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
    private System.Windows.Forms.Label labelPassordLength;
    private System.Windows.Forms.ComboBox comboBoxPasswordLength;
    private System.Windows.Forms.CheckBox checkBoxIncludeSymbols;
    private System.Windows.Forms.Button buttonGeneratePassword;
    private System.Windows.Forms.TextBox textBoxPasswordGenerated;
    private System.Windows.Forms.Button buttonCopyToClipBoard;
    private System.Windows.Forms.Label labelIncludeSymbols;
    private System.Windows.Forms.Label labelIncludeNumbers;
    private System.Windows.Forms.CheckBox checkBoxIncludeNumbers;
    private System.Windows.Forms.Label labelIncludeLowerCase;
    private System.Windows.Forms.CheckBox checkBoxIncludeLowerCase;
    private System.Windows.Forms.Label labelIncludeUpperCase;
    private System.Windows.Forms.CheckBox checkBoxIncludeUpperCase;
    private System.Windows.Forms.Label labelExcludeSimilarCharacters;
    private System.Windows.Forms.CheckBox checkBoxExcludeSimilarCharacters;
    private System.Windows.Forms.Label labelExcludeAmbiguousCharacters;
    private System.Windows.Forms.CheckBox checkBoxExcludeAmbiguousCharacters;
  }
}


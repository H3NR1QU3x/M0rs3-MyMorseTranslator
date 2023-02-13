namespace M0rs3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.rbnTextToMorse = new System.Windows.Forms.RadioButton();
            this.rbnMorseToText = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInput.Location = new System.Drawing.Point(35, 36);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(230, 385);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutput.Location = new System.Drawing.Point(285, 36);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(230, 385);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.Text = "";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTranslate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTranslate.Location = new System.Drawing.Point(595, 236);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(108, 23);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "Traduzir";
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // rbnTextToMorse
            // 
            this.rbnTextToMorse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnTextToMorse.AutoSize = true;
            this.rbnTextToMorse.Checked = true;
            this.rbnTextToMorse.Location = new System.Drawing.Point(595, 106);
            this.rbnTextToMorse.Name = "rbnTextToMorse";
            this.rbnTextToMorse.Size = new System.Drawing.Size(108, 17);
            this.rbnTextToMorse.TabIndex = 3;
            this.rbnTextToMorse.TabStop = true;
            this.rbnTextToMorse.Text = "Texto para Morse";
            this.rbnTextToMorse.UseVisualStyleBackColor = true;
            this.rbnTextToMorse.CheckedChanged += new System.EventHandler(this.rbnTextToMorse_CheckedChanged);
            // 
            // rbnMorseToText
            // 
            this.rbnMorseToText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnMorseToText.AutoSize = true;
            this.rbnMorseToText.Location = new System.Drawing.Point(595, 150);
            this.rbnMorseToText.Name = "rbnMorseToText";
            this.rbnMorseToText.Size = new System.Drawing.Size(108, 17);
            this.rbnMorseToText.TabIndex = 4;
            this.rbnMorseToText.Text = "Morse para Texto";
            this.rbnMorseToText.UseVisualStyleBackColor = true;
            this.rbnMorseToText.CheckedChanged += new System.EventHandler(this.rbnMorseToText_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output";
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHelp.Location = new System.Drawing.Point(626, 398);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(45, 23);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Ajuda";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopy.Location = new System.Drawing.Point(595, 263);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(108, 23);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copiar";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPaste.Location = new System.Drawing.Point(595, 290);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(108, 23);
            this.btnPaste.TabIndex = 9;
            this.btnPaste.Text = "Colar";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(626, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbnMorseToText);
            this.Controls.Add(this.rbnTextToMorse);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "M0rs3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.RadioButton rbnTextToMorse;
        private System.Windows.Forms.RadioButton rbnMorseToText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnClear;
    }
}


namespace AIHelloWorldForms
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
            this.labelHint = new System.Windows.Forms.Label();
            this.tbxWords = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelLanguageHint = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelHint.Location = new System.Drawing.Point(12, 9);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(411, 25);
            this.labelHint.TabIndex = 0;
            this.labelHint.Text = "Type any words below using one language:";
            // 
            // tbxWords
            // 
            this.tbxWords.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxWords.Location = new System.Drawing.Point(17, 37);
            this.tbxWords.Name = "tbxWords";
            this.tbxWords.Size = new System.Drawing.Size(555, 33);
            this.tbxWords.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(485, 76);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 35);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_ClickAsync);
            // 
            // labelLanguageHint
            // 
            this.labelLanguageHint.AutoSize = true;
            this.labelLanguageHint.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLanguageHint.Location = new System.Drawing.Point(12, 114);
            this.labelLanguageHint.Name = "labelLanguageHint";
            this.labelLanguageHint.Size = new System.Drawing.Size(261, 25);
            this.labelLanguageHint.TabIndex = 3;
            this.labelLanguageHint.Text = "The language you typed is:";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLanguage.ForeColor = System.Drawing.Color.Maroon;
            this.labelLanguage.Location = new System.Drawing.Point(279, 114);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(77, 25);
            this.labelLanguage.TabIndex = 4;
            this.labelLanguage.Text = "English";
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelHello.ForeColor = System.Drawing.Color.Maroon;
            this.labelHello.Location = new System.Drawing.Point(240, 230);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(121, 25);
            this.labelHello.TabIndex = 5;
            this.labelHello.Text = "Hello World";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.labelLanguageHint);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbxWords);
            this.Controls.Add(this.labelHint);
            this.Name = "MainForm";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.TextBox tbxWords;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelLanguageHint;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelHello;
    }
}


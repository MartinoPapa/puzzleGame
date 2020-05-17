namespace puzzleGame
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_easy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_medium = new System.Windows.Forms.Button();
            this.btn_hard = new System.Windows.Forms.Button();
            this.btn_impossible = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_easy
            // 
            this.btn_easy.Location = new System.Drawing.Point(161, 80);
            this.btn_easy.Name = "btn_easy";
            this.btn_easy.Size = new System.Drawing.Size(129, 33);
            this.btn_easy.TabIndex = 0;
            this.btn_easy.Text = "easy";
            this.btn_easy.UseVisualStyleBackColor = true;
            this.btn_easy.Click += new System.EventHandler(this.btn_easy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "select difficulty";
            // 
            // btn_medium
            // 
            this.btn_medium.Location = new System.Drawing.Point(161, 119);
            this.btn_medium.Name = "btn_medium";
            this.btn_medium.Size = new System.Drawing.Size(129, 33);
            this.btn_medium.TabIndex = 2;
            this.btn_medium.Text = "medium";
            this.btn_medium.UseVisualStyleBackColor = true;
            this.btn_medium.Click += new System.EventHandler(this.btn_medium_Click);
            // 
            // btn_hard
            // 
            this.btn_hard.Location = new System.Drawing.Point(161, 158);
            this.btn_hard.Name = "btn_hard";
            this.btn_hard.Size = new System.Drawing.Size(129, 33);
            this.btn_hard.TabIndex = 3;
            this.btn_hard.Text = "hard";
            this.btn_hard.UseVisualStyleBackColor = true;
            this.btn_hard.Click += new System.EventHandler(this.btn_hard_Click);
            // 
            // btn_impossible
            // 
            this.btn_impossible.Location = new System.Drawing.Point(161, 197);
            this.btn_impossible.Name = "btn_impossible";
            this.btn_impossible.Size = new System.Drawing.Size(129, 33);
            this.btn_impossible.TabIndex = 4;
            this.btn_impossible.Text = "impossible";
            this.btn_impossible.UseVisualStyleBackColor = true;
            this.btn_impossible.Click += new System.EventHandler(this.btn_impossible_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 255);
            this.Controls.Add(this.btn_impossible);
            this.Controls.Add(this.btn_hard);
            this.Controls.Add(this.btn_medium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_easy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PuzzleGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_easy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_medium;
        private System.Windows.Forms.Button btn_hard;
        private System.Windows.Forms.Button btn_impossible;
    }
}


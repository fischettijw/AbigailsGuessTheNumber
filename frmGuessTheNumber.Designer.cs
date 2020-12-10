namespace AbigailsGuessTheNumber
{
    partial class frmGuessTheNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuessTheNumber));
            this.lblGuesses = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMaxNumber = new System.Windows.Forms.TextBox();
            this.lblMaxNumber = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtNumGuesses = new System.Windows.Forms.TextBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblHighLow = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.lblHighestLow = new System.Windows.Forms.Label();
            this.lblLowestHigh = new System.Windows.Forms.Label();
            this.lblHighestLowLBL = new System.Windows.Forms.Label();
            this.lblLowestHighLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGuesses
            // 
            this.lblGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuesses.Location = new System.Drawing.Point(45, 237);
            this.lblGuesses.Name = "lblGuesses";
            this.lblGuesses.Size = new System.Drawing.Size(249, 23);
            this.lblGuesses.TabIndex = 0;
            this.lblGuesses.Text = "Current Number of Guesses";
            this.lblGuesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(-7, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(549, 59);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Abigail\'s Guess The Number Game";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaxNumber
            // 
            this.txtMaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxNumber.Location = new System.Drawing.Point(389, 99);
            this.txtMaxNumber.Name = "txtMaxNumber";
            this.txtMaxNumber.Size = new System.Drawing.Size(100, 29);
            this.txtMaxNumber.TabIndex = 2;
            this.txtMaxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaxNumber
            // 
            this.lblMaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxNumber.Location = new System.Drawing.Point(45, 103);
            this.lblMaxNumber.Name = "lblMaxNumber";
            this.lblMaxNumber.Size = new System.Drawing.Size(227, 23);
            this.lblMaxNumber.TabIndex = 3;
            this.lblMaxNumber.Text = "Maximum Number";
            this.lblMaxNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(125, 153);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(287, 42);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Secret Number";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtNumGuesses
            // 
            this.txtNumGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumGuesses.Location = new System.Drawing.Point(389, 234);
            this.txtNumGuesses.Name = "txtNumGuesses";
            this.txtNumGuesses.ReadOnly = true;
            this.txtNumGuesses.Size = new System.Drawing.Size(100, 29);
            this.txtNumGuesses.TabIndex = 5;
            this.txtNumGuesses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGuess
            // 
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(210, 299);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(116, 23);
            this.lblGuess.TabIndex = 6;
            this.lblGuess.Text = "New Guess";
            this.lblGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(218, 332);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 29);
            this.txtGuess.TabIndex = 7;
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(125, 417);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(287, 42);
            this.btnGuess.TabIndex = 8;
            this.btnGuess.Text = "Submit Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblHighLow
            // 
            this.lblHighLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighLow.ForeColor = System.Drawing.Color.Red;
            this.lblHighLow.Location = new System.Drawing.Point(62, 368);
            this.lblHighLow.Name = "lblHighLow";
            this.lblHighLow.Size = new System.Drawing.Size(412, 23);
            this.lblHighLow.TabIndex = 9;
            this.lblHighLow.Text = "Last Guess was TOO -------";
            this.lblHighLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(94, 491);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(349, 42);
            this.btnNewGame.TabIndex = 10;
            this.btnNewGame.Text = "Start New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // txtDebug
            // 
            this.txtDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebug.Location = new System.Drawing.Point(220, 4);
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ReadOnly = true;
            this.txtDebug.Size = new System.Drawing.Size(97, 29);
            this.txtDebug.TabIndex = 11;
            this.txtDebug.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHighestLow
            // 
            this.lblHighestLow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHighestLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestLow.ForeColor = System.Drawing.Color.Red;
            this.lblHighestLow.Location = new System.Drawing.Point(62, 332);
            this.lblHighestLow.Name = "lblHighestLow";
            this.lblHighestLow.Size = new System.Drawing.Size(95, 30);
            this.lblHighestLow.TabIndex = 12;
            this.lblHighestLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowestHigh
            // 
            this.lblLowestHigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLowestHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestHigh.ForeColor = System.Drawing.Color.Red;
            this.lblLowestHigh.Location = new System.Drawing.Point(392, 332);
            this.lblLowestHigh.Name = "lblLowestHigh";
            this.lblLowestHigh.Size = new System.Drawing.Size(95, 30);
            this.lblLowestHigh.TabIndex = 13;
            this.lblLowestHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighestLowLBL
            // 
            this.lblHighestLowLBL.AutoSize = true;
            this.lblHighestLowLBL.Location = new System.Drawing.Point(78, 315);
            this.lblHighestLowLBL.Name = "lblHighestLowLBL";
            this.lblHighestLowLBL.Size = new System.Drawing.Size(63, 13);
            this.lblHighestLowLBL.TabIndex = 14;
            this.lblHighestLowLBL.Text = "HighestLow";
            this.lblHighestLowLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowestHighLBL
            // 
            this.lblLowestHighLBL.AutoSize = true;
            this.lblLowestHighLBL.Location = new System.Drawing.Point(408, 315);
            this.lblLowestHighLBL.Name = "lblLowestHighLBL";
            this.lblLowestHighLBL.Size = new System.Drawing.Size(66, 13);
            this.lblLowestHighLBL.TabIndex = 15;
            this.lblLowestHighLBL.Text = "Lowest High";
            this.lblLowestHighLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGuessTheNumber
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 560);
            this.Controls.Add(this.lblLowestHighLBL);
            this.Controls.Add(this.lblHighestLowLBL);
            this.Controls.Add(this.lblLowestHigh);
            this.Controls.Add(this.lblHighestLow);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblHighLow);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.txtNumGuesses);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblMaxNumber);
            this.Controls.Add(this.txtMaxNumber);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblGuesses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuessTheNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abigail\'s Guess The Number";
            this.Load += new System.EventHandler(this.frmGuessTheNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuesses;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMaxNumber;
        private System.Windows.Forms.Label lblMaxNumber;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtNumGuesses;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblHighLow;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Label lblHighestLow;
        private System.Windows.Forms.Label lblLowestHigh;
        private System.Windows.Forms.Label lblHighestLowLBL;
        private System.Windows.Forms.Label lblLowestHighLBL;
    }
}


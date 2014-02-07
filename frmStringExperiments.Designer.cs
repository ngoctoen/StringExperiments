namespace StringExperiments
{
    partial class frmStringExperiments
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
            this.btnNumChars = new System.Windows.Forms.Button();
            this.btnNumWords = new System.Windows.Forms.Button();
            this.btnFileNameAndExtension = new System.Windows.Forms.Button();
            this.btnWhatever = new System.Windows.Forms.Button();
            this.btnDownshift = new System.Windows.Forms.Button();
            this.btnUpshift = new System.Windows.Forms.Button();
            this.btnLastCharacter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNumChars
            // 
            this.btnNumChars.Location = new System.Drawing.Point(12, 117);
            this.btnNumChars.Name = "btnNumChars";
            this.btnNumChars.Size = new System.Drawing.Size(163, 23);
            this.btnNumChars.TabIndex = 0;
            this.btnNumChars.Text = "Number of Characters";
            this.btnNumChars.UseVisualStyleBackColor = true;
            this.btnNumChars.Click += new System.EventHandler(this.btnNumChars_Click);
            // 
            // btnNumWords
            // 
            this.btnNumWords.Location = new System.Drawing.Point(12, 146);
            this.btnNumWords.Name = "btnNumWords";
            this.btnNumWords.Size = new System.Drawing.Size(163, 23);
            this.btnNumWords.TabIndex = 1;
            this.btnNumWords.Text = "Number of Words";
            this.btnNumWords.UseVisualStyleBackColor = true;
            this.btnNumWords.Click += new System.EventHandler(this.btnNumWords_Click);
            // 
            // btnFileNameAndExtension
            // 
            this.btnFileNameAndExtension.Location = new System.Drawing.Point(12, 175);
            this.btnFileNameAndExtension.Name = "btnFileNameAndExtension";
            this.btnFileNameAndExtension.Size = new System.Drawing.Size(163, 23);
            this.btnFileNameAndExtension.TabIndex = 2;
            this.btnFileNameAndExtension.Text = "File Name and Extension";
            this.btnFileNameAndExtension.UseVisualStyleBackColor = true;
            this.btnFileNameAndExtension.Click += new System.EventHandler(this.btnFileNameAndExtension_Click);
            // 
            // btnWhatever
            // 
            this.btnWhatever.Location = new System.Drawing.Point(12, 204);
            this.btnWhatever.Name = "btnWhatever";
            this.btnWhatever.Size = new System.Drawing.Size(163, 23);
            this.btnWhatever.TabIndex = 3;
            this.btnWhatever.Text = "Whatever";
            this.btnWhatever.UseVisualStyleBackColor = true;
            this.btnWhatever.Click += new System.EventHandler(this.btnWhatever_Click);
            // 
            // btnDownshift
            // 
            this.btnDownshift.Location = new System.Drawing.Point(181, 117);
            this.btnDownshift.Name = "btnDownshift";
            this.btnDownshift.Size = new System.Drawing.Size(91, 23);
            this.btnDownshift.TabIndex = 4;
            this.btnDownshift.Text = "Downshift";
            this.btnDownshift.UseVisualStyleBackColor = true;
            this.btnDownshift.Click += new System.EventHandler(this.btnDownshift_Click);
            // 
            // btnUpshift
            // 
            this.btnUpshift.Location = new System.Drawing.Point(181, 146);
            this.btnUpshift.Name = "btnUpshift";
            this.btnUpshift.Size = new System.Drawing.Size(91, 23);
            this.btnUpshift.TabIndex = 5;
            this.btnUpshift.Text = "Upshift";
            this.btnUpshift.UseVisualStyleBackColor = true;
            this.btnUpshift.Click += new System.EventHandler(this.btnUpshift_Click);
            // 
            // btnLastCharacter
            // 
            this.btnLastCharacter.Location = new System.Drawing.Point(181, 175);
            this.btnLastCharacter.Name = "btnLastCharacter";
            this.btnLastCharacter.Size = new System.Drawing.Size(91, 23);
            this.btnLastCharacter.TabIndex = 6;
            this.btnLastCharacter.Text = "Last Character";
            this.btnLastCharacter.UseVisualStyleBackColor = true;
            this.btnLastCharacter.Click += new System.EventHandler(this.btnLastCharacter_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(181, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 38);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOutput.Size = new System.Drawing.Size(260, 73);
            this.txtOutput.TabIndex = 8;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(260, 20);
            this.txtInput.TabIndex = 9;
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(12, 233);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(62, 20);
            this.txtOriginal.TabIndex = 10;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(119, 233);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(56, 20);
            this.txtChange.TabIndex = 11;
            // 
            // frmStringExperiments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLastCharacter);
            this.Controls.Add(this.btnUpshift);
            this.Controls.Add(this.btnDownshift);
            this.Controls.Add(this.btnWhatever);
            this.Controls.Add(this.btnFileNameAndExtension);
            this.Controls.Add(this.btnNumWords);
            this.Controls.Add(this.btnNumChars);
            this.Name = "frmStringExperiments";
            this.Text = "String Experiments";
            this.Load += new System.EventHandler(this.frmStringExperiments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNumChars;
        private System.Windows.Forms.Button btnNumWords;
        private System.Windows.Forms.Button btnFileNameAndExtension;
        private System.Windows.Forms.Button btnWhatever;
        private System.Windows.Forms.Button btnDownshift;
        private System.Windows.Forms.Button btnUpshift;
        private System.Windows.Forms.Button btnLastCharacter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtChange;
    }
}


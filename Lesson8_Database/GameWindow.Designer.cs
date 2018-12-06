namespace Lesson8_Database
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbQuestion = new System.Windows.Forms.TextBox();
            this.btTrue = new System.Windows.Forms.Button();
            this.btFalse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbQuestion
            // 
            this.txtbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbQuestion.Location = new System.Drawing.Point(14, 18);
            this.txtbQuestion.Multiline = true;
            this.txtbQuestion.Name = "txtbQuestion";
            this.txtbQuestion.ReadOnly = true;
            this.txtbQuestion.Size = new System.Drawing.Size(273, 252);
            this.txtbQuestion.TabIndex = 0;
            this.txtbQuestion.TabStop = false;
            // 
            // btTrue
            // 
            this.btTrue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btTrue.Location = new System.Drawing.Point(14, 277);
            this.btTrue.Name = "btTrue";
            this.btTrue.Size = new System.Drawing.Size(75, 41);
            this.btTrue.TabIndex = 1;
            this.btTrue.Text = "Верю";
            this.btTrue.UseVisualStyleBackColor = true;
            this.btTrue.Click += new System.EventHandler(this.btTrue_Click);
            // 
            // btFalse
            // 
            this.btFalse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFalse.Location = new System.Drawing.Point(212, 276);
            this.btFalse.Name = "btFalse";
            this.btFalse.Size = new System.Drawing.Size(75, 41);
            this.btFalse.TabIndex = 2;
            this.btFalse.Text = "Не верю";
            this.btFalse.UseVisualStyleBackColor = true;
            this.btFalse.Click += new System.EventHandler(this.btFalse_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 330);
            this.Controls.Add(this.btFalse);
            this.Controls.Add(this.btTrue);
            this.Controls.Add(this.txtbQuestion);
            this.Name = "GameWindow";
            this.Text = "Верю - не верю";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbQuestion;
        private System.Windows.Forms.Button btTrue;
        private System.Windows.Forms.Button btFalse;
    }
}
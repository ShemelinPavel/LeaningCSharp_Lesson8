namespace Lesson8_Database
{
    partial class MainWindow
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
            this.btGame = new System.Windows.Forms.Button();
            this.btBaseEditor = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGame
            // 
            this.btGame.Location = new System.Drawing.Point(12, 27);
            this.btGame.Name = "btGame";
            this.btGame.Size = new System.Drawing.Size(256, 51);
            this.btGame.TabIndex = 0;
            this.btGame.Text = "Игра";
            this.btGame.UseVisualStyleBackColor = true;
            this.btGame.Click += new System.EventHandler(this.btGame_Click);
            // 
            // btBaseEditor
            // 
            this.btBaseEditor.Location = new System.Drawing.Point(12, 84);
            this.btBaseEditor.Name = "btBaseEditor";
            this.btBaseEditor.Size = new System.Drawing.Size(256, 51);
            this.btBaseEditor.TabIndex = 1;
            this.btBaseEditor.Text = "База вопросов";
            this.btBaseEditor.UseVisualStyleBackColor = true;
            this.btBaseEditor.Click += new System.EventHandler(this.btBaseEditor_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(12, 141);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(256, 51);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 213);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btBaseEditor);
            this.Controls.Add(this.btGame);
            this.Name = "MainWindow";
            this.Text = "Игра \"Верю - не верю\"";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGame;
        private System.Windows.Forms.Button btBaseEditor;
        private System.Windows.Forms.Button btExit;
    }
}
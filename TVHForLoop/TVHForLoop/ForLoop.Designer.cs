namespace TVHForLoop
{
    partial class ForLoop
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
            this.timeOutputLabel = new System.Windows.Forms.Label();
            this.layerInput = new System.Windows.Forms.TextBox();
            this.layerAskLabel = new System.Windows.Forms.Label();
            this.movesOutputLabel = new System.Windows.Forms.Label();
            this.towerOfHanoiPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.towerOfHanoiPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // timeOutputLabel
            // 
            this.timeOutputLabel.AutoSize = true;
            this.timeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutputLabel.Location = new System.Drawing.Point(12, 63);
            this.timeOutputLabel.Name = "timeOutputLabel";
            this.timeOutputLabel.Size = new System.Drawing.Size(37, 20);
            this.timeOutputLabel.TabIndex = 0;
            this.timeOutputLabel.Text = "Tijd:";
            this.timeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layerInput
            // 
            this.layerInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layerInput.Location = new System.Drawing.Point(143, 6);
            this.layerInput.Name = "layerInput";
            this.layerInput.Size = new System.Drawing.Size(414, 26);
            this.layerInput.TabIndex = 1;
            this.layerInput.TextChanged += new System.EventHandler(this.layerInput_TextChanged);
            // 
            // layerAskLabel
            // 
            this.layerAskLabel.AutoSize = true;
            this.layerAskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layerAskLabel.Location = new System.Drawing.Point(12, 9);
            this.layerAskLabel.Name = "layerAskLabel";
            this.layerAskLabel.Size = new System.Drawing.Size(125, 20);
            this.layerAskLabel.TabIndex = 2;
            this.layerAskLabel.Text = "Hoeveel Lagen?";
            this.layerAskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movesOutputLabel
            // 
            this.movesOutputLabel.AutoSize = true;
            this.movesOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movesOutputLabel.Location = new System.Drawing.Point(12, 43);
            this.movesOutputLabel.Name = "movesOutputLabel";
            this.movesOutputLabel.Size = new System.Drawing.Size(60, 20);
            this.movesOutputLabel.TabIndex = 3;
            this.movesOutputLabel.Text = "Zetten:";
            this.movesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // towerOfHanoiPicture
            // 
            this.towerOfHanoiPicture.Location = new System.Drawing.Point(194, 43);
            this.towerOfHanoiPicture.Name = "towerOfHanoiPicture";
            this.towerOfHanoiPicture.Size = new System.Drawing.Size(363, 132);
            this.towerOfHanoiPicture.TabIndex = 4;
            this.towerOfHanoiPicture.TabStop = false;
            // 
            // ForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 187);
            this.Controls.Add(this.towerOfHanoiPicture);
            this.Controls.Add(this.movesOutputLabel);
            this.Controls.Add(this.layerAskLabel);
            this.Controls.Add(this.layerInput);
            this.Controls.Add(this.timeOutputLabel);
            this.Name = "ForLoop";
            this.Text = "Tower of Hanoi Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.towerOfHanoiPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeOutputLabel;
        private System.Windows.Forms.TextBox layerInput;
        private System.Windows.Forms.Label layerAskLabel;
        private System.Windows.Forms.Label movesOutputLabel;
        private System.Windows.Forms.PictureBox towerOfHanoiPicture;
    }
}


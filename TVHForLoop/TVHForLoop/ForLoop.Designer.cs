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
            this.layerInputBox = new System.Windows.Forms.TextBox();
            this.layerAskLabel = new System.Windows.Forms.Label();
            this.movesOutputLabel = new System.Windows.Forms.Label();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // layerInputBox
            // 
            this.layerInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layerInputBox.Location = new System.Drawing.Point(151, 6);
            this.layerInputBox.Name = "layerInputBox";
            this.layerInputBox.Size = new System.Drawing.Size(343, 26);
            this.layerInputBox.TabIndex = 0;
            this.layerInputBox.TextChanged += new System.EventHandler(this.layerInputBox_TextChanged);
            // 
            // layerAskLabel
            // 
            this.layerAskLabel.AutoSize = true;
            this.layerAskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layerAskLabel.Location = new System.Drawing.Point(12, 9);
            this.layerAskLabel.Name = "layerAskLabel";
            this.layerAskLabel.Size = new System.Drawing.Size(133, 20);
            this.layerAskLabel.TabIndex = 1;
            this.layerAskLabel.Text = "Hoeveel lagen?";
            // 
            // movesOutputLabel
            // 
            this.movesOutputLabel.AutoSize = true;
            this.movesOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movesOutputLabel.Location = new System.Drawing.Point(12, 51);
            this.movesOutputLabel.Name = "movesOutputLabel";
            this.movesOutputLabel.Size = new System.Drawing.Size(82, 20);
            this.movesOutputLabel.TabIndex = 2;
            this.movesOutputLabel.Text = "Zetten: ?";
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.AutoSize = true;
            this.dateOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutputLabel.Location = new System.Drawing.Point(12, 109);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(82, 20);
            this.dateOutputLabel.TabIndex = 3;
            this.dateOutputLabel.Text = "Datum: ?";
            // 
            // ForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.movesOutputLabel);
            this.Controls.Add(this.layerAskLabel);
            this.Controls.Add(this.layerInputBox);
            this.Name = "ForLoop";
            this.Text = "Tower of Hanoi Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox layerInputBox;
        private System.Windows.Forms.Label layerAskLabel;
        private System.Windows.Forms.Label movesOutputLabel;
        private System.Windows.Forms.Label dateOutputLabel;
    }
}


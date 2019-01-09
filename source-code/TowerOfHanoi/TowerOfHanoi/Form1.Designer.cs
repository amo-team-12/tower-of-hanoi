namespace TowerOfHanoi
{
    partial class Form1
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
            this.decreaseByTenBtn = new System.Windows.Forms.Button();
            this.increaseByOneBtn = new System.Windows.Forms.Button();
            this.increaseByTenBtn = new System.Windows.Forms.Button();
            this.decreaseByOneBtn = new System.Windows.Forms.Button();
            this.layersInputLabel = new System.Windows.Forms.Label();
            this.outputForLoopLabel = new System.Windows.Forms.Label();
            this.forLoopGroupBox = new System.Windows.Forms.GroupBox();
            this.machtsverheffingGroupBox = new System.Windows.Forms.GroupBox();
            this.outputMachtsverheffingLabel = new System.Windows.Forms.Label();
            this.recursieGroupBox = new System.Windows.Forms.GroupBox();
            this.outputRecursieLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.forLoopGroupBox.SuspendLayout();
            this.machtsverheffingGroupBox.SuspendLayout();
            this.recursieGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // decreaseByTenBtn
            // 
            this.decreaseByTenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decreaseByTenBtn.Location = new System.Drawing.Point(12, 12);
            this.decreaseByTenBtn.Name = "decreaseByTenBtn";
            this.decreaseByTenBtn.Size = new System.Drawing.Size(53, 53);
            this.decreaseByTenBtn.TabIndex = 0;
            this.decreaseByTenBtn.Text = "- 10";
            this.decreaseByTenBtn.UseVisualStyleBackColor = true;
            this.decreaseByTenBtn.Click += new System.EventHandler(this.decreaseByTenBtn_Click);
            // 
            // increaseByOneBtn
            // 
            this.increaseByOneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increaseByOneBtn.Location = new System.Drawing.Point(235, 12);
            this.increaseByOneBtn.Name = "increaseByOneBtn";
            this.increaseByOneBtn.Size = new System.Drawing.Size(53, 53);
            this.increaseByOneBtn.TabIndex = 1;
            this.increaseByOneBtn.Text = "+ 1";
            this.increaseByOneBtn.UseVisualStyleBackColor = true;
            this.increaseByOneBtn.Click += new System.EventHandler(this.increaseByOneBtn_Click);
            // 
            // increaseByTenBtn
            // 
            this.increaseByTenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increaseByTenBtn.Location = new System.Drawing.Point(294, 12);
            this.increaseByTenBtn.Name = "increaseByTenBtn";
            this.increaseByTenBtn.Size = new System.Drawing.Size(53, 53);
            this.increaseByTenBtn.TabIndex = 2;
            this.increaseByTenBtn.Text = "+ 10";
            this.increaseByTenBtn.UseVisualStyleBackColor = true;
            this.increaseByTenBtn.Click += new System.EventHandler(this.increaseByTenBtn_Click);
            // 
            // decreaseByOneBtn
            // 
            this.decreaseByOneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decreaseByOneBtn.Location = new System.Drawing.Point(71, 12);
            this.decreaseByOneBtn.Name = "decreaseByOneBtn";
            this.decreaseByOneBtn.Size = new System.Drawing.Size(53, 53);
            this.decreaseByOneBtn.TabIndex = 3;
            this.decreaseByOneBtn.Text = "- 1";
            this.decreaseByOneBtn.UseVisualStyleBackColor = true;
            this.decreaseByOneBtn.Click += new System.EventHandler(this.decreaseByOneBtn_Click);
            // 
            // layersInputLabel
            // 
            this.layersInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layersInputLabel.Location = new System.Drawing.Point(130, 12);
            this.layersInputLabel.Name = "layersInputLabel";
            this.layersInputLabel.Size = new System.Drawing.Size(99, 53);
            this.layersInputLabel.TabIndex = 4;
            this.layersInputLabel.Text = "0";
            this.layersInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.layersInputLabel.TextChanged += new System.EventHandler(this.layersInputLabel_TextChanged);
            // 
            // outputForLoopLabel
            // 
            this.outputForLoopLabel.AutoSize = true;
            this.outputForLoopLabel.Location = new System.Drawing.Point(6, 25);
            this.outputForLoopLabel.Name = "outputForLoopLabel";
            this.outputForLoopLabel.Size = new System.Drawing.Size(44, 13);
            this.outputForLoopLabel.TabIndex = 5;
            this.outputForLoopLabel.Text = "Zetten: ";
            // 
            // forLoopGroupBox
            // 
            this.forLoopGroupBox.Controls.Add(this.outputForLoopLabel);
            this.forLoopGroupBox.Location = new System.Drawing.Point(12, 71);
            this.forLoopGroupBox.Name = "forLoopGroupBox";
            this.forLoopGroupBox.Size = new System.Drawing.Size(335, 170);
            this.forLoopGroupBox.TabIndex = 0;
            this.forLoopGroupBox.TabStop = false;
            this.forLoopGroupBox.Text = "For-Loop";
            // 
            // machtsverheffingGroupBox
            // 
            this.machtsverheffingGroupBox.Controls.Add(this.outputMachtsverheffingLabel);
            this.machtsverheffingGroupBox.Location = new System.Drawing.Point(12, 247);
            this.machtsverheffingGroupBox.Name = "machtsverheffingGroupBox";
            this.machtsverheffingGroupBox.Size = new System.Drawing.Size(335, 170);
            this.machtsverheffingGroupBox.TabIndex = 1;
            this.machtsverheffingGroupBox.TabStop = false;
            this.machtsverheffingGroupBox.Text = "Machtsverheffing";
            // 
            // outputMachtsverheffingLabel
            // 
            this.outputMachtsverheffingLabel.AutoSize = true;
            this.outputMachtsverheffingLabel.Location = new System.Drawing.Point(6, 25);
            this.outputMachtsverheffingLabel.Name = "outputMachtsverheffingLabel";
            this.outputMachtsverheffingLabel.Size = new System.Drawing.Size(44, 13);
            this.outputMachtsverheffingLabel.TabIndex = 7;
            this.outputMachtsverheffingLabel.Text = "Zetten: ";
            // 
            // recursieGroupBox
            // 
            this.recursieGroupBox.Controls.Add(this.outputRecursieLabel);
            this.recursieGroupBox.Location = new System.Drawing.Point(353, 247);
            this.recursieGroupBox.Name = "recursieGroupBox";
            this.recursieGroupBox.Size = new System.Drawing.Size(335, 170);
            this.recursieGroupBox.TabIndex = 1;
            this.recursieGroupBox.TabStop = false;
            this.recursieGroupBox.Text = "Recusrie";
            // 
            // outputRecursieLabel
            // 
            this.outputRecursieLabel.AutoSize = true;
            this.outputRecursieLabel.Location = new System.Drawing.Point(6, 25);
            this.outputRecursieLabel.Name = "outputRecursieLabel";
            this.outputRecursieLabel.Size = new System.Drawing.Size(44, 13);
            this.outputRecursieLabel.TabIndex = 6;
            this.outputRecursieLabel.Text = "Zetten: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TowerOfHanoi.Properties.Resources.towerofhanoi;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(353, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 229);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.machtsverheffingGroupBox);
            this.Controls.Add(this.recursieGroupBox);
            this.Controls.Add(this.forLoopGroupBox);
            this.Controls.Add(this.layersInputLabel);
            this.Controls.Add(this.decreaseByOneBtn);
            this.Controls.Add(this.increaseByTenBtn);
            this.Controls.Add(this.increaseByOneBtn);
            this.Controls.Add(this.decreaseByTenBtn);
            this.MaximumSize = new System.Drawing.Size(713, 493);
            this.MinimumSize = new System.Drawing.Size(713, 493);
            this.Name = "Form1";
            this.Text = "Tower Of Hanoi";
            this.forLoopGroupBox.ResumeLayout(false);
            this.forLoopGroupBox.PerformLayout();
            this.machtsverheffingGroupBox.ResumeLayout(false);
            this.machtsverheffingGroupBox.PerformLayout();
            this.recursieGroupBox.ResumeLayout(false);
            this.recursieGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button decreaseByTenBtn;
        private System.Windows.Forms.Button increaseByOneBtn;
        private System.Windows.Forms.Button increaseByTenBtn;
        private System.Windows.Forms.Button decreaseByOneBtn;
        private System.Windows.Forms.Label layersInputLabel;
        private System.Windows.Forms.Label outputForLoopLabel;
        private System.Windows.Forms.GroupBox forLoopGroupBox;
        private System.Windows.Forms.GroupBox machtsverheffingGroupBox;
        private System.Windows.Forms.GroupBox recursieGroupBox;
        private System.Windows.Forms.Label outputMachtsverheffingLabel;
        private System.Windows.Forms.Label outputRecursieLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace TVHForLoop
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
            this.forLoopInputBox = new System.Windows.Forms.TextBox();
            this.forLoopMovesOutputLabel = new System.Windows.Forms.Label();
            this.forLoopTimeOutputLabel = new System.Windows.Forms.Label();
            this.decreaseOneBtn = new System.Windows.Forms.Button();
            this.decreaseTenBtn = new System.Windows.Forms.Button();
            this.indecreaseTenBtn = new System.Windows.Forms.Button();
            this.indecreaseOneBtn = new System.Windows.Forms.Button();
            this.forLoopGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mDecreaseTenBtn = new System.Windows.Forms.Button();
            this.mIncreaseOneBtn = new System.Windows.Forms.Button();
            this.mInputBox = new System.Windows.Forms.TextBox();
            this.mIncreaseTenBtn = new System.Windows.Forms.Button();
            this.mMovesOutputLabel = new System.Windows.Forms.Label();
            this.mTimeOutputLabel = new System.Windows.Forms.Label();
            this.mdecreaseOneBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.forLoopGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // forLoopInputBox
            // 
            this.forLoopInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forLoopInputBox.Location = new System.Drawing.Point(140, 19);
            this.forLoopInputBox.Name = "forLoopInputBox";
            this.forLoopInputBox.Size = new System.Drawing.Size(61, 30);
            this.forLoopInputBox.TabIndex = 0;
            this.forLoopInputBox.Text = "0";
            this.forLoopInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.forLoopInputBox.TextChanged += new System.EventHandler(this.forLoopInputBox_TextChanged);
            // 
            // forLoopMovesOutputLabel
            // 
            this.forLoopMovesOutputLabel.AutoSize = true;
            this.forLoopMovesOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forLoopMovesOutputLabel.Location = new System.Drawing.Point(6, 62);
            this.forLoopMovesOutputLabel.Name = "forLoopMovesOutputLabel";
            this.forLoopMovesOutputLabel.Size = new System.Drawing.Size(137, 20);
            this.forLoopMovesOutputLabel.TabIndex = 2;
            this.forLoopMovesOutputLabel.Text = "Aantal zetten: ?";
            // 
            // forLoopTimeOutputLabel
            // 
            this.forLoopTimeOutputLabel.AutoSize = true;
            this.forLoopTimeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forLoopTimeOutputLabel.Location = new System.Drawing.Point(6, 96);
            this.forLoopTimeOutputLabel.Name = "forLoopTimeOutputLabel";
            this.forLoopTimeOutputLabel.Size = new System.Drawing.Size(57, 20);
            this.forLoopTimeOutputLabel.TabIndex = 3;
            this.forLoopTimeOutputLabel.Text = "Tijd: ?";
            // 
            // decreaseOneBtn
            // 
            this.decreaseOneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decreaseOneBtn.Location = new System.Drawing.Point(73, 19);
            this.decreaseOneBtn.Name = "decreaseOneBtn";
            this.decreaseOneBtn.Size = new System.Drawing.Size(61, 30);
            this.decreaseOneBtn.TabIndex = 7;
            this.decreaseOneBtn.Text = "- 1";
            this.decreaseOneBtn.UseVisualStyleBackColor = true;
            this.decreaseOneBtn.Click += new System.EventHandler(this.decreaseOneBtn_Click);
            // 
            // decreaseTenBtn
            // 
            this.decreaseTenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decreaseTenBtn.Location = new System.Drawing.Point(6, 19);
            this.decreaseTenBtn.Name = "decreaseTenBtn";
            this.decreaseTenBtn.Size = new System.Drawing.Size(61, 30);
            this.decreaseTenBtn.TabIndex = 8;
            this.decreaseTenBtn.Text = "- 10";
            this.decreaseTenBtn.UseVisualStyleBackColor = true;
            this.decreaseTenBtn.Click += new System.EventHandler(this.decreaseTenBtn_Click);
            // 
            // indecreaseTenBtn
            // 
            this.indecreaseTenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indecreaseTenBtn.Location = new System.Drawing.Point(274, 19);
            this.indecreaseTenBtn.Name = "indecreaseTenBtn";
            this.indecreaseTenBtn.Size = new System.Drawing.Size(61, 30);
            this.indecreaseTenBtn.TabIndex = 9;
            this.indecreaseTenBtn.Text = "+ 10";
            this.indecreaseTenBtn.UseVisualStyleBackColor = true;
            this.indecreaseTenBtn.Click += new System.EventHandler(this.indecreaseTenBtn_Click);
            // 
            // indecreaseOneBtn
            // 
            this.indecreaseOneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indecreaseOneBtn.Location = new System.Drawing.Point(207, 19);
            this.indecreaseOneBtn.Name = "indecreaseOneBtn";
            this.indecreaseOneBtn.Size = new System.Drawing.Size(61, 30);
            this.indecreaseOneBtn.TabIndex = 10;
            this.indecreaseOneBtn.Text = "+ 1";
            this.indecreaseOneBtn.UseVisualStyleBackColor = true;
            this.indecreaseOneBtn.Click += new System.EventHandler(this.indecreaseOneBtn_Click);
            // 
            // forLoopGroup
            // 
            this.forLoopGroup.Controls.Add(this.decreaseTenBtn);
            this.forLoopGroup.Controls.Add(this.indecreaseOneBtn);
            this.forLoopGroup.Controls.Add(this.forLoopInputBox);
            this.forLoopGroup.Controls.Add(this.indecreaseTenBtn);
            this.forLoopGroup.Controls.Add(this.forLoopMovesOutputLabel);
            this.forLoopGroup.Controls.Add(this.forLoopTimeOutputLabel);
            this.forLoopGroup.Controls.Add(this.decreaseOneBtn);
            this.forLoopGroup.Location = new System.Drawing.Point(12, 12);
            this.forLoopGroup.Name = "forLoopGroup";
            this.forLoopGroup.Size = new System.Drawing.Size(343, 130);
            this.forLoopGroup.TabIndex = 11;
            this.forLoopGroup.TabStop = false;
            this.forLoopGroup.Text = "For-Loop";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mDecreaseTenBtn);
            this.groupBox1.Controls.Add(this.mIncreaseOneBtn);
            this.groupBox1.Controls.Add(this.mInputBox);
            this.groupBox1.Controls.Add(this.mIncreaseTenBtn);
            this.groupBox1.Controls.Add(this.mMovesOutputLabel);
            this.groupBox1.Controls.Add(this.mTimeOutputLabel);
            this.groupBox1.Controls.Add(this.mdecreaseOneBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 130);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machtsverheffing";
            // 
            // mDecreaseTenBtn
            // 
            this.mDecreaseTenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDecreaseTenBtn.Location = new System.Drawing.Point(6, 19);
            this.mDecreaseTenBtn.Name = "mDecreaseTenBtn";
            this.mDecreaseTenBtn.Size = new System.Drawing.Size(61, 30);
            this.mDecreaseTenBtn.TabIndex = 8;
            this.mDecreaseTenBtn.Text = "- 10";
            this.mDecreaseTenBtn.UseVisualStyleBackColor = true;
            this.mDecreaseTenBtn.Click += new System.EventHandler(this.mDecreaseTenBtn_Click);
            // 
            // mIncreaseOneBtn
            // 
            this.mIncreaseOneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mIncreaseOneBtn.Location = new System.Drawing.Point(207, 19);
            this.mIncreaseOneBtn.Name = "mIncreaseOneBtn";
            this.mIncreaseOneBtn.Size = new System.Drawing.Size(61, 30);
            this.mIncreaseOneBtn.TabIndex = 10;
            this.mIncreaseOneBtn.Text = "+ 1";
            this.mIncreaseOneBtn.UseVisualStyleBackColor = true;
            this.mIncreaseOneBtn.Click += new System.EventHandler(this.mIncreaseOneBtn_Click);
            // 
            // mInputBox
            // 
            this.mInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mInputBox.Location = new System.Drawing.Point(140, 19);
            this.mInputBox.Name = "mInputBox";
            this.mInputBox.Size = new System.Drawing.Size(61, 30);
            this.mInputBox.TabIndex = 0;
            this.mInputBox.Text = "0";
            this.mInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mInputBox.TextChanged += new System.EventHandler(this.mInputBox_TextChanged);
            // 
            // mIncreaseTenBtn
            // 
            this.mIncreaseTenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mIncreaseTenBtn.Location = new System.Drawing.Point(274, 19);
            this.mIncreaseTenBtn.Name = "mIncreaseTenBtn";
            this.mIncreaseTenBtn.Size = new System.Drawing.Size(61, 30);
            this.mIncreaseTenBtn.TabIndex = 9;
            this.mIncreaseTenBtn.Text = "+ 10";
            this.mIncreaseTenBtn.UseVisualStyleBackColor = true;
            this.mIncreaseTenBtn.Click += new System.EventHandler(this.mIncreaseTenBtn_Click);
            // 
            // mMovesOutputLabel
            // 
            this.mMovesOutputLabel.AutoSize = true;
            this.mMovesOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMovesOutputLabel.Location = new System.Drawing.Point(6, 62);
            this.mMovesOutputLabel.Name = "mMovesOutputLabel";
            this.mMovesOutputLabel.Size = new System.Drawing.Size(137, 20);
            this.mMovesOutputLabel.TabIndex = 2;
            this.mMovesOutputLabel.Text = "Aantal zetten: ?";
            // 
            // mTimeOutputLabel
            // 
            this.mTimeOutputLabel.AutoSize = true;
            this.mTimeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTimeOutputLabel.Location = new System.Drawing.Point(6, 96);
            this.mTimeOutputLabel.Name = "mTimeOutputLabel";
            this.mTimeOutputLabel.Size = new System.Drawing.Size(57, 20);
            this.mTimeOutputLabel.TabIndex = 3;
            this.mTimeOutputLabel.Text = "Tijd: ?";
            // 
            // mdecreaseOneBtn
            // 
            this.mdecreaseOneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdecreaseOneBtn.Location = new System.Drawing.Point(73, 19);
            this.mdecreaseOneBtn.Name = "mdecreaseOneBtn";
            this.mdecreaseOneBtn.Size = new System.Drawing.Size(61, 30);
            this.mdecreaseOneBtn.TabIndex = 7;
            this.mdecreaseOneBtn.Text = "- 1";
            this.mdecreaseOneBtn.UseVisualStyleBackColor = true;
            this.mdecreaseOneBtn.Click += new System.EventHandler(this.mdecreaseOneBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(13, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 130);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "- 10";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(207, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "+ 1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(140, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(274, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "+ 10";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aantal zetten: ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tijd: ?";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(73, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "- 1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.forLoopGroup);
            this.Name = "MainForm";
            this.Text = "Tower of Hanoi Calculator";
            this.forLoopGroup.ResumeLayout(false);
            this.forLoopGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox forLoopInputBox;
        private System.Windows.Forms.Label forLoopMovesOutputLabel;
        private System.Windows.Forms.Label forLoopTimeOutputLabel;
        private System.Windows.Forms.Button decreaseOneBtn;
        private System.Windows.Forms.Button decreaseTenBtn;
        private System.Windows.Forms.Button indecreaseTenBtn;
        private System.Windows.Forms.Button indecreaseOneBtn;
        private System.Windows.Forms.GroupBox forLoopGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mDecreaseTenBtn;
        private System.Windows.Forms.Button mIncreaseOneBtn;
        private System.Windows.Forms.TextBox mInputBox;
        private System.Windows.Forms.Button mIncreaseTenBtn;
        private System.Windows.Forms.Label mMovesOutputLabel;
        private System.Windows.Forms.Label mTimeOutputLabel;
        private System.Windows.Forms.Button mdecreaseOneBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
    }
}


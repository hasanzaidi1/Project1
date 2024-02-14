namespace Proj1
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.labelRandNum = new System.Windows.Forms.Label();
            this.groupBoxRadBtns = new System.Windows.Forms.GroupBox();
            this.radioButtonSlow = new System.Windows.Forms.RadioButton();
            this.radioButtonFast = new System.Windows.Forms.RadioButton();
            this.labelNumSelected = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelSelectedNumList = new System.Windows.Forms.Label();
            this.groupBoxRadBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNumber.Location = new System.Drawing.Point(367, 62);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 0;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(147, 66);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(214, 16);
            this.labelNumber.TabIndex = 1;
            this.labelNumber.Text = "Enter a number to set a range:";
            // 
            // enterBtn
            // 
            this.enterBtn.Enabled = false;
            this.enterBtn.Location = new System.Drawing.Point(482, 59);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 23);
            this.enterBtn.TabIndex = 2;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // labelRandNum
            // 
            this.labelRandNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRandNum.Location = new System.Drawing.Point(256, 179);
            this.labelRandNum.Name = "labelRandNum";
            this.labelRandNum.Size = new System.Drawing.Size(105, 97);
            this.labelRandNum.TabIndex = 3;
            this.labelRandNum.Text = "?";
            this.labelRandNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRandNum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelRandNum_MouseClick_1);
            // 
            // groupBoxRadBtns
            // 
            this.groupBoxRadBtns.Controls.Add(this.radioButtonSlow);
            this.groupBoxRadBtns.Controls.Add(this.radioButtonFast);
            this.groupBoxRadBtns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRadBtns.Location = new System.Drawing.Point(527, 179);
            this.groupBoxRadBtns.Name = "groupBoxRadBtns";
            this.groupBoxRadBtns.Size = new System.Drawing.Size(167, 100);
            this.groupBoxRadBtns.TabIndex = 4;
            this.groupBoxRadBtns.TabStop = false;
            this.groupBoxRadBtns.Text = "Speed";
            // 
            // radioButtonSlow
            // 
            this.radioButtonSlow.AutoSize = true;
            this.radioButtonSlow.Location = new System.Drawing.Point(48, 37);
            this.radioButtonSlow.Name = "radioButtonSlow";
            this.radioButtonSlow.Size = new System.Drawing.Size(54, 20);
            this.radioButtonSlow.TabIndex = 1;
            this.radioButtonSlow.TabStop = true;
            this.radioButtonSlow.Text = "Slow";
            this.radioButtonSlow.UseVisualStyleBackColor = true;
            this.radioButtonSlow.CheckedChanged += new System.EventHandler(this.radioButtonSlow_CheckedChanged);
            // 
            // radioButtonFast
            // 
            this.radioButtonFast.AutoSize = true;
            this.radioButtonFast.Location = new System.Drawing.Point(48, 60);
            this.radioButtonFast.Name = "radioButtonFast";
            this.radioButtonFast.Size = new System.Drawing.Size(51, 20);
            this.radioButtonFast.TabIndex = 0;
            this.radioButtonFast.TabStop = true;
            this.radioButtonFast.Text = "Fast";
            this.radioButtonFast.UseVisualStyleBackColor = true;
            this.radioButtonFast.CheckedChanged += new System.EventHandler(this.radioButtonFast_CheckedChanged);
            // 
            // labelNumSelected
            // 
            this.labelNumSelected.AutoSize = true;
            this.labelNumSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumSelected.Location = new System.Drawing.Point(121, 344);
            this.labelNumSelected.Name = "labelNumSelected";
            this.labelNumSelected.Size = new System.Drawing.Size(154, 16);
            this.labelNumSelected.TabIndex = 6;
            this.labelNumSelected.Text = "15 numbers selected:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelSelectedNumList
            // 
            this.labelSelectedNumList.AutoSize = true;
            this.labelSelectedNumList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedNumList.ForeColor = System.Drawing.Color.Teal;
            this.labelSelectedNumList.Location = new System.Drawing.Point(121, 374);
            this.labelSelectedNumList.Name = "labelSelectedNumList";
            this.labelSelectedNumList.Size = new System.Drawing.Size(24, 20);
            this.labelSelectedNumList.TabIndex = 7;
            this.labelSelectedNumList.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSelectedNumList);
            this.Controls.Add(this.labelNumSelected);
            this.Controls.Add(this.groupBoxRadBtns);
            this.Controls.Add(this.labelRandNum);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBoxRadBtns.ResumeLayout(false);
            this.groupBoxRadBtns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label labelRandNum;
        private System.Windows.Forms.GroupBox groupBoxRadBtns;
        private System.Windows.Forms.RadioButton radioButtonSlow;
        private System.Windows.Forms.RadioButton radioButtonFast;
        private System.Windows.Forms.Label labelNumSelected;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelSelectedNumList;
    }
}


namespace Astar
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
            this.rdBtnStart = new System.Windows.Forms.RadioButton();
            this.rdBtnWall = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdBtnDest = new System.Windows.Forms.RadioButton();
            this.rdBtnOnlyResult = new System.Windows.Forms.RadioButton();
            this.rdbtnStep = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdBtnStart
            // 
            this.rdBtnStart.AutoSize = true;
            this.rdBtnStart.Location = new System.Drawing.Point(38, 68);
            this.rdBtnStart.Name = "rdBtnStart";
            this.rdBtnStart.Size = new System.Drawing.Size(69, 24);
            this.rdBtnStart.TabIndex = 0;
            this.rdBtnStart.TabStop = true;
            this.rdBtnStart.Text = "Start";
            this.rdBtnStart.UseVisualStyleBackColor = true;
            // 
            // rdBtnWall
            // 
            this.rdBtnWall.AutoSize = true;
            this.rdBtnWall.Location = new System.Drawing.Point(38, 38);
            this.rdBtnWall.Name = "rdBtnWall";
            this.rdBtnWall.Size = new System.Drawing.Size(64, 24);
            this.rdBtnWall.TabIndex = 1;
            this.rdBtnWall.TabStop = true;
            this.rdBtnWall.Text = "Wall";
            this.rdBtnWall.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.rdBtnDest);
            this.panel1.Controls.Add(this.rdBtnWall);
            this.panel1.Controls.Add(this.rdBtnStart);
            this.panel1.Location = new System.Drawing.Point(1008, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 186);
            this.panel1.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(38, 128);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 24);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Clear";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdBtnDest
            // 
            this.rdBtnDest.AutoSize = true;
            this.rdBtnDest.Location = new System.Drawing.Point(38, 98);
            this.rdBtnDest.Name = "rdBtnDest";
            this.rdBtnDest.Size = new System.Drawing.Size(115, 24);
            this.rdBtnDest.TabIndex = 2;
            this.rdBtnDest.TabStop = true;
            this.rdBtnDest.Text = "Destination";
            this.rdBtnDest.UseVisualStyleBackColor = true;
            // 
            // rdBtnOnlyResult
            // 
            this.rdBtnOnlyResult.AutoSize = true;
            this.rdBtnOnlyResult.Location = new System.Drawing.Point(36, 13);
            this.rdBtnOnlyResult.Name = "rdBtnOnlyResult";
            this.rdBtnOnlyResult.Size = new System.Drawing.Size(111, 24);
            this.rdBtnOnlyResult.TabIndex = 3;
            this.rdBtnOnlyResult.TabStop = true;
            this.rdBtnOnlyResult.Text = "OnlyResult";
            this.rdBtnOnlyResult.UseVisualStyleBackColor = true;
            // 
            // rdbtnStep
            // 
            this.rdbtnStep.AutoSize = true;
            this.rdbtnStep.Location = new System.Drawing.Point(36, 43);
            this.rdbtnStep.Name = "rdbtnStep";
            this.rdbtnStep.Size = new System.Drawing.Size(76, 24);
            this.rdbtnStep.TabIndex = 4;
            this.rdbtnStep.TabStop = true;
            this.rdbtnStep.Text = "Steps";
            this.rdbtnStep.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.rdbtnStep);
            this.panel2.Controls.Add(this.rdBtnOnlyResult);
            this.panel2.Location = new System.Drawing.Point(1008, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 85);
            this.panel2.TabIndex = 5;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1065, 393);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(121, 44);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(1065, 467);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(121, 53);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1229, 742);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBtnStart;
        private System.Windows.Forms.RadioButton rdBtnWall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdBtnDest;
        private System.Windows.Forms.RadioButton rdBtnOnlyResult;
        private System.Windows.Forms.RadioButton rdbtnStep;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnFind;
    }
}


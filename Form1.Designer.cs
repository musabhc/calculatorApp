using System.Drawing;
using System.Windows.Forms;
using System;

namespace calculatorApp
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.percentBtn = new System.Windows.Forms.Button();
            this.clearEntryBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.divisionBtn = new System.Windows.Forms.Button();
            this.rootBtn = new System.Windows.Forms.Button();
            this.squareBtn = new System.Windows.Forms.Button();
            this.reciprocalBtn = new System.Windows.Forms.Button();
            this.multiplicationBtn = new System.Windows.Forms.Button();
            this.numberBtn3 = new System.Windows.Forms.Button();
            this.numberBtn2 = new System.Windows.Forms.Button();
            this.numberBtn1 = new System.Windows.Forms.Button();
            this.subtractionBtn = new System.Windows.Forms.Button();
            this.numberBtn6 = new System.Windows.Forms.Button();
            this.numberBtn5 = new System.Windows.Forms.Button();
            this.numberBtn4 = new System.Windows.Forms.Button();
            this.summationBtn = new System.Windows.Forms.Button();
            this.numberBtn9 = new System.Windows.Forms.Button();
            this.numberBtn8 = new System.Windows.Forms.Button();
            this.numberBtn7 = new System.Windows.Forms.Button();
            this.resultBtn = new System.Windows.Forms.Button();
            this.periodBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.resultReverseBtn = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(351, 93);
            this.txtDisplay.TabIndex = 0;
            // 
            // percentBtn
            // 
            this.percentBtn.Location = new System.Drawing.Point(13, 112);
            this.percentBtn.Name = "percentBtn";
            this.percentBtn.Size = new System.Drawing.Size(83, 63);
            this.percentBtn.TabIndex = 1;
            this.percentBtn.Text = "%";
            this.percentBtn.UseVisualStyleBackColor = true;
            this.percentBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearEntryBtn
            // 
            this.clearEntryBtn.Location = new System.Drawing.Point(102, 112);
            this.clearEntryBtn.Name = "clearEntryBtn";
            this.clearEntryBtn.Size = new System.Drawing.Size(83, 63);
            this.clearEntryBtn.TabIndex = 2;
            this.clearEntryBtn.Text = "CE";
            this.clearEntryBtn.UseVisualStyleBackColor = true;
            this.clearEntryBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(191, 112);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(83, 63);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(280, 112);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(83, 63);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "<--";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // divisionBtn
            // 
            this.divisionBtn.Location = new System.Drawing.Point(280, 181);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.Size = new System.Drawing.Size(83, 63);
            this.divisionBtn.TabIndex = 8;
            this.divisionBtn.Text = "/";
            this.divisionBtn.UseVisualStyleBackColor = true;
            this.divisionBtn.Click += new System.EventHandler(this.divisionBtn_Click);
            // 
            // rootBtn
            // 
            this.rootBtn.Location = new System.Drawing.Point(191, 181);
            this.rootBtn.Name = "rootBtn";
            this.rootBtn.Size = new System.Drawing.Size(83, 63);
            this.rootBtn.TabIndex = 7;
            this.rootBtn.Text = "√x";
            this.rootBtn.UseVisualStyleBackColor = true;
            this.rootBtn.Click += new System.EventHandler(this.rootBtn_Click);
            // 
            // squareBtn
            // 
            this.squareBtn.Location = new System.Drawing.Point(102, 181);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(83, 63);
            this.squareBtn.TabIndex = 6;
            this.squareBtn.Text = "x^2";
            this.squareBtn.UseVisualStyleBackColor = true;
            this.squareBtn.Click += new System.EventHandler(this.squareBtn_Click);
            // 
            // reciprocalBtn
            // 
            this.reciprocalBtn.Location = new System.Drawing.Point(13, 181);
            this.reciprocalBtn.Name = "reciprocalBtn";
            this.reciprocalBtn.Size = new System.Drawing.Size(83, 63);
            this.reciprocalBtn.TabIndex = 5;
            this.reciprocalBtn.Text = "1/x";
            this.reciprocalBtn.UseVisualStyleBackColor = true;
            // 
            // multiplicationBtn
            // 
            this.multiplicationBtn.Location = new System.Drawing.Point(280, 250);
            this.multiplicationBtn.Name = "multiplicationBtn";
            this.multiplicationBtn.Size = new System.Drawing.Size(83, 63);
            this.multiplicationBtn.TabIndex = 12;
            this.multiplicationBtn.Text = "X";
            this.multiplicationBtn.UseVisualStyleBackColor = true;
            this.multiplicationBtn.Click += new System.EventHandler(this.multiplicationBtn_Click);
            // 
            // numberBtn3
            // 
            this.numberBtn3.Location = new System.Drawing.Point(191, 250);
            this.numberBtn3.Name = "numberBtn3";
            this.numberBtn3.Size = new System.Drawing.Size(83, 63);
            this.numberBtn3.TabIndex = 11;
            this.numberBtn3.Text = "3";
            this.numberBtn3.UseVisualStyleBackColor = true;
            this.numberBtn3.Click += new System.EventHandler(this.numberBtn3_Click);
            // 
            // numberBtn2
            // 
            this.numberBtn2.Location = new System.Drawing.Point(102, 250);
            this.numberBtn2.Name = "numberBtn2";
            this.numberBtn2.Size = new System.Drawing.Size(83, 63);
            this.numberBtn2.TabIndex = 10;
            this.numberBtn2.Text = "2";
            this.numberBtn2.UseVisualStyleBackColor = true;
            this.numberBtn2.Click += new System.EventHandler(this.numberBtn2_Click);
            // 
            // numberBtn1
            // 
            this.numberBtn1.Location = new System.Drawing.Point(13, 250);
            this.numberBtn1.Name = "numberBtn1";
            this.numberBtn1.Size = new System.Drawing.Size(83, 63);
            this.numberBtn1.TabIndex = 9;
            this.numberBtn1.Text = "1";
            this.numberBtn1.UseVisualStyleBackColor = true;
            this.numberBtn1.Click += new System.EventHandler(this.numberBtn1_Click);
            // 
            // subtractionBtn
            // 
            this.subtractionBtn.Location = new System.Drawing.Point(280, 319);
            this.subtractionBtn.Name = "subtractionBtn";
            this.subtractionBtn.Size = new System.Drawing.Size(83, 63);
            this.subtractionBtn.TabIndex = 16;
            this.subtractionBtn.Text = "-";
            this.subtractionBtn.UseVisualStyleBackColor = true;
            this.subtractionBtn.Click += new System.EventHandler(this.subtractionBtn_Click);
            // 
            // numberBtn6
            // 
            this.numberBtn6.Location = new System.Drawing.Point(191, 319);
            this.numberBtn6.Name = "numberBtn6";
            this.numberBtn6.Size = new System.Drawing.Size(83, 63);
            this.numberBtn6.TabIndex = 15;
            this.numberBtn6.Text = "6";
            this.numberBtn6.UseVisualStyleBackColor = true;
            this.numberBtn6.Click += new System.EventHandler(this.numberBtn6_Click);
            // 
            // numberBtn5
            // 
            this.numberBtn5.Location = new System.Drawing.Point(102, 319);
            this.numberBtn5.Name = "numberBtn5";
            this.numberBtn5.Size = new System.Drawing.Size(83, 63);
            this.numberBtn5.TabIndex = 14;
            this.numberBtn5.Text = "5";
            this.numberBtn5.UseVisualStyleBackColor = true;
            this.numberBtn5.Click += new System.EventHandler(this.numberBtn5_Click);
            // 
            // numberBtn4
            // 
            this.numberBtn4.Location = new System.Drawing.Point(13, 319);
            this.numberBtn4.Name = "numberBtn4";
            this.numberBtn4.Size = new System.Drawing.Size(83, 63);
            this.numberBtn4.TabIndex = 13;
            this.numberBtn4.Text = "4";
            this.numberBtn4.UseVisualStyleBackColor = true;
            this.numberBtn4.Click += new System.EventHandler(this.numberBtn4_Click);
            // 
            // summationBtn
            // 
            this.summationBtn.Location = new System.Drawing.Point(280, 388);
            this.summationBtn.Name = "summationBtn";
            this.summationBtn.Size = new System.Drawing.Size(83, 63);
            this.summationBtn.TabIndex = 20;
            this.summationBtn.Text = "+";
            this.summationBtn.UseVisualStyleBackColor = true;
            this.summationBtn.Click += new System.EventHandler(this.summationBtn_Click);
            // 
            // numberBtn9
            // 
            this.numberBtn9.Location = new System.Drawing.Point(191, 388);
            this.numberBtn9.Name = "numberBtn9";
            this.numberBtn9.Size = new System.Drawing.Size(83, 63);
            this.numberBtn9.TabIndex = 19;
            this.numberBtn9.Text = "9";
            this.numberBtn9.UseVisualStyleBackColor = true;
            this.numberBtn9.Click += new System.EventHandler(this.numberBtn9_Click);
            // 
            // numberBtn8
            // 
            this.numberBtn8.Location = new System.Drawing.Point(102, 388);
            this.numberBtn8.Name = "numberBtn8";
            this.numberBtn8.Size = new System.Drawing.Size(83, 63);
            this.numberBtn8.TabIndex = 18;
            this.numberBtn8.Text = "8";
            this.numberBtn8.UseVisualStyleBackColor = true;
            this.numberBtn8.Click += new System.EventHandler(this.numberBtn8_Click);
            // 
            // numberBtn7
            // 
            this.numberBtn7.Location = new System.Drawing.Point(13, 388);
            this.numberBtn7.Name = "numberBtn7";
            this.numberBtn7.Size = new System.Drawing.Size(83, 63);
            this.numberBtn7.TabIndex = 17;
            this.numberBtn7.Text = "7";
            this.numberBtn7.UseVisualStyleBackColor = true;
            this.numberBtn7.Click += new System.EventHandler(this.numberBtn7_Click);
            // 
            // resultBtn
            // 
            this.resultBtn.Location = new System.Drawing.Point(280, 457);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(83, 63);
            this.resultBtn.TabIndex = 24;
            this.resultBtn.Text = "=";
            this.resultBtn.UseVisualStyleBackColor = true;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // periodBtn
            // 
            this.periodBtn.Location = new System.Drawing.Point(191, 457);
            this.periodBtn.Name = "periodBtn";
            this.periodBtn.Size = new System.Drawing.Size(83, 63);
            this.periodBtn.TabIndex = 23;
            this.periodBtn.Text = ",";
            this.periodBtn.UseVisualStyleBackColor = true;
            this.periodBtn.Click += new System.EventHandler(this.periodBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Location = new System.Drawing.Point(102, 457);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(83, 63);
            this.zeroBtn.TabIndex = 22;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // resultReverseBtn
            // 
            this.resultReverseBtn.Location = new System.Drawing.Point(13, 457);
            this.resultReverseBtn.Name = "resultReverseBtn";
            this.resultReverseBtn.Size = new System.Drawing.Size(83, 63);
            this.resultReverseBtn.TabIndex = 21;
            this.resultReverseBtn.Text = "+/-";
            this.resultReverseBtn.UseVisualStyleBackColor = true;
            this.resultReverseBtn.Click += new System.EventHandler(this.resultReverseBtn_Click);
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputBox.Cursor = System.Windows.Forms.Cursors.No;
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputBox.Location = new System.Drawing.Point(190, 12);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.ReadOnly = true;
            this.inputBox.Size = new System.Drawing.Size(173, 47);
            this.inputBox.TabIndex = 25;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(380, 538);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.periodBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.resultReverseBtn);
            this.Controls.Add(this.summationBtn);
            this.Controls.Add(this.numberBtn9);
            this.Controls.Add(this.numberBtn8);
            this.Controls.Add(this.numberBtn7);
            this.Controls.Add(this.subtractionBtn);
            this.Controls.Add(this.numberBtn6);
            this.Controls.Add(this.numberBtn5);
            this.Controls.Add(this.numberBtn4);
            this.Controls.Add(this.multiplicationBtn);
            this.Controls.Add(this.numberBtn3);
            this.Controls.Add(this.numberBtn2);
            this.Controls.Add(this.numberBtn1);
            this.Controls.Add(this.divisionBtn);
            this.Controls.Add(this.rootBtn);
            this.Controls.Add(this.squareBtn);
            this.Controls.Add(this.reciprocalBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.clearEntryBtn);
            this.Controls.Add(this.percentBtn);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Yeni font ayarları
            Font newFont = new Font("Arial", 14, FontStyle.Bold);

            // Tüm kontrollerin üzerinden geç ve font ayarlarını değiştir
            foreach (Control control in Controls)
            {
                control.Font = newFont;
            }
        }
        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button percentBtn;
        private System.Windows.Forms.Button clearEntryBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button divisionBtn;
        private System.Windows.Forms.Button rootBtn;
        private System.Windows.Forms.Button squareBtn;
        private System.Windows.Forms.Button reciprocalBtn;
        private System.Windows.Forms.Button multiplicationBtn;
        private System.Windows.Forms.Button numberBtn3;
        private System.Windows.Forms.Button numberBtn2;
        private System.Windows.Forms.Button numberBtn1;
        private System.Windows.Forms.Button subtractionBtn;
        private System.Windows.Forms.Button numberBtn6;
        private System.Windows.Forms.Button numberBtn5;
        private System.Windows.Forms.Button numberBtn4;
        private System.Windows.Forms.Button summationBtn;
        private System.Windows.Forms.Button numberBtn9;
        private System.Windows.Forms.Button numberBtn8;
        private System.Windows.Forms.Button numberBtn7;
        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.Button periodBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button resultReverseBtn;
        private TextBox inputBox;
    }

}


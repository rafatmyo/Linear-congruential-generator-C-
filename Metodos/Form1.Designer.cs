namespace Metodos
{
    partial class Mixto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnGen = new System.Windows.Forms.Button();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.txtIt = new System.Windows.Forms.TextBox();
            this.bttnClear = new System.Windows.Forms.Button();
            this.randomNums = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Método Congruencial mixto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "seed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "mod";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "c";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "a";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "iterar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bttnGen
            // 
            this.bttnGen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttnGen.Location = new System.Drawing.Point(291, 117);
            this.bttnGen.Name = "bttnGen";
            this.bttnGen.Padding = new System.Windows.Forms.Padding(2);
            this.bttnGen.Size = new System.Drawing.Size(75, 23);
            this.bttnGen.TabIndex = 6;
            this.bttnGen.Text = "Generate";
            this.bttnGen.UseVisualStyleBackColor = true;
            this.bttnGen.Click += new System.EventHandler(this.bttnGen_Click);
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(61, 87);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(40, 20);
            this.txtSeed.TabIndex = 7;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(61, 113);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(40, 20);
            this.txtA.TabIndex = 8;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(61, 139);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(40, 20);
            this.txtC.TabIndex = 9;
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(61, 165);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(40, 20);
            this.txtMod.TabIndex = 10;
            // 
            // txtIt
            // 
            this.txtIt.Location = new System.Drawing.Point(61, 191);
            this.txtIt.Name = "txtIt";
            this.txtIt.Size = new System.Drawing.Size(40, 20);
            this.txtIt.TabIndex = 11;
            // 
            // bttnClear
            // 
            this.bttnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttnClear.Location = new System.Drawing.Point(291, 166);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Padding = new System.Windows.Forms.Padding(2);
            this.bttnClear.Size = new System.Drawing.Size(75, 23);
            this.bttnClear.TabIndex = 13;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // randomNums
            // 
            this.randomNums.Location = new System.Drawing.Point(127, 87);
            this.randomNums.Multiline = true;
            this.randomNums.Name = "randomNums";
            this.randomNums.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.randomNums.Size = new System.Drawing.Size(143, 208);
            this.randomNums.TabIndex = 14;
            this.randomNums.TextChanged += new System.EventHandler(this.randomNums_TextChanged);
            // 
            // Mixto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(397, 307);
            this.Controls.Add(this.randomNums);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.txtIt);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.bttnGen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mixto";
            this.Text = "Método Congruencial mixto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnGen;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.TextBox txtIt;
        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.TextBox randomNums;
    }
}


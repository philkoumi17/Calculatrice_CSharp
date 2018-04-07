namespace Calculatrice
{
    partial class frmCalculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxRes = new System.Windows.Forms.TextBox();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnVirgule = new System.Windows.Forms.Button();
            this.btnEgal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnRacineCarree = new System.Windows.Forms.Button();
            this.btnByTwo = new System.Windows.Forms.Button();
            this.btnByFour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxRes
            // 
            this.txtBoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRes.Location = new System.Drawing.Point(12, 12);
            this.txtBoxRes.Name = "txtBoxRes";
            this.txtBoxRes.Size = new System.Drawing.Size(299, 35);
            this.txtBoxRes.TabIndex = 0;
            this.txtBoxRes.Text = "0";
            this.txtBoxRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxRes_KeyPress);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(12, 171);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(55, 47);
            this.btnSeven.TabIndex = 1;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(73, 171);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(55, 47);
            this.btnEight.TabIndex = 2;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(134, 171);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(55, 47);
            this.btnNine.TabIndex = 3;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(195, 171);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(55, 47);
            this.btnMultiplication.TabIndex = 4;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(12, 118);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(55, 47);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(73, 118);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(55, 47);
            this.btnFive.TabIndex = 6;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(134, 118);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(55, 47);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(195, 65);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(55, 47);
            this.btnPlus.TabIndex = 8;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(12, 65);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(55, 47);
            this.btnOne.TabIndex = 9;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(73, 65);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(55, 47);
            this.btnTwo.TabIndex = 10;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(134, 65);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(55, 47);
            this.btnThree.TabIndex = 11;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            // 
            // btnMoins
            // 
            this.btnMoins.Location = new System.Drawing.Point(195, 118);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(55, 47);
            this.btnMoins.TabIndex = 12;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(12, 228);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(55, 47);
            this.btnZero.TabIndex = 14;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            // 
            // btnVirgule
            // 
            this.btnVirgule.Location = new System.Drawing.Point(73, 228);
            this.btnVirgule.Name = "btnVirgule";
            this.btnVirgule.Size = new System.Drawing.Size(55, 47);
            this.btnVirgule.TabIndex = 15;
            this.btnVirgule.Text = ".";
            this.btnVirgule.UseVisualStyleBackColor = true;
            this.btnVirgule.Click += new System.EventHandler(this.btnVirgule_Click);
            // 
            // btnEgal
            // 
            this.btnEgal.Location = new System.Drawing.Point(134, 228);
            this.btnEgal.Name = "btnEgal";
            this.btnEgal.Size = new System.Drawing.Size(55, 47);
            this.btnEgal.TabIndex = 16;
            this.btnEgal.Text = "=";
            this.btnEgal.UseVisualStyleBackColor = true;
            this.btnEgal.Click += new System.EventHandler(this.btnEgal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(256, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 47);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(195, 228);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(55, 47);
            this.btnDivision.TabIndex = 18;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnRacineCarree
            // 
            this.btnRacineCarree.Location = new System.Drawing.Point(256, 118);
            this.btnRacineCarree.Name = "btnRacineCarree";
            this.btnRacineCarree.Size = new System.Drawing.Size(55, 47);
            this.btnRacineCarree.TabIndex = 19;
            this.btnRacineCarree.Text = "√";
            this.btnRacineCarree.UseVisualStyleBackColor = true;
            this.btnRacineCarree.Click += new System.EventHandler(this.btnRacineCarree_Click);
            // 
            // btnByTwo
            // 
            this.btnByTwo.Location = new System.Drawing.Point(256, 171);
            this.btnByTwo.Name = "btnByTwo";
            this.btnByTwo.Size = new System.Drawing.Size(55, 47);
            this.btnByTwo.TabIndex = 20;
            this.btnByTwo.Text = "½";
            this.btnByTwo.UseVisualStyleBackColor = true;
            this.btnByTwo.Click += new System.EventHandler(this.btnByTwo_Click);
            // 
            // btnByFour
            // 
            this.btnByFour.Location = new System.Drawing.Point(256, 228);
            this.btnByFour.Name = "btnByFour";
            this.btnByFour.Size = new System.Drawing.Size(55, 47);
            this.btnByFour.TabIndex = 21;
            this.btnByFour.Text = "¼";
            this.btnByFour.UseVisualStyleBackColor = true;
            this.btnByFour.Click += new System.EventHandler(this.btnByFour_Click);
            // 
            // frmCalculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(321, 290);
            this.Controls.Add(this.btnByFour);
            this.Controls.Add(this.btnByTwo);
            this.Controls.Add(this.btnRacineCarree);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEgal);
            this.Controls.Add(this.btnVirgule);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.txtBoxRes);
            this.Name = "frmCalculatrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.frmCalculatrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxRes;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnVirgule;
        private System.Windows.Forms.Button btnEgal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnRacineCarree;
        private System.Windows.Forms.Button btnByTwo;
        private System.Windows.Forms.Button btnByFour;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class frmCalculatrice : Form
    {
        private string operand1 = string.Empty, operand2 = string.Empty, result;
        private int nbVirgules = 0;
        private char operation;

        public frmCalculatrice()
        {
            InitializeComponent();
        }

        private void frmCalculatrice_Load(object sender, EventArgs e)
        {
            btnOne.Click += new EventHandler(btn_Click);
            btnTwo.Click += new EventHandler(btn_Click);
            btnThree.Click += new EventHandler(btn_Click);
            btnFour.Click += new EventHandler(btn_Click);
            btnFive.Click += new EventHandler(btn_Click);
            btnSix.Click += new EventHandler(btn_Click);
            btnSeven.Click += new EventHandler(btn_Click);
            btnEight.Click += new EventHandler(btn_Click);
            btnNine.Click += new EventHandler(btn_Click);
            btnZero.Click += new EventHandler(btn_Click);
            btnVirgule.Click += new EventHandler(btn_Click);
        }

        void btn_Click(object sender, EventArgs e)
        {
            if(txtBoxRes.Text == "0")
            {
                txtBoxRes.Clear();
            }

            try
            {
                Button btn = sender as Button;

                switch(btn.Name)
                {
                    case "btnOne":
                        txtBoxRes.Text += "1";
                        break;
                    case "btnTwo":
                        txtBoxRes.Text += "2";
                        break;
                    case "btnThree":
                        txtBoxRes.Text += "3";
                        break;
                    case "btnFour":
                        txtBoxRes.Text += "4";
                        break;
                    case "btnFive":
                        txtBoxRes.Text += "5";
                        break;
                    case "btnSix":
                        txtBoxRes.Text += "6";
                        break;
                    case "btnSeven":
                        txtBoxRes.Text += "7";
                        break;
                    case "btnEight":
                        txtBoxRes.Text += "8";
                        break;
                    case "btnNine":
                        txtBoxRes.Text += "9";
                        break;
                    case "btnZero":
                        txtBoxRes.Text += "0";
                        break;
                    case "btnDot":
                        if(!txtBoxRes.Text.Contains("."))
                        {
                            txtBoxRes.Text += ".";
                        }
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Désolé pour le désagrément, une erreur inattendue s'est produite. Détails: " + ex.Message);
            }
        }

        private void txtBoxRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Uniquement les nombres, +, -, ., *, / sont autorisés");
                    break;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operand1 = txtBoxRes.Text;
            operation = '+';
            txtBoxRes.Text = string.Empty;
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            operand1 = txtBoxRes.Text;
            operation = '-';
            txtBoxRes.Text = string.Empty;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operand1 = txtBoxRes.Text;
            operation = '*';
            txtBoxRes.Text = string.Empty;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operand1 = txtBoxRes.Text;
            operation = '/';
            txtBoxRes.Text = string.Empty;
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            operand2 = txtBoxRes.Text;

            double opr1, opr2;
            double.TryParse(operand1, out opr1);
            double.TryParse(operand2, out opr2);

            switch(operation)
            {
                case '+':
                    result = (opr1 + opr2).ToString();
                    break;

                case '-':
                    result = (opr1 - opr2).ToString();
                    break;

                case '*':
                    result = (opr1 * opr2).ToString();
                    break;

                case '/':
                    if(opr2 != 0)
                    {
                        result = (opr1 / opr2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Can't divide by zero");
                    }
                    break;
            }

            txtBoxRes.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxRes.Text = "0";
            operand1 = string.Empty;
            operand2 = string.Empty;
            nbVirgules = 0;
            result = "0";
        }

        private void btnRacineCarree_Click(object sender, EventArgs e)
        {
            double opr1;
            if(double.TryParse(txtBoxRes.Text, out opr1))
            {
                txtBoxRes.Text = (Math.Sqrt(opr1)).ToString();
            }
        }

        private void btnByTwo_Click(object sender, EventArgs e)
        {
            double opr1;
            if(double.TryParse(txtBoxRes.Text, out opr1))
            {
                txtBoxRes.Text = (opr1 / 2).ToString();
            }
        }

        private void btnByFour_Click(object sender, EventArgs e)
        {
            double opr1;
            if(double.TryParse(txtBoxRes.Text, out opr1))
            {
                txtBoxRes.Text = (opr1 / 4).ToString();
            }
        }

        private void btnVirgule_Click(object sender, EventArgs e)
        {
            if(nbVirgules == 0 && !txtBoxRes.Text.Equals(""))
            {
                txtBoxRes.Text += ".";
                nbVirgules++;
            }
        }
    }
}
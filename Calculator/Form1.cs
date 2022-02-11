using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool isoperatordone = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_click(object sender, EventArgs e)
        {
            if (textBox_result.Text == "0" || (isoperatordone))
                textBox_result.Clear();
            isoperatordone = false;
            Button button = (Button)sender; // instead of repeated func to all numbers make a sender button
            if (button.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                    textBox_result.Text = textBox_result.Text + button.Text; 
            }
            else

            textBox_result.Text = textBox_result.Text + button.Text;
            
        }
        double result=0;
        string operation = "";
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(result != 0)
            {
                buttonEqual.PerformClick(); 
                operation = button.Text;
               // result = double.Parse(textBox_result.Text);
                labelCurrentoperation.Text = result + " " + operation;
                isoperatordone = true;
            }else 
            operation= button.Text;
            result=double.Parse(textBox_result.Text);
            labelCurrentoperation.Text = result + " " + operation;
            isoperatordone = true;
            
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            labelCurrentoperation.Text = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            result = 0;
            labelCurrentoperation.Text="";
        }
        
        private void button_equal(object sender, EventArgs e)
        {
            
            switch(operation)
            {
                case "+":
                   // textBox_result.Clear();
                    textBox_result.Text=(result + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                 //   textBox_result.Clear();
                    textBox_result.Text = (result - Double.Parse(textBox_result.Text)).ToString();
                    break;
                    case "*":
                   // textBox_result.Clear();
                    textBox_result.Text = (result * Double.Parse(textBox_result.Text)).ToString();
                    break;
                    case "/":
                    //textBox_result.Clear();
                    
                    textBox_result.Text = (result / Double.Parse(textBox_result.Text)).ToString();
                    break ;
                default:
                    break;

            }
        }
    }
}

using System.Globalization;

namespace Complex_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool click;             
        double num1;          
        string operation = "";   

        

        private void button11_Click(object sender, EventArgs e)   
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 1;
        }
        private void button12_Click(object sender, EventArgs e)  
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 2;
        }
        private void button13_Click(object sender, EventArgs e)   
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 3;
        }
        private void button14_Click(object sender, EventArgs e)   
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 4;
        }
        private void button5_Click(object sender, EventArgs e)    
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 5;
        }
        private void button6_Click(object sender, EventArgs e)    
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 6;
        }
        private void button7_Click(object sender, EventArgs e)    
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 7;
        }
        private void button8_Click(object sender, EventArgs e)    
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 8;
        }
        private void button9_Click(object sender, EventArgs e)   
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 9;
        }
        private void button16_Click(object sender, EventArgs e)   
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 0;
            if (richTextBox1.Text == "00")   
            {
                richTextBox1.Text = "0";
            }
        }

    

        private void button10_Click(object sender, EventArgs e)   
        {
            richTextBox1.Text = "0";
            num1 = 0;
            operation = "";
            click = false;
            listBox1.Items.Clear();
        }
        private void button15_Click(object sender, EventArgs e)  
        {
            if (richTextBox1.Text.Length > 1)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
                if (richTextBox1.Text == "-")
                {
                    richTextBox1.Text = "0";
                }
            }
            else
            {
                richTextBox1.Text = "0";
            }
        }

        

        private void button17_Click(object sender, EventArgs e)  
        {
            if (richTextBox1.Text == "0" || string.IsNullOrEmpty(richTextBox1.Text))
            {
                return;
            }
            if (richTextBox1.Text.StartsWith("-"))
            {
                richTextBox1.Text = richTextBox1.Text.Substring(1);
            }
            else
            {
                richTextBox1.Text = "-" + richTextBox1.Text;
            }
        }

       

        private void button1_Click(object sender, EventArgs e)   
        {
            SetOperation("+");
        }
        private void button2_Click(object sender, EventArgs e)  
        {
            SetOperation("-");
        }
        private void button3_Click(object sender, EventArgs e)   
        {
            SetOperation("*");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SetOperation("/");
        }

        private void SetOperation(string op)
        {
           
            if (operation != "" && !click)
            {
                if (!Calculate())
                {
                    return;
                }
            }
            if (!double.TryParse(richTextBox1.Text, CultureInfo.InvariantCulture, out num1))
            {
                num1 = 0;
            }
            operation = op;
            click = true;
        }

        

        private void button18_Click(object sender, EventArgs e)  
        {
            if (!double.TryParse(richTextBox1.Text, CultureInfo.InvariantCulture, out double x))
            {
                return;
            }
            if (x < 0)
            {
                MessageBox.Show("Mənfi ədədin kökü tapılmır!");
                return;
            }
            double result = Math.Sqrt(x);
            listBox1.Items.Add("√" + Format(x) + " = " + Format(result));
            richTextBox1.Text = Format(result);
            click = true;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(richTextBox1.Text, CultureInfo.InvariantCulture, out double x))
            {
                return;
            }
            double result = x * x;
            listBox1.Items.Add(Format(x) + "² = " + Format(result));
            richTextBox1.Text = Format(result);
            click = true;
        }

       

        private void button20_Click(object sender, EventArgs e) 
        {
            if (operation == "")
            {
                return;
            }
            if (Calculate())
            {
                operation = "";
                click = true;
            }
        }

        
        private bool Calculate()
        {
            if (!double.TryParse(richTextBox1.Text, CultureInfo.InvariantCulture, out double num2))
            {
                return false;
            }
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("0-a bölmək olmaz!");
                        richTextBox1.Text = "0";
                        num1 = 0;
                        operation = "";
                        click = false;
                        return false;
                    }
                    result = num1 / num2;
                    break;
            }

            listBox1.Items.Add(Format(num1) + " " + operation + " " + Format(num2) + " = " + Format(result));
            richTextBox1.Text = Format(result);
            num1 = result;
            click = true;
            return true;
        }

        private string Format(double value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }
    }
}

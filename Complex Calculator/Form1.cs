using System.Globalization;

namespace Complex_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool click;              // operator ve ya "=" basildiqdan sonra yeni eded yazilmalidir
        double num1;             // birinci eded
        string operation = "";   // secilmis emeliyyat (+, -, *, /)

        // ---------------- RƏQƏM DÜYMƏLƏRİ ----------------

        private void button11_Click(object sender, EventArgs e)   // 1
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
        private void button12_Click(object sender, EventArgs e)   // 2
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
        private void button13_Click(object sender, EventArgs e)   // 3
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
        private void button14_Click(object sender, EventArgs e)   // 4
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
        private void button5_Click(object sender, EventArgs e)    // 5
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
        private void button6_Click(object sender, EventArgs e)    // 6
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
        private void button7_Click(object sender, EventArgs e)    // 7
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
        private void button8_Click(object sender, EventArgs e)    // 8
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
        private void button9_Click(object sender, EventArgs e)    // 9
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
        private void button16_Click(object sender, EventArgs e)   // 0
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
            if (richTextBox1.Text == "00")   // 0 üçün "00" yazılmasın
            {
                richTextBox1.Text = "0";
            }
        }

        // ---------------- C və <-- ----------------

        private void button10_Click(object sender, EventArgs e)   // C
        {
            richTextBox1.Text = "0";
            num1 = 0;
            operation = "";
            click = false;
            listBox1.Items.Clear();
        }
        private void button15_Click(object sender, EventArgs e)   // <--
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

        // ---------------- İŞARƏ DƏYİŞ (-) ----------------

        private void button17_Click(object sender, EventArgs e)   // +/-
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

        // ---------------- ƏMƏLİYYAT DÜYMƏLƏRİ ----------------

        private void button1_Click(object sender, EventArgs e)    // +
        {
            SetOperation("+");
        }
        private void button2_Click(object sender, EventArgs e)    // -
        {
            SetOperation("-");
        }
        private void button3_Click(object sender, EventArgs e)    // *
        {
            SetOperation("*");
        }
        private void button4_Click(object sender, EventArgs e)    // /
        {
            SetOperation("/");
        }

        private void SetOperation(string op)
        {
            // Əgər artıq əməliyyat seçilibsə və ikinci ədəd yazılıbsa, əvvəlcə onu hesabla
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

        // ---------------- Sqrt, x^2 ----------------

        private void button18_Click(object sender, EventArgs e)   // Sqrt
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
        private void button19_Click(object sender, EventArgs e)   // x^2
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

        // ---------------- = ----------------

        private void button20_Click(object sender, EventArgs e)   // =
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

        // ---------------- HESABLAMA ----------------

        // Uğurlu olarsa true, xəta olarsa (məs. 0-a bölmə) false qaytarır
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

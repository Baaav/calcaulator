namespace calcaulator
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result;
        bool isop=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text == "0"||isop==true) { textBox1.Clear(); }
            if (btn.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            }
            else {

                textBox1.Text = textBox1.Text + btn.Text;
            }isop = false; }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            result = double.Parse(textBox1.Text);
            isop = true;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "X":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }
    }
}
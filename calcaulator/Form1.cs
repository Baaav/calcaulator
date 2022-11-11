namespace calcaulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text+ btn.Text ;
        }
    }
}
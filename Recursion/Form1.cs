namespace Recursion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int FactorialCalculation(int n)
        {
            if (n == 0 || n == 1) 
                return 1;
            else
                return n * FactorialCalculation(n - 1);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int numbre = int.Parse(txtNumber.Text);

                if (numbre < 0)
                {
                    MessageBox.Show("Please enter a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int result = FactorialCalculation(numbre);
                    lblResult.Text = "Result:" + result ;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

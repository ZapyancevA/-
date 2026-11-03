namespace WinFormsApp1i_307a
{
    public partial class Calculator : Form
    {

        double firstNumber = 0;
        double secondNumber = 0;
        string currentOperation = "";
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnNumdersAction_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (btn.Text == "," && txtDisplay.Text.Contains(","))
            {
                return;
            }
            txtDisplay.Text += btn.Text;


            //if (txtDisplay.Text.IndexOf(",") == 0)
            //    return;

            //txtDisplay.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            currentOperation = "";
            isOperationPerformed = false;
        }

    }

}



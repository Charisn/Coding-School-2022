namespace Session_06
{
    public partial class Form1 : Form
    {
        bool operandPerformed = false;
        string operand = "";
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void NumEvent(object sender, EventArgs e)
        {
            if (textResult.Text == "0" || operandPerformed )
            {
                textResult.Clear();
            }

            Button btn= (Button)sender;
            this.textResult.Text += btn.Text;
            operandPerformed = false;
        }

        private void OperandEvent(object sender, EventArgs e)
        {
            operandPerformed = true;
            Button btn= (Button)sender;
            string newOperand = btn.Text;

            lbResult.Text = lbResult.Text + " " + textResult.Text + " " + newOperand;

            switch (operand)

            {
                case "+": 
                    textResult.Text = (result + Double.Parse(textResult.Text)).ToString(); 
                    break;
                case "-": 
                    textResult.Text = (result - Double.Parse(textResult.Text)).ToString(); 
                    break;
                case "/": 
                    textResult.Text = (result / Double.Parse(textResult.Text)).ToString(); 
                    break;
                case "*": 
                    textResult.Text = (result * Double.Parse(textResult.Text)).ToString(); 
                    break;
                case "nⁿ":
                    textResult.Text = Math.Pow(result, Double.Parse(textResult.Text)).ToString();
                    break;
                case "√":
                    textResult.Text = Math.Sqrt(Double.Parse(textResult.Text)).ToString();
                    break;
                default: break;
            }

            result = Double.Parse(textResult.Text);
            operand = newOperand;

        }

        private void C_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
            lbResult.Text = "";
            result = 0;
            operand = "";

        }

        private void Results_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            operandPerformed = true;
            switch (operand)
            {
                case "+": 
                    textResult.Text = (result + Double.Parse(textResult.Text)).ToString(); 
                    break;
                case "-": 
                    textResult.Text = (result - Double.Parse(textResult.Text)).ToString(); 
                    break;
                case "/": 
                    textResult.Text = (result / Double.Parse(textResult.Text)).ToString(); 
                    break;
                case "*": 
                    textResult.Text = (result * Double.Parse(textResult.Text)).ToString(); 
                    break;
                case "nⁿ":
                    textResult.Text = Math.Pow(result , Double.Parse(textResult.Text)).ToString(); 
                    break;
                case "√":
                    textResult.Text =  Math.Sqrt(Double.Parse(textResult.Text)).ToString() ; 
                    break;
                default: break;
            }
            result = Double.Parse(textResult.Text);
            textResult.Text = result.ToString();
            result = 0;
            operand = "";

        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (!operandPerformed && !textResult.Text.Contains(","))
            {
                textResult.Text += ",";
            }
            else if (operandPerformed)
            {
                textResult.Text = "0";
            }

            if (!textResult.Text.Contains(','))
            {
                textResult.Text += ",";
            }

            operandPerformed = false;
        }
    }
}
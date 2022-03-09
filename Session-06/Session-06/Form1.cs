namespace Session_06 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        Calculator.CalcType calcType;
        int numbers = 0;
        bool newNumber = true;
        bool dot = false;




        private void buttonAdd_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "+";
            calcType = Calculator.CalcType.Add;
            ButtonsDisabler();
            newNumber = true;
            dot = false;
        }

        private void buttonSubtraction_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "-";
            calcType = Calculator.CalcType.Sub;
            ButtonsDisabler();
            //buttonEquals.Enabled = true;
            newNumber = true;
        }


        private void buttonDivision_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "/";
            calcType = Calculator.CalcType.Divide;
            ButtonsDisabler();
            //buttonEquals.Enabled = true;
            newNumber = true;
        }


        private void buttonMultiplication_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "*";
            calcType = Calculator.CalcType.Multiply;
            ButtonsDisabler();
            //buttonEquals.Enabled = true;
            newNumber = true;
        }
        private void buttonPower_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "p";
            calcType = Calculator.CalcType.Power;
            ButtonsDisabler();
            //buttonEquals.Enabled = true;
            newNumber = true;
        }

        private void buttonRoot_Click(object sender, EventArgs e) {
            calcType = Calculator.CalcType.Root;
            ButtonsDisabler();
            Calculator.Factory f = new Calculator.Factory(this.textBoxScreen.Text, calcType);
            textBoxScreen.Text = f.CalcResolver();
            ButtonsEnabler();
            newNumber = true;
            //buttonEquals.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e) {

        }

        private void buttonEquals_Click(object sender, EventArgs e) {
            Calculator.Factory f = new Calculator.Factory(this.textBoxScreen.Text, calcType);
            textBoxScreen.Text = f.CalcResolver();
            ButtonsEnabler();
            numbers = 1;
            buttonEquals.Enabled = false;




        }


        public void ButtonsDisabler() {

            this.buttonAddition.Enabled = false;
            this.buttonDivision.Enabled = false;
            this.buttonMultiplication.Enabled = false;
            this.buttonSubtraction.Enabled = false;
            this.buttonPower.Enabled = false;
            this.buttonRoot.Enabled = false;

        }

        public void ButtonsEnabler() {

            this.buttonAddition.Enabled = true;
            this.buttonDivision.Enabled = true;
            this.buttonMultiplication.Enabled = true;
            this.buttonSubtraction.Enabled = true;
            this.buttonPower.Enabled = true;
            this.buttonRoot.Enabled = true;

        }



        private void button1_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "1";

            if (newNumber) {
                numbers++;
                newNumber = false;
            }

            if (numbers == 2) {
                buttonEquals.Enabled = true;
            }


        }

        private void button5_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "6";
            ButtonsKeyLogic();

        }

        private void button7_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "8";
            ButtonsKeyLogic();

        }

        private void Button1_Click_1(object sender, EventArgs e) {
            this.textBoxScreen.Text += "0";
            ButtonsKeyLogic();
        }
        private void buttonNumber2_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "2";
            ButtonsKeyLogic();

        }

        private void buttonNumber3_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "3";
            ButtonsKeyLogic();

        }

        private void buttonNumber4_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "4";
            ButtonsKeyLogic();

        }

        private void buttonNumber5_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "5";
            ButtonsKeyLogic();

        }

        private void buttonNumber7_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "7";
            ButtonsKeyLogic();

        }

        private void buttonNumber9_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "9";
            ButtonsKeyLogic();

        }

 




        private void button1_Click_2(object sender, EventArgs e) {
            this.textBoxScreen.Text = string.Empty;
            ButtonsEnabler();

        }




        private void ButtonsKeyLogic() {
            if (newNumber) {
                numbers++;
                newNumber = false;
                
            }

            if (numbers == 2) {
                buttonEquals.Enabled = true;
            }
        }

        private void buttonDot_Click(object sender, EventArgs e) {
            if (dot==false) {
                this.textBoxScreen.Text += ".";
                dot = true;
                ButtonsKeyLogic();
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
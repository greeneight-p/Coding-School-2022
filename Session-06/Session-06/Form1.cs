namespace Session_06 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Calculator.CalcType calcType;
   

        private void button1_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "1";
          
        }

        private void button5_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "8";
        }

        private void button1_Click_1(object sender, EventArgs e) {
            this.textBoxScreen.Text += "0";
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "+";
            calcType = Calculator.CalcType.Add;
            ButtonsDisabler();
            buttonEquals.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void buttonEquals_Click(object sender, EventArgs e) {
            Calculator.Factory f = new Calculator.Factory(this.textBoxScreen.Text, calcType);
            textBoxScreen.Text = f.CalcResolver();
            ButtonsEnabler();
            
  

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




        private void buttonNumber2_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "2";
        }

        private void buttonNumber3_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "3";
        }

        private void buttonNumber4_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "4";
        }

        private void buttonNumber5_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "5";
        }

        private void buttonNumber7_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "7";
        }

        private void buttonNumber9_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "9";
        }

        private void buttonSubtraction_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "-";
            calcType = Calculator.CalcType.Sub;
            ButtonsDisabler();
            buttonEquals.Enabled = true;
        }

        private void buttonMultiplication_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "*";
            calcType = Calculator.CalcType.Multiply;
            ButtonsDisabler();
            buttonEquals.Enabled = true;
        }

        private void buttonDivision_Click(object sender, EventArgs e) {
            this.textBoxScreen.Text += "/";
            calcType = Calculator.CalcType.Divide;
            ButtonsDisabler();
            buttonEquals.Enabled = true;
        }

        private void button1_Click_2(object sender, EventArgs e) {
            this.textBoxScreen.Text = string.Empty;
            ButtonsEnabler();

        }
    }
}
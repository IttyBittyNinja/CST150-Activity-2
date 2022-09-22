// Jared L. Abrams// CST-150// September 18, 2022// 

namespace _ABRAMS__CST_150_Activity_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readInputButton_Click(object sender, EventArgs e) // Converts your entered weight on Earth to your calculated weight on Mars
        {
            double earthWeightInputDouble = double.Parse(earthWeightInput.Text);
            double marsWeightOutputDouble = earthWeightInputDouble * .38;
            string marsWeightOutputString = Convert.ToString(marsWeightOutputDouble);
            marsWeightOutput.Text = marsWeightOutputString;
        }
    }
}
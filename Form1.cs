namespace Vezba4._3c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(
            object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.Show("Obavezna je cifra!", 
                maskedTextBox1,
                0, -20, 2000);
        }

        private void maskedTextBox1_TypeValidationCompleted(
            object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Pogresan format!",
                    maskedTextBox1,
                    0, -20, 2000);
                maskedTextBox1.Focus();
            }
        }
    }
}

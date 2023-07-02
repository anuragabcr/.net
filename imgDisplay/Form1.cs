namespace imgDisplay
{
    public partial class Form1 : Form
    {
        private Image[] itemImages = { Properties.Resources.apple, Properties.Resources.banana, Properties.Resources.chikoo, Properties.Resources.grapes, Properties.Resources.orange, Properties.Resources.strawberry };
        private Int16[] prices = { 100, 200, 300, 150, 250, 350 };
        private String[] names = { "Apple", "Banana", "Chikoo", "Grapes", "Orange", "Strawberry" };
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index >= 0 && index < itemImages.Length)
            {
                pictureBox1.Image = itemImages[index];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index >= 0 && index < itemImages.Length)
            {
                label1.Text = "Price of 1 Kg " + names[index] + " is " + prices[index];
            }
        }
    }
}
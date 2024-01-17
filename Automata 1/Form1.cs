namespace Automata_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cad = textBox1.Text;
            ClaseDT obj = new ClaseDT();
            obj.dt1(cad);
        }
    }
}
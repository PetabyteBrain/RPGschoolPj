namespace C__Spiel_Janjao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start f2 = new Start();
            f2.ShowDialog();
        }

        // LÖSCH DENN Form1_Load NICHT SONST GEHT ES NICHT MEHR
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

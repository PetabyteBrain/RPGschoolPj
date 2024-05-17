namespace C__Spiel_Janjao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initializeTitle();
        }

        private void initializeTitle()
        {
            Label Title = new Label();
            Title.Location = new Point(200, 100);
            Title.AutoSize = true;
            Title.Font = new Font("Calibri", 18);
            Title.ForeColor = Color.Black;
            Title.Padding = new Padding(6);
            this.Controls.Add(Title);
            Title.Text = String.Format("TITLE");
            Title.Refresh();
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

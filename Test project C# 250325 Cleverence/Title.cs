namespace Test_project_C__250325_Cleverence
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            Form task1 = new Task1();
            Hide();
            task1.ShowDialog();
            Show();
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            Form task2 = new Task2();
            Hide();
            task2.ShowDialog();
            Show();
        }

        private void Title_Load(object sender, EventArgs e)
        {

        }
    }
}
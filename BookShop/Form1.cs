namespace BookShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.MdiParent = this;
            mainForm.Show();
        }

        private void ثبتگروهجدبدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupForm group = new GroupForm();
            group.MdiParent = this;
            group.Show();

        }

        private void ثبتکتابجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.MdiParent = this;
            bookForm.Show();
        }
    }
}
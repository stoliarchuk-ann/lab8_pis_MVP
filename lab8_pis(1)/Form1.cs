namespace lab8_pis_MVP
{
    public partial class Form1 : Form, ICourseView
    {
        private CoursePresenter presenter;
        public Form1()
        {
            InitializeComponent();
            presenter = new CoursePresenter(this, new CourseModel());
        }
        void ICourseView.SetEffective(double e)
        {
            label4.Text = e.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.LoadEffective(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }
            catch { };
        }
    }
}

using Busines.concrate;
using DataAccess.Concrate.EntitiyFramework;

namespace Rent_A_Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            markaLBL.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            yilLBL.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            renkLBL.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            ucretLBL.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            dataGridView1.DataSource = carManager.GetCarDetail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 admin = new Form2();
            this.Hide();
            admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
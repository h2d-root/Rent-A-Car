using Busines.concrate;
using DataAccess.Concrate.EntitiyFramework;
using Entities.concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            carManager.AddCar(new Car()
            {
                BrandId=Convert.ToInt32(brandIdTB.Text),
                ColorId=Convert.ToInt32(colorTb.Text),
                ModelYear = modelYearTb.Text,
                DailyPrice=Convert.ToInt32(dailyPriceTb.Text),
            });
            brandIdTB.Clear();
            colorTb.Clear();
            dailyPriceTb.Clear();
            modelYearTb.Clear();
            MessageBox.Show("ARAÇ VERİTABANINA EKLENDİ", "ADMİN");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            this.Close();
            form1.Show();
        }
    }
}

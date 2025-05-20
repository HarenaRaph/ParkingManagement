using Parking.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Form1 : Form
    {

        BindingList<Vehicle> listeVehicule = new BindingList<Vehicle>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = listeVehicule;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string typeVehicle = comboBox1.SelectedItem?.ToString();
            string owner = textBox1.Text;
            string numberPlate = textBox2.Text;
            string brand = textBox3.Text;
            string color = textBox4.Text;
            if (typeVehicle != "" && owner != "" && numberPlate != "" && brand != "" && color != "")
            {
                switch (typeVehicle)
                {
                    case "Voiture":
                        Car c = new Car(owner, numberPlate, brand, color);
                        listeVehicule.Add(c);
                        break;
                    case "Camion":
                        Truck t = new Truck(owner, numberPlate, brand, color);
                        listeVehicule.Add(t);
                        break;
                    case "Moto":
                        Moto m = new Moto(owner, numberPlate, brand, color);
                        listeVehicule.Add(m);
                        break;
                }
                
                
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }else
            {
                MessageBox.Show("Informations manquantes");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            string owner = row.Cells["Owner"].Value.ToString();

            Vehicle v = null;
            
            for(int i = 0; i < listeVehicule.Count; i++)
            {
                if (listeVehicule[i].Owner == owner)
                {
                    v = listeVehicule[i]; break;
                }
            }
            MessageBox.Show($"{v.Owner} doit payer {v.getFee()}Ar");
        }
    }
}

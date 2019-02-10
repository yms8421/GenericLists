using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BilgeAdam.GenericLists
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            var cities = new string[5] { "İstanbul", "Ankara", "İzmir", "Adana", "Bursa" };
            //cities[5] = "Diyarbakır";
            //cities[6] = "Gaziantep";
            //cities[7] = "Antalya";
            //cities[8] = "Samsun";
            lstCities.DataSource = cities;
            //foreach (var city in cities)
            //{
            //    lstCities.Items.Add(city);
            //}
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<string> cities = new List<string>();
            cities.Add("İstanbul");
            cities.Add("Kars");
            cities.Add("Ankara");
            cities.Add("İzmir");
            cities.Add("Adana");
            cities.Add("Bursa");
            cities.Add("Diyarbakır");
            cities.Add("Gaziantep");
            cities.Add("Samsun");

            cities.Insert(4, "Trabzon");
            //cities.Clear();
            lstCities.DataSource = cities;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var list = new List<string>();
            foreach (var name in comboBox1.Items)
            {
                var newName = name.ToString().ToUpper();
                list.Add(newName);
            }

            comboBox1.DataSource = list;
        }

        private void btnNumberList_Click(object sender, EventArgs e)
        {
            var numbers = new List<int>();
            var ages = new List<int> { 12, 5, 34, 2 };
            numbers.AddRange(ages);
            numbers.Add(3);
            numbers.Add(10);
            numbers.Add(4);
            
            //Remove, Find, 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            erpValidate.Clear();//hep hata gösteriyordu o sebeple temizlesin
            if (!lstCities.Items.Contains(txtName.Text))
            {
                lstCities.Items.Add(txtName.Text);
                txtName.Clear();
            }
            else
            {
                erpValidate.SetError(txtName, $"{txtName.Text}, zaten eklendi");
                //MessageBox.Show($"{txtName.Text}, zaten eklendi");
            }
        }
        HashSet<string> names = new HashSet<string>();
        private void btnAddUnique_Click(object sender, EventArgs e)
        {
            //Unique -> benzersiz
            names.Add(txtName.Text);
            lstCities.DataSource = names.ToList();
        }
    }
}

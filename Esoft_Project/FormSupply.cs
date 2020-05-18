using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstates();
            ShowSupplySet();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void ShowAgents()
        {
            comboBoxAgent.Items.Clear();
            foreach(Риелтор agentSet in Program.wftDb.Риелтор)
            {
                string[] item = { agentSet.Id.ToString() + ".", agentSet.MiddleName };
                comboBoxAgent.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClients()
        {
            comboBoxClient.Items.Clear();
            foreach(Клиент clientsSet in Program.wftDb.Клиент)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowRealEstates()
        {
            comboBoxRealEstate.Items.Clear();
            foreach(Недвижимость realEstateSet in Program.wftDb.Недвижимость)
            {
                string[] item = { realEstateSet.Id.ToString() + ".", realEstateSet.Address_City + ".", realEstateSet.Address_Street + "." };
                comboBoxRealEstate.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxAgent.SelectedItem!=null && comboBoxClient.SelectedItem!=null && comboBoxRealEstate.SelectedItem!=null && textBoxPrice.Text!="")
            {
                SupplySet supply = new SupplySet();
                supply.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.wftDb.SupplySet.Add(supply);
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
            else
            {
                MessageBox.Show("Данны не выбраны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void ShowSupplySet()
        {
            listViewSupply.Items.Clear();
            foreach(SupplySet supply in Program.wftDb.SupplySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    supply.IdAgent.ToString(),
                    supply.Риелтор.LastName+ " ",
                    supply.IdClient.ToString(),
                    supply.Клиент.FirstName + " " + supply.Клиент.MiddleName + " ",
                    supply.IdRealEstate.ToString(),
                    "г. " + supply.Недвижимость.Address_City + " " + "Ул. " + supply.Недвижимость.Address_Street + " ",
                    supply.Price.ToString()
                });
                item.Tag = supply;
                listViewSupply.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listViewSupply.SelectedItems.Count == 1)
            {
                SupplySet supply = listViewSupply.SelectedItems[0].Tag as SupplySet;
                supply.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
        }

        private void listViewSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewSupply.SelectedItems.Count == 1)
            {
                SupplySet supply = listViewSupply.SelectedItems[0].Tag as SupplySet;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(supply.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(supply.IdClient.ToString());
                comboBoxRealEstate.SelectedIndex = comboBoxRealEstate.FindString(supply.IdRealEstate.ToString());
                textBoxPrice.Text = supply.Price.ToString();
            }
            else
            {
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if(listViewSupply.SelectedItems.Count == 1)
                {
                    SupplySet supply = listViewSupply.SelectedItems[0].Tag as SupplySet;
                    Program.wftDb.SupplySet.Remove(supply);
                    Program.wftDb.SaveChanges();
                }
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

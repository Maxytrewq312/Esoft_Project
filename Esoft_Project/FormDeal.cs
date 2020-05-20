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
    public partial class FormDeal : Form
    {
        public FormDeal()
        {
            InitializeComponent();
            ShowSupply();
            ShowDemand();
            ShowDealSet();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        void ShowSupply()
        {
            comboBoxSupply.Items.Clear();
            foreach(SupplySet supply in Program.wftDb.SupplySet)
            {
                string[] item = { supply.Id.ToString() + ". ", "Риелтор: " + supply.Риелтор.MiddleName, "; Клиент: " + supply.Клиент.MiddleName };
                comboBoxSupply.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDemand()
        {
            comboBoxDemand.Items.Clear();
            foreach (DemandSet demand in Program.wftDb.DemandSet)
            {
                string[] item = { demand.Id.ToString() + ". ", "Риелтор: " + demand.Риелтор.MiddleName, "; Клиент: " + demand.Клиент.MiddleName };
                comboBoxDemand.Items.Add(string.Join(" ", item));
            }
        }

        private void comboBoxSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }

        private void comboBoxDemand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }
        void Deductions()
        {
            if(comboBoxSupply.SelectedItem != null && comboBoxDemand.SelectedItem != null)
            {
                SupplySet supply = Program.wftDb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                DemandSet demand = Program.wftDb.DemandSet.Find(Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]));
                double customerCompanyDeductions = supply.Price * 0.03;
                textBoxCustomerCompanyDeduction.Text = customerCompanyDeductions.ToString("0.00");

                if(demand.Риелтор.DealShare != null)
                {
                    double agentCustomerDeductions = customerCompanyDeductions * Convert.ToDouble(demand.Риелтор.DealShare) / 100.00;
                    textBoxAgentCustomerDeduction.Text = agentCustomerDeductions.ToString("0.00");
                }
                else
                {
                    double agentCustomerDeductions = customerCompanyDeductions * 0.45;
                    textBoxAgentCustomerDeduction.Text = agentCustomerDeductions.ToString("0.00");
                }
            }
            else
            {
                textBoxCustomerCompanyDeduction.Text = "";
                textBoxAgentCustomerDeduction.Text = "";
            }
            if(comboBoxSupply.SelectedItem != null)
            {
                SupplySet supply = Program.wftDb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                double sallerCompanyDeductions;
                if (supply.Недвижимость.Type == 0)
                {
                    sallerCompanyDeductions = 36000 + supply.Price * 0.01;
                    textBoxSallerCompanyDeduction.Text = sallerCompanyDeductions.ToString("0.00");
                }
                else if (supply.Недвижимость.Type == 1)
                {
                    sallerCompanyDeductions = 30000 + supply.Price * 0.01;
                    textBoxSallerCompanyDeduction.Text = sallerCompanyDeductions.ToString("0.00");
                }
                else
                {
                    sallerCompanyDeductions = 30000 + supply.Price * 0.02;
                    textBoxSallerCompanyDeduction.Text = sallerCompanyDeductions.ToString("0.00");
                }
                if(supply.Риелтор.DealShare !=null)
                {
                    double agentSallerDeductions = sallerCompanyDeductions * 0.45;
                    textBoxAgentSallerDeduction.Text = agentSallerDeductions.ToString("0.00");
                }
                else
                {
                    textBoxSallerCompanyDeduction.Text = "";
                    textBoxAgentSallerDeduction.Text = "";
                    textBoxCustomerCompanyDeduction.Text = "";
                    textBoxAgentCustomerDeduction.Text = "";
                }
            }
        }
        void ShowDealSet()
        {
            listViewDealSet.Items.Clear();
            foreach(DealSet deal in Program.wftDb.DealSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    deal.SupplySet.Клиент.MiddleName,
                    deal.SupplySet.Риелтор.MiddleName,
                    deal.DemandSet.Клиент.MiddleName,
                    deal.DemandSet.Риелтор.MiddleName,
                    "г. " + deal.SupplySet.Недвижимость.Address_City + 
                    ", Ул. " + deal.SupplySet.Недвижимость.Address_Street,
                    deal.SupplySet.Price.ToString()
                });
                item.Tag = deal;
                listViewDealSet.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxDemand.SelectedItem != null && comboBoxSupply.SelectedItem != null)
            {
                DealSet deal = new DealSet();
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.DealSet.Add(deal);
                Program.wftDb.SaveChanges();
                ShowDealSet();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listViewDealSet.SelectedItems.Count == 1)
            {
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.SaveChanges();
                ShowDealSet();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if(listViewDealSet.SelectedItems.Count == 1)
                {
                    DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                    Program.wftDb.DealSet.Remove(deal);
                    Program.wftDb.SaveChanges();
                    ShowDealSet();
                }
                comboBoxSupply.SelectedItem = null;
                comboBoxDemand.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewDealSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewDealSet.SelectedItems.Count == 1)
            {
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                comboBoxSupply.SelectedIndex = comboBoxSupply.FindString(deal.IdSupply.ToString());
                comboBoxDemand.SelectedIndex = comboBoxDemand.FindString(deal.IdDemand.ToString());
            }
            else
            {
                comboBoxSupply.SelectedItem = null;
                comboBoxDemand.SelectedItem = null;
            }
        }
    }
}

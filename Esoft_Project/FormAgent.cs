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
    public partial class FormAgent : Form
    {
        public FormAgent()
        {
            InitializeComponent();
            ShowAgent();
        }


        private void textBoxDealShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Риелтор agentSet = new Риелтор();
            agentSet.FirstName = textBoxFirstName.Text;
            agentSet.MiddleName = textBoxMiddleName.Text;
            agentSet.LastName = textBoxLastName.Text;
            agentSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
            Program.wftDb.Риелтор.Add(agentSet);
            Program.wftDb.SaveChanges();
            ShowAgent();
        }
        void ShowAgent()
        {
            listViewAgent.Items.Clear();
            foreach (Риелтор agentsSet in Program.wftDb.Риелтор)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    agentsSet.Id.ToString(), agentsSet.FirstName, agentsSet.MiddleName,
                    agentsSet.LastName, agentsSet.DealShare.ToString()
                });
                item.Tag = agentsSet;
                listViewAgent.Items.Add(item);
            }
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                Риелтор agentSet = listViewAgent.SelectedItems[0].Tag as Риелтор;
                textBoxFirstName.Text = agentSet.FirstName;
                textBoxMiddleName.Text = agentSet.MiddleName;
                textBoxLastName.Text = agentSet.LastName;
                textBoxDealShare.Text = agentSet.DealShare.ToString();
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                Риелтор agentSet = listViewAgent.SelectedItems[0].Tag as Риелтор;
                agentSet.FirstName = textBoxFirstName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;
                agentSet.LastName = textBoxLastName.Text;
                agentSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
                Program.wftDb.SaveChanges();
                ShowAgent();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    Риелтор agentSet = listViewAgent.SelectedItems[0].Tag as Риелтор;
                    Program.wftDb.Риелтор.Remove(agentSet);
                    Program.wftDb.SaveChanges();
                    ShowAgent();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

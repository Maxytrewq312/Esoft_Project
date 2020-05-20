namespace Esoft_Project
{
    partial class FormDeal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSupply = new System.Windows.Forms.ComboBox();
            this.comboBoxDemand = new System.Windows.Forms.ComboBox();
            this.textBoxSallerCompanyDeduction = new System.Windows.Forms.TextBox();
            this.textBoxAgentSallerDeduction = new System.Windows.Forms.TextBox();
            this.textBoxCustomerCompanyDeduction = new System.Windows.Forms.TextBox();
            this.textBoxAgentCustomerDeduction = new System.Windows.Forms.TextBox();
            this.labelSupply = new System.Windows.Forms.Label();
            this.labelDemand = new System.Windows.Forms.Label();
            this.labelSallerCompanyDeduction = new System.Windows.Forms.Label();
            this.labelAgentSallerDeduction = new System.Windows.Forms.Label();
            this.labelCustomerCompanyDeduction = new System.Windows.Forms.Label();
            this.labelAgentCustomerDeduction = new System.Windows.Forms.Label();
            this.listViewDealSet = new System.Windows.Forms.ListView();
            this.КП = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.РиелторКП = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.КПК = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.РиелторКПК = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.АдресОН = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Стоимость = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSupply
            // 
            this.comboBoxSupply.FormattingEnabled = true;
            this.comboBoxSupply.Location = new System.Drawing.Point(12, 28);
            this.comboBoxSupply.Name = "comboBoxSupply";
            this.comboBoxSupply.Size = new System.Drawing.Size(231, 21);
            this.comboBoxSupply.TabIndex = 0;
            this.comboBoxSupply.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupply_SelectedIndexChanged);
            // 
            // comboBoxDemand
            // 
            this.comboBoxDemand.FormattingEnabled = true;
            this.comboBoxDemand.Location = new System.Drawing.Point(12, 78);
            this.comboBoxDemand.Name = "comboBoxDemand";
            this.comboBoxDemand.Size = new System.Drawing.Size(231, 21);
            this.comboBoxDemand.TabIndex = 1;
            this.comboBoxDemand.SelectedIndexChanged += new System.EventHandler(this.comboBoxDemand_SelectedIndexChanged);
            // 
            // textBoxSallerCompanyDeduction
            // 
            this.textBoxSallerCompanyDeduction.Location = new System.Drawing.Point(12, 158);
            this.textBoxSallerCompanyDeduction.Name = "textBoxSallerCompanyDeduction";
            this.textBoxSallerCompanyDeduction.Size = new System.Drawing.Size(231, 20);
            this.textBoxSallerCompanyDeduction.TabIndex = 2;
            // 
            // textBoxAgentSallerDeduction
            // 
            this.textBoxAgentSallerDeduction.Location = new System.Drawing.Point(12, 205);
            this.textBoxAgentSallerDeduction.Name = "textBoxAgentSallerDeduction";
            this.textBoxAgentSallerDeduction.Size = new System.Drawing.Size(231, 20);
            this.textBoxAgentSallerDeduction.TabIndex = 3;
            // 
            // textBoxCustomerCompanyDeduction
            // 
            this.textBoxCustomerCompanyDeduction.Location = new System.Drawing.Point(12, 283);
            this.textBoxCustomerCompanyDeduction.Name = "textBoxCustomerCompanyDeduction";
            this.textBoxCustomerCompanyDeduction.Size = new System.Drawing.Size(231, 20);
            this.textBoxCustomerCompanyDeduction.TabIndex = 4;
            // 
            // textBoxAgentCustomerDeduction
            // 
            this.textBoxAgentCustomerDeduction.Location = new System.Drawing.Point(12, 332);
            this.textBoxAgentCustomerDeduction.Name = "textBoxAgentCustomerDeduction";
            this.textBoxAgentCustomerDeduction.Size = new System.Drawing.Size(231, 20);
            this.textBoxAgentCustomerDeduction.TabIndex = 5;
            // 
            // labelSupply
            // 
            this.labelSupply.AutoSize = true;
            this.labelSupply.Location = new System.Drawing.Point(12, 12);
            this.labelSupply.Name = "labelSupply";
            this.labelSupply.Size = new System.Drawing.Size(77, 13);
            this.labelSupply.TabIndex = 6;
            this.labelSupply.Text = "Предложение";
            // 
            // labelDemand
            // 
            this.labelDemand.AutoSize = true;
            this.labelDemand.Location = new System.Drawing.Point(9, 62);
            this.labelDemand.Name = "labelDemand";
            this.labelDemand.Size = new System.Drawing.Size(73, 13);
            this.labelDemand.TabIndex = 7;
            this.labelDemand.Text = "Потребность";
            // 
            // labelSallerCompanyDeduction
            // 
            this.labelSallerCompanyDeduction.AutoSize = true;
            this.labelSallerCompanyDeduction.Location = new System.Drawing.Point(9, 142);
            this.labelSallerCompanyDeduction.Name = "labelSallerCompanyDeduction";
            this.labelSallerCompanyDeduction.Size = new System.Drawing.Size(208, 13);
            this.labelSallerCompanyDeduction.TabIndex = 8;
            this.labelSallerCompanyDeduction.Text = "Стоимость услуг для клиента-продавца";
            // 
            // labelAgentSallerDeduction
            // 
            this.labelAgentSallerDeduction.AutoSize = true;
            this.labelAgentSallerDeduction.Location = new System.Drawing.Point(12, 190);
            this.labelAgentSallerDeduction.Name = "labelAgentSallerDeduction";
            this.labelAgentSallerDeduction.Size = new System.Drawing.Size(211, 13);
            this.labelAgentSallerDeduction.TabIndex = 9;
            this.labelAgentSallerDeduction.Text = "Отчисления риелтору клиента-продавца";
            // 
            // labelCustomerCompanyDeduction
            // 
            this.labelCustomerCompanyDeduction.AutoSize = true;
            this.labelCustomerCompanyDeduction.Location = new System.Drawing.Point(9, 267);
            this.labelCustomerCompanyDeduction.Name = "labelCustomerCompanyDeduction";
            this.labelCustomerCompanyDeduction.Size = new System.Drawing.Size(218, 13);
            this.labelCustomerCompanyDeduction.TabIndex = 10;
            this.labelCustomerCompanyDeduction.Text = "Стоимость услуг для клиента-покупателя";
            this.labelCustomerCompanyDeduction.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelAgentCustomerDeduction
            // 
            this.labelAgentCustomerDeduction.AutoSize = true;
            this.labelAgentCustomerDeduction.Location = new System.Drawing.Point(9, 316);
            this.labelAgentCustomerDeduction.Name = "labelAgentCustomerDeduction";
            this.labelAgentCustomerDeduction.Size = new System.Drawing.Size(221, 13);
            this.labelAgentCustomerDeduction.TabIndex = 11;
            this.labelAgentCustomerDeduction.Text = "Отчисления риелтору клиента-покупателя";
            // 
            // listViewDealSet
            // 
            this.listViewDealSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.КП,
            this.РиелторКП,
            this.КПК,
            this.РиелторКПК,
            this.АдресОН,
            this.Стоимость});
            this.listViewDealSet.FullRowSelect = true;
            this.listViewDealSet.GridLines = true;
            this.listViewDealSet.HideSelection = false;
            this.listViewDealSet.Location = new System.Drawing.Point(315, 12);
            this.listViewDealSet.MultiSelect = false;
            this.listViewDealSet.Name = "listViewDealSet";
            this.listViewDealSet.Size = new System.Drawing.Size(773, 340);
            this.listViewDealSet.TabIndex = 12;
            this.listViewDealSet.UseCompatibleStateImageBehavior = false;
            this.listViewDealSet.View = System.Windows.Forms.View.Details;
            this.listViewDealSet.SelectedIndexChanged += new System.EventHandler(this.listViewDealSet_SelectedIndexChanged);
            // 
            // КП
            // 
            this.КП.Text = "Клиент-продавец";
            this.КП.Width = 100;
            // 
            // РиелторКП
            // 
            this.РиелторКП.Text = "Риелтор клиента-продавца";
            this.РиелторКП.Width = 153;
            // 
            // КПК
            // 
            this.КПК.Text = "Клиент-покупатель";
            this.КПК.Width = 111;
            // 
            // РиелторКПК
            // 
            this.РиелторКПК.Text = "Риелтор клиента-покупателя";
            this.РиелторКПК.Width = 161;
            // 
            // АдресОН
            // 
            this.АдресОН.Text = "Адрес объекта недвижимости";
            this.АдресОН.Width = 169;
            // 
            // Стоимость
            // 
            this.Стоимость.Text = "Стоимость";
            this.Стоимость.Width = 73;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(459, 398);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 40);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(635, 398);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(170, 40);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Location = new System.Drawing.Point(811, 398);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(170, 40);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDealSet);
            this.Controls.Add(this.labelAgentCustomerDeduction);
            this.Controls.Add(this.labelCustomerCompanyDeduction);
            this.Controls.Add(this.labelAgentSallerDeduction);
            this.Controls.Add(this.labelSallerCompanyDeduction);
            this.Controls.Add(this.labelDemand);
            this.Controls.Add(this.labelSupply);
            this.Controls.Add(this.textBoxAgentCustomerDeduction);
            this.Controls.Add(this.textBoxCustomerCompanyDeduction);
            this.Controls.Add(this.textBoxAgentSallerDeduction);
            this.Controls.Add(this.textBoxSallerCompanyDeduction);
            this.Controls.Add(this.comboBoxDemand);
            this.Controls.Add(this.comboBoxSupply);
            this.Name = "FormDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сделки";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSupply;
        private System.Windows.Forms.ComboBox comboBoxDemand;
        private System.Windows.Forms.TextBox textBoxSallerCompanyDeduction;
        private System.Windows.Forms.TextBox textBoxAgentSallerDeduction;
        private System.Windows.Forms.TextBox textBoxCustomerCompanyDeduction;
        private System.Windows.Forms.TextBox textBoxAgentCustomerDeduction;
        private System.Windows.Forms.Label labelSupply;
        private System.Windows.Forms.Label labelDemand;
        private System.Windows.Forms.Label labelSallerCompanyDeduction;
        private System.Windows.Forms.Label labelAgentSallerDeduction;
        private System.Windows.Forms.Label labelCustomerCompanyDeduction;
        private System.Windows.Forms.Label labelAgentCustomerDeduction;
        private System.Windows.Forms.ListView listViewDealSet;
        private System.Windows.Forms.ColumnHeader КП;
        private System.Windows.Forms.ColumnHeader РиелторКП;
        private System.Windows.Forms.ColumnHeader КПК;
        private System.Windows.Forms.ColumnHeader РиелторКПК;
        private System.Windows.Forms.ColumnHeader АдресОН;
        private System.Windows.Forms.ColumnHeader Стоимость;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
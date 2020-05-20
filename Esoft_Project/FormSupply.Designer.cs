namespace Esoft_Project
{
    partial class FormSupply
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
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelRealEstate = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.listViewSupply = new System.Windows.Forms.ListView();
            this.Риелтор = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ФамилияРиелтора = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Клиент = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.инициалы = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ОбъектНедвижимости = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.городиулица = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Цена = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxAgent = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxRealEstate = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 269);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(194, 20);
            this.textBoxPrice.TabIndex = 0;
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Location = new System.Drawing.Point(9, 43);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(49, 13);
            this.labelAgent.TabIndex = 1;
            this.labelAgent.Text = "Риелтор";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(9, 116);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 2;
            this.labelClient.Text = "Клиент";
            this.labelClient.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelRealEstate
            // 
            this.labelRealEstate.AutoSize = true;
            this.labelRealEstate.Location = new System.Drawing.Point(9, 183);
            this.labelRealEstate.Name = "labelRealEstate";
            this.labelRealEstate.Size = new System.Drawing.Size(123, 13);
            this.labelRealEstate.TabIndex = 3;
            this.labelRealEstate.Text = "Объект недвижимости";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(9, 253);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Цена";
            // 
            // listViewSupply
            // 
            this.listViewSupply.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Риелтор,
            this.ФамилияРиелтора,
            this.Клиент,
            this.инициалы,
            this.ОбъектНедвижимости,
            this.городиулица,
            this.Цена});
            this.listViewSupply.FullRowSelect = true;
            this.listViewSupply.GridLines = true;
            this.listViewSupply.HideSelection = false;
            this.listViewSupply.Location = new System.Drawing.Point(263, 12);
            this.listViewSupply.MultiSelect = false;
            this.listViewSupply.Name = "listViewSupply";
            this.listViewSupply.Size = new System.Drawing.Size(863, 350);
            this.listViewSupply.TabIndex = 5;
            this.listViewSupply.UseCompatibleStateImageBehavior = false;
            this.listViewSupply.View = System.Windows.Forms.View.Details;
            this.listViewSupply.SelectedIndexChanged += new System.EventHandler(this.listViewSupply_SelectedIndexChanged);
            // 
            // Риелтор
            // 
            this.Риелтор.Text = "Риелтор";
            this.Риелтор.Width = 64;
            // 
            // ФамилияРиелтора
            // 
            this.ФамилияРиелтора.Text = "Фамилия риелтора";
            this.ФамилияРиелтора.Width = 137;
            // 
            // Клиент
            // 
            this.Клиент.Text = "Клиент";
            this.Клиент.Width = 127;
            // 
            // инициалы
            // 
            this.инициалы.Text = "Фамилия и имя клиента";
            this.инициалы.Width = 166;
            // 
            // ОбъектНедвижимости
            // 
            this.ОбъектНедвижимости.Text = "Объект недвижимости";
            this.ОбъектНедвижимости.Width = 131;
            // 
            // городиулица
            // 
            this.городиулица.Text = "Город и улица ОН";
            this.городиулица.Width = 133;
            // 
            // Цена
            // 
            this.Цена.Text = "Цена";
            this.Цена.Width = 101;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(482, 398);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 40);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(658, 398);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(170, 40);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Location = new System.Drawing.Point(834, 398);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(170, 40);
            this.buttonDel.TabIndex = 8;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxAgent
            // 
            this.comboBoxAgent.FormattingEnabled = true;
            this.comboBoxAgent.Location = new System.Drawing.Point(12, 59);
            this.comboBoxAgent.Name = "comboBoxAgent";
            this.comboBoxAgent.Size = new System.Drawing.Size(194, 21);
            this.comboBoxAgent.TabIndex = 9;
            this.comboBoxAgent.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(12, 132);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(194, 21);
            this.comboBoxClient.TabIndex = 10;
            // 
            // comboBoxRealEstate
            // 
            this.comboBoxRealEstate.FormattingEnabled = true;
            this.comboBoxRealEstate.Location = new System.Drawing.Point(12, 199);
            this.comboBoxRealEstate.Name = "comboBoxRealEstate";
            this.comboBoxRealEstate.Size = new System.Drawing.Size(194, 21);
            this.comboBoxRealEstate.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 386);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxRealEstate);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxAgent);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewSupply);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelRealEstate);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.textBoxPrice);
            this.Name = "FormSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предложения";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelRealEstate;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ListView listViewSupply;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxAgent;
        private System.Windows.Forms.ColumnHeader Риелтор;
        private System.Windows.Forms.ColumnHeader Клиент;
        private System.Windows.Forms.ColumnHeader ОбъектНедвижимости;
        private System.Windows.Forms.ColumnHeader Цена;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxRealEstate;
        private System.Windows.Forms.ColumnHeader ФамилияРиелтора;
        private System.Windows.Forms.ColumnHeader инициалы;
        private System.Windows.Forms.ColumnHeader городиулица;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
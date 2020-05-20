namespace Esoft_Project
{
    partial class FormDemand
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewApartment = new System.Windows.Forms.ListView();
            this.риелтор = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.клиент = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Минимальнаяцена = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.максцена = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.минплощадь = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.максплощадь = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.минэтаж = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.максэтаж = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.минколвокомнат = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.максколвокомнат = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewHouse = new System.Windows.Forms.ListView();
            this.клиент1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.риелтор1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.минцен = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.максцен = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.минареа = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.максареа = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.минколвоэтажей = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.максколвоэтажей = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewLand = new System.Windows.Forms.ListView();
            this.риелтор2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.клиент2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.минцена1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.максцена1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.минареа1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.максареа1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxAgent = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMinArea = new System.Windows.Forms.TextBox();
            this.textBoxMaxArea = new System.Windows.Forms.TextBox();
            this.textBoxMinRooms = new System.Windows.Forms.TextBox();
            this.textBoxMaxRooms = new System.Windows.Forms.TextBox();
            this.textBoxMinFloor = new System.Windows.Forms.TextBox();
            this.textBoxMaxFloor = new System.Windows.Forms.TextBox();
            this.textBoxMinFloors = new System.Windows.Forms.TextBox();
            this.textBoxMaxFloors = new System.Windows.Forms.TextBox();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.labelMinArea = new System.Windows.Forms.Label();
            this.labelMaxArea = new System.Windows.Forms.Label();
            this.labelMinRooms = new System.Windows.Forms.Label();
            this.labelMaxRooms = new System.Windows.Forms.Label();
            this.labelMinFloor = new System.Windows.Forms.Label();
            this.labelMaxFloor = new System.Windows.Forms.Label();
            this.labelMinFloors = new System.Windows.Forms.Label();
            this.labelMaxFloors = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Location = new System.Drawing.Point(852, 390);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 48);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEdit.Location = new System.Drawing.Point(1028, 390);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(170, 48);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDel.Location = new System.Drawing.Point(1204, 390);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(170, 48);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewApartment
            // 
            this.listViewApartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.риелтор,
            this.клиент,
            this.Минимальнаяцена,
            this.максцена,
            this.минплощадь,
            this.максплощадь,
            this.минэтаж,
            this.максэтаж,
            this.минколвокомнат,
            this.максколвокомнат});
            this.listViewApartment.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.listViewApartment.FullRowSelect = true;
            this.listViewApartment.GridLines = true;
            this.listViewApartment.HideSelection = false;
            this.listViewApartment.Location = new System.Drawing.Point(434, 12);
            this.listViewApartment.MultiSelect = false;
            this.listViewApartment.Name = "listViewApartment";
            this.listViewApartment.Size = new System.Drawing.Size(940, 334);
            this.listViewApartment.TabIndex = 3;
            this.listViewApartment.UseCompatibleStateImageBehavior = false;
            this.listViewApartment.View = System.Windows.Forms.View.Details;
            this.listViewApartment.SelectedIndexChanged += new System.EventHandler(this.listViewApartment_SelectedIndexChanged);
            // 
            // риелтор
            // 
            this.риелтор.Text = "Риелтор";
            // 
            // клиент
            // 
            this.клиент.Text = "Клиент";
            // 
            // Минимальнаяцена
            // 
            this.Минимальнаяцена.Text = "Мин. цена";
            // 
            // максцена
            // 
            this.максцена.Text = "Макс. цена";
            // 
            // минплощадь
            // 
            this.минплощадь.Text = "Мин. площадь";
            // 
            // максплощадь
            // 
            this.максплощадь.Text = "Макс. площадь";
            // 
            // минэтаж
            // 
            this.минэтаж.Text = "Мин. этаж";
            this.минэтаж.Width = 72;
            // 
            // максэтаж
            // 
            this.максэтаж.Text = "Макс. этаж";
            this.максэтаж.Width = 74;
            // 
            // минколвокомнат
            // 
            this.минколвокомнат.Text = "Мин. количество комнат";
            // 
            // максколвокомнат
            // 
            this.максколвокомнат.Text = "Макс. количество комнат";
            // 
            // listViewHouse
            // 
            this.listViewHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.клиент1,
            this.риелтор1,
            this.минцен,
            this.максцен,
            this.минареа,
            this.максареа,
            this.минколвоэтажей,
            this.максколвоэтажей});
            this.listViewHouse.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.listViewHouse.FullRowSelect = true;
            this.listViewHouse.GridLines = true;
            this.listViewHouse.HideSelection = false;
            this.listViewHouse.Location = new System.Drawing.Point(434, 12);
            this.listViewHouse.MultiSelect = false;
            this.listViewHouse.Name = "listViewHouse";
            this.listViewHouse.Size = new System.Drawing.Size(940, 334);
            this.listViewHouse.TabIndex = 4;
            this.listViewHouse.UseCompatibleStateImageBehavior = false;
            this.listViewHouse.View = System.Windows.Forms.View.Details;
            this.listViewHouse.SelectedIndexChanged += new System.EventHandler(this.listViewHouse_SelectedIndexChanged);
            // 
            // клиент1
            // 
            this.клиент1.Text = "Клиент";
            this.клиент1.Width = 78;
            // 
            // риелтор1
            // 
            this.риелтор1.Text = "Риелтор";
            // 
            // минцен
            // 
            this.минцен.Text = "Мин. цена";
            // 
            // максцен
            // 
            this.максцен.Text = "Макс. цена";
            // 
            // минареа
            // 
            this.минареа.Text = "Мин. площадь";
            // 
            // максареа
            // 
            this.максареа.Text = "Макс. площадь";
            // 
            // минколвоэтажей
            // 
            this.минколвоэтажей.Text = "Мин. количество этажей";
            // 
            // максколвоэтажей
            // 
            this.максколвоэтажей.Text = "Макс. количество этажей";
            // 
            // listViewLand
            // 
            this.listViewLand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.риелтор2,
            this.клиент2,
            this.минцена1,
            this.максцена1,
            this.минареа1,
            this.максареа1});
            this.listViewLand.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.listViewLand.FullRowSelect = true;
            this.listViewLand.GridLines = true;
            this.listViewLand.HideSelection = false;
            this.listViewLand.Location = new System.Drawing.Point(434, 12);
            this.listViewLand.MultiSelect = false;
            this.listViewLand.Name = "listViewLand";
            this.listViewLand.Size = new System.Drawing.Size(940, 334);
            this.listViewLand.TabIndex = 5;
            this.listViewLand.UseCompatibleStateImageBehavior = false;
            this.listViewLand.View = System.Windows.Forms.View.Details;
            this.listViewLand.SelectedIndexChanged += new System.EventHandler(this.listViewLand_SelectedIndexChanged);
            // 
            // риелтор2
            // 
            this.риелтор2.Text = "Риелтор";
            // 
            // клиент2
            // 
            this.клиент2.Text = "Клиент";
            this.клиент2.Width = 133;
            // 
            // минцена1
            // 
            this.минцена1.Text = "Мин. цена";
            // 
            // максцена1
            // 
            this.максцена1.Text = "Макс. цена";
            // 
            // минареа1
            // 
            this.минареа1.Text = "Мин. площадь";
            // 
            // максареа1
            // 
            this.максареа1.Text = "Макс. площадь";
            // 
            // comboBoxAgent
            // 
            this.comboBoxAgent.FormattingEnabled = true;
            this.comboBoxAgent.Location = new System.Drawing.Point(12, 42);
            this.comboBoxAgent.Name = "comboBoxAgent";
            this.comboBoxAgent.Size = new System.Drawing.Size(162, 21);
            this.comboBoxAgent.TabIndex = 7;
            this.comboBoxAgent.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgent_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelType.Location = new System.Drawing.Point(220, 26);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(148, 13);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Тип объекта недвижимости";
            this.labelType.Click += new System.EventHandler(this.labelRealEstate_Click);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(111, 97);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(162, 21);
            this.comboBoxClient.TabIndex = 9;
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxClient_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(212, 42);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(162, 21);
            this.comboBoxType.TabIndex = 10;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelAgent.Location = new System.Drawing.Point(63, 26);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(49, 13);
            this.labelAgent.TabIndex = 11;
            this.labelAgent.Text = "Риелтор";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelClient.Location = new System.Drawing.Point(171, 81);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 12;
            this.labelClient.Text = "Клиент";
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(12, 156);
            this.textBoxMinPrice.Multiline = true;
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(162, 21);
            this.textBoxMinPrice.TabIndex = 14;
            this.textBoxMinPrice.TextChanged += new System.EventHandler(this.textBoxMinPrice_TextChanged);
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(212, 156);
            this.textBoxMaxPrice.Multiline = true;
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(162, 21);
            this.textBoxMaxPrice.TabIndex = 15;
            this.textBoxMaxPrice.TextChanged += new System.EventHandler(this.textBoxMaxPrice_TextChanged);
            // 
            // textBoxMinArea
            // 
            this.textBoxMinArea.Location = new System.Drawing.Point(12, 217);
            this.textBoxMinArea.Multiline = true;
            this.textBoxMinArea.Name = "textBoxMinArea";
            this.textBoxMinArea.Size = new System.Drawing.Size(162, 21);
            this.textBoxMinArea.TabIndex = 16;
            this.textBoxMinArea.TextChanged += new System.EventHandler(this.textBoxMinArea_TextChanged);
            // 
            // textBoxMaxArea
            // 
            this.textBoxMaxArea.Location = new System.Drawing.Point(212, 217);
            this.textBoxMaxArea.Multiline = true;
            this.textBoxMaxArea.Name = "textBoxMaxArea";
            this.textBoxMaxArea.Size = new System.Drawing.Size(162, 21);
            this.textBoxMaxArea.TabIndex = 17;
            this.textBoxMaxArea.TextChanged += new System.EventHandler(this.textBoxMaxArea_TextChanged);
            // 
            // textBoxMinRooms
            // 
            this.textBoxMinRooms.Location = new System.Drawing.Point(12, 340);
            this.textBoxMinRooms.Multiline = true;
            this.textBoxMinRooms.Name = "textBoxMinRooms";
            this.textBoxMinRooms.Size = new System.Drawing.Size(162, 21);
            this.textBoxMinRooms.TabIndex = 18;
            this.textBoxMinRooms.TextChanged += new System.EventHandler(this.textBoxMinRooms_TextChanged);
            // 
            // textBoxMaxRooms
            // 
            this.textBoxMaxRooms.Location = new System.Drawing.Point(212, 340);
            this.textBoxMaxRooms.Multiline = true;
            this.textBoxMaxRooms.Name = "textBoxMaxRooms";
            this.textBoxMaxRooms.Size = new System.Drawing.Size(162, 21);
            this.textBoxMaxRooms.TabIndex = 19;
            this.textBoxMaxRooms.TextChanged += new System.EventHandler(this.textBoxMaxRooms_TextChanged);
            // 
            // textBoxMinFloor
            // 
            this.textBoxMinFloor.Location = new System.Drawing.Point(12, 278);
            this.textBoxMinFloor.Multiline = true;
            this.textBoxMinFloor.Name = "textBoxMinFloor";
            this.textBoxMinFloor.Size = new System.Drawing.Size(162, 21);
            this.textBoxMinFloor.TabIndex = 20;
            this.textBoxMinFloor.TextChanged += new System.EventHandler(this.textBoxMinFloor_TextChanged);
            // 
            // textBoxMaxFloor
            // 
            this.textBoxMaxFloor.Location = new System.Drawing.Point(212, 278);
            this.textBoxMaxFloor.Multiline = true;
            this.textBoxMaxFloor.Name = "textBoxMaxFloor";
            this.textBoxMaxFloor.Size = new System.Drawing.Size(162, 21);
            this.textBoxMaxFloor.TabIndex = 21;
            this.textBoxMaxFloor.TextChanged += new System.EventHandler(this.textBoxMaxFloor_TextChanged);
            // 
            // textBoxMinFloors
            // 
            this.textBoxMinFloors.Location = new System.Drawing.Point(12, 278);
            this.textBoxMinFloors.Multiline = true;
            this.textBoxMinFloors.Name = "textBoxMinFloors";
            this.textBoxMinFloors.Size = new System.Drawing.Size(162, 21);
            this.textBoxMinFloors.TabIndex = 22;
            this.textBoxMinFloors.Visible = false;
            this.textBoxMinFloors.TextChanged += new System.EventHandler(this.textBoxMinFloors_TextChanged);
            // 
            // textBoxMaxFloors
            // 
            this.textBoxMaxFloors.Location = new System.Drawing.Point(212, 278);
            this.textBoxMaxFloors.Multiline = true;
            this.textBoxMaxFloors.Name = "textBoxMaxFloors";
            this.textBoxMaxFloors.Size = new System.Drawing.Size(162, 21);
            this.textBoxMaxFloors.TabIndex = 23;
            this.textBoxMaxFloors.Visible = false;
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelMinPrice.Location = new System.Drawing.Point(9, 140);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(106, 13);
            this.labelMinPrice.TabIndex = 24;
            this.labelMinPrice.Text = "Минимальная цена";
            this.labelMinPrice.Click += new System.EventHandler(this.labelMinPrice_Click);
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelMaxPrice.Location = new System.Drawing.Point(209, 140);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(112, 13);
            this.labelMaxPrice.TabIndex = 25;
            this.labelMaxPrice.Text = "Максимальная цена";
            this.labelMaxPrice.Click += new System.EventHandler(this.labelMaxPrice_Click);
            // 
            // labelMinArea
            // 
            this.labelMinArea.AutoSize = true;
            this.labelMinArea.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelMinArea.Location = new System.Drawing.Point(12, 201);
            this.labelMinArea.Name = "labelMinArea";
            this.labelMinArea.Size = new System.Drawing.Size(127, 13);
            this.labelMinArea.TabIndex = 26;
            this.labelMinArea.Text = "Минимальная площадь";
            this.labelMinArea.Click += new System.EventHandler(this.labelMinArea_Click);
            // 
            // labelMaxArea
            // 
            this.labelMaxArea.AutoSize = true;
            this.labelMaxArea.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelMaxArea.Location = new System.Drawing.Point(209, 201);
            this.labelMaxArea.Name = "labelMaxArea";
            this.labelMaxArea.Size = new System.Drawing.Size(133, 13);
            this.labelMaxArea.TabIndex = 27;
            this.labelMaxArea.Text = "Максимальная площадь";
            this.labelMaxArea.Click += new System.EventHandler(this.labelMaxArea_Click);
            // 
            // labelMinRooms
            // 
            this.labelMinRooms.AutoSize = true;
            this.labelMinRooms.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelMinRooms.Location = new System.Drawing.Point(9, 324);
            this.labelMinRooms.Name = "labelMinRooms";
            this.labelMinRooms.Size = new System.Drawing.Size(155, 13);
            this.labelMinRooms.TabIndex = 28;
            this.labelMinRooms.Text = "Минимальное кол-во комнат";
            this.labelMinRooms.Click += new System.EventHandler(this.labelMinRooms_Click);
            // 
            // labelMaxRooms
            // 
            this.labelMaxRooms.AutoSize = true;
            this.labelMaxRooms.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelMaxRooms.Location = new System.Drawing.Point(209, 324);
            this.labelMaxRooms.Name = "labelMaxRooms";
            this.labelMaxRooms.Size = new System.Drawing.Size(161, 13);
            this.labelMaxRooms.TabIndex = 29;
            this.labelMaxRooms.Text = "Максимальное кол-во комнат";
            this.labelMaxRooms.Click += new System.EventHandler(this.labelMaxRooms_Click);
            // 
            // labelMinFloor
            // 
            this.labelMinFloor.AutoSize = true;
            this.labelMinFloor.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelMinFloor.Location = new System.Drawing.Point(12, 262);
            this.labelMinFloor.Name = "labelMinFloor";
            this.labelMinFloor.Size = new System.Drawing.Size(109, 13);
            this.labelMinFloor.TabIndex = 30;
            this.labelMinFloor.Text = "Минимальный этаж";
            this.labelMinFloor.Click += new System.EventHandler(this.labelMinFloor_Click);
            // 
            // labelMaxFloor
            // 
            this.labelMaxFloor.AutoSize = true;
            this.labelMaxFloor.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelMaxFloor.Location = new System.Drawing.Point(209, 262);
            this.labelMaxFloor.Name = "labelMaxFloor";
            this.labelMaxFloor.Size = new System.Drawing.Size(115, 13);
            this.labelMaxFloor.TabIndex = 31;
            this.labelMaxFloor.Text = "Максимальный этаж";
            this.labelMaxFloor.Click += new System.EventHandler(this.labelMaxFloor_Click);
            // 
            // labelMinFloors
            // 
            this.labelMinFloors.AutoSize = true;
            this.labelMinFloors.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelMinFloors.Location = new System.Drawing.Point(12, 262);
            this.labelMinFloors.Name = "labelMinFloors";
            this.labelMinFloors.Size = new System.Drawing.Size(155, 13);
            this.labelMinFloors.TabIndex = 32;
            this.labelMinFloors.Text = "Минимальное кол-во этажей";
            this.labelMinFloors.Visible = false;
            this.labelMinFloors.Click += new System.EventHandler(this.labelMinFloors_Click);
            // 
            // labelMaxFloors
            // 
            this.labelMaxFloors.AutoSize = true;
            this.labelMaxFloors.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelMaxFloors.Location = new System.Drawing.Point(209, 262);
            this.labelMaxFloors.Name = "labelMaxFloors";
            this.labelMaxFloors.Size = new System.Drawing.Size(161, 13);
            this.labelMaxFloors.TabIndex = 33;
            this.labelMaxFloors.Text = "Максимальное кол-во этажей";
            this.labelMaxFloors.Visible = false;
            this.labelMaxFloors.Click += new System.EventHandler(this.labelMaxFloors_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 386);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // FormDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMaxFloor);
            this.Controls.Add(this.labelMinFloor);
            this.Controls.Add(this.labelMaxRooms);
            this.Controls.Add(this.labelMinRooms);
            this.Controls.Add(this.labelMaxArea);
            this.Controls.Add(this.labelMinArea);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.textBoxMaxRooms);
            this.Controls.Add(this.textBoxMinRooms);
            this.Controls.Add(this.textBoxMaxArea);
            this.Controls.Add(this.textBoxMinArea);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.textBoxMinPrice);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxAgent);
            this.Controls.Add(this.listViewApartment);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewHouse);
            this.Controls.Add(this.listViewLand);
            this.Controls.Add(this.textBoxMaxFloors);
            this.Controls.Add(this.labelMaxFloors);
            this.Controls.Add(this.textBoxMinFloors);
            this.Controls.Add(this.labelMinFloors);
            this.Controls.Add(this.textBoxMaxFloor);
            this.Controls.Add(this.textBoxMinFloor);
            this.Name = "FormDemand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потребности";
            this.Load += new System.EventHandler(this.FormDemand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewApartment;
        private System.Windows.Forms.ListView listViewHouse;
        private System.Windows.Forms.ListView listViewLand;
        private System.Windows.Forms.ComboBox comboBoxAgent;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ColumnHeader клиент;
        private System.Windows.Forms.ColumnHeader риелтор;
        private System.Windows.Forms.ColumnHeader Минимальнаяцена;
        private System.Windows.Forms.ColumnHeader максцена;
        private System.Windows.Forms.ColumnHeader минплощадь;
        private System.Windows.Forms.ColumnHeader максплощадь;
        private System.Windows.Forms.ColumnHeader минколвокомнат;
        private System.Windows.Forms.ColumnHeader максколвокомнат;
        private System.Windows.Forms.ColumnHeader минэтаж;
        private System.Windows.Forms.ColumnHeader максэтаж;
        private System.Windows.Forms.ColumnHeader клиент1;
        private System.Windows.Forms.ColumnHeader риелтор1;
        private System.Windows.Forms.ColumnHeader минцен;
        private System.Windows.Forms.ColumnHeader максцен;
        private System.Windows.Forms.ColumnHeader минареа;
        private System.Windows.Forms.ColumnHeader максареа;
        private System.Windows.Forms.ColumnHeader минколвоэтажей;
        private System.Windows.Forms.ColumnHeader максколвоэтажей;
        private System.Windows.Forms.ColumnHeader клиент2;
        private System.Windows.Forms.ColumnHeader риелтор2;
        private System.Windows.Forms.ColumnHeader минцена1;
        private System.Windows.Forms.ColumnHeader максцена1;
        private System.Windows.Forms.ColumnHeader минареа1;
        private System.Windows.Forms.ColumnHeader максареа1;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.TextBox textBoxMinArea;
        private System.Windows.Forms.TextBox textBoxMaxArea;
        private System.Windows.Forms.TextBox textBoxMinRooms;
        private System.Windows.Forms.TextBox textBoxMaxRooms;
        private System.Windows.Forms.TextBox textBoxMinFloor;
        private System.Windows.Forms.TextBox textBoxMaxFloor;
        private System.Windows.Forms.TextBox textBoxMinFloors;
        private System.Windows.Forms.TextBox textBoxMaxFloors;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.Label labelMinArea;
        private System.Windows.Forms.Label labelMaxArea;
        private System.Windows.Forms.Label labelMinRooms;
        private System.Windows.Forms.Label labelMaxRooms;
        private System.Windows.Forms.Label labelMinFloor;
        private System.Windows.Forms.Label labelMaxFloor;
        private System.Windows.Forms.Label labelMinFloors;
        private System.Windows.Forms.Label labelMaxFloors;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
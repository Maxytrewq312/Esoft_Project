﻿namespace Esoft_Project
{
    partial class FormRealEstate
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
            this.textBoxAddress_City = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Street = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Number = new System.Windows.Forms.TextBox();
            this.textBoxAddress_House = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_latitude = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_longitude = new System.Windows.Forms.TextBox();
            this.textBoxTotalArea = new System.Windows.Forms.TextBox();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxTotalFloors = new System.Windows.Forms.TextBox();
            this.labelAddress_City = new System.Windows.Forms.Label();
            this.labelAddress_Street = new System.Windows.Forms.Label();
            this.labelAddress_House = new System.Windows.Forms.Label();
            this.labelAddress_Number = new System.Windows.Forms.Label();
            this.labelCoordinate_latitude = new System.Windows.Forms.Label();
            this.labelCoordinate_longitude = new System.Windows.Forms.Label();
            this.labelTotalArea = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.labelTotalFloors = new System.Windows.Forms.Label();
            this.listViewRealEstateSet_Apartment = new System.Windows.Forms.ListView();
            this.Город = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Улица = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Номер_дома = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Номер_квартиры = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Широта = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Долгота = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Площадь = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Количество_комнат = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Этаж = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRealEstateSet_House = new System.Windows.Forms.ListView();
            this.Город2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Улица2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Номер_дома2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Номер_квартиры2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Широта2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Долгота2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Площадь2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Количество_этажей = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRealEstateSet_Land = new System.Windows.Forms.ListView();
            this.Город1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Улица1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Номер_дома1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Номер_квартиры1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Широта1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Долгота1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Площадь1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAddress_City
            // 
            this.textBoxAddress_City.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAddress_City.Location = new System.Drawing.Point(12, 30);
            this.textBoxAddress_City.Name = "textBoxAddress_City";
            this.textBoxAddress_City.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress_City.TabIndex = 0;
            this.textBoxAddress_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_City_KeyPress);
            // 
            // textBoxAddress_Street
            // 
            this.textBoxAddress_Street.Location = new System.Drawing.Point(12, 132);
            this.textBoxAddress_Street.Name = "textBoxAddress_Street";
            this.textBoxAddress_Street.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress_Street.TabIndex = 1;
            this.textBoxAddress_Street.TextChanged += new System.EventHandler(this.textBoxAddress_House_TextChanged);
            this.textBoxAddress_Street.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_House_KeyPress_1);
            // 
            // textBoxAddress_Number
            // 
            this.textBoxAddress_Number.Location = new System.Drawing.Point(12, 181);
            this.textBoxAddress_Number.Name = "textBoxAddress_Number";
            this.textBoxAddress_Number.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress_Number.TabIndex = 2;
            this.textBoxAddress_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_House_KeyPress);
            // 
            // textBoxAddress_House
            // 
            this.textBoxAddress_House.Location = new System.Drawing.Point(12, 79);
            this.textBoxAddress_House.Name = "textBoxAddress_House";
            this.textBoxAddress_House.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress_House.TabIndex = 3;
            this.textBoxAddress_House.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBoxAddress_House.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_Number_KeyPress);
            // 
            // textBoxCoordinate_latitude
            // 
            this.textBoxCoordinate_latitude.Location = new System.Drawing.Point(12, 232);
            this.textBoxCoordinate_latitude.Name = "textBoxCoordinate_latitude";
            this.textBoxCoordinate_latitude.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordinate_latitude.TabIndex = 4;
            this.textBoxCoordinate_latitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoordinate_latitude_KeyPress);
            // 
            // textBoxCoordinate_longitude
            // 
            this.textBoxCoordinate_longitude.Location = new System.Drawing.Point(12, 280);
            this.textBoxCoordinate_longitude.Name = "textBoxCoordinate_longitude";
            this.textBoxCoordinate_longitude.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordinate_longitude.TabIndex = 5;
            this.textBoxCoordinate_longitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoordinate_longitude_KeyPress);
            // 
            // textBoxTotalArea
            // 
            this.textBoxTotalArea.Location = new System.Drawing.Point(12, 331);
            this.textBoxTotalArea.Name = "textBoxTotalArea";
            this.textBoxTotalArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalArea.TabIndex = 6;
            this.textBoxTotalArea.TextChanged += new System.EventHandler(this.textBoxTotalArea_TextChanged);
            this.textBoxTotalArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTotalArea_KeyPress);
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.Location = new System.Drawing.Point(166, 79);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.Size = new System.Drawing.Size(100, 20);
            this.textBoxRooms.TabIndex = 7;
            this.textBoxRooms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRooms_KeyPress);
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(166, 132);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxFloor.TabIndex = 8;
            this.textBoxFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFloor_KeyPress);
            // 
            // textBoxTotalFloors
            // 
            this.textBoxTotalFloors.Location = new System.Drawing.Point(166, 79);
            this.textBoxTotalFloors.Name = "textBoxTotalFloors";
            this.textBoxTotalFloors.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalFloors.TabIndex = 9;
            this.textBoxTotalFloors.Visible = false;
            this.textBoxTotalFloors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTotalFloors_KeyPress);
            // 
            // labelAddress_City
            // 
            this.labelAddress_City.AutoSize = true;
            this.labelAddress_City.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelAddress_City.Location = new System.Drawing.Point(9, 14);
            this.labelAddress_City.Name = "labelAddress_City";
            this.labelAddress_City.Size = new System.Drawing.Size(36, 13);
            this.labelAddress_City.TabIndex = 10;
            this.labelAddress_City.Text = "Город";
            // 
            // labelAddress_Street
            // 
            this.labelAddress_Street.AutoSize = true;
            this.labelAddress_Street.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelAddress_Street.Location = new System.Drawing.Point(9, 63);
            this.labelAddress_Street.Name = "labelAddress_Street";
            this.labelAddress_Street.Size = new System.Drawing.Size(38, 13);
            this.labelAddress_Street.TabIndex = 11;
            this.labelAddress_Street.Text = "Улица";
            // 
            // labelAddress_House
            // 
            this.labelAddress_House.AutoSize = true;
            this.labelAddress_House.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelAddress_House.Location = new System.Drawing.Point(9, 116);
            this.labelAddress_House.Name = "labelAddress_House";
            this.labelAddress_House.Size = new System.Drawing.Size(70, 13);
            this.labelAddress_House.TabIndex = 12;
            this.labelAddress_House.Text = "Номер дома";
            // 
            // labelAddress_Number
            // 
            this.labelAddress_Number.AutoSize = true;
            this.labelAddress_Number.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelAddress_Number.Location = new System.Drawing.Point(9, 165);
            this.labelAddress_Number.Name = "labelAddress_Number";
            this.labelAddress_Number.Size = new System.Drawing.Size(93, 13);
            this.labelAddress_Number.TabIndex = 13;
            this.labelAddress_Number.Text = "Номер квартиры";
            // 
            // labelCoordinate_latitude
            // 
            this.labelCoordinate_latitude.AutoSize = true;
            this.labelCoordinate_latitude.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelCoordinate_latitude.Location = new System.Drawing.Point(9, 216);
            this.labelCoordinate_latitude.Name = "labelCoordinate_latitude";
            this.labelCoordinate_latitude.Size = new System.Drawing.Size(46, 13);
            this.labelCoordinate_latitude.TabIndex = 14;
            this.labelCoordinate_latitude.Text = "Широта";
            // 
            // labelCoordinate_longitude
            // 
            this.labelCoordinate_longitude.AutoSize = true;
            this.labelCoordinate_longitude.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelCoordinate_longitude.Location = new System.Drawing.Point(9, 264);
            this.labelCoordinate_longitude.Name = "labelCoordinate_longitude";
            this.labelCoordinate_longitude.Size = new System.Drawing.Size(49, 13);
            this.labelCoordinate_longitude.TabIndex = 15;
            this.labelCoordinate_longitude.Text = "Долгота";
            // 
            // labelTotalArea
            // 
            this.labelTotalArea.AutoSize = true;
            this.labelTotalArea.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelTotalArea.Location = new System.Drawing.Point(9, 315);
            this.labelTotalArea.Name = "labelTotalArea";
            this.labelTotalArea.Size = new System.Drawing.Size(54, 13);
            this.labelTotalArea.TabIndex = 16;
            this.labelTotalArea.Text = "Площадь";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelType.Location = new System.Drawing.Point(163, 14);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(148, 13);
            this.labelType.TabIndex = 17;
            this.labelType.Text = "Тип объекта недвижимости";
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelRooms.Location = new System.Drawing.Point(163, 63);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(107, 13);
            this.labelRooms.TabIndex = 18;
            this.labelRooms.Text = "Количество комнат";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelFloor.Location = new System.Drawing.Point(163, 116);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(33, 13);
            this.labelFloor.TabIndex = 19;
            this.labelFloor.Text = "Этаж";
            // 
            // labelTotalFloors
            // 
            this.labelTotalFloors.AutoSize = true;
            this.labelTotalFloors.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.labelTotalFloors.Location = new System.Drawing.Point(163, 64);
            this.labelTotalFloors.Name = "labelTotalFloors";
            this.labelTotalFloors.Size = new System.Drawing.Size(107, 13);
            this.labelTotalFloors.TabIndex = 20;
            this.labelTotalFloors.Text = "Количество этажей";
            this.labelTotalFloors.Visible = false;
            // 
            // listViewRealEstateSet_Apartment
            // 
            this.listViewRealEstateSet_Apartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Город,
            this.Улица,
            this.Номер_дома,
            this.Номер_квартиры,
            this.Широта,
            this.Долгота,
            this.Площадь,
            this.Количество_комнат,
            this.Этаж});
            this.listViewRealEstateSet_Apartment.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.listViewRealEstateSet_Apartment.FullRowSelect = true;
            this.listViewRealEstateSet_Apartment.GridLines = true;
            this.listViewRealEstateSet_Apartment.HideSelection = false;
            this.listViewRealEstateSet_Apartment.Location = new System.Drawing.Point(321, 12);
            this.listViewRealEstateSet_Apartment.MultiSelect = false;
            this.listViewRealEstateSet_Apartment.Name = "listViewRealEstateSet_Apartment";
            this.listViewRealEstateSet_Apartment.Size = new System.Drawing.Size(684, 344);
            this.listViewRealEstateSet_Apartment.TabIndex = 21;
            this.listViewRealEstateSet_Apartment.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Apartment.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Apartment.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Apartment_SelectedIndexChanged);
            // 
            // Город
            // 
            this.Город.Text = "Город";
            this.Город.Width = 50;
            // 
            // Улица
            // 
            this.Улица.Text = "Улица";
            this.Улица.Width = 56;
            // 
            // Номер_дома
            // 
            this.Номер_дома.Text = "Номер дома";
            this.Номер_дома.Width = 81;
            // 
            // Номер_квартиры
            // 
            this.Номер_квартиры.Text = "Номер квартиры";
            this.Номер_квартиры.Width = 99;
            // 
            // Широта
            // 
            this.Широта.Text = "Широта";
            // 
            // Долгота
            // 
            this.Долгота.Text = "Долгота";
            // 
            // Площадь
            // 
            this.Площадь.Text = "Площадь";
            // 
            // Количество_комнат
            // 
            this.Количество_комнат.Text = "Количество комнат";
            this.Количество_комнат.Width = 121;
            // 
            // Этаж
            // 
            this.Этаж.Text = "Этаж";
            // 
            // listViewRealEstateSet_House
            // 
            this.listViewRealEstateSet_House.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Город2,
            this.Улица2,
            this.Номер_дома2,
            this.Номер_квартиры2,
            this.Широта2,
            this.Долгота2,
            this.Площадь2,
            this.Количество_этажей});
            this.listViewRealEstateSet_House.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.listViewRealEstateSet_House.FullRowSelect = true;
            this.listViewRealEstateSet_House.GridLines = true;
            this.listViewRealEstateSet_House.HideSelection = false;
            this.listViewRealEstateSet_House.Location = new System.Drawing.Point(321, 12);
            this.listViewRealEstateSet_House.MultiSelect = false;
            this.listViewRealEstateSet_House.Name = "listViewRealEstateSet_House";
            this.listViewRealEstateSet_House.Size = new System.Drawing.Size(683, 344);
            this.listViewRealEstateSet_House.TabIndex = 22;
            this.listViewRealEstateSet_House.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_House.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_House.Visible = false;
            this.listViewRealEstateSet_House.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_House_SelectedIndexChanged);
            // 
            // Город2
            // 
            this.Город2.Text = "Город";
            this.Город2.Width = 52;
            // 
            // Улица2
            // 
            this.Улица2.Text = "Улица";
            this.Улица2.Width = 56;
            // 
            // Номер_дома2
            // 
            this.Номер_дома2.Text = "Номер дома";
            this.Номер_дома2.Width = 81;
            // 
            // Номер_квартиры2
            // 
            this.Номер_квартиры2.Text = "Номер квартиры";
            this.Номер_квартиры2.Width = 98;
            // 
            // Широта2
            // 
            this.Широта2.Text = "Широта";
            // 
            // Долгота2
            // 
            this.Долгота2.Text = "Долгота";
            // 
            // Площадь2
            // 
            this.Площадь2.Text = "Площадь";
            // 
            // Количество_этажей
            // 
            this.Количество_этажей.Text = "Количество этажей";
            this.Количество_этажей.Width = 116;
            // 
            // listViewRealEstateSet_Land
            // 
            this.listViewRealEstateSet_Land.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Город1,
            this.Улица1,
            this.Номер_дома1,
            this.Номер_квартиры1,
            this.Широта1,
            this.Долгота1,
            this.Площадь1});
            this.listViewRealEstateSet_Land.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.listViewRealEstateSet_Land.FullRowSelect = true;
            this.listViewRealEstateSet_Land.GridLines = true;
            this.listViewRealEstateSet_Land.HideSelection = false;
            this.listViewRealEstateSet_Land.Location = new System.Drawing.Point(321, 12);
            this.listViewRealEstateSet_Land.MultiSelect = false;
            this.listViewRealEstateSet_Land.Name = "listViewRealEstateSet_Land";
            this.listViewRealEstateSet_Land.Size = new System.Drawing.Size(683, 344);
            this.listViewRealEstateSet_Land.TabIndex = 23;
            this.listViewRealEstateSet_Land.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Land.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Land.Visible = false;
            this.listViewRealEstateSet_Land.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Land_SelectedIndexChanged);
            // 
            // Город1
            // 
            this.Город1.Text = "Город";
            this.Город1.Width = 54;
            // 
            // Улица1
            // 
            this.Улица1.Text = "Улица";
            this.Улица1.Width = 57;
            // 
            // Номер_дома1
            // 
            this.Номер_дома1.Text = "Номер дома";
            this.Номер_дома1.Width = 79;
            // 
            // Номер_квартиры1
            // 
            this.Номер_квартиры1.Text = "Номер квартиры";
            this.Номер_квартиры1.Width = 100;
            // 
            // Широта1
            // 
            this.Широта1.Text = "Широта";
            // 
            // Долгота1
            // 
            this.Долгота1.Text = "Долгота";
            // 
            // Площадь1
            // 
            this.Площадь1.Text = "Площадь";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Location = new System.Drawing.Point(483, 385);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 48);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseMnemonic = false;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.UseWaitCursor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEdit.Location = new System.Drawing.Point(659, 385);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(170, 48);
            this.buttonEdit.TabIndex = 25;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDel.Location = new System.Drawing.Point(835, 385);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(170, 48);
            this.buttonDel.TabIndex = 26;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(166, 30);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxType.TabIndex = 27;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // FormRealEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTotalArea);
            this.Controls.Add(this.labelCoordinate_longitude);
            this.Controls.Add(this.labelCoordinate_latitude);
            this.Controls.Add(this.labelAddress_Number);
            this.Controls.Add(this.labelAddress_House);
            this.Controls.Add(this.labelAddress_Street);
            this.Controls.Add(this.labelAddress_City);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.textBoxRooms);
            this.Controls.Add(this.textBoxTotalArea);
            this.Controls.Add(this.textBoxCoordinate_longitude);
            this.Controls.Add(this.textBoxCoordinate_latitude);
            this.Controls.Add(this.textBoxAddress_House);
            this.Controls.Add(this.textBoxAddress_Number);
            this.Controls.Add(this.textBoxAddress_Street);
            this.Controls.Add(this.textBoxAddress_City);
            this.Controls.Add(this.listViewRealEstateSet_Apartment);
            this.Controls.Add(this.listViewRealEstateSet_Land);
            this.Controls.Add(this.listViewRealEstateSet_House);
            this.Controls.Add(this.labelTotalFloors);
            this.Controls.Add(this.textBoxTotalFloors);
            this.Name = "FormRealEstate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объекты недвижимости";
            this.Load += new System.EventHandler(this.FormRealEstate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddress_City;
        private System.Windows.Forms.TextBox textBoxAddress_Street;
        private System.Windows.Forms.TextBox textBoxAddress_Number;
        private System.Windows.Forms.TextBox textBoxAddress_House;
        private System.Windows.Forms.TextBox textBoxCoordinate_latitude;
        private System.Windows.Forms.TextBox textBoxCoordinate_longitude;
        private System.Windows.Forms.TextBox textBoxTotalArea;
        private System.Windows.Forms.TextBox textBoxRooms;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.TextBox textBoxTotalFloors;
        private System.Windows.Forms.Label labelAddress_City;
        private System.Windows.Forms.Label labelAddress_Street;
        private System.Windows.Forms.Label labelAddress_House;
        private System.Windows.Forms.Label labelAddress_Number;
        private System.Windows.Forms.Label labelCoordinate_latitude;
        private System.Windows.Forms.Label labelCoordinate_longitude;
        private System.Windows.Forms.Label labelTotalArea;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelTotalFloors;
        private System.Windows.Forms.ListView listViewRealEstateSet_Apartment;
        private System.Windows.Forms.ListView listViewRealEstateSet_House;
        private System.Windows.Forms.ListView listViewRealEstateSet_Land;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ColumnHeader Город;
        private System.Windows.Forms.ColumnHeader Улица;
        private System.Windows.Forms.ColumnHeader Номер_дома;
        private System.Windows.Forms.ColumnHeader Номер_квартиры;
        private System.Windows.Forms.ColumnHeader Широта;
        private System.Windows.Forms.ColumnHeader Долгота;
        private System.Windows.Forms.ColumnHeader Площадь;
        private System.Windows.Forms.ColumnHeader Количество_комнат;
        private System.Windows.Forms.ColumnHeader Этаж;
        private System.Windows.Forms.ColumnHeader Город2;
        private System.Windows.Forms.ColumnHeader Улица2;
        private System.Windows.Forms.ColumnHeader Номер_дома2;
        private System.Windows.Forms.ColumnHeader Номер_квартиры2;
        private System.Windows.Forms.ColumnHeader Широта2;
        private System.Windows.Forms.ColumnHeader Долгота2;
        private System.Windows.Forms.ColumnHeader Площадь2;
        private System.Windows.Forms.ColumnHeader Количество_этажей;
        private System.Windows.Forms.ColumnHeader Город1;
        private System.Windows.Forms.ColumnHeader Улица1;
        private System.Windows.Forms.ColumnHeader Номер_дома1;
        private System.Windows.Forms.ColumnHeader Номер_квартиры1;
        private System.Windows.Forms.ColumnHeader Широта1;
        private System.Windows.Forms.ColumnHeader Долгота1;
        private System.Windows.Forms.ColumnHeader Площадь1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
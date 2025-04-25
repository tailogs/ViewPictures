namespace ViewPictures
{
    partial class Root
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Root));
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.извлечьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повернутьНа90ГрадусовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повернутьНа180ГрадусовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отразитьПоГоризонталиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отразитьПоВертикалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОФотоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимМасштабированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обрезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.установитьИзображениеНаРабочийСтолToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чернобелыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ретроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.негативToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрастностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зерноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темнаяТемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светлаяТемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настроитьСвюТемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разработчикFadisNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            resources.ApplyResources(this.pictureBoxMain, "pictureBoxMain");
            this.pictureBoxMain.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxMain_DragDrop);
            this.pictureBoxMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxMain_DragEnter);
            this.pictureBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseDown);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseMove);
            this.pictureBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseUp);
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.LightCoral;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.изображениеToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.помощьToolStripMenuItem});
            resources.ApplyResources(this.menuStripMain, "menuStripMain");
            this.menuStripMain.Name = "menuStripMain";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.экспортироватьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.извлечьToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.открытьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            resources.ApplyResources(this.открытьToolStripMenuItem, "открытьToolStripMenuItem");
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // экспортироватьToolStripMenuItem
            // 
            this.экспортироватьToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.экспортироватьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.экспортироватьToolStripMenuItem.Name = "экспортироватьToolStripMenuItem";
            resources.ApplyResources(this.экспортироватьToolStripMenuItem, "экспортироватьToolStripMenuItem");
            this.экспортироватьToolStripMenuItem.Click += new System.EventHandler(this.экспортироватьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.копироватьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            resources.ApplyResources(this.копироватьToolStripMenuItem, "копироватьToolStripMenuItem");
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.вставитьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            resources.ApplyResources(this.вставитьToolStripMenuItem, "вставитьToolStripMenuItem");
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // извлечьToolStripMenuItem
            // 
            this.извлечьToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.извлечьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.извлечьToolStripMenuItem.Name = "извлечьToolStripMenuItem";
            resources.ApplyResources(this.извлечьToolStripMenuItem, "извлечьToolStripMenuItem");
            this.извлечьToolStripMenuItem.Click += new System.EventHandler(this.извлечьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.закрытьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            resources.ApplyResources(this.закрытьToolStripMenuItem, "закрытьToolStripMenuItem");
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.выходToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            resources.ApplyResources(this.выходToolStripMenuItem, "выходToolStripMenuItem");
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // изображениеToolStripMenuItem
            // 
            this.изображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.повернутьНа90ГрадусовToolStripMenuItem,
            this.повернутьНа180ГрадусовToolStripMenuItem,
            this.отразитьПоГоризонталиToolStripMenuItem,
            this.отразитьПоВертикалиToolStripMenuItem,
            this.информацияОФотоToolStripMenuItem,
            this.режимМасштабированияToolStripMenuItem,
            this.обрезатьToolStripMenuItem,
            this.установитьИзображениеНаРабочийСтолToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.изображениеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.изображениеToolStripMenuItem.Name = "изображениеToolStripMenuItem";
            resources.ApplyResources(this.изображениеToolStripMenuItem, "изображениеToolStripMenuItem");
            // 
            // повернутьНа90ГрадусовToolStripMenuItem
            // 
            this.повернутьНа90ГрадусовToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.повернутьНа90ГрадусовToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.повернутьНа90ГрадусовToolStripMenuItem.Name = "повернутьНа90ГрадусовToolStripMenuItem";
            resources.ApplyResources(this.повернутьНа90ГрадусовToolStripMenuItem, "повернутьНа90ГрадусовToolStripMenuItem");
            this.повернутьНа90ГрадусовToolStripMenuItem.Click += new System.EventHandler(this.повернутьНа90ГрадусовToolStripMenuItem_Click);
            // 
            // повернутьНа180ГрадусовToolStripMenuItem
            // 
            this.повернутьНа180ГрадусовToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.повернутьНа180ГрадусовToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.повернутьНа180ГрадусовToolStripMenuItem.Name = "повернутьНа180ГрадусовToolStripMenuItem";
            resources.ApplyResources(this.повернутьНа180ГрадусовToolStripMenuItem, "повернутьНа180ГрадусовToolStripMenuItem");
            this.повернутьНа180ГрадусовToolStripMenuItem.Click += new System.EventHandler(this.повернутьНа180ГрадусовToolStripMenuItem_Click);
            // 
            // отразитьПоГоризонталиToolStripMenuItem
            // 
            this.отразитьПоГоризонталиToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.отразитьПоГоризонталиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.отразитьПоГоризонталиToolStripMenuItem.Name = "отразитьПоГоризонталиToolStripMenuItem";
            resources.ApplyResources(this.отразитьПоГоризонталиToolStripMenuItem, "отразитьПоГоризонталиToolStripMenuItem");
            this.отразитьПоГоризонталиToolStripMenuItem.Click += new System.EventHandler(this.отразитьПоГоризонталиToolStripMenuItem_Click);
            // 
            // отразитьПоВертикалиToolStripMenuItem
            // 
            this.отразитьПоВертикалиToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.отразитьПоВертикалиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.отразитьПоВертикалиToolStripMenuItem.Name = "отразитьПоВертикалиToolStripMenuItem";
            resources.ApplyResources(this.отразитьПоВертикалиToolStripMenuItem, "отразитьПоВертикалиToolStripMenuItem");
            this.отразитьПоВертикалиToolStripMenuItem.Click += new System.EventHandler(this.отразитьПоВертикалиToolStripMenuItem_Click);
            // 
            // информацияОФотоToolStripMenuItem
            // 
            this.информацияОФотоToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.информацияОФотоToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.информацияОФотоToolStripMenuItem.Name = "информацияОФотоToolStripMenuItem";
            resources.ApplyResources(this.информацияОФотоToolStripMenuItem, "информацияОФотоToolStripMenuItem");
            this.информацияОФотоToolStripMenuItem.Click += new System.EventHandler(this.информацияОФотоToolStripMenuItem_Click);
            // 
            // режимМасштабированияToolStripMenuItem
            // 
            this.режимМасштабированияToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.режимМасштабированияToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.режимМасштабированияToolStripMenuItem.Name = "режимМасштабированияToolStripMenuItem";
            resources.ApplyResources(this.режимМасштабированияToolStripMenuItem, "режимМасштабированияToolStripMenuItem");
            this.режимМасштабированияToolStripMenuItem.Click += new System.EventHandler(this.режимМасштабированияToolStripMenuItem_Click);
            // 
            // обрезатьToolStripMenuItem
            // 
            this.обрезатьToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.обрезатьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.обрезатьToolStripMenuItem.Name = "обрезатьToolStripMenuItem";
            resources.ApplyResources(this.обрезатьToolStripMenuItem, "обрезатьToolStripMenuItem");
            this.обрезатьToolStripMenuItem.Click += new System.EventHandler(this.обрезатьToolStripMenuItem_Click);
            // 
            // установитьИзображениеНаРабочийСтолToolStripMenuItem
            // 
            this.установитьИзображениеНаРабочийСтолToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.установитьИзображениеНаРабочийСтолToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.установитьИзображениеНаРабочийСтолToolStripMenuItem.Name = "установитьИзображениеНаРабочийСтолToolStripMenuItem";
            resources.ApplyResources(this.установитьИзображениеНаРабочийСтолToolStripMenuItem, "установитьИзображениеНаРабочийСтолToolStripMenuItem");
            this.установитьИзображениеНаРабочийСтолToolStripMenuItem.Click += new System.EventHandler(this.установитьИзображениеНаРабочийСтолToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чернобелыйToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.ретроToolStripMenuItem,
            this.негативToolStripMenuItem,
            this.контрастностьToolStripMenuItem,
            this.резкостьToolStripMenuItem,
            this.зерноToolStripMenuItem});
            this.фильтрыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            resources.ApplyResources(this.фильтрыToolStripMenuItem, "фильтрыToolStripMenuItem");
            // 
            // чернобелыйToolStripMenuItem
            // 
            this.чернобелыйToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.чернобелыйToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.чернобелыйToolStripMenuItem.Name = "чернобелыйToolStripMenuItem";
            resources.ApplyResources(this.чернобелыйToolStripMenuItem, "чернобелыйToolStripMenuItem");
            this.чернобелыйToolStripMenuItem.Click += new System.EventHandler(this.чернобелыйToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.сепияToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            resources.ApplyResources(this.сепияToolStripMenuItem, "сепияToolStripMenuItem");
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // ретроToolStripMenuItem
            // 
            this.ретроToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.ретроToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ретроToolStripMenuItem.Name = "ретроToolStripMenuItem";
            resources.ApplyResources(this.ретроToolStripMenuItem, "ретроToolStripMenuItem");
            this.ретроToolStripMenuItem.Click += new System.EventHandler(this.ретроToolStripMenuItem_Click);
            // 
            // негативToolStripMenuItem
            // 
            this.негативToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.негативToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.негативToolStripMenuItem.Name = "негативToolStripMenuItem";
            resources.ApplyResources(this.негативToolStripMenuItem, "негативToolStripMenuItem");
            this.негативToolStripMenuItem.Click += new System.EventHandler(this.негативToolStripMenuItem_Click);
            // 
            // контрастностьToolStripMenuItem
            // 
            this.контрастностьToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.контрастностьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.контрастностьToolStripMenuItem.Name = "контрастностьToolStripMenuItem";
            resources.ApplyResources(this.контрастностьToolStripMenuItem, "контрастностьToolStripMenuItem");
            this.контрастностьToolStripMenuItem.Click += new System.EventHandler(this.контрастностьToolStripMenuItem_Click);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.резкостьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            resources.ApplyResources(this.резкостьToolStripMenuItem, "резкостьToolStripMenuItem");
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // зерноToolStripMenuItem
            // 
            this.зерноToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.зерноToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.зерноToolStripMenuItem.Name = "зерноToolStripMenuItem";
            resources.ApplyResources(this.зерноToolStripMenuItem, "зерноToolStripMenuItem");
            this.зерноToolStripMenuItem.Click += new System.EventHandler(this.зерноToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темнаяТемаToolStripMenuItem,
            this.светлаяТемаToolStripMenuItem,
            this.настроитьСвюТемуToolStripMenuItem,
            this.настройкиToolStripMenuItem1});
            this.настройкиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            resources.ApplyResources(this.настройкиToolStripMenuItem, "настройкиToolStripMenuItem");
            // 
            // темнаяТемаToolStripMenuItem
            // 
            this.темнаяТемаToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.темнаяТемаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.темнаяТемаToolStripMenuItem.Name = "темнаяТемаToolStripMenuItem";
            resources.ApplyResources(this.темнаяТемаToolStripMenuItem, "темнаяТемаToolStripMenuItem");
            this.темнаяТемаToolStripMenuItem.Click += new System.EventHandler(this.темнаяТемаToolStripMenuItem_Click);
            // 
            // светлаяТемаToolStripMenuItem
            // 
            this.светлаяТемаToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.светлаяТемаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.светлаяТемаToolStripMenuItem.Name = "светлаяТемаToolStripMenuItem";
            resources.ApplyResources(this.светлаяТемаToolStripMenuItem, "светлаяТемаToolStripMenuItem");
            this.светлаяТемаToolStripMenuItem.Click += new System.EventHandler(this.светлаяТемаToolStripMenuItem_Click);
            // 
            // настроитьСвюТемуToolStripMenuItem
            // 
            this.настроитьСвюТемуToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.настроитьСвюТемуToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.настроитьСвюТемуToolStripMenuItem.Name = "настроитьСвюТемуToolStripMenuItem";
            resources.ApplyResources(this.настроитьСвюТемуToolStripMenuItem, "настроитьСвюТемуToolStripMenuItem");
            this.настроитьСвюТемуToolStripMenuItem.Click += new System.EventHandler(this.настроитьСвюТемуToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.BackColor = System.Drawing.Color.LightCoral;
            this.настройкиToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            resources.ApplyResources(this.настройкиToolStripMenuItem1, "настройкиToolStripMenuItem1");
            this.настройкиToolStripMenuItem1.Click += new System.EventHandler(this.настройкиToolStripMenuItem1_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разработчикFadisNetToolStripMenuItem});
            this.помощьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            resources.ApplyResources(this.помощьToolStripMenuItem, "помощьToolStripMenuItem");
            // 
            // разработчикFadisNetToolStripMenuItem
            // 
            this.разработчикFadisNetToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.разработчикFadisNetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.разработчикFadisNetToolStripMenuItem.Name = "разработчикFadisNetToolStripMenuItem";
            resources.ApplyResources(this.разработчикFadisNetToolStripMenuItem, "разработчикFadisNetToolStripMenuItem");
            this.разработчикFadisNetToolStripMenuItem.Click += new System.EventHandler(this.разработчикFadisNetToolStripMenuItem_Click);
            // 
            // Root
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.menuStripMain);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Root";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Root_FormClosing);
            this.Load += new System.EventHandler(this.Root_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Root_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разработчикFadisNetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутьНа180ГрадусовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отразитьПоГоризонталиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отразитьПоВертикалиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутьНа90ГрадусовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОФотоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимМасштабированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обрезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem установитьИзображениеНаРабочийСтолToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чернобелыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ретроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem негативToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрастностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зерноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темнаяТемаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светлаяТемаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem извлечьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настроитьСвюТемуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
    }
}


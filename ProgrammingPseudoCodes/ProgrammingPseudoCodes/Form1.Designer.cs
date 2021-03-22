namespace ProgrammingPseudoCodes
{
    partial class Form_main
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
            this.comboBox_main = new System.Windows.Forms.ComboBox();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabSorozatszamitas = new System.Windows.Forms.TabPage();
            this.panel0 = new System.Windows.Forms.Panel();
            this.radioButton_szorzas = new System.Windows.Forms.RadioButton();
            this.radioButton_osszeadas = new System.Windows.Forms.RadioButton();
            this.textBox_sorozatszamitas = new System.Windows.Forms.TextBox();
            this.labelTombSegitseg = new System.Windows.Forms.Label();
            this.tabEldontes = new System.Windows.Forms.TabPage();
            this.tabModositott_Eldontes = new System.Windows.Forms.TabPage();
            this.tabNovekvoRendezettseg = new System.Windows.Forms.TabPage();
            this.tabKivalsztas = new System.Windows.Forms.TabPage();
            this.tabLinearisKereses = new System.Windows.Forms.TabPage();
            this.tabMegszamlalas = new System.Windows.Forms.TabPage();
            this.tabMaxkiv = new System.Windows.Forms.TabPage();
            this.tabMasolas = new System.Windows.Forms.TabPage();
            this.tabKivalogatas = new System.Windows.Forms.TabPage();
            this.tabKivalogatasETomb = new System.Windows.Forms.TabPage();
            this.tabKivalogatasETombEElem = new System.Windows.Forms.TabPage();
            this.tabSzetvalogatas = new System.Windows.Forms.TabPage();
            this.tabSzetvalogatasEgyUj = new System.Windows.Forms.TabPage();
            this.tabSzetvalogatasETomb = new System.Windows.Forms.TabPage();
            this.tabMetszet = new System.Windows.Forms.TabPage();
            this.tabKozosElem = new System.Windows.Forms.TabPage();
            this.tabUnio = new System.Windows.Forms.TabPage();
            this.tabIsmetlodesekKiszur = new System.Windows.Forms.TabPage();
            this.tabOsszefuttatas = new System.Windows.Forms.TabPage();
            this.tabModositottOsszefuttatas = new System.Windows.Forms.TabPage();
            this.tabMasolasESMaxkiv = new System.Windows.Forms.TabPage();
            this.tabMegszamlalasESKereses = new System.Windows.Forms.TabPage();
            this.tabMaxkivESKivalogatas = new System.Windows.Forms.TabPage();
            this.tabKivalogatasESMaxkiv = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.tabPage21 = new System.Windows.Forms.TabPage();
            this.button_main = new System.Windows.Forms.Button();
            this.listBox_main = new System.Windows.Forms.ListBox();
            this.textBox_eldontes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_eldontes0 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_eldontes1 = new System.Windows.Forms.RadioButton();
            this.tabControl_main.SuspendLayout();
            this.tabSorozatszamitas.SuspendLayout();
            this.panel0.SuspendLayout();
            this.tabEldontes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_main
            // 
            this.comboBox_main.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_main.FormattingEnabled = true;
            this.comboBox_main.Items.AddRange(new object[] {
            "Sorozatszámítás",
            "Eldöntés",
            "Módosított Eldöntés",
            "Növekvő rendezettség vizsgálata",
            "Kiválasztás",
            "Lineáris keresés",
            "Megszámlálás",
            "Maximumkiválasztás",
            "Másolás",
            "Kiválogatás",
            "Kiválaogatás az eredeti tömbben",
            "Kiválogatás eredeti tömb, eredeti elemek megtartása",
            "Szétválogatás",
            "Szétválogatás egy új tömbbe",
            "Szétválogatás eredeti tömbben",
            "Metszet",
            "Közöm elem létezése",
            "Unió (tömb)",
            "Ismétlődések kiszűrése",
            "Összefuttatás",
            "Módosított összefuttatás",
            "Másolás és maximumkiválasztás",
            "Megszámlálás és keresés",
            "Maximumkiválasztás és Kiválogatás",
            "Kiválogatás és maximumkiválasztás",
            "Minimumkiválasztásos rendezés",
            "Buborékrendezés",
            "Javított buborékrendezés",
            "Beillesztéses rendezés",
            "Javított beillesztéses rendezés",
            "Lineáris keresés rendezett tömbben",
            "Logaritmikus keresés",
            "Eldöntés rendezett tömbben",
            "Módosított eldöntés rendezett tömbben (intervallum)",
            "Kiválasztás rendezett tömbben",
            "Kiválogatás rendezett tömbben",
            "Megszámlálás rendezett tömbben",
            "Halmaztulajdonség vizsgálata",
            "Tartalmazás vizsgálata",
            "Részhalmaz vizsgálata",
            "HalmazUnió",
            "HalmazMetszet",
            "HalmazKülönbség",
            "Halmazok Szimmetrikus Differenciája",
            "Faktoriális számítás iteratívan",
            "Faktoriális számítás rekurzívan",
            "Fibonacci sorozat iteratívan",
            "Fibonacci sorozat rekurzívan",
            "Hatványozás iteratívan",
            "Hatványozás rekurzívan",
            "Hatványozás fleezéses elv",
            "Sorozatszámítás rekurzívan",
            "Megszámlálás rekurzívan",
            "Maximumkiválasztás rekurzívan",
            "Lineáris keresés rekurzívan",
            "Logaritmikus keresés rekurzívan",
            "Maximumkiválasztás OMU",
            "Összefésülő rendezés + Összefésülés",
            "Gyorsrendezés + szétválogatás",
            "K-adik legkisebb elem",
            "Hátizsák probléma (külső link)",
            "Kincsek begyűjtése + Kiolvasás",
            "Leghosszabb közös részsorozat (külső link)",
            "Pénzkifizetés",
            "0 - 1 Hátizsák mohón",
            "Kincsbegyűjtés mohón"});
            this.comboBox_main.Location = new System.Drawing.Point(12, 12);
            this.comboBox_main.Name = "comboBox_main";
            this.comboBox_main.Size = new System.Drawing.Size(212, 21);
            this.comboBox_main.TabIndex = 0;
            this.comboBox_main.SelectedIndexChanged += new System.EventHandler(this.comboBox_main_SelectedIndexChanged);
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabSorozatszamitas);
            this.tabControl_main.Controls.Add(this.tabEldontes);
            this.tabControl_main.Controls.Add(this.tabModositott_Eldontes);
            this.tabControl_main.Controls.Add(this.tabNovekvoRendezettseg);
            this.tabControl_main.Controls.Add(this.tabKivalsztas);
            this.tabControl_main.Controls.Add(this.tabLinearisKereses);
            this.tabControl_main.Controls.Add(this.tabMegszamlalas);
            this.tabControl_main.Controls.Add(this.tabMaxkiv);
            this.tabControl_main.Controls.Add(this.tabMasolas);
            this.tabControl_main.Controls.Add(this.tabKivalogatas);
            this.tabControl_main.Controls.Add(this.tabKivalogatasETomb);
            this.tabControl_main.Controls.Add(this.tabKivalogatasETombEElem);
            this.tabControl_main.Controls.Add(this.tabSzetvalogatas);
            this.tabControl_main.Controls.Add(this.tabSzetvalogatasEgyUj);
            this.tabControl_main.Controls.Add(this.tabSzetvalogatasETomb);
            this.tabControl_main.Controls.Add(this.tabMetszet);
            this.tabControl_main.Controls.Add(this.tabKozosElem);
            this.tabControl_main.Controls.Add(this.tabUnio);
            this.tabControl_main.Controls.Add(this.tabIsmetlodesekKiszur);
            this.tabControl_main.Controls.Add(this.tabOsszefuttatas);
            this.tabControl_main.Controls.Add(this.tabModositottOsszefuttatas);
            this.tabControl_main.Controls.Add(this.tabMasolasESMaxkiv);
            this.tabControl_main.Controls.Add(this.tabMegszamlalasESKereses);
            this.tabControl_main.Controls.Add(this.tabMaxkivESKivalogatas);
            this.tabControl_main.Controls.Add(this.tabKivalogatasESMaxkiv);
            this.tabControl_main.Controls.Add(this.tabPage8);
            this.tabControl_main.Controls.Add(this.tabPage9);
            this.tabControl_main.Controls.Add(this.tabPage10);
            this.tabControl_main.Controls.Add(this.tabPage11);
            this.tabControl_main.Controls.Add(this.tabPage12);
            this.tabControl_main.Controls.Add(this.tabPage13);
            this.tabControl_main.Controls.Add(this.tabPage14);
            this.tabControl_main.Controls.Add(this.tabPage15);
            this.tabControl_main.Controls.Add(this.tabPage16);
            this.tabControl_main.Controls.Add(this.tabPage17);
            this.tabControl_main.Controls.Add(this.tabPage18);
            this.tabControl_main.Controls.Add(this.tabPage19);
            this.tabControl_main.Controls.Add(this.tabPage20);
            this.tabControl_main.Controls.Add(this.tabPage21);
            this.tabControl_main.Location = new System.Drawing.Point(12, 40);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(212, 326);
            this.tabControl_main.TabIndex = 1;
            // 
            // tabSorozatszamitas
            // 
            this.tabSorozatszamitas.Controls.Add(this.panel0);
            this.tabSorozatszamitas.Controls.Add(this.textBox_sorozatszamitas);
            this.tabSorozatszamitas.Controls.Add(this.labelTombSegitseg);
            this.tabSorozatszamitas.Location = new System.Drawing.Point(4, 22);
            this.tabSorozatszamitas.Name = "tabSorozatszamitas";
            this.tabSorozatszamitas.Padding = new System.Windows.Forms.Padding(3);
            this.tabSorozatszamitas.Size = new System.Drawing.Size(204, 300);
            this.tabSorozatszamitas.TabIndex = 0;
            this.tabSorozatszamitas.Text = "Sorozatszámítás";
            this.tabSorozatszamitas.UseVisualStyleBackColor = true;
            // 
            // panel0
            // 
            this.panel0.Controls.Add(this.radioButton_szorzas);
            this.panel0.Controls.Add(this.radioButton_osszeadas);
            this.panel0.Location = new System.Drawing.Point(6, 6);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(192, 54);
            this.panel0.TabIndex = 3;
            // 
            // radioButton_szorzas
            // 
            this.radioButton_szorzas.AutoSize = true;
            this.radioButton_szorzas.Location = new System.Drawing.Point(6, 30);
            this.radioButton_szorzas.Name = "radioButton_szorzas";
            this.radioButton_szorzas.Size = new System.Drawing.Size(62, 17);
            this.radioButton_szorzas.TabIndex = 0;
            this.radioButton_szorzas.TabStop = true;
            this.radioButton_szorzas.Text = "Szorzás";
            this.radioButton_szorzas.UseVisualStyleBackColor = true;
            // 
            // radioButton_osszeadas
            // 
            this.radioButton_osszeadas.AutoSize = true;
            this.radioButton_osszeadas.Location = new System.Drawing.Point(6, 7);
            this.radioButton_osszeadas.Name = "radioButton_osszeadas";
            this.radioButton_osszeadas.Size = new System.Drawing.Size(77, 17);
            this.radioButton_osszeadas.TabIndex = 0;
            this.radioButton_osszeadas.TabStop = true;
            this.radioButton_osszeadas.Text = "Összeadás";
            this.radioButton_osszeadas.UseVisualStyleBackColor = true;
            // 
            // textBox_sorozatszamitas
            // 
            this.textBox_sorozatszamitas.Location = new System.Drawing.Point(12, 79);
            this.textBox_sorozatszamitas.Name = "textBox_sorozatszamitas";
            this.textBox_sorozatszamitas.Size = new System.Drawing.Size(182, 20);
            this.textBox_sorozatszamitas.TabIndex = 2;
            // 
            // labelTombSegitseg
            // 
            this.labelTombSegitseg.AutoSize = true;
            this.labelTombSegitseg.Location = new System.Drawing.Point(9, 63);
            this.labelTombSegitseg.Name = "labelTombSegitseg";
            this.labelTombSegitseg.Size = new System.Drawing.Size(185, 13);
            this.labelTombSegitseg.TabIndex = 1;
            this.labelTombSegitseg.Text = "Tömb, számok vesszővel elválasztva:";
            // 
            // tabEldontes
            // 
            this.tabEldontes.Controls.Add(this.panel1);
            this.tabEldontes.Controls.Add(this.label1);
            this.tabEldontes.Controls.Add(this.textBox_eldontes);
            this.tabEldontes.Location = new System.Drawing.Point(4, 22);
            this.tabEldontes.Name = "tabEldontes";
            this.tabEldontes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEldontes.Size = new System.Drawing.Size(204, 300);
            this.tabEldontes.TabIndex = 1;
            this.tabEldontes.Text = "Eldöntés";
            this.tabEldontes.UseVisualStyleBackColor = true;
            // 
            // tabModositott_Eldontes
            // 
            this.tabModositott_Eldontes.Location = new System.Drawing.Point(4, 22);
            this.tabModositott_Eldontes.Name = "tabModositott_Eldontes";
            this.tabModositott_Eldontes.Size = new System.Drawing.Size(204, 300);
            this.tabModositott_Eldontes.TabIndex = 2;
            this.tabModositott_Eldontes.Text = "Módosított Eldöntés";
            this.tabModositott_Eldontes.UseVisualStyleBackColor = true;
            // 
            // tabNovekvoRendezettseg
            // 
            this.tabNovekvoRendezettseg.Location = new System.Drawing.Point(4, 22);
            this.tabNovekvoRendezettseg.Name = "tabNovekvoRendezettseg";
            this.tabNovekvoRendezettseg.Size = new System.Drawing.Size(204, 300);
            this.tabNovekvoRendezettseg.TabIndex = 3;
            this.tabNovekvoRendezettseg.Text = "Növekvő rendezettség vizsgálata";
            this.tabNovekvoRendezettseg.UseVisualStyleBackColor = true;
            // 
            // tabKivalsztas
            // 
            this.tabKivalsztas.Location = new System.Drawing.Point(4, 22);
            this.tabKivalsztas.Name = "tabKivalsztas";
            this.tabKivalsztas.Size = new System.Drawing.Size(204, 300);
            this.tabKivalsztas.TabIndex = 4;
            this.tabKivalsztas.Text = "Kiválasztás";
            this.tabKivalsztas.UseVisualStyleBackColor = true;
            // 
            // tabLinearisKereses
            // 
            this.tabLinearisKereses.Location = new System.Drawing.Point(4, 22);
            this.tabLinearisKereses.Name = "tabLinearisKereses";
            this.tabLinearisKereses.Size = new System.Drawing.Size(204, 300);
            this.tabLinearisKereses.TabIndex = 5;
            this.tabLinearisKereses.Text = "Lineáris keresés";
            this.tabLinearisKereses.UseVisualStyleBackColor = true;
            // 
            // tabMegszamlalas
            // 
            this.tabMegszamlalas.Location = new System.Drawing.Point(4, 22);
            this.tabMegszamlalas.Name = "tabMegszamlalas";
            this.tabMegszamlalas.Size = new System.Drawing.Size(204, 300);
            this.tabMegszamlalas.TabIndex = 6;
            this.tabMegszamlalas.Text = "Megszámlálás";
            this.tabMegszamlalas.UseVisualStyleBackColor = true;
            // 
            // tabMaxkiv
            // 
            this.tabMaxkiv.Location = new System.Drawing.Point(4, 22);
            this.tabMaxkiv.Name = "tabMaxkiv";
            this.tabMaxkiv.Size = new System.Drawing.Size(204, 300);
            this.tabMaxkiv.TabIndex = 7;
            this.tabMaxkiv.Text = "Maximumkiválasztás";
            this.tabMaxkiv.UseVisualStyleBackColor = true;
            // 
            // tabMasolas
            // 
            this.tabMasolas.Location = new System.Drawing.Point(4, 22);
            this.tabMasolas.Name = "tabMasolas";
            this.tabMasolas.Size = new System.Drawing.Size(204, 300);
            this.tabMasolas.TabIndex = 8;
            this.tabMasolas.Text = "Másolás";
            this.tabMasolas.UseVisualStyleBackColor = true;
            // 
            // tabKivalogatas
            // 
            this.tabKivalogatas.Location = new System.Drawing.Point(4, 22);
            this.tabKivalogatas.Name = "tabKivalogatas";
            this.tabKivalogatas.Size = new System.Drawing.Size(204, 300);
            this.tabKivalogatas.TabIndex = 9;
            this.tabKivalogatas.Text = "Kiválogatás";
            this.tabKivalogatas.UseVisualStyleBackColor = true;
            // 
            // tabKivalogatasETomb
            // 
            this.tabKivalogatasETomb.Location = new System.Drawing.Point(4, 22);
            this.tabKivalogatasETomb.Name = "tabKivalogatasETomb";
            this.tabKivalogatasETomb.Size = new System.Drawing.Size(204, 300);
            this.tabKivalogatasETomb.TabIndex = 10;
            this.tabKivalogatasETomb.Text = "Kiválaogatás az eredeti tömbben";
            this.tabKivalogatasETomb.UseVisualStyleBackColor = true;
            // 
            // tabKivalogatasETombEElem
            // 
            this.tabKivalogatasETombEElem.Location = new System.Drawing.Point(4, 22);
            this.tabKivalogatasETombEElem.Name = "tabKivalogatasETombEElem";
            this.tabKivalogatasETombEElem.Size = new System.Drawing.Size(204, 300);
            this.tabKivalogatasETombEElem.TabIndex = 11;
            this.tabKivalogatasETombEElem.Text = "Kiválogatás eredeti tömb, eredeti elemek megtartása";
            this.tabKivalogatasETombEElem.UseVisualStyleBackColor = true;
            // 
            // tabSzetvalogatas
            // 
            this.tabSzetvalogatas.Location = new System.Drawing.Point(4, 22);
            this.tabSzetvalogatas.Name = "tabSzetvalogatas";
            this.tabSzetvalogatas.Size = new System.Drawing.Size(204, 300);
            this.tabSzetvalogatas.TabIndex = 12;
            this.tabSzetvalogatas.Text = "Szétválogatás";
            this.tabSzetvalogatas.UseVisualStyleBackColor = true;
            // 
            // tabSzetvalogatasEgyUj
            // 
            this.tabSzetvalogatasEgyUj.Location = new System.Drawing.Point(4, 22);
            this.tabSzetvalogatasEgyUj.Name = "tabSzetvalogatasEgyUj";
            this.tabSzetvalogatasEgyUj.Size = new System.Drawing.Size(204, 300);
            this.tabSzetvalogatasEgyUj.TabIndex = 13;
            this.tabSzetvalogatasEgyUj.Text = "Szétválogatás egy új tömbbe";
            this.tabSzetvalogatasEgyUj.UseVisualStyleBackColor = true;
            // 
            // tabSzetvalogatasETomb
            // 
            this.tabSzetvalogatasETomb.Location = new System.Drawing.Point(4, 22);
            this.tabSzetvalogatasETomb.Name = "tabSzetvalogatasETomb";
            this.tabSzetvalogatasETomb.Size = new System.Drawing.Size(204, 300);
            this.tabSzetvalogatasETomb.TabIndex = 14;
            this.tabSzetvalogatasETomb.Text = "Szétválogatás eredeti tömbben";
            this.tabSzetvalogatasETomb.UseVisualStyleBackColor = true;
            // 
            // tabMetszet
            // 
            this.tabMetszet.Location = new System.Drawing.Point(4, 22);
            this.tabMetszet.Name = "tabMetszet";
            this.tabMetszet.Size = new System.Drawing.Size(204, 300);
            this.tabMetszet.TabIndex = 15;
            this.tabMetszet.Text = "Metszet";
            this.tabMetszet.UseVisualStyleBackColor = true;
            // 
            // tabKozosElem
            // 
            this.tabKozosElem.Location = new System.Drawing.Point(4, 22);
            this.tabKozosElem.Name = "tabKozosElem";
            this.tabKozosElem.Size = new System.Drawing.Size(204, 300);
            this.tabKozosElem.TabIndex = 16;
            this.tabKozosElem.Text = "Közöm elem létezése";
            this.tabKozosElem.UseVisualStyleBackColor = true;
            // 
            // tabUnio
            // 
            this.tabUnio.Location = new System.Drawing.Point(4, 22);
            this.tabUnio.Name = "tabUnio";
            this.tabUnio.Size = new System.Drawing.Size(204, 300);
            this.tabUnio.TabIndex = 17;
            this.tabUnio.Text = "Unió (tömb)";
            this.tabUnio.UseVisualStyleBackColor = true;
            // 
            // tabIsmetlodesekKiszur
            // 
            this.tabIsmetlodesekKiszur.Location = new System.Drawing.Point(4, 22);
            this.tabIsmetlodesekKiszur.Name = "tabIsmetlodesekKiszur";
            this.tabIsmetlodesekKiszur.Size = new System.Drawing.Size(204, 300);
            this.tabIsmetlodesekKiszur.TabIndex = 18;
            this.tabIsmetlodesekKiszur.Text = "Ismétlődések kiszűrése";
            this.tabIsmetlodesekKiszur.UseVisualStyleBackColor = true;
            // 
            // tabOsszefuttatas
            // 
            this.tabOsszefuttatas.Location = new System.Drawing.Point(4, 22);
            this.tabOsszefuttatas.Name = "tabOsszefuttatas";
            this.tabOsszefuttatas.Size = new System.Drawing.Size(204, 300);
            this.tabOsszefuttatas.TabIndex = 19;
            this.tabOsszefuttatas.Text = "Összefuttatás";
            this.tabOsszefuttatas.UseVisualStyleBackColor = true;
            // 
            // tabModositottOsszefuttatas
            // 
            this.tabModositottOsszefuttatas.Location = new System.Drawing.Point(4, 22);
            this.tabModositottOsszefuttatas.Name = "tabModositottOsszefuttatas";
            this.tabModositottOsszefuttatas.Size = new System.Drawing.Size(204, 300);
            this.tabModositottOsszefuttatas.TabIndex = 20;
            this.tabModositottOsszefuttatas.Text = "Módosított összefuttatás";
            this.tabModositottOsszefuttatas.UseVisualStyleBackColor = true;
            // 
            // tabMasolasESMaxkiv
            // 
            this.tabMasolasESMaxkiv.Location = new System.Drawing.Point(4, 22);
            this.tabMasolasESMaxkiv.Name = "tabMasolasESMaxkiv";
            this.tabMasolasESMaxkiv.Size = new System.Drawing.Size(204, 300);
            this.tabMasolasESMaxkiv.TabIndex = 21;
            this.tabMasolasESMaxkiv.Text = "Másolás és maximumkiválasztás";
            this.tabMasolasESMaxkiv.UseVisualStyleBackColor = true;
            // 
            // tabMegszamlalasESKereses
            // 
            this.tabMegszamlalasESKereses.Location = new System.Drawing.Point(4, 22);
            this.tabMegszamlalasESKereses.Name = "tabMegszamlalasESKereses";
            this.tabMegszamlalasESKereses.Size = new System.Drawing.Size(204, 300);
            this.tabMegszamlalasESKereses.TabIndex = 22;
            this.tabMegszamlalasESKereses.Text = "Megszámlálás és keresés";
            this.tabMegszamlalasESKereses.UseVisualStyleBackColor = true;
            // 
            // tabMaxkivESKivalogatas
            // 
            this.tabMaxkivESKivalogatas.Location = new System.Drawing.Point(4, 22);
            this.tabMaxkivESKivalogatas.Name = "tabMaxkivESKivalogatas";
            this.tabMaxkivESKivalogatas.Size = new System.Drawing.Size(204, 300);
            this.tabMaxkivESKivalogatas.TabIndex = 23;
            this.tabMaxkivESKivalogatas.Text = "Maximumkiválasztás és Kiválogatás";
            this.tabMaxkivESKivalogatas.UseVisualStyleBackColor = true;
            // 
            // tabKivalogatasESMaxkiv
            // 
            this.tabKivalogatasESMaxkiv.Location = new System.Drawing.Point(4, 22);
            this.tabKivalogatasESMaxkiv.Name = "tabKivalogatasESMaxkiv";
            this.tabKivalogatasESMaxkiv.Size = new System.Drawing.Size(204, 300);
            this.tabKivalogatasESMaxkiv.TabIndex = 24;
            this.tabKivalogatasESMaxkiv.Text = "Kiválogatás és maximumkiválasztás";
            this.tabKivalogatasESMaxkiv.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(204, 300);
            this.tabPage8.TabIndex = 25;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(204, 300);
            this.tabPage9.TabIndex = 26;
            this.tabPage9.Text = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(204, 300);
            this.tabPage10.TabIndex = 27;
            this.tabPage10.Text = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(204, 300);
            this.tabPage11.TabIndex = 28;
            this.tabPage11.Text = "tabPage11";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(204, 300);
            this.tabPage12.TabIndex = 29;
            this.tabPage12.Text = "tabPage12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Size = new System.Drawing.Size(204, 300);
            this.tabPage13.TabIndex = 30;
            this.tabPage13.Text = "tabPage13";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Size = new System.Drawing.Size(204, 300);
            this.tabPage14.TabIndex = 31;
            this.tabPage14.Text = "tabPage14";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Size = new System.Drawing.Size(204, 300);
            this.tabPage15.TabIndex = 32;
            this.tabPage15.Text = "tabPage15";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // tabPage16
            // 
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(204, 300);
            this.tabPage16.TabIndex = 33;
            this.tabPage16.Text = "tabPage16";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // tabPage17
            // 
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(204, 300);
            this.tabPage17.TabIndex = 34;
            this.tabPage17.Text = "tabPage17";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // tabPage18
            // 
            this.tabPage18.Location = new System.Drawing.Point(4, 22);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Size = new System.Drawing.Size(204, 300);
            this.tabPage18.TabIndex = 35;
            this.tabPage18.Text = "tabPage18";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // tabPage19
            // 
            this.tabPage19.Location = new System.Drawing.Point(4, 22);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Size = new System.Drawing.Size(204, 300);
            this.tabPage19.TabIndex = 36;
            this.tabPage19.Text = "tabPage19";
            this.tabPage19.UseVisualStyleBackColor = true;
            // 
            // tabPage20
            // 
            this.tabPage20.Location = new System.Drawing.Point(4, 22);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Size = new System.Drawing.Size(204, 300);
            this.tabPage20.TabIndex = 37;
            this.tabPage20.Text = "tabPage20";
            this.tabPage20.UseVisualStyleBackColor = true;
            // 
            // tabPage21
            // 
            this.tabPage21.Location = new System.Drawing.Point(4, 22);
            this.tabPage21.Name = "tabPage21";
            this.tabPage21.Size = new System.Drawing.Size(204, 300);
            this.tabPage21.TabIndex = 38;
            this.tabPage21.Text = "tabPage21";
            this.tabPage21.UseVisualStyleBackColor = true;
            // 
            // button_main
            // 
            this.button_main.Location = new System.Drawing.Point(12, 372);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(212, 23);
            this.button_main.TabIndex = 2;
            this.button_main.Text = "Levezetés";
            this.button_main.UseVisualStyleBackColor = true;
            this.button_main.Click += new System.EventHandler(this.button_main_Click);
            // 
            // listBox_main
            // 
            this.listBox_main.BackColor = System.Drawing.Color.DarkGray;
            this.listBox_main.FormattingEnabled = true;
            this.listBox_main.Location = new System.Drawing.Point(230, 12);
            this.listBox_main.Name = "listBox_main";
            this.listBox_main.Size = new System.Drawing.Size(558, 394);
            this.listBox_main.TabIndex = 3;
            // 
            // textBox_eldontes
            // 
            this.textBox_eldontes.Location = new System.Drawing.Point(12, 79);
            this.textBox_eldontes.Name = "textBox_eldontes";
            this.textBox_eldontes.Size = new System.Drawing.Size(182, 20);
            this.textBox_eldontes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tömb, számok vesszővel elválasztva:";
            // 
            // radioButton_eldontes0
            // 
            this.radioButton_eldontes0.AutoSize = true;
            this.radioButton_eldontes0.Location = new System.Drawing.Point(7, 5);
            this.radioButton_eldontes0.Name = "radioButton_eldontes0";
            this.radioButton_eldontes0.Size = new System.Drawing.Size(52, 17);
            this.radioButton_eldontes0.TabIndex = 3;
            this.radioButton_eldontes0.TabStop = true;
            this.radioButton_eldontes0.Text = "Páros";
            this.radioButton_eldontes0.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_eldontes1);
            this.panel1.Controls.Add(this.radioButton_eldontes0);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 51);
            this.panel1.TabIndex = 4;
            // 
            // radioButton_eldontes1
            // 
            this.radioButton_eldontes1.AutoSize = true;
            this.radioButton_eldontes1.Location = new System.Drawing.Point(7, 28);
            this.radioButton_eldontes1.Name = "radioButton_eldontes1";
            this.radioButton_eldontes1.Size = new System.Drawing.Size(64, 17);
            this.radioButton_eldontes1.TabIndex = 4;
            this.radioButton_eldontes1.TabStop = true;
            this.radioButton_eldontes1.Text = "Páratlan";
            this.radioButton_eldontes1.UseVisualStyleBackColor = true;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_main);
            this.Controls.Add(this.button_main);
            this.Controls.Add(this.tabControl_main);
            this.Controls.Add(this.comboBox_main);
            this.Name = "Form_main";
            this.Text = "Pseudo Code Visualizer";
            this.tabControl_main.ResumeLayout(false);
            this.tabSorozatszamitas.ResumeLayout(false);
            this.tabSorozatszamitas.PerformLayout();
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            this.tabEldontes.ResumeLayout(false);
            this.tabEldontes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_main;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabSorozatszamitas;
        private System.Windows.Forms.TabPage tabEldontes;
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.ListBox listBox_main;
        private System.Windows.Forms.TabPage tabModositott_Eldontes;
        private System.Windows.Forms.TabPage tabNovekvoRendezettseg;
        private System.Windows.Forms.TabPage tabKivalsztas;
        private System.Windows.Forms.TabPage tabLinearisKereses;
        private System.Windows.Forms.TabPage tabMegszamlalas;
        private System.Windows.Forms.TabPage tabMaxkiv;
        private System.Windows.Forms.TabPage tabMasolas;
        private System.Windows.Forms.TabPage tabKivalogatas;
        private System.Windows.Forms.TabPage tabKivalogatasETomb;
        private System.Windows.Forms.TabPage tabKivalogatasETombEElem;
        private System.Windows.Forms.TabPage tabSzetvalogatas;
        private System.Windows.Forms.TabPage tabSzetvalogatasEgyUj;
        private System.Windows.Forms.TabPage tabSzetvalogatasETomb;
        private System.Windows.Forms.TabPage tabMetszet;
        private System.Windows.Forms.TabPage tabKozosElem;
        private System.Windows.Forms.TabPage tabUnio;
        private System.Windows.Forms.TabPage tabIsmetlodesekKiszur;
        private System.Windows.Forms.TabPage tabOsszefuttatas;
        private System.Windows.Forms.TabPage tabModositottOsszefuttatas;
        private System.Windows.Forms.TabPage tabMasolasESMaxkiv;
        private System.Windows.Forms.TabPage tabMegszamlalasESKereses;
        private System.Windows.Forms.TabPage tabMaxkivESKivalogatas;
        private System.Windows.Forms.TabPage tabKivalogatasESMaxkiv;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.TabPage tabPage17;
        private System.Windows.Forms.TabPage tabPage18;
        private System.Windows.Forms.TabPage tabPage19;
        private System.Windows.Forms.TabPage tabPage20;
        private System.Windows.Forms.TabPage tabPage21;
        private System.Windows.Forms.TextBox textBox_sorozatszamitas;
        private System.Windows.Forms.Label labelTombSegitseg;
        private System.Windows.Forms.RadioButton radioButton_szorzas;
        private System.Windows.Forms.RadioButton radioButton_osszeadas;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_eldontes1;
        private System.Windows.Forms.RadioButton radioButton_eldontes0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_eldontes;
    }
}


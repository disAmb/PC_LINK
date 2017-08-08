namespace WindowsFormsApplication1
{
    partial class frmPcLink
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabLogging = new System.Windows.Forms.TabPage();
            this.tlLoggingTab = new System.Windows.Forms.TableLayoutPanel();
            this.lbComponentDesignator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLoggingCount = new System.Windows.Forms.NumericUpDown();
            this.lbLoggingInterval = new System.Windows.Forms.Label();
            this.lbLoggingSetup = new System.Windows.Forms.Label();
            this.lbLoggingMode = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbLoggingMode = new System.Windows.Forms.ComboBox();
            this.nudLoggingInterval = new System.Windows.Forms.NumericUpDown();
            this.lbSec = new System.Windows.Forms.Label();
            this.lbLoggingCount = new System.Windows.Forms.Label();
            this.cbDataFilter = new System.Windows.Forms.ComboBox();
            this.cbCompDesStat = new System.Windows.Forms.ComboBox();
            this.txbComponentDesignator = new System.Windows.Forms.TextBox();
            this.btLoggingHold = new System.Windows.Forms.Button();
            this.btLoggingClear = new System.Windows.Forms.Button();
            this.btLoggingExport = new System.Windows.Forms.Button();
            this.btStartLogging = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMeasurementSetup = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.tabMID = new System.Windows.Forms.TabPage();
            this.tabVisualMID = new System.Windows.Forms.TabPage();
            this.tabMultimeter = new System.Windows.Forms.TabPage();
            this.tabOsciloscope = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutResults = new System.Windows.Forms.TableLayoutPanel();
            this.pbLCR_Results = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabLogging.SuspendLayout();
            this.tlLoggingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoggingCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoggingInterval)).BeginInit();
            this.tabConfiguration.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLCR_Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 613F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tabControlMain, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1344, 814);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabLogging);
            this.tabControlMain.Controls.Add(this.tabConfiguration);
            this.tabControlMain.Controls.Add(this.tabSystem);
            this.tabControlMain.Controls.Add(this.tabMID);
            this.tabControlMain.Controls.Add(this.tabVisualMID);
            this.tabControlMain.Controls.Add(this.tabMultimeter);
            this.tabControlMain.Controls.Add(this.tabOsciloscope);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.ItemSize = new System.Drawing.Size(40, 26);
            this.tabControlMain.Location = new System.Drawing.Point(5, 5);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(605, 804);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabLogging
            // 
            this.tabLogging.Controls.Add(this.tlLoggingTab);
            this.tabLogging.Location = new System.Drawing.Point(4, 30);
            this.tabLogging.Margin = new System.Windows.Forms.Padding(4);
            this.tabLogging.Name = "tabLogging";
            this.tabLogging.Padding = new System.Windows.Forms.Padding(4);
            this.tabLogging.Size = new System.Drawing.Size(597, 770);
            this.tabLogging.TabIndex = 0;
            this.tabLogging.Text = "Logging    ";
            this.tabLogging.UseVisualStyleBackColor = true;
            // 
            // tlLoggingTab
            // 
            this.tlLoggingTab.ColumnCount = 4;
            this.tlLoggingTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlLoggingTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlLoggingTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlLoggingTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlLoggingTab.Controls.Add(this.lbComponentDesignator, 0, 6);
            this.tlLoggingTab.Controls.Add(this.label1, 0, 5);
            this.tlLoggingTab.Controls.Add(this.nudLoggingCount, 2, 4);
            this.tlLoggingTab.Controls.Add(this.lbLoggingInterval, 0, 3);
            this.tlLoggingTab.Controls.Add(this.lbLoggingSetup, 0, 0);
            this.tlLoggingTab.Controls.Add(this.lbLoggingMode, 0, 2);
            this.tlLoggingTab.Controls.Add(this.button1, 0, 1);
            this.tlLoggingTab.Controls.Add(this.cbLoggingMode, 2, 2);
            this.tlLoggingTab.Controls.Add(this.nudLoggingInterval, 2, 3);
            this.tlLoggingTab.Controls.Add(this.lbSec, 3, 3);
            this.tlLoggingTab.Controls.Add(this.lbLoggingCount, 3, 3);
            this.tlLoggingTab.Controls.Add(this.cbDataFilter, 2, 5);
            this.tlLoggingTab.Controls.Add(this.cbCompDesStat, 3, 6);
            this.tlLoggingTab.Controls.Add(this.txbComponentDesignator, 2, 6);
            this.tlLoggingTab.Controls.Add(this.btLoggingHold, 0, 10);
            this.tlLoggingTab.Controls.Add(this.btLoggingClear, 1, 10);
            this.tlLoggingTab.Controls.Add(this.btLoggingExport, 3, 10);
            this.tlLoggingTab.Controls.Add(this.btStartLogging, 0, 8);
            this.tlLoggingTab.Controls.Add(this.textBox1, 0, 12);
            this.tlLoggingTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlLoggingTab.Location = new System.Drawing.Point(4, 4);
            this.tlLoggingTab.Margin = new System.Windows.Forms.Padding(4);
            this.tlLoggingTab.Name = "tlLoggingTab";
            this.tlLoggingTab.RowCount = 15;
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlLoggingTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlLoggingTab.Size = new System.Drawing.Size(589, 762);
            this.tlLoggingTab.TabIndex = 0;
            // 
            // lbComponentDesignator
            // 
            this.lbComponentDesignator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbComponentDesignator.AutoSize = true;
            this.lbComponentDesignator.BackColor = System.Drawing.Color.White;
            this.tlLoggingTab.SetColumnSpan(this.lbComponentDesignator, 2);
            this.lbComponentDesignator.Location = new System.Drawing.Point(4, 222);
            this.lbComponentDesignator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbComponentDesignator.Name = "lbComponentDesignator";
            this.lbComponentDesignator.Size = new System.Drawing.Size(286, 37);
            this.lbComponentDesignator.TabIndex = 10;
            this.lbComponentDesignator.Text = "Component Designator";
            this.lbComponentDesignator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.tlLoggingTab.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(4, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Filter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudLoggingCount
            // 
            this.nudLoggingCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudLoggingCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudLoggingCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLoggingCount.Location = new System.Drawing.Point(442, 152);
            this.nudLoggingCount.Margin = new System.Windows.Forms.Padding(1, 4, 1, 0);
            this.nudLoggingCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLoggingCount.Name = "nudLoggingCount";
            this.nudLoggingCount.Size = new System.Drawing.Size(146, 29);
            this.nudLoggingCount.TabIndex = 6;
            this.nudLoggingCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLoggingCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbLoggingInterval
            // 
            this.lbLoggingInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoggingInterval.AutoSize = true;
            this.lbLoggingInterval.BackColor = System.Drawing.Color.White;
            this.tlLoggingTab.SetColumnSpan(this.lbLoggingInterval, 2);
            this.lbLoggingInterval.Location = new System.Drawing.Point(4, 111);
            this.lbLoggingInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoggingInterval.Name = "lbLoggingInterval";
            this.lbLoggingInterval.Size = new System.Drawing.Size(286, 37);
            this.lbLoggingInterval.TabIndex = 4;
            this.lbLoggingInterval.Text = "Logging Interval";
            this.lbLoggingInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLoggingSetup
            // 
            this.lbLoggingSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoggingSetup.AutoSize = true;
            this.lbLoggingSetup.BackColor = System.Drawing.Color.White;
            this.tlLoggingTab.SetColumnSpan(this.lbLoggingSetup, 4);
            this.lbLoggingSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoggingSetup.Location = new System.Drawing.Point(4, 0);
            this.lbLoggingSetup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoggingSetup.Name = "lbLoggingSetup";
            this.lbLoggingSetup.Size = new System.Drawing.Size(581, 37);
            this.lbLoggingSetup.TabIndex = 0;
            this.lbLoggingSetup.Text = "Logging Setup";
            this.lbLoggingSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLoggingMode
            // 
            this.lbLoggingMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoggingMode.AutoSize = true;
            this.lbLoggingMode.BackColor = System.Drawing.Color.White;
            this.tlLoggingTab.SetColumnSpan(this.lbLoggingMode, 2);
            this.lbLoggingMode.Location = new System.Drawing.Point(4, 74);
            this.lbLoggingMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoggingMode.Name = "lbLoggingMode";
            this.lbLoggingMode.Size = new System.Drawing.Size(286, 37);
            this.lbLoggingMode.TabIndex = 1;
            this.lbLoggingMode.Text = "Logging Mode";
            this.lbLoggingMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.tlLoggingTab.SetColumnSpan(this.button1, 4);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(1, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(587, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Logging Autoset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbLoggingMode
            // 
            this.cbLoggingMode.DisplayMember = "Continuous";
            this.cbLoggingMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLoggingMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoggingMode.FormattingEnabled = true;
            this.cbLoggingMode.Items.AddRange(new object[] {
            "Continuous",
            "Upto X Count",
            "Press R Key"});
            this.cbLoggingMode.Location = new System.Drawing.Point(295, 75);
            this.cbLoggingMode.Margin = new System.Windows.Forms.Padding(1);
            this.cbLoggingMode.Name = "cbLoggingMode";
            this.cbLoggingMode.Size = new System.Drawing.Size(145, 28);
            this.cbLoggingMode.TabIndex = 3;
            this.cbLoggingMode.Text = "Continuous";
            // 
            // nudLoggingInterval
            // 
            this.nudLoggingInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudLoggingInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudLoggingInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLoggingInterval.Location = new System.Drawing.Point(295, 115);
            this.nudLoggingInterval.Margin = new System.Windows.Forms.Padding(1, 4, 1, 0);
            this.nudLoggingInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLoggingInterval.Name = "nudLoggingInterval";
            this.nudLoggingInterval.Size = new System.Drawing.Size(145, 29);
            this.nudLoggingInterval.TabIndex = 5;
            this.nudLoggingInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLoggingInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbSec
            // 
            this.lbSec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSec.AutoSize = true;
            this.lbSec.BackColor = System.Drawing.Color.White;
            this.lbSec.Location = new System.Drawing.Point(298, 148);
            this.lbSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(139, 37);
            this.lbSec.TabIndex = 7;
            this.lbSec.Text = "(Sec)";
            this.lbSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLoggingCount
            // 
            this.lbLoggingCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoggingCount.AutoSize = true;
            this.lbLoggingCount.BackColor = System.Drawing.Color.White;
            this.tlLoggingTab.SetColumnSpan(this.lbLoggingCount, 2);
            this.lbLoggingCount.Location = new System.Drawing.Point(4, 148);
            this.lbLoggingCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoggingCount.Name = "lbLoggingCount";
            this.lbLoggingCount.Size = new System.Drawing.Size(286, 37);
            this.lbLoggingCount.TabIndex = 6;
            this.lbLoggingCount.Text = "Logging Count";
            this.lbLoggingCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDataFilter
            // 
            this.cbDataFilter.DisplayMember = "Off";
            this.cbDataFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDataFilter.FormattingEnabled = true;
            this.cbDataFilter.Items.AddRange(new object[] {
            "Off",
            "1%",
            "2%",
            "3%",
            "4%",
            "5%",
            "6%",
            "7%",
            "8%",
            "9%",
            "10%"});
            this.cbDataFilter.Location = new System.Drawing.Point(295, 186);
            this.cbDataFilter.Margin = new System.Windows.Forms.Padding(1);
            this.cbDataFilter.Name = "cbDataFilter";
            this.cbDataFilter.Size = new System.Drawing.Size(140, 32);
            this.cbDataFilter.TabIndex = 8;
            this.cbDataFilter.Text = "Off";
            // 
            // cbCompDesStat
            // 
            this.cbCompDesStat.DisplayMember = "Off";
            this.cbCompDesStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompDesStat.FormattingEnabled = true;
            this.cbCompDesStat.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.cbCompDesStat.Location = new System.Drawing.Point(442, 223);
            this.cbCompDesStat.Margin = new System.Windows.Forms.Padding(1);
            this.cbCompDesStat.Name = "cbCompDesStat";
            this.cbCompDesStat.Size = new System.Drawing.Size(140, 32);
            this.cbCompDesStat.TabIndex = 11;
            this.cbCompDesStat.Text = "Off";
            // 
            // txbComponentDesignator
            // 
            this.txbComponentDesignator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbComponentDesignator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComponentDesignator.Location = new System.Drawing.Point(295, 226);
            this.txbComponentDesignator.Margin = new System.Windows.Forms.Padding(1, 4, 1, 1);
            this.txbComponentDesignator.Name = "txbComponentDesignator";
            this.txbComponentDesignator.Size = new System.Drawing.Size(145, 29);
            this.txbComponentDesignator.TabIndex = 12;
            // 
            // btLoggingHold
            // 
            this.btLoggingHold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLoggingHold.Location = new System.Drawing.Point(1, 371);
            this.btLoggingHold.Margin = new System.Windows.Forms.Padding(1);
            this.btLoggingHold.Name = "btLoggingHold";
            this.btLoggingHold.Size = new System.Drawing.Size(145, 35);
            this.btLoggingHold.TabIndex = 14;
            this.btLoggingHold.Text = "Hold";
            this.btLoggingHold.UseVisualStyleBackColor = true;
            // 
            // btLoggingClear
            // 
            this.tlLoggingTab.SetColumnSpan(this.btLoggingClear, 2);
            this.btLoggingClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLoggingClear.Location = new System.Drawing.Point(148, 371);
            this.btLoggingClear.Margin = new System.Windows.Forms.Padding(1);
            this.btLoggingClear.Name = "btLoggingClear";
            this.btLoggingClear.Size = new System.Drawing.Size(292, 35);
            this.btLoggingClear.TabIndex = 15;
            this.btLoggingClear.Text = "Clear";
            this.btLoggingClear.UseVisualStyleBackColor = true;
            // 
            // btLoggingExport
            // 
            this.btLoggingExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLoggingExport.Location = new System.Drawing.Point(442, 371);
            this.btLoggingExport.Margin = new System.Windows.Forms.Padding(1);
            this.btLoggingExport.Name = "btLoggingExport";
            this.btLoggingExport.Size = new System.Drawing.Size(146, 35);
            this.btLoggingExport.TabIndex = 16;
            this.btLoggingExport.Text = "Export";
            this.btLoggingExport.UseVisualStyleBackColor = true;
            // 
            // btStartLogging
            // 
            this.tlLoggingTab.SetColumnSpan(this.btStartLogging, 4);
            this.btStartLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btStartLogging.Location = new System.Drawing.Point(1, 297);
            this.btStartLogging.Margin = new System.Windows.Forms.Padding(1);
            this.btStartLogging.Name = "btStartLogging";
            this.tlLoggingTab.SetRowSpan(this.btStartLogging, 2);
            this.btStartLogging.Size = new System.Drawing.Size(587, 72);
            this.btStartLogging.TabIndex = 13;
            this.btStartLogging.Text = "Start Logging";
            this.btStartLogging.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.tlLoggingTab.SetColumnSpan(this.textBox1, 4);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1, 448);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1, 4, 1, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.tlLoggingTab.SetRowSpan(this.textBox1, 3);
            this.textBox1.Size = new System.Drawing.Size(587, 313);
            this.textBox1.TabIndex = 17;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Controls.Add(this.tableLayoutPanel1);
            this.tabConfiguration.Location = new System.Drawing.Point(4, 30);
            this.tabConfiguration.Margin = new System.Windows.Forms.Padding(4);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Padding = new System.Windows.Forms.Padding(4);
            this.tabConfiguration.Size = new System.Drawing.Size(597, 770);
            this.tabConfiguration.TabIndex = 1;
            this.tabConfiguration.Text = "Configuration  ";
            this.tabConfiguration.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbMeasurementSetup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBox3, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.button5, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 12);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 762);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(4, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Component Designator";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(4, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data Filter";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(442, 152);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(1, 4, 1, 0);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(146, 29);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Location = new System.Drawing.Point(4, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Logging Interval";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMeasurementSetup
            // 
            this.lbMeasurementSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMeasurementSetup.AutoSize = true;
            this.lbMeasurementSetup.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.lbMeasurementSetup, 4);
            this.lbMeasurementSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMeasurementSetup.Location = new System.Drawing.Point(4, 0);
            this.lbMeasurementSetup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMeasurementSetup.Name = "lbMeasurementSetup";
            this.lbMeasurementSetup.Size = new System.Drawing.Size(581, 37);
            this.lbMeasurementSetup.TabIndex = 0;
            this.lbMeasurementSetup.Text = "Measurement Setup";
            this.lbMeasurementSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.label6, 2);
            this.label6.Location = new System.Drawing.Point(4, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Logging Mode";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button2, 2);
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(295, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Logging Autoset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Continuous";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Continuous",
            "Upto X Count",
            "Press R Key"});
            this.comboBox1.Location = new System.Drawing.Point(295, 75);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Continuous";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(295, 115);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(1, 4, 1, 0);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(145, 29);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(298, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "(Sec)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 2);
            this.label8.Location = new System.Drawing.Point(4, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(286, 37);
            this.label8.TabIndex = 6;
            this.label8.Text = "Logging Count";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Off";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Off",
            "1%",
            "2%",
            "3%",
            "4%",
            "5%",
            "6%",
            "7%",
            "8%",
            "9%",
            "10%"});
            this.comboBox2.Location = new System.Drawing.Point(295, 186);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 32);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "Off";
            // 
            // comboBox3
            // 
            this.comboBox3.DisplayMember = "Off";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.comboBox3.Location = new System.Drawing.Point(442, 223);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 32);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.Text = "Off";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(295, 226);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1, 4, 1, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 29);
            this.textBox2.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(1, 371);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Hold";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button4, 2);
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(148, 371);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(292, 35);
            this.button4.TabIndex = 15;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(442, 371);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 35);
            this.button5.TabIndex = 16;
            this.button5.Text = "Export";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button6, 4);
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(1, 297);
            this.button6.Margin = new System.Windows.Forms.Padding(1);
            this.button6.Name = "button6";
            this.tableLayoutPanel1.SetRowSpan(this.button6, 2);
            this.button6.Size = new System.Drawing.Size(587, 72);
            this.button6.TabIndex = 13;
            this.button6.Text = "Start Logging";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox3, 4);
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(1, 448);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1, 4, 1, 1);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.tableLayoutPanel1.SetRowSpan(this.textBox3, 3);
            this.textBox3.Size = new System.Drawing.Size(587, 313);
            this.textBox3.TabIndex = 17;
            // 
            // tabSystem
            // 
            this.tabSystem.Location = new System.Drawing.Point(4, 30);
            this.tabSystem.Margin = new System.Windows.Forms.Padding(4);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Padding = new System.Windows.Forms.Padding(4);
            this.tabSystem.Size = new System.Drawing.Size(597, 770);
            this.tabSystem.TabIndex = 2;
            this.tabSystem.Text = "System    ";
            this.tabSystem.UseVisualStyleBackColor = true;
            // 
            // tabMID
            // 
            this.tabMID.Location = new System.Drawing.Point(4, 30);
            this.tabMID.Margin = new System.Windows.Forms.Padding(4);
            this.tabMID.Name = "tabMID";
            this.tabMID.Padding = new System.Windows.Forms.Padding(4);
            this.tabMID.Size = new System.Drawing.Size(597, 770);
            this.tabMID.TabIndex = 3;
            this.tabMID.Text = "MultipleID    ";
            this.tabMID.UseVisualStyleBackColor = true;
            // 
            // tabVisualMID
            // 
            this.tabVisualMID.Location = new System.Drawing.Point(4, 30);
            this.tabVisualMID.Margin = new System.Windows.Forms.Padding(4);
            this.tabVisualMID.Name = "tabVisualMID";
            this.tabVisualMID.Padding = new System.Windows.Forms.Padding(4);
            this.tabVisualMID.Size = new System.Drawing.Size(597, 770);
            this.tabVisualMID.TabIndex = 4;
            this.tabVisualMID.Text = "Visual MID  ";
            this.tabVisualMID.UseVisualStyleBackColor = true;
            this.tabVisualMID.Click += new System.EventHandler(this.tabVisualMID_Click);
            // 
            // tabMultimeter
            // 
            this.tabMultimeter.Location = new System.Drawing.Point(4, 30);
            this.tabMultimeter.Margin = new System.Windows.Forms.Padding(4);
            this.tabMultimeter.Name = "tabMultimeter";
            this.tabMultimeter.Size = new System.Drawing.Size(597, 770);
            this.tabMultimeter.TabIndex = 5;
            this.tabMultimeter.Text = "Multimeter";
            this.tabMultimeter.UseVisualStyleBackColor = true;
            // 
            // tabOsciloscope
            // 
            this.tabOsciloscope.Location = new System.Drawing.Point(4, 30);
            this.tabOsciloscope.Margin = new System.Windows.Forms.Padding(4);
            this.tabOsciloscope.Name = "tabOsciloscope";
            this.tabOsciloscope.Size = new System.Drawing.Size(597, 770);
            this.tabOsciloscope.TabIndex = 6;
            this.tabOsciloscope.Text = "Osciloscope";
            this.tabOsciloscope.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutResults);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(615, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 812);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutResults
            // 
            this.tableLayoutResults.ColumnCount = 1;
            this.tableLayoutResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutResults.Controls.Add(this.pbLCR_Results, 0, 1);
            this.tableLayoutResults.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutResults.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutResults.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutResults.Name = "tableLayoutResults";
            this.tableLayoutResults.RowCount = 2;
            this.tableLayoutResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutResults.Size = new System.Drawing.Size(728, 812);
            this.tableLayoutResults.TabIndex = 0;
            // 
            // pbLCR_Results
            // 
            this.pbLCR_Results.BackColor = System.Drawing.Color.Silver;
            this.pbLCR_Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLCR_Results.Location = new System.Drawing.Point(4, 594);
            this.pbLCR_Results.Margin = new System.Windows.Forms.Padding(4);
            this.pbLCR_Results.Name = "pbLCR_Results";
            this.pbLCR_Results.Size = new System.Drawing.Size(720, 214);
            this.pbLCR_Results.TabIndex = 0;
            this.pbLCR_Results.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 582);
            this.dataGridView1.TabIndex = 1;
            // 
            // frmPcLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 814);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPcLink";
            this.Text = "PC LINK";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabLogging.ResumeLayout(false);
            this.tlLoggingTab.ResumeLayout(false);
            this.tlLoggingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoggingCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoggingInterval)).EndInit();
            this.tabConfiguration.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLCR_Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabLogging;
        private System.Windows.Forms.TabPage tabConfiguration;
        private System.Windows.Forms.TabPage tabSystem;
        private System.Windows.Forms.TabPage tabMID;
        private System.Windows.Forms.TabPage tabVisualMID;
        private System.Windows.Forms.TableLayoutPanel tlLoggingTab;
        private System.Windows.Forms.Label lbLoggingSetup;
        private System.Windows.Forms.Label lbLoggingMode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbLoggingMode;
        private System.Windows.Forms.Label lbLoggingInterval;
        private System.Windows.Forms.NumericUpDown nudLoggingInterval;
        private System.Windows.Forms.Label lbLoggingCount;
        private System.Windows.Forms.Label lbComponentDesignator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLoggingCount;
        private System.Windows.Forms.Label lbSec;
        private System.Windows.Forms.ComboBox cbDataFilter;
        private System.Windows.Forms.ComboBox cbCompDesStat;
        private System.Windows.Forms.TextBox txbComponentDesignator;
        private System.Windows.Forms.Button btLoggingHold;
        private System.Windows.Forms.Button btLoggingClear;
        private System.Windows.Forms.Button btLoggingExport;
        private System.Windows.Forms.Button btStartLogging;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutResults;
        private System.Windows.Forms.PictureBox pbLCR_Results;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMeasurementSetup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage tabMultimeter;
        private System.Windows.Forms.TabPage tabOsciloscope;
    }
}


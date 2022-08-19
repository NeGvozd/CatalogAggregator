namespace WorkParser2;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SntCheck = new System.Windows.Forms.CheckBox();
            this.UdtCheck = new System.Windows.Forms.CheckBox();
            this.T2kCheck = new System.Windows.Forms.CheckBox();
            this.RenCheck = new System.Windows.Forms.CheckBox();
            this.RecCheck = new System.Windows.Forms.CheckBox();
            this.AkpCheck = new System.Windows.Forms.CheckBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AboutButton = new System.Windows.Forms.ToolStripButton();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ToExcelButton = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BreakButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "Введите здесь запрашиваемые артикулы, по одному в строку";
            this.textBox1.AccessibleName = "Поле для ввода";
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBox1.AllowDrop = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(81)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox1.Location = new System.Drawing.Point(36, 302);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Введите здесь артикулы для поиска, по одному в строку";
            this.textBox1.Size = new System.Drawing.Size(290, 448);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(131)))), ((int)(((byte)(249)))));
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(131)))), ((int)(((byte)(249)))));
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(90)))), ((int)(((byte)(172)))));
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StartButton.Location = new System.Drawing.Point(36, 27);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(128, 42);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "ПОИСК";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(76)))));
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(122)))), ((int)(((byte)(53)))));
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(19)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClearButton.Location = new System.Drawing.Point(36, 86);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(128, 42);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "ОЧИСТИТЬ";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SntCheck
            // 
            this.SntCheck.AutoSize = true;
            this.SntCheck.Checked = true;
            this.SntCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SntCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SntCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SntCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SntCheck.Location = new System.Drawing.Point(3, 3);
            this.SntCheck.Name = "SntCheck";
            this.SntCheck.Size = new System.Drawing.Size(60, 28);
            this.SntCheck.TabIndex = 3;
            this.SntCheck.Tag = "1";
            this.SntCheck.Text = "SNT";
            this.SntCheck.UseVisualStyleBackColor = true;
            // 
            // UdtCheck
            // 
            this.UdtCheck.AutoSize = true;
            this.UdtCheck.Checked = true;
            this.UdtCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UdtCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UdtCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UdtCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UdtCheck.Location = new System.Drawing.Point(69, 3);
            this.UdtCheck.Name = "UdtCheck";
            this.UdtCheck.Size = new System.Drawing.Size(60, 28);
            this.UdtCheck.TabIndex = 4;
            this.UdtCheck.Tag = "2";
            this.UdtCheck.Text = "UDT";
            this.UdtCheck.UseVisualStyleBackColor = true;
            // 
            // T2kCheck
            // 
            this.T2kCheck.AutoSize = true;
            this.T2kCheck.Checked = true;
            this.T2kCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.T2kCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.T2kCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.T2kCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.T2kCheck.Location = new System.Drawing.Point(135, 3);
            this.T2kCheck.Name = "T2kCheck";
            this.T2kCheck.Size = new System.Drawing.Size(60, 28);
            this.T2kCheck.TabIndex = 5;
            this.T2kCheck.Tag = "3";
            this.T2kCheck.Text = "T2K";
            this.T2kCheck.UseVisualStyleBackColor = true;
            // 
            // RenCheck
            // 
            this.RenCheck.AutoSize = true;
            this.RenCheck.Checked = true;
            this.RenCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RenCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RenCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RenCheck.Location = new System.Drawing.Point(201, 3);
            this.RenCheck.Name = "RenCheck";
            this.RenCheck.Size = new System.Drawing.Size(63, 28);
            this.RenCheck.TabIndex = 6;
            this.RenCheck.Tag = "4";
            this.RenCheck.Text = "REN";
            this.RenCheck.UseVisualStyleBackColor = true;
            // 
            // RecCheck
            // 
            this.RecCheck.AutoSize = true;
            this.RecCheck.Checked = true;
            this.RecCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RecCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RecCheck.Location = new System.Drawing.Point(3, 37);
            this.RecCheck.Name = "RecCheck";
            this.RecCheck.Size = new System.Drawing.Size(60, 31);
            this.RecCheck.TabIndex = 7;
            this.RecCheck.Tag = "5";
            this.RecCheck.Text = "REC";
            this.RecCheck.UseVisualStyleBackColor = true;
            // 
            // AkpCheck
            // 
            this.AkpCheck.AutoSize = true;
            this.AkpCheck.Checked = true;
            this.AkpCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AkpCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AkpCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AkpCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AkpCheck.Location = new System.Drawing.Point(69, 37);
            this.AkpCheck.Name = "AkpCheck";
            this.AkpCheck.Size = new System.Drawing.Size(60, 31);
            this.AkpCheck.TabIndex = 8;
            this.AkpCheck.Tag = "6";
            this.AkpCheck.Text = "AKP";
            this.AkpCheck.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(985, 753);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutButton,
            this.progressBar1,
            this.ToExcelButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1323, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AboutButton
            // 
            this.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(88, 22);
            this.AboutButton.Text = "О Программе";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(72)))));
            this.progressBar1.ForeColor = System.Drawing.Color.Blue;
            this.progressBar1.Margin = new System.Windows.Forms.Padding(50, 2, 0, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(337, 22);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.ToolTipText = "Прогресс поиска";
            // 
            // ToExcelButton
            // 
            this.ToExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ToExcelButton.Image")));
            this.ToExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToExcelButton.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.ToExcelButton.Name = "ToExcelButton";
            this.ToExcelButton.Size = new System.Drawing.Size(95, 22);
            this.ToExcelButton.Text = "Экспорт в Excel";
            this.ToExcelButton.Click += new System.EventHandler(this.ToExcelButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(985, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 753);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(86)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(39, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "__________________________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(81)))));
            this.panel3.Controls.Add(this.StartButton);
            this.panel3.Controls.Add(this.BreakButton);
            this.panel3.Controls.Add(this.ClearButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.panel3.Size = new System.Drawing.Size(338, 131);
            this.panel3.TabIndex = 17;
            // 
            // BreakButton
            // 
            this.BreakButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BreakButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(82)))));
            this.BreakButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BreakButton.Enabled = false;
            this.BreakButton.FlatAppearance.BorderSize = 0;
            this.BreakButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.BreakButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BreakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BreakButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BreakButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BreakButton.Location = new System.Drawing.Point(175, 27);
            this.BreakButton.Name = "BreakButton";
            this.BreakButton.Size = new System.Drawing.Size(128, 42);
            this.BreakButton.TabIndex = 15;
            this.BreakButton.Text = "ОТМЕНИТЬ";
            this.BreakButton.UseVisualStyleBackColor = false;
            this.BreakButton.Click += new System.EventHandler(this.BreakButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(86)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(39, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "__________________________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.SntCheck, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.T2kCheck, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.UdtCheck, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RenCheck, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.RecCheck, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AkpCheck, 1, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 190);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 71);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 753);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 778);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1338, 816);
            this.Name = "Form1";
            this.Text = "Прайс Агрегатор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private Button StartButton;
    private Button ClearButton;
    private CheckBox SntCheck;
    private CheckBox UdtCheck;
    private CheckBox T2kCheck;
    private CheckBox RenCheck;
    private CheckBox RecCheck;
    private CheckBox AkpCheck;
    public TextBox textBox1;
    public DataGridView dataGridView1;
    public System.ComponentModel.BackgroundWorker backgroundWorker;
    private ToolStrip toolStrip1;
    private Panel panel2;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private ToolStripButton AboutButton;
    public ToolStripProgressBar progressBar1;
    private Button BreakButton;
    private ToolStripButton ToExcelButton;
    private Label label1;
    private Label label2;
    private Panel panel3;
}

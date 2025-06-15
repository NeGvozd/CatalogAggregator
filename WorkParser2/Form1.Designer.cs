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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        textBox1 = new TextBox();
        StartButton = new Button();
        ClearButton = new Button();
        SntCheck = new CheckBox();
        UdtCheck = new CheckBox();
        T2kCheck = new CheckBox();
        RenCheck = new CheckBox();
        RecCheck = new CheckBox();
        AkpCheck = new CheckBox();
        backgroundWorker = new System.ComponentModel.BackgroundWorker();
        dataGridView1 = new DataGridView();
        toolStrip1 = new ToolStrip();
        AboutButton = new ToolStripButton();
        progressBar1 = new ToolStripProgressBar();
        ToExcelButton = new ToolStripButton();
        panel2 = new Panel();
        label2 = new Label();
        panel3 = new Panel();
        BreakButton = new Button();
        label1 = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        panel1 = new Panel();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        toolStrip1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.AccessibleDescription = "Введите здесь запрашиваемые артикулы, по одному в строку";
        textBox1.AccessibleName = "Поле для ввода";
        textBox1.AccessibleRole = AccessibleRole.Text;
        textBox1.AllowDrop = true;
        textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        textBox1.BackColor = Color.FromArgb(63, 66, 81);
        textBox1.BorderStyle = BorderStyle.None;
        textBox1.Font = new Font("Segoe UI", 11.25F);
        textBox1.ForeColor = Color.WhiteSmoke;
        textBox1.ImeMode = ImeMode.Off;
        textBox1.Location = new Point(36, 302);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.PlaceholderText = "Введите здесь артикулы для поиска, по одному в строку";
        textBox1.Size = new Size(290, 448);
        textBox1.TabIndex = 0;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // StartButton
        // 
        StartButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        StartButton.BackColor = Color.WhiteSmoke;
        StartButton.Cursor = Cursors.Hand;
        StartButton.FlatAppearance.BorderColor = Color.FromArgb(60, 131, 249);
        StartButton.FlatAppearance.BorderSize = 0;
        StartButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 107, 197);
        StartButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 134, 255);
        StartButton.FlatStyle = FlatStyle.Flat;
        StartButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
        StartButton.ForeColor = Color.Black;
        StartButton.Location = new Point(36, 27);
        StartButton.Name = "StartButton";
        StartButton.Size = new Size(128, 42);
        StartButton.TabIndex = 1;
        StartButton.Text = "ПОИСК";
        StartButton.UseVisualStyleBackColor = false;
        StartButton.Click += StartButton_Click;
        // 
        // ClearButton
        // 
        ClearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        ClearButton.BackColor = Color.WhiteSmoke;
        ClearButton.Cursor = Cursors.Hand;
        ClearButton.FlatAppearance.BorderSize = 0;
        ClearButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 119, 15);
        ClearButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 149, 19);
        ClearButton.FlatStyle = FlatStyle.Flat;
        ClearButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
        ClearButton.ForeColor = Color.Black;
        ClearButton.Location = new Point(36, 86);
        ClearButton.Name = "ClearButton";
        ClearButton.Size = new Size(128, 42);
        ClearButton.TabIndex = 2;
        ClearButton.Text = "ОЧИСТИТЬ";
        ClearButton.UseVisualStyleBackColor = false;
        ClearButton.Click += ClearButton_Click;
        // 
        // SntCheck
        // 
        SntCheck.AutoSize = true;
        SntCheck.Checked = true;
        SntCheck.CheckState = CheckState.Checked;
        SntCheck.Cursor = Cursors.Hand;
        SntCheck.Dock = DockStyle.Fill;
        SntCheck.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
        SntCheck.Location = new Point(3, 3);
        SntCheck.Name = "SntCheck";
        SntCheck.Size = new Size(58, 28);
        SntCheck.TabIndex = 3;
        SntCheck.Tag = "1";
        SntCheck.Text = "SNT";
        SntCheck.UseVisualStyleBackColor = true;
        // 
        // UdtCheck
        // 
        UdtCheck.AutoSize = true;
        UdtCheck.Checked = true;
        UdtCheck.CheckState = CheckState.Checked;
        UdtCheck.Cursor = Cursors.Hand;
        UdtCheck.Dock = DockStyle.Fill;
        UdtCheck.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
        UdtCheck.Location = new Point(67, 3);
        UdtCheck.Name = "UdtCheck";
        UdtCheck.Size = new Size(62, 28);
        UdtCheck.TabIndex = 4;
        UdtCheck.Tag = "2";
        UdtCheck.Text = "UDT";
        UdtCheck.UseVisualStyleBackColor = true;
        // 
        // T2kCheck
        // 
        T2kCheck.AutoSize = true;
        T2kCheck.Checked = true;
        T2kCheck.CheckState = CheckState.Checked;
        T2kCheck.Cursor = Cursors.Hand;
        T2kCheck.Dock = DockStyle.Fill;
        T2kCheck.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
        T2kCheck.Location = new Point(135, 3);
        T2kCheck.Name = "T2kCheck";
        T2kCheck.Size = new Size(57, 28);
        T2kCheck.TabIndex = 5;
        T2kCheck.Tag = "3";
        T2kCheck.Text = "T2K";
        T2kCheck.UseVisualStyleBackColor = true;
        // 
        // RenCheck
        // 
        RenCheck.AutoSize = true;
        RenCheck.Checked = true;
        RenCheck.CheckState = CheckState.Checked;
        RenCheck.Cursor = Cursors.Hand;
        RenCheck.Dock = DockStyle.Fill;
        RenCheck.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
        RenCheck.Location = new Point(198, 3);
        RenCheck.Name = "RenCheck";
        RenCheck.Size = new Size(66, 28);
        RenCheck.TabIndex = 6;
        RenCheck.Tag = "4";
        RenCheck.Text = "MOD";
        RenCheck.UseVisualStyleBackColor = true;
        // 
        // RecCheck
        // 
        RecCheck.AutoSize = true;
        RecCheck.Checked = true;
        RecCheck.CheckState = CheckState.Checked;
        RecCheck.Cursor = Cursors.Hand;
        RecCheck.Dock = DockStyle.Fill;
        RecCheck.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
        RecCheck.Location = new Point(3, 37);
        RecCheck.Name = "RecCheck";
        RecCheck.Size = new Size(58, 31);
        RecCheck.TabIndex = 7;
        RecCheck.Tag = "5";
        RecCheck.Text = "REC";
        RecCheck.UseVisualStyleBackColor = true;
        // 
        // AkpCheck
        // 
        AkpCheck.AutoSize = true;
        AkpCheck.Checked = true;
        AkpCheck.CheckState = CheckState.Checked;
        AkpCheck.Cursor = Cursors.Hand;
        AkpCheck.Dock = DockStyle.Fill;
        AkpCheck.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
        AkpCheck.Location = new Point(67, 37);
        AkpCheck.Name = "AkpCheck";
        AkpCheck.Size = new Size(62, 31);
        AkpCheck.TabIndex = 8;
        AkpCheck.Tag = "6";
        AkpCheck.Text = "AKP";
        AkpCheck.UseVisualStyleBackColor = true;
        // 
        // backgroundWorker
        // 
        backgroundWorker.WorkerReportsProgress = true;
        backgroundWorker.WorkerSupportsCancellation = true;
        backgroundWorker.DoWork += backgroundWorker_DoWork;
        backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
        backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.White;
        dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        dataGridView1.BackgroundColor = Color.WhiteSmoke;
        dataGridView1.BorderStyle = BorderStyle.None;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Control;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F);
        dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
        dataGridView1.Dock = DockStyle.Fill;
        dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        dataGridView1.Location = new Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
        dataGridView1.Size = new Size(985, 753);
        dataGridView1.TabIndex = 11;
        dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        dataGridView1.CellPainting += dataGridView1_CellPainting;
        // 
        // toolStrip1
        // 
        toolStrip1.BackColor = Color.WhiteSmoke;
        toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
        toolStrip1.Items.AddRange(new ToolStripItem[] { AboutButton, progressBar1, ToExcelButton });
        toolStrip1.Location = new Point(0, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.RenderMode = ToolStripRenderMode.Professional;
        toolStrip1.Size = new Size(1323, 25);
        toolStrip1.TabIndex = 12;
        toolStrip1.Text = "toolStrip1";
        // 
        // AboutButton
        // 
        AboutButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        AboutButton.Image = (Image)resources.GetObject("AboutButton.Image");
        AboutButton.ImageTransparentColor = Color.Magenta;
        AboutButton.Name = "AboutButton";
        AboutButton.Size = new Size(88, 22);
        AboutButton.Text = "О Программе";
        AboutButton.Click += AboutButton_Click;
        // 
        // progressBar1
        // 
        progressBar1.Alignment = ToolStripItemAlignment.Right;
        progressBar1.BackColor = Color.FromArgb(40, 53, 72);
        progressBar1.ForeColor = Color.Blue;
        progressBar1.Margin = new Padding(50, 2, 0, 1);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(337, 22);
        progressBar1.Style = ProgressBarStyle.Continuous;
        progressBar1.ToolTipText = "Прогресс поиска";
        // 
        // ToExcelButton
        // 
        ToExcelButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        ToExcelButton.Image = (Image)resources.GetObject("ToExcelButton.Image");
        ToExcelButton.ImageTransparentColor = Color.Magenta;
        ToExcelButton.Margin = new Padding(10, 1, 0, 2);
        ToExcelButton.Name = "ToExcelButton";
        ToExcelButton.Size = new Size(94, 22);
        ToExcelButton.Text = "Экспорт в Excel";
        ToExcelButton.Click += ToExcelButton_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(63, 66, 81);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(panel3);
        panel2.Controls.Add(label1);
        panel2.Controls.Add(tableLayoutPanel1);
        panel2.Controls.Add(textBox1);
        panel2.Dock = DockStyle.Right;
        panel2.Location = new Point(985, 25);
        panel2.Name = "panel2";
        panel2.Size = new Size(338, 753);
        panel2.TabIndex = 13;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.FlatStyle = FlatStyle.Flat;
        label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
        label2.ForeColor = Color.FromArgb(83, 86, 100);
        label2.Location = new Point(39, 145);
        label2.Name = "label2";
        label2.Size = new Size(261, 20);
        label2.TabIndex = 18;
        label2.Text = "__________________________________________";
        label2.TextAlign = ContentAlignment.TopCenter;
        // 
        // panel3
        // 
        panel3.BackColor = Color.FromArgb(63, 66, 81);
        panel3.Controls.Add(StartButton);
        panel3.Controls.Add(BreakButton);
        panel3.Controls.Add(ClearButton);
        panel3.Dock = DockStyle.Top;
        panel3.Location = new Point(0, 0);
        panel3.Name = "panel3";
        panel3.Padding = new Padding(0, 20, 0, 20);
        panel3.Size = new Size(338, 131);
        panel3.TabIndex = 17;
        // 
        // BreakButton
        // 
        BreakButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        BreakButton.BackColor = Color.WhiteSmoke;
        BreakButton.Cursor = Cursors.Hand;
        BreakButton.Enabled = false;
        BreakButton.FlatAppearance.BorderSize = 0;
        BreakButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 64, 65);
        BreakButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 81, 82);
        BreakButton.FlatStyle = FlatStyle.Flat;
        BreakButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
        BreakButton.ForeColor = Color.Black;
        BreakButton.Location = new Point(175, 27);
        BreakButton.Name = "BreakButton";
        BreakButton.Size = new Size(128, 42);
        BreakButton.TabIndex = 15;
        BreakButton.Text = "ОТМЕНИТЬ";
        BreakButton.UseVisualStyleBackColor = false;
        BreakButton.Click += BreakButton_Click;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.FlatStyle = FlatStyle.Flat;
        label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
        label1.ForeColor = Color.FromArgb(83, 86, 100);
        label1.Location = new Point(39, 263);
        label1.Name = "label1";
        label1.Size = new Size(261, 20);
        label1.TabIndex = 16;
        label1.Text = "__________________________________________";
        label1.TextAlign = ContentAlignment.TopCenter;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.9700375F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.4681644F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5955048F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9662914F));
        tableLayoutPanel1.Controls.Add(SntCheck, 0, 0);
        tableLayoutPanel1.Controls.Add(T2kCheck, 2, 0);
        tableLayoutPanel1.Controls.Add(UdtCheck, 1, 0);
        tableLayoutPanel1.Controls.Add(RenCheck, 3, 0);
        tableLayoutPanel1.Controls.Add(RecCheck, 0, 1);
        tableLayoutPanel1.Controls.Add(AkpCheck, 1, 1);
        tableLayoutPanel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        tableLayoutPanel1.ForeColor = Color.WhiteSmoke;
        tableLayoutPanel1.Location = new Point(36, 190);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.21429F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.78571F));
        tableLayoutPanel1.Size = new Size(267, 71);
        tableLayoutPanel1.TabIndex = 14;
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panel1.Controls.Add(dataGridView1);
        panel1.Location = new Point(0, 25);
        panel1.Name = "panel1";
        panel1.Size = new Size(985, 753);
        panel1.TabIndex = 14;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1323, 778);
        Controls.Add(panel1);
        Controls.Add(panel2);
        Controls.Add(toolStrip1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(1338, 816);
        Name = "Form1";
        Text = "Прайс Агрегатор";
        WindowState = FormWindowState.Maximized;
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel3.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
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

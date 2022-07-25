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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AboutButton = new System.Windows.Forms.ToolStripButton();
            this.ToExcelButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ProgressStatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "Введите здесь запрашиваемые артикулы, по одному в строку";
            this.textBox1.AccessibleName = "Поле для ввода";
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(3, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(273, 517);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(139, 44);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(134, 24);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Location = new System.Drawing.Point(139, 74);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(134, 24);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SntCheck
            // 
            this.SntCheck.AutoSize = true;
            this.SntCheck.Checked = true;
            this.SntCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SntCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SntCheck.Location = new System.Drawing.Point(3, 3);
            this.SntCheck.Name = "SntCheck";
            this.SntCheck.Size = new System.Drawing.Size(62, 21);
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
            this.UdtCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UdtCheck.Location = new System.Drawing.Point(71, 3);
            this.UdtCheck.Name = "UdtCheck";
            this.UdtCheck.Size = new System.Drawing.Size(55, 21);
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
            this.T2kCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.T2kCheck.Location = new System.Drawing.Point(132, 3);
            this.T2kCheck.Name = "T2kCheck";
            this.T2kCheck.Size = new System.Drawing.Size(60, 21);
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
            this.RenCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenCheck.Location = new System.Drawing.Point(198, 3);
            this.RenCheck.Name = "RenCheck";
            this.RenCheck.Size = new System.Drawing.Size(69, 21);
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
            this.RecCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecCheck.Location = new System.Drawing.Point(3, 30);
            this.RecCheck.Name = "RecCheck";
            this.RecCheck.Size = new System.Drawing.Size(62, 23);
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
            this.AkpCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AkpCheck.Location = new System.Drawing.Point(71, 30);
            this.AkpCheck.Name = "AkpCheck";
            this.AkpCheck.Size = new System.Drawing.Size(55, 23);
            this.AkpCheck.TabIndex = 8;
            this.AkpCheck.Tag = "6";
            this.AkpCheck.Text = "AKP";
            this.AkpCheck.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(0, 686);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(276, 26);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 712);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutButton,
            this.ToExcelButton,
            this.toolStripProgressBar1,
            this.ProgressStatusLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
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
            // 
            // ToExcelButton
            // 
            this.ToExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ToExcelButton.Image")));
            this.ToExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToExcelButton.Name = "ToExcelButton";
            this.ToExcelButton.Size = new System.Drawing.Size(48, 22);
            this.ToExcelButton.Text = "В Excel";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(50, 2, 1, 1);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 22);
            // 
            // ProgressStatusLabel
            // 
            this.ProgressStatusLabel.Name = "ProgressStatusLabel";
            this.ProgressStatusLabel.Size = new System.Drawing.Size(80, 22);
            this.ProgressStatusLabel.Text = "ProgressLabel";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.StartButton);
            this.panel2.Location = new System.Drawing.Point(1047, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 712);
            this.panel2.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.71318F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.28682F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Controls.Add(this.SntCheck, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.T2kCheck, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.UdtCheck, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RenCheck, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.RecCheck, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AkpCheck, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 56);
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
            this.panel1.Size = new System.Drawing.Size(1044, 712);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 737);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Каталожный Агрегатор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    public ProgressBar progressBar1;
    public System.ComponentModel.BackgroundWorker backgroundWorker;
    private ToolStrip toolStrip1;
    private Panel panel2;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private ToolStripButton AboutButton;
    private ToolStripButton ToExcelButton;
    private ToolStripProgressBar toolStripProgressBar1;
    private ToolStripLabel ProgressStatusLabel;
}

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(1037, 129);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(274, 567);
            this.textBox1.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(1177, 12);
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
            this.ClearButton.Location = new System.Drawing.Point(1177, 42);
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
            this.SntCheck.Location = new System.Drawing.Point(13, 3);
            this.SntCheck.Name = "SntCheck";
            this.SntCheck.Size = new System.Drawing.Size(47, 19);
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
            this.UdtCheck.Location = new System.Drawing.Point(66, 3);
            this.UdtCheck.Name = "UdtCheck";
            this.UdtCheck.Size = new System.Drawing.Size(47, 19);
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
            this.T2kCheck.Location = new System.Drawing.Point(116, 3);
            this.T2kCheck.Name = "T2kCheck";
            this.T2kCheck.Size = new System.Drawing.Size(45, 19);
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
            this.RenCheck.Location = new System.Drawing.Point(167, 3);
            this.RenCheck.Name = "RenCheck";
            this.RenCheck.Size = new System.Drawing.Size(48, 19);
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
            this.RecCheck.Location = new System.Drawing.Point(13, 28);
            this.RecCheck.Name = "RecCheck";
            this.RecCheck.Size = new System.Drawing.Size(47, 19);
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
            this.AkpCheck.Location = new System.Drawing.Point(221, 3);
            this.AkpCheck.Name = "AkpCheck";
            this.AkpCheck.Size = new System.Drawing.Size(48, 19);
            this.AkpCheck.TabIndex = 8;
            this.AkpCheck.Tag = "6";
            this.AkpCheck.Text = "AKP";
            this.AkpCheck.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(1037, 702);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(283, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.SntCheck);
            this.panel1.Controls.Add(this.UdtCheck);
            this.panel1.Controls.Add(this.RecCheck);
            this.panel1.Controls.Add(this.AkpCheck);
            this.panel1.Controls.Add(this.T2kCheck);
            this.panel1.Controls.Add(this.RenCheck);
            this.panel1.Location = new System.Drawing.Point(1037, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 51);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 725);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 737);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    private ProgressBar progressBar1;
    private System.ComponentModel.BackgroundWorker backgroundWorker;
    public TextBox textBox1;
    private Panel panel1;
    public DataGridView dataGridView1;
}

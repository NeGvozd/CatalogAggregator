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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(761, 645);
            this.textBox1.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(779, 10);
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
            this.ClearButton.Location = new System.Drawing.Point(779, 40);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(134, 24);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SntCheck
            // 
            this.SntCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SntCheck.AutoSize = true;
            this.SntCheck.Checked = true;
            this.SntCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SntCheck.Location = new System.Drawing.Point(779, 83);
            this.SntCheck.Name = "SntCheck";
            this.SntCheck.Size = new System.Drawing.Size(47, 19);
            this.SntCheck.TabIndex = 3;
            this.SntCheck.Tag = "1";
            this.SntCheck.Text = "SNT";
            this.SntCheck.UseVisualStyleBackColor = true;
            // 
            // UdtCheck
            // 
            this.UdtCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UdtCheck.AutoSize = true;
            this.UdtCheck.Checked = true;
            this.UdtCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UdtCheck.Location = new System.Drawing.Point(779, 109);
            this.UdtCheck.Name = "UdtCheck";
            this.UdtCheck.Size = new System.Drawing.Size(47, 19);
            this.UdtCheck.TabIndex = 4;
            this.UdtCheck.Tag = "2";
            this.UdtCheck.Text = "UDT";
            this.UdtCheck.UseVisualStyleBackColor = true;
            // 
            // T2kCheck
            // 
            this.T2kCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.T2kCheck.AutoSize = true;
            this.T2kCheck.Checked = true;
            this.T2kCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.T2kCheck.Location = new System.Drawing.Point(779, 134);
            this.T2kCheck.Name = "T2kCheck";
            this.T2kCheck.Size = new System.Drawing.Size(45, 19);
            this.T2kCheck.TabIndex = 5;
            this.T2kCheck.Tag = "3";
            this.T2kCheck.Text = "T2K";
            this.T2kCheck.UseVisualStyleBackColor = true;
            // 
            // RenCheck
            // 
            this.RenCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RenCheck.AutoSize = true;
            this.RenCheck.Checked = true;
            this.RenCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RenCheck.Location = new System.Drawing.Point(779, 159);
            this.RenCheck.Name = "RenCheck";
            this.RenCheck.Size = new System.Drawing.Size(48, 19);
            this.RenCheck.TabIndex = 6;
            this.RenCheck.Tag = "4";
            this.RenCheck.Text = "REN";
            this.RenCheck.UseVisualStyleBackColor = true;
            // 
            // RecCheck
            // 
            this.RecCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecCheck.AutoSize = true;
            this.RecCheck.Checked = true;
            this.RecCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RecCheck.Location = new System.Drawing.Point(779, 184);
            this.RecCheck.Name = "RecCheck";
            this.RecCheck.Size = new System.Drawing.Size(47, 19);
            this.RecCheck.TabIndex = 7;
            this.RecCheck.Tag = "5";
            this.RecCheck.Text = "REC";
            this.RecCheck.UseVisualStyleBackColor = true;
            // 
            // AkpCheck
            // 
            this.AkpCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AkpCheck.AutoSize = true;
            this.AkpCheck.Checked = true;
            this.AkpCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AkpCheck.Location = new System.Drawing.Point(779, 209);
            this.AkpCheck.Name = "AkpCheck";
            this.AkpCheck.Size = new System.Drawing.Size(48, 19);
            this.AkpCheck.TabIndex = 8;
            this.AkpCheck.Tag = "6";
            this.AkpCheck.Text = "AKP";
            this.AkpCheck.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(779, 244);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(134, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 669);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.AkpCheck);
            this.Controls.Add(this.RecCheck);
            this.Controls.Add(this.RenCheck);
            this.Controls.Add(this.T2kCheck);
            this.Controls.Add(this.UdtCheck);
            this.Controls.Add(this.SntCheck);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ImageList imageList1;
    private TextBox textBox1;
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
}

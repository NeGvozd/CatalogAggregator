using System.Text.RegularExpressions;

namespace WorkParser2;

public partial class Form1 : Form
{
    InitialController controller;
    ExcelExport excelExport;

    public Form1()
    {
        InitializeComponent();
        controller = new InitialController(this);
        excelExport = new ExcelExport();
    }

    static string RemoveBadChars(string text)
    {
        Regex reg = new(@"[^\d]");
        return reg.Replace(text, string.Empty);
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
        StartButton.Enabled = false;
        BreakButton.Enabled = true;
        ClearButton.Enabled = false;
        progressBar1.Value = progressBar1.Minimum;
        //StartButton_Action
        backgroundWorker.RunWorkerAsync();
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        textBox1.Clear();
        progressBar1.Value = progressBar1.Minimum;
    }

    private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        if (RemoveBadChars(textBox1.Text).Length == 0)
        {
            backgroundWorker.CancelAsync();
        }

        var requested_sites = new List<Site>();
        var requests = textBox1.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList();
        var check_boxes = this.AllControls<CheckBox>().Where(control => control.Checked).ToList();
        
        check_boxes.Reverse();
        foreach (var c in check_boxes)
        {
            requested_sites.Add((Site)int.Parse((string)c.Tag));
        }

        controller.Start(e, requested_sites, requests);
    }

    private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
        progressBar1.Value = e.ProgressPercentage;
    }

    private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
        BreakButton.Enabled = false;
        StartButton.Enabled = true;
        ClearButton.Enabled = true;
        progressBar1.Value = progressBar1.Maximum;
    }
    private bool IsTheSameCellValue(int col, int row)
    {
        DataGridViewCell cell1 = dataGridView1.Rows[row].Cells[col];
        DataGridViewCell cell2 = dataGridView1.Rows[row - 1].Cells[col];

        if (cell1.Value == null || cell2.Value == null || col > 1)
            return false;

        return cell1.Value.ToString() == cell2.Value.ToString();
    }

    private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex == 0 || e.ColumnIndex > 1)
            return;
        if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
        {
            e.Value = "";
            e.FormattingApplied = true;
        }
    }

    private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
        e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
        if (e.RowIndex < 1 || e.ColumnIndex < 0)
            return;
        if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
        {
            e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
        }
        else
        {
            e.AdvancedBorderStyle.Top = dataGridView1.AdvancedCellBorderStyle.Top;
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        //dataGridView1.AutoGenerateColumns = false;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void progressBar1_Click(object sender, EventArgs e)
    {

    }

    private void BreakButton_Click(object sender, EventArgs e)
    {
        backgroundWorker.CancelAsync();

        BreakButton.Enabled = false;
        StartButton.Enabled = true;
        ClearButton.Enabled = true;
    }

    private void AboutButton_Click(object sender, EventArgs e)
    {
        AboutBox1 about = new AboutBox1();
        about.Show();
    }

    private void ToExcelButton_Click(object sender, EventArgs e)
    {
        dataGridView1.SelectAll();
        excelExport.Export(dataGridView1.GetClipboardContent());
        dataGridView1.ClearSelection();
    }
}


public static class Extensions
{
    public static IEnumerable<T> AllControls<T>(this Control startingPoint) where T : Control
    {
        bool hit = startingPoint is T;
        if (hit)
        {
            yield return startingPoint as T;
        }
        foreach (var child in startingPoint.Controls.Cast<Control>())
        {
            foreach (var item in AllControls<T>(child))
            {
                yield return item;
            }
        }
    }
}
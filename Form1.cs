namespace WorkParser2;

public partial class Form1 : Form
{
    InitialController controller;

    public Form1()
    {
        InitializeComponent();
        controller = new InitialController();
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
        //StartButton_Action
        backgroundWorker.RunWorkerAsync();
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        textBox1.Clear();
    }

    private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        var requested_sites = new List<Site>();
        var requests = textBox1.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList();
        var check_boxes = this.AllControls<CheckBox>().Where(control => control.Checked).ToList();

        check_boxes.Reverse();
        foreach (var c in check_boxes)
        {
            requested_sites.Add((Site)int.Parse((string)c.Tag));
        }

        controller.Start(requested_sites, requests);
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
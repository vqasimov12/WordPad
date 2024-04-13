using System.Drawing.Text;
namespace WinFormsApp1;
public partial class Form1 : Form
{
    List<string> fonts = new();
    List<int> sizes = new();
    public Form1()
    {
        InitializeComponent();
        Text = "WordPad";
        InstalledFontCollection installedFontCollection = new InstalledFontCollection();
        foreach (FontFamily font in installedFontCollection.Families)
            fonts.Add(font.Name);
        for (int i = 8; i <= 50; i++)
            sizes.Add(i);
        FontList.DataSource = fonts;
        SizeList.DataSource = sizes;
        openFileDialog1.Filter = "Text file|* .txt";
        saveFileDialog1.Filter = "Text file|* .txt";
    }
    private void btnColor_Click(object sender, EventArgs e)
    {
        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            btnColor.Text = colorDialog1.Color.Name;
            btnColor.BackColor = colorDialog1.Color;
            btnColor.ForeColor = (colorDialog1.Color != Color.Black ? Color.Black : Color.White);
            richTextBox1.ForeColor = colorDialog1.Color;
        }
    }
    private void bold_Click(object sender, EventArgs e)
    {
        ChangeStyle(FontStyle.Bold);
    }
    private void Italic_Click(object sender, EventArgs e)
    {
        ChangeStyle(FontStyle.Italic);
    }
    private void Underlined_Click(object sender, EventArgs e)
    {
        ChangeStyle(FontStyle.Underline);
    }
    private void Left_Click(object sender, EventArgs e)
    {
        richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
    }
    private void Center_Click(object sender, EventArgs e)
    {
        richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
    }
    private void Right_Click(object sender, EventArgs e)
    {
        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
    }
    private void FontList_MouseEnter(object sender, EventArgs e)
    {
        ListBox? l = sender as ListBox;
        if (l != null)
        {
            l.Size = new Size(268, 142);
            l.Location = new Point(3, 55);
        }
    }
    private void FontList_MouseLeave(object sender, EventArgs e)
    {
        ListBox? l = sender as ListBox;
        if (l != null)
        {
            l.Size = new Size(126, 27);
            l.Location = new Point(3, 55);
        }
    }
    private void FontList_SelectedValueChanged(object sender, EventArgs e)
    {
        if (FontList.SelectedItem != null)
        {
            string sl = FontList.SelectedItem.ToString()!;
            fonts.RemoveAt(FontList.SelectedIndex);
            fonts.Insert(0, sl);
            FontList.DataSource = null;
            FontList.DataSource = fonts;
            richTextBox1.Font = new Font(sl, richTextBox1.Font.Size);
        }
        FontList_MouseLeave(sender, null);
    }
    private void SizeList_MouseEnter(object sender, EventArgs e)
    {
        ListBox? l = sender as ListBox;
        if (l != null)
        {
            l.Size = new Size(80, 121);
            l.Location = new Point(160, 55);
        }
    }
    private void SizeList_MouseLeave(object sender, EventArgs e)
    {
        ListBox? l = sender as ListBox;
        if (l != null)
        {
            l.Size = new Size(80, 27);
            l.Location = new Point(160, 55);
        }
    }
    private void SizeList_SelectedValueChanged(object sender, EventArgs e)
    {
        if (SizeList.SelectedItem != null)
        {
            var sl = Convert.ToInt32(SizeList.SelectedItem);
            sizes.RemoveAt(SizeList.SelectedIndex);
            sizes.Insert(0, sl);
            SizeList.DataSource = null;
            SizeList.DataSource = sizes;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, sl);
        }
        SizeList_MouseLeave(sender, null);
    }
    private void Load_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
            try
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
            }
    }
    private void btnSave_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            try
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
            }
    }
    void ChangeStyle(FontStyle style)
    {
        FontStyle currentStyle = richTextBox1.Font.Style;
        if ((currentStyle & style) != 0)
            richTextBox1.Font = new Font(richTextBox1.Font, currentStyle & ~style);
        else
            richTextBox1.Font = new Font(richTextBox1.Font, currentStyle | style);
    }
}
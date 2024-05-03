using System.Diagnostics;

namespace Collatz_Conjecture
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      int val = Convert.ToInt16(textBox1.Text);
      int count = 1;
      while (val != 1)
      {
        if (val % 2 == 0)
        {
          val /= 2;
          count++;
        }
        else
        {
          val = (val * 3) + 1;
          count++;
        }

      }
      textBox2.Text = count.ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Process process = new Process();
      process.StartInfo.UseShellExecute = true;
      process.StartInfo.FileName = "chrome";
      process.StartInfo.Arguments = "https://en.wikipedia.org/wiki/Collatz_conjecture";
      process.Start();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
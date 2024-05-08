namespace Collatz_Conjecture
{
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
      label1 = new Label();
      button1 = new Button();
      button2 = new Button();
      textBox1 = new TextBox();
      label2 = new Label();
      textBox2 = new TextBox();
      label3 = new Label();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.BackColor = SystemColors.Menu;
      label1.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
      label1.Location = new Point(10, 4);
      label1.Name = "label1";
      label1.Size = new Size(240, 35);
      label1.TabIndex = 0;
      label1.Text = "Collatz Conjecture";
      label1.Click += label1_Click;
      // 
      // button1
      // 
      button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
      button1.Location = new Point(29, 174);
      button1.Margin = new Padding(3, 4, 3, 4);
      button1.Name = "button1";
      button1.Size = new Size(378, 84);
      button1.TabIndex = 1;
      button1.Text = "Calculate steps";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // button2
      // 
      button2.Location = new Point(295, 13);
      button2.Margin = new Padding(3, 4, 3, 4);
      button2.Name = "button2";
      button2.Size = new Size(112, 64);
      button2.TabIndex = 2;
      button2.Text = "Wikipedia Page";
      button2.UseVisualStyleBackColor = true;
      button2.Click += button2_Click;
      // 
      // textBox1
      // 
      textBox1.Location = new Point(29, 117);
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(134, 27);
      textBox1.TabIndex = 3;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(29, 94);
      label2.Name = "label2";
      label2.Size = new Size(134, 20);
      label2.TabIndex = 4;
      label2.Text = "Input number here:";
      // 
      // textBox2
      // 
      textBox2.Location = new Point(256, 117);
      textBox2.Name = "textBox2";
      textBox2.ReadOnly = true;
      textBox2.Size = new Size(127, 27);
      textBox2.TabIndex = 5;
      textBox2.TextChanged += textBox2_TextChanged;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(261, 93);
      label3.Name = "label3";
      label3.Size = new Size(122, 20);
      label3.TabIndex = 6;
      label3.Text = "Number of steps:";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(419, 271);
      Controls.Add(label3);
      Controls.Add(textBox2);
      Controls.Add(label2);
      Controls.Add(textBox1);
      Controls.Add(button2);
      Controls.Add(button1);
      Controls.Add(label1);
      Margin = new Padding(3, 4, 3, 4);
      Name = "Form1";
      Text = "Collatz Conjecture Steps Calculator";
      Load += Form1_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Button button1;
    private Button button2;
    private TextBox textBox1;
    private Label label2;
    private TextBox textBox2;
    private Label label3;
  }
}
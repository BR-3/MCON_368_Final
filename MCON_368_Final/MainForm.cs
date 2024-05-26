using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Drawing.Text;

namespace MCON_368_Final
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public decimal check_amount;
        public decimal tip_amount;
        public decimal divide_amount;
        public decimal total_and_tip;
        public decimal individual_total;
        public decimal tip;

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tip_result = new Label();
            total_result = new Label();
            individual_result = new Label();
            print_button = new Button();
            splitting_input = new NumericUpDown();
            check_input = new NumericUpDown();
            tip_input = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)splitting_input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)check_input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tip_input).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            label1.Location = new Point(49, 56);
            label1.Name = "label1";
            label1.Size = new Size(117, 18);
            label1.TabIndex = 0;
            label1.Text = "Check Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            label2.Location = new Point(49, 105);
            label2.Name = "label2";
            label2.Size = new Size(60, 18);
            label2.TabIndex = 1;
            label2.Text = "Tip (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            label3.Location = new Point(49, 192);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 2;
            label3.Text = "Tip Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            label4.Location = new Point(49, 252);
            label4.Name = "label4";
            label4.Size = new Size(112, 18);
            label4.TabIndex = 3;
            label4.Text = "Total Amount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            label5.Location = new Point(49, 342);
            label5.Name = "label5";
            label5.Size = new Size(108, 18);
            label5.TabIndex = 4;
            label5.Text = "Splitting with:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            label6.Location = new Point(49, 405);
            label6.Name = "label6";
            label6.Size = new Size(130, 18);
            label6.TabIndex = 5;
            label6.Text = "Individual Total:";
            // 
            // tip_result
            // 
            tip_result.AutoSize = true;
            tip_result.Font = new Font("Segoe UI", 9F);
            tip_result.Location = new Point(328, 192);
            tip_result.Name = "tip_result";
            tip_result.Size = new Size(0, 20);
            tip_result.TabIndex = 6;
            // 
            // total_result
            // 
            total_result.AutoSize = true;
            total_result.Font = new Font("Segoe UI", 9F);
            total_result.Location = new Point(328, 252);
            total_result.Name = "total_result";
            total_result.Size = new Size(0, 20);
            total_result.TabIndex = 7;
            // 
            // individual_result
            // 
            individual_result.AutoSize = true;
            individual_result.Font = new Font("Segoe UI", 9F);
            individual_result.Location = new Point(328, 405);
            individual_result.Name = "individual_result";
            individual_result.Size = new Size(0, 20);
            individual_result.TabIndex = 8;
            // 
            // print_button
            // 
            print_button.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            print_button.Location = new Point(326, 462);
            print_button.Name = "print_button";
            print_button.Size = new Size(94, 29);
            print_button.TabIndex = 12;
            print_button.Text = "Print";
            print_button.UseVisualStyleBackColor = true;
            print_button.Click += export_file;
            // 
            // splitting_input
            // 
            splitting_input.Font = new Font("Segoe UI", 9F);
            splitting_input.Location = new Point(228, 340);
            splitting_input.Name = "splitting_input";
            splitting_input.Size = new Size(150, 27);
            splitting_input.TabIndex = 13;
            splitting_input.Leave += divide_tip;
            // 
            // check_input
            // 
            check_input.DecimalPlaces = 2;
            check_input.Font = new Font("Segoe UI", 9F);
            check_input.Location = new Point(228, 54);
            check_input.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            check_input.Name = "check_input";
            check_input.Size = new Size(150, 27);
            check_input.TabIndex = 14;
            // 
            // tip_input
            // 
            tip_input.DecimalPlaces = 2;
            tip_input.Font = new Font("Segoe UI", 9F);
            tip_input.Location = new Point(228, 103);
            tip_input.Name = "tip_input";
            tip_input.Size = new Size(150, 27);
            tip_input.TabIndex = 15;
            tip_input.Leave += calculate_tip;
            // 
            // MainForm
            // 
            BackColor = Color.Thistle;
            ClientSize = new Size(432, 503);
            Controls.Add(tip_input);
            Controls.Add(check_input);
            Controls.Add(splitting_input);
            Controls.Add(print_button);
            Controls.Add(individual_result);
            Controls.Add(total_result);
            Controls.Add(tip_result);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Rockwell", 9F, FontStyle.Bold);
            Name = "MainForm";
            Text = "Check-Splitter";
            ((System.ComponentModel.ISupportInitialize)splitting_input).EndInit();
            ((System.ComponentModel.ISupportInitialize)check_input).EndInit();
            ((System.ComponentModel.ISupportInitialize)tip_input).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void calculate_tip(object sender, EventArgs e)
        {
            if (check_input.Text == null || tip_input.Text == null)
            {
                MessageBox.Show("Please enter both fields.");
            }
            else
            {
                check_amount = (check_input.Value);
                tip_amount = (tip_input.Value)/100;

                tip = (check_amount * tip_amount);
                total_and_tip = tip + check_amount;

                tip_result.Text = "$" + Convert.ToString(tip);
                total_result.Text = "$" + Convert.ToString(total_and_tip);

            }
        }

        private void divide_tip(object sender, EventArgs e)
        {
            divide_amount = splitting_input.Value;
            if(divide_amount != 0)
            {
                individual_total = total_and_tip / divide_amount;
            } else
            {
                individual_total = total_and_tip;
            }
            
            individual_result.Text = "$" + Convert.ToString(individual_total);
        }

        private void export_file(object sender, EventArgs e)
        {
            String fileName = Extensions.CreateFileName();
            System.IO.FileStream oFileStr = default(System.IO.FileStream);
            string thePath = System.IO.Path.GetDirectoryName(fileName);

            if (!System.IO.File.Exists(thePath))
            {
                System.IO.Directory.CreateDirectory(thePath);
            }

            if (!System.IO.File.Exists(fileName))
            {
                oFileStr = new System.IO.FileStream(fileName, System.IO.FileMode.CreateNew);
                oFileStr.Close();
            }

            FileSystem.FileOpen(1, fileName, OpenMode.Append, OpenAccess.Write);
            String theText = "Check Splitting" + Environment.NewLine + Environment.NewLine;
            theText += "Check: " + check_input.Text + Environment.NewLine;
            theText += "Tip: " + tip_input.Text + Environment.NewLine;
            theText += "Tip Total: " + tip_result.Text + Environment.NewLine;
            theText += "Total Cost: " + total_result.Text + Environment.NewLine;
            theText += "Divided By: " + divide_amount + Environment.NewLine;
            theText += "Individual Total: " + individual_result.Text + Environment.NewLine;
            FileSystem.Print(1, theText + Environment.NewLine);
            
            FileSystem.FileClose(1);
            Process.Start("notepad", fileName);
        }
    }

    public static class Extensions
    {
        public static string MixedCase(this string theString)
        {
            string returnData = string.Empty;
            if (!string.IsNullOrEmpty(theString))
            {
                for (int i = 0; i < theString.Length; i++)
                {
                    returnData += i % 2 != 0 ? theString.Substring(i, 1).ToLower() : theString.Substring(i, 1).ToUpper();
                }
            }
            return returnData;
        }

        public static string CreateFileName()
        {
            string returnData = string.Empty;
            returnData = "C:\\temp\\";
            returnData += "MyCheckCalculated";
            returnData += DateTime.Now.ToString("yyyy.MM.dd.mm:ss") +".txt";
            return returnData;
        }
    }
}

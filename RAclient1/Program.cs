using System;
using System.Windows.Forms;

namespace PasscodeChecker
{
    public class Program : Form
    {
        private TextBox passcodeTextBox;
        private Button submitButton;

        public Program()
        {
            InitializeComponents();
        }
        private void InitializeComponents()
        {
            passcodeTextBox = new TextBox();
            passcodeTextBox.Location = new System.Drawing.Point(50, 50);
            passcodeTextBox.Size = new System.Drawing.Size(150, 20);
            Controls.Add(passcodeTextBox);

            submitButton = new Button();
            submitButton.Location = new System.Drawing.Point(50, 80);
            submitButton.Size = new System.Drawing.Size(150, 23);
            submitButton.Text = "Submit";
            submitButton.Click += SubmitButton_Click;
            Controls.Add(submitButton);

            Size = new System.Drawing.Size(250, 150);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string passcode = passcodeTextBox.Text;
            if (passcode == "hard-crackme-code")
            {
                MessageBox.Show("Correct Passcode");
            }
            else
            {
                MessageBox.Show("Incorrect Passcode");
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Program());
        }
    }
}

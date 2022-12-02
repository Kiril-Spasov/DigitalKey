using System;
using System.IO;
using System.Windows.Forms;

namespace DigitalKey
{
    public partial class FormDigitalKey : Form
    {
        public FormDigitalKey()
        {
            InitializeComponent();
        }

        private void BtnReadDigitalKey_Click(object sender, EventArgs e)
        {
            string line = "";
            int lineCount = 0;

            string path = Application.StartupPath + @"\digitalkey.txt";
            StreamReader streamReader = new StreamReader(path);

            bool finished = false;

            while (!finished)
            {
                line = streamReader.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    if (line != "")
                    {
                        lineCount++;

                        TxtResult.Text += ReadDigitalKey(line);

                        if (lineCount == 7)
                        {
                            TxtResult.Text += Environment.NewLine;
                            lineCount = 0;
                        }
                    }  
                }
            }
        }

        private string ReadDigitalKey(string keyTheetHight)
        {
            string character;
            string result = "";
            int hCount = 0;

            for (int i = 0; i <= 4; i++)
            {
                character = keyTheetHight.Substring(i, 1);

                if (i == 0 && character == ".")
                {
                    result += "0";
                }
                else if (character == "#")
                {
                    hCount++;
                }
            }

            return result = hCount.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRG252_Project
{
    class FileHandler
    {
        string[] arr;

        public bool CheckUser(string userName, int password)
        {
            try
            {
                using (StreamReader sr = new StreamReader("credentials.txt"))
                {
                    string holder;
                    bool value = false;

                    while ((holder = sr.ReadLine()) != null)
                    {
                        arr = holder.Split(' ');

                        if (userName == arr[0] && password == int.Parse(arr[1]))
                        {
                            value = true;
                            return true;
                        }
                    }
                    if (value == false)
                    {

                        return false;
                        
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        string handler = @"credentials.txt";

        public void Write(string username, int password)
        {
            try
            {
                if (File.Exists(handler))
                {
                    FileStream fs = new FileStream(handler, FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.WriteLine(username + " " + password);

                    sw.Close();
                    fs.Close();
                    
                }
                else
                {
                    FileStream fs = new FileStream(handler, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.WriteLine(username + " " + password);

                    sw.Close();
                    fs.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EncDecMachine
{
    class Logger
    {
        private ListBox logListBox;

        public Logger(ListBox logListBox)
        {
            this.logListBox = logListBox;
        }

        public void addLog(string item)
        {
            logListBox.Items.Add(item);
        }

        public void saveLog()
        {
            FileStream file = new FileStream("Log_" + DateTime.Now.ToString("yyyyMMdd") + ".txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);

            foreach (string item in this.logListBox.Items)
                writer.WriteLine(item);

            writer.Close();
            file.Close();
        }

        public void clearLog()
        {
            this.logListBox.Items.Clear();
        }
    }
}

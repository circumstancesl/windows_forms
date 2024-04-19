using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsForms;

namespace WindowsFormsLab
{
    public partial class View : Form, IView
    {
        public View()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        string IView.FirstDirectory()
        {
            return pathDirectory1.Text;
        }

        string IView.SecondDirectory()
        {
            return pathDirectory2.Text;
        }

        void IView.Synchronize(List<string> messages)
        {
            result.Items.Clear();
            List<string> outputList = messages;

            foreach (string output in outputList)
            {
                result.Items.Add(output);
            }
        }

        public event EventHandler<EventArgs> SynchronizeDirectories;

        private void cynchronizeButton_Click(object sender, EventArgs newEvent)
        {
            SynchronizeDirectories(sender, newEvent);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WindowsFormsLab;

namespace WindowsForms
{
    interface IView
    {
        string FirstDirectory();
        string SecondDirectory();

        void Synchronize(List<string> messages);

        event EventHandler<EventArgs> SynchronizeDirectories;
    }

    class Model
    {
        public List<string> SynchronizingDirectories(string firstDirectory, string secondDirectory)
        {
            DirectoryInfo startDirectory = new DirectoryInfo(firstDirectory);
            DirectoryInfo finalDirectory = new DirectoryInfo(secondDirectory);

            List<string> synchronizationResult;

            synchronizationResult = DirectorySynchronization(startDirectory, finalDirectory);

            return synchronizationResult;
        }

        private List<string> DirectorySynchronization(DirectoryInfo firstDirectory, DirectoryInfo secondDirectory)
        {
            List<string> resultOfDirectorySynchronization = new List<string>();

            foreach (FileInfo file in firstDirectory.GetFiles())
            {
                FileInfo fileInFirstDirectory = new FileInfo(Path.Combine(secondDirectory.FullName, file.Name));

                if (!fileInFirstDirectory.Exists || fileInFirstDirectory.LastWriteTime < file.LastWriteTime)
                {
                    File.Copy(file.FullName, fileInFirstDirectory.FullName, true);
                    resultOfDirectorySynchronization.Add($"Файл {file.Name} изменен");
                }
            }

            foreach (FileInfo file in secondDirectory.GetFiles())
            {
                FileInfo fileInSecondDirectory = new FileInfo(Path.Combine(firstDirectory.FullName, file.Name));

                if (!fileInSecondDirectory.Exists)
                {
                    file.Delete();
                    resultOfDirectorySynchronization.Add($"Файл {file.Name} удален");
                }
            }
            return resultOfDirectorySynchronization;
        }
    }

    class Presenter
    {
        private IView view;
        private Model model;
        public Presenter(IView newView)
        {
            view = newView;
            model = new Model();
            view.SynchronizeDirectories += new EventHandler<EventArgs>(Synchronize);
        }

        private void Synchronize(object sender, EventArgs newEvent)
        {
            List<string> resultOfSynchronization = model.SynchronizingDirectories(view.FirstDirectory(), view.SecondDirectory());
            view.Synchronize(resultOfSynchronization);
        }
    }

    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowsFormsLab.View());
        }
    }
}
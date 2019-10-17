using System;
using System.Windows.Forms;

namespace Batony
{
    public partial class ButonsForm : Form
    {
        public ButonsForm()
        {
            InitializeComponent();
        }

        private void ButonsForm_Load(object sender, EventArgs e)
        {
            PersonalizeFormWindow();
            AddButtonsEvents();
        }

        public void PersonalizeFormWindow() {
            Text = "Zadanie - Batony";
            MaximizeBox = false;
        }

        public void AddButtonsEvents() {
            authorButton.Click += new EventHandler(ShowAuthorInformationHandler);
            departmentButton.Click += new EventHandler(ShowDepartmentInformationHandler);
            subjectButton.Click += new EventHandler(ShowSubjectInformationHandler);
        }

        public void ShowAuthorInformationHandler(object sender, EventArgs evt)
        {
            string authorInfoTitle = "Informacja o autorze";
            string authorInfoContent = "Autor: Kacper Pruszyński";

            ShowInformationMessageBox(authorInfoContent, authorInfoTitle);
        }

        public void ShowDepartmentInformationHandler(object sender, EventArgs evt)
        {
            string departmentInfoTitle = "Informacja o wydziale";
            string departmentInfoContent = "Wydział: Informatyka";

            ShowInformationMessageBox(departmentInfoContent, departmentInfoTitle);
        }

        public void ShowSubjectInformationHandler(object sender, EventArgs evt)
        {
            string subjectInfoTitle = "Informacja o przedmiocie";
            string subjectInfoContent = "Przedmiot: Programowanie";

            ShowInformationMessageBox(subjectInfoContent, subjectInfoTitle);
        }

        private DialogResult ShowInformationMessageBox(string messageBoxContent, string messageBoxTitle) {
            MessageBoxButtons messageBoxButtons= MessageBoxButtons.OK;
            return MessageBox.Show(messageBoxContent, messageBoxTitle, messageBoxButtons);
        }
    }
}

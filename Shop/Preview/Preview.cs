using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class Preview : Form
    {

        private Form m_Parent;
        public Preview(String msg, Form parent)
        {
            this.m_Parent = parent;
            InitializeComponent();
            this.previewLabel.Text = msg;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

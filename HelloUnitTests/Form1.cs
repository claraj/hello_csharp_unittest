using System;

using System.Windows.Forms;

namespace HelloUnitTests
{

    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
            comboBoxTitle.Items.Add("Mr.");
            comboBoxTitle.Items.Add("Ms.");
            comboBoxTitle.Items.Add("Dr.");
        }
        
    
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Name name = NameUtilities.makeName(textBoxName.Text);
            name.Title = comboBoxTitle.SelectedItem.ToString(); 
            String fullNameWithTitle = NameUtilities.fullNameString(name);
            textBoxName.Clear();
            labelWelcome.Text = "Welcome, " + fullNameWithTitle;
        }
  
    }

}

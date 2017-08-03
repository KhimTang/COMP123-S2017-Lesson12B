using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Khim Tang
 * StudentID: 300920672
 * Date: August 02. 2017
 * Description: Demo Application to showcase windows forms and UI Controls
 * Version: 0.1 - Project was Created
*/

namespace COMP123_S2017_Lesson12B
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the HelloButton event handler for the click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelloButton_Click(object sender, EventArgs e)
        {
            if (NameTexBox.Text.Length > 0)
            {
                HelloLable.Text = "Hello, " + NameTexBox.Text;
            }
            else
            {
                HelloLable.Text = "Hello, World!";
            }
            
        }

        private void HelloLable_Click(object sender, EventArgs e)
        {

        }
    }
}

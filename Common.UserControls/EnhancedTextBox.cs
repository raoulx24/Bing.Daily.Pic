using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomUserControls
{
    public partial class EnhancedTextBox : UserControl
    {
        public EnhancedTextBox()
        {
            InitializeComponent();
        }

        public string TextBoxValue
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public string Label
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public bool ReadOnly
        {
            get { return textBox.ReadOnly; }
            set { textBox.ReadOnly = value; }
        }

        public bool MultiLine
        {
            get { return textBox.Multiline; }
            set { textBox.Multiline = value;  }
        }
    }
}

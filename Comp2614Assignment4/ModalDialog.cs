using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp2614Assignment4
{
    // ModalDialog implements all the features expected of a modal dialog:
    // Ok and Cancel buttons, bound to Enter and Esc
    // Fixed size
    // Not shown in system tray
    // Modal
    public partial class ModalDialog : Form
    {
        public ModalDialog()
        {
            InitializeComponent();
        }
    }
}

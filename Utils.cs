using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDChanger
{
    class Utils
    {
        //utils

        internal static void success(string msg)
        {
            MessageBox.Show(msg, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void fail(string cause)
        {
            MessageBox.Show(cause, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }
}

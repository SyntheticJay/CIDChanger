using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//our imports
using MetroFramework.Forms;
using PS3Lib;

/*
 * CID Changer
 * by ReductionCFW, 2018
 * 
 * Status: Not Tested, not yet..
 * (Will test on my phat, banned later)
 * 
 * Expect a new video up for a fix if this DOESN'T work. <3
 * 
 * also, expect this to be up on github, so feel free to send any pull requests:
 * 
 * https://www.github.com/SyntheticJay
 */
namespace CIDChanger
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //our constants
        public static PS3API PS3 = new PS3API();

        private void Form1_Load(object sender, EventArgs e)
        {
            //changing the current api to CCAPI, as that's all we'll accept.
            PS3.ChangeAPI(SelectAPI.ControlConsole);

            //checking all of the boxes that require connection disabled.
            btnDisconnect.Enabled = false;
            btnSetBoot.Enabled = false;
            btnSetCID.Enabled = false;
            btnSetPSID.Enabled = false;
        }

        //called when the connect button is pressed
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //try to establish a connection between CCAPI/PC and the PS3.
                if (PS3.ConnectTarget())
                {
                    Utils.success("Connected to PS3 with CCAPI!");

                    PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Single);
                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.FRIEND, "CID Changer: Connected.");

                    //checking all of the boxes that require connection ENABLED.
                    btnDisconnect.Enabled = true;
                    btnSetBoot.Enabled = true;
                    btnSetCID.Enabled = true;
                    btnSetPSID.Enabled = true;
                }
                else //if we fail to connect to the target PS3.
                {
                    Utils.fail("Failed to connect! Try:\r\n- Restarting the program\r\n- Use CCAPI");
                }
            }
            catch //catching any exceptions/errors.
            {
                Utils.fail("I've caught an exception! Try:\r\n- Restarting the program\r\n- Use CCAPI");
            }
        }

        //called when the disconnect button is pressed.
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "CID Changer: Disconnecting..");
            PS3.DisconnectTarget(); //ending the connection
            Utils.success("Successfully disconnected from PS3.");

            //checking all of the boxes that require connection disabled.
            btnDisconnect.Enabled = false;
            btnSetBoot.Enabled = false;
            btnSetCID.Enabled = false;
            btnSetPSID.Enabled = false;
        }

        //called when the set boot cid button is pressed.
        private void btnSetBoot_Click(object sender, EventArgs e)
        {
            //checking if the characters of the text box is OVER 32. (max limit of a CID/PSID alone)
            if(CIDBox.Text.Length != 32)
            {
                Utils.fail("Your CID box is over 32 characters! Fix.");
            }
            else
            {
                PS3.CCAPI.SetBootConsoleID(CIDBox.Text); //setting the (boot) CID.
                Utils.success("Set boot CID!");
            }
        }

        //called when the set current CID button is pressed.
        private void btnSetCID_Click(object sender, EventArgs e)
        {
            if(CIDBox.Text.Length != 32)
            {
                Utils.fail("Your CID box is over 32 characters! Fix.");
            }
            else
            {
                PS3.CCAPI.SetConsoleID(CIDBox.Text); //setting the current Console id, NOT BOOT.
                Utils.success("Set CID!");
            }
        }

        //called when the set PSID button is clicked.
        private void btnSetPSID_Click(object sender, EventArgs e)
        {
            if(PSIDBox.Text.Length != 32)
            {
                Utils.fail("Your PSID box is over 32 characters! Fix.");
            }
            else
            {
                PS3.CCAPI.SetPSID(PSIDBox.Text); //setting the playstation id to the current box.
                Utils.success("Set PSID!");
            }
        }
    }
}

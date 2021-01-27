using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using StreadChatSpammer.Properties;
using System.Threading;
namespace StreadChatSpammer
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

               bool method = false;
               bool startstop = false;
        public bool themecontrol = false;
 
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelText_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void customSpeed_Click(object sender, EventArgs e)
        {
            if (themecontrol == false)
            {
                homeSelector.BackColor = Color.FromArgb(25, 25, 25);
                settingsSelector.BackColor = Color.WhiteSmoke;
                infoSelector.BackColor = Color.FromArgb(25, 25, 25);
            }
            else
            {
                homeSelector.BackColor = Color.LightGray;
                settingsSelector.BackColor = Color.DimGray;
                infoSelector.BackColor = Color.LightGray;
            }
            normalSpeed.Checked = false;
            highSpeed.Checked = false;
            lowSpeed.Checked = false;

            settingsPanel.Visible = true;
        }

        private void highSpeed_Click(object sender, EventArgs e)
        {
            timerSpammer.Interval = 250;
            textSpeedValue.Text = "";
        }


        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            timerSlider.Enabled = true;
        }
        bool slidecontroller = false;
        int slidemax = 150;
        int slidemin = 99;
        private void timerSlider_Tick(object sender, EventArgs e)
        {
            if (slidecontroller == false)
            {
                sliderPanel.Width += 7;
                
              
                if (sliderPanel.Width >= slidemax)
                {
                    timerSlider.Enabled = false;
                    slidecontroller = true;
                    settingsPanel.Width = 734;
                }
            }
            else
            {
                sliderPanel.Width -= 5;
                settingsPanel.Width = 785;
                if (sliderPanel.Width <= slidemin)
                {
                    timerSlider.Enabled = false;
                   slidecontroller= false;
                  
                }
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
           if(themecontrol==false)
           {
               homeSelector.BackColor = Color.WhiteSmoke;
               settingsSelector.BackColor = Color.FromArgb(25, 25, 25);
               infoSelector.BackColor = Color.FromArgb(25, 25, 25);
           }
           else
           {
               homeSelector.BackColor = Color.DimGray;
               settingsSelector.BackColor = Color.LightGray;
               infoSelector.BackColor = Color.LightGray;
           }
            
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

            if (themecontrol == false)
            {
                homeSelector.BackColor = Color.FromArgb(25, 25, 25);
                settingsSelector.BackColor = Color.WhiteSmoke;
                infoSelector.BackColor = Color.FromArgb(25, 25, 25);
            }
            else
            {
                homeSelector.BackColor = Color.LightGray;
                settingsSelector.BackColor = Color.DimGray;
                infoSelector.BackColor = Color.LightGray;
            }
            settingsPanel.Visible = true;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
              Info infoform = new Info();
              Info_Light infoform_light = new Info_Light();
            infoform.Name = "infoform";
            
            if (themecontrol == false)
            {
                infoform.Name = "infoform";
                if (Application.OpenForms["infoform"] == null)
                {
                    infoform.Show();
                }
                else
                {
                    infoform.Focus();
                }
                homeSelector.BackColor = Color.FromArgb(25, 25, 25);
                settingsSelector.BackColor = Color.FromArgb(25, 25, 25);
                infoSelector.BackColor = Color.WhiteSmoke;
            }
            else
            {
                infoform_light.Name = "infoform-light";
                if (Application.OpenForms["infoform-light"] == null)
                {
                    infoform_light.Show();
                }
                else
                {
                    infoform_light.Show();
                }
                homeSelector.BackColor = Color.LightGray;
                settingsSelector.BackColor = Color.LightGray;
                infoSelector.BackColor = Color.DimGray;
            }
        }

        private void homeSelector_Click(object sender, EventArgs e)
        {

        }

        private void homeButtonSlide_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
            homeSelector.BackColor = Color.WhiteSmoke;
            settingsSelector.BackColor = Color.FromArgb(25, 25, 25);
            infoSelector.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void settingsButtonSlide_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = true;
            homeSelector.BackColor = Color.FromArgb(25, 25, 25);
            settingsSelector.BackColor = Color.WhiteSmoke;
            infoSelector.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void infoButtonSlide_Click(object sender, EventArgs e)
        {
            
            Info info = new Info();
            info.Show();
            homeSelector.BackColor = Color.FromArgb(25, 25, 25);
            settingsSelector.BackColor = Color.FromArgb(25, 25, 25);
            infoSelector.BackColor = Color.WhiteSmoke;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sliderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void spamTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(spamTextBox.Text))
            {
                MessageBox.Show("Spam Text Value Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                timerSpammer.Enabled = true;
                startstop = true;
                if (startstop == true)
                {
                    spamTextBox.ReadOnly = true;
                    startButton.Visible = false;
                    stopButton.Visible = true;
                }
            }
            
        }

        private void normalSpeed_Click(object sender, EventArgs e)
        {
            timerSpammer.Interval = 500;
            textSpeedValue.Text = "";
        }

        private void lowSpeed_Click(object sender, EventArgs e)
        {
            timerSpammer.Interval = 1000;
            textSpeedValue.Text = "";
        }

        private void methodCopyPaste_Click(object sender, EventArgs e)
        {
            method = true;
        }


        private void methodWrite_Click(object sender, EventArgs e)
        {
            method = false;
        }

        private void timerSpammer_Tick(object sender, EventArgs e)
        {
            if(method)
            {
                MessageBox.Show("Copy Paste Method Coming Soon!", "Error", MessageBoxButtons.OK,  MessageBoxIcon.Error);

                SendKeys.Send(spamTextBox.Text);
                SendKeys.Send("{ENTER}");
            }
            else
            {
                SendKeys.Send(spamTextBox.Text);
                SendKeys.Send("{ENTER}");
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timerSpammer.Enabled = false;
            startstop = false;
            if (startstop == false)
            {
                startButton.Visible = true;
                stopButton.Visible = false;
            }
        }

        public Boolean numbercontroller(String strVeri)
        {
            if (String.IsNullOrEmpty(strVeri) == true)
            {
                return false;
            }
            else
            {
                Regex desen = new Regex("^[0-9]*$");
                return desen.IsMatch(strVeri);
            }
        }

        private void textSpeedValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

      

        private void radioDark_Click(object sender, EventArgs e)
        {
            mainForm form = new mainForm();
            //THEME CONTROLLER
            themecontrol = false;
            //THEME CONTROLLER
            //RESOURCE CHANGE
            menuButton.Image = Properties.Resources.menu;
            homeButton.Image = Properties.Resources.home;
            settingsButton.Image = Properties.Resources.settings;
            infoButton.Image = Properties.Resources.info;
            //RESOURCE CHANGE
            normalSpeed.ForeColor = Color.White;
            highSpeed.ForeColor = Color.White;
            lowSpeed.ForeColor = Color.White;
            customSpeed.BackColor = Color.FromArgb(25, 25, 25);
            customSpeed.ForeColor = Color.White;
            homeButtonSlide.BackColor = Color.FromArgb(25, 25, 25);
            homeButtonSlide.ForeColor = Color.White;
            spamTextBox.BackColor = Color.FromArgb(15, 15, 15);
            spamTextBox.ForeColor = Color.WhiteSmoke;
            startButton.BackColor = Color.FromArgb(25, 25, 25);
            startButton.ForeColor = Color.White;
            stopButton.BackColor = Color.FromArgb(25, 25, 25);
            stopButton.ForeColor = Color.White;
            minimizeButton.BackColor = Color.FromArgb(25, 25, 25);
            exitButton.BackColor = Color.FromArgb(25, 25, 25);
            minimizeButton.BackColor = Color.FromArgb(25, 25, 25);
            exitButton.BackColor = Color.FromArgb(25, 25, 25);
            groupTheme.ForeColor = Color.White;
            this.ForeColor = Color.White;
            methodGroup.ForeColor = Color.White;
            headerLabel.ForeColor = Color.White;
            homeButton.BackColor = Color.FromArgb(23, 23, 23);
            infoButton.BackColor = Color.FromArgb(23, 23, 23);
            settingsButton.BackColor = Color.FromArgb(23, 23, 23);
            radioDark.BackColor = Color.FromArgb(30, 30, 30);
            radioDark.ForeColor = Color.White;
            radioLight.BackColor = Color.FromArgb(30, 30, 30);
            radioLight.ForeColor = Color.White;
            methodCopyPaste.ForeColor = Color.White;
            methodWrite.ForeColor = Color.White;
            selectSpeedGroup.ForeColor = Color.White;
            labelSpeedValue.ForeColor = Color.White;
            selectSpeedGroup.ForeColor = Color.White;
            customSpeedGroup.ForeColor = Color.White;
            textSpeedValue.BackColor = Color.FromArgb(20, 20, 20);
            textSpeedValue.ForeColor = Color.WhiteSmoke;
            applyButton.BackColor = Color.FromArgb(23, 23, 23);
            applyButton.ForeColor = Color.White;
            homeSelector.BackColor = Color.FromArgb(25, 25, 25);
            settingsSelector.BackColor = Color.FromArgb(25, 25, 25);
            infoSelector.BackColor = Color.FromArgb(25, 25, 25);
            topPanel.BackColor = Color.FromArgb(25, 25, 25);
            sliderPanel.BackColor = Color.FromArgb(25, 25, 25);
            settingsPanel.BackColor = Color.FromArgb(30, 30, 30);
            groupTheme.BackColor = Color.FromArgb(30, 30, 30);
            this.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void radioLight_Click(object sender, EventArgs e)
        {

            mainForm form = new mainForm();
            //THEME CONTROLLER
            themecontrol = true;
            //THEME CONTROLLER
            //RESOURCE CHANGE
            menuButton.Image = Properties.Resources.menu_black;
            homeButton.Image = Properties.Resources.home_black;
            settingsButton.Image = Properties.Resources.settings_black;
            infoButton.Image = Properties.Resources.info_black;
            //RESOURCE CHANGE
            highSpeed.ForeColor = Color.Black;
            normalSpeed.ForeColor = Color.Black;
            lowSpeed.ForeColor = Color.Black;
            spamTextBox.BackColor = Color.LightGray;
            spamTextBox.ForeColor = Color.Black;
            startButton.BackColor = Color.LightGray;
            startButton.ForeColor = Color.Black;
            stopButton.BackColor = Color.LightGray;
            stopButton.ForeColor = Color.Black;
            customSpeed.BackColor = Color.LightGray;
            customSpeed.ForeColor = Color.Black;
            minimizeButton.BackColor = Color.LightGray;
            exitButton.BackColor = Color.LightGray;
            minimizeButton.BackColor = Color.LightGray;
            exitButton.BackColor = Color.LightGray;
            applyButton.BackColor = Color.LightGray;
            applyButton.ForeColor = Color.Black;
            textSpeedValue.BackColor = Color.LightGray;
            headerLabel.ForeColor = Color.FromArgb(15,15,15);
            methodGroup.ForeColor = Color.Black;
            textSpeedValue.ForeColor = Color.Black;
            methodCopyPaste.ForeColor = Color.Black;
            customSpeedGroup.ForeColor = Color.Black;
            selectSpeedGroup.ForeColor = Color.Black;
            labelSpeedValue.ForeColor = Color.Black;
            methodWrite.ForeColor = Color.Black;
            settingsPanel.ForeColor = Color.Black;
            groupTheme.ForeColor = Color.Black;
            homeButton.BackColor = Color.LightGray;
            homeButtonSlide.BackColor = Color.LightGray;
            homeButtonSlide.ForeColor = Color.Black;
            infoButton.BackColor = Color.LightGray;
            settingsButton.BackColor = Color.LightGray;
            selectSpeedGroup.ForeColor = Color.Black;
            this.ForeColor = Color.Black;
            radioDark.BackColor = Color.WhiteSmoke;
            radioDark.ForeColor = Color.Black;
            radioLight.BackColor = Color.WhiteSmoke;
            radioLight.ForeColor = Color.Black;
            topPanel.BackColor = Color.LightGray;
            settingsPanel.BackColor = Color.WhiteSmoke;
            groupTheme.BackColor = Color.WhiteSmoke;
            this.BackColor = Color.WhiteSmoke;
            sliderPanel.BackColor = Color.LightGray;
            homeSelector.BackColor = Color.LightGray;
            settingsSelector.BackColor = Color.LightGray;
            infoSelector.BackColor = Color.LightGray;

            
        }

        private void groupTheme_Enter(object sender, EventArgs e)
        {

        }

        private void infoSelector_Click(object sender, EventArgs e)
        {

        }

        private void applyButtonLabel_MouseEnter(object sender, EventArgs e)
        {
           
        }

      

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            if (themecontrol == false)
            {
                minimizeButton.BackColor = Color.FromArgb(20, 20, 20);
            }
            else
            {
                minimizeButton.BackColor = Color.DimGray;
            }
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            if (themecontrol == false)
            {
                minimizeButton.BackColor = Color.FromArgb(25, 25, 25);
            }
            else
            {
                minimizeButton.BackColor = Color.LightGray;
            }
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            if (themecontrol == false)
            {
                
                exitButton.BackColor = Color.Red;
            }
            else
            {
                exitButton.BackColor = Color.Red;
            }
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            if (themecontrol == false)
            {
                exitButton.BackColor = Color.FromArgb(25, 25, 25);
            }
            else
            {
                exitButton.BackColor = Color.LightGray;
            }
        }

        private void stopButton_MouseEnter(object sender, EventArgs e)
        {
            stopButton.BackColor = Color.Red;
        }

        private void stopButton_MouseLeave(object sender, EventArgs e)
        {
            if (themecontrol)
            {
                stopButton.BackColor = Color.LightGray;
            }
            else
            {
                stopButton.BackColor = Color.FromArgb(25, 25, 25);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            
            
            mainForm form = new mainForm();
            if (string.IsNullOrEmpty(textSpeedValue.Text))
            {
                MessageBox.Show("Custom Speed Value Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (numbercontroller(textSpeedValue.Text))
                {
                    int value = Convert.ToInt32(textSpeedValue.Text);
                    timerSpammer.Interval = value;
                    highSpeed.Checked = false;
                    normalSpeed.Checked = false;
                    lowSpeed.Checked = false;
                }
                else
                {
                    MessageBox.Show("Custom Speed Value String!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }
    }
}

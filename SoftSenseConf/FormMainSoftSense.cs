using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace SoftSenseConf
{
    public partial class FormMainSoftSense : Form
    {
        public FormMainSoftSense()
        {
            InitializeComponent();
        }

        string title = "Missing"; // Global text string used in message boxes
        string filePath = ""; // Global variable used for opening a file
        string password;
        string[] recievedDataReadings;
        string[] recievedData = new string[5];
        string commandWrite;
        string connectSoftSensConf = ConfigurationManager.ConnectionStrings["SoftSensConfConnectionString"].ConnectionString;

        /// <summary>
        /// ToolStrip when "Mouse Hover" and "Mouse Leave" in the "Ports" window of the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxComPorts_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_com.Text = "Choose a serial port";
        }

        private void comboBoxBitRates_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_com.Text = "Choose a bitrate";
        }

        private void buttonConnect_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_com.Text = "Connect to device";
        }

        private void buttonDisconnect_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_com.Text = "Disconnect from device";
        }

        private void comboBoxComPorts_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_com.Text = "";
        }

        private void comboBoxBitRates_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_com.Text = "";
        }

        private void buttonConnect_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_com.Text = "";
        }

        private void buttonDisconnect_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_com.Text = "";
        }

        private void button_sendCommands_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "Send command";
        }

        private void button_sendCommands_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "";
        }

        private void button_clear_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "Clear the textbox windows";
        }

        private void button_clear_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "";
        }

        private void button_loadValue_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "Load data from file";
        }

        private void button_loadValue_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "";
        }

        private void button_saveConfigurations_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "Save data to file";
        }

        private void button_saveConfigurations_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "";
        }

        private void button_status_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "Get status from device";
        }

        private void button_status_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "";
        }

        private void button_scaled_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "Get scaled data from device";
        }

        private void button_scaled_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "";
        }

        private void button_raw_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "Get raw data from device";
        }

        private void button_raw_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "";
        }

        private void button_write_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "Write new values to the device";
        }

        private void button_write_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "";
        }

        private void button_about_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_com.Text = "Information about the Software";
        }

        private void button_about_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_com.Text = "";
        }

        private void button_startLiveValues_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_currentValues.Text = "Start reading live values from device";
        }

        private void button_startLiveValues_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_currentValues.Text = "";
        }

        private void button_stopLive_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_currentValues.Text = "Stop live readings from device";
        }

        private void button_stopLive_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_currentValues.Text = "";
        }

        private void button_saveCurrentValues_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_currentValues.Text = "Save live data to a csv file";
        }

        private void button_saveCurrentValues_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_currentValues.Text = "";
        }

        private void button_saveChart_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_currentValues.Text = "Save charts to Png file";
        }

        private void button_saveChart_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_currentValues.Text = "";
        }

        private void button_resetCurrentValues_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_currentValues.Text = "Reset charts and list boxes";
        }

        private void button_resetCurrentValues_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_currentValues.Text = "";
        }

        private void button_status2_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_currentValues.Text = "Device status";
        }

        private void button_status2_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_currentValues.Text = "";
        }

        private void button_DatabaseConfig_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "Save new device configurations or update configurations in database";
        }

        private void button_DatabaseConfig_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "";
        }

        private void buttonUpdateDb_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "Update configurations in database";
        }

        private void buttonUpdateDb_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_instrumentConfig.Text = "";
        }

        private void btnUpdateDAU_MouseHover(object sender, EventArgs e)
        {
            toolStripLabelDAU.Text = "Save new configurations to database or update alredy existing data";
        }

        private void btnUpdateDAU_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabelDAU.Text = "";
        }

        private void btnClearDAU_MouseHover(object sender, EventArgs e)
        {
            toolStripLabelDAU.Text = "Clear all the textboxes";
        }

        private void btnClearDAU_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabelDAU.Text = "";
        }

        /// <summary>
        /// Code to locate usable communication ports and add them to the combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxComPorts_Enter(object sender, EventArgs e)
        {
            comboBox_ports.Items.Clear();
            string[] comPorts = SerialPort.GetPortNames();

            foreach (string ports in comPorts)
            {
                comboBox_ports.Items.Add(ports);
            }
        }

        /// <summary>
        /// Connect to device, as well as to show a message that the device is connected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_ports.SelectedIndex > -1)
                {
                    serialPort_ComPorts.PortName = comboBox_ports.Items[comboBox_ports.SelectedIndex].ToString();

                    if (comboBox_baudRate.SelectedIndex > -1)
                    {
                        serialPort_ComPorts.BaudRate = Convert.ToInt32(comboBox_baudRate.Items[comboBox_baudRate.SelectedIndex]);
                        serialPort_ComPorts.Open();

                        toolStripLabel_connected.Visible = true;
                        toolStripLabel2_connected.Visible = true;
                        toolStripLabel3_connected.Visible = true;
                        toolStripLabel4_connected.Visible = true;
                        toolStripLabel_disconnected.Visible = false;
                        toolStripLabel2_disconnected.Visible = false;
                        toolStripLabel3_disconnected.Visible = false;
                        toolStripLabel4_disconnected.Visible = false;

                        MessageBox.Show("Connection established", "Connected",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (InvalidOperationException) //Catches an error and lets the user know that the device is alredy connected
            {
                MessageBox.Show("The device is alredy connected", "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (comboBox_baudRate.SelectedIndex < 0 && comboBox_ports.SelectedIndex < 0) //Shows a MessageBox if neither a COM-port or Baud rate is selected
            {
                MessageBox.Show("No COM-port or Baud rate selected", title,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (comboBox_ports.SelectedIndex < 0) //Shows a MessageBox if just the COM-port is not selected
            {
                MessageBox.Show("COM-port not selected", title,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (comboBox_baudRate.SelectedIndex < 0) //Shows a MessageBox if just the Baud rate is not selected
            {
                MessageBox.Show("Baud rate not selected", title,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Disconnect device and shows a message that device disconnected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {

            serialPort_ComPorts.Close();

            toolStripLabel_connected.Visible = false;
            toolStripLabel2_connected.Visible = false;
            toolStripLabel3_connected.Visible = false;
            toolStripLabel4_connected.Visible = false;
            toolStripLabel_disconnected.Visible = true;
            toolStripLabel2_disconnected.Visible = true;
            toolStripLabel3_disconnected.Visible = true;
            toolStripLabel4_disconnected.Visible = true;

            MessageBox.Show("Device disconnected", "Disconnected",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// When the About button is clicked, opens an "about" window with information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_about_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        /// <summary>
        /// Sends different commands to the connected device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_read_Click(object sender, EventArgs e)
        {
            try
            {
                string bufferClear = "";

                serialPort_ComPorts.WriteLine("readconf");
                label_status.Hide();
                timer_configurations.Enabled = true;

                bufferClear = serialPort_ComPorts.ReadExisting().ToString();
            }
            catch (InvalidOperationException)
            {
                toolStripLabel_connected.Visible = false;
                toolStripLabel_disconnected.Visible = true;

                toolStripLabel2_connected.Visible = false;
                toolStripLabel2_disconnected.Visible = true;

                toolStripLabel3_connected.Visible = false;
                toolStripLabel3_disconnected.Visible = true;

                toolStripLabel4_connected.Visible = false;
                toolStripLabel4_disconnected.Visible = true;
                
                MessageBox.Show("Device not connected", "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button_status_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_ComPorts.WriteLine("readstatus");
                label_status.Show();
                timer_configurations.Enabled = true;

            }
            catch (InvalidOperationException)
            {
                toolStripLabel_connected.Visible = false;
                toolStripLabel_disconnected.Visible = true;

                toolStripLabel2_connected.Visible = false;
                toolStripLabel2_disconnected.Visible = true;

                toolStripLabel3_connected.Visible = false;
                toolStripLabel3_disconnected.Visible = true;

                toolStripLabel4_connected.Visible = false;
                toolStripLabel4_disconnected.Visible = true;

                MessageBox.Show("Device not connected", "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_raw_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_ComPorts.WriteLine("readraw");
                label_status.Hide();
                timer_configurations.Enabled = true;
            }
            catch (InvalidOperationException)
            {
                toolStripLabel_connected.Visible = false;
                toolStripLabel_disconnected.Visible = true;

                toolStripLabel2_connected.Visible = false;
                toolStripLabel2_disconnected.Visible = true;

                toolStripLabel3_connected.Visible = false;
                toolStripLabel3_disconnected.Visible = true;

                toolStripLabel4_connected.Visible = false;
                toolStripLabel4_disconnected.Visible = true;

                MessageBox.Show("Device not connected", "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_scaled_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_ComPorts.WriteLine("readscaled");
                label_status.Hide();
                timer_configurations.Enabled = true;
            }
            catch (InvalidOperationException)
            {
                toolStripLabel_connected.Visible = false;
                toolStripLabel_disconnected.Visible = true;

                toolStripLabel2_connected.Visible = false;
                toolStripLabel2_disconnected.Visible = true;

                toolStripLabel3_connected.Visible = false;
                toolStripLabel3_disconnected.Visible = true;

                toolStripLabel4_connected.Visible = false;
                toolStripLabel4_disconnected.Visible = true;

                MessageBox.Show("Device not connected", "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// When the write button is presse, a password window opens and the changes is applied.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button_write_Click(object sender, EventArgs e)
        {
            PasswordForm pfrm = new PasswordForm();
            pfrm.ShowDialog(); //Shows the PasswordForm
            password = pfrm.textPassword;

            commandWrite = "writeconf";
            string[] newConfData = new string[5];

            newConfData[0] = textBox_tagName.Text;
            newConfData[1] = textBox_lowerRangeValue.Text;
            newConfData[2] = textBox_upperRangeValue.Text;
            newConfData[3] = textBox_alarmLow.Text;
            newConfData[4] = textBox_alarmHigh.Text;


            string writeString = commandWrite + ">" + password + ">" + string.Join(";", newConfData);

            serialPort_ComPorts.WriteLine(writeString);
            timer_write.Enabled = true;

        }

        /// <summary>
        /// The user can save data to a ssc file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_saveConfigurations_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string configsFromDevice = textBox_showConfigurations.Text;
            string[] dataToSave = configsFromDevice.Split(';');

            if (textBox_showConfigurations.Text != string.Empty)
            {
                if (saveFileDialog_saveConfigurations.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog_saveConfigurations.FileName;
                    File.WriteAllLines(fileName, dataToSave);

                    MessageBox.Show(fileName, "File was saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No values to save", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        /// <summary>
        /// The user can choose a file to open in the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_loadValue_Click(object sender, EventArgs e)
        {
            var fileName = string.Empty;
            openFileDialog_instrumentConfig.InitialDirectory = "c:\\";
            openFileDialog_instrumentConfig.RestoreDirectory = true;
            openFileDialog_instrumentConfig.FileName = "";

            if (openFileDialog_instrumentConfig.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog_instrumentConfig.FileName;
                filePath = openFileDialog_instrumentConfig.FileName;
            }

            if (File.Exists(filePath)) // This is only executed if the file at filePath exists
            {
                string dataFromFile = "";
                using (StreamReader sr = new StreamReader(filePath))
                {
                    dataFromFile = sr.ReadToEnd(); //Saves all text
                    textBox_showConfigurations.Text = dataFromFile.ToString(); // Displays the data from loaded file inside the "showConfigurations" textbox
                }
            }
        }

        /// <summary>
        /// Clears the textboxes in the "Instrument Configuration" window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_tagName.Text = "";
            textBox_lowerRangeValue.Text = "";
            textBox_upperRangeValue.Text = "";
            textBox_alarmLow.Text = "";
            textBox_alarmHigh.Text = "";
            textBox_showConfigurations.Text = "";
            tbInterval.Text = "";
            tbUnit.Text = "";
            tbDescription.Text = "";
        }

        /// <summary>
        /// Clears textboxes in the "DAU" window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearDAU_Click(object sender, EventArgs e)
        {
            dAU_IDTextBox1.Text = "";
            baud_rateTextBox1.Text = "";
            data_bitsTextBox1.Text = "";
            parityTextBox1.Text = "";
            stop_bitTextBox1.Text = "";
            descriptionTextBox1.Text = "";
        }

        /// <summary>
        /// Starts timer so the program will be able to read live data, as well as to show the right chart 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_startLiveValues_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_tagName.Enabled = false;

                if (tbInterval.TextLength == 0)
                {
                    labelStandardInterval.Visible = true;
                    labelloggingInterval.Visible = false;
                }
                else
                {
                    labelloggingInterval.Visible = true;
                    labelStandardInterval.Visible = false;
                }

                Thread.Sleep(1000); //milliseconds
                if (checkBox_raw.Checked == true && checkBox_scaled.Checked == false)
                {
                    label_status.Hide();

                    checkBox_scaled.Enabled = false;

                    tbInterval.Enabled = false;

                    timer_rawValuesLive.Enabled = true;
                    chart_rawValues.Visible = true;
                    chart_scaledLive.Visible = false;

                    if (textBox_tagName.TextLength == 0)
                    {
                        MessageBox.Show("TagName missing.\nPress <Stop> and insert TagName in configuration window", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (checkBox_raw.Checked == false && checkBox_scaled.Checked == true)
                {
                    label_status.Hide();

                    checkBox_raw.Enabled = false;

                    tbInterval.Enabled = false;

                    timer_scaledLive1.Enabled = true;
                    chart_scaledLive.Visible = true;
                    chart_rawValues.Visible = false;

                    if (textBox_tagName.TextLength == 0)
                    {
                        MessageBox.Show("TagName missing.\nPress <Stop> and insert TagName in configuration window", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (checkBox_raw.Checked == false && checkBox_scaled.Checked == false)
                {
                    MessageBox.Show("Select  values to read", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (checkBox_raw.Checked == true && checkBox_scaled.Checked == true)
                {
                    MessageBox.Show("Only one data value can be read at a time", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                label_sentToDatabase.Visible = true;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Device not connected", "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                toolStripLabel3_connected.Visible = false;
                toolStripLabel3_disconnected.Visible = true;
            }
        }

        /// <summary>
        /// This button stops the live data readings displayed in charts and listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stopLive_Click(object sender, EventArgs e)
        {
            try
            {
                string bufferClear = "";
                
                tbInterval.Enabled = true;
                textBox_tagName.Enabled = true;

                checkBox_raw.Enabled = true;
                checkBox_scaled.Enabled = true;

                labelloggingInterval.Visible = false;
                labelStandardInterval.Visible = false;

                if (checkBox_raw.Checked == true && checkBox_scaled.Checked == false)
                {
                    timer_rawValuesLive.Enabled = false;
                    timer_rawValuesLive2.Enabled = false;

                    label_status.Hide();
                }

                else if (checkBox_raw.Checked == false && checkBox_scaled.Checked == true)
                {
                    timer_scaledLive1.Enabled = false;
                    timer_scaledLive2.Enabled = false;

                    label_status.Hide();
                }

                label_sentToDatabase.Visible = false;

                bufferClear = serialPort_ComPorts.ReadExisting().ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Device not connected", "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Saves data from listBox in the "Current Values" window to a csv file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_saveCurrentValues_Click(object sender, EventArgs e)
        {
            if (checkBox_raw.Checked == true && checkBox_scaled.Checked == false)
            {
                if (listBox_liveDataRaw.Items.Count != 0 || listBox_liveDataScaled.Items.Count != 0)
                {
                    if (saveFileDialog_currentValues.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter liveDataReadings = new StreamWriter(saveFileDialog_currentValues.FileName))

                            for (int i = 0; i < listBox_liveDataRaw.Items.Count; i++)
                            {
                                liveDataReadings.WriteLine((string)listBox_liveDataRaw.Items[i]);
                            }

                        MessageBox.Show("File was saved", "Saving",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("There are no values to save", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (checkBox_raw.Checked == false && checkBox_scaled.Checked == true)
            {
                if (listBox_liveDataRaw.Items.Count != 0 || listBox_liveDataScaled.Items.Count != 0)
                {
                    if (saveFileDialog_currentValues.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter liveDataReadings = new StreamWriter(saveFileDialog_currentValues.FileName))

                            for (int i = 0; i < listBox_liveDataScaled.Items.Count; i++)
                            {
                                liveDataReadings.WriteLine((string)listBox_liveDataScaled.Items[i]);
                            }

                        MessageBox.Show("File was saved", "Saving",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("There are no values to save", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (checkBox_raw.Checked == false && checkBox_scaled.Checked == false)
            {
                MessageBox.Show("Select which values to save", "Save Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            saveFileDialog_currentValues.Dispose();
        }

        /// <summary>
        /// Saves the charts to a png file. Note that only one chart can be saved at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_saveChart_Click(object sender, EventArgs e)
        {
            if (checkBox_raw.Checked == true && checkBox_scaled.Checked == false)
            {
                if (saveFileDialog_chartRaw.ShowDialog() == DialogResult.OK)
                {
                    this.chart_rawValues.SaveImage(saveFileDialog_chartRaw.FileName,
                        System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

                    MessageBox.Show("Chart with raw values was saved", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (checkBox_raw.Checked == false && checkBox_scaled.Checked == true)
            {
                if (saveFileDialog_chartScaled.ShowDialog() == DialogResult.OK)
                {
                    this.chart_scaledLive.SaveImage(saveFileDialog_chartScaled.FileName,
                        System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

                    MessageBox.Show("Chart with scaled values was saved", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Unable to save two charts at a time", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Resets values in listBox as well as the charts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_resetCurrentValues_Click(object sender, EventArgs e)
        {
            listBox_liveDataRaw.Items.Clear();
            listBox_liveDataScaled.Items.Clear();
            label_status.Hide();

            chart_rawValues.Visible = false;
            chart_scaledLive.Visible = false;

            checkBox_raw.Checked = false;
            checkBox_scaled.Checked = false;
            checkBox_raw.Enabled = true;
            checkBox_scaled.Enabled = true;

            timer_rawValuesLive.Enabled = false;
            timer_scaledLive1.Enabled = false;

            label_sentToDatabase.Visible = false;
            labelloggingInterval.Visible = false;
            labelStandardInterval.Visible = false;

            foreach (var series in chart_rawValues.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in chart_scaledLive.Series)
            {
                series.Points.Clear();
            }
        }

        /// <summary>
        /// Timers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_configurations_Tick(object sender, EventArgs e)
        {
            if (serialPort_ComPorts.BytesToRead > 0)
            {
                string clearBuffer = "";
                string deviceConfig = "";
                deviceConfig = serialPort_ComPorts.ReadExisting().ToString() + "\r\n";

                recievedDataReadings = deviceConfig.Split(';');
                textBox_showConfigurations.AppendText(deviceConfig);


                if (recievedDataReadings.Length == 5)
                {
                    textBox_showConfigurations.Text = deviceConfig;
                    textBox_tagName.Text = recievedDataReadings[0];
                    textBox_lowerRangeValue.Text = recievedDataReadings[1];
                    textBox_upperRangeValue.Text = recievedDataReadings[2];
                    textBox_alarmLow.Text = recievedDataReadings[3];
                    textBox_alarmHigh.Text = recievedDataReadings[4];
                }

                timer_configurations.Enabled = false;
                clearBuffer = serialPort_ComPorts.ReadExisting().ToString();
            }
        }

        private void timer_write_Tick(object sender, EventArgs e)
        {
            try
            {
                string success = serialPort_ComPorts.ReadExisting();

                if (success.Length > 0)
                {
                    try
                    {
                        if (success == "1")
                        {

                            MessageBox.Show("Action Successful", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Controll that the password is correct or try pressing the Clear button",
                                "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        timer_write.Enabled = false;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Something went wrong. Try agian", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("The communication port is closed", "Port Closed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer_rawValuesLive_Tick(object sender, EventArgs e)
        {
            if (serialPort_ComPorts.IsOpen)
            {
                serialPort_ComPorts.WriteLine("readraw");

                timer_rawValuesLive.Enabled = false;
                timer_rawValuesLive2.Enabled = true;
            }
        }

        private void timer_rawValuesLive2_Tick(object sender, EventArgs e)
        {
            string buffClear = "";

            
            //Lets the user choose logging frequency in seconds:
            if (tbInterval.Text == "")
            {
                timer_rawValuesLive2.Interval = 1000; //Milliseconds
            }
            else
            {
                timer_rawValuesLive2.Interval = int.Parse(tbInterval.Text.ToString()) * 1000;
            }
                       

            string getRawdata = serialPort_ComPorts.ReadExisting().ToString();
            int.TryParse(getRawdata, out int checkVal);


            SqlConnection con = new SqlConnection(connectSoftSensConf);
            string sqlInsertQuery = ("INSERT INTO AI (RawValue, TagName) VALUES (@RawValue, @TagName)");
            SqlCommand com = new SqlCommand(sqlInsertQuery, con);
            con.Open();

            try
            {
                if (getRawdata == "" || getRawdata.Split(',').Length != 1 || checkVal > 1000 || checkVal < 0 || textBox_tagName.TextLength == 0)
                {
                    buffClear = serialPort_ComPorts.ReadExisting().ToString();
                }
                else
                {
                    listBox_liveDataRaw.Items.Add(getRawdata);
                    chart_rawValues.Series[0].Points.AddXY(Convert.ToInt32(listBox_liveDataRaw.Items.Count - 1),
                    Convert.ToInt32(listBox_liveDataRaw.Items[listBox_liveDataRaw.Items.Count - 1]));

                    com.Parameters.AddWithValue("@RawValue", Convert.ToInt32(getRawdata));
                    com.Parameters.AddWithValue("@TagName", textBox_tagName.Text);
                    com.ExecuteNonQuery();
                    com.Parameters.Clear();

                }

                timer_rawValuesLive2.Enabled = false;
                timer_rawValuesLive.Enabled = true;
            }
            catch (SqlException)
            {

            }

        }

        private void timer_scaledLive1_Tick(object sender, EventArgs e)
        {
            if (serialPort_ComPorts.IsOpen)
            {
                serialPort_ComPorts.WriteLine("readscaled");

                timer_scaledLive1.Enabled = false;
                timer_scaledLive2.Enabled = true;
            }

        }

        //When this timer starts, the program will collect scaled data if different criterias is met.
        private void timer_scaledLive2_Tick(object sender, EventArgs e)
        {
            string bufferClear = "";

            
            //Lets the user choose logging frequency in seconds:
            if (tbInterval.TextLength == 0)
            {
                timer_scaledLive2.Interval = 1000; //Milliseconds
            }
            else
            {
                timer_scaledLive2.Interval = int.Parse(tbInterval.Text.ToString()) * 1000;
            }

            string getScaledData = serialPort_ComPorts.ReadExisting().ToString();
            getScaledData = getScaledData.Replace(".", ","); // Error messages is shown in Norwegian, so this part is to replace . with ,
            double.TryParse(getScaledData, out double checkVal);

            SqlConnection con = new SqlConnection(connectSoftSensConf);
            string sqlInsertQuery = ("INSERT INTO AI (ScaledValue, TagName) VALUES (@ScaledValue, @TagName)");
            SqlCommand com = new SqlCommand(sqlInsertQuery, con);
            con.Open();

            try
            {


                if (getScaledData == "" || checkVal > 1000 || checkVal < 0 || getScaledData.Split(',').Length > 2 || textBox_tagName.TextLength == 0)
                {
                    bufferClear = serialPort_ComPorts.ReadExisting().ToString();
                }
                else
                {

                    listBox_liveDataScaled.Items.Add(getScaledData);
                    chart_scaledLive.Series[0].Points.AddXY(Convert.ToDouble(listBox_liveDataScaled.Items.Count - 1),
                        Convert.ToDouble(listBox_liveDataScaled.Items[listBox_liveDataScaled.Items.Count - 1]));

                    com.Parameters.AddWithValue("@ScaledValue", Convert.ToDouble(getScaledData));
                    com.Parameters.AddWithValue("@TagName", textBox_tagName.Text);
                    com.ExecuteNonQuery();
                    com.Parameters.Clear();
                }

                timer_scaledLive2.Enabled = false;
                timer_scaledLive1.Enabled = true;

            }
            catch (SqlException)
            {

            }

        }

        /// <summary>
        /// Only allows numbers and backspace in some of the text boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_lowerRangeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_lowerRangeValue.MaxLength = 7;
            
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != ',')
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if ((chr == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;

                MessageBox.Show("Only one decimal point allowed.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox_upperRangeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_upperRangeValue.MaxLength = 7;

            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != ',')
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if ((chr == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;

                MessageBox.Show("Only one decimal point allowed.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox_alarmLow_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox_alarmHigh_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Only allows integer.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbInterval_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Only allows integer.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox_DAU_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Please choose an alredy existing value in combobox.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Please choose an alredy existing value in combobox.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Please choose an alredy existing value in combobox.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Please choose an alredy existing value in combobox.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Please choose an alredy existing value in combobox.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Please choose an alredy existing value in combobox.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Please choose an alredy existing value in combobox.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Please choose an alredy existing value in combobox.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbFindDeviceDAU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Choose values registered in combobox.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbRDCdau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Please choose an alredy existing value in combobox.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbModelDAU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Please choose an alredy existing value in combobox.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCompanyDAU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Please choose an alredy existing value in combobox.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbLocationDAU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Please choose an alredy existing value in combobox.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deviceNameTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            deviceNameTextBox1.MaxLength = 10;

            //For some reason I also had to permit '_' to make '-' work without messagebox showing up.
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar == '_' && e.KeyChar == '-') 
            {
                e.Handled = true;

                MessageBox.Show("Only allows digits and letters.\nText can only be 10 characters long.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dAU_IDTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Only allows integer.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void data_bitsTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Only allows integer.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void parityTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            parityTextBox1.MaxLength = 1;

            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Only allow either one letter or one digit.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void stop_bitTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Only allows integer.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void descriptionTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            descriptionTextBox1.MaxLength = 100;

            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar == '.' && e.KeyChar == ',' && e.KeyChar == '-')
            {
                e.Handled = true;

                MessageBox.Show("Only allows 100 characters.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void computer_IDTextBoxRDC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Only allows integer.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbAccessID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Choose an alredy existing value in combobox.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbCompanyRDC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Choose an alredy existing value in combobox.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbLocationRDC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Choose an alredy existing value in combobox.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Makes the "Write" button visible only after all the conditions are met.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_tagName_TextChanged(object sender, EventArgs e)
        {
            if (textBox_tagName.Text.Length > 0 && textBox_lowerRangeValue.Text.Length > 0
                && textBox_upperRangeValue.Text.Length > 0 && textBox_alarmLow.Text.Length > 0 && textBox_alarmHigh.Text.Length > 0)
            {
                button_write.Visible = true;
            }

            else
            {
                button_write.Visible = false;
            }
        }

        private void textBox_lowerRangeValue_TextChanged(object sender, EventArgs e)
        {
            if (textBox_tagName.Text.Length > 0 && textBox_lowerRangeValue.Text.Length > 0
                && textBox_upperRangeValue.Text.Length > 0 && textBox_alarmLow.Text.Length > 0 && textBox_alarmHigh.Text.Length > 0)
            {
                button_write.Visible = true;
            }

            else
            {
                button_write.Visible = false;
            }
        }

        private void textBox_upperRangeValue_TextChanged(object sender, EventArgs e)
        {
            if (textBox_tagName.Text.Length > 0 && textBox_lowerRangeValue.Text.Length > 0
                && textBox_upperRangeValue.Text.Length > 0 && textBox_alarmLow.Text.Length > 0 && textBox_alarmHigh.Text.Length > 0)
            {
                button_write.Visible = true;
            }

            else
            {
                button_write.Visible = false;
            }
        }

        private void textBox_alarmLow_TextChanged(object sender, EventArgs e)
        {
            if (textBox_tagName.Text.Length > 0 && textBox_lowerRangeValue.Text.Length > 0
                && textBox_upperRangeValue.Text.Length > 0 && textBox_alarmLow.Text.Length > 0 && textBox_alarmHigh.Text.Length > 0)
            {
                button_write.Visible = true;
            }

            else
            {
                button_write.Visible = false;
            }
        }

        private void textBox_alarmHigh_TextChanged(object sender, EventArgs e)
        {
            if (textBox_tagName.Text.Length > 0 && textBox_lowerRangeValue.Text.Length > 0
                && textBox_upperRangeValue.Text.Length > 0 && textBox_alarmLow.Text.Length > 0 && textBox_alarmHigh.Text.Length > 0)
            {
                button_write.Visible = true;
            }

            else
            {
                button_write.Visible = false;
            }
        }

        /// <summary>
        /// Different table adapters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMainSoftSense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softSensConfDataSet.MCU' table. You can move, or remove it, as needed.
            this.mCUTableAdapter.Fill(this.softSensConfDataSet.MCU);
            // TODO: This line of code loads data into the 'softSensConfDataSet.RDC1' table. You can move, or remove it, as needed.
            this.rDC1TableAdapter.Fill(this.softSensConfDataSet.RDC1);
            // TODO: This line of code loads data into the 'softSensConfDataSet.INSTRUMENT' table. You can move, or remove it, as needed.
            this.iNSTRUMENTTableAdapter.Fill(this.softSensConfDataSet.INSTRUMENT);
            // TODO: This line of code loads data into the 'softSensConfDataSet.INSTRUMENT1' table. You can move, or remove it, as needed.
            this.iNSTRUMENT1TableAdapter.Fill(this.softSensConfDataSet.INSTRUMENT1);
            // TODO: This line of code loads data into the 'softSensConfDataSet.RDC' table. You can move, or remove it, as needed.
            this.rDCTableAdapter.Fill(this.softSensConfDataSet.RDC);
            // TODO: This line of code loads data into the 'softSensConfDataSet.DAU1' table. You can move, or remove it, as needed.
            this.dAU1TableAdapter.Fill(this.softSensConfDataSet.DAU1);
            // TODO: This line of code loads data into the 'softSensConfDataSet.Area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this.softSensConfDataSet.Area);
            // TODO: This line of code loads data into the 'softSensConfDataSet.COMPANY' table. You can move, or remove it, as needed.
            this.cOMPANYTableAdapter.Fill(this.softSensConfDataSet.COMPANY);
            // TODO: This line of code loads data into the 'softSensConfDataSet.TYPE' table. You can move, or remove it, as needed.
            this.tYPETableAdapter.Fill(this.softSensConfDataSet.TYPE);
            // TODO: This line of code loads data into the 'softSensConfDataSet.DAU' table. You can move, or remove it, as needed.
            this.dAUTableAdapter.Fill(this.softSensConfDataSet.DAU);

            dAU_IDTextBox.Enabled = false;
            deviceNameTextBox.Enabled = false;
            baud_rateTextBox.Enabled = false;
            data_bitsTextBox.Enabled = false;
            parityTextBox.Enabled = false;
            stop_bitTextBox.Enabled = false;
            tbModel.Enabled = false;
            tbCompany.Enabled = false;
            tbLocation.Enabled = false;
            descriptionTextBox.Enabled = false;
            computer_IDTextBox.Enabled = false;

            loweRangeValuesTextBox.Enabled = false;
            upperRangeValuesTextBox.Enabled = false;
            alarmHighTextBox.Enabled = false;
            alarmLowTextBox.Enabled = false;
            tagNameTextBox.Enabled = false;
            measurementUnitTextBox.Enabled = false;
            modelNumberTextBox.Enabled = false;
            intervalTextBox.Enabled = false;
            companyIDTextBox.Enabled = false;
            areaIDTextBox.Enabled = false;
            dAU_IDTextBox2.Enabled = false;
            descriptionTextBox2.Enabled = false;

            labelloggingInterval.Visible = false;
            labelStandardInterval.Visible = false;


        }

        /// <summary>
        /// Buttons sending information to the SQL database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_DatabaseConfig_Click(object sender, EventArgs e)
        {
            try
            {

                //Converting to right type:
                int alarmHigh = int.Parse(textBox_alarmHigh.Text.ToString());
                int alarmLow = int.Parse(textBox_alarmLow.Text.ToString());
                int dau_ID = int.Parse(comboBox_DAU_ID.SelectedValue.ToString());
                double lRV = double.Parse(textBox_lowerRangeValue.Text.ToString().Replace(".", ","));
                double uRV = double.Parse(textBox_upperRangeValue.Text.ToString().Replace(".", ","));
                int alarmL = int.Parse(textBox_alarmLow.Text.ToString());
                int alarmH = int.Parse(textBox_alarmHigh.Text.ToString());
                int interval = int.Parse(tbInterval.Text.ToString());
                int modelNo = int.Parse(cbModel.SelectedValue.ToString());
                int company = int.Parse(cbCompany.SelectedValue.ToString());
                int area = int.Parse(cbLocation.SelectedValue.ToString());

                if (textBox_tagName.TextLength > 0 && textBox_lowerRangeValue.TextLength > 0 && textBox_upperRangeValue.TextLength > 0 && textBox_alarmHigh.TextLength > 0
                    && textBox_alarmLow.TextLength > 0)
                {
                    SqlConnection con = new SqlConnection(connectSoftSensConf);
                    con.Open();

                    //SQL command for checking if "TagName" exists in database:
                    string tag = "SELECT TOP 1 TagName FROM INSTRUMENT WHERE TagName = @TagName";

                    //SQL commands for registering device configurations to database:
                    string query = "INSERT INTO INSTRUMENT (TagName, LoweRangeValues, UpperRangeValues, AlarmLow, AlarmHigh, DAU_ID," +
                        "Interval, MeasurementUnit, ModelNumber, CompanyID, AreaID, Description)" +
                        " VALUES (@TagName, @LoweRangeValues, @UpperRangeValues, @AlarmLow, @AlarmHigh, @DAU_ID, @Interval, @MeasurementUnit, @ModelNumber," +
                        "@CompanyID, @AreaID, @Description)";

                    //SQL commands for updating configurations in database:
                    string instrumentUpdate = "UPDATE INSTRUMENT SET LoweRangeValues = @LoweRangeValues, " +
                        "UpperRangeValues = @UpperRangeValues, AlarmLow = @AlarmLow, AlarmHigh = @AlarmHigh, DAU_ID = @DAU_ID, Interval = @Interval," +
                        "MeasurementUnit = @MeasurementUnit, Description = @Description, ModelNumber = @ModelNumber, CompanyID = @CompanyID, AreaID = @AreaID " +
                        "WHERE TagName = @TagName";

                    SqlCommand tagName = new SqlCommand(tag, con);

                    tagName.Parameters.AddWithValue("@TagName", textBox_tagName.Text);
                    var TagName = tagName.ExecuteScalar();

                    SqlCommand cmd = new SqlCommand("", con);

                    if (TagName == null)
                    {
                        cmd = new SqlCommand(query, con);
                    }
                    else
                    {
                        cmd = new SqlCommand(instrumentUpdate, con);
                    }

                    cmd.Parameters.AddWithValue("@TagName", textBox_tagName.Text);
                    cmd.Parameters.AddWithValue("@LoweRangeValues", lRV);
                    cmd.Parameters.AddWithValue("@UpperRangeValues", uRV);
                    cmd.Parameters.AddWithValue("@AlarmLow", alarmL);
                    cmd.Parameters.AddWithValue("@AlarmHigh", alarmH);
                    cmd.Parameters.AddWithValue("@DAU_ID", dau_ID);
                    cmd.Parameters.AddWithValue("@Interval", interval);
                    cmd.Parameters.AddWithValue("@MeasurementUnit", tbUnit.Text);
                    cmd.Parameters.AddWithValue("@ModelNumber", modelNo);
                    cmd.Parameters.AddWithValue("@CompanyID", company);
                    cmd.Parameters.AddWithValue("@AreaID", area);
                    cmd.Parameters.AddWithValue("@Description", tbDescription.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Configurations was Registered/Updated in database", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Make sure to insert information into every textbox and combobox.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show("Make sure to insert information into every textbox and combobox.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateDAU_Click(object sender, EventArgs e)
        {
            try
            {

                //Converting to right type:
                int dauID = int.Parse(dAU_IDTextBox1.Text.ToString());
                int baud = int.Parse(baud_rateTextBox1.Text.ToString());
                int dataBits = int.Parse(data_bitsTextBox1.Text.ToString());
                int stpBit = int.Parse(stop_bitTextBox1.Text.ToString());
                int model = int.Parse(cbModelDAU.SelectedValue.ToString());
                int company = int.Parse(cbCompanyDAU.SelectedValue.ToString());
                int location = int.Parse(cbLocationDAU.SelectedValue.ToString());
                int rdc = int.Parse(cbRDCdau.SelectedValue.ToString());
                string parity = parityTextBox1.Text;
                string deviceName = deviceNameTextBox1.Text;
                string descripton = descriptionTextBox1.Text;

                if (dAU_IDTextBox1.TextLength > 0 && deviceNameTextBox1.TextLength > 0 && baud_rateTextBox1.TextLength > 0 && data_bitsTextBox1.TextLength > 0
                    && parityTextBox1.TextLength > 0 && stop_bitTextBox1.TextLength > 0)
                {
                    SqlConnection con = new SqlConnection(connectSoftSensConf);
                    con.Open();

                    //SQL command for checking if "DAU_ID" exists in database:
                    string DAU = "SELECT TOP 1 DAU_ID FROM DAU WHERE DAU_ID = @DAU_ID";

                    //SQL commands for registering device configurations to database:
                    string query = "INSERT INTO DAU (DAU_ID, DeviceName, Baud_rate, Data_bits, Parity, Stop_bit," +
                        "Description, ModelNumber, CompanyID, AreaID, Computer_ID)" +
                        " VALUES (@DAU_ID, @DeviceName, @Baud_rate, @Data_bits, @Parity, @Stop_bit, @Description, @ModelNumber," +
                        "@CompanyID, @AreaID, @Computer_ID)";

                    //SQL commands for updating configurations in database:
                    string dauUpdate = "UPDATE DAU SET DeviceName = @DeviceName, Baud_rate = @Baud_rate, Data_bits = @Data_bits, Parity = @Parity," +
                        "Stop_bit = @Stop_bit, Description = @Description, ModelNumber = @ModelNumber, CompanyID = @CompanyID, AreaID = @AreaID," +
                        "Computer_ID = @Computer_ID " +
                        "WHERE DAU_ID = @DAU_ID";

                    SqlCommand dau = new SqlCommand(DAU, con);

                    dau.Parameters.AddWithValue("@DAU_ID", dAU_IDTextBox1.Text);
                    var Dau = dau.ExecuteScalar();

                    SqlCommand cmd = new SqlCommand("", con);

                    if (Dau == null)
                    {
                        cmd = new SqlCommand(query, con);
                    }
                    else
                    {
                        cmd = new SqlCommand(dauUpdate, con);
                    }

                    cmd.Parameters.AddWithValue("@DAU_ID", dauID);
                    cmd.Parameters.AddWithValue("@DeviceName", deviceName);
                    cmd.Parameters.AddWithValue("@Baud_rate", baud);
                    cmd.Parameters.AddWithValue("@Data_bits", dataBits);
                    cmd.Parameters.AddWithValue("@Parity", parity);
                    cmd.Parameters.AddWithValue("@Stop_bit", stpBit);
                    cmd.Parameters.AddWithValue("@Description", descripton);
                    cmd.Parameters.AddWithValue("@ModelNumber", model);
                    cmd.Parameters.AddWithValue("@CompanyID", company);
                    cmd.Parameters.AddWithValue("@AreaID", location);
                    cmd.Parameters.AddWithValue("@Computer_ID", rdc);

                    cmd.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Configurations was Registered/Updated in database", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Make sure to insert information into every textbox and combobox.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show("Make sure to insert information into every textbox and combobox.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Retreaving information from database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFindDeviceDAU_Enter(object sender, EventArgs e)
        {
            this.dAU1TableAdapter.Fill(this.softSensConfDataSet.DAU1);
            cbFindDeviceDAU.DisplayMember = "DeviceName";
            cbFindDeviceDAU.ValueMember = "DAU_ID";
            cbFindDeviceDAU.DataSource = softSensConfDataSet.DAU1;
        }

        private void cbFindDeviceDAU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFindDeviceDAU.SelectedIndex > -1)
            {
                int filterDAUID = Convert.ToInt32(cbFindDeviceDAU.SelectedValue.ToString());
                this.dAUTableAdapter.FillByDAUID(this.softSensConfDataSet.DAU, filterDAUID);
            }
        }

        private void cbFindInstrument_Enter(object sender, EventArgs e)
        {
            this.iNSTRUMENT1TableAdapter.Fill(this.softSensConfDataSet.INSTRUMENT1);
            cbFindInstrument.DisplayMember = "TagName";
            cbFindInstrument.ValueMember = "TagName";
            cbFindInstrument.DataSource = softSensConfDataSet.INSTRUMENT1;
        }

        private void cbFindInstrument_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFindInstrument.SelectedIndex > -1)
            {
                var filterInstrument = Convert.ToString(cbFindInstrument.SelectedValue.ToString());
                this.iNSTRUMENTTableAdapter.FillByTagName(this.softSensConfDataSet.INSTRUMENT, filterInstrument);
            }
        }
    }
}
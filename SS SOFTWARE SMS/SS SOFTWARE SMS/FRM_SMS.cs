using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SS_SOFTWARE_SMS
{
    public partial class FRM_SMS : Form
    {
        private SerialPort serialPort;

        public FRM_SMS()
        {
            InitializeComponent();

            // Initialize the SerialPort
            serialPort = new SerialPort();

            // Populate the combo box with available serial ports
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbcom.Items.Add(port);
            }

            // Select the first port if available
            if (ports.Length > 0)
            {
                cmbcom.SelectedIndex = 0;
            }
        }

        private void FRM_SMS_Load(object sender, EventArgs e)
        {
            // Disable the Send button until a port is selected
            btnsend.Enabled = false;
        }

        private void FRM_SMS_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the serial port when the form is closing
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtphone.Text;
            string message = txtmessage.Text;

            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }

                serialPort.WriteLine("AT+CMGF=1" + Environment.NewLine);
                string response = serialPort.ReadExisting();
                Console.WriteLine("Response: " + response); // Log response

                // Set the recipient's phone number
                serialPort.WriteLine($"AT+CMGS=\"{phoneNumber}\"" + Environment.NewLine);
                System.Threading.Thread.Sleep(100);
                response = serialPort.ReadExisting();
                Console.WriteLine("Response: " + response); // Log response

                // Write the message and control character (Ctrl+Z) to send
                serialPort.Write(message + (char)26);
                serialPort.BaseStream.Flush();
                System.Threading.Thread.Sleep(3000); // Wait for the message to be sent
                response = serialPort.ReadExisting();
                Console.WriteLine("Response: " + response); // Log response

                if (response.Contains("ERROR"))
                {
                    MessageBox.Show($"Error in sending SMS: {response}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("SMS Sent Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending SMS: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close(); // Close the port after sending
                }
            }
        }


        private void cmbcom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the selected port when the combo box selection changes
            serialPort.PortName = cmbcom.SelectedItem.ToString();
            btnsend.Enabled = true; // Enable the Send button when a port is selected
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Refresh the COM port list
            cmbcom.Items.Clear(); // Clear the existing items
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbcom.Items.Add(port);
            }

            // Select the first port if available
            if (cmbcom.Items.Count > 0)
            {
                cmbcom.SelectedIndex = 0;
            }
        }
    }
}
using System;
using System.Windows.Forms;
using System.ServiceModel;
using System.Configuration;

using CommonTypes;
using ServiceInterface;

namespace ClientSideApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            severityComboBox.DataSource = Enum.GetNames(typeof(SeverityLevel));
            eventTypeComboBox.DataSource = Enum.GetNames(typeof(EventType));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                // may be need check for empty message
                service.DispatchMessage(
                    (SeverityLevel)Enum.Parse(typeof(SeverityLevel), severityComboBox.SelectedItem.ToString()),
                    (EventType)Enum.Parse(typeof(EventType), eventTypeComboBox.SelectedItem.ToString()),
                    messageTextBox.Text
                    );

                statusLabel.Text = "Успех";
            }
            catch(Exception exception)
            {
                statusLabel.Text = exception.Message;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                WSHttpBinding binding = new WSHttpBinding();
                statusLabel.Text = "Binding created.";

                EndpointAddress endpoint = new EndpointAddress(ConfigurationManager.AppSettings["Endpoint"]);
                statusLabel.Text = "Endpoint address created.";

                service = new ChannelFactory<IMessageDispatcherService>(binding, endpoint).CreateChannel();
                statusLabel.Text = "Channel created.";
            }
            catch(Exception exception)
            {
                statusLabel.Text = exception.Message;
            }
        }

        private IMessageDispatcherService service = null;
    }
}

using System.Windows.Forms;

namespace ProjectSetupTool
{
	public partial class Popup : Form
	{
		public Popup()
		{
			InitializeComponent();
		}

		public void SetText(string InText)
		{
			ErrorMessageTxtBox.Text = InText;
		}
	}
}

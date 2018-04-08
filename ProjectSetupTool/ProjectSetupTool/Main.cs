/*
 *	Project Setup Tool by Chris Ringenberg
 **/

using System;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;

namespace ProjectSetupTool
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		string FilePath = "E:\\";
		string ProjectName = "error";
		string ProjectNamePrefix = "error";
		string ProjectType = "error";
		string[] SourceList = { "error" };
		string BaseTargetPath = "..\\Project Setup Tool\\SetupFiles\\BaseTarget.txt";
		string BaseUProjectPath = "..\\Project Setup Tool\\SetupFiles\\BaseUProject.txt";
		string BaseServerTargetPath = "..\\Project Setup Tool\\SetupFiles\\BaseServerTarget.txt";
		string BaseBuildFilePath = "..\\Project Setup Tool\\SetupFiles\\BaseBuild.cs.txt";
		bool bUsePublicFolders = false;
		bool bAddServerTargetFile = false;
		bool bUseSlate = false;
		bool bUseSteam = false;

		private bool SetupProject()
		{
			string L_FilePath = "error";
			string TargetFile = ProjectName + ".Target.cs";
			string ServerTargetFile = ProjectName + "Server.Target.cs";
			string UProject = ProjectName + ".uproject";
			string BuildFile = ProjectName + ".build.cs";

			if (FilePath.EndsWith(ProjectName + "\\"))
			{
				L_FilePath = FilePath;
			}
			else if (FilePath.EndsWith(ProjectName))
			{
				L_FilePath = FilePath;
			}
			else if (FilePath.EndsWith("\\"))
			{
				L_FilePath = FilePath + ProjectName;
			}
			else
			{
				L_FilePath = FilePath + '\\' + ProjectName;
			}

			DirectorySecurity AccessRules = new DirectorySecurity();
			AccessRules.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));

			string[] DefaultSubfolders = new string[] {"Content", "Source", "Plugins"};

			string ContentFolder = Path.Combine(L_FilePath, DefaultSubfolders[0]);
			string SourceFolder = Path.Combine(L_FilePath, DefaultSubfolders[1]);
			string PluginsFolder = Path.Combine(L_FilePath, DefaultSubfolders[2]);
			string ProjectSourceCodePath = Path.Combine(SourceFolder, ProjectName);

			Directory.CreateDirectory(ContentFolder, AccessRules);
			Directory.CreateDirectory(SourceFolder, AccessRules);
			Directory.CreateDirectory(ProjectSourceCodePath, AccessRules);

			if (!IsProjectType("Code Project"))
			{
				Directory.CreateDirectory(PluginsFolder, AccessRules);

				L_FilePath = Path.Combine(L_FilePath, UProject);

				if (!(CreateFile(L_FilePath, GetBaseFile(BaseUProjectPath, false))))
				{
					Exit();
				}

				L_FilePath = SourceFolder;
				L_FilePath = Path.Combine(L_FilePath, TargetFile);

				if (!(CreateFile(L_FilePath, GetBaseTargetFile(BaseTargetPath, "Game"))))
				{
					Exit();
				}

				if (bAddServerTargetFile)
				{
					L_FilePath = SourceFolder;
					string ServerPath = Path.Combine(L_FilePath, ServerTargetFile);

					if (!(CreateFile(ServerPath, GetBaseTargetFile(BaseServerTargetPath, "Server"))))
					{
						Exit();
					}
				}
			}

			L_FilePath = SourceFolder + '\\' + ProjectName + '\\';

			if (bUsePublicFolders)
			{
				string[] PublicFolders = { "Public", "Private" };
				string PublicPath = Path.Combine(L_FilePath, PublicFolders[0]);
				string PrivatePath = Path.Combine(L_FilePath, PublicFolders[1]);
				Directory.CreateDirectory(PublicPath, AccessRules);
				Directory.CreateDirectory(PrivatePath, AccessRules);
			}

			if (!IsProjectType("Code Project"))
			{
				string BuildPath = Path.Combine(L_FilePath, BuildFile);
				
				if (!(CreateFile(BuildPath, GetBaseFile(BaseBuildFilePath, true))))
				{
					Exit();
				}
			}

			return true;
		}

		private bool CreateFile(string Path, string Content)
		{
			if (!File.Exists(Path))
			{
				using (FileStream FS = File.Create(Path))
				{
					FS.Close();
					File.WriteAllText(Path, Content);
				}

				return true;
			}

			DisplayPopup(Path + " Already Exists!");

			return false;
		}

		private bool GetUseSteam() { return bUseSteam; }
		private bool GetUseSlate() { return bUseSlate; }

		private bool IsProjectType(string InType)
		{
			if (InType == ProjectType)
			{
				return true;
			}

			return false;
		}

		private string GetBaseTargetFile(string TargetPath, string TargetType)
		{
			string OpenedFile = "error";

			using (StreamReader sr = File.OpenText(TargetPath))
			{
				OpenedFile = sr.ReadToEnd();
			}

			if (OpenedFile.Contains("CHANGEME"))
			{
				OpenedFile = OpenedFile.Replace("CHANGEME", ProjectName + "Target");
				OpenedFile = OpenedFile.Replace("PROJECTNAME", ProjectName);

				OpenedFile = OpenedFile.Replace(".Game;", ('.' + TargetType + ';'));
			}

			return OpenedFile;
		}

		private string GetBaseFile(string Path, bool bBuildFile)
		{
			string OpenedFile = "error";

			using (StreamReader sr = File.OpenText(Path))
			{
				OpenedFile = sr.ReadToEnd();

				if (OpenedFile.Contains("CHANGEME"))
				{
					OpenedFile = OpenedFile.Replace("CHANGEME", ProjectName);
				}

				if (GetUseSteam())
				{
					OpenedFile = OpenedFile.Replace("//USESTEAM", "");
				}

				if (GetUseSlate())
				{
					OpenedFile = OpenedFile.Replace("//USESLATE", "");
				}

				return OpenedFile;
			}
		}

		private void Exit()
		{
			Application.Exit();
		}

		private void RootFolderTxtBox_TextChanged(object sender, EventArgs e)
		{
			FilePath = RootFolderTxtBox.Text;
		}

		private void CreateProjectBtn_Click(object sender, EventArgs e)
		{
			if (ValidateInputs())
			{
				if (SetupProject())
				{
					DisplayPopup(ProjectName + " has successfully been setup!");
					Exit();
					return;
				}

				DisplayPopup("Failed to setup project");
				return;
			}
		}

		private bool ValidateInputs()
		{
			/*
			 *	This checks to make sure inputs fit style rules and common sense.
			 *	If they do not, it displays a popup with the proper error message.
			 *	This does checks to make sure it is not greater than a set amount,
			 *	this is done for safety, even though the text boxes have a max length set.
			 **/

			if (ProjectName.Equals("error") || ProjectNamePrefix.Equals("error") || ProjectType.Equals("error"))
			{
				DisplayPopup("Fill out all dialog boxes and select a project type then try again");
				return false;
			}

			if (ProjectName.Length <= 2)
			{
				DisplayPopup("Project name can be no shorter than " + 3 + " in length");
				return false;
			}
			else if (ProjectName.Length > 25)
			{
				DisplayPopup("Project name has to be less than " + 25 + " in length");
				return false;
			}

			if (ProjectNamePrefix.Length > 4)
			{
				DisplayPopup("Prefix should be less than 4 in length");
				return false;
			}

			return true;
		}

		private void ProjectNameTxtBox_TextChanged(object sender, EventArgs e)
		{
			ProjectName = ProjectNameTxtBox.Text;
		}

		private void ProjectTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ProjectType = ProjectTypeListBox.Text;

			if (IsProjectType("Code Project"))
			{
				ServerTargetFileBtn.Enabled = false;
				UseSlateBtn.Enabled = false;
				UseSteamBtn.Enabled = false;
			}
			else
			{
				ServerTargetFileBtn.Enabled = true;
				UseSlateBtn.Enabled = true;
				UseSteamBtn.Enabled = true;
			}
		}

		private void ProjectNamePrefixTxtBox_TextChanged(object sender, EventArgs e)
		{
			ProjectNamePrefix = ProjectNamePrefixTxtBox.Text;
		}

		private void ExitBtn_Click(object sender, EventArgs e)
		{
			Exit();
		}

		private void DisplayPopup(string PopupMessage)
		{
			Popup PopupForm = new Popup();
			PopupForm.SetText(PopupMessage);
			DialogResult DR = PopupForm.ShowDialog();
			if (DR == DialogResult.Cancel)
			{
				PopupForm.Dispose();
			}
		}

		private void SourceListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			SourceList = new string[SourceListBox.Items.Count];

			for (int Index = 0; Index < SourceListBox.Items.Count; Index++)
			{
				SourceList[Index] = SourceListBox.Items[Index].ToString();
			}
		}

		private void ServerTargetFileBtn_CheckedChanged(object sender, EventArgs e)
		{
			bAddServerTargetFile = ServerTargetFileBtn.Checked;
		}

		private void UseSlateBtn_CheckedChanged(object sender, EventArgs e)
		{
			bUseSlate = UseSlateBtn.Checked;
		}

		private void UseSteamBtn_CheckedChanged(object sender, EventArgs e)
		{
			bUseSteam = UseSteamBtn.Checked;
		}

		private void UsePublicBtn_CheckedChanged(object sender, EventArgs e)
		{
			bUsePublicFolders = UsePublicBtn.Checked;
		}
	}
}

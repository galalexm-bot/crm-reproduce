using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.Documents;

public class DocumentsSettings : GlobalSettingsBase
{
	[DisplayName(typeof(__Resources_DocumentsSettings), "ElmaAgentButtonAction")]
	public int ElmaAgentButtonAction { get; set; }

	[DisplayName(typeof(__Resources_DocumentsSettings), "SaveGridStateForFolder")]
	public bool SaveGridStateForFolder { get; set; }

	[DisplayName(typeof(__Resources_DocumentsSettings), "CheckPermissionForLinks")]
	public bool CheckPermissionForLinks { get; set; }

	[DisplayName(typeof(__Resources_DocumentsSettings), "CanSaveFolderWithSameName")]
	public bool CanSaveFolderWithSameName { get; set; }

	public DocumentsSettings()
	{
		ElmaAgentButtonAction = 2;
		CanSaveFolderWithSameName = true;
	}
}

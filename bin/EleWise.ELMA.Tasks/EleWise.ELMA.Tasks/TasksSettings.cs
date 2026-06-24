using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks;

public class TasksSettings : GlobalSettingsBase
{
	[DisplayName(typeof(__Resources_TasksSettings), "CheckOrganizationItem")]
	public CheckOrganizationItemEnum CheckOrganizationItem { get; set; }

	[DisplayName(typeof(__Resources_TasksSettings), "SetControl")]
	public bool SetControl { get; set; }

	[DisplayName(typeof(__Resources_TasksSettings), "DefaultControlType")]
	public TaskControlType DefaultControlType { get; set; }

	[DisplayName(typeof(__Resources_TasksSettings), "AllowChangeControl")]
	public bool AllowChangeControl { get; set; }

	[DisplayName(typeof(__Resources_TasksSettings), "EnableUserSettings")]
	public bool EnableUserSettings { get; set; }

	[DisplayName(typeof(__Resources_TasksSettings), "InformToExecutor")]
	public bool InformToExecutor { get; set; }

	[DisplayName(typeof(__Resources_TasksSettings), "RedirectToParentTask")]
	public bool RedirectToParentTask { get; set; }

	[DisplayName(typeof(__Resources_TasksSettings), "AllowAttachments")]
	public bool AllowAttachments { get; set; }

	[DisplayName(typeof(__Resources_TasksSettings), "MaxAttachmentSize")]
	public int MaxAttachmentSize { get; set; }

	[DisplayName(typeof(__Resources_TasksSettings), "DefaultDateCorrection")]
	public TaskDateCorrection DefaultDateCorrection { get; set; }

	public TasksSettings()
	{
		SetControl = true;
		DefaultControlType = TaskControlType.Execution;
		AllowChangeControl = true;
		EnableUserSettings = true;
		InformToExecutor = false;
		AllowAttachments = true;
		MaxAttachmentSize = 0;
		DefaultDateCorrection = TaskDateCorrection.None;
	}
}

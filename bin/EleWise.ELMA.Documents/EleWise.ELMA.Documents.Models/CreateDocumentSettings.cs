using System;
using System.Xml.Serialization;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Models;

[Serializable]
[XmlRoot("CreateDocumentSettings")]
public class CreateDocumentSettings : DocumentStorageSettingsBase
{
	internal static class CreateDocumentSettings_SR
	{
		public static string Folder => SR.T("Папка");
	}

	[XmlElement("FolderId")]
	public long FolderId { get; set; }

	[DisplayName(typeof(CreateDocumentSettings_SR), "Folder")]
	public IFolder Folder
	{
		get
		{
			IFolder folder = FolderManager.Instance.LoadOrNull(FolderId);
			return folder ?? Locator.GetServiceNotNull<ISystemFoldersService>().GetMyDocumentFolderForCurrentUser();
		}
		set
		{
			FolderId = value?.Id ?? 0;
		}
	}
}

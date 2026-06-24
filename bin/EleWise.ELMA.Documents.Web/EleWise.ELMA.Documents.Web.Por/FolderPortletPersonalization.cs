using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Mvc;
using System.Xml.Serialization;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Web.Portlets;

[Serializable]
public class FolderPortletPersonalization : PortletPersonalization
{
	[OptionalField]
	private FolderType folderType;

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual long? FolderId { get; set; }

	[XmlIgnore]
	[HiddenInput(DisplayValue = false)]
	public virtual IFolder Folder
	{
		get
		{
			if (FolderType == FolderType.SharedFolder && FolderId.HasValue)
			{
				IFolder folder = null;
				Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
				{
					folder = FolderManager.Instance.LoadOrNull(FolderId.Value);
				});
				return folder;
			}
			return null;
		}
		set
		{
			if (value != null)
			{
				FolderId = value.Id;
			}
			else
			{
				FolderId = null;
			}
		}
	}

	[HiddenInput(DisplayValue = false)]
	[Personalization(PersonalizationScope.Shared)]
	public virtual string GridIdPostfix { get; set; }

	[HiddenInput(DisplayValue = false)]
	[Personalization(PersonalizationScope.Shared)]
	public virtual Guid GridStateProvider { get; set; }

	[Personalization(PersonalizationScope.User)]
	[DefaultValue(true)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool ViewAsWebDocument { get; set; }

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual FolderType FolderType
	{
		get
		{
			return folderType;
		}
		set
		{
			folderType = value;
		}
	}

	public virtual IFolder GetFolderByType()
	{
		switch (FolderType)
		{
		case FolderType.SharedFolder:
			if (FolderId.HasValue)
			{
				return FolderManager.Instance.Load(FolderId.Value);
			}
			break;
		case FolderType.MyDocuments:
			return Locator.GetServiceNotNull<ISystemFoldersService>().GetMyDocumentFolderForCurrentUser();
		case FolderType.Favorites:
			return Locator.GetServiceNotNull<ISystemFoldersService>().GetFavoritesFolderForCurrentUser();
		}
		return null;
	}
}

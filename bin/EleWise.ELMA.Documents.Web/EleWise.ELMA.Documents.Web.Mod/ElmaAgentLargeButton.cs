using System;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Models;

public class ElmaAgentLargeButton
{
	private Lazy<DocumentsSettings> _fullPerm;

	public IDocumentVersion DocumentVersion { get; set; }

	public DocumentsSettings DocumentsSettings
	{
		get
		{
			DocumentsSettingsModule module = Locator.GetService<DocumentsSettingsModule>();
			if (module == null)
			{
				return null;
			}
			if (_fullPerm == null)
			{
				_fullPerm = new Lazy<DocumentsSettings>(() => module.Settings);
			}
			return _fullPerm.Value;
		}
	}

	public Func<IDocumentVersion, bool> CanEditFunction { get; set; }

	public bool CanEdit
	{
		get
		{
			try
			{
				if (CanEditFunction != null)
				{
					return CanEditFunction(DocumentVersion);
				}
				IAuthenticationService serviceNotNull = Locator.GetServiceNotNull<IAuthenticationService>();
				ISecurityService serviceNotNull2 = Locator.GetServiceNotNull<ISecurityService>();
				EleWise.ELMA.Security.Models.IUser user = (EleWise.ELMA.Security.Models.IUser)serviceNotNull.GetCurrentUser();
				if (!serviceNotNull2.HasPermission(user, PermissionProvider.DocumentFullAccessPermission, DocumentVersion.Document) && (!serviceNotNull2.HasPermission(user, PermissionProvider.DocumentEditPermission, DocumentVersion.Document) || DocumentVersion.CreationAuthor != user))
				{
					return false;
				}
			}
			catch
			{
				return false;
			}
			return true;
		}
	}

	public string LeftButtonImage
	{
		get
		{
			if (DocumentVersion == null)
			{
				return "";
			}
			if (!DocumentVersion.CanEdit())
			{
				if (!Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentEditPermission, DocumentVersion.Document))
				{
					return "#info-circle.svg";
				}
				return "#plus-square.svg";
			}
			ElmaAgentDMSLinkGenerator.DMSVersionSetting dMSVersionSetting = ElmaAgentDMSLinkGenerator.DMSVersionSetting.Edit;
			try
			{
				if (DocumentsSettings != null)
				{
					dMSVersionSetting = (ElmaAgentDMSLinkGenerator.DMSVersionSetting)DocumentsSettings.ElmaAgentButtonAction;
				}
				switch (dMSVersionSetting)
				{
				case ElmaAgentDMSLinkGenerator.DMSVersionSetting.Edit:
					return "#edit.svg";
				case ElmaAgentDMSLinkGenerator.DMSVersionSetting.New:
					return "#add.svg";
				case ElmaAgentDMSLinkGenerator.DMSVersionSetting.EditAndBlock:
					return "#lock.svg";
				case ElmaAgentDMSLinkGenerator.DMSVersionSetting.NewAndBlock:
					return "#document_lock.svg";
				case (ElmaAgentDMSLinkGenerator.DMSVersionSetting)3:
				case (ElmaAgentDMSLinkGenerator.DMSVersionSetting)5:
				case (ElmaAgentDMSLinkGenerator.DMSVersionSetting)7:
					break;
				}
			}
			catch
			{
				return "";
			}
			return "";
		}
	}

	public string LeftButtonText
	{
		get
		{
			if (DocumentVersion == null)
			{
				return "";
			}
			if (!DocumentVersion.CanEdit())
			{
				if (!Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentEditPermission, DocumentVersion.Document))
				{
					return SR.T("Просмотреть");
				}
				return ElmaAgentDMSLinkGenerator.GetActionName(ElmaAgentDMSLinkGenerator.DMSVersionSetting.New);
			}
			ElmaAgentDMSLinkGenerator.DMSVersionSetting dMSVersionSetting = ElmaAgentDMSLinkGenerator.DMSVersionSetting.Edit;
			try
			{
				if (DocumentsSettings != null)
				{
					dMSVersionSetting = (ElmaAgentDMSLinkGenerator.DMSVersionSetting)DocumentsSettings.ElmaAgentButtonAction;
				}
				switch (dMSVersionSetting)
				{
				case ElmaAgentDMSLinkGenerator.DMSVersionSetting.Edit:
					return ElmaAgentDMSLinkGenerator.GetActionName(ElmaAgentDMSLinkGenerator.DMSVersionSetting.Edit);
				case ElmaAgentDMSLinkGenerator.DMSVersionSetting.New:
					return ElmaAgentDMSLinkGenerator.GetActionName(ElmaAgentDMSLinkGenerator.DMSVersionSetting.New);
				case ElmaAgentDMSLinkGenerator.DMSVersionSetting.EditAndBlock:
					return ElmaAgentDMSLinkGenerator.GetActionName(ElmaAgentDMSLinkGenerator.DMSVersionSetting.EditAndBlock);
				case ElmaAgentDMSLinkGenerator.DMSVersionSetting.NewAndBlock:
					return ElmaAgentDMSLinkGenerator.GetActionName(ElmaAgentDMSLinkGenerator.DMSVersionSetting.NewAndBlock);
				case (ElmaAgentDMSLinkGenerator.DMSVersionSetting)3:
				case (ElmaAgentDMSLinkGenerator.DMSVersionSetting)5:
				case (ElmaAgentDMSLinkGenerator.DMSVersionSetting)7:
					break;
				}
			}
			catch
			{
				return "";
			}
			return "";
		}
	}

	public string LeftButtonCommand
	{
		get
		{
			if (DocumentVersion == null)
			{
				return "";
			}
			if (!DocumentVersion.CanEdit())
			{
				if (!Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentEditPermission, DocumentVersion.Document))
				{
					return ElmaAgentDMSLinkGenerator.GetVersionLink(DocumentVersion.Id.ToString(), ElmaAgentDMSLinkGenerator.DMSVerion.ReadOnly);
				}
				return ElmaAgentDMSLinkGenerator.GetVersionLink(DocumentVersion.Id.ToString(), ElmaAgentDMSLinkGenerator.DMSVerion.New);
			}
			ElmaAgentDMSLinkGenerator.DMSVersionSetting dMSVersionSetting = ElmaAgentDMSLinkGenerator.DMSVersionSetting.Edit;
			try
			{
				if (DocumentsSettings != null)
				{
					dMSVersionSetting = (ElmaAgentDMSLinkGenerator.DMSVersionSetting)DocumentsSettings.ElmaAgentButtonAction;
				}
				switch (dMSVersionSetting)
				{
				case ElmaAgentDMSLinkGenerator.DMSVersionSetting.Edit:
					return ElmaAgentDMSLinkGenerator.GetVersionLink(DocumentVersion.Id.ToString(), ElmaAgentDMSLinkGenerator.DMSVerion.Edit);
				case ElmaAgentDMSLinkGenerator.DMSVersionSetting.New:
					return ElmaAgentDMSLinkGenerator.GetVersionLink(DocumentVersion.Id.ToString(), ElmaAgentDMSLinkGenerator.DMSVerion.New);
				case ElmaAgentDMSLinkGenerator.DMSVersionSetting.EditAndBlock:
					return ElmaAgentDMSLinkGenerator.GetVersionLink(DocumentVersion.Id.ToString(), ElmaAgentDMSLinkGenerator.DMSVerion.BlockEdit);
				case ElmaAgentDMSLinkGenerator.DMSVersionSetting.NewAndBlock:
					return ElmaAgentDMSLinkGenerator.GetVersionLink(DocumentVersion.Id.ToString(), ElmaAgentDMSLinkGenerator.DMSVerion.BlockNew);
				case (ElmaAgentDMSLinkGenerator.DMSVersionSetting)3:
				case (ElmaAgentDMSLinkGenerator.DMSVersionSetting)5:
				case (ElmaAgentDMSLinkGenerator.DMSVersionSetting)7:
					break;
				}
			}
			catch
			{
				return "";
			}
			return "";
		}
	}

	public ElmaAgentLargeButton(IDocumentVersion documentVersion)
	{
		DocumentVersion = documentVersion;
	}
}

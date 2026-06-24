using System;
using System.Collections.Generic;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentVersionGrid : BaseGridViewModel<IDocumentVersion, IDocumentVersionFilter>
{
	private IDocument _document;

	public long DocumentId { get; set; }

	public string SaveCallback { get; set; }

	public bool AllowEdit { get; set; }

	public bool FullAccess { get; set; }

	public bool SelectMode { get; set; }

	public string SelectName { get; set; }

	public string Target { get; set; }

	public bool RealTimeUpdateTarget { get; set; }

	public long? SelectedVersion { get; set; }

	public bool? SelectAssigned { get; set; }

	public List<string> GetNotVisibleItems(IDocumentVersion version)
	{
		List<string> list = new List<string>();
		if (!CheckDocumentVersionAction(DocumentActionProvider.DocumentVersionChangeStatusActionUID))
		{
			list.Add("btnChangeStatus");
		}
		if (!CheckDocumentVersionAction(DocumentActionProvider.DocumentVersionDownloadActionUID))
		{
			list.Add("btnUnload");
		}
		if (!CheckDocumentVersionAction(DocumentActionProvider.DocumentVersionELMAAgentActionUID))
		{
			list.Add("btnElmaAgent");
		}
		if (!CheckDocumentVersionAction(DocumentActionProvider.DocumentVersionEditActionUID))
		{
			list.Add("btnChangeVersion");
		}
		if (!CheckDocumentVersionAction(DocumentActionProvider.DocumentVersionLockActionUID))
		{
			list.Add("btnLock");
		}
		if (!CheckDocumentVersionAction(DocumentActionProvider.DocumentVersionUnlockActionUID))
		{
			list.Add("btnUnlock");
		}
		if (!CheckDocumentVersionAction(DocumentActionProvider.DocumentVersionSignActionUID))
		{
			list.Add("btnAssign");
		}
		if (!FullAccess && (!AllowEdit || version.CreationAuthor == null || !version.CreationAuthor.Equals(Locator.GetService<IAuthenticationService>().GetCurrentUser<IUser>())))
		{
			list.AddRange(new List<string> { "btnChangeVersion", "btnLock", "btnUnlock", "btnUnload", "btnEAgentBlockEditVer", "btnEAgentEditVer", "btnEAgentBlockNewVer" });
		}
		if (version != null)
		{
			list.AddRange(version.IsBlocked ? new List<string> { "btnLock", "btnAssign", "btnUnload", "btnChangeVersion", "btnChangeStatus", "btnEAgentBlockEditVer", "btnEAgentEditVer", "btnEAgentBlockNewVer" } : new List<string> { "btnUnlock" });
			if ((DocumentVersionManager.Instance.IsCurrentUserSigned(version) && !DocumentVersionManager.Instance.CanCurrentUserResign(version)) || !DocumentVersionManager.Instance.HasPermissionToSign(version))
			{
				list.Add("btnAssign");
			}
			list.AddRange(DocumentVersionManager.Instance.IsSigned(version) ? new List<string> { "btnLock", "btnUnload", "btnChangeVersion", "btnChangeStatus", "btnUnlock", "btnEAgentBlockEditVer", "btnEAgentEditVer", "btnEAgentBlockNewVer" } : ((version.Status == DocumentVersionStatus.Current) ? new List<string> { "btnCurrent" } : ((version.Status == DocumentVersionStatus.Draft) ? new List<string> { "btnDraft" } : ((version.Status == DocumentVersionStatus.Obsolete) ? new List<string> { "btnObsolete" } : new List<string>()))));
			if (WebDocumentManager.Instance.IsWebDocument(version.Document.TypeUid))
			{
				list.AddRange((version.Status == DocumentVersionStatus.Current) ? new List<string> { "btnCurrent" } : new List<string>());
			}
			if (version.Encrypt)
			{
				list.Add("btnElmaAgent");
			}
		}
		return list;
	}

	public string GetRowClass(IDocumentVersion m)
	{
		bool flag = !SelectAssigned.HasValue || SelectAssigned.Value;
		string text = GetVersionCssClass(m);
		if (SelectMode && (flag || (!m.IsBlocked && !DocumentVersionManager.Instance.IsSigned(m))))
		{
			text += " selectable";
		}
		if (SelectMode && SelectedVersion.HasValue && SelectedVersion.Value == m.Id && !m.IsBlocked)
		{
			text = $"{text} selected";
		}
		return text;
	}

	public static string GetVersionCssClass(IDocumentVersion m)
	{
		if (!m.IsBlocked)
		{
			if (m.Status != DocumentVersionStatus.Current)
			{
				if (m.Status != DocumentVersionStatus.Obsolete)
				{
					return "";
				}
				return "gray_text";
			}
			return "green_text";
		}
		return "red_text";
	}

	public bool CheckDocumentVersionAction(Guid uid)
	{
		IDocument document = GetDocument();
		if (document == null)
		{
			return true;
		}
		return DocumentActionsProfileManager.Instance.ActionIsVisible(uid, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, document.TypeUid);
	}

	public IDocument GetDocument()
	{
		if (_document == null && DocumentId > 0)
		{
			_document = DocumentManager.Instance.Load(DocumentId);
		}
		return _document;
	}

	public DocumentVersionGrid()
	{
		SelectName = "DocumentVersion";
	}
}

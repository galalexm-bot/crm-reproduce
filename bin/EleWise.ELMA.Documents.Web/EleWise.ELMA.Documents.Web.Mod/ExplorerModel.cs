using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Documents.Web.Models;

public class ExplorerModel
{
	private Lazy<IFolder> _currentFolder;

	private Lazy<IFolder> _sharedFolder;

	private Lazy<IFolder> _myDocumentsFolder;

	private Lazy<List<IFolder>> _rootFolders;

	public GridData<IDmsObject, IDmsObjectFilter> Data { get; set; }

	public string PopupId { get; set; }

	public bool MultiSelect { get; set; }

	public string FilterProviderUid { get; set; }

	public string FilterProviderData { get; set; }

	public long FolderId { get; set; }

	public IDmsObjectFilter Filter { get; set; }

	public string InputId { get; set; }

	public string InputPrefix { get; set; }

	public string InputPostFix { get; set; }

	public string PrefixUid { get; set; }

	public string FunctionId
	{
		get
		{
			if (!PrefixUid.IsNullOrEmpty())
			{
				return $"Explorer_{PrefixUid}";
			}
			if (!InputId.IsNullOrEmpty())
			{
				return InputId.Replace("_", "x");
			}
			return string.Empty;
		}
	}

	public IEntity<long> Value { get; set; }

	public IFolder CurrentFolder
	{
		get
		{
			if (FolderId > 0 && (_currentFolder == null || !_currentFolder.IsValueCreated))
			{
				_currentFolder = new Lazy<IFolder>(() => FolderManager.Instance.Load(FolderId));
			}
			if (_currentFolder == null)
			{
				return MyDocumentsFolder;
			}
			return _currentFolder.Value;
		}
	}

	public IFolder SharedFolder
	{
		get
		{
			if (_sharedFolder == null || !_sharedFolder.IsValueCreated)
			{
				_sharedFolder = new Lazy<IFolder>(() => FolderManager.Instance.Load(DocumentConstants.SharedFolderUid));
			}
			return _sharedFolder.Value;
		}
	}

	public IFolder MyDocumentsFolder
	{
		get
		{
			if (_myDocumentsFolder == null || !_myDocumentsFolder.IsValueCreated)
			{
				_myDocumentsFolder = new Lazy<IFolder>(() => Locator.GetServiceNotNull<ISystemFoldersService>().GetMyDocumentFolderForCurrentUser());
			}
			return _myDocumentsFolder.Value;
		}
	}

	public List<IFolder> RootFolders
	{
		get
		{
			if (_rootFolders == null)
			{
				_rootFolders = new Lazy<List<IFolder>>(() => FolderManager.Instance.GetRoots());
			}
			return _rootFolders.Value;
		}
	}

	public MvcHtmlString GenerateRowClick(HtmlHelper html, long id)
	{
		return GenerateRowClick(html, id, null);
	}

	public MvcHtmlString GenerateRowClick(HtmlHelper html, long id, string postfix)
	{
		if (MultiSelect)
		{
			return MvcHtmlString.Create(string.Format("SelectItem{2}{0}(event, {1})", FunctionId, id, postfix));
		}
		return MvcHtmlString.Create($"elma.SelectorControl.setValue('{PopupId}', {id});{html.ClosePopup(PopupId)}");
	}
}

using System;
using EleWise.ELMA.BPM.Web.Common.Services;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Models;

public class FolderModel : FolderBaseModel<IFolder>
{
	private bool canRemoved;

	private Lazy<bool> anyFiles;

	private Lazy<DragAndDropSettings> _dragAndDropSettings;

	public string PopupId { get; set; }

	public bool ModeWebDocument { get; set; }

	public string DropDownContainer { get; set; }

	public IDocumentVersion Version { get; set; }

	public bool EnableChecked { get; set; }

	public bool NeedBackFolder { get; set; }

	public bool IsArchive { get; set; }

	public bool CanRemoved
	{
		get
		{
			return canRemoved;
		}
		set
		{
			canRemoved = value;
		}
	}

	public bool AnyFiles => anyFiles.Value;

	public bool IsRootFolder
	{
		get
		{
			if (base.Entity != null && base.Entity.Folder == null)
			{
				return true;
			}
			return false;
		}
	}

	public DragAndDropSettings DragAndDropSettings
	{
		get
		{
			if (_dragAndDropSettings == null)
			{
				_dragAndDropSettings = new Lazy<DragAndDropSettings>(() => Locator.GetServiceNotNull<DragAndDropSettingsBlock>().Settings);
			}
			return _dragAndDropSettings.Value;
		}
	}

	public FolderModel()
	{
		DropDownContainer = "body";
		EnableChecked = true;
		NeedBackFolder = true;
		anyFiles = new Lazy<bool>(() => Locator.GetServiceNotNull<ICheckAnyAttachmentService>().CheckAnyFile(base.Entity.TypeUid, base.Entity));
	}
}

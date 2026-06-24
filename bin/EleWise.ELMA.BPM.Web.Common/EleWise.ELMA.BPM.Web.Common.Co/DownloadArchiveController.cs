using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public class DownloadArchiveController : BPMController
{
	public IObjectAttachmentsArchiveServiceCheckFileExt ObjectAttachmentsArchiveService { get; set; }

	public IEnumerable<IObjectAttachmentExtension> ObjectAttachmentExtensions { get; set; }

	public IEnumerable<IObjectAttachmentWithPropertyExtension> PropertyAttachmentExtensions { get; set; }

	public ActionResult DownloadSelectedPropertyFilesPopup(Guid typeUid, long id, string nameProperty)
	{
		IEnumerable<AttachmentFileModel> attachmentFileModelsForGrid = GetAttachmentFileModelsForGrid(typeUid, id, nameProperty, withNameProperty: true);
		AttachmentPopupModel attachmentPopupModel = new AttachmentPopupModel
		{
			PopupId = "DownloadSelectedPropertyFilesPopup",
			TypeUid = typeUid,
			Id = id,
			NameProperty = nameProperty,
			WithNameProperty = true,
			GridData = GetGridDataForDownloadSelectedFilesGrid(attachmentFileModelsForGrid, null, null)
		};
		return (ActionResult)(object)((Controller)this).PartialView("DownloadArchive/DownloadSelectedFilesPopupPartial", (object)attachmentPopupModel);
	}

	[HttpPost]
	public JsonResult CheckFilesInProperty(Guid typeUid, string stringId, string nameProperty)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		if (typeUid == Guid.Empty || stringId.IsNullOrEmpty() || nameProperty.IsNullOrEmpty())
		{
			JsonResult val = new JsonResult();
			val.set_Data((object)new
			{
				anyTwoAndMoreFiles = false
			});
			return val;
		}
		long.TryParse(stringId, out var result);
		if (result == 0L)
		{
			JsonResult val2 = new JsonResult();
			val2.set_Data((object)new
			{
				anyTwoAndMoreFiles = false
			});
			return val2;
		}
		IEntity entity = ModelHelper.GetEntity(typeUid, result);
		bool anyTwoAndMoreFiles = PropertyAttachmentExtensions.Where((IObjectAttachmentWithPropertyExtension p) => p.EntityType(typeUid)).Any((IObjectAttachmentWithPropertyExtension x) => x.GetAttachments(entity, nameProperty).Count() > 1);
		JsonResult val3 = new JsonResult();
		val3.set_Data((object)new { anyTwoAndMoreFiles });
		return val3;
	}

	public ActionResult DownloadSelectedFilesPopup(Guid typeUid, long id, string popupId = null, string entityName = null)
	{
		IEnumerable<AttachmentFileModel> attachmentFileModelsForGrid = GetAttachmentFileModelsForGrid(typeUid, id, null, withNameProperty: false);
		AttachmentPopupModel attachmentPopupModel = new AttachmentPopupModel
		{
			PopupId = popupId,
			EntityName = (entityName.IsNullOrEmpty() ? "" : entityName),
			TypeUid = typeUid,
			Id = id,
			GridData = GetGridDataForDownloadSelectedFilesGrid(attachmentFileModelsForGrid, null, null)
		};
		return (ActionResult)(object)((Controller)this).PartialView("DownloadArchive/DownloadSelectedFilesPopupPartial", (object)attachmentPopupModel);
	}

	[CustomGridAction]
	public ActionResult DownloadSelectedFilesGrid(GridCommand command, string gridId, Guid typeUid, long id, string nameProperty, string searchString, bool withNameProperty = false)
	{
		GridData<AttachmentFileModel> gridDataForDownloadSelectedFilesGrid = GetGridDataForDownloadSelectedFilesGrid(GetAttachmentFileModelsForGrid(typeUid, id, nameProperty, withNameProperty), command, searchString);
		((ControllerBase)this).get_ViewData().set_Item("GridId", (object)gridId);
		return (ActionResult)(object)((Controller)this).PartialView("DownloadArchive/DownloadSelectedFilesGrid", (object)gridDataForDownloadSelectedFilesGrid);
	}

	public static GridData<AttachmentFileModel> GetGridDataForDownloadSelectedFilesGrid(IEnumerable<AttachmentFileModel> attachments, GridCommand command, string searchString)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		object obj = command;
		if (obj == null)
		{
			GridCommand val = new GridCommand();
			obj = (object)val;
			val.set_Page(1);
			val.set_PageSize(15);
		}
		command = (GridCommand)obj;
		if (!searchString.IsNullOrWhiteSpace())
		{
			searchString = searchString.ToLower();
			attachments = attachments.Where((AttachmentFileModel a) => a.Name.ToLower().Contains(searchString));
		}
		AttachmentFileModel[] array = attachments.Distinct().ToArray();
		AttachmentFileModel[] dataSource = array.OrderBy((AttachmentFileModel m) => m.Name).Skip(command.get_Page() * command.get_PageSize() - command.get_PageSize()).Take(command.get_PageSize())
			.ToArray();
		GridData<AttachmentFileModel> gridData = new GridData<AttachmentFileModel>();
		gridData.Command = command;
		gridData.SetData(array.Length, dataSource);
		return gridData;
	}

	[HttpPost]
	public ActionResult CreateArchiveFile(string fileUids, string entityName = null)
	{
		if (fileUids.IsNullOrWhiteSpace())
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				result = false
			}, "text/plain", (JsonRequestBehavior)0);
		}
		string[] uidArray = fileUids.Trim().Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
		AttachmentArchiveModel attachmentArchiveModel = ObjectAttachmentsArchiveService.CreateArchiveCacheFileAndCheckSizeFile(uidArray, entityName.IsNullOrEmpty() ? "" : entityName);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			result = attachmentArchiveModel.CheckSizeFile,
			fileGuid = attachmentArchiveModel.GuidArchive
		}, "text/plain", (JsonRequestBehavior)0);
	}

	[WithoutSpa]
	[HttpGet]
	public ActionResult GetArchive(Guid archiveGuid)
	{
		BinaryFile binaryFile = base.CacheFilesService.GetBinaryFile(archiveGuid);
		return (ActionResult)(object)File(binaryFile);
	}

	private IEnumerable<AttachmentFileModel> GetAttachmentFileModelsForGrid(Guid typeUid, long id, string nameProperty, bool withNameProperty)
	{
		IEntity entity = ModelHelper.GetEntity(typeUid, id);
		IEnumerable<AttachmentFileModel> enumerable = null;
		if (withNameProperty)
		{
			return PropertyAttachmentExtensions.Where((IObjectAttachmentWithPropertyExtension p) => p.EntityType(typeUid)).SelectMany((IObjectAttachmentWithPropertyExtension x) => x.GetAttachments(entity, nameProperty)).Distinct();
		}
		return ObjectAttachmentExtensions.Where((IObjectAttachmentExtension p) => p.EntityType(typeUid)).SelectMany((IObjectAttachmentExtension e) => e.GetAttachments(entity));
	}
}

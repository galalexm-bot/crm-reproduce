using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class CommentWithAttachments : FormViewModel
{
	private object _object;

	private string _objectTypeName;

	public long ObjectId { get; set; }

	public Guid AddCommentActionUid { get; set; }

	public ICommentActionModel ActionModel { get; set; }

	public string PopupId { get; set; }

	public bool ShowAttachment { get; set; }

	public bool UseJson { get; set; }

	public Guid ObjectTypeUid { get; set; }

	public string ActionName { get; set; }

	public List<IComment> LastComments { get; set; }

	public bool ShowLastComments { get; set; }

	public bool DenyEmptyComments { get; set; }

	public bool UseFastCommentForm { get; set; }

	public string EmptyCommentAlertHeader { get; set; }

	public string EmptyCommentAlertMessage { get; set; }

	public string AjaxSuccessMessage { get; set; }

	public string AjaxSuccessScript { get; set; }

	public string HtmlPrefix { get; set; }

	public object Object
	{
		get
		{
			if (_object == null && ObjectTypeUid != Guid.Empty)
			{
				Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(ObjectTypeUid);
				IEntityManager entityManager = (IEntityManager)Locator.GetServiceNotNull(typeof(IEntityManager<>).MakeGenericType(typeByUid));
				_object = entityManager.Load(ObjectId);
			}
			return _object;
		}
	}

	public string ObjectTypeName
	{
		get
		{
			if (string.IsNullOrEmpty(_objectTypeName) && ObjectTypeUid != Guid.Empty)
			{
				ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(ObjectTypeUid));
				_objectTypeName = classMetadata.DisplayName;
			}
			return _objectTypeName;
		}
	}

	public CommentWithAttachments()
	{
		ShowAttachment = true;
		base.PostAction = "AddComment";
		base.PostController = "Comment";
		base.PostArea = "EleWise.ELMA.BPM.Web.Common";
		LastComments = new List<IComment>();
		ActionModel = InterfaceActivator.Create<ICommentActionModel>();
		DenyEmptyComments = false;
		EmptyCommentAlertHeader = SR.T("Предупреждение");
		EmptyCommentAlertMessage = SR.T("Введите текст для отправки комментария");
	}
}

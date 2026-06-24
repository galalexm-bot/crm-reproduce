using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 20)]
internal class CommentBinaryFileAttachmentConvertor : ICommentAttachmentConvertor
{
	private IAuthenticationService authenticationService { get; set; }

	private ICacheFilesService cacheFilesService { get; set; }

	public Guid AttachmentTypeUid => InterfaceActivator.UID<IAttachment>();

	public Guid ObjectAttachmentTypeUid => new Guid("692f9f96-dd18-4477-a632-e145c53291e5");

	public CommentBinaryFileAttachmentConvertor(IAuthenticationService authenticationService, ICacheFilesService cacheFilesService)
	{
		this.authenticationService = authenticationService;
		this.cacheFilesService = cacheFilesService;
	}

	public void AddAttachmentToActionModel(ICommentActionModel actionModel, IEntity entity)
	{
		if (entity is IAttachment item && actionModel != null)
		{
			if (actionModel.Attachments == null)
			{
				actionModel.Attachments = new List<IAttachment>();
			}
			actionModel.Attachments.Add(item);
		}
	}

	public void AddAttachmentToActionModel(ICommentActionModel actionModel, string id, Guid typeUid)
	{
		AddAttachmentToActionModel(actionModel, ConvertToAttachment(id, typeUid));
	}

	public IEntity ConvertToAttachment(string id, Guid typeUid)
	{
		IAttachment attachment = null;
		long result2;
		if (Supported(typeUid) && typeUid != AttachmentTypeUid)
		{
			Guid result;
			BinaryFile binaryFile = (Guid.TryParse(id, out result) ? cacheFilesService.GetBinaryFile(result) : DataAccessManager.FileManager.LoadFile(id));
			if (binaryFile != null)
			{
				DataAccessManager.FileManager.SaveFile(binaryFile);
				attachment = InterfaceActivator.Create<IAttachment>();
				attachment.File = binaryFile;
				attachment.CreationAuthor = authenticationService.GetCurrentUser<IUser>();
				attachment.CreationDate = DateTime.Now;
			}
		}
		else if (long.TryParse(id, out result2))
		{
			attachment = AttachmentManager.Instance.LoadOrNull(result2);
		}
		return attachment;
	}

	public bool Supported(Guid typeUid)
	{
		if (!(typeUid == ObjectAttachmentTypeUid))
		{
			return typeUid == AttachmentTypeUid;
		}
		return true;
	}
}

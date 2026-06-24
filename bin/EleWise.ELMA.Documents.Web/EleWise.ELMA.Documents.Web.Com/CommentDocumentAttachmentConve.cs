using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 20)]
internal class CommentDocumentAttachmentConvertor : ICommentAttachmentConvertor
{
	private IMetadataRuntimeService metadataRuntimeService { get; set; }

	private IAuthenticationService authenticationService { get; set; }

	private DocumentManager documentManager { get; set; }

	public Guid ObjectAttachmentTypeUid => InterfaceActivator.UID<IDocument>();

	public Guid AttachmentTypeUid => InterfaceActivator.UID<IDocumentAttachment>();

	public CommentDocumentAttachmentConvertor(IMetadataRuntimeService metadataRuntimeService, IAuthenticationService authenticationService, DocumentManager documentManager)
	{
		this.metadataRuntimeService = metadataRuntimeService;
		this.authenticationService = authenticationService;
		this.documentManager = documentManager;
	}

	public bool Supported(Guid typeUid)
	{
		Type typeByUidOrNull = metadataRuntimeService.GetTypeByUidOrNull(typeUid);
		Type typeByUidOrNull2 = metadataRuntimeService.GetTypeByUidOrNull(ObjectAttachmentTypeUid);
		if (typeByUidOrNull != null)
		{
			if (!(typeUid == ObjectAttachmentTypeUid) && !(typeUid == AttachmentTypeUid))
			{
				if (typeByUidOrNull2 != null)
				{
					return typeByUidOrNull.IsSubclassOf(typeByUidOrNull2);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public IEntity ConvertToAttachment(string id, Guid typeUid)
	{
		IDocumentAttachment documentAttachment = null;
		if (long.TryParse(id, out var result))
		{
			if (Supported(typeUid) && typeUid != AttachmentTypeUid)
			{
				IDocument document = documentManager.LoadOrNull(result);
				if (document != null)
				{
					documentAttachment = InterfaceActivator.Create<IDocumentAttachment>();
					documentAttachment.Document = document;
					documentAttachment.CreationAuthor = authenticationService.GetCurrentUser<IUser>();
					documentAttachment.CreationDate = DateTime.Now;
				}
			}
			else
			{
				documentAttachment = DocumentAttachmentManager.Instance.LoadOrNull(result);
			}
		}
		return documentAttachment;
	}

	public void AddAttachmentToActionModel(ICommentActionModel actionModel, string id, Guid typeUid)
	{
		AddAttachmentToActionModel(actionModel, ConvertToAttachment(id, typeUid));
	}

	public void AddAttachmentToActionModel(ICommentActionModel actionModel, IEntity entity)
	{
		IDocumentAttachment documentAttachment = entity as IDocumentAttachment;
		ICommentWithDocumentsActionModel commentWithDocumentsActionModel = actionModel as ICommentWithDocumentsActionModel;
		if (documentAttachment != null && commentWithDocumentsActionModel != null)
		{
			if (commentWithDocumentsActionModel.DocumentAttachments == null)
			{
				commentWithDocumentsActionModel.DocumentAttachments = new List<IDocumentAttachment>();
			}
			commentWithDocumentsActionModel.DocumentAttachments.Add(documentAttachment);
		}
	}
}

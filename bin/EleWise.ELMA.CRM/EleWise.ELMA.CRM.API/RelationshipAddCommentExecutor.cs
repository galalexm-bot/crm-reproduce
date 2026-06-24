using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.CRM.API;

public class RelationshipAddCommentExecutor : PublicServiceMethodExecutor
{
	public const string MethodName = "AddCommentRelationship";

	public static string MethodDescription => SR.T("Добавить комментарий к событию");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("EventId").Descriptor(SR.T("Идентификатор события (Int64)"));
	}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Comment").Descriptor(delegate(TypeSerializationDescriptorBuilder cb)
		{
			cb.Item(delegate(TypeSerializationItemDescriptorBuilder ci)
			{
				ci.Name("Text").Descriptor(SR.T("Текст комментария (String)"));
			});
			cb.Item(delegate(TypeSerializationItemDescriptorBuilder ci)
			{
				ci.Name("Attachments").Descriptor(delegate(TypeSerializationDescriptorBuilder cia)
				{
					cia.IsArray().Item(delegate(TypeSerializationItemDescriptorBuilder ciai)
					{
						ciai.Name("Uid").Descriptor(SR.T("Идентификатор файла BinaryFile (Guid)"));
					});
				});
			});
		});
	}).Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
	}).Descriptor;

	protected static IUnitOfWorkManager UnitOfWorkManager => Locator.GetServiceNotNull<IUnitOfWorkManager>();

	public RelationshipAddCommentExecutor(WebData parameters)
		: base(parameters)
	{
	}

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	protected virtual WebData ExecuteInternal()
	{
		if (Parameters == null || Parameters.Items == null)
		{
			return GetError();
		}
		WebDataItem webDataItem = Parameters.FindItem("EventId");
		if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
		{
			return GetError();
		}
		WebDataItem webDataItem2 = Parameters.FindItem("Comment");
		WebDataItem attachItem = null;
		if (webDataItem2 != null && webDataItem2.Data != null)
		{
			attachItem = webDataItem2.Data.FindItem("Attachments");
		}
		if (!long.TryParse(webDataItem.Value, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора события, должен быть Int64"), 400);
		}
		IRelationship calendarEvent = RelationshipManager.Instance.Load(result).CastAsRealType();
		IComment comment = GetComment(webDataItem2);
		IList<IAttachment> attachments = GetAttachments(attachItem);
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		if (comment != null)
		{
			commentActionModel.Comment = comment;
		}
		if (attachments != null)
		{
			commentActionModel.Attachments = attachments;
		}
		BindAdditionalData(Parameters, commentActionModel, calendarEvent);
		DoTaskAction(commentActionModel, calendarEvent);
		return GetResult();
	}

	protected virtual void BindAdditionalData(WebData parameters, ICommentActionModel actionModel, IRelationship calendarEvent)
	{
		WebDataItem webDataItem = parameters.FindItem("Comment");
		if (webDataItem != null && webDataItem.Data != null)
		{
			webDataItem.Data.SaveToEntity(actionModel);
		}
	}

	protected virtual WebData GetResult()
	{
		return WebData.CreateFromObject(new
		{
			Result = true
		});
	}

	protected virtual WebData GetError()
	{
		return WebData.CreateFromObject(new
		{
			Result = false
		});
	}

	public virtual void DoTaskAction(ICommentActionModel actionModel, IRelationship calendarEvent)
	{
		DoAddCommentAction(actionModel, calendarEvent, RelationshipActions.AddCommentGuid);
	}

	protected static void DoAddCommentAction(ICommentActionModel actionModel, IRelationship calendarEvent, Guid actionGuid)
	{
		IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		try
		{
			ICommentActionHandler serviceNotNull2 = Locator.GetServiceNotNull<ICommentActionHandler>();
			serviceNotNull2.Process(calendarEvent, actionModel);
			RelationshipManager.Instance.Save(calendarEvent);
			EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, calendarEvent, actionGuid);
			if (entityActionEventArgs != null)
			{
				serviceNotNull2.ProcessEventArgs(entityActionEventArgs, actionModel);
				serviceNotNull.ActionExecuted(entityActionEventArgs);
			}
		}
		catch (Exception)
		{
			unitOfWork.Rollback();
			throw;
		}
		unitOfWork.Commit();
	}

	protected virtual IList<IAttachment> GetAttachments(WebDataItem attachItem)
	{
		List<IAttachment> list = new List<IAttachment>();
		if (attachItem == null || attachItem.DataArray == null)
		{
			return list;
		}
		list.AddRange(from a in attachItem.DataArray.Select(GetAttachment)
			where a != null
			select a);
		return list;
	}

	protected virtual IAttachment GetAttachment(WebData data)
	{
		IAttachment attachment = InterfaceActivator.Create<IAttachment>();
		string value = data.FindItem("Uid").Value;
		attachment.File = BinaryFileDescriptor.Download(Guid.Parse(value));
		attachment.CreationAuthor = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		attachment.CreationDate = DateTime.Now;
		return attachment;
	}

	protected virtual IComment GetComment(WebDataItem commentItem)
	{
		if (commentItem == null || commentItem.Data == null)
		{
			return null;
		}
		IComment comment = CommentManager.Instance.Create();
		comment.Text = commentItem.Data.FindItem("Text").Value;
		comment.CreationAuthor = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		comment.CreationDate = DateTime.Now;
		return comment;
	}
}

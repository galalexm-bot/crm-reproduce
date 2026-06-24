using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Calendar.API;

public class CalendarEventCompleteExecutor : PublicServiceMethodExecutor
{
	private static class Names
	{
		public const string EntityId = "EntityId";

		public const string Comment = "Comment";

		public const string Attachments = "Attachments";
	}

	public const string MethodName = "CompleteEvent";

	public static string MethodDescription => SR.T("Выполнить событие");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("EntityId", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор события")).Type(typeof(long));
	}).ItemWithDescriptor("Comment", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Комментарий")).Type(typeof(string)).Optional()
			.ItemWithDescriptor("Attachments", delegate(TypeSerializationDescriptorBuilder b)
			{
				b.Description(SR.T("Идентификаторы файлов")).Type(typeof(Guid[]));
			});
	}).Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
	}).Descriptor;

	protected static IUnitOfWorkManager UnitOfWorkManager => Locator.GetServiceNotNull<IUnitOfWorkManager>();

	public CalendarEventCompleteExecutor(WebData parameters)
		: base(parameters)
	{
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
		WebDataItem webDataItem = Parameters.FindItem("EntityId");
		if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задан идентификатор события"));
		}
		if (!long.TryParse(webDataItem.Value, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора события, должен быть Int64"));
		}
		WebDataItem webDataItem2 = Parameters.FindItem("Comment");
		string comment = ((webDataItem2 != null) ? webDataItem2.Value : "");
		WebDataItem attachItem = null;
		if (webDataItem2 != null && webDataItem2.Data != null)
		{
			attachItem = webDataItem2.Data.FindItem("Attachments");
		}
		IList<IAttachment> attachments = GetAttachments(attachItem);
		DoCompleteAction(result, comment, attachments);
		return GetResult();
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

	private static void DoCompleteAction(long entityId, string comment, IList<IAttachment> attachments)
	{
		ICalendarEvent calendarEvent = CalendarEventManager.Instance.LoadOrNull(entityId);
		if (calendarEvent == null || !CalendarEventManager.Instance.CanEdit(calendarEvent))
		{
			throw new InvalidOperationException(SR.T("Текущий пользователь не имеет прав на изменение события"));
		}
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		ICommentActionModel commentActionModel = null;
		try
		{
			if (!string.IsNullOrEmpty(comment))
			{
				commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
				commentActionModel.Comment = InterfaceActivator.Create<IComment>();
				commentActionModel.Comment.Text = comment;
				if (attachments != null)
				{
					commentActionModel.Attachments = attachments;
				}
			}
			CalendarEventManager.Instance.CompleteEvent(calendarEvent, commentActionModel);
		}
		catch (Exception)
		{
			unitOfWork.Rollback();
			throw;
		}
		unitOfWork.Commit();
	}
}

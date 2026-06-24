using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.API;

public class CalendarEventAddQuestionExecutor : PublicServiceMethodExecutor
{
	public const string MethodName = "AddQuestion";

	protected long QuestionId;

	public static string Description => SR.T("Задать вопрос по событию");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("EventId").Descriptor(SR.T("Идентификатор события, по которому задается вопрос (Int64)"));
	}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("ExecutorId").Descriptor(SR.T("Идентификатор пользователя, которому задан вопрос (Int64)"));
	}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Description").Descriptor(SR.T("Текст вопроса (String)"));
	})
		.Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("Attachments").Descriptor(delegate(TypeSerializationDescriptorBuilder cia)
			{
				cia.IsArray().Item(delegate(TypeSerializationItemDescriptorBuilder ciai)
				{
					ciai.Name("Uid").Descriptor(SR.T("Идентификатор файла BinaryFile (Guid)"));
				});
			});
		})
		.Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("ShowAll").Descriptor(SR.T("Показывать всем. Опционально. (Boolean)"));
		})
		.Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
	}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Id").Descriptor(SR.T("Идентификатор заданного вопроса"));
	}).Descriptor;

	protected static IUnitOfWorkManager UnitOfWorkManager => Locator.GetServiceNotNull<IUnitOfWorkManager>();

	public CalendarEventAddQuestionExecutor(WebData parameters)
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
		if (webDataItem == null || string.IsNullOrWhiteSpace(webDataItem.Value))
		{
			return GetError();
		}
		WebDataItem webDataItem2 = Parameters.FindItem("ExecutorId");
		if (webDataItem2 == null || string.IsNullOrWhiteSpace(webDataItem2.Value))
		{
			return GetError();
		}
		WebDataItem webDataItem3 = Parameters.FindItem("Description");
		if (webDataItem3 == null || string.IsNullOrWhiteSpace(webDataItem3.Value))
		{
			return GetError();
		}
		WebDataItem webDataItem4 = Parameters.FindItem("ShowAll");
		WebDataItem attachItem = Parameters.FindItem("Attachments");
		if (!long.TryParse(webDataItem.Value, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора объекта, должен быть Int64"), 400);
		}
		if (!long.TryParse(webDataItem2.Value, out var result2))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора исполнителя, должен быть Int64"), 400);
		}
		bool result3 = true;
		if (webDataItem4 != null && !string.IsNullOrWhiteSpace(webDataItem4.Value) && !bool.TryParse(webDataItem4.Value, out result3))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат признака Показывать всем, должен быть True или False"), 400);
		}
		string value = webDataItem3.Value;
		IList<IAttachment> attachments = GetAttachments(attachItem);
		ICalendarEvent calendarEvent = CalendarEventManager.Instance.Load(result).CastAsRealType();
		IUser executor = UserManager.Instance.Load(result2);
		DoAddQuestionAction(calendarEvent, executor, value, attachments, result3);
		return GetResult();
	}

	protected virtual WebData GetResult()
	{
		return WebData.CreateFromObject(new
		{
			Result = true,
			Id = QuestionId
		});
	}

	protected virtual WebData GetError()
	{
		return WebData.CreateFromObject(new
		{
			Result = false
		});
	}

	public virtual void DoAddQuestionAction(ICalendarEvent calendarEvent, IUser executor, string description, IList<IAttachment> attachments, bool showAll)
	{
		IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		try
		{
			IQuestion question = InterfaceActivator.Create<IQuestion>();
			question.RefObject = new ReferenceOnEntity
			{
				Object = calendarEvent
			};
			question.Subject = calendarEvent.ToString();
			question.Executor = executor;
			question.Description = description;
			question.ShowAll = showAll;
			question.Status = TaskBaseStatus.NewOrder;
			if (attachments != null && attachments.Count > 0)
			{
				question.Attachments.AddAll((ICollection<IAttachment>)attachments.Where((IAttachment a) => a.File != null).ToList());
			}
			question.Save();
			EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, calendarEvent, CalendarEventActions.AddQuestionGuid);
			if (entityActionEventArgs != null)
			{
				serviceNotNull.ActionExecuted(entityActionEventArgs);
			}
			QuestionId = question.Id;
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
}

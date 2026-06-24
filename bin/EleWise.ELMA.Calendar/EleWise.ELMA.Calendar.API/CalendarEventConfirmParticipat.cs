using System;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Calendar.API;

internal sealed class CalendarEventConfirmParticipationExecutor : PublicServiceMethodExecutor
{
	private static class Names
	{
		public const string EventId = "EventId";

		public const string Status = "Status";

		public const string Comment = "Comment";

		public const string Result = "Result";

		public const string ResultText = "ResultText";
	}

	public const string MethodName = "ConfirmParticipation";

	private IAuthenticationService authenticationService;

	private IUnitOfWorkManager unitOfWorkManager;

	private CalendarEventManager calendarEventManager;

	public static string MethodDescription => SR.T("Подтвердить участие или отказаться от участия в событии");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("EventId", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор события")).Type(typeof(long));
	}).ItemWithDescriptor("Status", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Статус участия в событии")).Type(typeof(ConfirmParticipation));
	}).ItemWithDescriptor("Comment", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Комментарий")).Type(typeof(string)).Optional();
	})
		.Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("Result", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Результат выполнения. True, если выполнение завершено успешно.")).Type(typeof(bool));
	}).ItemWithDescriptor("ResultText", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Комментарий к результату выполненения. При возникновении исключения возвращается текст ошибки")).Type(typeof(string));
	}).Descriptor;

	private IUnitOfWorkManager UnitOfWorkManager => unitOfWorkManager ?? (unitOfWorkManager = Locator.GetServiceNotNull<IUnitOfWorkManager>());

	private IAuthenticationService AuthenticationService => authenticationService ?? (authenticationService = Locator.GetServiceNotNull<IAuthenticationService>());

	internal CalendarEventManager CalendarEventManager => calendarEventManager ?? (calendarEventManager = CalendarEventManager.Instance);

	public CalendarEventConfirmParticipationExecutor(WebData parameters)
		: base(parameters)
	{
	}

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	private WebData ExecuteInternal()
	{
		if (Parameters == null || Parameters.Items == null)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не заданы параметры запроса"), 400);
		}
		WebDataItem webDataItem = Parameters.FindItem("EventId");
		if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задан идентификатор события"), 400);
		}
		if (!long.TryParse(webDataItem.Value, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора события, должен быть Int64"), 400);
		}
		WebDataItem webDataItem2 = Parameters.FindItem("Status");
		if (webDataItem2 == null || string.IsNullOrEmpty(webDataItem2.Value))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не задан статус подтверждения участия в событии"), 400);
		}
		if (!Enum.TryParse<ConfirmParticipation>(webDataItem2.Value, out var result2) || !Enum.IsDefined(typeof(ConfirmParticipation), result2))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверно задан параметр статуса подтверждения участия, должен быть ConfirmParticipation"), 400);
		}
		WebDataItem webDataItem3 = Parameters.FindItem("Comment");
		string comment = ((webDataItem3 != null) ? webDataItem3.Value : string.Empty);
		try
		{
			string resultText = DoCompleteAction(result, result2, comment);
			return WebData.CreateFromObject(new
			{
				Result = true,
				ResultText = resultText
			});
		}
		catch (Exception ex)
		{
			return WebData.CreateFromObject(new
			{
				Result = false,
				ResultText = ex.Message
			});
		}
	}

	private string DoCompleteAction(long eventId, ConfirmParticipation confirmationStatus, string comment)
	{
		ICalendarEvent calendarEvent = CalendarEventManager.LoadOrNull(eventId);
		if (calendarEvent == null)
		{
			throw new ObjectNotFoundException(SR.T("Событие календаря"), eventId);
		}
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		string result = string.Empty;
		using (IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true))
		{
			ICommentActionModel commentActionModel = null;
			try
			{
				if (!string.IsNullOrWhiteSpace(comment))
				{
					commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
					commentActionModel.Comment = InterfaceActivator.Create<IComment>();
					commentActionModel.Comment.Text = comment;
				}
				result = CalendarEventManager.ConfirmParticipation(calendarEvent, currentUser, confirmationStatus, commentActionModel);
			}
			catch (Exception ex)
			{
				unitOfWork.Rollback();
				throw ex;
			}
			unitOfWork.Commit();
		}
		return result;
	}
}

using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Calendar.API;

[Component]
public class EventsPublicServiceMethodsProvider : IPublicServiceMethodsProvider
{
	public IEnumerable<IPublicServiceMethod> GetMethods()
	{
		return new IPublicServiceMethod[9]
		{
			new PublicServiceMethod(CalendarPublicService.UID, "CompleteEvent", CalendarEventCompleteExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new CalendarEventCompleteExecutor(data))
			{
				ParametersDescriptor = CalendarEventCompleteExecutor.ParametersDescriptor,
				ResultDescriptor = CalendarEventCompleteExecutor.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "AddDayEvent", CalendarEventAddDayExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new CalendarEventAddDayExecutor(data))
			{
				ParametersDescriptor = CalendarEventAddDayExecutor.ParametersDescriptor,
				ResultDescriptor = CalendarEventAddDayExecutor.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "ChangeTimeEvent", CalendarEventChangeTimeExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new CalendarEventChangeTimeExecutor(data))
			{
				ParametersDescriptor = CalendarEventChangeTimeExecutor.ParametersDescriptor,
				ResultDescriptor = CalendarEventChangeTimeExecutor.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "DeleteEvent", CalendarEventDeleteExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new CalendarEventDeleteExecutor(data))
			{
				ParametersDescriptor = CalendarEventDeleteExecutor.ParametersDescriptor,
				ResultDescriptor = CalendarEventDeleteExecutor.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "AddComment", CalendarEventAddCommentExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new CalendarEventAddCommentExecutor(data))
			{
				ParametersDescriptor = CalendarEventAddCommentExecutor.ParametersDescriptor,
				ResultDescriptor = CalendarEventAddCommentExecutor.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "CreateEvent", CalendarEventCreateExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new CalendarEventCreateExecutor(data))
			{
				ParametersDescriptor = CalendarEventCreateExecutor.ParametersDescriptor,
				ResultDescriptor = CalendarEventCreateExecutor.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "EditEvent", CalendarEventEditEventExecutor.Description, new Version(1, 0, 0), (WebData data) => new CalendarEventEditEventExecutor(data))
			{
				ParametersDescriptor = CalendarEventEditEventExecutor.ParamsDescriptor,
				ResultDescriptor = CalendarEventCreateExecutor.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "ConfirmParticipation", CalendarEventConfirmParticipationExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new CalendarEventConfirmParticipationExecutor(data))
			{
				ParametersDescriptor = CalendarEventConfirmParticipationExecutor.ParametersDescriptor,
				ResultDescriptor = CalendarEventConfirmParticipationExecutor.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "GetConfirmaionStatus", CalendarEventGetConfirmaionStatusExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new CalendarEventGetConfirmaionStatusExecutor(data))
			{
				ParametersDescriptor = CalendarEventGetConfirmaionStatusExecutor.ParametersDescriptor,
				ResultDescriptor = CalendarEventGetConfirmaionStatusExecutor.ResultDescriptor
			}
		};
	}

	internal static WebData GetSimpleResultWebData(bool resValue)
	{
		return WebData.CreateFromObject(new
		{
			Result = resValue
		});
	}
}

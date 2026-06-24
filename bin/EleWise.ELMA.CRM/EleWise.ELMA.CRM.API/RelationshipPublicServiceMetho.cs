using System;
using System.Collections.Generic;
using EleWise.ELMA.Calendar.API;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.CRM.API;

[Component]
public class RelationshipPublicServiceMethodsProvider : IPublicServiceMethodsProvider
{
	public IEnumerable<IPublicServiceMethod> GetMethods()
	{
		return new IPublicServiceMethod[13]
		{
			new PublicServiceMethod(CalendarPublicService.UID, "CompleteRelationshipCall", RelationshipCallCompleteMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new RelationshipCallCompleteMethodExecutor(data))
			{
				ParametersDescriptor = RelationshipBaseMethodExecutor<IRelationshipCall>.ParametersDescriptor,
				ResultDescriptor = RelationshipBaseMethodExecutor<IRelationshipCall>.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "CompleteRelationshipMeeting", RelationshipMeetingCompleteMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new RelationshipMeetingCompleteMethodExecutor(data))
			{
				ParametersDescriptor = RelationshipBaseMethodExecutor<IRelationshipMeeting>.ParametersDescriptor,
				ResultDescriptor = RelationshipBaseMethodExecutor<IRelationshipMeeting>.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "CompleteRelationshipMail", RelationshipMailCompleteMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new RelationshipMailCompleteMethodExecutor(data))
			{
				ParametersDescriptor = RelationshipBaseMethodExecutor<IRelationshipMail>.ParametersDescriptor,
				ResultDescriptor = RelationshipBaseMethodExecutor<IRelationshipMail>.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "AddDayRelationshipCall", RelationshipCallAddDayMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new RelationshipCallAddDayMethodExecutor(data))
			{
				ParametersDescriptor = RelationshipAddDayMethodExecutor<IRelationshipCall>.ParametersDescriptor,
				ResultDescriptor = RelationshipAddDayMethodExecutor<IRelationshipCall>.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "AddDayRelationshipMeeting", RelationshipMeetingAddDayMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new RelationshipMeetingAddDayMethodExecutor(data))
			{
				ParametersDescriptor = RelationshipAddDayMethodExecutor<IRelationshipMeeting>.ParametersDescriptor,
				ResultDescriptor = RelationshipAddDayMethodExecutor<IRelationshipMeeting>.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "AddDayRelationshipMail", RelationshipMailAddDayMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new RelationshipMailAddDayMethodExecutor(data))
			{
				ParametersDescriptor = RelationshipAddDayMethodExecutor<IRelationshipMail>.ParametersDescriptor,
				ResultDescriptor = RelationshipAddDayMethodExecutor<IRelationshipMail>.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "ChangeTimeRelationshipCall", RelationshipCallChangeTimeMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new RelationshipCallChangeTimeMethodExecutor(data))
			{
				ParametersDescriptor = RelationshipChangeTimeMethodExecutor<IRelationshipCall>.ParametersDescriptor,
				ResultDescriptor = RelationshipChangeTimeMethodExecutor<IRelationshipCall>.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "ChangeTimeRelationshipMeeting", RelationshipMeetingChangeTimeMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new RelationshipMeetingChangeTimeMethodExecutor(data))
			{
				ParametersDescriptor = RelationshipChangeTimeMethodExecutor<IRelationshipMeeting>.ParametersDescriptor,
				ResultDescriptor = RelationshipChangeTimeMethodExecutor<IRelationshipMeeting>.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "ChangeTimeRelationshipMail", RelationshipMailChangeTimeMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new RelationshipMailChangeTimeMethodExecutor(data))
			{
				ParametersDescriptor = RelationshipChangeTimeMethodExecutor<IRelationshipMail>.ParametersDescriptor,
				ResultDescriptor = RelationshipChangeTimeMethodExecutor<IRelationshipMeeting>.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "DeleteRelationshipCall", RelationshipCallDeleteMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new RelationshipCallDeleteMethodExecutor(data))
			{
				ParametersDescriptor = RelationshipDeleteMethodExecutor<IRelationshipCall>.ParametersDescriptor,
				ResultDescriptor = RelationshipDeleteMethodExecutor<IRelationshipCall>.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "DeleteRelationshipMeeting", RelationshipMeetingDeleteMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new RelationshipMeetingDeleteMethodExecutor(data))
			{
				ParametersDescriptor = RelationshipDeleteMethodExecutor<IRelationshipMeeting>.ParametersDescriptor,
				ResultDescriptor = RelationshipDeleteMethodExecutor<IRelationshipMeeting>.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "DeleteRelationshipMail", RelationshipMailDeleteMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new RelationshipMailDeleteMethodExecutor(data))
			{
				ParametersDescriptor = RelationshipDeleteMethodExecutor<IRelationshipMail>.ParametersDescriptor,
				ResultDescriptor = RelationshipDeleteMethodExecutor<IRelationshipMeeting>.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "AddCommentRelationship", RelationshipAddCommentExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new RelationshipAddCommentExecutor(data))
			{
				ParametersDescriptor = RelationshipAddCommentExecutor.ParametersDescriptor,
				ResultDescriptor = RelationshipAddCommentExecutor.ResultDescriptor
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

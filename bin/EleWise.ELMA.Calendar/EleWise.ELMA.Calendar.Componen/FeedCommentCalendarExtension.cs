using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Calendar.Components.Feed;

[Component(Order = 1000)]
internal class FeedCommentCalendarExtension : BaseFeedPostExtension
{
	private void CheckForCalendarEvent(Dictionary<long, bool> items)
	{
		IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string text = string.Join(", ", items.Keys);
		string sql = string.Format("SELECT DISTINCT cep.{0} as {7} FROM {2} LEFT JOIN {3} ON usc.{5} = cep.{1}  WHERE ( (cep.{1} = {8}) or (cep.{1} <> {8} and cep.{4} = 1 and cep.{1} <> usc.{1} and usc.{1} = {8}) ) and cep.{0} in ({6})", serviceNotNull.Dialect.QuoteIfNeeded("Target"), serviceNotNull.Dialect.QuoteIfNeeded("UserId"), serviceNotNull.NoLockTableExpression("CalendarEventPermission", "cep"), serviceNotNull.NoLockTableExpression("UserSecuritySetCache", "usc"), serviceNotNull.Dialect.QuoteIfNeeded("AllowChief"), serviceNotNull.Dialect.QuoteIfNeeded("SubordinateUserId"), text, serviceNotNull.Dialect.QuoteIfNeeded("TargetId"), currentUser.GetId());
		using IDataReader dataReader = serviceNotNull.ExecuteQuery(sql);
		while (dataReader.Read())
		{
			if (!(dataReader["TargetId"] is DBNull))
			{
				long key = Convert.ToInt64(dataReader["TargetId"]);
				if (items.ContainsKey(key))
				{
					items[key] = true;
				}
			}
		}
	}

	public override Guid GetCommentActionUid(Guid objectUid)
	{
		Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
		Guid guid = InterfaceActivator.UID<ICalendarEvent>();
		if (objectUid == guid || typeByUidOrNull.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid)))
		{
			return CalendarEventActions.AddCommentGuid;
		}
		return Guid.Empty;
	}

	protected override List<Guid> CommentSupportedObject()
	{
		return new List<Guid> { InterfaceActivator.UID<ICalendarEvent>() };
	}

	public override void CanCreateComment(Guid objectUid, Dictionary<long, bool> items)
	{
		if (items != null && items.Count != 0 && CommentIsSupported(objectUid))
		{
			CheckForCalendarEvent(items);
		}
	}

	public override Guid GetQuestionActionUid(Guid objectUid)
	{
		Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
		Guid guid = InterfaceActivator.UID<ICalendarEvent>();
		if (objectUid == guid || typeByUidOrNull.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid)))
		{
			return CalendarEventActions.AddQuestionGuid;
		}
		return Guid.Empty;
	}

	public override string GetQuestionSubject(IEntity target)
	{
		return (target is ICalendarEvent calendarEvent) ? calendarEvent.Subject : base.GetQuestionSubject(target);
	}

	protected override List<Guid> QuestionSupportedObject()
	{
		return new List<Guid> { InterfaceActivator.UID<ICalendarEvent>() };
	}

	public override void CanCreateQuestion(Guid objectUid, Dictionary<long, bool> items)
	{
		if (items != null && items.Count != 0 && QuestionIsSupported(objectUid))
		{
			CheckForCalendarEvent(items);
		}
	}
}

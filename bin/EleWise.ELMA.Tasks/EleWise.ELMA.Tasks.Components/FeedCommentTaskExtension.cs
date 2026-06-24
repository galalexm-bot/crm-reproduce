using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Components.Feed;

[Component(Order = 1300)]
internal class FeedCommentTaskExtension : BaseFeedPostExtension
{
	private void CheckForWorkLogItem(Dictionary<long, bool> items)
	{
		EleWise.ELMA.Security.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		IEnumerable<long> enumerable = items.Keys.Where((long k) => k > 0);
		if (!enumerable.Any())
		{
			return;
		}
		string text = string.Join(", ", enumerable);
		if (Locator.GetServiceNotNull<SecurityService>().HasPermission(currentUser, PermissionProvider.AdminWorklogPermission))
		{
			string sql = string.Format("SELECT DISTINCT wli.{0} as {1} FROM {2} WHERE wli.{0} in ({3}) and wli.{4} <> 1", serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("TargetId"), serviceNotNull.NoLockTableExpression("WorklogItem", "wli"), text, serviceNotNull.Dialect.QuoteIfNeeded("IsDeleted"));
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
			return;
		}
		string sql2 = string.Format("SELECT DISTINCT wli.{0} as {1} FROM {2} wli left join {3} usc on wli.{4} = usc.{5} WHERE (wli.{4} = {6} or wli.{7} = {6} or usc.{8} = {6}) and wli.{0} in ({9}) and wli.{10} <> 1", serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("TargetId"), serviceNotNull.Dialect.QuoteIfNeeded("WorklogItem"), serviceNotNull.Dialect.QuoteIfNeeded("UserSecuritySetCache"), serviceNotNull.Dialect.QuoteIfNeeded("CreationAuthor"), serviceNotNull.Dialect.QuoteIfNeeded("SubordinateUserId"), currentUser.GetId(), serviceNotNull.Dialect.QuoteIfNeeded("Harmonizator"), serviceNotNull.Dialect.QuoteIfNeeded("UserId"), text, serviceNotNull.Dialect.QuoteIfNeeded("IsDeleted"));
		using IDataReader dataReader2 = serviceNotNull.ExecuteQuery(sql2);
		while (dataReader2.Read())
		{
			if (!(dataReader2["TargetId"] is DBNull))
			{
				long key2 = Convert.ToInt64(dataReader2["TargetId"]);
				if (items.ContainsKey(key2))
				{
					items[key2] = true;
				}
			}
		}
	}

	private void CheckForTask(Dictionary<long, bool> items)
	{
		EleWise.ELMA.Security.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
		ITransformationProvider transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>();
		string text = string.Join(",", items.Keys.Select((long item, int i) => $"{transformationProvider.ParameterSeparator}u{i}"));
		Dictionary<string, object> parametrs = new Dictionary<string, object> { 
		{
			"currentUserId",
			currentUser.GetId()
		} };
		int index = 0;
		items.Keys.ForEach(delegate(long item)
		{
			parametrs.Add("u" + index, item);
			index++;
		});
		string sql = string.Format("SELECT DISTINCT tbp.{0} as {7} FROM {2} tbp LEFT JOIN {3} usc ON usc.{5}=tbp.{1} WHERE ( (tbp.{1} = {8}currentUserId) or (tbp.{1} <> {8}currentUserId and tbp.{4} = 1 and tbp.{1} <> usc.{1} and usc.{1} = {8}currentUserId) ) and tbp.{0} in ({6})", transformationProvider.Dialect.QuoteIfNeeded("Target"), transformationProvider.Dialect.QuoteIfNeeded("UserId"), transformationProvider.Dialect.QuoteIfNeeded("TaskBasePermission"), transformationProvider.Dialect.QuoteIfNeeded("UserSecuritySetCache"), transformationProvider.Dialect.QuoteIfNeeded("AllowChief"), transformationProvider.Dialect.QuoteIfNeeded("SubordinateUserId"), text, transformationProvider.Dialect.QuoteIfNeeded("TargetId"), transformationProvider.ParameterSeparator);
		using IDataReader dataReader = transformationProvider.ExecuteQuery(sql, parametrs);
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
		Guid guid = InterfaceActivator.UID<ITaskBase>();
		if (objectUid == guid || typeByUidOrNull.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid)))
		{
			return TaskBaseActions.AddCommentGuid;
		}
		Guid guid2 = InterfaceActivator.UID<IWorkLogItem>();
		if (objectUid == guid2 || typeByUidOrNull.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid2)))
		{
			return WorkLogItemActions.AddCommentGuid;
		}
		return Guid.Empty;
	}

	protected override List<Guid> CommentSupportedObject()
	{
		return new List<Guid>
		{
			InterfaceActivator.UID<ITaskBase>(),
			InterfaceActivator.UID<IWorkLogItem>()
		};
	}

	public override bool CommentIsSupported(Guid objectUid)
	{
		if (!(InterfaceActivator.UID<IQuestion>() == objectUid))
		{
			return base.CommentIsSupported(objectUid);
		}
		return true;
	}

	public override void CanCreateComment(Guid objectUid, Dictionary<long, bool> items)
	{
		if (items == null || items.Count == 0 || !CommentIsSupported(objectUid))
		{
			return;
		}
		if (InterfaceActivator.UID<IQuestion>() == objectUid)
		{
			EleWise.ELMA.Security.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
			long[] array = items.Keys.ToArray();
			ICriteria val = Locator.GetServiceNotNull<ISessionProvider>().GetSession("").CreateCriteria(InterfaceActivator.TypeOf<IQuestion>());
			val.Add((ICriterion)(object)Restrictions.IsNull("Answer"));
			val.Add((ICriterion)(object)Restrictions.Eq(LinqUtils.NameOf((Expression<Func<IQuestion, object>>)((IQuestion t) => t.Executor)), (object)currentUser));
			val.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq(LinqUtils.NameOf((Expression<Func<IQuestion, object>>)((IQuestion t) => t.Status)), (object)TaskBaseStatus.WasClosed)));
			val.Add((ICriterion)(object)Restrictions.In((IProjection)(object)Projections.Property("Id"), (ICollection)array));
			val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("Id") });
			val.List<long>().ToArray().ForEach(delegate(long a)
			{
				if (items.ContainsKey(a))
				{
					items[a] = true;
				}
			});
		}
		else
		{
			Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
			if (objectUid == InterfaceActivator.UID<ITaskBase>() || typeByUidOrNull.IsSubclassOf(InterfaceActivator.TypeOf(typeof(ITaskBase))))
			{
				CheckForTask(items);
			}
			else if (objectUid == InterfaceActivator.UID<IWorkLogItem>() || typeByUidOrNull.IsSubclassOf(InterfaceActivator.TypeOf(typeof(IWorkLogItem))))
			{
				CheckForWorkLogItem(items);
			}
		}
	}

	public override Guid CreateComment(Guid objectUid, long objectId, string text, MessageAttachment[] messageAttachments)
	{
		if (objectUid == Guid.Empty || !CommentIsSupported(objectUid))
		{
			return Guid.Empty;
		}
		if (objectUid == InterfaceActivator.UID<IQuestion>())
		{
			EleWise.ELMA.Security.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
			IQuestion question = QuestionManager.Instance.Load(objectId);
			if (question.Answer == null)
			{
				InstanceOf<IAnswer> instanceOf = new InstanceOf<IAnswer>();
				instanceOf.New.CreationAuthor = (EleWise.ELMA.Security.Models.IUser)currentUser;
				instanceOf.New.Question = question;
				instanceOf.New.Text = text;
				IAnswer @new = instanceOf.New;
				question.EndDate = DateTime.Now;
				question.Status = TaskBaseStatus.Complete;
				question.Answer = @new;
				@new.Save();
			}
			return DefaultEntityActions.CreateGuid;
		}
		return base.CreateComment(objectUid, objectId, text, messageAttachments);
	}

	public override string GetQuestionSubject(IEntity target)
	{
		if (target is ITaskBase taskBase)
		{
			return taskBase.Subject;
		}
		if (target is IWorkLogItem workLogItem)
		{
			return workLogItem.Name;
		}
		return base.GetQuestionSubject(target);
	}

	public override Guid GetQuestionActionUid(Guid objectUid)
	{
		Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
		Guid guid = InterfaceActivator.UID<ITaskBase>();
		if (objectUid == guid || typeByUidOrNull.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid)))
		{
			return TaskBaseActions.AddQuestionGuid;
		}
		Guid guid2 = InterfaceActivator.UID<IWorkLogItem>();
		if (objectUid == guid2 || typeByUidOrNull.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid2)))
		{
			return WorkLogItemActions.AddQuestionGuid;
		}
		return Guid.Empty;
	}

	protected override List<Guid> QuestionSupportedObject()
	{
		return new List<Guid>
		{
			InterfaceActivator.UID<ITaskBase>(),
			InterfaceActivator.UID<IWorkLogItem>()
		};
	}

	public override bool QuestionIsSupported(Guid objectUid)
	{
		if (InterfaceActivator.UID<IQuestion>() == objectUid)
		{
			return false;
		}
		return base.QuestionIsSupported(objectUid);
	}

	public override void CanCreateQuestion(Guid objectUid, Dictionary<long, bool> items)
	{
		if (items != null && items.Count != 0 && QuestionIsSupported(objectUid))
		{
			Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
			if (objectUid == InterfaceActivator.UID<ITaskBase>() || typeByUidOrNull.IsSubclassOf(InterfaceActivator.TypeOf(typeof(ITaskBase))))
			{
				CheckForTask(items);
			}
			else if (objectUid == InterfaceActivator.UID<IWorkLogItem>() || typeByUidOrNull.IsSubclassOf(InterfaceActivator.TypeOf(typeof(IWorkLogItem))))
			{
				CheckForWorkLogItem(items);
			}
		}
	}
}

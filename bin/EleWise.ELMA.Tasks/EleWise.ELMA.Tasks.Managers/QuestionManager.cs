using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class QuestionManager : TaskBaseManager<IQuestion>
{
	public IAuditManager auditManager { get; set; }

	public new static QuestionManager Instance => Locator.GetServiceNotNull<QuestionManager>();

	public List<IQuestion> GetQuestions(IEntity entity)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		IEntity obj = entity.CastAsRealType();
		return GetQuestionsCriteria(currentUser, ReferenceOnEntity.Create(obj)).List<IQuestion>().ToList();
	}

	public List<IQuestion> GetQuestions(long entityId, Guid entityTypeUid)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		return GetQuestionsCriteria(currentUser, ReferenceOnEntity.Create(entityTypeUid, entityId)).List<IQuestion>().ToList();
	}

	public long GetQuestionsCount(IEntity entity)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		IEntity obj = entity.CastAsRealType();
		return Convert.ToInt64(GetQuestionsCriteria(currentUser, ReferenceOnEntity.Create(obj)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Count("Id") }).UniqueResult());
	}

	internal ICriteria CreateQuestionsCriteria(IUser user, ReferenceOnEntity referenceOnEntity)
	{
		return GetQuestionsCriteria(user, referenceOnEntity);
	}

	protected virtual ICriteria GetQuestionsCriteria(IUser user, ReferenceOnEntity referenceOnEntity)
	{
		return CreateCriteria(new Filter
		{
			DisableSecurity = true
		}).Add((ICriterion)(object)Restrictions.Eq("RefObject", (object)referenceOnEntity)).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("CreationAuthor", (object)user), (ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("Executor", (object)user), (ICriterion)(object)Restrictions.Eq("ShowAll", (object)true))));
	}

	public bool IsAnswerer(IQuestion question)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		return TaskBaseManager<ITaskBase>.IsExecutor(question, currentUser, checkSubordinateUser: false);
	}

	public bool IsAuthor(IQuestion question)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		return question.CreationAuthor.Id == currentUser.Id;
	}

	[ActionMethod("9800bbe4-3b24-49b6-b854-973d13045a67")]
	[Transaction]
	public virtual void Close(IQuestion question)
	{
		question.EndDate = DateTime.Now;
		question.Status = TaskBaseStatus.WasClosed;
		question.Save();
		base.ActionHandler.ActionExecuted(new EntityActionEventArgs(null, question, QuestionActions.CloseGuid));
	}

	public List<Pair<long, List<WebDataItem>>> GetQuestionFeedInfo(Guid typeUid, long id)
	{
		string displayName = auditManager.GetAction(QuestionActions.CloseGuid).DisplayName;
		IList<long> list = base.Session.CreateCriteria(InterfaceActivator.TypeOf<ITaskBase>()).Add((ICriterion)(object)Restrictions.Eq("Id", (object)id)).Add((ICriterion)(object)Restrictions.Eq("TypeUid", (object)typeUid))
			.Add((ICriterion)(object)Restrictions.Eq("Status", (object)TaskBaseStatus.WasClosed))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("Executor.Id") })
			.List<long>();
		List<Pair<long, List<WebDataItem>>> list2 = new List<Pair<long, List<WebDataItem>>>();
		List<WebDataItem> second = new List<WebDataItem>
		{
			new WebDataItem
			{
				Name = displayName,
				Value = true.ToString()
			}
		};
		foreach (long item in list)
		{
			list2.Add(new Pair<long, List<WebDataItem>>(item, second));
		}
		return list2;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Extensions;

public static class ReplacementTaskExtensions
{
	public static IUser GetAssignment(this IReplacementTask replacementTask, ReferenceOnEntity entity, Guid propertyUid)
	{
		IUser plannedAssignment = null;
		string assignmentValue = replacementTask.GetAssignmentValue(entity, propertyUid, delegate(ReferenceOnEntity entity1, Guid propertyUid1)
		{
			plannedAssignment = replacementTask.GetPlanedAssignment(entity1, propertyUid1);
			return (plannedAssignment == null) ? string.Empty : plannedAssignment.Id.ToString();
		});
		long result = 0L;
		if (long.TryParse(assignmentValue, out result) && result != 0L)
		{
			if (plannedAssignment == null || plannedAssignment.Id != result)
			{
				return UserManager.Instance.Load(result);
			}
			return plannedAssignment;
		}
		return null;
	}

	public static string GetAssignmentValue(this IReplacementTask replacementTask, ReferenceOnEntity entity, Guid propertyUid, Func<ReferenceOnEntity, Guid, string> defaultValue)
	{
		List<ReplacementTaskAssignment> list = (List<ReplacementTaskAssignment>)replacementTask.Assignments;
		ReplacementTaskAssignment replacementTaskAssignment;
		if (list != null && (replacementTaskAssignment = list.Find((ReplacementTaskAssignment a) => entity.Equals(a.Entity) && a.PropertyUid == propertyUid)) != null)
		{
			if (replacementTaskAssignment.UserId != 0L)
			{
				replacementTaskAssignment.Value = replacementTaskAssignment.UserId.ToString();
			}
			return replacementTaskAssignment.Value;
		}
		if (defaultValue != null)
		{
			return defaultValue(entity, propertyUid);
		}
		return string.Empty;
	}

	public static void SetAssignmentValue(this IReplacementTask replacementTask, ReferenceOnEntity entity, Guid propertyUid, string value, Func<ReferenceOnEntity, Guid, string> defaultValue)
	{
		List<ReplacementTaskAssignment> list = (List<ReplacementTaskAssignment>)replacementTask.Assignments;
		string text = string.Empty;
		if (defaultValue != null)
		{
			text = defaultValue(entity, propertyUid);
		}
		if (!string.IsNullOrEmpty(text) && text == value)
		{
			if (list != null && list.RemoveAll((ReplacementTaskAssignment a) => entity.Equals(a.Entity) && a.PropertyUid == propertyUid) > 0)
			{
				replacementTask.Assignments = list.ToList();
				replacementTask.Save();
			}
			return;
		}
		if (list == null)
		{
			list = (List<ReplacementTaskAssignment>)(replacementTask.Assignments = new List<ReplacementTaskAssignment>());
		}
		ReplacementTaskAssignment replacementTaskAssignment = list.Find((ReplacementTaskAssignment a) => entity.Equals(a.Entity) && a.PropertyUid == propertyUid);
		if (replacementTaskAssignment == null)
		{
			replacementTaskAssignment = new ReplacementTaskAssignment
			{
				Entity = entity,
				PropertyUid = propertyUid
			};
			list.Add(replacementTaskAssignment);
		}
		replacementTaskAssignment.UserId = 0L;
		replacementTaskAssignment.Value = value;
		replacementTask.Assignments = list.ToList();
		replacementTask.Save();
	}

	public static IUser GetPlanedAssignment(this IReplacementTask replacementTask, ReferenceOnEntity entity, Guid propertyUid)
	{
		if (!(replacementTask.GetReplacementObject() is IReplacement replacement))
		{
			return replacementTask.Executor;
		}
		return ReplacementRuleManager.Instance.AssignmentReplacementRule(entity.Object, propertyUid, replacement, saveAndFlush: false) ?? replacement.TargetUser;
	}

	public static IEntity GetReplacementObject(this IReplacementTask replacementTask)
	{
		if (replacementTask.Replacement != null)
		{
			return replacementTask.Replacement;
		}
		return replacementTask.BlockedUser;
	}

	public static IUser GetReplacementUser(this IReplacementTask replacementTask)
	{
		if (replacementTask.Replacement == null)
		{
			return replacementTask.BlockedUser;
		}
		return replacementTask.Replacement.SourceUser;
	}

	public static bool IsReplacementTask(this IReplacementTask repTask)
	{
		return repTask.Replacement != null;
	}

	public static bool IsBlockUserTask(this IReplacementTask repTask)
	{
		return repTask.BlockedUser != null;
	}
}

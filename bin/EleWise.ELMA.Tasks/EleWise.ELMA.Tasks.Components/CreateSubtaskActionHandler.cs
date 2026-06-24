using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
public class CreateSubtaskActionHandler : ICreateSubtaskActionHandler, IEventHandler
{
	public void ProcessBeforeCreate(ITaskBase source, ITaskBase target, ICreateSubtaskActionModel subtask)
	{
		if (source == null)
		{
			return;
		}
		if (subtask.CopySubject)
		{
			target.Subject = source.Subject;
		}
		if (subtask.CopyPriority)
		{
			target.Priority = source.Priority;
		}
		if (subtask.CopyDates)
		{
			target.StartDate = source.StartDate;
			target.EndDate = source.EndDate;
		}
		if (subtask.CopyDescription)
		{
			target.Description = source.Description;
		}
		if (subtask.AppendCommentsToDescription)
		{
			foreach (IComment item in ((IEnumerable<IComment>)source.Comments).OrderBy((IComment a) => a.CreationDate))
			{
				if (!string.IsNullOrWhiteSpace(target.Description))
				{
					target.Description += "\n";
				}
				target.Description += string.Format(SR.T("{0} {1}\n--------------------\n{2}\n"), item.CreationDate, item.CreationAuthor, item.Text);
			}
		}
		if (subtask.CopyAttachments)
		{
			CopyAttachments((IEnumerable<IAttachment>)source.Attachments, (ISet<IAttachment>)target.Attachments);
			CopyAttachments((IEnumerable<IAttachment>)source.AttachmentsSpecified, (ISet<IAttachment>)target.AttachmentsSpecified);
		}
		static void CopyAttachments(IEnumerable<IAttachment> attachments, ISet<IAttachment> targetCollection)
		{
			targetCollection.AddAll(from a in attachments
				where a.File != null
				group a by a.File.Id into g
				select g.First() into a
				select CloneHelperBuilder.Create(a).Clone());
		}
	}

	public void ProcessBeforeSave(ITaskBase source, ITaskBase target, ICreateSubtaskActionModel subtask)
	{
	}

	public static bool IsDefaultValueSubject(ITaskBase source)
	{
		if (source != null && !string.IsNullOrWhiteSpace(source.Subject))
		{
			return false;
		}
		return true;
	}

	public static bool IsDefaultValuePriority(ITaskBase source)
	{
		if (source != null && source.Priority != TaskPriority.Medium)
		{
			return false;
		}
		return true;
	}

	public static bool IsDefaultValueDates(ITaskBase source)
	{
		if (source != null && source.StartDate.HasValue && source.EndDate.HasValue)
		{
			return false;
		}
		return true;
	}

	public static bool IsDefaultValueDescription(ITaskBase source)
	{
		if (source != null && !string.IsNullOrWhiteSpace(source.Description))
		{
			return false;
		}
		return true;
	}

	public static bool IsDefaultValueAttachments(ITaskBase source)
	{
		if (source != null && (((ICollection<IAttachment>)source.Attachments).Count > 0 || ((ICollection<IAttachment>)source.AttachmentsSpecified).Count > 0))
		{
			return false;
		}
		return true;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class SubtaskAttachmentsInfo
{
	private IEnumerable<IObjectAttachmentExtension> objectAttachmentExtension;

	private Lazy<Dictionary<IAttachment, ITaskBase>> _attachments;

	private Lazy<List<ITaskBase>> _tasks;

	public ITask ParentTask { get; set; }

	public List<ITaskBase> SubTasks
	{
		get
		{
			if (ParentTask == null)
			{
				return null;
			}
			if (_tasks == null)
			{
				_tasks = new Lazy<List<ITaskBase>>(delegate
				{
					List<ITaskBase> result = new List<ITaskBase>();
					GetSubTasks(ParentTask, result);
					return result;
				});
			}
			return _tasks.Value;
		}
	}

	public Dictionary<IAttachment, ITaskBase> Attachments
	{
		get
		{
			if (ParentTask == null)
			{
				return null;
			}
			if (_attachments == null)
			{
				_attachments = new Lazy<Dictionary<IAttachment, ITaskBase>>(delegate
				{
					Dictionary<IAttachment, ITaskBase> dictionary = new Dictionary<IAttachment, ITaskBase>();
					foreach (ITaskBase subTask in SubTasks)
					{
						foreach (IAttachment item in (IEnumerable<IAttachment>)subTask.Attachments)
						{
							if (!dictionary.ContainsKey(item))
							{
								dictionary.Add(item, subTask);
							}
						}
					}
					return dictionary;
				});
			}
			return _attachments.Value;
		}
	}

	public SubtaskAttachmentsInfo()
	{
		objectAttachmentExtension = from a in ComponentManager.Current.GetExtensionPoints<IObjectAttachmentExtension>()
			where a.EntityType(InterfaceActivator.UID<ITaskBase>())
			select a;
	}

	public bool IsAnyAttachment(ITaskBase task)
	{
		return objectAttachmentExtension.Any((IObjectAttachmentExtension a) => a.IsAnyAttachments(task));
	}

	private void GetSubTasks(ITask parent, List<ITaskBase> result)
	{
		result.AddRange((IEnumerable<ITaskBase>)parent.ChildTasks);
		foreach (ITaskBase item in (IEnumerable<ITaskBase>)parent.ChildTasks)
		{
			if (item.CastAsRealType() is ITask)
			{
				GetSubTasks((ITask)item, result);
			}
		}
	}
}

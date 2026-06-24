using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class SubtaskDocumentAttachmentsInfo
{
	private Lazy<Dictionary<IDocumentAttachment, ITask>> _attachments;

	public ITask ParentTask { get; set; }

	public Dictionary<IDocumentAttachment, ITask> Attachments
	{
		get
		{
			if (ParentTask == null)
			{
				return null;
			}
			if (_attachments == null)
			{
				_attachments = new Lazy<Dictionary<IDocumentAttachment, ITask>>(delegate
				{
					List<ITask> list = new List<ITask>();
					GetSubTasks(ParentTask, list);
					Dictionary<IDocumentAttachment, ITask> dictionary = new Dictionary<IDocumentAttachment, ITask>();
					foreach (ITask item in list)
					{
						foreach (IDocumentAttachment item2 in (IEnumerable<IDocumentAttachment>)((IAttachmentsTaskBase)item).DocumentAttachments)
						{
							if (!dictionary.ContainsKey(item2))
							{
								dictionary.Add(item2, item);
							}
						}
					}
					return dictionary;
				});
			}
			return _attachments.Value;
		}
	}

	private void GetSubTasks(ITask parent, List<ITask> result)
	{
		result.AddRange(((IEnumerable)parent.ChildTasks).Cast<ITask>());
		foreach (ITaskBase item in (IEnumerable<ITaskBase>)parent.ChildTasks)
		{
			GetSubTasks((ITask)item, result);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "TaskBase")]
public abstract class TaskBaseWCF
{
	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public Guid StatusUid { get; set; }

	[DataMember]
	public string Subject { get; set; }

	[DataMember]
	public string Description { get; set; }

	[DataMember]
	public DateTime CreationDate { get; set; }

	[DataMember]
	public DateTime? StartDate { get; set; }

	[DataMember]
	public DateTime? EndDate { get; set; }

	[DataMember]
	public DateTime? EndWorkDate { get; set; }

	[DataMember]
	public TaskPriorityEnum Priority { get; set; }

	[DataMember]
	public long CreationAuthorId { get; set; }

	[DataMember]
	public long ExecutorId { get; set; }

	[DataMember]
	public TaskAttachmentWCF[] Attachments { get; set; }

	[DataMember]
	public TaskCommentWCF[] Comments { get; set; }

	[DataMember]
	public TaskQuestionWCF[] Questions { get; set; }

	[DataMember]
	public TaskDocumentAttachmentWCF[] DocumentAttachments { get; set; }

	[DataMember]
	public WebData AdditionalFields { get; set; }

	protected TaskBaseWCF()
	{
	}

	protected TaskBaseWCF(ITaskBase task)
	{
		Id = task.Id;
		Uid = task.Uid;
		StatusUid = task.Status.Value;
		Subject = task.Subject;
		Description = task.Description;
		CreationDate = task.CreationDate ?? DateTime.Today;
		StartDate = task.StartDate;
		EndDate = task.EndDate;
		EndWorkDate = task.EndWorkDate;
		Priority = (TaskPriorityEnum)task.Priority;
		CreationAuthorId = task.CreationAuthor.Id;
		ExecutorId = task.Executor.Id;
		IFileManager fileManager = Locator.GetServiceNotNull<IFileManager>();
		Attachments = ((task.Attachments == null) ? new TaskAttachmentWCF[0] : (from a in (IEnumerable<IAttachment>)task.Attachments
			where a.File != null
			select new TaskAttachmentWCF
			{
				Id = a.Id,
				Uid = a.Uid,
				FileUid = a.File.Uid,
				CreationAuthorId = a.CreationAuthor.Id,
				CreationDate = (a.CreationDate ?? DateTime.Today),
				FileName = a.File.Name,
				FileSize = fileManager.FileSize(a.File.Id)
			}).ToArray());
		Comments = ((task.Comments == null) ? new TaskCommentWCF[0] : ((IEnumerable<IComment>)task.Comments).Select((IComment c) => new TaskCommentWCF
		{
			Id = c.Id,
			Uid = c.Uid,
			Text = c.Text,
			CreationAuthorId = c.CreationAuthor.Id,
			CreationDate = (c.CreationDate ?? DateTime.Today)
		}).ToArray());
		Questions = (from q in QuestionManager.Instance.GetQuestions(task)
			select new TaskQuestionWCF
			{
				Id = q.Id,
				Uid = q.Uid,
				Question = q.Description,
				CreationAuthorId = q.CreationAuthor.Id,
				ExecutorId = q.Executor.Id,
				CreationDate = (q.CreationDate ?? DateTime.Today),
				Attachments = ((q.Attachments == null) ? new TaskAttachmentWCF[0] : (from a in (IEnumerable<IAttachment>)q.Attachments
					where a.File != null
					select new TaskAttachmentWCF
					{
						Id = a.Id,
						Uid = a.Uid,
						FileUid = a.File.Uid,
						CreationAuthorId = a.CreationAuthor.Id,
						CreationDate = (a.CreationDate ?? DateTime.Today),
						FileName = a.File.Name,
						FileSize = fileManager.FileSize(a.File.Id)
					}).ToArray()),
				Answer = ((q.Answer == null) ? null : new TaskAnswerWCF
				{
					Id = q.Answer.Id,
					Uid = q.Answer.Uid,
					Answer = q.Answer.Text,
					CreationAuthorId = q.Answer.CreationAuthor.Id,
					CreationDate = (q.Answer.CreationDate ?? DateTime.Today),
					Attachments = ((q.Answer.Attachments == null) ? new TaskAttachmentWCF[0] : (from a in (IEnumerable<IAttachment>)q.Answer.Attachments
						where a.File != null
						select new TaskAttachmentWCF
						{
							Id = a.Id,
							Uid = a.Uid,
							FileUid = a.File.Uid,
							CreationAuthorId = a.CreationAuthor.Id,
							CreationDate = (a.CreationDate ?? DateTime.Today),
							FileName = a.File.Name,
							FileSize = fileManager.FileSize(a.File.Id)
						}).ToArray())
				})
			}).ToArray();
	}
}

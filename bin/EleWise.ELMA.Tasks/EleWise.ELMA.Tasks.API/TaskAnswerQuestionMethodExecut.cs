using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.API;

public class TaskAnswerQuestionMethodExecutor : PublicServiceMethodExecutor
{
	public const string MethodName = "AnswerQuestion";

	protected long AnswerId;

	public static string Description => SR.T("Ответить на вопрос");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("QuestionId").Descriptor(SR.T("Идентификатор вопроса, на который дается ответ (Int64)"));
	}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Text").Descriptor(SR.T("Текст вопроса (String)"));
	}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Attachments").Descriptor(delegate(TypeSerializationDescriptorBuilder cia)
		{
			cia.IsArray().Item(delegate(TypeSerializationItemDescriptorBuilder ciai)
			{
				ciai.Name("Uid").Descriptor(SR.T("Идентификатор файла BinaryFile (Guid)"));
			});
		});
	})
		.Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("ShowAll").Descriptor(SR.T("Показывать всем. Опционально. (Boolean)"));
		})
		.Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
	}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Id").Descriptor(SR.T("Идентификатор ответа на вопрос"));
	}).Descriptor;

	protected static IUnitOfWorkManager UnitOfWorkManager => Locator.GetServiceNotNull<IUnitOfWorkManager>();

	public TaskAnswerQuestionMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	protected virtual WebData ExecuteInternal()
	{
		if (Parameters == null || Parameters.Items == null)
		{
			return GetError();
		}
		WebDataItem webDataItem = Parameters.FindItem("QuestionId");
		if (webDataItem == null || string.IsNullOrWhiteSpace(webDataItem.Value))
		{
			return GetError();
		}
		WebDataItem webDataItem2 = Parameters.FindItem("Text");
		if (webDataItem2 == null || string.IsNullOrWhiteSpace(webDataItem2.Value))
		{
			return GetError();
		}
		WebDataItem webDataItem3 = Parameters.FindItem("ShowAll");
		WebDataItem attachItem = Parameters.FindItem("Attachments");
		if (!long.TryParse(webDataItem.Value, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора вопроса, должен быть Int64"), 400);
		}
		bool result2 = true;
		if (webDataItem3 != null && !string.IsNullOrWhiteSpace(webDataItem3.Value) && !bool.TryParse(webDataItem3.Value, out result2))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат признака Показывать всем, должен быть True или False"), 400);
		}
		string value = webDataItem2.Value;
		IList<IAttachment> attachments = GetAttachments(attachItem);
		IQuestion question = QuestionManager.Instance.Load(result);
		DoAnswerQuestionAction(question, value, attachments, result2);
		return GetResult();
	}

	protected virtual WebData GetResult()
	{
		return WebData.CreateFromObject(new
		{
			Result = true,
			Id = AnswerId
		});
	}

	protected virtual WebData GetError()
	{
		return TasksPublicServiceMethodsProvider.GetSimpleResultWebData(resValue: false);
	}

	public virtual void DoAnswerQuestionAction(IQuestion question, string text, IList<IAttachment> attachments, bool showAll)
	{
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		try
		{
			if (question.Answer == null)
			{
				InstanceOf<IAnswer> instanceOf = new InstanceOf<IAnswer>();
				instanceOf.New.Question = question;
				instanceOf.New.Text = text;
				instanceOf.New.ShowAll = showAll;
				IAnswer @new = instanceOf.New;
				if (attachments != null && attachments.Count > 0)
				{
					@new.Attachments.AddAll((ICollection<IAttachment>)attachments.Where((IAttachment a) => a.File != null).ToList());
				}
				question.EndDate = DateTime.Now;
				question.Status = TaskBaseStatus.Complete;
				question.Answer = @new;
				@new.Save();
			}
			AnswerId = question.Answer.Id;
		}
		catch (Exception)
		{
			unitOfWork.Rollback();
			throw;
		}
		unitOfWork.Commit();
	}

	protected virtual IList<IAttachment> GetAttachments(WebDataItem attachItem)
	{
		List<IAttachment> list = new List<IAttachment>();
		if (attachItem == null || attachItem.DataArray == null)
		{
			return list;
		}
		list.AddRange(from a in attachItem.DataArray.Select(GetAttachment)
			where a != null
			select a);
		return list;
	}

	protected virtual IAttachment GetAttachment(WebData data)
	{
		IAttachment attachment = InterfaceActivator.Create<IAttachment>();
		string value = data.FindItem("Uid").Value;
		attachment.File = BinaryFileDescriptor.Download(Guid.Parse(value));
		attachment.CreationAuthor = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		attachment.CreationDate = DateTime.Now;
		return attachment;
	}
}

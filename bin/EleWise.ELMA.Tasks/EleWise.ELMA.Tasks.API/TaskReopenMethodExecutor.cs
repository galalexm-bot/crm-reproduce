using System;
using System.Collections.Generic;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.API.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.API;

public class TaskReopenMethodExecutor : TaskAddCommentMethodExecutor
{
	public new const string MethodName = "Reopen";

	private static TaskWorkflowActions TaskWorkflowActions => Locator.GetServiceNotNull<TaskWorkflowActions>();

	private static IAuthenticationService AuthenticationService => Locator.GetServiceNotNull<IAuthenticationService>();

	public new static string MethodDescription => SR.T("Переоткрыть задачу (поручение)");

	public new static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Task").Descriptor(TaskItemDescription);
	}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Comment").Descriptor(delegate(TypeSerializationDescriptorBuilder cb)
		{
			cb.Item(delegate(TypeSerializationItemDescriptorBuilder ci)
			{
				ci.Name("Text").Descriptor(SR.T("Текст комментария (String)"));
			});
			cb.Item(delegate(TypeSerializationItemDescriptorBuilder ci)
			{
				ci.Name("Attachments").Descriptor(delegate(TypeSerializationDescriptorBuilder cia)
				{
					cia.IsArray().Item(delegate(TypeSerializationItemDescriptorBuilder ciai)
					{
						ciai.Name("Uid").Descriptor(SR.T("Идентификатор файла BinaryFile (Guid)"));
					});
				});
			});
		});
	}).Descriptor;

	public static string TaskItemDescription => SR.T("Задача ({0}). В качестве данных можно передать значения полей в формате метода Load", InterfaceActivator.TypeOf<ITask>());

	public new static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
	}).Descriptor;

	public TaskReopenMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}

	protected override WebData GetResult()
	{
		return WebData.CreateFromObject(new
		{
			Result = true
		});
	}

	protected override WebData GetError()
	{
		return WebData.CreateFromObject(new
		{
			Result = false
		});
	}

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	protected override WebData ExecuteInternal()
	{
		if (Parameters == null || Parameters.Items == null)
		{
			return GetError();
		}
		WebDataItem webDataItem = Parameters.FindItem("Task");
		if (webDataItem == null || webDataItem.Data == null)
		{
			return GetError();
		}
		ITask task = CreateTask(webDataItem.Data);
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		foreach (ICommentProvider item in Locator.GetServiceNotNull<IEnumerable<ICommentProvider>>())
		{
			item.Process(commentActionModel, Parameters);
		}
		BindAdditionalData(Parameters, commentActionModel, task);
		DoReopenTaskAction(task, commentActionModel);
		return GetResult();
	}

	protected static ITask CreateTask(WebData webData)
	{
		if (webData == null)
		{
			return null;
		}
		if (webData.FindItem("Id") == null)
		{
			throw new InvalidOperationException(SR.T("Невозможно переоткрыть задачу, т.к. не задан идентификатор задачи"));
		}
		return new EntityJsonSerializer().ConvertFromSerializable<ITask>(webData.ToDictionary());
	}

	private static void DoReopenTaskAction(ITask task, ICommentActionModel actionModel)
	{
		if (task.IsNew())
		{
			throw new InvalidOperationException(SR.T("Невозможно переоткрыть задачу, т.к. не задан идентификатор или задачи с заданным идентификатором не существует"));
		}
		if (!TaskWorkflowActions.IsAvailableControlledAction(task, AuthenticationService.GetCurrentUser<IUser>()))
		{
			throw new InvalidOperationException(SR.T("Текущий пользователь не имеет доступа для переоткрытия этой задачи"));
		}
		using IUnitOfWork unitOfWork = TaskAddCommentMethodExecutor.UnitOfWorkManager.Create(string.Empty, transactional: true);
		try
		{
			task.Status = TaskBaseStatus.NewOrder;
			task.Save();
			TaskAddCommentMethodExecutor.DoAddCommentAction(actionModel, task, TaskActions.ReopenGuid);
		}
		catch (Exception)
		{
			unitOfWork.Rollback();
			throw;
		}
		unitOfWork.Commit();
	}
}

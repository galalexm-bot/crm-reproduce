using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.API;

public class TaskCreateMethodExecutor : PublicServiceMethodExecutor
{
	public const string MethodName = "Create";

	public static string MethodDescription => SR.T("Создать новую задачу (поручение)");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Description(TaskItemDescription).Descriptor;

	public static string TaskItemDescription => SR.T("Задача ({0}). В качестве данных можно передать значения полей в формате метода Load", InterfaceActivator.TypeOf<ITask>());

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
	}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
	{
		b.Name("Id").Descriptor(SR.T("Идентификатор созданной задачи (Int64)"));
	}).Descriptor;

	protected static IUnitOfWorkManager UnitOfWorkManager => Locator.GetServiceNotNull<IUnitOfWorkManager>();

	public TaskCreateMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}

	protected virtual WebData GetResult(long id)
	{
		return WebData.CreateFromObject(new
		{
			Result = true,
			Id = id
		});
	}

	protected virtual WebData GetError()
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

	protected virtual WebData ExecuteInternal()
	{
		if (Parameters == null || Parameters.Items == null)
		{
			return GetError();
		}
		ITask task = CreateTask(Parameters);
		if (task == null)
		{
			return GetError();
		}
		DoCreateTaskAction(task);
		return GetResult(task.Id);
	}

	public static ITask CreateTask(WebData webData)
	{
		if (webData == null)
		{
			return null;
		}
		return new EntityJsonSerializer().ConvertFromSerializable<ITask>(webData.ToDictionary());
	}

	private static void DoCreateTaskAction(ITask task)
	{
		if (!task.IsNew())
		{
			throw new InvalidOperationException(SR.T("Невозможно создать задачу, т.к. задан идентификатор"));
		}
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		try
		{
			CreateApprovalTask(task, AuthenticationService.GetCurrentUser<IUser>())?.Save();
			task.Save();
			if (task.ParentTask != null)
			{
				TaskBaseManager.Instance.RaiseCreateSubTaskActionExecute(task);
			}
			TaskManager.Instance.UpdatePeriodTask(task);
		}
		catch (Exception)
		{
			unitOfWork.Rollback();
			throw;
		}
		unitOfWork.Commit();
	}

	private static IApprovalTask CreateApprovalTask(ITask task, IUser author)
	{
		if (task.Harmonizator != null && !((IEnumerable<ITaskBase>)task.ChildTasks).Any((ITaskBase t) => t is IApprovalTask && ((IApprovalTask)t).ApprovalStatus == ApprovalStatus.None))
		{
			IApprovalTask @new = new InstanceOf<IApprovalTask>().New;
			@new.ParentStatus = task.Status;
			@new.ParentTask = task;
			@new.Executor = task.Harmonizator;
			@new.Status = TaskBaseStatus.NewOrder;
			@new.Subject = task.Subject;
			@new.StartDate = task.StartDate;
			@new.EndDate = task.EndDate;
			@new.CreationAuthor = author;
			@new.CreationDate = DateTime.Now;
			@new.Priority = task.Priority;
			@new.Attachments = task.Attachments;
			task.Status = TaskBaseStatus.OnApproval;
			return @new;
		}
		return null;
	}
}

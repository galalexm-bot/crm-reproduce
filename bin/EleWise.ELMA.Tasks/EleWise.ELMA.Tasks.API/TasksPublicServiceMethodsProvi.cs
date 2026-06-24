using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Calendar.API;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.API;

[Component]
public class TasksPublicServiceMethodsProvider : IPublicServiceMethodsProvider
{
	internal class TaskControlCompleteMethodExecutor : TaskAddCommentMethodExecutor
	{
		internal new const string MethodName = "ControlComplete";

		public static string Description => SR.T("Контроль завершен, задача выполнена");

		public TaskControlCompleteMethodExecutor(WebData parameters)
			: base(parameters)
		{
		}

		public override void DoTaskAction(ICommentActionModel actionModel, ITaskBase taskBase)
		{
			if (!(taskBase is ITask task))
			{
				throw new InvalidOperationException(SR.T("Невозможно при помощи данного метода отметить выполненной задачу типа {0}. Задача должна быть наследником типа {1}", taskBase.GetType().GetTypeWithoutProxy(), typeof(ITask)));
			}
			DoControlCompleteAction(actionModel, task);
		}

		private static void DoControlCompleteAction(ICommentActionModel actionModel, ITaskBase task)
		{
			using IUnitOfWork unitOfWork = TaskAddCommentMethodExecutor.UnitOfWorkManager.Create(string.Empty, transactional: true);
			try
			{
				TaskManager.Instance.InvokeAction((TaskManager m) => m.DoControlComplete(task.Id, actionModel), task.GetType());
			}
			catch (Exception)
			{
				unitOfWork.Rollback();
				throw;
			}
			unitOfWork.Commit();
		}
	}

	internal class TaskStartWorkMethodExecutor : TaskAddCommentMethodExecutor
	{
		internal new const string MethodName = "StartWork";

		public static string Description => SR.T("Начать работу над задачей");

		public TaskStartWorkMethodExecutor(WebData parameters)
			: base(parameters)
		{
		}

		public override void DoTaskAction(ICommentActionModel actionModel, ITaskBase taskBase)
		{
			DoStartWorkAction(actionModel, taskBase);
		}

		private static void DoStartWorkAction(ICommentActionModel actionModel, ITaskBase task)
		{
			using IUnitOfWork unitOfWork = TaskAddCommentMethodExecutor.UnitOfWorkManager.Create(string.Empty, transactional: true);
			try
			{
				TaskBaseManager.Instance.InvokeAction((TaskBaseManager m) => m.StartWork(task.Id, alertCoexecuters: true, actionModel), task.GetType());
			}
			catch (Exception)
			{
				unitOfWork.Rollback();
				throw;
			}
			unitOfWork.Commit();
		}
	}

	internal class TaskCloseMethodExecutor : TaskAddCommentMethodExecutor
	{
		internal new const string MethodName = "Close";

		public static string Description => SR.T("Закрыть задачу");

		public TaskCloseMethodExecutor(WebData parameters)
			: base(parameters)
		{
		}

		public override void DoTaskAction(ICommentActionModel actionModel, ITaskBase taskBase)
		{
			if (!(taskBase is ITask task))
			{
				throw new InvalidOperationException(SR.T("Невозможно при помощи данного метода закрыть задачу типа {0}. Задача должна быть наследником типа {1}", taskBase.GetType().GetTypeWithoutProxy(), typeof(ITask)));
			}
			DoCloseAction(actionModel, task);
		}

		private static void DoCloseAction(ICommentActionModel actionModel, ITask task)
		{
			using IUnitOfWork unitOfWork = TaskAddCommentMethodExecutor.UnitOfWorkManager.Create(string.Empty, transactional: true);
			try
			{
				TaskManager.Instance.InvokeAction((TaskManager m) => m.Close(task.Id, alert: true, actionModel), task.GetType());
			}
			catch (Exception)
			{
				unitOfWork.Rollback();
				throw;
			}
			unitOfWork.Commit();
		}
	}

	internal class TaskCompleteMethodExecutor : TaskAddCommentMethodExecutor
	{
		internal new const string MethodName = "Complete";

		public static string Description => SR.T("Отметить задачу как выполненную");

		public TaskCompleteMethodExecutor(WebData parameters)
			: base(parameters)
		{
		}

		public override void DoTaskAction(ICommentActionModel actionModel, ITaskBase taskBase)
		{
			if (!(taskBase is ITask task))
			{
				throw new InvalidOperationException(SR.T("Невозможно при помощи данного метода отметить выполненной задачу типа {0}. Задача должна быть наследником типа {1}", taskBase.GetType().GetTypeWithoutProxy(), typeof(ITask)));
			}
			DoCompleteAction(actionModel, task);
		}

		private static void DoCompleteAction(ICommentActionModel actionModel, ITask task)
		{
			using IUnitOfWork unitOfWork = TaskAddCommentMethodExecutor.UnitOfWorkManager.Create(string.Empty, transactional: true);
			try
			{
				TaskManager.Instance.InvokeAction((TaskManager m) => m.DoCompleted(task.Id, alertCoexecuters: true, actionModel), task.GetType());
			}
			catch (Exception)
			{
				unitOfWork.Rollback();
				throw;
			}
			unitOfWork.Commit();
		}
	}

	internal class TaskIncompleteMethodExecutor : TaskAddCommentMethodExecutor
	{
		internal new const string MethodName = "Incomplete";

		public static string Description => SR.T("Отметить, что задачу невозможно выполнить");

		public TaskIncompleteMethodExecutor(WebData parameters)
			: base(parameters)
		{
		}

		public override void DoTaskAction(ICommentActionModel actionModel, ITaskBase taskBase)
		{
			if (!(taskBase is ITask task))
			{
				throw new InvalidOperationException(SR.T("Невозможо при помощи данного метода отметить невыполненной задачу типа {0}. Задача должна быть наследником типа {1}", taskBase.GetType().GetTypeWithoutProxy(), typeof(ITask)));
			}
			DoIncompleteAction(actionModel, task);
		}

		private static void DoIncompleteAction(ICommentActionModel actionModel, ITask task)
		{
			using IUnitOfWork unitOfWork = TaskAddCommentMethodExecutor.UnitOfWorkManager.Create(string.Empty, transactional: true);
			try
			{
				TaskManager.Instance.InvokeAction((TaskManager m) => m.DoIncompleted(task.Id, alertCoexecuters: true, actionModel), task.GetType());
			}
			catch (Exception)
			{
				unitOfWork.Rollback();
				throw;
			}
			unitOfWork.Commit();
		}
	}

	internal class TaskChangeDateMethodExecutor : TaskRedirectMethodExecutor
	{
		internal new const string MethodName = "ChangeEndDate";

		public new static string Description => SR.T("Перенести срок задачи");

		public new static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("TaskId").Descriptor(SR.T("Идентификатор задачи (Int64)"));
		}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("StartDate").Descriptor(SR.T("Дата начала задачи (DateTime)"));
		}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("StartDateUseTime").Descriptor(SR.T("Использовать ли время для даты начала задачи. Опционально. (Boolean)"));
		})
			.Item(delegate(TypeSerializationItemDescriptorBuilder b)
			{
				b.Name("EndDate").Descriptor(SR.T("Срок завершения задачи (DateTime)"));
			})
			.Item(delegate(TypeSerializationItemDescriptorBuilder b)
			{
				b.Name("EndDateUseTime").Descriptor(SR.T("Использовать ли время для срока завершения задачи. Опционально. (Boolean)"));
			})
			.Descriptor;

		public new static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
		}).Descriptor;

		public TaskChangeDateMethodExecutor(WebData parameters)
			: base(parameters)
		{
		}

		protected override WebData ExecuteInternal()
		{
			if (Parameters == null || Parameters.Items == null)
			{
				return GetError();
			}
			WebDataItem webDataItem = Parameters.FindItem("TaskId");
			if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
			{
				return GetError();
			}
			WebDataItem startDateItem = Parameters.FindItem("StartDate");
			WebDataItem startDateUseTimeItem = Parameters.FindItem("StartDateUseTime");
			WebDataItem endDateItem = Parameters.FindItem("EndDate");
			WebDataItem endDateUseTimeItem = Parameters.FindItem("EndDateUseTime");
			if (!long.TryParse(webDataItem.Value, out var result))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора задачи, должен быть Int64"), 400);
			}
			ITaskBase task = TaskBaseManager.Instance.Load(result).CastAsRealType();
			DateTime startDate = TaskRedirectMethodExecutor.GetStartDate(startDateItem, startDateUseTimeItem, task);
			DateTime endDate = TaskRedirectMethodExecutor.GetEndDate(endDateItem, endDateUseTimeItem, task);
			DoTaskAction(task, startDate, endDate);
			return GetResult();
		}

		protected virtual void DoTaskAction(ITaskBase task, DateTime startDate, DateTime endDate)
		{
			DoChangeEndDateAction(task, startDate, endDate);
		}

		protected static void DoChangeEndDateAction(ITaskBase task, DateTime startDate, DateTime endDate)
		{
			using IUnitOfWork unitOfWork = UnitOfWork.New(string.Empty, transactional: true);
			try
			{
				TaskBaseManager.Instance.InvokeAction((TaskBaseManager m) => m.ChangeDate(task.Id, startDate, endDate), task.GetType());
			}
			catch (Exception)
			{
				unitOfWork.Rollback();
				throw;
			}
			unitOfWork.Commit();
		}
	}

	internal class TaskChangeControlMethodExecutor : TaskRedirectMethodExecutor
	{
		internal new const string MethodName = "ChangeControl";

		public new static string Description => SR.T("Изменить контроль задачи");

		public new static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("TaskId").Descriptor(SR.T("Идентификатор задачи. Обязательно. (Int64)"));
		}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("UnderControl").Descriptor(SR.T("На контроле. Обязательно. (Boolean)"));
		}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("ControlUser").Descriptor(SR.T("Установить нового контролера задачи (Entity:User)"));
		})
			.Item(delegate(TypeSerializationItemDescriptorBuilder b)
			{
				b.Name("ControlType").Descriptor(SR.T("Тип контроля задачи (Enum:TaskControlType)"));
			})
			.Item(delegate(TypeSerializationItemDescriptorBuilder b)
			{
				b.Name("Comment").Descriptor(SR.T("Комментарий. Опционально. (String)"));
			})
			.Descriptor;

		public new static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
		}).Descriptor;

		public TaskChangeControlMethodExecutor(WebData parameters)
			: base(parameters)
		{
		}

		protected override WebData ExecuteInternal()
		{
			if (Parameters == null || Parameters.Items == null)
			{
				return GetError();
			}
			WebDataItem webDataItem = Parameters.FindItem("TaskId");
			if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
			{
				return GetError();
			}
			WebDataItem booleanItem = Parameters.FindItem("UnderControl");
			WebDataItem userWebDataItem = Parameters.FindItem("ControlUser");
			WebDataItem controlTypeItem = Parameters.FindItem("ControlType");
			WebDataItem commentItem = Parameters.FindItem("Comment");
			if (!long.TryParse(webDataItem.Value, out var result))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора задачи, должен быть Int64"), 400);
			}
			ITask task = TaskManager.Instance.Load(result).CastAsRealType();
			bool @bool = TaskRedirectMethodExecutor.GetBool(booleanItem);
			IUser controlUser = TaskRedirectMethodExecutor.GetUser(userWebDataItem) ?? task.ControlUser;
			TaskControlType taskControlType = GetTaskControlType(controlTypeItem, task);
			IComment comment = TaskRedirectMethodExecutor.GetComment(commentItem);
			DoTaskAction(task, @bool, controlUser, taskControlType, comment);
			return GetResult();
		}

		protected static TaskControlType GetTaskControlType(WebDataItem controlTypeItem, ITask currentTask)
		{
			if (controlTypeItem == null || controlTypeItem.Value.IsNullOrWhiteSpace())
			{
				return currentTask.ControlType;
			}
			return (TaskControlType)ModelHelper.GetEnumValue(typeof(TaskControlType), controlTypeItem.Value);
		}

		protected virtual void DoTaskAction(ITask task, bool underControl, IUser controlUser, TaskControlType controlType, IComment comment)
		{
			DoChangeControlAction(task, underControl, controlUser, controlType, comment);
		}

		protected static void DoChangeControlAction(ITask task, bool underControl, IUser controlUser, TaskControlType controlType, IComment comment)
		{
			using IUnitOfWork unitOfWork = UnitOfWork.New(string.Empty, transactional: true);
			try
			{
				TaskManager.Instance.InvokeAction((TaskManager m) => m.ChangeControl(task.Id, underControl, controlUser, controlType, comment), task.GetType());
			}
			catch (Exception)
			{
				unitOfWork.Rollback();
				throw;
			}
			unitOfWork.Commit();
		}
	}

	internal class TaskRedirectMethodExecutor : PublicServiceMethodExecutor
	{
		internal const string MethodName = "Redirect";

		public static string Description => SR.T("Переназначить задачу");

		public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("TaskId").Descriptor(SR.T("Идентификатор задачи (Int64)"));
		}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("StartDate").Descriptor(SR.T("Дата начала задачи (DateTime)"));
		}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("StartDateUseTime").Descriptor(SR.T("Использовать ли время для даты начала задачи. Опционально. (Boolean)"));
		})
			.Item(delegate(TypeSerializationItemDescriptorBuilder b)
			{
				b.Name("EndDate").Descriptor(SR.T("Срок завершения задачи (DateTime)"));
			})
			.Item(delegate(TypeSerializationItemDescriptorBuilder b)
			{
				b.Name("EndDateUseTime").Descriptor(SR.T("Использовать ли время для срока завершения задачи. Опционально. (Boolean)"));
			})
			.Item(delegate(TypeSerializationItemDescriptorBuilder b)
			{
				b.Name("Priority").Descriptor(SR.T("Приоритет задачи ({0})", typeof(TaskPriority)));
			})
			.Item(delegate(TypeSerializationItemDescriptorBuilder b)
			{
				b.Name("ExecutorId").Descriptor(SR.T("Новый исполнитель задачи ({0})", InterfaceActivator.TypeOf<IUser>()));
			})
			.Item(delegate(TypeSerializationItemDescriptorBuilder b)
			{
				b.Name("Comment").Descriptor(SR.T("Текст комментария (String)"));
			})
			.Descriptor;

		public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
		}).Descriptor;

		public TaskRedirectMethodExecutor(WebData parameters)
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
			WebDataItem webDataItem = Parameters.FindItem("TaskId");
			if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
			{
				return GetError();
			}
			WebDataItem webDataItem2 = Parameters.FindItem("ExecutorId");
			if (webDataItem2 == null || string.IsNullOrEmpty(webDataItem2.Value))
			{
				return GetError();
			}
			WebDataItem commentItem = Parameters.FindItem("Comment");
			WebDataItem startDateItem = Parameters.FindItem("StartDate");
			WebDataItem startDateUseTimeItem = Parameters.FindItem("StartDateUseTime");
			WebDataItem endDateItem = Parameters.FindItem("EndDate");
			WebDataItem endDateUseTimeItem = Parameters.FindItem("EndDateUseTime");
			WebDataItem priorityItem = Parameters.FindItem("Priority");
			if (!long.TryParse(webDataItem.Value, out var result))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора задачи, должен быть Int64"), 400);
			}
			if (!long.TryParse(webDataItem2.Value, out var result2))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора исполнителя, должен быть Int64"), 400);
			}
			ITaskBase taskBase = TaskBaseManager.Instance.Load(result).CastAsRealType();
			IUser user = UserManager.Instance.Load(result2);
			if (user.Id == taskBase.Executor.Id)
			{
				throw PublicServiceException.CreateWebFault(SR.T("Новый исполнитель должен отличаться от текущего исполнителя задачи"), 400);
			}
			DateTime startDate = GetStartDate(startDateItem, startDateUseTimeItem, taskBase);
			DateTime endDate = GetEndDate(endDateItem, endDateUseTimeItem, taskBase);
			TaskPriority taskPriority = GetTaskPriority(priorityItem, taskBase);
			IComment comment = GetComment(commentItem);
			DoTaskAction(taskBase, startDate, endDate, user, taskPriority, comment);
			return GetResult();
		}

		protected virtual void DoTaskAction(ITaskBase task, DateTime startDate, DateTime endDate, IUser executor, TaskPriority priority, IComment comment)
		{
			DoRedirectAction(task, startDate, endDate, executor, priority, comment);
		}

		protected static void DoRedirectAction(ITaskBase task, DateTime startDate, DateTime endDate, IUser executor, TaskPriority priority, IComment comment)
		{
			using IUnitOfWork unitOfWork = UnitOfWork.New(string.Empty, transactional: true);
			try
			{
				IReAssignActionModel reAssignActionModel = InterfaceActivator.Create<IReAssignActionModel>();
				reAssignActionModel.TaskId = task.Id;
				reAssignActionModel.StartDate = startDate;
				reAssignActionModel.EndDate = endDate;
				reAssignActionModel.Executor = executor;
				reAssignActionModel.Priority = priority;
				reAssignActionModel.Comment = comment;
				TaskBaseManager.Instance.InvokeAction((TaskBaseManager m) => m.ReAssign(reAssignActionModel), task.GetType());
			}
			catch (Exception)
			{
				unitOfWork.Rollback();
				throw;
			}
			unitOfWork.Commit();
		}

		protected static TaskPriority GetTaskPriority(WebDataItem priorityItem, ITaskBase currentTask)
		{
			if (priorityItem == null || priorityItem.Value.IsNullOrWhiteSpace())
			{
				return currentTask.Priority;
			}
			return (TaskPriority)ModelHelper.GetEnumValue(typeof(TaskPriority), priorityItem.Value);
		}

		protected static DateTime GetStartDate(WebDataItem startDateItem, WebDataItem startDateUseTimeItem, ITaskBase task)
		{
			bool @bool = GetBool(startDateUseTimeItem);
			DateTime? date = GetDate(startDateItem);
			if (!date.HasValue)
			{
				if (!task.StartDate.HasValue)
				{
					return DateTime.MinValue;
				}
				return task.StartDate.Value;
			}
			return date.Value.NormalizeStartDate(@bool);
		}

		protected static DateTime GetEndDate(WebDataItem endDateItem, WebDataItem endDateUseTimeItem, ITaskBase task)
		{
			bool @bool = GetBool(endDateUseTimeItem);
			DateTime? date = GetDate(endDateItem);
			if (!date.HasValue)
			{
				if (!task.EndDate.HasValue)
				{
					return DateTime.MinValue;
				}
				return task.EndDate.Value;
			}
			return date.Value.NormalizeEndDate(@bool);
		}

		protected static DateTime? GetDate(WebDataItem dateTimeItem)
		{
			if (dateTimeItem == null || dateTimeItem.Value.IsNullOrWhiteSpace())
			{
				return null;
			}
			return Locator.GetServiceNotNull<DateTimeDescriptor>().DeserializeSimple(dateTimeItem.Value);
		}

		protected static bool GetBool(WebDataItem booleanItem)
		{
			if (booleanItem == null || booleanItem.Value.IsNullOrWhiteSpace())
			{
				return false;
			}
			return Locator.GetServiceNotNull<BoolDescriptor>().DeserializeSimple(booleanItem.Value);
		}

		protected static IComment GetComment(WebDataItem commentItem)
		{
			if (commentItem == null || commentItem.Value.IsNullOrWhiteSpace())
			{
				return null;
			}
			IComment comment = CommentManager.Instance.Create();
			comment.Text = commentItem.Value;
			return comment;
		}

		protected static IUser GetUser(WebDataItem userWebDataItem)
		{
			if (userWebDataItem == null || userWebDataItem.Value.IsNullOrWhiteSpace())
			{
				return null;
			}
			long id = Locator.GetServiceNotNull<Int64Descriptor>().DeserializeSimple(userWebDataItem.Value);
			return UserManager.Instance.Load(id);
		}

		protected virtual WebData GetResult()
		{
			return GetSimpleResultWebData(resValue: true);
		}

		protected virtual WebData GetError()
		{
			return GetSimpleResultWebData(resValue: false);
		}
	}

	internal class TaskMarkReadMethodExecutor : PublicServiceMethodExecutor
	{
		internal const string MethodName = "MarkRead";

		public static string Description => SR.T("Отметить задачу как прочитанную исполнителем");

		public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("TaskId").Descriptor(SR.T("Идентификатор задачи (Int64)"));
		}).Descriptor;

		public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
		}).Descriptor;

		public TaskMarkReadMethodExecutor(WebData parameters)
			: base(parameters)
		{
		}

		public override WebData Execute()
		{
			return ExecuteInternal();
		}

		protected WebData ExecuteInternal()
		{
			if (Parameters == null || Parameters.Items == null)
			{
				return GetError();
			}
			WebDataItem webDataItem = Parameters.FindItem("TaskId");
			if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
			{
				return GetError();
			}
			if (!long.TryParse(webDataItem.Value, out var result))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора задачи, должен быть Int64"), 400);
			}
			ITaskBase taskBase = TaskBaseManager.Instance.Load(result).CastAsRealType();
			DoTaskAction(taskBase);
			return GetResult();
		}

		public void DoTaskAction(ITaskBase taskBase)
		{
			DoMarkReadAction(taskBase);
		}

		private static void DoMarkReadAction(ITaskBase task)
		{
			using IUnitOfWork unitOfWork = UnitOfWork.New(string.Empty, transactional: true);
			try
			{
				TaskBaseManager.Instance.InvokeAction((TaskBaseManager m) => m.MarkRead(task.Id), task.GetType());
			}
			catch (Exception)
			{
				unitOfWork.Rollback();
				throw;
			}
			unitOfWork.Commit();
		}

		protected virtual WebData GetResult()
		{
			return GetSimpleResultWebData(resValue: true);
		}

		protected virtual WebData GetError()
		{
			return GetSimpleResultWebData(resValue: false);
		}
	}

	internal class TaskConfirmApprovalMethodExecutor : TaskAddCommentMethodExecutor
	{
		internal new const string MethodName = "ConfirmApproval";

		public static string Description => SR.T("Согласовать задачу");

		public TaskConfirmApprovalMethodExecutor(WebData parameters)
			: base(parameters)
		{
		}

		public override void DoTaskAction(ICommentActionModel actionModel, ITaskBase taskBase)
		{
			if (!(taskBase is IApprovalTask approvalTask))
			{
				throw new InvalidOperationException(SR.T("Невозможно при помощи данного метода выполнить задачу типа {0}. Задача должна быть наследником типа {1}", taskBase.GetType().GetTypeWithoutProxy(), typeof(IApprovalTask)));
			}
			if (!(approvalTask.ParentTask.CastAsRealType() is ITask parentTask))
			{
				throw new InvalidOperationException(SR.T("Невозможно при помощи данного метода согласовать задачи типа {0}. Задача должна быть наследником типа {1}", taskBase.GetType().GetTypeWithoutProxy(), typeof(ITask)));
			}
			DoApproveAction(actionModel, approvalTask, parentTask);
		}

		private static void DoApproveAction(ICommentActionModel actionModel, IApprovalTask task, ITask parentTask)
		{
			using IUnitOfWork unitOfWork = TaskAddCommentMethodExecutor.UnitOfWorkManager.Create(string.Empty, transactional: true);
			try
			{
				TaskManager.Instance.InvokeAction((TaskManager m) => m.DoConfirmApprove(task.Id, actionModel), parentTask.GetType());
			}
			catch (Exception)
			{
				unitOfWork.Rollback();
				throw;
			}
			unitOfWork.Commit();
		}
	}

	internal class TaskRefuseApprovalMethodExecutor : TaskAddCommentMethodExecutor
	{
		internal new const string MethodName = "RefuseApproval";

		public static string Description => SR.T("Отказать в согласовании задачи");

		public TaskRefuseApprovalMethodExecutor(WebData parameters)
			: base(parameters)
		{
		}

		public override void DoTaskAction(ICommentActionModel actionModel, ITaskBase taskBase)
		{
			if (!(taskBase is IApprovalTask approvalTask))
			{
				throw new InvalidOperationException(SR.T("Невозможно при помощи данного метода выполнить задачу типа {0}. Задача должна быть наследником типа {1}", taskBase.GetType().GetTypeWithoutProxy(), typeof(IApprovalTask)));
			}
			if (!(approvalTask.ParentTask.CastAsRealType() is ITask parentTask))
			{
				throw new InvalidOperationException(SR.T("Невозможно при помощи данного метода отказать в согласовании задачи типа {0}. Задача должна быть наследником типа {1}", taskBase.GetType().GetTypeWithoutProxy(), typeof(ITask)));
			}
			DoRefuseAction(actionModel, approvalTask, parentTask);
		}

		private static void DoRefuseAction(ICommentActionModel actionModel, IApprovalTask task, ITask parentTask)
		{
			using IUnitOfWork unitOfWork = TaskAddCommentMethodExecutor.UnitOfWorkManager.Create(string.Empty, transactional: true);
			try
			{
				TaskManager.Instance.InvokeAction((TaskManager m) => m.DoRefuseApprove(task.Id, actionModel), parentTask.GetType());
			}
			catch (Exception)
			{
				unitOfWork.Rollback();
				throw;
			}
			unitOfWork.Commit();
		}
	}

	internal class TaskApprovementStatusMethodExecutor : PublicServiceMethodExecutor
	{
		internal const string MethodName = "ApprovementStatus";

		public static string Description => SR.T("Получить статус согласования задачи");

		public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("TaskId").Descriptor(SR.T("Идентификатор задачи (Int64)"));
		}).Descriptor;

		public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("Result").Descriptor(SR.T("Результат выполнения. True, если выполнение завершено успешно."));
		}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("Task").Descriptor(SR.T("Задача согласования ({0})", InterfaceActivator.TypeOf<IApprovalTask>()));
		}).Item(delegate(TypeSerializationItemDescriptorBuilder b)
		{
			b.Name("Comment").Descriptor(SR.T("Комментарий согласования (String)"));
		})
			.Descriptor;

		public TaskApprovementStatusMethodExecutor(WebData parameters)
			: base(parameters)
		{
		}

		public override WebData Execute()
		{
			return ExecuteInternal();
		}

		protected WebData ExecuteInternal()
		{
			if (Parameters == null || Parameters.Items == null)
			{
				return GetError();
			}
			WebDataItem webDataItem = Parameters.FindItem("TaskId");
			if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
			{
				return GetError();
			}
			if (!long.TryParse(webDataItem.Value, out var result))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора задачи, должен быть Int64"), 400);
			}
			ITaskBase taskBase = TaskBaseManager.Instance.Load(result).CastAsRealType();
			IApprovalTask approvalTask = DoTaskAction(taskBase);
			if (approvalTask == null)
			{
				return GetError();
			}
			return GetResult(approvalTask);
		}

		internal IApprovalTask DoTaskAction(ITaskBase taskBase)
		{
			if (taskBase == null || taskBase.ChildTasks == null || ((ICollection<ITaskBase>)taskBase.ChildTasks).Count == 0)
			{
				return null;
			}
			return ((IEnumerable<ITaskBase>)taskBase.ChildTasks).LastOrDefault((ITaskBase t) => t is IApprovalTask) as IApprovalTask;
		}

		internal WebData GetResult(IApprovalTask task)
		{
			WebData webData = WebData.CreateFromObject(new
			{
				Result = true,
				Comment = ((IEnumerable<IComment>)task.Comments).LastOrDefault()?.Text
			});
			List<WebDataItem> list = webData.Items.ToList();
			list.Add(new WebDataItem
			{
				Name = "Task",
				Data = WebData.CreateFromEntity(task)
			});
			webData.Items = list.ToArray();
			return webData;
		}

		internal WebData GetError()
		{
			return GetSimpleResultWebData(resValue: false);
		}
	}

	public IEnumerable<IPublicServiceMethod> GetMethods()
	{
		return new IPublicServiceMethod[18]
		{
			new PublicServiceMethod(TasksPublicService.UID, "Create", TaskCreateMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new TaskCreateMethodExecutor(data))
			{
				ParametersDescriptor = TaskCreateMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskCreateMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "Reopen", TaskReopenMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new TaskReopenMethodExecutor(data))
			{
				ParametersDescriptor = TaskReopenMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskReopenMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "AddComment", TaskAddCommentMethodExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new TaskAddCommentMethodExecutor(data))
			{
				ParametersDescriptor = TaskAddCommentMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskAddCommentMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "Complete", TaskCompleteMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskCompleteMethodExecutor(data))
			{
				ParametersDescriptor = TaskAddCommentMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskAddCommentMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "Incomplete", TaskIncompleteMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskIncompleteMethodExecutor(data))
			{
				ParametersDescriptor = TaskAddCommentMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskAddCommentMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "StartWork", TaskStartWorkMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskStartWorkMethodExecutor(data))
			{
				ParametersDescriptor = TaskAddCommentMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskAddCommentMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "MarkRead", TaskMarkReadMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskMarkReadMethodExecutor(data))
			{
				ParametersDescriptor = TaskMarkReadMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskMarkReadMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "Redirect", TaskRedirectMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskRedirectMethodExecutor(data))
			{
				ParametersDescriptor = TaskRedirectMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskRedirectMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "ChangeEndDate", TaskChangeDateMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskChangeDateMethodExecutor(data))
			{
				ParametersDescriptor = TaskChangeDateMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskChangeDateMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "ControlComplete", TaskControlCompleteMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskControlCompleteMethodExecutor(data))
			{
				ParametersDescriptor = TaskAddCommentMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskAddCommentMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "ChangeControl", TaskChangeControlMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskChangeControlMethodExecutor(data))
			{
				ParametersDescriptor = TaskChangeControlMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskChangeControlMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "Close", TaskCloseMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskCloseMethodExecutor(data))
			{
				ParametersDescriptor = TaskAddCommentMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskAddCommentMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "AddQuestion", TaskAddQuestionMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskAddQuestionMethodExecutor(data))
			{
				ParametersDescriptor = TaskAddQuestionMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskAddQuestionMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "AnswerQuestion", TaskAnswerQuestionMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskAnswerQuestionMethodExecutor(data))
			{
				ParametersDescriptor = TaskAnswerQuestionMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskAnswerQuestionMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "ConfirmApproval", TaskConfirmApprovalMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskConfirmApprovalMethodExecutor(data))
			{
				ParametersDescriptor = TaskAddCommentMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskAddCommentMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "RefuseApproval", TaskRefuseApprovalMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskRefuseApprovalMethodExecutor(data))
			{
				ParametersDescriptor = TaskAddCommentMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskAddCommentMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(TasksPublicService.UID, "ApprovementStatus", TaskApprovementStatusMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new TaskApprovementStatusMethodExecutor(data))
			{
				ParametersDescriptor = TaskApprovementStatusMethodExecutor.ParametersDescriptor,
				ResultDescriptor = TaskApprovementStatusMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(CalendarPublicService.UID, "AddQuestion", CalendarEventAddQuestionExecutor.Description, new Version(1, 0, 0), (WebData data) => new CalendarEventAddQuestionExecutor(data))
			{
				ParametersDescriptor = CalendarEventAddQuestionExecutor.ParametersDescriptor,
				ResultDescriptor = CalendarEventAddQuestionExecutor.ResultDescriptor
			}
		};
	}

	internal static WebData GetSimpleResultWebData(bool resValue)
	{
		return WebData.CreateFromObject(new
		{
			Result = resValue
		});
	}
}

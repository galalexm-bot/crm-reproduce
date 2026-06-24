using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.DynamicAPI;

[Component(Order = 13)]
internal class PublicApiTasksNodeEntityProvider : IPublicApiNodeProvider
{
	public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
	{
		PublicApiPropertyClassNode taskBaseNode = new PublicApiPropertyClassNode("PublicAPI.Portal", "TaskBasePortalApi", typeof(ITaskBase))
		{
			Description = SR.T("Базовый класс задачи"),
			Remarks = SR.T("Раздел содержащий методы для работы с задачами(поручениями)"),
			Code = SR.T("\r\n<para>\r\nСоздадим задачу, с которой будем работать\r\n<code>\r\n<![CDATA[\r\nvar myTask = PublicAPI.Portal.TaskBase.Task.Create();\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nПрежде чем работать с переменной myTask, нужно заполнить обязательные поля этой переменной\r\n<code>\r\n<![CDATA[\r\n//дата создания задачи\r\nmyTask.CreationDate = DateTime.Now;\r\n//автор создания задачи\r\nmyTask.CreationAuthor = PublicAPI.Security.User.GerCurrentUser();\r\n//тема задачи\r\nmyTask.Subject = \"Тема задачи\";\r\n//исполнитель задачи\r\nmyTask.Executor = context.UserExecutor;\r\n//дата начала и завершения задачи\r\nmyTask.StartDate = DateTime.Now;\r\nmyTask.EndDate = DateTime.Now.AddWeeks(3);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nНе забываем сохранить объект в базу для его корректной работы\r\n<code>\r\n<![CDATA[\r\nmyTask.Save();\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nУстановим трудозатраты по задаче\r\n<code>\r\n<![CDATA[\r\nPublicAPI.Portal.TaskBase.SetFactWorkLogHours(myTask.Id, 4, DateTime.Now, \"Описание работы за 4 часа\");\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nПереназначим задачу на другого пользователя\r\n<code>\r\n<![CDATA[\r\nPublicAPI.Portal.TaskBase.ReAssign(myTask.Id, context.UserNewExecutor, DateTime.Now.AddDays(4), \"Задача переназначена\");\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nИзменим срок завершения задачи\r\n<code>\r\n<![CDATA[\r\nPublicAPI.Portal.TaskBase.SetTaskEndDate(myTask.Id, DateTime.Now.AddDays(5));\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nЗавершим задачу\r\n<code>\r\n<![CDATA[\r\n//заполняем модель завершения задачи\r\nvar model = new CompleteTaskModel();\r\nmodel.alertCoexecuters = true;\r\n//заполняем поле \"Дата начала\"\r\nmodel.startDate = DateTime.Now;\r\n//заполняем поле \"Трудозатраты\" (в минутах)\r\nmodel.worklogMinutes = 360;\r\n//завершаем задачу\r\nPublicAPI.Portal.TaskBase.CompleteTask(myTask.Id, model);\r\n]]>\r\n</code>\r\n</para>\r\n")
		};
		yield return taskBaseNode;
		PublicApiPropertyClassNode taskNode = new PublicApiPropertyClassNode(taskBaseNode.Path, "TaskPortalApi", typeof(ITask))
		{
			Description = SR.T("Задача"),
			Remarks = SR.T("Раздел содержащий методы для работы с задачами(поручениями)")
		};
		yield return taskNode;
		foreach (IPublicApiNode item in PublicApiNodeEntityProvider.Members<ITaskBase, TaskBaseManager>(taskBaseNode.Path))
		{
			yield return item;
		}
		foreach (IPublicApiNode item2 in PublicApiNodeEntityProvider.Members<ITask, TaskManager>(taskNode.Path))
		{
			yield return item2;
		}
	}
}

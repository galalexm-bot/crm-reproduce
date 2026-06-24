using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.BPM.Web.Tasks.Menu;

[Component]
public class TasksMenuItems : IMenuItemsProvider
{
	public const string tasks = "left_tasks_menu";

	public const string tasksTree = "tasks-threads-tree";

	public const string incomingThread = "incomingThread";

	public const string outgoingThread = "outgoingThread";

	public const string executionControlThread = "executionControlThread";

	public const string currentControlThread = "currentControlThread";

	public const string searchThread = "searchThread";

	public const string periodMemu = "period-menu";

	public const string periodCurrent = "period-Current";

	public const string periodClosed = "period-Closed";

	public const string mydepartmentTree = "mydepartment-tree";

	public const string mydepartmentMenu = "mydepartment-menu";

	public const string mydepartmentTasksFor = "my_department_tasks_for";

	public const string mydepartmentTasksFrom = "my_department_tasks_from";

	public const string mydepartmentTasksClosed = "closed_tasks_department";

	public const string departmentMenu = "department-menu";

	public const string worklogMenu = "worklog-menu";

	public const string workLogReports = "workLogReport-menu";

	public const string workLogApprove = "workLogApprove-menu";

	public const string TASKS_CREATE = "tasks-create";

	public const string coexecutionTread = "CoexecutionTread";

	public const string TASKS_ADMIN_MENU = "tasks-admin-menu";

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public void Items(MenuItemFactory factory)
	{
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("create");
		});
		factory.Action("tasks-create").Order(20).Name(SR.M("Создать задачу"));
		factory.Action("EleWise.ELMA.BPM.Web.Tasks.Controllers.WorkLogReportController.Create-Root").Order(90).Name(SR.M("Отчёт о трудозатратах"))
			.Container("create");
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("start");
		});
		factory.Section(SR.M("Задачи"), "start-tasks-menu").Order(100).Color("green")
			.Image16("#task.svg");
		factory.Action(new ActionRoute("Incoming", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Мои задачи")).Parent("start-tasks-menu")
			.Order(110)
			.Image16("#task.svg");
		factory.Action(new ActionRoute("Outgoing", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Задачи от меня")).Parent("start-tasks-menu")
			.Order(120)
			.Image16("#arrow_outline_next.svg");
		factory.Action("executionControl").Name(SR.M("Контроль")).Parent("start-tasks-menu")
			.Order(130)
			.Image16("#control.svg");
		factory.Section(SR.M("Трудозатраты"), "start-worklog-menu").Order(200).Color("green")
			.Image16("#clock.svg");
		factory.Action(new ActionRoute("Index", "WorkLogApproveReport", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Согласование")).Parent("start-worklog-menu")
			.Order(220)
			.Image16("#complete_outline.svg");
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("top");
		});
		factory.Action("tasks-create").Parent("create").Order(10)
			.Image24("#add.svg")
			.Name(SR.M("Задача"))
			.Container("top");
		factory.Action(new ActionRoute("CreatePeriod", "Task", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Parent("create").Order(30)
			.Image24("#add.svg")
			.Name(SR.M("Периодическая задача"))
			.Container("top");
		factory.Action(new ActionRoute("Create", "WorkLogReport", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Parent("create").Order(110)
			.Image24("#add.svg")
			.Name(SR.M("Отчёт о трудозатратах"))
			.Container("top");
		factory.Section(SR.M("Задачи"), "top_tasks_menu").Order(20).Container("top");
		factory.Section(SR.M("Мой отдел"), "top_closed_tasks_department").Parent("top_closed_tasks").Order(20)
			.Container("top");
		factory.Action("forDepartmentClosed").Parent("top_closed_tasks_department").Code("closed_tasks_department_for")
			.Name(SR.M("Задачи отдела"))
			.Container("top");
		factory.Action("fromDepartmentClosed").Parent("top_closed_tasks_department").Code("closed_tasks_department_from")
			.Name(SR.M("Задачи от отдела"))
			.Container("top");
		factory.Section(SR.M("Периодические задачи"), "period_tasks").Parent("top_tasks_menu").Order(50)
			.Container("top");
		factory.Action(new ActionRoute("PeriodCurrent", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Parent("period_tasks").Code("period_tasks_PeriodCurrent")
			.Name(SR.M("Текущие"))
			.Container("top");
		factory.Action(new ActionRoute("PeriodClosed", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Parent("period_tasks").Code("period_tasks_PeriodClosed")
			.Name(SR.M("Завершенные"))
			.Container("top");
		factory.Section(SR.M("Мой отдел"), "my_department_tasks").Parent("top_tasks_menu").Order(60)
			.Container("top");
		factory.Section(SR.M("Задачи отдела"), "my_department_tasks_for").Parent("my_department_tasks").Order(10)
			.Container("top");
		factory.Action("myDepartmentCurrent").Parent("my_department_tasks_for").Name(SR.M("Текущие"))
			.Order(10)
			.Container("top");
		factory.Action("myDepartmentExpired").Parent("my_department_tasks_for").Name(SR.M("Просроченные"))
			.Order(30)
			.Container("top");
		factory.Section(SR.M("Задачи от отдела"), "my_department_tasks_from").Parent("my_department_tasks").Order(20)
			.Container("top");
		factory.Action("fromDepartmentCurrent").Parent("my_department_tasks_from").Name(SR.M("Текущие"))
			.Order(10)
			.Container("top");
		factory.Action("fromDepartmentExpired").Parent("my_department_tasks_from").Name(SR.M("Просроченные"))
			.Order(20)
			.Container("top");
		factory.Action("fromDepartmentCompleted").Parent("my_department_tasks_from").Name(SR.M("Выполненные"))
			.Order(30)
			.Container("top");
		factory.Section(SR.M("Трудозатраты"), "workLog_tasks").Parent("top_tasks_menu").Order(60)
			.Container("top");
		factory.Action(new ActionRoute("Index", "WorkLogReport", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Parent("workLog_tasks").Name(SR.M("Отчёты"))
			.Container("top");
		factory.Action(new ActionRoute("Index", "WorkLogApproveReport", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Parent("workLog_tasks").Name(SR.M("Согласование"))
			.Container("top");
		factory.Separator().Parent("top_tasks_menu").Order(75)
			.Container("top");
		factory.Action(new ActionRoute("Search", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Parent("top_tasks_menu").Image24("#search.svg")
			.Name(SR.M("Поиск задач"))
			.Order(80)
			.Container("top");
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("left");
		});
		factory.Section(SR.M("Задачи"), "left_tasks_menu").Image24("#task.svg").Order(20)
			.Container("left")
			.OnTop(onTop: true)
			.Stretch(stretch: true);
		factory.Action(new ActionRoute("Incoming", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Список задач")).Image24("#list.svg")
			.Code("tasks-threads-tree")
			.Parent("left_tasks_menu")
			.Container("left")
			.Order(10);
		factory.Section(SR.M("Периодические задачи"), "period-menu").Image24("#period.svg").Order(20)
			.Container("left")
			.Parent("left_tasks_menu");
		factory.Action(new ActionRoute("PeriodCurrent", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Текущие")).Code("period-Current")
			.Parent("period-menu")
			.Container("left");
		factory.Action(new ActionRoute("PeriodClosed", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Завершенные")).Code("period-Closed")
			.Parent("period-menu")
			.Container("left");
		factory.Section(SR.M("Мой отдел"), "mydepartment-menu").Image24("#users.svg").Order(30)
			.Container("left")
			.Parent("left_tasks_menu");
		factory.Action(new ActionRoute("MyDepartmentCurrent", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Задачи отдела")).Code("my_department_tasks_for")
			.Parent("mydepartment-menu")
			.Order(10)
			.Container("left");
		factory.Action(new ActionRoute("MyDepartmentCurrent", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Текущие")).Code("myDepartmentCurrent")
			.Parent("my_department_tasks_for")
			.Order(10)
			.Container("left");
		factory.Action(new ActionRoute("MyDepartmentExpired", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Просроченные")).Code("myDepartmentExpired")
			.Parent("my_department_tasks_for")
			.Order(20)
			.Container("left");
		factory.Action(new ActionRoute("FromDepartmentCurrent", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Задачи от отдела")).Code("my_department_tasks_from")
			.Parent("mydepartment-menu")
			.Order(20)
			.Container("left");
		factory.Action(new ActionRoute("FromDepartmentCurrent", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Текущие")).Code("fromDepartmentCurrent")
			.Parent("my_department_tasks_from")
			.Order(10)
			.Container("left");
		factory.Action(new ActionRoute("FromDepartmentExpired", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Просроченные")).Code("fromDepartmentExpired")
			.Parent("my_department_tasks_from")
			.Order(20)
			.Container("left");
		factory.Action(new ActionRoute("FromDepartmentCompleted", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Выполненные")).Code("fromDepartmentCompleted")
			.Parent("my_department_tasks_from")
			.Order(30)
			.Container("left");
		factory.Action(new ActionRoute("ForDepartmentClosed", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Архив")).Code("closed_tasks_department")
			.Parent("mydepartment-menu")
			.Order(30)
			.Container("left");
		factory.Action(new ActionRoute("ForDepartmentClosed", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Задачи отдела")).Code("forDepartmentClosed")
			.Parent("closed_tasks_department")
			.Container("left");
		factory.Action(new ActionRoute("FromDepartmentClosed", "AllTasks", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Name(SR.M("Задачи от отдела")).Code("fromDepartmentClosed")
			.Parent("closed_tasks_department")
			.Container("left");
		factory.Action("companyPage").Name(SR.M("Компания")).Image24("#company_menu.svg")
			.Order(25)
			.Code("department-menu")
			.Container("left");
		if (WorkLogSettingsHelper.WorkLogEnabled())
		{
			factory.Section(SR.M("Трудозатраты"), "worklog-menu").Image24("#clock.svg").Order(30)
				.Container("left")
				.Parent("left_tasks_menu");
			factory.Action(new ActionRoute("Index", "WorkLogReport", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			})).Code("workLogReport-menu").Parent("worklog-menu")
				.Order(30)
				.Container("left");
			factory.Action(new ActionRoute("Index", "WorkLogApproveReport", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			})).Code("workLogApprove-menu").Parent("worklog-menu")
				.Order(40)
				.Container("left");
		}
		factory.Action(new ActionRoute("Index", "Settings", new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks"
		})).Code("tasks-admin-menu").Order(20)
			.Parent("commonhome")
			.Container("left")
			.Copy(delegate(MenuItemBuilder b)
			{
				b.Container("top");
			});
	}
}

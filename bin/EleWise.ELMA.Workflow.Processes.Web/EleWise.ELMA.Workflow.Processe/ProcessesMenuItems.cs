using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Workflow.Processes.Web.Menu;

[Component]
public class ProcessesMenuItems : IMenuItemsProvider
{
	public const string MYPROCESSES = "my-processes";

	public const string MYPROCESSES_TOP = "my-processes-top";

	public const string MONITOR = "monitor-processes";

	public const string MONITOR_TOP = "monitor-processes-top";

	public const string DOCUMENTATION = "documentation-processes";

	public const string DOCUMENTATION_MY = "documentation-processes-my";

	public const string DOCUMENTATION_FULL = "documentation-processes-full";

	public const string DOCUMENTATION_TOP = "documentation-processes-top";

	public const string DOCUMENTATION_MY_TOP = "documentation-processes-my-top";

	public const string DOCUMENTATION_FULL_TOP = "documentation-processes-full-top";

	public const string IMPROVEMENT = "improvement-processes";

	public const string IMPROVEMENT_TOP = "improvement-processes-top";

	public const string WORKFLOW_QUEUE_PERFORMANCE = "workflow-queue-performance";

	public const string WORKFLOW_QUEUE_ERROR = "workflow-queue-error";

	public const string MONITORRECALC_QUEUE = "monitor-recalc-queue";

	public const string CHANGE_VERSION = "change-version-package";

	public const string CHANGE_VERSION__PACKAGE_LIST_PROCESSED = "change-version-package-list-processed";

	public const string CHANGE_VERSION_PACKAGES_LIST_ACTIVE = "change-version-packages-list-active";

	public const string WORKFLOW_MODULE_SETTINGS = "EleWise.ELMA.Workflow.Processes.Web.Controllers.ProcessHeaderController.Settings";

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public void Items(MenuItemFactory factory)
	{
		factory.Action("EleWise.ELMA.Workflow.Processes.Web-Module-StartProcess").Order(40).Container("create");
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("start");
		});
		factory.Action(new ActionRoute("Index", "MyProcesses", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		})).Name(SR.M("Процессы")).Code("start-processes-menu")
			.Order(800)
			.Color("green")
			.Image16("#process.svg");
		factory.Action(new ActionRoute("Index", "MyProcesses", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		})).Parent("start-processes-menu").Order(810)
			.Image16("#process.svg");
		factory.Action(new ActionRoute("Index", "Monitor", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		})).Parent("start-processes-menu").Order(820)
			.Image16("#computer.svg");
		factory.Action(new ActionRoute("Index", "Improvement", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		})).Parent("start-processes-menu").Order(830)
			.Image16("#update.svg");
		factory.Action("EleWise.ELMA.Workflow.Processes.Web-Module-StartProcess", ObjectIconFormat.x16).Parent("create").Order(50)
			.Image24("#process.svg")
			.Name(SR.M("Запустить процесс"))
			.Container("top");
		factory.Section(SR.M("Процессы"), "processes").Order(50).Container("top");
		factory.Action(new ActionRoute("Index", "MyProcesses", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		}), ObjectIconFormat.x16).Code("my-processes-top").Order(10)
			.Parent("processes")
			.Container("top");
		factory.Action(new ActionRoute("Index", "Monitor", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		}), ObjectIconFormat.x16).Code("monitor-processes-top").Order(20)
			.Parent("processes")
			.Container("top");
		factory.Action(new ActionRoute("Index", "Improvement", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		}), ObjectIconFormat.x16).Code("improvement-processes-top").Order(30)
			.Parent("processes")
			.Container("top");
		factory.Action("EleWise.ELMA.Workflow.Processes.Web-Module-StartImprovement", ObjectIconFormat.x16).Order(100).Parent("processes")
			.Image24("#update.svg")
			.Name(SR.M("Улучшить процесс"))
			.Container("top");
		factory.Action(new ActionRoute("ChapterIndex", "Documentation", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		}), ObjectIconFormat.x16).Code("documentation-processes-top").Order(40)
			.Parent("processes")
			.Container("top");
		factory.Action(new ActionRoute("Index", "Documentation", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		}), ObjectIconFormat.x16).Code("documentation-processes-my-top").Order(50)
			.Parent("documentation-processes-top")
			.Container("top");
		factory.Action(new ActionRoute("FullIndex", "Documentation", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		}), ObjectIconFormat.x16).Code("documentation-processes-full-top").Order(60)
			.Parent("documentation-processes-top")
			.Container("top");
		factory.Action(new ActionRoute("Settings", "ProcessHeader", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		}), ObjectIconFormat.x16).Order(100).Parent("admin")
			.Image24("#process.svg")
			.Container("top");
		factory.Section(SR.M("Процессы"), "processes").Order(50).Image24("#process.svg")
			.Container("left")
			.OnTop(onTop: true)
			.Stretch(stretch: true);
		factory.Action(new ActionRoute("Index", "MyProcesses", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		}), ObjectIconFormat.x16).Code("my-processes").Order(10)
			.Parent("processes")
			.Container("left")
			.OnTop(onTop: true);
		factory.Action(new ActionRoute("Index", "Monitor", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		}), ObjectIconFormat.x16).Order(20).Code("monitor-processes")
			.Parent("processes")
			.Container("left")
			.OnTop(onTop: true);
		factory.Action("EleWise.ELMA.Workflow.Processes.Web-Module-MyMonitorProcessesPage").Code("EleWise.ELMA.Workflow.Processes.Web-Module-MyMonitorProcessesPage").Parent("monitor-processes")
			.Container("left")
			.OnTop(onTop: true);
		factory.Action("EleWise.ELMA.Workflow.Processes.Web-Module-FullMonitorProcessesPage").Code("EleWise.ELMA.Workflow.Processes.Web-Module-FullMonitorProcessesPage").Parent("monitor-processes")
			.Container("left")
			.OnTop(onTop: true);
		factory.Section(SR.M("Улучшения"), "EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementProcessesSection").Order(30).Parent("processes")
			.Container("left")
			.Image24("#arrow_up.svg")
			.OnTop(onTop: true);
		factory.Action(new ActionRoute("Index", "Improvement", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		})).Order(10).Code("improvement-processes")
			.Parent("EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementProcessesSection")
			.Name(WorkflowConstants.ImprovementProcessSearchName)
			.Container("left")
			.OnTop(onTop: true);
		factory.Action("EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementProcessesPage").Parent("EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementProcessesSection").Code("EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementMyMonitorProcessAction")
			.Name(WorkflowConstants.ImprovementMyMonitorProcessName)
			.Container("left");
		factory.Action("EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementAllProcessesPage").Parent("EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementProcessesSection").Code("EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementAllProcessesPage")
			.Name(WorkflowConstants.ImprovementAllProcessesName)
			.Container("left");
		factory.Action(new ActionRoute("ChapterIndex", "Documentation", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		}), ObjectIconFormat.x16).Name(SR.M("Документирование")).Code("documentation-processes")
			.Order(40)
			.Parent("processes")
			.Container("left");
		factory.Action(new ActionRoute("Settings", "ProcessHeader", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		}), ObjectIconFormat.x16).Order(100).Parent("admin")
			.Image24("#process.svg")
			.Container("left");
		factory.Action(new ActionRoute("Index", "WorkflowQueue", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		})).Name(SR.M("Очередь исполнения")).Code("WorkflowQueues")
			.Order(110)
			.Parent("processes")
			.Image24("#clock.svg")
			.Container("left")
			.Stretch(stretch: true);
		factory.Action(new ActionRoute("Index", "MonitorAdmin", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		})).Code("monitor-recalc-queue").Order(500)
			.Parent("system-home")
			.Container("left");
		factory.Action(new ActionRoute("MigrationPackageIsActiveList", "WorkflowInstanceMigrationPackage", new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web"
		})).Name(SR.M("Смена версии")).Code("WorkflowInstanceChangeVersion")
			.Order(111)
			.Parent("processes")
			.Image24("#switch.svg")
			.Container("left")
			.Stretch(stretch: true);
	}
}

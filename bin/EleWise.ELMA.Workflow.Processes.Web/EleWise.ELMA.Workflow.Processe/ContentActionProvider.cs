using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Workflow.Security;

namespace EleWise.ELMA.Workflow.Processes.Web.Menu;

[Component]
public class ContentActionProvider : ControllerActionProviderBase
{
	public const string START_PROCESS = "EleWise.ELMA.Workflow.Processes.Web-Module-StartProcess";

	public const string START_IMPROVEMENT = "EleWise.ELMA.Workflow.Processes.Web-Module-StartImprovement";

	private readonly ContentAction _startProcess;

	private readonly ContentAction _myProcessesPage;

	private readonly ContentAction _monitorProcessesPage;

	private readonly ContentAction _fullMonitorProcessesPage;

	private readonly ContentAction _improvementProcessesPage;

	private readonly ContentAction _improvementAllProcessesPage;

	private readonly ContentAction _startImprovement;

	private readonly ContentAction myMonitorProcessesPage;

	public ISecurityService SecurityService { get; set; }

	public ContentActionProvider()
	{
		_startProcess = new ContentAction
		{
			Id = "EleWise.ELMA.Workflow.Processes.Web-Module-StartProcess",
			DescriptionForLocalization = SR.M("Запустить бизнес процесс"),
			Image24 = "#process.svg",
			NameForLocalization = SR.M("Запустить процесс"),
			ActionType = ContentAction.ActionTypeDialog,
			IsAvalilableDelegate = (RequestContext target) => SecurityService.HasPermission(WorkflowGlobalPermissionProvider.WorkflowAccessPermission),
			LinkTemplate = (RequestContext cc) => ((object)UIExtensions.OpenPopup("MainProcessTree")).ToString().PrepareJavascriptHref(),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("StartProcessSelectorWindow", (dynamic d) => ChildActionExtensions.Action(html, "TreeWindow", "ProcessHeader", (object)new
				{
					area = "EleWise.ELMA.Workflow.Processes.Web",
					treeId = "MainProcessTree"
				}));
			}
		};
		_myProcessesPage = new ContentAction
		{
			Id = "EleWise.ELMA.Workflow.Processes.Web-Module-MyProcessesPage",
			DescriptionForLocalization = SR.M("Страница с моими процессами и краткой статистикой по экземплярам"),
			Image24 = "#process.svg",
			NameForLocalization = SR.M("Мои процессы"),
			ActionType = ContentAction.ActionTypePage,
			Routes = new ActionRoute("MyProcesses", "ProcessHeader", new
			{
				area = "EleWise.ELMA.Workflow.Processes.Web"
			}),
			Order = 20
		};
		_monitorProcessesPage = new ContentAction
		{
			Id = "EleWise.ELMA.Workflow.Processes.Web-Module-MonitorProcessesPage",
			DescriptionForLocalization = SR.M("Страница для работы с процессами, на мониторинг которых текущий пользователь имеет доступ"),
			Image24 = "#computer.svg",
			NameForLocalization = SR.M("Монитор процессов"),
			ActionType = ContentAction.ActionTypePage,
			Routes = new ActionRoute("Index", "Monitor", new
			{
				area = "EleWise.ELMA.Workflow.Processes.Web"
			}),
			Order = 30
		};
		myMonitorProcessesPage = new ContentAction
		{
			Id = "EleWise.ELMA.Workflow.Processes.Web-Module-MyMonitorProcessesPage",
			DescriptionForLocalization = SR.M("Страница для работы с процессами, на мониторинг которых текущий пользователь имеет доступ"),
			Image24 = "#computer.svg",
			NameForLocalization = SR.M(WorkflowConstants.MyMonitorProcessName),
			ActionType = ContentAction.ActionTypePage,
			Routes = new ActionRoute("List", "Monitor", new
			{
				area = "EleWise.ELMA.Workflow.Processes.Web"
			}),
			Order = 35
		};
		_fullMonitorProcessesPage = new ContentAction
		{
			Id = "EleWise.ELMA.Workflow.Processes.Web-Module-FullMonitorProcessesPage",
			DescriptionForLocalization = SR.M("Страница с полным деревом процессов для мониторинга"),
			Image24 = "#computer.svg",
			NameForLocalization = SR.M(WorkflowConstants.ImprovementAllProcessesName),
			ActionType = ContentAction.ActionTypePage,
			Routes = new ActionRoute("FullIndex", "Monitor", new
			{
				area = "EleWise.ELMA.Workflow.Processes.Web"
			}),
			Order = 40
		};
		_improvementProcessesPage = new ContentAction
		{
			Id = "EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementProcessesPage",
			DescriptionForLocalization = SR.M("Перечень процессов, где есть актуальные изменения"),
			Image24 = "#process.svg",
			NameForLocalization = SR.M("{0} - Улучшения", WorkflowConstants.ImprovementMyMonitorProcessName),
			ActionType = ContentAction.ActionTypePage,
			Routes = new ActionRoute("Processes", "Improvement", new
			{
				area = "EleWise.ELMA.Workflow.Processes.Web"
			}),
			Order = 50
		};
		_improvementAllProcessesPage = new ContentAction
		{
			Id = "EleWise.ELMA.Workflow.Processes.Web-Module-ImprovementAllProcessesPage",
			DescriptionForLocalization = SR.M("Перечень всех процессов"),
			Image24 = "#workflow.svg",
			NameForLocalization = SR.M("{0} - Улучшения", WorkflowConstants.ImprovementAllProcessesName),
			ActionType = ContentAction.ActionTypePage,
			Routes = new ActionRoute("AllProcesses", "Improvement", new
			{
				area = "EleWise.ELMA.Workflow.Processes.Web"
			}),
			Order = 60
		};
		_startImprovement = new ContentAction
		{
			Id = "EleWise.ELMA.Workflow.Processes.Web-Module-StartImprovement",
			DescriptionForLocalization = SR.M("Запустить улучшение процесса"),
			Image24 = "#arrow_up.svg",
			NameForLocalization = SR.M("Улучшить процесс"),
			ActionType = ContentAction.ActionTypeDialog,
			IsAvalilableDelegate = (RequestContext target) => SecurityService.HasPermission(WorkflowGlobalPermissionProvider.WorkflowAccessPermission) && SecurityService.HasPermission(WorkflowProcessesPermissionProvider.ImprovementModulePermission) && SecurityService.HasPermission(WorkflowProcessesPermissionProvider.CreateImprovementPermission),
			LinkTemplate = (RequestContext cc) => ((object)UIExtensions.RefreshPopup("ProcessImprovementPopup", new UrlHelper(cc).Action("ImprovementPopup", "Improvement", (object)new
			{
				area = "EleWise.ELMA.Workflow.Processes.Web",
				id = (long?)null,
				popupId = "ProcessImprovementPopup"
			}))).ToString().PrepareJavascriptHref(),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("ProcessImprovementPopup", (dynamic d) => ChildActionExtensions.Action(html, "ProcessImprovementPopup", "Improvement", (object)new
				{
					area = "EleWise.ELMA.Workflow.Processes.Web"
				}));
			},
			Order = 70
		};
	}

	protected override IEnumerable<ContentAction> GetAction()
	{
		yield return _startProcess;
		yield return _myProcessesPage;
		yield return _monitorProcessesPage;
		yield return myMonitorProcessesPage;
		yield return _fullMonitorProcessesPage;
		yield return _improvementProcessesPage;
		yield return _improvementAllProcessesPage;
		yield return _startImprovement;
	}
}

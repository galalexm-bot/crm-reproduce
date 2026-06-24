using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using EleWise.ELMA.Workflow.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Workflow.Processes.Web.Models
{
	public class WorkflowInstanceMigrationPackageViewModel : EntityModel<IWorkflowInstanceMigrationPackage>
	{
		public WorkflowInstanceMigrationPackageViewModel(IWorkflowInstanceMigrationPackage package)
			: base(package)
		{
		}
	}
}
namespace EleWise.ELMA.Workflow.Processes.Web.Controllers
{
	public class WorkflowInstanceMigrationPackageController : BPMController<IWorkflowInstanceMigrationPackage, long>
	{
		public WorkflowInstanceManager WorkflowInstanceManager { get; set; }

		public WorkflowInstanceMigrationPackageManager WfInstanceMigrationPackageManager { get; set; }

		public ActionResult Index([Bind(Prefix = "DataFilter")] IWorkflowInstanceMigrationPackageFilter filter)
		{
			return (ActionResult)(object)((Controller)this).View("index", (object)CreateGridData(null, filter));
		}

		[ContentItem(Name = "SR.M('Текущие операции')", Image24 = "#clock.svg", Order = 600)]
		public ActionResult MigrationPackageIsActiveList()
		{
			InstanceOf<IWorkflowInstanceMigrationPackageFilter> instanceOf = new InstanceOf<IWorkflowInstanceMigrationPackageFilter>();
			instanceOf.New.IsActive = true;
			return Index(instanceOf.New);
		}

		[ContentItem(Name = "SR.M('Обработанные')", Image24 = "#delete.svg", Order = 700)]
		public ActionResult MigrationPackageProcessedList()
		{
			InstanceOf<IWorkflowInstanceMigrationPackageFilter> instanceOf = new InstanceOf<IWorkflowInstanceMigrationPackageFilter>();
			instanceOf.New.IsActive = false;
			return Index(instanceOf.New);
		}

		[CustomGridAction]
		public ActionResult Grid(GridCommand command, [Bind(Prefix = "DataFilter")] IWorkflowInstanceMigrationPackageFilter filter)
		{
			return (ActionResult)(object)((Controller)this).PartialView((object)CreateGridData(command, filter));
		}

		public ActionResult CreatePackagePage(string infoJson)
		{
			CreatePackageInfo createPackageInfo = new CreatePackageInfo
			{
				JsonItemIds = infoJson
			};
			return (ActionResult)(object)((Controller)this).PartialView((object)createPackageInfo);
		}

		[HttpPost]
		public ActionResult CreateMigrationPackage([JsonBinder] IEnumerable<long> jsonItemIds, string name, string migrationReason)
		{
			ICollection<IWorkflowInstance> collection = WorkflowInstanceManager.FindByIdArray(jsonItemIds.ToArray());
			List<string> list = new List<string>();
			foreach (IWorkflowInstance item in collection)
			{
				if (!base.SecurityService.HasPermission(WorkflowPermissionProvider.ChangeProcessVersionPermission, item) && !list.Contains(item.Process.Name))
				{
					list.Add(item.Process.Name);
				}
			}
			if (list.Count > 0)
			{
				throw new SecurityException(SR.T("Недостаточно прав для изменения версии процессов: {0}", string.Join(", ", list.ToArray())));
			}
			IWorkflowInstanceMigrationPackage workflowInstanceMigrationPackage = WfInstanceMigrationPackageManager.Create(collection, name, migrationReason);
			return (ActionResult)(object)((Controller)this).RedirectToAction("ShowPackageItems", "WorkflowInstanceMigrationItem", (object)new
			{
				id = workflowInstanceMigrationPackage.Id
			});
		}
	}
}

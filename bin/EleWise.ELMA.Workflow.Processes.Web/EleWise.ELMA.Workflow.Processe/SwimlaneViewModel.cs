using System.Collections.Generic;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class SwimlaneViewModel
{
	public class StaticParameters
	{
		public string PositionKindName { get; set; }

		public IOrganizationItem OrgItem { get; set; }
	}

	public class DynamicParameters
	{
		public string PropertyName { get; set; }

		public string WorkerDetectionName { get; set; }

		public IList<WorkerViewModel> WorkerModels { get; set; }
	}

	public class DynamicScriptParameters
	{
		public string PropertyName { get; set; }

		public string ScriptName { get; set; }
	}

	public class BusinessRoleParameters
	{
		public string TypeName { get; set; }
	}

	public string Name { get; set; }

	public string Type { get; set; }

	public StaticParameters Static { get; set; }

	public DynamicParameters Dynamic { get; set; }

	public DynamicScriptParameters DynamicScript { get; set; }

	public BusinessRoleParameters BusinessRole { get; set; }
}

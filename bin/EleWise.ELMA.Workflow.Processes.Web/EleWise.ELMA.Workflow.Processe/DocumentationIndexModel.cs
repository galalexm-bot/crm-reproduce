using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class DocumentationIndexModel
{
	public List<IProcessHeader> Headers { get; set; }

	public List<ProcessResponsibilityItemInfo> RoleInfos { get; set; }

	public IEnumerable<IProcessHeader> GetOwnerHeaders()
	{
		return Headers.Where((IProcessHeader h) => RoleInfos.Any((ProcessResponsibilityItemInfo i) => i.ResponsibilityLevel == 2 && h.Id == i.ProcessHeader));
	}

	public IEnumerable<IProcessHeader> GetIsCuratorHeaders()
	{
		return Headers.Where((IProcessHeader h) => RoleInfos.Any((ProcessResponsibilityItemInfo i) => i.IsCurator && h.Id == i.ProcessHeader));
	}
}

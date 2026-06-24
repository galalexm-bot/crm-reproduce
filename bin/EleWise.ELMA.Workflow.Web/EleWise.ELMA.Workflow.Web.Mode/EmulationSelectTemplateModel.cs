using System.Collections.Generic;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Models;

public class EmulationSelectTemplateModel
{
	public IList<IEmulationContextTemplates> ListTemplate { get; set; }

	public long TemplateSelect { get; set; }

	public string TemplateSelectName { get; set; }

	public string Style { get; set; }

	public EmulationSelectTemplateModel()
	{
		TemplateSelectName = "";
		TemplateSelect = 0L;
	}
}

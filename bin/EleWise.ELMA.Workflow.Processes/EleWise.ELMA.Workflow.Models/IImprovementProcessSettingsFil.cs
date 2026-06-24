using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IImprovementProcessSettings))]
public interface IImprovementProcessSettingsFilter : IEntityFilter
{
	bool? Default { get; set; }
}

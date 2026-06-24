using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Deploy.Services;

public interface IExportRulesService
{
	ExportRuleList BaseMerge(IEntity entity, ExportRuleList customRules);

	ExportRuleList Base(IEntity entity);
}

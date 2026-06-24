using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ICategoryRule))]
public interface ICategoryRuleFilter : IEntityFilter
{
	CategoryRuleType? Type { get; set; }
}

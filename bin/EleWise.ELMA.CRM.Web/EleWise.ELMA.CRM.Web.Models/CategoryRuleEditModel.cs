using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class CategoryRuleEditModel
{
	public ICategoryRule CategoryRule { get; set; }

	public FilterModel DataFilter { get; set; }
}

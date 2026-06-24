using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.CRM.Web.Models;

public class CategoryRulesListModel
{
	public GridData<ICategoryRule> Rules { get; set; }

	public string Header { get; set; }

	public string GridId { get; set; }

	public long TypeId { get; set; }
}

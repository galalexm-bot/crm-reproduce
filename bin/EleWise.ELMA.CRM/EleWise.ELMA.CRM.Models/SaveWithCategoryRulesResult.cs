using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Models;

public class SaveWithCategoryRulesResult
{
	public List<ICategory> AddedCategories { get; set; }

	public List<ICategory> DeletedCategories { get; set; }
}

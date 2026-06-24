using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public interface IDeleteCategoriesDialogModel
{
	bool? UnassignOldCategories { get; set; }

	IEnumerable<ICategory> CategoriesToDelete { get; set; }
}

using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.Models.Boxes;

namespace EleWise.ELMA.CRM.Web.Models;

public class AutoCompleteContractorItem : AutocompleteItem
{
	public static AutoCompleteContractorItem[] GetItems(IEnumerable<IContractor> contractors)
	{
		return (from u in contractors
			where u != null
			select new AutoCompleteContractorItem
			{
				Value = u.Id.ToString(),
				Text = u.Name,
				ViewText = u.Name
			} into i
			where !string.IsNullOrEmpty(i.Text)
			select i).ToArray();
	}

	public static AutoCompleteContractorItem GetItem(IContractor contractor)
	{
		if (contractor == null)
		{
			return null;
		}
		return new AutoCompleteContractorItem
		{
			Value = contractor.Id.ToString(),
			Text = contractor.Name,
			ViewText = contractor.Name
		};
	}
}

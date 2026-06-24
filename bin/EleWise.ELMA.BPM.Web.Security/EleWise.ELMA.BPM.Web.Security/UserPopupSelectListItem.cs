using System.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class UserPopupSelectListItem : SelectListItem
{
	public AutoCompleteUserItem AutoCompleteUserItem { get; set; }

	public bool Available { get; set; }
}

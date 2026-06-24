using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Security.Models;

internal class UserPopupSelectItemComparator : IEqualityComparer<UserPopupSelectListItem>
{
	public bool Equals(UserPopupSelectListItem x, UserPopupSelectListItem y)
	{
		if (x != null && y != null)
		{
			return x.AutoCompleteUserItem.ObjectId == y.AutoCompleteUserItem.ObjectId;
		}
		return false;
	}

	public int GetHashCode(UserPopupSelectListItem obj)
	{
		return 1;
	}
}

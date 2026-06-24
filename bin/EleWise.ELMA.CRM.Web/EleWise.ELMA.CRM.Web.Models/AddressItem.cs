using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.CRM.Web.Models;

public class AddressItem : DropDownItem
{
	public Guid? Uid { get; set; }

	public string Zip { get; set; }

	public static AddressItem[] GetItems(IEnumerable<IAddrBase> addrs)
	{
		return (from u in addrs
			where u != null && !string.IsNullOrEmpty(u.ObjectName)
			orderby u.ObjectName
			select u).Select(GetItem).ToArray();
	}

	public static AddressItem GetItem(IAddrBase addr)
	{
		if (addr == null)
		{
			return null;
		}
		AddressItem obj = new AddressItem
		{
			Zip = addr.ZIP
		};
		((DropDownItem)obj).set_Value(addr.Id.ToString());
		((DropDownItem)obj).set_Text(addr.ObjectName + " " + addr.ShortName);
		obj.Uid = addr.Uid;
		return obj;
	}
}

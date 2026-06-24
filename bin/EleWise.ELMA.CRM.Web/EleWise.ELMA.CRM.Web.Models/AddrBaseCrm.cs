using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

[Obsolete]
public class AddrBaseCrm
{
	public long Id { get; set; }

	public Guid? Uid { get; set; }

	public Guid? ParentGuid { get; set; }

	public int TypeOfSub { get; set; }

	public string CountryCode { get; set; }

	public string ObjectName { get; set; }

	public string ShortName { get; set; }

	public string Zip { get; set; }

	public string FiasCode { get; set; }

	public DateTime UpdateDate { get; set; }

	public bool Actual { get; set; }

	public long Value { get; set; }

	public string Text { get; set; }

	public static AddrBaseCrm[] GetItems(UrlHelper helper, IEnumerable<IAddrBase> addrs)
	{
		return (from u in addrs
			where u != null
			select GetItem(helper, u) into i
			where !string.IsNullOrEmpty(i.ObjectName)
			select i).ToArray();
	}

	public static AddrBaseCrm GetItem(UrlHelper helper, IAddrBase addr)
	{
		if (addr == null)
		{
			return null;
		}
		string text = addr.ObjectName + " " + addr.ShortName;
		return new AddrBaseCrm
		{
			Id = addr.Id,
			ObjectName = addr.ObjectName,
			Zip = addr.ZIP,
			Value = addr.Id,
			Text = text,
			Uid = addr.Uid,
			CountryCode = addr.CountryCode
		};
	}
}

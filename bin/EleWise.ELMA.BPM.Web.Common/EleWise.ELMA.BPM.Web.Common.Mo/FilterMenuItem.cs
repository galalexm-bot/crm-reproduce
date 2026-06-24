using System;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Common.Models;

[Serializable]
public class FilterMenuItem
{
	public string Code { get; set; }

	public Guid TypeUid { get; set; }

	public ActionRoute Routes { get; set; }

	public string FilterIdParameter { get; set; }

	public string ClickAction { get; set; }

	public string FilterEditAction { get; set; }

	public Guid? TypeCode { get; set; }

	public bool IncludeFavorites { get; set; }
}

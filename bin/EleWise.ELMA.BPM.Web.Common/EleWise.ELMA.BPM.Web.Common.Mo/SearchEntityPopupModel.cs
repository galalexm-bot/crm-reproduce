using System;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public sealed class SearchEntityPopupModel
{
	public Guid PopupUid { get; set; }

	public string InputName { get; set; }

	public Guid TypeUid { get; set; }

	public bool ShowOnlyGroups { get; set; }

	public string EntityFilterProvider { get; set; }

	public string EntityFilterData { get; set; }

	public int PopupWidth { get; set; }

	public bool MultiSelect { get; set; }
}

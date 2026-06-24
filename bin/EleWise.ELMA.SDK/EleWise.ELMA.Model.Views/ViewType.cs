using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

[Flags]
public enum ViewType
{
	[DisplayName(typeof(__ViewTypeLocalization), "Create")]
	Create = 1,
	[DisplayName(typeof(__ViewTypeLocalization), "Edit")]
	Edit = 2,
	[DisplayName(typeof(__ViewTypeLocalization), "Display")]
	Display = 4,
	[DisplayName(typeof(__ViewTypeLocalization), "List")]
	List = 8,
	[DisplayName(typeof(__ViewTypeLocalization), "Filter")]
	Filter = 0x10,
	[DisplayName(typeof(__ViewTypeLocalization), "Custom")]
	Custom = 0x100,
	AllExceptList = 0x17,
	All = 0x1F
}

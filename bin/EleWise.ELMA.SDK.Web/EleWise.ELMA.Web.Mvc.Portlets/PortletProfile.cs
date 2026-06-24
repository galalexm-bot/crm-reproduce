using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Portlets;

public sealed class PortletProfile : IPortletProfile
{
	[NotNull]
	public static PortletProfile Default => new PortletProfile
	{
		Collapsible = true,
		Customizable = false,
		DefaultZone = "Left",
		UseDynamicLoad = false,
		DynamicLoadUrl = string.Empty,
		CssClass = string.Empty,
		ImageUrl = string.Empty,
		DefaultOrder = 0,
		Scope = PersonalizationScope.User
	};

	public bool Collapsible { get; set; }

	public bool Customizable { get; set; }

	public string ImageUrl { get; set; }

	public string DefaultZone { get; set; }

	public int DefaultOrder { get; set; }

	public bool UseDynamicLoad { get; set; }

	public string DynamicLoadUrl { get; set; }

	public string CssClass { get; set; }

	public PersonalizationScope Scope { get; set; }
}

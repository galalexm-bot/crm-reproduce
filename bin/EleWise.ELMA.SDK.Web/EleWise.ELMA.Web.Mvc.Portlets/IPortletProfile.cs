using System;

namespace EleWise.ELMA.Web.Mvc.Portlets;

public interface IPortletProfile
{
	bool Collapsible { get; }

	bool Customizable { get; }

	string ImageUrl { get; }

	string DefaultZone { get; }

	int DefaultOrder { get; }

	bool UseDynamicLoad { get; }

	string DynamicLoadUrl { get; }

	string CssClass { get; }

	[Obsolete("Уровень персонализации определяется для кажого инстраса портлета из контекста")]
	PersonalizationScope Scope { get; }
}

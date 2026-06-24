using System;
using System.Collections.Generic;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.Portlets.Layouts;

namespace EleWise.ELMA.Web.Mvc.Models.Portal;

public class PortalModel
{
	private PersonalizationScope scope = PersonalizationScope.Shared;

	public string PersonalPath { get; set; }

	public IEnumerable<Tuple<string, PortletViewModel>> ZonePortletViews { get; set; }

	public IPortletLayout PortletLayout { get; set; }

	public PersonalizationScope Scope
	{
		get
		{
			return scope;
		}
		set
		{
			scope = value;
		}
	}

	public bool Edit { get; set; }

	public ICollection<PortalZone> Zones { get; set; }

	public bool AllowedAddPortlet { get; set; }

	public bool AllowedEdit { get; set; }

	public bool AllowedChangeSharedSettings { get; set; }

	public bool HasPersonalization { get; set; }
}

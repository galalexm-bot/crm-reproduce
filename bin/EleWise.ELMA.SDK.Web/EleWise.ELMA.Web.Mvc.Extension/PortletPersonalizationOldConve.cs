using System;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public abstract class PortletPersonalizationOldConverterExtensions : IPortletPersonalizationOldConverterExtensions
{
	public abstract Type OldSettingsType { get; }

	public abstract Type NewSettingsType { get; }

	public virtual PortletPersonalization Convert(PortletPersonalization personalization)
	{
		return personalization;
	}

	public virtual void Update(PortletPersonalization personalization)
	{
	}
}

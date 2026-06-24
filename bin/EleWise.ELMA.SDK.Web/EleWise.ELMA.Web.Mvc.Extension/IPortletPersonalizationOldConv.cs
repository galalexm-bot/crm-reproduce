using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Web.Mvc.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPortletPersonalizationOldConverterExtensions
{
	Type OldSettingsType { get; }

	Type NewSettingsType { get; }

	PortletPersonalization Convert(PortletPersonalization personalization);

	void Update(PortletPersonalization personalization);
}

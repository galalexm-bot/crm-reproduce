using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Web.Mvc.Portlets.Layouts;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPortletLayout : IIdentified
{
	Guid Id { get; }

	string Name { get; }

	string TemplatePath { get; }

	ZoneDescriptor[] Zones { get; }

	string ImagePreview { get; }

	string ConvertToCustomLayout { get; }
}

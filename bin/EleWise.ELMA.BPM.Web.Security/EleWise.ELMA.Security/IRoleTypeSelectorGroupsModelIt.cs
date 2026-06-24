using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.Security;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IRoleTypeSelectorGroupsModelItems
{
	Type EntityType { get; }

	IRoleTypeSelectorGroupsCategory Category { get; }

	IList<TreeMenuNode> GetItems(object instance, Type type);
}

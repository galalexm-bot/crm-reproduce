using System;
using System.Collections.Generic;
using Orchard.Environment.ShellBuilders.Models;

namespace EleWise.ELMA.Web.Orchard.Enviroment.ShellBuilders;

public class ShellBlueprintWithComponents : ShellBlueprint
{
	public IEnumerable<Type> ComponentTypes { get; set; }

	public ShellBlueprintWithComponents()
	{
	}

	public ShellBlueprintWithComponents(ShellBlueprint source)
	{
		base.Controllers = source.Controllers;
		base.Dependencies = source.Dependencies;
		base.Descriptor = source.Descriptor;
		base.Records = source.Records;
		base.Settings = source.Settings;
	}
}

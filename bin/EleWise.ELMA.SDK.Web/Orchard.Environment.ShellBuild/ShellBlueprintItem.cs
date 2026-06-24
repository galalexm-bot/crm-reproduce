using System;
using Orchard.Environment.Extensions.Models;

namespace Orchard.Environment.ShellBuilders.Models;

public class ShellBlueprintItem
{
	public Type Type { get; set; }

	public Feature Feature { get; set; }
}

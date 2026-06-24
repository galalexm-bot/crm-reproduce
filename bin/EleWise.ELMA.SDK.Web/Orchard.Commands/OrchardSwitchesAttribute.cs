using System;
using System.Collections.Generic;
using System.Linq;

namespace Orchard.Commands;

[AttributeUsage(AttributeTargets.Method)]
public class OrchardSwitchesAttribute : Attribute
{
	private readonly string _switches;

	public IEnumerable<string> Switches => from s in (_switches ?? "").Trim().Split(',')
		select s.Trim();

	public OrchardSwitchesAttribute(string switches)
	{
		_switches = switches;
	}
}

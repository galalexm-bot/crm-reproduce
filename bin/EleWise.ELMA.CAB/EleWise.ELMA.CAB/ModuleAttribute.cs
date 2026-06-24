using System;

namespace EleWise.ELMA.CAB;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
public sealed class ModuleAttribute : Attribute
{
	private readonly string name;

	public string Name => name;

	public ModuleAttribute(string name)
	{
		this.name = name;
	}
}

using System;

namespace EleWise.ELMA.CAB;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class ModuleDependencyAttribute : Attribute
{
	public string Name { get; set; }

	public ModuleDependencyAttribute(string name)
	{
		Name = name;
	}
}

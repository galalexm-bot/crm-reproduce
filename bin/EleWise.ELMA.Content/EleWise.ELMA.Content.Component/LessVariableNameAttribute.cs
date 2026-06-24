using System;

namespace EleWise.ELMA.Content.Components;

public sealed class LessVariableNameAttribute : Attribute
{
	public string Name { get; }

	public LessVariableNameAttribute(string name)
	{
		Name = name;
	}
}

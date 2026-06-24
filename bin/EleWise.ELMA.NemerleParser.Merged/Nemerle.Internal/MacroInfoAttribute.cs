using System;

namespace Nemerle.Internal;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class MacroInfoAttribute : Attribute
{
	public string Name { get; private set; }

	public bool Syntactical { get; private set; }

	public string[] ParameterNames { get; private set; }

	public string[] ParameterTypes { get; private set; }

	public string[] ParameterDefaultValues { get; private set; }

	public bool[] IsParamArrays { get; private set; }

	public string Usage { get; private set; }

	public MacroInfoAttribute(string name, bool syntactical, string usage)
	{
	}

	[RecordCtor]
	public MacroInfoAttribute([MappedMember("Name")] string name, [MappedMember("Syntactical")] bool syntactical, [MappedMember("ParameterNames")] string[] parameterNames, [MappedMember("ParameterTypes")] string[] parameterTypes, [MappedMember("ParameterDefaultValues")] string[] parameterDefaultValues, [MappedMember("IsParamArrays")] bool[] isParamArrays, [MappedMember("Usage")] string usage)
	{
		Name = name;
		Syntactical = syntactical;
		ParameterNames = parameterNames;
		ParameterTypes = parameterTypes;
		ParameterDefaultValues = parameterDefaultValues;
		IsParamArrays = isParamArrays;
		Usage = usage;
	}
}

using System;
using EleWise.ELMA.Core.Diagnostics;

namespace EleWise.ELMA.Core;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
public sealed class ElmaAssemblyFileVersionAttribute : System.Attribute
{
	private readonly string _003CVersion_003Ek__BackingField;

	public string Version => _003CVersion_003Ek__BackingField;

	public ElmaAssemblyFileVersionAttribute(string version)
	{
		Contract.ArgumentNotNullOrEmpty(version, "version");
		_003CVersion_003Ek__BackingField = version;
	}
}

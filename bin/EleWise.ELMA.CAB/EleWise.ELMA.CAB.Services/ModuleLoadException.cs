using System;
using System.Globalization;
using System.Runtime.Serialization;
using EleWise.ELMA.CAB.Properties;

namespace EleWise.ELMA.CAB.Services;

[Serializable]
public class ModuleLoadException : Exception
{
	public ModuleLoadException()
	{
	}

	public ModuleLoadException(string message)
		: base(message)
	{
	}

	public ModuleLoadException(string message, Exception exception)
		: base(message, exception)
	{
	}

	public ModuleLoadException(string moduleAssembly, string message)
		: base(string.Format(CultureInfo.CurrentCulture, Resources.FailedToLoadModule, new object[2] { moduleAssembly, message }))
	{
	}

	public ModuleLoadException(string moduleAssembly, string message, Exception innerException)
		: base(string.Format(CultureInfo.CurrentCulture, Resources.FailedToLoadModule, new object[2] { moduleAssembly, message }), innerException)
	{
	}

	protected ModuleLoadException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}

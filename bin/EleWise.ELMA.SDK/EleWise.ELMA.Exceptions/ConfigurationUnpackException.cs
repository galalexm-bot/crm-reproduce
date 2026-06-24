using System;
using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class ConfigurationUnpackException : Exception
{
	public string[] Warnings { get; }

	public string[] Errors { get; }

	public ConfigurationUnpackException(string message, Exception innerException, IEnumerable<string> warnings, IEnumerable<string> errors)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(message, innerException);
		Warnings = warnings?.ToArray() ?? Array.Empty<string>();
		Errors = errors?.ToArray() ?? Array.Empty<string>();
	}
}

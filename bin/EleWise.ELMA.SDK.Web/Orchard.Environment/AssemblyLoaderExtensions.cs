namespace Orchard.Environment;

public static class AssemblyLoaderExtensions
{
	public static string ExtractAssemblyShortName(this IAssemblyLoader assemblyLoader, string fullName)
	{
		return ExtractAssemblyShortName(fullName);
	}

	public static string ExtractAssemblyShortName(string fullName)
	{
		int num = fullName.IndexOf(',');
		if (num < 0)
		{
			return fullName;
		}
		return fullName.Substring(0, num);
	}
}

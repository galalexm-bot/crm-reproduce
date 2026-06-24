using System;
using System.IO;

namespace Orchard.Validation;

public static class PathValidation
{
	public static string ValidatePath(string basePath, string mappedPath)
	{
		bool flag = false;
		try
		{
			flag = Path.GetFullPath(mappedPath).StartsWith(Path.GetFullPath(basePath), StringComparison.OrdinalIgnoreCase);
		}
		catch
		{
			flag = false;
		}
		if (!flag)
		{
			throw new ArgumentException("Invalid path");
		}
		return mappedPath;
	}
}

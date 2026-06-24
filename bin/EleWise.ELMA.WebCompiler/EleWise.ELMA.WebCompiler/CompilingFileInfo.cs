using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Web.Hosting;

namespace EleWise.ELMA.WebCompiler;

public class CompilingFileInfo
{
	private static Type typeMapPathBasedVirtualFile;

	private static PropertyInfo propertyPhysicalPath;

	private readonly string virtualPath;

	private readonly string physicalPath;

	private string hashCode;

	private readonly VirtualFile file;

	public string VirtualPath => virtualPath;

	internal string PhysicalPath => physicalPath;

	public static CompilingFileInfo Create(string virtualPath)
	{
		VirtualFile virtualFile = HostingEnvironment.VirtualPathProvider.GetFile(virtualPath);
		MapPathVirtualFile mapPathVirtualFile = virtualFile as MapPathVirtualFile;
		string text = null;
		if (mapPathVirtualFile != null)
		{
			text = mapPathVirtualFile.PhysicalPath;
		}
		else
		{
			if (typeMapPathBasedVirtualFile == null)
			{
				typeMapPathBasedVirtualFile = typeof(VirtualFile).Assembly.GetType("System.Web.Hosting.MapPathBasedVirtualFile");
			}
			if (typeMapPathBasedVirtualFile.IsInstanceOfType(virtualFile))
			{
				if (propertyPhysicalPath == null)
				{
					propertyPhysicalPath = typeMapPathBasedVirtualFile.GetProperty("PhysicalPath", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetProperty);
				}
				text = (string)propertyPhysicalPath.GetValue(virtualFile, null);
			}
		}
		if (text == null)
		{
			return new CompilingFileInfo(virtualFile);
		}
		return new CompilingFileInfo(virtualFile.VirtualPath, text);
	}

	internal CompilingFileInfo(string virtualPath, string physicalPath)
	{
		this.virtualPath = virtualPath;
		if (this.virtualPath.StartsWith("~"))
		{
			this.virtualPath = this.virtualPath.Substring(1);
		}
		this.physicalPath = physicalPath;
	}

	internal CompilingFileInfo(VirtualFile file)
	{
		virtualPath = file.VirtualPath;
		this.file = file;
	}

	public new string GetHashCode()
	{
		return hashCode ?? (hashCode = GetFileHash());
	}

	internal string GetSourceCode()
	{
		using Stream stream = Open();
		using StreamReader streamReader = new StreamReader(stream);
		return streamReader.ReadToEnd();
	}

	private string GetFileHash()
	{
		if (physicalPath == null)
		{
			return HostingEnvironment.VirtualPathProvider.GetFileHash(VirtualPath, null);
		}
		if (!File.Exists(physicalPath))
		{
			return "";
		}
		using SHA256 sHA = SHA256.Create();
		using FileStream inputStream = File.OpenRead(physicalPath);
		return Convert.ToBase64String(sHA.ComputeHash(inputStream)).TrimEnd('=');
	}

	public Stream Open()
	{
		if (physicalPath == null)
		{
			return file.Open();
		}
		return File.OpenRead(physicalPath);
	}

	public override string ToString()
	{
		return VirtualPath;
	}
}

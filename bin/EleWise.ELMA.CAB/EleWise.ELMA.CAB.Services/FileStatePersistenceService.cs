using System;
using System.Globalization;
using System.IO;

namespace EleWise.ELMA.CAB.Services;

public class FileStatePersistenceService : StreamStatePersistenceService
{
	private readonly string fileNameFormat = "{0}.state";

	private string basePath;

	public string BasePath
	{
		get
		{
			return basePath;
		}
		set
		{
			basePath = new DirectoryInfo(value).FullName;
		}
	}

	public FileStatePersistenceService()
		: this(AppDomain.CurrentDomain.BaseDirectory)
	{
	}

	public FileStatePersistenceService(string basePath)
	{
		BasePath = basePath;
	}

	public override bool Contains(string id)
	{
		return File.Exists(GetFileName(id));
	}

	public override void RemoveStream(string id)
	{
		string fileName = GetFileName(id);
		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}
	}

	protected override Stream GetStream(string id)
	{
		string fileName = GetFileName(id);
		return new FileStream(fileName, File.Exists(fileName) ? FileMode.Open : FileMode.Create, FileAccess.ReadWrite);
	}

	private string GetFileName(string id)
	{
		return Path.Combine(basePath, string.Format(CultureInfo.InvariantCulture, fileNameFormat, new object[1] { id }));
	}
}

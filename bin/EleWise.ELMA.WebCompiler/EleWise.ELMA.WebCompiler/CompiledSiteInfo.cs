using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using Newtonsoft.Json;

namespace EleWise.ELMA.WebCompiler;

internal class CompiledSiteInfo
{
	public const string Extension = ".moduleinfo";

	private Dictionary<string, CompiledFileInfo> filesDictionary;

	[JsonIgnore]
	private Dictionary<string, Assembly> cacheAssemblies = new Dictionary<string, Assembly>(StringComparer.OrdinalIgnoreCase);

	[JsonIgnore]
	protected ICompilerConsole console;

	[JsonIgnore]
	protected string precompiledDirectory;

	[JsonIgnore]
	protected long hashCode;

	[JsonIgnore]
	protected bool debug;

	[JsonIgnore]
	public bool IsInitialized => filesDictionary != null;

	public CompiledFileInfo[] Files
	{
		get
		{
			if (filesDictionary == null)
			{
				return null;
			}
			return filesDictionary.Values.ToArray();
		}
		set
		{
			AddFiles(value);
		}
	}

	[Obsolete("Не использовать, необходим для десериалиации", true)]
	public CompiledSiteInfo()
	{
	}

	public CompiledSiteInfo(string webPhysicalPath, ICompilerConsole console, bool debug)
	{
		this.debug = debug;
		precompiledDirectory = GetPrecompiledDirectory(webPhysicalPath);
		this.console = console;
	}

	public bool HasChanges(ICollection<CompilingFileInfo> newFileInfos)
	{
		if (!IsInitialized || newFileInfos.Count != filesDictionary.Count)
		{
			return true;
		}
		foreach (CompilingFileInfo newFileInfo in newFileInfos)
		{
			string value = newFileInfo.GetHashCode();
			CompiledFileInfo compiledFileInfo = GetCompiledFileInfo(newFileInfo.VirtualPath);
			if (compiledFileInfo == null || (compiledFileInfo.HashCode != null && !compiledFileInfo.HashCode.Equals(value)))
			{
				return true;
			}
		}
		return false;
	}

	public virtual void Save(IEnumerable<CompiledFileInfo> filesInfo, IEnumerable<CompiledAssemblyInfo> assembliesInfo)
	{
		filesDictionary = filesInfo.ToDictionary((CompiledFileInfo f) => f.VirtualPath, StringComparer.OrdinalIgnoreCase);
		if (Directory.Exists(precompiledDirectory))
		{
			string[] files = Directory.GetFiles(precompiledDirectory, "*", SearchOption.TopDirectoryOnly);
			foreach (string text in files)
			{
				try
				{
					console.WriteDebug($"Remove file {text}");
					File.Delete(text);
				}
				catch (IOException)
				{
				}
			}
		}
		else if (assembliesInfo.Any((CompiledAssemblyInfo info) => info.AssemblyRaw != null))
		{
			CreatePrecompiledDirectory();
		}
		cacheAssemblies = new Dictionary<string, Assembly>(StringComparer.OrdinalIgnoreCase);
		foreach (CompiledAssemblyInfo item in assembliesInfo.Where((CompiledAssemblyInfo assemblyInfo) => assemblyInfo.AssemblyRaw != null))
		{
			item.Write(precompiledDirectory, console);
		}
		string infoFileFullName = Path.Combine(precompiledDirectory, assembliesInfo.Select((CompiledAssemblyInfo info) => info.AssemblyName).First() + ".moduleinfo");
		using FileStream stream = GetInfoFileStream(infoFileFullName);
		using StreamWriter writer = new StreamWriter(stream);
		SaveInternal(writer);
	}

	protected virtual FileStream GetInfoFileStream(string infoFileFullName)
	{
		return File.Open(infoFileFullName, FileMode.OpenOrCreate);
	}

	public bool TryLoad()
	{
		if (Directory.Exists(precompiledDirectory))
		{
			string siteInfoFileName = GetSiteInfoFileName();
			if (!string.IsNullOrEmpty(siteInfoFileName))
			{
				using (FileStream stream = GetInfoFileStream(siteInfoFileName))
				{
					return TryLoad(new StreamReader(stream));
				}
			}
		}
		return false;
	}

	protected bool TryLoad(StreamReader sr)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		string name = ((FileStream)sr.BaseStream).Name;
		if (name != null)
		{
			long fileHashCode = GetFileHashCode(name);
			if (hashCode != fileHashCode)
			{
				CompiledSiteInfo compiledSiteInfo = (CompiledSiteInfo)new JsonSerializer().Deserialize((TextReader)sr, typeof(CompiledSiteInfo));
				hashCode = fileHashCode;
				if (compiledSiteInfo != null)
				{
					filesDictionary = compiledSiteInfo.Files.ToDictionary((CompiledFileInfo f) => f.VirtualPath, StringComparer.OrdinalIgnoreCase);
				}
				return true;
			}
		}
		return false;
	}

	public void AddFiles(IEnumerable<CompiledFileInfo> files)
	{
		if (filesDictionary == null)
		{
			filesDictionary = new Dictionary<string, CompiledFileInfo>();
		}
		foreach (CompiledFileInfo file in files)
		{
			file.LastUseDate = DateTime.UtcNow;
			filesDictionary[file.VirtualPath] = file;
		}
	}

	public bool TryLoadAssembly(string assemblyUid, AssemblyLoader assemblyLoader, out Assembly assembly)
	{
		assembly = null;
		string path = Path.Combine(precompiledDirectory, assemblyUid + ".dll");
		if (!File.Exists(path))
		{
			return false;
		}
		string path2 = Path.ChangeExtension(path, ".pdb");
		console.WriteInfo($"Loading assembly {assemblyUid}");
		CompiledAssemblyInfo compiledAssemblyInfo = new CompiledAssemblyInfo
		{
			AssemblyName = assemblyUid,
			AssemblyRaw = File.ReadAllBytes(path),
			DebugRaw = ((debug && File.Exists(path2)) ? File.ReadAllBytes(path2) : null)
		};
		try
		{
			assembly = compiledAssemblyInfo.Load(assemblyLoader, console);
		}
		catch (IOException)
		{
			return false;
		}
		return true;
	}

	public virtual bool? TryGetCompiledType(CompilingFileInfo fileInfo, AssemblyLoader assemblyLoader, out Type type)
	{
		type = null;
		if (!IsInitialized)
		{
			return false;
		}
		CompiledFileInfo compiledFileInfo = GetCompiledFileInfo(fileInfo.VirtualPath);
		if (compiledFileInfo == null)
		{
			return null;
		}
		if (NeedRecompile(fileInfo, compiledFileInfo))
		{
			return false;
		}
		type = GetType(compiledFileInfo, assemblyLoader);
		return type != null;
	}

	protected bool NeedRecompile(CompilingFileInfo fileInfo, CompiledFileInfo compiledFileInfo)
	{
		if (compiledFileInfo.HashCode != null && !compiledFileInfo.HashCode.Equals(fileInfo.GetHashCode()))
		{
			return true;
		}
		if (compiledFileInfo.Errors != null && compiledFileInfo.Errors.Count > 0)
		{
			throw GetHttpParseException(compiledFileInfo.VirtualPath, fileInfo, compiledFileInfo.Errors.First());
		}
		return false;
	}

	protected internal CompiledFileInfo GetCompiledFileInfo(string virtualPath)
	{
		if (!IsInitialized || !filesDictionary.TryGetValue(virtualPath, out var value))
		{
			return null;
		}
		return value;
	}

	protected string GetSiteInfoFileName()
	{
		return Directory.GetFiles(precompiledDirectory, "*.moduleinfo", SearchOption.TopDirectoryOnly).OrderByDescending(File.GetLastWriteTime).FirstOrDefault();
	}

	protected long GetFileHashCode(string fileName)
	{
		FileInfo fileInfo = new FileInfo(fileName);
		long num = 5381L;
		num = ((num << 5) + num) ^ fileName.GetHashCode();
		num = ((num << 5) + num) ^ fileInfo.CreationTimeUtc.GetHashCode();
		num = ((num << 5) + num) ^ fileInfo.LastWriteTimeUtc.GetHashCode();
		return ((num << 5) + num) ^ fileInfo.Length.GetHashCode();
	}

	protected void RemoveFile(CompiledFileInfo fileInfo)
	{
		if (filesDictionary != null)
		{
			filesDictionary.Remove(fileInfo.VirtualPath);
		}
	}

	protected void SaveInternal(StreamWriter writer)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		string name = ((FileStream)writer.BaseStream).Name;
		console.WriteDebug($"Write file {name}");
		JsonSerializer val = new JsonSerializer();
		val.set_Formatting((Formatting)1);
		val.Serialize((TextWriter)writer, (object)this);
		hashCode = GetFileHashCode(name);
	}

	protected void CreatePrecompiledDirectory()
	{
		string asRelativeToCurrentDirectory = GetAsRelativeToCurrentDirectory(Path.GetFullPath(Path.Combine(precompiledDirectory, "..")));
		if (!Directory.Exists(asRelativeToCurrentDirectory))
		{
			Directory.CreateDirectory(asRelativeToCurrentDirectory).Attributes |= FileAttributes.Hidden;
		}
		Directory.CreateDirectory(precompiledDirectory);
	}

	protected HttpParseException GetHttpParseException(string virtualPath, CompilingFileInfo fileInfo, WebCompileDiagnostic error)
	{
		return new HttpParseException(error.Message, null, virtualPath.Replace("~", ""), fileInfo.GetSourceCode(), (error.Position != null) ? (error.Position.Line + 1) : 0);
	}

	protected virtual Type GetType(CompiledFileInfo compiledFileInfo, AssemblyLoader assemblyLoader)
	{
		if (cacheAssemblies.TryGetValue(compiledFileInfo.AssemblyUid, out var value) || TryLoadAssembly(compiledFileInfo.AssemblyUid, assemblyLoader, out value))
		{
			cacheAssemblies[compiledFileInfo.AssemblyUid] = value;
			return cacheAssemblies[compiledFileInfo.AssemblyUid].GetType(compiledFileInfo.ClassName);
		}
		return null;
	}

	protected string GetPrecompiledDirectory(string webPhysicalPath)
	{
		return GetAsRelativeToCurrentDirectory(Path.Combine(webPhysicalPath, "App_Data", "Precompiled"));
	}

	protected string GetAsRelativeToCurrentDirectory(string absolutePath)
	{
		string currentDirectory = Environment.CurrentDirectory;
		absolutePath = Path.GetFullPath(absolutePath);
		string[] array = currentDirectory.Split('\\');
		string[] array2 = absolutePath.Split('\\');
		int num = Math.Min(array.Length, array2.Length);
		int i;
		for (i = 0; i <= num && i != num && array[i].Equals(array2[i], StringComparison.InvariantCultureIgnoreCase); i++)
		{
		}
		if (i == 0)
		{
			return absolutePath;
		}
		string text = string.Join("\\", Enumerable.Repeat("..", array.Length - i).Concat(array2.Skip(i)));
		if (text.Length >= absolutePath.Length)
		{
			return absolutePath;
		}
		return text;
	}
}

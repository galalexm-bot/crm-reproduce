using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace EleWise.ELMA.WebCompiler;

internal class CompiledConfigSiteInfo : CompiledSiteInfo
{
	private const string LockName = "WebConfigApplicationBuildManagerLockKey";

	private const int MaxTryingNumber = 500;

	private const int TryingTimeout = 200;

	private readonly ConcurrentDictionary<string, Type> cacheTypes = new ConcurrentDictionary<string, Type>();

	[Obsolete("Не использовать, необходим для десериалиации", true)]
	internal CompiledConfigSiteInfo()
	{
	}

	internal CompiledConfigSiteInfo(string webPhysicalPath, ICompilerConsole console, bool debug)
		: base(webPhysicalPath, console, debug)
	{
	}

	public override void Save(IEnumerable<CompiledFileInfo> filesInfo, IEnumerable<CompiledAssemblyInfo> assembliesInfo)
	{
		if (!Directory.Exists(precompiledDirectory))
		{
			CreatePrecompiledDirectory();
		}
		using (FileStream stream = GetInfoFileStream(GetSiteInfoFileName() ?? Path.Combine(precompiledDirectory, "WebModule__" + Guid.NewGuid().ToString("n") + ".moduleinfo")))
		{
			TryLoad(new StreamReader(stream));
			AddFiles(filesInfo);
			using StreamWriter writer = new StreamWriter(stream);
			SaveInternal(writer);
		}
		assembliesInfo.FirstOrDefault((CompiledAssemblyInfo info) => info.AssemblyRaw != null)?.Write(precompiledDirectory, console);
	}

	protected override FileStream GetInfoFileStream(string infoFileFullName)
	{
		for (int i = 0; i < 500; i++)
		{
			if (i > 0)
			{
				Thread.Sleep(200);
			}
			try
			{
				return File.Open(infoFileFullName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
			}
			catch (IOException)
			{
			}
		}
		throw new TimeoutException($"The file access timeout has expired: {infoFileFullName}");
	}

	public void UpdateVisitedPath(IEnumerable<string> paths)
	{
		IEnumerable<CompiledFileInfo> enumerable = from path in paths
			select GetCompiledFileInfo(path) into fileInfo
			where fileInfo != null && fileInfo.LastUseDate.Date < DateTime.UtcNow.Date
			select fileInfo;
		if (!enumerable.Any())
		{
			return;
		}
		using (FileStream stream = GetInfoFileStream(GetSiteInfoFileName()))
		{
			TryLoad(new StreamReader(stream));
			foreach (CompiledFileInfo item in enumerable)
			{
				item.LastUseDate = DateTime.UtcNow;
			}
			using StreamWriter writer = new StreamWriter(stream);
			SaveInternal(writer);
		}
		foreach (CompiledFileInfo item2 in enumerable)
		{
			try
			{
				File.SetLastAccessTimeUtc(Path.Combine(precompiledDirectory, item2.AssemblyUid + ".dll"), DateTime.UtcNow);
			}
			catch (IOException)
			{
			}
		}
	}

	public void DeleteExpiredVirtualPath(DateTime lastPossibleDate)
	{
		if (!base.IsInitialized || !base.Files.Any((CompiledFileInfo f) => f.LastUseDate.Date < lastPossibleDate))
		{
			return;
		}
		using (FileStream stream = GetInfoFileStream(GetSiteInfoFileName()))
		{
			TryLoad(new StreamReader(stream));
			foreach (CompiledFileInfo item in base.Files.Where((CompiledFileInfo f) => f.LastUseDate.Date < lastPossibleDate))
			{
				RemoveFile(item);
			}
			using StreamWriter writer = new StreamWriter(stream);
			SaveInternal(writer);
		}
		string[] files = Directory.GetFiles(precompiledDirectory, "*.dll", SearchOption.TopDirectoryOnly);
		foreach (string path in files)
		{
			if (File.GetLastAccessTimeUtc(path).Date < lastPossibleDate)
			{
				try
				{
					File.Delete(path);
				}
				catch (IOException)
				{
				}
				try
				{
					File.Delete(Path.ChangeExtension(path, ".pdb"));
				}
				catch (IOException)
				{
				}
			}
		}
	}

	protected override Type GetType(CompiledFileInfo fileInfo, AssemblyLoader assemblyLoader)
	{
		Assembly assembly;
		return cacheTypes.GetOrAdd(fileInfo.AssemblyUid, (string assemblyName) => TryLoadAssembly(assemblyName, assemblyLoader, out assembly) ? assembly.GetType(fileInfo.ClassName) : null);
	}
}

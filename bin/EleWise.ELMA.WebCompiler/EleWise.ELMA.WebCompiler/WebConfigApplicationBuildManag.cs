using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EleWise.ELMA.WebCompiler;

public class WebConfigApplicationBuildManager : WebModuleBuildManager
{
	private readonly WebApplicationCompiler applicationCompiler;

	private readonly ConcurrentDictionary<string, object> lockCompile = new ConcurrentDictionary<string, object>();

	private readonly ReaderWriterLockSlim visitLock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);

	private HashSet<string> visitedPath = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

	private DateTime lastUpdate = DateTime.Today;

	private DateTime nextDeleteExpiredViews = DateTime.Now;

	private long nextUpdateVisitedPath = DateTime.Now.Ticks;

	private static readonly long UpdateTimeoutInTicks = TimeSpan.FromHours(1.0).Ticks;

	private static readonly TimeSpan DeleteExpiredViewsTimeout = TimeSpan.FromDays(7.0);

	public WebConfigApplicationBuildManager(WebApplicationCompiler applicationCompiler, string physicalPath)
		: base(applicationCompiler, physicalPath, null, "", new CompiledConfigSiteInfo(physicalPath, applicationCompiler.console, applicationCompiler.Debug))
	{
		this.applicationCompiler = applicationCompiler;
	}

	public override Type GetViewType(CompilingFileInfo fileInfo)
	{
		using (@lock.ReadLock())
		{
			if (currentSiteInfo.TryGetCompiledType(fileInfo, assemblyLoader, out var type) == true)
			{
				return type;
			}
		}
		lock (lockCompile.GetOrAdd(fileInfo.VirtualPath, (string _) => new object()))
		{
			using (@lock.WriteLock())
			{
				if (currentSiteInfo.TryLoad() && currentSiteInfo.TryGetCompiledType(fileInfo, assemblyLoader, out var type2) == true)
				{
					return type2;
				}
			}
			string baseAssemblyName = "WebView_" + fileInfo.VirtualPath.Replace("/", "_").Replace("~", "").Replace(".", "_") + "_";
			SingleFileCompiler singleFileCompiler = new SingleFileCompiler(applicationCompiler.PhysicalPath, base.PhysicalPath, fileInfo, "ASP_Config", baseAssemblyName, applicationCompiler.AdditionalModules, applicationCompiler.compiler, console, applicationCompiler.GetAssemblyLocation)
			{
				Debug = (applicationCompiler.Debug && !fileInfo.VirtualPath.StartsWith("~")),
				RetryCompileWithoutFailedFiles = false,
				IgnoreParseError = applicationCompiler.IgnoreParseError
			};
			singleFileCompiler.BeforeCompile += applicationCompiler.BeforeCompile;
			try
			{
				singleFileCompiler.Compile();
			}
			catch (WebCompileException)
			{
			}
			using (@lock.WriteLock())
			{
				if (singleFileCompiler.FileInfo != null)
				{
					CompiledAssemblyInfo compiledAssemblyInfo = new CompiledAssemblyInfo
					{
						AssemblyName = singleFileCompiler.AssemblyUid,
						AssemblyRaw = singleFileCompiler.AssemblyRaw,
						DebugRaw = ((applicationCompiler.Debug && singleFileCompiler.DebugRaw != null) ? singleFileCompiler.DebugRaw : null)
					};
					currentSiteInfo.Save(new CompiledFileInfo[1] { singleFileCompiler.FileInfo }, new CompiledAssemblyInfo[1] { compiledAssemblyInfo });
				}
				lockCompile.TryRemove(fileInfo.VirtualPath, out var _);
				if (currentSiteInfo.TryGetCompiledType(fileInfo, assemblyLoader, out var type3) == true)
				{
					return type3;
				}
			}
		}
		return null;
	}

	public void Visit(string virtualPath)
	{
		long num = nextUpdateVisitedPath;
		if (currentSiteInfo.IsInitialized && DateTime.Now.Ticks >= num)
		{
			long value = DateTime.Now.Ticks + UpdateTimeoutInTicks;
			if (Interlocked.CompareExchange(ref nextUpdateVisitedPath, value, num) == num)
			{
				new Thread((ThreadStart)delegate
				{
					UpdateVisitedPath();
					DeleteExpiredVirtualPath();
				}).Start();
			}
		}
		visitLock.EnterReadLock();
		try
		{
			if (visitedPath.Contains(virtualPath))
			{
				return;
			}
		}
		finally
		{
			if (visitLock.IsReadLockHeld)
			{
				visitLock.ExitReadLock();
			}
		}
		visitLock.EnterWriteLock();
		try
		{
			visitedPath.Add(virtualPath);
		}
		finally
		{
			if (visitLock.IsWriteLockHeld)
			{
				visitLock.ExitWriteLock();
			}
		}
	}

	private void UpdateVisitedPath()
	{
		visitLock.EnterReadLock();
		List<string> paths;
		try
		{
			paths = visitedPath.ToList();
		}
		finally
		{
			if (visitLock.IsReadLockHeld)
			{
				visitLock.ExitReadLock();
			}
		}
		if (lastUpdate.Date < DateTime.Today)
		{
			visitLock.EnterWriteLock();
			try
			{
				paths = visitedPath.ToList();
				visitedPath = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
				lastUpdate = DateTime.Today;
			}
			finally
			{
				if (visitLock.IsWriteLockHeld)
				{
					visitLock.ExitWriteLock();
				}
			}
		}
		((CompiledConfigSiteInfo)currentSiteInfo).UpdateVisitedPath(paths);
	}

	private void DeleteExpiredVirtualPath()
	{
		if (!(DateTime.Now >= nextDeleteExpiredViews))
		{
			((CompiledConfigSiteInfo)currentSiteInfo).DeleteExpiredVirtualPath(DateTime.UtcNow.AddMonths(-1));
			nextDeleteExpiredViews = DateTime.Now.Add(DeleteExpiredViewsTimeout);
		}
	}
}

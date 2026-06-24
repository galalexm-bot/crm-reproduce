using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Timers;
using System.Web.Compilation;
using EleWise.ELMA.Logging;
using Orchard.Exceptions;
using Orchard.FileSystems.VirtualPath;
using Orchard.Logging;

namespace Orchard.Environment;

public class ViewsBackgroundCompilation : IViewsBackgroundCompilation
{
	public class CompilationContext
	{
		public IEnumerable<string> DirectoriesToBrowse { get; set; }

		public IEnumerable<string> FileExtensionsToCompile { get; set; }

		public HashSet<string> ProcessedDirectories { get; set; }
	}

	private readonly IVirtualPathProvider _virtualPathProvider;

	private volatile bool _stopping;

	public ILogger Logger { get; set; }

	public ViewsBackgroundCompilation(IVirtualPathProvider virtualPathProvider)
	{
		_virtualPathProvider = virtualPathProvider;
		Logger = NullLogger.Instance;
	}

	public void Start()
	{
		_stopping = false;
		Timer timer = new Timer();
		timer.Elapsed += CompileViews;
		timer.Interval = TimeSpan.FromMilliseconds(1500.0).TotalMilliseconds;
		timer.AutoReset = false;
		timer.Start();
	}

	public void Stop()
	{
		_stopping = true;
	}

	private void CompileViews(object sender, ElapsedEventArgs elapsedEventArgs)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		Logger.Information("Starting background compilation of views");
		((Timer)sender).Stop();
		CompilationContext context = new CompilationContext
		{
			DirectoriesToBrowse = new string[21]
			{
				"~/Modules/Orchard.Setup/Views", "~/Themes/SafeMode/Views", "~/Core/Contents/Views", "~/Core/Common/Views", "~/Core/Settings/Views", "~/Core/Dashboard/Views", "~/Themes/TheAdmin/Views", "~/Modules/Orchard.PublishLater/Views", "~/Modules/Orchard.ContentTypes/Views", "~/Modules/TinyMce/Views",
				"~/Modules/Orchard.Tags/Views", "~/Core/Navigation/Views", "~/Core/Settings/Views", "~/Core/Containers/Views", "~/Modules/Orchard.Widgets/Views", "~/Modules/Orchard.Users/Views", "~/Modules/Orchard.MediaLibrary/Views", "~/Modules/Orchard.Comments/Views", "~/Core", "~/Modules",
				"~/Themes"
			},
			FileExtensionsToCompile = new string[1] { ".cshtml" },
			ProcessedDirectories = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		};
		IEnumerable<string> enumerable = context.DirectoriesToBrowse.SelectMany((string folder) => GetViewDirectories(folder, context.FileExtensionsToCompile));
		int num = 0;
		foreach (string item in enumerable)
		{
			if (_stopping)
			{
				if (!Logger.IsEnabled(LogLevel.Information))
				{
					break;
				}
				List<string> list = enumerable.Except(context.ProcessedDirectories).ToList();
				Logger.Information("Background compilation stopped before all directories were processed ({0} directories left)", list.Count);
				foreach (string item2 in list)
				{
					Logger.Information("Directory not processed: '{0}'", item2);
				}
				break;
			}
			CompileDirectory(context, item);
			num++;
		}
		stopwatch.Stop();
		Logger.Information("Ending background compilation of views, {0} directories processed in {1} sec", num, stopwatch.Elapsed.TotalSeconds);
	}

	private void CompileDirectory(CompilationContext context, string viewDirectory)
	{
		if (context.ProcessedDirectories.Contains(viewDirectory))
		{
			return;
		}
		context.ProcessedDirectories.Add(viewDirectory);
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		try
		{
			string text = (from f in _virtualPathProvider.ListFiles(viewDirectory)
				where context.FileExtensionsToCompile.Any((string e) => f.EndsWith(e, StringComparison.OrdinalIgnoreCase))
				select f).FirstOrDefault();
			if (text != null)
			{
				BuildManager.GetCompiledAssembly(text);
			}
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			Logger.Information(ex, "Compilation of directory '{0}' skipped", viewDirectory);
		}
		stopwatch.Stop();
		Logger.Information("Directory '{0}' compiled in {1} msec", viewDirectory, stopwatch.ElapsedMilliseconds);
	}

	private IEnumerable<string> GetViewDirectories(string directory, IEnumerable<string> extensions)
	{
		List<string> list = new List<string>();
		GetViewDirectories(_virtualPathProvider, directory, extensions, list);
		return list;
	}

	private static void GetViewDirectories(IVirtualPathProvider vpp, string directory, IEnumerable<string> extensions, ICollection<string> files)
	{
		if ((from f in vpp.ListFiles(directory)
			where extensions.Any((string e) => f.EndsWith(e, StringComparison.OrdinalIgnoreCase))
			select f).Any())
		{
			files.Add(directory);
		}
		foreach (string item in vpp.ListDirectories(directory).OrderBy((string d) => d, StringComparer.OrdinalIgnoreCase))
		{
			GetViewDirectories(vpp, item, extensions, files);
		}
	}
}

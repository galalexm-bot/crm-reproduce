using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using EleWise.ELMA.Logging;
using Orchard.Environment.Extensions.Loaders;
using Orchard.Environment.Extensions.Models;
using Orchard.FileSystems.Dependencies;

namespace Orchard.Environment.Extensions;

public class ExtensionLoadingContext
{
	private bool _restartAppDomain;

	public IDictionary<string, ExtensionProbeEntry> ProcessedExtensions { get; private set; }

	public IDictionary<string, ExtensionReferenceProbeEntry> ProcessedReferences { get; private set; }

	public IList<DependencyDescriptor> NewDependencies { get; private set; }

	public IList<Action> DeleteActions { get; private set; }

	public IList<Action> CopyActions { get; private set; }

	public bool RestartAppDomain
	{
		get
		{
			return _restartAppDomain;
		}
		set
		{
			try
			{
				if (value)
				{
					throw new Exception("RestartAppDomain = true");
				}
			}
			catch (Exception exception)
			{
				Logger.Fatal("Restart AppDomain requested", exception);
			}
			_restartAppDomain = value;
		}
	}

	public ILogger Logger { get; set; }

	public ConcurrentDictionary<string, DateTime> VirtualPathModficationDates { get; set; }

	public List<ExtensionDescriptor> AvailableExtensions { get; set; }

	public List<DependencyDescriptor> PreviousDependencies { get; set; }

	public List<DependencyDescriptor> DeletedDependencies { get; set; }

	public IDictionary<string, IEnumerable<ExtensionProbeEntry>> AvailableExtensionsProbes { get; set; }

	public IDictionary<string, IEnumerable<ExtensionReferenceProbeEntry>> ReferencesByModule { get; set; }

	public IDictionary<string, IEnumerable<ExtensionReferenceProbeEntry>> ReferencesByName { get; set; }

	public ExtensionLoadingContext()
	{
		ProcessedExtensions = new Dictionary<string, ExtensionProbeEntry>(StringComparer.OrdinalIgnoreCase);
		ProcessedReferences = new Dictionary<string, ExtensionReferenceProbeEntry>(StringComparer.OrdinalIgnoreCase);
		DeleteActions = new List<Action>();
		CopyActions = new List<Action>();
		NewDependencies = new List<DependencyDescriptor>();
		Logger = NullLogger.Instance;
	}
}

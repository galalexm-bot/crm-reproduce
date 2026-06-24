using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Orchard.Caching;
using Orchard.Environment.Extensions.Models;
using Orchard.FileSystems.Dependencies;

namespace Orchard.Environment.Extensions.Loaders;

public abstract class ExtensionLoaderBase : IExtensionLoader
{
	private readonly IDependenciesFolder _dependenciesFolder;

	public abstract int Order { get; }

	public string Name => GetType().Name;

	protected ExtensionLoaderBase(IDependenciesFolder dependenciesFolder)
	{
		_dependenciesFolder = dependenciesFolder;
	}

	public virtual IEnumerable<ExtensionReferenceProbeEntry> ProbeReferences(ExtensionDescriptor descriptor)
	{
		return Enumerable.Empty<ExtensionReferenceProbeEntry>();
	}

	public virtual Assembly LoadReference(DependencyReferenceDescriptor reference)
	{
		return null;
	}

	public virtual bool IsCompatibleWithModuleReferences(ExtensionDescriptor extension, IEnumerable<ExtensionProbeEntry> references)
	{
		return true;
	}

	public abstract ExtensionProbeEntry Probe(ExtensionDescriptor descriptor);

	public ExtensionEntry Load(ExtensionDescriptor descriptor)
	{
		DependencyDescriptor descriptor2 = _dependenciesFolder.GetDescriptor(descriptor.Id);
		if (descriptor2 != null && descriptor2.LoaderName == Name)
		{
			return LoadWorker(descriptor);
		}
		return null;
	}

	public virtual void ReferenceActivated(ExtensionLoadingContext context, ExtensionReferenceProbeEntry referenceEntry)
	{
	}

	public virtual void ReferenceDeactivated(ExtensionLoadingContext context, ExtensionReferenceProbeEntry referenceEntry)
	{
	}

	public virtual void ExtensionActivated(ExtensionLoadingContext ctx, ExtensionDescriptor extension)
	{
	}

	public virtual void ExtensionDeactivated(ExtensionLoadingContext ctx, ExtensionDescriptor extension)
	{
	}

	public virtual void ExtensionRemoved(ExtensionLoadingContext ctx, DependencyDescriptor dependency)
	{
	}

	public virtual void Monitor(ExtensionDescriptor extension, Action<IVolatileToken> monitor)
	{
	}

	protected abstract ExtensionEntry LoadWorker(ExtensionDescriptor descriptor);

	public virtual IEnumerable<ExtensionCompilationReference> GetCompilationReferences(DependencyDescriptor dependency)
	{
		return Enumerable.Empty<ExtensionCompilationReference>();
	}

	public virtual IEnumerable<string> GetVirtualPathDependencies(DependencyDescriptor dependency)
	{
		return Enumerable.Empty<string>();
	}
}

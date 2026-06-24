using System;
using System.Collections.Generic;
using System.Reflection;
using Orchard.Caching;
using Orchard.Environment.Extensions.Models;
using Orchard.FileSystems.Dependencies;

namespace Orchard.Environment.Extensions.Loaders;

public interface IExtensionLoader
{
	int Order { get; }

	string Name { get; }

	IEnumerable<ExtensionReferenceProbeEntry> ProbeReferences(ExtensionDescriptor extensionDescriptor);

	Assembly LoadReference(DependencyReferenceDescriptor reference);

	void ReferenceActivated(ExtensionLoadingContext context, ExtensionReferenceProbeEntry referenceEntry);

	void ReferenceDeactivated(ExtensionLoadingContext context, ExtensionReferenceProbeEntry referenceEntry);

	bool IsCompatibleWithModuleReferences(ExtensionDescriptor extension, IEnumerable<ExtensionProbeEntry> references);

	ExtensionProbeEntry Probe(ExtensionDescriptor descriptor);

	ExtensionEntry Load(ExtensionDescriptor descriptor);

	void ExtensionActivated(ExtensionLoadingContext ctx, ExtensionDescriptor extension);

	void ExtensionDeactivated(ExtensionLoadingContext ctx, ExtensionDescriptor extension);

	void ExtensionRemoved(ExtensionLoadingContext ctx, DependencyDescriptor dependency);

	void Monitor(ExtensionDescriptor extension, Action<IVolatileToken> monitor);

	IEnumerable<ExtensionCompilationReference> GetCompilationReferences(DependencyDescriptor dependency);

	IEnumerable<string> GetVirtualPathDependencies(DependencyDescriptor dependency);
}

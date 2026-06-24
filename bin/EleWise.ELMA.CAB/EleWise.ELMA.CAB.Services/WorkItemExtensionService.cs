#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using EleWise.ELMA.CAB.Instrumentation;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Utility;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.Services;

public class WorkItemExtensionService : IWorkItemExtensionService
{
	private class ClassNameTraceSourceAttribute : TraceSourceAttribute
	{
		public ClassNameTraceSourceAttribute()
			: base(typeof(WorkItemExtensionService).FullName)
		{
		}
	}

	private readonly ListDictionary<Type, Type> extensions = new ListDictionary<Type, Type>();

	private readonly List<Type> rootExtensions = new List<Type>();

	private readonly TraceSource traceSource;

	public ReadOnlyDictionary<Type, IList<Type>> RegisteredExtensions
	{
		get
		{
			Dictionary<Type, IList<Type>> dictionary = new Dictionary<Type, IList<Type>>();
			foreach (KeyValuePair<Type, List<Type>> item in (IEnumerable<KeyValuePair<Type, List<Type>>>)extensions)
			{
				dictionary[item.Key] = item.Value.AsReadOnly();
			}
			return new ReadOnlyDictionary<Type, IList<Type>>(dictionary);
		}
	}

	public IList<Type> RegisteredRootExtensions => rootExtensions.AsReadOnly();

	public WorkItemExtensionService()
		: this(null)
	{
	}

	[InjectionConstructor]
	public WorkItemExtensionService([ClassNameTraceSource] TraceSource traceSource)
	{
		this.traceSource = traceSource;
	}

	public void RegisterExtension(Type workItemType, Type extensionType)
	{
		Guard.ArgumentNotNull(workItemType, "workItemType");
		Guard.ArgumentNotNull(extensionType, "extensionType");
		Guard.TypeIsAssignableFromType(workItemType, typeof(WorkItem), "workItemType");
		Guard.TypeIsAssignableFromType(extensionType, typeof(IWorkItemExtension), "extensionType");
		ThrowIfAlreadyAdded(workItemType, extensionType);
		extensions.Add(workItemType, extensionType);
		if (traceSource != null)
		{
			traceSource.TraceInformation(string.Format(CultureInfo.CurrentCulture, Resources.WorkItemExtensionRegistered, new object[2] { extensionType, workItemType }));
		}
	}

	public void RegisterRootExtension(Type extensionType)
	{
		Guard.ArgumentNotNull(extensionType, "extensionType");
		Guard.TypeIsAssignableFromType(extensionType, typeof(IWorkItemExtension), "extensionType");
		rootExtensions.Add(extensionType);
		if (traceSource != null)
		{
			traceSource.TraceInformation(string.Format(CultureInfo.CurrentCulture, Resources.WorkItemExtensionRootRegistered, new object[1] { extensionType }));
		}
	}

	public void InitializeExtensions(WorkItem workItem)
	{
		Guard.ArgumentNotNull(workItem, "workItem");
		InnerInitialize(workItem, GetRegisteredExtensions(workItem.GetType()));
		if (workItem.Parent == null)
		{
			InnerInitialize(workItem, rootExtensions);
		}
	}

	private void ThrowIfAlreadyAdded(Type workItemType, Type extensionType)
	{
		if (extensions.ContainsKey(workItemType) && extensions[workItemType].Contains(extensionType))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.WorkItemExtensionTypeAlreadyRegistered, new object[2] { extensionType, workItemType }));
		}
	}

	private void InnerInitialize(WorkItem workItem, IEnumerable<Type> extensions)
	{
		foreach (Type extension in extensions)
		{
			IWorkItemExtension workItemExtension = (IWorkItemExtension)workItem.Items.AddNew(extension);
			workItemExtension.Initialize(workItem);
			if (traceSource != null)
			{
				traceSource.TraceInformation(string.Format(CultureInfo.CurrentCulture, Resources.WorkItemExtensionInitialized, new object[2] { workItemExtension, workItem }));
			}
		}
	}

	private IEnumerable<Type> GetRegisteredExtensions(Type workItemType)
	{
		return extensions.FindAllValuesByKey((Type key) => key.IsAssignableFrom(workItemType));
	}
}

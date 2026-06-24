using System;
using System.Collections.Generic;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Services;

public interface IWorkItemExtensionService
{
	ReadOnlyDictionary<Type, IList<Type>> RegisteredExtensions { get; }

	IList<Type> RegisteredRootExtensions { get; }

	void InitializeExtensions(WorkItem workItem);

	void RegisterExtension(Type workItemType, Type extensionType);

	void RegisterRootExtension(Type extensionType);
}

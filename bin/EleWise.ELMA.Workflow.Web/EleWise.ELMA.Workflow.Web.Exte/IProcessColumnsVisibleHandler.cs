using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Workflow.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IProcessColumnsVisibleHandler
{
	Type EntityType { get; }

	Guid TypeUid { get; }

	bool IsVisible(ITaskBase task);
}

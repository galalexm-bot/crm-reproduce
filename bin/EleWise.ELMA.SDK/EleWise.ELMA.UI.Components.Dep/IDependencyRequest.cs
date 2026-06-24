using System;

namespace EleWise.ELMA.UI.Components.Dependency.Models;

public interface IDependencyRequest
{
	Guid ModuleUid { get; }

	Guid HeaderUid { get; }
}

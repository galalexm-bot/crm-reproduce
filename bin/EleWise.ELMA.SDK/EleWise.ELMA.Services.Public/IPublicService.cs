using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Services.Public;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ComponentType.Server)]
public interface IPublicService
{
	Guid Uid { get; }

	Guid ModuleUid { get; }

	string Name { get; }

	string Description { get; }
}

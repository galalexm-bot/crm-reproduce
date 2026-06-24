using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.Server, ForceRegister = true)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IDbStructureExtension
{
	Guid ProviderUid { get; }

	DbStructure Structure { get; }

	Version Version { get; }

	Type Parent { get; }

	Type[] References { get; }
}

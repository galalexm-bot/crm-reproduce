using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IImportTestUserAction
{
	Guid ActionUid { get; }

	string Name { get; }

	string Description { get; }
}

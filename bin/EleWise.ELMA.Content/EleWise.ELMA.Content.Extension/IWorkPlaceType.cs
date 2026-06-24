using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Content.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IWorkPlaceType
{
	string Name { get; }

	Guid Uid { get; }

	string Folder { get; }
}

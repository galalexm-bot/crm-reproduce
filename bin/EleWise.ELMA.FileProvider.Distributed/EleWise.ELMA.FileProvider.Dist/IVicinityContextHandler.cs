using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FileProvider.Distributed.Models;

namespace EleWise.ELMA.FileProvider.Distributed.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IVicinityContextHandler
{
	Guid Uid { get; }

	string Description { get; }

	string Handle(VicinityContext vicinityContext);
}

using System;
using System.Collections.Generic;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints.API;

[ExtensionPoint(ComponentType.All)]
public interface ITaskUpdatePackages
{
	Guid ServiceUid { get; }

	Guid[] TypeUids { get; }

	IEnumerable<PackageBase> ConvertPackages(IEnumerable<ITaskBase> updateIdPackages);

	IEnumerable<PackageBase> ConvertPackages(Guid serviceUid, IEnumerable<ITaskBase> updateIdPackages);
}

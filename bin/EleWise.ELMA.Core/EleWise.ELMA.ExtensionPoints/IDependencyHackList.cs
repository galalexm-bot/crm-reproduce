using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[Obsolete]
[ExtensionPoint]
public interface IDependencyHackList
{
	Guid[] TypeUids { get; }

	ValueTuple<Guid, string>[] Properties { get; }
}

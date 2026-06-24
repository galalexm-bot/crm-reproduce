using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.History.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
internal interface IHistoryCacheEnabledExtension
{
	Guid BaseObjectTypeUid { get; }
}

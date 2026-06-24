using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Services.Public;

[ExtensionPoint(ComponentType.Server)]
public interface IPublicMetadataFilter
{
	Func<IMetadata, bool> Filter { get; }
}

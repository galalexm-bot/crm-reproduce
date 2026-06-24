using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Services.Public;

[ExtensionPoint(ComponentType.Server)]
public interface IPublicMetadataProvider
{
	IEnumerable<IPublicMetadataInfo> GetMetadataInfoList();

	IEnumerable<IPublicMetadataGroupInfo> GetGroups();
}

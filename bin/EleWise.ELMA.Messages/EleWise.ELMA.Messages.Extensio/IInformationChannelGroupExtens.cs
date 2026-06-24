using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IInformationChannelGroupExtension
{
	bool IsSupport(IInformationChannel infoChannel);

	Guid GroupGuid(IInformationChannel infoChannel);
}

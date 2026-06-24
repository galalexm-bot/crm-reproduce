using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IFeedIndexesExtension
{
	bool IsSupport(Guid uidProvider);

	void Enable();

	void Disable();
}

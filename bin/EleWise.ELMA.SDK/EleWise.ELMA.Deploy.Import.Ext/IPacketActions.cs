using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Models;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[ExtensionPoint(ComponentType.Server)]
internal interface IPacketActions
{
	bool BeforeCommitAction(PacketActionArgs args);

	bool AfterCommitAction(PacketActionArgs args);

	bool ErrorAction(PacketActionArgs args, bool beforeCommit);
}

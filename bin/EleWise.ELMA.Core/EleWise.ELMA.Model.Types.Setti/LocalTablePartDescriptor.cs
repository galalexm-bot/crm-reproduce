using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Model.Types.Settings.Groups;

[Component(Order = 305)]
internal sealed class LocalTablePartDescriptor : TablePartDescriptor
{
	public new static readonly Guid UID = TypeConstants.LocalTablePartUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Блоки");

	public override Guid ParentUid => Guid.Empty;

	public override bool Visible => true;

	public LocalTablePartDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(proxyGeneratorService, extendEntityService, logger)
	{
	}
}

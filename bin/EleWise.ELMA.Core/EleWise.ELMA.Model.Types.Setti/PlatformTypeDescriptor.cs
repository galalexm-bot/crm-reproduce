using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Model.Types.Settings.Groups;

[Component(Order = 300)]
public sealed class PlatformTypeDescriptor : EntityDescriptor
{
	public new static readonly Guid UID = TypeConstants.PlatformTypeUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Объекты платформы");

	public override Guid ParentUid => Guid.Empty;

	public PlatformTypeDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(proxyGeneratorService, extendEntityService, logger)
	{
	}
}

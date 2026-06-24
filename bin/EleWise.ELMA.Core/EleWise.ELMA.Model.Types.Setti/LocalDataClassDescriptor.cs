using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Model.Types.Settings.Groups;

[Component(Order = 305)]
internal sealed class LocalDataClassDescriptor : DataClassDescriptor
{
	public new static readonly Guid UID = TypeConstants.LocalDataClassUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Внутренние структуры обмена данными");

	public override Guid ParentUid => Guid.Empty;

	public LocalDataClassDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(proxyGeneratorService, extendEntityService, logger)
	{
	}
}

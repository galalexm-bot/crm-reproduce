using System;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Model.Types;

public abstract class EntitySubTypeDescriptor : EntityDescriptor
{
	public override Guid SubTypeUid => EntityUid;

	public override bool Visible => false;

	protected abstract Guid EntityUid { get; }

	protected EntitySubTypeDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(proxyGeneratorService, extendEntityService, logger)
	{
	}
}

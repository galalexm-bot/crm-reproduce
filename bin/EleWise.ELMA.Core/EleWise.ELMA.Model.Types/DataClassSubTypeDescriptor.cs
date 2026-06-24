using System;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Model.Types;

public abstract class DataClassSubTypeDescriptor : DataClassDescriptor
{
	public override Guid SubTypeUid => DataClassUid;

	public override bool Visible => false;

	protected abstract Guid DataClassUid { get; }

	protected DataClassSubTypeDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(proxyGeneratorService, extendEntityService, logger)
	{
	}
}

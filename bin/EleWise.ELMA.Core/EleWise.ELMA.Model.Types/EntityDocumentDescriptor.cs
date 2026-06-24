using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types;

internal sealed class EntityDocumentDescriptor : EntitySubTypeDescriptor
{
	protected override Guid EntityUid => MetadataConstants.DocumentMetadataTypeUid;

	public override string Name => SR.T("Документ");

	public override bool Visible => false;

	public EntityDocumentDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(proxyGeneratorService, extendEntityService, logger)
	{
	}
}

using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Security;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types;

internal sealed class EntityOrganizationItemDescriptor : EntitySubTypeDescriptor
{
	protected override Guid EntityUid => MetadataConstants.OrganizationItemTypeUid;

	public override string Name => SR.T("Элемент оргструктуры");

	public override bool Visible => false;

	public override System.Type SettingsType => typeof(OrganizationItemSettings);

	public EntityOrganizationItemDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(proxyGeneratorService, extendEntityService, logger)
	{
	}
}

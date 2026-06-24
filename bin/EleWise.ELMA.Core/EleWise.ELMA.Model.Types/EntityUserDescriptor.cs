using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Security;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types;

internal sealed class EntityUserDescriptor : EntitySubTypeDescriptor
{
	protected override Guid EntityUid => MetadataConstants.EntityUserTypeUid;

	public override string Name => SR.T("Пользователь");

	public override bool Visible => false;

	public override System.Type SettingsType => typeof(EntityUserSettings);

	public EntityUserDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(proxyGeneratorService, extendEntityService, logger)
	{
	}
}

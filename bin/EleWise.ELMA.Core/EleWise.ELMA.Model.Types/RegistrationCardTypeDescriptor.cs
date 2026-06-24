using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 500)]
internal sealed class RegistrationCardTypeDescriptor : EntityDescriptor
{
	internal new static readonly Guid UID = TypeConstants.RegistrationCardTypeUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Регистрационные карточки");

	public RegistrationCardTypeDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(proxyGeneratorService, extendEntityService, logger)
	{
	}
}

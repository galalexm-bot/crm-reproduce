using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 500)]
internal sealed class ProjectTypeDescriptor : EntityDescriptor
{
	internal new static readonly Guid UID = TypeConstants.ProjectTypeUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Проекты");

	public ProjectTypeDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(proxyGeneratorService, extendEntityService, logger)
	{
	}
}

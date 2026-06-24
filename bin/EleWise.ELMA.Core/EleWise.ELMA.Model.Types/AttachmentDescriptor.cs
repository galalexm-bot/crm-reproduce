using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Model.Types;

public sealed class AttachmentDescriptor : EntitySubTypeDescriptor
{
	public const string SubTypeUID_S = "{3536c931-154c-4618-93b8-4e35bd8db226}";

	public static readonly Guid SubTypeUID = new Guid("{3536c931-154c-4618-93b8-4e35bd8db226}");

	protected override Guid EntityUid => SubTypeUID;

	public override string Name => SR.T("Вложение");

	public override bool Visible => false;

	public AttachmentDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(proxyGeneratorService, extendEntityService, logger)
	{
	}
}

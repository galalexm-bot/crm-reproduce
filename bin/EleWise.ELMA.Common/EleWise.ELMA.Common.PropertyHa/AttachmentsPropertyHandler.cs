using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.PropertyHandlers;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Common.PropertyHandlers;

[Component(Order = 300)]
public class AttachmentsPropertyHandler : TypedPropertyHandler
{
	public const string UID_S = "{81C57A64-25C0-4A7D-84A1-D018E2727460}";

	public static readonly Guid UID = new Guid("{81C57A64-25C0-4A7D-84A1-D018E2727460}");

	public override Guid Uid => UID;

	public override string Name => SR.T("Вложения");

	protected override Guid? TypeUid => EntityDescriptor.UID;

	protected override Guid? SubTypeUid => new Guid("3536c931-154c-4618-93b8-4e35bd8db226");
}

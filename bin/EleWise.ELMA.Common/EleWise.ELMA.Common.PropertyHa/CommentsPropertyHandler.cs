using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.PropertyHandlers;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Common.PropertyHandlers;

[Component(Order = 300)]
public class CommentsPropertyHandler : TypedPropertyHandler
{
	public const string UID_S = "{F05F5CD0-2F19-4A89-8920-F6A24C8AC94E}";

	public static readonly Guid UID = new Guid("{F05F5CD0-2F19-4A89-8920-F6A24C8AC94E}");

	public override Guid Uid => UID;

	public override string Name => SR.T("Комментарий");

	protected override Guid? TypeUid => EntityDescriptor.UID;

	protected override Guid? SubTypeUid => new Guid("e70b68f9-15b1-4b31-8db4-9990152bb51d");
}

using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.PropertyHandlers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Documents.PropertyHandlers;

[Component(Order = 400)]
public class DocumentAttachmentsPropertyHandler : TypedPropertyHandler
{
	public const string UID_S = "{53DF388F-023D-458E-9D1D-2D72945A6226}";

	public static readonly Guid UID = new Guid("{53DF388F-023D-458E-9D1D-2D72945A6226}");

	public override Guid Uid => UID;

	public override string Name => SR.T("Прикрепленные документы");

	protected override Guid? TypeUid => EntityDescriptor.UID;

	protected override Guid? SubTypeUid => InterfaceActivator.UID<IDocumentAttachment>(loadImplementation: false);
}

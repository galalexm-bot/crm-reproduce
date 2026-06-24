using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Audit.History;

[Component]
internal sealed class DocumentHistoryCacheEnabled : IHistoryCacheEnabledExtension
{
	private readonly Guid documentTypeUid = InterfaceActivator.UID<IDocument>();

	public Guid BaseObjectTypeUid => documentTypeUid;
}

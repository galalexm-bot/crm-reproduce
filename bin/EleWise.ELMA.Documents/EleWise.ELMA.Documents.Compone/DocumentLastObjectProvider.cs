using System;
using EleWise.ELMA.Common.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class DocumentLastObjectProvider : BaseLastObjectProvider
{
	public override Guid TypeUid => InterfaceActivator.UID<IDocument>();

	public override string DisplayName => SR.T("Документы");
}

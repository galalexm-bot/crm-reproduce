using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class SystemDocumentMetadata : ISystemDocumentMetadata
{
	public IEnumerable<Guid> TypeUid
	{
		get
		{
			yield return InterfaceActivator.UID<IFile>(loadImplementation: false);
			yield return InterfaceActivator.UID<IWebDocument>(loadImplementation: false);
		}
	}
}

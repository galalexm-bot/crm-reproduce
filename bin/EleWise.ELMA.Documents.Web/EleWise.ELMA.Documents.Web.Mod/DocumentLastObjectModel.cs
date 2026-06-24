using System;
using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentLastObjectModel : ILastObjectSettings
{
	public virtual string Version { get; set; }

	public virtual bool RestrictTypes { get; set; }

	public virtual List<Guid> ObjectTypes { get; set; }

	public virtual int ObjectCount { get; set; }

	public DocumentLastObjectModel()
	{
		Version = "DocumentLastObject";
		RestrictTypes = true;
		ObjectTypes = new List<Guid> { InterfaceActivator.UID<IDocument>() };
		ObjectCount = 15;
	}
}

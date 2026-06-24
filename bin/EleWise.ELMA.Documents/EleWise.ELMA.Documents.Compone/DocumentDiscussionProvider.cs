using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Messages.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Components;

[Component]
internal class DocumentDiscussionProvider : IDiscussionAvailableProvider
{
	public IEnumerable<Guid> TypeUids
	{
		get
		{
			EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IDocument>();
			List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(entityMetadata);
			childClasses.Add(entityMetadata);
			return childClasses.Select((ClassMetadata classMetadata) => classMetadata.Uid).ToList();
		}
	}
}

using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Components.Feed;

[Component(Order = 500)]
public class DocumentFeedObjectGroupExtension : DefaultFeedObjectGroupExtension
{
	public override string MessageTypeCssClass => "FeedTypeDocument";

	public override bool IsSupport(Guid objectTypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IDocument>(objectTypeUid);
	}
}

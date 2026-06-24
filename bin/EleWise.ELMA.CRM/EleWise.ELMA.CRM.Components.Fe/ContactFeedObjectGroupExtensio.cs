using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Components.Feed;

[Component(Order = 500)]
public class ContactFeedObjectGroupExtension : DefaultFeedObjectGroupExtension
{
	public override string MessageTypeCssClass => "FeedTypeContact";

	public override bool IsSupport(Guid objectTypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IContact>(objectTypeUid);
	}
}

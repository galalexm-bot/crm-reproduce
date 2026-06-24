using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Components.Feed;

[Component(Order = 500)]
public class LeadFeedObjectGroupExtension : DefaultFeedObjectGroupExtension
{
	public override string MessageTypeCssClass => "FeedTypeLead";

	public override bool IsSupport(Guid objectTypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<ILead>(objectTypeUid);
	}
}

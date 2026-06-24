using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Components.Feed;

[Component(Order = 1100)]
internal class FeedCommentCRMExtension : BaseFeedPostExtension
{
	public override Guid GetCommentActionUid(Guid objectUid)
	{
		Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
		Guid guid = InterfaceActivator.UID<IContact>();
		if (objectUid == guid || typeByUidOrNull.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid)))
		{
			return ContactActions.AddCommentGuid;
		}
		Type typeByUidOrNull2 = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
		Guid guid2 = InterfaceActivator.UID<ILead>();
		if (objectUid == guid2 || typeByUidOrNull2.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid2)))
		{
			return LeadActions.AddCommentGuid;
		}
		Type typeByUidOrNull3 = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
		Guid guid3 = InterfaceActivator.UID<IRelationship>();
		if (objectUid == guid3 || typeByUidOrNull3.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid3)))
		{
			return RelationshipActions.AddCommentGuid;
		}
		Type typeByUidOrNull4 = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
		Guid guid4 = InterfaceActivator.UID<IContractor>();
		if (objectUid == guid4 || typeByUidOrNull4.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid4)))
		{
			return ContractorActions.AddCommentGuid;
		}
		Type typeByUidOrNull5 = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
		Guid guid5 = InterfaceActivator.UID<ISale>();
		if (objectUid == guid5 || typeByUidOrNull5.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid5)))
		{
			return SaleActions.AddCommentGuid;
		}
		return Guid.Empty;
	}

	protected override List<Guid> CommentSupportedObject()
	{
		return new List<Guid>
		{
			InterfaceActivator.UID<IContact>(),
			InterfaceActivator.UID<ILead>(),
			InterfaceActivator.UID<IRelationship>(),
			InterfaceActivator.UID<IContractor>(),
			InterfaceActivator.UID<ISale>()
		};
	}

	public override void CanCreateComment(Guid objectUid, Dictionary<long, bool> items)
	{
		if (items != null && items.Count != 0)
		{
			CommentIsSupported(objectUid);
		}
	}

	public override Guid GetQuestionActionUid(Guid objectUid)
	{
		return Guid.Empty;
	}

	protected override List<Guid> QuestionSupportedObject()
	{
		return new List<Guid>();
	}

	public override void CanCreateQuestion(Guid objectUid, Dictionary<long, bool> items)
	{
		if (items != null && items.Count != 0)
		{
			QuestionIsSupported(objectUid);
		}
	}
}

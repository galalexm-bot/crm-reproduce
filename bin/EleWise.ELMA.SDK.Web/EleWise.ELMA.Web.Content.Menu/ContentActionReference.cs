using System;

namespace EleWise.ELMA.Web.Content.Menu;

[Serializable]
public class ContentActionReference
{
	private string actionId;

	private string actionTypeProviderId = "ActionsLinkTypeProvider";

	public string ActionId
	{
		get
		{
			return actionId;
		}
		set
		{
			actionId = value;
		}
	}

	public string ActionTypeProviderId
	{
		get
		{
			return actionTypeProviderId;
		}
		set
		{
			actionTypeProviderId = value;
		}
	}

	public ContentActionReference()
	{
	}

	public ContentActionReference(string actionId)
	{
		this.actionId = actionId;
	}

	public ContentActionReference(string actionId, string actionTypeProviderId)
	{
		this.actionId = actionId;
		this.actionTypeProviderId = actionTypeProviderId;
	}

	public override string ToString()
	{
		return $"ActionId: {actionId}, ActionTypeProviderId: {actionTypeProviderId}";
	}

	public override bool Equals(object obj)
	{
		if (!(obj is ContentActionReference contentActionReference))
		{
			return this == obj;
		}
		if (ActionId == contentActionReference.ActionId)
		{
			return ActionTypeProviderId == contentActionReference.ActionTypeProviderId;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((ActionId != null) ? ActionId.GetHashCode() : 0) * 397) ^ ((ActionTypeProviderId != null) ? ActionTypeProviderId.GetHashCode() : 0);
	}
}

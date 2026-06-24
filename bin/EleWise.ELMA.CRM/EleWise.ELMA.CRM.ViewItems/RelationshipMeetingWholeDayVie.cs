using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_RelationshipMeetingWholeDayViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IRelationshipMeeting))]
public class RelationshipMeetingWholeDayViewItem : PropertyViewItem
{
	[Component]
	private class ToolboxItem : RelationshipViewItemToolboxItem<RelationshipMeetingWholeDayViewItem>
	{
	}

	public RelationshipMeetingWholeDayViewItem()
	{
		base.Attributes.Name = SR.T("Весь день / уточнить время позже");
	}
}

using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_RelationshipMeetingSchedulesViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IRelationshipMeeting))]
public class RelationshipMeetingSchedulesViewItem : PropertyViewItem
{
	[Component]
	private class ToolboxItem : RelationshipViewItemToolboxItem<RelationshipMeetingSchedulesViewItem>
	{
	}

	public RelationshipMeetingSchedulesViewItem()
	{
		base.Attributes.Name = SR.T("Календари");
	}
}

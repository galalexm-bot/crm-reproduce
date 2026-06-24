using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Messages.Audit.History;

[Component(Order = int.MaxValue)]
internal class DiscussionActionEventMapping : IEntityActionEventMapping
{
	public EntitySerializationSettings GetEntitySerializationSettings(Type entityType)
	{
		if (entityType == null || !typeof(IDiscussionObject).IsAssignableFrom(entityType))
		{
			return null;
		}
		return new EntitySerializationSettings
		{
			PropertySelector = new EntitySerializationSelector
			{
				Properties = new Dictionary<string, EntitySerializationSelector> { 
				{
					"Message",
					new EntitySerializationSelector
					{
						SelectionMode = SelectionMode.ByName
					}
				} },
				SelectionMode = SelectionMode.ByName
			}
		};
	}
}

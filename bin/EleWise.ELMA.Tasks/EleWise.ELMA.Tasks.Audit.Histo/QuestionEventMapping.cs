using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Audit.History;

[Component(Order = int.MaxValue)]
internal sealed class QuestionEventMapping : IEntityActionEventMapping
{
	public EntitySerializationSettings GetEntitySerializationSettings(Type entityType)
	{
		if (entityType == null || !typeof(IQuestion).IsAssignableFrom(entityType))
		{
			return null;
		}
		return new EntitySerializationSettings
		{
			PropertySelector = new EntitySerializationSelector
			{
				Properties = new Dictionary<string, EntitySerializationSelector>
				{
					{
						"Answer",
						new EntitySerializationSelector
						{
							Properties = new Dictionary<string, EntitySerializationSelector>
							{
								{
									"CreationAuthor",
									new EntitySerializationSelector()
								},
								{
									"Text",
									new EntitySerializationSelector()
								},
								{
									"Attachments",
									new EntitySerializationSelector()
								},
								{
									"CreationDate",
									new EntitySerializationSelector()
								}
							},
							SelectionMode = SelectionMode.ByName
						}
					},
					{
						"Executor",
						new EntitySerializationSelector()
					}
				},
				SelectionMode = SelectionMode.All
			}
		};
	}
}

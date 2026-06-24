using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Documents.Audit.History;

[Component(Order = int.MaxValue)]
internal sealed class DocumentVersionActionEventMapping : IEntityActionEventMapping
{
	public EntitySerializationSettings GetEntitySerializationSettings(Type entityType)
	{
		if (entityType == null || !typeof(IDocumentVersion).IsAssignableFrom(entityType))
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
						"Document",
						new EntitySerializationSelector
						{
							Properties = new Dictionary<string, EntitySerializationSelector>
							{
								{
									"Comments",
									new EntitySerializationSelector()
								},
								{
									"Attachments",
									new EntitySerializationSelector()
								}
							},
							SelectionMode = SelectionMode.ByName
						}
					},
					{
						"File",
						new EntitySerializationSelector
						{
							Properties = new Dictionary<string, EntitySerializationSelector>(),
							SelectionMode = SelectionMode.ByName
						}
					}
				},
				SelectionMode = SelectionMode.ByName
			}
		};
	}
}

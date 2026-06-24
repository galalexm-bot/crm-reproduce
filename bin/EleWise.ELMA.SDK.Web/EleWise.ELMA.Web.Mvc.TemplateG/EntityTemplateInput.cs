using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;

namespace EleWise.ELMA.Web.Mvc.TemplateGenerators;

[Component]
public abstract class EntityTemplateInput<T> : IEntityTemplateInput where T : IEntity
{
	private Type[] types;

	public virtual Type[] SupportedTypes
	{
		get
		{
			if (types == null)
			{
				List<Type> list = new List<Type>();
				list.Add(InterfaceActivator.TypeOf(typeof(T)));
				if (MetadataLoader.LoadMetadata(typeof(T)) is EntityMetadata entityMetadata && entityMetadata.Type == EntityMetadataType.InterfaceImplementation)
				{
					Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityMetadata.ImplementationUid, loadImplementation: false);
					list.Add(typeByUid);
					if (entityMetadata.ImplementedExtensionUids != null)
					{
						foreach (Guid implementedExtensionUid in entityMetadata.ImplementedExtensionUids)
						{
							Type typeByUid2 = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(implementedExtensionUid, loadImplementation: false);
							list.Add(typeByUid2);
						}
					}
				}
				types = list.ToArray();
			}
			return types;
		}
	}

	public virtual string GetListSeparator(TemplateRenderMode renderMode)
	{
		return ", ";
	}

	public abstract string FormatValue(object value, TemplateRenderMode renderMode);
}

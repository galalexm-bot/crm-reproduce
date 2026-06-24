using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.PropertyHandlers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.PropertyHandlers;
using EleWise.ELMA.Tasks.ExtensionPoints;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Components.WorkLog;

internal class DefaultWorkLogObjectSearch : WorkLogObjectSearchExtensionBase
{
	private readonly Guid objectTypeUid;

	private EntityMetadata metaData;

	private readonly Type baseObjectType;

	private PropertyMetadata titleProperty;

	private PropertyMetadata creationAuthorProperty;

	private PropertyMetadata creationDateProperty;

	public override Type BaseObjectType => baseObjectType;

	public override Guid Uid => Guid.Empty;

	public DefaultWorkLogObjectSearch(Type baseObjectType, Guid objectTypeUid)
	{
		this.baseObjectType = baseObjectType;
		this.objectTypeUid = objectTypeUid;
		Init();
	}

	protected override void Init()
	{
		if (objectTypeUid == Guid.Empty)
		{
			return;
		}
		Type entityType = ModelHelper.GetEntityType(objectTypeUid);
		metaData = MetadataLoader.LoadMetadata(entityType) as EntityMetadata;
		if (metaData == null)
		{
			return;
		}
		titleProperty = GetTitleProperty(metaData);
		creationAuthorProperty = GetCreationAuthorProperty(metaData);
		creationDateProperty = GetCreationDateProperty(metaData);
		if (titleProperty != null)
		{
			AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.Name);
		}
		if (creationAuthorProperty != null)
		{
			AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationAuthor);
		}
		if (creationDateProperty != null)
		{
			AddPropertyGlobal((IWorkLogObjectSearchFilter m) => m.CreationDate);
		}
	}

	public override void SetupCriteria(ICriteria criteria, IWorkLogObjectSearchFilter filter)
	{
		if (creationDateProperty != null)
		{
			string fieldName = ((SimpleTypeSettings)creationDateProperty.Settings).FieldName;
			DateTimeRange dateTimeRange = RelativeDateTimeDescriptor.GetDateTimeRange(filter.CreationDate);
			if (dateTimeRange.From.HasValue)
			{
				criteria.Add((ICriterion)(object)Restrictions.Ge(fieldName, (object)dateTimeRange.From));
			}
			if (dateTimeRange.To.HasValue)
			{
				criteria.Add((ICriterion)(object)Restrictions.Le(fieldName, (object)dateTimeRange.To));
			}
		}
		if (creationAuthorProperty != null)
		{
			string fieldName2 = ((SimpleTypeSettings)creationAuthorProperty.Settings).FieldName;
			if (filter.CreationAuthor != null)
			{
				criteria.Add((ICriterion)(object)Restrictions.Ge(fieldName2, (object)filter.CreationAuthor));
			}
		}
		if (titleProperty != null)
		{
			string fieldName3 = ((SimpleTypeSettings)titleProperty.Settings).FieldName;
			if (!string.IsNullOrEmpty(filter.Name))
			{
				criteria.Add((ICriterion)(object)ElmaRestrictions.Like(fieldName3, $"%{filter.Name}%"));
			}
		}
	}

	private static PropertyMetadata GetTitleProperty(ClassMetadata metadata)
	{
		PropertyMetadata propertyMetadata = metadata.GetTitleProperty();
		if (propertyMetadata.TypeUid == StringDescriptor.UID || propertyMetadata.SubTypeUid == TextDescriptor.UID)
		{
			return propertyMetadata;
		}
		return null;
	}

	private static PropertyMetadata GetCreationAuthorProperty(ClassMetadata metadata)
	{
		return GetEntityProperty(metadata, ChangeAuthorPropertyHandler.UID, (PropertyMetadata p) => ModelHelper.GetEntityType(p.SubTypeUid) == ModelHelper.GetEntityType(InterfaceActivator.UID<IUser>()), "CreationAuthor");
	}

	private static PropertyMetadata GetCreationDateProperty(ClassMetadata metadata)
	{
		return GetEntityProperty(metadata, CreationDatePropertyHandler.UID, (PropertyMetadata p) => p.TypeUid == DateTimeDescriptor.UID || p.SubTypeUid == DateTimeDescriptor.UID, "CreationDate");
	}

	private static PropertyMetadata GetEntityProperty(ClassMetadata metadata, Guid handlerUid, Func<PropertyMetadata, bool> propertyEq, string propertyName)
	{
		using (IEnumerator<PropertyMetadata> enumerator = metadata.Properties.Where((PropertyMetadata propertyMetadata) => propertyMetadata.Handlers.Exists((PropertyHandlerInfo h) => h.HandlerUid == handlerUid) && propertyEq(propertyMetadata)).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return enumerator.Current;
			}
		}
		PropertyMetadata propertyMetadata2 = metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == propertyName);
		if (propertyMetadata2 == null || !propertyEq(propertyMetadata2))
		{
			return null;
		}
		return propertyMetadata2;
	}
}

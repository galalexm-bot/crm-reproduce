using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Common.BulkDataImport.Extensions;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers.Components;

[Component(Order = 90000)]
internal class EntityIdMapProvider : EntityMapProvider
{
	private abstract class PropertyExtensionBase : IMapPropertyExtension
	{
		protected abstract string PropertyColumnName { get; }

		public bool Can(PropertyMetadata propertyMetadata)
		{
			return true;
		}

		public MapPropertyInfo CreatePropertyInfo(PropertyMetadata propertyMetadata, string tableName, bool isKey)
		{
			return CreatePropertyInfo(tableName);
		}

		public MapPropertyInfo CreatePropertyInfo(string tableName)
		{
			return new MapPropertyInfo(PropertyColumnName, new List<string> { GenerateColumnIdName(PropertyColumnName) }, isImportKey: false, tableName, this);
		}

		public virtual Type GetPropertyDbType(PropertyMetadata propertyMetadata)
		{
			if (propertyMetadata == null)
			{
				return typeof(object);
			}
			return typeof(long);
		}

		public void SetValue(PropertyValue propertyValue, object value, SetPropertyInfo mapSettings)
		{
			propertyValue.Columns[GenerateColumnIdName(PropertyColumnName)] = value;
		}

		private string GenerateColumnIdName(string columnName)
		{
			if (!(columnName == "Id"))
			{
				return columnName;
			}
			return "@" + columnName;
		}
	}

	private class EntityIdMapPropertyExtension : PropertyExtensionBase
	{
		protected override string PropertyColumnName => "Id";
	}

	private class EntityTypeUidMapPropertyExtension : PropertyExtensionBase
	{
		protected override string PropertyColumnName => "TypeUid";

		public override Type GetPropertyDbType(PropertyMetadata propertyMetadata)
		{
			return typeof(Guid);
		}
	}

	public const string ColumnPrefix = "@";

	private const string Field_Id = "Id";

	private const string Field_TypeUid = "TypeUid";

	public override bool Can(Type objectType)
	{
		Type myType = typeof(IEntity<>);
		return objectType.GetInterfacesCache().Any((Type i) => i.IsGenericType && i.GetGenericTypeDefinition() == myType);
	}

	protected override List<string> AdditionalProperties(Type type)
	{
		return new List<string> { "Id" };
	}

	protected override List<string> AdditionalProperties(ClassMetadata classMetadata)
	{
		List<string> list = new List<string>();
		if (classMetadata != null && classMetadata.AllowCreateHeirs)
		{
			list.Add(GetPropertyName((IInheritable i) => i.TypeUid));
		}
		return list;
	}

	protected override MapPropertyInfo CreateAdditionalProperty(Type objectType, string propertyName)
	{
		if (propertyName == "Id")
		{
			return new EntityIdMapPropertyExtension().CreatePropertyInfo("");
		}
		if (propertyName == "TypeUid")
		{
			string tableName = GetTableName(objectType, propertyName);
			return new EntityTypeUidMapPropertyExtension().CreatePropertyInfo(tableName);
		}
		return null;
	}

	protected override object CreateAdditionalPropertyValue(Type objectType, object targetObject, string propertyName)
	{
		if (AdditionalProperties(objectType).Contains(propertyName))
		{
			if (propertyName == "Id")
			{
				if (targetObject is ObjectId)
				{
					return targetObject;
				}
				return new ObjectId(objectType);
			}
			if (propertyName == "TypeUid")
			{
				return InterfaceActivator.UID(objectType);
			}
		}
		return null;
	}

	protected override MapObject ConvertObjectLink(MapObject @object, Dictionary<string, object> propertyList)
	{
		if (Can(@object.GetType()))
		{
			if (propertyList.ContainsKey("Id"))
			{
				return (MapObject)propertyList["Id"];
			}
			if (@object is ObjectId)
			{
				return @object;
			}
		}
		return base.ConvertObjectLink(@object, propertyList);
	}

	protected override MapObject CreateObject(Type objectType)
	{
		return new ObjectId(objectType);
	}

	private string GetTableName(Type objectType, string propertyName)
	{
		if (AdditionalProperties(objectType).Contains(propertyName))
		{
			if (propertyName == "Id")
			{
				return "";
			}
			if (propertyName == "TypeUid")
			{
				EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata(objectType);
				string tableName = entityMetadata.TableName;
				if (entityMetadata.BaseClassUid != Guid.Empty)
				{
					foreach (ClassMetadata baseClass in MetadataLoader.GetBaseClasses(entityMetadata))
					{
						if (baseClass is EntityMetadata entityMetadata2 && entityMetadata2.BaseClassUid == Guid.Empty)
						{
							return entityMetadata2.TableName;
						}
					}
					return tableName;
				}
				return tableName;
			}
		}
		return "";
	}

	public string GetPropertyName<T>(Expression<Func<T, object>> expr)
	{
		string name = "BulkDataImport_GetPropertyName";
		string expressionName = TypeExtensions.GetExpressionName(expr);
		Type typeFromHandle = typeof(T);
		Dictionary<Type, Dictionary<string, string>> orAdd = ContextVars.GetOrAdd(name, () => new Dictionary<Type, Dictionary<string, string>>());
		string value2;
		if (!orAdd.TryGetValue(typeFromHandle, out var value))
		{
			value2 = InterfaceActivator.PropertyName(expr);
			value = (orAdd[typeFromHandle] = new Dictionary<string, string> { { expressionName, value2 } });
			ContextVars.Set(name, orAdd);
		}
		else if (!value.TryGetValue(expressionName, out value2))
		{
			value2 = (value[expressionName] = InterfaceActivator.PropertyName(expr));
			orAdd[typeFromHandle] = value;
			ContextVars.Set(name, orAdd);
		}
		return value2;
	}
}

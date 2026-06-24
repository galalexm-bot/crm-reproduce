using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Common.BulkDataImport.Extensions;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping;

public class RulesBuilder : RulesBuilderBase
{
	protected Type objectType;

	private ConcurrentDictionary<Type, Type> actionBuilderTypes = new ConcurrentDictionary<Type, Type>();

	internal RulesBuilder(DataTable table, Type objectType)
		: base(table)
	{
		this.objectType = InterfaceActivator.TypeOf(objectType);
	}

	protected void SetPropertySettings(string propertyName, Func<PropertyCollectionSettings, int> collectionSettings)
	{
		if (collectionSettings == null)
		{
			throw new ArgumentNullException("countInfoAction");
		}
		if (PropertySettingsDictionary.ContainsKey(propertyName))
		{
			PropertySettingsDictionary[propertyName] = collectionSettings;
		}
		else
		{
			PropertySettingsDictionary.Add(propertyName, collectionSettings);
		}
		PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata(objectType, propertyName, inherit: true);
		if (propertyMetadata == null)
		{
			return;
		}
		EntitySettings settings = propertyMetadata.Settings as EntitySettings;
		if (settings == null)
		{
			return;
		}
		if (settings.RelationType == RelationType.OneToMany)
		{
			PropertyMetadata propertyMetadata2 = (InterfaceActivator.LoadMetadata(ModelHelper.GetEntityType(propertyMetadata.SubTypeUid)) as ClassMetadata).Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == settings.KeyColumnUid);
			if (propertyMetadata2 != null)
			{
				string name = propertyMetadata2.Name;
				if (!RelationProperties.ContainsKey(propertyName))
				{
					RelationProperties.Add(propertyName, new Relation(name));
				}
			}
		}
		if (settings.RelationType == RelationType.ManyToMany && !RelationProperties.ContainsKey(propertyName))
		{
			RelationProperties.Add(propertyName, new Relation());
		}
	}

	protected Type GetActionBuilderType(Type propertyType)
	{
		return actionBuilderTypes.GetOrAdd(propertyType, (Type t) => typeof(ActionBuilder<, >).MakeGenericType(objectType, t));
	}

	protected ActionBuilder CreateMapActionBuilder(string propertyName, Type propertyType)
	{
		Type actionBuilderType = GetActionBuilderType(propertyType);
		BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.NonPublic;
		ActionBuilder actionBuilder = (ActionBuilder)Activator.CreateInstance(actionBuilderType, bindingAttr, null, new object[1] { propertyName }, null);
		ActionBuilders[propertyName] = actionBuilder;
		return actionBuilder;
	}

	public RulesBuilder<TExt> Extension<TExt>() where TExt : class
	{
		RulesBuilder<TExt> rulesBuilder = new RulesBuilder<TExt>(Table);
		RulesExtensions.Add(rulesBuilder);
		return rulesBuilder;
	}

	public ActionBuilder Property(Type propertyType, Expression<Func<object, object>> expression, Func<PropertyCollectionSettings, int> collectionSettings)
	{
		string expressionName = TypeExtensions.GetExpressionName(expression);
		return Property(expressionName, propertyType, collectionSettings);
	}

	public ActionBuilder Property(string propertyName, Type propertyType, Func<PropertyCollectionSettings, int> collectionSettings)
	{
		SetPropertySettings(propertyName, collectionSettings);
		return CreateMapActionBuilder(propertyName, propertyType);
	}

	public ActionBuilder Property(Type propertyType, Expression<Func<object, object>> expression)
	{
		string expressionName = TypeExtensions.GetExpressionName(expression);
		return Property(expressionName, propertyType);
	}

	public ActionBuilder Property(string propertyName, Type propertyType)
	{
		return CreateMapActionBuilder(propertyName, propertyType);
	}

	public MapBuilder PropertyObject(Type propertyType, Expression<Func<object, ISet<object>>> expression, Func<PropertyCollectionSettings, int> collectionSettings)
	{
		string expressionName = TypeExtensions.GetExpressionName(expression);
		return PropertyObject(expressionName, propertyType, collectionSettings);
	}

	public MapBuilder PropertyObject(string propertyName, Type propertyType, Func<PropertyCollectionSettings, int> collectionSettings)
	{
		SetPropertySettings(propertyName, collectionSettings);
		return PropertyObject(propertyName, propertyType);
	}

	public MapBuilder PropertyObject(Type propertyType, Expression<Func<object, object>> expression)
	{
		string expressionName = TypeExtensions.GetExpressionName(expression);
		return PropertyObject(expressionName, propertyType);
	}

	public MapBuilder PropertyObject(string propertyName, Type propertyType)
	{
		MapBuilder mapBuilder = MapBuilder.Create(Table, propertyType);
		ImportBuilders[propertyName] = mapBuilder;
		return mapBuilder;
	}
}
public class RulesBuilder<T> : RulesBuilder where T : class
{
	internal RulesBuilder(DataTable table)
		: base(table, typeof(T))
	{
	}

	private ActionBuilder<T, TProperty> CreateMapActionBuilder<TProperty>(string propertyName)
	{
		ActionBuilder<T, TProperty> actionBuilder = new ActionBuilder<T, TProperty>(propertyName);
		ActionBuilders[propertyName] = actionBuilder;
		return actionBuilder;
	}

	public ActionBuilder<T, TProperty> Property<TProperty>(Expression<Func<T, TProperty>> expression, Func<PropertyCollectionSettings, int> collectionSettings)
	{
		string expressionName = TypeExtensions.GetExpressionName(expression);
		return Property<TProperty>(expressionName, collectionSettings);
	}

	public ActionBuilder<T, TProperty> Property<TProperty>(string propertyName, Func<PropertyCollectionSettings, int> collectionSettings)
	{
		SetPropertySettings(propertyName, collectionSettings);
		return CreateMapActionBuilder<TProperty>(propertyName);
	}

	public ActionBuilder<T, TProperty> Property<TProperty>(Expression<Func<T, TProperty>> expression)
	{
		string expressionName = TypeExtensions.GetExpressionName(expression);
		return Property<TProperty>(expressionName);
	}

	public ActionBuilder<T, TProperty> Property<TProperty>(string propertyName)
	{
		return CreateMapActionBuilder<TProperty>(propertyName);
	}

	public MapBuilder<TProperty> PropertyObject<TProperty>(Expression<Func<T, ISet<TProperty>>> expression, Func<PropertyCollectionSettings, int> collectionSettings) where TProperty : class
	{
		string expressionName = TypeExtensions.GetExpressionName(expression);
		return PropertyObject<TProperty>(expressionName, collectionSettings);
	}

	public MapBuilder<TProperty> PropertyObject<TProperty>(string propertyName, Func<PropertyCollectionSettings, int> collectionSettings) where TProperty : class
	{
		SetPropertySettings(propertyName, collectionSettings);
		return PropertyObject<TProperty>(propertyName);
	}

	public MapBuilder<TProperty> PropertyObject<TProperty>(Expression<Func<T, TProperty>> expression) where TProperty : class
	{
		string expressionName = TypeExtensions.GetExpressionName(expression);
		return PropertyObject<TProperty>(expressionName);
	}

	public MapBuilder<TProperty> PropertyObject<TProperty>(string propertyName) where TProperty : class
	{
		MapBuilder<TProperty> mapBuilder = MapBuilder<TProperty>.Create(Table);
		ImportBuilders[propertyName] = mapBuilder;
		return mapBuilder;
	}
}

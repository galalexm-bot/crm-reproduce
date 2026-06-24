using System;
using System.Data;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping;

public class ActionBuilder : ActionBuilderBase
{
	protected Type objectType;

	protected Func<PropertyActionInfo, object> action;

	internal ActionBuilder(string propertyName, Type objectType)
		: base(propertyName)
	{
		this.objectType = InterfaceActivator.TypeOf(objectType);
	}

	public ActionBuilder Key(bool value = true)
	{
		IsKeyField = value;
		return this;
	}

	public ActionBuilder Ignore(bool value = true)
	{
		IgnoreMap = value;
		return this;
	}

	public ActionBuilder Action(Func<PropertyActionInfo, object> value)
	{
		action = value;
		return this;
	}

	public ActionBuilder Column(string columnName)
	{
		base.columnName = columnName;
		return this;
	}

	internal override object Action(MapObject mapObject, DataRow row, SmartLogger logger, int? index, int count)
	{
		if (action == null)
		{
			return null;
		}
		return action(new PropertyActionInfo(objectType, mapObject, row, logger, index, count));
	}

	internal override bool ActionExist()
	{
		return action != null;
	}
}
public class ActionBuilder<T, TProperty> : ActionBuilder
{
	internal ActionBuilder(string propertyName)
		: base(propertyName, typeof(T))
	{
	}

	public new ActionBuilder<T, TProperty> Key(bool value = true)
	{
		base.Key(value);
		return this;
	}

	public new ActionBuilder<T, TProperty> Ignore(bool value = true)
	{
		base.Ignore(value);
		return this;
	}

	public ActionBuilder<T, TProperty> Action(Func<PropertyActionInfo<T>, object> value)
	{
		Func<PropertyActionInfo, object> func = (action = (PropertyActionInfo info) => value((PropertyActionInfo<T>)info));
		return this;
	}

	public new ActionBuilder<T, TProperty> Column(string columnName)
	{
		base.Column(columnName);
		return this;
	}

	internal override object Action(MapObject mapObject, DataRow row, SmartLogger logger, int? index, int count)
	{
		if (action == null)
		{
			return null;
		}
		return action(new PropertyActionInfo<T>(mapObject, row, logger, index, count));
	}

	internal override bool ActionExist()
	{
		return action != null;
	}
}

using System;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public class ViewItemTransformationBuilder<TM> where TM : IEntity
{
	protected readonly FormViewItemTransformationBuilder<TM> builder;

	protected readonly Guid itemUid;

	internal ViewItemTransformationBuilder(FormViewItemTransformationBuilder<TM> builder, Guid itemUid)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.builder = builder;
		this.itemUid = itemUid;
	}

	public FormViewItemTransformationBuilder<TM> Add(ViewItem item, Guid? afterItem = null, Guid? beforeItem = null)
	{
		builder.transformations.Items.Add(ViewItemTransformation.Add(itemUid, item, afterItem, beforeItem));
		return builder;
	}

	public FormViewItemTransformationBuilder<TM> Add(ViewItem item, Guid? afterItem, Expression<Func<TM, object>> beforePropertyExpr)
	{
		return Add(item, afterItem, InterfaceActivator.PropertyUid(beforePropertyExpr, inherit: true));
	}

	public FormViewItemTransformationBuilder<TM> Add(ViewItem item, Expression<Func<TM, object>> afterPropertyExpr, Guid? beforeItem = null)
	{
		return Add(item, InterfaceActivator.PropertyUid(afterPropertyExpr, inherit: true), beforeItem);
	}

	public FormViewItemTransformationBuilder<TM> Add(ViewItem item, Expression<Func<TM, object>> afterPropertyExpr, Expression<Func<TM, object>> beforePropertyExpr)
	{
		return Add(item, InterfaceActivator.PropertyUid(afterPropertyExpr, inherit: true), InterfaceActivator.PropertyUid(beforePropertyExpr, inherit: true));
	}

	public FormViewItemTransformationBuilder<TM> Add<TB>(Action<TB> builder, Guid? afterItem = null, Guid? beforeItem = null) where TB : ViewItemBuilder, new()
	{
		if (builder != null)
		{
			TB val = new TB();
			builder(val);
			if (val.viewItem is RootViewItem rootViewItem)
			{
				foreach (ViewItem item in rootViewItem.Items)
				{
					this.builder.transformations.Items.Add(ViewItemTransformation.Add(itemUid, item, afterItem, beforeItem));
					afterItem = item.Uid;
				}
			}
		}
		return this.builder;
	}

	public FormViewItemTransformationBuilder<TM> Add<TB>(Action<TB> builder, Guid? afterItem, Expression<Func<TM, object>> beforePropertyExpr) where TB : ViewItemBuilder, new()
	{
		return Add(builder, afterItem, InterfaceActivator.PropertyUid(beforePropertyExpr, inherit: true));
	}

	public FormViewItemTransformationBuilder<TM> Add<TB>(Action<TB> builder, Expression<Func<TM, object>> afterPropertyExpr, Guid? beforeItem = null) where TB : ViewItemBuilder, new()
	{
		return Add(builder, InterfaceActivator.PropertyUid(afterPropertyExpr, inherit: true), beforeItem);
	}

	public FormViewItemTransformationBuilder<TM> Add<TB>(Action<TB> builder, Expression<Func<TM, object>> afterPropertyExpr, Expression<Func<TM, object>> beforePropertyExpr) where TB : ViewItemBuilder, new()
	{
		return Add(builder, InterfaceActivator.PropertyUid(afterPropertyExpr, inherit: true), InterfaceActivator.PropertyUid(beforePropertyExpr, inherit: true));
	}

	public FormViewItemTransformationBuilder<TM> Move(Guid toItemUid, Guid? afterItem = null, Guid? beforeItem = null)
	{
		builder.transformations.Items.Add(ViewItemTransformation.Move(toItemUid, itemUid, afterItem, beforeItem));
		return builder;
	}

	public FormViewItemTransformationBuilder<TM> Move(Guid toItemUid, Guid? afterItem, Expression<Func<TM, object>> beforePropertyExpr)
	{
		return Move(toItemUid, afterItem, InterfaceActivator.PropertyUid(beforePropertyExpr, inherit: true));
	}

	public FormViewItemTransformationBuilder<TM> Move(Guid toItemUid, Expression<Func<TM, object>> afterPropertyExpr, Guid? beforeItem = null)
	{
		return Move(toItemUid, InterfaceActivator.PropertyUid(afterPropertyExpr, inherit: true), beforeItem);
	}

	public FormViewItemTransformationBuilder<TM> Move(Guid toItemUid, Expression<Func<TM, object>> afterPropertyExpr, Expression<Func<TM, object>> beforePropertyExpr)
	{
		return Move(toItemUid, InterfaceActivator.PropertyUid(afterPropertyExpr, inherit: true), InterfaceActivator.PropertyUid(beforePropertyExpr, inherit: true));
	}

	public FormViewItemTransformationBuilder<TM> Hide()
	{
		builder.transformations.Items.Add(ViewItemTransformation.Hide(itemUid));
		return builder;
	}

	public FormViewItemTransformationBuilder<TM> SetPropertyValue(string propertyName, object value)
	{
		builder.transformations.Items.Add(ViewItemTransformation.SetPropertyValue(itemUid, propertyName, value));
		return builder;
	}
}
public class ViewItemTransformationBuilder<TM, TItem> : ViewItemTransformationBuilder<TM> where TM : IEntity where TItem : ViewItem
{
	internal ViewItemTransformationBuilder(FormViewItemTransformationBuilder<TM> builder, Guid itemUid)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(builder, itemUid);
	}

	public FormViewItemTransformationBuilder<TM> SetPropertyValue<T>(Expression<Func<TItem, T>> property, T value)
	{
		builder.transformations.Items.Add(ViewItemTransformation<TItem>.SetPropertyValue(itemUid, property, value));
		return builder;
	}
}

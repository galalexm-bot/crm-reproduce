using System;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Model.Views.Builders;

public static class FormViewItemTransformationExtension
{
	public static FormViewItem Transformate(this FormViewItem formViewItem, Action<FormViewItemTransformationBuilder<IEntity>> builder)
	{
		if (builder == null)
		{
			return formViewItem;
		}
		FormViewItemTransformation formViewItemTransformation = new FormViewItemTransformation();
		builder(new FormViewItemTransformationBuilder<IEntity>(formViewItem, formViewItemTransformation));
		return formViewItem.Transformate(formViewItemTransformation);
	}

	public static FormViewItem Transformate<TM>(this FormViewItem formViewItem, Action<FormViewItemTransformationBuilder<TM>> builder) where TM : IEntity
	{
		if (builder == null)
		{
			return formViewItem;
		}
		FormViewItemTransformation formViewItemTransformation = new FormViewItemTransformation();
		builder(new FormViewItemTransformationBuilder<TM>(formViewItem, formViewItemTransformation));
		return formViewItem.Transformate(formViewItemTransformation);
	}
}

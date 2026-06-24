using System;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public class FormViewItemTransformationBuilder<TM> where TM : IEntity
{
	internal readonly FormViewItem formViewItem;

	internal readonly FormViewItemTransformation transformations;

	private static object GBD2knoD1UINdDoc2KkA;

	internal FormViewItemTransformationBuilder(FormViewItem formViewItem, FormViewItemTransformation transformations)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				this.formViewItem = formViewItem;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num = 0;
				}
				break;
			default:
				this.transformations = transformations;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public FormViewItemTransformationBuilder<TM> If(bool condition, Action<FormViewItemTransformationBuilder<TM>> builder)
	{
		if (condition)
		{
			builder?.Invoke(this);
		}
		return this;
	}

	public ViewItemTransformationBuilder<TM> ForItem(Guid itemUid)
	{
		return new ViewItemTransformationBuilder<TM>(this, itemUid);
	}

	public ViewItemTransformationBuilder<TM, PropertyViewItem> ForPropertyItem(Expression<Func<TM, object>> expr)
	{
		return new ViewItemTransformationBuilder<TM, PropertyViewItem>(this, InterfaceActivator.PropertyUid(expr, inherit: true));
	}

	public ViewItemTransformationBuilder<TM, TItem> ForItem<TItem>(Guid itemUid) where TItem : ViewItem
	{
		return new ViewItemTransformationBuilder<TM, TItem>(this, itemUid);
	}

	public ViewItemTransformationBuilder<TM, TItem> ForItem<TItem>(Expression<Func<TM, object>> expr) where TItem : ViewItem
	{
		return new ViewItemTransformationBuilder<TM, TItem>(this, InterfaceActivator.PropertyUid(expr, inherit: true));
	}

	internal static bool NhVmf6oDN8W6JwZIOYVW()
	{
		return GBD2knoD1UINdDoc2KkA == null;
	}

	internal static object t0POkNoD3XGySfxSJMKc()
	{
		return GBD2knoD1UINdDoc2KkA;
	}
}

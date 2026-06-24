using System;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public abstract class RootViewItemBuilder<TM, T, TB> : ViewItemBuilder<TM, T, TB>, IRootViewItemBuilder where TM : IEntity where T : RootViewItem, new()where TB : RootViewItemBuilder<TM, T, TB>
{
	internal static object HRxtRVoaSWjanCcBAIZe;

	protected RootViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected RootViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TB ColumnsLayout(Action<ColumnsLayoutViewItemBuilder<TM>> builder = null)
	{
		builder?.Invoke(new ColumnsLayoutViewItemBuilder<TM>(this));
		return this as TB;
	}

	public TB TabLayout(Action<TabLayoutViewItemBuilder<TM>> builder = null)
	{
		builder?.Invoke(new TabLayoutViewItemBuilder<TM>(this));
		return this as TB;
	}

	public TB TableLayout(Action<TableLayoutViewItemBuilder<TM>> builder = null)
	{
		builder?.Invoke(new TableLayoutViewItemBuilder<TM>(this));
		return this as TB;
	}

	public TB Panel(Action<PanelViewItemBuilder<TM>> builder = null)
	{
		builder?.Invoke(new PanelViewItemBuilder<TM>(this));
		return this as TB;
	}

	public TB PropertyValue(Expression<Func<TM, object>> property, Action<PropertyValueViewItemBuilder<TM>> builder = null)
	{
		PropertyValueViewItemBuilder<TM> obj = new PropertyValueViewItemBuilder<TM>(property, this);
		builder?.Invoke(obj);
		return this as TB;
	}

	public TB PropertyValue<TM2>(Expression<Func<TM2, object>> property, Action<PropertyValueViewItemBuilder<TM2>> builder = null) where TM2 : TM
	{
		PropertyValueViewItemBuilder<TM2> obj = new PropertyValueViewItemBuilder<TM2>(property, this);
		builder?.Invoke(obj);
		return this as TB;
	}

	public TB PropertyCaption(Expression<Func<TM, object>> property, Action<PropertyCaptionViewItemBuilder<TM>> builder = null)
	{
		PropertyCaptionViewItemBuilder<TM> obj = new PropertyCaptionViewItemBuilder<TM>(property, this);
		builder?.Invoke(obj);
		return this as TB;
	}

	public TB PropertyCaption<TM2>(Expression<Func<TM2, object>> property, Action<PropertyCaptionViewItemBuilder<TM2>> builder = null) where TM2 : TM
	{
		PropertyCaptionViewItemBuilder<TM2> obj = new PropertyCaptionViewItemBuilder<TM2>(property, this);
		builder?.Invoke(obj);
		return this as TB;
	}

	public TB PropertyDescription(Expression<Func<TM, object>> property, Action<PropertyDescriptionViewItemBuilder<TM>> builder = null)
	{
		PropertyDescriptionViewItemBuilder<TM> obj = new PropertyDescriptionViewItemBuilder<TM>(property, this);
		builder?.Invoke(obj);
		return this as TB;
	}

	public TB PropertyDescription<TM2>(Expression<Func<TM2, object>> property, Action<PropertyDescriptionViewItemBuilder<TM2>> builder = null) where TM2 : TM
	{
		PropertyDescriptionViewItemBuilder<TM2> obj = new PropertyDescriptionViewItemBuilder<TM2>(property, this);
		builder?.Invoke(obj);
		return this as TB;
	}

	public TB StaticText(Action<StaticTextViewItemBuilder<TM>> builder = null)
	{
		builder?.Invoke(new StaticTextViewItemBuilder<TM>(null, this));
		return this as TB;
	}

	public TB StaticText(string text, Action<StaticTextViewItemBuilder<TM>> builder = null)
	{
		StaticTextViewItemBuilder<TM> obj = new StaticTextViewItemBuilder<TM>(text, this);
		builder?.Invoke(obj);
		return this as TB;
	}

	public TB ExtensionZone(string ZoneId, Action<ExtensionZoneViewItemBuilder<TM>> builder = null)
	{
		ExtensionZoneViewItemBuilder<TM> obj = new ExtensionZoneViewItemBuilder<TM>(ZoneId, this);
		builder?.Invoke(obj);
		return this as TB;
	}

	public TB HideEmpty(HideEmptyEnum hideEmpty = HideEmptyEnum.HideEmpty)
	{
		base.ViewItem.HideEmptySettings = hideEmpty;
		return this as TB;
	}

	internal static bool NESCc6oaio8mc0BiDqDK()
	{
		return HRxtRVoaSWjanCcBAIZe == null;
	}

	internal static object phJZ10oaRE0nc0ViiHrf()
	{
		return HRxtRVoaSWjanCcBAIZe;
	}
}

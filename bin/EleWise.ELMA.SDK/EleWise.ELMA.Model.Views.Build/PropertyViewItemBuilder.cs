using System;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public class PropertyViewItemBuilder<TM, T, TB> : RootViewItemBuilder<TM, T, TB> where TM : IEntity where T : PropertyViewItem, new()where TB : PropertyViewItemBuilder<TM, T, TB>
{
	private static object NInTa2oDQp8xaau3FTQ6;

	public PropertyViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected PropertyViewItemBuilder(Expression<Func<TM, object>> property, ViewItemBuilder parentViewItemBuilder)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
		base.ViewItem.PropertyUid = InterfaceActivator.PropertyUid(property, inherit: true);
	}

	public TB CustomViewName(string customViewName)
	{
		base.ViewItem.CustomViewName = customViewName;
		return this as TB;
	}

	public TB ReadOnly(bool readOnly = true)
	{
		base.ViewItem.Attributes.ReadOnly = readOnly;
		return this as TB;
	}

	public TB Visible(bool visible = true)
	{
		base.ViewItem.Attributes.Visible = visible;
		return this as TB;
	}

	public TB Required(bool required = true)
	{
		base.ViewItem.Attributes.Required = required;
		return this as TB;
	}

	public TB Caption(string caption)
	{
		base.ViewItem.Attributes.Name = caption;
		return this as TB;
	}

	internal static bool e7Cu29oDCmfmXqvOpNUU()
	{
		return NInTa2oDQp8xaau3FTQ6 == null;
	}

	internal static object HNEISyoDvUa5S0lj8sFQ()
	{
		return NInTa2oDQp8xaau3FTQ6;
	}
}
public class PropertyViewItemBuilder<TM> : PropertyViewItemBuilder<TM, PropertyViewItem, PropertyViewItemBuilder<TM>> where TM : IEntity
{
	private static object VYv01joD8DHJLdjApEw4;

	public PropertyViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal PropertyViewItemBuilder(Expression<Func<TM, object>> property, ViewItemBuilder parentViewItemBuilder)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(property, parentViewItemBuilder);
		base.ViewItem.PropertyUid = InterfaceActivator.PropertyUid(property, inherit: true);
	}

	internal static bool PPKilnoDZbX37CJI1RtP()
	{
		return VYv01joD8DHJLdjApEw4 == null;
	}

	internal static object zEm0paoDuqOhr01ss3c0()
	{
		return VYv01joD8DHJLdjApEw4;
	}
}

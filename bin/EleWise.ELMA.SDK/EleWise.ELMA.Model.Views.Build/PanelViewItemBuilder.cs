using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public abstract class PanelViewItemBuilder<TM, T, TB> : RootViewItemBuilder<TM, T, TB> where TM : IEntity where T : PanelViewItem, new()where TB : PanelViewItemBuilder<TM, T, TB>
{
	private static object Un8qAPoasjsnJwZBu4fe;

	protected PanelViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected PanelViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TB Collapsible(bool collapsible = true)
	{
		base.ViewItem.Collapsible = collapsible;
		return this as TB;
	}

	public TB Collapsed(bool collapsed = true)
	{
		base.ViewItem.DefaultCollapseState = (collapsed ? PanelViewItemCollapseType.DefaultCollapsed : PanelViewItemCollapseType.DefaultExpanded);
		return this as TB;
	}

	public TB SaveState(bool saveState = true)
	{
		base.ViewItem.SaveState = saveState;
		return this as TB;
	}

	public TB Style(PanelViewItemStyle style)
	{
		base.ViewItem.Style = style;
		return this as TB;
	}

	public TB CssClass(string cssClass)
	{
		base.ViewItem.CssClass = cssClass;
		return this as TB;
	}

	public TB Caption(string caption)
	{
		base.ViewItem.Caption = caption;
		return this as TB;
	}

	public TB CustomViewName(string customViewName, bool useOriginalModel = false)
	{
		base.ViewItem.CustomViewName = customViewName;
		base.ViewItem.UseOriginalModel = useOriginalModel;
		return this as TB;
	}

	internal static bool aVi7pwoacRn2OUK9YKDg()
	{
		return Un8qAPoasjsnJwZBu4fe == null;
	}

	internal static object skyoOVoazeBhQAltvttF()
	{
		return Un8qAPoasjsnJwZBu4fe;
	}
}
public class PanelViewItemBuilder<TM> : PanelViewItemBuilder<TM, PanelViewItem, PanelViewItemBuilder<TM>> where TM : IEntity
{
	internal static object MDRpx1oDFNfQgSa1wCoQ;

	public PanelViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal PanelViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool kcBxbaoDBXglJR1QwfRc()
	{
		return MDRpx1oDFNfQgSa1wCoQ == null;
	}

	internal static object ETUwZhoDWHud1Gexv5DA()
	{
		return MDRpx1oDFNfQgSa1wCoQ;
	}
}

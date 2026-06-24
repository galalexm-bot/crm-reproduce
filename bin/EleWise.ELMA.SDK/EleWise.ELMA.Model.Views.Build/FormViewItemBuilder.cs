using System;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public class FormViewItemBuilder<TM> : RootViewItemBuilder<TM, FormViewItem, FormViewItemBuilder<TM>> where TM : IEntity
{
	internal static object kB3DIxoaqjIx1fTIfrdy;

	public FormViewItem FormView => base.ViewItem;

	protected FormViewItemBuilder(Guid metadataUid, ViewType viewType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				base.ViewItem.ViewType = viewType;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				base.ViewItem.MetadataUid = metadataUid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public FormViewItemBuilder(ViewType viewType = ViewType.Custom)
	{
		//Discarded unreachable code: IL_0031, IL_0036
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(InterfaceActivator.UID<TM>(), viewType);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public FormViewItemBuilder<TM> DisplayName(string displayName)
	{
		base.ViewItem.DisplayName = displayName;
		return this;
	}

	public FormViewItemBuilder<TM> DefaultContainer(bool defaultContainer = true)
	{
		DefaultContainerViewItem item = base.ViewItem.FormViewItem.FindItem<DefaultContainerViewItem>(DefaultContainerViewItem.ItemUid) ?? new DefaultContainerViewItem();
		if (defaultContainer)
		{
			Add(item);
		}
		else
		{
			base.ViewItem.FormViewItem.Items.Add(item);
		}
		return this;
	}

	internal static bool SrXw2JoaK5b2vOkX4mln()
	{
		return kB3DIxoaqjIx1fTIfrdy == null;
	}

	internal static object Y6hQQooaXZnugOi8wTaG()
	{
		return kB3DIxoaqjIx1fTIfrdy;
	}
}
public class FormViewItemBuilder : FormViewItemBuilder<IEntity>
{
	internal static FormViewItemBuilder CvD9QjoaTjXeeexx8Yew;

	public FormViewItemBuilder(Guid metadataUid, ViewType viewType = ViewType.Custom)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		YPOPmxoaOqHrwx8MAOeH();
		base._002Ector(metadataUid, viewType);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void YPOPmxoaOqHrwx8MAOeH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Jg90Byoak9Uk1JUBjSd4()
	{
		return CvD9QjoaTjXeeexx8Yew == null;
	}

	internal static FormViewItemBuilder OD7hbHoanpq0D9PhSNBq()
	{
		return CvD9QjoaTjXeeexx8Yew;
	}
}

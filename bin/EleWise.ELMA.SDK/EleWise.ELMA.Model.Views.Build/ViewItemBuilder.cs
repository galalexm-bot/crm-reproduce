using System;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public abstract class ViewItemBuilder
{
	protected internal readonly ViewItem viewItem;

	internal static ViewItemBuilder TvwukLoaEB21QLH4kWyf;

	protected ViewItemBuilder(ViewItem viewItem)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MPStiLoaCU5ZQ0lcLpIJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.viewItem = viewItem;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
			{
				num = 1;
			}
		}
	}

	internal static void MPStiLoaCU5ZQ0lcLpIJ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool zEVTaSoafiOrP2df1XcO()
	{
		return TvwukLoaEB21QLH4kWyf == null;
	}

	internal static ViewItemBuilder eYDds0oaQA37tioZErat()
	{
		return TvwukLoaEB21QLH4kWyf;
	}
}
public abstract class ViewItemBuilder<TM, T, TB> : ViewItemBuilder where TM : IEntity where T : ViewItem, new()where TB : ViewItemBuilder<TM, T, TB>
{
	internal static object b7JcBGoavlyiEFUv0XQF;

	protected T ViewItem => viewItem as T;

	protected ViewItemBuilder()
	{
		//Discarded unreachable code: IL_0034, IL_0039
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(new T());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected ViewItemBuilder(T viewItem)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(viewItem);
	}

	protected ViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(parentViewItemBuilder, new T());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected ViewItemBuilder(ViewItemBuilder parentViewItemBuilder, T viewItem)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(viewItem);
		(parentViewItemBuilder.viewItem as RootViewItem).Items.Add(ViewItem);
	}

	public TB Uid(Guid uid)
	{
		ViewItem.Uid = uid;
		return this as TB;
	}

	public TB Name(string name)
	{
		ViewItem.Name = name;
		return this as TB;
	}

	public TB Add(ViewItem viewItem)
	{
		if (ViewItem is RootViewItem rootViewItem)
		{
			rootViewItem.Items.Add(viewItem);
		}
		return this as TB;
	}

	public TB Hide(bool hide = true)
	{
		ViewItem.Hide = hide;
		return this as TB;
	}

	public TB If(bool condition, Action<TB> builder)
	{
		if (condition)
		{
			builder?.Invoke(this as TB);
		}
		return this as TB;
	}

	internal static bool FJYJjtoa8oDPklqvCIKW()
	{
		return b7JcBGoavlyiEFUv0XQF == null;
	}

	internal static object dMHhCioaZ20Xus2engsH()
	{
		return b7JcBGoavlyiEFUv0XQF;
	}
}

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public abstract class TabViewItemBuilder<TM, T, TB> : RootViewItemBuilder<TM, T, TB> where TM : IEntity where T : TabViewItem, new()where TB : TabViewItemBuilder<TM, T, TB>
{
	private static object lxRpf7oatCfsGtCNLuSy;

	protected TabViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected TabViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
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

	public TB Caption(string caption)
	{
		base.ViewItem.Caption = caption;
		return this as TB;
	}

	public TB AsyncLoading(bool asyncLoading = true)
	{
		base.ViewItem.AsyncLoading = asyncLoading;
		base.ViewItem.LoadingType = (asyncLoading ? ViewItemLoadingType.AsyncLoading : ViewItemLoadingType.SyncLoading);
		return this as TB;
	}

	internal static bool eu5pjloawNOdR46oZhtQ()
	{
		return lxRpf7oatCfsGtCNLuSy == null;
	}

	internal static object nx8unQoa4VMQVp4uGYCw()
	{
		return lxRpf7oatCfsGtCNLuSy;
	}
}
public class TabViewItemBuilder<TM> : TabViewItemBuilder<TM, TabViewItem, TabViewItemBuilder<TM>> where TM : IEntity
{
	internal static object OwJk8soa6iWD9lxO7tBJ;

	public TabViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal TabViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool xpQONLoaHkf8vSeSNlEw()
	{
		return OwJk8soa6iWD9lxO7tBJ == null;
	}

	internal static object uMYb0joaAuiemiy4ZIjj()
	{
		return OwJk8soa6iWD9lxO7tBJ;
	}
}

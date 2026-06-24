using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views.Toolbox;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TabLayoutViewItem), "DisplayName")]
public class TabLayoutViewItem : RootViewItem, ILayoutViewItem, IViewItemWithActiveKey, IViewItemWithPropertyParents
{
	[Component(Order = 300)]
	private class ToolboxItem : CommonViewItemToolboxItem<TabLayoutViewItem>
	{
		internal static object BtQlQiCZbF8pBVREOQ4S;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			sDc8yfCZETWPUH8hp04u();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void sDc8yfCZETWPUH8hp04u()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool fFH2xBCZh45JebhwWuax()
		{
			return BtQlQiCZbF8pBVREOQ4S == null;
		}

		internal static ToolboxItem nMsFidCZGtVH1mt8ylMw()
		{
			return (ToolboxItem)BtQlQiCZbF8pBVREOQ4S;
		}
	}

	internal static TabLayoutViewItem WWJjCpopIoNEeg5XR8Pg;

	[DefaultValue(false)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public bool UseTabProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CUseTabProvider_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CUseTabProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(true)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public bool TabProviderUseOriginalModel
	{
		[CompilerGenerated]
		get
		{
			return _003CTabProviderUseOriginalModel_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CTabProviderUseOriginalModel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public Guid ActiveKeyProperty
	{
		[CompilerGenerated]
		get
		{
			return _003CActiveKeyProperty_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CActiveKeyProperty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public List<Guid> PropertyParents { get; set; }

	public TabLayoutViewItem()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		x3kMXYopiqVSeMrgdsvR();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				TabProviderUseOriginalModel = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num = 0;
				}
				break;
			default:
				PropertyParents = new List<Guid>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_0037, IL_0046
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return parentViewItem.IsChildValid(this);
			default:
				return true;
			case 1:
				if (parentViewItem == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is TabViewItem;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeActiveKeyProperty()
	{
		return Tmd2LMopRqDWTRgr1hXr(ActiveKeyProperty, Guid.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializePropertyParents()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return eoM1IMopqBpoWbr6ZuF4(PropertyParents) > 0;
			case 1:
				if (PropertyParents == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void x3kMXYopiqVSeMrgdsvR()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool zMIMUmopVvikR0rTpNac()
	{
		return WWJjCpopIoNEeg5XR8Pg == null;
	}

	internal static TabLayoutViewItem jWj1PoopS3axiuTnAqHy()
	{
		return WWJjCpopIoNEeg5XR8Pg;
	}

	internal static bool Tmd2LMopRqDWTRgr1hXr(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static int eoM1IMopqBpoWbr6ZuF4(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}
}

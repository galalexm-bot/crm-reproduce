using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class TreeStructureViewItem : RootViewItem, ITreeViewItem, IDynamicViewItem, IViewItemWithPropertyParents
{
	private static TreeStructureViewItem ydqamSoKidFuNhOWwsrw;

	public Guid PropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyUid_003Ek__BackingField;
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
					_003CPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
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

	public Guid KeyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CKeyUid_003Ek__BackingField;
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
					_003CKeyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid ParentKeyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CParentKeyUid_003Ek__BackingField;
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
					_003CParentKeyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Guid> PropertyParents { get; set; }

	public TreeStructureViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wELELOoKKnaawDgsjSKF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
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
			PropertyParents = new List<Guid>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
			{
				num = 1;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_0057, IL_0066
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return ccj56NoKXIsyVq7MraKV(parentViewItem, this);
			case 1:
				return true;
			case 2:
				if (parentViewItem == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializePropertyParents()
	{
		//Discarded unreachable code: IL_003e, IL_004d
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return VRswVAoKT7coMXP9cO9X(PropertyParents) > 0;
			default:
				return false;
			case 1:
				if (PropertyParents == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	internal static void wELELOoKKnaawDgsjSKF()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool a4xNykoKRNmrhJbR3Jbn()
	{
		return ydqamSoKidFuNhOWwsrw == null;
	}

	internal static TreeStructureViewItem wF87YKoKq6mXxh6LbU1g()
	{
		return ydqamSoKidFuNhOWwsrw;
	}

	internal static bool ccj56NoKXIsyVq7MraKV(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static int VRswVAoKT7coMXP9cO9X(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}
}

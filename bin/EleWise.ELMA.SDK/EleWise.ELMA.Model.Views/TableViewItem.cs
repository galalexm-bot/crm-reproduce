using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class TableViewItem : RootViewItem, ISelectionItemViewItem, IDynamicViewItem, IViewItemWithPropertyParents
{
	internal static TableViewItem zZR6WVoRTwQDj9VacQ1x;

	[DefaultValue(null)]
	public TableView TableView
	{
		[CompilerGenerated]
		get
		{
			return _003CTableView_003Ek__BackingField;
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
					_003CTableView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
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

	[DefaultValue(null)]
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
				case 0:
					return;
				case 1:
					_003CPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Guid> PropertyParents { get; set; }

	public bool EnableSelection
	{
		[CompilerGenerated]
		get
		{
			return _003CEnableSelection_003Ek__BackingField;
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
					_003CEnableSelection_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid SelectablePropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CSelectablePropertyUid_003Ek__BackingField;
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
					_003CSelectablePropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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

	public List<Guid> SelectablePropertyParents { get; set; }

	public TableViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tojgGKoROYqBhrT0lMcb();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				PropertyParents = new List<Guid>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return LcYpfJoR2x4PIkgVxWBH(parentViewItem, this);
			default:
				return true;
			case 1:
				if (parentViewItem == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
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
		return childViewItem is IGridColumnViewItem;
	}

	public override bool IsHideEmpty(RootViewItem parent = null)
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 1;
		int num2 = num;
		while (true)
		{
			RootViewItem rootViewItem;
			RootViewItem rootViewItem2;
			switch (num2)
			{
			case 3:
				rootViewItem = parent;
				if (rootViewItem == null)
				{
					num2 = 5;
					break;
				}
				goto IL_00d1;
			case 2:
				return base.HideEmptySettings == HideEmptyEnum.HideEmpty;
			default:
				rootViewItem2 = parent;
				if (rootViewItem2 == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto IL_00bc;
			case 1:
				if (base.HideEmptySettings == HideEmptyEnum.Inherit)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				rootViewItem2 = base.Parent;
				goto IL_00bc;
			case 5:
				{
					rootViewItem = base.Parent;
					goto IL_00d1;
				}
				IL_00bc:
				if (rootViewItem2 != null)
				{
					num2 = 3;
					break;
				}
				return false;
				IL_00d1:
				return rootViewItem.IsHideEmpty();
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializePropertyParents()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return P3BgoMoResOjmlvh0w02(PropertyParents) > 0;
			case 1:
				if (PropertyParents == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeSelectablePropertyParents()
	{
		//Discarded unreachable code: IL_0063, IL_0072
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (SelectablePropertyParents == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return P3BgoMoResOjmlvh0w02(SelectablePropertyParents) > 0;
			default:
				return false;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeSelectablePropertyUid()
	{
		return RSSHpNoRPB9seFEu7dEK(SelectablePropertyUid, Guid.Empty);
	}

	internal static void tojgGKoROYqBhrT0lMcb()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool wHidkboRkmmvOQNeFwcS()
	{
		return zZR6WVoRTwQDj9VacQ1x == null;
	}

	internal static TableViewItem rap6pKoRnE7TnXWP4SIy()
	{
		return zZR6WVoRTwQDj9VacQ1x;
	}

	internal static bool LcYpfJoR2x4PIkgVxWBH(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static int P3BgoMoResOjmlvh0w02(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static bool RSSHpNoRPB9seFEu7dEK(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}
}

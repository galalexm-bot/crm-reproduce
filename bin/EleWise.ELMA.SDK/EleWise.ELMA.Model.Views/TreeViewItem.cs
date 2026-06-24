using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class TreeViewItem : RootViewItem, ISelectionItemViewItem, ITreeViewItem, IDynamicViewItem, IViewItemWithPropertyParents
{
	private static TreeViewItem Aj3xnJoR1XlaRu1nhmZp;

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(ViewItemTreeType.Default)]
	public ViewItemTreeType Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
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
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Guid> PropertyParents { get; set; }

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public bool IsExpanded
	{
		[CompilerGenerated]
		get
		{
			return _003CIsExpanded_003Ek__BackingField;
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
					_003CIsExpanded_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
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
				case 0:
					return;
				case 1:
					_003CSelectablePropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Guid> SelectablePropertyParents { get; set; }

	[DefaultValue(false)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public bool ShowTreeButtons
	{
		[CompilerGenerated]
		get
		{
			return _003CShowTreeButtons_003Ek__BackingField;
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
					_003CShowTreeButtons_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

	public TreeViewItem()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		zNPdXRoRpPiLfewBgiHP();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				PropertyParents = new List<Guid>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				Type = ViewItemTreeType.Default;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_0057, IL_0066
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (parentViewItem == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return parentViewItem.IsChildValid(this);
			default:
				return true;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is DynamicSlotViewItem;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializePropertyParents()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return PropertyParents.Count > 0;
			case 1:
				return false;
			case 2:
				if (PropertyParents == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeSelectablePropertyParents()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return AbEt2KoRaFWdt4n7pmOR(SelectablePropertyParents) > 0;
			default:
				return false;
			case 1:
				if (SelectablePropertyParents == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeSelectablePropertyUid()
	{
		return HiKGmxoRDvL8HA8k7Rak(SelectablePropertyUid, Guid.Empty);
	}

	internal static void zNPdXRoRpPiLfewBgiHP()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool VYeJfToRNeEJ45MS4tky()
	{
		return Aj3xnJoR1XlaRu1nhmZp == null;
	}

	internal static TreeViewItem xK77b3oR3ACB7T6vosfS()
	{
		return Aj3xnJoR1XlaRu1nhmZp;
	}

	internal static int AbEt2KoRaFWdt4n7pmOR(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static bool HiKGmxoRDvL8HA8k7Rak(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}
}

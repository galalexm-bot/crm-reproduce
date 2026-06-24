using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Diagrammer;

[Serializable]
public class BaseDiagrammerShapeViewItem : RootViewItem
{
	internal static BaseDiagrammerShapeViewItem E05CKDowUq0t4cCCiNws;

	private Guid Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
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
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
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
				case 1:
					_003CPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
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

	public bool IsSelected
	{
		[CompilerGenerated]
		get
		{
			return _003CIsSelected_003Ek__BackingField;
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
					_003CIsSelected_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private bool DisplayControls
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayControls_003Ek__BackingField;
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
					_003CDisplayControls_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is SlotViewItem;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_0072, IL_0081, IL_0091, IL_00a0, IL_00d6, IL_00e5
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (parentViewItem == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 4:
				if (WKFe22owz1jLC8v4CPCD(parentViewItem) == null)
				{
					num2 = 6;
					break;
				}
				goto case 5;
			default:
				if (!(parentViewItem is DynamicListViewItem))
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 5:
				return parentViewItem.Parent is DiagrammerViewItem;
			case 1:
			case 3:
			case 6:
				return false;
			}
		}
	}

	public BaseDiagrammerShapeViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.PushGlobal();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool SObgqbows93qikjRcu52()
	{
		return E05CKDowUq0t4cCCiNws == null;
	}

	internal static BaseDiagrammerShapeViewItem cMeg9Howc5JfcoKKotIW()
	{
		return E05CKDowUq0t4cCCiNws;
	}

	internal static object WKFe22owz1jLC8v4CPCD(object P_0)
	{
		return ((ViewItem)P_0).Parent;
	}
}

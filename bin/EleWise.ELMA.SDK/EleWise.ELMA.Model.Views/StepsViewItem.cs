using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public sealed class StepsViewItem : RootViewItem, ILayoutViewItem, IViewItemWithActiveKey, IViewItemWithPropertyParents
{
	private static StepsViewItem no4witoirV79JDiJ5gW5;

	[DefaultValue(DirectionType.Horizontal)]
	public DirectionType Direction
	{
		[CompilerGenerated]
		get
		{
			return _003CDirection_003Ek__BackingField;
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
					_003CDirection_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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

	public StepsViewItem()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		Smi74woijIqqoWXiAPfA();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				Direction = DirectionType.Horizontal;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num = 0;
				}
				break;
			default:
				PropertyParents = new List<Guid>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
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
			case 1:
				if (PropertyParents != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return PropertyParents.Count > 0;
			}
		}
	}

	internal static void Smi74woijIqqoWXiAPfA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Gs0QZfoigl1y8nHYWM2j()
	{
		return no4witoirV79JDiJ5gW5 == null;
	}

	internal static StepsViewItem aZi5x1oi5em4tOb4Cb20()
	{
		return no4witoirV79JDiJ5gW5;
	}
}

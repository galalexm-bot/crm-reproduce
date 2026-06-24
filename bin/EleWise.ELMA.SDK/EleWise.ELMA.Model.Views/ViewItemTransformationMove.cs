using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class ViewItemTransformationMove : ViewItemTransformation
{
	private static ViewItemTransformationMove suqrkooPrKSIkiaWDyOv;

	public Guid MoveItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CMoveItemUid_003Ek__BackingField;
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
					_003CMoveItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
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

	public Guid? BeforeItem { get; set; }

	public Guid? AfterItem { get; set; }

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeBeforeItem()
	{
		int num = 1;
		int num2 = num;
		Guid? beforeItem = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				beforeItem = BeforeItem;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return beforeItem.HasValue;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeAfterItem()
	{
		int num = 1;
		int num2 = num;
		Guid? afterItem = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			default:
				return afterItem.HasValue;
			case 1:
				afterItem = AfterItem;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void Apply(ViewItem formViewItem)
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
				TransformationMove<ViewItem, TransformationViewItem, Guid, Guid?>.StaticApply(formViewItem, base.Uid, MoveItemUid, BeforeItem, AfterItem);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ViewItemTransformationMove()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool brkQjAoPgAi368x0IHmP()
	{
		return suqrkooPrKSIkiaWDyOv == null;
	}

	internal static ViewItemTransformationMove ku4cnYoP5CwlKthmNZ7m()
	{
		return suqrkooPrKSIkiaWDyOv;
	}
}

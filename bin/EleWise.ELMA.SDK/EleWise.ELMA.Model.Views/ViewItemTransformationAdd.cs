using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class ViewItemTransformationAdd : ViewItemTransformation
{
	internal static ViewItemTransformationAdd oU5RsJoPtBJSKbowNq1B;

	public ViewItem Item
	{
		[CompilerGenerated]
		get
		{
			return _003CItem_003Ek__BackingField;
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
					_003CItem_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
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
			default:
				return beforeItem.HasValue;
			case 1:
				beforeItem = BeforeItem;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override IEnumerable<string> GetLocalizableStrings()
	{
		IEnumerable<string> localizableStrings = base.GetLocalizableStrings();
		List<string> second = new List<string>();
		if (Item != null)
		{
			second = Item.GetLocalizableStrings().ToList();
		}
		return localizableStrings.Union(second).Distinct().ToArray();
	}

	public override void ApplyLocalization()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				base.ApplyLocalization();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				CFsOf9oP6rEZKNDuHwjH(Item);
				num2 = 3;
				break;
			case 1:
				if (Item != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 3:
				return;
			}
		}
	}

	public override void Apply(ViewItem formViewItem)
	{
		int num = 1;
		int num2 = num;
		TransformationViewItem instance = default(TransformationViewItem);
		while (true)
		{
			switch (num2)
			{
			default:
				TransformationAdd<ViewItem, TransformationViewItem, Guid, Guid?, ViewItem>.StaticApply(formViewItem, base.Uid, instance.Clone(Item), BeforeItem, AfterItem, instance);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				instance = Transformation<ViewItem, TransformationViewItem, Guid, Guid?>.Instance;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ViewItemTransformationAdd()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		eg0fV6oPHCeJmEDRIotx();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool CJwnihoPw0NJ9XNBImuB()
	{
		return oU5RsJoPtBJSKbowNq1B == null;
	}

	internal static ViewItemTransformationAdd ExaRoGoP4QgrvptfE5gJ()
	{
		return oU5RsJoPtBJSKbowNq1B;
	}

	internal static void CFsOf9oP6rEZKNDuHwjH(object P_0)
	{
		((ViewItem)P_0).ApplyLocalization();
	}

	internal static void eg0fV6oPHCeJmEDRIotx()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

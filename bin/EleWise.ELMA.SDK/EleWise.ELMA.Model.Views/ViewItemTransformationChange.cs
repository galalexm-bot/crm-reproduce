using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class ViewItemTransformationChange : ViewItemTransformation
{
	internal static ViewItemTransformationChange wkweMVoPAmbNaEmVKHmP;

	public string PropertyName
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyName_003Ek__BackingField;
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
					_003CPropertyName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public object Value
	{
		[CompilerGenerated]
		get
		{
			return _003CValue_003Ek__BackingField;
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
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
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

	[XmlAttribute("Type")]
	[DefaultValue("")]
	public string TypeName
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeName_003Ek__BackingField;
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
					_003CTypeName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool Localizable
	{
		[CompilerGenerated]
		get
		{
			return _003CLocalizable_003Ek__BackingField;
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
					_003CLocalizable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override void Apply(ViewItem formViewItem)
	{
		//Discarded unreachable code: IL_0128
		int num = 7;
		ViewItem viewItem = default(ViewItem);
		ComputedValueTransformation computedValueTransformation = default(ComputedValueTransformation);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 5:
					if (viewItem != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 3:
					return;
				default:
					computedValueTransformation.Apply(viewItem.DynamicProperties);
					num2 = 3;
					continue;
				case 6:
					if ((computedValueTransformation = Value as ComputedValueTransformation) == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					break;
				case 7:
					if (!dXtXFFoPmajob1g7B1HU(PropertyName, vZiceNoP0atY1sfKgrXT(0x2ACE37D ^ 0x2AE80AF)))
					{
						TransformationChange<ViewItem, TransformationViewItem, Guid, Guid?>.StaticApply(formViewItem, base.Uid, PropertyName, Value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 6;
					}
					continue;
				case 1:
					return;
				case 4:
					return;
				}
				break;
			}
			viewItem = Transformation<ViewItem, TransformationViewItem, Guid, Guid?>.Instance.FindItem(formViewItem, base.Uid);
			num = 5;
		}
	}

	internal static object CheckDynamicProperties(ViewItem viewItem, ViewItem originalItem)
	{
		//Discarded unreachable code: IL_002d, IL_003c, IL_006d
		int num = 2;
		int num2 = num;
		object items;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (viewItem != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto default;
			default:
				items = null;
				break;
			case 1:
				items = viewItem.DynamicProperties;
				break;
			}
			break;
		}
		return ComputedValueTransformation.CreateTransformation((IList<ComputedValue>)items, originalItem?.DynamicProperties);
	}

	public override IEnumerable<string> GetLocalizableStrings()
	{
		List<string> list = new List<string>();
		IEnumerable<string> localizableStrings = base.GetLocalizableStrings();
		if (localizableStrings != null)
		{
			list.AddRange(localizableStrings);
		}
		TransformationChange<ViewItem, TransformationViewItem, Guid, Guid?>.StaticGetLocalizableStrings(list, Localizable, Value);
		return list;
	}

	public override void ApplyLocalization()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Value = TransformationChange<ViewItem, TransformationViewItem, Guid, Guid?>.StaticApplyLocalization(Localizable, Value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				gfXSupoPyQnnlH2R9X2L(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public ViewItemTransformationChange()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LGUGgBoPMl8r18W3tyTo();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool k1UCG0oP7JYNt4FBWlrr()
	{
		return wkweMVoPAmbNaEmVKHmP == null;
	}

	internal static ViewItemTransformationChange nscr0qoPxiRnGYsLOGJ0()
	{
		return wkweMVoPAmbNaEmVKHmP;
	}

	internal static object vZiceNoP0atY1sfKgrXT(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool dXtXFFoPmajob1g7B1HU(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void gfXSupoPyQnnlH2R9X2L(object P_0)
	{
		((BaseTransformation<ViewItem, Guid>)P_0).ApplyLocalization();
	}

	internal static void LGUGgBoPMl8r18W3tyTo()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

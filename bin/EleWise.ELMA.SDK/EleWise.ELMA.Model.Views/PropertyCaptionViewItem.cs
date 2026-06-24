using System;
using System.Linq;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[DisplayName(typeof(__Resources_PropertyCaptionViewItem), "DisplayName")]
public class PropertyCaptionViewItem : PropertyViewItem
{
	internal static PropertyCaptionViewItem GReLEloO5DIEhrOQPWHl;

	public override bool IsMainPropertyViewItem()
	{
		//Discarded unreachable code: IL_00be, IL_00cd
		int num = 2;
		PropertyViewItem[] array = default(PropertyViewItem[]);
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		FormViewItem formViewItem = default(FormViewItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (array.Length == 0)
					{
						num2 = 9;
						break;
					}
					goto default;
				case 7:
					return true;
				case 2:
					_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (array.Length == 1)
					{
						num2 = 4;
						break;
					}
					goto IL_01dd;
				case 4:
					if (array[0] == this)
					{
						num2 = 10;
						break;
					}
					goto IL_01dd;
				case 6:
					return false;
				case 12:
					if (formViewItem != null)
					{
						goto end_IL_0012;
					}
					num2 = 7;
					break;
				case 5:
					if (array.OfType<PropertyCaptionViewItem>().FirstOrDefault() == this)
					{
						num2 = 11;
						break;
					}
					return false;
				case 1:
					if (!LaowYBoOLLV8s5O7fkp5(this))
					{
						formViewItem = base.FormViewItem;
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 12;
						}
					}
					else
					{
						num2 = 6;
					}
					break;
				case 8:
					array = formViewItem.FindItems(ignoreHide: false, (ViewItem i) => i is PropertyViewItem, delegate(ViewItem i)
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (i is PropertyViewItem)
								{
									return true;
								}
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
								{
									num4 = 0;
								}
								break;
							default:
								return !_003C_003Ec.DDhWXbCfR0PRlQ4iqMVw(i);
							}
						}
					}).Cast<PropertyViewItem>().Where(_003C_003Ec__DisplayClass0_._003CIsMainPropertyViewItem_003Eb__2)
						.ToArray();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 2;
					}
					break;
				case 9:
				case 10:
					return true;
				case 11:
					{
						return array.FirstOrDefault(delegate(PropertyViewItem p)
						{
							//Discarded unreachable code: IL_0061, IL_0070
							int num5 = 2;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								default:
									return !(p is PropertyDescriptionViewItem);
								case 1:
									return false;
								case 2:
									if (p is PropertyCaptionViewItem)
									{
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
										{
											num6 = 0;
										}
										break;
									}
									goto default;
								}
							}
						}) is PropertyValueViewItem;
					}
					IL_01dd:
					array = array.Where((PropertyViewItem p) => !_003C_003Ec.cshSvjCfqMjmM35MHZrA(p)).ToArray();
					num2 = 5;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			_003C_003Ec__DisplayClass0_.fullProperyUid = FullProperyUid().ToArray();
			num = 8;
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_004d, IL_005c
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return pinHe2oOUdy53W8FhX8N(parentViewItem, this);
			default:
				return true;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	public PropertyCaptionViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ThQltwoOsXtSo3ftAJd5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool LaowYBoOLLV8s5O7fkp5(object P_0)
	{
		return ((RootViewItem)P_0).IsReadOnly();
	}

	internal static bool qeXG1GoOjUiriLXCXVrh()
	{
		return GReLEloO5DIEhrOQPWHl == null;
	}

	internal static PropertyCaptionViewItem ObTHD0oOYZQGchFGdOZD()
	{
		return GReLEloO5DIEhrOQPWHl;
	}

	internal static bool pinHe2oOUdy53W8FhX8N(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static void ThQltwoOsXtSo3ftAJd5()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

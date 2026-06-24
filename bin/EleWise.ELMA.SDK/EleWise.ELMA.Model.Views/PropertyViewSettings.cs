using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[Component]
public class PropertyViewSettings : IXsiRoot, IEquatable<PropertyViewSettings>
{
	internal static PropertyViewSettings cHNB3RoNK3mQ9CQcQVNa;

	public List<ViewAttribute> Attributes { get; set; }

	public PropertyViewSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		r8GawUoNkdcboWfRU5aX();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Attributes = new List<ViewAttribute>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ViewAttribute GetForView(ViewType viewType)
	{
		return GetForView(viewType, ItemType.Default);
	}

	public ViewAttribute GetForView(ViewType viewType, ItemType itemType)
	{
		int num = 9;
		int num2 = num;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		ViewAttribute viewAttribute = default(ViewAttribute);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass6_.itemType = itemType;
				num2 = 4;
				break;
			case 7:
				viewAttribute = GetForView(ViewType.Edit, _003C_003Ec__DisplayClass6_.itemType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				_003C_003Ec__DisplayClass6_.viewType = viewType;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (viewAttribute != null)
				{
					num2 = 10;
					break;
				}
				viewAttribute = Attributes.FirstOrDefault(_003C_003Ec__DisplayClass6_._003CGetForView_003Eb__1);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 3;
				}
				break;
			case 10:
				return viewAttribute;
			case 3:
			{
				if (viewAttribute != null)
				{
					num2 = 2;
					break;
				}
				if (_003C_003Ec__DisplayClass6_.viewType == ViewType.Filter)
				{
					num2 = 7;
					break;
				}
				ViewAttribute viewAttribute2 = new ViewAttribute();
				YH7w8ooNOEe4jgiCaLhK(viewAttribute2, _003C_003Ec__DisplayClass6_.viewType);
				jgXvehoN2v7yVf0ASbAH(viewAttribute2, (_003C_003Ec__DisplayClass6_.viewType != ViewType.List) ? Visibility.Visible : Visibility.Hidden);
				return viewAttribute2;
			}
			case 2:
				return viewAttribute;
			default:
				vxLGVfoNnhHvEAPHVrgr(viewAttribute, false);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				viewAttribute = Attributes.FirstOrDefault(_003C_003Ec__DisplayClass6_._003CGetForView_003Eb__0);
				num2 = 5;
				break;
			case 9:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 8;
				}
				break;
			case 6:
				return viewAttribute;
			}
		}
	}

	public override bool Equals(object obj)
	{
		return KX8to0oNeuX4aly5Z2Cg(this, obj as PropertyViewSettings);
	}

	public virtual bool Equals(PropertyViewSettings s)
	{
		//Discarded unreachable code: IL_009b, IL_00aa, IL_0109, IL_0118, IL_01a1, IL_01b4, IL_01c3
		int num = 3;
		int num2 = num;
		List<ViewAttribute>.Enumerator enumerator = default(List<ViewAttribute>.Enumerator);
		bool result = default(bool);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (s == null)
				{
					num2 = 2;
				}
				else if (xkJFDooNPmKtIQq2omoD(Attributes) == xkJFDooNPmKtIQq2omoD(s.Attributes))
				{
					enumerator = Attributes.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 4;
				}
				continue;
			case 4:
				return false;
			case 2:
				return false;
			case 1:
				break;
			default:
				try
				{
					while (true)
					{
						IL_015f:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 6;
							goto IL_00b9;
						}
						goto IL_0123;
						IL_00b9:
						while (true)
						{
							switch (num3)
							{
							case 4:
								return result;
							case 3:
								result = false;
								num3 = 4;
								continue;
							case 2:
								_003C_003Ec__DisplayClass8_.attr = enumerator.Current;
								num3 = 5;
								continue;
							case 5:
								if (!s.Attributes.Any(_003C_003Ec__DisplayClass8_._003CEquals_003Eb__0))
								{
									num3 = 3;
									continue;
								}
								goto IL_015f;
							case 1:
								goto IL_015f;
							case 6:
								goto end_IL_015f;
							}
							break;
						}
						goto IL_0123;
						IL_0123:
						_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
						int num4 = 2;
						num3 = num4;
						goto IL_00b9;
						continue;
						end_IL_015f:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				break;
			}
			break;
		}
		return true;
	}

	internal static void r8GawUoNkdcboWfRU5aX()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool xKKX6AoNXl9SABDPPt5K()
	{
		return cHNB3RoNK3mQ9CQcQVNa == null;
	}

	internal static PropertyViewSettings o3lCkdoNTcI47obZ4Mef()
	{
		return cHNB3RoNK3mQ9CQcQVNa;
	}

	internal static void vxLGVfoNnhHvEAPHVrgr(object P_0, bool value)
	{
		((ViewAttribute)P_0).ReadOnly = value;
	}

	internal static void YH7w8ooNOEe4jgiCaLhK(object P_0, ViewType value)
	{
		((ViewAttribute)P_0).ViewType = value;
	}

	internal static void jgXvehoN2v7yVf0ASbAH(object P_0, Visibility value)
	{
		((ViewAttribute)P_0).Visibility = value;
	}

	internal static bool KX8to0oNeuX4aly5Z2Cg(object P_0, object P_1)
	{
		return ((PropertyViewSettings)P_0).Equals((PropertyViewSettings)P_1);
	}

	internal static int xkJFDooNPmKtIQq2omoD(object P_0)
	{
		return ((List<ViewAttribute>)P_0).Count;
	}
}

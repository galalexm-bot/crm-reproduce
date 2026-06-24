using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public class Int64PropertyDescriptor : FullTextPropertyDescriptor
{
	internal static Int64PropertyDescriptor pgJB4wGI8HJO1Bg2M6L9;

	public Int64PropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		ewQPd9GII5RXOR1SfRx5();
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (propMd != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return new FieldIndexList();
			default:
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), (obj == null) ? null : new long?(Convert.ToInt64(obj)), FullTextFieldType.Long)
				};
			}
		}
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_004d, IL_00c6, IL_00d5, IL_010b, IL_017c, IL_024d, IL_0285, IL_0294
		FilterListItem result2 = default(FilterListItem);
		switch (1)
		{
		default:
			return result2;
		case 1:
		{
			FilterListItem result = default(FilterListItem);
			try
			{
				Int64RangeWrapper int64RangeWrapper = value as Int64RangeWrapper;
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num = 0;
				}
				List<object> list = default(List<object>);
				while (true)
				{
					switch (num)
					{
					case 6:
						return result2;
					case 9:
						return result2;
					default:
						return result;
					case 0:
						return result;
					case 3:
					case 4:
						list = new List<object>();
						num = 12;
						break;
					case 8:
						result2 = new FilterListItem(ValueFieldName(propMd), list, FilterListItemType.Between, FullTextFieldType.Long);
						num = 9;
						break;
					case 5:
						if (GBhtP1GIVGvnxWmk0kDx(int64RangeWrapper))
						{
							num = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
							{
								num = 4;
							}
							break;
						}
						goto case 11;
					case 7:
						if (!int64RangeWrapper.HasFromValue)
						{
							num = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
							{
								num = 5;
							}
							break;
						}
						goto case 3;
					case 2:
						result2 = new FilterListItem(ValueFieldName(propMd), new List<object> { value }, FilterListItemType.Must, FullTextFieldType.Long);
						num = 6;
						break;
					case 1:
						if (int64RangeWrapper != null)
						{
							num = 7;
							break;
						}
						goto case 2;
					case 11:
						result = null;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num = 0;
						}
						break;
					case 12:
						list.Add(SVHNacGIS9DpjyiVoY9F(int64RangeWrapper) ? new long?(hK1RkBGIifWBK8SI295H(int64RangeWrapper)) : null);
						num = 10;
						break;
					case 10:
						list.Add(GBhtP1GIVGvnxWmk0kDx(int64RangeWrapper) ? new long?(txqNNmGIRZqAqe24CJXR(int64RangeWrapper)) : null);
						num = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num = 8;
						}
						break;
					}
				}
			}
			catch (Exception)
			{
				int num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						return result;
					case 0:
						return result;
					case 1:
						result = null;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}
		}
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(ValueFieldName(propMd), FullTextFieldType.Long);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_00f8, IL_019d, IL_01ac, IL_01d7, IL_0228, IL_0237, IL_0246
		int num = 11;
		int num2 = num;
		PropertyInfo propertyCached = default(PropertyInfo);
		WebDataItem webDataItem = default(WebDataItem);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
				return;
			case 10:
				if (propMd == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
				propertyCached = obj.GetType().GetPropertyCached(propMd.Name);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 11:
				if (obj == null)
				{
					return;
				}
				num2 = 10;
				break;
			case 4:
				if (webDataItem == null)
				{
					num2 = 8;
					break;
				}
				goto case 9;
			case 9:
				if (QE5g4xGIqR7o0ZtSnYu8(webDataItem.Name, ValueFieldName(propMd)))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 6;
					}
				}
				else
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 8:
				return;
			case 5:
				try
				{
					int num4;
					if (!long.TryParse((string)klHQQ6GIKMM4oZ1YIYPq(webDataItem), out var result))
					{
						int num3 = 2;
						num4 = num3;
						goto IL_012c;
					}
					goto IL_016e;
					IL_012c:
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							return;
						case 2:
						case 3:
							BWl6L1GIX2JKQLNqUGta(propertyCached, obj, null, null);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num4 = 0;
							}
							continue;
						case 4:
							break;
						}
						break;
					}
					goto IL_016e;
					IL_016e:
					BWl6L1GIX2JKQLNqUGta(propertyCached, obj, result, null);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num4 = 1;
					}
					goto IL_012c;
				}
				catch (Exception ex)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							return;
						}
						mmZmQ9GIncJRBEAKemN1(SKvY6VGITNjU13ujfN3S(), fR8v2HGIkxa3pkdCuWOo(-2138958856 ^ -2138973936), ex);
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num5 = 1;
						}
					}
				}
			case 3:
				return;
			case 6:
				return;
			case 1:
				webDataItem = value as WebDataItem;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (propertyCached == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_00a8, IL_00d7, IL_00fa, IL_019e, IL_01b5, IL_01ff, IL_0241, IL_0250
		int num = 9;
		PropertyInfo propertyCached = default(PropertyInfo);
		object value = default(object);
		object obj2 = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 2:
					if (propMd is PropertyMetadata)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 3;
						}
						continue;
					}
					num = 5;
					break;
				case 6:
					try
					{
						int num3;
						if (!WUsW9QGI2G3pBTqUJjA3(propMd as PropertyMetadata))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
							{
								num3 = 1;
							}
							goto IL_00ac;
						}
						goto IL_00e1;
						IL_00e1:
						BWl6L1GIX2JKQLNqUGta(propertyCached, obj, null, null);
						num3 = 6;
						goto IL_00ac;
						IL_00ac:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 6:
								return;
							case 2:
								break;
							case 1:
							case 3:
								value = base.TypeDescriptor.SerializeSimple(null, qX92s2GIePvhJuEqjF1y(typeof(long).TypeHandle));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
								{
									num3 = 4;
								}
								continue;
							case 5:
								BWl6L1GIX2JKQLNqUGta(propertyCached, obj, obj2, null);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
								obj2 = base.TypeDescriptor.DeserializeSimple(value, qX92s2GIePvhJuEqjF1y(typeof(long).TypeHandle));
								num3 = 5;
								continue;
							case 0:
								return;
							}
							break;
						}
						goto IL_00e1;
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
				case 1:
					if (DbQbq4GIOtbjLhkxOkyH(propertyCached, null))
					{
						return;
					}
					num = 7;
					break;
				case 4:
					if (propMd != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 3:
					return;
				case 8:
					return;
				case 10:
					return;
				default:
					propertyCached = obj.GetType().GetPropertyCached(propMd.Name);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					if (QE5g4xGIqR7o0ZtSnYu8(fieldName, ValueFieldName(propMd)))
					{
						return;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					if (obj == null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 4;
				}
				break;
			}
		}
	}

	internal static void ewQPd9GII5RXOR1SfRx5()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool xYAOUHGIZLFKtEBXfpWD()
	{
		return pgJB4wGI8HJO1Bg2M6L9 == null;
	}

	internal static Int64PropertyDescriptor AF6jQ4GIudNuJx6AVieP()
	{
		return pgJB4wGI8HJO1Bg2M6L9;
	}

	internal static bool GBhtP1GIVGvnxWmk0kDx(object P_0)
	{
		return ((Int64RangeWrapper)P_0).HasToValue;
	}

	internal static bool SVHNacGIS9DpjyiVoY9F(object P_0)
	{
		return ((Int64RangeWrapper)P_0).HasFromValue;
	}

	internal static long hK1RkBGIifWBK8SI295H(object P_0)
	{
		return ((Int64RangeWrapper)P_0).From;
	}

	internal static long txqNNmGIRZqAqe24CJXR(object P_0)
	{
		return ((Int64RangeWrapper)P_0).To;
	}

	internal static bool QE5g4xGIqR7o0ZtSnYu8(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object klHQQ6GIKMM4oZ1YIYPq(object P_0)
	{
		return ((WebDataItem)P_0).Value;
	}

	internal static void BWl6L1GIX2JKQLNqUGta(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object SKvY6VGITNjU13ujfN3S()
	{
		return Logger.Log;
	}

	internal static object fR8v2HGIkxa3pkdCuWOo(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void mmZmQ9GIncJRBEAKemN1(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static bool DbQbq4GIOtbjLhkxOkyH(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static bool WUsW9QGI2G3pBTqUJjA3(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static Type qX92s2GIePvhJuEqjF1y(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}

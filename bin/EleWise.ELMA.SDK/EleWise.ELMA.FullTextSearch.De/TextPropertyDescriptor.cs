using System;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public class TextPropertyDescriptor : FullTextPropertyDescriptor
{
	private static TextPropertyDescriptor MORBMvGuDGw2KmVCfpes;

	public override bool IsSupportedFullTextSearchInIndex => true;

	public TextPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
	{
		return new FieldIndexList
		{
			new FieldIndexListItem(ValueFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem(SortFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Sort)
		};
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		//Discarded unreachable code: IL_0075, IL_0084
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return new FieldIndexList();
			case 1:
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), Convert.ToString(obj), FullTextFieldType.String),
					new FieldIndexListItem(SortFieldName(propMd), FBHZhwGu4014KZDEjf6M(obj), FullTextFieldType.String)
				};
			case 2:
				if (propMd != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public override FieldListItem GetSearchField(object value, IPropertyMetadata propMd)
	{
		return new FieldListItem(ValueFieldName(propMd), (value == null) ? string.Empty : value.ToString());
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(SortFieldName(propMd), FullTextFieldType.String);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0059, IL_008a, IL_010a, IL_013d, IL_0194, IL_01a3, IL_01db, IL_0235, IL_0244
		int num = 3;
		WebDataItem webDataItem = default(WebDataItem);
		PropertyInfo propertyCached = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 5:
					return;
				case 8:
					webDataItem = value as WebDataItem;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					if (obj == null)
					{
						num2 = 2;
						break;
					}
					goto case 1;
				case 10:
					if (kxfqf7GuHEBmqjost8Wb(propertyCached, null))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 7;
				case 1:
					if (propMd == null)
					{
						return;
					}
					goto end_IL_0012;
				case 13:
					try
					{
						propertyCached.SetValue(obj, SYCJBcGuxj9I18nws6hS(webDataItem), null);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return;
							}
							WOyxGdGumiu3Ygcb9opU(MiJNKEGu0h7KRZOQe8T4(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234154504), ex);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
							{
								num4 = 1;
							}
						}
					}
				case 12:
					if (!JE5gT0Gu7U93VOOWRltf(nF8Gt8GuATIDHVx3aiKy(webDataItem), ValueFieldName(propMd)))
					{
						num2 = 6;
						break;
					}
					return;
				case 0:
					return;
				case 7:
					if (webDataItem != null)
					{
						num2 = 12;
						break;
					}
					return;
				case 9:
					return;
				case 6:
					num2 = 13;
					break;
				case 2:
					return;
				case 4:
					return;
				case 11:
					propertyCached = obj.GetType().GetPropertyCached((string)HSaI4UGu6hNrC3JkFIva(propMd));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 8;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_0091, IL_00c6, IL_0147, IL_01c9, IL_01e0, IL_020b, IL_021a, IL_027b, IL_02d2, IL_02e1
		int num = 13;
		object value = default(object);
		PropertyInfo propertyCached = default(PropertyInfo);
		object obj2 = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 12:
					return;
				case 4:
					if (propMd is PropertyMetadata)
					{
						num = 2;
						break;
					}
					return;
				case 0:
					return;
				case 10:
					try
					{
						int num3;
						if (COYgPlGuy8a39aspA4Ri(propMd as PropertyMetadata))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
							{
								num3 = 0;
							}
							goto IL_00ca;
						}
						goto IL_00ec;
						IL_00ec:
						value = base.TypeDescriptor.SerializeSimple(null, typeof(string));
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num3 = 2;
						}
						goto IL_00ca;
						IL_00ca:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							default:
								propertyCached.SetValue(obj, null, null);
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
								{
									num3 = 1;
								}
								continue;
							case 3:
								return;
							case 2:
								obj2 = base.TypeDescriptor.DeserializeSimple(value, CLc4tSGuMZwJ189DkwVq(typeof(string).TypeHandle));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
								{
									num3 = 4;
								}
								continue;
							case 4:
								w6B5NKGuJNkQX6vJn4pb(propertyCached, obj, obj2, null);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								return;
							}
							break;
						}
						goto IL_00ec;
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
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
					return;
				case 8:
					return;
				case 2:
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					if (propMd != null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					return;
				case 11:
					if (JE5gT0Gu7U93VOOWRltf(fieldName, ValueFieldName(propMd)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 13:
					if (obj == null)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 7;
				case 3:
					if (kxfqf7GuHEBmqjost8Wb(propertyCached, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 11;
				case 6:
					return;
				case 5:
					return;
				case 9:
					propertyCached = obj.GetType().GetPropertyCached((string)HSaI4UGu6hNrC3JkFIva(propMd));
					num = 3;
					break;
				}
				break;
			}
		}
	}

	internal static bool B5xH1VGutso8n0bLhsNv()
	{
		return MORBMvGuDGw2KmVCfpes == null;
	}

	internal static TextPropertyDescriptor PCsxh7GuwSJcdslWlxQF()
	{
		return MORBMvGuDGw2KmVCfpes;
	}

	internal static object FBHZhwGu4014KZDEjf6M(object P_0)
	{
		return StringPropertyDescriptor.ConvertToSortable(P_0);
	}

	internal static object HSaI4UGu6hNrC3JkFIva(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool kxfqf7GuHEBmqjost8Wb(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object nF8Gt8GuATIDHVx3aiKy(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static bool JE5gT0Gu7U93VOOWRltf(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object SYCJBcGuxj9I18nws6hS(object P_0)
	{
		return ((WebDataItem)P_0).Value;
	}

	internal static object MiJNKEGu0h7KRZOQe8T4()
	{
		return Logger.Log;
	}

	internal static void WOyxGdGumiu3Ygcb9opU(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static bool COYgPlGuy8a39aspA4Ri(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static Type CLc4tSGuMZwJ189DkwVq(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void w6B5NKGuJNkQX6vJn4pb(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}
}

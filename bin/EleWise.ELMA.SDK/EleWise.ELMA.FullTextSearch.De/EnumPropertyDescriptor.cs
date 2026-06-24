using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public class EnumPropertyDescriptor : FullTextPropertyDescriptor
{
	private Func<IPropertyMetadata, string> indexFieldName;

	private static EnumPropertyDescriptor e6Sl2qG8ggH8o8ZyRwbs;

	public EnumPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_005d, IL_0062
		O0EIknG8Y0HOn6dCd6PF();
		indexFieldName = (IPropertyMetadata propMd) => (string)_003C_003Ec.ySRHGEvYh3kdRoVTsuE1(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53DEC47), _003C_003Ec.rLGG6WvYoYNVrUW38xDu(propMd).ToString(), _003C_003Ec.DRCE95vYbVR0tEfrZkpS(-29254301 ^ -29339625));
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
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
			new FieldIndexListItem(ValueFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Sort),
			new FieldIndexListItem(indexFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Value)
		};
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		//Discarded unreachable code: IL_003f, IL_004e
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return GetIndexField(obj, propMd);
			case 1:
				return GetReIndexField(obj, propMd);
			case 2:
				if (reindex)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0061, IL_0070
		int num = 4;
		int num2 = num;
		EnumBase enumBase = default(EnumBase);
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 5:
				return new FieldIndexList();
			default:
				enumBase = obj as EnumBase;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 4:
				if (propMd == null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 1:
				return new FieldIndexList
				{
					new FieldIndexListItem(indexFieldName(propMd), qF8VhLG8LUb9cfp0FG9f(enumBase, null) ? tBw58dG8seiE5E32XlGx(enumBase).ToString((string)J2WkynG8cWLttdTyybZN(0x57A5235E ^ 0x57A5D916)) : cAaL2AG8UO6tAIgDCqq6(obj).ToString(), FullTextFieldType.String),
					new FieldIndexListItem(ValueFieldName(propMd), AS9XJPG8z26yM37OYZq1(qF8VhLG8LUb9cfp0FG9f(enumBase, null) ? enumBase.Name : obj.ToString()), FullTextFieldType.String)
				};
			}
		}
	}

	private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_009c, IL_00ab, IL_00bb, IL_00ca
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (obj == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				return GetIndexField(obj, propMd);
			case 3:
				return new FieldIndexList
				{
					new FieldIndexListItem(indexFieldName(propMd), null, FullTextFieldType.String),
					new FieldIndexListItem(ValueFieldName(propMd), null, FullTextFieldType.String)
				};
			case 1:
				return new FieldIndexList();
			case 2:
				if (propMd == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0052, IL_00a9, IL_0151, IL_01af, IL_01be, IL_01ce, IL_01dc, IL_02e9, IL_02fc, IL_030b, IL_03e0, IL_0418
		int num = 2;
		int num2 = num;
		ListInfo listInfo = default(ListInfo);
		List<object> list = default(List<object>);
		FilterListItem result = default(FilterListItem);
		List<object>.Enumerator enumerator = default(List<object>.Enumerator);
		EnumBaseWrapper enumBaseWrapper = default(EnumBaseWrapper);
		object current = default(object);
		EnumBaseWrapper enumBaseWrapper2 = default(EnumBaseWrapper);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					int num3;
					if (value is System.Enum)
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num3 = 2;
						}
						goto IL_0056;
					}
					goto IL_0173;
					IL_0056:
					while (true)
					{
						switch (num3)
						{
						case 3:
							if (listInfo.Objects != null)
							{
								num3 = 14;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						case 4:
							if (listInfo == null)
							{
								num3 = 16;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
								{
									num3 = 16;
								}
								continue;
							}
							goto case 3;
						case 11:
							list = new List<object>();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
							{
								num3 = 0;
							}
							continue;
						case 12:
							result = new FilterListItem(indexFieldName(propMd), list, FilterListItemType.Must, FullTextFieldType.String);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
							{
								num3 = 1;
							}
							continue;
						case 16:
							break;
						default:
							enumerator = listInfo.Objects.GetEnumerator();
							num3 = 7;
							continue;
						case 6:
							goto IL_0173;
						case 2:
						case 15:
							enumBaseWrapper = value as EnumBaseWrapper;
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num3 = 1;
							}
							continue;
						case 13:
							break;
						case 7:
							try
							{
								while (true)
								{
									IL_0234:
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
										{
											num4 = 0;
										}
										goto IL_01e0;
									}
									goto IL_01fe;
									IL_01fe:
									current = enumerator.Current;
									num4 = 4;
									goto IL_01e0;
									IL_01e0:
									while (true)
									{
										switch (num4)
										{
										case 2:
											break;
										case 4:
											enumBaseWrapper2 = current as EnumBaseWrapper;
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
											{
												num4 = 3;
											}
											continue;
										default:
											goto IL_0234;
										case 3:
											list.Add((enumBaseWrapper2 != null) ? WiEpCTGZFVY3Fg6QtUJI(enumBaseWrapper2).ToString((string)J2WkynG8cWLttdTyybZN(-70037984 ^ -70011800)) : cAaL2AG8UO6tAIgDCqq6(current).ToString());
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
											{
												num4 = 0;
											}
											continue;
										case 1:
											goto end_IL_0234;
										}
										break;
									}
									goto IL_01fe;
									continue;
									end_IL_0234:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
							goto case 12;
						case 10:
							goto IL_0319;
						case 14:
							if (!listInfo.Objects.Any())
							{
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num3 = 13;
								}
								continue;
							}
							goto case 11;
						case 8:
							result = new FilterListItem(indexFieldName(propMd), new List<object> { (enumBaseWrapper != null) ? WiEpCTGZFVY3Fg6QtUJI(enumBaseWrapper).ToString((string)J2WkynG8cWLttdTyybZN(-1317790512 ^ -1317738856)) : cAaL2AG8UO6tAIgDCqq6(value).ToString() }, FilterListItemType.Must, FullTextFieldType.String);
							num3 = 5;
							continue;
						case 9:
							break;
						case 1:
							return result;
						case 5:
							return result;
						}
						break;
					}
					goto end_IL_002d;
					IL_0319:
					listInfo = value as ListInfo;
					num3 = 4;
					goto IL_0056;
					IL_0173:
					if (value is EnumBaseWrapper)
					{
						num3 = 15;
						goto IL_0056;
					}
					goto IL_0319;
					end_IL_002d:;
				}
				catch (Exception)
				{
					int num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							result = null;
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
							{
								num6 = 0;
							}
							break;
						default:
							return result;
						case 0:
							return result;
						}
					}
				}
				goto case 3;
			case 3:
				return null;
			case 2:
				if (value == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 1:
				return null;
			}
		}
	}

	public override List<string> GetReturnField(IPropertyMetadata propMd)
	{
		return new List<string> { indexFieldName(propMd) };
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(ValueFieldName(propMd), FullTextFieldType.String);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0071, IL_0148, IL_0195, IL_0251, IL_02a8, IL_02b7, IL_02c6, IL_02d6, IL_02e5, IL_036c
		int num = 15;
		WebDataItem webDataItem = default(WebDataItem);
		PropertyInfo propertyCached = default(PropertyInfo);
		EnumMetadata metadata = default(EnumMetadata);
		List<EnumValueMetadata> list2 = default(List<EnumValueMetadata>);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				List<EnumValueMetadata> list;
				switch (num2)
				{
				case 6:
					return;
				case 17:
					return;
				case 5:
					if (webDataItem == null)
					{
						num2 = 6;
						continue;
					}
					goto case 7;
				case 4:
					return;
				case 16:
					propertyCached = obj.GetType().GetPropertyCached((string)zOstC9GZBmPrwItGR9oM(propMd));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
					if (propMd == null)
					{
						return;
					}
					num2 = 16;
					continue;
				case 3:
					webDataItem = value as WebDataItem;
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					continue;
				case 18:
					if (BPFob3GZWC9j0wcieCBS(propertyCached, null))
					{
						return;
					}
					num2 = 5;
					continue;
				case 2:
					if (kbWn0ZGZGo1EEEH8gxy6(metadata) == EnumMetadataType.Enum)
					{
						num2 = 12;
						continue;
					}
					goto case 10;
				case 8:
					if (metadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 19:
					try
					{
						if (list2 == null)
						{
							return;
						}
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (list2[0] != null)
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
									{
										num3 = 2;
									}
									continue;
								}
								return;
							case 2:
								Ao17SmGZfFROKhKqrDCP(propertyCached, obj, AiuVkmGZEQinYwVvpaE7(list2[0]), null);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								return;
							}
							if (list2.Any())
							{
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num3 = 1;
								}
								continue;
							}
							return;
						}
					}
					catch (Exception exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
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
							Logger.Log.Warn(J2WkynG8cWLttdTyybZN(0x6DC147B0 ^ 0x6DC28D58), exception);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
							{
								num4 = 0;
							}
						}
					}
				case 13:
					return;
				case 15:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 14;
					continue;
				case 14:
					if (obj == null)
					{
						return;
					}
					num2 = 11;
					continue;
				case 7:
					if (!((string)gtkFP0GZoEVTgv9xT3EE(webDataItem) != indexFieldName(propMd)))
					{
						metadata = GetMetadata(AxAg58GZb7jTGFe6u44s(propMd), throwOnError: false);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 8;
						}
					}
					else
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 7;
						}
					}
					continue;
				case 10:
					list = metadata.Values.Where(_003C_003Ec__DisplayClass9_._003CSetIndexField_003Eb__1).ToList();
					break;
				case 9:
					goto end_IL_0012;
				case 1:
					return;
				default:
					int.TryParse(webDataItem.Value, out _003C_003Ec__DisplayClass9_.valueInt);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 2;
					}
					continue;
				case 12:
					list = metadata.Values.Where(_003C_003Ec__DisplayClass9_._003CSetIndexField_003Eb__0).ToList();
					break;
				}
				list2 = list;
				num2 = 19;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 17;
				}
				continue;
				end_IL_0012:
				break;
			}
			Guid.TryParse((string)eAoexSGZhg1QjM2kfTeN(webDataItem), out _003C_003Ec__DisplayClass9_.valueUid);
			num = 2;
		}
	}

	private EnumMetadata GetMetadata(Guid subTypeUid, bool throwOnError)
	{
		//Discarded unreachable code: IL_0062, IL_0094, IL_00cc, IL_011d, IL_012c
		int num = 2;
		int num2 = num;
		EnumMetadata enumMetadata = default(EnumMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					enumMetadata = (EnumMetadata)((IMetadataService)RmYHTXGZQ3eAAmDfbi4W()).GetMetadata(subTypeUid, loadImplementation: true);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							enumMetadata = null;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 3;
			case 3:
				if (enumMetadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return enumMetadata;
			case 2:
				enumMetadata = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (throwOnError)
				{
					num2 = 5;
					break;
				}
				goto case 4;
			case 4:
				return null;
			case 5:
				throw new TypeNotFoundException(subTypeUid);
			}
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_00ea, IL_00f9, IL_0108, IL_0166, IL_0198, IL_01af
		int num = 7;
		int num2 = num;
		PropertyInfo propertyCached = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!(fieldName != indexFieldName(propMd)))
				{
					num2 = 8;
					break;
				}
				return;
			case 3:
				if (propMd != null)
				{
					num2 = 9;
					break;
				}
				return;
			case 7:
				if (obj == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			case 8:
				if (!(propMd is PropertyMetadata))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 10;
					}
				}
				break;
			case 1:
				if (!BPFob3GZWC9j0wcieCBS(propertyCached, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 6:
				return;
			case 5:
				return;
			case 9:
				propertyCached = obj.GetType().GetPropertyCached((string)zOstC9GZBmPrwItGR9oM(propMd));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				try
				{
					Ao17SmGZfFROKhKqrDCP(propertyCached, obj, null, null);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
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
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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
			case 4:
				return;
			case 2:
				return;
			}
		}
	}

	internal static void O0EIknG8Y0HOn6dCd6PF()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool xwMGPmG85XCYX5dtbS7s()
	{
		return e6Sl2qG8ggH8o8ZyRwbs == null;
	}

	internal static EnumPropertyDescriptor klcJH5G8jdIp9JR1cwSv()
	{
		return e6Sl2qG8ggH8o8ZyRwbs;
	}

	internal static bool qF8VhLG8LUb9cfp0FG9f(object P_0, object P_1)
	{
		return (EnumBase)P_0 != (EnumBase)P_1;
	}

	internal static long cAaL2AG8UO6tAIgDCqq6(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static Guid tBw58dG8seiE5E32XlGx(object P_0)
	{
		return ((EnumBase)P_0).Value;
	}

	internal static object J2WkynG8cWLttdTyybZN(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object AS9XJPG8z26yM37OYZq1(object P_0)
	{
		return StringPropertyDescriptor.ConvertToSortable(P_0);
	}

	internal static Guid WiEpCTGZFVY3Fg6QtUJI(object P_0)
	{
		return ((EnumBaseWrapper)P_0).Value;
	}

	internal static object zOstC9GZBmPrwItGR9oM(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool BPFob3GZWC9j0wcieCBS(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object gtkFP0GZoEVTgv9xT3EE(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static Guid AxAg58GZb7jTGFe6u44s(object P_0)
	{
		return ((IPropertyMetadata)P_0).SubTypeUid;
	}

	internal static object eAoexSGZhg1QjM2kfTeN(object P_0)
	{
		return ((WebDataItem)P_0).Value;
	}

	internal static EnumMetadataType kbWn0ZGZGo1EEEH8gxy6(object P_0)
	{
		return ((EnumMetadata)P_0).Type;
	}

	internal static object AiuVkmGZEQinYwVvpaE7(object P_0)
	{
		return ((EnumValueMetadata)P_0).EnumValue;
	}

	internal static void Ao17SmGZfFROKhKqrDCP(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object RmYHTXGZQ3eAAmDfbi4W()
	{
		return MetadataServiceContext.Service;
	}
}

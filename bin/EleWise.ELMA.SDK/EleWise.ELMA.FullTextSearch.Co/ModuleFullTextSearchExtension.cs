using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Components;

[Component]
public abstract class ModuleFullTextSearchExtension : IFullTextSearchFieldsMappingsReIndexingExtension, IFullTextSearchFieldsMappingsExtension, IModuleFullTextSearchExtension
{
	private IFullTextSearchDescriptorMappingService fullTextSearchDescriptorService;

	protected const int PageSize = 10;

	internal static ModuleFullTextSearchExtension JWBgQJGV1FbfMgqASqVi;

	private IFullTextSearchDescriptorMappingService FullTextSearchDescriptorService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IFullTextSearchDescriptorMappingService fullTextSearchDescriptorMappingService = default(IFullTextSearchDescriptorMappingService);
			IFullTextSearchDescriptorMappingService fullTextSearchDescriptorMappingService2;
			while (true)
			{
				switch (num2)
				{
				default:
					fullTextSearchDescriptorMappingService = (fullTextSearchDescriptorService = Locator.GetServiceNotNull<IFullTextSearchDescriptorMappingService>());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					fullTextSearchDescriptorMappingService2 = fullTextSearchDescriptorService;
					if (fullTextSearchDescriptorMappingService2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					fullTextSearchDescriptorMappingService2 = fullTextSearchDescriptorMappingService;
					break;
				}
				break;
			}
			return fullTextSearchDescriptorMappingService2;
		}
	}

	public virtual IGlobalSettingsModule SettingModule => null;

	public int GetPageSize()
	{
		//Discarded unreachable code: IL_00c0, IL_00cf, IL_00df
		int num = 4;
		int num2 = num;
		int setting = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (setting <= 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 5:
				if (setting >= 10000)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return setting;
			default:
				return 10;
			case 4:
				setting = SR.GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6D964D), 10);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual List<KeyValuePair<Type, Guid>> GetSupportedCardTypes(bool checkSettings = true)
	{
		return new List<KeyValuePair<Type, Guid>>();
	}

	public virtual Type GetSupportedCardType(Guid cardUid)
	{
		return null;
	}

	public virtual Guid? GetSupportedCardType(Type cardType)
	{
		return null;
	}

	public virtual Type GetSupportedCardTypeByTypeUid(Guid objectTypeUid)
	{
		return null;
	}

	public virtual Type GetSupportedCardTypeByObject(object obj)
	{
		return null;
	}

	public virtual FieldIndexList MappingFields(Type cardType)
	{
		return new FieldIndexList();
	}

	public virtual FieldIndexList MappingFields(Guid uid)
	{
		int num = 1;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return (FieldIndexList)sWcU1QGVpKTEdiur42dK(this, classMetadata);
			case 1:
				classMetadata = MetadataLoader.LoadMetadata(uid) as ClassMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual FieldIndexList MappingFields(ClassMetadata metadata)
	{
		//Discarded unreachable code: IL_0056, IL_0060, IL_008c, IL_01bd, IL_01cc, IL_021a, IL_022d, IL_023c, IL_031d, IL_0330, IL_033f, IL_0395
		int num = 4;
		int num2 = num;
		FieldIndexList fieldIndexList = default(FieldIndexList);
		List<Guid> list = default(List<Guid>);
		List<ClassMetadata>.Enumerator enumerator = default(List<ClassMetadata>.Enumerator);
		ClassMetadata current = default(ClassMetadata);
		List<IPropertyMetadata>.Enumerator enumerator2 = default(List<IPropertyMetadata>.Enumerator);
		FieldIndexList mappingField = default(FieldIndexList);
		IPropertyMetadata current2 = default(IPropertyMetadata);
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (metadata != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 2;
			case 1:
				return fieldIndexList;
			case 2:
				return new FieldIndexList();
			case 3:
			{
				List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(metadata);
				childClasses.Add(metadata);
				list = new List<Guid>();
				fieldIndexList = new FieldIndexList();
				enumerator = childClasses.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num3 = 0;
						}
						goto IL_0064;
					}
					goto IL_02de;
					IL_02de:
					current = enumerator.Current;
					num3 = 2;
					goto IL_0064;
					IL_0064:
					while (true)
					{
						switch (num3)
						{
						case 4:
							try
							{
								while (true)
								{
									IL_010c:
									int num4;
									if (!enumerator2.MoveNext())
									{
										num4 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
										{
											num4 = 2;
										}
										goto IL_009a;
									}
									goto IL_01d7;
									IL_009a:
									while (true)
									{
										switch (num4)
										{
										case 4:
											break;
										default:
											mappingField = FullTextSearchDescriptorService.GetMappingField(current2);
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
											{
												num4 = 6;
											}
											continue;
										case 7:
											goto IL_010c;
										case 5:
										case 9:
											list.Add(qDYaXFGVad9d4rZUM1bq(current2));
											num4 = 7;
											continue;
										case 6:
											if (mappingField != null)
											{
												num4 = 4;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
												{
													num4 = 2;
												}
												continue;
											}
											goto case 5;
										case 1:
											if (N7IuL8GVDRts2Ov4NhvQ(FullTextSearchDescriptorService, current2))
											{
												goto default;
											}
											goto IL_017d;
										case 2:
											if (!list.Contains(qDYaXFGVad9d4rZUM1bq(current2)))
											{
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
												{
													num4 = 1;
												}
												continue;
											}
											goto IL_010c;
										case 8:
											goto IL_01d7;
										case 3:
											goto end_IL_010c;
										}
										break;
									}
									fieldIndexList.AddRange(mappingField);
									int num5 = 5;
									goto IL_0096;
									IL_017d:
									num5 = 9;
									goto IL_0096;
									IL_01d7:
									current2 = enumerator2.Current;
									num5 = 2;
									goto IL_0096;
									IL_0096:
									num4 = num5;
									goto IL_009a;
									continue;
									end_IL_010c:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator2).Dispose();
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
								{
									num6 = 0;
								}
								switch (num6)
								{
								case 0:
									break;
								}
							}
							break;
						case 3:
						{
							List<IPropertyMetadata> list2 = new List<IPropertyMetadata>();
							_003C_003Ec__DisplayClass12_.baseProperties = MetadataLoader.GetBaseProperties(current);
							list2.AddRange(_003C_003Ec__DisplayClass12_.baseProperties);
							list2.AddRange(current.Properties.Where(_003C_003Ec__DisplayClass12_._003CMappingFields_003Eb__0));
							enumerator2 = list2.GetEnumerator();
							num3 = 4;
							continue;
						}
						case 1:
							break;
						case 2:
							_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num3 = 3;
							}
							continue;
						case 5:
							goto IL_02de;
						default:
							return fieldIndexList;
						case 0:
							return fieldIndexList;
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num7 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num7 = 0;
				}
				switch (num7)
				{
				case 0:
					break;
				}
			}
		}
	}

	protected virtual void ProcessingDynamicProperties(IEntity entity, IFullTextSearchObjectContainer objF)
	{
		//Discarded unreachable code: IL_009c, IL_00a6, IL_0106, IL_0115, IL_0191, IL_01c1, IL_01d0, IL_0240, IL_024f, IL_025a, IL_0306, IL_033e, IL_03be, IL_03d1, IL_03e0
		int num = 3;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		PropertyMetadata current = default(PropertyMetadata);
		IFullTextSearchDescriptorService serviceNotNull = default(IFullTextSearchDescriptorService);
		PropertyInfo propertyCached = default(PropertyInfo);
		FieldIndexList indexField = default(FieldIndexList);
		IEnumerator<FieldIndexListItem> enumerator2 = default(IEnumerator<FieldIndexListItem>);
		FieldIndexListItem current2 = default(FieldIndexListItem);
		while (true)
		{
			switch (num2)
			{
			case 3:
				classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entity.GetType());
				num2 = 2;
				break;
			case 1:
				return;
			case 5:
				enumerator = classMetadata.Properties.GetEnumerator();
				num2 = 4;
				break;
			case 6:
				dictionary = (IDictionary<string, object>)TsNiKRGVwa7fyJgkAsDd(objF);
				num2 = 5;
				break;
			default:
				VR9YIMGVttuIypmmn0A5(objF, new ExpandoObject());
				num2 = 6;
				break;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num3 = 12;
							}
							goto IL_00aa;
						}
						goto IL_0227;
						IL_0227:
						current = enumerator.Current;
						num3 = 9;
						goto IL_00aa;
						IL_00aa:
						while (true)
						{
							switch (num3)
							{
							case 12:
								return;
							case 9:
								serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchDescriptorService>();
								num3 = 14;
								continue;
							case 8:
								propertyCached = entity.GetType().GetPropertyCached(current.Name);
								num3 = 7;
								continue;
							case 14:
								if (!N7IuL8GVDRts2Ov4NhvQ(serviceNotNull, current))
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 8;
							case 4:
								if (indexField == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 13;
							case 10:
								indexField = serviceNotNull.GetIndexField(R6xfpYGV6quBgQXOOItm(propertyCached, entity, null), current, reindex: false);
								num3 = 4;
								continue;
							case 7:
								if (propertyCached != null)
								{
									num3 = 3;
									continue;
								}
								break;
							case 3:
								if (!EdepqIGV4AHt3tIaI5Gt(propertyCached))
								{
									num3 = 2;
									continue;
								}
								goto case 10;
							case 6:
								goto IL_0227;
							case 5:
								try
								{
									while (true)
									{
										int num4;
										if (!uBhgmNGV7nZEbaXkFfg4(enumerator2))
										{
											num4 = 3;
											goto IL_025e;
										}
										goto IL_02bd;
										IL_025e:
										while (true)
										{
											switch (num4)
											{
											case 2:
												dictionary[(string)fWUVAQGVHcaZj9j0cWGL(current2)] = dqj90nGVAm7CfwtRuYF9(current2);
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
												{
													num4 = 0;
												}
												continue;
											case 1:
												goto IL_02bd;
											case 3:
												goto end_IL_0278;
											}
											break;
										}
										continue;
										IL_02bd:
										current2 = enumerator2.Current;
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
										{
											num4 = 1;
										}
										goto IL_025e;
										continue;
										end_IL_0278:
										break;
									}
								}
								finally
								{
									if (enumerator2 != null)
									{
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
										{
											num5 = 1;
										}
										while (true)
										{
											switch (num5)
											{
											case 1:
												L87mgJGVxJL2IZK5w4qn(enumerator2);
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
												{
													num5 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								break;
							case 13:
								enumerator2 = indexField.Where((FieldIndexListItem f) => !_003C_003Ec.L7cm7cvYmDlQDawpQc9i(_003C_003Ec.UH0LZNvY0CgP20ckvQcP(f))).GetEnumerator();
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
								{
									num3 = 5;
								}
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
			case 2:
				if (classMetadata == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual Dictionary<Guid, List<string>> ProcessingDynamicFieldsMapping(ClassMetadata classMd)
	{
		Dictionary<Guid, List<string>> dictionary = new Dictionary<Guid, List<string>>();
		foreach (KeyValuePair<Guid, List<IPropertyMetadata>> item in SupportedDynamicFields(classMd))
		{
			if (!dictionary.ContainsKey(item.Key))
			{
				dictionary.Add(item.Key, item.Value.Select((IPropertyMetadata a) => (string)_003C_003Ec.vFTFSevYy6I4EU9OvWom(a)).ToList());
			}
		}
		return dictionary;
	}

	protected virtual Dictionary<Guid, List<IPropertyMetadata>> SupportedDynamicFields(ClassMetadata classMd)
	{
		List<ClassMetadata> list = (from c in MetadataLoader.GetChildClasses(classMd)
			where c != null
			select c).ToList();
		list.Add(classMd);
		Dictionary<Guid, List<IPropertyMetadata>> dictionary = new Dictionary<Guid, List<IPropertyMetadata>>();
		foreach (ClassMetadata item in list)
		{
			if (dictionary.ContainsKey(item.Uid))
			{
				continue;
			}
			_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
			List<IPropertyMetadata> list2 = new List<IPropertyMetadata>();
			List<IPropertyMetadata> list3 = new List<IPropertyMetadata>();
			CS_0024_003C_003E8__locals0.baseProperties = MetadataLoader.GetBaseProperties(item);
			list3.AddRange(CS_0024_003C_003E8__locals0.baseProperties);
			list3.AddRange(item.Properties.Where(delegate(PropertyMetadata p)
			{
				int num = 2;
				int num2 = num;
				_003C_003Ec__DisplayClass15_1 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_1);
				while (true)
				{
					switch (num2)
					{
					default:
						return CS_0024_003C_003E8__locals0.baseProperties.All(_003C_003Ec__DisplayClass15_._003CSupportedDynamicFields_003Eb__2);
					case 1:
						_003C_003Ec__DisplayClass15_.p = p;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_1();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}));
			foreach (IPropertyMetadata item2 in list3)
			{
				if (FullTextSearchDescriptorService.IsSupportedIndexing(item2))
				{
					list2.Add(item2);
				}
			}
			dictionary.Add(item.Uid, list2);
		}
		return dictionary;
	}

	public virtual Dictionary<Type, Dictionary<Guid, List<string>>> GetDynamicFieldsMapping()
	{
		return null;
	}

	public virtual Dictionary<string, Weight> GetWeightSearchFields(Type cardType)
	{
		return new Dictionary<string, Weight>();
	}

	public virtual Dictionary<string, string> GetReverseMapping(Type cardType)
	{
		return new Dictionary<string, string>();
	}

	public virtual Dictionary<string, long> GetHighlightsOrder(Type cardType)
	{
		return new Dictionary<string, long>();
	}

	public abstract List<string> GetHighlightFields(Type cardType);

	public virtual List<string> GetFields(Type cardType)
	{
		List<string> list = new List<string>();
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IFullTextSearchObject), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x5488AE68));
		list.Add(LinqUtils.NameOf(Expression.Lambda<Func<IFullTextSearchObject, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(IFullTextSearchObject), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E71E39));
		list.Add(LinqUtils.NameOf(Expression.Lambda<Func<IFullTextSearchObject, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		return list;
	}

	public virtual List<string> GetSearchFields(Type cardType)
	{
		return new List<string>();
	}

	public virtual List<string> GetSearchFields(Type cardType, IEntityFilter filter)
	{
		return new List<string>();
	}

	public virtual FilterList GetFilterFields(Type cardType, FullTextSearchResultModel searchModel)
	{
		return new FilterList();
	}

	public virtual FieldList GetCustomSearchFields(Type cardType, FilterProperty filterProperty)
	{
		return null;
	}

	public virtual FilterList GetCustomFilterFields(Type cardType, FilterProperty filterProperty, FullTextSearchResultModel searchModel)
	{
		//Discarded unreachable code: IL_016f, IL_0266, IL_0275, IL_031c, IL_0358, IL_0367, IL_0377, IL_038a, IL_0399, IL_03a8, IL_03b8, IL_03c7, IL_04ff, IL_0674, IL_06e0, IL_06f3, IL_0889, IL_0898, IL_08dc
		int num = 49;
		ParameterExpression parameterExpression = default(ParameterExpression);
		bool result4 = default(bool);
		bool result2 = default(bool);
		bool result6 = default(bool);
		bool result5 = default(bool);
		bool result = default(bool);
		bool result3 = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 36:
					if (!mMM03IGVdrverdH9PS8y(InterfaceActivator.LoadPropertyMetadata(Expression.Lambda<Func<IEntityFilter, object>>((Expression)k2dJvkGVriweX4Uga0Ym(akBjZiGVMYAZU31yq5WU(parameterExpression, (MethodInfo)rysjTEGVyvwanHqiuvEh((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), j8MeypGV0lbcuV1krpTY(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })).Uid, fjlFY9GV9M6o9S5tqXoE(filterProperty)))
					{
						num2 = 20;
						continue;
					}
					goto case 8;
				case 14:
					if (!result4)
					{
						num2 = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 46;
						}
						continue;
					}
					goto IL_05a3;
				case 10:
					if (!bool.TryParse(y8vy1wGVgTGIBqbWP18j(filterProperty).ToString(), out result2))
					{
						num2 = 52;
						continue;
					}
					goto case 12;
				case 2:
					if (mMM03IGVdrverdH9PS8y(Fgfg5sGVJ3qdkYYTUunp(InterfaceActivator.LoadPropertyMetadata(Expression.Lambda<Func<IEntityFilter, object>>((Expression)k2dJvkGVriweX4Uga0Ym(akBjZiGVMYAZU31yq5WU(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), j8MeypGV0lbcuV1krpTY(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }))), filterProperty.Uid))
					{
						num2 = 15;
						continue;
					}
					parameterExpression = (ParameterExpression)L6PsSqGVmNNVX4OUVkSs(j8MeypGV0lbcuV1krpTY(typeof(IEntityFilter).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68B9CF90));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 45;
					}
					continue;
				case 8:
					if (y8vy1wGVgTGIBqbWP18j(filterProperty) == null)
					{
						num2 = 30;
						continue;
					}
					goto case 40;
				case 4:
					if (mMM03IGVdrverdH9PS8y(Fgfg5sGVJ3qdkYYTUunp(InterfaceActivator.LoadPropertyMetadata(Expression.Lambda<Func<IEntityFilter, object>>((Expression)k2dJvkGVriweX4Uga0Ym(akBjZiGVMYAZU31yq5WU(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), j8MeypGV0lbcuV1krpTY(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }))), fjlFY9GV9M6o9S5tqXoE(filterProperty)))
					{
						num2 = 16;
						continue;
					}
					parameterExpression = (ParameterExpression)L6PsSqGVmNNVX4OUVkSs(j8MeypGV0lbcuV1krpTY(typeof(IEntityFilter).TypeHandle), tR85XbGVlJ1mqTyWbWbo(0x3CE17B75 ^ 0x3CE301DB));
					num2 = 36;
					continue;
				case 49:
					parameterExpression = (ParameterExpression)L6PsSqGVmNNVX4OUVkSs(j8MeypGV0lbcuV1krpTY(typeof(IEntityFilter).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957695762));
					num2 = 48;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 3;
					}
					continue;
				case 39:
					if (result6)
					{
						num2 = 7;
						continue;
					}
					goto case 35;
				case 9:
					if (filterProperty.Value != null)
					{
						num2 = 31;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 37;
						}
						continue;
					}
					goto case 35;
				case 25:
					if (result5)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 3;
				case 31:
					return new FilterList();
				case 42:
				case 52:
					return null;
				case 41:
					if (y8vy1wGVgTGIBqbWP18j(filterProperty) != null)
					{
						num2 = 47;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 27;
				case 23:
					if (y8vy1wGVgTGIBqbWP18j(filterProperty) != null)
					{
						num2 = 36;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 43;
						}
						continue;
					}
					goto case 3;
				case 40:
					if (bool.TryParse(y8vy1wGVgTGIBqbWP18j(filterProperty).ToString(), out result4))
					{
						num2 = 14;
						continue;
					}
					goto IL_05a3;
				case 38:
					if (bool.TryParse(y8vy1wGVgTGIBqbWP18j(filterProperty).ToString(), out result))
					{
						num2 = 22;
						continue;
					}
					goto case 1;
				case 26:
				case 34:
					return new FilterList();
				case 13:
					return null;
				case 44:
					if (filterProperty.Value != null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 31;
				case 45:
					if (mMM03IGVdrverdH9PS8y(Fgfg5sGVJ3qdkYYTUunp(InterfaceActivator.LoadPropertyMetadata(Expression.Lambda<Func<IEntityFilter, object>>(Expression.Convert((Expression)akBjZiGVMYAZU31yq5WU(parameterExpression, (MethodInfo)rysjTEGVyvwanHqiuvEh((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }))), fjlFY9GV9M6o9S5tqXoE(filterProperty)))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 3;
						}
					}
					else
					{
						parameterExpression = (ParameterExpression)L6PsSqGVmNNVX4OUVkSs(typeof(IEntityFilter), tR85XbGVlJ1mqTyWbWbo(0x7459E02 ^ 0x747E4AC));
						num2 = 50;
					}
					continue;
				case 37:
					if (bool.TryParse(y8vy1wGVgTGIBqbWP18j(filterProperty).ToString(), out result6))
					{
						num2 = 39;
						continue;
					}
					goto case 7;
				case 11:
					return new FilterList();
				case 33:
					return new FilterList();
				case 5:
					parameterExpression = (ParameterExpression)L6PsSqGVmNNVX4OUVkSs(typeof(IEntityFilter), tR85XbGVlJ1mqTyWbWbo(-538519530 ^ -538664264));
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 9;
					}
					continue;
				case 30:
				case 46:
					return new FilterList();
				case 20:
					parameterExpression = Expression.Parameter(j8MeypGV0lbcuV1krpTY(typeof(IEntityFilter).TypeHandle), (string)tR85XbGVlJ1mqTyWbWbo(0x68BBB53E ^ 0x68B9CF90));
					num2 = 2;
					continue;
				case 43:
					if (!bool.TryParse(filterProperty.Value.ToString(), out result5))
					{
						num2 = 6;
						continue;
					}
					goto case 25;
				case 12:
					if (result2)
					{
						num2 = 42;
						continue;
					}
					goto case 31;
				case 27:
					return new FilterList();
				case 47:
					return null;
				case 16:
					if (y8vy1wGVgTGIBqbWP18j(filterProperty) == null)
					{
						num2 = 26;
						continue;
					}
					goto case 29;
				case 24:
					if (!mMM03IGVdrverdH9PS8y(Fgfg5sGVJ3qdkYYTUunp(InterfaceActivator.LoadPropertyMetadata(Expression.Lambda<Func<IEntityFilter, object>>((Expression)akBjZiGVMYAZU31yq5WU(parameterExpression, (MethodInfo)rysjTEGVyvwanHqiuvEh((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))), filterProperty.Uid))
					{
						num2 = 5;
						continue;
					}
					goto case 33;
				case 17:
					if (!(Fgfg5sGVJ3qdkYYTUunp(InterfaceActivator.LoadPropertyMetadata(Expression.Lambda<Func<IEntityFilter, object>>(Expression.Convert((Expression)akBjZiGVMYAZU31yq5WU(parameterExpression, (MethodInfo)rysjTEGVyvwanHqiuvEh((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), j8MeypGV0lbcuV1krpTY(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }))) == fjlFY9GV9M6o9S5tqXoE(filterProperty)))
					{
						parameterExpression = (ParameterExpression)L6PsSqGVmNNVX4OUVkSs(j8MeypGV0lbcuV1krpTY(typeof(IEntityFilter).TypeHandle), tR85XbGVlJ1mqTyWbWbo(-2138958856 ^ -2139068074));
						num2 = 4;
					}
					else
					{
						num2 = 11;
					}
					continue;
				case 21:
					if (!mMM03IGVdrverdH9PS8y(Fgfg5sGVJ3qdkYYTUunp(InterfaceActivator.LoadPropertyMetadata(Expression.Lambda<Func<IEntityFilter, object>>(Expression.Convert((Expression)akBjZiGVMYAZU31yq5WU(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), j8MeypGV0lbcuV1krpTY(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }))), filterProperty.Uid))
					{
						num2 = 41;
						continue;
					}
					goto case 44;
				case 22:
					if (result)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 51:
					if (result3)
					{
						num2 = 13;
						continue;
					}
					goto case 26;
				case 50:
					if (mMM03IGVdrverdH9PS8y(InterfaceActivator.LoadPropertyMetadata(Expression.Lambda<Func<IEntityFilter, object>>((Expression)k2dJvkGVriweX4Uga0Ym(akBjZiGVMYAZU31yq5WU(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), j8MeypGV0lbcuV1krpTY(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })).Uid, filterProperty.Uid))
					{
						num = 23;
						break;
					}
					parameterExpression = (ParameterExpression)L6PsSqGVmNNVX4OUVkSs(typeof(IEntityFilter), tR85XbGVlJ1mqTyWbWbo(-1978478350 ^ -1978619300));
					num2 = 21;
					continue;
				case 15:
					if (filterProperty.Value == null)
					{
						num2 = 28;
						continue;
					}
					goto case 38;
				case 32:
					return new FilterList();
				case 19:
					parameterExpression = (ParameterExpression)L6PsSqGVmNNVX4OUVkSs(typeof(IEntityFilter), tR85XbGVlJ1mqTyWbWbo(-1217523399 ^ -1217631337));
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 24;
					}
					continue;
				default:
					return new FilterList();
				case 1:
					return null;
				case 35:
					return new FilterList();
				case 7:
					return null;
				case 29:
					if (bool.TryParse(y8vy1wGVgTGIBqbWP18j(filterProperty).ToString(), out result3))
					{
						num2 = 51;
						continue;
					}
					goto case 13;
				case 48:
					if (!mMM03IGVdrverdH9PS8y(Fgfg5sGVJ3qdkYYTUunp(InterfaceActivator.LoadPropertyMetadata(Expression.Lambda<Func<IEntityFilter, object>>((Expression)akBjZiGVMYAZU31yq5WU(parameterExpression, (MethodInfo)rysjTEGVyvwanHqiuvEh((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))), fjlFY9GV9M6o9S5tqXoE(filterProperty)))
					{
						num = 19;
						break;
					}
					goto case 32;
				case 3:
					return new FilterList();
				case 6:
				case 18:
					{
						return null;
					}
					IL_05a3:
					return null;
				}
				break;
			}
		}
	}

	public virtual FilterList GetAutoFilterFields(Type cardType, FilterProperty filterProperty, FullTextSearchResultModel searchModel)
	{
		return null;
	}

	public abstract void FillObject(Type cardType, IFullTextSearchObjectContainer obj, IEntity entity);

	public virtual List<IEntity> GetEntities(Type type, List<Guid> listUid)
	{
		return new List<IEntity>();
	}

	public virtual List<IEntity> GetEntities(Type cardType, List<long> listId)
	{
		return new List<IEntity>();
	}

	public virtual List<IEntity> LoadEntitiesByPage(Type cardType, int page, List<Guid> typeUidFilter = null)
	{
		return new List<IEntity>();
	}

	public virtual List<IEntity> LoadEntities(Type cardType, long? lastId, List<Guid> typeUidFilter = null)
	{
		return new List<IEntity>();
	}

	protected void SetFilterTypeUid(FullTextSearchResultModel resultModel, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_00ab, IL_00ba
		int num = 2;
		int num2 = num;
		ClassMetadata entityMetadataByFilter = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 4:
				return;
			case 5:
				entityMetadataByFilter = MetadataLoader.GetEntityMetadataByFilter(filter.GetType());
				num2 = 3;
				break;
			case 2:
				if (filter == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			default:
				resultModel.TypeUid = entityMetadataByFilter.Uid;
				num2 = 4;
				break;
			case 3:
				if (entityMetadataByFilter == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual FullTextSearchResultModel CreateResultModelByFilter(IEntityFilter filter)
	{
		return null;
	}

	public virtual SortList GetDefaultSortExpression()
	{
		return null;
	}

	public virtual List<KeyValuePair<string, object>> CreateFromObject(Type cardType, IFullTextSearchObjectContainer obj)
	{
		return new List<KeyValuePair<string, object>>();
	}

	public virtual void DisableIndexing(string disableInfo)
	{
	}

	public abstract void ReconstructEntity(Type cardType, IFullTextSearchResultItem resultItem, IEntity<long> fakeEntity);

	protected ModuleFullTextSearchExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool FlJxWnGVNbj4lCnUKt2T()
	{
		return JWBgQJGV1FbfMgqASqVi == null;
	}

	internal static ModuleFullTextSearchExtension sLyBvUGV3RTTJuJFlGlb()
	{
		return JWBgQJGV1FbfMgqASqVi;
	}

	internal static object sWcU1QGVpKTEdiur42dK(object P_0, object P_1)
	{
		return ((ModuleFullTextSearchExtension)P_0).MappingFields((ClassMetadata)P_1);
	}

	internal static Guid qDYaXFGVad9d4rZUM1bq(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static bool N7IuL8GVDRts2Ov4NhvQ(object P_0, object P_1)
	{
		return ((IFullTextSearchDescriptorService)P_0).IsSupportedIndexing((IPropertyMetadata)P_1);
	}

	internal static void VR9YIMGVttuIypmmn0A5(object P_0, object P_1)
	{
		((IFullTextSearchObjectContainer)P_0).Properties = (ExpandoObject)P_1;
	}

	internal static object TsNiKRGVwa7fyJgkAsDd(object P_0)
	{
		return ((IFullTextSearchObjectContainer)P_0).Properties;
	}

	internal static bool EdepqIGV4AHt3tIaI5Gt(object P_0)
	{
		return ((PropertyInfo)P_0).CanRead;
	}

	internal static object R6xfpYGV6quBgQXOOItm(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static object fWUVAQGVHcaZj9j0cWGL(object P_0)
	{
		return ((FieldIndexListItem)P_0).Field;
	}

	internal static object dqj90nGVAm7CfwtRuYF9(object P_0)
	{
		return ((FieldIndexListItem)P_0).Value;
	}

	internal static bool uBhgmNGV7nZEbaXkFfg4(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void L87mgJGVxJL2IZK5w4qn(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Type j8MeypGV0lbcuV1krpTY(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object L6PsSqGVmNNVX4OUVkSs(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object rysjTEGVyvwanHqiuvEh(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object akBjZiGVMYAZU31yq5WU(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static Guid Fgfg5sGVJ3qdkYYTUunp(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Guid fjlFY9GV9M6o9S5tqXoE(object P_0)
	{
		return ((FilterProperty)P_0).Uid;
	}

	internal static bool mMM03IGVdrverdH9PS8y(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object tR85XbGVlJ1mqTyWbWbo(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object k2dJvkGVriweX4Uga0Ym(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object y8vy1wGVgTGIBqbWP18j(object P_0)
	{
		return ((FilterProperty)P_0).Value;
	}
}

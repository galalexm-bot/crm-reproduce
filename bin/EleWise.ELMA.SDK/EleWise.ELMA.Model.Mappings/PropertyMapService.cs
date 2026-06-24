using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using Iesi.Collections;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Mappings;

[Service]
internal sealed class PropertyMapService : IPropertyMapService
{
	private readonly IMetadataRuntimeService metadataRuntimeService;

	private static PropertyMapService S6duK0hoVg54i8AivnIN;

	public PropertyMapService(IMetadataRuntimeService metadataRuntimeService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cEm9sQhoRClHhMViFhs5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.metadataRuntimeService = metadataRuntimeService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
			{
				num = 1;
			}
		}
	}

	public void Map(object objLeft, object objRight, PropertyMap map)
	{
		//Discarded unreachable code: IL_00c6, IL_0160, IL_016f, IL_023c, IL_028c, IL_02bf, IL_0385, IL_03c6, IL_03d7, IL_03e1, IL_03f0, IL_0473, IL_0492, IL_04ad, IL_04e9, IL_051c, IL_05a1, IL_05b0, IL_05c0, IL_068d, IL_06a0, IL_06c1, IL_075d, IL_0791, IL_07d1, IL_07dc, IL_07eb, IL_0825, IL_0834
		int num = 7;
		int num2 = num;
		IEnumerable<IPropertyMetadata> propertiesFromMetadata = default(IEnumerable<IPropertyMetadata>);
		ClassMetadata objectClassMetadata2 = default(ClassMetadata);
		IEnumerable<IPropertyMetadata> propertiesFromMetadata2 = default(IEnumerable<IPropertyMetadata>);
		List<PropertyMapItem>.Enumerator enumerator = default(List<PropertyMapItem>.Enumerator);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		IEntity entity = default(IEntity);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		IPropertyMetadata propertyMetadata2 = default(IPropertyMetadata);
		PropertyMetadata rightPropMd = default(PropertyMetadata);
		object obj3 = default(object);
		IPropertyMetadata propertyMetadata3 = default(IPropertyMetadata);
		ReplaceUidAtPropertyMapServiceContext replaceUidAtPropertyMapServiceContext = default(ReplaceUidAtPropertyMapServiceContext);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
				Contract.ArgumentNotNull(objLeft, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE110AB9));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				ex34fQhoKhg7DOPBF1bd(objRight, q1QeRDhoqJf8YTgHlG7t(0x68BBB53E ^ 0x68B896B6));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				try
				{
					ClassMetadata objectClassMetadata = GetObjectClassMetadata(objLeft);
					int num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							propertiesFromMetadata = GetPropertiesFromMetadata(objectClassMetadata);
							num3 = 4;
							break;
						case 2:
							objectClassMetadata2 = GetObjectClassMetadata(objRight);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
							{
								num3 = 1;
							}
							break;
						case 4:
							propertiesFromMetadata2 = GetPropertiesFromMetadata(objectClassMetadata2);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
							{
								num3 = 0;
							}
							break;
						default:
							enumerator = map.Items.GetEnumerator();
							num3 = 3;
							break;
						case 3:
							try
							{
								while (true)
								{
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 14;
										goto IL_017e;
									}
									goto IL_064c;
									IL_017e:
									while (true)
									{
										object obj;
										object obj2;
										switch (num4)
										{
										case 13:
											if (jEYlgdhokTRX2sSycJ1a(_003C_003Ec__DisplayClass2_.item) == Guid.Empty)
											{
												int num9 = 8;
												num4 = num9;
												continue;
											}
											goto case 24;
										case 3:
											obj = zbTeAVhoa8sj0qyPrEXl(entity, msV9lOhopTuXwkay6hrN(propertyMetadata));
											goto IL_0715;
										case 4:
											propertyMetadata = propertyMetadata2 as PropertyMetadata;
											num4 = 12;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
											{
												num4 = 4;
											}
											continue;
										case 18:
											try
											{
												MapProperty(objRight, rightPropMd, obj3, propertyMetadata);
												int num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
												{
													num5 = 0;
												}
												switch (num5)
												{
												case 0:
													break;
												}
											}
											catch (Exception ex)
											{
												int num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
												{
													num6 = 0;
												}
												while (true)
												{
													switch (num6)
													{
													case 1:
														uSbxHZho1D5t4Nh76uD7(av70MfhoDGdOmqkDcumu(), SugC6dho4nkjIiqMETEC(q1QeRDhoqJf8YTgHlG7t(--1333735954 ^ 0x4F7C1616), (propertyMetadata != null) ? K7Ux7ihowJQAnGJfs9nk(sJTlFwho2W1Lpxk4b5mv(objectClassMetadata), q1QeRDhoqJf8YTgHlG7t(-882126494 ^ -882127962), sJTlFwho2W1Lpxk4b5mv(propertyMetadata)) : BQ2hsThot30AOUQuqNjw(q1QeRDhoqJf8YTgHlG7t(0x4785BC0D ^ 0x47869855), obj3, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123637310)), sJTlFwho2W1Lpxk4b5mv(objectClassMetadata2), W5qSlkhoeYHG0jwT14AX(propertyMetadata3)), ex);
														num6 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
														{
															num6 = 0;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
											break;
										case 28:
											propertyMetadata3 = propertiesFromMetadata2.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CMap_003Eb__1);
											num4 = 22;
											continue;
										case 12:
											entity = objLeft as IEntity;
											num4 = 27;
											continue;
										case 29:
											obj = entity;
											goto IL_0715;
										case 23:
											_003C_003Ec__DisplayClass2_.item = enumerator.Current;
											num4 = 13;
											continue;
										case 2:
											if (propertyMetadata3 is TablePartMetadata)
											{
												num4 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
												{
													num4 = 5;
												}
												continue;
											}
											goto case 1;
										case 24:
											if (sjNsvshoOtAZLE3TRDd5(t4A2bJhonmytmLyGlmhB(_003C_003Ec__DisplayClass2_.item), Guid.Empty))
											{
												num4 = 4;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
												{
													num4 = 10;
												}
												continue;
											}
											goto case 20;
										case 9:
											obj = C4PEMnho3QJQw3VyqtNr(_003C_003Ec__DisplayClass2_.item);
											goto IL_0715;
										case 22:
											if (propertyMetadata3 == null)
											{
												num4 = 16;
												continue;
											}
											goto case 26;
										case 5:
											try
											{
												MapTablePart(objLeft, objRight, (TablePartMetadata)propertyMetadata2, (TablePartMetadata)propertyMetadata3, map);
												int num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
												{
													num7 = 0;
												}
												switch (num7)
												{
												case 0:
													break;
												}
											}
											catch (Exception ex2)
											{
												int num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
												{
													num8 = 0;
												}
												while (true)
												{
													switch (num8)
													{
													default:
														uSbxHZho1D5t4Nh76uD7(Logger.Log, tJTptZhoPrji1QLiw9k9(q1QeRDhoqJf8YTgHlG7t(--1867379187 ^ 0x6F4ED255), new object[4]
														{
															sJTlFwho2W1Lpxk4b5mv(objectClassMetadata),
															W5qSlkhoeYHG0jwT14AX(propertyMetadata2),
															sJTlFwho2W1Lpxk4b5mv(objectClassMetadata2),
															W5qSlkhoeYHG0jwT14AX(propertyMetadata3)
														}), ex2);
														num8 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
														{
															num8 = 0;
														}
														continue;
													case 1:
														break;
													}
													break;
												}
											}
											break;
										case 11:
										case 19:
											num4 = 18;
											continue;
										case 27:
											if (propertyMetadata == null)
											{
												num4 = 25;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
												{
													num4 = 14;
												}
												continue;
											}
											if (entity == null)
											{
												num4 = 21;
												continue;
											}
											goto case 3;
										case 26:
											if (propertyMetadata2 is TablePartMetadata)
											{
												num4 = 2;
												continue;
											}
											goto case 1;
										case 1:
											if ((rightPropMd = propertyMetadata3 as PropertyMetadata) == null)
											{
												num4 = 17;
												continue;
											}
											goto case 4;
										case 7:
											if (propertyMetadata != null)
											{
												num4 = 19;
												continue;
											}
											break;
										case 8:
										case 15:
										case 16:
										case 17:
											break;
										default:
											goto IL_064c;
										case 25:
											if (sSTOgohoN1DpE8sfXdZl(_003C_003Ec__DisplayClass2_.item))
											{
												num4 = 24;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
												{
													num4 = 29;
												}
												continue;
											}
											goto case 9;
										case 6:
											if (obj3 != null)
											{
												num4 = 11;
												continue;
											}
											goto case 7;
										case 20:
											obj2 = null;
											goto IL_06eb;
										case 10:
											obj2 = propertiesFromMetadata.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CMap_003Eb__0);
											goto IL_06eb;
										case 21:
											obj = GetPropertyValue(objLeft, msV9lOhopTuXwkay6hrN(propertyMetadata));
											goto IL_0715;
										case 14:
											return;
											IL_06eb:
											propertyMetadata2 = (IPropertyMetadata)obj2;
											num4 = 19;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
											{
												num4 = 28;
											}
											continue;
											IL_0715:
											obj3 = obj;
											num4 = 6;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
											{
												num4 = 1;
											}
											continue;
										}
										break;
									}
									continue;
									IL_064c:
									_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
									num4 = 23;
									goto IL_017e;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
								{
									num10 = 0;
								}
								switch (num10)
								{
								case 0:
									break;
								}
							}
						}
					}
				}
				finally
				{
					int num11;
					if (replaceUidAtPropertyMapServiceContext == null)
					{
						num11 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num11 = 0;
						}
						goto IL_0795;
					}
					goto IL_07ab;
					IL_07ab:
					EbRpgGho6TWOE3mbfsjc(replaceUidAtPropertyMapServiceContext);
					num11 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num11 = 0;
					}
					goto IL_0795;
					IL_0795:
					switch (num11)
					{
					default:
						goto end_IL_0770;
					case 2:
						break;
					case 1:
						goto end_IL_0770;
					case 0:
						goto end_IL_0770;
					}
					goto IL_07ab;
					end_IL_0770:;
				}
			case 2:
				if (ahMJcghoXIMjQNaj19Uq(map.Items) != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 3;
					}
					break;
				}
				return;
			case 0:
				return;
			case 4:
				ex34fQhoKhg7DOPBF1bd(map, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53C865D7));
				num2 = 2;
				break;
			case 5:
				return;
			case 3:
				replaceUidAtPropertyMapServiceContext = (ReplaceUidAtPropertyMapServiceContext)hED5ShhoTL7ZOT9UqHvo(objLeft, objRight);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void MapTablePart(object objLeft, object objRight, TablePartMetadata leftTp, TablePartMetadata rightTp, PropertyMap map)
	{
		//Discarded unreachable code: IL_00d6, IL_00e0, IL_0111, IL_011b, IL_01bc, IL_01f4, IL_022a, IL_0239, IL_0244, IL_02fa, IL_031d, IL_032c, IL_036a, IL_0379, IL_038a, IL_0395, IL_03b0, IL_03bf, IL_04d7, IL_0534, IL_053e, IL_054d, IL_055f, IL_056e, IL_0579, IL_07fc, IL_080b, IL_082c, IL_083b, IL_0889, IL_08a9, IL_08b8, IL_08f0, IL_08ff
		int num = 37;
		IEntity entity = default(IEntity);
		IEntity entity2 = default(IEntity);
		IEnumerator<IEntity> enumerator2 = default(IEnumerator<IEntity>);
		IEntity current = default(IEntity);
		ISet val = default(ISet);
		Dictionary<Guid, IEntity> dictionary = default(Dictionary<Guid, IEntity>);
		IEnumerator enumerator = default(IEnumerator);
		IEntity entity4 = default(IEntity);
		PropertyInfo propertyInfo = default(PropertyInfo);
		PropertyInfo propertyInfo2 = default(PropertyInfo);
		Type type2 = default(Type);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		Type type = default(Type);
		Type type3 = default(Type);
		Type type4 = default(Type);
		ISet val2 = default(ISet);
		IEntity value = default(IEntity);
		Guid guid = default(Guid);
		IEntity entity3 = default(IEntity);
		Guid? newUid = default(Guid?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj5;
				object obj6;
				object obj2;
				object obj3;
				object obj4;
				object obj;
				switch (num2)
				{
				case 30:
					obj5 = zbTeAVhoa8sj0qyPrEXl(entity, pBmCGUhoHDi50wjeKajr(leftTp));
					goto IL_094d;
				case 18:
					if (entity2 == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 35;
				case 5:
					try
					{
						while (true)
						{
							IL_015c:
							int num8;
							if (!RUGYwaho94wuIriVdRwG(enumerator2))
							{
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
								{
									num8 = 0;
								}
								goto IL_011f;
							}
							goto IL_0139;
							IL_0139:
							current = enumerator2.Current;
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num8 = 1;
							}
							goto IL_011f;
							IL_011f:
							while (true)
							{
								switch (num8)
								{
								default:
									return;
								case 2:
									break;
								case 3:
									goto IL_015c;
								case 1:
									Nhw1Hohogafn52glC2rp(val, current);
									num8 = 3;
									continue;
								case 0:
									return;
								}
								break;
							}
							goto IL_0139;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
							{
								num9 = 0;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									EbRpgGho6TWOE3mbfsjc(enumerator2);
									num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
									{
										num9 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				case 6:
					if (entity != null)
					{
						num2 = 30;
						continue;
					}
					obj5 = GetPropertyValue(objLeft, leftTp.TablePartPropertyUid);
					goto IL_094d;
				case 10:
					dictionary = new Dictionary<Guid, IEntity>();
					num = 23;
					break;
				case 11:
					try
					{
						while (true)
						{
							IL_02ac:
							int num6;
							if (!RUGYwaho94wuIriVdRwG(enumerator))
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
								{
									num6 = 0;
								}
								goto IL_0248;
							}
							goto IL_0262;
							IL_0262:
							entity4 = (IEntity)rATkSihoMV25rBFVCgce(enumerator);
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
							{
								num6 = 1;
							}
							goto IL_0248;
							IL_0248:
							while (true)
							{
								switch (num6)
								{
								case 2:
									goto IL_0262;
								case 1:
									dictionary[(Guid)Lc59IJhoJxuF1Q6FdWS1(propertyInfo, entity4, null)] = entity4;
									num6 = 3;
									continue;
								case 3:
									goto IL_02ac;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num7 = 1;
						}
						while (true)
						{
							switch (num7)
							{
							case 2:
								break;
							default:
								EbRpgGho6TWOE3mbfsjc(disposable);
								num7 = 3;
								continue;
							case 1:
								if (disposable == null)
								{
									num7 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num7 = 1;
									}
									continue;
								}
								goto default;
							case 3:
								break;
							}
							break;
						}
					}
					goto case 21;
				case 27:
					obj6 = null;
					goto IL_09d8;
				case 8:
					obj2 = null;
					goto IL_09bf;
				case 33:
				case 40:
					val.Clear();
					num2 = 7;
					continue;
				case 20:
					return;
				case 14:
					if (c5Z7suhom55NDSNeE6tT(propertyInfo, null))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 21;
				case 7:
					return;
				case 19:
					propertyInfo2 = (PropertyInfo)EteKu5ho0N8aebgMZpHW(type2, q1QeRDhoqJf8YTgHlG7t(0x5A4C7B29 ^ 0x5A4C14BB));
					num2 = 31;
					continue;
				case 37:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 36;
					continue;
				case 25:
					if (KN0AE1ho7BF8hiMLoivU(type, null))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 22;
				case 16:
					if (dictionary == null)
					{
						num2 = 20;
						continue;
					}
					goto case 32;
				case 36:
					entity = objLeft as IEntity;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					if (!k15NhuhoxQl6IxKGRwSK(type2, null))
					{
						num2 = 39;
						continue;
					}
					goto case 33;
				case 39:
					if (!k15NhuhoxQl6IxKGRwSK(type3, null))
					{
						num2 = 19;
						continue;
					}
					goto case 33;
				case 21:
					_003C_003Ec__DisplayClass3_.currentRightItems = new List<IEntity>();
					num2 = 28;
					continue;
				case 35:
					obj3 = zbTeAVhoa8sj0qyPrEXl(entity2, pBmCGUhoHDi50wjeKajr(rightTp));
					goto IL_096c;
				case 17:
					if (!KN0AE1ho7BF8hiMLoivU(type4, null))
					{
						num2 = 27;
						continue;
					}
					obj6 = type4.GetGenericArguments()[0];
					goto IL_09d8;
				case 28:
					enumerator = (IEnumerator)HlVTHRhoyrfEkRhnIVCy(val2);
					num = 12;
					break;
				case 15:
					if (c5Z7suhom55NDSNeE6tT(propertyInfo2, null))
					{
						num2 = 14;
						continue;
					}
					goto case 21;
				case 9:
					dictionary = null;
					num2 = 15;
					continue;
				case 24:
					obj4 = null;
					goto IL_0998;
				case 38:
					return;
				case 12:
					try
					{
						while (true)
						{
							IL_075d:
							int num3;
							if (!RUGYwaho94wuIriVdRwG(enumerator))
							{
								num3 = 9;
								goto IL_057d;
							}
							goto IL_0673;
							IL_057d:
							while (true)
							{
								switch (num3)
								{
								case 3:
									if (value == null)
									{
										num3 = 13;
										continue;
									}
									goto case 11;
								case 11:
									_003C_003Ec__DisplayClass3_.currentRightItems.Add(value);
									num3 = 14;
									continue;
								case 10:
									guid = (Guid)Lc59IJhoJxuF1Q6FdWS1(propertyInfo2, entity3, null);
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
									{
										num3 = 6;
									}
									continue;
								case 2:
									dictionary.TryGetValue(guid, out value);
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
									{
										num3 = 1;
									}
									continue;
								case 12:
									guid = newUid.Value;
									num3 = 2;
									continue;
								default:
									yYmZQOhorHYMJYMEcFEY(propertyInfo, value, guid, null);
									num3 = 6;
									continue;
								case 4:
									break;
								case 15:
									if (dictionary != null)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 6;
								case 14:
									Map(entity3, value, map);
									num3 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
									{
										num3 = 7;
									}
									continue;
								case 6:
									val.Add((object)value);
									num3 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
									{
										num3 = 11;
									}
									continue;
								case 1:
									guid = Guid.Empty;
									num3 = 16;
									continue;
								case 13:
									value = (IEntity)F0cEptholviSYDdqhGFu(type3);
									num3 = 15;
									continue;
								case 16:
									if (dictionary != null)
									{
										num3 = 10;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
										{
											num3 = 4;
										}
										continue;
									}
									goto case 3;
								case 5:
									value = null;
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
									{
										num3 = 0;
									}
									continue;
								case 8:
									goto IL_075d;
								case 7:
									if (((IReplaceUidAtPropertyMapServiceExtension)EHPWhlhodg7JneS5BVR4()).GetUidReplace(guid, out newUid))
									{
										num3 = 12;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
										{
											num3 = 3;
										}
										continue;
									}
									goto case 2;
								case 9:
									goto end_IL_075d;
								}
								break;
							}
							goto IL_0673;
							IL_0673:
							entity3 = (IEntity)rATkSihoMV25rBFVCgce(enumerator);
							num3 = 5;
							goto IL_057d;
							continue;
							end_IL_075d:
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num4 = 3;
						while (true)
						{
							switch (num4)
							{
							default:
								disposable.Dispose();
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
								{
									num4 = 0;
								}
								continue;
							case 2:
								break;
							case 3:
								if (disposable == null)
								{
									int num5 = 2;
									num4 = num5;
									continue;
								}
								goto default;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 16;
				default:
					if (val != null)
					{
						num2 = 41;
						continue;
					}
					return;
				case 34:
					return;
				case 41:
					if (val2 == null)
					{
						num2 = 40;
						continue;
					}
					goto case 13;
				case 23:
					enumerator = (IEnumerator)HlVTHRhoyrfEkRhnIVCy(val);
					num = 11;
					break;
				case 22:
					obj = null;
					goto IL_09ed;
				case 1:
					entity2 = objRight as IEntity;
					num = 6;
					break;
				case 31:
					propertyInfo = (PropertyInfo)EteKu5ho0N8aebgMZpHW(type3, q1QeRDhoqJf8YTgHlG7t(0x1FFEF86A ^ 0x1FFE97F8));
					num2 = 9;
					continue;
				case 26:
					if (val != null)
					{
						num = 29;
						break;
					}
					goto case 8;
				case 2:
					if (val2 == null)
					{
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 12;
						}
						continue;
					}
					obj4 = ((object)val2).GetType().GetInterface(hbSrgEhoAui7eSQumWWB(typeof(ISet<>).TypeHandle).FullName);
					goto IL_0998;
				case 3:
					obj3 = GetPropertyValue(objRight, pBmCGUhoHDi50wjeKajr(rightTp));
					goto IL_096c;
				case 29:
					obj2 = ((object)val).GetType().GetInterface(typeof(ISet<>).FullName);
					goto IL_09bf;
				case 4:
					obj = type.GetGenericArguments()[0];
					goto IL_09ed;
				case 32:
					{
						enumerator2 = dictionary.Values.Where(_003C_003Ec__DisplayClass3_._003CMapTablePart_003Eb__0).GetEnumerator();
						num2 = 5;
						continue;
					}
					IL_094d:
					val2 = (ISet)((obj5 is ISet) ? obj5 : null);
					num2 = 18;
					continue;
					IL_0998:
					type4 = (Type)obj4;
					num2 = 26;
					continue;
					IL_09bf:
					type = (Type)obj2;
					num = 17;
					break;
					IL_09d8:
					type2 = (Type)obj6;
					num2 = 25;
					continue;
					IL_096c:
					val = (ISet)((obj3 is ISet) ? obj3 : null);
					num2 = 2;
					continue;
					IL_09ed:
					type3 = (Type)obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	public void MapProperty(object objRight, PropertyMetadata rightPropMd, object leftValue, PropertyMetadata leftPropMetadata)
	{
		//Discarded unreachable code: IL_0083, IL_009f, IL_00f2, IL_00fc, IL_01af, IL_01fc, IL_020b, IL_031f, IL_032e, IL_033d
		int num = 2;
		IEntity entity = default(IEntity);
		IConvertableTypeDescriptor convertableTypeDescriptor = default(IConvertableTypeDescriptor);
		IEnumerator enumerator = default(IEnumerator);
		object current = default(object);
		ISet val = default(ISet);
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 6:
					return;
				case 14:
					obj = zbTeAVhoa8sj0qyPrEXl(entity, msV9lOhopTuXwkay6hrN(rightPropMd));
					break;
				case 2:
					entity = objRight as IEntity;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					leftValue = dvUpnDhoLL4L3PZhYGlV(convertableTypeDescriptor, leftValue, rightPropMd);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 16;
					}
					continue;
				case 4:
					return;
				case 19:
					try
					{
						while (true)
						{
							IL_0161:
							int num3;
							if (!RUGYwaho94wuIriVdRwG(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
								{
									num3 = 0;
								}
								goto IL_0100;
							}
							goto IL_013e;
							IL_013e:
							current = enumerator.Current;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
							{
								num3 = 0;
							}
							goto IL_0100;
							IL_0100:
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 0:
									return;
								case 2:
									kfi3wXhoUhS7ZHJgqMg7(val, current);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
									{
										num3 = 1;
									}
									continue;
								case 3:
									break;
								case 1:
									goto IL_0161;
								}
								break;
							}
							goto IL_013e;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 2:
								disposable.Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								if (disposable != null)
								{
									num4 = 2;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
				case 1:
					if ((convertableTypeDescriptor = bwryYkhoY70LqNegDwDu(metadataRuntimeService, VS9QvSho5D87Jh5vTfi0(rightPropMd), rT9rN3hojBU4PgFRvBmu(rightPropMd)) as IConvertableTypeDescriptor) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 16;
				case 16:
					if (entity == null)
					{
						num2 = 13;
						continue;
					}
					goto case 14;
				case 9:
					return;
				case 5:
					w4Qyr1hosxl2ULSgeMJY(entity, msV9lOhopTuXwkay6hrN(rightPropMd), leftValue);
					num2 = 4;
					continue;
				case 11:
					enumerable = leftValue as IEnumerable;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 1;
					}
					continue;
				case 18:
					goto end_IL_0012;
				case 7:
					if (enumerable == null)
					{
						num2 = 3;
						continue;
					}
					goto case 10;
				case 10:
					enumerator = (IEnumerator)HlVTHRhoyrfEkRhnIVCy(enumerable);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 7;
					}
					continue;
				case 12:
					if (val == null)
					{
						if (entity != null)
						{
							num2 = 5;
							continue;
						}
						goto case 15;
					}
					num2 = 18;
					continue;
				case 3:
				case 8:
					if (leftValue == null)
					{
						return;
					}
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 17;
					}
					continue;
				case 15:
					SetPropertyValue(objRight, msV9lOhopTuXwkay6hrN(rightPropMd), leftValue, leftPropMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 9;
					}
					continue;
				case 17:
					kfi3wXhoUhS7ZHJgqMg7(val, leftValue);
					num2 = 6;
					continue;
				case 13:
					obj = GetPropertyValue(objRight, msV9lOhopTuXwkay6hrN(rightPropMd));
					break;
				}
				val = (ISet)((obj is ISet) ? obj : null);
				num2 = 12;
				continue;
				end_IL_0012:
				break;
			}
			val.Clear();
			num = 11;
		}
	}

	private ClassMetadata GetObjectClassMetadata(object obj)
	{
		int num = 2;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(obj.GetType());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (classMetadata == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			default:
				return classMetadata;
			case 2:
				classMetadata = obj as ClassMetadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private IEnumerable<IPropertyMetadata> GetPropertiesFromMetadata(ClassMetadata metadata)
	{
		if (!(metadata is EntityMetadata))
		{
			return metadata.Properties.Cast<IPropertyMetadata>();
		}
		return ((EntityMetadata)metadata).GetPropertiesAndTableParts();
	}

	private PropertyInfo GetPropertyInfo(object inputObject, Guid propertyUid)
	{
		int num = 2;
		int num2 = num;
		Pair<ClassMetadata, IPropertyMetadata> propertyMetadata = default(Pair<ClassMetadata, IPropertyMetadata>);
		IPropertyMetadata second = default(IPropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				propertyMetadata = GetPropertyMetadata(inputObject, propertyUid);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				second = propertyMetadata.Second;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				object obj = EteKu5ho0N8aebgMZpHW(inputObject.GetType(), W5qSlkhoeYHG0jwT14AX(second));
				if (JqtuuyhocqYRC6iBZVoT(obj, null))
				{
					throw new MetadataException((string)nb93PHhbFLPUhKCaof7I(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1634E059)), W5qSlkhoeYHG0jwT14AX(second), rTM5xthoz7bmEruEkI25(propertyMetadata.First)));
				}
				return (PropertyInfo)obj;
			}
			}
		}
	}

	private Pair<ClassMetadata, IPropertyMetadata> GetPropertyMetadata(object inputObject, Guid propertyUid)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(inputObject.GetType());
		if (classMetadata == null)
		{
			throw new MetadataException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837868357), inputObject.GetType().FullName));
		}
		IPropertyMetadata propertyMetadata = classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass8_0.estPHfClOqIlspAouCMG(_003C_003Ec__DisplayClass8_0.XTBU3AClnUkGYsc7BN35(p), CS_0024_003C_003E8__locals0.propertyUid));
		if (propertyMetadata == null && classMetadata is EntityMetadata entityMetadata)
		{
			propertyMetadata = entityMetadata.TableParts.FirstOrDefault((TablePartMetadata tp) => _003C_003Ec__DisplayClass8_0.estPHfClOqIlspAouCMG(_003C_003Ec__DisplayClass8_0.IctvxvCl2PGuqPDXA1Te(tp), CS_0024_003C_003E8__locals0.propertyUid));
		}
		if (propertyMetadata == null)
		{
			throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420949448)), CS_0024_003C_003E8__locals0.propertyUid, classMetadata.FullTypeName));
		}
		return new Pair<ClassMetadata, IPropertyMetadata>(classMetadata, propertyMetadata);
	}

	private object GetPropertyValue(object inputObject, Guid propertyUid)
	{
		return Lc59IJhoJxuF1Q6FdWS1(GetPropertyInfo(inputObject, propertyUid), inputObject, null);
	}

	private void SetPropertyValue(object inputObject, Guid propertyUid, object value, PropertyMetadata leftPropMetadata)
	{
		int num = 3;
		IConvertTypeMapper convertTypeMapper = default(IConvertTypeMapper);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 7:
					value = QF5lf5hbWjyuYJuaTFgJ(convertTypeMapper, value);
					num = 4;
					break;
				default:
					_003C_003Ec__DisplayClass10_.md = GetPropertyMetadata(inputObject, propertyUid);
					num2 = 6;
					continue;
				case 3:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass10_.leftPropMetadata = leftPropMetadata;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					convertTypeMapper = ((ComponentManager)S3jfWnhbBS3817uCqsGM()).GetExtensionPoints<IConvertTypeMapper>().FirstOrDefault(_003C_003Ec__DisplayClass10_._003CSetPropertyValue_003Eb__0);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (convertTypeMapper != null)
					{
						num2 = 7;
						continue;
					}
					goto case 4;
				case 4:
					yYmZQOhorHYMJYMEcFEY(GetPropertyInfo(inputObject, propertyUid), inputObject, value, null);
					num = 5;
					break;
				}
				break;
			}
		}
	}

	internal static void cEm9sQhoRClHhMViFhs5()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool sWVWCphoSc4QOHCYhf7q()
	{
		return S6duK0hoVg54i8AivnIN == null;
	}

	internal static PropertyMapService KR8CG4hoiakA9g6dqstC()
	{
		return S6duK0hoVg54i8AivnIN;
	}

	internal static object q1QeRDhoqJf8YTgHlG7t(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void ex34fQhoKhg7DOPBF1bd(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static int ahMJcghoXIMjQNaj19Uq(object P_0)
	{
		return ((List<PropertyMapItem>)P_0).Count;
	}

	internal static object hED5ShhoTL7ZOT9UqHvo(object P_0, object P_1)
	{
		return ReplaceUidAtPropertyMapServiceContext.Extend(P_0, P_1);
	}

	internal static Guid jEYlgdhokTRX2sSycJ1a(object P_0)
	{
		return ((PropertyMapItem)P_0).RightPropertyUid;
	}

	internal static Guid t4A2bJhonmytmLyGlmhB(object P_0)
	{
		return ((PropertyMapItem)P_0).LeftPropertyUid;
	}

	internal static bool sjNsvshoOtAZLE3TRDd5(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object sJTlFwho2W1Lpxk4b5mv(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object W5qSlkhoeYHG0jwT14AX(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static object tJTptZhoPrji1QLiw9k9(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static void uSbxHZho1D5t4Nh76uD7(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool sSTOgohoN1DpE8sfXdZl(object P_0)
	{
		return ((PropertyMapItem)P_0).ThisMarker;
	}

	internal static object C4PEMnho3QJQw3VyqtNr(object P_0)
	{
		return ((PropertyMapItem)P_0).LeftValue;
	}

	internal static Guid msV9lOhopTuXwkay6hrN(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object zbTeAVhoa8sj0qyPrEXl(object P_0, Guid propertyUid)
	{
		return ((IEntity)P_0).GetPropertyValue(propertyUid);
	}

	internal static object av70MfhoDGdOmqkDcumu()
	{
		return Logger.Log;
	}

	internal static object BQ2hsThot30AOUQuqNjw(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static object K7Ux7ihowJQAnGJfs9nk(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object SugC6dho4nkjIiqMETEC(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void EbRpgGho6TWOE3mbfsjc(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Guid pBmCGUhoHDi50wjeKajr(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyUid;
	}

	internal static Type hbSrgEhoAui7eSQumWWB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool KN0AE1ho7BF8hiMLoivU(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool k15NhuhoxQl6IxKGRwSK(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object EteKu5ho0N8aebgMZpHW(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool c5Z7suhom55NDSNeE6tT(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static object HlVTHRhoyrfEkRhnIVCy(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object rATkSihoMV25rBFVCgce(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object Lc59IJhoJxuF1Q6FdWS1(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static bool RUGYwaho94wuIriVdRwG(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object EHPWhlhodg7JneS5BVR4()
	{
		return ReplaceUidAtPropertyMapServiceContext.Service;
	}

	internal static object F0cEptholviSYDdqhGFu(Type t)
	{
		return InterfaceActivator.Create(t);
	}

	internal static void yYmZQOhorHYMJYMEcFEY(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool Nhw1Hohogafn52glC2rp(object P_0, object P_1)
	{
		return ((ISet)P_0).Remove(P_1);
	}

	internal static Guid VS9QvSho5D87Jh5vTfi0(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid rT9rN3hojBU4PgFRvBmu(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object bwryYkhoY70LqNegDwDu(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object dvUpnDhoLL4L3PZhYGlV(object P_0, object P_1, object P_2)
	{
		return ((IConvertableTypeDescriptor)P_0).ConvertFrom(P_1, (PropertyMetadata)P_2);
	}

	internal static bool kfi3wXhoUhS7ZHJgqMg7(object P_0, object P_1)
	{
		return ((ISet)P_0).Add(P_1);
	}

	internal static void w4Qyr1hosxl2ULSgeMJY(object P_0, Guid propertyUid, object P_2)
	{
		((IEntity)P_0).SetPropertyValue(propertyUid, P_2);
	}

	internal static bool JqtuuyhocqYRC6iBZVoT(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object rTM5xthoz7bmEruEkI25(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static object nb93PHhbFLPUhKCaof7I(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object S3jfWnhbBS3817uCqsGM()
	{
		return ComponentManager.Current;
	}

	internal static object QF5lf5hbWjyuYJuaTFgJ(object P_0, object P_1)
	{
		return ((IConvertTypeMapper)P_0).Convert(P_1);
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.Services;

[Component(Order = 200)]
public class ObjectsBAConverter : IBPMAppItemsConverter
{
	private static readonly Guid exportCatalogsUid;

	private static readonly Guid exportEnumsUid;

	internal static ObjectsBAConverter O3g4Upf2atdcvnyh6sLy;

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		//Discarded unreachable code: IL_010b, IL_011a, IL_012a, IL_0171, IL_0180, IL_0190, IL_01f9, IL_02b5, IL_031f, IL_032e, IL_0396, IL_03a5, IL_03cf
		int num = 16;
		ObjectsExportSetting objectsExportSetting = default(ObjectsExportSetting);
		ObjectsBAChapter objectsBAChapter = default(ObjectsBAChapter);
		object value = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 34:
					if (objectsExportSetting.Catalogs != null)
					{
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 2;
				case 7:
					h5aAlPf2AMj9y6qmoNno(bpmAppManifest, exportCatalogsUid, kevtUBf2H1xmF1uV1ODA(objectsExportSetting));
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 33;
					}
					continue;
				case 5:
				case 19:
				case 30:
					adH1dEf2mJXPPhiXmSBl(bpmAppManifest, objectsBAChapter);
					num2 = 9;
					continue;
				default:
					if (ljRpGHf27HC42UJ7EVlP(objectsExportSetting))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 4;
				case 37:
					return;
				case 10:
					objectsExportSetting = value as ObjectsExportSetting;
					num2 = 23;
					continue;
				case 24:
				case 35:
					if (objectsBAChapter.Enums != null)
					{
						num = 22;
						break;
					}
					goto case 6;
				case 8:
					if (objectsBAChapter.DataClasses.Count > 0)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 19;
						}
						continue;
					}
					return;
				case 15:
					JIgIjUf24NXQhX5cbspv(settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7247E804));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 10;
					}
					continue;
				case 11:
					if (!settings.CustomSettings.TryGetValue(ObjectsExportConsts.ExportExtensionUid, out value))
					{
						return;
					}
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 10;
					}
					continue;
				case 3:
				case 29:
					if (objectsBAChapter.Catalogs != null)
					{
						num2 = 31;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 27;
				case 4:
				case 32:
					if (objectsExportSetting.DataClasses == null)
					{
						num2 = 29;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 28;
				case 23:
					if (objectsExportSetting != null)
					{
						num = 20;
						break;
					}
					return;
				case 16:
					JIgIjUf24NXQhX5cbspv(bpmAppManifest, iyUFHOf2w3mGFdFRIwR8(-475857671 ^ -475548565));
					num2 = 15;
					continue;
				case 31:
					if (CBUBk5f2x6mUhTk1q1dq(objectsBAChapter.Catalogs) <= 0)
					{
						num = 27;
						break;
					}
					goto case 5;
				case 27:
					if (objectsBAChapter.SysCatalogs == null)
					{
						num2 = 24;
						continue;
					}
					goto case 1;
				case 22:
					if (i5kYu2f204eh9N1mCifu(objectsBAChapter.Enums) > 0)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 6;
				case 33:
					if (!kevtUBf2H1xmF1uV1ODA(objectsExportSetting))
					{
						num2 = 2;
						continue;
					}
					goto case 34;
				case 17:
					if (objectsExportSetting.SysCatalogs == null)
					{
						num = 18;
						break;
					}
					goto case 25;
				case 14:
					if (objectsExportSetting.Enums == null)
					{
						num2 = 4;
						continue;
					}
					goto case 21;
				case 13:
					return;
				case 20:
				{
					ObjectsBAChapter objectsBAChapter2 = new ObjectsBAChapter();
					oo2qfBf26ccKRDxBMWMn(objectsBAChapter2, ObjectsExportConsts.ExportExtensionUid);
					objectsBAChapter = objectsBAChapter2;
					num2 = 7;
					continue;
				}
				case 6:
					if (objectsBAChapter.DataClasses != null)
					{
						num2 = 8;
						continue;
					}
					return;
				case 1:
					if (CBUBk5f2x6mUhTk1q1dq(objectsBAChapter.SysCatalogs) > 0)
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num2 = 30;
						}
						continue;
					}
					goto case 24;
				case 2:
				case 12:
					if (kevtUBf2H1xmF1uV1ODA(objectsExportSetting))
					{
						num2 = 17;
						continue;
					}
					goto case 18;
				case 9:
					return;
				case 18:
				case 36:
					bpmAppManifest.SetFlag(exportEnumsUid, objectsExportSetting.ExportEnums);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					continue;
				case 26:
					objectsBAChapter.Catalogs = objectsExportSetting.Catalogs.Select((KeyValuePair<Guid, bool> c) => new EntityBAItem
					{
						Uid = c.Key,
						ExportData = c.Value
					}).ToList();
					num2 = 12;
					continue;
				case 25:
					objectsBAChapter.SysCatalogs = objectsExportSetting.SysCatalogs.Select(delegate(Guid uid)
					{
						EntityBAItem entityBAItem = new EntityBAItem();
						_003C_003Ec.BYQ7Y58z9vnQw1jpTIfY(entityBAItem, uid);
						entityBAItem.ExportData = true;
						return entityBAItem;
					}).ToList();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 36;
					}
					continue;
				case 21:
					objectsBAChapter.Enums = objectsExportSetting.Enums.Select(delegate(Guid uid)
					{
						EnumBAItem enumBAItem = new EnumBAItem();
						_003C_003Ec.BYQ7Y58z9vnQw1jpTIfY(enumBAItem, uid);
						return enumBAItem;
					}).ToList();
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 32;
					}
					continue;
				case 28:
					objectsBAChapter.DataClasses = objectsExportSetting.DataClasses.Select(delegate(Guid uid)
					{
						DataClassBAItem dataClassBAItem = new DataClassBAItem();
						_003C_003Ec.BYQ7Y58z9vnQw1jpTIfY(dataClassBAItem, uid);
						return dataClassBAItem;
					}).ToList();
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_0096, IL_00a5, IL_00b0, IL_0170, IL_0183, IL_0259, IL_02c2, IL_02cc, IL_037c, IL_038f, IL_039f, IL_0450, IL_047a, IL_0489, IL_0494, IL_054b, IL_055e, IL_056d, IL_05bd, IL_05cc, IL_05d7, IL_0697, IL_06aa, IL_06bd, IL_06cc
		int num = 7;
		List<EnumBAItem>.Enumerator enumerator3 = default(List<EnumBAItem>.Enumerator);
		EnumBAItem current4 = default(EnumBAItem);
		ObjectsExportSetting objectsExportSetting = default(ObjectsExportSetting);
		ObjectsBAChapter objectsBAChapter = default(ObjectsBAChapter);
		List<EntityBAItem>.Enumerator enumerator = default(List<EntityBAItem>.Enumerator);
		List<DataClassBAItem>.Enumerator enumerator2 = default(List<DataClassBAItem>.Enumerator);
		DataClassBAItem current3 = default(DataClassBAItem);
		EntityBAItem current2 = default(EntityBAItem);
		EntityBAItem current = default(EntityBAItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					try
					{
						while (true)
						{
							int num9;
							if (!enumerator3.MoveNext())
							{
								num9 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
								{
									num9 = 3;
								}
								goto IL_00b4;
							}
							goto IL_0121;
							IL_0121:
							current4 = enumerator3.Current;
							num9 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num9 = 0;
							}
							goto IL_00b4;
							IL_00b4:
							while (true)
							{
								switch (num9)
								{
								case 2:
									objectsExportSetting.Enums.Add(PpV4ipf2MKYedgVOoMFj(current4));
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
									{
										num9 = 0;
									}
									continue;
								case 1:
									goto IL_0121;
								case 3:
									goto end_IL_00fb;
								}
								break;
							}
							continue;
							end_IL_00fb:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num10 = 0;
						}
						switch (num10)
						{
						case 0:
							break;
						}
					}
					goto case 22;
				case 12:
					if (objectsBAChapter.Catalogs == null)
					{
						num2 = 23;
						continue;
					}
					goto case 10;
				case 7:
					JIgIjUf24NXQhX5cbspv(bpmAppManifest, iyUFHOf2w3mGFdFRIwR8(-1998538950 ^ -1998192728));
					num2 = 6;
					continue;
				case 16:
					return;
				case 13:
					enumerator = objectsBAChapter.SysCatalogs.GetEnumerator();
					num2 = 19;
					continue;
				case 6:
					JIgIjUf24NXQhX5cbspv(settings, iyUFHOf2w3mGFdFRIwR8(-1921202237 ^ -1921241779));
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
				case 23:
					if (objectsBAChapter.SysCatalogs == null)
					{
						num2 = 3;
						continue;
					}
					goto case 15;
				case 9:
					enumerator3 = objectsBAChapter.Enums.GetEnumerator();
					num = 20;
					break;
				case 15:
					objectsExportSetting.SysCatalogs = new List<Guid>();
					num2 = 13;
					continue;
				case 24:
				case 27:
					settings.CustomSettings[ObjectsExportConsts.ExportExtensionUid] = objectsExportSetting;
					num2 = 26;
					continue;
				case 4:
					if (objectsBAChapter != null)
					{
						objectsExportSetting = new ObjectsExportSetting();
						num = 17;
						break;
					}
					num2 = 16;
					continue;
				case 11:
					objectsExportSetting.DataClasses = new List<Guid>();
					num2 = 21;
					continue;
				case 8:
					try
					{
						while (true)
						{
							int num7;
							if (!enumerator2.MoveNext())
							{
								num7 = 3;
								goto IL_02d0;
							}
							goto IL_032d;
							IL_02d0:
							while (true)
							{
								switch (num7)
								{
								default:
									objectsExportSetting.DataClasses.Add(PpV4ipf2MKYedgVOoMFj(current3));
									num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
									{
										num7 = 1;
									}
									continue;
								case 1:
									break;
								case 2:
									goto IL_032d;
								case 3:
									goto end_IL_0317;
								}
								break;
							}
							continue;
							IL_032d:
							current3 = enumerator2.Current;
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num7 = 0;
							}
							goto IL_02d0;
							continue;
							end_IL_0317:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 24;
				case 26:
					return;
				case 22:
				case 28:
					if (objectsBAChapter.DataClasses == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 11;
				case 10:
					objectsExportSetting.Catalogs = new SerializableDictionary<Guid, bool>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					enumerator = objectsBAChapter.Catalogs.GetEnumerator();
					num2 = 2;
					continue;
				case 25:
					if (objectsBAChapter.Enums == null)
					{
						num2 = 28;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 14;
				case 21:
					enumerator2 = objectsBAChapter.DataClasses.GetEnumerator();
					num2 = 8;
					continue;
				case 14:
					objectsExportSetting.Enums = new List<Guid>();
					num2 = 9;
					continue;
				case 2:
					try
					{
						while (true)
						{
							IL_04f9:
							int num5;
							if (!enumerator.MoveNext())
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
								{
									num5 = 1;
								}
								goto IL_0498;
							}
							goto IL_04e6;
							IL_04e6:
							current2 = enumerator.Current;
							num5 = 2;
							goto IL_0498;
							IL_0498:
							while (true)
							{
								switch (num5)
								{
								case 2:
									objectsExportSetting.Catalogs[PpV4ipf2MKYedgVOoMFj(current2)] = MyHoJwf2JmM0UfnGekwH(current2);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
									{
										num5 = 0;
									}
									continue;
								case 3:
									break;
								default:
									goto IL_04f9;
								case 1:
									goto end_IL_04f9;
								}
								break;
							}
							goto IL_04e6;
							continue;
							end_IL_04f9:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 1;
				case 17:
					GQcp37f2ydhq7Rul1BIX(objectsExportSetting, bpmAppManifest.GetFlag(exportCatalogsUid, kevtUBf2H1xmF1uV1ODA(objectsExportSetting)));
					num2 = 12;
					continue;
				case 18:
					objectsBAChapter = bpmAppManifest.GetChapter(ObjectsExportConsts.ExportExtensionUid) as ObjectsBAChapter;
					num2 = 4;
					continue;
				case 19:
					try
					{
						while (true)
						{
							IL_0645:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
								{
									num3 = 3;
								}
								goto IL_05db;
							}
							goto IL_0622;
							IL_0622:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num3 = 0;
							}
							goto IL_05db;
							IL_05db:
							while (true)
							{
								switch (num3)
								{
								default:
									objectsExportSetting.SysCatalogs.Add(current.Uid);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
									{
										num3 = 2;
									}
									continue;
								case 1:
									break;
								case 2:
									goto IL_0645;
								case 3:
									goto end_IL_0645;
								}
								break;
							}
							goto IL_0622;
							continue;
							end_IL_0645:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 3:
				case 5:
					objectsExportSetting.ExportEnums = eOsKHGf29elH8aWmrBQd(bpmAppManifest, exportEnumsUid, ljRpGHf27HC42UJ7EVlP(objectsExportSetting));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 25;
					}
					continue;
				}
				break;
			}
		}
	}

	public ObjectsBAConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zAXW4Uf2dMtnKcjLtEx2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ObjectsBAConverter()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				zAXW4Uf2dMtnKcjLtEx2();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				exportCatalogsUid = new Guid((string)iyUFHOf2w3mGFdFRIwR8(0x1FFEF86A ^ 0x1FFBB168));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				exportEnumsUid = new Guid((string)iyUFHOf2w3mGFdFRIwR8(-1978478350 ^ -1978164832));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object iyUFHOf2w3mGFdFRIwR8(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void JIgIjUf24NXQhX5cbspv(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void oo2qfBf26ccKRDxBMWMn(object P_0, Guid value)
	{
		((BPMAppManifestChapter)P_0).Uid = value;
	}

	internal static bool kevtUBf2H1xmF1uV1ODA(object P_0)
	{
		return ((ObjectsExportSetting)P_0).ExportCatalogs;
	}

	internal static void h5aAlPf2AMj9y6qmoNno(object P_0, Guid uid, bool value)
	{
		((BPMAppManifest)P_0).SetFlag(uid, value);
	}

	internal static bool ljRpGHf27HC42UJ7EVlP(object P_0)
	{
		return ((ObjectsExportSetting)P_0).ExportEnums;
	}

	internal static int CBUBk5f2x6mUhTk1q1dq(object P_0)
	{
		return ((List<EntityBAItem>)P_0).Count;
	}

	internal static int i5kYu2f204eh9N1mCifu(object P_0)
	{
		return ((List<EnumBAItem>)P_0).Count;
	}

	internal static void adH1dEf2mJXPPhiXmSBl(object P_0, object P_1)
	{
		((BPMAppManifest)P_0).SetChapter((BPMAppManifestChapter)P_1);
	}

	internal static bool vApeiPf2DKlE88H1XWmC()
	{
		return O3g4Upf2atdcvnyh6sLy == null;
	}

	internal static ObjectsBAConverter bH8A23f2tJWvoabiWPia()
	{
		return O3g4Upf2atdcvnyh6sLy;
	}

	internal static void GQcp37f2ydhq7Rul1BIX(object P_0, bool value)
	{
		((ObjectsExportSetting)P_0).ExportCatalogs = value;
	}

	internal static Guid PpV4ipf2MKYedgVOoMFj(object P_0)
	{
		return ((BPMAppManifestItem)P_0).Uid;
	}

	internal static bool MyHoJwf2JmM0UfnGekwH(object P_0)
	{
		return ((EntityBAItem)P_0).ExportData;
	}

	internal static bool eOsKHGf29elH8aWmrBQd(object P_0, Guid uid, bool defaultValue)
	{
		return ((BPMAppManifest)P_0).GetFlag(uid, defaultValue);
	}

	internal static void zAXW4Uf2dMtnKcjLtEx2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

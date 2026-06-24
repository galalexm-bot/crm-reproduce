using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.MultiEdit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services.MultiEdit;

[Service]
public class MultiEditService
{
	private static MultiEditService mn7A9NBmK0KBGAi5dHRE;

	public ICacheService Cache
	{
		[CompilerGenerated]
		get
		{
			return _003CCache_003Ek__BackingField;
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
					_003CCache_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
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

	public MultiEditEditorStoreModel PingAndGetCurrentSoleEditor(long objectId, string objectName, long parentObjectId, string parentObjectName, long userId, string userName, string sessionPrefix, long sessionLifeTime, Guid editSessionUid, bool selfKick = false, bool saveChanges = false)
	{
		return PingAndGetCurrentSoleEditor(objectId.ToString(), objectName, parentObjectId, parentObjectName, userId, userName, sessionPrefix, sessionLifeTime, editSessionUid, selfKick, saveChanges);
	}

	public MultiEditEditorStoreModel PingAndGetCurrentSoleEditor(Guid objectUid, string objectName, long parentObjectId, string parentObjectName, long userId, string userName, string sessionPrefix, long sessionLifeTime, Guid editSessionUid, bool selfKick = false, bool saveChanges = false)
	{
		return PingAndGetCurrentSoleEditor(objectUid.ToString(), objectName, parentObjectId, parentObjectName, userId, userName, sessionPrefix, sessionLifeTime, editSessionUid, selfKick, saveChanges);
	}

	public bool FinishObjectSoleEditSession(long objectId, string objectName, long userId, string sessionPrefix)
	{
		return FinishObjectSoleEditSession(objectId.ToString(), objectName, userId, sessionPrefix);
	}

	public bool FinishObjectSoleEditSession(Guid objectUid, string objectName, long userId, string sessionPrefix)
	{
		return FinishObjectSoleEditSession(objectUid.ToString(), objectName, userId, sessionPrefix);
	}

	public MultiEditEditorStoreModel[] PingAndGetCurrentEditorsForObject(long objectId, string objectName, long parentObjectId, string parentObjectName, long userId, string userName, string sessionPrefix, long sessionLifeTime, Guid editSessionUid)
	{
		//Discarded unreachable code: IL_0113, IL_0122, IL_028e, IL_0306, IL_0315, IL_03fb, IL_04ae, IL_04bd, IL_05a3, IL_05e3, IL_05f2, IL_05fe, IL_06b2
		int num = 23;
		MultiEditEditorStoreModel[] array = default(MultiEditEditorStoreModel[]);
		List<MultiEditEditorStoreModel> value = default(List<MultiEditEditorStoreModel>);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_2 = default(_003C_003Ec__DisplayClass8_0);
		MultiEditEditorStoreModel multiEditEditorStoreModel = default(MultiEditEditorStoreModel);
		_003C_003Ec__DisplayClass8_1 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_1);
		string key = default(string);
		DateTime dateTime = default(DateTime);
		MultiEditEditorStoreModel multiEditEditorStoreModel2 = default(MultiEditEditorStoreModel);
		int num3 = default(int);
		MultiEditEditorStoreModel[] array2 = default(MultiEditEditorStoreModel[]);
		TimeSpan timeSpan = default(TimeSpan);
		IEnumerator<MultiEditEditorStoreModel> enumerator = default(IEnumerator<MultiEditEditorStoreModel>);
		MultiEditEditorStoreModel current = default(MultiEditEditorStoreModel);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 33:
				case 36:
					array = value.Where(_003C_003Ec__DisplayClass8_2._003CPingAndGetCurrentEditorsForObject_003Eb__0).ToArray();
					num2 = 18;
					continue;
				case 2:
					return array;
				case 24:
					multiEditEditorStoreModel.savedAfter = false;
					num2 = 41;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 27;
					}
					continue;
				case 16:
					value = value.Where(_003C_003Ec__DisplayClass8_._003CPingAndGetCurrentEditorsForObject_003Eb__1).ToList();
					num2 = 8;
					continue;
				case 41:
					multiEditEditorStoreModel.lastActivityTime = DateTime.Now;
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 22;
					}
					continue;
				case 10:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_1();
					num2 = 4;
					continue;
				case 28:
					if (!Cache.TryGetValue<List<MultiEditEditorStoreModel>>(key, out value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 17:
				{
					MultiEditEditorStoreModel obj2 = new MultiEditEditorStoreModel
					{
						editSessionUid = _003C_003Ec__DisplayClass8_2.editSessionUid,
						userId = _003C_003Ec__DisplayClass8_2.userId,
						userName = userName,
						parentObjectId = parentObjectId,
						parentObjectName = parentObjectName,
						objectId = _003C_003Ec__DisplayClass8_2.objectId,
						objectName = objectName,
						openTime = baynqFBmOdDpss30YnNI(),
						openTimeStr = baynqFBmOdDpss30YnNI().ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638492941)),
						saveTime = null,
						saveTimeStr = string.Empty,
						savedAfter = false,
						lastActivityTime = DateTime.Now
					};
					dateTime = baynqFBmOdDpss30YnNI();
					obj2.lastActivityTimeStr = dateTime.ToString((string)AS6opCBmnbTpJdcDxOs0(-1317790512 ^ -1317700046));
					multiEditEditorStoreModel = obj2;
					num2 = 3;
					continue;
				}
				case 21:
					if (!AbC5nqBm1R0TP02CqPGX(multiEditEditorStoreModel2.saveTime.Value, multiEditEditorStoreModel.openTime))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 20;
				case 13:
				case 32:
				case 37:
					multiEditEditorStoreModel2.savedAfter = false;
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 29;
					}
					continue;
				case 9:
				case 34:
					num3++;
					num2 = 19;
					continue;
				case 35:
					_003C_003Ec__DisplayClass8_2.editSessionUid = editSessionUid;
					num2 = 12;
					continue;
				case 4:
					_003C_003Ec__DisplayClass8_.sessionsToDelete = new List<Guid>();
					num2 = 15;
					continue;
				case 20:
					multiEditEditorStoreModel2.savedAfter = true;
					num2 = 9;
					continue;
				case 18:
					array2 = array;
					num = 30;
					break;
				case 25:
					if (!multiEditEditorStoreModel2.saveTime.HasValue)
					{
						num2 = 32;
						continue;
					}
					goto case 21;
				case 7:
					value = new List<MultiEditEditorStoreModel> { multiEditEditorStoreModel };
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 39;
					}
					continue;
				case 12:
					timeSpan = xuWlGaBmkWmaLYMDVLnF(sessionLifeTime);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 11;
					}
					continue;
				case 40:
					_003C_003Ec__DisplayClass8_2.objectId = objectId;
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 35;
					}
					continue;
				case 22:
					_003C_003Ec__DisplayClass8_2.userId = userId;
					num2 = 40;
					continue;
				case 38:
					multiEditEditorStoreModel = null;
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 28;
					}
					continue;
				case 1:
				case 5:
					Cache.Insert(key, value, timeSpan);
					num2 = 33;
					continue;
				case 23:
					_003C_003Ec__DisplayClass8_2 = new _003C_003Ec__DisplayClass8_0();
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 14;
					}
					continue;
				case 30:
					num3 = 0;
					num2 = 31;
					continue;
				case 19:
				case 31:
					if (num3 >= array2.Length)
					{
						num2 = 2;
						continue;
					}
					goto case 6;
				case 29:
					value = null;
					num = 38;
					break;
				case 14:
					try
					{
						while (true)
						{
							int num4;
							if (!mUtcRnBmeCVbp3Kc9a09(enumerator))
							{
								num4 = 4;
								goto IL_04cc;
							}
							goto IL_0542;
							IL_04cc:
							while (true)
							{
								switch (num4)
								{
								case 2:
									dateTime = baynqFBmOdDpss30YnNI();
									num4 = 5;
									continue;
								default:
									_003C_003Ec__DisplayClass8_.sessionsToDelete.Add(current.editSessionUid);
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
									{
										num4 = 3;
									}
									continue;
								case 3:
									break;
								case 1:
									goto IL_0542;
								case 5:
									if (TjK9U9Bm2IECiO7gOuDC(dateTime.Subtract(current.lastActivityTime), timeSpan))
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
										{
											num4 = 0;
										}
										continue;
									}
									break;
								case 4:
									goto end_IL_052c;
								}
								break;
							}
							continue;
							IL_0542:
							current = enumerator.Current;
							int num5 = 2;
							num4 = num5;
							goto IL_04cc;
							continue;
							end_IL_052c:
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 2;
							goto IL_05a7;
						}
						goto IL_05bd;
						IL_05a7:
						switch (num6)
						{
						case 2:
							goto end_IL_0592;
						case 1:
							goto end_IL_0592;
						}
						goto IL_05bd;
						IL_05bd:
						qcCXjhBmPAE3Nn89Bcmt(enumerator);
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num6 = 1;
						}
						goto IL_05a7;
						end_IL_0592:;
					}
					goto case 16;
				case 8:
					multiEditEditorStoreModel = value.FirstOrDefault(_003C_003Ec__DisplayClass8_2._003CPingAndGetCurrentEditorsForObject_003Eb__2);
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 25;
					}
					continue;
				case 39:
					Cache.Insert(key, value, timeSpan);
					num2 = 36;
					continue;
				case 6:
					multiEditEditorStoreModel2 = array2[num3];
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 4;
					}
					continue;
				case 11:
					key = string.Format((string)AS6opCBmnbTpJdcDxOs0(-345420348 ^ -345399506), sessionPrefix, parentObjectId);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 29;
					}
					continue;
				case 27:
					if (multiEditEditorStoreModel == null)
					{
						num2 = 17;
						continue;
					}
					goto case 24;
				case 26:
					multiEditEditorStoreModel.lastActivityTimeStr = multiEditEditorStoreModel.lastActivityTime.ToString((string)AS6opCBmnbTpJdcDxOs0(0x1ECE530A ^ 0x1ECF31E8));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					value.Add(multiEditEditorStoreModel);
					num2 = 5;
					continue;
				default:
				{
					MultiEditEditorStoreModel obj = new MultiEditEditorStoreModel
					{
						editSessionUid = _003C_003Ec__DisplayClass8_2.editSessionUid,
						userId = _003C_003Ec__DisplayClass8_2.userId,
						userName = userName,
						parentObjectId = parentObjectId,
						parentObjectName = parentObjectName,
						objectId = _003C_003Ec__DisplayClass8_2.objectId,
						objectName = objectName,
						openTime = baynqFBmOdDpss30YnNI(),
						openTimeStr = baynqFBmOdDpss30YnNI().ToString((string)AS6opCBmnbTpJdcDxOs0(-1979251663 ^ -1979291949)),
						saveTime = null,
						saveTimeStr = string.Empty,
						savedAfter = false,
						lastActivityTime = baynqFBmOdDpss30YnNI()
					};
					dateTime = DateTime.Now;
					obj.lastActivityTimeStr = dateTime.ToString((string)AS6opCBmnbTpJdcDxOs0(0x35C0467B ^ 0x35C12499));
					multiEditEditorStoreModel = obj;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				case 15:
					enumerator = value.Where(delegate(MultiEditEditorStoreModel m)
					{
						//Discarded unreachable code: IL_0068, IL_0077
						int num7 = 1;
						int num8 = num7;
						while (true)
						{
							switch (num8)
							{
							case 1:
								if (m.saveTime.HasValue)
								{
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
									{
										num8 = 0;
									}
									break;
								}
								goto case 2;
							case 2:
								return !m.publishTime.HasValue;
							default:
								return false;
							}
						}
					}).GetEnumerator();
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	public bool FinishMyObjectEditSession(long objectId, string objectName, long parentObjectId, string parentObjectName, long userId, string userName, string sessionPrefix, long sessionLifeTime, Guid editSessionUid)
	{
		//Discarded unreachable code: IL_00b0, IL_00bf, IL_00cf, IL_034a, IL_0359, IL_03b0, IL_03bf, IL_03f9, IL_0408, IL_04fe, IL_0511
		int num = 18;
		string text = default(string);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		MultiEditEditorStoreModel multiEditEditorStoreModel = default(MultiEditEditorStoreModel);
		List<MultiEditEditorStoreModel> value = default(List<MultiEditEditorStoreModel>);
		_003C_003Ec__DisplayClass9_1 _003C_003Ec__DisplayClass9_2 = default(_003C_003Ec__DisplayClass9_1);
		List<MultiEditEditorStoreModel>.Enumerator enumerator = default(List<MultiEditEditorStoreModel>.Enumerator);
		DateTime dateTime = default(DateTime);
		TimeSpan timeSpan = default(TimeSpan);
		MultiEditEditorStoreModel current = default(MultiEditEditorStoreModel);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					NwE2jsBm3YjDjLM3Aahg(Cache, text);
					num2 = 2;
					continue;
				case 18:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 17;
					}
					continue;
				case 23:
					multiEditEditorStoreModel = value.FirstOrDefault(_003C_003Ec__DisplayClass9_._003CFinishMyObjectEditSession_003Eb__0);
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 28;
					}
					continue;
				case 20:
					_003C_003Ec__DisplayClass9_2 = new _003C_003Ec__DisplayClass9_1();
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 23;
					}
					continue;
				case 12:
					enumerator = value.GetEnumerator();
					num2 = 9;
					continue;
				case 22:
					_003C_003Ec__DisplayClass9_.objectId = objectId;
					num2 = 14;
					continue;
				default:
					multiEditEditorStoreModel.savedAfter = false;
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 26;
					}
					continue;
				case 3:
				case 19:
					multiEditEditorStoreModel.saveTime = baynqFBmOdDpss30YnNI();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
				{
					MultiEditEditorStoreModel obj = new MultiEditEditorStoreModel
					{
						editSessionUid = _003C_003Ec__DisplayClass9_.editSessionUid,
						userId = _003C_003Ec__DisplayClass9_.userId,
						userName = userName,
						parentObjectId = parentObjectId,
						parentObjectName = parentObjectName,
						objectId = _003C_003Ec__DisplayClass9_.objectId,
						objectName = objectName,
						openTime = baynqFBmOdDpss30YnNI(),
						openTimeStr = baynqFBmOdDpss30YnNI().ToString((string)AS6opCBmnbTpJdcDxOs0(0xE1229CF ^ 0xE134B2D)),
						saveTime = DateTime.Now,
						saveTimeStr = baynqFBmOdDpss30YnNI().ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751234302)),
						savedAfter = false,
						lastActivityTime = DateTime.Now
					};
					dateTime = baynqFBmOdDpss30YnNI();
					obj.lastActivityTimeStr = dateTime.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951555324));
					multiEditEditorStoreModel = obj;
					num2 = 4;
					continue;
				}
				case 7:
					value = null;
					num2 = 5;
					continue;
				case 8:
					if (value.Count > 1)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 25:
				case 29:
					_003C_003Ec__DisplayClass9_2.sessionsToDelete = new List<Guid>();
					num2 = 12;
					continue;
				case 15:
					Cache.Insert(text, value, timeSpan);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 16;
					}
					continue;
				case 5:
					multiEditEditorStoreModel = null;
					num2 = 27;
					continue;
				case 28:
					if (multiEditEditorStoreModel != null)
					{
						num2 = 3;
						continue;
					}
					goto case 13;
				case 1:
				{
					MultiEditEditorStoreModel multiEditEditorStoreModel2 = multiEditEditorStoreModel;
					dateTime = multiEditEditorStoreModel.saveTime.Value;
					multiEditEditorStoreModel2.saveTimeStr = dateTime.ToString((string)AS6opCBmnbTpJdcDxOs0(-1978478350 ^ -1978420720));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 9:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
								{
									num3 = 0;
								}
								goto IL_03ce;
							}
							goto IL_049a;
							IL_049a:
							current = enumerator.Current;
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
							{
								num3 = 5;
							}
							goto IL_03ce;
							IL_03ce:
							while (true)
							{
								switch (num3)
								{
								case 3:
								case 4:
									break;
								case 6:
									if (!TjK9U9Bm2IECiO7gOuDC(dateTime.Subtract(current.lastActivityTime), timeSpan))
									{
										num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
										{
											num3 = 4;
										}
										continue;
									}
									goto default;
								default:
									_003C_003Ec__DisplayClass9_2.sessionsToDelete.Add(current.editSessionUid);
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
									{
										num3 = 3;
									}
									continue;
								case 2:
									goto IL_049a;
								case 5:
								{
									dateTime = DateTime.Now;
									int num4 = 6;
									num3 = num4;
									continue;
								}
								case 1:
									goto end_IL_0413;
								}
								break;
							}
							continue;
							end_IL_0413:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
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
				case 14:
					_003C_003Ec__DisplayClass9_.editSessionUid = editSessionUid;
					num2 = 10;
					continue;
				case 24:
					multiEditEditorStoreModel.lastActivityTimeStr = multiEditEditorStoreModel.lastActivityTime.ToString((string)AS6opCBmnbTpJdcDxOs0(-87337865 ^ -87411051));
					num2 = 29;
					continue;
				case 11:
					break;
				case 26:
					multiEditEditorStoreModel.lastActivityTime = DateTime.Now;
					num2 = 24;
					continue;
				case 2:
				case 16:
					return true;
				case 4:
					value.Add(multiEditEditorStoreModel);
					num2 = 25;
					continue;
				case 21:
					text = (string)hhH8p9BmNPTqqPMm1rD3(AS6opCBmnbTpJdcDxOs0(0x6A81B9B4 ^ 0x6A816B5E), sessionPrefix, parentObjectId);
					num2 = 7;
					continue;
				case 10:
					timeSpan = xuWlGaBmkWmaLYMDVLnF(sessionLifeTime);
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 18;
					}
					continue;
				case 17:
					_003C_003Ec__DisplayClass9_.userId = userId;
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 22;
					}
					continue;
				case 27:
					if (Cache.TryGetValue<List<MultiEditEditorStoreModel>>(text, out value))
					{
						num2 = 20;
						continue;
					}
					goto case 2;
				}
				break;
			}
			value = value.Where(_003C_003Ec__DisplayClass9_2._003CFinishMyObjectEditSession_003Eb__1).ToList();
			num = 8;
		}
	}

	public bool PublishMyObjectEditSession(long objectId, string objectName, long parentObjectId, string parentObjectName, long userId, string userName, string sessionPrefix, long sessionLifeTime)
	{
		//Discarded unreachable code: IL_00d8, IL_0280, IL_038d, IL_0397, IL_03c6, IL_03d5, IL_0497, IL_04aa
		int num = 6;
		int num2 = num;
		List<MultiEditEditorStoreModel> value = default(List<MultiEditEditorStoreModel>);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		string text = default(string);
		Guid editSessionUid = default(Guid);
		TimeSpan timeSpan = default(TimeSpan);
		DateTime dateTime = default(DateTime);
		MultiEditEditorStoreModel item = default(MultiEditEditorStoreModel);
		List<MultiEditEditorStoreModel>.Enumerator enumerator = default(List<MultiEditEditorStoreModel>.Enumerator);
		MultiEditEditorStoreModel current = default(MultiEditEditorStoreModel);
		while (true)
		{
			switch (num2)
			{
			case 17:
				value = value.Where(_003C_003Ec__DisplayClass10_._003CPublishMyObjectEditSession_003Eb__0).ToList();
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				continue;
			case 19:
				if (!Cache.TryGetValue<List<MultiEditEditorStoreModel>>(text, out value))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 13;
			case 15:
				editSessionUid = kcaT0HBmpDbNQDVkvwav();
				num2 = 11;
				continue;
			case 6:
				timeSpan = xuWlGaBmkWmaLYMDVLnF(sessionLifeTime);
				num2 = 5;
				continue;
			case 11:
			{
				MultiEditEditorStoreModel obj = new MultiEditEditorStoreModel
				{
					editSessionUid = editSessionUid,
					userId = userId,
					userName = userName,
					parentObjectId = parentObjectId,
					parentObjectName = parentObjectName,
					objectId = objectId,
					objectName = objectName,
					openTime = DateTime.Now,
					openTimeStr = baynqFBmOdDpss30YnNI().ToString((string)AS6opCBmnbTpJdcDxOs0(-629844702 ^ -629917760)),
					publishTime = DateTime.Now,
					publishTimeStr = DateTime.Now.ToString((string)AS6opCBmnbTpJdcDxOs0(0x35C0467B ^ 0x35C12499)),
					saveTime = null,
					saveTimeStr = string.Empty,
					savedAfter = false,
					lastActivityTime = DateTime.Now
				};
				dateTime = baynqFBmOdDpss30YnNI();
				obj.lastActivityTimeStr = dateTime.ToString((string)AS6opCBmnbTpJdcDxOs0(0x637E299B ^ 0x637F4B79));
				item = obj;
				num2 = 19;
				continue;
			}
			case 13:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				continue;
			case 14:
				item = null;
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 12;
				}
				continue;
			case 12:
				if (B9PJaaBmakCpfNbGQGlK(value) > 1)
				{
					num2 = 3;
					continue;
				}
				break;
			default:
				value.Add(item);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 18;
				}
				continue;
			case 4:
			case 8:
			case 16:
				return true;
			case 5:
				text = (string)hhH8p9BmNPTqqPMm1rD3(AS6opCBmnbTpJdcDxOs0(0x7E6E5A0B ^ 0x7E6E88E1), sessionPrefix, parentObjectId);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				value = new List<MultiEditEditorStoreModel> { item };
				num2 = 10;
				continue;
			case 18:
				_003C_003Ec__DisplayClass10_.sessionsToDelete = new List<Guid>();
				num2 = 20;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 20;
				}
				continue;
			case 20:
				enumerator = value.GetEnumerator();
				num2 = 7;
				continue;
			case 1:
				value = null;
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 1;
				}
				continue;
			case 10:
				Cache.Insert(text, value, timeSpan);
				num2 = 8;
				continue;
			case 3:
				Cache.Insert(text, value, timeSpan);
				num2 = 16;
				continue;
			case 9:
				break;
			case 7:
				try
				{
					while (true)
					{
						IL_0417:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_039b;
						}
						goto IL_03e0;
						IL_039b:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							case 5:
								if (!(dateTime.Subtract(current.lastActivityTime) > timeSpan))
								{
									num3 = 3;
									continue;
								}
								goto case 1;
							default:
								goto IL_0417;
							case 6:
								dateTime = baynqFBmOdDpss30YnNI();
								num3 = 5;
								continue;
							case 1:
								_003C_003Ec__DisplayClass10_.sessionsToDelete.Add(current.editSessionUid);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								goto end_IL_0417;
							}
							break;
						}
						goto IL_03e0;
						IL_03e0:
						current = enumerator.Current;
						num3 = 6;
						goto IL_039b;
						continue;
						end_IL_0417:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 17;
			}
			NwE2jsBm3YjDjLM3Aahg(Cache, text);
			num2 = 4;
		}
	}

	private MultiEditEditorStoreModel PingAndGetCurrentSoleEditor(string objectId, string objectName, long parentObjectId, string parentObjectName, long userId, string userName, string sessionPrefix, long sessionLifeTime, Guid editSessionUid, bool selfKick, bool saveChanges)
	{
		//Discarded unreachable code: IL_0081, IL_0090, IL_009f, IL_0137, IL_0146, IL_01e1, IL_0396, IL_03a5
		int num = 22;
		MultiEditEditorStoreModel value = default(MultiEditEditorStoreModel);
		DateTime dateTime = default(DateTime);
		TimeSpan timeSpan = default(TimeSpan);
		string key = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
				case 19:
					if (value != null)
					{
						num2 = 23;
						continue;
					}
					break;
				case 16:
					value = null;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					dateTime = baynqFBmOdDpss30YnNI();
					num2 = 17;
					continue;
				case 4:
					value.SaveChanges = selfKick && saveChanges;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					value.openTime = dateTime;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					continue;
				case 22:
					timeSpan = xuWlGaBmkWmaLYMDVLnF(sessionLifeTime);
					num2 = 21;
					continue;
				case 10:
					value.editSessionUid = editSessionUid;
					num2 = 6;
					continue;
				case 1:
					value.lastActivityTime = dateTime;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 2;
					}
					continue;
				case 9:
					if (!Abo8Q4BmDgLgvGaYjmyq(value.editSessionUid, editSessionUid))
					{
						num2 = 8;
						continue;
					}
					goto case 1;
				case 21:
					key = (string)hhH8p9BmNPTqqPMm1rD3(AS6opCBmnbTpJdcDxOs0(-1217523399 ^ -1217477677), sessionPrefix, objectId);
					num2 = 2;
					continue;
				case 17:
					if (!Cache.TryGetValue<MultiEditEditorStoreModel>(key, out value))
					{
						goto end_IL_0012;
					}
					goto case 7;
				case 8:
				case 13:
				case 14:
					Cache.Insert(key, value, timeSpan);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 12;
					}
					continue;
				case 11:
					if (selfKick)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 4;
				case 3:
					Cache.Insert(key, value, timeSpan);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 18;
					}
					continue;
				default:
					if (value.userId == userId)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 8;
				case 7:
					if (!TjK9U9Bm2IECiO7gOuDC(dateTime.Subtract(value.lastActivityTime), timeSpan))
					{
						num2 = 19;
						continue;
					}
					goto case 16;
				case 15:
					value = new MultiEditEditorStoreModel
					{
						editSessionUid = editSessionUid,
						userId = userId,
						userName = userName,
						parentObjectId = parentObjectId,
						parentObjectName = parentObjectName,
						objectName = objectName,
						openTime = dateTime,
						lastActivityTime = dateTime
					};
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
				case 18:
					return value;
				case 20:
					break;
				}
				value = new MultiEditEditorStoreModel
				{
					editSessionUid = editSessionUid,
					userId = userId,
					userName = userName,
					parentObjectId = parentObjectId,
					parentObjectName = parentObjectName,
					objectName = objectName,
					openTime = dateTime,
					lastActivityTime = dateTime
				};
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 15;
		}
	}

	private bool FinishObjectSoleEditSession(string objectId, string objectName, long userId, string sessionPrefix)
	{
		int num = 2;
		int num2 = num;
		string key = default(string);
		MultiEditEditorStoreModel value = default(MultiEditEditorStoreModel);
		while (true)
		{
			switch (num2)
			{
			default:
				Cache.Remove(key);
				num2 = 4;
				break;
			case 4:
				return true;
			case 1:
				if (Cache.TryGetValue<MultiEditEditorStoreModel>(key, out value))
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 3:
				if (value.userId == userId)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				key = string.Format((string)AS6opCBmnbTpJdcDxOs0(0x7247028A ^ 0x7247D060), sessionPrefix, objectId);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public MultiEditService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool QA0jTwBmXI44SjlDmMxA()
	{
		return mn7A9NBmK0KBGAi5dHRE == null;
	}

	internal static MultiEditService IYODAsBmT5BsxCh8ZV6X()
	{
		return mn7A9NBmK0KBGAi5dHRE;
	}

	internal static TimeSpan xuWlGaBmkWmaLYMDVLnF(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static object AS6opCBmnbTpJdcDxOs0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static DateTime baynqFBmOdDpss30YnNI()
	{
		return DateTime.Now;
	}

	internal static bool TjK9U9Bm2IECiO7gOuDC(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 > P_1;
	}

	internal static bool mUtcRnBmeCVbp3Kc9a09(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void qcCXjhBmPAE3Nn89Bcmt(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool AbC5nqBm1R0TP02CqPGX(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static object hhH8p9BmNPTqqPMm1rD3(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void NwE2jsBm3YjDjLM3Aahg(object P_0, object P_1)
	{
		((ICacheService)P_0).Remove((string)P_1);
	}

	internal static Guid kcaT0HBmpDbNQDVkvwav()
	{
		return Guid.NewGuid();
	}

	internal static int B9PJaaBmakCpfNbGQGlK(object P_0)
	{
		return ((List<MultiEditEditorStoreModel>)P_0).Count;
	}

	internal static bool Abo8Q4BmDgLgvGaYjmyq(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}

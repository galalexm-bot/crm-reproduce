using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Nullifier;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Extensions;

[Component]
internal class NullifierActionsWorkflowExtension : INullifierActions
{
	private ClearObjectParameters ClearObjectParams;

	private string tempTableName;

	private string TempTableNameFileDel;

	private string tempTableHistory;

	private string TempTableFreeFile;

	private Dictionary<string, string> endClear;

	private static NullifierActionsWorkflowExtension WYAs9ZiKvYoJ4BD9Xj6;

	public void CreateTree(Func<string, Guid, object, int, string, Guid, bool, bool, Image, bool> addNode)
	{
	}

	public DeleteFoldersOutput DeleteFolders(DeleteFoldersInput deleteFoldersInput)
	{
		return null;
	}

	public void PostNullifier(PostNullifierParameters postNullifierParameters)
	{
	}

	public void SearchSystemFile()
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_0240, IL_0253, IL_0263, IL_0272, IL_027d, IL_02eb, IL_02fa, IL_03a8, IL_0505, IL_0514, IL_05ac, IL_05e4, IL_05f3, IL_0643, IL_0652, IL_0673, IL_0682, IL_06b3, IL_06eb, IL_06fa
		int num = 5;
		int num2 = num;
		IEnumerator<IProcessHeader> enumerator = default(IEnumerator<IProcessHeader>);
		IEnumerator<EntityPropertyMetadata> enumerator3 = default(IEnumerator<EntityPropertyMetadata>);
		IProcessHeader current2 = default(IProcessHeader);
		List<string> list2 = default(List<string>);
		string item = default(string);
		string text = default(string);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		EntityPropertyMetadata current = default(EntityPropertyMetadata);
		SimpleTypeSettings simpleTypeSettings = default(SimpleTypeSettings);
		List<Guid> list = default(List<Guid>);
		long num3 = default(long);
		List<string>.Enumerator enumerator2 = default(List<string>.Enumerator);
		string current3 = default(string);
		string arg = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				try
				{
					while (true)
					{
						IL_02cf:
						int num4;
						if (!lEXtx9igwepfRBJ0slh(enumerator))
						{
							num4 = 2;
							goto IL_0281;
						}
						goto IL_02bc;
						IL_0281:
						while (true)
						{
							switch (num4)
							{
							case 3:
								enumerator3 = ((IEnumerable<EntityPropertyMetadata>)((EntityMetadata)TwDttwiYt2jvZnw1IRV(current2)).EntityProperties).GetEnumerator();
								num4 = 4;
								continue;
							case 1:
								break;
							default:
								goto IL_02cf;
							case 4:
								try
								{
									while (true)
									{
										int num5;
										if (!enumerator3.MoveNext())
										{
											num5 = 16;
											goto IL_0309;
										}
										goto IL_05cc;
										IL_0309:
										while (true)
										{
											int num6;
											switch (num5)
											{
											case 3:
												list2.Add(item);
												num5 = 14;
												continue;
											case 11:
												text = (string)L0UJywim7K7frpAaDTW(((EntityMetadata)TwDttwiYt2jvZnw1IRV(current2)).TableName, WqOocKiynALQQp44LK2(_003C_003Ec__DisplayClass9_.properti));
												num5 = 17;
												continue;
											case 5:
												_003C_003Ec__DisplayClass9_.properti = current;
												num5 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
												{
													num5 = 6;
												}
												continue;
											case 17:
												item = string.Format((string)inYRs1itej7QwEaN62a(0x101D10F ^ 0x100F77D), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), YVsakiiJewIGgaE2csa(simpleTypeSettings)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), text), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-772614310 ^ -772542018)));
												num5 = 3;
												continue;
											case 7:
												if (STODUvis77NruotHRlv(YlTP1Ci8h96Idl0k2G6(current), BinaryFileDescriptor.UID))
												{
													num5 = 19;
													continue;
												}
												break;
											case 19:
												if (!(current.Settings is SimpleTypeSettings))
												{
													num6 = 15;
													goto IL_0305;
												}
												goto default;
											case 9:
												if (!rk69jWilp4i49orp2ax(YVsakiiJewIGgaE2csa(simpleTypeSettings), string.Empty))
												{
													num6 = 12;
													goto IL_0305;
												}
												goto case 18;
											case 20:
												simpleTypeSettings = current.Settings as SimpleTypeSettings;
												num5 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
												{
													num5 = 2;
												}
												continue;
											default:
												_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
												num5 = 5;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
												{
													num5 = 0;
												}
												continue;
											case 8:
											case 12:
											case 13:
											case 14:
											case 15:
												break;
											case 1:
												if (YVsakiiJewIGgaE2csa(simpleTypeSettings) != null)
												{
													num5 = 9;
													continue;
												}
												break;
											case 10:
												if (list.Any(_003C_003Ec__DisplayClass9_._003CSearchSystemFile_003Eb__0))
												{
													num5 = 8;
													continue;
												}
												goto case 20;
											case 18:
												list.Add(aXFdIji0sdRAeHLsOCY(current2));
												num5 = 11;
												continue;
											case 2:
												if (simpleTypeSettings != null)
												{
													num5 = 1;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
													{
														num5 = 0;
													}
													continue;
												}
												break;
											case 6:
												if (_003C_003Ec__DisplayClass9_.properti == null)
												{
													num5 = 13;
													continue;
												}
												goto case 10;
											case 4:
												goto IL_05cc;
											case 16:
												goto end_IL_051f;
												IL_0305:
												num5 = num6;
												continue;
											}
											break;
										}
										continue;
										IL_05cc:
										current = enumerator3.Current;
										num5 = 7;
										goto IL_0309;
										continue;
										end_IL_051f:
										break;
									}
								}
								finally
								{
									int num7;
									if (enumerator3 == null)
									{
										num7 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
										{
											num7 = 1;
										}
										goto IL_0628;
									}
									goto IL_065d;
									IL_065d:
									enumerator3.Dispose();
									int num8 = 2;
									num7 = num8;
									goto IL_0628;
									IL_0628:
									switch (num7)
									{
									case 1:
										goto end_IL_0603;
									case 2:
										goto end_IL_0603;
									}
									goto IL_065d;
									end_IL_0603:;
								}
								goto IL_02cf;
							case 2:
								goto end_IL_02cf;
							}
							break;
						}
						goto IL_02bc;
						IL_02bc:
						current2 = enumerator.Current;
						num4 = 3;
						goto IL_0281;
						continue;
						end_IL_02cf:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num9 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
						{
							num9 = 1;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
								K1mXiMiBUH4f49vgMuD(enumerator);
								num9 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
								{
									num9 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 1;
			case 1:
				num3 = 0L;
				num2 = 3;
				continue;
			case 3:
				enumerator2 = list2.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			case 5:
			{
				ICollection<IProcessHeader> collection = ((AbstractNHEntityManager<IProcessHeader, long>)nwLSouivRQCCv5F0kNR()).FindAll();
				list = new List<Guid>();
				list2 = new List<string>();
				enumerator = collection.GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
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
					IL_01ee:
					int num10;
					if (!enumerator2.MoveNext())
					{
						num10 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
						{
							num10 = 1;
						}
						goto IL_0058;
					}
					goto IL_007a;
					IL_007a:
					current3 = enumerator2.Current;
					int num11 = 3;
					num10 = num11;
					goto IL_0058;
					IL_0058:
					while (true)
					{
						switch (num10)
						{
						case 2:
							ClearObjectParams.ExecuteQuery(arg, (string)XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(0x69063C81 ^ 0x69071B4D)));
							num10 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
							{
								num10 = 4;
							}
							continue;
						case 3:
							arg = (string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-495296780 ^ -495224828), new object[6]
							{
								current3,
								PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-105863102 ^ -105803976)),
								PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F530CDA)),
								PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772542214)),
								PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x738ABA6E ^ 0x738B9DDA)),
								PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x246EEF98 ^ 0x246EA9E4))
							});
							num10 = 2;
							continue;
						case 4:
							num3++;
							num10 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
							{
								num10 = 1;
							}
							continue;
						case 1:
							goto IL_01ee;
						case 5:
							return;
						}
						break;
					}
					goto IL_007a;
				}
			}
			finally
			{
				((IDisposable)enumerator2).Dispose();
				int num12 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
				{
					num12 = 0;
				}
				switch (num12)
				{
				case 0:
					break;
				}
			}
		}
	}

	public void ClearObject(ClearObjectParameters clearObjectParameters)
	{
		//Discarded unreachable code: IL_015a, IL_0169, IL_0342, IL_03b7, IL_03c7, IL_04cd, IL_04e0, IL_0517, IL_0585, IL_05f7, IL_076b, IL_07a6, IL_07b0, IL_07c7, IL_07d1, IL_07e0, IL_083d, IL_08c3, IL_092a, IL_0939, IL_0964, IL_0a88, IL_0ce1, IL_0cf0, IL_0d0c, IL_0d72, IL_0ded, IL_0dfc, IL_0e0c, IL_0e1b, IL_1008, IL_101b
		int num = 8;
		List<UnitNullConfig>.Enumerator enumerator = default(List<UnitNullConfig>.Enumerator);
		UnitNullConfigWorkflow unitNullConfigWorkflow = default(UnitNullConfigWorkflow);
		DateTime? dateTime = default(DateTime?);
		long? num5 = default(long?);
		string text = default(string);
		DateTime dateTime5 = default(DateTime);
		TimeSpan timeSpan = default(TimeSpan);
		DateTime now = default(DateTime);
		int num9 = default(int);
		int num11 = default(int);
		DateTime dateTime7 = default(DateTime);
		int num10 = default(int);
		DateTime dateTime3 = default(DateTime);
		DateTime dateTime4 = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					TempTableFreeFile = (string)PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x738ABA6E ^ 0x738B9D14));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					return;
				case 5:
					tempTableHistory = (string)PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-1028861977 ^ -1028790345));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					ok372JiM7WkE30rHSJ5(PBjWmOiCOa3JdN1bqG3());
					num2 = 9;
					continue;
				case 1:
					endClear = new Dictionary<string, string>();
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 6;
					}
					continue;
				case 8:
					ClearObjectParams = clearObjectParameters;
					num2 = 7;
					continue;
				default:
					tempTableName = (string)PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x101D10F ^ 0x100F973));
					num2 = 4;
					continue;
				case 2:
					try
					{
						while (true)
						{
							IL_0d7c:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 62;
								goto IL_0174;
							}
							goto IL_0a13;
							IL_0408:
							num3 = 39;
							goto IL_0174;
							IL_0a13:
							unitNullConfigWorkflow = enumerator.Current as UnitNullConfigWorkflow;
							int num4 = 83;
							goto IL_0178;
							IL_0178:
							while (true)
							{
								DateTime dateTime6;
								int num8;
								int num6;
								object obj;
								int num7;
								DateTime dateTime2;
								switch (num4)
								{
								case 18:
									if (!dateTime.HasValue)
									{
										num4 = 17;
										continue;
									}
									dateTime6 = dateTime.GetValueOrDefault();
									goto IL_0eaf;
								case 1:
									num5 = unitNullConfigWorkflow.CheckRelativeDateWorkflowInstanceYear;
									num4 = 66;
									continue;
								case 85:
									if (!num5.HasValue)
									{
										num4 = 2;
										continue;
									}
									goto case 21;
								case 61:
									if (!FgNkYfidVeXeFftensX(unitNullConfigWorkflow))
									{
										num4 = 41;
										continue;
									}
									goto case 59;
								case 57:
									text += SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895908165);
									num4 = 69;
									continue;
								case 22:
									text += (string)inYRs1itej7QwEaN62a(-63028171 ^ -62952273);
									num4 = 90;
									continue;
								case 19:
									num8 = 0;
									goto IL_0ed6;
								case 83:
									if (unitNullConfigWorkflow == null)
									{
										num4 = 82;
										continue;
									}
									goto case 92;
								case 63:
								case 79:
									num5 = unitNullConfigWorkflow.InstanceIdFrom;
									num4 = 45;
									continue;
								case 58:
									if (IaYIS8iuRqDHkt3kVWo(unitNullConfigWorkflow.InstanceIdTo) >= 0)
									{
										goto IL_0408;
									}
									goto case 2;
								case 10:
									if (Convert.ToInt64(unitNullConfigWorkflow.InstanceIdTo) >= 0)
									{
										num4 = 31;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
										{
											num4 = 54;
										}
										continue;
									}
									goto case 2;
								case 87:
									text = (string)iFk8e4iDvqvjRP1aAur(text, inYRs1itej7QwEaN62a(-106528299 ^ -106452657));
									num4 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
									{
										num4 = 78;
									}
									continue;
								case 38:
									num5 = unitNullConfigWorkflow.InstanceIdFrom;
									num4 = 25;
									continue;
								case 9:
									dateTime5 = P2tdYqiRve5tqi0J6tE();
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
									{
										num4 = 0;
									}
									continue;
								case 8:
									num5 = unitNullConfigWorkflow.InstanceIdTo;
									num4 = 76;
									continue;
								default:
									timeSpan = knbyQ4iTtRXIt3RGaG0(P2tdYqiRve5tqi0J6tE(), now);
									num4 = 26;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
									{
										num4 = 20;
									}
									continue;
								case 66:
									break;
								case 64:
									text += (string)inYRs1itej7QwEaN62a(0x69063C81 ^ 0x6907141B);
									num4 = 51;
									continue;
								case 42:
									dateTime5 = dateTime5.AddMonths(num9 * -1);
									num4 = 13;
									continue;
								case 67:
									now = DateTime.Now;
									num4 = 18;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
									{
										num4 = 24;
									}
									continue;
								case 39:
									if (rk69jWilp4i49orp2ax(text, string.Empty))
									{
										num4 = 31;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
										{
											num4 = 10;
										}
										continue;
									}
									goto case 80;
								case 28:
									if (num5.HasValue)
									{
										num4 = 84;
										continue;
									}
									goto case 56;
								case 6:
									if (((Array)zEDxv8iHB294MxmKNts(unitNullConfigWorkflow)).Length != 0)
									{
										num4 = 16;
										continue;
									}
									goto case 53;
								case 68:
									dateTime = unitNullConfigWorkflow.CreateDateFrom;
									num4 = 18;
									continue;
								case 13:
									dateTime5 = dateTime5.AddDays(num11 * -1);
									num4 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
									{
										num4 = 15;
									}
									continue;
								case 69:
									text = (string)iFk8e4iDvqvjRP1aAur(text, sZ3UaginZZw3223o7vZ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x7595BA6), ((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(0x75872B6 ^ 0x7583476)), string.Join((string)inYRs1itej7QwEaN62a(-135674354 ^ -135701492), (IEnumerable<long>)zEDxv8iHB294MxmKNts(unitNullConfigWorkflow))));
									num4 = 53;
									continue;
								case 90:
									text = (string)iFk8e4iDvqvjRP1aAur(text, P4gdvbiWbaKa36dZQ9U(inYRs1itej7QwEaN62a(--1436248540 ^ 0x559A4174), ((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-43932417 ^ -44003891)), FwCjYZi9hhiYG3GMGXe(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), dateTime7), FwCjYZi9hhiYG3GMGXe(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), dateTime5)));
									num4 = 91;
									continue;
								case 81:
									goto end_IL_0178;
								case 33:
									num6 = 0;
									goto IL_0f0e;
								case 11:
									if (dateTime.HasValue)
									{
										num4 = 72;
										continue;
									}
									goto case 65;
								case 53:
									if (!WhxdfriLaLW1wxYxuAN(unitNullConfigWorkflow))
									{
										num4 = 88;
										continue;
									}
									goto case 70;
								case 5:
									obj = "";
									goto IL_0fc0;
								case 17:
									dateTime6 = new DateTime(1, 1, 1);
									goto IL_0eaf;
								case 43:
									text += (string)CvrvNWi6DgafWvkxP66(unitNullConfigWorkflow);
									num4 = 14;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
									{
										num4 = 50;
									}
									continue;
								case 14:
									if (Convert.ToInt64(unitNullConfigWorkflow.InstanceIdFrom) >= 0)
									{
										num4 = 58;
										continue;
									}
									goto case 2;
								case 35:
									num7 = 0;
									goto IL_0efa;
								case 2:
								case 20:
								case 36:
								case 71:
								case 84:
									if (zEDxv8iHB294MxmKNts(unitNullConfigWorkflow) != null)
									{
										num4 = 6;
										continue;
									}
									goto case 53;
								case 49:
									goto IL_086b;
								case 59:
									if (unitNullConfigWorkflow.UseIdBetweenParams)
									{
										num4 = 38;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
										{
											num4 = 17;
										}
										continue;
									}
									goto case 2;
								case 77:
									if (num5.HasValue)
									{
										num4 = 14;
										continue;
									}
									goto case 63;
								case 4:
									goto IL_08d1;
								case 16:
									if (rk69jWilp4i49orp2ax(text, string.Empty))
									{
										num4 = 57;
										continue;
									}
									goto case 69;
								case 34:
								case 73:
									num5 = unitNullConfigWorkflow.InstanceIdFrom;
									num4 = 49;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
									{
										num4 = 85;
									}
									continue;
								case 23:
									if (!rk69jWilp4i49orp2ax(text, string.Empty))
									{
										num4 = 89;
										continue;
									}
									goto case 64;
								case 27:
									dateTime7 = new DateTime(1, 1, 1);
									num4 = 9;
									continue;
								case 92:
									if (!STODUvis77NruotHRlv(GSE4TviX5lWKUusmbe0(unitNullConfigWorkflow), InterfaceActivator.UID<IProcessHeader>()))
									{
										num4 = 44;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
										{
											num4 = 10;
										}
										continue;
									}
									goto case 40;
								case 47:
								case 52:
									text += (string)sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(0x56F860D7 ^ 0x56F9482F), ((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB2CC54)), unitNullConfigWorkflow.InstanceIdFrom);
									num4 = 36;
									continue;
								case 86:
									goto IL_0a13;
								case 40:
									text = "";
									num4 = 61;
									continue;
								case 15:
									if (rk69jWilp4i49orp2ax(text, string.Empty))
									{
										num4 = 22;
										continue;
									}
									goto case 90;
								case 45:
									if (!num5.HasValue)
									{
										num4 = 8;
										continue;
									}
									goto case 34;
								case 76:
									if (!num5.HasValue)
									{
										num4 = 34;
										continue;
									}
									goto case 10;
								case 80:
									text = (string)iFk8e4iDvqvjRP1aAur(text, string.Format((string)inYRs1itej7QwEaN62a(0x56F860D7 ^ 0x56F9487F), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1361019545)), unitNullConfigWorkflow.InstanceIdFrom, unitNullConfigWorkflow.InstanceIdTo));
									num4 = 20;
									continue;
								case 29:
									goto IL_0afe;
								case 26:
									ClearObjectParams.AddLog((string)P2vUKcipcOr8wHtTSy8(inYRs1itej7QwEaN62a(-1516552726 ^ -1516628892), new object[2]
									{
										timeSpan,
										kXtxDfiQyPfnsRMPONC(unitNullConfigWorkflow)
									}));
									num4 = 3;
									continue;
								case 54:
									if (!rk69jWilp4i49orp2ax(text, string.Empty))
									{
										num4 = 48;
										continue;
									}
									goto case 87;
								case 41:
								case 46:
								case 50:
									if (fQgbFniq9F2RVRatYBl(text) <= 2)
									{
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
										{
											num4 = 5;
										}
										continue;
									}
									obj = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8D5763A ^ 0x8D45F72), text, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-398691253 ^ -398708019)), ((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(0x56F860D7 ^ 0x56F8387D)));
									goto IL_0fc0;
								case 32:
									num5 = unitNullConfigWorkflow.InstanceIdTo;
									num4 = 77;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
									{
										num4 = 52;
									}
									continue;
								case 21:
									num5 = unitNullConfigWorkflow.InstanceIdTo;
									num4 = 28;
									continue;
								case 25:
									if (!num5.HasValue)
									{
										num4 = 79;
										continue;
									}
									goto case 32;
								case 7:
									dateTime5 = dateTime5.AddYears(num10 * -1);
									num4 = 42;
									continue;
								case 24:
									deleteProcess(coTKT2i3pbth8vKeWLG(unitNullConfigWorkflow), unitNullConfigWorkflow.Name, text);
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
									{
										num4 = 0;
									}
									continue;
								case 31:
									text = (string)iFk8e4iDvqvjRP1aAur(text, inYRs1itej7QwEaN62a(--1436248540 ^ 0x559A4146));
									num4 = 80;
									continue;
								case 48:
								case 78:
									text = (string)iFk8e4iDvqvjRP1aAur(text, sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(0xD305CC2 ^ 0xD317422), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-1600060848 ^ -1600043818)), unitNullConfigWorkflow.InstanceIdTo));
									num4 = 28;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
									{
										num4 = 71;
									}
									continue;
								case 65:
									dateTime2 = new DateTime(9999, 1, 1);
									goto IL_0ec2;
								case 30:
								case 88:
								case 91:
									if (string.IsNullOrEmpty(unitNullConfigWorkflow.AdditionalSqlText))
									{
										num4 = 46;
										continue;
									}
									goto case 75;
								case 70:
									if (!dVg5gPifGKxcQ68njth(unitNullConfigWorkflow))
									{
										num4 = 94;
										continue;
									}
									goto case 68;
								case 56:
									if (!(text != string.Empty))
									{
										num4 = 47;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
										{
											num4 = 14;
										}
										continue;
									}
									goto case 93;
								case 3:
								case 44:
								case 82:
									goto IL_0d7c;
								case 37:
									dateTime = unitNullConfigWorkflow.CreateDateTo;
									num4 = 11;
									continue;
								case 93:
									text = (string)iFk8e4iDvqvjRP1aAur(text, inYRs1itej7QwEaN62a(-1542190822 ^ -1542119040));
									num4 = 52;
									continue;
								case 74:
								case 94:
									if (Se55PAij0ChsUMvusj4(unitNullConfigWorkflow))
									{
										num4 = 27;
										continue;
									}
									goto case 30;
								case 51:
								case 89:
									text += (string)P4gdvbiWbaKa36dZQ9U(inYRs1itej7QwEaN62a(0x246EEF98 ^ 0x246FC730), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-1001967776 ^ -1002043822)), FwCjYZi9hhiYG3GMGXe(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), dateTime3), FwCjYZi9hhiYG3GMGXe(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), dateTime4));
									num4 = 30;
									continue;
								case 72:
									dateTime2 = dateTime.GetValueOrDefault();
									goto IL_0ec2;
								case 55:
									num8 = (int)num5.Value;
									goto IL_0ed6;
								case 60:
									num7 = (int)num5.Value;
									goto IL_0efa;
								case 12:
									num6 = (int)num5.Value;
									goto IL_0f0e;
								case 75:
									text = (string)iFk8e4iDvqvjRP1aAur(text, (!string.IsNullOrEmpty(text)) ? SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542119040) : "");
									num4 = 43;
									continue;
								case 62:
									goto end_IL_0d7c;
									IL_0eaf:
									dateTime3 = dateTime6;
									num4 = 37;
									continue;
									IL_0efa:
									num9 = num7;
									num4 = 49;
									continue;
									IL_0fc0:
									text = (string)obj;
									num4 = 20;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
									{
										num4 = 67;
									}
									continue;
									IL_0ec2:
									dateTime4 = dateTime2;
									num4 = 23;
									continue;
									IL_0f0e:
									num11 = num6;
									num4 = 7;
									continue;
									IL_0ed6:
									num10 = num8;
									num4 = 80;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
									{
										num4 = 81;
									}
									continue;
								}
								if (!num5.HasValue)
								{
									num4 = 19;
									continue;
								}
								num5 = unitNullConfigWorkflow.CheckRelativeDateWorkflowInstanceYear;
								num4 = 55;
								continue;
								IL_0afe:
								if (num5.HasValue)
								{
									num5 = unitNullConfigWorkflow.CheckRelativeDateWorkflowInstanceDay;
									num4 = 12;
									continue;
								}
								num4 = 26;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
								{
									num4 = 33;
								}
								continue;
								IL_08d1:
								if (num5.HasValue)
								{
									num5 = unitNullConfigWorkflow.CheckRelativeDateWorkflowInstanceMonth;
									num4 = 60;
								}
								else
								{
									num4 = 35;
								}
								continue;
								end_IL_0178:
								break;
							}
							num5 = unitNullConfigWorkflow.CheckRelativeDateWorkflowInstanceMonth;
							num3 = 4;
							goto IL_0174;
							IL_086b:
							num5 = unitNullConfigWorkflow.CheckRelativeDateWorkflowInstanceDay;
							num3 = 29;
							goto IL_0174;
							IL_0174:
							num4 = num3;
							goto IL_0178;
							continue;
							end_IL_0d7c:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num12 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
						{
							num12 = 0;
						}
						switch (num12)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 6:
					enumerator = ClearObjectParams.units.GetEnumerator();
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					break;
				}
				break;
			}
			TempTableNameFileDel = (string)PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(--1436248540 ^ 0x559A41F8));
			num = 5;
		}
	}

	private void deleteTablePart(List<TablePartMetadata> TableParts, string condition)
	{
		foreach (TablePartMetadata TablePart in TableParts)
		{
			string text = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F67C03), ClearObjectParams.Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -947921939)), ClearObjectParams.Transform.Dialect.QuoteIfNeeded(TablePart.TableName), ClearObjectParams.Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420018951)), condition);
			deleteTablePart(TablePart.TableParts, text);
			ClearObjectParams.DeleteEntityMetadata(TablePart, text, arg3: false, 0, arg5: false);
		}
	}

	private void deleteProcess(Guid unitUid, string unitName, string Condition = "")
	{
		//Discarded unreachable code: IL_0216, IL_0225, IL_0765, IL_0774, IL_09d7, IL_09e6, IL_0a7f, IL_0af8, IL_0c93, IL_0cb2, IL_0cc1, IL_0cee, IL_0cfd, IL_0d56, IL_0e97, IL_0ea6, IL_112b, IL_1135, IL_11eb, IL_1250, IL_125f, IL_1769, IL_177c, IL_178b, IL_186b, IL_1c72, IL_3a9e, IL_3b5b, IL_3b6a
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				IProcessHeader processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)nwLSouivRQCCv5F0kNR()).LoadOrNull(unitUid);
				int num = 48;
				string text2 = default(string);
				string text4 = default(string);
				EntityMetadata entityMetadata12 = default(EntityMetadata);
				ProcessContext processContext = default(ProcessContext);
				EntityMetadata entityMetadata6 = default(EntityMetadata);
				string text = default(string);
				IEnumerator<IProcessHeader> enumerator = default(IEnumerator<IProcessHeader>);
				EntityMetadata entityMetadata10 = default(EntityMetadata);
				EntityMetadata entityMetadata7 = default(EntityMetadata);
				IProcessHeader current2 = default(IProcessHeader);
				string condition = default(string);
				TimeSpan timeSpan = default(TimeSpan);
				DateTime dateTime = default(DateTime);
				string text5 = default(string);
				List<PropertyMetadata>.Enumerator enumerator2 = default(List<PropertyMetadata>.Enumerator);
				EntityMetadata entityMetadata9 = default(EntityMetadata);
				EntityMetadata entityMetadata8 = default(EntityMetadata);
				EntityMetadata entityMetadata = default(EntityMetadata);
				EntityMetadata entityMetadata2 = default(EntityMetadata);
				string text3 = default(string);
				ProcessContext context = default(ProcessContext);
				PropertyMetadata current = default(PropertyMetadata);
				EntityMetadata entityMetadata5 = default(EntityMetadata);
				EntityMetadata entityMetadata4 = default(EntityMetadata);
				EntityMetadata entityMetadata3 = default(EntityMetadata);
				EntityMetadata entityMetadata11 = default(EntityMetadata);
				while (true)
				{
					int num2;
					switch (num)
					{
					case 13:
						return;
					case 21:
						return;
					case 41:
						return;
					case 62:
						return;
					case 61:
						ClearObjectParams.SqlQuery((string)CSNQ6QiU6QssGtPcmaV(inYRs1itej7QwEaN62a(0x6871CA ^ 0x695D80), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(riAs1RiAdYhlN5kfvUG(jnnRRTikRcHymckiTOG(processHeader))))), string.Format((string)XmwnLUiPYfcEhPq8joV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790167052)), text2));
						num = 9;
						break;
					case 15:
						ClearObjectParams.SqlQuery((string)CSNQ6QiU6QssGtPcmaV(inYRs1itej7QwEaN62a(0x1EA50FCC ^ 0x1EA43416), text4), (string)UU9ARticveoVt1x7E0K(XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(0x2F44D93A ^ 0x2F45E2C0)), Array.Empty<object>()));
						num2 = 84;
						goto IL_003d;
					case 11:
						ClearObjectParams.SqlQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-1108877388 ^ -1108940392), new object[4]
						{
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata12)),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(0x6F6D7B44 ^ 0x6F6D3DC2)),
							tempTableName,
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-885093259 ^ -885110153))
						}), (string)CSNQ6QiU6QssGtPcmaV(SR.T((string)inYRs1itej7QwEaN62a(-452127399 ^ -452189233)), text2));
						num2 = 36;
						goto IL_003d;
					case 4:
						processContext = LoadFullContext(processHeader.Id);
						num = 20;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
						{
							num = 35;
						}
						break;
					case 42:
						ClearObjectParams.AddLog((string)iFk8e4iDvqvjRP1aAur(inYRs1itej7QwEaN62a(0x3C1FFB55 ^ 0x3C1ED773), text2));
						num = 67;
						break;
					case 19:
						ClearObjectParams.SqlQuery((string)P4gdvbiWbaKa36dZQ9U(inYRs1itej7QwEaN62a(-1214182792 ^ -1214238372), text4, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), entityMetadata6.TableName), ((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-1498811449 ^ -1498827455))), string.Format((string)XmwnLUiPYfcEhPq8joV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790141052))));
						num = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
						{
							num = 15;
						}
						break;
					case 28:
					case 72:
						if (!endClear.ContainsKey(unitUid.ToString()))
						{
							num2 = 60;
							goto IL_003d;
						}
						goto case 34;
					case 76:
					{
						Func<UnitNullConfig, string, bool, int, bool, bool> deleteEntityMetadataUnit3 = ClearObjectParams.DeleteEntityMetadataUnit;
						UnitNullConfig unitNullConfig3 = new UnitNullConfig();
						Plu51uiINd2sfSJvRf8(unitNullConfig3, InterfaceActivator.UID<IQuestion>(loadImplementation: false));
						deleteEntityMetadataUnit3(unitNullConfig3, (string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(0x46EA3D1 ^ 0x46F99C9), new object[6]
						{
							ClearObjectParams.Transform.Dialect.QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-43932417 ^ -43916679)),
							tempTableName,
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x56A753C9 ^ 0x56A79A07)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x423024A4)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-885093259 ^ -885016125)),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(0x37F755F5 ^ 0x37F6603D))
						}), arg3: false, 0, arg5: false);
						num = 45;
						break;
					}
					case 30:
						entityMetadata12 = (EntityMetadata)InterfaceActivator.LoadMetadata<ITaskBasePermission>(inherit: true, loadImplementation: false);
						num = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
						{
							num = 5;
						}
						break;
					case 43:
						ClearObjectParams.SqlQuery((string)sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(-801808857 ^ -801871543), text4, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-197778752 ^ -197761978))), string.Format(SR.T((string)inYRs1itej7QwEaN62a(-1600060848 ^ -1600113164))));
						num = 52;
						break;
					case 3:
						text4 = (string)PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(--296112178 ^ 0x11A76770));
						num = 24;
						break;
					case 48:
						if (processHeader == null)
						{
							num = 20;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
							{
								num = 29;
							}
							break;
						}
						goto case 20;
					case 46:
					{
						Func<UnitNullConfig, string, bool, int, bool, bool> deleteEntityMetadataUnit = ClearObjectParams.DeleteEntityMetadataUnit;
						UnitNullConfig unitNullConfig = new UnitNullConfig();
						Plu51uiINd2sfSJvRf8(unitNullConfig, InterfaceActivator.UID<IWorkflowBookmark>(loadImplementation: false));
						deleteEntityMetadataUnit(unitNullConfig, text, arg3: false, 0, arg5: false);
						num = 27;
						break;
					}
					case 16:
						enumerator = ((IEnumerable<IProcessHeader>)processHeader.SubHeaders).GetEnumerator();
						num = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
						{
							num = 7;
						}
						break;
					case 27:
						entityMetadata10 = (EntityMetadata)InterfaceActivator.LoadMetadata<ITerminateExternalSubProcessShelulerJob>(inherit: true, loadImplementation: false);
						num = 55;
						break;
					case 29:
						ClearObjectParams.AddLog(string.Format((string)XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(0x51EF0063 ^ 0x51EE2A2B)), unitUid, unitName));
						num = 41;
						break;
					case 36:
						text = (string)sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(-17847711 ^ -17916725), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(--1436248540 ^ 0x559B2F5A)), tempTableName);
						num = 44;
						break;
					case 45:
						ClearObjectParams.SqlQuery((string)P4gdvbiWbaKa36dZQ9U(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x22688616), text4, PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, entityMetadata6.TableName), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(--296112178 ^ 0x11A616B4))), (string)UU9ARticveoVt1x7E0K(XmwnLUiPYfcEhPq8joV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431945138)), Array.Empty<object>()));
						num = 22;
						break;
					case 78:
						ClearObjectParams.ExecuteQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-197778752 ^ -197716316), new object[6]
						{
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(0x157D5AF4 ^ 0x157D1C72)),
							tempTableName,
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-29981480 ^ -29995754)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x65B7F624 ^ 0x65B6C3B8)),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949665403)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x34EA50D4 ^ 0x34EB651C))
						}), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(-10408775 ^ -10479269)), text2));
						num = 30;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
						{
							num = 5;
						}
						break;
					case 14:
						entityMetadata7 = (EntityMetadata)InterfaceActivator.LoadMetadata<IWorkflowQueueItem>(inherit: true, loadImplementation: false);
						num = 80;
						break;
					case 8:
						try
						{
							while (true)
							{
								IL_0ab7:
								int num5;
								if (!lEXtx9igwepfRBJ0slh(enumerator))
								{
									num5 = 7;
									goto IL_09f5;
								}
								goto IL_0a57;
								IL_09f5:
								while (true)
								{
									object obj;
									int num6;
									switch (num5)
									{
									case 1:
										deleteProcess(aXFdIji0sdRAeHLsOCY(current2), (string)FMaicYiVx7PWw8Wom7H(current2), condition);
										num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
										{
											num5 = 0;
										}
										continue;
									case 5:
										break;
									default:
										timeSpan = knbyQ4iTtRXIt3RGaG0(DateTime.Now, dateTime);
										num5 = 8;
										continue;
									case 9:
										if (fQgbFniq9F2RVRatYBl(Condition) > 2)
										{
											num5 = 4;
											continue;
										}
										goto case 3;
									case 6:
										goto IL_0ab7;
									case 2:
										dateTime = P2tdYqiRve5tqi0J6tE();
										num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
										{
											num5 = 1;
										}
										continue;
									case 3:
										obj = "";
										goto IL_0c5d;
									case 8:
										ClearObjectParams.AddLog((string)P2vUKcipcOr8wHtTSy8(inYRs1itej7QwEaN62a(0x3C1FFB55 ^ 0x3C1ED0FF), new object[2]
										{
											timeSpan,
											FMaicYiVx7PWw8Wom7H(current2)
										}));
										num5 = 6;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
										{
											num5 = 5;
										}
										continue;
									case 4:
										obj = UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-683713632 ^ -683773824), new object[5]
										{
											Condition,
											((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-1965291699 ^ -1965216735)),
											PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E937DF)),
											PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(-1776305410 ^ -1776295340)),
											rk69jWilp4i49orp2ax(Condition, string.Empty) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF7DA7E), Condition, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56A753C9 ^ 0x56A7154F))) : ""
										});
										goto IL_0c5d;
									case 7:
										goto end_IL_0ab7;
										IL_0c5d:
										condition = (string)obj;
										num6 = 2;
										num5 = num6;
										continue;
									}
									break;
								}
								goto IL_0a57;
								IL_0a57:
								current2 = enumerator.Current;
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
								{
									num5 = 9;
								}
								goto IL_09f5;
								continue;
								end_IL_0ab7:
								break;
							}
						}
						finally
						{
							int num7;
							if (enumerator == null)
							{
								num7 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
								{
									num7 = 0;
								}
								goto IL_0c97;
							}
							goto IL_0ccc;
							IL_0ccc:
							K1mXiMiBUH4f49vgMuD(enumerator);
							num7 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
							{
								num7 = 2;
							}
							goto IL_0c97;
							IL_0c97:
							switch (num7)
							{
							default:
								goto end_IL_0c72;
							case 0:
								goto end_IL_0c72;
							case 1:
								break;
							case 2:
								goto end_IL_0c72;
							}
							goto IL_0ccc;
							end_IL_0c72:;
						}
						goto case 71;
					case 73:
						if (KasoOfiGpYq9rsmvRQy(riAs1RiAdYhlN5kfvUG(jnnRRTikRcHymckiTOG(processHeader))) != null)
						{
							num = 61;
							break;
						}
						goto case 9;
					case 83:
						deleteTablePart(processContext.TableParts, text5);
						num = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
						{
							num = 0;
						}
						break;
					case 35:
						enumerator2 = processContext.Properties.GetEnumerator();
						num = 17;
						break;
					case 47:
						ClearObjectParams.SqlQuery((string)CSNQ6QiU6QssGtPcmaV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x438B2209), PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, KasoOfiGpYq9rsmvRQy(FZPSq7i7mhnjBcomocp(jnnRRTikRcHymckiTOG(processHeader))))), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B43467)), text2));
						num = 26;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
						{
							num = 20;
						}
						break;
					case 64:
						entityMetadata9 = (EntityMetadata)InterfaceActivator.LoadMetadata<IWorkflowSwimlaneExecutor>(inherit: true, loadImplementation: false);
						num2 = 7;
						goto IL_003d;
					case 6:
						ClearObjectParams.AddLog((string)CSNQ6QiU6QssGtPcmaV(inYRs1itej7QwEaN62a(-29981480 ^ -29905292), processHeader.Name));
						num = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
						{
							num = 2;
						}
						break;
					case 82:
						entityMetadata8 = (EntityMetadata)InterfaceActivator.LoadMetadata<IWorkflowTrackingItem>(inherit: true, loadImplementation: false);
						num = 25;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
						{
							num = 23;
						}
						break;
					case 71:
						text2 = (string)FMaicYiVx7PWw8Wom7H(processHeader);
						num = 42;
						break;
					case 66:
						deleteHistory((string)KasoOfiGpYq9rsmvRQy(entityMetadata), text, InterfaceActivator.UID<IWorkflowInstance>(loadImplementation: false));
						num = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
						{
							num = 5;
						}
						break;
					case 40:
					{
						Func<UnitNullConfig, string, bool, int, bool, bool> deleteEntityMetadataUnit2 = ClearObjectParams.DeleteEntityMetadataUnit;
						UnitNullConfig unitNullConfig2 = new UnitNullConfig();
						Plu51uiINd2sfSJvRf8(unitNullConfig2, InterfaceActivator.UID<IWorkflowTask>(loadImplementation: false));
						deleteEntityMetadataUnit2(unitNullConfig2, text, arg3: false, 0, arg5: false);
						num = 76;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
						{
							num = 2;
						}
						break;
					}
					case 7:
						entityMetadata2 = (EntityMetadata)InterfaceActivator.LoadMetadata<IWorkflowProcess>(inherit: true, loadImplementation: false);
						num = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
						{
							num = 5;
						}
						break;
					case 59:
						ClearObjectParams.SqlQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-1386448964 ^ -1386397968), new object[5]
						{
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-261315199 ^ -261307015)),
							text3,
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), entityMetadata6.TableName),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46EE557)),
							text4
						}), string.Format((string)XmwnLUiPYfcEhPq8joV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763751527)), text2));
						num = 63;
						break;
					case 26:
					case 50:
						context = processHeader.Context;
						num = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
						{
							num = 3;
						}
						break;
					case 79:
						ClearObjectParams.CheckAndDeleteCildMetadate(processContext);
						num = 37;
						break;
					case 39:
						ClearObjectParams.SqlQuery((string)CSNQ6QiU6QssGtPcmaV(inYRs1itej7QwEaN62a(--1418337216 ^ 0x548B527C), text3), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7381F16B ^ 0x7380B8BF)), text2));
						num = 19;
						break;
					case 22:
						ClearObjectParams.SqlQuery((string)CSNQ6QiU6QssGtPcmaV(inYRs1itej7QwEaN62a(--727842433 ^ 0x2B60C55B), text4), (string)UU9ARticveoVt1x7E0K(XmwnLUiPYfcEhPq8joV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC73204)), Array.Empty<object>()));
						num = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
						{
							num = 1;
						}
						break;
					case 17:
						try
						{
							while (true)
							{
								IL_1225:
								int num3;
								if (!enumerator2.MoveNext())
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
									{
										num3 = 1;
									}
									goto IL_1139;
								}
								goto IL_11b8;
								IL_11b8:
								current = enumerator2.Current;
								num3 = 2;
								goto IL_1139;
								IL_1139:
								while (true)
								{
									switch (num3)
									{
									case 7:
									case 8:
									case 11:
										if (STODUvis77NruotHRlv(LkRtcxiFDRqOASgFdIo(current), InterfaceActivator.UID<IAttachment>(loadImplementation: false)))
										{
											num3 = 10;
											continue;
										}
										goto default;
									case 2:
										if (!(YlTP1Ci8h96Idl0k2G6(current) == BinaryFileDescriptor.UID))
										{
											num3 = 7;
											continue;
										}
										goto case 3;
									case 4:
										break;
									case 3:
										if (!(current.Settings is SimpleTypeSettings))
										{
											num3 = 8;
											continue;
										}
										goto case 5;
									case 10:
										if (Jj6KmBiigJfB7eik6cL(z8nAsyi2sBoPHWDIrtF(current) as EntitySettings) != 0)
										{
											num3 = 9;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
											{
												num3 = 7;
											}
											continue;
										}
										goto case 6;
									case 12:
										goto IL_1225;
									case 5:
										ClearObjectParams.ExecuteQuery(string.Format((string)inYRs1itej7QwEaN62a(-539998957 ^ -539923991), TempTableNameFileDel, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x42311138 ^ 0x423157BE)), inYRs1itej7QwEaN62a(--601115071 ^ 0x23D40FC3), ((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)YVsakiiJewIGgaE2csa((SimpleTypeSettings)z8nAsyi2sBoPHWDIrtF(current))), PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, KasoOfiGpYq9rsmvRQy(processContext)), (Condition != string.Empty) ? sZ3UaginZZw3223o7vZ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431940606), Condition, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x1AF6F1F2 ^ 0x1AF6A958))) : "", TempTableFreeFile, ((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-45832783 ^ -45773897)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x5DB28AD2 ^ 0x5DB2EF68)), i1WqtUio7VS9WwoiLgm(processContext), i1WqtUio7VS9WwoiLgm(current)), (string)XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(0x75BAD659 ^ 0x75BBF847)));
										num3 = 11;
										continue;
									case 6:
										ClearObjectParams.ExecuteQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-768800937 ^ -768857641), new object[15]
										{
											TempTableNameFileDel,
											((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-261315199 ^ -261299449)),
											inYRs1itej7QwEaN62a(0x4940763B ^ 0x494030BD),
											((SimpleTypeSettings)z8nAsyi2sBoPHWDIrtF(current)).FieldName,
											PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(processContext)),
											rk69jWilp4i49orp2ax(Condition, string.Empty) ? sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(0x6A69C5CD ^ 0x6A68E811), Condition, ((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125907246))) : "",
											TempTableFreeFile,
											PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x157D5AF4 ^ 0x157C7C10)),
											((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-865213812 ^ -865229584)),
											PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x69063C81 ^ 0x69071333)),
											PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -682969754)),
											PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(-790221436 ^ -790214594)),
											i1WqtUio7VS9WwoiLgm(processContext),
											i1WqtUio7VS9WwoiLgm(current),
											PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-2122743969 ^ -2122821483))
										}), (string)XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(0x56F860D7 ^ 0x56F94F37)));
										num3 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
										{
											num3 = 0;
										}
										continue;
									default:
										ClearRelationTable(current, (string)((Condition != string.Empty) ? UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(0x5DB28AD2 ^ 0x5DB3BA94), new object[4]
										{
											Condition,
											PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(--296112178 ^ 0x11A60898)),
											PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(0x6C7F14 ^ 0x6C3992)),
											PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(context))
										}) : ""));
										num3 = 12;
										continue;
									case 1:
										goto end_IL_1225;
									}
									break;
								}
								goto IL_11b8;
								continue;
								end_IL_1225:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator2).Dispose();
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						goto case 79;
					case 58:
					case 60:
						if (processHeader.SubHeaders != null)
						{
							num = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
							{
								num = 16;
							}
							break;
						}
						goto case 71;
					case 1:
						ClearObjectParams.ExecuteQuery((string)CSNQ6QiU6QssGtPcmaV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD316EB8), tempTableName), (string)XmwnLUiPYfcEhPq8joV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x100ED4F)));
						num = 77;
						break;
					case 67:
						if (riAs1RiAdYhlN5kfvUG(processHeader.Published) == null)
						{
							num2 = 32;
							goto IL_003d;
						}
						goto case 73;
					case 5:
						if (KasoOfiGpYq9rsmvRQy(FZPSq7i7mhnjBcomocp(jnnRRTikRcHymckiTOG(processHeader))) != null)
						{
							num = 47;
							break;
						}
						goto case 26;
					case 20:
						if (jnnRRTikRcHymckiTOG(processHeader) != null)
						{
							num2 = 72;
							goto IL_003d;
						}
						goto case 6;
					case 38:
						entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IWorkflowInstance>(inherit: true, loadImplementation: false);
						num = 64;
						break;
					case 69:
						ClearObjectParams.ExecuteQuery(string.Format((string)inYRs1itej7QwEaN62a(-148495695 ^ -148434741), tempTableName), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(0x5F534A5C ^ 0x5F520F1C)), text2));
						num = 33;
						break;
					case 33:
						entityMetadata5 = (EntityMetadata)InterfaceActivator.LoadMetadata<IWorkflowInstanceState>(inherit: true, loadImplementation: false);
						num = 14;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
						{
							num = 31;
						}
						break;
					case 44:
						ClearObjectParams.SqlQuery((string)UU9ARticveoVt1x7E0K(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772546164), new object[4]
						{
							text,
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, KasoOfiGpYq9rsmvRQy(entityMetadata4)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1600034710)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D68F95))
						}), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x4942D4CA)), text2));
						num = 68;
						break;
					case 56:
						entityMetadata3 = (EntityMetadata)InterfaceActivator.LoadMetadata<IEntityActionHistory>(inherit: true, loadImplementation: false);
						num = 81;
						break;
					case 81:
						ClearObjectParams.SqlQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(0x6CC04061 ^ 0x6CC178ED), new object[9]
						{
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata3)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), entityMetadata4.TableName),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--296112178 ^ 0x11A616B4)),
							"",
							text,
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -29901456)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x2269BD32 ^ 0x22688884)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-1776305410 ^ -1776385228)),
							tempTableHistory
						}), (string)XmwnLUiPYfcEhPq8joV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45769637)));
						num = 40;
						break;
					case 70:
						ClearObjectParams.SqlQuery((string)P4gdvbiWbaKa36dZQ9U(inYRs1itej7QwEaN62a(0x6CC04061 ^ 0x6CC10B63), tempTableName, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1214182792 ^ -1214165762)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata5))), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(-708128192 ^ -708077268)), text2));
						num = 21;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
						{
							num = 21;
						}
						break;
					case 34:
						ClearObjectParams.AddLog((string)CSNQ6QiU6QssGtPcmaV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949657895), FMaicYiVx7PWw8Wom7H(processHeader)));
						num = 62;
						break;
					case 10:
					{
						Func<UnitNullConfig, string, bool, int, bool, bool> deleteEntityMetadataUnit4 = ClearObjectParams.DeleteEntityMetadataUnit;
						UnitNullConfig unitNullConfig4 = new UnitNullConfig();
						Plu51uiINd2sfSJvRf8(unitNullConfig4, InterfaceActivator.UID<IWorkflowInstance>(loadImplementation: false));
						deleteEntityMetadataUnit4(unitNullConfig4, text, arg3: false, 0, arg5: false);
						num = 70;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
						{
							num = 23;
						}
						break;
					}
					default:
						ClearObjectParams.DeleteEntityMetadata(context, text5, arg3: false, 0, arg5: false);
						num = 74;
						break;
					case 68:
						text4 = (string)PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x12F686A ^ 0x12E5F28));
						num = 43;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
						{
							num = 22;
						}
						break;
					case 77:
						ClearObjectParams.SqlQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-1361036319 ^ -1360984221), new object[7]
						{
							processHeader.Id,
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata2)),
							ClearObjectParams.Transform.Dialect.QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-1776305410 ^ -1776384032)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x614CF569 ^ 0x614CAB51)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F800F5B ^ 0x5F8049DD)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x51EF0063 ^ 0x51EF68F5))
						}), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077836410)), text2));
						num2 = 51;
						goto IL_003d;
					case 75:
						ClearObjectParams.SqlQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(0x63D6C913 ^ 0x63D7FEF9), new object[7]
						{
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, KasoOfiGpYq9rsmvRQy(entityMetadata6)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(0x74AB4717 ^ 0x74AB0191)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-1712492721 ^ -1712517193)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(0x1927DA93 ^ 0x1926E2F7)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-261315199 ^ -261251839)),
							text,
							text4
						}), "");
						num = 56;
						break;
					case 52:
						entityMetadata6 = (EntityMetadata)InterfaceActivator.LoadMetadata<IComment>(inherit: true, loadImplementation: false);
						num = 75;
						break;
					case 18:
						ClearObjectParams.ExecuteQuery(string.Format((string)inYRs1itej7QwEaN62a(-1776305410 ^ -1776383868), tempTableName), string.Format(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10478041)), text2));
						num = 2;
						break;
					case 2:
						entityMetadata11 = (EntityMetadata)InterfaceActivator.LoadMetadata<IWorkflowBookmark>(inherit: true, loadImplementation: false);
						num = 23;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
						{
							num = 14;
						}
						break;
					case 24:
						ClearObjectParams.SqlQuery((string)sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(-420003255 ^ -420055769), text4, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122761767))), (string)UU9ARticveoVt1x7E0K(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A68F269)), Array.Empty<object>()));
						num = 59;
						break;
					case 23:
						entityMetadata4 = (EntityMetadata)InterfaceActivator.LoadMetadata<ITaskBase>(inherit: true, loadImplementation: false);
						num2 = 38;
						goto IL_003d;
					case 9:
					case 32:
						if (FZPSq7i7mhnjBcomocp(jnnRRTikRcHymckiTOG(processHeader)) == null)
						{
							num = 50;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
							{
								num = 27;
							}
							break;
						}
						goto case 5;
					case 63:
						deleteHistory((string)PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, KasoOfiGpYq9rsmvRQy(entityMetadata6)), text, InterfaceActivator.UID<IComment>(loadImplementation: false));
						num = 33;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
						{
							num = 39;
						}
						break;
					case 37:
						text5 = (string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-1600060848 ^ -1600113980), new object[10]
						{
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded(((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)KasoOfiGpYq9rsmvRQy(context))),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-790221436 ^ -790203090)),
							ClearObjectParams.Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614274E3 ^ 0x61423265)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542172240)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642733691)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(0x37F755F5 ^ 0x37F712F1)),
							processHeader.Id,
							(Condition != string.Empty) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614274E3 ^ 0x61434595), Condition, PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(0x69063C81 ^ 0x69067A07))) : "",
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x3C1FFB55 ^ 0x3C1FBDE5)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x2269BD32 ^ 0x2269D5A4))
						});
						num = 83;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
						{
							num = 9;
						}
						break;
					case 74:
						ClearObjectParams.SqlQuery(string.Format((string)inYRs1itej7QwEaN62a(-29981480 ^ -29903550), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -43956419)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x6871CA ^ 0x68614E)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x19279C15)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x19278239)), PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(0x4943E3E4 ^ 0x4943BDDC)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x56A753C9 ^ 0x56A714CD)), processHeader.Id, rk69jWilp4i49orp2ax(Condition, string.Empty) ? sZ3UaginZZw3223o7vZ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772544980), Condition, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EF46E5))) : "", PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD303454))), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(-683713632 ^ -683775538)), text2));
						num2 = 18;
						goto IL_003d;
					case 12:
						ClearObjectParams.ExecuteQuery(string.Format((string)inYRs1itej7QwEaN62a(0x614274E3 ^ 0x61434609), tempTableName, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata11)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata4)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata)), ((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)KasoOfiGpYq9rsmvRQy(entityMetadata2)), PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(0x4940763B ^ 0x494030BD)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x56A753C9 ^ 0x56A739F3)), processHeader.Id, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-862330810 ^ -862339458)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-1539486135 ^ -1539481907)), ((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(0x75BAD659 ^ 0x75BABECF)), (Condition != string.Empty) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772545668), Condition, PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135692152))) : ""), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(0x46EA3D1 ^ 0x46F9781)), text2));
						num = 78;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
						{
							num = 75;
						}
						break;
					case 51:
						ClearObjectParams.SqlQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-642713667 ^ -642659623), new object[9]
						{
							processHeader.Id,
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), entityMetadata11.TableName),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata)),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, KasoOfiGpYq9rsmvRQy(entityMetadata2)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657578335)),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A69834B)),
							ClearObjectParams.Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF6AFCA)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x1AF6F1F2 ^ 0x1AF69964)),
							rk69jWilp4i49orp2ax(Condition, string.Empty) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935235537), Condition, PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(0x747FFBE0 ^ 0x747FBD66))) : ""
						}), (string)inYRs1itej7QwEaN62a(-684210684 ^ -684263348));
						num2 = 65;
						goto IL_003d;
					case 65:
						ClearObjectParams.SqlQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-949717965 ^ -949663129), new object[9]
						{
							processHeader.Id,
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded(entityMetadata11.TableName),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), entityMetadata2.TableName),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-642713667 ^ -642717895)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x1927DA93 ^ 0x19279C15)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-29981480 ^ -29959456)),
							ClearObjectParams.Transform.Dialect.QuoteIfNeeded((string)inYRs1itej7QwEaN62a(0x614CF569 ^ 0x614C9DFF)),
							(Condition != string.Empty) ? sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(-148495695 ^ -148431459), Condition, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-1895853023 ^ -1895837017))) : ""
						}), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(-197778752 ^ -197714530)), text2));
						num = 54;
						break;
					case 54:
						text = (string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-1647793954 ^ -1647732884), new object[9]
						{
							processHeader.Id,
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata11)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata)),
							ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata2.TableName),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(-135674354 ^ -135670134)),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F08324)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x42311138 ^ 0x42314F00)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548A7356)),
							(Condition != string.Empty) ? string.Format((string)inYRs1itej7QwEaN62a(-1050383744 ^ -1050323540), Condition, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x101D10F ^ 0x1019789))) : ""
						});
						num = 20;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
						{
							num = 46;
						}
						break;
					case 55:
						ClearObjectParams.SqlQuery((string)UU9ARticveoVt1x7E0K(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614DB5F3), new object[11]
						{
							processHeader.Id,
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata10)),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, KasoOfiGpYq9rsmvRQy(entityMetadata11)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded(entityMetadata.TableName),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, KasoOfiGpYq9rsmvRQy(entityMetadata2)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-772614310 ^ -772620960)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-1001967776 ^ -1001952794)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x747FFBE0 ^ 0x747FEB64)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-667465279 ^ -667478023)),
							rk69jWilp4i49orp2ax(Condition, string.Empty) ? sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(-949717965 ^ -949662945), Condition, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-768800937 ^ -768785967))) : "",
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x6871CA ^ 0x68195C))
						}), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(0x6871CA ^ 0x693060)), text2));
						num = 57;
						break;
					case 57:
						ClearObjectParams.SqlQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(0x75BAD659 ^ 0x75BB9411), new object[9]
						{
							processHeader.Id,
							ClearObjectParams.Transform.Dialect.QuoteIfNeeded((string)KasoOfiGpYq9rsmvRQy(entityMetadata9)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)KasoOfiGpYq9rsmvRQy(entityMetadata)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata2)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-29981480 ^ -29959054)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D68F95)),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708146056)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D42129)),
							rk69jWilp4i49orp2ax(Condition, string.Empty) ? string.Format((string)inYRs1itej7QwEaN62a(-1001967776 ^ -1002037738), Condition, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x438A0E43 ^ 0x438A48C5))) : ""
						}), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(0x101D10F ^ 0x1009213)), text2));
						num = 55;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
						{
							num = 82;
						}
						break;
					case 25:
						ClearObjectParams.SqlQuery(string.Format((string)inYRs1itej7QwEaN62a(0x56F860D7 ^ 0x56F92395), processHeader.Id, ClearObjectParams.Transform.Dialect.QuoteIfNeeded((string)KasoOfiGpYq9rsmvRQy(entityMetadata8)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata)), PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, entityMetadata2.TableName), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x11349446)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x747FFBE0 ^ 0x747FEB64)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x1927DA93 ^ 0x192784AB)), PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(-22348816 ^ -22375578)), (Condition != string.Empty) ? sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(0x1C7F6FED ^ 0x1C7E5E9B), Condition, ClearObjectParams.Transform.Dialect.QuoteIfNeeded((string)inYRs1itej7QwEaN62a(0xB7793C9 ^ 0xB77D54F))) : ""), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(0x628167BE ^ 0x628023A8)), text2));
						num = 14;
						break;
					case 80:
						ClearObjectParams.SqlQuery((string)UU9ARticveoVt1x7E0K(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F186E0), new object[9]
						{
							processHeader.Id,
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, KasoOfiGpYq9rsmvRQy(entityMetadata7)),
							ClearObjectParams.Transform.Dialect.QuoteIfNeeded(entityMetadata.TableName),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)KasoOfiGpYq9rsmvRQy(entityMetadata2)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(--1436248540 ^ 0x559B2F5A)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548A0B44)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-135674354 ^ -135686090)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-360662087 ^ -360656081)),
							(Condition != string.Empty) ? sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(0x75BAD659 ^ 0x75BBE72F), Condition, ClearObjectParams.Transform.Dialect.QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-43932417 ^ -43916679))) : ""
						}), (string)CSNQ6QiU6QssGtPcmaV(SR.T((string)inYRs1itej7QwEaN62a(-1498811449 ^ -1498892435)), text2));
						num = 69;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
						{
							num = 37;
						}
						break;
					case 31:
						ClearObjectParams.ExecuteQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-1028861977 ^ -1028814229), new object[10]
						{
							processHeader.Id,
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata5)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), entityMetadata.TableName),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata2)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x1843E01F ^ 0x184388B9)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x8D5763A ^ 0x8D530BC)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x157D5AF4 ^ 0x157D04CC)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-935313063 ^ -935319089)),
							rk69jWilp4i49orp2ax(Condition, string.Empty) ? sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(0xD305CC2 ^ 0xD316DB4), Condition, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-39189604 ^ -39172838))) : "",
							tempTableName
						}), (string)CSNQ6QiU6QssGtPcmaV(XmwnLUiPYfcEhPq8joV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1303601216 ^ -1303520940)), text2));
						num = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
						{
							num = 53;
						}
						break;
					case 53:
						ClearObjectParams.SqlQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-452127399 ^ -452177189), new object[8]
						{
							processHeader.Id,
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x37F755F5 ^ 0x37F71373)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata2)),
							ClearObjectParams.Transform.Dialect.QuoteIfNeeded((string)KasoOfiGpYq9rsmvRQy(entityMetadata)),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(-2122743969 ^ -2122820557)),
							PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x1145E0EF)),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F73D63)),
							rk69jWilp4i49orp2ax(Condition, string.Empty) ? sZ3UaginZZw3223o7vZ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862400208), Condition, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F08324))) : ""
						}), (string)CSNQ6QiU6QssGtPcmaV(SR.T((string)inYRs1itej7QwEaN62a(0x738ABA6E ^ 0x738BF248)), text2));
						num = 49;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
						{
							num = 34;
						}
						break;
					case 49:
						text3 = (string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-1600060848 ^ -1600108032), new object[9]
						{
							processHeader.Id,
							ClearObjectParams.Transform.Dialect.QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-683713632 ^ -683797832)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)KasoOfiGpYq9rsmvRQy(entityMetadata)),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, KasoOfiGpYq9rsmvRQy(entityMetadata2)),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651FBA37)),
							PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(-1638225214 ^ -1638208444)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(0x2F44D93A ^ 0x2F448702)),
							((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-961162596 ^ -961168886)),
							rk69jWilp4i49orp2ax(Condition, string.Empty) ? sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(0x738ABA6E ^ 0x738B8B18), Condition, PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(--601115071 ^ 0x23D40F39))) : ""
						});
						num = 3;
						break;
					case 84:
						{
							text = string.Format((string)inYRs1itej7QwEaN62a(-1001967776 ^ -1002019578), processHeader.Id, ((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)KasoOfiGpYq9rsmvRQy(entityMetadata)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata2)), PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(0x6A69C5CD ^ 0x6A69834B)), ((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-351369538 ^ -351348602)), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(-2111219045 ^ -2111229427)), rk69jWilp4i49orp2ax(Condition, string.Empty) ? sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(-2002063381 ^ -2002002275), Condition, ClearObjectParams.Transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--727842433 ^ 0x2B61B807))) : "");
							num = 66;
							break;
						}
						IL_003d:
						num = num2;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				int num8 = 2;
				string text6 = default(string);
				while (true)
				{
					switch (num8)
					{
					case 1:
						return;
					default:
						((ILogger)Q1G8MJiaU6ldlKSVCx7()).Error(text6, ex);
						num8 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
						{
							num8 = 0;
						}
						break;
					case 2:
						text6 = (string)P4gdvbiWbaKa36dZQ9U(SR.T((string)inYRs1itej7QwEaN62a(0x438A0E43 ^ 0x438B4259)), unitUid, unitName, ex);
						num8 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
						{
							num8 = 3;
						}
						break;
					case 3:
						ClearObjectParams.AddLog(text6);
						num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
						{
							num8 = 0;
						}
						break;
					}
				}
			}
		}
	}

	private void deleteHistory(string tableName, string sql, Guid typeGuid)
	{
		int num = 1;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IEntityActionHistory>(inherit: true, loadImplementation: false);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ClearObjectParams.SqlQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(0x1134D2C0 ^ 0x11359E50), new object[9]
			{
				PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), KasoOfiGpYq9rsmvRQy(entityMetadata)),
				tableName,
				PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x56A753C9 ^ 0x56A7154F)),
				"",
				sql,
				PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x5BCD23A0 ^ 0x5BCC1A08)),
				CSNQ6QiU6QssGtPcmaV(inYRs1itej7QwEaN62a(0x2F44D93A ^ 0x2F459494), typeGuid),
				PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x17F0C5A2 ^ 0x17F1FC68)),
				tempTableHistory
			}), (string)XmwnLUiPYfcEhPq8joV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498890629)));
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
			{
				num2 = 1;
			}
		}
	}

	private ProcessContext LoadFullContext(long processHeadId)
	{
		int num = 3;
		int num2 = num;
		ProcessContext processContext = default(ProcessContext);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return new ProcessContext();
			case 2:
				if (processContext != null)
				{
					CopyTableParts(processContext);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
					{
						num2 = 1;
					}
				}
				break;
			default:
				return processContext;
			case 3:
				processContext = (ProcessContext)TwDttwiYt2jvZnw1IRV(ProcessHeaderManager.Instance.Load(processHeadId));
				num2 = 2;
				break;
			}
		}
	}

	private void CopyTableParts(EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_00cf, IL_00de, IL_00e9, IL_019e, IL_01b1
		int num = 2;
		int num2 = num;
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			case 5:
				O1nbeZie2jHJ0yKNlO1(metadata.TableParts);
				num2 = 6;
				continue;
			case 4:
				return;
			case 2:
				LdufBrirjAurO8kpXGf(metadata.Properties);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				metadata.TableParts.AddRange((IEnumerable<TablePartMetadata>)metadata.EntityTableParts);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				metadata.Properties.AddRange((IEnumerable<PropertyMetadata>)metadata.EntityProperties);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
				{
					num2 = 4;
				}
				continue;
			case 3:
				enumerator = metadata.TableParts.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_014c:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
						{
							num3 = 0;
						}
						goto IL_00ed;
					}
					goto IL_0107;
					IL_0107:
					current = enumerator.Current;
					num3 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
					{
						num3 = 1;
					}
					goto IL_00ed;
					IL_00ed:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 3:
							break;
						case 1:
							CopyTableParts(current);
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							goto IL_014c;
						}
						break;
					}
					goto IL_0107;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num4 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	private void ClearRelationTable(PropertyMetadata pm, string additionalCondition, bool parent = true)
	{
		//Discarded unreachable code: IL_0083, IL_0256, IL_0265, IL_02fe, IL_0499, IL_04a3
		int num = 12;
		int num2 = num;
		EntitySettings entitySettings = default(EntitySettings);
		string text2 = default(string);
		string text3 = default(string);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		string text = default(string);
		while (true)
		{
			object obj;
			string text4;
			switch (num2)
			{
			case 13:
				if (entitySettings != null)
				{
					num2 = 16;
					continue;
				}
				return;
			case 14:
				obj = "";
				break;
			case 15:
				ClearObjectParams.ExecuteQuery((string)UU9ARticveoVt1x7E0K(inYRs1itej7QwEaN62a(-420003255 ^ -420082489), new object[13]
				{
					TempTableNameFileDel,
					((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF404B7E)),
					TempTableFreeFile,
					PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548A5D46)),
					PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), rkoH2NihfYJX80XhCN7(entitySettings)),
					text2,
					text3,
					PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(-452127399 ^ -452185155)),
					PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x747FFBE0 ^ 0x747FBD9C)),
					PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), inYRs1itej7QwEaN62a(0x213F6477 ^ 0x213E4BC5)),
					((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)inYRs1itej7QwEaN62a(-790221436 ^ -790166654)),
					PS4hq0i5uk09Z9ixxk2(ClearObjectParams.Transform.Dialect, inYRs1itej7QwEaN62a(0x246EEF98 ^ 0x246E8A22)),
					i1WqtUio7VS9WwoiLgm(pm)
				}), (string)XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(0x614CF569 ^ 0x614DBAA9)));
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
				{
					num2 = 2;
				}
				continue;
			case 16:
				if (Jj6KmBiigJfB7eik6cL(entitySettings) != RelationType.ManyToManyInverse)
				{
					num2 = 9;
					continue;
				}
				goto case 7;
			case 6:
				if (!(pm.SubTypeUid == InterfaceActivator.UID<IAttachment>(loadImplementation: false)))
				{
					num2 = 17;
					continue;
				}
				goto case 4;
			case 1:
				if (!string.IsNullOrEmpty((string)aEM8jdiNIntnfFxwAKR(additionalCondition)))
				{
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
					{
						num2 = 18;
					}
					continue;
				}
				goto case 14;
			case 9:
				if (!parent)
				{
					num2 = 7;
					continue;
				}
				goto case 8;
			case 11:
				entitySettings = z8nAsyi2sBoPHWDIrtF(entityPropertyMetadata) as EntitySettings;
				num2 = 13;
				continue;
			case 10:
				text2 = ((Dialect)umOPggibMri9DUMFM3e(ClearObjectParams.Transform)).QuoteIfNeeded((string)Pb5Nbjixus1ocQerZJr(entityPropertyMetadata));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
				{
					num2 = 5;
				}
				continue;
			case 5:
				ClearObjectParams.AddLog((string)MYGc9diSvhKxxkE9BLG(new string[8]
				{
					(string)inYRs1itej7QwEaN62a(0x141C968 ^ 0x140875E),
					pm.Name,
					(string)inYRs1itej7QwEaN62a(0x157D5AF4 ^ 0x157C14B0),
					(string)YVsakiiJewIGgaE2csa(entitySettings),
					(string)inYRs1itej7QwEaN62a(-1214182792 ^ -1214233562),
					text2,
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614274E3 ^ 0x61433A8D),
					Jj6KmBiigJfB7eik6cL(entitySettings).ToString()
				}));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				if (entitySettings.RelationType == RelationType.ManyToMany)
				{
					num2 = 15;
					continue;
				}
				goto case 3;
			case 3:
				ClearObjectParams.SqlQuery(string.Format((string)inYRs1itej7QwEaN62a(-1393899982 ^ -1393846738), text2, text3), (string)XmwnLUiPYfcEhPq8joV(inYRs1itej7QwEaN62a(-1516552726 ^ -1516606036)));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
				{
					num2 = 2;
				}
				continue;
			case 12:
				entityPropertyMetadata = (EntityPropertyMetadata)pm;
				num2 = 11;
				continue;
			case 8:
				text4 = entitySettings.ParentColumnName;
				goto IL_04cb;
			case 17:
				return;
			default:
				if (!OhYi25i16bMQ1KSYG7q(text2))
				{
					num2 = 6;
					continue;
				}
				return;
			case 2:
				return;
			case 7:
				text4 = entitySettings.ChildColumnName;
				goto IL_04cb;
			case 18:
				{
					obj = sZ3UaginZZw3223o7vZ(inYRs1itej7QwEaN62a(0x1134D2C0 ^ 0x11359CCC), PS4hq0i5uk09Z9ixxk2(umOPggibMri9DUMFM3e(ClearObjectParams.Transform), text), additionalCondition);
					break;
				}
				IL_04cb:
				text = text4;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			text3 = (string)obj;
			num2 = 10;
		}
	}

	public NullifierActionsWorkflowExtension()
	{
		//Discarded unreachable code: IL_006a, IL_006f
		ja3FiiiE5sbZPG2uVrL();
		tempTableName = "";
		TempTableNameFileDel = "";
		tempTableHistory = "";
		TempTableFreeFile = "";
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object nwLSouivRQCCv5F0kNR()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static object TwDttwiYt2jvZnw1IRV(object P_0)
	{
		return ((IProcessHeader)P_0).Context;
	}

	internal static Guid YlTP1Ci8h96Idl0k2G6(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool STODUvis77NruotHRlv(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object YVsakiiJewIGgaE2csa(object P_0)
	{
		return ((SimpleTypeSettings)P_0).FieldName;
	}

	internal static bool rk69jWilp4i49orp2ax(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static Guid aXFdIji0sdRAeHLsOCY(object P_0)
	{
		return ((IProcessHeader)P_0).Uid;
	}

	internal static int WqOocKiynALQQp44LK2(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).TableNumber;
	}

	internal static object L0UJywim7K7frpAaDTW(object P_0, int P_1)
	{
		return EntityPropertyMetadata.GetTableName((string)P_0, P_1);
	}

	internal static object inYRs1itej7QwEaN62a(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object umOPggibMri9DUMFM3e(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object PS4hq0i5uk09Z9ixxk2(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static bool lEXtx9igwepfRBJ0slh(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void K1mXiMiBUH4f49vgMuD(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object UU9ARticveoVt1x7E0K(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object XmwnLUiPYfcEhPq8joV(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool wUyLugiOGs7V5MuKmLx()
	{
		return WYAs9ZiKvYoJ4BD9Xj6 == null;
	}

	internal static NullifierActionsWorkflowExtension robydQiZTZNvWVhCAPa()
	{
		return WYAs9ZiKvYoJ4BD9Xj6;
	}

	internal static Guid GSE4TviX5lWKUusmbe0(object P_0)
	{
		return ((UnitNullConfig)P_0).TypeUid;
	}

	internal static bool FgNkYfidVeXeFftensX(object P_0)
	{
		return ((UnitNullConfig)P_0).UseAdditionalParams;
	}

	internal static long IaYIS8iuRqDHkt3kVWo(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object iFk8e4iDvqvjRP1aAur(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object sZ3UaginZZw3223o7vZ(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object zEDxv8iHB294MxmKNts(object P_0)
	{
		return ((UnitNullConfigWorkflow)P_0).InstanceStatuses;
	}

	internal static bool WhxdfriLaLW1wxYxuAN(object P_0)
	{
		return ((UnitNullConfig)P_0).UseDateBetweenParams;
	}

	internal static bool dVg5gPifGKxcQ68njth(object P_0)
	{
		return ((UnitNullConfigWorkflow)P_0).CheckExactDateWorkflowInstance;
	}

	internal static object FwCjYZi9hhiYG3GMGXe(object P_0, DateTime P_1)
	{
		return ((Dialect)P_0).DateTimeToSql(P_1);
	}

	internal static object P4gdvbiWbaKa36dZQ9U(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static bool Se55PAij0ChsUMvusj4(object P_0)
	{
		return ((UnitNullConfigWorkflow)P_0).CheckRelativeDateWorkflowInstance;
	}

	internal static DateTime P2tdYqiRve5tqi0J6tE()
	{
		return DateTime.Now;
	}

	internal static object CvrvNWi6DgafWvkxP66(object P_0)
	{
		return ((UnitNullConfig)P_0).AdditionalSqlText;
	}

	internal static int fQgbFniq9F2RVRatYBl(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static Guid coTKT2i3pbth8vKeWLG(object P_0)
	{
		return ((UnitNullConfig)P_0).Uid;
	}

	internal static TimeSpan knbyQ4iTtRXIt3RGaG0(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static object kXtxDfiQyPfnsRMPONC(object P_0)
	{
		return ((UnitNullConfig)P_0).Name;
	}

	internal static object P2vUKcipcOr8wHtTSy8(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object PBjWmOiCOa3JdN1bqG3()
	{
		return MonitorCacheItemManager.Instance;
	}

	internal static void ok372JiM7WkE30rHSJ5(object P_0)
	{
		((MonitorCacheItemManager)P_0).RecreateCache();
	}

	internal static object jnnRRTikRcHymckiTOG(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static object CSNQ6QiU6QssGtPcmaV(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object FMaicYiVx7PWw8Wom7H(object P_0)
	{
		return ((IProcessHeader)P_0).Name;
	}

	internal static object riAs1RiAdYhlN5kfvUG(object P_0)
	{
		return ((IWorkflowProcess)P_0).ProcessMetrics;
	}

	internal static object KasoOfiGpYq9rsmvRQy(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static object FZPSq7i7mhnjBcomocp(object P_0)
	{
		return ((IWorkflowProcess)P_0).InstanceMetrics;
	}

	internal static object z8nAsyi2sBoPHWDIrtF(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object i1WqtUio7VS9WwoiLgm(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static Guid LkRtcxiFDRqOASgFdIo(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static RelationType Jj6KmBiigJfB7eik6cL(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static void Plu51uiINd2sfSJvRf8(object P_0, Guid P_1)
	{
		((UnitNullConfig)P_0).Uid = P_1;
	}

	internal static object Q1G8MJiaU6ldlKSVCx7()
	{
		return Logger.Log;
	}

	internal static void LdufBrirjAurO8kpXGf(object P_0)
	{
		((List<PropertyMetadata>)P_0).Clear();
	}

	internal static void O1nbeZie2jHJ0yKNlO1(object P_0)
	{
		((List<TablePartMetadata>)P_0).Clear();
	}

	internal static object aEM8jdiNIntnfFxwAKR(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object Pb5Nbjixus1ocQerZJr(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).RelationTableName;
	}

	internal static object MYGc9diSvhKxxkE9BLG(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static bool OhYi25i16bMQ1KSYG7q(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object rkoH2NihfYJX80XhCN7(object P_0)
	{
		return ((EntitySettings)P_0).ChildColumnName;
	}

	internal static void ja3FiiiE5sbZPG2uVrL()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}

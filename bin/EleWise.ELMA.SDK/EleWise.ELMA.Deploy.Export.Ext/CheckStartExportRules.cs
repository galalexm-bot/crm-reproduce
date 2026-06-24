using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints;

[Component(Type = ComponentType.Server)]
public class CheckStartExportRules : IInitHandler
{
	internal static CheckStartExportRules EG8IUTEUBhKsMMHiWie2;

	private void GenerateForInterface()
	{
		//Discarded unreachable code: IL_0079, IL_00d8, IL_0118, IL_0127, IL_0133, IL_015a, IL_0372, IL_0381, IL_03a8, IL_0444, IL_0453, IL_0746, IL_077e, IL_078d, IL_080e, IL_0846
		int num = 4;
		int num2 = num;
		StreamWriter streamWriter2 = default(StreamWriter);
		FileInfo fileInfo = default(FileInfo);
		IEnumerator<EntityMetadata> enumerator = default(IEnumerator<EntityMetadata>);
		int num3 = default(int);
		EntityMetadata current = default(EntityMetadata);
		string text = default(string);
		Type typeByUid2 = default(Type);
		Guid uid = default(Guid);
		IEntityManager entityManager = default(IEntityManager);
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		Type typeByUid = default(Type);
		StreamWriter streamWriter = default(StreamWriter);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		PropertyMetadata[] array = default(PropertyMetadata[]);
		int num6 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				streamWriter2 = fileInfo.AppendText();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				return;
			case 4:
				fileInfo = new FileInfo((string)TFYsFZEUbTDCT2YO6kRa());
				num2 = 3;
				continue;
			case 1:
				try
				{
					while (true)
					{
						IL_07bb:
						int num4;
						if (!enumerator.MoveNext())
						{
							num4 = 9;
							goto IL_0168;
						}
						goto IL_07d1;
						IL_0168:
						while (true)
						{
							switch (num4)
							{
							case 4:
								num3++;
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num4 = 1;
								}
								continue;
							case 12:
								break;
							case 5:
								if (current.IsSystem())
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto IL_07bb;
							case 10:
								text = (string)MLaEIWEUf4cEw8jsex0O(typeByUid2.Assembly);
								num4 = 3;
								continue;
							default:
								uid = m0nWokEUEWiAWN4FR1fV(current);
								num4 = 8;
								continue;
							case 3:
								entityManager = (IEntityManager)yjY9iCEUQNafFQcBHV0P(typeByUid2);
								num4 = 4;
								continue;
							case 8:
								typeByUid2 = serviceNotNull.GetTypeByUid(uid, loadImplementation: false);
								num4 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
								{
									num4 = 6;
								}
								continue;
							case 6:
								typeByUid = serviceNotNull.GetTypeByUid(current.ImplementationUid);
								num4 = 10;
								continue;
							case 11:
								try
								{
									MF0DUDEUZTEmMm6NYZCE(streamWriter, (string)NrkVMaEUvx2feqv2XBFP(0x7C1EE318 ^ 0x7C1BE7BE) + (string)no64IIEU8fgm5lZkB8fu(current));
									int num5 = 2;
									while (true)
									{
										switch (num5)
										{
										case 9:
											MF0DUDEUZTEmMm6NYZCE(streamWriter, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767391305));
											num5 = 5;
											continue;
										case 21:
											streamWriter.WriteLine((string)NrkVMaEUvx2feqv2XBFP(0x1FFEF86A ^ 0x1FFEF396));
											num5 = 15;
											continue;
										case 1:
										case 11:
										{
											propertyMetadata = array[num6 - 1];
											int num7 = 16;
											num5 = num7;
											continue;
										}
										case 7:
										case 19:
											MF0DUDEUZTEmMm6NYZCE(streamWriter, Tt0falEUI9QepKTNClkE(NrkVMaEUvx2feqv2XBFP(0x7247028A ^ 0x72420798), typeByUid));
											num5 = 10;
											continue;
										case 17:
											num6 = 1;
											num5 = 20;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
											{
												num5 = 11;
											}
											continue;
										case 4:
											rJDNeuEUqRlRIrA1CtyP(streamWriter);
											num5 = 8;
											continue;
										case 10:
											MF0DUDEUZTEmMm6NYZCE(streamWriter, NrkVMaEUvx2feqv2XBFP(0x4A1640F ^ 0x4A46139));
											num5 = 21;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
											{
												num5 = 15;
											}
											continue;
										case 3:
											MF0DUDEUZTEmMm6NYZCE(streamWriter, NrkVMaEUvx2feqv2XBFP(0x4A1640F ^ 0x4A46345));
											num5 = 22;
											continue;
										case 13:
											MF0DUDEUZTEmMm6NYZCE(streamWriter, NrkVMaEUvx2feqv2XBFP(-538519530 ^ -538520570));
											num5 = 4;
											continue;
										case 6:
											if (entityManager == null)
											{
												num5 = 19;
												continue;
											}
											goto case 18;
										case 22:
											streamWriter.WriteLine(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978678191));
											num5 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
											{
												num5 = 13;
											}
											continue;
										case 12:
										case 20:
											if (num6 <= array.Count())
											{
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
												{
													num5 = 1;
												}
												continue;
											}
											goto case 3;
										case 15:
											MF0DUDEUZTEmMm6NYZCE(streamWriter, HjmMTjEUVwIdTbSG9IrT(NrkVMaEUvx2feqv2XBFP(-541731959 ^ -542058981), typeByUid2.FullName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -630173482)));
											num5 = 14;
											continue;
										case 18:
											MF0DUDEUZTEmMm6NYZCE(streamWriter, Tt0falEUI9QepKTNClkE(NrkVMaEUvx2feqv2XBFP(0x49E27B8A ^ 0x49E77F64), entityManager));
											num5 = 7;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
											{
												num5 = 2;
											}
											continue;
										case 2:
											MF0DUDEUZTEmMm6NYZCE(streamWriter, ncF3RTEUupkmFKnZIqRP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671796751), text));
											num5 = 6;
											continue;
										default:
											num6++;
											num5 = 12;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
											{
												num5 = 2;
											}
											continue;
										case 14:
											streamWriter.WriteLine((string)NrkVMaEUvx2feqv2XBFP(-1123633026 ^ -1123828098));
											num5 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
											{
												num5 = 9;
											}
											continue;
										case 5:
											array = current.Properties.OrderBy((PropertyMetadata m) => m.Name).ToArray();
											num5 = 17;
											continue;
										case 16:
											MF0DUDEUZTEmMm6NYZCE(streamWriter, (string)NrkVMaEUvx2feqv2XBFP(-1487388570 ^ -1487059396) + (string)xy9tYQEURwGLce1FcvgI(NrkVMaEUvx2feqv2XBFP(-35995181 ^ -35666105), bqxfMOEUigsl2x9e66WG(vub1TuEUSs6R0fJoRBgE(current), Guid.Empty) ? "" : serviceNotNull.GetTypeByUid(vub1TuEUSs6R0fJoRBgE(current)).Name, no64IIEU8fgm5lZkB8fu(propertyMetadata)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97773804) + (string)((num6 == array.Count()) ? "" : NrkVMaEUvx2feqv2XBFP(-740338220 ^ -740358364)));
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
											{
												num5 = 0;
											}
											continue;
										case 8:
											break;
										}
										break;
									}
								}
								finally
								{
									if (streamWriter != null)
									{
										int num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
										{
											num8 = 0;
										}
										while (true)
										{
											switch (num8)
											{
											default:
												((IDisposable)streamWriter).Dispose();
												num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
												{
													num8 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								goto IL_07bb;
							case 2:
								streamWriter = (StreamWriter)wmGUU4EUCZyLQPQKsCYP(fileInfo);
								num4 = 8;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
								{
									num4 = 11;
								}
								continue;
							case 1:
								goto IL_07bb;
							case 7:
								goto IL_07d1;
							case 9:
								goto end_IL_07bb;
							}
							break;
						}
						if (G8ph3jEUGkDkZInVJ0ZI(current) != EntityMetadataType.Interface)
						{
							continue;
						}
						int num9 = 5;
						goto IL_0164;
						IL_07d1:
						current = enumerator.Current;
						num9 = 12;
						goto IL_0164;
						IL_0164:
						num4 = num9;
						goto IL_0168;
						continue;
						end_IL_07bb:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num10 = 0;
						}
						while (true)
						{
							switch (num10)
							{
							default:
								BXYOC6EUKxO1ORS8FgUQ(enumerator);
								num10 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num10 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 2;
			case 3:
			{
				IOrderedEnumerable<EntityMetadata> orderedEnumerable = from m in ((IMetadataService)NsJoIaEUh3FLPu0HwSmb()).GetMetadataList().OfType<EntityMetadata>()
					where _003C_003Ec.kbjQYs80Ju79VNVYMmvj(m) == EntityMetadataType.Interface
					select m into md
					orderby md.Name
					select md;
				num3 = 0;
				serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				enumerator = orderedEnumerable.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			}
			try
			{
				rJDNeuEUqRlRIrA1CtyP(streamWriter2);
				int num11 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num11 = 0;
				}
				while (true)
				{
					switch (num11)
					{
					case 1:
						return;
					}
					NtBfDwEUXSwnlm7KR01W(streamWriter2, num3);
					num11 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num11 = 1;
					}
				}
			}
			finally
			{
				int num12;
				if (streamWriter2 == null)
				{
					num12 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num12 = 0;
					}
					goto IL_00dc;
				}
				goto IL_00f2;
				IL_00f2:
				((IDisposable)streamWriter2).Dispose();
				num12 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num12 = 0;
				}
				goto IL_00dc;
				IL_00dc:
				switch (num12)
				{
				default:
					goto end_IL_00b7;
				case 1:
					break;
				case 0:
					goto end_IL_00b7;
				case 2:
					goto end_IL_00b7;
				}
				goto IL_00f2;
				end_IL_00b7:;
			}
		}
	}

	private void GenerateForEntity()
	{
		//Discarded unreachable code: IL_003e, IL_004d, IL_0058, IL_00e3, IL_02a9, IL_02b8, IL_02f9, IL_05da, IL_061a, IL_0629, IL_0635, IL_0708, IL_0778, IL_07b8, IL_07c7, IL_07d3, IL_084e, IL_08ad, IL_08e5
		int num = 6;
		int num2 = num;
		IEnumerator<EntityMetadata> enumerator = default(IEnumerator<EntityMetadata>);
		Type type = default(Type);
		Type typeByUid = default(Type);
		bool flag = default(bool);
		IEnumerable<IStartExportRulesIgnore> extensionPoints = default(IEnumerable<IStartExportRulesIgnore>);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		StreamWriter streamWriter2 = default(StreamWriter);
		IEntityManager entityManager = default(IEntityManager);
		int num8 = default(int);
		string text = default(string);
		PropertyMetadata[] array = default(PropertyMetadata[]);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		Guid uid = default(Guid);
		int num3 = default(int);
		FileInfo fileInfo = default(FileInfo);
		StreamWriter streamWriter = default(StreamWriter);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					while (true)
					{
						int num6;
						if (!rceMaBEUnyM60aHQl7MK(enumerator))
						{
							num6 = 8;
							goto IL_005c;
						}
						goto IL_06e2;
						IL_005c:
						while (true)
						{
							switch (num6)
							{
							case 3:
							case 7:
							case 12:
								break;
							case 15:
								type = typeByUid;
								num6 = 14;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
								{
									num6 = 16;
								}
								continue;
							case 14:
								if (flag)
								{
									num6 = 12;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
									{
										num6 = 0;
									}
									continue;
								}
								goto case 4;
							case 5:
								flag = extensionPoints.Any(_003C_003Ec__DisplayClass1_._003CGenerateForEntity_003Eb__2);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num6 = 1;
								}
								continue;
							case 2:
								try
								{
									MF0DUDEUZTEmMm6NYZCE(streamWriter2, ncF3RTEUupkmFKnZIqRP(NrkVMaEUvx2feqv2XBFP(0x1FFEF86A ^ 0x1FFBFCCC), no64IIEU8fgm5lZkB8fu(_003C_003Ec__DisplayClass1_.md)));
									int num7 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
									{
										num7 = 7;
									}
									while (true)
									{
										int num9;
										switch (num7)
										{
										case 12:
											if (entityManager == null)
											{
												num7 = 17;
												continue;
											}
											goto case 3;
										case 5:
											MF0DUDEUZTEmMm6NYZCE(streamWriter2, NrkVMaEUvx2feqv2XBFP(0xE1229CF ^ 0xE172E85));
											num7 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
											{
												num7 = 2;
											}
											continue;
										case 18:
											num8 = 1;
											num7 = 9;
											continue;
										case 10:
											MF0DUDEUZTEmMm6NYZCE(streamWriter2, (string)NrkVMaEUvx2feqv2XBFP(-420743386 ^ -420547604) + text);
											num7 = 12;
											continue;
										case 6:
										case 17:
											MF0DUDEUZTEmMm6NYZCE(streamWriter2, Tt0falEUI9QepKTNClkE(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978149408), type));
											num7 = 8;
											continue;
										case 9:
										case 20:
											if (num8 > array.Count())
											{
												num7 = 5;
												continue;
											}
											goto default;
										case 4:
											MF0DUDEUZTEmMm6NYZCE(streamWriter2, NrkVMaEUvx2feqv2XBFP(0x4DC2B14D ^ 0x4DC2BAB1));
											num7 = 8;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
											{
												num7 = 11;
											}
											continue;
										case 16:
											num8++;
											num9 = 20;
											goto IL_0187;
										case 21:
											streamWriter2.WriteLine((string)NrkVMaEUvx2feqv2XBFP(0x7E6E5A0B ^ 0x7E6B5C47));
											num7 = 7;
											continue;
										case 11:
											MF0DUDEUZTEmMm6NYZCE(streamWriter2, (string)NrkVMaEUvx2feqv2XBFP(-1852837372 ^ -1853163626) + typeByUid.FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6B5FFF));
											num7 = 14;
											continue;
										default:
											propertyMetadata = array[num8 - 1];
											num7 = 13;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
											{
												num7 = 13;
											}
											continue;
										case 3:
											streamWriter2.WriteLine((string)Tt0falEUI9QepKTNClkE(NrkVMaEUvx2feqv2XBFP(-787452571 ^ -787125877), entityManager));
											num7 = 6;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
											{
												num7 = 5;
											}
											continue;
										case 8:
											MF0DUDEUZTEmMm6NYZCE(streamWriter2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138630450));
											num7 = 4;
											continue;
										case 2:
											MF0DUDEUZTEmMm6NYZCE(streamWriter2, NrkVMaEUvx2feqv2XBFP(-1334993905 ^ -1335321771));
											num7 = 19;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
											{
												num7 = 0;
											}
											continue;
										case 14:
											MF0DUDEUZTEmMm6NYZCE(streamWriter2, NrkVMaEUvx2feqv2XBFP(-210725949 ^ -210397757));
											num7 = 21;
											continue;
										case 1:
											rJDNeuEUqRlRIrA1CtyP(streamWriter2);
											num7 = 13;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
											{
												num7 = 15;
											}
											continue;
										case 19:
											MF0DUDEUZTEmMm6NYZCE(streamWriter2, NrkVMaEUvx2feqv2XBFP(-289714582 ^ -289717638));
											num7 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
											{
												num7 = 1;
											}
											continue;
										case 7:
											array = _003C_003Ec__DisplayClass1_.md.Properties.OrderBy((PropertyMetadata m) => (string)_003C_003Ec.bNKmqM809X8YZJX0083K(m)).ToArray();
											num7 = 18;
											continue;
										case 13:
											MF0DUDEUZTEmMm6NYZCE(streamWriter2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978149208) + (string)xy9tYQEURwGLce1FcvgI(NrkVMaEUvx2feqv2XBFP(-281842504 ^ -281646548), bqxfMOEUigsl2x9e66WG(vub1TuEUSs6R0fJoRBgE(_003C_003Ec__DisplayClass1_.md), Guid.Empty) ? "" : r7a4PIEUkNCTKaUordC8(serviceNotNull.GetTypeByUid(vub1TuEUSs6R0fJoRBgE(_003C_003Ec__DisplayClass1_.md))), no64IIEU8fgm5lZkB8fu(propertyMetadata)) + (string)NrkVMaEUvx2feqv2XBFP(-1939377524 ^ -1939704370) + (string)((num8 == array.Count()) ? "" : NrkVMaEUvx2feqv2XBFP(-1765851862 ^ -1765838886)));
											num9 = 16;
											goto IL_0187;
										case 15:
											break;
											IL_0187:
											num7 = num9;
											continue;
										}
										break;
									}
								}
								finally
								{
									int num10;
									if (streamWriter2 == null)
									{
										num10 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
										{
											num10 = 0;
										}
										goto IL_05de;
									}
									goto IL_05f4;
									IL_05f4:
									((IDisposable)streamWriter2).Dispose();
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
									{
										num10 = 0;
									}
									goto IL_05de;
									IL_05de:
									switch (num10)
									{
									default:
										goto end_IL_05b9;
									case 1:
										break;
									case 2:
										goto end_IL_05b9;
									case 0:
										goto end_IL_05b9;
									}
									goto IL_05f4;
									end_IL_05b9:;
								}
								break;
							case 11:
								typeByUid = serviceNotNull.GetTypeByUid(uid, loadImplementation: false);
								num6 = 15;
								continue;
							case 10:
								num3++;
								num6 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
								{
									num6 = 6;
								}
								continue;
							case 6:
								streamWriter2 = (StreamWriter)wmGUU4EUCZyLQPQKsCYP(fileInfo);
								num6 = 2;
								continue;
							case 1:
								if (!boGs6xEUTW3oP66XuPqg(_003C_003Ec__DisplayClass1_.md))
								{
									num6 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
									{
										num6 = 4;
									}
									continue;
								}
								goto case 14;
							case 13:
								entityManager = (IEntityManager)yjY9iCEUQNafFQcBHV0P(typeByUid);
								num6 = 10;
								continue;
							case 4:
								uid = m0nWokEUEWiAWN4FR1fV(_003C_003Ec__DisplayClass1_.md);
								num6 = 11;
								continue;
							default:
								goto IL_06e2;
							case 16:
								text = (string)MLaEIWEUf4cEw8jsex0O(typeByUid.Assembly);
								num6 = 13;
								continue;
							case 9:
								_003C_003Ec__DisplayClass1_.md = enumerator.Current;
								num6 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
								{
									num6 = 3;
								}
								continue;
							case 8:
								goto end_IL_00aa;
							}
							break;
						}
						continue;
						IL_06e2:
						_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
						num6 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num6 = 2;
						}
						goto IL_005c;
						continue;
						end_IL_00aa:
						break;
					}
				}
				finally
				{
					int num11;
					if (enumerator == null)
					{
						num11 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num11 = 0;
						}
						goto IL_077c;
					}
					goto IL_0792;
					IL_0792:
					enumerator.Dispose();
					num11 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num11 = 2;
					}
					goto IL_077c;
					IL_077c:
					switch (num11)
					{
					default:
						goto end_IL_0757;
					case 1:
						break;
					case 0:
						goto end_IL_0757;
					case 2:
						goto end_IL_0757;
					}
					goto IL_0792;
					end_IL_0757:;
				}
				goto case 3;
			case 6:
				fileInfo = new FileInfo((string)TFYsFZEUbTDCT2YO6kRa());
				num2 = 5;
				break;
			case 5:
				extensionPoints = ComponentManager.Current.GetExtensionPoints<IStartExportRulesIgnore>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				streamWriter = fileInfo.AppendText();
				num2 = 4;
				break;
			case 4:
				try
				{
					rJDNeuEUqRlRIrA1CtyP(streamWriter);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							NtBfDwEUXSwnlm7KR01W(streamWriter, num3);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
				finally
				{
					if (streamWriter != null)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								((IDisposable)streamWriter).Dispose();
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
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
			case 2:
				return;
			default:
			{
				IOrderedEnumerable<EntityMetadata> orderedEnumerable = from m in ((IMetadataService)NsJoIaEUh3FLPu0HwSmb()).GetMetadataList().OfType<EntityMetadata>()
					where _003C_003Ec.kbjQYs80Ju79VNVYMmvj(m) == EntityMetadataType.Entity
					select m into md
					orderby md.Name
					select md;
				num3 = 0;
				serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				enumerator = orderedEnumerable.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			}
			}
		}
	}

	private void GenerateCodeExportRuleList()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				GenerateForInterface();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				GenerateForEntity();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void CheckExportRuleList()
	{
		//Discarded unreachable code: IL_0046, IL_0066, IL_0075, IL_00b4, IL_00c3, IL_0232, IL_0245, IL_0254, IL_0354, IL_038c, IL_039b, IL_0435, IL_047e, IL_048d
		switch (1)
		{
		case 1:
			try
			{
				IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num = 1;
				}
				IEnumerator<EntityMetadata> enumerator = default(IEnumerator<EntityMetadata>);
				List<PropertyMetadata>.Enumerator enumerator2 = default(List<PropertyMetadata>.Enumerator);
				_003C_003Ec__DisplayClass3_1 _003C_003Ec__DisplayClass3_2 = default(_003C_003Ec__DisplayClass3_1);
				EntityMetadata current = default(EntityMetadata);
				_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
				ExportRuleList source = default(ExportRuleList);
				Guid uid = default(Guid);
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 2:
						try
						{
							while (true)
							{
								int num2;
								if (!enumerator.MoveNext())
								{
									num2 = 7;
									goto IL_0084;
								}
								goto IL_030b;
								IL_0084:
								while (true)
								{
									switch (num2)
									{
									case 4:
										try
										{
											while (true)
											{
												IL_014d:
												int num4;
												if (!enumerator2.MoveNext())
												{
													num4 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
													{
														num4 = 1;
													}
													goto IL_00d2;
												}
												goto IL_01f1;
												IL_01f1:
												_003C_003Ec__DisplayClass3_2 = new _003C_003Ec__DisplayClass3_1();
												int num5 = 3;
												num4 = num5;
												goto IL_00d2;
												IL_00d2:
												while (true)
												{
													switch (num4)
													{
													case 5:
														throw new Exception(SR.T((string)NrkVMaEUvx2feqv2XBFP(-629844702 ^ -630173022), ATT0BqEUOPNbSuQYMsIZ(_003C_003Ec__DisplayClass3_2.property), no64IIEU8fgm5lZkB8fu(_003C_003Ec__DisplayClass3_2.property), ATT0BqEUOPNbSuQYMsIZ(current), no64IIEU8fgm5lZkB8fu(current)));
													case 3:
														_003C_003Ec__DisplayClass3_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass3_;
														num4 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
														{
															num4 = 1;
														}
														continue;
													case 1:
														_003C_003Ec__DisplayClass3_2.property = enumerator2.Current;
														num4 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
														{
															num4 = 0;
														}
														continue;
													default:
														goto IL_01be;
													case 4:
														break;
													case 2:
														goto end_IL_00d2;
													}
													goto IL_01f1;
													IL_01be:
													if (!source.Any(_003C_003Ec__DisplayClass3_2._003CCheckExportRuleList_003Eb__2))
													{
														num4 = 5;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
														{
															num4 = 1;
														}
														continue;
													}
													goto IL_014d;
													continue;
													end_IL_00d2:
													break;
												}
												break;
											}
										}
										finally
										{
											((IDisposable)enumerator2).Dispose();
											int num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
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
									case 1:
									{
										_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
										int num3 = 3;
										num2 = num3;
										continue;
									}
									case 3:
										uid = current.Uid;
										num2 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
										{
											num2 = 5;
										}
										continue;
									case 6:
										enumerator2 = current.Properties.GetEnumerator();
										num2 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
										{
											num2 = 3;
										}
										continue;
									case 2:
										break;
									case 5:
									{
										Type typeByUid = serviceNotNull.GetTypeByUid(uid, loadImplementation: false);
										_003C_003Ec__DisplayClass3_.typeMdImpl = serviceNotNull.GetTypeByUid(vub1TuEUSs6R0fJoRBgE(current));
										source = ((IEntityManager)yjY9iCEUQNafFQcBHV0P(typeByUid)).ExportRules();
										num2 = 6;
										continue;
									}
									default:
										goto IL_030b;
									case 7:
										return;
									}
									break;
								}
								continue;
								IL_030b:
								current = enumerator.Current;
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
								{
									num2 = 1;
								}
								goto IL_0084;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
								{
									num7 = 1;
								}
								while (true)
								{
									switch (num7)
									{
									case 1:
										enumerator.Dispose();
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
										{
											num7 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
					case 1:
						enumerator = (from m in ((IMetadataService)NsJoIaEUh3FLPu0HwSmb()).GetMetadataList().OfType<EntityMetadata>()
							where _003C_003Ec.kbjQYs80Ju79VNVYMmvj(m) == EntityMetadataType.Interface
							select m into md
							orderby md.Name
							select md).GetEnumerator();
						num = 2;
						break;
					case 0:
						return;
					}
				}
			}
			catch (Exception ex)
			{
				int num8 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num8 = 0;
				}
				while (true)
				{
					switch (num8)
					{
					case 1:
						throw new Exception((string)B7caL6EUP4V0LtpOoDej(ex));
					}
					kBQ1VbEUehAy82csmYZU(dd7JZNEU2Lf5ej18vaX3(), ex);
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num8 = 1;
					}
				}
			}
		case 0:
			break;
		}
	}

	public void Init()
	{
	}

	public void InitComplete()
	{
	}

	public CheckStartExportRules()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		M38hLcEU11Zs8YgqITM7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object TFYsFZEUbTDCT2YO6kRa()
	{
		return IOExtensions.GetTempFileName();
	}

	internal static object NsJoIaEUh3FLPu0HwSmb()
	{
		return MetadataServiceContext.Service;
	}

	internal static EntityMetadataType G8ph3jEUGkDkZInVJ0ZI(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid m0nWokEUEWiAWN4FR1fV(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object MLaEIWEUf4cEw8jsex0O(object P_0)
	{
		return ComponentManager.GetAssemblyShortName((Assembly)P_0);
	}

	internal static object yjY9iCEUQNafFQcBHV0P(Type entityType)
	{
		return ModelHelper.GetEntityManagerOrNull(entityType);
	}

	internal static object wmGUU4EUCZyLQPQKsCYP(object P_0)
	{
		return ((FileInfo)P_0).AppendText();
	}

	internal static object NrkVMaEUvx2feqv2XBFP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object no64IIEU8fgm5lZkB8fu(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void MF0DUDEUZTEmMm6NYZCE(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static object ncF3RTEUupkmFKnZIqRP(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object Tt0falEUI9QepKTNClkE(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object HjmMTjEUVwIdTbSG9IrT(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Guid vub1TuEUSs6R0fJoRBgE(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static bool bqxfMOEUigsl2x9e66WG(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object xy9tYQEURwGLce1FcvgI(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void rJDNeuEUqRlRIrA1CtyP(object P_0)
	{
		((TextWriter)P_0).WriteLine();
	}

	internal static void BXYOC6EUKxO1ORS8FgUQ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void NtBfDwEUXSwnlm7KR01W(object P_0, int P_1)
	{
		((TextWriter)P_0).WriteLine(P_1);
	}

	internal static bool uQtIEBEUWD79yGgw5B5K()
	{
		return EG8IUTEUBhKsMMHiWie2 == null;
	}

	internal static CheckStartExportRules cimO34EUor85BxNSS57j()
	{
		return EG8IUTEUBhKsMMHiWie2;
	}

	internal static bool boGs6xEUTW3oP66XuPqg(object P_0)
	{
		return ((EntityMetadata)P_0).IsUnique;
	}

	internal static object r7a4PIEUkNCTKaUordC8(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool rceMaBEUnyM60aHQl7MK(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object ATT0BqEUOPNbSuQYMsIZ(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object dd7JZNEU2Lf5ej18vaX3()
	{
		return Logger.Log;
	}

	internal static void kBQ1VbEUehAy82csmYZU(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object B7caL6EUP4V0LtpOoDej(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void M38hLcEU11Zs8YgqITM7()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

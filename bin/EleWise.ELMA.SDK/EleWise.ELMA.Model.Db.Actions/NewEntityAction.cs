using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db.Actions;

public class NewEntityAction : EntityAction
{
	internal static NewEntityAction kYtAuyoGxkDC2L6TDfqk;

	public NewEntityAction(IDbModelUpdater updater, EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_002c, IL_00fa, IL_01cd, IL_0230, IL_02d9, IL_0398, IL_0415, IL_0424, IL_04db, IL_0567, IL_0576, IL_0581, IL_067f, IL_0692, IL_080b, IL_0832, IL_0841, IL_087d, IL_088c, IL_0897, IL_08c3, IL_08d2, IL_08dd, IL_096d, IL_0980, IL_098f, IL_0a39, IL_0a4c, IL_0a5c, IL_0a6b, IL_0a76, IL_0b21, IL_0b34, IL_0b43, IL_0b74, IL_0b93, IL_0ba2, IL_0bcf, IL_0c19, IL_0c75, IL_0c7f, IL_0d1f, IL_0d32, IL_0d41
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(updater, metadata);
		int num = 7;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
		{
			num = 30;
		}
		int? length = default(int?);
		List<IDbCreateTableActionExtender>.Enumerator enumerator = default(List<IDbCreateTableActionExtender>.Enumerator);
		List<IDbCreateTableActionExtender> list = default(List<IDbCreateTableActionExtender>);
		IMetadata metadata2 = default(IMetadata);
		Column column = default(Column);
		Column columnForIdentifier = default(Column);
		IEnumerator<EntityPropertyMetadata> enumerator2 = default(IEnumerator<EntityPropertyMetadata>);
		Column item = default(Column);
		Table table = default(Table);
		EntityPropertyMetadata current = default(EntityPropertyMetadata);
		List<ForeignKey>.Enumerator enumerator5 = default(List<ForeignKey>.Enumerator);
		ForeignKey current4 = default(ForeignKey);
		List<Table>.Enumerator enumerator4 = default(List<Table>.Enumerator);
		TypeDbStructures typeDbStructures = default(TypeDbStructures);
		List<Column>.Enumerator enumerator3 = default(List<Column>.Enumerator);
		Table current3 = default(Table);
		Column current2 = default(Column);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 2:
				if (!length.HasValue)
				{
					num = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num = 11;
					}
					break;
				}
				goto case 25;
			case 23:
				enumerator = list.GetEnumerator();
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num = 18;
				}
				break;
			case 22:
				throw new DbModelException((string)v2RvZloGsGyWLOo0Jy8i(T1r2epoGcBM9GAye21hl(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521385328)), base.Metadata.FullTypeName, metadata2.GetType().FullName));
			case 33:
				column = (Column)YZtHdAoGzUYxca7MZY1N(base.Metadata);
				num = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num = 8;
				}
				break;
			case 25:
				length = ((ColumnType)nqP4d9oGj2wGhvLGlWC0(columnForIdentifier)).Length;
				num2 = 12;
				goto IL_0031;
			case 20:
				if (metadata2 != null)
				{
					num = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num = 34;
					}
					break;
				}
				goto case 9;
			case 1:
			case 21:
				enumerator2 = base.Metadata.Properties.OfType<EntityPropertyMetadata>().GetEnumerator();
				num = 29;
				break;
			case 5:
				item = new Column((string)o6dbl3oGUsrjiiFHHAhU(0x42643203 ^ 0x42647061), DbType.Guid);
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num = 8;
				}
				break;
			case 8:
				table.Columns.Add(item);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num = 0;
				}
				break;
			case 28:
				base.Updater.TablesCreatedActions.Add(new DbCreateTableAction(base.Transform, table));
				num2 = 7;
				goto IL_0031;
			case 13:
				NRQg19oGLWlsk4Rxioj1(column, ColumnProperty.PrimaryKey);
				num = 19;
				break;
			case 24:
				if (!oJ8tpPoG5cFJwq9UsjGF(SWUO1XoGgxxnM2T4bRcq(base.Metadata), Guid.Empty))
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num = 0;
					}
					break;
				}
				goto case 31;
			case 26:
				return;
			case 14:
				table.Columns.Add(columnForIdentifier);
				num = 6;
				break;
			case 11:
			case 15:
				((ColumnType)nqP4d9oGj2wGhvLGlWC0(columnForIdentifier)).Length = 255;
				num = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num = 16;
				}
				break;
			case 6:
			case 10:
				if (base.Metadata.AllowCreateHeirs)
				{
					num = 27;
					break;
				}
				goto case 1;
			case 27:
				if (!oJ8tpPoG5cFJwq9UsjGF(SWUO1XoGgxxnM2T4bRcq(metadata), Guid.Empty))
				{
					num = 21;
					break;
				}
				goto case 5;
			default:
				metadata2 = MetadataLoader.LoadMetadata(SWUO1XoGgxxnM2T4bRcq(base.Metadata));
				num = 20;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num = 14;
				}
				break;
			case 3:
				throw new DbModelException((string)Nnbg9hoG9ExiHujgT2dQ(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309783430)), Yk1FqioGJONY29vsyeUs(base.Metadata)));
			case 17:
			{
				Table obj = new Table
				{
					Columns = new List<Column>()
				};
				Q2OZdQoGdIMKFIwlusfG(obj, aXPn2poGyN2aOI241sOW(base.Metadata));
				table = obj;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num = 28;
				}
				break;
			}
			case 31:
			{
				columnForIdentifier = DbModelHelper.GetColumnForIdentifier(base.Metadata, out var _);
				num2 = 4;
				goto IL_0031;
			}
			case 30:
				if (!ReDCV1oGMVP6E0ITlvJ4(aXPn2poGyN2aOI241sOW(base.Metadata)))
				{
					num = 17;
					break;
				}
				goto case 3;
			case 9:
				throw new DbModelException((string)v2RvZloGsGyWLOo0Jy8i(SR.T((string)o6dbl3oGUsrjiiFHHAhU(--1360331293 ^ 0x511757EF)), Yk1FqioGJONY29vsyeUs(base.Metadata), SWUO1XoGgxxnM2T4bRcq(base.Metadata)));
			case 34:
				if (metadata2 is EntityMetadata)
				{
					num = 33;
					break;
				}
				goto case 22;
			case 19:
				table.Columns.Add(column);
				num = 10;
				break;
			case 29:
				try
				{
					while (true)
					{
						int num5;
						if (!frCorsoEb8F9GZFoq0yX(enumerator2))
						{
							num5 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
							{
								num5 = 3;
							}
							goto IL_04e9;
						}
						goto IL_07d7;
						IL_07d7:
						current = enumerator2.Current;
						num5 = 11;
						goto IL_04e9;
						IL_04e9:
						while (true)
						{
							int num12;
							switch (num5)
							{
							case 7:
								return;
							case 14:
								if (!((ComponentManager)vlXNIQoGlH0VlIo6Dvsg()).GetExtensionPoints<IIgnoreUidUI>().Any((IIgnoreUidUI m) => TNZfwuoEhh631ieCllEU(m, base.Metadata)))
								{
									num5 = 12;
									continue;
								}
								break;
							case 9:
								try
								{
									while (true)
									{
										IL_05a3:
										int num13;
										if (!enumerator5.MoveNext())
										{
											num13 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
											{
												num13 = 0;
											}
											goto IL_0585;
										}
										goto IL_0609;
										IL_0609:
										current4 = enumerator5.Current;
										num13 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
										{
											num13 = 1;
										}
										goto IL_0585;
										IL_0585:
										while (true)
										{
											switch (num13)
											{
											case 2:
												goto IL_05a3;
											case 1:
												current4.Name = base.Updater.GenerateForeignKeyName(current4.TableName, current4.Columns[0]);
												num13 = 4;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
												{
													num13 = 4;
												}
												continue;
											case 3:
												goto IL_0609;
											case 4:
												base.Updater.ForeignKeysCreatedActions.Add(new DbCreateForeignKeyAction(base.Transform, current4));
												num13 = 2;
												continue;
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
									((IDisposable)enumerator5).Dispose();
									int num14 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
									{
										num14 = 0;
									}
									switch (num14)
									{
									case 0:
										break;
									}
								}
								goto case 3;
							case 1:
								enumerator4 = typeDbStructures.Tables.GetEnumerator();
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num5 = 4;
								}
								continue;
							case 12:
							{
								List<IDbAction> tablesCreatedActions = base.Updater.TablesCreatedActions;
								ITransformationProvider transformationProvider = base.Transform;
								Index index = new Index();
								fSsMD3oEoC7FQryRO0nT(index, string.Format((string)o6dbl3oGUsrjiiFHHAhU(-1317790512 ^ -1317647042), aXPn2poGyN2aOI241sOW(base.Metadata)));
								index.TableName = (string)aXPn2poGyN2aOI241sOW(base.Metadata);
								index.Columns = new List<string> { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A615A2C) };
								tablesCreatedActions.Add(new DbCreateUniqueIndexAction(transformationProvider, index));
								num12 = 16;
								goto IL_04e5;
							}
							case 8:
								if (oJ8tpPoG5cFJwq9UsjGF(SWUO1XoGgxxnM2T4bRcq(base.Metadata), Guid.Empty))
								{
									num5 = 14;
									continue;
								}
								break;
							case 13:
							case 15:
							case 16:
								break;
							case 11:
								typeDbStructures = (TypeDbStructures)PGwEBDoEFUCQEFDBwXr0(base.Metadata, current);
								num5 = 2;
								continue;
							default:
								if (!P0YKnAoEWp2Wx5Fxo1Tj(base.Metadata))
								{
									num5 = 15;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
									{
										num5 = 4;
									}
									continue;
								}
								goto case 8;
							case 6:
								goto IL_07d7;
							case 5:
								enumerator5 = typeDbStructures.ForeignKeys.GetEnumerator();
								num12 = 9;
								goto IL_04e5;
							case 2:
								enumerator3 = typeDbStructures.Columns.GetEnumerator();
								num5 = 10;
								continue;
							case 3:
								if (!((string)d1E5ccoEBoD45esaRdIi(current) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542714353)))
								{
									num5 = 13;
									continue;
								}
								goto default;
							case 4:
								try
								{
									while (true)
									{
										int num8;
										if (!enumerator4.MoveNext())
										{
											num8 = 4;
											goto IL_089b;
										}
										goto IL_09fa;
										IL_089b:
										while (true)
										{
											switch (num8)
											{
											default:
												try
												{
													while (true)
													{
														int num9;
														if (!enumerator.MoveNext())
														{
															num9 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
															{
																num9 = 1;
															}
															goto IL_08e1;
														}
														goto IL_091d;
														IL_091d:
														TDgng2oGr2GAM7G17oiG(enumerator.Current, base.Updater, base.Transform, current3);
														num9 = 2;
														goto IL_08e1;
														IL_08e1:
														switch (num9)
														{
														case 2:
															break;
														default:
															goto IL_091d;
														case 1:
															goto end_IL_08f7;
														}
														continue;
														end_IL_08f7:
														break;
													}
												}
												finally
												{
													((IDisposable)enumerator).Dispose();
													int num10 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
													{
														num10 = 0;
													}
													switch (num10)
													{
													case 0:
														break;
													}
												}
												break;
											case 5:
												enumerator = list.GetEnumerator();
												num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
												{
													num8 = 0;
												}
												continue;
											case 2:
												base.Updater.TablesCreatedActions.Add(new DbCreateTableAction(base.Transform, current3));
												num8 = 5;
												continue;
											case 1:
												break;
											case 3:
												goto IL_09fa;
											case 4:
												goto end_IL_09e4;
											}
											break;
										}
										continue;
										IL_09fa:
										current3 = enumerator4.Current;
										num8 = 2;
										goto IL_089b;
										continue;
										end_IL_09e4:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator4).Dispose();
									int num11 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
									{
										num11 = 0;
									}
									switch (num11)
									{
									case 0:
										break;
									}
								}
								goto case 5;
							case 10:
								{
									try
									{
										while (true)
										{
											int num6;
											if (!enumerator3.MoveNext())
											{
												num6 = 3;
												goto IL_0a7a;
											}
											goto IL_0ad2;
											IL_0a7a:
											while (true)
											{
												switch (num6)
												{
												case 1:
													table.Columns.Add(current2);
													num6 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
													{
														num6 = 0;
													}
													continue;
												case 2:
													goto IL_0ad2;
												case 3:
													goto end_IL_0a94;
												}
												break;
											}
											continue;
											IL_0ad2:
											current2 = enumerator3.Current;
											num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
											{
												num6 = 1;
											}
											goto IL_0a7a;
											continue;
											end_IL_0a94:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator3).Dispose();
										int num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
										{
											num7 = 0;
										}
										switch (num7)
										{
										case 0:
											break;
										}
									}
									goto case 1;
								}
								IL_04e5:
								num5 = num12;
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					int num15;
					if (enumerator2 == null)
					{
						num15 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num15 = 0;
						}
						goto IL_0b78;
					}
					goto IL_0bad;
					IL_0bad:
					enumerator2.Dispose();
					num15 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num15 = 0;
					}
					goto IL_0b78;
					IL_0b78:
					switch (num15)
					{
					default:
						goto end_IL_0b53;
					case 1:
						goto end_IL_0b53;
					case 2:
						break;
					case 0:
						goto end_IL_0b53;
					}
					goto IL_0bad;
					end_IL_0b53:;
				}
			case 32:
				length = ((ColumnType)nqP4d9oGj2wGhvLGlWC0(columnForIdentifier)).Length;
				num = 2;
				break;
			case 16:
				NRQg19oGLWlsk4Rxioj1(columnForIdentifier, ColumnProperty.PrimaryKey);
				num = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num = 14;
				}
				break;
			case 12:
				if (length.Value > 255)
				{
					num = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num = 10;
					}
					break;
				}
				goto case 16;
			case 4:
				if (PJQ3LWoGYlHLXpXVqNg0(nqP4d9oGj2wGhvLGlWC0(columnForIdentifier)) == DbType.String)
				{
					num = 32;
					break;
				}
				goto case 16;
			case 18:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
							{
								num3 = 0;
							}
							goto IL_0c83;
						}
						goto IL_0cbf;
						IL_0cbf:
						TDgng2oGr2GAM7G17oiG(enumerator.Current, base.Updater, base.Transform, table);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num3 = 1;
						}
						goto IL_0c83;
						IL_0c83:
						switch (num3)
						{
						case 1:
							continue;
						case 2:
							goto IL_0cbf;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 24;
			case 7:
				{
					list = ((ComponentManager)vlXNIQoGlH0VlIo6Dvsg()).GetExtensionPoints<IDbCreateTableActionExtender>().ToList();
					num = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num = 23;
					}
					break;
				}
				IL_0031:
				num = num2;
				break;
			}
		}
	}

	internal static object aXPn2poGyN2aOI241sOW(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static bool ReDCV1oGMVP6E0ITlvJ4(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object Yk1FqioGJONY29vsyeUs(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static object Nnbg9hoG9ExiHujgT2dQ(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void Q2OZdQoGdIMKFIwlusfG(object P_0, object P_1)
	{
		((Table)P_0).Name = (string)P_1;
	}

	internal static object vlXNIQoGlH0VlIo6Dvsg()
	{
		return ComponentManager.Current;
	}

	internal static void TDgng2oGr2GAM7G17oiG(object P_0, object P_1, object P_2, object P_3)
	{
		((IDbCreateTableActionExtender)P_0).Extend((IDbModelUpdater)P_1, (ITransformationProvider)P_2, (Table)P_3);
	}

	internal static Guid SWUO1XoGgxxnM2T4bRcq(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool oJ8tpPoG5cFJwq9UsjGF(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object nqP4d9oGj2wGhvLGlWC0(object P_0)
	{
		return ((Column)P_0).ColumnType;
	}

	internal static DbType PJQ3LWoGYlHLXpXVqNg0(object P_0)
	{
		return ((ColumnType)P_0).DataType;
	}

	internal static void NRQg19oGLWlsk4Rxioj1(object P_0, ColumnProperty value)
	{
		((Column)P_0).ColumnProperty = value;
	}

	internal static object o6dbl3oGUsrjiiFHHAhU(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object v2RvZloGsGyWLOo0Jy8i(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object T1r2epoGcBM9GAye21hl(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object YZtHdAoGzUYxca7MZY1N(object P_0)
	{
		return DbModelHelper.GetColumnForIdentifier((EntityMetadata)P_0);
	}

	internal static object PGwEBDoEFUCQEFDBwXr0(object P_0, object P_1)
	{
		return DbModelHelper.GetPropertyDbStructures((EntityMetadata)P_0, (EntityPropertyMetadata)P_1);
	}

	internal static object d1E5ccoEBoD45esaRdIi(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool P0YKnAoEWp2Wx5Fxo1Tj(object P_0)
	{
		return ((EntityMetadata)P_0).IsUnique;
	}

	internal static void fSsMD3oEoC7FQryRO0nT(object P_0, object P_1)
	{
		((Index)P_0).Name = (string)P_1;
	}

	internal static bool frCorsoEb8F9GZFoq0yX(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool X8mqiFoG0uP7u2FI2Jjq()
	{
		return kYtAuyoGxkDC2L6TDfqk == null;
	}

	internal static NewEntityAction EUJ9kPoGmINXngx3QUco()
	{
		return kYtAuyoGxkDC2L6TDfqk;
	}

	internal static bool TNZfwuoEhh631ieCllEU(object P_0, object P_1)
	{
		return ((IIgnoreUidUI)P_0).NeedIgnoreUid((EntityMetadata)P_1);
	}
}

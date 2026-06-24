using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db.Actions;

public class NewPropertyAction : EntityPropertyAction
{
	private static NewPropertyAction s9vW6GoESLyvL5suY54f;

	public NewPropertyAction(IDbModelUpdater updater, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_001d, IL_0022, IL_0062, IL_0098, IL_00a7, IL_00b2, IL_012c, IL_014b, IL_015a, IL_0187, IL_0196, IL_025c, IL_026f, IL_027f, IL_0289, IL_0377, IL_038a, IL_0412, IL_0421, IL_042c, IL_04e1, IL_04f4, IL_0504, IL_0513, IL_051e, IL_0603, IL_0616, IL_0625
		gi5CSvoEqWCaFCpFYeas();
		base._002Ector(updater, metadata, propertyMetadata);
		int num = 6;
		List<Table>.Enumerator enumerator4 = default(List<Table>.Enumerator);
		Table current3 = default(Table);
		IEnumerator<IDbCreateTableActionExtender> enumerator5 = default(IEnumerator<IDbCreateTableActionExtender>);
		List<ForeignKey>.Enumerator enumerator3 = default(List<ForeignKey>.Enumerator);
		ForeignKey current4 = default(ForeignKey);
		List<Column>.Enumerator enumerator2 = default(List<Column>.Enumerator);
		TypeDbStructures propertyDbStructures = default(TypeDbStructures);
		List<Tuple<string, object>>.Enumerator enumerator = default(List<Tuple<string, object>>.Enumerator);
		Column current2 = default(Column);
		Tuple<string, object> current = default(Tuple<string, object>);
		while (true)
		{
			switch (num)
			{
			case 4:
				try
				{
					while (true)
					{
						IL_01c4:
						int num6;
						if (!enumerator4.MoveNext())
						{
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
							{
								num6 = 0;
							}
							goto IL_0070;
						}
						goto IL_01a1;
						IL_01a1:
						current3 = enumerator4.Current;
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num6 = 1;
						}
						goto IL_0070;
						IL_0070:
						while (true)
						{
							switch (num6)
							{
							case 5:
								try
								{
									while (true)
									{
										int num8;
										if (!S4mE2ToE24YlP0XgHmOQ(enumerator5))
										{
											num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
											{
												num8 = 1;
											}
											goto IL_00b6;
										}
										goto IL_00f2;
										IL_00f2:
										V686sloEOwJVx9FLJcdt(enumerator5.Current, base.Updater, base.Transform, current3);
										num8 = 2;
										goto IL_00b6;
										IL_00b6:
										switch (num8)
										{
										case 2:
											break;
										default:
											goto IL_00f2;
										case 1:
											goto end_IL_00cc;
										}
										continue;
										end_IL_00cc:
										break;
									}
								}
								finally
								{
									int num9;
									if (enumerator5 == null)
									{
										num9 = 2;
										goto IL_0130;
									}
									goto IL_0165;
									IL_0130:
									switch (num9)
									{
									default:
										goto end_IL_011b;
									case 2:
										goto end_IL_011b;
									case 1:
										break;
									case 0:
										goto end_IL_011b;
									}
									goto IL_0165;
									IL_0165:
									yXukcfoEek1ptMb45ZrK(enumerator5);
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
									{
										num9 = 0;
									}
									goto IL_0130;
									end_IL_011b:;
								}
								goto IL_01c4;
							case 2:
								goto IL_01a1;
							case 4:
								goto IL_01c4;
							case 3:
							{
								enumerator5 = ((ComponentManager)OID8mNoEnls6OwaO6qbB()).GetExtensionPoints<IDbCreateTableActionExtender>().GetEnumerator();
								int num7 = 5;
								num6 = num7;
								continue;
							}
							case 1:
								base.Updater.TablesCreatedActions.Add(new DbCreateTableAction(base.Transform, current3));
								num6 = 3;
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
					((IDisposable)enumerator4).Dispose();
					int num10 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num10 = 0;
					}
					switch (num10)
					{
					case 0:
						break;
					}
				}
				goto case 2;
			case 9:
				try
				{
					while (true)
					{
						int num11;
						if (!enumerator3.MoveNext())
						{
							num11 = 4;
							goto IL_028d;
						}
						goto IL_0328;
						IL_028d:
						while (true)
						{
							switch (num11)
							{
							case 3:
								break;
							default:
								hCA68EoENwZK19EJbBDW(current4, txYhcToE1Z17njxrLXX6(base.Updater, e0570IoEPcdki26L1Yir(current4), current4.Columns[0]));
								num11 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
								{
									num11 = 1;
								}
								continue;
							case 1:
								base.Updater.ForeignKeysCreatedActions.Add(new DbCreateForeignKeyAction(base.Transform, current4));
								num11 = 3;
								continue;
							case 2:
								goto IL_0328;
							case 4:
								goto end_IL_02ab;
							}
							break;
						}
						continue;
						IL_0328:
						current4 = enumerator3.Current;
						num11 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num11 = 0;
						}
						goto IL_028d;
						continue;
						end_IL_02ab:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator3).Dispose();
					int num12 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num12 = 0;
					}
					switch (num12)
					{
					case 0:
						break;
					}
				}
				goto case 5;
			default:
				enumerator2 = propertyDbStructures.Columns.GetEnumerator();
				num = 8;
				continue;
			case 1:
				return;
			case 2:
				enumerator3 = propertyDbStructures.ForeignKeys.GetEnumerator();
				num = 9;
				continue;
			case 6:
				if (string.IsNullOrEmpty((string)vxgIZqoEKeUksKqKxxyn(base.Metadata)))
				{
					num = 7;
					continue;
				}
				propertyDbStructures = DbModelHelper.GetPropertyDbStructures(base.Metadata, propertyMetadata);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num = 0;
				}
				continue;
			case 5:
				enumerator = propertyDbStructures.Updates.GetEnumerator();
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num = 2;
				}
				continue;
			case 8:
				try
				{
					while (true)
					{
						int num4;
						if (!enumerator2.MoveNext())
						{
							num4 = 2;
							goto IL_0430;
						}
						goto IL_0460;
						IL_0430:
						while (true)
						{
							switch (num4)
							{
							case 3:
								break;
							case 1:
								goto IL_0460;
							default:
								base.Updater.TablesCreatedActions.Add(new DbCreateColumnAction(base.Transform, base.Metadata.TableName, current2));
								num4 = 3;
								continue;
							case 2:
								goto end_IL_044a;
							}
							break;
						}
						continue;
						IL_0460:
						current2 = enumerator2.Current;
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num4 = 0;
						}
						goto IL_0430;
						continue;
						end_IL_044a:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
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
			case 3:
				try
				{
					while (true)
					{
						int num2;
						if (!enumerator.MoveNext())
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num2 = 2;
							}
							goto IL_0522;
						}
						goto IL_05b4;
						IL_05b4:
						current = enumerator.Current;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num2 = 0;
						}
						goto IL_0522;
						IL_0522:
						while (true)
						{
							switch (num2)
							{
							case 2:
								return;
							case 3:
								break;
							case 1:
								base.Updater.TablesDeletedActions.Add(new DbUpdateAction(base.Transform, (string)vxgIZqoEKeUksKqKxxyn(base.Metadata), new string[1] { current.Item1 }, new object[1] { current.Item2 }));
								num2 = 3;
								continue;
							default:
								goto IL_05b4;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
			case 7:
				throw new DbModelException((string)reamweoEkpYDsA6m9Pb9(oy2xeCoETYlQ0vHrChxG(yRtoosoEXfmrQo9KS3ji(-521266112 ^ -521384058)), base.Metadata.FullTypeName));
			case 10:
				break;
			}
			enumerator4 = propertyDbStructures.Tables.GetEnumerator();
			num = 4;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
			{
				num = 3;
			}
		}
	}

	internal static void gi5CSvoEqWCaFCpFYeas()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object vxgIZqoEKeUksKqKxxyn(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static object yRtoosoEXfmrQo9KS3ji(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object oy2xeCoETYlQ0vHrChxG(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object reamweoEkpYDsA6m9Pb9(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object OID8mNoEnls6OwaO6qbB()
	{
		return ComponentManager.Current;
	}

	internal static void V686sloEOwJVx9FLJcdt(object P_0, object P_1, object P_2, object P_3)
	{
		((IDbCreateTableActionExtender)P_0).Extend((IDbModelUpdater)P_1, (ITransformationProvider)P_2, (Table)P_3);
	}

	internal static bool S4mE2ToE24YlP0XgHmOQ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void yXukcfoEek1ptMb45ZrK(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object e0570IoEPcdki26L1Yir(object P_0)
	{
		return ((ForeignKey)P_0).TableName;
	}

	internal static object txYhcToE1Z17njxrLXX6(object P_0, object P_1, object P_2)
	{
		return ((IDbModelUpdater)P_0).GenerateForeignKeyName((string)P_1, (string)P_2);
	}

	internal static void hCA68EoENwZK19EJbBDW(object P_0, object P_1)
	{
		((ForeignKey)P_0).Name = (string)P_1;
	}

	internal static bool itPw6goEiDtjwyFQAweA()
	{
		return s9vW6GoESLyvL5suY54f == null;
	}

	internal static NewPropertyAction mqNxWSoERCKwC9i8GbvQ()
	{
		return s9vW6GoESLyvL5suY54f;
	}
}

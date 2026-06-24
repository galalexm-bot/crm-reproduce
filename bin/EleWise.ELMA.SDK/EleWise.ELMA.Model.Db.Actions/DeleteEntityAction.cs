using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db.Actions;

public class DeleteEntityAction : EntityAction
{
	internal static DeleteEntityAction wfcN5YohStMGvb7O1W62;

	public DeleteEntityAction(IDbModelUpdater updater, EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_001c, IL_0021, IL_0074, IL_0083, IL_008e, IL_00b6, IL_00c0, IL_018a, IL_019d, IL_0234, IL_0247, IL_0256
		vFAQsjohqQLvcHvgf1eU();
		base._002Ector(updater, metadata);
		int num = 3;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		List<Table>.Enumerator enumerator2 = default(List<Table>.Enumerator);
		Table current = default(Table);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		while (true)
		{
			switch (num)
			{
			case 1:
				updater.TablesDeletedActions.Add(new DbDeleteTableAction(base.Transform, (string)OMD0BAohORwGtvlXvUlC(base.Metadata)));
				num = 4;
				break;
			case 2:
				try
				{
					while (true)
					{
						IL_01cf:
						int num2;
						if (!enumerator.MoveNext())
						{
							num2 = 3;
							goto IL_0092;
						}
						goto IL_01a7;
						IL_0092:
						while (true)
						{
							switch (num2)
							{
							case 4:
								try
								{
									while (true)
									{
										IL_0138:
										int num3;
										if (!enumerator2.MoveNext())
										{
											num3 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
											{
												num3 = 2;
											}
											goto IL_00c4;
										}
										goto IL_00de;
										IL_00de:
										current = enumerator2.Current;
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
										{
											num3 = 1;
										}
										goto IL_00c4;
										IL_00c4:
										while (true)
										{
											switch (num3)
											{
											case 2:
												break;
											case 1:
												updater.TablesDeletedActions.Add(new DbDeleteTableAction(base.Transform, (string)imTuBXohn1dUSDFlhwTY(current)));
												num3 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
												{
													num3 = 0;
												}
												continue;
											default:
												goto IL_0138;
											case 3:
												goto end_IL_0138;
											}
											break;
										}
										goto IL_00de;
										continue;
										end_IL_0138:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
									{
										num4 = 0;
									}
									switch (num4)
									{
									case 0:
										break;
									}
								}
								goto IL_01cf;
							case 1:
								break;
							case 2:
								goto IL_01cf;
							default:
								enumerator2 = ((TypeDbStructures)INv8ZwohkaSOKvThDOBW(base.Metadata, entityPropertyMetadata)).Tables.GetEnumerator();
								num2 = 4;
								continue;
							case 3:
								goto end_IL_01cf;
							}
							break;
						}
						goto IL_01a7;
						IL_01a7:
						entityPropertyMetadata = (EntityPropertyMetadata)enumerator.Current;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
						{
							num2 = 0;
						}
						goto IL_0092;
						continue;
						end_IL_01cf:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			default:
				throw new DbModelException((string)KxB786ohTNSUpOyXAC7B(uk1HuIohXODubiWS18cW(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B34F8CF)), base.Metadata.FullTypeName));
			case 3:
				if (!UTr1RvohKolOJLWFfciH(base.Metadata.TableName))
				{
					enumerator = metadata.Properties.GetEnumerator();
					num = 2;
					break;
				}
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num = 0;
				}
				break;
			case 4:
				return;
			}
		}
	}

	public override void Execute()
	{
		base.Execute();
	}

	internal static void vFAQsjohqQLvcHvgf1eU()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool UTr1RvohKolOJLWFfciH(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object uk1HuIohXODubiWS18cW(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object KxB786ohTNSUpOyXAC7B(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object INv8ZwohkaSOKvThDOBW(object P_0, object P_1)
	{
		return DbModelHelper.GetPropertyDbStructures((EntityMetadata)P_0, (EntityPropertyMetadata)P_1);
	}

	internal static object imTuBXohn1dUSDFlhwTY(object P_0)
	{
		return ((Table)P_0).Name;
	}

	internal static object OMD0BAohORwGtvlXvUlC(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static bool rjPh2TohiMHxThXNHPKf()
	{
		return wfcN5YohStMGvb7O1W62 == null;
	}

	internal static DeleteEntityAction auLiYuohRQLaqjadxkU7()
	{
		return wfcN5YohStMGvb7O1W62;
	}
}

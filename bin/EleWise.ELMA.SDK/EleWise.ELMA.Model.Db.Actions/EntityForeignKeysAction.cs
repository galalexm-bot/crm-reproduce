using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db.Actions;

public class EntityForeignKeysAction : EntityAction
{
	private static EntityForeignKeysAction yxmoTuoGeKcvxv9iJUXB;

	public EntityForeignKeysAction(IDbModelUpdater updater, EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_002c, IL_0031, IL_00c2, IL_00cc, IL_00f4, IL_0103, IL_0210, IL_0223, IL_0232, IL_02da, IL_02ed, IL_02fc
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(updater, metadata);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 1;
		}
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		List<ForeignKey>.Enumerator enumerator2 = default(List<ForeignKey>.Enumerator);
		ForeignKey current = default(ForeignKey);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				throw new DbModelException((string)xforAJoGa3hvWyG6rypE(KHTLJwoGpDb77bFNQENk(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629733660)), base.Metadata.FullTypeName));
			case 1:
				if (!RPM2KcoG38h1sHQDVXNC(E7wMNRoGNnyfTW6Y1pik(base.Metadata)))
				{
					enumerator = base.Metadata.Properties.GetEnumerator();
					num = 2;
				}
				else
				{
					num = 3;
				}
				break;
			case 0:
				return;
			case 2:
				try
				{
					while (true)
					{
						int num2;
						if (!enumerator.MoveNext())
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num2 = 0;
							}
							goto IL_00d0;
						}
						goto IL_0286;
						IL_0286:
						entityPropertyMetadata = (EntityPropertyMetadata)enumerator.Current;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 3;
						}
						goto IL_00d0;
						IL_00d0:
						while (true)
						{
							switch (num2)
							{
							default:
								return;
							case 0:
								return;
							case 2:
								try
								{
									while (true)
									{
										IL_0187:
										int num3;
										if (!enumerator2.MoveNext())
										{
											num3 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
											{
												num3 = 0;
											}
											goto IL_0112;
										}
										goto IL_0130;
										IL_0130:
										current = enumerator2.Current;
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
										{
											num3 = 4;
										}
										goto IL_0112;
										IL_0112:
										while (true)
										{
											switch (num3)
											{
											case 2:
												goto IL_0130;
											case 4:
											{
												RAH64eoGw6gKoHThUgPQ(current, tHTfQ5oGtTN9BDVNVKrt(base.Updater, current.TableName, current.Columns[0]));
												int num4 = 3;
												num3 = num4;
												continue;
											}
											case 1:
												goto IL_0187;
											case 3:
												base.Updater.ForeignKeysCreatedActions.Add(new DbCreateForeignKeyAction(base.Transform, current));
												num3 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
												{
													num3 = 1;
												}
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
									((IDisposable)enumerator2).Dispose();
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
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
								enumerator2 = ((TypeDbStructures)dlh3HmoGDJFScU9LXe8X(base.Metadata, entityPropertyMetadata)).ForeignKeys.GetEnumerator();
								num2 = 2;
								continue;
							case 1:
								break;
							case 4:
								goto IL_0286;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	internal static object E7wMNRoGNnyfTW6Y1pik(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static bool RPM2KcoG38h1sHQDVXNC(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object KHTLJwoGpDb77bFNQENk(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object xforAJoGa3hvWyG6rypE(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object dlh3HmoGDJFScU9LXe8X(object P_0, object P_1)
	{
		return DbModelHelper.GetPropertyDbStructures((EntityMetadata)P_0, (EntityPropertyMetadata)P_1);
	}

	internal static object tHTfQ5oGtTN9BDVNVKrt(object P_0, object P_1, object P_2)
	{
		return ((IDbModelUpdater)P_0).GenerateForeignKeyName((string)P_1, (string)P_2);
	}

	internal static void RAH64eoGw6gKoHThUgPQ(object P_0, object P_1)
	{
		((ForeignKey)P_0).Name = (string)P_1;
	}

	internal static bool gZKndDoGPMO8aph2P6Go()
	{
		return yxmoTuoGeKcvxv9iJUXB == null;
	}

	internal static EntityForeignKeysAction vZN4eUoG18UGCPTTq08f()
	{
		return yxmoTuoGeKcvxv9iJUXB;
	}
}

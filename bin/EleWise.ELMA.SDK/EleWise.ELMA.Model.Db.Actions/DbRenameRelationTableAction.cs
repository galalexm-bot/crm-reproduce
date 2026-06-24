using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db.Actions;

public class DbRenameRelationTableAction : ModelAction
{
	private class MoveDataAction : DbAction
	{
		private object _query;

		internal static object b2fEM0CGAkZkMZqZBx6H;

		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return _003CEnabled_003Ek__BackingField;
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
					case 0:
						return;
					case 1:
						_003CEnabled_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public MoveDataAction(ITransformationProvider transform, string query)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			xV72xxCG0WPPYwl94u71();
			base._002Ector(transform);
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					_query = query;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public override void Execute()
		{
			//Discarded unreachable code: IL_0088
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					if (!Enabled)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 2;
				case 2:
					base.Transform.ExecuteNonQuery((string)_query);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 1:
					return;
				case 4:
					base.Execute();
					num2 = 3;
					break;
				}
			}
		}

		internal static void xV72xxCG0WPPYwl94u71()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool IKP51eCG7PmAsvYcetZx()
		{
			return b2fEM0CGAkZkMZqZBx6H == null;
		}

		internal static MoveDataAction JcLsqOCGxD0pDBrSQAgp()
		{
			return (MoveDataAction)b2fEM0CGAkZkMZqZBx6H;
		}
	}

	private EntityMetadata _parentMetadata;

	private EntityMetadata _childMetadata;

	private EntitySettings _oldSettings;

	private EntitySettings _newSettings;

	private MoveDataAction _moveDataAction;

	private static DbRenameRelationTableAction huRDF7oh2kPBSu59x0ne;

	public DbRenameRelationTableAction(IDbModelUpdater updater, ClassMetadata parentMetadata, ClassMetadata childMetadata, EntitySettings oldSettings, EntitySettings newSettings)
	{
		//Discarded unreachable code: IL_001b, IL_0020, IL_00a8, IL_02c6, IL_02d5, IL_0333, IL_0342, IL_039d
		WIaVU0oh1AoXY1pU2vwW();
		base._002Ector(updater);
		int num = 11;
		string query = default(string);
		Func<string, string> func = default(Func<string, string>);
		DbDeleteTableAction dbDeleteTableAction = default(DbDeleteTableAction);
		while (true)
		{
			switch (num)
			{
			case 21:
				return;
			case 22:
				return;
			case 20:
				query = (string)NIH3AaohD2GY11rQEv6w(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889602474), new object[9]
				{
					func(_newSettings.RelationTableName),
					func(_newSettings.ParentColumnName),
					func((string)U8qtuCohNIaX7sK5sl62(_newSettings)),
					func(_oldSettings.RelationTableName),
					func((string)Y5W5gnoh3NRTUF6dqyXC(_oldSettings)),
					func((string)U8qtuCohNIaX7sK5sl62(_oldSettings)),
					func((string)J8Ten5ohpZ6emSct9bSL(0x12441CA4 ^ 0x12449DFA)),
					func((string)MTlcIRoha3stw9W3P6ys(_parentMetadata)),
					func(_childMetadata.TableName)
				});
				num = 17;
				break;
			case 17:
				_moveDataAction = new MoveDataAction(base.Transform, query);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num = 0;
				}
				break;
			default:
				if (dbDeleteTableAction == null)
				{
					num = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num = 5;
					}
					break;
				}
				goto case 18;
			case 7:
				dbDeleteTableAction = new DbDeleteTableAction(base.Transform, (string)x7QB1hohtE4AL7OvALcG(_oldSettings));
				num = 8;
				break;
			case 9:
				if (_parentMetadata == null)
				{
					num = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num = 10;
					}
					break;
				}
				goto case 4;
			case 3:
				_newSettings = newSettings;
				num = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num = 4;
				}
				break;
			case 5:
			case 6:
				updater.TablesDeletedActions.Add(_moveDataAction);
				num = 13;
				break;
			case 8:
				updater.TablesDeletedActions.Add(dbDeleteTableAction);
				num = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num = 6;
				}
				break;
			case 4:
				if (_oldSettings == null)
				{
					return;
				}
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num = 0;
				}
				break;
			case 11:
				_parentMetadata = parentMetadata as EntityMetadata;
				num = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num = 0;
				}
				break;
			case 19:
				dbDeleteTableAction = updater.TablesDeletedActions.OfType<DbDeleteTableAction>().FirstOrDefault((DbDeleteTableAction a) => wV3tnWohyM0OyDKB2SZf(xbUCu3ohmQjKlTMDCQeF(a), x7QB1hohtE4AL7OvALcG(_oldSettings), StringComparison.CurrentCultureIgnoreCase));
				num = 2;
				break;
			case 15:
				_oldSettings = oldSettings;
				num = 3;
				break;
			case 18:
				updater.TablesDeletedActions.Insert(updater.TablesDeletedActions.IndexOf(dbDeleteTableAction), _moveDataAction);
				num = 14;
				break;
			case 13:
			case 14:
				if (dbDeleteTableAction != null)
				{
					num = 16;
					break;
				}
				goto case 7;
			case 16:
				return;
			case 10:
				_childMetadata = childMetadata as EntityMetadata;
				num = 15;
				break;
			case 2:
				if (_childMetadata != null)
				{
					num = 20;
					break;
				}
				goto case 13;
			case 12:
				return;
			case 1:
				if (_newSettings != null)
				{
					func = (string s) => (string)aRaccLoh0E2e1WEV86jl(IqmpMLohx5imfemImkxw(base.Transform), s);
					num = 19;
					break;
				}
				num = 22;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num = 14;
				}
				break;
			}
		}
	}

	public override void Execute()
	{
		//Discarded unreachable code: IL_0171, IL_01c2, IL_01d1
		int num = 1;
		Column column2 = default(Column);
		Column column3 = default(Column);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Column column;
				switch (num2)
				{
				default:
					if (_parentMetadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 11;
						}
						continue;
					}
					return;
				case 14:
					if (_childMetadata != null)
					{
						goto end_IL_0012;
					}
					goto case 9;
				case 10:
					column2 = (Column)vxQl6Moh6lUou4RYt9M2(_parentMetadata);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 6;
					}
					continue;
				case 6:
					wxpSdAohH0Qq4TUJwSFa(column2, Y5W5gnoh3NRTUF6dqyXC(_newSettings));
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
					base.Execute();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
				{
					ITransformationProvider transformationProvider = base.Transform;
					Table table = new Table();
					UtdrfjohAtVVM0jeS7Gt(table, x7QB1hohtE4AL7OvALcG(_newSettings));
					table.Columns = new List<Column> { column2, column3 };
					BGkPVVoh7jEFUU3EHx1c(transformationProvider, table);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				case 9:
					column = DbModelHelper.GetDefaultColumnForIdentifier();
					break;
				case 3:
					return;
				case 5:
					return;
				case 15:
					if (_moveDataAction != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 2;
				case 2:
					if (flag)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 10;
				case 16:
					if (_newSettings == null)
					{
						num2 = 12;
						continue;
					}
					flag = ILJtxQohwaOD6jj3X0Ou(base.Transform, _newSettings.RelationTableName);
					num2 = 15;
					continue;
				case 12:
					return;
				case 11:
					if (_oldSettings == null)
					{
						return;
					}
					num2 = 16;
					continue;
				case 7:
					wxpSdAohH0Qq4TUJwSFa(column3, U8qtuCohNIaX7sK5sl62(_newSettings));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					ajTGqIoh4HcW9VRy4d5V(_moveDataAction, ILJtxQohwaOD6jj3X0Ou(base.Transform, x7QB1hohtE4AL7OvALcG(_oldSettings)) && !flag);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 2;
					}
					continue;
				case 13:
					column = DbModelHelper.GetColumnForIdentifier(_childMetadata);
					break;
				}
				column3 = column;
				num2 = 7;
				continue;
				end_IL_0012:
				break;
			}
			num = 13;
		}
	}

	internal static void WIaVU0oh1AoXY1pU2vwW()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object U8qtuCohNIaX7sK5sl62(object P_0)
	{
		return ((EntitySettings)P_0).ChildColumnName;
	}

	internal static object Y5W5gnoh3NRTUF6dqyXC(object P_0)
	{
		return ((EntitySettings)P_0).ParentColumnName;
	}

	internal static object J8Ten5ohpZ6emSct9bSL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object MTlcIRoha3stw9W3P6ys(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static object NIH3AaohD2GY11rQEv6w(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object x7QB1hohtE4AL7OvALcG(object P_0)
	{
		return ((EntitySettings)P_0).RelationTableName;
	}

	internal static bool drV4J6oheP8sPC05YYNF()
	{
		return huRDF7oh2kPBSu59x0ne == null;
	}

	internal static DbRenameRelationTableAction M3T7dDohPC2l3wYV4ly5()
	{
		return huRDF7oh2kPBSu59x0ne;
	}

	internal static bool ILJtxQohwaOD6jj3X0Ou(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static void ajTGqIoh4HcW9VRy4d5V(object P_0, bool value)
	{
		((MoveDataAction)P_0).Enabled = value;
	}

	internal static object vxQl6Moh6lUou4RYt9M2(object P_0)
	{
		return DbModelHelper.GetColumnForIdentifier((EntityMetadata)P_0);
	}

	internal static void wxpSdAohH0Qq4TUJwSFa(object P_0, object P_1)
	{
		((Column)P_0).Name = (string)P_1;
	}

	internal static void UtdrfjohAtVVM0jeS7Gt(object P_0, object P_1)
	{
		((Table)P_0).Name = (string)P_1;
	}

	internal static void BGkPVVoh7jEFUU3EHx1c(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddTable((Table)P_1);
	}

	internal static object IqmpMLohx5imfemImkxw(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object aRaccLoh0E2e1WEV86jl(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object xbUCu3ohmQjKlTMDCQeF(object P_0)
	{
		return ((DbDeleteTableAction)P_0).TableName;
	}

	internal static bool wV3tnWohyM0OyDKB2SZf(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}
}

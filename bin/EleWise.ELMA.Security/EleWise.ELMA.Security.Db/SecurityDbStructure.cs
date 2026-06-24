using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Diagrams.Elements;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Properties;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Db;

public class SecurityDbStructure : DbStructureExtension
{
	private bool _systemUserCreated;

	private static Guid DigitalSignatureSettingsModuleUid;

	internal static SecurityDbStructure Am9l24b4xaEaxQfgfhT;

	public override Guid ProviderUid => Guid.Empty;

	public override Type[] References => new Type[1] { typeof(CoreDbStructure) };

	public void CreateGroupPermissions()
	{
		//Discarded unreachable code: IL_005b, IL_006a
		int num = 1;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		Table table = default(Table);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				return;
			case 1:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				f4QbPMb8iEjtw6hcvtI(serviceNotNull, table);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
				{
					num2 = 3;
				}
				break;
			case 4:
			{
				Table table2 = new Table();
				RoUxTwbgC64PWlceN7N(table2, tUlbGsbThr8tjuv0TFp(-1027693337 ^ -1027627895));
				table2.Columns = new List<Column>
				{
					new Column((string)tUlbGsbThr8tjuv0TFp(0x11C59687 ^ 0x11C5869F), DbType.Int64, ColumnProperty.PrimaryKey),
					new Column((string)tUlbGsbThr8tjuv0TFp(0x74C28149 ^ 0x74C29961), DbType.Guid, ColumnProperty.PrimaryKey)
				};
				table = table2;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
				{
					num2 = 5;
				}
				break;
			}
			default:
				if (WTGHKtbdWUHqrhNKlgF(serviceNotNull, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788380826 ^ -1788446456)))
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public void CreateUserSecuritySetCacheTable7()
	{
		//Discarded unreachable code: IL_0222, IL_0231, IL_033f, IL_0417, IL_0426, IL_0474, IL_0483
		int num = 2;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		Table table = default(Table);
		Table table2 = default(Table);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					CreateUserSecuritySetCacheTable(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E79A885 ^ 0x3E79E8DD));
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					CreateUserSecuritySetCacheTable(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x43ED0455 ^ 0x43EC04C7));
					num2 = 14;
					continue;
				case 10:
					if (!WTGHKtbdWUHqrhNKlgF(serviceNotNull, tUlbGsbThr8tjuv0TFp(-1757426405 ^ -1757441085)))
					{
						num2 = 16;
						continue;
					}
					goto case 6;
				case 11:
					f4QbPMb8iEjtw6hcvtI(serviceNotNull, table);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
					{
						num2 = 13;
					}
					continue;
				case 6:
					if (f0vDLcbraCuoqG2a7j9(serviceNotNull, tUlbGsbThr8tjuv0TFp(-1084772212 ^ -1084756396), tUlbGsbThr8tjuv0TFp(0x65F93013 ^ 0x65F83113)))
					{
						num2 = 12;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 9;
				case 14:
					CreateHistoryUserSecuritySetCacheTable((string)tUlbGsbThr8tjuv0TFp(--553267277 ^ 0x20FB308B));
					num2 = 7;
					continue;
				case 7:
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 10;
					continue;
				case 17:
					tUBHrnb3ci1MFPDvpca(serviceNotNull, tUlbGsbThr8tjuv0TFp(-163225536 ^ -163234120), new Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2030777218 ^ -2030711426), DbType.Int64));
					num2 = 15;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d != 0)
					{
						num2 = 14;
					}
					continue;
				case 8:
				case 12:
				case 13:
					if (WTGHKtbdWUHqrhNKlgF(serviceNotNull, tUlbGsbThr8tjuv0TFp(-905821499 ^ -905831363)))
					{
						num2 = 5;
						continue;
					}
					goto default;
				case 3:
					serviceNotNull.AddTable(table2);
					num2 = 16;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
					{
						num2 = 18;
					}
					continue;
				case 4:
					return;
				case 15:
					return;
				case 16:
					break;
				default:
				{
					Table table3 = new Table();
					RoUxTwbgC64PWlceN7N(table3, tUlbGsbThr8tjuv0TFp(0x3B1D6430 ^ 0x3B1D3AC8));
					table3.Columns = new List<Column>
					{
						new Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31C71464 ^ 0x31C70474), DbType.Int64, ColumnProperty.NotNull),
						new Column((string)tUlbGsbThr8tjuv0TFp(-1957236745 ^ -1957252813), DbType.Int32),
						new Column((string)tUlbGsbThr8tjuv0TFp(-566078848 ^ -566079078), DbType.Int64),
						new Column((string)tUlbGsbThr8tjuv0TFp(-1957236745 ^ -1957171465), DbType.Int64)
					};
					table2 = table3;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				case 9:
					serviceNotNull.AddColumn((string)tUlbGsbThr8tjuv0TFp(0x22A54A05 ^ 0x22A514DD), new Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x23D92C6F ^ 0x23D82D6F), DbType.Int64));
					num2 = 8;
					continue;
				case 18:
					return;
				case 5:
					if (f0vDLcbraCuoqG2a7j9(serviceNotNull, tUlbGsbThr8tjuv0TFp(0x335D4787 ^ 0x335D197F), tUlbGsbThr8tjuv0TFp(-726732645 ^ -726666853)))
					{
						num2 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 17;
				}
				break;
			}
			table = new Table
			{
				Name = (string)tUlbGsbThr8tjuv0TFp(-1027693337 ^ -1027671489),
				Columns = new List<Column>
				{
					new Column((string)tUlbGsbThr8tjuv0TFp(-1195916818 ^ -1195912706), DbType.Int64, ColumnProperty.NotNull),
					new Column((string)tUlbGsbThr8tjuv0TFp(-731479136 ^ -731456156), DbType.Int32),
					new Column((string)tUlbGsbThr8tjuv0TFp(0x31274285 ^ 0x3127419F), DbType.Int64),
					new Column((string)tUlbGsbThr8tjuv0TFp(0x32A45635 ^ 0x32A41333), DbType.Int64),
					new Column((string)tUlbGsbThr8tjuv0TFp(-784481839 ^ -784477751), DbType.Int64),
					new Column((string)tUlbGsbThr8tjuv0TFp(-1712587919 ^ -1712653711), DbType.Int64)
				}
			};
			num = 11;
		}
	}

	private void CreateHistoryUserSecuritySetCacheTable(string tableName)
	{
		//Discarded unreachable code: IL_02a0, IL_02b7, IL_02c6
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				int num = 9;
				int num2 = num;
				List<Column> list = default(List<Column>);
				Table table = default(Table);
				while (true)
				{
					switch (num2)
					{
					case 11:
						return;
					case 7:
						list.Add(new Column((string)tUlbGsbThr8tjuv0TFp(0x432996D0 ^ 0x4329C814), DbType.Int32));
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						f4QbPMb8iEjtw6hcvtI(serviceNotNull, table);
						num2 = 9;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
						{
							num2 = 11;
						}
						break;
					case 5:
						list.Add(new Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x22A54A05 ^ 0x22A5491F), DbType.Int64));
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 != 0)
						{
							num2 = 1;
						}
						break;
					case 6:
						list = new List<Column>();
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af == 0)
						{
							num2 = 10;
						}
						break;
					case 1:
						table = new Table
						{
							Name = tableName,
							Columns = list
						};
						num2 = 3;
						break;
					case 4:
						list.Add(new Column((string)tUlbGsbThr8tjuv0TFp(-2068904634 ^ -2068900514), DbType.Int64));
						num2 = 8;
						break;
					default:
						list.Add(new Column((string)tUlbGsbThr8tjuv0TFp(0x38328F00 ^ 0x3832809E), DbType.String, 36));
						num2 = 7;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b != 0)
						{
							num2 = 7;
						}
						break;
					case 8:
						list.Add(new Column((string)tUlbGsbThr8tjuv0TFp(-225736894 ^ -225802686), DbType.Int64));
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						list.Add(new Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x45F3B9A1 ^ 0x45F3FCA7), DbType.Int64));
						num2 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
						{
							num2 = 1;
						}
						break;
					case 10:
						list.Add(new Column((string)tUlbGsbThr8tjuv0TFp(0x67DFA65E ^ 0x67DFB64E), DbType.Int64));
						num2 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
						{
							num2 = 5;
						}
						break;
					case 9:
						if (WTGHKtbdWUHqrhNKlgF(serviceNotNull, tableName))
						{
							return;
						}
						num2 = 6;
						break;
					}
				}
			}
			catch (Exception)
			{
				int num3 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				break;
			}
		}
	}

	private void CreateUserSecuritySetCacheTable(string tableName)
	{
		//Discarded unreachable code: IL_00e6, IL_0116, IL_0212, IL_0221, IL_0231, IL_0240, IL_0359, IL_03c2, IL_03e0, IL_03ef, IL_045d, IL_046c, IL_04ac, IL_0553, IL_055d, IL_056c, IL_058d, IL_05a1, IL_05cb
		int num = 19;
		bool flag4 = default(bool);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		bool flag3 = default(bool);
		Column column = default(Column);
		Column column5 = default(Column);
		bool flag2 = default(bool);
		Column column2 = default(Column);
		bool flag5 = default(bool);
		Column column3 = default(Column);
		bool flag = default(bool);
		Table table2 = default(Table);
		Column column4 = default(Column);
		bool flag6 = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num5;
				int num7;
				int num6;
				int num3;
				int num4;
				switch (num2)
				{
				case 7:
					if (!flag4)
					{
						num2 = 15;
						continue;
					}
					return;
				case 19:
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 18;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
					{
						num2 = 12;
					}
					continue;
				case 14:
					return;
				case 24:
					if (flag3)
					{
						num = 16;
						break;
					}
					num5 = 0;
					goto IL_05eb;
				case 3:
					column = new Column((string)tUlbGsbThr8tjuv0TFp(-726732645 ^ -726666859), DbType.Boolean);
					num2 = 24;
					continue;
				case 15:
					tUBHrnb3ci1MFPDvpca(serviceNotNull, tableName, column5);
					num2 = 37;
					continue;
				case 9:
					if (!flag2)
					{
						num2 = 10;
						continue;
					}
					goto case 7;
				case 18:
					flag3 = WTGHKtbdWUHqrhNKlgF(serviceNotNull, tableName);
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 != 0)
					{
						num2 = 40;
					}
					continue;
				default:
					if (flag3)
					{
						num2 = 34;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 != 0)
						{
							num2 = 35;
						}
						continue;
					}
					goto case 36;
				case 1:
					tUBHrnb3ci1MFPDvpca(serviceNotNull, tableName, column2);
					num2 = 8;
					continue;
				case 28:
					if (flag3)
					{
						num2 = 44;
						continue;
					}
					goto default;
				case 23:
					if (flag3)
					{
						num2 = 10;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
						{
							num2 = 39;
						}
						continue;
					}
					num7 = 0;
					goto IL_0615;
				case 12:
					if (!flag2)
					{
						num2 = 5;
						continue;
					}
					goto case 26;
				case 2:
					if (!flag5)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 17;
				case 11:
					column3 = new Column((string)tUlbGsbThr8tjuv0TFp(0x271B34E4 ^ 0x271B24FC), DbType.Int64);
					num2 = 22;
					continue;
				case 40:
					column2 = new Column((string)tUlbGsbThr8tjuv0TFp(0x23D92C6F ^ 0x23D96D1F), DbType.Int64);
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 != 0)
					{
						num2 = 42;
					}
					continue;
				case 25:
					column5 = new Column((string)tUlbGsbThr8tjuv0TFp(0x40944BC4 ^ 0x40954AEC), DbType.Int32);
					num2 = 23;
					continue;
				case 41:
					if (flag3)
					{
						num2 = 4;
						continue;
					}
					num6 = 0;
					goto IL_0608;
				case 8:
					if (!flag5)
					{
						num = 13;
						break;
					}
					goto case 33;
				case 27:
					return;
				case 35:
					if (!flag)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 37:
					return;
				case 39:
					num7 = (f0vDLcbraCuoqG2a7j9(serviceNotNull, tableName, column5.Name) ? 1 : 0);
					goto IL_0615;
				case 22:
					if (!flag3)
					{
						num2 = 30;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 34;
				case 31:
					serviceNotNull.AddTable(table2);
					num = 27;
					break;
				case 10:
					serviceNotNull.AddColumn(tableName, column4);
					num = 7;
					break;
				case 4:
					num6 = (serviceNotNull.ColumnExists(tableName, (string)Sqojfcby55LZwnkPleM(column4)) ? 1 : 0);
					goto IL_0608;
				case 6:
					tUBHrnb3ci1MFPDvpca(serviceNotNull, tableName, column);
					num2 = 9;
					continue;
				case 21:
					column4 = new Column((string)tUlbGsbThr8tjuv0TFp(0xA5DAE86 ^ 0xA5DEB80), DbType.Int64);
					num2 = 41;
					continue;
				case 13:
					serviceNotNull.AddColumn(tableName, column3);
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 != 0)
					{
						num2 = 33;
					}
					continue;
				case 33:
					if (!flag6)
					{
						num2 = 6;
						continue;
					}
					goto case 9;
				case 42:
					if (!flag3)
					{
						num2 = 29;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 20;
				case 16:
					num5 = (f0vDLcbraCuoqG2a7j9(serviceNotNull, tableName, Sqojfcby55LZwnkPleM(column)) ? 1 : 0);
					goto IL_05eb;
				case 36:
				{
					Table table = new Table();
					RoUxTwbgC64PWlceN7N(table, tableName);
					table.Columns = new List<Column>
					{
						new Column((string)tUlbGsbThr8tjuv0TFp(-1757426405 ^ -1757492197), DbType.Int64, ColumnProperty.NotNull),
						new Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2CFDCC80 ^ 0x2CFDCF9A), DbType.Int64, ColumnProperty.NotNull),
						column2,
						column,
						column3,
						column4,
						column5
					};
					table2 = table;
					num2 = 31;
					continue;
				}
				case 34:
					num3 = (f0vDLcbraCuoqG2a7j9(serviceNotNull, tableName, Sqojfcby55LZwnkPleM(column3)) ? 1 : 0);
					goto IL_05de;
				case 17:
					if (!flag6)
					{
						num2 = 43;
						continue;
					}
					goto case 12;
				case 26:
					if (flag4)
					{
						num2 = 14;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto default;
				case 44:
					if (!flag)
					{
						num2 = 38;
						continue;
					}
					goto case 2;
				case 20:
					num4 = (f0vDLcbraCuoqG2a7j9(serviceNotNull, tableName, Sqojfcby55LZwnkPleM(column2)) ? 1 : 0);
					goto IL_05d1;
				case 29:
					num4 = 0;
					goto IL_05d1;
				case 30:
					{
						num3 = 0;
						goto IL_05de;
					}
					IL_05d1:
					flag = (byte)num4 != 0;
					num2 = 11;
					continue;
					IL_05de:
					flag5 = (byte)num3 != 0;
					num2 = 3;
					continue;
					IL_05eb:
					flag6 = (byte)num5 != 0;
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd != 0)
					{
						num2 = 21;
					}
					continue;
					IL_0615:
					flag4 = (byte)num7 != 0;
					num2 = 28;
					continue;
					IL_0608:
					flag2 = (byte)num6 != 0;
					num2 = 25;
					continue;
				}
				break;
			}
		}
	}

	public void CreateUserSecuritySetCacheTestTable4()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				CreateUserSecuritySetCacheTestTable((string)tUlbGsbThr8tjuv0TFp(0x1B47BFA1 ^ 0x1B46BE9F));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
				{
					num2 = 0;
				}
				break;
			default:
				CreateUserSecuritySetCacheTestTable(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--553267277 ^ 0x20FB313F));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	private void CreateUserSecuritySetCacheTestTable(string tableName)
	{
		//Discarded unreachable code: IL_00d1, IL_00e0, IL_00fe, IL_0140, IL_014f, IL_0184, IL_0193, IL_0293, IL_02a2, IL_02c1, IL_02cb, IL_02da
		int num = 5;
		Column column2 = default(Column);
		bool flag4 = default(bool);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		Column column = default(Column);
		Column column3 = default(Column);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		Table table = default(Table);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				int num4;
				int num5;
				switch (num2)
				{
				case 9:
					column2 = new Column((string)tUlbGsbThr8tjuv0TFp(0x3B1D6430 ^ 0x3B1D7428), DbType.Int64);
					num2 = 17;
					continue;
				case 12:
				case 21:
					if (flag4)
					{
						num2 = 19;
						continue;
					}
					goto case 18;
				case 30:
					return;
				case 16:
					num3 = (f0vDLcbraCuoqG2a7j9(serviceNotNull, tableName, Sqojfcby55LZwnkPleM(column)) ? 1 : 0);
					goto IL_0428;
				case 4:
					flag4 = WTGHKtbdWUHqrhNKlgF(serviceNotNull, tableName);
					num2 = 22;
					continue;
				case 7:
					serviceNotNull.AddColumn(tableName, column3);
					num2 = 13;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d != 0)
					{
						num2 = 23;
					}
					continue;
				case 10:
					if (flag2)
					{
						num = 3;
						break;
					}
					goto case 12;
				case 15:
					return;
				case 26:
					num4 = (f0vDLcbraCuoqG2a7j9(serviceNotNull, tableName, Sqojfcby55LZwnkPleM(column3)) ? 1 : 0);
					goto IL_03fe;
				case 13:
					if (flag)
					{
						num2 = 30;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 12;
				case 23:
				case 27:
					if (flag3)
					{
						num2 = 8;
						continue;
					}
					goto case 25;
				case 6:
					column = new Column((string)tUlbGsbThr8tjuv0TFp(0x335D4787 ^ 0x335C4689), DbType.Boolean);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
					{
						num2 = 1;
					}
					continue;
				case 24:
					f4QbPMb8iEjtw6hcvtI(serviceNotNull, table);
					num2 = 20;
					continue;
				case 1:
					if (!flag4)
					{
						num2 = 28;
						continue;
					}
					goto case 16;
				case 2:
					if (!flag4)
					{
						num2 = 21;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 10;
				case 25:
					tUBHrnb3ci1MFPDvpca(serviceNotNull, tableName, column2);
					num2 = 14;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
					{
						num2 = 7;
					}
					continue;
				case 17:
					if (flag4)
					{
						num2 = 11;
						continue;
					}
					num5 = 0;
					goto IL_040b;
				default:
					serviceNotNull.AddColumn(tableName, column);
					num = 15;
					break;
				case 3:
					if (flag3)
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 12;
				case 11:
					num5 = (serviceNotNull.ColumnExists(tableName, (string)Sqojfcby55LZwnkPleM(column2)) ? 1 : 0);
					goto IL_040b;
				case 18:
					table = new Table
					{
						Name = tableName,
						Columns = new List<Column>
						{
							new Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1869C442 ^ 0x1868C542), DbType.Int64, ColumnProperty.NotNull),
							new Column((string)tUlbGsbThr8tjuv0TFp(-1084772212 ^ -1084771434), DbType.Int64, ColumnProperty.NotNull),
							column2,
							column3,
							column
						}
					};
					num2 = 24;
					continue;
				case 22:
					column3 = new Column((string)tUlbGsbThr8tjuv0TFp(-905821499 ^ -905837643), DbType.Int64);
					num = 29;
					break;
				case 5:
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 4;
					continue;
				case 29:
					if (flag4)
					{
						num2 = 16;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 != 0)
						{
							num2 = 26;
						}
						continue;
					}
					num4 = 0;
					goto IL_03fe;
				case 20:
					return;
				case 19:
					if (flag2)
					{
						num2 = 17;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
						{
							num2 = 27;
						}
						continue;
					}
					goto case 7;
				case 8:
				case 14:
					if (flag)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 28:
					{
						num3 = 0;
						goto IL_0428;
					}
					IL_0428:
					flag = (byte)num3 != 0;
					num2 = 2;
					continue;
					IL_040b:
					flag3 = (byte)num5 != 0;
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f != 0)
					{
						num2 = 6;
					}
					continue;
					IL_03fe:
					flag2 = (byte)num4 != 0;
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	public void CreateUpdateUserSecuritySetCacheQueueTable()
	{
		//Discarded unreachable code: IL_0072
		int num = 3;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				if (!serviceNotNull.TableExists((string)tUlbGsbThr8tjuv0TFp(-959661060 ^ -959651292)))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 4:
				return;
			case 3:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			ITransformationProvider obj = serviceNotNull;
			Table table = new Table();
			RoUxTwbgC64PWlceN7N(table, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71CDF2F ^ 0x71C86F7));
			table.Columns = new List<Column>
			{
				new Column((string)tUlbGsbThr8tjuv0TFp(-1580392499 ^ -1580396461), DbType.Guid),
				new Column((string)tUlbGsbThr8tjuv0TFp(0x46347DA6 ^ 0x463426BC), DbType.DateTime),
				new Column((string)tUlbGsbThr8tjuv0TFp(-76932334 ^ -76922844), DbType.String, int.MaxValue)
			};
			table.Sequence = false;
			obj.AddTable(table);
			num2 = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 != 0)
			{
				num2 = 1;
			}
		}
	}

	public void CreateAdminUsers()
	{
		int num = 7;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					user.UserName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A799728 ^ 0x4A789686);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					((UserSecurityProfileManager)RSAZE4bSkn8YLlmEbdn()).CreateProfile(user, string.Empty).ForcedChangePassword = true;
					num2 = 8;
					continue;
				case 5:
					HiTtYJSp3votIprocfp(user);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					user = UserManager.Instance.Create();
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
					{
						num2 = 6;
					}
					continue;
				case 8:
					user.EmployDate = DateTime.Now;
					num2 = 2;
					continue;
				case 6:
					if (user == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 7:
					break;
				case 3:
					dGOHE1Sk4YGUZXfucHw(user, SecurityConstants.AdminUserUid);
					num2 = 5;
					continue;
				case 1:
					return;
				case 2:
					fCq57cbfBxONWUKe57b(user, RTwsgLb9cDaOVMVvj72(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x40096392 ^ 0x4008622E)));
					num2 = 10;
					continue;
				case 10:
					KATRwJbzTxaasIX4CDW(user, XBgt2eb1IetgDw0veXX(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1757426405 ^ -1757444867)));
					num2 = 3;
					continue;
				}
				break;
			}
			user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)g33VtnbbfJJhcR7YD0C()).LoadOrNull(SecurityConstants.AdminUserUid);
			num = 6;
		}
	}

	public void CreateSystemUsers()
	{
		//Discarded unreachable code: IL_01e7
		int num = 10;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 3:
				user.Photo = CreateSystemUserPhoto();
				num2 = 12;
				break;
			case 5:
				KATRwJbzTxaasIX4CDW(user, XBgt2eb1IetgDw0veXX(tUlbGsbThr8tjuv0TFp(0x6AA79E0 ^ 0x6AA3006)));
				num2 = 6;
				break;
			case 14:
				user.EmployDate = mge6fiSA6Ee6OrgrRm6();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 != 0)
				{
					num2 = 8;
				}
				break;
			case 12:
				user.Save();
				num2 = 11;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d != 0)
				{
					num2 = 11;
				}
				break;
			case 1:
			case 4:
				mxjUfWSnkf0A2csfSw1(nwa0SZSX6mNQLqUoB0t(Locator.GetServiceNotNull<ISessionProvider>(), ""));
				num2 = 7;
				break;
			case 10:
				user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)g33VtnbbfJJhcR7YD0C()).LoadOrNull(SecurityConstants.SystemUserUid);
				num2 = 9;
				break;
			case 2:
				user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)g33VtnbbfJJhcR7YD0C()).Create();
				num2 = 13;
				break;
			case 11:
				_systemUserCreated = true;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				dGOHE1Sk4YGUZXfucHw(user, SecurityConstants.SystemUserUid);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 != 0)
				{
					num2 = 15;
				}
				break;
			case 7:
				return;
			case 13:
				ACPOpdS5mBJ9TSPFFwe(user, tUlbGsbThr8tjuv0TFp(0x62C4BCE8 ^ 0x62C5BD32));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UserSecurityProfileManager.Instance.CreateProfile(user, string.Empty);
				num2 = 14;
				break;
			case 15:
				PBHGTnSWMeD1Yqic4vJ(user, UserStatus.System);
				num2 = 3;
				break;
			case 8:
				user.LastName = SR.T((string)tUlbGsbThr8tjuv0TFp(0x51BB29A6 ^ 0x51BA2848));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
				{
					num2 = 5;
				}
				break;
			case 9:
				if (user != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	internal void UpdateSystemUsers2()
	{
		//Discarded unreachable code: IL_0052, IL_0061, IL_0098, IL_0130, IL_018c, IL_019b
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				return;
			case 3:
				try
				{
					EleWise.ELMA.Security.Models.IUser user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)g33VtnbbfJJhcR7YD0C()).LoadOrNull(SecurityConstants.SystemUserUid);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						case 1:
							guy6lJSiKS5dYLog3V7(user, CreateSystemUserPhoto());
							num3 = 3;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							HiTtYJSp3votIprocfp(user);
							num3 = 2;
							continue;
						}
						if (user == null)
						{
							return;
						}
						num3 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
						{
							num3 = 1;
						}
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							return;
						}
						BAkbq0S6Ji0uMZkCDHl(vEqcYSS7KyMpTCmLA9M(), RTwsgLb9cDaOVMVvj72(tUlbGsbThr8tjuv0TFp(-905821499 ^ -905756475)), ex);
						num4 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
						{
							num4 = 0;
						}
					}
				}
			case 1:
				if (_systemUserCreated)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private BinaryFile CreateSystemUserPhoto()
	{
		int num = 1;
		int num2 = num;
		BinaryFile binaryFile = default(BinaryFile);
		IMimeMappingService serviceNotNull = default(IMimeMappingService);
		while (true)
		{
			switch (num2)
			{
			default:
				binaryFile = (BinaryFile)vJhC05SB9xvWEvMZuPU(nSIFeeSxjMeRETyfYBh(VlUkWrSNgj7MHfwqfEq(BinaryFile.CreateNew().Name((string)tUlbGsbThr8tjuv0TFp(0x48E9668D ^ 0x48E864E3)), yndQAJSlWpVpVfBsqYZ(serviceNotNull, tUlbGsbThr8tjuv0TFp(-2119527672 ^ -2119462522))), tL2kYtSZEUjF8tEBSkJ()));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				serviceNotNull = Locator.GetServiceNotNull<IMimeMappingService>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return binaryFile;
			case 2:
				N89XT0Smd5gLsl4SnIa(ER1qcbSuqUjvv1dbNt4(), binaryFile);
				num2 = 3;
				break;
			}
		}
	}

	public void SignInAdminUsers()
	{
		int num = 2;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				Locator.GetServiceNotNull<IAuthenticationService>().SetAuthenticatedUserForRequest(user);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)g33VtnbbfJJhcR7YD0C()).LoadOrNull(SecurityConstants.AdminUserUid);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (user == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public void CreateAdminGroups()
	{
		//Discarded unreachable code: IL_01ba
		int num = 1;
		IUserGroup userGroup = default(IUserGroup);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					mxjUfWSnkf0A2csfSw1(Locator.GetServiceNotNull<ISessionProvider>().GetSession(""));
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 != 0)
					{
						num2 = 2;
					}
					continue;
				default:
					if (userGroup != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 6;
				case 10:
				{
					if (user == null)
					{
						num = 9;
						break;
					}
					InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
					O7MiA5S2Zu1gsQZgGsN(instanceOf.New, SecurityConstants.AdminGroupDescriptor.Name);
					iOS0WySvBuS46qKIgvn(instanceOf.New, RIPgWkSPXAIa1KyfcAQ(SecurityConstants.AdminGroupDescriptor));
					Rpgi2mSC8neYKV5LdeM(instanceOf.New, user);
					IUserGroup @new = instanceOf.New;
					HashedSet<EleWise.ELMA.Security.Models.IUser> obj2 = new HashedSet<EleWise.ELMA.Security.Models.IUser>();
					((Set<EleWise.ELMA.Security.Models.IUser>)(object)obj2).Add(user);
					@new.Users = (ISet<EleWise.ELMA.Security.Models.IUser>)(object)obj2;
					userGroup = instanceOf.New;
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				case 9:
					throw new InvalidOperationException((string)bE1ed0SwnEOSh5T8sac(tUlbGsbThr8tjuv0TFp(-764392425 ^ -764326259), new object[1] { SecurityConstants.AdminUserUid }));
				case 2:
					return;
				case 8:
					X3trk4SU7UYPrS0md7H(userGroup, true);
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)g33VtnbbfJJhcR7YD0C()).LoadOrNull(SecurityConstants.AdminUserUid);
					num2 = 10;
					continue;
				case 4:
					HiTtYJSp3votIprocfp(userGroup);
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
				case 5:
					userGroup.Uid = SecurityConstants.AdminGroupUid;
					num = 8;
					break;
				case 1:
				{
					object obj = U4tvtqSeQobeNDbNjof();
					ParameterExpression parameterExpression = (ParameterExpression)YeVTYFSjUiBCmFnjMd9(UZLR21SLLEqps1DiEqT(typeof(IUserGroup).TypeHandle), tUlbGsbThr8tjuv0TFp(0x7DABA580 ^ 0x7DABEA66));
					userGroup = ((AbstractNHEntityManager<IUserGroup, long>)obj).Find(Expression.Lambda<Func<IUserGroup, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)E9SetBSHvogq3PdiJ4V((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)CS4THBSRKfwh4GImbN4(null, YDgKK3SaW5xaOuGrtYa((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), liftToNull: false, (MethodInfo)E9SetBSHvogq3PdiJ4V((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	public void CreateAllUsersGroups()
	{
		//Discarded unreachable code: IL_01b6, IL_01c5, IL_01d6
		int num = 11;
		IUserGroup userGroup = default(IUserGroup);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					HiTtYJSp3votIprocfp(userGroup);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					userGroup = ((AbstractNHEntityManager<IUserGroup, long>)U4tvtqSeQobeNDbNjof()).LoadOrNull(SecurityConstants.AllUsersGroupUid);
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd != 0)
					{
						num2 = 10;
					}
					continue;
				case 10:
					if (userGroup != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					break;
				case 9:
				case 12:
					goto end_IL_0012;
				case 3:
					throw new InvalidOperationException((string)bE1ed0SwnEOSh5T8sac(tUlbGsbThr8tjuv0TFp(-1957236745 ^ -1957171859), new object[1] { SecurityConstants.AdminUserUid }));
				case 1:
				{
					InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
					O7MiA5S2Zu1gsQZgGsN(instanceOf.New, BgGLGaSogmm2OIdiNEa(SecurityConstants.AllUsersGroupDescriptor));
					iOS0WySvBuS46qKIgvn(instanceOf.New, RIPgWkSPXAIa1KyfcAQ(SecurityConstants.AllUsersGroupDescriptor));
					Rpgi2mSC8neYKV5LdeM(instanceOf.New, user);
					IUserGroup @new = instanceOf.New;
					HashedSet<EleWise.ELMA.Security.Models.IUser> obj = new HashedSet<EleWise.ELMA.Security.Models.IUser>();
					((Set<EleWise.ELMA.Security.Models.IUser>)(object)obj).Add(user);
					@new.Users = (ISet<EleWise.ELMA.Security.Models.IUser>)(object)obj;
					userGroup = instanceOf.New;
					num2 = 12;
					continue;
				}
				case 2:
					Locator.GetServiceNotNull<ISessionProvider>().GetSession("").Flush();
					num2 = 8;
					continue;
				case 4:
					X3trk4SU7UYPrS0md7H(userGroup, true);
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					return;
				case 5:
					qIpOpSSKMV7GYn57sgT(userGroup, true);
					num2 = 6;
					continue;
				default:
					if (user != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				case 7:
					break;
				}
				user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)g33VtnbbfJJhcR7YD0C()).LoadOrNull(SecurityConstants.AdminUserUid);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			hrdwdDSJA1ZZoJrHGJF(userGroup, SecurityConstants.AllUsersGroupUid);
			num = 4;
		}
	}

	public void CreateConfiguringGroup()
	{
		int num = 7;
		IUserGroup userGroup = default(IUserGroup);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					break;
				case 3:
					userGroup.IsSystem = true;
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
					{
						num2 = 9;
					}
					continue;
				case 8:
					return;
				default:
					user = UserManager.Instance.LoadOrNull(SecurityConstants.AdminUserUid);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
				{
					if (user == null)
					{
						num2 = 4;
						continue;
					}
					InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
					O7MiA5S2Zu1gsQZgGsN(instanceOf.New, BgGLGaSogmm2OIdiNEa(SecurityConstants.ConfiguringGroupDescriptor));
					iOS0WySvBuS46qKIgvn(instanceOf.New, RIPgWkSPXAIa1KyfcAQ(SecurityConstants.ConfiguringGroupDescriptor));
					Rpgi2mSC8neYKV5LdeM(instanceOf.New, user);
					instanceOf.New.Users = (ISet<EleWise.ELMA.Security.Models.IUser>)(object)new HashedSet<EleWise.ELMA.Security.Models.IUser>();
					userGroup = instanceOf.New;
					num2 = 5;
					continue;
				}
				case 7:
				{
					object obj = U4tvtqSeQobeNDbNjof();
					ParameterExpression parameterExpression = (ParameterExpression)YeVTYFSjUiBCmFnjMd9(UZLR21SLLEqps1DiEqT(typeof(IUserGroup).TypeHandle), tUlbGsbThr8tjuv0TFp(-426925384 ^ -426906274));
					userGroup = ((AbstractNHEntityManager<IUserGroup, long>)obj).Find(Expression.Lambda<Func<IUserGroup, bool>>((Expression)xN1fTQShb0FSWeYCxk0(UqRvfeStV25sy8kGI6M(parameterExpression, (MethodInfo)E9SetBSHvogq3PdiJ4V((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), CS4THBSRKfwh4GImbN4(null, YDgKK3SaW5xaOuGrtYa((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), false, (MethodInfo)E9SetBSHvogq3PdiJ4V((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
					num2 = 6;
					continue;
				}
				case 9:
					HiTtYJSp3votIprocfp(userGroup);
					num2 = 2;
					continue;
				case 6:
					if (userGroup == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 4:
					throw new InvalidOperationException((string)bE1ed0SwnEOSh5T8sac(tUlbGsbThr8tjuv0TFp(-1965109395 ^ -1965044233), new object[1] { SecurityConstants.AdminUserUid }));
				case 2:
					mxjUfWSnkf0A2csfSw1(nwa0SZSX6mNQLqUoB0t(Locator.GetServiceNotNull<ISessionProvider>(), ""));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 != 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
			hrdwdDSJA1ZZoJrHGJF(userGroup, SecurityConstants.ConfiguringGroupUid);
			num = 3;
		}
	}

	public void CreateUsersManagementGroup()
	{
		//Discarded unreachable code: IL_0132, IL_0157
		int num = 6;
		int num2 = num;
		IUserGroup userGroup = default(IUserGroup);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 7:
				X3trk4SU7UYPrS0md7H(userGroup, true);
				num2 = 4;
				break;
			case 10:
				if (user != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 8;
			case 6:
			{
				object obj = U4tvtqSeQobeNDbNjof();
				ParameterExpression parameterExpression = Expression.Parameter(UZLR21SLLEqps1DiEqT(typeof(IUserGroup).TypeHandle), (string)tUlbGsbThr8tjuv0TFp(0x84482CB ^ 0x844CD2D));
				userGroup = ((AbstractNHEntityManager<IUserGroup, long>)obj).Find(Expression.Lambda<Func<IUserGroup, bool>>((Expression)xN1fTQShb0FSWeYCxk0(UqRvfeStV25sy8kGI6M(parameterExpression, (MethodInfo)E9SetBSHvogq3PdiJ4V((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), CS4THBSRKfwh4GImbN4(null, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), false, (MethodInfo)E9SetBSHvogq3PdiJ4V((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
				{
					num2 = 5;
				}
				break;
			}
			case 5:
				if (userGroup != null)
				{
					num2 = 9;
					break;
				}
				goto case 11;
			case 4:
				userGroup.Save();
				num2 = 3;
				break;
			case 2:
				return;
			case 11:
				user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)g33VtnbbfJJhcR7YD0C()).LoadOrNull(SecurityConstants.AdminUserUid);
				num2 = 10;
				break;
			default:
				hrdwdDSJA1ZZoJrHGJF(userGroup, SecurityConstants.UsersManagementGroupUid);
				num2 = 7;
				break;
			case 3:
				mxjUfWSnkf0A2csfSw1(nwa0SZSX6mNQLqUoB0t(Locator.GetServiceNotNull<ISessionProvider>(), ""));
				num2 = 2;
				break;
			case 8:
				throw new InvalidOperationException((string)bE1ed0SwnEOSh5T8sac(tUlbGsbThr8tjuv0TFp(0x4B68CDFB ^ 0x4B69CF61), new object[1] { SecurityConstants.AdminUserUid }));
			case 1:
			{
				InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
				O7MiA5S2Zu1gsQZgGsN(instanceOf.New, SecurityConstants.UsersManagementGroupDescriptor.Name);
				iOS0WySvBuS46qKIgvn(instanceOf.New, RIPgWkSPXAIa1KyfcAQ(SecurityConstants.UsersManagementGroupDescriptor));
				Rpgi2mSC8neYKV5LdeM(instanceOf.New, user);
				instanceOf.New.Users = (ISet<EleWise.ELMA.Security.Models.IUser>)(object)new HashedSet<EleWise.ELMA.Security.Models.IUser>();
				userGroup = instanceOf.New;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public void UpdateOrganizationModelChiefs()
	{
		//Discarded unreachable code: IL_0092, IL_00a1, IL_00da, IL_00e9, IL_00f4, IL_015a, IL_01aa, IL_01b9, IL_01ec, IL_01fb, IL_02c8, IL_0300, IL_0342, IL_0351
		int num = 4;
		int num2 = num;
		IOrganizationModel organizationModel = default(IOrganizationModel);
		IEnumerator<DepartmentElement> enumerator = default(IEnumerator<DepartmentElement>);
		DepartmentElement current = default(DepartmentElement);
		PositionElement positionElement = default(PositionElement);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
				if (rACZOUScJ5U1YrDGOSa(organizationModel) != null)
				{
					num2 = 2;
					break;
				}
				return;
			case 5:
				HiTtYJSp3votIprocfp(organizationModel);
				num2 = 6;
				break;
			case 4:
				organizationModel = (IOrganizationModel)X88UUUSqTNoIK5bMFPx(UGg8fYSObT6Oow6aIIJ());
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				return;
			case 3:
				if (organizationModel.Id <= 0)
				{
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 6;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
							{
								num3 = 1;
							}
							goto IL_00f8;
						}
						goto IL_01c4;
						IL_01c4:
						current = enumerator.Current;
						num3 = 9;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 != 0)
						{
							num3 = 9;
						}
						goto IL_00f8;
						IL_00f8:
						while (true)
						{
							object obj;
							switch (num3)
							{
							case 2:
							case 3:
							case 8:
								break;
							case 5:
								obj = null;
								goto IL_0286;
							case 1:
								if (wEnNZOS0gTFx2YjMfUQ(dXBHYRSFqJlgcU2CGgy(positionElement), RTwsgLb9cDaOVMVvj72(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-714706387 ^ -714641115))))
								{
									num3 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
									{
										num3 = 7;
									}
									continue;
								}
								break;
							case 10:
								goto IL_01c4;
							default:
								if (dXBHYRSFqJlgcU2CGgy(positionElement) == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
									{
										num3 = 8;
									}
									continue;
								}
								goto case 1;
							case 9:
								if (current.Composition == null)
								{
									num3 = 5;
									continue;
								}
								obj = current.Composition.OfType<PositionElement>().FirstOrDefault();
								goto IL_0286;
							case 7:
								positionElement.IsChief = true;
								num3 = 2;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
								{
									num3 = 2;
								}
								continue;
							case 4:
								if (positionElement == null)
								{
									num3 = 3;
									continue;
								}
								goto default;
							case 6:
								goto end_IL_012e;
								IL_0286:
								positionElement = (PositionElement)obj;
								num3 = 4;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
						continue;
						end_IL_012e:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								fpmSgYSEHiGdkH2ayIU(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 5;
			case 0:
				return;
			case 8:
				return;
			case 2:
				enumerator = ((IEnumerable)w1Qe2TSGPW3Flky69Gc(rACZOUScJ5U1YrDGOSa(organizationModel))).OfType<DepartmentElement>().GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void CreatePublicCacheTables()
	{
		int num = 2;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		Table table = default(Table);
		while (true)
		{
			switch (num2)
			{
			default:
				f4QbPMb8iEjtw6hcvtI(serviceNotNull, table);
				num2 = 4;
				break;
			case 3:
				return;
			case 1:
				if (!WTGHKtbdWUHqrhNKlgF(serviceNotNull, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-185816410 ^ -185855780)))
				{
					table = new Table
					{
						Name = (string)tUlbGsbThr8tjuv0TFp(0x40944BC4 ^ 0x4094F1BE),
						Columns = new List<Column>
						{
							new Column((string)tUlbGsbThr8tjuv0TFp(--561310391 ^ 0x2174502B), DbType.Int64, ColumnProperty.PrimaryKey),
							new Column((string)tUlbGsbThr8tjuv0TFp(0x335D4787 ^ 0x335DFCA7), DbType.Int64, ColumnProperty.PrimaryKey)
						}
					};
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
					{
						num2 = 3;
					}
				}
				break;
			case 4:
				return;
			case 2:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void CreatePublicCacheFK()
	{
		int num = 3;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
			{
				if (!serviceNotNull.TableExists(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5FD42272 ^ 0x5FD49808)))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
					{
						num2 = 1;
					}
					break;
				}
				ITransformationProvider obj = serviceNotNull;
				ForeignKey obj2 = new ForeignKey
				{
					Columns = new List<string> { (string)tUlbGsbThr8tjuv0TFp(0x6547C338 ^ 0x654779A4) }
				};
				DJ1aJWSDgnNFaZxwYjp(obj2, tUlbGsbThr8tjuv0TFp(0x432996D0 ^ 0x43292CAA));
				coYJp4SMl6eGj9wYblH(obj2, tUlbGsbThr8tjuv0TFp(-1084772212 ^ -1084836974));
				obj2.RefColumns = new List<string> { (string)tUlbGsbThr8tjuv0TFp(-724676315 ^ -724680395) };
				HxI8wBSswwfZrnrQIkc(obj2, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-225736894 ^ -225803252));
				F9IHigSYorA10rD48sN(obj2, EleWise.ELMA.Runtime.Db.Migrator.Framework.ForeignKeyConstraint.Cascade);
				G3RUSTSIs8WHcv5tFQl(obj2, EleWise.ELMA.Runtime.Db.Migrator.Framework.ForeignKeyConstraint.NoAction);
				XkBS7jS4v2E4EKlfRlp(obj, obj2);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
				return;
			}
		}
	}

	public void FillOrgItemSoftDeletable()
	{
		int num = 1;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				ITransformationProvider obj = serviceNotNull;
				object table = tUlbGsbThr8tjuv0TFp(0x6A336151 ^ 0x6A33A02F);
				string[] array = new string[1];
				ParameterExpression parameterExpression = (ParameterExpression)YeVTYFSjUiBCmFnjMd9(UZLR21SLLEqps1DiEqT(typeof(IOrganizationItem).TypeHandle), tUlbGsbThr8tjuv0TFp(0x5EE4A7B ^ 0x5EE0597));
				array[0] = LinqUtils.NameOf(Expression.Lambda<Func<IOrganizationItem, object>>((Expression)J9w2VaSVxDCX4dFxohb(UqRvfeStV25sy8kGI6M(parameterExpression, (MethodInfo)E9SetBSHvogq3PdiJ4V((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), UZLR21SLLEqps1DiEqT(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				object[] values = new object[1] { 0 };
				parameterExpression = (ParameterExpression)YeVTYFSjUiBCmFnjMd9(typeof(IOrganizationItem), tUlbGsbThr8tjuv0TFp(0x487E82CC ^ 0x487ECD20));
				obj.Update((string)table, array, values, (string)K7nsQDSQ8P7EVAC0jE8(LinqUtils.NameOf(Expression.Lambda<Func<IOrganizationItem, object>>((Expression)J9w2VaSVxDCX4dFxohb(UqRvfeStV25sy8kGI6M(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), UZLR21SLLEqps1DiEqT(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })), tUlbGsbThr8tjuv0TFp(0x416A5E3C ^ 0x416B5DBA)));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
			{
				ITransformationProvider obj2 = serviceNotNull;
				object table2 = tUlbGsbThr8tjuv0TFp(0x6547C338 ^ 0x65470246);
				string[] array2 = new string[1];
				ParameterExpression parameterExpression = (ParameterExpression)YeVTYFSjUiBCmFnjMd9(UZLR21SLLEqps1DiEqT(typeof(IOrganizationItem).TypeHandle), tUlbGsbThr8tjuv0TFp(--553267277 ^ 0x20FA7FA1));
				array2[0] = LinqUtils.NameOf(Expression.Lambda<Func<IOrganizationItem, object>>((Expression)J9w2VaSVxDCX4dFxohb(UqRvfeStV25sy8kGI6M(parameterExpression, (MethodInfo)E9SetBSHvogq3PdiJ4V((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
				object[] values2 = new object[1] { 0 };
				parameterExpression = (ParameterExpression)YeVTYFSjUiBCmFnjMd9(UZLR21SLLEqps1DiEqT(typeof(IOrganizationItem).TypeHandle), tUlbGsbThr8tjuv0TFp(0x67DFA65E ^ 0x67DFE9B2));
				obj2.Update((string)table2, array2, values2, (string)K7nsQDSQ8P7EVAC0jE8(LinqUtils.NameOf(Expression.Lambda<Func<IOrganizationItem, object>>((Expression)J9w2VaSVxDCX4dFxohb(UqRvfeStV25sy8kGI6M(parameterExpression, (MethodInfo)E9SetBSHvogq3PdiJ4V((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), UZLR21SLLEqps1DiEqT(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })), tUlbGsbThr8tjuv0TFp(0x1B3723C5 ^ 0x1B362043)));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
				{
					num2 = 3;
				}
				break;
			}
			case 3:
				return;
			case 1:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void RetrieveCertificationAuthoritySettings()
	{
		//Discarded unreachable code: IL_0061, IL_0104, IL_014c, IL_015b
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				string text = (string)TZmqtTST9YrwTDaCnyU(kEuEFnSdxGvvxwfWraR(), DigitalSignatureSettingsModuleUid, tUlbGsbThr8tjuv0TFp(0x417D81DE ^ 0x417C8244));
				int num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						return;
					case 1:
						((ISettingsManager)kEuEFnSdxGvvxwfWraR()).SetString(new Guid((string)tUlbGsbThr8tjuv0TFp(-434542700 ^ -434609112)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4B68CDFB ^ 0x4B69CE61), text);
						num = 2;
						continue;
					}
					if (I8tbi4Sgo0f7nThBai3(text))
					{
						return;
					}
					num = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
					{
						num = 1;
					}
				}
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					}
					BAkbq0S6Ji0uMZkCDHl(Logger.Log, ex.Message, ex);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
					{
						num2 = 1;
					}
				}
			}
		}
	}

	protected void DirectColumnConvert(string tableName, string columnName)
	{
		int num = 6;
		int num2 = num;
		string sql = default(string);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		string text = default(string);
		string deletingColumnTemporaryName = default(string);
		while (true)
		{
			switch (num2)
			{
			case 7:
				sql = (string)HfGvIxS3ZV83ZsQHVJ2(tUlbGsbThr8tjuv0TFp(--1983795824 ^ 0x763F5678), new object[4]
				{
					((Dialect)oZRK8gS8yvjNSUKaP23(serviceNotNull)).QuoteIfNeeded(tableName),
					pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), text),
					pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), deletingColumnTemporaryName),
					((Dialect)oZRK8gS8yvjNSUKaP23(serviceNotNull)).QuoteIfNeeded((string)tUlbGsbThr8tjuv0TFp(0x738E3073 ^ 0x738E2063))
				});
				num2 = 2;
				continue;
			case 1:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				deletingColumnTemporaryName = Locator.GetServiceNotNull<DbModelUpdater>().GetDeletingColumnTemporaryName(tableName, text);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				if (f0vDLcbraCuoqG2a7j9(serviceNotNull, tableName, deletingColumnTemporaryName))
				{
					num2 = 7;
					continue;
				}
				return;
			case 4:
				return;
			case 2:
				serviceNotNull.ExecuteNonQuery(sql);
				num2 = 4;
				continue;
			case 6:
				text = columnName;
				num2 = 5;
				continue;
			}
			if (f0vDLcbraCuoqG2a7j9(serviceNotNull, tableName, text))
			{
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
				{
					num2 = 3;
				}
				continue;
			}
			return;
		}
	}

	public void UserPublicKeyConvert()
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
				DirectColumnConvert(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x32A45635 ^ 0x32A55209), (string)tUlbGsbThr8tjuv0TFp(-1518425080 ^ -1518360468));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void ChangeUserNames()
	{
		B1ufkqSyDYoxctbK8Ro(g33VtnbbfJJhcR7YD0C());
	}

	public void CreateActiveUserSessionTable3()
	{
		//Discarded unreachable code: IL_02fa, IL_0309
		int num = 7;
		Table table = default(Table);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		Column column = default(Column);
		Column column2 = default(Column);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					table.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.LastPingDate, DbType.DateTime));
					num = 15;
					break;
				case 18:
					return;
				case 1:
					table.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.RemoteAddress, new ColumnType(DbType.String, 255)));
					num2 = 20;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
					{
						num2 = 22;
					}
					continue;
				case 7:
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 6;
					continue;
				case 19:
					table.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.TicketUid, DbType.Guid, ColumnProperty.PrimaryKey));
					num2 = 8;
					continue;
				case 17:
					if (f0vDLcbraCuoqG2a7j9(serviceNotNull, tUlbGsbThr8tjuv0TFp(0x31274285 ^ 0x3127404D), Sqojfcby55LZwnkPleM(column)))
					{
						num2 = 13;
						continue;
					}
					goto case 16;
				case 14:
					column2 = new Column(AuthenticatedSessionInfo.Db.Fields.SessionData, DbType.Binary);
					num2 = 9;
					continue;
				case 4:
					table.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.SessionId, new ColumnType(DbType.String, 255)));
					num2 = 21;
					continue;
				case 5:
					f4QbPMb8iEjtw6hcvtI(serviceNotNull, table);
					num2 = 10;
					continue;
				case 9:
					if (!WTGHKtbdWUHqrhNKlgF(serviceNotNull, tUlbGsbThr8tjuv0TFp(-163225536 ^ -163224952)))
					{
						table = new Table
						{
							Columns = new List<Column>(),
							Name = (string)tUlbGsbThr8tjuv0TFp(-730071140 ^ -730071724),
							Sequence = false
						};
						num2 = 19;
					}
					else
					{
						num2 = 17;
					}
					continue;
				case 15:
					table.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.LastActionInfo, new ColumnType(DbType.String, int.MaxValue)));
					num2 = 3;
					continue;
				case 20:
					table.Columns.Add(column);
					num2 = 4;
					continue;
				case 3:
					table.Columns.Add(column2);
					num2 = 5;
					continue;
				case 2:
					table.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.LastActionDate, DbType.DateTime));
					num2 = 11;
					continue;
				case 22:
					table.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.CreationDate, DbType.DateTime));
					num2 = 2;
					continue;
				case 12:
				case 13:
					if (f0vDLcbraCuoqG2a7j9(serviceNotNull, tUlbGsbThr8tjuv0TFp(0x84482CB ^ 0x8448003), Sqojfcby55LZwnkPleM(column2)))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					column = new Column(AuthenticatedSessionInfo.Db.Fields.Expiration, DbType.DateTime);
					num2 = 14;
					continue;
				default:
					tUBHrnb3ci1MFPDvpca(serviceNotNull, tUlbGsbThr8tjuv0TFp(-816887841 ^ -816888553), column2);
					num = 18;
					break;
				case 21:
					table.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.UserId, DbType.Int64));
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					table.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.Status, DbType.Int32));
					num2 = 20;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 != 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					return;
				case 16:
					tUBHrnb3ci1MFPDvpca(serviceNotNull, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x32A45635 ^ 0x32A454FD), column);
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	public void CreatePrivilegeUsersGroup()
	{
		int num = 10;
		int num2 = num;
		IUserGroup userGroup = default(IUserGroup);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 6:
				throw new InvalidOperationException((string)bE1ed0SwnEOSh5T8sac(tUlbGsbThr8tjuv0TFp(0x23D92C6F ^ 0x23D82EF5), new object[1] { SecurityConstants.AdminUserUid }));
			case 2:
				X3trk4SU7UYPrS0md7H(userGroup, true);
				num2 = 8;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
				{
					num2 = 6;
				}
				break;
			default:
				mxjUfWSnkf0A2csfSw1(Locator.GetServiceNotNull<ISessionProvider>().GetSession(""));
				num2 = 5;
				break;
			case 3:
				userGroup.Users.Add(user);
				num2 = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
				{
					num2 = 5;
				}
				break;
			case 1:
				if (user != null)
				{
					InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
					O7MiA5S2Zu1gsQZgGsN(instanceOf.New, RTwsgLb9cDaOVMVvj72(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x23D92C6F ^ 0x23D82815)));
					iOS0WySvBuS46qKIgvn(instanceOf.New, RTwsgLb9cDaOVMVvj72(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-698589567 ^ -698525111)));
					Rpgi2mSC8neYKV5LdeM(instanceOf.New, user);
					instanceOf.New.Users = (ISet<EleWise.ELMA.Security.Models.IUser>)(object)new HashedSet<EleWise.ELMA.Security.Models.IUser>();
					userGroup = instanceOf.New;
					num2 = 3;
				}
				else
				{
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
					{
						num2 = 4;
					}
				}
				break;
			case 5:
				return;
			case 10:
			{
				object obj = U4tvtqSeQobeNDbNjof();
				ParameterExpression parameterExpression = Expression.Parameter(UZLR21SLLEqps1DiEqT(typeof(IUserGroup).TypeHandle), (string)tUlbGsbThr8tjuv0TFp(-730071140 ^ -730091398));
				userGroup = ((AbstractNHEntityManager<IUserGroup, long>)obj).Find(Expression.Lambda<Func<IUserGroup, bool>>((Expression)xN1fTQShb0FSWeYCxk0(Expression.Property(parameterExpression, (MethodInfo)E9SetBSHvogq3PdiJ4V((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), CS4THBSRKfwh4GImbN4(null, YDgKK3SaW5xaOuGrtYa((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), false, (MethodInfo)E9SetBSHvogq3PdiJ4V((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
				num2 = 9;
				break;
			}
			case 7:
				userGroup.Uid = SecurityConstants.PrivilegeUsersGroupUid;
				num2 = 2;
				break;
			case 4:
				user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)g33VtnbbfJJhcR7YD0C()).LoadOrNull(SecurityConstants.AdminUserUid);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 != 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				if (userGroup == null)
				{
					num2 = 4;
					break;
				}
				goto case 7;
			case 8:
				userGroup.Save();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ConvertLangUserColumn()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				zVnkK9SbScfYPEoEcPc(Locator.GetServiceNotNull<ITransformationProvider>(), tUlbGsbThr8tjuv0TFp(-730071140 ^ -730075072), tUlbGsbThr8tjuv0TFp(-230994601 ^ -231061349), 10);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				mxjUfWSnkf0A2csfSw1(Locator.GetServiceNotNull<ISessionProvider>().GetSession(""));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public void SetDefaultLocalToUsers()
	{
		int num = 1;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		string sql = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 7:
				serviceNotNull.ExecuteNonQuery(sql);
				num2 = 6;
				break;
			case 5:
				serviceNotNull.ExecuteNonQuery(sql);
				num2 = 3;
				break;
			case 6:
				sql = (string)HfGvIxS3ZV83ZsQHVJ2(tUlbGsbThr8tjuv0TFp(-1757426405 ^ -1757492373), new object[4]
				{
					pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A336151 ^ 0x6A336E8D)),
					text,
					((Dialect)oZRK8gS8yvjNSUKaP23(serviceNotNull)).QuoteIfNeeded((string)tUlbGsbThr8tjuv0TFp(0x3E5BC59F ^ 0x3E5AC3CD)),
					pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), tUlbGsbThr8tjuv0TFp(-737960346 ^ -738026582))
				});
				num2 = 5;
				break;
			case 2:
				serviceNotNull.ExecuteNonQuery(sql);
				num2 = 4;
				break;
			case 4:
				Locator.GetServiceNotNull<ISessionProvider>().GetSession("").Flush();
				num2 = 8;
				break;
			case 9:
				sql = (string)HfGvIxS3ZV83ZsQHVJ2(tUlbGsbThr8tjuv0TFp(-2030777218 ^ -2030712410), new object[4]
				{
					pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-764392425 ^ -764394549)),
					text,
					pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), tUlbGsbThr8tjuv0TFp(0x84482CB ^ 0x8458707)),
					serviceNotNull.Dialect.QuoteIfNeeded((string)tUlbGsbThr8tjuv0TFp(-1378061210 ^ -1377996236))
				});
				num2 = 7;
				break;
			case 8:
				return;
			default:
				text = (string)aEwDyZSSM6aQlDKJCDb(SR.GetDefaultCulture());
				num2 = 9;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
				{
					num2 = 9;
				}
				break;
			case 3:
				sql = (string)HfGvIxS3ZV83ZsQHVJ2(tUlbGsbThr8tjuv0TFp(0x5FD42272 ^ 0x5FD524CE), new object[4]
				{
					pvvWalSr08nGXDNgFkx(serviceNotNull.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71BC7C31 ^ 0x71BC73ED)),
					text,
					pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), tUlbGsbThr8tjuv0TFp(0x6AA79E0 ^ 0x6AB7FB2)),
					pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), tUlbGsbThr8tjuv0TFp(0x6AA79E0 ^ 0x6AB7C2C))
				});
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void UpdateOldUsersCultures()
	{
		//Discarded unreachable code: IL_012e, IL_0138, IL_0239, IL_02fc, IL_033c, IL_034b, IL_0357, IL_0366, IL_0388, IL_0397, IL_03a2, IL_044a, IL_045d
		int num = 7;
		int num2 = num;
		string sql = default(string);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		List<string> list = default(List<string>);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		IDataReader dataReader = default(IDataReader);
		string text = default(string);
		CultureInfo cultureInfo = default(CultureInfo);
		string item = default(string);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 6:
				sql = string.Format((string)tUlbGsbThr8tjuv0TFp(0xBBC1CCD ^ 0xBBD1BC7), serviceNotNull.Dialect.QuoteIfNeeded((string)tUlbGsbThr8tjuv0TFp(0x48E9668D ^ 0x48E96951)), pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), tUlbGsbThr8tjuv0TFp(-1826813434 ^ -1826877494)));
				num2 = 8;
				break;
			case 8:
				list = new List<string>();
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				mxjUfWSnkf0A2csfSw1(nwa0SZSX6mNQLqUoB0t(Locator.GetServiceNotNull<ISessionProvider>(), ""));
				num2 = 2;
				break;
			case 1:
				enumerator = list.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				dataReader = serviceNotNull.ExecuteQuery(sql);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f != 0)
				{
					num2 = 0;
				}
				break;
			default:
				try
				{
					while (true)
					{
						int num5;
						if (!CvCfsU9k2uKGrZu6alo(dataReader))
						{
							num5 = 7;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af != 0)
							{
								num5 = 2;
							}
							goto IL_013c;
						}
						goto IL_0190;
						IL_01bc:
						text = (string)vGN49SSf4xY3OdKlqSU(lnoW7wS9qLjdL7qN05Q(dataReader, 0));
						num5 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
						{
							num5 = 0;
						}
						goto IL_013c;
						IL_013c:
						while (true)
						{
							switch (num5)
							{
							case 4:
							case 6:
								break;
							case 8:
								goto IL_0190;
							case 2:
								goto IL_01bc;
							case 3:
								cultureInfo = (CultureInfo)gVF9W3SzSZrsQJ3c8UT(text);
								num5 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
								{
									num5 = 1;
								}
								continue;
							default:
								if (!s4Hq9bS13djr8GK1PZn(text, tUlbGsbThr8tjuv0TFp(-724676315 ^ -724674371)))
								{
									num5 = 3;
									continue;
								}
								break;
							case 5:
								list.Add(item);
								num5 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 != 0)
								{
									num5 = 4;
								}
								continue;
							case 1:
								item = (string)HfGvIxS3ZV83ZsQHVJ2(tUlbGsbThr8tjuv0TFp(0x6547C338 ^ 0x6546C476), new object[4]
								{
									pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), tUlbGsbThr8tjuv0TFp(0x4E6718AE ^ 0x4E671772)),
									pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), tUlbGsbThr8tjuv0TFp(-1687496463 ^ -1687429827)),
									cultureInfo.Name,
									text
								});
								num5 = 5;
								continue;
							case 7:
								goto end_IL_016a;
							}
							break;
						}
						continue;
						IL_0190:
						if (dataReader[0] is DBNull)
						{
							num5 = 5;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
							{
								num5 = 6;
							}
							goto IL_013c;
						}
						goto IL_01bc;
						continue;
						end_IL_016a:
						break;
					}
				}
				finally
				{
					int num6;
					if (dataReader == null)
					{
						num6 = 2;
						goto IL_0300;
					}
					goto IL_0316;
					IL_0300:
					switch (num6)
					{
					case 2:
						goto end_IL_02eb;
					case 1:
						goto end_IL_02eb;
					}
					goto IL_0316;
					IL_0316:
					fpmSgYSEHiGdkH2ayIU(dataReader);
					num6 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
					{
						num6 = 1;
					}
					goto IL_0300;
					end_IL_02eb:;
				}
				goto case 1;
			case 7:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 6;
				break;
			case 5:
				try
				{
					while (true)
					{
						IL_03d3:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
							{
								num3 = 0;
							}
							goto IL_03a6;
						}
						goto IL_03c0;
						IL_03c0:
						current = enumerator.Current;
						num3 = 3;
						goto IL_03a6;
						IL_03a6:
						while (true)
						{
							switch (num3)
							{
							case 1:
								goto IL_03c0;
							case 2:
								goto IL_03d3;
							case 3:
								serviceNotNull.ExecuteNonQuery(current);
								num3 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
								{
									num3 = 2;
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
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 4;
			}
		}
	}

	public void UpdateSecurityCryptoSettings()
	{
		//Discarded unreachable code: IL_00f8, IL_018d, IL_01db, IL_01ea, IL_0383, IL_03c9, IL_03d8
		switch (1)
		{
		case 1:
			try
			{
				Guid guid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C648300 ^ 0x2C6580BC));
				int num = 8;
				string text2 = default(string);
				string text = default(string);
				string text3 = default(string);
				string value2 = default(string);
				string value = default(string);
				Guid result = default(Guid);
				Guid guid2 = default(Guid);
				while (true)
				{
					int num2;
					switch (num)
					{
					default:
						return;
					case 8:
						text2 = (string)TZmqtTST9YrwTDaCnyU(DataAccessManager.SettingsManager, guid, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1642017152 ^ -1641951974));
						num = 2;
						continue;
					case 13:
						text = (string)TZmqtTST9YrwTDaCnyU(kEuEFnSdxGvvxwfWraR(), DigitalSignatureSettingsModuleUid, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1869C442 ^ 0x1868C394));
						num = 5;
						continue;
					case 6:
						return;
					case 9:
						return;
					case 12:
						if (I8tbi4Sgo0f7nThBai3(text))
						{
							num = 6;
							continue;
						}
						goto case 7;
					case 2:
						text3 = (string)TZmqtTST9YrwTDaCnyU(kEuEFnSdxGvvxwfWraR(), guid, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1687496463 ^ -1687429293));
						num2 = 4;
						goto IL_004c;
					case 4:
						value2 = (string)TZmqtTST9YrwTDaCnyU(DataAccessManager.SettingsManager, guid, tUlbGsbThr8tjuv0TFp(-566078848 ^ -566012610));
						num = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
						{
							num = 1;
						}
						continue;
					case 5:
						value = (string)TZmqtTST9YrwTDaCnyU(DataAccessManager.SettingsManager, DigitalSignatureSettingsModuleUid, tUlbGsbThr8tjuv0TFp(0xC66FB14 ^ 0xC67F31E));
						num = 12;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
						{
							num = 12;
						}
						continue;
					case 0:
						return;
					case 14:
						if (i4FEVR9p0T8bCOPDIrD(result, guid2))
						{
							break;
						}
						num2 = 3;
						goto IL_004c;
					case 7:
						if (!Guid.TryParse(text, out result))
						{
							num = 9;
							continue;
						}
						goto case 11;
					case 11:
						guid2 = new Guid((string)tUlbGsbThr8tjuv0TFp(0xD946FDB ^ 0xD9567F1));
						num = 14;
						continue;
					case 1:
						result = Guid.Empty;
						num = 13;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
						{
							num = 0;
						}
						continue;
					case 3:
						if (!i4FEVR9p0T8bCOPDIrD(result, Guid.Empty))
						{
							num = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 != 0)
							{
								num = 0;
							}
							continue;
						}
						break;
					case 15:
						break;
					case 10:
						return;
						IL_004c:
						num = num2;
						continue;
					}
					ISettingsManager settingsManager = DataAccessManager.SettingsManager;
					Guid uid = new Guid((string)tUlbGsbThr8tjuv0TFp(-1642017152 ^ -1641953546));
					Dictionary<string, string> obj = new Dictionary<string, string>
					{
						{
							(string)tUlbGsbThr8tjuv0TFp(0xA5DAE86 ^ 0xA5CA68C),
							value
						},
						{
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x78610A3D ^ 0x78600D83),
							value2
						}
					};
					object key = tUlbGsbThr8tjuv0TFp(0x4E6718AE ^ 0x4E66106C);
					string value3;
					if (!S1VCBx95pA0kPul8B7G(text3))
					{
						List<CertificationAuthorityInfo> list = new List<CertificationAuthorityInfo>();
						CertificationAuthorityInfo certificationAuthorityInfo = new CertificationAuthorityInfo();
						efGseT9AcsxjyBvsyB8(certificationAuthorityInfo, text2);
						AZ70js9WLIdaU35ElDq(certificationAuthorityInfo, text3);
						list.Add(certificationAuthorityInfo);
						value3 = ClassSerializationHelper.SerializeObjectByJson(list);
					}
					else
					{
						value3 = string.Empty;
					}
					obj.Add((string)key, value3);
					settingsManager.SetStrings(uid, obj);
					num = 10;
				}
			}
			catch (Exception ex)
			{
				int num3 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 1:
						g2EciP9n7pdVZGoiJGc(vEqcYSS7KyMpTCmLA9M(), dhxuXe9XO467RBQe73F(ex));
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed != 0)
						{
							num3 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		case 0:
			break;
		}
	}

	public void FillUserCertificateCryptoProvider()
	{
		int num = 3;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 2;
				break;
			case 2:
				sql = string.Format((string)tUlbGsbThr8tjuv0TFp(0x67DFA65E ^ 0x67DEAEBA), pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), tUlbGsbThr8tjuv0TFp(0xC66FB14 ^ 0xC67F250)), pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), tUlbGsbThr8tjuv0TFp(0x4D765E72 ^ 0x4D775714)), wqJ6OG9i9QI3TKUd9n4(serviceNotNull));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				serviceNotNull.ExecuteNonQuery(sql, new Dictionary<string, object> { 
				{
					(string)tUlbGsbThr8tjuv0TFp(-1429500015 ^ -1429567969),
					new Guid((string)tUlbGsbThr8tjuv0TFp(0x3B056A9C ^ 0x3B0462EA))
				} });
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void FillUserCertificateCryptoAction()
	{
		int num = 2;
		int num2 = num;
		string sql = default(string);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				sql = (string)OJR3F297iv1K0RPTaMK(tUlbGsbThr8tjuv0TFp(-930147978 ^ -930211438), pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), tUlbGsbThr8tjuv0TFp(-1757426405 ^ -1757494177)), pvvWalSr08nGXDNgFkx(oZRK8gS8yvjNSUKaP23(serviceNotNull), tUlbGsbThr8tjuv0TFp(0x43ED0455 ^ 0x43EC0DCB)), serviceNotNull.ParameterSeparator);
				num2 = 3;
				break;
			case 3:
				serviceNotNull.ExecuteNonQuery(sql, new Dictionary<string, object> { 
				{
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788380826 ^ -1788448536),
					AuthCryptoAction.UID
				} });
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal void FillDefaultGroundsForAbsence()
	{
		//Discarded unreachable code: IL_0121, IL_01f0, IL_0203, IL_0212
		int num = 1;
		int num2 = num;
		Dictionary<Guid, string>.Enumerator enumerator = default(Dictionary<Guid, string>.Enumerator);
		KeyValuePair<Guid, string> current = default(KeyValuePair<Guid, string>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = new Dictionary<Guid, string>
				{
					{
						new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E6718AE ^ 0x4E66116C)),
						(string)RTwsgLb9cDaOVMVvj72(tUlbGsbThr8tjuv0TFp(0x23D92C6F ^ 0x23D82661))
					},
					{
						new Guid((string)tUlbGsbThr8tjuv0TFp(-1712587919 ^ -1712656067)),
						(string)RTwsgLb9cDaOVMVvj72(tUlbGsbThr8tjuv0TFp(0x335D4787 ^ 0x335C4D1F))
					},
					{
						new Guid((string)tUlbGsbThr8tjuv0TFp(-2037738356 ^ -2037670322)),
						(string)RTwsgLb9cDaOVMVvj72(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-208231202 ^ -208162864))
					},
					{
						new Guid((string)tUlbGsbThr8tjuv0TFp(-1801396866 ^ -1801333160)),
						(string)RTwsgLb9cDaOVMVvj72(tUlbGsbThr8tjuv0TFp(0x40944BC4 ^ 0x409540B6))
					}
				}.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_019e:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
						{
							num3 = 0;
						}
						goto IL_012f;
					}
					goto IL_0149;
					IL_0149:
					current = enumerator.Current;
					int num4 = 3;
					num3 = num4;
					goto IL_012f;
					IL_012f:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							break;
						case 3:
						{
							IGroundsForAbsence groundsForAbsence = InterfaceActivator.Create<IGroundsForAbsence>();
							la7b1B96MqDdBIaPpuu(groundsForAbsence, current.Key);
							p9EfAf9lShImLSTRQXZ(groundsForAbsence, current.Value);
							HiTtYJSp3votIprocfp(groundsForAbsence);
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						case 1:
							goto IL_019e;
						}
						break;
					}
					goto IL_0149;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num5 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				case 0:
					break;
				}
			}
		}
	}

	public SecurityDbStructure()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static SecurityDbStructure()
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
				O4DXcr9NYmjafqCksft();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				DigitalSignatureSettingsModuleUid = new Guid((string)tUlbGsbThr8tjuv0TFp(-930147978 ^ -930211080));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool HOcqBbbVUiwQDBZuG66()
	{
		return Am9l24b4xaEaxQfgfhT == null;
	}

	internal static SecurityDbStructure I8UOAXbQeT0jWxlNv5O()
	{
		return Am9l24b4xaEaxQfgfhT;
	}

	internal static bool WTGHKtbdWUHqrhNKlgF(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static object tUlbGsbThr8tjuv0TFp(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void RoUxTwbgC64PWlceN7N(object P_0, object P_1)
	{
		((Table)P_0).Name = (string)P_1;
	}

	internal static void f4QbPMb8iEjtw6hcvtI(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddTable((Table)P_1);
	}

	internal static bool f0vDLcbraCuoqG2a7j9(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).ColumnExists((string)P_1, (string)P_2);
	}

	internal static void tUBHrnb3ci1MFPDvpca(object P_0, object P_1, object P_2)
	{
		((ITransformationProvider)P_0).AddColumn((string)P_1, (Column)P_2);
	}

	internal static object Sqojfcby55LZwnkPleM(object P_0)
	{
		return ((Column)P_0).Name;
	}

	internal static object g33VtnbbfJJhcR7YD0C()
	{
		return UserManager.Instance;
	}

	internal static object RSAZE4bSkn8YLlmEbdn()
	{
		return UserSecurityProfileManager.Instance;
	}

	internal static object RTwsgLb9cDaOVMVvj72(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void fCq57cbfBxONWUKe57b(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).LastName = (string)P_1;
	}

	internal static object XBgt2eb1IetgDw0veXX(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static void KATRwJbzTxaasIX4CDW(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).FirstName = (string)P_1;
	}

	internal static void dGOHE1Sk4YGUZXfucHw(object P_0, Guid value)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).Uid = value;
	}

	internal static void HiTtYJSp3votIprocfp(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void ACPOpdS5mBJ9TSPFFwe(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).UserName = (string)P_1;
	}

	internal static DateTime mge6fiSA6Ee6OrgrRm6()
	{
		return DateTime.Now;
	}

	internal static void PBHGTnSWMeD1Yqic4vJ(object P_0, UserStatus value)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).Status = value;
	}

	internal static object nwa0SZSX6mNQLqUoB0t(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static void mxjUfWSnkf0A2csfSw1(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static void guy6lJSiKS5dYLog3V7(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.IUser)P_0).Photo = (BinaryFile)P_1;
	}

	internal static object vEqcYSS7KyMpTCmLA9M()
	{
		return Logger.Log;
	}

	internal static void BAkbq0S6Ji0uMZkCDHl(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object yndQAJSlWpVpVfBsqYZ(object P_0, object P_1)
	{
		return ((IMimeMappingService)P_0).GetTypeByExtension((string)P_1);
	}

	internal static object VlUkWrSNgj7MHfwqfEq(object P_0, object P_1)
	{
		return ((BinaryFileBuilder)P_0).ContentType((string)P_1);
	}

	internal static object tL2kYtSZEUjF8tEBSkJ()
	{
		return Resources.SystemUser;
	}

	internal static object nSIFeeSxjMeRETyfYBh(object P_0, object P_1)
	{
		return ((BinaryFileBuilder)P_0).Content((byte[])P_1);
	}

	internal static object vJhC05SB9xvWEvMZuPU(object P_0)
	{
		return ((BinaryFileBuilder)P_0).Build();
	}

	internal static object ER1qcbSuqUjvv1dbNt4()
	{
		return DataAccessManager.FileManager;
	}

	internal static object N89XT0Smd5gLsl4SnIa(object P_0, object P_1)
	{
		return ((IFileManager)P_0).SaveFile((BinaryFile)P_1);
	}

	internal static object U4tvtqSeQobeNDbNjof()
	{
		return UserGroupManager.Instance;
	}

	internal static Type UZLR21SLLEqps1DiEqT(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object YeVTYFSjUiBCmFnjMd9(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object E9SetBSHvogq3PdiJ4V(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object YDgKK3SaW5xaOuGrtYa(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object CS4THBSRKfwh4GImbN4(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object bE1ed0SwnEOSh5T8sac(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void O7MiA5S2Zu1gsQZgGsN(object P_0, object P_1)
	{
		((IUserGroup)P_0).Name = (string)P_1;
	}

	internal static object RIPgWkSPXAIa1KyfcAQ(object P_0)
	{
		return ((GroupDescriptor)P_0).Description;
	}

	internal static void iOS0WySvBuS46qKIgvn(object P_0, object P_1)
	{
		((IUserGroup)P_0).Description = (string)P_1;
	}

	internal static void Rpgi2mSC8neYKV5LdeM(object P_0, object P_1)
	{
		((IUserGroup)P_0).CreationAuthor = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void X3trk4SU7UYPrS0md7H(object P_0, bool value)
	{
		((IUserGroup)P_0).IsSystem = value;
	}

	internal static object BgGLGaSogmm2OIdiNEa(object P_0)
	{
		return ((GroupDescriptor)P_0).Name;
	}

	internal static void hrdwdDSJA1ZZoJrHGJF(object P_0, Guid value)
	{
		((IUserGroup)P_0).Uid = value;
	}

	internal static void qIpOpSSKMV7GYn57sgT(object P_0, bool value)
	{
		((IUserGroup)P_0).AddToNewUser = value;
	}

	internal static object UqRvfeStV25sy8kGI6M(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object xN1fTQShb0FSWeYCxk0(object P_0, object P_1, bool P_2, object P_3)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1, P_2, (MethodInfo)P_3);
	}

	internal static object UGg8fYSObT6Oow6aIIJ()
	{
		return OrganizationModelManager.Instance;
	}

	internal static object X88UUUSqTNoIK5bMFPx(object P_0)
	{
		return ((OrganizationModelManager)P_0).Load();
	}

	internal static object rACZOUScJ5U1YrDGOSa(object P_0)
	{
		return ((IOrganizationModel)P_0).Diagram;
	}

	internal static object w1Qe2TSGPW3Flky69Gc(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object dXBHYRSFqJlgcU2CGgy(object P_0)
	{
		return ((Element)P_0).LocalizableName;
	}

	internal static bool wEnNZOS0gTFx2YjMfUQ(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static void fpmSgYSEHiGdkH2ayIU(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void DJ1aJWSDgnNFaZxwYjp(object P_0, object P_1)
	{
		((ForeignKey)P_0).TableName = (string)P_1;
	}

	internal static void coYJp4SMl6eGj9wYblH(object P_0, object P_1)
	{
		((ForeignKey)P_0).RefTableName = (string)P_1;
	}

	internal static void HxI8wBSswwfZrnrQIkc(object P_0, object P_1)
	{
		((ForeignKey)P_0).Name = (string)P_1;
	}

	internal static void F9IHigSYorA10rD48sN(object P_0, EleWise.ELMA.Runtime.Db.Migrator.Framework.ForeignKeyConstraint P_1)
	{
		((ForeignKey)P_0).DeleteAction = P_1;
	}

	internal static void G3RUSTSIs8WHcv5tFQl(object P_0, EleWise.ELMA.Runtime.Db.Migrator.Framework.ForeignKeyConstraint P_1)
	{
		((ForeignKey)P_0).UpdateAction = P_1;
	}

	internal static void XkBS7jS4v2E4EKlfRlp(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddForeignKey((ForeignKey)P_1);
	}

	internal static object J9w2VaSVxDCX4dFxohb(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object K7nsQDSQ8P7EVAC0jE8(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object kEuEFnSdxGvvxwfWraR()
	{
		return DataAccessManager.SettingsManager;
	}

	internal static object TZmqtTST9YrwTDaCnyU(object P_0, Guid P_1, object P_2)
	{
		return ((ISettingsManager)P_0).GetString(P_1, (string)P_2);
	}

	internal static bool I8tbi4Sgo0f7nThBai3(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object oZRK8gS8yvjNSUKaP23(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object pvvWalSr08nGXDNgFkx(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object HfGvIxS3ZV83ZsQHVJ2(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static void B1ufkqSyDYoxctbK8Ro(object P_0)
	{
		((UserManager)P_0).ChangeUserNames();
	}

	internal static void zVnkK9SbScfYPEoEcPc(object P_0, object P_1, object P_2, int P_3)
	{
		((ITransformationProvider)P_0).ConvertColumnStringIfNeed((string)P_1, (string)P_2, P_3);
	}

	internal static object aEwDyZSSM6aQlDKJCDb(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static object lnoW7wS9qLjdL7qN05Q(object P_0, int P_1)
	{
		return ((IDataRecord)P_0)[P_1];
	}

	internal static object vGN49SSf4xY3OdKlqSU(object P_0)
	{
		return Convert.ToString(P_0);
	}

	internal static bool s4Hq9bS13djr8GK1PZn(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object gVF9W3SzSZrsQJ3c8UT(object P_0)
	{
		return CultureInfo.CreateSpecificCulture((string)P_0);
	}

	internal static bool CvCfsU9k2uKGrZu6alo(object P_0)
	{
		return ((IDataReader)P_0).Read();
	}

	internal static bool i4FEVR9p0T8bCOPDIrD(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool S1VCBx95pA0kPul8B7G(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static void efGseT9AcsxjyBvsyB8(object P_0, object P_1)
	{
		((CertificationAuthorityInfo)P_0).ServerAddress = (string)P_1;
	}

	internal static void AZ70js9WLIdaU35ElDq(object P_0, object P_1)
	{
		((CertificationAuthorityInfo)P_0).Thumbprint = (string)P_1;
	}

	internal static object dhxuXe9XO467RBQe73F(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void g2EciP9n7pdVZGoiJGc(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object wqJ6OG9i9QI3TKUd9n4(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object OJR3F297iv1K0RPTaMK(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void la7b1B96MqDdBIaPpuu(object P_0, Guid value)
	{
		((IGroundsForAbsence)P_0).Uid = value;
	}

	internal static void p9EfAf9lShImLSTRQXZ(object P_0, object P_1)
	{
		((IGroundsForAbsence)P_0).Name = (string)P_1;
	}

	internal static void O4DXcr9NYmjafqCksft()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}

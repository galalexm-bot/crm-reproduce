using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db;

public class CoreDbStructure : DbStructureExtension
{
	private static readonly ILogger DbUpdateLog;

	internal static CoreDbStructure sWlNbSoW5Ys2mQKZw99Z;

	public override Guid ProviderUid => Guid.Empty;

	public void CreateModuleReferenceMetadataTable()
	{
		int num = 1;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 1:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			case 3:
				return;
			}
			if (QXhLWYoWU3mVZKDq0iKd(serviceNotNull, FOteEaoWLQ1PYIw5Jowo(-1638402543 ^ -1638551045)))
			{
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 2;
				}
				continue;
			}
			ITransformationProvider obj = serviceNotNull;
			Table table = new Table();
			YwxxD7oWscxM0P7q9yow(table, FOteEaoWLQ1PYIw5Jowo(0x307E9FD1 ^ 0x307CD83B));
			table.Columns = new List<Column>
			{
				new Column((string)FOteEaoWLQ1PYIw5Jowo(-1852837372 ^ -1852982776), DbType.Guid, ColumnProperty.PrimaryKey),
				new Column((string)FOteEaoWLQ1PYIw5Jowo(-521266112 ^ -521233076), DbType.Guid)
			};
			i5jt1OoWce42sL56AZeD(obj, table);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
			{
				num2 = 3;
			}
		}
	}

	public void CreateDataClassTypeReferenceTable()
	{
		int num = 2;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 0:
				return;
			case 1:
				if (!QXhLWYoWU3mVZKDq0iKd(serviceNotNull, FOteEaoWLQ1PYIw5Jowo(-542721635 ^ -542838341)))
				{
					ITransformationProvider obj = serviceNotNull;
					Table table = new Table();
					YwxxD7oWscxM0P7q9yow(table, FOteEaoWLQ1PYIw5Jowo(0x4A1640F ^ 0x4A32C29));
					table.Columns = new List<Column>
					{
						new Column((string)FOteEaoWLQ1PYIw5Jowo(-889460160 ^ -889492706), DbType.Int64, ColumnProperty.PrimaryKey),
						new Column((string)FOteEaoWLQ1PYIw5Jowo(0x3A6135BE ^ 0x3A637DB2), DbType.Guid),
						new Column((string)FOteEaoWLQ1PYIw5Jowo(-35995181 ^ -36140667), DbType.Guid)
					};
					i5jt1OoWce42sL56AZeD(obj, table);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	public void CreateSystemFileTable4()
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
				return;
			case 2:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
			{
				Table table2 = new Table();
				YwxxD7oWscxM0P7q9yow(table2, FOteEaoWLQ1PYIw5Jowo(0x571EA399 ^ 0x571CEBF1));
				table2.Columns = new List<Column>
				{
					new Column((string)FOteEaoWLQ1PYIw5Jowo(0x1C9495B4 ^ 0x1C9414EA), DbType.Int32, ColumnProperty.PrimaryKey),
					new Column((string)FOteEaoWLQ1PYIw5Jowo(-195614443 ^ -195606905), DbType.Guid),
					new Column((string)FOteEaoWLQ1PYIw5Jowo(0x3B36AB09 ^ 0x3B36D8C9), DbType.String),
					new Column((string)FOteEaoWLQ1PYIw5Jowo(-978351861 ^ -978468489), DbType.String),
					new Column((string)FOteEaoWLQ1PYIw5Jowo(0x31326106 ^ 0x31302990), DbType.DateTime),
					new Column((string)FOteEaoWLQ1PYIw5Jowo(0x20261A4F ^ 0x202452E1), DbType.String),
					new Column((string)FOteEaoWLQ1PYIw5Jowo(-105199646 ^ -105345190), DbType.Int64),
					new Column((string)FOteEaoWLQ1PYIw5Jowo(0x17ADCCD8 ^ 0x17AF8414), DbType.Int32),
					new Column((string)FOteEaoWLQ1PYIw5Jowo(0x571EA399 ^ 0x571CEB47), DbType.String),
					new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72454A60), DbType.Boolean)
				};
				table = table2;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 3;
				}
				break;
			}
			case 0:
				return;
			case 1:
				if (serviceNotNull.TableExists((string)FOteEaoWLQ1PYIw5Jowo(0x3A5D5EF ^ 0x3A79D87)))
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				i5jt1OoWce42sL56AZeD(serviceNotNull, table);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void CreateConfigurationTypeInfoTable()
	{
		int num = 4;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		Table table2 = default(Table);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					if (!serviceNotNull.TableExists((string)FOteEaoWLQ1PYIw5Jowo(0x463A0F3C ^ 0x4638463C)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 2:
					i5jt1OoWce42sL56AZeD(serviceNotNull, table2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 1:
				{
					Table table = new Table();
					YwxxD7oWscxM0P7q9yow(table, FOteEaoWLQ1PYIw5Jowo(-29254301 ^ -29109149));
					table.Columns = new List<Column>
					{
						new Column((string)FOteEaoWLQ1PYIw5Jowo(0x4EA5403C ^ 0x4EA7091A), DbType.Int32)
					};
					table2 = table;
					num2 = 2;
					continue;
				}
				case 4:
					break;
				}
				break;
			}
			serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
			num = 3;
		}
	}

	public void SetUniqueUids()
	{
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				WZf8jBooBLOxH5Dte3pl(_003C_003Ec__DisplayClass7_.transformationProvider, 0, new Action(_003C_003Ec__DisplayClass7_._003CSetUniqueUids_003Eb__2));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			default:
				_003C_003Ec__DisplayClass7_.mdIgnoreList = ((ComponentManager)xRTBITooFP6e1PCopJFs()).GetExtensionPoints<IIgnoreUidUI>();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass7_.transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 4;
				break;
			case 4:
				_003C_003Ec__DisplayClass7_.mdList = from md in ((IMetadataService)iInrZwoWzq2dTFYVYRhY()).GetMetadataList().OfType<EntityMetadata>().Where(delegate(EntityMetadata md)
					{
						//Discarded unreachable code: IL_0068, IL_0077
						int num3 = 4;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (md.Type == EntityMetadataType.Entity)
								{
									return true;
								}
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
								{
									num4 = 0;
								}
								break;
							default:
								return _003C_003Ec.qJkvCuCb4vmSUFeo1MLw(md) == EntityMetadataType.InterfaceImplementation;
							case 3:
								return false;
							case 2:
								if (_003C_003Ec.tsoDrACbwaYAALkupkV7(_003C_003Ec.glKdCoCbtkgOhy7xGCUp(md), Guid.Empty))
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
									{
										num4 = 1;
									}
									break;
								}
								goto case 3;
							case 4:
								if (!md.IsUnique)
								{
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
									{
										num4 = 2;
									}
									break;
								}
								goto case 2;
							}
						}
					})
					orderby md.TableName
					select md;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void CreateIndexesForReferenceObject()
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass8_.transform = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return;
			case 3:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 2;
				continue;
			}
			(from m in ((IMetadataService)iInrZwoWzq2dTFYVYRhY()).GetMetadataList().OfType<EntityMetadata>().Where(delegate(EntityMetadata m)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 1:
							if (_003C_003Ec.qJkvCuCb4vmSUFeo1MLw(m) == EntityMetadataType.InterfaceImplementation)
							{
								return true;
							}
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num4 = 0;
							}
							break;
						default:
							return _003C_003Ec.qJkvCuCb4vmSUFeo1MLw(m) == EntityMetadataType.Entity;
						}
					}
				})
				where m.Properties.Any((PropertyMetadata p) => _003C_003Ec.tsoDrACbwaYAALkupkV7(_003C_003Ec.fWv57ECb6iDf3Mu1o2ZH(p), ReferenceOnEntityDecription.UID))
				select m).ToList().ForEach(_003C_003Ec__DisplayClass8_._003CCreateIndexesForReferenceObject_003Eb__2);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
			{
				num2 = 1;
			}
		}
	}

	public void CreateIndexesForAllSoftDeletable()
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass9_.service = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				num2 = 3;
				break;
			case 1:
				_003C_003Ec__DisplayClass9_.transform = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			case 3:
				_003C_003Ec__DisplayClass9_.service.GetMetadataList().OfType<EntityMetadata>().Where(delegate(EntityMetadata m)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 1:
							if (_003C_003Ec.qJkvCuCb4vmSUFeo1MLw(m) == EntityMetadataType.InterfaceImplementation)
							{
								return true;
							}
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
							{
								num4 = 0;
							}
							break;
						default:
							return _003C_003Ec.qJkvCuCb4vmSUFeo1MLw(m) == EntityMetadataType.Entity;
						}
					}
				})
					.Where(_003C_003Ec__DisplayClass9_._003CCreateIndexesForAllSoftDeletable_003Eb__1)
					.ToList()
					.ForEach(_003C_003Ec__DisplayClass9_._003CCreateIndexesForAllSoftDeletable_003Eb__2);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public void CreateFormViewItemDependencies()
	{
		//Discarded unreachable code: IL_003a, IL_00db, IL_0100, IL_010f, IL_0153, IL_018b, IL_019a, IL_01bf, IL_0273, IL_02a9, IL_02bc, IL_02cb
		int num = 3;
		int num2 = num;
		IEnumerator<EntityMetadata> enumerator2 = default(IEnumerator<EntityMetadata>);
		Action<EntityMetadata> action = default(Action<EntityMetadata>);
		EntityMetadata current = default(EntityMetadata);
		List<EntityMetadata> list = default(List<EntityMetadata>);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_;
		List<IMetadataItem>.Enumerator enumerator = default(List<IMetadataItem>.Enumerator);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!qIGrXsooW1QhykJ86KBT(enumerator2))
						{
							num3 = 3;
							goto IL_004c;
						}
						goto IL_011a;
						IL_004c:
						while (true)
						{
							switch (num3)
							{
							default:
							{
								action(current);
								int num4 = 6;
								num3 = num4;
								continue;
							}
							case 7:
								if (!current.IsConfig())
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 4;
							case 4:
								list.Add(current);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
							case 6:
								break;
							case 5:
								goto IL_011a;
							case 3:
								goto end_IL_00e5;
							}
							break;
						}
						continue;
						IL_011a:
						current = enumerator2.Current;
						num3 = 7;
						goto IL_004c;
						continue;
						end_IL_00e5:
						break;
					}
				}
				finally
				{
					if (enumerator2 != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								enumerator2.Dispose();
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
								{
									num5 = 1;
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
			case 1:
				return;
			case 5:
				list.ForEach(action);
				num2 = 4;
				continue;
			case 3:
			{
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				_003C_003Ec__DisplayClass10_.service = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				action = delegate(EntityMetadata metadata)
				{
					//Discarded unreachable code: IL_015e, IL_016d, IL_030c, IL_031b, IL_040d, IL_0420, IL_0442, IL_044c, IL_0558, IL_056b, IL_057a
					int num9 = 15;
					int num10 = num9;
					_003C_003Ec__DisplayClass10_1 _003C_003Ec__DisplayClass10_2 = default(_003C_003Ec__DisplayClass10_1);
					List<FormViewItemTransformation> list3 = default(List<FormViewItemTransformation>);
					EntityMetadata entityMetadata2 = default(EntityMetadata);
					List<Guid> list2 = default(List<Guid>);
					List<FormViewItemTransformation>.Enumerator enumerator3 = default(List<FormViewItemTransformation>.Enumerator);
					_003C_003Ec__DisplayClass10_4 _003C_003Ec__DisplayClass10_5 = default(_003C_003Ec__DisplayClass10_4);
					_003C_003Ec__DisplayClass10_3 _003C_003Ec__DisplayClass10_4 = default(_003C_003Ec__DisplayClass10_3);
					_003C_003Ec__DisplayClass10_2 _003C_003Ec__DisplayClass10_3 = default(_003C_003Ec__DisplayClass10_2);
					while (true)
					{
						switch (num10)
						{
						case 4:
							_003C_003Ec__DisplayClass10_2.objectUid = _003C_003Ec__DisplayClass10_0.oYnARpChXLr6GDBnge1c(metadata);
							num10 = 16;
							break;
						case 6:
							_003C_003Ec__DisplayClass10_2.deps = new List<IFormDependencyData>();
							num10 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
							{
								num10 = 1;
							}
							break;
						case 12:
							if (_003C_003Ec__DisplayClass10_0.u4uoxfChOousOof7Y1hJ(_003C_003Ec__DisplayClass10_2.deps) == 0)
							{
								num10 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
								{
									num10 = 6;
								}
							}
							else
							{
								FormDependencyHelper.Update(_003C_003Ec__DisplayClass10_0.kLSibjChT2heZlRNPkHl(metadata), _003C_003Ec__DisplayClass10_2.deps.ToArray());
								num10 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num10 = 1;
								}
							}
							break;
						case 18:
							list3 = metadata.FormTransformations.ToList();
							num10 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
							{
								num10 = 10;
							}
							break;
						case 9:
							if (entityMetadata2 != null)
							{
								num10 = 8;
								break;
							}
							goto case 6;
						default:
							if (metadata.FormTransformations.Count == 0)
							{
								num10 = 5;
							}
							else
							{
								list2 = new List<Guid>();
								num10 = 18;
							}
							break;
						case 11:
							return;
						case 7:
							try
							{
								while (true)
								{
									int num13;
									if (!enumerator3.MoveNext())
									{
										num13 = 10;
										goto IL_017c;
									}
									goto IL_02f6;
									IL_017c:
									while (true)
									{
										switch (num13)
										{
										case 8:
											_003C_003Ec__DisplayClass10_5.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass10_4;
											num13 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
											{
												num13 = 14;
											}
											continue;
										case 12:
											_003C_003Ec__DisplayClass10_5.dependType = FormDependencyDataType.Inherit;
											num13 = 7;
											continue;
										case 2:
											_003C_003Ec__DisplayClass10_5.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.deps.Add(new FormDependencyData(_003C_003Ec__DisplayClass10_5.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.objectUid, _003C_003Ec__DisplayClass10_5.dependFormUid, _003C_003Ec__DisplayClass10_5.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.objectUid, _003C_003Ec__DisplayClass10_5.CS_0024_003C_003E8__locals2.t.Uid, _003C_003Ec__DisplayClass10_5.dependType));
											num13 = 11;
											continue;
										case 13:
											break;
										case 7:
											if (!_003C_003Ec__DisplayClass10_0.m2afZfChnQJvmqm3PC9e(_003C_003Ec__DisplayClass10_0.cQHPA8ChkqLoivvUlFZh(_003C_003Ec__DisplayClass10_5.CS_0024_003C_003E8__locals2.t), Guid.Empty))
											{
												num13 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
												{
													num13 = 3;
												}
												continue;
											}
											goto case 9;
										case 4:
											_003C_003Ec__DisplayClass10_4.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass10_2;
											num13 = 5;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
											{
												num13 = 1;
											}
											continue;
										case 14:
										{
											_003C_003Ec__DisplayClass10_5.dependFormUid = _003C_003Ec__DisplayClass10_5.CS_0024_003C_003E8__locals2.t.Uid;
											int num14 = 12;
											num13 = num14;
											continue;
										}
										case 6:
											goto IL_02f6;
										default:
											_003C_003Ec__DisplayClass10_5.dependType = FormDependencyDataType.Child;
											num13 = 2;
											continue;
										case 3:
										case 11:
											list2.ForEach(_003C_003Ec__DisplayClass10_5._003CCreateFormViewItemDependencies_003Eb__7);
											num13 = 13;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
											{
												num13 = 11;
											}
											continue;
										case 1:
											_003C_003Ec__DisplayClass10_5 = new _003C_003Ec__DisplayClass10_4();
											num13 = 8;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
											{
												num13 = 8;
											}
											continue;
										case 9:
											_003C_003Ec__DisplayClass10_5.dependFormUid = _003C_003Ec__DisplayClass10_0.cQHPA8ChkqLoivvUlFZh(_003C_003Ec__DisplayClass10_5.CS_0024_003C_003E8__locals2.t);
											num13 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
											{
												num13 = 0;
											}
											continue;
										case 5:
											_003C_003Ec__DisplayClass10_4.t = enumerator3.Current;
											num13 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
											{
												num13 = 1;
											}
											continue;
										case 10:
											goto end_IL_025d;
										}
										break;
									}
									continue;
									IL_02f6:
									_003C_003Ec__DisplayClass10_4 = new _003C_003Ec__DisplayClass10_3();
									num13 = 4;
									goto IL_017c;
									continue;
									end_IL_025d:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator3).Dispose();
								int num15 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num15 = 0;
								}
								switch (num15)
								{
								case 0:
									break;
								}
							}
							goto case 12;
						case 5:
							return;
						case 3:
							try
							{
								while (true)
								{
									int num11;
									if (!enumerator3.MoveNext())
									{
										num11 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
										{
											num11 = 0;
										}
										goto IL_0450;
									}
									goto IL_050b;
									IL_050b:
									_003C_003Ec__DisplayClass10_3 = new _003C_003Ec__DisplayClass10_2();
									num11 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
									{
										num11 = 4;
									}
									goto IL_0450;
									IL_0450:
									while (true)
									{
										switch (num11)
										{
										case 5:
											list3.Add(_003C_003Ec__DisplayClass10_3.t);
											num11 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
											{
												num11 = 0;
											}
											continue;
										case 2:
											if (!list3.Any(_003C_003Ec__DisplayClass10_3._003CCreateFormViewItemDependencies_003Eb__6))
											{
												num11 = 5;
												continue;
											}
											break;
										case 4:
											_003C_003Ec__DisplayClass10_3.t = enumerator3.Current;
											num11 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
											{
												num11 = 2;
											}
											continue;
										case 3:
											goto IL_050b;
										case 1:
											goto end_IL_04e5;
										}
										break;
									}
									continue;
									end_IL_04e5:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator3).Dispose();
								int num12 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
								{
									num12 = 0;
								}
								switch (num12)
								{
								case 0:
									break;
								}
							}
							goto case 6;
						case 16:
							entityMetadata2 = _003C_003Ec__DisplayClass10_.service.GetMetadata(_003C_003Ec__DisplayClass10_0.oYnARpChXLr6GDBnge1c(metadata), loadImplementation: false) as EntityMetadata;
							num10 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num10 = 4;
							}
							break;
						case 14:
							if (metadata == null)
							{
								return;
							}
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num10 = 0;
							}
							break;
						case 13:
							enumerator3 = entityMetadata2.FormTransformations.GetEnumerator();
							num10 = 3;
							break;
						case 1:
							return;
						case 2:
							enumerator3 = list3.GetEnumerator();
							num10 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
							{
								num10 = 2;
							}
							break;
						case 15:
							_003C_003Ec__DisplayClass10_2 = new _003C_003Ec__DisplayClass10_1();
							num10 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num10 = 14;
							}
							break;
						case 10:
							if (metadata.Type == EntityMetadataType.InterfaceExtension)
							{
								num10 = 4;
								break;
							}
							goto case 19;
						case 19:
							_003C_003Ec__DisplayClass10_2.objectUid = _003C_003Ec__DisplayClass10_0.kLSibjChT2heZlRNPkHl(metadata);
							num10 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
							{
								num10 = 17;
							}
							break;
						case 8:
							list2.AddRange(from q in MetadataLoader.GetBaseClassMetadataList(entityMetadata2, includeExtensions: false, loadImplementation: false)
								select _003C_003Ec.mROHVUCbxcxecfDjD4Em(q));
							num10 = 13;
							break;
						case 17:
							list2.AddRange(from q in MetadataLoader.GetBaseClassMetadataList(metadata, includeExtensions: false, loadImplementation: false)
								select q.Uid);
							num10 = 6;
							break;
						}
					}
				};
				List<EntityMetadata> source = _003C_003Ec__DisplayClass10_.service.GetMetadataList().OfType<EntityMetadata>().ToList();
				source.Where((EntityMetadata q) => q.Type == EntityMetadataType.Interface).ForEach(action);
				list = new List<EntityMetadata>();
				enumerator2 = source.Where((EntityMetadata q) => _003C_003Ec.qJkvCuCb4vmSUFeo1MLw(q) == EntityMetadataType.InterfaceExtension).GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 2;
				}
				continue;
			}
			case 4:
			{
				IEntityManager<IMetadataItemHeader, long> instance = AbstractNHEntityManager<IMetadataItemHeader, long>.Instance;
				ParameterExpression parameterExpression = (ParameterExpression)dp4VOeoobIsZZAnLlHta(mijW1wooorQmuNQcLdwH(typeof(IMetadataItemHeader).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139071820));
				enumerator = (from q in instance.Find(Expression.Lambda<Func<IMetadataItemHeader, bool>>((Expression)KG6VL6ooGxXu1Vjd9lWG(parameterExpression, (MethodInfo)oxkay6oohUE9qViLuQl6((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))
					select q.Current).ToList().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
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
					int num6;
					if (!enumerator.MoveNext())
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num6 = 0;
						}
						goto IL_01d1;
					}
					goto IL_0219;
					IL_0219:
					entityMetadata = uSHj0xooEHVyM0Xgo9e0(enumerator.Current) as EntityMetadata;
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num6 = 1;
					}
					goto IL_01d1;
					IL_01d1:
					while (true)
					{
						switch (num6)
						{
						default:
							return;
						case 0:
							return;
						case 3:
						case 5:
							break;
						case 2:
							goto IL_0219;
						case 1:
							if (entityMetadata == null)
							{
								num6 = 3;
								continue;
							}
							goto case 4;
						case 4:
						{
							action(entityMetadata);
							int num7 = 5;
							num6 = num7;
							continue;
						}
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num8 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num8 = 0;
				}
				switch (num8)
				{
				case 0:
					break;
				}
			}
		}
	}

	public void CreateFormDependenciesTable()
	{
		//Discarded unreachable code: IL_017b, IL_018a
		int num = 2;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		Table table2 = default(Table);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			default:
				serviceNotNull.AddTable(table2);
				num2 = 4;
				break;
			case 1:
				if (!QXhLWYoWU3mVZKDq0iKd(serviceNotNull, FOteEaoWLQ1PYIw5Jowo(0x3630F361 ^ 0x3632BA33)))
				{
					num2 = 3;
					break;
				}
				return;
			case 5:
				return;
			case 3:
			{
				Table table = new Table();
				YwxxD7oWscxM0P7q9yow(table, FOteEaoWLQ1PYIw5Jowo(0x3A6135BE ^ 0x3A637CEC));
				aZ5VZqoofrnArL0drNLE(table, false);
				table.Columns = new List<Column>
				{
					new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852982414), DbType.Guid),
					new Column((string)FOteEaoWLQ1PYIw5Jowo(-1487388570 ^ -1487271426), DbType.Guid),
					new Column((string)FOteEaoWLQ1PYIw5Jowo(-420743386 ^ -420888860), DbType.Guid),
					new Column((string)FOteEaoWLQ1PYIw5Jowo(0x63ABA4E8 ^ 0x63A9ED08), DbType.Guid),
					new Column((string)FOteEaoWLQ1PYIw5Jowo(-1939377524 ^ -1939387798), DbType.Int64)
				};
				table2 = table;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal void CreateFormDependenciesIndex()
	{
		//Discarded unreachable code: IL_0051, IL_0195, IL_01a4
		int num = 4;
		int num2 = num;
		string text2 = default(string);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		string text = default(string);
		Index index = default(Index);
		Index index2 = default(Index);
		while (true)
		{
			switch (num2)
			{
			case 3:
				text2 = (string)FOteEaoWLQ1PYIw5Jowo(0x6A81B9B4 ^ 0x6A83F3B2) + owqjXSooQpZhd0vXbu3J(FOteEaoWLQ1PYIw5Jowo(0x307E9FD1 ^ 0x307CD5DF)).ToString((string)FOteEaoWLQ1PYIw5Jowo(-2112703338 ^ -2112729378)).Substring(0, 20);
				num2 = 8;
				continue;
			case 8:
				if (US4sj7ooC8SBoFFmMXFh(serviceNotNull, FOteEaoWLQ1PYIw5Jowo(-1886646897 ^ -1886501667), text2))
				{
					num2 = 11;
					continue;
				}
				goto case 9;
			case 2:
				return;
			case 4:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 3;
				}
				continue;
			case 5:
				if (!US4sj7ooC8SBoFFmMXFh(serviceNotNull, FOteEaoWLQ1PYIw5Jowo(0x103FE975 ^ 0x103DA027), text))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 9:
				index = new Index
				{
					TableName = (string)FOteEaoWLQ1PYIw5Jowo(0x61EC0CB8 ^ 0x61EE45EA),
					Name = text2,
					Columns = new List<string> { (string)FOteEaoWLQ1PYIw5Jowo(0x4A1640F ^ 0x4A32D79) }
				};
				num2 = 6;
				continue;
			case 10:
				return;
			case 1:
				serviceNotNull.AddIndex(index2);
				num2 = 2;
				continue;
			case 7:
			case 11:
				text = (string)t5Jo8Doo8tuQOP9CPSrM(FOteEaoWLQ1PYIw5Jowo(0xA592A41 ^ 0xA5B6047), owqjXSooQpZhd0vXbu3J(FOteEaoWLQ1PYIw5Jowo(-2107978722 ^ -2108127668)).ToString((string)FOteEaoWLQ1PYIw5Jowo(0x12441CA4 ^ 0x1244E6EC)).Substring(0, 20));
				num2 = 5;
				continue;
			case 6:
				miCvR8oovoI28hhYsPee(serviceNotNull, index);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 7;
				}
				continue;
			}
			Index index3 = new Index();
			m0URYWooZ690Wq3fZI9o(index3, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2024531D));
			zLdRBVoou4v2uAaJQkCN(index3, text);
			index3.Columns = new List<string> { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97822316) };
			index2 = index3;
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
			{
				num2 = 0;
			}
		}
	}

	internal void UpdateDoubleUidsSystemFile()
	{
		int num = 1;
		int num2 = num;
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				sql = string.Format((string)FOteEaoWLQ1PYIw5Jowo(-3333094 ^ -3182968), EKY5BRooVtlYq0iLcyhJ(VifNIUooIKC9VFxUYX5b(base.Transformation), FOteEaoWLQ1PYIw5Jowo(-882126494 ^ -882271990)), EKY5BRooVtlYq0iLcyhJ(base.Transformation.Dialect, FOteEaoWLQ1PYIw5Jowo(-541731959 ^ -541737957)), NYt1hSooSGa1Up500GHj(VifNIUooIKC9VFxUYX5b(base.Transformation)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			default:
				base.Transformation.ExecuteNonQuery(sql);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal void ConvertMetadataItemHeaderNameColumn()
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		string columnName = default(string);
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 3:
				base.Transformation.ConvertColumnString(text, columnName, 512);
				num2 = 4;
				break;
			case 4:
				return;
			case 5:
				vq2d1Ioois52STxplnMK(base.Transformation, text, FOteEaoWLQ1PYIw5Jowo(0x307E9FD1 ^ 0x307CD457));
				num2 = 3;
				break;
			default:
				columnName = LinqUtils.NameOf(Expression.Lambda<Func<IMetadataItemHeader, object>>((Expression)KG6VL6ooGxXu1Vjd9lWG(parameterExpression, (MethodInfo)oxkay6oohUE9qViLuQl6((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 5;
				break;
			case 1:
				parameterExpression = Expression.Parameter(mijW1wooorQmuNQcLdwH(typeof(IMetadataItemHeader).TypeHandle), (string)FOteEaoWLQ1PYIw5Jowo(0x92F12D5 ^ 0x92FBE61));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				text = (string)FOteEaoWLQ1PYIw5Jowo(-1088304168 ^ -1088192378);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal void ConvertMetadataItemHeaderTagColumn()
	{
		int num = 3;
		int num2 = num;
		string text2 = default(string);
		ParameterExpression parameterExpression = default(ParameterExpression);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				text2 = LinqUtils.NameOf(Expression.Lambda<Func<IMetadataItemHeader, object>>((Expression)KG6VL6ooGxXu1Vjd9lWG(parameterExpression, (MethodInfo)oxkay6oohUE9qViLuQl6((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 3:
				text = (string)FOteEaoWLQ1PYIw5Jowo(-218496594 ^ -218608912);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				VmxTBbooRPBVPvlZUEe0(base.Transformation, text, text2, 512);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				parameterExpression = (ParameterExpression)dp4VOeoobIsZZAnLlHta(mijW1wooorQmuNQcLdwH(typeof(IMetadataItemHeader).TypeHandle), FOteEaoWLQ1PYIw5Jowo(0x18A6761F ^ 0x18A6DAAB));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	internal void ConvertModuleMetadataItemHeaderNameColumn()
	{
		int num = 2;
		int num2 = num;
		string tableName = default(string);
		string columnName = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				tableName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AEA8C1);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				columnName = (string)FOteEaoWLQ1PYIw5Jowo(-521266112 ^ -521244800);
				num2 = 3;
				break;
			case 3:
				base.Transformation.ConvertColumnString(tableName, columnName, 512);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal void ConvertGlobalScriptModuleHeaderNamespaceColumn()
	{
		int num = 2;
		int num2 = num;
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				text2 = (string)FOteEaoWLQ1PYIw5Jowo(0x638095EB ^ 0x638113A7);
				num2 = 3;
				break;
			case 3:
				VmxTBbooRPBVPvlZUEe0(base.Transformation, text, text2, 2000);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				text = (string)KIKK7LooqyrZQVZ9YDkN(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195730715), 1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public CoreDbStructure()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TlViORooKdkTj8NGgXGb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CoreDbStructure()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				DbUpdateLog = Logger.GetLogger((string)FOteEaoWLQ1PYIw5Jowo(-1998538950 ^ -1998502058));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				TlViORooKdkTj8NGgXGb();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object FOteEaoWLQ1PYIw5Jowo(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool QXhLWYoWU3mVZKDq0iKd(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static void YwxxD7oWscxM0P7q9yow(object P_0, object P_1)
	{
		((Table)P_0).Name = (string)P_1;
	}

	internal static void i5jt1OoWce42sL56AZeD(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddTable((Table)P_1);
	}

	internal static bool uJM30JoWj5KWJroUIWIw()
	{
		return sWlNbSoW5Ys2mQKZw99Z == null;
	}

	internal static CoreDbStructure GHbHiKoWYkC2NWmLu1O7()
	{
		return sWlNbSoW5Ys2mQKZw99Z;
	}

	internal static object iInrZwoWzq2dTFYVYRhY()
	{
		return MetadataServiceContext.Service;
	}

	internal static object xRTBITooFP6e1PCopJFs()
	{
		return ComponentManager.Current;
	}

	internal static void WZf8jBooBLOxH5Dte3pl(object P_0, int timeout, object P_2)
	{
		((ITransformationProvider)P_0).ExecuteWithTimeout(timeout, (Action)P_2);
	}

	internal static bool qIGrXsooW1QhykJ86KBT(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static Type mijW1wooorQmuNQcLdwH(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object dp4VOeoobIsZZAnLlHta(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object oxkay6oohUE9qViLuQl6(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object KG6VL6ooGxXu1Vjd9lWG(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object uSHj0xooEHVyM0Xgo9e0(object P_0)
	{
		return ((IMetadataItem)P_0).Metadata;
	}

	internal static void aZ5VZqoofrnArL0drNLE(object P_0, bool value)
	{
		((Table)P_0).IsTemporary = value;
	}

	internal static Guid owqjXSooQpZhd0vXbu3J(object P_0)
	{
		return ((string)P_0).GetDeterministicGuid();
	}

	internal static bool US4sj7ooC8SBoFFmMXFh(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).IndexExists((string)P_1, (string)P_2);
	}

	internal static void miCvR8oovoI28hhYsPee(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddIndex((Index)P_1);
	}

	internal static object t5Jo8Doo8tuQOP9CPSrM(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void m0URYWooZ690Wq3fZI9o(object P_0, object P_1)
	{
		((Index)P_0).TableName = (string)P_1;
	}

	internal static void zLdRBVoou4v2uAaJQkCN(object P_0, object P_1)
	{
		((Index)P_0).Name = (string)P_1;
	}

	internal static object VifNIUooIKC9VFxUYX5b(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object EKY5BRooVtlYq0iLcyhJ(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object NYt1hSooSGa1Up500GHj(object P_0)
	{
		return ((Dialect)P_0).GenUid();
	}

	internal static void vq2d1Ioois52STxplnMK(object P_0, object P_1, object P_2)
	{
		((ITransformationProvider)P_0).RemoveIndex((string)P_1, (string)P_2);
	}

	internal static void VmxTBbooRPBVPvlZUEe0(object P_0, object P_1, object P_2, int columnSize)
	{
		((ITransformationProvider)P_0).ConvertColumnString((string)P_1, (string)P_2, columnSize);
	}

	internal static object KIKK7LooqyrZQVZ9YDkN(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static void TlViORooKdkTj8NGgXGb()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

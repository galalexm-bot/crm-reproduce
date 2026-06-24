using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Db.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Db;

public class DbProcessContextUpdater : IDbModelUpdater, IActionsHolder
{
	public const string FOREIGN_KEY_PREFIX = "FK_P_";

	public const string INDEX_PREFIX = "IX_P_";

	public const string PRIMARY_KEY_PREFIX = "PK_P_";

	private long processHeadId;

	private EntityMetadata _oldContext;

	private EntityMetadata _newContext;

	private ITransformationProvider transform;

	private IMetadataRuntimeService metadataService;

	private List<IDbAction> tablesCreateActions;

	private List<IDbAction> foreignKeysDeleteActions;

	private List<IDbAction> foreignKeysCreateActions;

	private List<IDbAction> primaryKeysCreateActions;

	private List<IDbAction> tablesDeletedActions;

	private DbUpdateMarkerService markerService;

	private Dictionary<string, List<ForeignKey>> existingForeignKeys;

	private static DbProcessContextUpdater xK3McEOOi8Go8AruwaBp;

	protected ITransformationProvider Transform => transform;

	protected IMetadataRuntimeService MetadataService => metadataService;

	protected List<IDbAction> TablesCreateActions => tablesCreateActions;

	protected List<IDbAction> ForeignKeysCreateActions => foreignKeysCreateActions;

	public List<IDbAction> PrimaryKeysCreatedActions => primaryKeysCreateActions;

	ITransformationProvider IDbModelUpdater.Transform => transform;

	DbUpdateMarkerService IDbModelUpdater.MarkerService => markerService;

	bool IDbModelUpdater.RecreateConstraints => false;

	List<IDbAction> IActionsHolder.TablesCreatedActions => tablesCreateActions;

	List<IDbAction> IActionsHolder.TablesDeletedActions => tablesDeletedActions;

	List<IDbAction> IActionsHolder.ForeignKeysCreatedActions => foreignKeysCreateActions;

	public DbProcessContextUpdater(long processHeadId, EntityMetadata oldContext, EntityMetadata newContext)
	{
		//Discarded unreachable code: IL_008a, IL_008f
		Y6aYJ3OOrS3L2hL7o8Fy();
		tablesCreateActions = new List<IDbAction>();
		foreignKeysDeleteActions = new List<IDbAction>();
		foreignKeysCreateActions = new List<IDbAction>();
		primaryKeysCreateActions = new List<IDbAction>();
		tablesDeletedActions = new List<IDbAction>();
		existingForeignKeys = new Dictionary<string, List<ForeignKey>>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				metadataService = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				num = 4;
				break;
			case 6:
				this.processHeadId = processHeadId;
				num = 3;
				break;
			case 4:
				markerService = Locator.GetServiceNotNull<DbUpdateMarkerService>();
				num = 2;
				break;
			case 2:
				return;
			default:
				xMxJebOONIbkKXs78h8Q(newContext, OJYEvVOOegUQcJDUEZ2f(-1361036319 ^ -1360938127));
				num = 6;
				break;
			case 3:
				_oldContext = oldContext;
				num = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
				{
					num = 7;
				}
				break;
			case 5:
				transform = Locator.GetServiceNotNull<ITransformationProvider>();
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
				{
					num = 1;
				}
				break;
			case 7:
				_newContext = newContext;
				num = 5;
				break;
			}
		}
	}

	public void Update()
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
				T3MYP4OOxOK3xVHgbxBV(this);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				PrepareActions();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void PrepareActions()
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
				ilvJE9OOShWSb0T39WI1(this, _oldContext, _newContext);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void ExecuteActions()
	{
		//Discarded unreachable code: IL_003e, IL_004c, IL_00de, IL_00f1, IL_0100, IL_0138, IL_0147, IL_01d8, IL_01eb, IL_0229, IL_0238, IL_0243, IL_02d5, IL_02e8, IL_02f7
		int num = 2;
		int num2 = num;
		List<IDbAction>.Enumerator enumerator = default(List<IDbAction>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 6:
				try
				{
					while (true)
					{
						int num8;
						if (!enumerator.MoveNext())
						{
							num8 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
							{
								num8 = 1;
							}
							goto IL_0050;
						}
						goto IL_0066;
						IL_0066:
						RrhFlNOO1qxxb6FxBgQ3(enumerator.Current);
						num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
						{
							num8 = 0;
						}
						goto IL_0050;
						IL_0050:
						switch (num8)
						{
						case 2:
							break;
						default:
							continue;
						case 1:
							goto end_IL_008c;
						}
						goto IL_0066;
						continue;
						end_IL_008c:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num9 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
					{
						num9 = 0;
					}
					switch (num9)
					{
					case 0:
						break;
					}
				}
				break;
			case 2:
				enumerator = TablesCreateActions.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				try
				{
					while (true)
					{
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
							{
								num5 = 1;
							}
							goto IL_0156;
						}
						goto IL_016c;
						IL_016c:
						RrhFlNOO1qxxb6FxBgQ3(enumerator.Current);
						int num6 = 2;
						num5 = num6;
						goto IL_0156;
						IL_0156:
						switch (num5)
						{
						case 2:
							continue;
						case 1:
							return;
						}
						goto IL_016c;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
			default:
				enumerator = PrimaryKeysCreatedActions.GetEnumerator();
				num2 = 6;
				continue;
			case 3:
				break;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
							{
								num3 = 1;
							}
							goto IL_0247;
						}
						goto IL_025d;
						IL_025d:
						enumerator.Current.Execute();
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
						{
							num3 = 0;
						}
						goto IL_0247;
						IL_0247:
						switch (num3)
						{
						case 2:
							break;
						default:
							continue;
						case 1:
							goto end_IL_0283;
						}
						goto IL_025d;
						continue;
						end_IL_0283:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 4:
				return;
			}
			enumerator = ForeignKeysCreateActions.GetEnumerator();
			num2 = 5;
		}
	}

	protected virtual void PrepareActions(EntityMetadata oldContext, EntityMetadata newContext)
	{
		//Discarded unreachable code: IL_0181, IL_0190, IL_019b, IL_0243, IL_0298, IL_02ab, IL_02ba, IL_02ed, IL_04f1, IL_0500, IL_05ab, IL_05b5, IL_06a8, IL_06b7, IL_06fc, IL_07dc, IL_07fe, IL_080d, IL_0865, IL_0878, IL_093b, IL_0c04, IL_0c0e, IL_0cd3, IL_0ce6, IL_0ea2, IL_0eb1, IL_0ee6, IL_0efe, IL_0f0d, IL_0fbb, IL_0fce, IL_0fdd, IL_1077, IL_108a
		int num = 12;
		Dictionary<int, Table> dictionary2 = default(Dictionary<int, Table>);
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		Table value2 = default(Table);
		List<TablePartMetadata>.Enumerator enumerator4 = default(List<TablePartMetadata>.Enumerator);
		int tableRecordMaxSize = default(int);
		Dictionary<int, int> dictionary = default(Dictionary<int, int>);
		string tableName = default(string);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		_003C_003Ec__DisplayClass17_5 _003C_003Ec__DisplayClass17_4 = default(_003C_003Ec__DisplayClass17_5);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		_003C_003Ec__DisplayClass17_1 _003C_003Ec__DisplayClass17_2 = default(_003C_003Ec__DisplayClass17_1);
		TypeDbStructures arg = default(TypeDbStructures);
		_003C_003Ec__DisplayClass17_2 _003C_003Ec__DisplayClass17_3 = default(_003C_003Ec__DisplayClass17_2);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		string propertyTypeDisplayName = default(string);
		string propertyTypeDisplayName2 = default(string);
		List<Table>.Enumerator enumerator3 = default(List<Table>.Enumerator);
		List<Column>.Enumerator enumerator2 = default(List<Column>.Enumerator);
		Column current2 = default(Column);
		int num9 = default(int);
		int value = default(int);
		IPropertyTypeInfo propertyTypeInfo2 = default(IPropertyTypeInfo);
		IPropertyTypeInfo propertyTypeInfo = default(IPropertyTypeInfo);
		int num5 = default(int);
		Table current3 = default(Table);
		Action<bool, TypeDbStructures> action = default(Action<bool, TypeDbStructures>);
		Column current = default(Column);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					dictionary2.TryGetValue(QytNxGOOh3YRvheXCkvx(_003C_003Ec__DisplayClass17_.newContext), out value2);
					num = 4;
					break;
				case 2:
					enumerator4 = _003C_003Ec__DisplayClass17_.newContext.TableParts.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
					{
						num2 = 13;
					}
					continue;
				case 9:
					return;
				case 5:
					_003C_003Ec__DisplayClass17_._003C_003E4__this = this;
					num2 = 7;
					continue;
				case 6:
					tableRecordMaxSize = Transform.TableRecordMaxSize;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					dictionary2 = new Dictionary<int, Table>();
					num = 3;
					break;
				case 14:
					CreateOrRenameTables(oldContext, _003C_003Ec__DisplayClass17_.newContext, dictionary2, dictionary);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					tableName = GetTableName(_003C_003Ec__DisplayClass17_.newContext, QytNxGOOh3YRvheXCkvx(_003C_003Ec__DisplayClass17_.newContext));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					dictionary = new Dictionary<int, int>();
					num2 = 14;
					continue;
				case 12:
					_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
					num2 = 11;
					continue;
				case 13:
					try
					{
						while (true)
						{
							int num16;
							if (!enumerator4.MoveNext())
							{
								num16 = 5;
								goto IL_019f;
							}
							goto IL_01f4;
							IL_019f:
							while (true)
							{
								object obj2;
								switch (num16)
								{
								case 5:
									return;
								case 6:
									break;
								case 3:
									ilvJE9OOShWSb0T39WI1(this, tablePartMetadata, _003C_003Ec__DisplayClass17_4.tp);
									num16 = 6;
									continue;
								case 1:
									goto IL_01f4;
								default:
									if (oldContext == null)
									{
										num16 = 2;
										continue;
									}
									obj2 = oldContext.TableParts.FirstOrDefault(_003C_003Ec__DisplayClass17_4._003CPrepareActions_003Eb__7);
									goto IL_0260;
								case 4:
									_003C_003Ec__DisplayClass17_4.tp = enumerator4.Current;
									num16 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
									{
										num16 = 0;
									}
									continue;
								case 2:
									{
										obj2 = null;
										goto IL_0260;
									}
									IL_0260:
									tablePartMetadata = (TablePartMetadata)obj2;
									num16 = 3;
									continue;
								}
								break;
							}
							continue;
							IL_01f4:
							_003C_003Ec__DisplayClass17_4 = new _003C_003Ec__DisplayClass17_5();
							num16 = 4;
							goto IL_019f;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num17 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
						{
							num17 = 0;
						}
						switch (num17)
						{
						case 0:
							break;
						}
					}
				case 11:
					_003C_003Ec__DisplayClass17_.newContext = newContext;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					try
					{
						while (true)
						{
							IL_0b23:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 31;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
								{
									num3 = 1;
								}
								goto IL_02fb;
							}
							goto IL_0528;
							IL_0528:
							_003C_003Ec__DisplayClass17_2 = new _003C_003Ec__DisplayClass17_1();
							num3 = 35;
							goto IL_02fb;
							IL_02fb:
							while (true)
							{
								object obj;
								switch (num3)
								{
								case 43:
									arg = (TypeDbStructures)qUb7jrOOEf6GUkW7hqp2(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext, entityPropertyMetadata);
									num3 = 10;
									continue;
								case 11:
								{
									tableName = GetTableName(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext, QytNxGOOh3YRvheXCkvx(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext));
									int num14 = 24;
									num3 = num14;
									continue;
								}
								case 26:
								{
									EntityMetadata newContext2 = _003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext;
									short num13 = QytNxGOOh3YRvheXCkvx(newContext2);
									newContext2.LastTableNumber = (short)(num13 + 1);
									num3 = 22;
									continue;
								}
								case 10:
									iG7y9AOZmvDL9DhJ9wwm(this, _003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext, _003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata, entityPropertyMetadata);
									num3 = 15;
									continue;
								case 36:
									throw new DbModelException((string)IRUr73OZ0kXZUtmG7kBn(OJYEvVOOegUQcJDUEZ2f(-1028861977 ^ -1028829519), new object[4]
									{
										vP0P3ROZKXutNRQwACNW(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata),
										vP0P3ROZKXutNRQwACNW(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext),
										propertyTypeDisplayName,
										propertyTypeDisplayName2
									}));
								case 3:
									enumerator3 = _003C_003Ec__DisplayClass17_3.propStructures.Tables.GetEnumerator();
									num3 = 17;
									continue;
								case 7:
									break;
								case 33:
									if (heSy6tOZyMgytmG47BCx(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata) != null)
									{
										num3 = 28;
										continue;
									}
									goto case 15;
								case 25:
									if (oldContext == null)
									{
										num3 = 38;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
										{
											num3 = 20;
										}
										continue;
									}
									obj = (EntityPropertyMetadata)oldContext.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass17_1.uxfht6ZEyjXZOJaQohIO(_003C_003Ec__DisplayClass17_1.Y65qN2ZE0SDvOMkCg5IB(p), _003C_003Ec__DisplayClass17_1.Y65qN2ZE0SDvOMkCg5IB(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata)));
									goto IL_103f;
								case 12:
								case 47:
									if (XxoSNuOZssVfkScJtvIk(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata) != entityPropertyMetadata.TypeUid)
									{
										num3 = 9;
										continue;
									}
									goto IL_0e3f;
								case 13:
									try
									{
										while (true)
										{
											int num8;
											if (!enumerator2.MoveNext())
											{
												num8 = 4;
												goto IL_05b9;
											}
											goto IL_07e6;
											IL_05b9:
											while (true)
											{
												switch (num8)
												{
												default:
													tablesCreateActions.Add(new DbCreateColumnAction(Transform, tableName, current2));
													num8 = 14;
													continue;
												case 5:
													if (!_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext.IsUnique)
													{
														num8 = 9;
														continue;
													}
													goto case 13;
												case 11:
													value2.Columns.Add(current2);
													num8 = 8;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
													{
														num8 = 7;
													}
													continue;
												case 12:
													num9 = W4EBDAOO462q23Ph6nwl(Transform, current2);
													num8 = 10;
													continue;
												case 1:
													break;
												case 8:
												case 14:
													if (o2T5rNOZOQPUOFHSEEWe(vP0P3ROZKXutNRQwACNW(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata), OJYEvVOOegUQcJDUEZ2f(0xDF4D1F8 ^ 0xDF49784)))
													{
														num8 = 5;
														continue;
													}
													goto case 6;
												case 2:
												{
													List<IDbAction> list = tablesCreateActions;
													ITransformationProvider transformationProvider = Transform;
													Index index = new Index();
													RVhOLBOZYxVORT67XFCT(index, H8rw4cOZv4v4F1FURCxc(OJYEvVOOegUQcJDUEZ2f(0x361628FF ^ 0x3617A857), tableName));
													ydxbZMOZ8EiOcXW6lhLE(index, tableName);
													index.Columns = new List<string> { (string)OJYEvVOOegUQcJDUEZ2f(0x5F800F5B ^ 0x5F804927) };
													list.Add(new DbCreateUniqueIndexAction(transformationProvider, index));
													num8 = 3;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
													{
														num8 = 6;
													}
													continue;
												}
												case 6:
												case 9:
												case 15:
													value += num9;
													num8 = 1;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
													{
														num8 = 1;
													}
													continue;
												case 13:
													if (!(c62ZwBOZZY2DFbO4Er0u(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext) == Guid.Empty))
													{
														num8 = 15;
														continue;
													}
													goto case 2;
												case 7:
													goto IL_07e6;
												case 10:
													if (value2 == null)
													{
														num8 = 0;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
														{
															num8 = 0;
														}
														continue;
													}
													goto case 11;
												case 4:
													goto end_IL_068d;
												}
												break;
											}
											continue;
											IL_07e6:
											current2 = enumerator2.Current;
											num8 = 12;
											goto IL_05b9;
											continue;
											end_IL_068d:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num10 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
										{
											num10 = 0;
										}
										switch (num10)
										{
										case 0:
											break;
										}
									}
									goto case 3;
								case 45:
									dictionary.TryGetValue(QytNxGOOh3YRvheXCkvx(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext), out value);
									num3 = 11;
									continue;
								case 24:
									q3tdvlOOzswrfGcNXl1E(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata, QytNxGOOh3YRvheXCkvx(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext));
									num3 = 14;
									continue;
								case 2:
									enumerator2 = _003C_003Ec__DisplayClass17_3.propStructures.Columns.GetEnumerator();
									num3 = 30;
									continue;
								case 44:
									if (!heSy6tOZyMgytmG47BCx(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata).Equals(heSy6tOZyMgytmG47BCx(entityPropertyMetadata)))
									{
										num3 = 18;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
										{
											num3 = 43;
										}
										continue;
									}
									goto case 15;
								case 32:
									_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass17_2;
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
									{
										num3 = 4;
									}
									continue;
								case 16:
									_003C_003Ec__DisplayClass17_3 = new _003C_003Ec__DisplayClass17_2();
									num3 = 32;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
									{
										num3 = 24;
									}
									continue;
								case 48:
									propertyTypeInfo2 = (IPropertyTypeInfo)MetadataService.GetTypeDescriptor(XxoSNuOZssVfkScJtvIk(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata), _003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata.SubTypeUid);
									num3 = 46;
									continue;
								case 46:
									goto IL_09c7;
								case 9:
								case 39:
									propertyTypeInfo = (IPropertyTypeInfo)MetadataService.GetTypeDescriptor(XxoSNuOZssVfkScJtvIk(entityPropertyMetadata), lKTKQYOZJitj9heEooCN(entityPropertyMetadata));
									num3 = 48;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
									{
										num3 = 15;
									}
									continue;
								case 4:
									_003C_003Ec__DisplayClass17_3.propStructures = (TypeDbStructures)qUb7jrOOEf6GUkW7hqp2(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext, _003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata);
									num3 = 25;
									continue;
								case 22:
									CreateOrRenameTable(oldContext, _003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext, dictionary2, dictionary, _003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext.LastTableNumber);
									num3 = 40;
									continue;
								case 8:
									throw new DbModelException(SR.T((string)OJYEvVOOegUQcJDUEZ2f(0x1C7F6FED ^ 0x1C7EEF5B), _003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata.Name, _003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext.Name, XxoSNuOZssVfkScJtvIk(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata)));
								default:
									goto IL_0b23;
								case 5:
									propertyTypeDisplayName2 = propertyTypeInfo.GetPropertyTypeDisplayName(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata);
									num3 = 36;
									continue;
								case 27:
									if (value + num5 > tableRecordMaxSize)
									{
										num3 = 26;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
										{
											num3 = 26;
										}
										continue;
									}
									goto case 24;
								case 28:
									if (heSy6tOZyMgytmG47BCx(entityPropertyMetadata) != null)
									{
										num3 = 44;
										continue;
									}
									goto case 15;
								case 14:
									enumerator2 = _003C_003Ec__DisplayClass17_3.propStructures.Columns.GetEnumerator();
									num3 = 13;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
									{
										num3 = 11;
									}
									continue;
								case 37:
									if (dictionary2.ContainsKey(n5SCvbOOwICMSoYiqoVL(entityPropertyMetadata)))
									{
										num3 = 33;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
										{
											num3 = 34;
										}
										continue;
									}
									goto case 18;
								case 17:
									try
									{
										while (true)
										{
											IL_0c2c:
											int num11;
											if (!enumerator3.MoveNext())
											{
												num11 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
												{
													num11 = 0;
												}
												goto IL_0c12;
											}
											goto IL_0c52;
											IL_0c52:
											current3 = enumerator3.Current;
											num11 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
											{
												num11 = 1;
											}
											goto IL_0c12;
											IL_0c12:
											while (true)
											{
												switch (num11)
												{
												case 2:
													goto IL_0c2c;
												case 3:
													goto IL_0c52;
												case 1:
													tablesCreateActions.Add(new DbCreateTableAction(Transform, current3));
													num11 = 2;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
													{
														num11 = 2;
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
										((IDisposable)enumerator3).Dispose();
										int num12 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
										{
											num12 = 0;
										}
										switch (num12)
										{
										case 0:
											break;
										}
									}
									goto case 41;
								case 41:
									action(entityPropertyMetadata == null, null);
									num3 = 6;
									continue;
								case 20:
									_003C_003Ec__DisplayClass17_2.propertyMetadata = (EntityPropertyMetadata)enumerator.Current;
									num3 = 16;
									continue;
								case 15:
									action(arg1: true, arg);
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
									{
										num3 = 0;
									}
									continue;
								case 23:
									action = _003C_003Ec__DisplayClass17_3._003CPrepareActions_003Eb__1;
									num3 = 29;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
									{
										num3 = 21;
									}
									continue;
								case 42:
									if (!o2T5rNOZOQPUOFHSEEWe(vP0P3ROZKXutNRQwACNW(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata), OJYEvVOOegUQcJDUEZ2f(-1361036319 ^ -1361019567)))
									{
										num3 = 47;
										continue;
									}
									goto IL_0fe8;
								case 1:
									throw new DbModelException((string)IRUr73OZ0kXZUtmG7kBn(OJYEvVOOegUQcJDUEZ2f(-642713667 ^ -642681077), new object[3]
									{
										vP0P3ROZKXutNRQwACNW(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata),
										vP0P3ROZKXutNRQwACNW(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext),
										XxoSNuOZssVfkScJtvIk(entityPropertyMetadata)
									}));
								case 40:
									dictionary2.TryGetValue(QytNxGOOh3YRvheXCkvx(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext), out value2);
									num3 = 45;
									continue;
								case 19:
									goto IL_0e3f;
								case 18:
									q3tdvlOOzswrfGcNXl1E(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata, n5SCvbOOwICMSoYiqoVL(entityPropertyMetadata));
									num3 = 42;
									continue;
								case 35:
									_003C_003Ec__DisplayClass17_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass17_;
									num3 = 20;
									continue;
								case 29:
									if (entityPropertyMetadata != null)
									{
										num3 = 37;
										continue;
									}
									goto case 34;
								case 38:
									obj = null;
									goto IL_103f;
								case 34:
									num5 = 0;
									num3 = 2;
									continue;
								case 30:
									try
									{
										while (true)
										{
											int num4;
											if (!enumerator2.MoveNext())
											{
												num4 = 2;
												goto IL_0f1c;
											}
											goto IL_0f4c;
											IL_0f1c:
											while (true)
											{
												switch (num4)
												{
												case 3:
													break;
												case 1:
													goto IL_0f4c;
												default:
												{
													num5 += W4EBDAOO462q23Ph6nwl(Transform, current);
													int num6 = 3;
													num4 = num6;
													continue;
												}
												case 2:
													goto end_IL_0f36;
												}
												break;
											}
											continue;
											IL_0f4c:
											current = enumerator2.Current;
											num4 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
											{
												num4 = 0;
											}
											goto IL_0f1c;
											continue;
											end_IL_0f36:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num7 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
										{
											num7 = 0;
										}
										switch (num7)
										{
										case 0:
											break;
										}
									}
									goto case 27;
								case 21:
									goto IL_0fe8;
								case 31:
									goto end_IL_0b23;
									IL_103f:
									entityPropertyMetadata = (EntityPropertyMetadata)obj;
									num3 = 23;
									continue;
								}
								break;
								IL_0fe8:
								if (!(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newContext is TablePartMetadata))
								{
									num3 = 9;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
									{
										num3 = 12;
									}
									continue;
								}
								goto IL_04df;
								IL_04df:
								arg = null;
								num3 = 33;
								continue;
								IL_0e3f:
								if (towtGMOZlUQZ6evQVoBL(_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals2.propertyMetadata.SubTypeUid, lKTKQYOZJitj9heEooCN(entityPropertyMetadata)))
								{
									num3 = 39;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto IL_04df;
								IL_09c7:
								if (propertyTypeInfo == null)
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
									{
										num3 = 1;
									}
								}
								else if (propertyTypeInfo2 != null)
								{
									propertyTypeDisplayName = propertyTypeInfo.GetPropertyTypeDisplayName(entityPropertyMetadata);
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
									{
										num3 = 5;
									}
								}
								else
								{
									num3 = 8;
								}
							}
							goto IL_0528;
							continue;
							end_IL_0b23:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num15 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
						{
							num15 = 0;
						}
						switch (num15)
						{
						case 0:
							break;
						}
					}
					goto case 2;
				case 4:
					dictionary.TryGetValue(QytNxGOOh3YRvheXCkvx(_003C_003Ec__DisplayClass17_.newContext), out value);
					num2 = 10;
					continue;
				case 1:
					enumerator = _003C_003Ec__DisplayClass17_.newContext.Properties.GetEnumerator();
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			}
		}
	}

	protected void CreateOrRenameTables(EntityMetadata oldContext, EntityMetadata newContext, Dictionary<int, Table> createdTables, Dictionary<int, int> tableSizes)
	{
		for (int i = 0; i <= newContext.LastTableNumber; i++)
		{
			if (oldContext == null || string.IsNullOrEmpty(oldContext.TableName) || !oldContext.TableName.Equals(newContext.TableName, StringComparison.CurrentCultureIgnoreCase))
			{
				CreateOrRenameTable(oldContext, newContext, createdTables, tableSizes, i);
				continue;
			}
			string tableName = GetTableName(newContext.TableName, i);
			if (!Transform.TableExists(tableName))
			{
				Logger.Log.Warn(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EE8279), tableName));
				CreateOrRenameTable(oldContext, newContext, createdTables, tableSizes, i);
			}
			else
			{
				tableSizes[i] = Transform.GetTableColumnsSize(tableName);
			}
		}
	}

	protected void CreateOrRenameTable(EntityMetadata oldContext, EntityMetadata newContext, Dictionary<int, Table> createdTables, Dictionary<int, int> tableSizes, int tableNumber)
	{
		string text = ((oldContext != null && !string.IsNullOrEmpty(oldContext.TableName)) ? GetTableName(oldContext.TableName, tableNumber) : null);
		string tableName = GetTableName(newContext.TableName, tableNumber);
		bool flag = text != null && Transform.TableExists(text);
		bool flag2 = Transform.TableExists(tableName);
		if (flag && !flag2)
		{
			tablesCreateActions.Add(new DbRenameTableAction(transform, text, tableName));
			tableSizes[tableNumber] = Transform.GetTableColumnsSize(text);
		}
		if (!flag && !flag2)
		{
			Table table2 = (createdTables[tableNumber] = CreateTable(newContext, tableNumber));
			tablesCreateActions.Add(new DbCreateTableAction(transform, table2));
		}
		if (flag && flag2)
		{
			throw new DbStructureException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7EED89), tableName));
		}
		if (text != null && !flag && flag2)
		{
			tableSizes[tableNumber] = Transform.GetTableColumnsSize(tableName);
			Logger.Log.Warn(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x759F004), text, tableName));
		}
	}

	protected Table CreateLastTable(EntityMetadata newContext)
	{
		return CreateTable(newContext, QytNxGOOh3YRvheXCkvx(newContext));
	}

	protected Table CreateTable(EntityMetadata newContext, int tableNumber)
	{
		Table table = new Table();
		YIQbnHOZtLG1KpaoX9JC(table, GetTableName(newContext, tableNumber));
		table.Columns = new List<Column>();
		table.Sequence = tableNumber == 0;
		Column columnForIdentifier = DbModelHelper.GetColumnForIdentifier(newContext);
		LpRCcnOZbnrALQCpOXD4(columnForIdentifier, ColumnProperty.PrimaryKey);
		table.Columns.Add(columnForIdentifier);
		return table;
	}

	protected string GetTableName(EntityMetadata newContext, int tableNumber)
	{
		return GetTableName(newContext.TableName, tableNumber);
	}

	protected string GetTableName(string firstTableName, int tableNumber)
	{
		return EntityPropertyMetadata.GetTableName(firstTableName, tableNumber);
	}

	protected string GenerateFKName(string tableName, IEnumerable<string> columnNames)
	{
		return GenerateNameHelper.GenerateForeignKeyName(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--727842433 ^ 0x2B607D99), tableName, columnNames);
	}

	protected string GeneratePKName(string tableName, string columnName)
	{
		return GenerateNameHelper.GeneratePrimaryKeyName((string)OJYEvVOOegUQcJDUEZ2f(0x213F6477 ^ 0x213EE751), tableName, columnName);
	}

	protected List<ForeignKey> GetTableForeignKeys(string tableName)
	{
		if (!existingForeignKeys.TryGetValue(tableName.ToUpper(), out var value))
		{
			value = Transform.GetForeignKeys(tableName);
			existingForeignKeys[tableName.ToUpper()] = value;
		}
		return value;
	}

	string IDbModelUpdater.GenerateForeignKeyName(string tableName, string columnName)
	{
		return GenerateFKName(tableName, new string[1] { columnName });
	}

	string IDbModelUpdater.GeneratePrimaryKeyName(string tableName, string columnName)
	{
		return GeneratePKName(tableName, columnName);
	}

	string IDbModelUpdater.GenerateDeletingColumnTemporaryName(string tableName, string columnName)
	{
		return transform.GenerateDeletingColumnTemporaryName(tableName, columnName);
	}

	string IDbModelUpdater.GetDeletingColumnTemporaryName(string tableName, string columnName)
	{
		return transform.GetDeletingColumnTemporaryName(tableName, columnName);
	}

	internal static void Y6aYJ3OOrS3L2hL7o8Fy()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object OJYEvVOOegUQcJDUEZ2f(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void xMxJebOONIbkKXs78h8Q(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool MfHdASOOI4faxg9qUG3t()
	{
		return xK3McEOOi8Go8AruwaBp == null;
	}

	internal static DbProcessContextUpdater YJ5XnOOOa8doD58X3mWb()
	{
		return xK3McEOOi8Go8AruwaBp;
	}

	internal static void T3MYP4OOxOK3xVHgbxBV(object P_0)
	{
		((DbProcessContextUpdater)P_0).ExecuteActions();
	}

	internal static void ilvJE9OOShWSb0T39WI1(object P_0, object P_1, object P_2)
	{
		((DbProcessContextUpdater)P_0).PrepareActions((EntityMetadata)P_1, (EntityMetadata)P_2);
	}

	internal static void RrhFlNOO1qxxb6FxBgQ3(object P_0)
	{
		((IDbAction)P_0).Execute();
	}

	internal static short QytNxGOOh3YRvheXCkvx(object P_0)
	{
		return ((EntityMetadata)P_0).LastTableNumber;
	}

	internal static object qUb7jrOOEf6GUkW7hqp2(object P_0, object P_1)
	{
		return DbModelHelper.GetPropertyDbStructures((EntityMetadata)P_0, (EntityPropertyMetadata)P_1);
	}

	internal static int n5SCvbOOwICMSoYiqoVL(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).TableNumber;
	}

	internal static int W4EBDAOO462q23Ph6nwl(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).GetColumnSize((Column)P_1);
	}

	internal static void q3tdvlOOzswrfGcNXl1E(object P_0, int P_1)
	{
		((EntityPropertyMetadata)P_0).TableNumber = P_1;
	}

	internal static object vP0P3ROZKXutNRQwACNW(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool o2T5rNOZOQPUOFHSEEWe(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Guid c62ZwBOZZY2DFbO4Er0u(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static object H8rw4cOZv4v4F1FURCxc(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void RVhOLBOZYxVORT67XFCT(object P_0, object P_1)
	{
		((Index)P_0).Name = (string)P_1;
	}

	internal static void ydxbZMOZ8EiOcXW6lhLE(object P_0, object P_1)
	{
		((Index)P_0).TableName = (string)P_1;
	}

	internal static Guid XxoSNuOZssVfkScJtvIk(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid lKTKQYOZJitj9heEooCN(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static bool towtGMOZlUQZ6evQVoBL(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object IRUr73OZ0kXZUtmG7kBn(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object heSy6tOZyMgytmG47BCx(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static bool iG7y9AOZmvDL9DhJ9wwm(object P_0, object P_1, object P_2, object P_3)
	{
		return DbModelHelper.ApplyPropertyDbChanges((IDbModelUpdater)P_0, (EntityMetadata)P_1, (EntityPropertyMetadata)P_2, (EntityPropertyMetadata)P_3);
	}

	internal static void YIQbnHOZtLG1KpaoX9JC(object P_0, object P_1)
	{
		((Table)P_0).Name = (string)P_1;
	}

	internal static void LpRCcnOZbnrALQCpOXD4(object P_0, ColumnProperty P_1)
	{
		((Column)P_0).ColumnProperty = P_1;
	}
}

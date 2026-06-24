using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Model.Db.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db;

internal class DbDeltaModelUpdater : IDbDeltaModelUpdater
{
	private class ActionCollector : IDbModelUpdater, IActionsHolder
	{
		private readonly object transformationProvider;

		private readonly object oldModelMetadata;

		private readonly object newModelMetadata;

		private readonly Dictionary<string, List<ForeignKey>> existingForeignKeys;

		internal static object r0hQ97CoaRyYAogGTJV8;

		public List<IDbAction> TablesCreatedActions { get; }

		ITransformationProvider IDbModelUpdater.Transform => (ITransformationProvider)transformationProvider;

		DbUpdateMarkerService IDbModelUpdater.MarkerService
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		bool IDbModelUpdater.RecreateConstraints
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		List<IDbAction> IActionsHolder.TablesDeletedActions { get; }

		public List<IDbAction> ForeignKeysCreatedActions { get; }

		public List<IDbAction> PrimaryKeysCreatedActions { get; }

		public ActionCollector(EntityMetadata oldMetadata, EntityMetadata newMetadata)
		{
			//Discarded unreachable code: IL_007a, IL_007f
			PM6wKTCowU8tjWnRfOMt();
			existingForeignKeys = new Dictionary<string, List<ForeignKey>>();
			TablesCreatedActions = new List<IDbAction>();
			EleWise_002EELMA_002ERuntime_002EDb_002EActions_002EIActionsHolder_002ETablesDeletedActions = new List<IDbAction>();
			ForeignKeysCreatedActions = new List<IDbAction>();
			PrimaryKeysCreatedActions = new List<IDbAction>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
			{
				num = 5;
			}
			while (true)
			{
				switch (num)
				{
				default:
					oldModelMetadata = oldMetadata;
					num = 2;
					break;
				case 2:
					newModelMetadata = newMetadata;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num = 1;
					}
					break;
				case 3:
					PrepareActions();
					num = 4;
					break;
				case 4:
					return;
				case 1:
					transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>();
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num = 3;
					}
					break;
				case 5:
					IjeAbfCo4usVeq6i9Yc7(newMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63A8AC16));
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		private void PrepareActions()
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
					PrepareActions((EntityMetadata)oldModelMetadata, (EntityMetadata)newModelMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private void PrepareActions(EntityMetadata oldMetadata, EntityMetadata newMetadata)
		{
			//Discarded unreachable code: IL_009d, IL_00ac, IL_00e8, IL_00f7, IL_01c8, IL_01d7, IL_01e2, IL_0215, IL_0224, IL_02bc, IL_0342, IL_0355, IL_0439, IL_0448, IL_049e, IL_0503, IL_0512, IL_05a3, IL_06f6, IL_0705, IL_0710, IL_07c5, IL_07d8, IL_09d9, IL_09e8, IL_0a92, IL_0ad5, IL_0b4d, IL_0b5c, IL_0b6c, IL_0bd1, IL_0bdc, IL_0be6, IL_0ca5, IL_0d01, IL_0d14, IL_0e79, IL_0e8c
			int num = 26;
			_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_3 = default(_003C_003Ec__DisplayClass7_0);
			EntityMetadata metadataImpl = default(EntityMetadata);
			List<TablePartMetadata>.Enumerator enumerator4 = default(List<TablePartMetadata>.Enumerator);
			_003C_003Ec__DisplayClass7_5 _003C_003Ec__DisplayClass7_4 = default(_003C_003Ec__DisplayClass7_5);
			TablePartMetadata oldMetadata2 = default(TablePartMetadata);
			string text = default(string);
			EntityMetadata entityMetadata = default(EntityMetadata);
			DbUpdateAction item = default(DbUpdateAction);
			List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
			_003C_003Ec__DisplayClass7_2 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_2);
			EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
			List<Table>.Enumerator enumerator2 = default(List<Table>.Enumerator);
			Table current2 = default(Table);
			string text2 = default(string);
			string text3 = default(string);
			TypeDbStructures arg = default(TypeDbStructures);
			Action<bool, TypeDbStructures> action = default(Action<bool, TypeDbStructures>);
			_003C_003Ec__DisplayClass7_1 _003C_003Ec__DisplayClass7_2 = default(_003C_003Ec__DisplayClass7_1);
			IPropertyTypeInfo propertyTypeInfo = default(IPropertyTypeInfo);
			List<Column>.Enumerator enumerator3 = default(List<Column>.Enumerator);
			Column current = default(Column);
			Table table = default(Table);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj3;
					switch (num2)
					{
					case 22:
						if (_003C_003Ec__DisplayClass7_3.newMetadata.Type != EntityMetadataType.InterfaceExtension)
						{
							num2 = 30;
							continue;
						}
						goto case 8;
					case 30:
						if (oldMetadata == null)
						{
							num2 = 11;
							continue;
						}
						goto case 12;
					case 24:
						if (!kBSdZPCoAtB3pS069crB(AwcHXTCoH5ExUZ5IKg5u(_003C_003Ec__DisplayClass7_3.newMetadata)))
						{
							num2 = 28;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num2 = 14;
							}
							continue;
						}
						goto default;
					case 25:
						_003C_003Ec__DisplayClass7_3.newMetadata = newMetadata;
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 5;
						}
						continue;
					case 6:
						if (oldMetadata == null)
						{
							num2 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 1;
					case 13:
					case 28:
						metadataImpl = GetMetadataImpl(_003C_003Ec__DisplayClass7_3.newMetadata);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 2;
						}
						continue;
					case 27:
						if (wJ9gLHCogOSgrMVLQ29E(_003C_003Ec__DisplayClass7_3.newMetadata) == Guid.Empty)
						{
							num2 = 22;
							continue;
						}
						goto case 8;
					case 7:
						try
						{
							while (true)
							{
								int num10;
								if (!enumerator4.MoveNext())
								{
									num10 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
									{
										num10 = 4;
									}
									goto IL_01e6;
								}
								goto IL_02c1;
								IL_02c1:
								_003C_003Ec__DisplayClass7_4 = new _003C_003Ec__DisplayClass7_5();
								num10 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
								{
									num10 = 6;
								}
								goto IL_01e6;
								IL_01e6:
								while (true)
								{
									object obj2;
									switch (num10)
									{
									case 2:
										if (oldMetadata != null)
										{
											num10 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
											{
												num10 = 1;
											}
											continue;
										}
										goto default;
									case 6:
										_003C_003Ec__DisplayClass7_4.tablePartNew = enumerator4.Current;
										num10 = 2;
										continue;
									case 3:
										break;
									case 5:
										PrepareActions(oldMetadata2, _003C_003Ec__DisplayClass7_4.tablePartNew);
										num10 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
										{
											num10 = 0;
										}
										continue;
									default:
										obj2 = null;
										goto IL_02fa;
									case 4:
										goto IL_02c1;
									case 1:
										obj2 = oldMetadata.TableParts.FirstOrDefault(_003C_003Ec__DisplayClass7_4._003CPrepareActions_003Eb__7);
										goto IL_02fa;
									case 7:
										return;
										IL_02fa:
										oldMetadata2 = (TablePartMetadata)obj2;
										num10 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
										{
											num10 = 5;
										}
										continue;
									}
									break;
								}
							}
						}
						finally
						{
							((IDisposable)enumerator4).Dispose();
							int num11 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num11 = 0;
							}
							switch (num11)
							{
							case 0:
								break;
							}
						}
					case 5:
						if (YJNZ4HCorcHuiwQSrDvn(_003C_003Ec__DisplayClass7_3.newMetadata))
						{
							num = 27;
							break;
						}
						goto case 8;
					case 16:
						text = (string)AwcHXTCoH5ExUZ5IKg5u(_003C_003Ec__DisplayClass7_3.newMetadata);
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 17;
						}
						continue;
					case 11:
					case 21:
						TablesCreatedActions.Add(new DbCreateColumnAction((ITransformationProvider)transformationProvider, text, new Column((string)TOOKcMCo9nAG6RBmcg46(0x3A6135BE ^ 0x3A6177DC), DbType.Guid)));
						num = 6;
						break;
					case 17:
						if (YZt1QgCo6yF679CeNgEI(_003C_003Ec__DisplayClass7_3.newMetadata) == EntityMetadataType.InterfaceExtension)
						{
							num2 = 29;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num2 = 20;
							}
							continue;
						}
						obj3 = PrepareTable(_003C_003Ec__DisplayClass7_3.newMetadata);
						goto IL_0ebf;
					case 26:
						_003C_003Ec__DisplayClass7_3 = new _003C_003Ec__DisplayClass7_0();
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num2 = 25;
						}
						continue;
					case 9:
						_003C_003Ec__DisplayClass7_3._003C_003E4__this = this;
						num2 = 18;
						continue;
					case 18:
						if (oldMetadata == null)
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto case 4;
					case 15:
						text = entityMetadata.TableName;
						num2 = 13;
						continue;
					case 4:
					case 29:
						obj3 = null;
						goto IL_0ebf;
					case 19:
						if ((entityMetadata = MetadataServiceContext.MetadataRuntimeService.GetMetadata(_003C_003Ec__DisplayClass7_3.newMetadata.BaseClassUid) as EntityMetadata) != null)
						{
							num2 = 15;
							continue;
						}
						goto case 13;
					case 8:
					case 10:
						enumerator4 = _003C_003Ec__DisplayClass7_3.newMetadata.TableParts.GetEnumerator();
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 7;
						}
						continue;
					case 3:
						if (_003C_003Ec__DisplayClass7_3.newMetadata == null)
						{
							num2 = 4;
							continue;
						}
						goto case 17;
					case 12:
						if (!YJNZ4HCorcHuiwQSrDvn(oldMetadata))
						{
							num2 = 21;
							continue;
						}
						goto case 8;
					case 23:
						((IActionsHolder)this).TablesDeletedActions.Add(item);
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 10;
						}
						continue;
					case 20:
						return;
					case 2:
						enumerator = _003C_003Ec__DisplayClass7_3.newMetadata.Properties.GetEnumerator();
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 14;
						}
						continue;
					case 14:
						try
						{
							while (true)
							{
								IL_0d22:
								int num3;
								if (!enumerator.MoveNext())
								{
									num3 = 2;
									goto IL_05b1;
								}
								goto IL_0962;
								IL_05b1:
								while (true)
								{
									int num6;
									object obj;
									switch (num3)
									{
									case 10:
										throw new DbModelException(SR.T((string)TOOKcMCo9nAG6RBmcg46(-1876063057 ^ -1875911341), wXcuPECoxxsIc1HmWJXh(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata), wXcuPECoxxsIc1HmWJXh(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newMetadata), kcpNuiCo0u0IM8At5WnV(entityPropertyMetadata)));
									case 31:
										try
										{
											while (true)
											{
												IL_072e:
												int num7;
												if (!enumerator2.MoveNext())
												{
													num7 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
													{
														num7 = 0;
													}
													goto IL_0714;
												}
												goto IL_0776;
												IL_0776:
												current2 = enumerator2.Current;
												num7 = 3;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
												{
													num7 = 3;
												}
												goto IL_0714;
												IL_0714:
												while (true)
												{
													switch (num7)
													{
													case 2:
														goto IL_072e;
													case 3:
														TablesCreatedActions.Add(new DbCreateTableAction((ITransformationProvider)transformationProvider, current2));
														num7 = 2;
														continue;
													case 1:
														goto IL_0776;
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
											int num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
											{
												num8 = 0;
											}
											switch (num8)
											{
											case 0:
												break;
											}
										}
										goto case 13;
									case 28:
										throw new DbModelException(SR.T((string)TOOKcMCo9nAG6RBmcg46(--1333735954 ^ 0x4F7D608E), wXcuPECoxxsIc1HmWJXh(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata), wXcuPECoxxsIc1HmWJXh(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newMetadata), text2, text3));
									case 21:
										arg = null;
										num3 = 16;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
										{
											num3 = 15;
										}
										continue;
									case 27:
										enumerator2 = _003C_003Ec__DisplayClass7_.propStructures.Tables.GetEnumerator();
										num3 = 31;
										continue;
									case 25:
										if (!kCjhPaColZqB78i6PTZf(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata).Equals(kCjhPaColZqB78i6PTZf(entityPropertyMetadata)))
										{
											num3 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
											{
												num3 = 19;
											}
											continue;
										}
										goto case 1;
									case 6:
									case 37:
										if ((string)wXcuPECoxxsIc1HmWJXh(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675542647))
										{
											num6 = 36;
											goto IL_05ad;
										}
										goto case 24;
									case 1:
										action(arg1: true, arg);
										num3 = 23;
										continue;
									case 17:
										DbModelHelper.ApplyPropertyDbChanges(this, _003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newMetadata, _003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata, entityPropertyMetadata);
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
										{
											num3 = 1;
										}
										continue;
									case 5:
										_003C_003Ec__DisplayClass7_.propStructures = (TypeDbStructures)jnI1p7Co7QZYW0Bk4hZ7(metadataImpl, _003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata);
										num3 = 9;
										continue;
									case 14:
										break;
									case 22:
										_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass7_2;
										num3 = 5;
										continue;
									case 26:
										if (kCjhPaColZqB78i6PTZf(entityPropertyMetadata) != null)
										{
											num3 = 25;
											continue;
										}
										goto case 1;
									case 33:
										text3 = (string)LNA5GpCodiJVrVK7iBiX(propertyTypeInfo, _003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata);
										num6 = 28;
										goto IL_05ad;
									case 19:
										arg = DbModelHelper.GetPropertyDbStructures(metadataImpl, entityPropertyMetadata);
										num3 = 17;
										continue;
									case 29:
										goto IL_09f3;
									case 30:
										text2 = (string)LNA5GpCodiJVrVK7iBiX(propertyTypeInfo, entityPropertyMetadata);
										num3 = 33;
										continue;
									case 3:
										enumerator3 = _003C_003Ec__DisplayClass7_.propStructures.Columns.GetEnumerator();
										num3 = 15;
										continue;
									case 35:
										_003C_003Ec__DisplayClass7_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass7_3;
										num3 = 18;
										continue;
									case 20:
										goto IL_0aaf;
									case 18:
										_003C_003Ec__DisplayClass7_2.propertyMetadata = (EntityPropertyMetadata)enumerator.Current;
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
										{
											num3 = 0;
										}
										continue;
									case 24:
										if (VUHnm6ComSOf8Hh2jiB2(kcpNuiCo0u0IM8At5WnV(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata), entityPropertyMetadata.TypeUid))
										{
											num3 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
											{
												num3 = 11;
											}
											continue;
										}
										goto case 34;
									case 8:
										action = _003C_003Ec__DisplayClass7_._003CPrepareActions_003Eb__1;
										num3 = 12;
										continue;
									case 34:
										if (!VUHnm6ComSOf8Hh2jiB2(t7TxpiCoyNRFetu7Uf2b(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata), t7TxpiCoyNRFetu7Uf2b(entityPropertyMetadata)))
										{
											num3 = 6;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
											{
												num3 = 21;
											}
											continue;
										}
										goto case 7;
									case 32:
										obj = null;
										goto IL_0e41;
									case 15:
										try
										{
											while (true)
											{
												IL_0caf:
												int num4;
												if (!enumerator3.MoveNext())
												{
													num4 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
													{
														num4 = 2;
													}
													goto IL_0bea;
												}
												goto IL_0c10;
												IL_0c10:
												current = enumerator3.Current;
												num4 = 4;
												goto IL_0bea;
												IL_0bea:
												while (true)
												{
													switch (num4)
													{
													case 6:
														break;
													case 5:
														table.Columns.Add(current);
														num4 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
														{
															num4 = 0;
														}
														continue;
													case 4:
														if (table != null)
														{
															num4 = 5;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
															{
																num4 = 1;
															}
															continue;
														}
														goto case 3;
													case 3:
														TablesCreatedActions.Add(new DbCreateColumnAction((ITransformationProvider)transformationProvider, text, current));
														num4 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
														{
															num4 = 1;
														}
														continue;
													default:
														goto IL_0caf;
													case 2:
														goto end_IL_0caf;
													}
													break;
												}
												goto IL_0c10;
												continue;
												end_IL_0caf:
												break;
											}
										}
										finally
										{
											((IDisposable)enumerator3).Dispose();
											int num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
											{
												num5 = 0;
											}
											switch (num5)
											{
											case 0:
												break;
											}
										}
										goto case 27;
									case 4:
									case 23:
										goto IL_0d22;
									case 12:
										if (entityPropertyMetadata != null)
										{
											num3 = 6;
											continue;
										}
										goto case 3;
									case 13:
										action(entityPropertyMetadata == null, null);
										num3 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
										{
											num3 = 0;
										}
										continue;
									case 7:
									case 11:
										propertyTypeInfo = (IPropertyTypeInfo)BTbfFYCoJPVkccgs5NqB(PQuPcqCoMEbHS5CWpXln(), kcpNuiCo0u0IM8At5WnV(entityPropertyMetadata), t7TxpiCoyNRFetu7Uf2b(entityPropertyMetadata));
										num3 = 20;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
										{
											num3 = 18;
										}
										continue;
									case 36:
										if (!(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newMetadata is TablePartMetadata))
										{
											num3 = 24;
											continue;
										}
										goto case 21;
									case 9:
										if (oldMetadata == null)
										{
											num3 = 32;
											continue;
										}
										obj = (EntityPropertyMetadata)oldMetadata.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass7_1.wIBtttZIGcH9g1Es7DPx(_003C_003Ec__DisplayClass7_1.oTghr8ZIhyDE83QAkvIF(p), _003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata.Uid));
										goto IL_0e41;
									default:
										_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_2();
										num3 = 22;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
										{
											num3 = 8;
										}
										continue;
									case 16:
										if (_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata.Settings != null)
										{
											num3 = 26;
											continue;
										}
										goto case 1;
									case 2:
										goto end_IL_0d22;
										IL_0e41:
										entityPropertyMetadata = (EntityPropertyMetadata)obj;
										num3 = 8;
										continue;
										IL_05ad:
										num3 = num6;
										continue;
									}
									break;
									IL_0aaf:
									if (propertyTypeInfo != null)
									{
										if ((IPropertyTypeInfo)((IMetadataService)PQuPcqCoMEbHS5CWpXln()).GetTypeDescriptor(kcpNuiCo0u0IM8At5WnV(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata), t7TxpiCoyNRFetu7Uf2b(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata)) != null)
										{
											num3 = 30;
											continue;
										}
										goto IL_09f3;
									}
									num3 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
									{
										num3 = 10;
									}
									continue;
									IL_09f3:
									throw new DbModelException(SR.T((string)TOOKcMCo9nAG6RBmcg46(--1867379187 ^ 0x6F4FA00F), wXcuPECoxxsIc1HmWJXh(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata), wXcuPECoxxsIc1HmWJXh(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.newMetadata), kcpNuiCo0u0IM8At5WnV(_003C_003Ec__DisplayClass7_.CS_0024_003C_003E8__locals2.propertyMetadata)));
								}
								goto IL_0962;
								IL_0962:
								_003C_003Ec__DisplayClass7_2 = new _003C_003Ec__DisplayClass7_1();
								num3 = 35;
								goto IL_05b1;
								continue;
								end_IL_0d22:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num9 = 0;
							}
							switch (num9)
							{
							case 0:
								break;
							}
						}
						goto case 5;
					default:
						if (YZt1QgCo6yF679CeNgEI(_003C_003Ec__DisplayClass7_3.newMetadata) == EntityMetadataType.InterfaceExtension)
						{
							num2 = 19;
							continue;
						}
						goto case 13;
					case 1:
						{
							item = new DbUpdateAction((ITransformationProvider)transformationProvider, text, new string[1] { (string)TOOKcMCo9nAG6RBmcg46(0x3B36AB09 ^ 0x3B36E96B) }, new object[1] { (YZt1QgCo6yF679CeNgEI(_003C_003Ec__DisplayClass7_3.newMetadata) == EntityMetadataType.InterfaceImplementation) ? _003C_003Ec__DisplayClass7_3.newMetadata.Uid : OmGgAlCo5sjkL8T43cms(_003C_003Ec__DisplayClass7_3.newMetadata) }, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957705386));
							num2 = 23;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
							{
								num2 = 17;
							}
							continue;
						}
						IL_0ebf:
						table = (Table)obj3;
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 12;
						}
						continue;
					}
					break;
				}
			}
		}

		private Table PrepareTable(EntityMetadata newMetadata)
		{
			//Discarded unreachable code: IL_006b, IL_007a
			int num = 2;
			string text = default(string);
			Table table = default(Table);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 5:
						return null;
					case 6:
						if (!m7qAseCojMFlGEDx4YSH(transformationProvider, text))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
							{
								num2 = 0;
							}
							break;
						}
						throw new DbModelException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487023086), text));
					case 4:
						return table;
					case 1:
						if (!kBSdZPCoAtB3pS069crB(text))
						{
							goto end_IL_0012;
						}
						goto case 5;
					case 3:
						TablesCreatedActions.Add(new DbCreateTableAction((ITransformationProvider)transformationProvider, table));
						num2 = 4;
						break;
					default:
						table = CreateTable(newMetadata);
						num2 = 3;
						break;
					case 2:
						text = (string)AwcHXTCoH5ExUZ5IKg5u(newMetadata);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 1;
						}
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 6;
			}
		}

		private Table CreateTable(EntityMetadata newMetadata)
		{
			Table table = new Table();
			FaNvpoCoYtWOICUdGJZW(table, AwcHXTCoH5ExUZ5IKg5u(newMetadata));
			table.Columns = new List<Column>();
			XCbuYFCoLAK681VnVkkb(table, true);
			Column columnForIdentifier = DbModelHelper.GetColumnForIdentifier(newMetadata);
			columnForIdentifier.ColumnProperty = ColumnProperty.PrimaryKey;
			table.Columns.Add(columnForIdentifier);
			return table;
		}

		private IEnumerable<ForeignKey> GetTableForeignKeys(string tableName)
		{
			if (!existingForeignKeys.TryGetValue(tableName.ToUpper(), out var value))
			{
				value = ((ITransformationProvider)transformationProvider).GetForeignKeys(tableName);
				existingForeignKeys[tableName.ToUpper()] = value;
			}
			return value;
		}

		private EntityMetadata GetMetadataImpl(EntityMetadata metadata)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return (EntityMetadata)MetadataLoader.LoadMetadata(wJ9gLHCogOSgrMVLQ29E(metadata));
				default:
					return metadata;
				case 2:
					return (EntityMetadata)MetadataLoader.LoadMetadata(metadata.Uid);
				case 1:
					if (metadata != null)
					{
						if (YZt1QgCo6yF679CeNgEI(metadata) == EntityMetadataType.Interface)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
							{
								num2 = 2;
							}
							break;
						}
						if (metadata.Type != EntityMetadataType.InterfaceExtension)
						{
							return metadata;
						}
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 3;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 0;
						}
					}
					break;
				}
			}
		}

		string IDbModelUpdater.GenerateForeignKeyName(string tableName, string columnName)
		{
			return GenerateNameHelper.GenerateForeignKeyName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542840265), tableName, columnName);
		}

		string IDbModelUpdater.GeneratePrimaryKeyName(string tableName, string columnName)
		{
			return (string)nMNRc1CoUnGwpY0KasbR(TOOKcMCo9nAG6RBmcg46(-1867198571 ^ -1867080659), tableName, columnName);
		}

		string IDbModelUpdater.GenerateDeletingColumnTemporaryName(string tableName, string columnName)
		{
			throw new NotImplementedException();
		}

		string IDbModelUpdater.GetDeletingColumnTemporaryName(string tableName, string columnName)
		{
			throw new NotImplementedException();
		}

		internal static void PM6wKTCowU8tjWnRfOMt()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static void IjeAbfCo4usVeq6i9Yc7(object P_0, object P_1)
		{
			Contract.ArgumentNotNull(P_0, (string)P_1);
		}

		internal static bool NDALb8CoD856DmE8a2E9()
		{
			return r0hQ97CoaRyYAogGTJV8 == null;
		}

		internal static ActionCollector YAxXYICotoM7KSqAcG31()
		{
			return (ActionCollector)r0hQ97CoaRyYAogGTJV8;
		}

		internal static EntityMetadataType YZt1QgCo6yF679CeNgEI(object P_0)
		{
			return ((EntityMetadata)P_0).Type;
		}

		internal static object AwcHXTCoH5ExUZ5IKg5u(object P_0)
		{
			return ((EntityMetadata)P_0).TableName;
		}

		internal static bool kBSdZPCoAtB3pS069crB(object P_0)
		{
			return string.IsNullOrWhiteSpace((string)P_0);
		}

		internal static object jnI1p7Co7QZYW0Bk4hZ7(object P_0, object P_1)
		{
			return DbModelHelper.GetPropertyDbStructures((EntityMetadata)P_0, (EntityPropertyMetadata)P_1);
		}

		internal static object wXcuPECoxxsIc1HmWJXh(object P_0)
		{
			return ((NamedMetadata)P_0).Name;
		}

		internal static Guid kcpNuiCo0u0IM8At5WnV(object P_0)
		{
			return ((PropertyMetadata)P_0).TypeUid;
		}

		internal static bool VUHnm6ComSOf8Hh2jiB2(Guid P_0, Guid P_1)
		{
			return P_0 != P_1;
		}

		internal static Guid t7TxpiCoyNRFetu7Uf2b(object P_0)
		{
			return ((PropertyMetadata)P_0).SubTypeUid;
		}

		internal static object PQuPcqCoMEbHS5CWpXln()
		{
			return MetadataServiceContext.MetadataRuntimeService;
		}

		internal static object BTbfFYCoJPVkccgs5NqB(object P_0, Guid typeUid, Guid subTypeUid)
		{
			return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
		}

		internal static object TOOKcMCo9nAG6RBmcg46(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object LNA5GpCodiJVrVK7iBiX(object P_0, object P_1)
		{
			return ((IPropertyTypeInfo)P_0).GetPropertyTypeDisplayName((PropertyMetadata)P_1);
		}

		internal static object kCjhPaColZqB78i6PTZf(object P_0)
		{
			return ((PropertyMetadata)P_0).Settings;
		}

		internal static bool YJNZ4HCorcHuiwQSrDvn(object P_0)
		{
			return ((ClassMetadata)P_0).AllowCreateHeirs;
		}

		internal static Guid wJ9gLHCogOSgrMVLQ29E(object P_0)
		{
			return ((ClassMetadata)P_0).BaseClassUid;
		}

		internal static Guid OmGgAlCo5sjkL8T43cms(object P_0)
		{
			return ((EntityMetadata)P_0).ImplementationUid;
		}

		internal static bool m7qAseCojMFlGEDx4YSH(object P_0, object P_1)
		{
			return ((ITransformationProvider)P_0).TableExists((string)P_1);
		}

		internal static void FaNvpoCoYtWOICUdGJZW(object P_0, object P_1)
		{
			((Table)P_0).Name = (string)P_1;
		}

		internal static void XCbuYFCoLAK681VnVkkb(object P_0, bool value)
		{
			((Table)P_0).Sequence = value;
		}

		internal static object nMNRc1CoUnGwpY0KasbR(object P_0, object P_1, object P_2)
		{
			return GenerateNameHelper.GeneratePrimaryKeyName((string)P_0, (string)P_1, (string)P_2);
		}
	}

	private readonly List<IDbAction> tablesCreatedActions;

	private readonly List<IDbAction> foreignKeysCreatedActions;

	private readonly List<IDbAction> primaryKeysCreatedActions;

	private readonly List<IDbAction> tablesDeletedActions;

	internal static DbDeltaModelUpdater ljmEIeoWJfbyfA1T4KF5;

	public DbDeltaModelUpdater(IEnumerable<ModifedEntityPair> metadataList)
	{
		SingletonReader.JJCZtPuTvSt();
		tablesCreatedActions = new List<IDbAction>();
		foreignKeysCreatedActions = new List<IDbAction>();
		primaryKeysCreatedActions = new List<IDbAction>();
		tablesDeletedActions = new List<IDbAction>();
		base._002Ector();
		foreach (ModifedEntityPair metadata in metadataList)
		{
			ActionCollector actionCollector = new ActionCollector(metadata.OldMetadata, metadata.NewMetadata);
			tablesCreatedActions.AddRange(actionCollector.TablesCreatedActions);
			foreignKeysCreatedActions.AddRange(actionCollector.ForeignKeysCreatedActions);
			primaryKeysCreatedActions.AddRange(actionCollector.PrimaryKeysCreatedActions);
			tablesDeletedActions.AddRange(((IActionsHolder)actionCollector).TablesDeletedActions);
		}
	}

	public void Update(ISession session)
	{
		//Discarded unreachable code: IL_0078, IL_00cf, IL_0108, IL_0117, IL_018d, IL_027f, IL_02b8, IL_02c7
		int num = 3;
		ITransaction val = default(ITransaction);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						tablesDeletedActions.ForEach(delegate(IDbAction action)
						{
							_003C_003Ec.C0KKVYCbBnD69G4mT1aT(action);
						});
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								return;
							case 1:
								WvOuG1oWrO6nYkfE8E5B(val);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
								{
									num5 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}
					catch
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								mKtE60oWgjctsLVPxync(val);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
								{
									num6 = 0;
								}
								break;
							default:
								throw;
							}
						}
					}
				case 1:
					return;
				case 4:
					break;
				case 2:
					try
					{
						tablesCreatedActions.ForEach(delegate(IDbAction action)
						{
							_003C_003Ec.C0KKVYCbBnD69G4mT1aT(action);
						});
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								WvOuG1oWrO6nYkfE8E5B(val);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
								{
									num3 = 1;
								}
								continue;
							default:
								primaryKeysCreatedActions.ForEach(delegate(IDbAction action)
								{
									_003C_003Ec.C0KKVYCbBnD69G4mT1aT(action);
								});
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num3 = 2;
								}
								continue;
							case 2:
								foreignKeysCreatedActions.ForEach(delegate(IDbAction action)
								{
									_003C_003Ec.C0KKVYCbBnD69G4mT1aT(action);
								});
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
								{
									num3 = 3;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					catch
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								throw;
							}
							val.Rollback();
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
							{
								num4 = 0;
							}
						}
					}
					break;
				case 3:
					goto end_IL_0012;
				}
				val = (ITransaction)EudOB5oWlEjUPNIg7GE1(session);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			val = (ITransaction)EudOB5oWlEjUPNIg7GE1(session);
			num = 2;
		}
	}

	internal static object EudOB5oWlEjUPNIg7GE1(object P_0)
	{
		return ((ISession)P_0).BeginTransaction();
	}

	internal static void WvOuG1oWrO6nYkfE8E5B(object P_0)
	{
		((ITransaction)P_0).Commit();
	}

	internal static void mKtE60oWgjctsLVPxync(object P_0)
	{
		((ITransaction)P_0).Rollback();
	}

	internal static bool Hmw3NVoW990204mraLkW()
	{
		return ljmEIeoWJfbyfA1T4KF5 == null;
	}

	internal static DbDeltaModelUpdater nQanyOoWduhZc0K7PGxj()
	{
		return ljmEIeoWJfbyfA1T4KF5;
	}
}

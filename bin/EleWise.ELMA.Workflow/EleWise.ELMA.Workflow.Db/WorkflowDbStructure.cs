using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Db;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Db;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.Regulation;
using EleWise.ELMA.Workflow.Security;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Exceptions;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Db;

public class WorkflowDbStructure : DbStructureExtension
{
	internal static WorkflowDbStructure oJ7adQOZxh4q05cXXYUd;

	public override Guid ProviderUid => Guid.Empty;

	public override Type[] References => new Type[2]
	{
		wv8abEOZhRRl9re14UG4(typeof(SecurityDbStructure).TypeHandle),
		typeof(TaskDbStructure)
	};

	internal void ReCreateWorkflowInstanceParentsTable()
	{
		//Discarded unreachable code: IL_01da, IL_01e9
		int num = 9;
		int num2 = num;
		Table table = default(Table);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 7:
				table.Columns.Add(new Column((string)YDRdrQOZEWtXK3Wsxu4I(-11799394 ^ -11825004), DbType.Int64, ColumnProperty.NotNull));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				table.Columns.Add(new Column((string)YDRdrQOZEWtXK3Wsxu4I(0x1EA50FCC ^ 0x1EA56B5C), DbType.Boolean, ColumnProperty.NotNull, false));
				num2 = 2;
				break;
			case 3:
			{
				Table obj = new Table
				{
					Columns = new List<Column>(),
					Name = (string)YDRdrQOZEWtXK3Wsxu4I(0x1AF6F1F2 ^ 0x1AF695A6)
				};
				lVbXdNOZwZ9qkR5tnmbU(obj, false);
				table = obj;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 8:
				if (serviceNotNull.TableExists((string)YDRdrQOZEWtXK3Wsxu4I(0x1EA50FCC ^ 0x1EA56B98)))
				{
					num2 = 10;
					break;
				}
				goto case 3;
			case 9:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 8;
				break;
			case 1:
				return;
			default:
				table.Columns.Add(new Column((string)YDRdrQOZEWtXK3Wsxu4I(--727842433 ^ 0x2B61B831), DbType.Int64, ColumnProperty.NotNull));
				num2 = 7;
				break;
			case 6:
				return;
			case 10:
				if (HQUOgSOZzwW8o1IJ7u0l(LrPxI2OZ43ctAuwZyUXg(this), YDRdrQOZEWtXK3Wsxu4I(--1756698829 ^ 0x68B57C99), YDRdrQOZEWtXK3Wsxu4I(--1212129906 ^ 0x483FC6E2)))
				{
					return;
				}
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				serviceNotNull.AddTable(table);
				num2 = 6;
				break;
			case 5:
				((ITransformationProvider)LrPxI2OZ43ctAuwZyUXg(this)).AddColumn((string)YDRdrQOZEWtXK3Wsxu4I(-1539486135 ^ -1539495395), new Column((string)YDRdrQOZEWtXK3Wsxu4I(--727842433 ^ 0x2B619A11), DbType.Boolean, ColumnProperty.NotNull, false));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void CreateProcessRegulationDefault()
	{
		int num = 7;
		IRegulationTemplate regulationTemplate = default(IRegulationTemplate);
		IEntityManager<IRegulationTemplate> instance = default(IEntityManager<IRegulationTemplate>);
		byte[] array = default(byte[]);
		BlobStore serviceNotNull = default(BlobStore);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					WRs8XtOvcHGM2jWwLI83(regulationTemplate, cjfllHOvZy5OcFbbkO2r(YDRdrQOZEWtXK3Wsxu4I(0x2F44D93A ^ 0x2F455F1E)));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					DEvoULOvP63oPGOmy0fM(regulationTemplate, YDRdrQOZEWtXK3Wsxu4I(0x628167BE ^ 0x6280E1F6));
					num2 = 4;
					continue;
				case 3:
					break;
				case 12:
				{
					IEntityManager<IRegulationTemplate> entityManager = instance;
					ParameterExpression parameterExpression = (ParameterExpression)hqjIUmOv0ryXalTt0OK9(typeof(IRegulationTemplate), YDRdrQOZEWtXK3Wsxu4I(-885093259 ^ -885061115));
					if (FS04mBOv5rbbmaKhE2Kk(entityManager.Find(Expression.Lambda<Func<IRegulationTemplate, bool>>((Expression)YFWQ1wOvbfpLyEeRnaXr(DtqEmvOvmvSY9Xw2KIF4(parameterExpression, (MethodInfo)I6KV4DOvyE4KLoHPEJGE((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(null, (FieldInfo)eNf33ZOvtjYO8VDwBsWI((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))) == 0)
					{
						num2 = 8;
						continue;
					}
					return;
				}
				case 13:
				{
					ProcessRegulation processRegulation = new ProcessRegulation();
					XirrWwOvOFVhhRNneaFr(processRegulation, ProcessRegulation.SystemRegulationTemplateUid);
					RegulationTemplateClass regulationTemplateClass = new RegulationTemplateClass();
					Guid templateUid = (regulationTemplateClass.Uid = ProcessRegulation.SystemRegulationTemplateUid);
					jplBxVOvv8nRJU8QV69r(regulationTemplateClass, cjfllHOvZy5OcFbbkO2r(YDRdrQOZEWtXK3Wsxu4I(0x747FFBE0 ^ 0x747E7DC4)));
					GdRTEHOvYN2jCwA9OeHu(regulationTemplateClass, cjfllHOvZy5OcFbbkO2r(YDRdrQOZEWtXK3Wsxu4I(0x438A0E43 ^ 0x438B8867)));
					regulationTemplateClass.FileName = (string)YDRdrQOZEWtXK3Wsxu4I(0x56F860D7 ^ 0x56F9E69F);
					zpBImPOv8wk6s0aat3RH(regulationTemplateClass, true);
					VLckpPOvsUxrZqmdrK8r(regulationTemplateClass, true);
					processRegulation.GlobalTemplates.Add(regulationTemplateClass);
					processRegulation.TemplateUid = templateUid;
					array = (byte[])J3y9BUOvJXQDAq18nImH(processRegulation);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 5:
					if (VG9OGROvKuyOUsg998ql(serviceNotNull, text) == null)
					{
						num2 = 13;
						continue;
					}
					break;
				case 10:
					lL9AHlOvBBu2xPcNDYut(regulationTemplate, cjfllHOvZy5OcFbbkO2r(YDRdrQOZEWtXK3Wsxu4I(0x4940763B ^ 0x4941F01F)));
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
					{
						num2 = 9;
					}
					continue;
				case 14:
					instance.Save(regulationTemplate);
					num2 = 2;
					continue;
				case 6:
					serviceNotNull = Locator.GetServiceNotNull<BlobStore>();
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					regulationTemplate = instance.Create();
					num2 = 11;
					continue;
				case 1:
					kkKjEpOvlahQNHh4mIvo(serviceNotNull, text, array);
					num2 = 3;
					continue;
				case 2:
					return;
				case 11:
					Da5xEDOvgDC8gBmp7mQO(regulationTemplate, ProcessRegulation.SystemRegulationTemplateUid);
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
					{
						num2 = 10;
					}
					continue;
				case 4:
					VUJ3mkOvXAAu1fMBO1bV(regulationTemplate, true);
					num2 = 14;
					continue;
				case 7:
					text = (string)YDRdrQOZEWtXK3Wsxu4I(0x628167BE ^ 0x6280E240);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			instance = EntityManager<IRegulationTemplate>.Instance;
			num = 12;
		}
	}

	public void CreateFullMonitorUserGroup()
	{
		//Discarded unreachable code: IL_01f8, IL_0207
		int num = 11;
		int num2 = num;
		IUserGroup userGroup2 = default(IUserGroup);
		IUserGroup userGroup = default(IUserGroup);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 3:
				userGroup2 = ((AbstractNHEntityManager<IUserGroup, long>)luFfiBOvdRhlTlJmTTmS()).LoadOrNull(SecurityConstants.AdminGroupUid);
				num2 = 2;
				break;
			case 4:
				return;
			case 11:
				userGroup = ((AbstractNHEntityManager<IUserGroup, long>)luFfiBOvdRhlTlJmTTmS()).LoadOrNull(BaseWorkflowConstants.FullMonitorGroupId);
				num2 = 10;
				break;
			case 8:
				if (user != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 9;
			case 2:
				if (userGroup2 != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 12;
					}
					break;
				}
				goto case 7;
			case 9:
				throw new InvalidOperationException((string)s0I6rvOvDZVc3VE81brO(YDRdrQOZEWtXK3Wsxu4I(--727842433 ^ 0x2B6078F7), new object[1] { SecurityConstants.AdminUserUid }));
			case 1:
			{
				InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
				instanceOf.New.Name = BaseWorkflowConstants.FullMonitorGroupDescriptor.Name;
				instanceOf.New.Description = (string)KcK5XJOvnCHJ9A6bAo3G(BaseWorkflowConstants.FullMonitorGroupDescriptor);
				vdrno3OvHRFoo9LxXUZk(instanceOf.New, user);
				userGroup = instanceOf.New;
				num2 = 3;
				break;
			}
			case 13:
				oyp5FYOv91iGsEjjt0u0(userGroup);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
				{
					num2 = 0;
				}
				break;
			case 12:
				userGroup.Groups.Add(userGroup2);
				num2 = 7;
				break;
			default:
				VeLv5VOvW61NkLJy6dbE(Locator.GetServiceNotNull<ISessionProvider>().GetSession(""));
				num2 = 4;
				break;
			case 7:
				svn8iyOvLacR7R8MHSJL(userGroup, BaseWorkflowConstants.FullMonitorGroupId);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)KLIruiOvuV8QLenlvsTR()).LoadOrNull(SecurityConstants.AdminUserUid);
				num2 = 8;
				break;
			case 10:
				if (userGroup == null)
				{
					num2 = 6;
					break;
				}
				goto case 7;
			case 5:
				HxkZwfOvf3BSDiFFIXq9(userGroup, true);
				num2 = 13;
				break;
			}
		}
	}

	public void CreateWorkflowProcessListRunning()
	{
		//Discarded unreachable code: IL_014a, IL_0154, IL_01fc, IL_021b, IL_022a, IL_0257, IL_0266, IL_02e8, IL_031a, IL_0331, IL_0340, IL_036c, IL_03ce, IL_04ec, IL_04fb, IL_052c
		int num = 13;
		_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals0;
		IProcessHeaderFilter processHeaderFilter = default(IProcessHeaderFilter);
		IEnumerator<IProcessHeader> enumerator = default(IEnumerator<IProcessHeader>);
		Guid objectType = default(Guid);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		WorkflowProcessListRunningManager workflowProcessListRunningManager = default(WorkflowProcessListRunningManager);
		IProcessHeader current = default(IProcessHeader);
		Guid[] array = default(Guid[]);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					try
					{
						CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_1();
						int num4 = 8;
						int num5 = num4;
						while (true)
						{
							switch (num5)
							{
							case 2:
								processHeaderFilter = InterfaceActivator.Create<IProcessHeaderFilter>();
								num5 = 5;
								continue;
							case 1:
								enumerator = ((AbstractNHEntityManager<IProcessHeader, long>)YPIRqZOvpYxrjfwt2R4p()).Find((IEntityFilter)processHeaderFilter, (FetchOptions)null).Where(delegate(IProcessHeader p)
								{
									//Discarded unreachable code: IL_002d, IL_003c
									int num11 = 2;
									int num12 = num11;
									while (true)
									{
										switch (num12)
										{
										case 2:
											if (p.Context == null)
											{
												num12 = 1;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
												{
													num12 = 1;
												}
												break;
											}
											goto default;
										default:
											return ((IEnumerable<EntityPropertyMetadata>)((EntityMetadata)_003C_003Ec__DisplayClass7_1.KgkPKyZwju8oAAkEeI8e(p)).EntityProperties).Any(delegate(EntityPropertyMetadata cp)
											{
												//Discarded unreachable code: IL_0085, IL_0094, IL_00ed, IL_00fc, IL_010b
												int num13 = 7;
												int num14 = num13;
												while (true)
												{
													switch (num14)
													{
													case 9:
														return CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.RelationTypes.Contains(_003C_003Ec__DisplayClass7_1.nQPpenZw3IrtJBoaaPyn((EntitySettings)_003C_003Ec__DisplayClass7_1.fPD3bjZwqBg8HNBAOn7l(cp)));
													case 3:
														return false;
													case 8:
														return true;
													case 6:
														return false;
													case 7:
														if (!_003C_003Ec__DisplayClass7_1.a4E3NQZwRX65mnQwfbQM(cp))
														{
															num14 = 6;
															break;
														}
														goto case 5;
													case 2:
														if (!(_003C_003Ec__DisplayClass7_1.fPD3bjZwqBg8HNBAOn7l(cp) is EntitySettings))
														{
															num14 = 1;
															if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
															{
																num14 = 3;
															}
															break;
														}
														goto case 9;
													case 1:
													case 4:
														if (!CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.RelationTypes.Any())
														{
															num14 = 8;
															break;
														}
														goto case 2;
													default:
														if (MetadataLoader.IsBaseClass(_003C_003Ec__DisplayClass7_1.FLXlvWZw6jhVX0p27HiE(cp), CS_0024_003C_003E8__locals0.metadata, loadImplementation: false))
														{
															num14 = 1;
															if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
															{
																num14 = 1;
															}
															break;
														}
														goto case 6;
													case 5:
														if (_003C_003Ec__DisplayClass7_1.FLXlvWZw6jhVX0p27HiE(cp) == CS_0024_003C_003E8__locals0.objectType)
														{
															num14 = 4;
															break;
														}
														goto default;
													}
												}
											});
										case 1:
											return false;
										}
									}
								}).GetEnumerator();
								num5 = 6;
								continue;
							case 3:
								CS_0024_003C_003E8__locals0.objectType = objectType;
								num5 = 4;
								continue;
							case 5:
								processHeaderFilter.HasPublished = true;
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
								{
									num5 = 0;
								}
								continue;
							default:
								processHeaderFilter.DisableSecurity = true;
								num5 = 7;
								continue;
							case 8:
								CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass7_;
								num5 = 3;
								continue;
							case 6:
								try
								{
									while (true)
									{
										IL_0195:
										int num8;
										if (!gJUaKBOvM8XKrhPnKijV(enumerator))
										{
											num8 = 2;
											goto IL_0158;
										}
										goto IL_0172;
										IL_0158:
										while (true)
										{
											switch (num8)
											{
											case 3:
												break;
											case 1:
												goto IL_0195;
											default:
											{
												IWorkflowProcessListRunning workflowProcessListRunning = workflowProcessListRunningManager.Create();
												workflowProcessListRunning.ProcessHeader = current;
												soYMFJOvCXpa7OaHxUeX(workflowProcessListRunning, CS_0024_003C_003E8__locals0.objectType);
												oyp5FYOv91iGsEjjt0u0(workflowProcessListRunning);
												num8 = 1;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
												{
													num8 = 0;
												}
												continue;
											}
											case 2:
												goto end_IL_0195;
											}
											break;
										}
										goto IL_0172;
										IL_0172:
										current = enumerator.Current;
										num8 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
										{
											num8 = 0;
										}
										goto IL_0158;
										continue;
										end_IL_0195:
										break;
									}
								}
								finally
								{
									int num9;
									if (enumerator == null)
									{
										num9 = 2;
										goto IL_0200;
									}
									goto IL_0235;
									IL_0200:
									switch (num9)
									{
									case 2:
										goto end_IL_01eb;
									case 1:
										goto end_IL_01eb;
									}
									goto IL_0235;
									IL_0235:
									enumerator.Dispose();
									num9 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
									{
										num9 = 1;
									}
									goto IL_0200;
									end_IL_01eb:;
								}
								break;
							case 7:
								Fwbq9nOvQNZuhJrRtBMP(processHeaderFilter, string.Format((string)YDRdrQOZEWtXK3Wsxu4I(-1516552726 ^ -1516586482), 1));
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
								{
									num5 = 1;
								}
								continue;
							case 4:
								try
								{
									CS_0024_003C_003E8__locals0.metadata = (ClassMetadata)nYevSTOvTXWQp14eKMOe(CS_0024_003C_003E8__locals0.objectType, true, false);
									int num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
									{
										num6 = 0;
									}
									switch (num6)
									{
									case 0:
										break;
									}
								}
								catch (TypeNotFoundException)
								{
									int num7 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
									{
										num7 = 0;
									}
									switch (num7)
									{
									case 0:
										break;
									}
									break;
								}
								goto case 2;
							case 9:
								break;
							}
							break;
						}
					}
					catch (Exception ex2)
					{
						int num10 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
						{
							num10 = 0;
						}
						while (true)
						{
							switch (num10)
							{
							default:
								((ILogger)kBjZGHOvjr2nj8DfCrtB()).Error(w1WlLWOvRkdXdST5xLk6(CVyylXOvkhF4Kq9N2vFN(YDRdrQOZEWtXK3Wsxu4I(-865213812 ^ -865310068), ex2), Array.Empty<object>()), ex2);
								num10 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
								{
									num10 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 5;
				case 3:
					array = new Guid[2]
					{
						new Guid((string)YDRdrQOZEWtXK3Wsxu4I(-1657582555 ^ -1657615511)),
						new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498909601))
					};
					num2 = 10;
					continue;
				case 14:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					num3 = 0;
					num2 = 9;
					continue;
				case 6:
					return;
				case 11:
					K4FPKHOv6nxfkjLD7A3H(kBjZGHOvjr2nj8DfCrtB(), w1WlLWOvRkdXdST5xLk6(YDRdrQOZEWtXK3Wsxu4I(-1574607501 ^ -1574638309), Array.Empty<object>()));
					num2 = 4;
					continue;
				case 5:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					objectType = array[num3];
					num2 = 8;
					continue;
				case 4:
					return;
				case 12:
					workflowProcessListRunningManager = (WorkflowProcessListRunningManager)BjTYugOvqTVClqyZs9Wt();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (pnuuEXOv3ey1XtAdNlJY(workflowProcessListRunningManager))
					{
						num2 = 11;
						continue;
					}
					goto case 14;
				case 13:
					K4FPKHOv6nxfkjLD7A3H(kBjZGHOvjr2nj8DfCrtB(), w1WlLWOvRkdXdST5xLk6(YDRdrQOZEWtXK3Wsxu4I(--1436248540 ^ 0x559AEF38), Array.Empty<object>()));
					num2 = 12;
					continue;
				case 2:
				case 9:
					if (num3 >= array.Length)
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 7;
				}
				break;
			}
			_003C_003Ec__DisplayClass7_.RelationTypes = new Collection<RelationType> { RelationType.OneToOne };
			num = 3;
		}
	}

	public void CreateFakeDependencies()
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
				serviceNotNull.ExecuteNonQuery(sql);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 3:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				sql = (string)w1WlLWOvRkdXdST5xLk6(YDRdrQOZEWtXK3Wsxu4I(--1212129906 ^ 0x483E2AA8), new object[8]
				{
					hQY33bOvU1OIlC57kdBf(serviceNotNull.Dialect, YDRdrQOZEWtXK3Wsxu4I(-105863102 ^ -105831962)),
					serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45798279)),
					hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(serviceNotNull), YDRdrQOZEWtXK3Wsxu4I(--1756698829 ^ 0x68B55EB1)),
					hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(serviceNotNull), YDRdrQOZEWtXK3Wsxu4I(0x157D5AF4 ^ 0x157D1DF0)),
					hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(serviceNotNull), YDRdrQOZEWtXK3Wsxu4I(0x628167BE ^ 0x62812158)),
					hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD06D13)),
					hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657599325)),
					hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(serviceNotNull), YDRdrQOZEWtXK3Wsxu4I(-1430645277 ^ -1430610981))
				});
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal void DeleteWorkflowQueueItemsAssociatedWithRestrictedWorkflowInstances()
	{
		int num = 3;
		int num2 = num;
		string sql = default(string);
		string text = default(string);
		string text2 = default(string);
		string name = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				base.Transformation.ExecuteNonQuery(sql, new Dictionary<string, object> { { text, 4 } });
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
			{
				object obj = YDRdrQOZEWtXK3Wsxu4I(0x7381F16B ^ 0x73807B61);
				object[] obj2 = new object[8]
				{
					hQY33bOvU1OIlC57kdBf(((ITransformationProvider)LrPxI2OZ43ctAuwZyUXg(this)).Dialect, text2),
					((Dialect)t1xnX7OvV5MEwwDvl0cP(LrPxI2OZ43ctAuwZyUXg(this))).QuoteIfNeeded((string)YDRdrQOZEWtXK3Wsxu4I(-947937941 ^ -947921939)),
					((ITransformationProvider)LrPxI2OZ43ctAuwZyUXg(this)).Dialect.QuoteIfNeeded(name),
					null,
					null,
					null,
					null,
					null
				};
				Dialect dialect = ((ITransformationProvider)LrPxI2OZ43ctAuwZyUXg(this)).Dialect;
				ParameterExpression parameterExpression = (ParameterExpression)hqjIUmOv0ryXalTt0OK9(wv8abEOZhRRl9re14UG4(typeof(IWorkflowQueueItem).TypeHandle), YDRdrQOZEWtXK3Wsxu4I(--1418337216 ^ 0x548A147A));
				obj2[3] = hQY33bOvU1OIlC57kdBf(dialect, LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				object obj3 = t1xnX7OvV5MEwwDvl0cP(base.Transformation);
				parameterExpression = (ParameterExpression)hqjIUmOv0ryXalTt0OK9(typeof(IWorkflowInstance), YDRdrQOZEWtXK3Wsxu4I(0x13F63440 ^ 0x13F63BFA));
				obj2[4] = hQY33bOvU1OIlC57kdBf(obj3, LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstance, object>>((Expression)jjvkmuOvAeiVRei0R3vW(DtqEmvOvmvSY9Xw2KIF4(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wv8abEOZhRRl9re14UG4(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
				object obj4 = t1xnX7OvV5MEwwDvl0cP(base.Transformation);
				parameterExpression = (ParameterExpression)hqjIUmOv0ryXalTt0OK9(wv8abEOZhRRl9re14UG4(typeof(IWorkflowQueueItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077783806));
				obj2[5] = ((Dialect)obj4).QuoteIfNeeded(LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)DtqEmvOvmvSY9Xw2KIF4(parameterExpression, (MethodInfo)I6KV4DOvyE4KLoHPEJGE((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				obj2[6] = XB8KOROvGAZAkGDhEc6F(LrPxI2OZ43ctAuwZyUXg(this));
				obj2[7] = text;
				sql = (string)w1WlLWOvRkdXdST5xLk6(obj, obj2);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
				{
					num2 = 1;
				}
				break;
			}
			case 0:
				return;
			case 2:
				text2 = (string)YDRdrQOZEWtXK3Wsxu4I(-106528299 ^ -106498333);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				name = (string)YDRdrQOZEWtXK3Wsxu4I(0x438A0E43 ^ 0x438A56E9);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				text = (string)YDRdrQOZEWtXK3Wsxu4I(-14356676 ^ -14326054);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal void DropObservedContextPropertyTable()
	{
		//Discarded unreachable code: IL_0062, IL_00a9, IL_00b8, IL_00e4, IL_0146, IL_0155
		//IL_00ca: Expected O, but got Unknown
		int num = 4;
		int num2 = num;
		Guid uid = default(Guid);
		string key = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					int num3;
					if (DataAccessManager.BLOBManager.GetBLOB<List<Guid>>(uid, key) == null)
					{
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
						{
							num3 = 1;
						}
						goto IL_0066;
					}
					goto IL_007c;
					IL_007c:
					((IBLOBDataManager)wXQo1HOv2D0Snfngwrkt()).RemoveBLOB<List<Guid>>(uid, key);
					num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
					{
						num3 = 2;
					}
					goto IL_0066;
					IL_0066:
					switch (num3)
					{
					case 1:
						return;
					case 2:
						return;
					}
					goto IL_007c;
				}
				catch (GenericADOException val)
				{
					GenericADOException val2 = val;
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
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
						UgXs6wOvoxjnsB66CDue(kBjZGHOvjr2nj8DfCrtB(), w1WlLWOvRkdXdST5xLk6(CVyylXOvkhF4Kq9N2vFN(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716528330), val2), Array.Empty<object>()), val2);
						num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
						{
							num4 = 0;
						}
					}
				}
			case 2:
				key = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1360938927);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				huWiHkOv7fGZ2URmgsV5(LrPxI2OZ43ctAuwZyUXg(this), YDRdrQOZEWtXK3Wsxu4I(--1212129906 ^ 0x483FC66A), true);
				num2 = 5;
				break;
			case 0:
				return;
			case 4:
				if (!((ITransformationProvider)LrPxI2OZ43ctAuwZyUXg(this)).TableExists(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75BAD659 ^ 0x75BAB241)))
				{
					return;
				}
				num2 = 3;
				break;
			case 5:
				uid = new Guid((string)YDRdrQOZEWtXK3Wsxu4I(-432000546 ^ -431900016));
				num2 = 2;
				break;
			}
		}
	}

	internal void ReCreateObservedContextPropertyTable()
	{
		int num = 2;
		int num2 = num;
		Table table = default(Table);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				if (((ITransformationProvider)LrPxI2OZ43ctAuwZyUXg(this)).TableExists((string)YDRdrQOZEWtXK3Wsxu4I(-11799394 ^ -11825018)))
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				table = new Table
				{
					Name = (string)YDRdrQOZEWtXK3Wsxu4I(-43932417 ^ -43925273),
					Columns = new List<Column>
					{
						new Column((string)YDRdrQOZEWtXK3Wsxu4I(-1539486135 ^ -1539444311), DbType.Guid),
						new Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x18435FF3), DbType.Guid),
						new Column((string)YDRdrQOZEWtXK3Wsxu4I(-1001967776 ^ -1001952890), DbType.Int64),
						new Column((string)YDRdrQOZEWtXK3Wsxu4I(-1600060848 ^ -1600038150), DbType.Int64),
						new Column((string)YDRdrQOZEWtXK3Wsxu4I(0x5F534A5C ^ 0x5F535AC4), DbType.Int64),
						new Column((string)YDRdrQOZEWtXK3Wsxu4I(-135674354 ^ -135683200), DbType.Guid),
						new Column(ObservedContextPropertyConsts.Fields.ObjectOI, DbType.Int64),
						new Column(ObservedContextPropertyConsts.Fields.ObjectTU, DbType.Guid)
					}
				};
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				R2qXLHOvFrIjV42XVjyW(base.Transformation, table);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void CreateWorkflowQueueDbServiceStructures()
	{
		int num = 1;
		Table table = default(Table);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
				{
					Table table2 = new Table();
					jxNwKAOvIku8UXKqWVb2(table2, YDRdrQOZEWtXK3Wsxu4I(-1028861977 ^ -1028894725));
					table2.Columns = new List<Column>
					{
						new Column((string)YDRdrQOZEWtXK3Wsxu4I(-22348816 ^ -22285682), DbType.Int64),
						new Column((string)YDRdrQOZEWtXK3Wsxu4I(0x7381F16B ^ 0x7381EC01), DbType.Int64),
						new Column((string)YDRdrQOZEWtXK3Wsxu4I(0x4940763B ^ 0x49417FB5), DbType.Guid),
						new Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801876083), DbType.DateTime),
						new Column((string)YDRdrQOZEWtXK3Wsxu4I(-539998957 ^ -539966139), DbType.Guid)
					};
					table = table2;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
					{
						num2 = 4;
					}
					break;
				}
				default:
					if (v92PAHOviFvlRVQetj20(serviceNotNull, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EAD0C8)))
					{
						return;
					}
					goto end_IL_0012;
				case 1:
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 4:
					R2qXLHOvFrIjV42XVjyW(serviceNotNull, table);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	internal void CreateActiveTasksMembers()
	{
		//Discarded unreachable code: IL_05e8, IL_05f7, IL_072d
		int num = 1;
		ParameterExpression parameterExpression = default(ParameterExpression);
		string selectFrom = default(string);
		string text3 = default(string);
		string text2 = default(string);
		string text5 = default(string);
		string text4 = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					parameterExpression = (ParameterExpression)hqjIUmOv0ryXalTt0OK9(wv8abEOZhRRl9re14UG4(typeof(IWorkflowInstanceMember).TypeHandle), YDRdrQOZEWtXK3Wsxu4I(-351369538 ^ -351368956));
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num2 = 8;
					}
					break;
				case 17:
					parameterExpression = (ParameterExpression)hqjIUmOv0ryXalTt0OK9(wv8abEOZhRRl9re14UG4(typeof(IWorkflowInstanceMember).TypeHandle), YDRdrQOZEWtXK3Wsxu4I(0x651FE29D ^ 0x651FED27));
					num2 = 15;
					break;
				case 12:
					if (base.Transformation.TableExists((string)YDRdrQOZEWtXK3Wsxu4I(-11799394 ^ -11821404)))
					{
						num2 = 17;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
						{
							num2 = 18;
						}
						break;
					}
					return;
				case 6:
					parameterExpression = (ParameterExpression)hqjIUmOv0ryXalTt0OK9(wv8abEOZhRRl9re14UG4(typeof(IWorkflowInstanceMember).TypeHandle), YDRdrQOZEWtXK3Wsxu4I(-2111219045 ^ -2111220447));
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
					{
						num2 = 3;
					}
					break;
				case 4:
					return;
				case 3:
					selectFrom = (string)w1WlLWOvRkdXdST5xLk6(YDRdrQOZEWtXK3Wsxu4I(--1418337216 ^ 0x548B9028), new object[18]
					{
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA736012),
						YDRdrQOZEWtXK3Wsxu4I(0x6C7F14 ^ 0x6DEE00),
						hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(base.Transformation), YDRdrQOZEWtXK3Wsxu4I(0x438A0E43 ^ 0x438A48C5)),
						hQY33bOvU1OIlC57kdBf(((ITransformationProvider)LrPxI2OZ43ctAuwZyUXg(this)).Dialect, YDRdrQOZEWtXK3Wsxu4I(0x651FE29D ^ 0x651F88BB)),
						hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(LrPxI2OZ43ctAuwZyUXg(this)), YDRdrQOZEWtXK3Wsxu4I(-398691253 ^ -398672507)),
						hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(LrPxI2OZ43ctAuwZyUXg(this)), YDRdrQOZEWtXK3Wsxu4I(0x1843E01F ^ 0x18438A25)),
						hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(LrPxI2OZ43ctAuwZyUXg(this)), YDRdrQOZEWtXK3Wsxu4I(0x6871CA ^ 0x682960)),
						hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(LrPxI2OZ43ctAuwZyUXg(this)), YDRdrQOZEWtXK3Wsxu4I(0x747FFBE0 ^ 0x747F1822)),
						YDRdrQOZEWtXK3Wsxu4I(--727842433 ^ 0x2B61BAE9),
						hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(LrPxI2OZ43ctAuwZyUXg(this)), YDRdrQOZEWtXK3Wsxu4I(0x7AC609FE ^ 0x7AC663C4)),
						hQY33bOvU1OIlC57kdBf(((ITransformationProvider)LrPxI2OZ43ctAuwZyUXg(this)).Dialect, YDRdrQOZEWtXK3Wsxu4I(-947937941 ^ -947941905)),
						hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(LrPxI2OZ43ctAuwZyUXg(this)), text3),
						hQY33bOvU1OIlC57kdBf(t1xnX7OvV5MEwwDvl0cP(base.Transformation), YDRdrQOZEWtXK3Wsxu4I(0x1843E01F ^ 0x1843A6DF)),
						XB8KOROvGAZAkGDhEc6F(LrPxI2OZ43ctAuwZyUXg(this)),
						YDRdrQOZEWtXK3Wsxu4I(-1712492721 ^ -1712521645),
						string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F44D93A ^ 0x2F444338), ((IEnumerable<TaskBaseStatus>)mcaTnlOvaCg0vIum3AJ0()).Select((TaskBaseStatus u) => (string)CrSdgEOvhkCuluFPX0GD(LrPxI2OZ43ctAuwZyUXg(this), gtpqMJOv1BZpWqkha0Rl(u)))),
						YDRdrQOZEWtXK3Wsxu4I(0x8D5763A ^ 0x8D4E712),
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638218986)
					});
					num2 = 11;
					break;
				case 13:
					text2 = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstanceMember, object>>((Expression)DtqEmvOvmvSY9Xw2KIF4(parameterExpression, (MethodInfo)I6KV4DOvyE4KLoHPEJGE((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
					{
						num2 = 1;
					}
					break;
				case 15:
					text5 = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstanceMember, object>>((Expression)jjvkmuOvAeiVRei0R3vW(DtqEmvOvmvSY9Xw2KIF4(parameterExpression, (MethodInfo)I6KV4DOvyE4KLoHPEJGE((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wv8abEOZhRRl9re14UG4(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num2 = 6;
					}
					break;
				case 5:
					parameterExpression = (ParameterExpression)hqjIUmOv0ryXalTt0OK9(wv8abEOZhRRl9re14UG4(typeof(IWorkflowInstanceMember).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x101DEB5));
					num2 = 16;
					break;
				case 11:
					((ITransformationProvider)LrPxI2OZ43ctAuwZyUXg(this)).Insert(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF61230), new string[5] { text5, text2, text3, text4, text }, (string)w1WlLWOvRkdXdST5xLk6(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC798CC), new object[4]
					{
						goSvkTOvrFiU4jCGD1yy(t1xnX7OvV5MEwwDvl0cP(LrPxI2OZ43ctAuwZyUXg(this))),
						((ITransformationProvider)LrPxI2OZ43ctAuwZyUXg(this)).ParameterSeparator,
						YDRdrQOZEWtXK3Wsxu4I(0x6A69C5CD ^ 0x6A685401),
						YDRdrQOZEWtXK3Wsxu4I(0x34EA50D4 ^ 0x34EBC1FC)
					}), selectFrom, isNeedInsertId: true, new Dictionary<string, object>
					{
						{
							(string)YDRdrQOZEWtXK3Wsxu4I(-865213812 ^ -865307840),
							Ht3wX6OvevCIiAjqItCu(WorkflowRoleTypes.CurrentExecutor)
						},
						{
							(string)YDRdrQOZEWtXK3Wsxu4I(-63028171 ^ -62925527),
							1
						}
					});
					num2 = 4;
					break;
				case 0:
					return;
				case 9:
					return;
				case 14:
					parameterExpression = (ParameterExpression)hqjIUmOv0ryXalTt0OK9(wv8abEOZhRRl9re14UG4(typeof(IWorkflowInstanceMember).TypeHandle), YDRdrQOZEWtXK3Wsxu4I(0x2ACCDD87 ^ 0x2ACCD23D));
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
					{
						num2 = 6;
					}
					break;
				case 8:
					text4 = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstanceMember, object>>((Expression)DtqEmvOvmvSY9Xw2KIF4(parameterExpression, (MethodInfo)I6KV4DOvyE4KLoHPEJGE((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 5;
					break;
				case 10:
					if (!v92PAHOviFvlRVQetj20(LrPxI2OZ43ctAuwZyUXg(this), YDRdrQOZEWtXK3Wsxu4I(-1647793954 ^ -1647817956)))
					{
						return;
					}
					num2 = 14;
					break;
				case 7:
					text3 = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstanceMember, object>>((Expression)DtqEmvOvmvSY9Xw2KIF4(parameterExpression, (MethodInfo)I6KV4DOvyE4KLoHPEJGE((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
					{
						num2 = 0;
					}
					break;
				case 18:
					if (!v92PAHOviFvlRVQetj20(LrPxI2OZ43ctAuwZyUXg(this), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22371494)))
					{
						return;
					}
					goto end_IL_0012;
				case 1:
					if (!v92PAHOviFvlRVQetj20(base.Transformation, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684257334)))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 12;
				case 16:
					text = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstanceMember, object>>((Expression)jjvkmuOvAeiVRei0R3vW(DtqEmvOvmvSY9Xw2KIF4(parameterExpression, (MethodInfo)I6KV4DOvyE4KLoHPEJGE((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), wv8abEOZhRRl9re14UG4(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 3;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 10;
		}
	}

	internal void CreateScriptErrorNotificationSendGroup()
	{
		//Discarded unreachable code: IL_005a, IL_0069
		int num = 2;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (user != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				if (((AbstractNHEntityManager<IUserGroup, long>)luFfiBOvdRhlTlJmTTmS()).LoadOrNull(BaseWorkflowConstants.ScriptErrorNotificationSendPermissionGroupId) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 3:
				throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776403320), SecurityConstants.AdminUserUid));
			default:
			{
				InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
				PwJCbTOvxwMdd1lPAkDM(instanceOf.New, Di0tFNOvNBsO8abTsgAv(BaseWorkflowConstants.ScriptErrorNotificationSendPermissionGroupDescriptor));
				zCuMWWOvSkOKv5oXg1DP(instanceOf.New, KcK5XJOvnCHJ9A6bAo3G(BaseWorkflowConstants.ScriptErrorNotificationSendPermissionGroupDescriptor));
				vdrno3OvHRFoo9LxXUZk(instanceOf.New, user);
				svn8iyOvLacR7R8MHSJL(instanceOf.New, BaseWorkflowConstants.ScriptErrorNotificationSendPermissionGroupId);
				instanceOf.New.IsSystem = true;
				oyp5FYOv91iGsEjjt0u0(instanceOf.New);
				num2 = 4;
				break;
			}
			case 4:
				return;
			case 1:
				user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)KLIruiOvuV8QLenlvsTR()).LoadOrNull(SecurityConstants.AdminUserUid);
				num2 = 5;
				break;
			}
		}
	}

	public WorkflowDbStructure()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type wv8abEOZhRRl9re14UG4(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool QgKDsxOZSg04MeVUiulk()
	{
		return oJ7adQOZxh4q05cXXYUd == null;
	}

	internal static WorkflowDbStructure BFRFfoOZ1uIR4PWQUBbe()
	{
		return oJ7adQOZxh4q05cXXYUd;
	}

	internal static object YDRdrQOZEWtXK3Wsxu4I(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void lVbXdNOZwZ9qkR5tnmbU(object P_0, bool P_1)
	{
		((Table)P_0).Sequence = P_1;
	}

	internal static object LrPxI2OZ43ctAuwZyUXg(object P_0)
	{
		return ((DbStructureExtension)P_0).Transformation;
	}

	internal static bool HQUOgSOZzwW8o1IJ7u0l(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).ColumnExists((string)P_1, (string)P_2);
	}

	internal static object VG9OGROvKuyOUsg998ql(object P_0, object P_1)
	{
		return ((BlobStore)P_0).LoadOrNull((string)P_1);
	}

	internal static void XirrWwOvOFVhhRNneaFr(object P_0, Guid value)
	{
		((ProcessRegulation)P_0).TemplateUid = value;
	}

	internal static object cjfllHOvZy5OcFbbkO2r(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void jplBxVOvv8nRJU8QV69r(object P_0, object P_1)
	{
		((RegulationTemplateClass)P_0).Name = (string)P_1;
	}

	internal static void GdRTEHOvYN2jCwA9OeHu(object P_0, object P_1)
	{
		((RegulationTemplateClass)P_0).Description = (string)P_1;
	}

	internal static void zpBImPOv8wk6s0aat3RH(object P_0, bool value)
	{
		((RegulationTemplateClass)P_0).Save = value;
	}

	internal static void VLckpPOvsUxrZqmdrK8r(object P_0, bool value)
	{
		((RegulationTemplateClass)P_0).IsSystem = value;
	}

	internal static object J3y9BUOvJXQDAq18nImH(object P_0)
	{
		return ClassSerializationHelper.SerializeObject(P_0);
	}

	internal static void kkKjEpOvlahQNHh4mIvo(object P_0, object P_1, object P_2)
	{
		((BlobStore)P_0).Save((string)P_1, (byte[])P_2);
	}

	internal static object hqjIUmOv0ryXalTt0OK9(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object I6KV4DOvyE4KLoHPEJGE(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object DtqEmvOvmvSY9Xw2KIF4(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object eNf33ZOvtjYO8VDwBsWI(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object YFWQ1wOvbfpLyEeRnaXr(object P_0, object P_1, bool P_2, object P_3)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1, P_2, (MethodInfo)P_3);
	}

	internal static int FS04mBOv5rbbmaKhE2Kk(object P_0)
	{
		return ((ICollection<IRegulationTemplate>)P_0).Count;
	}

	internal static void Da5xEDOvgDC8gBmp7mQO(object P_0, Guid value)
	{
		((IRegulationTemplate)P_0).Uid = value;
	}

	internal static void lL9AHlOvBBu2xPcNDYut(object P_0, object P_1)
	{
		((IRegulationTemplate)P_0).Name = (string)P_1;
	}

	internal static void WRs8XtOvcHGM2jWwLI83(object P_0, object P_1)
	{
		((IRegulationTemplate)P_0).Description = (string)P_1;
	}

	internal static void DEvoULOvP63oPGOmy0fM(object P_0, object P_1)
	{
		((IRegulationTemplate)P_0).FileName = (string)P_1;
	}

	internal static void VUJ3mkOvXAAu1fMBO1bV(object P_0, bool value)
	{
		((IRegulationTemplate)P_0).IsSystem = value;
	}

	internal static object luFfiBOvdRhlTlJmTTmS()
	{
		return UserGroupManager.Instance;
	}

	internal static object KLIruiOvuV8QLenlvsTR()
	{
		return UserManager.Instance;
	}

	internal static object s0I6rvOvDZVc3VE81brO(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object KcK5XJOvnCHJ9A6bAo3G(object P_0)
	{
		return ((GroupDescriptor)P_0).Description;
	}

	internal static void vdrno3OvHRFoo9LxXUZk(object P_0, object P_1)
	{
		((IUserGroup)P_0).CreationAuthor = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void svn8iyOvLacR7R8MHSJL(object P_0, Guid P_1)
	{
		((IUserGroup)P_0).Uid = P_1;
	}

	internal static void HxkZwfOvf3BSDiFFIXq9(object P_0, bool P_1)
	{
		((IUserGroup)P_0).IsSystem = P_1;
	}

	internal static void oyp5FYOv91iGsEjjt0u0(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void VeLv5VOvW61NkLJy6dbE(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static object kBjZGHOvjr2nj8DfCrtB()
	{
		return Logger.Log;
	}

	internal static object w1WlLWOvRkdXdST5xLk6(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static void K4FPKHOv6nxfkjLD7A3H(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static object BjTYugOvqTVClqyZs9Wt()
	{
		return WorkflowProcessListRunningManager.Instance;
	}

	internal static bool pnuuEXOv3ey1XtAdNlJY(object P_0)
	{
		return ((EntityManager<IWorkflowProcessListRunning, long>)P_0).Exists();
	}

	internal static object nYevSTOvTXWQp14eKMOe(Guid P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static void Fwbq9nOvQNZuhJrRtBMP(object P_0, object P_1)
	{
		((IEntityFilter)P_0).Query = (string)P_1;
	}

	internal static object YPIRqZOvpYxrjfwt2R4p()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static void soYMFJOvCXpa7OaHxUeX(object P_0, Guid value)
	{
		((IWorkflowProcessListRunning)P_0).TypeObject = value;
	}

	internal static bool gJUaKBOvM8XKrhPnKijV(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object CVyylXOvkhF4Kq9N2vFN(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object hQY33bOvU1OIlC57kdBf(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object t1xnX7OvV5MEwwDvl0cP(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object jjvkmuOvAeiVRei0R3vW(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object XB8KOROvGAZAkGDhEc6F(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static void huWiHkOv7fGZ2URmgsV5(object P_0, object P_1, bool P_2)
	{
		((ITransformationProvider)P_0).RemoveTable((string)P_1, P_2);
	}

	internal static object wXQo1HOv2D0Snfngwrkt()
	{
		return DataAccessManager.BLOBManager;
	}

	internal static void UgXs6wOvoxjnsB66CDue(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void R2qXLHOvFrIjV42XVjyW(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddTable((Table)P_1);
	}

	internal static bool v92PAHOviFvlRVQetj20(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static void jxNwKAOvIku8UXKqWVb2(object P_0, object P_1)
	{
		((Table)P_0).Name = (string)P_1;
	}

	internal static object mcaTnlOvaCg0vIum3AJ0()
	{
		return TaskBaseExtensions.CloseStatuses;
	}

	internal static object goSvkTOvrFiU4jCGD1yy(object P_0)
	{
		return ((Dialect)P_0).GenUid();
	}

	internal static Guid Ht3wX6OvevCIiAjqItCu(object P_0)
	{
		return ((PermissionRoleType)P_0).UID;
	}

	internal static object Di0tFNOvNBsO8abTsgAv(object P_0)
	{
		return ((GroupDescriptor)P_0).Name;
	}

	internal static void PwJCbTOvxwMdd1lPAkDM(object P_0, object P_1)
	{
		((IUserGroup)P_0).Name = (string)P_1;
	}

	internal static void zCuMWWOvSkOKv5oXg1DP(object P_0, object P_1)
	{
		((IUserGroup)P_0).Description = (string)P_1;
	}

	internal static Guid gtpqMJOv1BZpWqkha0Rl(object P_0)
	{
		return ((EnumBase)P_0).Value;
	}

	internal static object CrSdgEOvhkCuluFPX0GD(object P_0, Guid P_1)
	{
		return ((ITransformationProvider)P_0).GuidQuerySintaxis(P_1);
	}
}

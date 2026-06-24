using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Runtime.NH.Proxy;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.Loquacious;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Criterion;
using NHibernate.Dialect;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Mapping.ByCode;
using NHibernate.SqlCommand;
using NHibernate.Tool.hbm2ddl;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Providers;

public abstract class NHProvider : AbstractProvider, IMainDatabaseProvider, IProvider, IConfigurableProvider, IDisposable
{
	private DbStructure[] dbStructures;

	internal static NHProvider h1sdPJWEPb0S33mFM7dv;

	public abstract string ConnectionString { get; }

	public abstract string DataProviderName { get; }

	public virtual bool Enabled
	{
		[CompilerGenerated]
		get
		{
			return _003CEnabled_003Ek__BackingField;
		}
		[CompilerGenerated]
		protected set
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected abstract IMapIdentityProvider MapIdentityProvider { get; }

	protected abstract Type TransformationProviderType { get; }

	protected abstract Version MinServerVersion { get; }

	public override void Init()
	{
		//Discarded unreachable code: IL_0143, IL_017b, IL_01bb, IL_01c6, IL_01d5, IL_0282, IL_029a, IL_02a4, IL_0332, IL_0351, IL_0360, IL_039e, IL_03d6, IL_0530, IL_058f, IL_05ae, IL_05da, IL_060d, IL_0669, IL_06a9, IL_06b8, IL_06c4, IL_06d3, IL_0772, IL_078a, IL_0799, IL_0801, IL_0810, IL_081b, IL_0885, IL_0894, IL_0919, IL_092c, IL_093b, IL_0996, IL_09a5, IL_09b0, IL_09db, IL_09ea, IL_0a9e, IL_0ab1, IL_0ac0, IL_0ae1, IL_0b00, IL_0b0f, IL_0b5d, IL_0b95, IL_0d25, IL_0d5d, IL_0df2, IL_0e01, IL_0e0c, IL_0e98, IL_0ed8, IL_0ee3, IL_0ef2, IL_0f58, IL_0f90, IL_0f9f
		int num = 2;
		int num2 = num;
		IEnumerable<INHManagerRegistrar> extensionPoints = default(IEnumerable<INHManagerRegistrar>);
		IStartInformation startInformation2 = default(IStartInformation);
		IRuntimeApplication serviceNotNull = default(IRuntimeApplication);
		NHManagerRegisterParams nHManagerRegisterParams = default(NHManagerRegisterParams);
		SessionFactoryHolder sessionFactoryHolder = default(SessionFactoryHolder);
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0;
		IEnumerable<IDbStructureExtension> enumerable = default(IEnumerable<IDbStructureExtension>);
		Configuration val = default(Configuration);
		HbmMapping val2 = default(HbmMapping);
		IStartInformation startInformation3 = default(IStartInformation);
		Dictionary<string, DbStructure.DbProcedure>.ValueCollection.Enumerator enumerator4 = default(Dictionary<string, DbStructure.DbProcedure>.ValueCollection.Enumerator);
		DbStructure current3 = default(DbStructure);
		DbStructure.DbProcedure current2 = default(DbStructure.DbProcedure);
		Dictionary<string, DbStructure.DbView>.ValueCollection.Enumerator enumerator3 = default(Dictionary<string, DbStructure.DbView>.ValueCollection.Enumerator);
		DbStructure.DbView current = default(DbStructure.DbView);
		IEnumerator<INHProviderDependentUserTypeRegistrar> enumerator = default(IEnumerator<INHProviderDependentUserTypeRegistrar>);
		IStartInformation startInformation = default(IStartInformation);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					InitInternal();
					int num3 = 13;
					while (true)
					{
						int num22;
						switch (num3)
						{
						case 6:
							extensionPoints = ((ComponentManager)uWDe7UWEtqeS2Xx4CPeC()).GetExtensionPoints<INHManagerRegistrar>();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num3 = 0;
							}
							break;
						case 14:
							startInformation2 = (IStartInformation)t2saf6WEpS98FQCvbhef(100.0, th4tViWE0kDOJwC5x96v(HeKR9RWE3F1PkePe16DB(0x53CACA3 ^ 0x53D0F93)));
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
							{
								num3 = 1;
							}
							break;
						case 15:
						{
							NHManagerRegisterParams nHManagerRegisterParams2 = new NHManagerRegisterParams();
							mSt1FTWEH4S9dZ4igr97(nHManagerRegisterParams2, ComponentManager.Builder);
							nHManagerRegisterParams2.TransformationProvider = (ITransformationProvider)lLlQkrWEAMdbnK3PVc8l(serviceNotNull);
							nHManagerRegisterParams = nHManagerRegisterParams2;
							num22 = 10;
							goto IL_0039;
						}
						case 9:
							try
							{
								CrLeqZWELU3FExsmGiMI(sessionFactoryHolder);
								int num27 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
								{
									num27 = 0;
								}
								switch (num27)
								{
								case 0:
									break;
								}
							}
							finally
							{
								int num28;
								if (startInformation2 == null)
								{
									num28 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
									{
										num28 = 0;
									}
									goto IL_017f;
								}
								goto IL_0195;
								IL_0195:
								ubHXZOWE6Vou1NCIHia3(startInformation2);
								num28 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
								{
									num28 = 1;
								}
								goto IL_017f;
								IL_017f:
								switch (num28)
								{
								default:
									goto end_IL_015a;
								case 2:
									break;
								case 0:
									goto end_IL_015a;
								case 1:
									goto end_IL_015a;
								}
								goto IL_0195;
								end_IL_015a:;
							}
							goto case 5;
						case 5:
							RegistrationExtensions.RegisterInstance<SessionFactoryHolder>((ContainerBuilder)eCJp2qWEaNQrMnTxUngj(), sessionFactoryHolder).SingleInstance();
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num3 = 8;
							}
							break;
						case 3:
							startInformation2 = StartInformation.Operation(93.0, SR.M((string)HeKR9RWE3F1PkePe16DB(0x42643203 ^ 0x4265934B)));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
							{
								num3 = 1;
							}
							break;
						case 2:
							tg2v2kWEmu2d44oMPfdY();
							num22 = 3;
							goto IL_0039;
						case 7:
							try
							{
								IEnumerator<INHManagerRegistrar> enumerator5 = extensionPoints.GetEnumerator();
								int num23 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
								{
									num23 = 0;
								}
								switch (num23)
								{
								default:
									try
									{
										while (true)
										{
											int num24;
											if (!RNjLyPWE42Y6SZYis3QZ(enumerator5))
											{
												num24 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
												{
													num24 = 1;
												}
												goto IL_02a8;
											}
											goto IL_02e4;
											IL_02e4:
											enumerator5.Current.Register(nHManagerRegisterParams);
											num24 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
											{
												num24 = 0;
											}
											goto IL_02a8;
											IL_02a8:
											switch (num24)
											{
											case 2:
												goto IL_02e4;
											case 1:
												goto end_IL_02be;
											}
											continue;
											end_IL_02be:
											break;
										}
									}
									finally
									{
										int num25;
										if (enumerator5 == null)
										{
											num25 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
											{
												num25 = 0;
											}
											goto IL_0336;
										}
										goto IL_036b;
										IL_036b:
										ubHXZOWE6Vou1NCIHia3(enumerator5);
										num25 = 2;
										goto IL_0336;
										IL_0336:
										switch (num25)
										{
										default:
											goto end_IL_0311;
										case 0:
											goto end_IL_0311;
										case 1:
											break;
										case 2:
											goto end_IL_0311;
										}
										goto IL_036b;
										end_IL_0311:;
									}
									break;
								}
							}
							finally
							{
								if (startInformation2 != null)
								{
									int num26 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
									{
										num26 = 1;
									}
									while (true)
									{
										switch (num26)
										{
										case 1:
											startInformation2.Dispose();
											num26 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
											{
												num26 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
							goto case 2;
						case 8:
							OZMgW0WEULCnZpPm5FET(this, true);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
							{
								num3 = 17;
							}
							break;
						case 13:
							RegistrationExtensions.PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType((ContainerBuilder)eCJp2qWEaNQrMnTxUngj(), t3CDWlWEDqpKO4UHE6rd(this)).As<ITransformationProvider>().As<ITransformationProviderAsync>()
								.SingleInstance(), (PropertyWiringOptions)0);
							num3 = 16;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num3 = 0;
							}
							break;
						case 1:
							try
							{
								CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
								{
									num6 = 0;
								}
								while (true)
								{
									switch (num6)
									{
									case 1:
										CS_0024_003C_003E8__locals0.deactivatingModules = ((DbPreUpdater)VGWMDbWEyswbndfAuIct(serviceNotNull)).GetDeactivatingModules();
										num6 = 12;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
										{
											num6 = 1;
										}
										continue;
									default:
										enumerable = ((ComponentManager)uWDe7UWEtqeS2Xx4CPeC()).GetExtensionPoints<IDbStructureExtension>().Where(delegate(IDbStructureExtension db)
										{
											//Discarded unreachable code: IL_0070, IL_007f
											int num30 = 1;
											int num31 = num30;
											while (true)
											{
												switch (num31)
												{
												case 1:
													if (IJVGXiWfCCI0Eh1Rr2Rg(m0aRYsWfYrYqHXfylIwd(db), twb10qWfj6Qd8pYRnvNf(this)))
													{
														num31 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
														{
															num31 = 0;
														}
														break;
													}
													goto case 2;
												case 2:
													return IJVGXiWfCCI0Eh1Rr2Rg(m0aRYsWfYrYqHXfylIwd(db), Guid.Empty);
												default:
													return true;
												}
											}
										});
										num6 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
										{
											num6 = 2;
										}
										continue;
									case 10:
										try
										{
											val = (Configuration)a2KfrOWE91Imh7KtBiAc(this);
											int num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
											{
												num7 = 0;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													qkBNKJWEdfeRMClZBoCB(val, val2);
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
													{
														num7 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
										finally
										{
											int num8;
											if (startInformation3 == null)
											{
												num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
												{
													num8 = 0;
												}
												goto IL_0593;
											}
											goto IL_05b8;
											IL_05b8:
											ubHXZOWE6Vou1NCIHia3(startInformation3);
											num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
											{
												num8 = 1;
											}
											goto IL_0593;
											IL_0593:
											switch (num8)
											{
											default:
												goto end_IL_056e;
											case 0:
												goto end_IL_056e;
											case 2:
												break;
											case 1:
												goto end_IL_056e;
											}
											goto IL_05b8;
											end_IL_056e:;
										}
										goto case 7;
									case 5:
										try
										{
											val2 = (HbmMapping)qkDsKjWEJlchZ8XDkljE(Jy62nhWEM7qe9YY1KXPB(nHManagerRegisterParams));
											int num19 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
											{
												num19 = 0;
											}
											while (true)
											{
												switch (num19)
												{
												default:
													val2.defaultaccess = typeof(EntityPropertyAccessor).AssemblyQualifiedName;
													num19 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
													{
														num19 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
										finally
										{
											int num20;
											if (startInformation3 == null)
											{
												num20 = 2;
												goto IL_066d;
											}
											goto IL_0683;
											IL_066d:
											switch (num20)
											{
											default:
												goto end_IL_0658;
											case 1:
												break;
											case 2:
												goto end_IL_0658;
											case 0:
												goto end_IL_0658;
											}
											goto IL_0683;
											IL_0683:
											ubHXZOWE6Vou1NCIHia3(startInformation3);
											num20 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
											{
												num20 = 0;
											}
											goto IL_066d;
											end_IL_0658:;
										}
										goto case 9;
									case 9:
										startInformation3 = (IStartInformation)t2saf6WEpS98FQCvbhef(88.0, th4tViWE0kDOJwC5x96v(HeKR9RWE3F1PkePe16DB(0x53FA00CE ^ 0x53FBA174)));
										num6 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
										{
											num6 = 10;
										}
										continue;
									case 6:
										try
										{
											IEnumerator<DbStructure> enumerator2 = dbStructures.Where((DbStructure db) => !_003C_003Ec.d6oJk0QNtC0AUirAVlxe(db)).GetEnumerator();
											int num10 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
											{
												num10 = 0;
											}
											switch (num10)
											{
											default:
												try
												{
													while (true)
													{
														IL_097a:
														int num11;
														if (!RNjLyPWE42Y6SZYis3QZ(enumerator2))
														{
															num11 = 3;
															goto IL_07a8;
														}
														goto IL_0946;
														IL_07a8:
														while (true)
														{
															switch (num11)
															{
															case 6:
																enumerator4 = current3.Procedures.Values.GetEnumerator();
																num11 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
																{
																	num11 = 4;
																}
																continue;
															case 4:
																try
																{
																	while (true)
																	{
																		int num14;
																		if (!enumerator4.MoveNext())
																		{
																			num14 = 3;
																			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
																			{
																				num14 = 4;
																			}
																			goto IL_081f;
																		}
																		goto IL_089f;
																		IL_089f:
																		current2 = enumerator4.Current;
																		num14 = 1;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
																		{
																			num14 = 1;
																		}
																		goto IL_081f;
																		IL_081f:
																		while (true)
																		{
																			switch (num14)
																			{
																			case 5:
																				FnvR49WEgeMKyGVgUW9r(val, current2.Mappings);
																				num14 = 3;
																				continue;
																			case 2:
																			case 3:
																				break;
																			default:
																				goto IL_089f;
																			case 1:
																				if (udr4LiWErhmyAf8Nuv3G(XSgZiJWElg9VF5y9MOYU(current2)))
																				{
																					num14 = 2;
																					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
																					{
																						num14 = 0;
																					}
																					continue;
																				}
																				goto case 5;
																			case 4:
																				goto end_IL_085a;
																			}
																			break;
																		}
																		continue;
																		end_IL_085a:
																		break;
																	}
																}
																finally
																{
																	((IDisposable)enumerator4).Dispose();
																	int num15 = 0;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
																	{
																		num15 = 0;
																	}
																	switch (num15)
																	{
																	case 0:
																		break;
																	}
																}
																goto case 1;
															case 5:
																break;
															case 1:
																enumerator3 = current3.Views.Values.GetEnumerator();
																num11 = 2;
																continue;
															default:
																goto IL_097a;
															case 2:
																try
																{
																	while (true)
																	{
																		IL_0a4c:
																		int num12;
																		if (!enumerator3.MoveNext())
																		{
																			num12 = 3;
																			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
																			{
																				num12 = 4;
																			}
																			goto IL_09b4;
																		}
																		goto IL_09f5;
																		IL_09f5:
																		current = enumerator3.Current;
																		num12 = 5;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
																		{
																			num12 = 1;
																		}
																		goto IL_09b4;
																		IL_09b4:
																		while (true)
																		{
																			switch (num12)
																			{
																			case 5:
																				if (udr4LiWErhmyAf8Nuv3G(kihwtxWE5fTvHCWRUL3J(current)))
																				{
																					num12 = 3;
																					continue;
																				}
																				goto case 1;
																			case 1:
																				FnvR49WEgeMKyGVgUW9r(val, kihwtxWE5fTvHCWRUL3J(current));
																				num12 = 2;
																				continue;
																			case 2:
																			case 3:
																				goto IL_0a4c;
																			case 4:
																				goto end_IL_0a4c;
																			}
																			break;
																		}
																		goto IL_09f5;
																		continue;
																		end_IL_0a4c:
																		break;
																	}
																}
																finally
																{
																	((IDisposable)enumerator3).Dispose();
																	int num13 = 0;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
																	{
																		num13 = 0;
																	}
																	switch (num13)
																	{
																	case 0:
																		break;
																	}
																}
																goto IL_097a;
															case 3:
																goto end_IL_097a;
															}
															break;
														}
														goto IL_0946;
														IL_0946:
														current3 = enumerator2.Current;
														int num16 = 6;
														num11 = num16;
														goto IL_07a8;
														continue;
														end_IL_097a:
														break;
													}
												}
												finally
												{
													int num17;
													if (enumerator2 == null)
													{
														num17 = 2;
														goto IL_0ae5;
													}
													goto IL_0b1a;
													IL_0ae5:
													switch (num17)
													{
													case 2:
														goto end_IL_0ad0;
													case 1:
														goto end_IL_0ad0;
													}
													goto IL_0b1a;
													IL_0b1a:
													ubHXZOWE6Vou1NCIHia3(enumerator2);
													num17 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
													{
														num17 = 1;
													}
													goto IL_0ae5;
													end_IL_0ad0:;
												}
												break;
											}
										}
										finally
										{
											if (startInformation3 != null)
											{
												int num18 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
												{
													num18 = 0;
												}
												while (true)
												{
													switch (num18)
													{
													default:
														ubHXZOWE6Vou1NCIHia3(startInformation3);
														num18 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
														{
															num18 = 1;
														}
														continue;
													case 1:
														break;
													}
													break;
												}
											}
										}
										goto case 13;
									case 2:
										enumerable = SortDbStructures(enumerable);
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
										{
											num6 = 0;
										}
										continue;
									case 7:
									{
										startInformation3 = (IStartInformation)t2saf6WEpS98FQCvbhef(97.0, th4tViWE0kDOJwC5x96v(HeKR9RWE3F1PkePe16DB(--1418440330 ^ 0x548A0C88)));
										int num9 = 6;
										num6 = num9;
										continue;
									}
									case 13:
										kSlA2dWEjYR3rSeWWwdq(val);
										num6 = 4;
										continue;
									case 11:
										startInformation3 = StartInformation.Operation(60.0, (string)th4tViWE0kDOJwC5x96v(HeKR9RWE3F1PkePe16DB(-1487388570 ^ -1487281674)));
										num6 = 5;
										continue;
									case 4:
										eYf7nTWEYCS78w69Ih1c(val, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858993163), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978441333));
										num6 = 3;
										continue;
									case 3:
										eYf7nTWEYCS78w69Ih1c(val, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637F8A9B), TZ.ServerOffset.ToString());
										num6 = 8;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
										{
											num6 = 7;
										}
										continue;
									case 12:
										dbStructures = (from s in enumerable.Select(delegate(IDbStructureExtension db)
											{
												//Discarded unreachable code: IL_006e, IL_00b7, IL_00c6
												int num32 = 6;
												IModule module = default(IModule);
												DbStructure dbStructure = default(DbStructure);
												while (true)
												{
													int num33 = num32;
													while (true)
													{
														switch (num33)
														{
														case 4:
															if (!CS_0024_003C_003E8__locals0.deactivatingModules.Contains((string)_003C_003Ec__DisplayClass8_0.AppqkuQN1jR2wkd0iu3m(module)))
															{
																goto end_IL_0012;
															}
															goto case 1;
														default:
															if (module != null)
															{
																num33 = 1;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
																{
																	num33 = 4;
																}
																break;
															}
															goto case 7;
														case 5:
															if (dbStructure != null)
															{
																num33 = 3;
																break;
															}
															goto case 9;
														case 8:
															return dbStructure;
														case 7:
															return null;
														case 9:
															return null;
														case 3:
															if (((ComponentManager)_003C_003Ec__DisplayClass8_0.NlLstBQNe3ZvnfSPkXvP()).ModuleManager.IsAssemblyAvailable(db.GetType().Assembly))
															{
																return dbStructure;
															}
															num33 = 2;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
															{
																num33 = 2;
															}
															break;
														case 6:
															dbStructure = (DbStructure)_003C_003Ec__DisplayClass8_0.TBlkynQN2raTja1DwYno(db);
															num33 = 5;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
															{
																num33 = 0;
															}
															break;
														case 1:
															_003C_003Ec__DisplayClass8_0.GKWZNHQNND8f6obLRFAy(dbStructure, true);
															num33 = 8;
															break;
														case 2:
															module = (IModule)_003C_003Ec__DisplayClass8_0.aC0PbTQNP38NWyRTxlQu(((ComponentManager)_003C_003Ec__DisplayClass8_0.NlLstBQNe3ZvnfSPkXvP()).ModuleManager, db.GetType().Assembly);
															num33 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
															{
																num33 = 0;
															}
															break;
														}
														continue;
														end_IL_0012:
														break;
													}
													num32 = 7;
												}
											})
											where s != null
											select s).ToArray();
										num6 = 11;
										continue;
									case 8:
										break;
									}
									break;
								}
							}
							finally
							{
								if (startInformation2 != null)
								{
									int num21 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
									{
										num21 = 0;
									}
									while (true)
									{
										switch (num21)
										{
										default:
											ubHXZOWE6Vou1NCIHia3(startInformation2);
											num21 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
											{
												num21 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
							goto case 4;
						case 4:
							sessionFactoryHolder = new SessionFactoryHolder(val);
							num3 = 14;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
							{
								num3 = 7;
							}
							break;
						default:
							serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
							num3 = 14;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
							{
								num3 = 15;
							}
							break;
						case 16:
							enumerator = (from registrar in ((ComponentManager)uWDe7UWEtqeS2Xx4CPeC()).GetExtensionPoints<INHProviderDependentUserTypeRegistrar>()
								where IJVGXiWfCCI0Eh1Rr2Rg(pjWS22Wf5EUq1e6PDuQi(registrar), twb10qWfj6Qd8pYRnvNf(this))
								select registrar).GetEnumerator();
							num3 = 11;
							break;
						case 10:
							tGfbSXWExMlfxQMrsju9(ifvQwOWE7kfYKACEOlr4(this));
							num3 = 12;
							break;
						case 11:
							try
							{
								while (true)
								{
									int num4;
									if (!RNjLyPWE42Y6SZYis3QZ(enumerator))
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
										{
											num4 = 0;
										}
										goto IL_0e10;
									}
									goto IL_0e26;
									IL_0e26:
									rCCZEdWEw0C9hYyRBlGF(enumerator.Current);
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
									{
										num4 = 2;
									}
									goto IL_0e10;
									IL_0e10:
									switch (num4)
									{
									case 1:
										goto IL_0e26;
									case 2:
										continue;
									case 0:
										break;
									}
									break;
								}
							}
							finally
							{
								int num5;
								if (enumerator == null)
								{
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
									{
										num5 = 0;
									}
									goto IL_0e9c;
								}
								goto IL_0eb2;
								IL_0eb2:
								ubHXZOWE6Vou1NCIHia3(enumerator);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num5 = 1;
								}
								goto IL_0e9c;
								IL_0e9c:
								switch (num5)
								{
								default:
									goto end_IL_0e77;
								case 2:
									break;
								case 0:
									goto end_IL_0e77;
								case 1:
									goto end_IL_0e77;
								}
								goto IL_0eb2;
								end_IL_0e77:;
							}
							goto case 6;
						case 12:
							startInformation2 = (IStartInformation)t2saf6WEpS98FQCvbhef(91.0, th4tViWE0kDOJwC5x96v(HeKR9RWE3F1PkePe16DB(0x7C1EE318 ^ 0x7C1F4200)));
							num3 = 7;
							break;
						case 17:
							return;
							IL_0039:
							num3 = num22;
							break;
						}
					}
				}
				finally
				{
					if (startInformation != null)
					{
						int num29 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num29 = 1;
						}
						while (true)
						{
							switch (num29)
							{
							case 1:
								ubHXZOWE6Vou1NCIHia3(startInformation);
								num29 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
								{
									num29 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 2:
				startInformation = (IStartInformation)t2saf6WEpS98FQCvbhef(100.0, SR.M((string)HeKR9RWE3F1PkePe16DB(0x6DC147B0 ^ 0x6DC0E70A)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void InitComplete()
	{
		//Discarded unreachable code: IL_006c, IL_00cf, IL_0114, IL_0184, IL_01e1, IL_025d, IL_026c, IL_0300, IL_0340, IL_034f, IL_035b, IL_0467, IL_0487, IL_0491, IL_051d, IL_0555, IL_05ca, IL_060a, IL_0619, IL_0646, IL_067e, IL_068d
		int num = 1;
		int num2 = num;
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		IRuntimeApplication serviceNotNull = default(IRuntimeApplication);
		IStartInformation startInformation = default(IStartInformation);
		while (true)
		{
			switch (num2)
			{
			case 1:
				metadataServiceContext = MetadataServiceContext.New<IMetadataRuntimeService>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				DateTime dateTime = DateTime.Now;
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					case 5:
						try
						{
							IDbUpdateHandler[] handlers = ComponentManager.Current.GetExtensionPoints<IDbUpdateHandler>().Where(delegate(IDbUpdateHandler db)
							{
								int num13 = 1;
								int num14 = num13;
								while (true)
								{
									switch (num14)
									{
									default:
										return LvRNe1WfLwEAKyMAm7fh(db) == Guid.Empty;
									case 1:
										if (LvRNe1WfLwEAKyMAm7fh(db) == Uid)
										{
											return true;
										}
										num14 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
										{
											num14 = 0;
										}
										break;
									}
								}
							}).ToArray();
							int num4 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
							{
								num4 = 2;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (!g5cNbuWEsiIKliCLOZQb(serviceNotNull))
									{
										num4 = 6;
										continue;
									}
									goto case 5;
								case 6:
									break;
								case 3:
									try
									{
										((ITransformationProvider)lLlQkrWEAMdbnK3PVc8l(serviceNotNull)).ExecuteNonQuery((string)CRjEMAWfFKBhhSk32Jok(HeKR9RWE3F1PkePe16DB(-1998538950 ^ -1998572764), ((Dialect)A7OT4sWEzOKrJxMa36Oe(serviceNotNull.TransformationProvider)).QuoteIfNeeded((string)HeKR9RWE3F1PkePe16DB(-957824448 ^ -957786754))), (Dictionary<string, object>)null);
										int num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
										{
											num5 = 1;
										}
										while (true)
										{
											switch (num5)
											{
											case 1:
												Nfjov4WfBOxTdWIWaW68(serviceNotNull.TransformationProvider);
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
												{
													num5 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									catch (Exception ex)
									{
										int num6 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
										{
											num6 = 1;
										}
										while (true)
										{
											switch (num6)
											{
											case 1:
												baf2a8Wfbg7jwHCvKp2o(lLlQkrWEAMdbnK3PVc8l(serviceNotNull));
												num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
												{
													num6 = 0;
												}
												continue;
											case 2:
												hMg2JTWfoSD7PohMRvrq(oGZ3VPWfWGtL1AV5ZZjD(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812065906), ex);
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
												{
													num6 = 1;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									break;
								case 2:
									serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
									{
										num4 = 0;
									}
									continue;
								case 5:
									jE8Ll1WEcBbG99x0rNbF(lLlQkrWEAMdbnK3PVc8l(serviceNotNull));
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
									{
										num4 = 3;
									}
									continue;
								case 4:
									Locator.GetServiceNotNull<DbStructureReader>().Read(dbStructures, handlers);
									num4 = 2;
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						finally
						{
							int num7;
							if (startInformation == null)
							{
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
								{
									num7 = 1;
								}
								goto IL_0304;
							}
							goto IL_031a;
							IL_031a:
							ubHXZOWE6Vou1NCIHia3(startInformation);
							num7 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num7 = 2;
							}
							goto IL_0304;
							IL_0304:
							switch (num7)
							{
							case 1:
								goto end_IL_02df;
							case 2:
								goto end_IL_02df;
							}
							goto IL_031a;
							end_IL_02df:;
						}
						goto case 2;
					case 1:
						startInformation = (IStartInformation)t2saf6WEpS98FQCvbhef(40.0, th4tViWE0kDOJwC5x96v(HeKR9RWE3F1PkePe16DB(-1767720453 ^ -1767695737)));
						num3 = 5;
						continue;
					case 4:
						dateTime = ib6UP1WfhgQ5rsk5DpaD();
						num3 = 3;
						continue;
					case 2:
						AaZulgWfEEiepy2saa0J(oGZ3VPWfWGtL1AV5ZZjD(), CRjEMAWfFKBhhSk32Jok(HeKR9RWE3F1PkePe16DB(0x12441CA4 ^ 0x1245BF4C), (int)veOg29WfGu9YtB7Sd68c(ib6UP1WfhgQ5rsk5DpaD(), dateTime).TotalMilliseconds));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num3 = 4;
						}
						continue;
					case 3:
						startInformation = (IStartInformation)t2saf6WEpS98FQCvbhef(91.0, SR.M((string)HeKR9RWE3F1PkePe16DB(-978351861 ^ -978440919)));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num3 = 0;
						}
						continue;
					}
					try
					{
						IEnumerator<INHManager> enumerator = Locator.GetServiceNotNull<IEnumerable<INHManager>>().GetEnumerator();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num8 = 1;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								try
								{
									while (true)
									{
										int num9;
										if (!RNjLyPWE42Y6SZYis3QZ(enumerator))
										{
											num9 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
											{
												num9 = 0;
											}
											goto IL_0495;
										}
										goto IL_04ab;
										IL_04ab:
										odj44xWffsCKBSEZ90nT(enumerator.Current);
										num9 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
										{
											num9 = 1;
										}
										goto IL_0495;
										IL_0495:
										switch (num9)
										{
										case 2:
											goto IL_04ab;
										case 1:
											continue;
										case 0:
											break;
										}
										break;
									}
								}
								finally
								{
									if (enumerator != null)
									{
										int num10 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
										{
											num10 = 0;
										}
										while (true)
										{
											switch (num10)
											{
											default:
												enumerator.Dispose();
												num10 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
												{
													num10 = 0;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								break;
							case 2:
								break;
							}
							((ILogger)oGZ3VPWfWGtL1AV5ZZjD()).Debug(CRjEMAWfFKBhhSk32Jok(HeKR9RWE3F1PkePe16DB(0x7459E02 ^ 0x7443A6A), (int)veOg29WfGu9YtB7Sd68c(ib6UP1WfhgQ5rsk5DpaD(), dateTime).TotalMilliseconds));
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
							{
								num8 = 0;
							}
						}
					}
					finally
					{
						int num11;
						if (startInformation == null)
						{
							num11 = 2;
							goto IL_05ce;
						}
						goto IL_05e4;
						IL_05ce:
						switch (num11)
						{
						case 2:
							goto end_IL_05b9;
						case 1:
							goto end_IL_05b9;
						}
						goto IL_05e4;
						IL_05e4:
						ubHXZOWE6Vou1NCIHia3(startInformation);
						num11 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num11 = 1;
						}
						goto IL_05ce;
						end_IL_05b9:;
					}
				}
			}
			finally
			{
				if (metadataServiceContext != null)
				{
					int num12 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num12 = 1;
					}
					while (true)
					{
						switch (num12)
						{
						case 1:
							ubHXZOWE6Vou1NCIHia3(metadataServiceContext);
							num12 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num12 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public abstract IProjection GenerateOrderByProjection(EntityMetadata metadata, PropertyMetadata propertyMetadata, string entityName = null, string si = null);

	public virtual IProjection PrepareOrderByProjection(IProjection prj, Guid? propertyMetadataTypeUid)
	{
		return prj;
	}

	public abstract IProjection GenerateComparableStringProjection(IProjection propertyProjection, int maxLength = 255);

	public virtual void CustomMapping(INHibernatePropertyTypeMapper mapper, PropertyMetadata propertyMetadata)
	{
	}

	public abstract ITransformationProvider CreateTransformationProvider();

	protected bool PropertyIsString(IEntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00db, IL_00ea
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (propertyMetadata != null)
				{
					num2 = 3;
					break;
				}
				return false;
			default:
				if (!IJVGXiWfCCI0Eh1Rr2Rg(g4cmc7WfQUHxnoQ3lPB3(propertyMetadata), TextDescriptor.UID))
				{
					num2 = 5;
					break;
				}
				goto case 1;
			case 3:
				if (g4cmc7WfQUHxnoQ3lPB3(propertyMetadata) == StringDescriptor.UID)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 2:
				return IJVGXiWfCCI0Eh1Rr2Rg(g4cmc7WfQUHxnoQ3lPB3(propertyMetadata), HtmlStringDescriptor.UID);
			case 1:
				return true;
			case 5:
				if (!IJVGXiWfCCI0Eh1Rr2Rg(g4cmc7WfQUHxnoQ3lPB3(propertyMetadata), UrlDescriptor.UID))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public virtual SqlString EqualToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery, string lhsPropertyPath, IEntityPropertyMetadata lhsPropertyMetadata, object rhsValue)
	{
		//Discarded unreachable code: IL_0091, IL_02b0, IL_02bf, IL_0307, IL_0333, IL_0342, IL_0381, IL_0390, IL_03c1, IL_03d0, IL_03df
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		int num = 14;
		int num3 = default(int);
		Parameter[] array3 = default(Parameter[]);
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		int num4 = default(int);
		SqlString[] array = default(SqlString[]);
		Parameter val3 = default(Parameter);
		SqlStringBuilder val = default(SqlStringBuilder);
		TypedValue[] array2 = default(TypedValue[]);
		TypedValue val2 = default(TypedValue);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					num3 = 0;
					num2 = 22;
					continue;
				case 4:
					array3 = ((IEnumerable<TypedValue>)kgau1MWfZILAJ3gIVGda(_003C_003Ec__DisplayClass16_.criteriaQuery, criteria, null, lhsPropertyPath, new object[1] { rhsValue })).SelectMany(_003C_003Ec__DisplayClass16_._003CEqualToSqlString_003Eb__1).ToArray();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					num4 = 0;
					num2 = 20;
					continue;
				case 19:
					return ((SqlStringBuilder)bswnHCWfRTVP3WgSj8Yf(oiFbr3WfSVmMM3WJUpow(oiFbr3WfSVmMM3WJUpow(Hu22DpWfiA4EN0Cqtlvg(oiFbr3WfSVmMM3WJUpow(pvsggwWfVnAvnYAwY03t((object)new SqlStringBuilder(), qHGZvPWfI6q38YpcwGGF(((IMapping)rsEkvZWfuIJeqKN76RYB(_003C_003Ec__DisplayClass16_.criteriaQuery)).get_Dialect())), HeKR9RWE3F1PkePe16DB(-1108654032 ^ -1108650106)), array[0]), HeKR9RWE3F1PkePe16DB(0x7459E02 ^ 0x74581BE)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FBA452)), val3)).ToSqlString();
				case 8:
					val = new SqlStringBuilder();
					num = 4;
					break;
				case 2:
				case 18:
					bswnHCWfRTVP3WgSj8Yf(((SqlStringBuilder)Hu22DpWfiA4EN0Cqtlvg(val, array[num3])).Add((string)HeKR9RWE3F1PkePe16DB(-867826612 ^ -867721008)), array3[num3]);
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 3;
					}
					continue;
				default:
					if (!array3.Any())
					{
						num2 = 27;
						continue;
					}
					goto case 6;
				case 1:
				case 22:
					if (num3 < array.Length)
					{
						num2 = 24;
						continue;
					}
					goto case 5;
				case 13:
					_003C_003Ec__DisplayClass16_.criteriaQuery = criteriaQuery;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 9;
					}
					continue;
				case 23:
					if (!PropertyIsString(lhsPropertyMetadata))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 10;
				case 20:
				case 21:
					if (num4 < array2.Length)
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 19;
				case 15:
				case 17:
					val2 = array2[num4];
					num2 = 26;
					continue;
				case 11:
				case 24:
					if (num3 <= 0)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 16;
				case 16:
					val.Add((string)HeKR9RWE3F1PkePe16DB(-1123633026 ^ -1123607336));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					val3 = null;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 23;
					}
					continue;
				case 3:
					num4++;
					num2 = 21;
					continue;
				case 26:
					val3 = _003C_003Ec__DisplayClass16_.criteriaQuery.NewQueryParameter(val2).Last();
					num2 = 3;
					continue;
				case 14:
					_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 13;
					}
					continue;
				case 25:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
				case 27:
					return (SqlString)cKXGfOWfqrlXGFbDqbpy(val);
				case 9:
					array = Array.ConvertAll((string[])e5dQVcWfv7fEOYj52gQn(_003C_003Ec__DisplayClass16_.criteriaQuery, criteria, lhsPropertyPath), (Converter<string, SqlString>)((string col) => new SqlString(col)));
					num = 7;
					break;
				case 10:
					array2 = (TypedValue[])kgau1MWfZILAJ3gIVGda(_003C_003Ec__DisplayClass16_.criteriaQuery, criteria, null, lhsPropertyPath, new object[1] { (rhsValue != null) ? ORVVgXWf8YSdiunapy4U(rhsValue.ToString()) : null });
					num = 12;
					break;
				}
				break;
			}
		}
	}

	public virtual SqlString EqualToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery, SqlString[] lhsColumnNames, IEntityPropertyMetadata lhsPropertyMetadata, SqlString[] rhsColumnNames, IEntityPropertyMetadata rhsPropertyMetadata)
	{
		//Discarded unreachable code: IL_0140, IL_014f, IL_0242, IL_02a7, IL_02e0, IL_02ef, IL_02ff, IL_032b
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		int num = 10;
		SqlStringBuilder val = default(SqlStringBuilder);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					oiFbr3WfSVmMM3WJUpow(val, HeKR9RWE3F1PkePe16DB(0x4A1640F ^ 0x4A17BB3));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					Hu22DpWfiA4EN0Cqtlvg(val, cKXGfOWfqrlXGFbDqbpy(Hu22DpWfiA4EN0Cqtlvg(new SqlStringBuilder().Add(lhsColumnNames[num3]).Add((string)HeKR9RWE3F1PkePe16DB(-867826612 ^ -867721008)), rhsColumnNames[num3])));
					num2 = 16;
					continue;
				case 10:
					if (PropertyIsString(lhsPropertyMetadata))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 4;
				case 2:
					oiFbr3WfSVmMM3WJUpow(val, HeKR9RWE3F1PkePe16DB(0x8317432 ^ 0x8316B84));
					num = 7;
					break;
				case 9:
				case 13:
					return ((SqlStringBuilder)oiFbr3WfSVmMM3WJUpow(((SqlStringBuilder)oiFbr3WfSVmMM3WJUpow(oiFbr3WfSVmMM3WJUpow(oiFbr3WfSVmMM3WJUpow(((SqlStringBuilder)Hu22DpWfiA4EN0Cqtlvg(((SqlStringBuilder)pvsggwWfVnAvnYAwY03t((object)new SqlStringBuilder(), qHGZvPWfI6q38YpcwGGF(HoQE7wWfKC7EgAutgSIQ(criteriaQuery.get_Factory())))).Add((string)HeKR9RWE3F1PkePe16DB(0x53CB464B ^ 0x53CB59FD)), lhsColumnNames[0])).Add((string)HeKR9RWE3F1PkePe16DB(-3333094 ^ -3327066)), HeKR9RWE3F1PkePe16DB(-420743386 ^ -420850758)), qHGZvPWfI6q38YpcwGGF(HoQE7wWfKC7EgAutgSIQ(rsEkvZWfuIJeqKN76RYB(criteriaQuery)))), HeKR9RWE3F1PkePe16DB(-289714582 ^ -289713700))).Add(rhsColumnNames[0]), HeKR9RWE3F1PkePe16DB(0x1A33FE36 ^ 0x1A33E18A))).ToSqlString();
				case 18:
					val.Add((string)HeKR9RWE3F1PkePe16DB(0x4EA5403C ^ 0x4EA4E49A));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
				case 19:
					if (num3 < lhsColumnNames.Length)
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 1:
				case 3:
					return (SqlString)cKXGfOWfqrlXGFbDqbpy(val);
				case 5:
				case 17:
					if (num3 <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 18;
				case 7:
				case 12:
					num3 = 0;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					if (lhsColumnNames.Length <= 1)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 11;
				case 14:
					if (lhsColumnNames.Length <= 1)
					{
						num = 12;
						break;
					}
					goto case 2;
				case 4:
					if (!PropertyIsString(rhsPropertyMetadata))
					{
						val = new SqlStringBuilder();
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 11;
						}
					}
					else
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 12;
						}
					}
					continue;
				case 16:
					num3++;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 19;
					}
					continue;
				}
				break;
			}
		}
	}

	protected virtual Configuration ConfigureDb()
	{
		int num = 5;
		EleWise.ELMA.Runtime.NH.Configuration configuration = default(EleWise.ELMA.Runtime.NH.Configuration);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					((Configuration)configuration).SetProperty((string)HeKR9RWE3F1PkePe16DB(0x53CB464B ^ 0x53CAE2B5), (string)HeKR9RWE3F1PkePe16DB(-1765851862 ^ -1765894120));
					num2 = 10;
					continue;
				case 4:
					configuration = new EleWise.ELMA.Runtime.NH.Configuration();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					oyUCt9WfTUR2xlDPnqAF(this, configuration);
					num2 = 2;
					continue;
				case 10:
					return (Configuration)(object)configuration;
				case 1:
					break;
				case 7:
					eYf7nTWEYCS78w69Ih1c(configuration, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488773883), HeKR9RWE3F1PkePe16DB(0x26FFCB59 ^ 0x26FE6FAD));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					((Configuration)configuration).SetProperty((string)HeKR9RWE3F1PkePe16DB(0x3A5D5EF ^ 0x3A4715B), (string)HeKR9RWE3F1PkePe16DB(0x18A6761F ^ 0x18A66C05));
					num2 = 7;
					continue;
				case 9:
					ConfigurationExtensions.CollectionTypeFactory<ElmaCollectionTypeFactory>((Configuration)(object)configuration);
					num2 = 8;
					continue;
				case 2:
					IpOIgaWfkYsB4he26uZ0(this, configuration);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					uQbaapWfXlJvvwDmoadD(false);
					num2 = 4;
					continue;
				default:
					ConfigurationExtensions.Proxy((Configuration)(object)configuration, (Action<IProxyConfigurationProperties>)delegate(IProxyConfigurationProperties p)
					{
						p.ProxyFactoryFactory<ProxyFactoryFactory>();
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			QI6oJqWfn9kwkMH1f8xK(this, configuration);
			num = 9;
		}
	}

	protected virtual void ConfigListeners(Configuration t)
	{
		int num = 8;
		ExtensionPointsForwardListener extensionPointsForwardListener = default(ExtensionPointsForwardListener);
		HHH2763Fix hHH2763Fix = default(HHH2763Fix);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					AOwnxkWfedFgHtvJbE6w(ixRAjfWfO9LW1a80BY9d(t), new IFlushEventListener[2]
					{
						extensionPointsForwardListener,
						(IFlushEventListener)hHH2763Fix
					});
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					return;
				case 8:
					ji5DbxWf2qTqyo4Oge0U(ixRAjfWfO9LW1a80BY9d(t), new IDeleteEventListener[1] { (IDeleteEventListener)new SoftDeleteEventListener() });
					num2 = 7;
					continue;
				case 10:
					GCvNHfWf3KrVmGx4GiFQ(ixRAjfWfO9LW1a80BY9d(t), ((IEnumerable<IPostUpdateEventListener>)(object)new IPostUpdateEventListener[1] { extensionPointsForwardListener }).Concat((IEnumerable<IPostUpdateEventListener>)KYX1GOWfNfOBjF4TnF2s(t.get_EventListeners())).ToArray());
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 11;
					}
					continue;
				case 17:
					YZSJF0WfaadbQ9qNtQEE(ixRAjfWfO9LW1a80BY9d(t), ((IEnumerable<IPreInsertEventListener>)(object)new IPreInsertEventListener[1] { extensionPointsForwardListener }).Concat(((EventListeners)ixRAjfWfO9LW1a80BY9d(t)).get_PreInsertEventListeners()).ToArray());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					t.get_EventListeners().set_PostCollectionRemoveEventListeners(((IEnumerable<IPostCollectionRemoveEventListener>)(object)new IPostCollectionRemoveEventListener[1] { extensionPointsForwardListener }).Concat(((EventListeners)ixRAjfWfO9LW1a80BY9d(t)).get_PostCollectionRemoveEventListeners()).ToArray());
					num = 3;
					break;
				case 13:
					haKB9eWf0ATNg7LYJIg7(ixRAjfWfO9LW1a80BY9d(t), ((IEnumerable<IPreCollectionRecreateEventListener>)(object)new IPreCollectionRecreateEventListener[1] { extensionPointsForwardListener }).Concat((IEnumerable<IPreCollectionRecreateEventListener>)HkoRH2Wfx6oiIaH58jK1(t.get_EventListeners())).ToArray());
					num = 4;
					break;
				case 6:
					aljOk7WfHs0kwF8ljiEw(ixRAjfWfO9LW1a80BY9d(t), ((IEnumerable<IPostCollectionRecreateEventListener>)(object)new IPostCollectionRecreateEventListener[1] { extensionPointsForwardListener }).Concat(((EventListeners)ixRAjfWfO9LW1a80BY9d(t)).get_PostCollectionRecreateEventListeners()).ToArray());
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					KVeVT8Wf121T6neRmSbU(ixRAjfWfO9LW1a80BY9d(t), ((IEnumerable<IPostInsertEventListener>)(object)new IPostInsertEventListener[1] { extensionPointsForwardListener }).Concat((IEnumerable<IPostInsertEventListener>)Xa1tU4WfPX1vwldnPQxg(ixRAjfWfO9LW1a80BY9d(t))).ToArray());
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 10;
					}
					continue;
				case 16:
					hHH2763Fix = new HHH2763Fix();
					num2 = 9;
					continue;
				case 15:
					((EventListeners)ixRAjfWfO9LW1a80BY9d(t)).set_PreCollectionUpdateEventListeners(((IEnumerable<IPreCollectionUpdateEventListener>)(object)new IPreCollectionUpdateEventListener[1] { extensionPointsForwardListener }).Concat((IEnumerable<IPreCollectionUpdateEventListener>)zgfTcoWfyA01HjjXJtCG(ixRAjfWfO9LW1a80BY9d(t))).ToArray());
					num2 = 12;
					continue;
				case 4:
					Mj9CjZWfmQGMBw7yHSVK(ixRAjfWfO9LW1a80BY9d(t), ((IEnumerable<IPreCollectionRemoveEventListener>)(object)new IPreCollectionRemoveEventListener[1] { extensionPointsForwardListener }).Concat(t.get_EventListeners().get_PreCollectionRemoveEventListeners()).ToArray());
					num2 = 15;
					continue;
				case 11:
					((EventListeners)ixRAjfWfO9LW1a80BY9d(t)).set_PreUpdateEventListeners(((IEnumerable<IPreUpdateEventListener>)(object)new IPreUpdateEventListener[1] { extensionPointsForwardListener }).Concat((IEnumerable<IPreUpdateEventListener>)cP2tdCWfpNLgqDVKMZfW(ixRAjfWfO9LW1a80BY9d(t))).ToArray());
					num2 = 17;
					continue;
				case 7:
					extensionPointsForwardListener = new ExtensionPointsForwardListener();
					num2 = 16;
					continue;
				case 1:
					jOZopSWf6p4kXe6QSusQ(ixRAjfWfO9LW1a80BY9d(t), ((IEnumerable<IPreLoadEventListener>)(object)new IPreLoadEventListener[1] { extensionPointsForwardListener }).Concat((IEnumerable<IPreLoadEventListener>)epd31sWf4JIWbUEfCA1p(t.get_EventListeners())).ToArray());
					num2 = 6;
					continue;
				case 5:
					H0WsnHWfwNrwTGnnSIFR(ixRAjfWfO9LW1a80BY9d(t), ((IEnumerable<IPostDeleteEventListener>)(object)new IPostDeleteEventListener[1] { extensionPointsForwardListener }).Concat((IEnumerable<IPostDeleteEventListener>)plL4aQWfthyUNtxljpAe(ixRAjfWfO9LW1a80BY9d(t))).ToArray());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					((EventListeners)ixRAjfWfO9LW1a80BY9d(t)).set_PreDeleteEventListeners(((IEnumerable<IPreDeleteEventListener>)(object)new IPreDeleteEventListener[1] { extensionPointsForwardListener }).Concat((IEnumerable<IPreDeleteEventListener>)rBRrrLWfDgPlKjWLmEMj(ixRAjfWfO9LW1a80BY9d(t))).ToArray());
					num = 5;
					break;
				case 3:
					Glt6qTWf7I1EVbT6agLJ(ixRAjfWfO9LW1a80BY9d(t), ((IEnumerable<IPostCollectionUpdateEventListener>)(object)new IPostCollectionUpdateEventListener[1] { extensionPointsForwardListener }).Concat((IEnumerable<IPostCollectionUpdateEventListener>)l4ZUtdWfAxWVQ1EWKs87(ixRAjfWfO9LW1a80BY9d(t))).ToArray());
					num2 = 13;
					continue;
				}
				break;
			}
		}
	}

	protected virtual void ConfigureCacheProvider(Configuration cfg)
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
				ConfigurationExtensions.Cache(cfg, (Action<ICacheConfigurationProperties>)delegate(ICacheConfigurationProperties c)
				{
					int num3 = 4;
					int num4 = num3;
					bool setting = default(bool);
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							if (!setting)
							{
								return;
							}
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
							{
								num4 = 0;
							}
							break;
						case 4:
							c.Provider<NHCacheProviderWrapper>();
							num4 = 3;
							break;
						case 3:
							c.set_UseQueryCache(setting = SR.GetSetting((string)_003C_003Ec.UTobv6QNwCs842qehuCO(0x4D1C1EE4 ^ 0x4D1965DA), defaultValue: false));
							num4 = 2;
							break;
						case 1:
							CacheConfigurationPropertiesExtensions.QueryCacheFactory<NHQueryCacheFactoryWrapper>(c);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected void CheckDatabaseServerVersion()
	{
		//Discarded unreachable code: IL_0051, IL_0060
		int num = 4;
		int num2 = num;
		Version version = default(Version);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (FmDlifWfdX7nrerqLLxt(version, c8ZMxaWf9rHmaYXnrCVP(this)))
				{
					num2 = 2;
					break;
				}
				return;
			case 0:
				return;
			case 3:
				if (!cxXYbtWfJMPuush3bYtr(version, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 2:
				throw new ConfigurationInitializeException(SR.T((string)HeKR9RWE3F1PkePe16DB(-87337865 ^ -87363251), ebDyAaWfljOX9CHiTf0c(this), XdeeCJWfr9tvOZp7MCC0(this, version), GetDatabaseServerName((Version)c8ZMxaWf9rHmaYXnrCVP(this))));
			case 4:
				version = (Version)I14Fu7WfM5OEFDr6mcA9(this);
				num2 = 3;
				break;
			}
		}
	}

	protected abstract void InitInternal();

	protected abstract void Configure(Configuration cfg);

	protected abstract string GetDatabaseServerName(Version version);

	protected abstract Version GetDatabaseServerVersion();

	private IEnumerable<IDbStructureExtension> SortDbStructures(IEnumerable<IDbStructureExtension> structures)
	{
		IDbStructureExtension[] array = structures.ToArray();
		List<IDbStructureExtension> result = new List<IDbStructureExtension>();
		IDbStructureExtension[] array2 = array;
		foreach (IDbStructureExtension structure in array2)
		{
			List<IDbStructureExtension> stack = new List<IDbStructureExtension>();
			SortDbStructureItem(structure, array, result, stack);
		}
		return result;
	}

	private void SortDbStructureItem(IDbStructureExtension structure, IEnumerable<IDbStructureExtension> structures, List<IDbStructureExtension> result, List<IDbStructureExtension> stack)
	{
		_003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass34_0();
		CS_0024_003C_003E8__locals0.structure = structure;
		if (CS_0024_003C_003E8__locals0.structure == null || result.Contains(CS_0024_003C_003E8__locals0.structure) || stack.Contains(CS_0024_003C_003E8__locals0.structure))
		{
			return;
		}
		stack.Add(CS_0024_003C_003E8__locals0.structure);
		IDbStructureExtension dbStructureExtension = ((CS_0024_003C_003E8__locals0.structure.Parent != null) ? structures.FirstOrDefault((IDbStructureExtension s) => _003C_003Ec__DisplayClass34_0.LaGTrBQNM8KIjQxI3Jnu(s.GetType(), _003C_003Ec__DisplayClass34_0.S4nM1mQNyG0VPJ37113L(CS_0024_003C_003E8__locals0.structure))) : null);
		if (dbStructureExtension != null)
		{
			SortDbStructureItem(dbStructureExtension, structures, result, new List<IDbStructureExtension>(stack));
		}
		if (CS_0024_003C_003E8__locals0.structure.References != null)
		{
			Type[] references = CS_0024_003C_003E8__locals0.structure.References;
			for (int i = 0; i < references.Length; i++)
			{
				_003C_003Ec__DisplayClass34_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass34_1();
				CS_0024_003C_003E8__locals1.refStructType = references[i];
				IDbStructureExtension dbStructureExtension2 = structures.FirstOrDefault((IDbStructureExtension s) => _003C_003Ec__DisplayClass34_1.pAmoJSQNr2PdYsjN8S3S(s.GetType(), CS_0024_003C_003E8__locals1.refStructType));
				if (dbStructureExtension2 != null)
				{
					SortDbStructureItem(dbStructureExtension2, structures, result, new List<IDbStructureExtension>(stack));
				}
			}
		}
		result.Add(CS_0024_003C_003E8__locals0.structure);
		foreach (IDbStructureExtension item in structures.Where((IDbStructureExtension s) => _003C_003Ec__DisplayClass34_0.LaGTrBQNM8KIjQxI3Jnu(_003C_003Ec__DisplayClass34_0.S4nM1mQNyG0VPJ37113L(s), CS_0024_003C_003E8__locals0.structure.GetType())))
		{
			SortDbStructureItem(item, structures, result, new List<IDbStructureExtension>(stack));
		}
	}

	protected NHProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		s0txMIWfg1uY1yZ3XkYY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool tO1GLYWE1Gw0FZqWtVjZ()
	{
		return h1sdPJWEPb0S33mFM7dv == null;
	}

	internal static NHProvider vFGIO9WEN9fu7XDfa3AB()
	{
		return h1sdPJWEPb0S33mFM7dv;
	}

	internal static object HeKR9RWE3F1PkePe16DB(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object t2saf6WEpS98FQCvbhef(double completePercent, object P_1)
	{
		return StartInformation.Operation(completePercent, (string)P_1);
	}

	internal static object eCJp2qWEaNQrMnTxUngj()
	{
		return ComponentManager.Builder;
	}

	internal static Type t3CDWlWEDqpKO4UHE6rd(object P_0)
	{
		return ((NHProvider)P_0).TransformationProviderType;
	}

	internal static object uWDe7UWEtqeS2Xx4CPeC()
	{
		return ComponentManager.Current;
	}

	internal static void rCCZEdWEw0C9hYyRBlGF(object P_0)
	{
		((INHProviderDependentUserTypeRegistrar)P_0).Register();
	}

	internal static bool RNjLyPWE42Y6SZYis3QZ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void ubHXZOWE6Vou1NCIHia3(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void mSt1FTWEH4S9dZ4igr97(object P_0, object P_1)
	{
		((NHManagerRegisterParams)P_0).Builder = (ContainerBuilder)P_1;
	}

	internal static object lLlQkrWEAMdbnK3PVc8l(object P_0)
	{
		return ((IRuntimeApplication)P_0).TransformationProvider;
	}

	internal static object ifvQwOWE7kfYKACEOlr4(object P_0)
	{
		return ((NHProvider)P_0).MapIdentityProvider;
	}

	internal static void tGfbSXWExMlfxQMrsju9(object P_0)
	{
		EleWise.ELMA.Runtime.Db.MapIdentityProvider.CurrentThreadProvider = (IMapIdentityProvider)P_0;
	}

	internal static object th4tViWE0kDOJwC5x96v(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static void tg2v2kWEmu2d44oMPfdY()
	{
		ElmaInExpression.Init();
	}

	internal static object VGWMDbWEyswbndfAuIct(object P_0)
	{
		return ((IRuntimeApplication)P_0).DbPreUpdater;
	}

	internal static object Jy62nhWEM7qe9YY1KXPB(object P_0)
	{
		return ((NHManagerRegisterParams)P_0).CreateModelMapper();
	}

	internal static object qkDsKjWEJlchZ8XDkljE(object P_0)
	{
		return ((ModelMapper)P_0).CompileMappingForAllExplicitlyAddedEntities();
	}

	internal static object a2KfrOWE91Imh7KtBiAc(object P_0)
	{
		return ((NHProvider)P_0).ConfigureDb();
	}

	internal static void qkBNKJWEdfeRMClZBoCB(object P_0, object P_1)
	{
		((Configuration)P_0).AddMapping((HbmMapping)P_1);
	}

	internal static object XSgZiJWElg9VF5y9MOYU(object P_0)
	{
		return ((DbStructure.DbProcedure)P_0).Mappings;
	}

	internal static bool udr4LiWErhmyAf8Nuv3G(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object FnvR49WEgeMKyGVgUW9r(object P_0, object P_1)
	{
		return ((Configuration)P_0).AddXml((string)P_1);
	}

	internal static object kihwtxWE5fTvHCWRUL3J(object P_0)
	{
		return ((DbStructure.DbView)P_0).Mappings;
	}

	internal static void kSlA2dWEjYR3rSeWWwdq(object P_0)
	{
		SchemaMetadataUpdater.QuoteTableAndColumns((Configuration)P_0);
	}

	internal static object eYf7nTWEYCS78w69Ih1c(object P_0, object P_1, object P_2)
	{
		return ((Configuration)P_0).SetProperty((string)P_1, (string)P_2);
	}

	internal static void CrLeqZWELU3FExsmGiMI(object P_0)
	{
		((SessionFactoryHolder)P_0).CreateSessionFactory();
	}

	internal static void OZMgW0WEULCnZpPm5FET(object P_0, bool value)
	{
		((NHProvider)P_0).Enabled = value;
	}

	internal static bool g5cNbuWEsiIKliCLOZQb(object P_0)
	{
		return ((IRuntimeApplication)P_0).IsFirstServerInCluster;
	}

	internal static void jE8Ll1WEcBbG99x0rNbF(object P_0)
	{
		((ITransformationProvider)P_0).BeginTransaction();
	}

	internal static object A7OT4sWEzOKrJxMa36Oe(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object CRjEMAWfFKBhhSk32Jok(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void Nfjov4WfBOxTdWIWaW68(object P_0)
	{
		((ITransformationProviderBase)P_0).CommitTransaction();
	}

	internal static object oGZ3VPWfWGtL1AV5ZZjD()
	{
		return Logger.Log;
	}

	internal static void hMg2JTWfoSD7PohMRvrq(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void baf2a8Wfbg7jwHCvKp2o(object P_0)
	{
		((ITransformationProvider)P_0).RollbackTransaction();
	}

	internal static DateTime ib6UP1WfhgQ5rsk5DpaD()
	{
		return DateTime.Now;
	}

	internal static TimeSpan veOg29WfGu9YtB7Sd68c(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static void AaZulgWfEEiepy2saa0J(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static void odj44xWffsCKBSEZ90nT(object P_0)
	{
		((INHManager)P_0).Init();
	}

	internal static Guid g4cmc7WfQUHxnoQ3lPB3(object P_0)
	{
		return ((IPropertyMetadata)P_0).TypeUid;
	}

	internal static bool IJVGXiWfCCI0Eh1Rr2Rg(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object e5dQVcWfv7fEOYj52gQn(object P_0, object P_1, object P_2)
	{
		return ((ICriteriaQuery)P_0).GetColumnsUsingProjection((ICriteria)P_1, (string)P_2);
	}

	internal static object ORVVgXWf8YSdiunapy4U(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object kgau1MWfZILAJ3gIVGda(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return CriterionUtil.GetTypedValues((ICriteriaQuery)P_0, (ICriteria)P_1, (IProjection)P_2, (string)P_3, (object[])P_4);
	}

	internal static object rsEkvZWfuIJeqKN76RYB(object P_0)
	{
		return ((ICriteriaQuery)P_0).get_Factory();
	}

	internal static object qHGZvPWfI6q38YpcwGGF(object P_0)
	{
		return ((Dialect)P_0).get_LowercaseFunction();
	}

	internal static object pvsggwWfVnAvnYAwY03t(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((string)P_1);
	}

	internal static object oiFbr3WfSVmMM3WJUpow(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((string)P_1);
	}

	internal static object Hu22DpWfiA4EN0Cqtlvg(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((SqlString)P_1);
	}

	internal static object bswnHCWfRTVP3WgSj8Yf(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((Parameter)P_1);
	}

	internal static object cKXGfOWfqrlXGFbDqbpy(object P_0)
	{
		return ((SqlStringBuilder)P_0).ToSqlString();
	}

	internal static object HoQE7wWfKC7EgAutgSIQ(object P_0)
	{
		return ((IMapping)P_0).get_Dialect();
	}

	internal static void uQbaapWfXlJvvwDmoadD(bool P_0)
	{
		Environment.set_UseReflectionOptimizer(P_0);
	}

	internal static void oyUCt9WfTUR2xlDPnqAF(object P_0, object P_1)
	{
		((NHProvider)P_0).Configure((Configuration)P_1);
	}

	internal static void IpOIgaWfkYsB4he26uZ0(object P_0, object P_1)
	{
		((NHProvider)P_0).ConfigureCacheProvider((Configuration)P_1);
	}

	internal static void QI6oJqWfn9kwkMH1f8xK(object P_0, object P_1)
	{
		((NHProvider)P_0).ConfigListeners((Configuration)P_1);
	}

	internal static object ixRAjfWfO9LW1a80BY9d(object P_0)
	{
		return ((Configuration)P_0).get_EventListeners();
	}

	internal static void ji5DbxWf2qTqyo4Oge0U(object P_0, object P_1)
	{
		((EventListeners)P_0).set_DeleteEventListeners((IDeleteEventListener[])P_1);
	}

	internal static void AOwnxkWfedFgHtvJbE6w(object P_0, object P_1)
	{
		((EventListeners)P_0).set_FlushEventListeners((IFlushEventListener[])P_1);
	}

	internal static object Xa1tU4WfPX1vwldnPQxg(object P_0)
	{
		return ((EventListeners)P_0).get_PostInsertEventListeners();
	}

	internal static void KVeVT8Wf121T6neRmSbU(object P_0, object P_1)
	{
		((EventListeners)P_0).set_PostInsertEventListeners((IPostInsertEventListener[])P_1);
	}

	internal static object KYX1GOWfNfOBjF4TnF2s(object P_0)
	{
		return ((EventListeners)P_0).get_PostUpdateEventListeners();
	}

	internal static void GCvNHfWf3KrVmGx4GiFQ(object P_0, object P_1)
	{
		((EventListeners)P_0).set_PostUpdateEventListeners((IPostUpdateEventListener[])P_1);
	}

	internal static object cP2tdCWfpNLgqDVKMZfW(object P_0)
	{
		return ((EventListeners)P_0).get_PreUpdateEventListeners();
	}

	internal static void YZSJF0WfaadbQ9qNtQEE(object P_0, object P_1)
	{
		((EventListeners)P_0).set_PreInsertEventListeners((IPreInsertEventListener[])P_1);
	}

	internal static object rBRrrLWfDgPlKjWLmEMj(object P_0)
	{
		return ((EventListeners)P_0).get_PreDeleteEventListeners();
	}

	internal static object plL4aQWfthyUNtxljpAe(object P_0)
	{
		return ((EventListeners)P_0).get_PostDeleteEventListeners();
	}

	internal static void H0WsnHWfwNrwTGnnSIFR(object P_0, object P_1)
	{
		((EventListeners)P_0).set_PostDeleteEventListeners((IPostDeleteEventListener[])P_1);
	}

	internal static object epd31sWf4JIWbUEfCA1p(object P_0)
	{
		return ((EventListeners)P_0).get_PreLoadEventListeners();
	}

	internal static void jOZopSWf6p4kXe6QSusQ(object P_0, object P_1)
	{
		((EventListeners)P_0).set_PreLoadEventListeners((IPreLoadEventListener[])P_1);
	}

	internal static void aljOk7WfHs0kwF8ljiEw(object P_0, object P_1)
	{
		((EventListeners)P_0).set_PostCollectionRecreateEventListeners((IPostCollectionRecreateEventListener[])P_1);
	}

	internal static object l4ZUtdWfAxWVQ1EWKs87(object P_0)
	{
		return ((EventListeners)P_0).get_PostCollectionUpdateEventListeners();
	}

	internal static void Glt6qTWf7I1EVbT6agLJ(object P_0, object P_1)
	{
		((EventListeners)P_0).set_PostCollectionUpdateEventListeners((IPostCollectionUpdateEventListener[])P_1);
	}

	internal static object HkoRH2Wfx6oiIaH58jK1(object P_0)
	{
		return ((EventListeners)P_0).get_PreCollectionRecreateEventListeners();
	}

	internal static void haKB9eWf0ATNg7LYJIg7(object P_0, object P_1)
	{
		((EventListeners)P_0).set_PreCollectionRecreateEventListeners((IPreCollectionRecreateEventListener[])P_1);
	}

	internal static void Mj9CjZWfmQGMBw7yHSVK(object P_0, object P_1)
	{
		((EventListeners)P_0).set_PreCollectionRemoveEventListeners((IPreCollectionRemoveEventListener[])P_1);
	}

	internal static object zgfTcoWfyA01HjjXJtCG(object P_0)
	{
		return ((EventListeners)P_0).get_PreCollectionUpdateEventListeners();
	}

	internal static object I14Fu7WfM5OEFDr6mcA9(object P_0)
	{
		return ((NHProvider)P_0).GetDatabaseServerVersion();
	}

	internal static bool cxXYbtWfJMPuush3bYtr(object P_0, object P_1)
	{
		return (Version)P_0 != (Version)P_1;
	}

	internal static object c8ZMxaWf9rHmaYXnrCVP(object P_0)
	{
		return ((NHProvider)P_0).MinServerVersion;
	}

	internal static bool FmDlifWfdX7nrerqLLxt(object P_0, object P_1)
	{
		return (Version)P_0 < (Version)P_1;
	}

	internal static object ebDyAaWfljOX9CHiTf0c(object P_0)
	{
		return ((AbstractProvider)P_0).Name;
	}

	internal static object XdeeCJWfr9tvOZp7MCC0(object P_0, object P_1)
	{
		return ((NHProvider)P_0).GetDatabaseServerName((Version)P_1);
	}

	internal static void s0txMIWfg1uY1yZ3XkYY()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Guid pjWS22Wf5EUq1e6PDuQi(object P_0)
	{
		return ((INHProviderDependentUserTypeRegistrar)P_0).ProviderUid;
	}

	internal static Guid twb10qWfj6Qd8pYRnvNf(object P_0)
	{
		return ((AbstractProvider)P_0).Uid;
	}

	internal static Guid m0aRYsWfYrYqHXfylIwd(object P_0)
	{
		return ((IDbStructureExtension)P_0).ProviderUid;
	}

	internal static Guid LvRNe1WfLwEAKyMAm7fh(object P_0)
	{
		return ((IDbUpdateHandler)P_0).ProviderUid;
	}
}

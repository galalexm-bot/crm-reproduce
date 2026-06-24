using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.Listeners;

[Component]
internal class PostFlushEventForwarder : EntityEventsListener, IUnitOfWorkEventListener
{
	private class Holder
	{
		public readonly List<PostInsertEvent> insertEvents;

		public readonly List<PostUpdateEvent> updateEvents;

		public readonly List<PostDeleteEvent> deleteEvents;

		public readonly List<PostCollectionUpdateEvent> updateCollectionsEvents;

		internal static object Dgl5YkQjHwomlGvY95S2;

		public bool IsEmpty()
		{
			//Discarded unreachable code: IL_0079, IL_0088
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (GmexQbQj0P7TAcZw9SjT(updateEvents) == 0)
					{
						num2 = 4;
						break;
					}
					goto case 3;
				case 1:
					if (pe9sKtQjx8WBgSA8gsSy(insertEvents) == 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 2:
					return ClKkg1QjmFv3jrcZqp7J(updateCollectionsEvents) == 0;
				case 3:
					return false;
				case 4:
					if (deleteEvents.Count != 0)
					{
						num2 = 3;
						break;
					}
					goto case 2;
				}
			}
		}

		public Holder()
		{
			//Discarded unreachable code: IL_006a, IL_006f
			SingletonReader.JJCZtPuTvSt();
			insertEvents = new List<PostInsertEvent>();
			updateEvents = new List<PostUpdateEvent>();
			deleteEvents = new List<PostDeleteEvent>();
			updateCollectionsEvents = new List<PostCollectionUpdateEvent>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static int pe9sKtQjx8WBgSA8gsSy(object P_0)
		{
			return ((List<PostInsertEvent>)P_0).Count;
		}

		internal static int GmexQbQj0P7TAcZw9SjT(object P_0)
		{
			return ((List<PostUpdateEvent>)P_0).Count;
		}

		internal static int ClKkg1QjmFv3jrcZqp7J(object P_0)
		{
			return ((List<PostCollectionUpdateEvent>)P_0).Count;
		}

		internal static bool H21SP5QjAlhiovFgZ6Lq()
		{
			return Dgl5YkQjHwomlGvY95S2 == null;
		}

		internal static Holder wR0Bd9Qj70ADyDiOhMS9()
		{
			return (Holder)Dgl5YkQjHwomlGvY95S2;
		}
	}

	private readonly IContextBoundVariableService contextBoundVariableService;

	private readonly IEnumerable<IPostFlushEventListener> listeners;

	private readonly ITransformationProvider transform;

	private static PostFlushEventForwarder oP1XF5WAUfnaPtCWXYq7;

	public PostFlushEventForwarder(IContextBoundVariableService contextBoundVariableService, IEnumerable<IPostFlushEventListener> listeners, ITransformationProvider transform)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.contextBoundVariableService = contextBoundVariableService;
		this.listeners = listeners;
		this.transform = transform;
	}

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
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
				uupHhmW7FrU6jfjhCWog(contextBoundVariableService, Ukf4DuWAz0G0GP7bpecS(-1978478350 ^ -1978599862), new Holder());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
		//Discarded unreachable code: IL_0117, IL_0126, IL_0181, IL_01a9, IL_01b8, IL_01c3, IL_021b, IL_0267, IL_0271, IL_0327, IL_033a, IL_0349, IL_035a, IL_0369, IL_0374, IL_041a, IL_042d, IL_043c, IL_044d, IL_045c, IL_0467, IL_050d, IL_0520, IL_052f, IL_057b, IL_058a, IL_0595, IL_063b, IL_064e, IL_065d, IL_0688, IL_06a8, IL_071b, IL_076e, IL_07a6, IL_07b5, IL_07c6
		int num = 1;
		Holder holder = default(Holder);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		HashSet<string> hashSet = default(HashSet<string>);
		IEnumerator<IPostFlushEventListener> enumerator = default(IEnumerator<IPostFlushEventListener>);
		ISession val = default(ISession);
		string text = default(string);
		int num3 = default(int);
		int num17 = default(int);
		IPostFlushEventListener current = default(IPostFlushEventListener);
		List<PostInsertEvent> list2 = default(List<PostInsertEvent>);
		List<PostDeleteEvent>.Enumerator enumerator4 = default(List<PostDeleteEvent>.Enumerator);
		PostInsertEvent current5 = default(PostInsertEvent);
		List<PostCollectionUpdateEvent>.Enumerator enumerator5 = default(List<PostCollectionUpdateEvent>.Enumerator);
		PostCollectionUpdateEvent current4 = default(PostCollectionUpdateEvent);
		PostDeleteEvent current3 = default(PostDeleteEvent);
		List<PostUpdateEvent>.Enumerator enumerator3 = default(List<PostUpdateEvent>.Enumerator);
		List<PostUpdateEvent> list = default(List<PostUpdateEvent>);
		PostUpdateEvent current2 = default(PostUpdateEvent);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					holder = GetHolder();
					num2 = 15;
					continue;
				case 23:
					_003C_003Ec__DisplayClass8_.deleted.UnionWith(hashSet);
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 17;
					}
					continue;
				case 4:
					enumerator = listeners.GetEnumerator();
					num2 = 5;
					continue;
				case 8:
					TFZqTcW7EWLf28eXvaa7(val);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 24;
					}
					continue;
				case 15:
					val = (ISession)G2F27YW7BXpRyip0hiKb(base.SessionProvider, "");
					num2 = 7;
					continue;
				case 9:
					throw new InvalidOperationException((string)JBvoviW7QR67MFCq9nLI(FW8vk6W7fD4T6EaTw3it(Ukf4DuWAz0G0GP7bpecS(-1767720453 ^ -1767858489)), text));
				case 20:
					holder = GetHolder();
					num2 = 6;
					continue;
				case 6:
				case 19:
					if (HR4NDKW7CfM9LyUyT6Ps(holder))
					{
						num2 = 18;
						continue;
					}
					goto case 11;
				case 17:
				case 24:
					if (++num3 <= num17)
					{
						num2 = 20;
						continue;
					}
					goto case 21;
				case 5:
					try
					{
						while (true)
						{
							int num4;
							if (!wSpIIxW7GpTVmFKyClyr(enumerator))
							{
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
								{
									num4 = 1;
								}
								goto IL_01c7;
							}
							goto IL_0725;
							IL_0725:
							current = enumerator.Current;
							num4 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num4 = 2;
							}
							goto IL_01c7;
							IL_01c7:
							switch (num4)
							{
							case 2:
								break;
							case 3:
								try
								{
									List<PostInsertEvent>.Enumerator enumerator2 = list2.GetEnumerator();
									int num5 = 5;
									while (true)
									{
										switch (num5)
										{
										case 1:
											enumerator4 = holder.deleteEvents.GetEnumerator();
											num5 = 4;
											continue;
										case 5:
											try
											{
												while (true)
												{
													IL_02d5:
													int num12;
													if (!enumerator2.MoveNext())
													{
														num12 = 3;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
														{
															num12 = 3;
														}
														goto IL_0275;
													}
													goto IL_028f;
													IL_028f:
													current5 = enumerator2.Current;
													num12 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
													{
														num12 = 1;
													}
													goto IL_0275;
													IL_0275:
													while (true)
													{
														switch (num12)
														{
														case 2:
															break;
														case 1:
															current.OnPostInsert(current5);
															num12 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
															{
																num12 = 0;
															}
															continue;
														default:
															goto IL_02d5;
														case 3:
															goto end_IL_02d5;
														}
														break;
													}
													goto IL_028f;
													continue;
													end_IL_02d5:
													break;
												}
											}
											finally
											{
												((IDisposable)enumerator2).Dispose();
												int num13 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
												{
													num13 = 0;
												}
												switch (num13)
												{
												case 0:
													break;
												}
											}
											goto default;
										case 2:
											try
											{
												while (true)
												{
													IL_03a5:
													int num10;
													if (!enumerator5.MoveNext())
													{
														num10 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
														{
															num10 = 0;
														}
														goto IL_0378;
													}
													goto IL_03cb;
													IL_03cb:
													current4 = enumerator5.Current;
													num10 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
													{
														num10 = 2;
													}
													goto IL_0378;
													IL_0378:
													while (true)
													{
														switch (num10)
														{
														case 2:
															uhUssiW7oA5Bglnd6v7e(current, current4);
															num10 = 3;
															continue;
														case 3:
															goto IL_03a5;
														case 1:
															goto IL_03cb;
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
												((IDisposable)enumerator5).Dispose();
												int num11 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
												{
													num11 = 0;
												}
												switch (num11)
												{
												case 0:
													break;
												}
											}
											goto end_IL_021f;
										case 4:
											try
											{
												while (true)
												{
													IL_0485:
													int num8;
													if (!enumerator4.MoveNext())
													{
														num8 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
														{
															num8 = 0;
														}
														goto IL_046b;
													}
													goto IL_04ce;
													IL_04ce:
													current3 = enumerator4.Current;
													num8 = 3;
													goto IL_046b;
													IL_046b:
													while (true)
													{
														switch (num8)
														{
														case 1:
															goto IL_0485;
														case 3:
															current.OnPostDelete(current3);
															num8 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
															{
																num8 = 1;
															}
															continue;
														case 2:
															goto IL_04ce;
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
												int num9 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
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
										default:
											enumerator3 = list.GetEnumerator();
											num5 = 6;
											continue;
										case 7:
											break;
										case 6:
											try
											{
												while (true)
												{
													int num6;
													if (!enumerator3.MoveNext())
													{
														num6 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
														{
															num6 = 2;
														}
														goto IL_0599;
													}
													goto IL_05fc;
													IL_05fc:
													current2 = enumerator3.Current;
													num6 = 3;
													goto IL_0599;
													IL_0599:
													while (true)
													{
														switch (num6)
														{
														case 3:
															vAYjacW7WGWaaCCaXP5P(current, current2);
															num6 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
															{
																num6 = 1;
															}
															continue;
														case 1:
															break;
														default:
															goto IL_05fc;
														case 2:
															goto end_IL_05d6;
														}
														break;
													}
													continue;
													end_IL_05d6:
													break;
												}
											}
											finally
											{
												((IDisposable)enumerator3).Dispose();
												int num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
												{
													num7 = 0;
												}
												switch (num7)
												{
												case 0:
													break;
												}
											}
											goto case 1;
										case 3:
											goto end_IL_021f;
										}
										enumerator5 = holder.updateCollectionsEvents.GetEnumerator();
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
										{
											num5 = 2;
										}
										continue;
										end_IL_021f:
										break;
									}
								}
								catch (TransactionRollbackException)
								{
									int num14 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
									{
										num14 = 0;
									}
									switch (num14)
									{
									default:
										throw;
									}
								}
								catch (Exception ex2)
								{
									int num15 = 2;
									while (true)
									{
										switch (num15)
										{
										case 1:
											if (gryv09W7hxsyOwMqtbWp(transform, ex2))
											{
												num15 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
												{
													num15 = 0;
												}
												break;
											}
											goto end_IL_06ac;
										case 2:
											zGfIYTW7bKuBJIb9Xhks(Logger.Log, ex2);
											num15 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
											{
												num15 = 0;
											}
											break;
										default:
											throw;
										}
										continue;
										end_IL_06ac:
										break;
									}
								}
								break;
							default:
								goto IL_0725;
							case 1:
								goto end_IL_01e1;
							}
							continue;
							end_IL_01e1:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num16 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
							{
								num16 = 0;
							}
							while (true)
							{
								switch (num16)
								{
								default:
									enumerator.Dispose();
									num16 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
									{
										num16 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 2;
				case 18:
					return;
				case 3:
					num3 = 0;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 12;
					}
					continue;
				case 12:
					_003C_003Ec__DisplayClass8_.deleted = new HashSet<string>();
					num = 16;
					break;
				case 13:
					if (hashSet.Any())
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 22;
				case 2:
					if (!val.IsDirty())
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 8;
				case 7:
					num17 = 20;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					contextBoundVariableService.Set((string)Ukf4DuWAz0G0GP7bpecS(-1633514411 ^ -1633637651), new Holder());
					num2 = 10;
					continue;
				case 14:
					_003C_003Ec__DisplayClass8_.isDeleteEntity = _003C_003Ec__DisplayClass8_._003COnPreCommitUnitofWork_003Eb__1;
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 16;
					}
					continue;
				case 16:
					_003C_003Ec__DisplayClass8_.entityKey = delegate(object obj)
					{
						int num20 = 3;
						int num21 = num20;
						Type typeWithoutProxy = default(Type);
						IEntity entity = default(IEntity);
						while (true)
						{
							switch (num21)
							{
							case 4:
								if (_003C_003Ec.nLX56fQYWYxcZ8wY8OBN(typeWithoutProxy, null))
								{
									return (string)_003C_003Ec.EpTKDAQYb0kbfi28ivdL(typeWithoutProxy.FullName, _003C_003Ec.iV1D3EQYo5QVWXcCVfRl(entity).ToString());
								}
								num21 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
								{
									num21 = 1;
								}
								break;
							default:
								return null;
							case 2:
								if (entity != null)
								{
									typeWithoutProxy = entity.GetType().GetTypeWithoutProxy();
									num21 = 4;
								}
								else
								{
									num21 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
									{
										num21 = 0;
									}
								}
								break;
							case 3:
								entity = obj as IEntity;
								num21 = 2;
								break;
							case 1:
								return null;
							}
						}
					};
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 2;
					}
					continue;
				case 10:
					hashSet = holder.deleteEvents.Select(_003C_003Ec__DisplayClass8_._003COnPreCommitUnitofWork_003Eb__2).Where(_003C_003Ec__DisplayClass8_._003COnPreCommitUnitofWork_003Eb__3).Distinct()
						.ToHashSet();
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 3;
					}
					continue;
				case 22:
					list2 = holder.insertEvents.Where(_003C_003Ec__DisplayClass8_._003COnPreCommitUnitofWork_003Eb__4).ToList();
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 24;
					}
					continue;
				case 25:
					list = holder.updateEvents.Where(_003C_003Ec__DisplayClass8_._003COnPreCommitUnitofWork_003Eb__5).ToList();
					num = 4;
					break;
				case 21:
					text = string.Join((string)Ukf4DuWAz0G0GP7bpecS(-1979251663 ^ -1979230527), holder.insertEvents.Select((PostInsertEvent e) => (string)_003C_003Ec.xtRNKZQYEZJ9OcqlwalQ(new object[4]
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFB7506),
						((IEntityPersister)_003C_003Ec.tZGp64QYh4G9LOeHPgdy(e)).get_EntityName(),
						_003C_003Ec.ilo3iUQYGU0uo34RqWYc(0x12441CA4 ^ 0x12454DE6),
						((AbstractPostDatabaseOperationEvent)e).get_Id()
					})).Union(holder.updateEvents.Select(delegate(PostUpdateEvent e)
					{
						int num18 = 3;
						int[] array = default(int[]);
						_003C_003Ec__DisplayClass8_1 _003C_003Ec__DisplayClass8_2 = default(_003C_003Ec__DisplayClass8_1);
						while (true)
						{
							int num19 = num18;
							while (true)
							{
								switch (num19)
								{
								default:
									if (array == null)
									{
										num18 = 4;
										break;
									}
									goto case 1;
								case 1:
									return (string)_003C_003Ec.xtRNKZQYEZJ9OcqlwalQ(new object[7]
									{
										_003C_003Ec.ilo3iUQYGU0uo34RqWYc(-521266112 ^ -521391818),
										((IEntityPersister)_003C_003Ec.tZGp64QYh4G9LOeHPgdy(_003C_003Ec__DisplayClass8_2.e)).get_EntityName(),
										_003C_003Ec.ilo3iUQYGU0uo34RqWYc(-29254301 ^ -29307871),
										((AbstractPostDatabaseOperationEvent)_003C_003Ec__DisplayClass8_2.e).get_Id(),
										_003C_003Ec.ilo3iUQYGU0uo34RqWYc(-420743386 ^ -420578728),
										string.Join((string)_003C_003Ec.ilo3iUQYGU0uo34RqWYc(-867826612 ^ -867825586), array.Select(_003C_003Ec__DisplayClass8_2._003COnPreCommitUnitofWork_003Eb__9).ToArray()),
										z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710602718)
									});
								case 4:
									array = new int[0];
									num19 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
									{
										num19 = 1;
									}
									continue;
								case 2:
									_003C_003Ec__DisplayClass8_2.e = e;
									num18 = 5;
									break;
								case 3:
									_003C_003Ec__DisplayClass8_2 = new _003C_003Ec__DisplayClass8_1();
									num19 = 2;
									continue;
								case 5:
									array = (int[])_003C_003Ec.nhhapnQYC4ns4OQmSV1n(_003C_003Ec.tZGp64QYh4G9LOeHPgdy(_003C_003Ec__DisplayClass8_2.e), _003C_003Ec__DisplayClass8_2.e.get_State(), _003C_003Ec.giGvJrQYffhGrYe9TZ96(_003C_003Ec__DisplayClass8_2.e), ((AbstractPostDatabaseOperationEvent)_003C_003Ec__DisplayClass8_2.e).get_Entity(), _003C_003Ec.dpsv99QYQELdF8w4nox7(_003C_003Ec__DisplayClass8_2.e));
									num19 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
									{
										num19 = 0;
									}
									continue;
								}
								break;
							}
						}
					}).Union(holder.deleteEvents.Select((PostDeleteEvent e) => (string)_003C_003Ec.xtRNKZQYEZJ9OcqlwalQ(new object[4]
					{
						_003C_003Ec.ilo3iUQYGU0uo34RqWYc(-16752921 ^ -16395445),
						_003C_003Ec.fONgLyQYvQofsVQwN0f0(_003C_003Ec.tZGp64QYh4G9LOeHPgdy(e)),
						_003C_003Ec.ilo3iUQYGU0uo34RqWYc(-675505729 ^ -675428099),
						_003C_003Ec.uQV33dQY896LTPhLemwy(e)
					}))).ToArray()));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 9;
					}
					continue;
				}
				break;
			}
		}
	}

	public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
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
				uupHhmW7FrU6jfjhCWog(contextBoundVariableService, Ukf4DuWAz0G0GP7bpecS(0x18A6761F ^ 0x18A450A7), new Holder());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private Holder GetHolder()
	{
		return contextBoundVariableService.GetOrAdd((string)Ukf4DuWAz0G0GP7bpecS(-1822890472 ^ -1822768992), () => new Holder());
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
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
				GetHolder().updateEvents.Add(@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
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
				GetHolder().deleteEvents.Add(@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
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
				GetHolder().insertEvents.Add(@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
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
				GetHolder().updateCollectionsEvents.Add(@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	internal static object Ukf4DuWAz0G0GP7bpecS(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void uupHhmW7FrU6jfjhCWog(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}

	internal static bool XmGeveWAsTATI4ZjBw6m()
	{
		return oP1XF5WAUfnaPtCWXYq7 == null;
	}

	internal static PostFlushEventForwarder UBI4TpWAcdsXYINv9NE4()
	{
		return oP1XF5WAUfnaPtCWXYq7;
	}

	internal static object G2F27YW7BXpRyip0hiKb(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static void vAYjacW7WGWaaCCaXP5P(object P_0, object P_1)
	{
		((IPostFlushEventListener)P_0).OnPostUpdate((PostUpdateEvent)P_1);
	}

	internal static void uhUssiW7oA5Bglnd6v7e(object P_0, object P_1)
	{
		((IPostFlushEventListener)P_0).OnPostUpdateCollection((PostCollectionUpdateEvent)P_1);
	}

	internal static void zGfIYTW7bKuBJIb9Xhks(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static bool gryv09W7hxsyOwMqtbWp(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).IsUnrecoverableException((Exception)P_1);
	}

	internal static bool wSpIIxW7GpTVmFKyClyr(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void TFZqTcW7EWLf28eXvaa7(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static object FW8vk6W7fD4T6EaTw3it(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object JBvoviW7QR67MFCq9nLI(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool HR4NDKW7CfM9LyUyT6Ps(object P_0)
	{
		return ((Holder)P_0).IsEmpty();
	}
}

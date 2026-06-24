using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Events.Audit.Impl;

public abstract class BaseEntityActionUnitOfWorkListener : IUnitOfWorkEventListener
{
	private readonly IContextBoundVariableService contextBoundVariableService;

	private readonly ISessionProvider sessionProvider;

	private readonly ILogger logger;

	internal static BaseEntityActionUnitOfWorkListener nDS3v9GsmNlwIMjHFslX;

	public ITransformationProvider Transform
	{
		[CompilerGenerated]
		get
		{
			return _003CTransform_003Ek__BackingField;
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
					_003CTransform_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected IEnumerable<IEntityActionEventAggregator> Aggregators => contextBoundVariableService.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92B0C41), () => ComponentManager.Current.GetExtensionPoints<IEntityActionEventAggregator>());

	protected ISessionProvider SessionProvider => sessionProvider;

	protected ILogger Logger => logger;

	protected abstract string EventListContextKey { get; }

	public BaseEntityActionUnitOfWorkListener([NotNull] IContextBoundVariableService contextBoundVariableService, [NotNull] ISessionProvider sessionProvider, [NotNull] ILogger logger)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OQ3AGhGsJV4XR0RaYAya();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				if (contextBoundVariableService == null)
				{
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num = 5;
					}
					break;
				}
				if (sessionProvider == null)
				{
					num = 3;
					break;
				}
				if (logger == null)
				{
					num = 4;
					break;
				}
				this.contextBoundVariableService = contextBoundVariableService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				this.logger = logger;
				num = 6;
				break;
			case 5:
				throw new ArgumentNullException((string)gLa6UEGs90bmTcrADK0D(0x61EC0CB8 ^ 0x61E811F8));
			case 3:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE7C39B));
			default:
				this.sessionProvider = sessionProvider;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num = 2;
				}
				break;
			case 4:
				throw new ArgumentNullException((string)gLa6UEGs90bmTcrADK0D(-583745292 ^ -583600770));
			case 6:
				return;
			}
		}
	}

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
		//Discarded unreachable code: IL_0051, IL_0090, IL_009f, IL_00c6, IL_0118, IL_0127, IL_0132, IL_01f0, IL_01ff, IL_0230, IL_0268, IL_0277, IL_02eb, IL_0375, IL_0384
		switch (1)
		{
		case 1:
			try
			{
				ISession val = (ISession)y2nkieGsddM7mGryI5RK(SessionProvider, "");
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num = 0;
				}
				IEnumerator<EntityActionEventArgs> enumerator = default(IEnumerator<EntityActionEventArgs>);
				IList<EntityActionEventArgs> list = default(IList<EntityActionEventArgs>);
				EntityActionEventArgs current = default(EntityActionEventArgs);
				Guid value = default(Guid);
				while (true)
				{
					Guid guid;
					switch (num)
					{
					default:
						return;
					case 2:
						return;
					case 9:
						enumerator = list.GetEnumerator();
						num = 6;
						continue;
					case 7:
						guid = iVoklnGslioFQymwJLtu();
						break;
					case 8:
						NqKNEyGsUoSlc9VNrr3r(val);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num = 0;
						}
						continue;
					case 3:
						if (!MNTk1MGsLOA3Lr8PpCYH(val))
						{
							num = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
							{
								num = 2;
							}
							continue;
						}
						goto case 8;
					case 6:
						try
						{
							while (true)
							{
								int num2;
								if (!IAqitPGsjJkYQUZr8loG(enumerator))
								{
									num2 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
									{
										num2 = 3;
									}
									goto IL_0136;
								}
								goto IL_0182;
								IL_0182:
								current = enumerator.Current;
								num2 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
								{
									num2 = 2;
								}
								goto IL_0136;
								IL_0136:
								while (true)
								{
									switch (num2)
									{
									case 3:
									case 5:
										break;
									case 6:
										goto IL_0182;
									case 1:
										lXB6htGs5ugvyffxBHpN(this, current);
										num2 = 5;
										continue;
									case 2:
										if (current == null)
										{
											num2 = 3;
											continue;
										}
										goto default;
									default:
										pZmqo8GsgwbFyLHrfr6a(current, value);
										num2 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
										{
											num2 = 0;
										}
										continue;
									case 4:
										goto end_IL_015c;
									}
									break;
								}
								continue;
								end_IL_015c:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
								{
									num3 = 0;
								}
								while (true)
								{
									switch (num3)
									{
									default:
										koc7YjGsYRp1eu6r2LvC(enumerator);
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
										{
											num3 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
						goto case 3;
					case 10:
						list = PrepareEventsList(list);
						num = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num = 2;
						}
						continue;
					case 1:
						list = GetContextEventList();
						num = 10;
						continue;
					case 5:
						if (unitOfWork != null)
						{
							num = 4;
							continue;
						}
						goto case 7;
					case 4:
						guid = zIJpKLGsrOsUbr1DnK9L(unitOfWork);
						break;
					case 0:
						return;
					}
					value = guid;
					num = 9;
				}
			}
			catch (Exception ex)
			{
				int num4 = 2;
				while (true)
				{
					switch (num4)
					{
					case 2:
						Logger.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289451938)), ex);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num4 = 0;
						}
						continue;
					case 1:
						throw;
					}
					if (sUbMrHGss9rwnA2M8rNo(Transform, ex))
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num4 = 0;
						}
						continue;
					}
					return;
				}
			}
		case 0:
			break;
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
		ClearContextEventList();
	}

	protected abstract void PersistEvent(EntityActionEventArgs e);

	protected virtual IList<EntityActionEventArgs> PrepareEventsList(IList<EntityActionEventArgs> list)
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_0();
		CS_0024_003C_003E8__locals0.list = list;
		ActionEventAggregatorResult[] seed = new ActionEventAggregatorResult[0];
		return (from e in (from r in Aggregators.Aggregate(seed, (ActionEventAggregatorResult[] current, IEntityActionEventAggregator aggregator) => current.Union(aggregator.Aggregate(CS_0024_003C_003E8__locals0.list, current)).ToArray())
				where _003C_003Ec.ke5S8d8IDur4i38tYK8E(r)
				select (EntityActionEventArgs)_003C_003Ec.RfnAYS8ItbnZi14fOsVB(r)).Distinct()
			orderby e.ActionDate
			select e).ToList();
	}

	private IList<EntityActionEventArgs> GetContextEventList()
	{
		return contextBoundVariableService.GetOrAdd(EventListContextKey, () => new List<EntityActionEventArgs>());
	}

	private void ClearContextEventList()
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
				vXSdIOGszlq5yJ0psggD(contextBoundVariableService, RUa8ghGsck2FqnastY5g(this), new List<EntityActionEventArgs>());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool eEubSNGsyYWkLLa9HOMx()
	{
		return nDS3v9GsmNlwIMjHFslX == null;
	}

	internal static BaseEntityActionUnitOfWorkListener nWfX3oGsMUFOyFbF1aUm()
	{
		return nDS3v9GsmNlwIMjHFslX;
	}

	internal static void OQ3AGhGsJV4XR0RaYAya()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object gLa6UEGs90bmTcrADK0D(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object y2nkieGsddM7mGryI5RK(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static Guid iVoklnGslioFQymwJLtu()
	{
		return Guid.NewGuid();
	}

	internal static Guid zIJpKLGsrOsUbr1DnK9L(object P_0)
	{
		return ((IUnitOfWork)P_0).Uid;
	}

	internal static void pZmqo8GsgwbFyLHrfr6a(object P_0, Guid value)
	{
		((EntityActionEventArgs)P_0).UnitOfWorkUid = value;
	}

	internal static void lXB6htGs5ugvyffxBHpN(object P_0, object P_1)
	{
		((BaseEntityActionUnitOfWorkListener)P_0).PersistEvent((EntityActionEventArgs)P_1);
	}

	internal static bool IAqitPGsjJkYQUZr8loG(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void koc7YjGsYRp1eu6r2LvC(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool MNTk1MGsLOA3Lr8PpCYH(object P_0)
	{
		return ((ISession)P_0).IsDirty();
	}

	internal static void NqKNEyGsUoSlc9VNrr3r(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static bool sUbMrHGss9rwnA2M8rNo(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).IsUnrecoverableException((Exception)P_1);
	}

	internal static object RUa8ghGsck2FqnastY5g(object P_0)
	{
		return ((BaseEntityActionUnitOfWorkListener)P_0).EventListContextKey;
	}

	internal static void vXSdIOGszlq5yJ0psggD(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}
}

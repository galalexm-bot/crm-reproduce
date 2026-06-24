using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Events.Audit;

[Component]
public class EntityAuditObjectProvider : IAuditObjectProvider
{
	[Component(Order = -200)]
	private class MetadataPublishFinishedEventHandler : IMetadataPublishFinishedEventHandler, IEventHandler
	{
		private readonly object entityAuditObjectProvider;

		internal static object YsAyYXCoOEh9ESr81D6g;

		public MetadataPublishFinishedEventHandler(EntityAuditObjectProvider entityAuditObjectProvider)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			YTXKcDCoPRnSOfNZT3pO();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				this.entityAuditObjectProvider = entityAuditObjectProvider;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num = 1;
				}
			}
		}

		public void PublishExecuted(MetadataPublishedEventArgs e)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
				{
					ISet<Guid> toInitialize = ((EntityAuditObjectProvider)entityAuditObjectProvider).toInitialize;
					if (toInitialize == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 1;
						}
						break;
					}
					toInitialize.AddAll(from m in e.DeltaPublishedMetadata.OfType<EntityMetadata>()
						select _003C_003Ec.Rq3ct1ZuUotS1dGWypjH(m));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
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

		internal static void YTXKcDCoPRnSOfNZT3pO()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool MNCfslCo23DZuPDBEQKL()
		{
			return YsAyYXCoOEh9ESr81D6g == null;
		}

		internal static MetadataPublishFinishedEventHandler fH0XRMCoema8HAhDyjBd()
		{
			return (MetadataPublishFinishedEventHandler)YsAyYXCoOEh9ESr81D6g;
		}
	}

	private readonly IDictionary<Guid, IAuditObject> objectsByUid;

	private ISet<Guid> toInitialize;

	private static EntityAuditObjectProvider AtoDHjoWPSkehUYQo6yj;

	public IEnumerable<IAuditObject> GetObjects()
	{
		Initialize();
		return objectsByUid.Values;
	}

	public virtual IAuditObject GetObject(Guid uid)
	{
		int num = 1;
		int num2 = num;
		IAuditObject value = default(IAuditObject);
		while (true)
		{
			switch (num2)
			{
			default:
				objectsByUid.TryGetValue(uid, out value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return value;
			case 1:
				Initialize();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void Initialize()
	{
		//Discarded unreachable code: IL_004d, IL_00e8, IL_00f7, IL_0108, IL_0117, IL_0122, IL_01f1, IL_0200, IL_0221, IL_028e, IL_02e5, IL_02f4, IL_0304, IL_0313, IL_03e7, IL_0406, IL_0415, IL_0442, IL_0451, IL_047e
		int num = 3;
		int num2 = num;
		EntityAuditObjectProvider entityAuditObjectProvider = default(EntityAuditObjectProvider);
		bool lockTaken = default(bool);
		IEnumerable<EntityMetadata> source = default(IEnumerable<EntityMetadata>);
		IEnumerator<EntityMetadata> enumerator = default(IEnumerator<EntityMetadata>);
		EntityMetadata current = default(EntityMetadata);
		IMetadataRuntimeService service = default(IMetadataRuntimeService);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			default:
				try
				{
					Monitor.Enter(entityAuditObjectProvider, ref lockTaken);
					int num3 = 14;
					while (true)
					{
						switch (num3)
						{
						case 3:
							return;
						case 6:
							return;
						case 7:
							YF7isvoWtxBWn6ADtjWu(toInitialize);
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num3 = 6;
							}
							break;
						case 1:
							source = source.Where((EntityMetadata m) => toInitialize.Contains(m.Uid));
							num3 = 15;
							break;
						case 9:
							try
							{
								while (true)
								{
									int num4;
									if (!qSFh41oWaRYurEw4Qw4w(enumerator))
									{
										num4 = 3;
										goto IL_0126;
									}
									goto IL_0189;
									IL_0126:
									while (true)
									{
										switch (num4)
										{
										case 2:
											objectsByUid[NE5g51oWpphNIPaa6k1T(current)] = new EntityAuditObject(current);
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
											{
												num4 = 0;
											}
											continue;
										case 1:
											goto IL_0189;
										case 3:
											goto end_IL_0173;
										}
										break;
									}
									continue;
									IL_0189:
									current = enumerator.Current;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
									{
										num4 = 2;
									}
									goto IL_0126;
									continue;
									end_IL_0173:
									break;
								}
							}
							finally
							{
								int num5;
								if (enumerator == null)
								{
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
									{
										num5 = 0;
									}
									goto IL_01d6;
								}
								goto IL_020b;
								IL_020b:
								bTiBNqoWD0vYIWvXTLlG(enumerator);
								int num6 = 2;
								num5 = num6;
								goto IL_01d6;
								IL_01d6:
								switch (num5)
								{
								default:
									goto end_IL_01b1;
								case 0:
									goto end_IL_01b1;
								case 1:
									break;
								case 2:
									goto end_IL_01b1;
								}
								goto IL_020b;
								end_IL_01b1:;
							}
							goto case 5;
						default:
							service = Locator.GetService<IMetadataRuntimeService>();
							num3 = 16;
							break;
						case 5:
						case 11:
							if (toInitialize == null)
							{
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
								{
									num3 = 2;
								}
								break;
							}
							goto case 7;
						case 8:
							source = service.GetMetadataList().OfType<EntityMetadata>();
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num3 = 13;
							}
							break;
						case 16:
							if (service == null)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
								{
									num3 = 11;
								}
								break;
							}
							goto case 8;
						case 14:
						{
							ISet<Guid> set2 = toInitialize;
							if (set2 == null)
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
								{
									num3 = 12;
								}
								break;
							}
							if (EadZB7oW375pLuA3GRd8(set2) == 0)
							{
								return;
							}
							goto case 12;
						}
						case 13:
							if (toInitialize == null)
							{
								num3 = 2;
								break;
							}
							goto case 1;
						case 12:
							num3 = 4;
							break;
						case 2:
						case 15:
							enumerator = source.Where((EntityMetadata m) => !m.IsInterfaceType).GetEnumerator();
							num3 = 9;
							break;
						case 10:
							toInitialize = PublishCacheContext.CreateCache(delegate(ISet<Guid> c, Type t, Guid g)
							{
								c.Add(g);
							});
							num3 = 7;
							break;
						}
					}
				}
				finally
				{
					int num7;
					if (!lockTaken)
					{
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num7 = 0;
						}
						goto IL_03eb;
					}
					goto IL_0420;
					IL_0420:
					MT1jtcoWweWvWhKH3sej(entityAuditObjectProvider);
					num7 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num7 = 2;
					}
					goto IL_03eb;
					IL_03eb:
					switch (num7)
					{
					case 1:
						goto end_IL_03c6;
					case 2:
						goto end_IL_03c6;
					}
					goto IL_0420;
					end_IL_03c6:;
				}
			case 1:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				return;
			case 6:
				entityAuditObjectProvider = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
			{
				ISet<Guid> set = toInitialize;
				if (set == null)
				{
					num2 = 2;
					continue;
				}
				if (EadZB7oW375pLuA3GRd8(set) == 0)
				{
					return;
				}
				break;
			}
			case 2:
				break;
			}
			num2 = 6;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
			{
				num2 = 4;
			}
		}
	}

	public EntityAuditObjectProvider()
	{
		//Discarded unreachable code: IL_0061, IL_0066
		S645MRoW4COn972SnGkp();
		objectsByUid = PublishCacheContext.CreateCache(delegate(IDictionary<Guid, IAuditObject> c, Type t, Guid u)
		{
			c.Remove(u);
		});
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lLhHBUoW1UWVMduJbFgk()
	{
		return AtoDHjoWPSkehUYQo6yj == null;
	}

	internal static EntityAuditObjectProvider OUuKpdoWNSlaIjD1XAvi()
	{
		return AtoDHjoWPSkehUYQo6yj;
	}

	internal static int EadZB7oW375pLuA3GRd8(object P_0)
	{
		return ((ICollection<Guid>)P_0).Count;
	}

	internal static Guid NE5g51oWpphNIPaa6k1T(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool qSFh41oWaRYurEw4Qw4w(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void bTiBNqoWD0vYIWvXTLlG(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void YF7isvoWtxBWn6ADtjWu(object P_0)
	{
		((ICollection<Guid>)P_0).Clear();
	}

	internal static void MT1jtcoWweWvWhKH3sej(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void S645MRoW4COn972SnGkp()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

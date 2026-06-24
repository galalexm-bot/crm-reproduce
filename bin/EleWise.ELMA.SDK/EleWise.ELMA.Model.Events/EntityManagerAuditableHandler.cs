using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Events;

[Component]
public class EntityManagerAuditableHandler : IAuditableEventHandlerAsync, IAuditableEventHandler, IEventHandler
{
	private ConcurrentDictionary<Type, IEnumerable<IEntityExtensionManager>> _extManagersByInvokerType;

	internal static EntityManagerAuditableHandler qVfMsjoFcedYwMKGksJO;

	public IMetadataRuntimeService MetadataRuntimeService
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataRuntimeService_003Ek__BackingField;
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
					_003CMetadataRuntimeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public void Preprocess(AuditableCancelEventArgs e)
	{
		//Discarded unreachable code: IL_00b0, IL_00c0, IL_00cf, IL_00da, IL_0167, IL_017a, IL_0189, IL_01ba, IL_01f2, IL_0201
		int num = 3;
		int num2 = num;
		IEnumerable<IEntityExtensionManager> extensionManagers = default(IEnumerable<IEntityExtensionManager>);
		IEnumerator<IEntityExtensionManager> enumerator = default(IEnumerator<IEntityExtensionManager>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (TpwnIboBBsIVfFQiBKEu(e))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 2;
					}
					break;
				}
				extensionManagers = GetExtensionManagers(QeIfacoBW4cw4NfX5uG0(e));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 0:
				return;
			case 4:
				return;
			case 5:
				enumerator = extensionManagers.GetEnumerator();
				num2 = 6;
				break;
			case 1:
				if (extensionManagers == null)
				{
					num2 = 4;
					break;
				}
				goto case 5;
			case 6:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
							{
								num3 = 0;
							}
							goto IL_00de;
						}
						goto IL_013b;
						IL_013b:
						dAyy4moBo9XknkqjpOpm(enumerator.Current, e);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num3 = 2;
						}
						goto IL_00de;
						IL_00de:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 3:
								return;
							case 2:
								if (TpwnIboBBsIVfFQiBKEu(e))
								{
									return;
								}
								num3 = 5;
								continue;
							case 4:
							case 5:
								break;
							case 1:
								goto IL_013b;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								f3YJBfoBbNKg5GPVEbo5(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
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
			}
		}
	}

	public void Postprocess(AuditableEventArgs e)
	{
		//Discarded unreachable code: IL_0080, IL_008a, IL_0107, IL_0147, IL_0156, IL_0162
		int num = 1;
		int num2 = num;
		IEnumerable<IEntityExtensionManager> extensionManagers = default(IEnumerable<IEntityExtensionManager>);
		IEnumerator<IEntityExtensionManager> enumerator = default(IEnumerator<IEntityExtensionManager>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 1:
				extensionManagers = GetExtensionManagers(QeIfacoBW4cw4NfX5uG0(e));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (extensionManagers == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!d6fyoeoBGdwfjO2uBnVZ(enumerator))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
							{
								num3 = 1;
							}
							goto IL_008e;
						}
						goto IL_00a4;
						IL_00a4:
						jtt6pGoBhLIvlOuPYdsJ(enumerator.Current, e);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num3 = 0;
						}
						goto IL_008e;
						IL_008e:
						switch (num3)
						{
						case 1:
							return;
						case 2:
							break;
						default:
							continue;
						}
						goto IL_00a4;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 2;
						goto IL_010b;
					}
					goto IL_0121;
					IL_010b:
					switch (num4)
					{
					default:
						goto end_IL_00f6;
					case 1:
						break;
					case 2:
						goto end_IL_00f6;
					case 0:
						goto end_IL_00f6;
					}
					goto IL_0121;
					IL_0121:
					f3YJBfoBbNKg5GPVEbo5(enumerator);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num4 = 0;
					}
					goto IL_010b;
					end_IL_00f6:;
				}
			case 2:
				enumerator = extensionManagers.GetEnumerator();
				num2 = 3;
				break;
			}
		}
	}

	public Task PreprocessAsync(AuditableCancelEventArgs e, CancellationToken cancellationToken = default(CancellationToken))
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				cancellationToken.ThrowIfCancellationRequested();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return (Task)DHRStGoBEUvbh0bmgTAm();
			default:
				Preprocess(e);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public Task PostprocessAsync(AuditableEventArgs e, CancellationToken cancellationToken = default(CancellationToken))
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (Task)DHRStGoBEUvbh0bmgTAm();
			case 1:
				cancellationToken.ThrowIfCancellationRequested();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Postprocess(e);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private IEnumerable<IEntityExtensionManager> GetExtensionManagers(Type invokerType)
	{
		if (_extManagersByInvokerType.TryGetValue(invokerType, out var value))
		{
			return value;
		}
		if (MetadataRuntimeService == null)
		{
			_extManagersByInvokerType[invokerType] = null;
			return null;
		}
		Type @interface = invokerType.GetInterface(typeof(IEntityManager<>).FullName);
		if (@interface == null)
		{
			_extManagersByInvokerType[invokerType] = null;
			return null;
		}
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(@interface.GetGenericArguments()[0]) as EntityMetadata;
		List<IEntityExtensionManager> list = new List<IEntityExtensionManager>();
		GetExtensionManagers(entityMetadata, list);
		_extManagersByInvokerType[invokerType] = list;
		return list;
	}

	private void GetExtensionManagers(EntityMetadata entityMetadata, List<IEntityExtensionManager> managers)
	{
		if (entityMetadata == null || entityMetadata.Type != EntityMetadataType.InterfaceImplementation)
		{
			return;
		}
		if (entityMetadata.ImplementedExtensionUids != null && entityMetadata.ImplementedExtensionUids.Any())
		{
			Type typeByUid = MetadataRuntimeService.GetTypeByUid(entityMetadata.ImplementationUid, loadImplementation: false);
			Type entityIdType = ModelHelper.GetEntityIdType(typeByUid);
			if (typeByUid != null && entityIdType != null)
			{
				foreach (Guid implementedExtensionUid in entityMetadata.ImplementedExtensionUids)
				{
					Type typeByUid2 = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(implementedExtensionUid, loadImplementation: false);
					if (typeByUid2 != null && Locator.GetService(typeof(IEntityExtensionManager<, , >).MakeGenericType(typeByUid, typeByUid2, entityIdType)) is IEntityExtensionManager item)
					{
						managers.Add(item);
					}
				}
			}
		}
		EntityMetadata entityMetadata2 = ((entityMetadata.BaseClassUid != Guid.Empty) ? (MetadataRuntimeService.GetMetadata(entityMetadata.BaseClassUid) as EntityMetadata) : null);
		if (entityMetadata2 != null)
		{
			GetExtensionManagers(entityMetadata2, managers);
		}
	}

	public EntityManagerAuditableHandler()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		QhPQN6oBfvbVE3Eefec3();
		_extManagersByInvokerType = new ConcurrentDictionary<Type, IEnumerable<IEntityExtensionManager>>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool xJ9XeHoFzpphGGQOZR3l()
	{
		return qVfMsjoFcedYwMKGksJO == null;
	}

	internal static EntityManagerAuditableHandler bee8FyoBFeYuFY9QOGD7()
	{
		return qVfMsjoFcedYwMKGksJO;
	}

	internal static bool TpwnIboBBsIVfFQiBKEu(object P_0)
	{
		return ((AuditableCancelEventArgs)P_0).Cancel;
	}

	internal static Type QeIfacoBW4cw4NfX5uG0(object P_0)
	{
		return ((AuditableEventArgs)P_0).InvokerType;
	}

	internal static void dAyy4moBo9XknkqjpOpm(object P_0, object P_1)
	{
		((IEntityExtensionManager)P_0).Preprocess((AuditableCancelEventArgs)P_1);
	}

	internal static void f3YJBfoBbNKg5GPVEbo5(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void jtt6pGoBhLIvlOuPYdsJ(object P_0, object P_1)
	{
		((IEntityExtensionManager)P_0).Postprocess((AuditableEventArgs)P_1);
	}

	internal static bool d6fyoeoBGdwfjO2uBnVZ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object DHRStGoBEUvbh0bmgTAm()
	{
		return Task.CompletedTask;
	}

	internal static void QhPQN6oBfvbVE3Eefec3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

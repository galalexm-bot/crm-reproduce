using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Caching;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Extensions.NHibernateLinqExtensions;
using EleWise.ELMA.FullTextSearch.Exceptions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers.EQL;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Collection;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Persister.Entity;
using NHibernate.Proxy;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers;

public static class EntityManager<T> where T : IEntity
{
	public static IEntityManager<T> Instance => Locator.GetServiceNotNull<IEntityManager<T>>();

	public static T Create()
	{
		return Instance.Create();
	}
}
[DeveloperApi(DeveloperApiType.Manager)]
public class EntityManager<T, IdT> : AbstractNHEntityManager<T, IdT>, IEntityExistsManager, IEntityManagerAlias where T : IEntity<IdT>
{
	private static readonly ILogger IndexLog;

	private static MemoryCache memoryCache;

	private static readonly object locker;

	private static CacheItemPolicy DefaultCacheItemPolicy;

	private bool authenticationServiceExists;

	private bool securityServiceExists;

	private IndexQueueManager indexQueueManager;

	private RunWithSoftDeletableService runWithSoftDeletableService;

	private readonly NestedScopeComponents<IEntityManagerBehavior> behaviors;

	private bool? hasUidProperty;

	private PropertyMetadata uidPropertyMetadata;

	private Type implementationType;

	private string entityName;

	private Guid implementationTypeUid;

	private bool? isTablePart;

	private string entityTypeUidPropertyName;

	internal static object uNnDhfhvZuDlpgSRtlRK;

	private static MemoryCache MemoryCache
	{
		get
		{
			//Discarded unreachable code: IL_007d, IL_008c, IL_00ab, IL_0139, IL_0171
			int num = 1;
			int num2 = num;
			bool lockTaken = default(bool);
			object obj = default(object);
			while (true)
			{
				switch (num2)
				{
				case 4:
					lockTaken = false;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return memoryCache;
				case 3:
					obj = locker;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 2;
						while (true)
						{
							switch (num3)
							{
							case 1:
								memoryCache = new MemoryCache(GetCacheForUidName());
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								if (memoryCache == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
									{
										num3 = 1;
									}
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (lockTaken)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									Monitor.Exit(obj);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
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
					goto default;
				case 1:
					if (memoryCache != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				}
			}
		}
	}

	[NotNull]
	public ITransformationProvider Transformation
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformation_003Ek__BackingField;
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
					_003CTransformation_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[NotNull]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[NotNull]
	public IMemoryCacheService MemoryCacheService => Locator.GetServiceNotNull<IMemoryCacheService>();

	[NotNull]
	public IEntityActionHandler ActionHandler
	{
		[CompilerGenerated]
		get
		{
			return _003CActionHandler_003Ek__BackingField;
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
				case 1:
					_003CActionHandler_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[NotNull]
	public IAuthenticationService AuthenticationService => Locator.GetServiceNotNull<IAuthenticationService>();

	protected bool AuthenticationServiceExists
	{
		get
		{
			int num = 1;
			int num2 = num;
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					result = (authenticationServiceExists = Locator.GetService<IAuthenticationService>() != null);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return result;
				case 1:
					if (authenticationServiceExists)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[NotNull]
	public ActionDispatcherService ActionDispatcherService
	{
		[CompilerGenerated]
		get
		{
			return _003CActionDispatcherService_003Ek__BackingField;
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
					_003CActionDispatcherService_003Ek__BackingField = value;
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

	[NotNull]
	public ILogger Logger
	{
		[CompilerGenerated]
		get
		{
			return _003CLogger_003Ek__BackingField;
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
				case 1:
					_003CLogger_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[NotNull]
	public IUnitOfWorkManager UnitOfWorkManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUnitOfWorkManager_003Ek__BackingField;
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
					_003CUnitOfWorkManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[NotNull]
	public IMainDatabaseProvider MainDatabaseProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CMainDatabaseProvider_003Ek__BackingField;
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
				case 1:
					_003CMainDatabaseProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[NotNull]
	public ScriptExecutionService ScriptExecutionService
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptExecutionService_003Ek__BackingField;
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
					_003CScriptExecutionService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[NotNull]
	public ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	protected bool SecurityServiceExists
	{
		get
		{
			int num = 2;
			int num2 = num;
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 1:
					result = (securityServiceExists = Locator.GetService<ISecurityService>() != null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return result;
				case 2:
					if (securityServiceExists)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	public IContextBoundVariableService ContextService
	{
		[CompilerGenerated]
		get
		{
			return _003CContextService_003Ek__BackingField;
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
					_003CContextService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IFullTextSearchCardService FullTextSearchCardService
	{
		[CompilerGenerated]
		get
		{
			return _003CFullTextSearchCardService_003Ek__BackingField;
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
				case 1:
					_003CFullTextSearchCardService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public IFullTextSearchServiceReIndexingTypeExtension FullTextSearchService
	{
		[CompilerGenerated]
		get
		{
			return _003CFullTextSearchService_003Ek__BackingField;
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
				case 1:
					_003CFullTextSearchService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	protected IndexQueueManager IndexQueueManager
	{
		get
		{
			int num = 1;
			int num2 = num;
			IndexQueueManager indexQueueManager = default(IndexQueueManager);
			IndexQueueManager obj;
			while (true)
			{
				switch (num2)
				{
				default:
					indexQueueManager = (this.indexQueueManager = IndexQueueManager.Instance);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					obj = this.indexQueueManager;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					obj = indexQueueManager;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public IEnumerable<IFindCriteriaExtender> FindCriteriaExtenders { get; set; }

	public RunWithSoftDeletableService RunWithSoftDeletableService
	{
		get
		{
			int num = 2;
			int num2 = num;
			RunWithSoftDeletableService runWithSoftDeletableService = default(RunWithSoftDeletableService);
			RunWithSoftDeletableService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					runWithSoftDeletableService = (this.runWithSoftDeletableService = Locator.GetService<RunWithSoftDeletableService>());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = this.runWithSoftDeletableService;
					if (obj != null)
					{
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					obj = runWithSoftDeletableService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public IEnumerable<IEntityManagerBehavior> Behaviors => behaviors.Value;

	protected EntityMetadata ImplementationTypeMetadata => (EntityMetadata)MetadataLoader.LoadMetadata(ImplementationType, inherit: true, loadImplementation: false);

	protected Type ImplementationType
	{
		get
		{
			int num = 2;
			int num2 = num;
			Type type2;
			Type type = default(Type);
			while (true)
			{
				switch (num2)
				{
				case 2:
					type2 = implementationType;
					if ((object)type2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					type = (implementationType = InterfaceActivator.TypeOf<T>());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					type2 = type;
					break;
				}
				break;
			}
			return type2;
		}
	}

	protected Guid ImplementationTypeUid
	{
		get
		{
			int num = 1;
			int num2 = num;
			Guid result = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!(implementationTypeUid == Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num2 = 0;
						}
						break;
					}
					result = (implementationTypeUid = InterfaceActivator.UID<T>());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 2;
					}
					break;
				default:
					return implementationTypeUid;
				case 2:
					return result;
				}
			}
		}
	}

	protected virtual string DefaultCriteriaAlias => null;

	protected bool IsTablePart
	{
		get
		{
			//Discarded unreachable code: IL_0071, IL_0080
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					isTablePart = InterfaceActivator.LoadMetadata<T>() is ITablePartMetadata;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 2;
					}
					break;
				default:
					return isTablePart.Value;
				case 1:
					if (isTablePart.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				}
			}
		}
	}

	protected string EntityTypeUidPropertyName
	{
		get
		{
			int num = 1;
			int num2 = num;
			string text = default(string);
			string text2;
			while (true)
			{
				switch (num2)
				{
				default:
					text = (entityTypeUidPropertyName = NHibernateHelper.GetCriteriaTypeUidPropertyName(ImplementationType));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					text2 = entityTypeUidPropertyName;
					if (text2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					text2 = text;
					break;
				}
				break;
			}
			return text2;
		}
	}

	static EntityManager()
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
			case 1:
				IndexLog = EleWise.ELMA.Logging.Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978538085));
				num2 = 4;
				break;
			case 4:
				locker = new object();
				num2 = 3;
				break;
			case 3:
				SetDefaultCacheItemPolicy();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[Auditable]
	[PublicApiMember]
	[PublicApiObsoleteInNode("PublicAPI.Docflow.Document", "SR.M('Этот метод устарел')", true)]
	public override T Create()
	{
		T val = Locator.GetService<T>();
		if (val == null)
		{
			if (!ImplementationType.IsClass)
			{
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70189141), ImplementationType.FullName));
			}
			val = Activator.CreateInstance<T>();
		}
		return val;
	}

	[PublicApiMember]
	public override bool IsNew(T obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A5594F));
		}
		return Convert.ToInt64(obj.GetId()) <= 0;
	}

	[PublicApiMember]
	public sealed override bool IsDirty(T obj)
	{
		return CheckDirty(obj, null, null);
	}

	public sealed override bool IsDirty(T obj, object originalState)
	{
		return CheckDirty(obj, null, originalState);
	}

	public sealed override Guid[] GetDirtyPropertyUids(T obj)
	{
		List<Guid> list = new List<Guid>();
		CheckDirty(obj, list, null);
		return list.ToArray();
	}

	public sealed override Guid[] GetDirtyPropertyUids(T obj, object originalState)
	{
		List<Guid> list = new List<Guid>();
		CheckDirty(obj, list, originalState);
		return list.ToArray();
	}

	public sealed override object GetCurrentState(T obj)
	{
		return GetEntityState(obj, null);
	}

	[PublicApiMember]
	[Auditable]
	public override T Load(IdT id)
	{
		return LoadOrNull(id) ?? throw new ObjectNotFoundException(ImplementationType.FullName, id);
	}

	[PublicApiMember]
	[Auditable]
	public override T LoadOrNull(IdT id)
	{
		T val;
		if (CreateOnLoad(id))
		{
			val = GetContextObject(id);
			if (val == null)
			{
				val = Create();
				val.SetId(id);
				AddContextObject(val);
			}
		}
		else
		{
			ISession session = base.Session;
			string text = entityName;
			if (text == null)
			{
				string obj = base.Session.GetSessionImplementation().get_Factory().TryGetGuessEntityName(ImplementationType) ?? ImplementationType.FullName;
				string text2 = obj;
				entityName = obj;
				text = text2;
			}
			val = (T)session.Get(text, (object)id);
			if (val == null)
			{
				val = GetContextObject(id);
			}
			if (val != null)
			{
				NHibernateUtil.Initialize((object)val);
				try
				{
					foreach (IEntityManagerBehavior behavior in Behaviors)
					{
						behavior.OnLoad(val);
					}
					if (CanCache(val))
					{
						if (!hasUidProperty.HasValue)
						{
							InitUidPropertyMetadata();
						}
						if (hasUidProperty.HasValue)
						{
							if (hasUidProperty.Value)
							{
								if (uidPropertyMetadata != null)
								{
									PropertyInfo reflectionProperty = val.GetType().GetReflectionProperty(uidPropertyMetadata.Name);
									if (reflectionProperty != null)
									{
										Guid? guid = (Guid?)reflectionProperty.GetValue(val, null);
										if (guid.GetValueOrDefault() != Guid.Empty)
										{
											MemoryCache.Set(GetCacheKeyByUid(guid.GetValueOrDefault()), val.Id, GetCacheItemPolicy());
											return val;
										}
										return val;
									}
									return val;
								}
								return val;
							}
							return val;
						}
						return val;
					}
					return val;
				}
				catch (ObjectIsDeletedException)
				{
					return (T)(object)null;
				}
			}
		}
		return val;
	}

	private static bool CanCache(T res)
	{
		if (res != null && !NHibernateProxyHelper.IsProxy((object)res) && res.Id != null)
		{
			return !res.Id.Equals(default(IdT));
		}
		return false;
	}

	private static string GetCacheForUidName()
	{
		return InterfaceActivator.TypeOf<T>().FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3323000);
	}

	[Auditable]
	[PublicApiMember]
	public override T Load(Guid uid)
	{
		return LoadOrNull(uid) ?? throw new ObjectNotFoundException(ImplementationType.FullName, uid);
	}

	[Auditable]
	[PublicApiMember]
	public override T LoadOrNull(Guid uid)
	{
		return LoadOrNull(uid, null);
	}

	internal T LoadOrNull(Guid uid, string[] fetchColumns)
	{
		return LoadByUid(uid, fetchColumns);
	}

	[Auditable]
	[PublicApiMember]
	public override T LoadOrCreate(IdT id)
	{
		T val = LoadOrNull(id);
		if (val == null)
		{
			val = Create();
			val.SetId(id);
			AddContextObject(val);
		}
		return val;
	}

	[PublicApiMember]
	[Auditable]
	public override T LoadOrCreate(Guid uid)
	{
		T val = LoadOrNull(uid);
		if (val == null)
		{
			val = Create();
			InternalSetUid(uid, val);
			AddContextObject(val);
		}
		return val;
	}

	[Auditable]
	[PublicApiMember]
	public override void Refresh(T obj)
	{
		base.Session.Refresh((object)obj);
	}

	[ActionCheck("42986da3-d210-414d-9225-f3cde17c18c9")]
	public override ActionCheckResult CanSave(T obj)
	{
		if (ScriptExecutionService.Turned || !SecurityServiceExists || !AuthenticationServiceExists)
		{
			return ActionCheckResult.True;
		}
		if (AuthenticationService.GetCurrentUser() == null)
		{
			return ActionCheckResult.True;
		}
		string name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475937781) + obj.GetHashCode();
		if (ContextVars.TryGetValue<ActionCheckResult>(name, out var value))
		{
			return value;
		}
		Permission permission = (obj.IsNew() ? CommonPermissions.Create : (ChangeAccess(obj) ? CommonPermissions.GrantAccess : CommonPermissions.Edit));
		if (SecurityService.CanCheckPermission(permission, obj) && !SecurityService.HasPermission(permission, obj))
		{
			return ActionCheckResult.False(obj.IsNew() ? SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3269266), ((NamedMetadata)MetadataLoader.LoadMetadata(obj.GetType())).DisplayName) : SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138211458), obj));
		}
		if (permission == CommonPermissions.Create)
		{
			ContextVars.Set(name, ActionCheckResult.True);
		}
		else if (permission == CommonPermissions.Edit && (object)obj is ISoftDeletable softDeletable && (softDeletable.IsDeleted || softDeletable.HardDelete) && objectDeletion(obj))
		{
			return CanDelete(obj);
		}
		return ActionCheckResult.True;
	}

	[Transaction]
	[PublicApiMember]
	[Auditable]
	[ActionMethod("42986da3-d210-414d-9225-f3cde17c18c9")]
	public override void Save(T obj)
	{
		if (Logger.IsInfoEnabled())
		{
			Logger.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146446655), typeof(T).FullName, (obj != null) ? obj.Id.ToString() : z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6E4AED), Environment.StackTrace);
		}
		base.Session.SaveOrUpdate((object)obj);
		AddContextObject(obj);
	}

	[ActionCheck("f5d56c0f-95af-48d5-89a0-ea4e9a336429")]
	public override ActionCheckResult CanDelete(T obj)
	{
		if (!ScriptExecutionService.Turned && SecurityServiceExists && SecurityService.CanCheckPermission(CommonPermissions.Delete, obj) && !SecurityService.HasPermission(CommonPermissions.Delete, obj))
		{
			return ActionCheckResult.False(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87527829), obj));
		}
		return ActionCheckResult.True;
	}

	[ActionMethod("f5d56c0f-95af-48d5-89a0-ea4e9a336429")]
	[PublicApiMember]
	[Transaction]
	[Auditable]
	public override void Delete(T obj)
	{
		if (MetadataLoader.LoadMetadata(obj.GetType()) is EntityMetadata entityMetadata && entityMetadata.ShowInCatalogList && entityMetadata.Hierarchical)
		{
			if (entityMetadata.HierarchyType == HierarchyType.GroupAndElements)
			{
				if ((bool)base.Session.GetOriginalEntityProperty(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998453718)) && GetSubElementCountOfHierarchicalEntity(obj, entityMetadata) > 0)
				{
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A4D934)));
				}
			}
			else if (entityMetadata.HierarchyType == HierarchyType.Elements && GetSubElementCountOfHierarchicalEntity(obj, entityMetadata) > 0)
			{
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31315BDA)));
			}
		}
		base.Session.Delete((object)obj);
		RemoveFromContextObject(obj);
	}

	[NotNull]
	[PublicApiMember]
	public sealed override ICollection<T> Find(FetchOptions fetchOptions)
	{
		return Find(null, fetchOptions, CacheEnabled);
	}

	[NotNull]
	[PublicApiMember]
	public sealed override ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions)
	{
		return Find(filter, fetchOptions, CacheEnabled);
	}

	[NotNull]
	[PublicApiMember]
	public sealed override ICollection<T> Find(string eqlFilter)
	{
		return Find(new Filter
		{
			Query = eqlFilter
		}, FetchOptions.All);
	}

	[NotNull]
	[PublicApiMember]
	public sealed override ICollection<T> Find(string eqlFilter, FetchOptions fetchOptions)
	{
		return Find(new Filter
		{
			Query = eqlFilter
		}, fetchOptions);
	}

	[NotNull]
	public ICollection<IdT> FindIds(IEntityFilter filter, FetchOptions fetchOptions)
	{
		return FindIds(filter, fetchOptions, CacheEnabled);
	}

	[PublicApiMember]
	public sealed override long Count()
	{
		return Count(null);
	}

	[Auditable]
	public override void Refresh(T obj, LockMode mode)
	{
		base.Session.Refresh((object)obj, mode);
	}

	[PublicApiMember]
	public sealed override long Count(IEntityFilter filter)
	{
		int num = 2;
		long? num3 = default(long?);
		ICriteria criteria = default(ICriteria);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!num3.HasValue)
					{
						goto end_IL_0012;
					}
					num2 = 4;
					break;
				case 4:
					return num3.Value;
				default:
					return ReturnCount(criteria);
				case 2:
					num3 = CountByIndex(filter);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					SetupFilter(criteria, filter);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			criteria = CreateCriteria(filter);
			num = 3;
		}
	}

	[PublicApiMember]
	public bool Exists()
	{
		return Exists(null);
	}

	[PublicApiMember]
	public bool Exists(IEntityFilter filter)
	{
		//Discarded unreachable code: IL_00a6, IL_00b5
		int num = 2;
		int num2 = num;
		long num5 = default(long);
		long? num3 = default(long?);
		long? num4 = default(long?);
		ICriteria criteria = default(ICriteria);
		while (true)
		{
			switch (num2)
			{
			default:
				num5 = 0L;
				num2 = 5;
				break;
			case 2:
				num3 = CountByIndex(filter);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				num4 = num3;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (!num3.HasValue)
				{
					num2 = 7;
					break;
				}
				goto case 6;
			case 5:
				return num4 > num5;
			case 7:
				criteria = CreateCriteria(filter);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				SetupFilter(criteria, filter);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return ReturnExists(criteria);
			}
		}
	}

	public override void CheckFilter(IEntityFilter filter)
	{
		int num = 1;
		int num2 = num;
		ICriteria criteria = default(ICriteria);
		while (true)
		{
			switch (num2)
			{
			case 1:
				criteria = CreateCriteria(filter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				break;
			default:
				SetupFilter(criteria, filter);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[PublicApiMember]
	[NotNull]
	public sealed override ICollection<T> FindByIdArray([NotNull] IdT[] idArray)
	{
		return FindByIdArray(idArray, null, null);
	}

	public virtual ICollection<T> FindByIdArray([NotNull] IdT[] idArray, IEntityFilter filter, FetchOptions fetchOptions)
	{
		if (idArray == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307DA49F));
		}
		if (idArray.Length == 0)
		{
			return new Collection<T>();
		}
		ICriteria criteria = CreateCriteriaForArraySearch(idArray, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637EA8C5), filter, fetchOptions);
		return Find(criteria);
	}

	public virtual ICollection<T> FindByIdArray([NotNull] Guid[] uidArray)
	{
		if (uidArray == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957613792));
		}
		if (uidArray.Length == 0)
		{
			return new Collection<T>();
		}
		ICriteria criteria = CreateCriteriaForArraySearch(uidArray, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675482067), null, null);
		return Find(criteria);
	}

	public ICriteria CreateCriteriaForArraySearch<TData>([NotNull] IEnumerable<TData> values, string property, IEntityFilter filter, FetchOptions fetchOptions)
	{
		ICriteria val = CreateCriteria(fetchOptions, GetFetchType(filter), null, filter);
		if (filter != null && fetchOptions != null)
		{
			SetupFilter(val, filter);
			if (!string.IsNullOrEmpty(fetchOptions.QueryKey))
			{
				foreach (IFindCriteriaExtender findCriteriaExtender in FindCriteriaExtenders)
				{
					if (findCriteriaExtender.QueryKey == fetchOptions.QueryKey)
					{
						findCriteriaExtender.Extend(filter, val, fetchOptions);
					}
				}
			}
		}
		return val.Add((ICriterion)(object)Restrictions.In(property, (ICollection)values.ToArray()));
	}

	public EntityManager()
	{
		//Discarded unreachable code: IL_004b, IL_0050
		SingletonReader.JJCZtPuTvSt();
		behaviors = new NestedScopeComponents<IEntityManagerBehavior>(ServiceScope.Shell);
		implementationTypeUid = Guid.Empty;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
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
			Logger = NullLogger.Instance;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
			{
				num = 0;
			}
		}
	}

	[Auditable]
	[Transaction]
	public override void Delete(string query)
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
				base.Session.Delete(query);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[Auditable]
	[Transaction]
	[Obsolete("При необходимости используйте собственную реализацию метода, текущая работает долго и может превысить допустимое время выполнения при большом количестве записей.")]
	public override void DeleteAll()
	{
		//Discarded unreachable code: IL_002e, IL_003d, IL_0048, IL_00d7, IL_010f, IL_011e
		int num = 2;
		int num2 = num;
		IEnumerator<T> enumerator = default(IEnumerator<T>);
		T current = default(T);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_004c;
						}
						goto IL_008e;
						IL_004c:
						while (true)
						{
							switch (num3)
							{
							default:
								Delete(current);
								num3 = 3;
								continue;
							case 3:
								break;
							case 1:
								goto IL_008e;
							case 2:
								return;
							}
							break;
						}
						continue;
						IL_008e:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num3 = 0;
						}
						goto IL_004c;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								enumerator.Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 0:
				return;
			case 2:
				enumerator = FindAll(cacheble: false).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual void Evict(T obj)
	{
		base.Session.Evict((object)obj);
	}

	[NotNull]
	public sealed override ICollection<T> FindAll()
	{
		return Find(null, null, CacheEnabled);
	}

	[NotNull]
	public sealed override ICollection<T> FindAll(bool cacheble)
	{
		return Find(null, null, cacheble);
	}

	[Auditable]
	public virtual ICollection<RT> Query<RT>(Func<IQueryable<T>, IQueryable<RT>> queryExpression)
	{
		return queryExpression(base.Session.Query<T>()).ToList();
	}

	[Auditable]
	[NotNull]
	public override ICollection<T> Find(Expression<Func<T, bool>> condition)
	{
		return Find(condition, null);
	}

	[Auditable]
	[NotNull]
	public override ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition)
	{
		if (!typeof(TResult).IsAssignableFrom(ImplementationType))
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638609563), typeof(TResult), ImplementationType), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16554701));
		}
		return Find(condition, null);
	}

	public override ICollection<T> Find(Expression<Func<T, bool>> condition, FetchOptions fetchOptions)
	{
		return base.Session.Query<T>().Where(condition).SetupFetchOptions(fetchOptions)
			.ToList();
	}

	public override ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition, FetchOptions fetchOptions)
	{
		if (!typeof(TResult).IsAssignableFrom(ImplementationType))
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE24001), typeof(TResult), ImplementationType), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7244395E));
		}
		return base.Session.Query<TResult>().Where(condition).SetupFetchOptions(fetchOptions)
			.ToList();
	}

	[Auditable]
	public override ICollection<PT> Projection<PT>(string propertyName)
	{
		ICriteria criteria = CreateCriteria();
		return ReturnProjection<PT>(criteria, propertyName);
	}

	public override ExportRuleList ExportRules()
	{
		return new ExportRuleList();
	}

	public override bool ExistPropertiesForFastSearch(IEntityMetadata metadata, IEntityFilter filter = null)
	{
		//Discarded unreachable code: IL_006d, IL_007c
		int num = 4;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		List<EntityPropertyMetadata> propertiesForFastSearch = default(List<EntityPropertyMetadata>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				entityMetadata = metadata as EntityMetadata;
				num2 = 3;
				break;
			case 1:
				if (propertiesForFastSearch != null)
				{
					num2 = 5;
					break;
				}
				return false;
			case 3:
				if (entityMetadata != null)
				{
					num2 = 2;
					break;
				}
				goto default;
			case 5:
				return propertiesForFastSearch.Count > 0;
			default:
				return false;
			case 2:
				propertiesForFastSearch = GetPropertiesForFastSearch(entityMetadata, filter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public string GetDefaultCriteriaAlias()
	{
		return DefaultCriteriaAlias;
	}

	protected virtual bool CheckDirty(T obj, List<Guid> propertyUids, object originalState)
	{
		bool turned = RunWithSoftDeletableService.Turned;
		try
		{
			RunWithSoftDeletableService.Turned = true;
			ISessionImplementor sessionImplementation = base.Session.GetSessionImplementation();
			IEntityPersister entityPersister = base.Session.GetEntityPersister(obj);
			if (entityPersister.HasUninitializedLazyProperties((object)obj))
			{
				return false;
			}
			bool flag = originalState != null;
			if (originalState == null)
			{
				EntityEntry entry = sessionImplementation.get_PersistenceContext().GetEntry((object)obj);
				if (entry == null && NHibernateProxyHelper.IsProxy((object)obj))
				{
					object obj2 = obj;
					INHibernateProxy val = (INHibernateProxy)((obj2 is INHibernateProxy) ? obj2 : null);
					object obj3 = sessionImplementation.get_PersistenceContext().Unproxy((object)val);
					entry = sessionImplementation.get_PersistenceContext().GetEntry(obj3);
				}
				if (entry == null)
				{
					return false;
				}
				object[] loadedState = entry.get_LoadedState();
				originalState = GetEntityState(obj, loadedState);
			}
			if (!(originalState is Dictionary<string, object> dictionary))
			{
				return false;
			}
			object[] propertyValues = entityPersister.GetPropertyValues((object)obj);
			bool result = false;
			ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityPersister.get_EntityMetamodel().get_Type());
			Dictionary<string, PropertyMetadata> dictionary2 = classMetadata.Properties.ToDictionary((PropertyMetadata k) => k.Name, (PropertyMetadata v) => v);
			object[] array = new object[entityPersister.get_PropertyNames().Length];
			for (int j = 0; j < entityPersister.get_PropertyNames().Length; j++)
			{
				string key = entityPersister.get_PropertyNames()[j];
				if (dictionary.TryGetValue(key, out var value))
				{
					array[j] = value;
				}
				else
				{
					array[j] = null;
				}
				if (!dictionary2.TryGetValue(key, out var value2) || !(value2.Settings is EntitySettings) || ((EntitySettings)value2.Settings).RelationType != 0)
				{
					continue;
				}
				IEntity entity = array[j] as IEntity;
				IEntity entity2 = propertyValues[j] as IEntity;
				object objA = entity?.GetId();
				object objB = entity2?.GetId();
				if (!object.Equals(objA, objB))
				{
					if (propertyUids == null)
					{
						return true;
					}
					propertyUids.Add(value2.Uid);
					result = true;
				}
				propertyValues[j] = array[j];
			}
			int[] array2 = entityPersister.FindDirty(propertyValues, array, (object)obj, sessionImplementation);
			if (array2 != null && array2.Length != 0)
			{
				if (propertyUids != null)
				{
					int[] array3 = array2;
					foreach (int num in array3)
					{
						string key2 = entityPersister.get_PropertyNames()[num];
						if (dictionary2.TryGetValue(key2, out var value3) && !propertyUids.Contains(value3.Uid))
						{
							propertyUids.Add(value3.Uid);
						}
					}
				}
				if (propertyUids == null)
				{
					return true;
				}
				result = true;
			}
			foreach (IPropertyMetadata item in (classMetadata is IEntityMetadata entityMetadata) ? entityMetadata.GetPropertiesAndTableParts() : classMetadata.Properties.Cast<IPropertyMetadata>())
			{
				if (!(item is ITablePartMetadata) && (!(item.Settings is EntitySettings) || ((EntitySettings)item.Settings).RelationType == RelationType.OneToOne))
				{
					continue;
				}
				object propertyValue = obj.GetPropertyValue(item.PropertyUid);
				IPersistentCollection val2 = (IPersistentCollection)((propertyValue is IPersistentCollection) ? propertyValue : null);
				IEnumerable enumerable = ((val2 != null && val2.get_WasInitialized()) ? (val2.GetValue() as IEnumerable) : (propertyValue as IEnumerable));
				if (enumerable == null)
				{
					continue;
				}
				bool flag2 = enumerable.CastToListOrNull<object>().Any();
				if (!dictionary.TryGetValue(item.Name, out var value4))
				{
					value4 = null;
				}
				bool flag3 = false;
				if (item is ITablePartMetadata tablePartMetadata)
				{
					if (flag)
					{
						flag3 = ((val2 != null) ? val2.get_IsDirty() : flag2) && value4 == null;
						if (!flag3 && value4 is Dictionary<object, object> dictionary3)
						{
							IEntity[] array4 = enumerable.OfType<IEntity>().ToArray();
							if (dictionary3.Count != array4.Length)
							{
								flag3 = true;
							}
							else
							{
								IEntityManager entityManager = ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(tablePartMetadata.Uid));
								IEntity[] array5 = array4;
								foreach (IEntity entity3 in array5)
								{
									if (dictionary3.TryGetValue(entity3.GetId(), out var value5) && entityManager.IsDirty(entity3, value5))
									{
										flag3 = true;
										break;
									}
								}
							}
						}
					}
					else
					{
						flag3 = ((val2 != null) ? val2.get_IsDirty() : flag2);
						if (!flag3)
						{
							foreach (IEntity item2 in (val2 as IEnumerable) ?? enumerable)
							{
								if (item2.IsDirty())
								{
									flag3 = true;
									break;
								}
							}
						}
					}
				}
				else if (flag)
				{
					flag3 = ((val2 != null) ? val2.get_IsDirty() : flag2) && value4 == null;
					if (!flag3 && value4 != null && value4 is IEnumerable<object> enumerable2)
					{
						List<object> list = (from i in enumerable.OfType<IEntity>()
							select i.GetId()).ToList();
						flag3 = list.Count != enumerable2.Count() || !list.SequenceEqual(enumerable2);
					}
				}
				else
				{
					flag3 = ((val2 != null) ? val2.get_IsDirty() : flag2);
				}
				if (flag3)
				{
					if (propertyUids == null)
					{
						return true;
					}
					propertyUids.Add(item.PropertyUid);
					result = true;
				}
			}
			return result;
		}
		finally
		{
			RunWithSoftDeletableService.Turned = turned;
		}
	}

	protected virtual object GetEntityState(IEntity obj, object[] state)
	{
		//Discarded unreachable code: IL_0079, IL_0171, IL_0180, IL_025b, IL_026a, IL_0308, IL_0317, IL_0434, IL_0443, IL_044e, IL_04ec, IL_0524, IL_0574, IL_0608, IL_0639, IL_0648, IL_0653, IL_06f8, IL_0730, IL_076f, IL_077e, IL_07aa, IL_07b9, IL_0801, IL_0839, IL_087d, IL_088c, IL_089b, IL_08b7, IL_0950, IL_0963, IL_0972
		int num = 1;
		int num2 = num;
		object result = default(object);
		bool turned = default(bool);
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		ClassMetadata classMetadata = default(ClassMetadata);
		IEntityPersister entityPersister = default(IEntityPersister);
		string key = default(string);
		int num4 = default(int);
		object value2 = default(object);
		IEnumerator<IPropertyMetadata> enumerator = default(IEnumerator<IPropertyMetadata>);
		IPropertyMetadata current = default(IPropertyMetadata);
		IEnumerable enumerable2 = default(IEnumerable);
		object propertyValue = default(object);
		object value = default(object);
		IPersistentCollection val = default(IPersistentCollection);
		ITablePartMetadata tablePartMetadata = default(ITablePartMetadata);
		IEnumerator<IEntity> enumerator2 = default(IEnumerator<IEntity>);
		Dictionary<object, object> dictionary2 = default(Dictionary<object, object>);
		List<object> list = default(List<object>);
		IEntity current3 = default(IEntity);
		IEntityManager entityManager = default(IEntityManager);
		IEntity current2 = default(IEntity);
		IEntityMetadata entityMetadata = default(IEntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				turned = RunWithSoftDeletableService.Turned;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				RunWithSoftDeletableService.Turned = true;
				int num3 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num3 = 8;
				}
				while (true)
				{
					IEnumerable<IPropertyMetadata> enumerable;
					switch (num3)
					{
					case 16:
						return result;
					case 19:
						return result;
					case 18:
						result = dictionary;
						num3 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num3 = 16;
						}
						continue;
					case 1:
					case 6:
						if (state == null)
						{
							num3 = 14;
							continue;
						}
						goto case 20;
					case 5:
						classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityPersister.get_EntityMetamodel().get_Type());
						num3 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num3 = 4;
						}
						continue;
					case 3:
						if (!entityPersister.HasUninitializedLazyProperties((object)obj))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 9;
					case 9:
						result = null;
						num3 = 19;
						continue;
					case 13:
						key = entityPersister.get_PropertyNames()[num4];
						num3 = 2;
						continue;
					case 8:
						entityPersister = base.Session.GetEntityPersister(obj);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num3 = 3;
						}
						continue;
					case 15:
					case 22:
						if (num4 >= entityPersister.get_PropertyNames().Length)
						{
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto case 13;
					case 2:
						value2 = state[num4];
						num3 = 21;
						continue;
					case 20:
						dictionary = new Dictionary<string, object>();
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num3 = 0;
						}
						continue;
					case 21:
						dictionary[key] = value2;
						num3 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num3 = 1;
						}
						continue;
					case 12:
						try
						{
							while (true)
							{
								IL_03bf:
								int num5;
								if (!enumerator.MoveNext())
								{
									num5 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
									{
										num5 = 6;
									}
									goto IL_0279;
								}
								goto IL_034e;
								IL_034e:
								current = enumerator.Current;
								num5 = 4;
								goto IL_0279;
								IL_0279:
								while (true)
								{
									int num6;
									switch (num5)
									{
									case 7:
									case 22:
										enumerable2 = propertyValue as IEnumerable;
										num5 = 25;
										continue;
									case 1:
									case 19:
										dictionary[current.Name] = value;
										num5 = 15;
										continue;
									case 18:
										break;
									case 24:
										if (val.get_WasInitialized())
										{
											num5 = 2;
											continue;
										}
										goto case 7;
									case 26:
										propertyValue = obj.GetPropertyValue(current.PropertyUid);
										num5 = 27;
										continue;
									case 17:
										tablePartMetadata = current as ITablePartMetadata;
										num5 = 20;
										continue;
									case 6:
										enumerator2 = enumerable2.OfType<IEntity>().GetEnumerator();
										num6 = 21;
										goto IL_0275;
									case 3:
									case 15:
									case 23:
										goto IL_03bf;
									case 27:
										val = (IPersistentCollection)((propertyValue is IPersistentCollection) ? propertyValue : null);
										num5 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
										{
											num5 = 5;
										}
										continue;
									case 14:
										dictionary2 = new Dictionary<object, object>();
										num5 = 6;
										continue;
									default:
										list = new List<object>();
										num6 = 16;
										goto IL_0275;
									case 21:
										try
										{
											while (true)
											{
												int num9;
												if (!enumerator2.MoveNext())
												{
													num9 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
													{
														num9 = 1;
													}
													goto IL_0452;
												}
												goto IL_04b3;
												IL_04b3:
												current3 = enumerator2.Current;
												num9 = 2;
												goto IL_0452;
												IL_0452:
												while (true)
												{
													switch (num9)
													{
													case 2:
														dictionary2[current3.GetId()] = entityManager.GetCurrentState(current3);
														num9 = 3;
														continue;
													case 3:
														break;
													default:
														goto IL_04b3;
													case 1:
														goto end_IL_048d;
													}
													break;
												}
												continue;
												end_IL_048d:
												break;
											}
										}
										finally
										{
											if (enumerator2 != null)
											{
												int num10 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
												{
													num10 = 1;
												}
												while (true)
												{
													switch (num10)
													{
													case 1:
														enumerator2.Dispose();
														num10 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
														{
															num10 = 0;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
										}
										goto case 31;
									case 4:
										if (!(current is ITablePartMetadata))
										{
											num5 = 13;
											continue;
										}
										goto case 26;
									case 13:
										if (current.Settings is EntitySettings)
										{
											num5 = 29;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
											{
												num5 = 15;
											}
											continue;
										}
										goto IL_03bf;
									case 5:
										if (val == null)
										{
											num5 = 22;
											continue;
										}
										goto case 24;
									case 12:
										entityManager = ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(tablePartMetadata.Uid));
										num5 = 14;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
										{
											num5 = 12;
										}
										continue;
									case 25:
									case 28:
										if (enumerable2 == null)
										{
											num5 = 23;
											continue;
										}
										goto case 17;
									case 29:
										if (((EntitySettings)current.Settings).RelationType == RelationType.OneToOne)
										{
											num5 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
											{
												num5 = 3;
											}
											continue;
										}
										goto case 26;
									case 20:
										if (tablePartMetadata == null)
										{
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
											{
												num5 = 0;
											}
											continue;
										}
										goto case 12;
									case 9:
										try
										{
											while (true)
											{
												IL_0684:
												int num7;
												if (!enumerator2.MoveNext())
												{
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
													{
														num7 = 1;
													}
													goto IL_0657;
												}
												goto IL_0671;
												IL_0671:
												current2 = enumerator2.Current;
												num7 = 2;
												goto IL_0657;
												IL_0657:
												while (true)
												{
													switch (num7)
													{
													case 3:
														break;
													default:
														goto IL_0684;
													case 2:
														list.Add(current2.GetId());
														num7 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
														{
															num7 = 0;
														}
														continue;
													case 1:
														goto end_IL_0684;
													}
													break;
												}
												goto IL_0671;
												continue;
												end_IL_0684:
												break;
											}
										}
										finally
										{
											if (enumerator2 != null)
											{
												int num8 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
												{
													num8 = 1;
												}
												while (true)
												{
													switch (num8)
													{
													case 1:
														enumerator2.Dispose();
														num8 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
														{
															num8 = 0;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
										}
										goto case 11;
									case 31:
										value = dictionary2;
										num5 = 19;
										continue;
									case 11:
										value = list;
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
										{
											num5 = 1;
										}
										continue;
									case 16:
										enumerator2 = enumerable2.OfType<IEntity>().GetEnumerator();
										num6 = 9;
										goto IL_0275;
									case 2:
									case 10:
										enumerable2 = val.GetValue() as IEnumerable;
										num5 = 28;
										continue;
									case 8:
										goto end_IL_03bf;
										IL_0275:
										num5 = num6;
										continue;
									}
									break;
								}
								goto IL_034e;
								continue;
								end_IL_03bf:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num11 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
								{
									num11 = 0;
								}
								while (true)
								{
									switch (num11)
									{
									default:
										enumerator.Dispose();
										num11 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
										{
											num11 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
						goto case 18;
					case 11:
						if (entityMetadata != null)
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 10;
					case 14:
						state = entityPersister.GetPropertyValues((object)obj);
						num3 = 20;
						continue;
					case 10:
						enumerable = classMetadata.Properties.Cast<IPropertyMetadata>();
						break;
					case 7:
						num4 = 0;
						num3 = 15;
						continue;
					case 17:
						num4++;
						num3 = 22;
						continue;
					case 4:
						entityMetadata = classMetadata as IEntityMetadata;
						num3 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num3 = 9;
						}
						continue;
					default:
						enumerable = entityMetadata.GetPropertiesAndTableParts();
						break;
					}
					enumerator = enumerable.GetEnumerator();
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num3 = 12;
					}
				}
			}
			finally
			{
				RunWithSoftDeletableService.Turned = turned;
				int num12 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num12 = 0;
				}
				switch (num12)
				{
				case 0:
					break;
				}
			}
		}
	}

	protected virtual ICollection<T> Find(ICriteria criteria)
	{
		Contract.ArgumentNotNull(criteria, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3633C887));
		return criteria.List<T>();
	}

	protected virtual void SetupSortOptions(ICriteria criteria, FetchOptions fetchOptions, Type entityType)
	{
		//Discarded unreachable code: IL_0147, IL_018b, IL_019a, IL_01aa, IL_01b9, IL_021f, IL_02a9, IL_039d
		int num = 13;
		ICustomSortable customSortable = default(ICustomSortable);
		_003C_003Ec__DisplayClass129_0 _003C_003Ec__DisplayClass129_ = default(_003C_003Ec__DisplayClass129_0);
		string[] source = default(string[]);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 21:
					customSortable = ComponentManager.Current.GetExtensionPoints<ICustomSortable>().FirstOrDefault(_003C_003Ec__DisplayClass129_._003CSetupSortOptions_003Eb__1);
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 22;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass129_.fetchOptions.SortExpression = customSortable.BuildSortExpression(_003C_003Ec__DisplayClass129_.metadata, _003C_003Ec__DisplayClass129_.fetchOptions.SortExpression);
					num2 = 18;
					continue;
				case 6:
					if (_003C_003Ec__DisplayClass129_.metadata == null)
					{
						num2 = 24;
						continue;
					}
					goto case 15;
				case 30:
					if (_003C_003Ec__DisplayClass129_.fetchOptions == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 20;
				case 4:
					if (_003C_003Ec__DisplayClass129_.metadata.IsGroupPropertyUid != Guid.Empty)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 8;
				case 26:
					_003C_003Ec__DisplayClass129_.criteria = criteria;
					num2 = 28;
					continue;
				case 1:
				case 18:
					source = _003C_003Ec__DisplayClass129_.fetchOptions.SortExpression.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3630A191).ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
					num2 = 19;
					continue;
				case 8:
				case 24:
					obj = null;
					goto IL_04bd;
				case 22:
					if (customSortable == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				case 23:
					if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass129_.fetchOptions.SortExpression))
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 21;
						}
						continue;
					}
					return;
				case 14:
					_003C_003Ec__DisplayClass129_.childMetadataList = MetadataLoader.GetChildProperties(_003C_003Ec__DisplayClass129_.metadata);
					num2 = 6;
					continue;
				case 12:
					_003C_003Ec__DisplayClass129_.fetchOptions = fetchOptions;
					num2 = 2;
					continue;
				case 17:
					if (!_003C_003Ec__DisplayClass129_.fetchOptions.DisableDefaultGroupSorting)
					{
						num = 7;
						break;
					}
					goto case 11;
				case 28:
					_003C_003Ec__DisplayClass129_.entityType = entityType;
					num2 = 3;
					continue;
				case 20:
					if (_003C_003Ec__DisplayClass129_.fetchOptions.SortExpression != propertyMetadata.Name)
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 11;
				case 15:
					if (_003C_003Ec__DisplayClass129_.metadata.Hierarchical)
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 8;
				case 9:
					if (propertyMetadata == null)
					{
						num = 11;
						break;
					}
					goto case 30;
				case 27:
					return;
				case 25:
					if (_003C_003Ec__DisplayClass129_.metadata.HierarchyType == HierarchyType.GroupAndElements)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 8;
				case 13:
					_003C_003Ec__DisplayClass129_ = new _003C_003Ec__DisplayClass129_0();
					num2 = 12;
					continue;
				case 11:
				case 16:
					if (!(_003C_003Ec__DisplayClass129_.fetchOptions != null))
					{
						return;
					}
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 23;
					}
					continue;
				default:
					_003C_003Ec__DisplayClass129_.criteria.AddOrder(Order.Desc(propertyMetadata.Name));
					num2 = 16;
					continue;
				case 2:
					_003C_003Ec__DisplayClass129_._003C_003E4__this = this;
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 13;
					}
					continue;
				case 3:
					Contract.ArgumentNotNull(_003C_003Ec__DisplayClass129_.entityType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x831A7A6));
					num2 = 29;
					continue;
				case 29:
					_003C_003Ec__DisplayClass129_.metadata = ((_003C_003Ec__DisplayClass129_.entityType == ImplementationType) ? ImplementationTypeMetadata : (MetadataLoader.LoadMetadata(_003C_003Ec__DisplayClass129_.entityType) as EntityMetadata));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 14;
					}
					continue;
				case 10:
					obj = _003C_003Ec__DisplayClass129_.metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass129_._003CSetupSortOptions_003Eb__0);
					goto IL_04bd;
				case 19:
					{
						_003C_003Ec__DisplayClass129_.criteria = (from o in source.Select(_003C_003Ec__DisplayClass129_._003CSetupSortOptions_003Eb__2)
							where o != null
							select o).Aggregate(_003C_003Ec__DisplayClass129_.criteria, (ICriteria current, Order order) => current.AddOrder(order));
						num2 = 27;
						continue;
					}
					IL_04bd:
					propertyMetadata = (PropertyMetadata)obj;
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	protected virtual void SetupFetchOptions(ICriteria criteria, FetchOptions fetchOptions, Type entityType)
	{
		//Discarded unreachable code: IL_0122, IL_0196, IL_01a0, IL_022f, IL_023e, IL_0271, IL_0280, IL_0363, IL_0376, IL_0385, IL_044a, IL_0459, IL_05b4, IL_05d0, IL_05da, IL_063b, IL_0645, IL_06a6, IL_06f3, IL_0702, IL_07f4, IL_0852, IL_08bc, IL_08cf, IL_0942, IL_0951, IL_0961, IL_0970, IL_0980
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		List<string> list2 = default(List<string>);
		List<string> list = default(List<string>);
		EntityMetadata entityMetadata = default(EntityMetadata);
		ProjectionList val = default(ProjectionList);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string[] array = default(string[]);
		string propertyName = default(string);
		string current = default(string);
		CustomPropertyProjection customProj = default(CustomPropertyProjection);
		EntityMetadata realMetadata = default(EntityMetadata);
		SelectMode selectMode = default(SelectMode);
		string current2 = default(string);
		string[] array2 = default(string[]);
		CustomPropertyProjection customProj2 = default(CustomPropertyProjection);
		string alias2 = default(string);
		EntityMetadata realMetadata2 = default(EntityMetadata);
		string propertyName2 = default(string);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				List<string> list3;
				Type type;
				object obj;
				switch (num2)
				{
				case 35:
				case 36:
					if (!FetchOptionsBuilder.IsCanOptimaze(criteria, list2.Union(list).ToList(), entityMetadata))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 38;
				case 29:
					if (fetchOptions.SelectColumns.Count > 0)
					{
						num = 39;
						break;
					}
					goto case 35;
				case 24:
					num3 = 1;
					goto IL_0a71;
				case 8:
					criteria.FetchModeForProjections(true);
					num2 = 22;
					continue;
				case 12:
					SetupSortOptions(criteria, fetchOptions, entityType);
					num2 = 31;
					continue;
				case 7:
					val.Add((IProjection)(object)Projections.Property(GetTypeUidPropertyName(entityType)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE39FEB));
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 19;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_02c6:
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 2;
								goto IL_01a4;
							}
							goto IL_0249;
							IL_01a4:
							while (true)
							{
								string alias;
								switch (num4)
								{
								case 6:
									if (array.Length == 3)
									{
										num4 = 11;
										continue;
									}
									goto case 1;
								case 9:
									propertyName = "";
									num4 = 10;
									continue;
								case 13:
									array = current.Split(new char[1] { ':' }, StringSplitOptions.RemoveEmptyEntries);
									num4 = 6;
									continue;
								case 3:
									break;
								case 5:
									alias = null;
									num4 = 9;
									continue;
								case 12:
									if (customProj == null)
									{
										num4 = 7;
										continue;
									}
									goto case 8;
								case 10:
								{
									GetRealProjection(array, entityType, out customProj, out alias, out realMetadata, out var _, out propertyName);
									num4 = 12;
									continue;
								}
								default:
									goto IL_02c6;
								case 11:
									customProj = null;
									num4 = 5;
									continue;
								case 1:
									AddFetchColumnIfNeeded(entityMetadata, list, list2, current);
									num4 = 4;
									continue;
								case 8:
									AddFetchColumnIfNeeded(realMetadata ?? entityMetadata, list, list2, propertyName);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
									{
										num4 = 0;
									}
									continue;
								case 2:
									goto end_IL_02c6;
								}
								break;
							}
							goto IL_0249;
							IL_0249:
							current = enumerator.Current;
							num4 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num4 = 1;
							}
							goto IL_01a4;
							continue;
							end_IL_02c6:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 35;
				case 17:
					if (fetchOptions.UsePartialFetching)
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 24;
				case 4:
					criteria = criteria.SetFirstResult(fetchOptions.FirstResult);
					num2 = 3;
					continue;
				case 10:
					list3 = fetchOptions.FetchRelations;
					if (list3 == null)
					{
						num2 = 30;
						continue;
					}
					goto IL_09b1;
				case 22:
					enumerator = fetchOptions.SelectColumns.GetEnumerator();
					num2 = 32;
					continue;
				case 18:
					val = Projections.ProjectionList();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 1;
					}
					continue;
				case 31:
					list2 = new List<string>();
					num2 = 10;
					continue;
				case 38:
					if (fetchOptions.UseProjections)
					{
						num = 17;
						break;
					}
					goto case 24;
				case 5:
				case 19:
					criteria.AddProjection((IProjection)(object)val);
					num = 11;
					break;
				case 23:
				case 42:
					type = entityType;
					if ((object)type == null)
					{
						num2 = 26;
						continue;
					}
					goto IL_0990;
				case 40:
					if (entityMetadata.AllowCreateHeirs)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 5;
				case 41:
					if (fetchOptions.SelectColumns != null)
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 35;
				case 15:
					FetchOptionsBuilder.ResolveFetchColumns(criteria, list.ToList(), (SelectMode)1);
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 10;
					}
					continue;
				default:
					val.Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A8E62)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE12A891));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					criteria.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(entityType));
					num2 = 36;
					continue;
				case 13:
					return;
				case 33:
					return;
				case 27:
					FetchOptionsBuilder.ResolveFetchColumns(criteria, list2.ToList(), selectMode, usingAlias: true);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 8;
					}
					continue;
				case 3:
					if (fetchOptions.MaxResults <= 0)
					{
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 42;
						}
						continue;
					}
					goto case 37;
				case 21:
					obj = MetadataLoader.LoadMetadata(entityType) as EntityMetadata;
					goto IL_09d3;
				case 34:
					if (!(entityType == ImplementationType))
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 28;
				case 14:
					if (entityType == null)
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 28;
						}
						continue;
					}
					goto case 34;
				case 32:
					try
					{
						while (true)
						{
							int num6;
							if (!enumerator.MoveNext())
							{
								num6 = 17;
								goto IL_0649;
							}
							goto IL_07dc;
							IL_0649:
							while (true)
							{
								string text;
								switch (num6)
								{
								case 9:
									text = current2;
									goto IL_0884;
								case 3:
								{
									GetRealProjection(array2, entityType, out customProj2, out alias2, out realMetadata2, out var _, out propertyName2);
									num6 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
									{
										num6 = 7;
									}
									continue;
								}
								case 1:
								case 10:
								case 11:
									break;
								case 6:
									val.Add((IProjection)(object)Projections.Property(text2), current2);
									num6 = 14;
									continue;
								case 15:
									array2 = current2.Split(new char[1] { ':' }, StringSplitOptions.RemoveEmptyEntries);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
									{
										num6 = 0;
									}
									continue;
								case 16:
									alias2 = null;
									num6 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
									{
										num6 = 18;
									}
									continue;
								case 18:
									propertyName2 = "";
									num6 = 3;
									continue;
								default:
									if (array2.Length == 3)
									{
										num6 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
										{
											num6 = 5;
										}
										continue;
									}
									goto case 8;
								case 5:
									customProj2 = null;
									num6 = 16;
									continue;
								case 8:
									if (current2 == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C537A9D))
									{
										num6 = 13;
										continue;
									}
									goto case 9;
								case 12:
									goto IL_07dc;
								case 4:
									val.Add((IProjection)(object)customProj2, alias2);
									num6 = 2;
									continue;
								case 14:
									AddFetchColumnIfNeeded(entityMetadata, list, list2, current2);
									num6 = 11;
									continue;
								case 7:
									if (customProj2 == null)
									{
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
										{
											num6 = 1;
										}
										continue;
									}
									goto case 4;
								case 2:
									AddFetchColumnIfNeeded(realMetadata2 ?? entityMetadata, list, list2, propertyName2);
									num6 = 10;
									continue;
								case 13:
									text = GetTypeUidPropertyName(entityType);
									goto IL_0884;
								case 17:
									goto end_IL_06d8;
									IL_0884:
									text2 = text;
									num6 = 6;
									continue;
								}
								break;
							}
							continue;
							IL_07dc:
							current2 = enumerator.Current;
							num6 = 15;
							goto IL_0649;
							continue;
							end_IL_06d8:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 6;
				case 39:
					if (!fetchOptions.UseProjections)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 18;
				case 37:
					criteria = criteria.SetMaxResults(fetchOptions.MaxResults);
					num2 = 23;
					continue;
				case 16:
				case 20:
					enumerator = fetchOptions.SelectColumns.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 1;
					}
					continue;
				case 26:
					type = ImplementationType;
					goto IL_0990;
				case 30:
					list3 = new List<string>();
					goto IL_09b1;
				case 28:
					obj = ImplementationTypeMetadata;
					goto IL_09d3;
				case 6:
					if (fetchOptions.SelectColumns.FirstOrDefault((string c) => c.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4D70AD), StringComparison.OrdinalIgnoreCase)) != null)
					{
						num2 = 9;
						continue;
					}
					goto default;
				case 2:
				case 9:
					if (fetchOptions.SelectColumns.FirstOrDefault((string c) => c.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A81FBD6), StringComparison.OrdinalIgnoreCase)) != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 40;
				case 25:
					{
						num3 = 6;
						goto IL_0a71;
					}
					IL_0a71:
					selectMode = (SelectMode)num3;
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 17;
					}
					continue;
					IL_0990:
					entityType = type;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 5;
					}
					continue;
					IL_09d3:
					entityMetadata = (EntityMetadata)obj;
					num = 41;
					break;
					IL_09b1:
					list = list3;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			}
		}
	}

	private void GetRealProjection(string[] names, Type entityType, out CustomPropertyProjection customProj, out string alias, out EntityMetadata realMetadata, out EntityPropertyMetadata realPropertyMetadata, out string propertyName)
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
				GetRealProjection(names[2], names[0], entityType, out customProj, out alias, out realMetadata, out realPropertyMetadata, out propertyName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void GetRealProjection(string columnName, string entityName, Type entityType, out CustomPropertyProjection customProj, out string alias, out EntityMetadata realMetadata, out EntityPropertyMetadata realPropertyMetadata, out string propertyName)
	{
		//Discarded unreachable code: IL_00c9
		int num = 4;
		string realProperty = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					alias = CustomPropertyProjection.GetStringFromExpression(columnName, entityName);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 7;
					}
					continue;
				case 4:
					break;
				case 7:
					customProj = NHQueryExtensions.PropertyProjection(entityType, entityName, columnName, forOrder: false, out realProperty, out realMetadata, out realPropertyMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (customProj != null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 6:
					return;
				default:
					alias = CustomPropertyProjection.GetStringFromExpression(realProperty, entityName);
					num2 = 2;
					continue;
				case 5:
					if (!columnName.Equals(realProperty, StringComparison.OrdinalIgnoreCase))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 2:
					return;
				case 8:
					if (string.IsNullOrEmpty(realProperty))
					{
						num2 = 6;
						continue;
					}
					goto case 5;
				}
				break;
			}
			propertyName = columnName;
			num = 3;
		}
	}

	private void AddFetchColumnIfNeeded(EntityMetadata metadata, IEnumerable<string> globalFetchColumns, List<string> fetchColumns, string col)
	{
		_003C_003Ec__DisplayClass135_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass135_0();
		CS_0024_003C_003E8__locals0.col = col;
		string text = CS_0024_003C_003E8__locals0.col;
		if (text.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63ABBE2C)))
		{
			text = text.Split(new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A66CDB) }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
		}
		if (FetchOptionsBuilder.IsRefTypeColumn(metadata, text) && globalFetchColumns.All((string c) => c != CS_0024_003C_003E8__locals0.col))
		{
			fetchColumns.Add(CS_0024_003C_003E8__locals0.col);
		}
	}

	[Auditable]
	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0124, IL_01cc, IL_0321, IL_0352, IL_0389, IL_0398, IL_03ab, IL_03ba, IL_0414, IL_0423, IL_0458, IL_0536, IL_0570
		int num = 30;
		_003C_003Ec__DisplayClass136_1 _003C_003Ec__DisplayClass136_ = default(_003C_003Ec__DisplayClass136_1);
		FilterForAttribute attribute = default(FilterForAttribute);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		bool flag = default(bool);
		_003C_003Ec__DisplayClass136_0 _003C_003Ec__DisplayClass136_2 = default(_003C_003Ec__DisplayClass136_0);
		Type fetchType = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object obj2;
				switch (num2)
				{
				case 1:
					if (!(_003C_003Ec__DisplayClass136_.metadataGr.IsGroupPropertyUid != Guid.Empty))
					{
						num2 = 23;
						continue;
					}
					obj = _003C_003Ec__DisplayClass136_.metadataGr.Properties.FirstOrDefault(_003C_003Ec__DisplayClass136_._003CSetupFilter_003Eb__1);
					break;
				case 26:
					if (attribute == null)
					{
						num2 = 20;
						continue;
					}
					goto case 4;
				case 14:
					if (propertyMetadata == null)
					{
						num2 = 42;
						continue;
					}
					goto case 5;
				case 8:
					if (propertyMetadata2 == null)
					{
						num2 = 35;
						continue;
					}
					goto case 41;
				case 36:
					return;
				case 11:
					if (!string.IsNullOrWhiteSpace(filter.Query))
					{
						num2 = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					return;
				case 9:
					attribute = AttributeHelper<FilterForAttribute>.GetAttribute(filter.GetType(), inherited: true);
					num2 = 26;
					continue;
				case 17:
					criteria.Add((ICriterion)(object)Restrictions.IdEq(filter.Id));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 2;
					}
					continue;
				case 45:
					flag = true;
					num2 = 34;
					continue;
				case 41:
					criteria.Add((ICriterion)(object)Restrictions.Eq(propertyMetadata2.Name, (object)true));
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 21;
					}
					continue;
				case 4:
					if (!attribute.EntityType.IsAssignableFrom(ImplementationType))
					{
						num2 = 46;
						continue;
					}
					goto case 37;
				default:
					if (_003C_003Ec__DisplayClass136_2.metadata.Hierarchical)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 7;
				case 13:
					return;
				case 44:
					if (_003C_003Ec__DisplayClass136_.metadataGr.HierarchyType == HierarchyType.GroupAndElements)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 23;
				case 39:
					if (_003C_003Ec__DisplayClass136_2.metadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 7;
				case 30:
					Contract.ArgumentNotNull(criteria, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1766062388));
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 7;
					}
					continue;
				case 24:
					SetupFastSearchFilter(criteria, filter);
					num2 = 43;
					continue;
				case 29:
					if (filter != null)
					{
						if (filter.Id == null)
						{
							num2 = 10;
							continue;
						}
						goto case 17;
					}
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 11;
					}
					continue;
				case 12:
					_003C_003Ec__DisplayClass136_2 = new _003C_003Ec__DisplayClass136_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 16;
					}
					continue;
				case 23:
					obj = null;
					break;
				case 15:
				case 21:
				case 35:
					if (string.IsNullOrEmpty(filter.SearchString))
					{
						num2 = 31;
						continue;
					}
					goto case 24;
				case 2:
				case 10:
					fetchType = GetFetchType(filter);
					num2 = 28;
					continue;
				case 18:
					if (!(_003C_003Ec__DisplayClass136_2.metadata.ParentPropertyUid != Guid.Empty))
					{
						num2 = 7;
						continue;
					}
					obj2 = _003C_003Ec__DisplayClass136_2.metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass136_2._003CSetupFilter_003Eb__0);
					goto IL_05e4;
				case 3:
				case 6:
				case 42:
					if (!filter.ShowOnlyGroups)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 32;
				case 27:
					if (ImplementationTypeMetadata == null)
					{
						return;
					}
					num2 = 40;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 36;
					}
					continue;
				case 37:
					SetupAutoFilter(criteria, filter);
					num2 = 45;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 9;
					}
					continue;
				case 32:
					_003C_003Ec__DisplayClass136_ = new _003C_003Ec__DisplayClass136_1();
					num2 = 38;
					continue;
				case 19:
					if (_003C_003Ec__DisplayClass136_.metadataGr != null)
					{
						num2 = 33;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 23;
				case 33:
					if (_003C_003Ec__DisplayClass136_.metadataGr.Hierarchical)
					{
						num2 = 44;
						continue;
					}
					goto case 23;
				case 31:
				case 43:
					flag = false;
					num2 = 25;
					continue;
				case 40:
					SetupFilterQuery(criteria, filter, ImplementationTypeMetadata);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					continue;
				case 28:
					if (!filter.FilterByHierarchyParent)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 12;
				case 20:
				case 22:
				case 34:
				case 46:
					if (flag)
					{
						return;
					}
					num2 = 11;
					continue;
				case 25:
					if (filter.DisableAutoFilter)
					{
						goto end_IL_0012;
					}
					goto case 9;
				case 7:
					obj2 = null;
					goto IL_05e4;
				case 16:
					_003C_003Ec__DisplayClass136_2.metadata = ((fetchType == ImplementationType) ? ImplementationTypeMetadata : (MetadataLoader.LoadMetadata(fetchType) as EntityMetadata));
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 39;
					}
					continue;
				case 5:
					criteria.Add((ICriterion)((filter.HierarchyParent != null) ? ((object)Restrictions.Eq(propertyMetadata.Name, filter.HierarchyParent)) : ((object)Restrictions.IsNull(propertyMetadata.Name))));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 2;
					}
					continue;
				case 38:
					{
						_003C_003Ec__DisplayClass136_.metadataGr = ((fetchType == ImplementationType) ? ImplementationTypeMetadata : (MetadataLoader.LoadMetadata(fetchType) as EntityMetadata));
						num2 = 19;
						continue;
					}
					IL_05e4:
					propertyMetadata = (PropertyMetadata)obj2;
					num2 = 14;
					continue;
				}
				propertyMetadata2 = (PropertyMetadata)obj;
				num2 = 8;
				continue;
				end_IL_0012:
				break;
			}
			num = 22;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use SetupFilterQuery(ICriteria, IEntityFilter, EntityMetadata, alias) instead", true)]
	protected virtual void SetupFilterQuery(ICriteria criteria, string query)
	{
		//Discarded unreachable code: IL_0066, IL_0075
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				return;
			default:
				SetupFilterQuery(criteria, new Filter
				{
					Query = query
				}, ImplementationTypeMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (ImplementationTypeMetadata == null)
				{
					num2 = 2;
					break;
				}
				goto default;
			}
		}
	}

	[Auditable]
	protected virtual Type GetTypeForFastSearch(IEntityFilter filter)
	{
		return ImplementationType;
	}

	[Auditable]
	protected virtual List<EntityPropertyMetadata> GetPropertiesForFastSearch(EntityMetadata metadata, IEntityFilter filter)
	{
		return (from p in MetadataLoader.GetChildProperties(metadata)
			select p.Key).OfType<EntityPropertyMetadata>().Where(delegate(EntityPropertyMetadata p)
		{
			//Discarded unreachable code: IL_0085, IL_0094
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (p.TypeUid == StringDescriptor.UID)
					{
						return true;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					if (!p.InFastSearch)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto default;
				case 1:
					return p.TypeUid == TextDescriptor.UID;
				case 2:
					return false;
				}
			}
		}).ToList();
	}

	[Auditable]
	protected virtual void SetupFastSearchFilter(ICriteria criteria, IEntityFilter filter)
	{
		int num = 1;
		Disjunction val = default(Disjunction);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					val = Restrictions.Disjunction();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				case 2:
					break;
				default:
					SetupFastSearchFilter(val, filter, criteria);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			criteria.Add((ICriterion)(object)val);
			num = 3;
		}
	}

	[Auditable]
	protected virtual void SetupFastSearchFilter(Disjunction disjunction, IEntityFilter filter, ICriteria criteria)
	{
		//Discarded unreachable code: IL_018e, IL_019d, IL_0317, IL_0326, IL_035a, IL_0369, IL_03db, IL_0410, IL_041f, IL_042f, IL_04be, IL_055d, IL_056c, IL_05a3, IL_05b6, IL_05c5, IL_05d5, IL_0607, IL_0616, IL_0626, IL_0635
		int num = 17;
		string[] array = default(string[]);
		Conjunction val2 = default(Conjunction);
		AbstractCriterion val = default(AbstractCriterion);
		EntityMetadata entityMetadata = default(EntityMetadata);
		string[] array2 = default(string[]);
		List<EntityPropertyMetadata>.Enumerator enumerator = default(List<EntityPropertyMetadata>.Enumerator);
		EntityPropertyMetadata current = default(EntityPropertyMetadata);
		EntityMetadata realMetadata = default(EntityMetadata);
		CustomPropertyProjection customProj = default(CustomPropertyProjection);
		_003C_003Ec__DisplayClass141_0 _003C_003Ec__DisplayClass141_ = default(_003C_003Ec__DisplayClass141_0);
		string value = default(string);
		Type typeByUid = default(Type);
		KeyValuePair<PropertyMetadata, ClassMetadata> keyValuePair = default(KeyValuePair<PropertyMetadata, ClassMetadata>);
		IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>> source = default(IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>>);
		List<KeyValuePair<PropertyMetadata, ClassMetadata>> childProperties = default(List<KeyValuePair<PropertyMetadata, ClassMetadata>>);
		List<EntityPropertyMetadata> propertiesForFastSearch = default(List<EntityPropertyMetadata>);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 22:
					return;
				case 12:
					array = filter.SearchString.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740352778).ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					return;
				case 16:
					((Junction)disjunction).Add((ICriterion)(object)val2);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					if (val2 == null)
					{
						num = 3;
						break;
					}
					goto case 4;
				case 19:
					if (val != null)
					{
						num2 = 7;
						continue;
					}
					goto case 3;
				case 4:
					((Junction)val2).Add((ICriterion)(object)val);
					num2 = 10;
					continue;
				case 2:
					entityMetadata = MetadataLoader.LoadMetadata(GetTypeForFastSearch(filter)) as EntityMetadata;
					num = 15;
					break;
				case 5:
					val = null;
					num2 = 21;
					continue;
				case 11:
					if (array.Length != 0)
					{
						array2 = array;
						num2 = 18;
					}
					else
					{
						num2 = 22;
					}
					continue;
				case 9:
					try
					{
						while (true)
						{
							IL_04c8:
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
								{
									num4 = 0;
								}
								goto IL_01ac;
							}
							goto IL_0265;
							IL_0265:
							current = enumerator.Current;
							num4 = 14;
							goto IL_01ac;
							IL_01ac:
							while (true)
							{
								int num5;
								switch (num4)
								{
								case 3:
									if (!(entityMetadata.Uid == realMetadata.Uid))
									{
										num5 = 22;
										goto IL_01a8;
									}
									goto case 17;
								case 12:
									if (customProj == null)
									{
										num4 = 8;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
										{
											num4 = 23;
										}
										continue;
									}
									goto case 3;
								case 15:
									break;
								case 18:
									val = ElmaRestrictions.InsensitiveLike(AliasProperty(_003C_003Ec__DisplayClass141_.prop.Name), value, MatchMode.Anywhere);
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
									{
										num4 = 2;
									}
									continue;
								default:
									val |= ElmaRestrictions.InsensitiveLike((IProjection)(object)customProj, value, MatchMode.Anywhere);
									num4 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
									{
										num4 = 5;
									}
									continue;
								case 22:
								case 24:
									if (val == null)
									{
										num4 = 6;
										continue;
									}
									goto default;
								case 6:
								case 19:
									val = ElmaRestrictions.InsensitiveLike((IProjection)(object)customProj, value, MatchMode.Anywhere);
									num5 = 4;
									goto IL_01a8;
								case 21:
									typeByUid = MetadataRuntimeService.GetTypeByUid(keyValuePair.Value.Uid);
									num4 = 10;
									continue;
								case 14:
									_003C_003Ec__DisplayClass141_ = new _003C_003Ec__DisplayClass141_0();
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
									{
										num4 = 25;
									}
									continue;
								case 11:
									val |= ElmaRestrictions.InsensitiveLike(AliasProperty(_003C_003Ec__DisplayClass141_.prop.Name), value, MatchMode.Anywhere);
									num4 = 16;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
									{
										num4 = 16;
									}
									continue;
								case 8:
									if (source.Any())
									{
										num4 = 14;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
										{
											num4 = 20;
										}
										continue;
									}
									goto IL_04c8;
								case 17:
								case 23:
									if (val != null)
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
										{
											num4 = 11;
										}
										continue;
									}
									goto case 18;
								case 10:
								{
									GetRealProjection(keyValuePair.Key.Name, keyValuePair.Value.FullTypeName, typeByUid, out customProj, out var _, out realMetadata, out var _, out var _);
									num4 = 12;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
									{
										num4 = 5;
									}
									continue;
								}
								case 20:
									keyValuePair = source.First();
									num5 = 21;
									goto IL_01a8;
								case 2:
								case 4:
								case 7:
								case 9:
								case 16:
									goto IL_04c8;
								case 25:
									_003C_003Ec__DisplayClass141_.prop = current;
									num4 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
									{
										num4 = 13;
									}
									continue;
								case 13:
									if (childProperties.Any(_003C_003Ec__DisplayClass141_._003CSetupFastSearchFilter_003Eb__0))
									{
										num4 = 9;
										continue;
									}
									goto case 1;
								case 1:
									source = childProperties.Where(_003C_003Ec__DisplayClass141_._003CSetupFastSearchFilter_003Eb__1);
									num5 = 8;
									goto IL_01a8;
								case 5:
									goto end_IL_04c8;
									IL_01a8:
									num4 = num5;
									continue;
								}
								break;
							}
							goto IL_0265;
							continue;
							end_IL_04c8:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 19;
				case 21:
					enumerator = propertiesForFastSearch.GetEnumerator();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 7;
					}
					continue;
				case 15:
					if (entityMetadata != null)
					{
						childProperties = MetadataLoader.GetChildProperties(entityMetadata);
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num2 = 20;
						}
					}
					else
					{
						num2 = 6;
					}
					continue;
				case 1:
				case 13:
					value = array2[num3];
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 5;
					}
					continue;
				case 17:
					val2 = Restrictions.Conjunction();
					num2 = 16;
					continue;
				case 8:
				case 14:
					if (num3 >= array2.Length)
					{
						return;
					}
					num2 = 13;
					continue;
				case 3:
				case 10:
					num3++;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 8;
					}
					continue;
				case 18:
					num3 = 0;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 1;
					}
					continue;
				case 20:
					propertiesForFastSearch = GetPropertiesForFastSearch(entityMetadata, filter);
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	protected virtual void SetupAutoFilter(ICriteria criteria, IEntityFilter filter)
	{
		int num = 2;
		int num2 = num;
		EntityMetadata implementationTypeMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (implementationTypeMetadata == null)
				{
					num2 = 3;
					break;
				}
				SetupAutoFilter(criteria, filter, implementationTypeMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				implementationTypeMetadata = ImplementationTypeMetadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 3:
				return;
			}
		}
	}

	protected virtual void SetupAutoFilter(ICriteria criteria, IEntityFilter filter, EntityMetadata metadata, string alias = null)
	{
		//Discarded unreachable code: IL_00ed, IL_00f7, IL_0191, IL_01f2, IL_0201, IL_0211, IL_0255, IL_03a4, IL_03dc, IL_03eb
		int num = 7;
		IEnumerator<EntityPropertyMetadata> enumerator = default(IEnumerator<EntityPropertyMetadata>);
		PropertyInfo reflectionProperty = default(PropertyInfo);
		EntityPropertyMetadata current = default(EntityPropertyMetadata);
		IFilterableType filterableType = default(IFilterableType);
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		object value = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					Contract.ServiceNotNull(MetadataRuntimeService, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477343280));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					Contract.ArgumentNotNull(criteria, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341B65B3));
					num2 = 6;
					continue;
				default:
					enumerator = metadata.Properties.OfType<EntityPropertyMetadata>().GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					Contract.ArgumentNotNull(filter, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A25FF5));
					num2 = 2;
					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_02a8:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 8;
								goto IL_00fb;
							}
							goto IL_025f;
							IL_00fb:
							while (true)
							{
								switch (num3)
								{
								case 14:
									reflectionProperty = filter.GetType().GetReflectionProperty(current.Name);
									num3 = 10;
									continue;
								case 13:
									if (filterableType == null)
									{
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto case 12;
								case 6:
									if (!current.Filterable)
									{
										num3 = 2;
										continue;
									}
									goto case 14;
								case 11:
									if (typeDescriptor == null)
									{
										num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
										{
											num3 = 2;
										}
										continue;
									}
									goto case 16;
								case 10:
									if (!(reflectionProperty == null))
									{
										num3 = 4;
										continue;
									}
									goto IL_02a8;
								case 17:
									typeDescriptor = MetadataRuntimeService.GetTypeDescriptor(current.TypeUid, current.SubTypeUid);
									num3 = 11;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
									{
										num3 = 4;
									}
									continue;
								case 7:
									break;
								case 4:
									if (!reflectionProperty.IsDefined(typeof(PropertyAttribute), inherit: true))
									{
										num3 = 17;
										continue;
									}
									goto IL_02a8;
								case 12:
									value = reflectionProperty.GetValue(filter, null);
									num3 = 9;
									continue;
								default:
									goto IL_02a8;
								case 16:
									if (typeDescriptor.GetFilterType(current, metadata) == Guid.Empty)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 15;
								case 15:
									filterableType = (IFilterableType)MetadataRuntimeService.GetTypeDescriptor(typeDescriptor.GetFilterType(current, metadata), current.SubTypeUid);
									num3 = 13;
									continue;
								case 9:
									filterableType.ApplyFilterValue(criteria, metadata, current, value, string.IsNullOrEmpty(alias) ? ((criteria is DetachedCriteriaAdapter) ? criteria.get_Alias() : DefaultCriteriaAlias) : alias);
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
									{
										num3 = 4;
									}
									continue;
								case 8:
									goto end_IL_02a8;
								}
								break;
							}
							goto IL_025f;
							IL_025f:
							current = enumerator.Current;
							num3 = 6;
							goto IL_00fb;
							continue;
							end_IL_02a8:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									enumerator.Dispose();
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
									{
										num4 = 0;
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
				case 2:
					Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA50902));
					num = 5;
					break;
				case 3:
					if (!string.IsNullOrWhiteSpace(filter.Query))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 4;
						}
						continue;
					}
					return;
				case 8:
					return;
				case 4:
					SetupFilterQuery(criteria, filter, metadata, (!string.IsNullOrEmpty(alias)) ? alias : ((criteria is DetachedCriteriaAdapter) ? criteria.get_Alias() : DefaultCriteriaAlias));
					num = 8;
					break;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use SetupFilterQuery(ICriteria, IEntityFilter, EntityMetadata, alias) instead", true)]
	protected virtual void SetupFilterQuery(ICriteria criteria, string query, EntityMetadata metadata, string alias)
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
				SetupFilterQuery(criteria, new Filter
				{
					Query = query
				}, metadata, null, alias);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use SetupFilterQuery(ICriteria, IEntityFilter, EntityMetadata, Func, alias) instead", true)]
	protected virtual void SetupFilterQuery(ICriteria criteria, string query, EntityMetadata metadata, Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc, string alias)
	{
		SetupFilterQuery(criteria, new Filter
		{
			Query = query
		}, metadata, propertyCriterionFunc, alias);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use SetupFilterQuery(ICriteria, IEntityFilter, EntityMetadata, Func, alias) instead", true)]
	protected virtual void SetupFilterQuery(ICriteria criteria, string query, EntityMetadata metadata, Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc, IEntityFilter filter, string alias)
	{
		SetupFilterQuery(criteria, filter, metadata, propertyCriterionFunc, alias);
	}

	protected void SetupFilterQuery(ICriteria criteria, IEntityFilter filter, EntityMetadata metadata, string alias = null)
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
				SetupFilterQuery(criteria, filter, metadata, null, alias);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual void SetupFilterQuery(ICriteria criteria, IEntityFilter filter, EntityMetadata metadata, Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc, string alias = null)
	{
		try
		{
			Logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53F93CF4) + filter.Query);
			criteria.AddEQLQuery(filter.Query, metadata, filter.QueryParameters, alias, propertyCriterionFunc);
		}
		catch (Exception exception)
		{
			Logger.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957612524), exception);
			throw;
		}
	}

	[NotNull]
	protected virtual ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions, bool cacheble)
	{
		ICollection<T> collection = FindByIndex(filter, fetchOptions);
		if (collection != null)
		{
			return collection;
		}
		ICriteria val = CreateCriteria(fetchOptions, GetFetchType(filter), null, filter);
		if (cacheble)
		{
			val = val.SetCacheable(true).SetCacheRegion(ImplementationType.FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210522183));
		}
		SetupFilter(val, filter);
		if (fetchOptions != null && !string.IsNullOrEmpty(fetchOptions.QueryKey))
		{
			foreach (IFindCriteriaExtender findCriteriaExtender in FindCriteriaExtenders)
			{
				if (findCriteriaExtender.QueryKey == fetchOptions.QueryKey)
				{
					findCriteriaExtender.Extend(filter, val, fetchOptions);
				}
			}
		}
		return Find(val);
	}

	[NotNull]
	protected ICollection<IdT> FindIds(IEntityFilter filter, FetchOptions fetchOptions, bool cacheble)
	{
		ICriteria val = CreateCriteria(fetchOptions, GetFetchType(filter), null, filter);
		if (cacheble)
		{
			val = val.SetCacheable(true);
		}
		SetupFilter(val, filter);
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Id() });
		return val.List<IdT>();
	}

	protected virtual string AliasProperty(string property)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!string.IsNullOrEmpty(DefaultCriteriaAlias))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return property;
			default:
				return string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C94D7B6), DefaultCriteriaAlias, property);
			}
		}
	}

	public virtual string GetAliasedPropertyString(string property)
	{
		return AliasProperty(property);
	}

	[Auditable]
	protected internal virtual ICriteria CreateCriteria(FetchOptions fetchOptions, Type type, string alias = null, IEntityFilter filter = null)
	{
		//Discarded unreachable code: IL_0063, IL_007a, IL_0084, IL_0119, IL_0128, IL_0133, IL_01b3, IL_01f3, IL_0202, IL_020e, IL_024c
		int num = 1;
		int num2 = num;
		Type type2 = default(Type);
		IEnumerator<IEntityManagerBehavior> enumerator = default(IEnumerator<IEntityManagerBehavior>);
		ICriteria val = default(ICriteria);
		while (true)
		{
			ICriteria obj;
			Type type3;
			switch (num2)
			{
			case 10:
				obj = base.Session.CreateCriteria(type2, alias);
				break;
			case 5:
				obj = base.Session.CreateCriteria(type2);
				break;
			case 2:
			case 4:
				enumerator = Behaviors.GetEnumerator();
				num2 = 8;
				continue;
			case 1:
				type3 = type;
				if ((object)type3 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_025f;
			case 3:
				if (!(fetchOptions != null))
				{
					num2 = 4;
					continue;
				}
				goto case 11;
			case 11:
				SetupFetchOptions(val, fetchOptions, type2);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 2;
				}
				continue;
			case 9:
				SetDisctinctRoot(val);
				num2 = 3;
				continue;
			case 8:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
							{
								num3 = 0;
							}
							goto IL_0137;
						}
						goto IL_0173;
						IL_0173:
						enumerator.Current.OnCreateCriteria(val, filter);
						num3 = 2;
						goto IL_0137;
						IL_0137:
						switch (num3)
						{
						case 2:
							break;
						case 1:
							goto IL_0173;
						default:
							return val;
						case 0:
							return val;
						}
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num4 = 0;
						}
						goto IL_01b7;
					}
					goto IL_01cd;
					IL_01cd:
					enumerator.Dispose();
					num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num4 = 0;
					}
					goto IL_01b7;
					IL_01b7:
					switch (num4)
					{
					default:
						goto end_IL_0192;
					case 1:
						break;
					case 0:
						goto end_IL_0192;
					case 2:
						goto end_IL_0192;
					}
					goto IL_01cd;
					end_IL_0192:;
				}
			case 6:
				if (string.IsNullOrEmpty(alias))
				{
					if (!string.IsNullOrEmpty(DefaultCriteriaAlias))
					{
						num2 = 7;
						continue;
					}
					goto case 5;
				}
				num2 = 10;
				continue;
			case 12:
				return val;
			default:
				type3 = ImplementationType;
				goto IL_025f;
			case 7:
				{
					obj = base.Session.CreateCriteria(type2, DefaultCriteriaAlias);
					break;
				}
				IL_025f:
				type2 = type3;
				num2 = 6;
				continue;
			}
			val = obj;
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
			{
				num2 = 9;
			}
		}
	}

	public override DetachedCriteria CreateDetachedCriteria(FetchOptions fetchOptions, Type type, string alias = null, IEntityFilter filter = null)
	{
		//Discarded unreachable code: IL_003d, IL_0055, IL_00a5, IL_00af, IL_00be
		int num = 5;
		DetachedCriteria val = default(DetachedCriteria);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				DetachedCriteria obj;
				switch (num2)
				{
				case 2:
					return val;
				case 6:
					obj = DetachedCriteria.For(type);
					break;
				case 5:
					if (string.IsNullOrEmpty(alias))
					{
						num2 = 4;
						continue;
					}
					goto case 1;
				case 4:
					if (!string.IsNullOrEmpty(DefaultCriteriaAlias))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 1:
					obj = DetachedCriteria.For(type, alias);
					break;
				case 3:
					goto end_IL_0012;
				default:
					obj = DetachedCriteria.For(type, DefaultCriteriaAlias);
					break;
				}
				val = obj;
				num2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			FilterDetachedCriteria(val, fetchOptions, type, filter);
			num = 2;
		}
	}

	public override void FilterDetachedCriteria(DetachedCriteria detachedCriteria, FetchOptions fetchOptions, Type type, IEntityFilter filter = null)
	{
		//Discarded unreachable code: IL_0046, IL_0055, IL_0060, IL_00df, IL_0117, IL_0126
		int num = 6;
		IEnumerator<IEntityManagerBehavior> enumerator = default(IEnumerator<IEntityManagerBehavior>);
		ICriteria val = default(ICriteria);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								goto IL_0064;
							}
							goto IL_007a;
							IL_0064:
							switch (num3)
							{
							case 1:
								break;
							default:
								continue;
							case 2:
								goto end_IL_00a3;
							}
							goto IL_007a;
							IL_007a:
							enumerator.Current.OnCreateCriteria(val, null);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num3 = 0;
							}
							goto IL_0064;
							continue;
							end_IL_00a3:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									enumerator.Dispose();
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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
					goto case 7;
				case 6:
					val = (ICriteria)(object)new DetachedCriteriaAdapter(detachedCriteria, base.Session, type);
					num2 = 5;
					continue;
				case 5:
					SetDisctinctRoot(val);
					num2 = 8;
					continue;
				case 0:
					return;
				case 3:
					break;
				case 2:
					enumerator = Behaviors.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					if (filter == null)
					{
						return;
					}
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					if (fetchOptions != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 2;
				case 4:
					SetupFilter(val, filter);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			SetupFetchOptions(val, fetchOptions, type);
			num = 2;
		}
	}

	protected internal ICriteria CreateCriteria(IEntityFilter filter = null)
	{
		return CreateCriteria(null, GetFetchType(null), null, filter);
	}

	protected long ReturnCount(ICriteria criteria)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (criteria == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 1;
					}
					break;
				}
				criteria.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Count((IProjection)(object)Projections.Id()) });
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Convert.ToInt64(criteria.UniqueResult());
			case 1:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309822374));
			}
		}
	}

	protected bool ReturnExists(ICriteria criteria)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return criteria.UniqueResult() != null;
				case 1:
					if (criteria == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					criteria.SetMaxResults(1);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					break;
				default:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x5488956C));
				}
				break;
			}
			criteria.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Id() });
			num = 3;
		}
	}

	protected IList<PT> ReturnProjection<PT>(ICriteria criteria, string propertyName)
	{
		if (criteria == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3ED498));
		}
		return criteria.SetProjection((IProjection[])(object)new IProjection[1] { Projections.Distinct((IProjection)(object)Projections.Property(propertyName)) }).List<PT>();
	}

	protected ProjectionList GetProjectionProperties<TProjection>()
	{
		PropertyInfo[] reflectionProperties = typeof(TProjection).GetReflectionProperties();
		ProjectionList val = Projections.ProjectionList();
		PropertyInfo[] array = reflectionProperties;
		foreach (PropertyInfo propertyInfo in array)
		{
			val.Add((IProjection)(object)Projections.Property(propertyInfo.Name), propertyInfo.Name);
		}
		return val;
	}

	protected virtual T LoadByUid(Guid uid)
	{
		return LoadByUid(uid, null);
	}

	internal T LoadByUid(Guid uid, string[] fetchColumns)
	{
		if (!hasUidProperty.HasValue)
		{
			InitUidPropertyMetadata();
		}
		if (!hasUidProperty.HasValue || !hasUidProperty.Value || uidPropertyMetadata == null)
		{
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123711766), ImplementationType.FullName));
		}
		T val = TryLoadByCache(uid);
		if (val != null && !val.Equals(default(T)))
		{
			return val;
		}
		ICriteria val2 = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(uidPropertyMetadata.Name, (object)uid)).SetCacheable(CacheEnabled);
		if (fetchColumns != null)
		{
			FetchOptionsBuilder.ResolveFetchColumns(val2, fetchColumns, (SelectMode)1);
		}
		else
		{
			val2.SetMaxResults(1);
		}
		val = val2.UniqueResult<T>();
		if (val == null)
		{
			val = GetContextObject(uid);
		}
		if (val != null)
		{
			NHibernateUtil.Initialize((object)val);
			try
			{
				foreach (IEntityManagerBehavior behavior in Behaviors)
				{
					behavior.OnLoad(val);
				}
				if (CanCache(val))
				{
					MemoryCache.Set(GetCacheKeyByUid(uid), val.Id, GetCacheItemPolicy());
					return val;
				}
				return val;
			}
			catch (ObjectIsDeletedException)
			{
				return (T)(object)null;
			}
		}
		return val;
	}

	private T TryLoadByCache(Guid uid)
	{
		T result = default(T);
		object obj = MemoryCache.Get(GetCacheKeyByUid(uid));
		if (obj != null && obj is IdT)
		{
			return LoadOrNull((IdT)obj);
		}
		return result;
	}

	private static string GetCacheKeyByUid(Guid uid)
	{
		return uid.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE3AD87));
	}

	protected PropertyProjection ProjectionFor<TValue>(Expression<Func<T, TValue>> expression)
	{
		if (expression == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87336589));
		}
		return Projections.Property(((expression.Body as MemberExpression) ?? throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDE997A))).Member.Name);
	}

	protected virtual bool CreateOnLoad(IdT id)
	{
		if (IsTablePart)
		{
			return id as long? < 0;
		}
		return false;
	}

	protected string GetTypeUidPropertyName(IEntityFilter filter)
	{
		int num = 1;
		int num2 = num;
		Type fetchType = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				return GetTypeUidPropertyName(fetchType);
			case 1:
				fetchType = GetFetchType(filter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected string GetTypeUidPropertyName(Type entityType)
	{
		//Discarded unreachable code: IL_003b, IL_004a
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return EntityTypeUidPropertyName;
			case 1:
				return NHibernateHelper.GetCriteriaTypeUidPropertyName(entityType);
			case 2:
				if (entityType != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal T GetContextObject(IdT id)
	{
		string name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459366359) + typeof(T).AssemblyQualifiedName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76EE3A4) + id;
		if (ContextService == null || !ContextService.TryGetValue<T>(name, out var value))
		{
			return (T)(object)null;
		}
		return value;
	}

	internal T GetContextObject(Guid uid)
	{
		string name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42670F0B) + typeof(T).AssemblyQualifiedName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3270342) + uid;
		if (ContextService == null || !ContextService.TryGetValue<T>(name, out var value))
		{
			return (T)(object)null;
		}
		return value;
	}

	private long? CountByIndex(IEntityFilter filter)
	{
		try
		{
			if (filter != null)
			{
				IModuleFullTextSearchExtension extensionByFilter = FullTextSearchCardService.GetExtensionByFilter(filter);
				if (extensionByFilter != null && !IndexQueueManager.ContainIndexingVisualData())
				{
					Type cardTypeByFilter = FullTextSearchCardService.GetCardTypeByFilter(filter);
					if (cardTypeByFilter != null && FullTextSearchService.IndexingIsWorking() && !IndexQueueManager.HasIndexAllReIndexByTypeQueue())
					{
						Type typeForFastSearch = GetTypeForFastSearch(filter);
						EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(typeForFastSearch);
						if (typeForFastSearch == null || entityMetadata != null)
						{
							FullTextSearchResultModel fullTextSearchResultModel = extensionByFilter.CreateResultModelByFilter(filter);
							if (fullTextSearchResultModel != null && UniversalFilterSaver.Pack(filter) is SerializableFilter filterFields)
							{
								FullTextSearchResultModel fullTextSearchResultModel2 = FullTextSearchService.Count(cardTypeByFilter, fullTextSearchResultModel, filter, filterFields);
								if (fullTextSearchResultModel2 != null)
								{
									return fullTextSearchResultModel2.CountAllResult;
								}
							}
						}
					}
				}
			}
		}
		catch (FullTextFilterException ex)
		{
			IndexLog.Warn(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE2465B), ex.Message), ex);
		}
		catch (Exception ex2)
		{
			IndexLog.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853042848), ex2.Message), ex2);
		}
		return null;
	}

	private ICollection<T> FindByIndex(IEntityFilter filter, FetchOptions fetchOptions)
	{
		try
		{
			if (filter != null && fetchOptions != null)
			{
				IModuleFullTextSearchExtension extensionByFilter = FullTextSearchCardService.GetExtensionByFilter(filter);
				if (extensionByFilter != null && !IndexQueueManager.ContainIndexingVisualData())
				{
					Type cardTypeByFilter = FullTextSearchCardService.GetCardTypeByFilter(filter);
					if (cardTypeByFilter != null && FullTextSearchService.IndexingIsWorking() && !IndexQueueManager.HasIndexAllReIndexByTypeQueue())
					{
						bool flag = fetchOptions.UseProjections && fetchOptions.SelectColumns != null;
						bool flag2 = !fetchOptions.UseProjections;
						if (flag || flag2)
						{
							Type typeForFastSearch = GetTypeForFastSearch(filter);
							EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(typeForFastSearch);
							if (typeForFastSearch == null || entityMetadata != null)
							{
								FullTextSearchResultModel fullTextSearchResultModel = extensionByFilter.CreateResultModelByFilter(filter);
								if (fullTextSearchResultModel != null && UniversalFilterSaver.Pack(filter) is SerializableFilter filterFields)
								{
									List<Guid> list = null;
									if (flag)
									{
										foreach (string selectColumn in fetchOptions.SelectColumns)
										{
											string[] array = selectColumn.Split(':');
											if (array.Count() != 3)
											{
												continue;
											}
											GetRealProjection(array, typeForFastSearch, out var _, out var _, out var _, out var realPropertyMetadata, out var _);
											if (realPropertyMetadata != null)
											{
												if (list == null)
												{
													list = new List<Guid>();
												}
												list.Add(realPropertyMetadata.Uid);
											}
										}
									}
									if (flag2)
									{
										list = new List<Guid>();
									}
									if (list != null)
									{
										FullTextSearchResultModel fullTextSearchResultModel2 = FullTextSearchService.Find(cardTypeByFilter, fullTextSearchResultModel, filter, filterFields, list, fetchOptions.FirstResult, fetchOptions.MaxResults, fetchOptions.SortExpression, fetchOptions.SortDirection);
										if (fullTextSearchResultModel2 != null)
										{
											if (flag)
											{
												List<IEntity> list2 = FullTextSearchCardService.ReconstructEntities(cardTypeByFilter, fullTextSearchResultModel2);
												if (list2 != null)
												{
													return new Collection<T>(list2.Cast<T>().ToList());
												}
											}
											if (flag2)
											{
												List<long> idArray = FullTextSearchCardService.GetIdArray(fullTextSearchResultModel2.Items);
												if (idArray != null)
												{
													return FindByIdArray(idArray.Cast<IdT>().ToArray());
												}
											}
											IndexLog.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECD6EAC), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859085245)), flag ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099549939) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29187241)));
										}
									}
								}
							}
						}
					}
				}
			}
		}
		catch (FullTextFilterException ex)
		{
			IndexLog.Warn(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867878200), ex.Message), ex);
		}
		catch (Exception ex2)
		{
			IndexLog.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x746A0BA), ex2.Message), ex2);
		}
		return null;
	}

	private void InitUidPropertyMetadata()
	{
		//Discarded unreachable code: IL_00d7
		int num = 5;
		PropertyMetadata uidProperty = default(PropertyMetadata);
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 7:
					uidPropertyMetadata = uidProperty;
					num2 = 9;
					break;
				case 1:
					if (!hasUidProperty.Value)
					{
						return;
					}
					goto end_IL_0012;
				case 9:
					return;
				case 10:
					hasUidProperty = false;
					num2 = 3;
					break;
				case 3:
					return;
				case 8:
					uidProperty = classMetadata.GetUidProperty();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 2;
					}
					break;
				case 0:
					return;
				case 4:
					if (!hasUidProperty.HasValue)
					{
						classMetadata = MetadataLoader.LoadMetadata(ImplementationType) as ClassMetadata;
						num2 = 6;
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					if (classMetadata == null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 8;
				case 5:
					if (uidPropertyMetadata != null)
					{
						return;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					hasUidProperty = uidProperty != null && uidProperty.TypeUid == GuidDescriptor.UID;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	internal void AddContextObject(T obj)
	{
		if (ContextService != null)
		{
			if (!obj.GetId().Equals(default(IdT)))
			{
				string name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811973306) + typeof(T).AssemblyQualifiedName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138213038) + obj.Id;
				ContextService.Set(name, obj);
			}
			Guid? guid = InternalGetUid(obj);
			if (guid.HasValue && guid.Value != Guid.Empty)
			{
				string name2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307DA2D9) + typeof(T).AssemblyQualifiedName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A6C7E7) + guid.Value;
				ContextService.Set(name2, obj);
			}
		}
	}

	internal void RemoveFromContextObject(T obj)
	{
		if (ContextService != null)
		{
			if (!obj.GetId().Equals(default(IdT)))
			{
				string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4F4621) + typeof(T).AssemblyQualifiedName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECD6420) + obj.Id;
				ContextService.Remove(key);
			}
			Guid? guid = InternalGetUid(obj);
			if (guid.HasValue && guid.Value != Guid.Empty)
			{
				string key2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AEF1D0) + typeof(T).AssemblyQualifiedName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A30C316) + guid.Value;
				ContextService.Remove(key2);
			}
		}
	}

	private void InternalSetUid(Guid uid, T res)
	{
		InitUidPropertyMetadata();
		PropertyInfo reflectionProperty = res.GetType().GetReflectionProperty(uidPropertyMetadata.Name);
		if (reflectionProperty != null)
		{
			reflectionProperty.SetValue(res, uid, null);
		}
	}

	private Guid? InternalGetUid(T res)
	{
		InitUidPropertyMetadata();
		if (uidPropertyMetadata == null)
		{
			return null;
		}
		return (Guid?)res.GetType().GetReflectionProperty(uidPropertyMetadata.Name).GetValue(res, null);
	}

	protected Type GetFetchType(IEntityFilter filter)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return ImplementationType;
			case 1:
				if (filter != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			default:
				if (!(filter.Subtype == null))
				{
					return InterfaceActivator.TypeOf(filter.Subtype);
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected static void SetDisctinctRoot(ICriteria criteria)
	{
		//Discarded unreachable code: IL_0094
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (criteria != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A25FE9));
			default:
				criteria.SetResultTransformer(CriteriaSpecification.DistinctRootEntity);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	private bool objectDeletion(T obj)
	{
		EntityEntry entry = base.Session.GetSessionImplementation().get_PersistenceContext().GetEntry((object)obj);
		if (entry == null)
		{
			return false;
		}
		object[] loadedState = entry.get_LoadedState();
		int num = entry.get_Persister().get_PropertyNames().IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811913052));
		int num2 = entry.get_Persister().get_PropertyNames().IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51163CE5));
		if (num < 0 && num2 < 0)
		{
			return false;
		}
		bool flag = (bool)loadedState[num];
		bool flag2 = (bool)loadedState[num2];
		if ((object)obj is ISoftDeletable softDeletable)
		{
			if (flag == softDeletable.IsDeleted)
			{
				return flag2 != softDeletable.HardDelete;
			}
			return true;
		}
		return false;
	}

	private bool ChangeAccess(T obj)
	{
		_003C_003Ec__DisplayClass200_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass200_0();
		CS_0024_003C_003E8__locals0.dirtyProperties = GetDirtyPropertyUids(obj);
		if (CS_0024_003C_003E8__locals0.dirtyProperties.Length != 1)
		{
			return false;
		}
		string key = string.Concat(GetType(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A8286A4), CS_0024_003C_003E8__locals0.dirtyProperties[0]);
		if (MemoryCacheService.TryGetValue<bool>(key, out var result))
		{
			return result;
		}
		CS_0024_003C_003E8__locals0.objType = obj.GetType();
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals0.objType);
		if (classMetadata == null)
		{
			return false;
		}
		PropertyMetadata propertyMetadata = classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == CS_0024_003C_003E8__locals0.dirtyProperties[0]);
		if (propertyMetadata == null)
		{
			return false;
		}
		CS_0024_003C_003E8__locals0.setting = propertyMetadata.Settings as EntitySettings;
		if (CS_0024_003C_003E8__locals0.setting == null || CS_0024_003C_003E8__locals0.setting.RelationType != RelationType.OneToMany)
		{
			return false;
		}
		ClassMetadata classMetadata2 = (ClassMetadata)MetadataLoader.LoadMetadata(propertyMetadata.SubTypeUid);
		CS_0024_003C_003E8__locals0.permissionType = MetadataRuntimeService.GetTypeByUid(classMetadata2.Uid);
		CS_0024_003C_003E8__locals0.keyProperty = classMetadata2.Properties.FirstOrDefault((PropertyMetadata x) => x.Uid == CS_0024_003C_003E8__locals0.setting.KeyColumnUid);
		bool flag = ComponentManager.Current.GetExtensionPoints<IInstanceSettingsPermission>(useCache: false).Any(delegate(IInstanceSettingsPermission x)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (x.TargetPropetyName == CS_0024_003C_003E8__locals0.keyProperty.Name)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_006f;
				default:
					return CS_0024_003C_003E8__locals0.permissionType.IsInheritOrSame(x.PermissionHolderType);
				case 2:
					{
						if (CS_0024_003C_003E8__locals0.objType.IsInheritOrSame(x.EntityType))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_006f;
					}
					IL_006f:
					return false;
				}
			}
		});
		MemoryCacheService.Insert(key, flag);
		return flag;
	}

	private long GetSubElementCountOfHierarchicalEntity(T obj, EntityMetadata entitymetadata)
	{
		Contract.ArgumentNotNull(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1E4090));
		Contract.ArgumentNotNull(entitymetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD7DF9E));
		ISoftDeletable softDeletable = obj as ISoftDeletable;
		string tableName = entitymetadata.TableName;
		string text = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978536871), Transformation.Dialect.QuoteIfNeeded(tableName), Transformation.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A9F0A)), (softDeletable != null) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837874721), Transformation.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87483235))) : string.Empty);
		return Convert.ToInt64(((IQuery)base.Session.CreateSQLQuery(text)).SetParameter<IdT>(0, obj.Id).CleanUpCache(cleanUpCache: false).UniqueResult());
	}

	protected virtual CacheItemPolicy GetCacheItemPolicy()
	{
		return DefaultCacheItemPolicy;
	}

	private static void SetDefaultCacheItemPolicy()
	{
		int num = 2;
		int num2 = num;
		int result = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (result <= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 3;
			case 3:
				DefaultCacheItemPolicy = new CacheItemPolicy
				{
					SlidingExpiration = TimeSpan.FromMinutes(result)
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (int.TryParse(SR.GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12472318), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576145368)), out result))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 4:
				break;
			case 0:
				return;
			}
			result = 10;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
			{
				num2 = 3;
			}
		}
	}

	internal static bool FjYnSBhvu35tuEgdiJyX()
	{
		return uNnDhfhvZuDlpgSRtlRK == null;
	}

	internal static object CeDyDPhvIpkGfB8Fe9y3()
	{
		return uNnDhfhvZuDlpgSRtlRK;
	}
}

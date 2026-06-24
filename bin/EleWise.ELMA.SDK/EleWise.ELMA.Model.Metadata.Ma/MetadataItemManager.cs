using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Publication;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Managers;

public class MetadataItemManager : EntityManager<IMetadataItem, long>
{
	private class PublishResultResolver : IMetadataPublishFinishedEventHandler, IEventHandler
	{
		private static object zxeHJ6CJrY6G0j5fjZbE;

		public MetadataPublishResult PublishResult
		{
			[CompilerGenerated]
			get
			{
				return _003CPublishResult_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
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
						_003CPublishResult_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public void PublishExecuted(MetadataPublishedEventArgs e)
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
					PublishResult = e.PublishResult;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public PublishResultResolver()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			vh2eRDCJjjPkpEekYNtC();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool gBfbFiCJgDy32PIrDWvg()
		{
			return zxeHJ6CJrY6G0j5fjZbE == null;
		}

		internal static PublishResultResolver fc67HtCJ5McUFvLwZ46S()
		{
			return (PublishResultResolver)zxeHJ6CJrY6G0j5fjZbE;
		}

		internal static void vh2eRDCJjjPkpEekYNtC()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private class PublicationEventHandler : IPublicationEventHandler, IEventHandler
	{
		private readonly TaskCompletionSource<bool> waitPublication;

		private readonly Dictionary<Guid, Exception> completeTokens;

		private Guid token;

		internal static object UxWDRGCJYOleAcTV51El;

		public Task WaitPublication => waitPublication.Task;

		public void InitToken(Guid token)
		{
			//Discarded unreachable code: IL_006e, IL_00be, IL_0145, IL_0154, IL_0160, IL_016f, IL_017f, IL_018e
			int num = 1;
			int num2 = num;
			Dictionary<Guid, Exception> dictionary = default(Dictionary<Guid, Exception>);
			bool lockTaken = default(bool);
			Exception value = default(Exception);
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 6:
					return;
				case 1:
					this.token = token;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					try
					{
						Monitor.Enter(dictionary, ref lockTaken);
						int num3 = 3;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								return;
							case 3:
								if (!completeTokens.TryGetValue(token, out value))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							case 2:
								break;
							}
							Error(token, value);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
							{
								num3 = 1;
							}
						}
					}
					finally
					{
						int num5;
						if (!lockTaken)
						{
							int num4 = 2;
							num5 = num4;
							goto IL_0109;
						}
						goto IL_011f;
						IL_0109:
						switch (num5)
						{
						default:
							goto end_IL_00f0;
						case 1:
							break;
						case 2:
							goto end_IL_00f0;
						case 0:
							goto end_IL_00f0;
						}
						goto IL_011f;
						IL_011f:
						Y0cpv1CJciJvKd1WNEsL(dictionary);
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num5 = 0;
						}
						goto IL_0109;
						end_IL_00f0:;
					}
				case 3:
					dictionary = completeTokens;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 2;
					}
					break;
				default:
					if (!DoX8K2CJsf7tQbw86jcg(token, Guid.Empty))
					{
						num2 = 4;
						break;
					}
					goto case 3;
				case 2:
					lockTaken = false;
					num2 = 5;
					break;
				}
			}
		}

		public void Complete(Guid publicationToken)
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
					Error(publicationToken, null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public void Error(Guid publicationToken, Exception exception)
		{
			//Discarded unreachable code: IL_00e6, IL_0191, IL_01a0, IL_01f1, IL_0214, IL_0223, IL_029a, IL_02b9, IL_02e5, IL_02f4
			int num = 14;
			bool lockTaken = default(bool);
			Dictionary<Guid, Exception> dictionary = default(Dictionary<Guid, Exception>);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 8:
					case 12:
						waitPublication.SetException(exception);
						num2 = 3;
						break;
					case 3:
						return;
					case 6:
						waitPublication.SetResult(result: true);
						num2 = 4;
						break;
					case 9:
						if (!(exception is MetadataValidationException))
						{
							num2 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num2 = 10;
							}
							break;
						}
						goto case 8;
					case 5:
						if (!(exception is InvalidOperationException))
						{
							num2 = 9;
							break;
						}
						goto case 8;
					case 2:
						if (exception is MetadataPublishingException)
						{
							num2 = 12;
							break;
						}
						goto case 5;
					case 11:
						lockTaken = false;
						num2 = 7;
						break;
					default:
						if (exception == null)
						{
							goto end_IL_0012;
						}
						goto case 2;
					case 10:
						exception = new InvalidOperationException((string)MdNvwiC9FNArSYPd9arR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A04F1F)), exception);
						num2 = 8;
						break;
					case 14:
						if (token == Guid.Empty)
						{
							num2 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
							{
								num2 = 2;
							}
							break;
						}
						goto case 1;
					case 1:
						if (IZVI60CJzLKchtKbDsk4(publicationToken, token))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
							{
								num2 = 0;
							}
							break;
						}
						return;
					case 4:
						return;
					case 13:
						dictionary = completeTokens;
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num2 = 5;
						}
						break;
					case 7:
						try
						{
							Monitor.Enter(dictionary, ref lockTaken);
							int num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num3 = 1;
							}
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 0:
									return;
								case 3:
									completeTokens[publicationToken] = exception;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
									{
										num3 = 0;
									}
									continue;
								case 1:
									if (IZVI60CJzLKchtKbDsk4(token, Guid.Empty))
									{
										num3 = 3;
										continue;
									}
									break;
								case 2:
									break;
								}
								break;
							}
						}
						finally
						{
							int num4;
							if (!lockTaken)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
								{
									num4 = 0;
								}
								goto IL_029e;
							}
							goto IL_02c3;
							IL_02c3:
							Y0cpv1CJciJvKd1WNEsL(dictionary);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
							{
								num4 = 1;
							}
							goto IL_029e;
							IL_029e:
							switch (num4)
							{
							default:
								goto end_IL_0279;
							case 0:
								goto end_IL_0279;
							case 2:
								break;
							case 1:
								goto end_IL_0279;
							}
							goto IL_02c3;
							end_IL_0279:;
						}
						goto case 1;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 6;
			}
		}

		public PublicationEventHandler()
		{
			//Discarded unreachable code: IL_005c, IL_0061
			SingletonReader.JJCZtPuTvSt();
			waitPublication = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
			completeTokens = new Dictionary<Guid, Exception>();
			token = Guid.Empty;
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool DoX8K2CJsf7tQbw86jcg(Guid P_0, Guid P_1)
		{
			return P_0 != P_1;
		}

		internal static void Y0cpv1CJciJvKd1WNEsL(object P_0)
		{
			Monitor.Exit(P_0);
		}

		internal static bool CmrjmpCJLca8Jv5sagTH()
		{
			return UxWDRGCJYOleAcTV51El == null;
		}

		internal static PublicationEventHandler tJcRZ5CJUVrG4I17Lqrr()
		{
			return (PublicationEventHandler)UxWDRGCJYOleAcTV51El;
		}

		internal static bool IZVI60CJzLKchtKbDsk4(Guid P_0, Guid P_1)
		{
			return P_0 == P_1;
		}

		internal static object MdNvwiC9FNArSYPd9arR(object P_0)
		{
			return SR.T((string)P_0);
		}
	}

	internal interface IRestartRequiredMetadataUidsActor : IActorWithGuidKey, IActor
	{
		Task<(List<Guid> RestartRequired, ICollection<IRootMetadata> SoftPublished)> GetMetadata();
	}

	internal class RestartRequiredMetadataUidsActor : Actor, IRestartRequiredMetadataUidsActor, IActorWithGuidKey, IActor
	{
		private readonly MetadataItemManager metadataItemManager;

		internal static RestartRequiredMetadataUidsActor dYPJXLC9bD439FJ8pkry;

		public override TimeSpan LifeTime { get; }

		public RestartRequiredMetadataUidsActor(MetadataItemManager metadataItemManager)
		{
			//Discarded unreachable code: IL_0043, IL_0048
			SgsLkFC9EkL0FsOfdC44();
			LifeTime = sPweRtC9fOSSRP3uA3VI(1.0);
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
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
				this.metadataItemManager = metadataItemManager;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num = 0;
				}
			}
		}

		public Task<(List<Guid>, ICollection<IRootMetadata>)> GetMetadata()
		{
			return Task.FromResult((metadataItemManager.restartNeededMetadataUids ?? new List<Guid>(), metadataItemManager.softPublishedMetadata.Values));
		}

		internal static void SgsLkFC9EkL0FsOfdC44()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static TimeSpan sPweRtC9fOSSRP3uA3VI(double P_0)
		{
			return TimeSpan.FromMinutes(P_0);
		}

		internal static bool dcH42rC9hXvGjPNJqmjx()
		{
			return dYPJXLC9bD439FJ8pkry == null;
		}

		internal static RestartRequiredMetadataUidsActor lxUdWQC9GA6Qf28ekqPu()
		{
			return dYPJXLC9bD439FJ8pkry;
		}
	}

	private static IEntityMetadataDependencyService entityMetadataDependencyService;

	private List<Guid> restartNeededMetadataUids;

	private IDictionary<Guid, IRootMetadata> softPublishedMetadata;

	private IDynamicPublicationService dynamicPublicationService;

	private static ILogger publishLogger;

	internal static MetadataItemManager WpUPgPhFjOWJxVPVc3V3;

	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
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
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IMetadataSaveFinishedEventHandler MetadataSaveFinishedEventHandler
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataSaveFinishedEventHandler_003Ek__BackingField;
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
					_003CMetadataSaveFinishedEventHandler_003Ek__BackingField = value;
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

	public IMetadataItemSaveEventHandler MetadataItemSaveEventHandler
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataItemSaveEventHandler_003Ek__BackingField;
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
					_003CMetadataItemSaveEventHandler_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
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

	public IMetadataPublishFinishedEventHandler MetadataPublishFinishedEventHandler
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataPublishFinishedEventHandler_003Ek__BackingField;
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
					_003CMetadataPublishFinishedEventHandler_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
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

	public IEnumerable<IFormDependencyExtension> FormDependencyExtensions { get; set; }

	public IWorkWithFormDependeciesService WorkWithFormDependeciesService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkWithFormDependeciesService_003Ek__BackingField;
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
					_003CWorkWithFormDependeciesService_003Ek__BackingField = value;
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
	}

	public IActorModelRuntime ActorModelRuntime
	{
		[CompilerGenerated]
		get
		{
			return _003CActorModelRuntime_003Ek__BackingField;
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
					_003CActorModelRuntime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
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

	public IEventHandlerSubscribeService EventHandlerSubscribeService
	{
		[CompilerGenerated]
		get
		{
			return _003CEventHandlerSubscribeService_003Ek__BackingField;
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
					_003CEventHandlerSubscribeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ILazy<IMetadataSourceCodeCache> MetadataSourceCodeCache { get; set; }

	private static IEntityMetadataDependencyService EntityMetadataDependencyService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IEntityMetadataDependencyService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = entityMetadataDependencyService;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (entityMetadataDependencyService = Locator.GetServiceNotNull<IEntityMetadataDependencyService>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	public new static MetadataItemManager Instance => Locator.GetServiceNotNull<MetadataItemManager>();

	private IDynamicPublicationService DynamicPublicationService
	{
		get
		{
			int num = 2;
			int num2 = num;
			IDynamicPublicationService dynamicPublicationService = default(IDynamicPublicationService);
			IDynamicPublicationService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					dynamicPublicationService = (this.dynamicPublicationService = Locator.GetService<IDynamicPublicationService>());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = this.dynamicPublicationService;
					if (obj == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = dynamicPublicationService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public virtual IEnumerable<IMetadataItem> FindDraftItems()
	{
		return base.Session.CreateCriteria(InterfaceActivator.TypeOf<IMetadataItemHeader>()).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811965290)) }).List<IMetadataItem>();
	}

	[Transaction]
	public virtual void Save(IEnumerable<IMetadataItem> metadataItems)
	{
		foreach (IMetadataItem metadataItem in metadataItems)
		{
			Save(metadataItem);
		}
		MetadataSavedEventArgs e = new MetadataSavedEventArgs
		{
			SavedMetadata = metadataItems.Select((IMetadataItem i) => i.Metadata).OfType<IRootMetadata>().ToList()
		};
		MetadataSaveFinishedEventHandler.SaveExecuted(e);
	}

	public MetadataPublishResult Publish(string comment, params long[] headerIds)
	{
		return Publish(comment, null, headerIds);
	}

	public virtual MetadataPublishResult Publish(string comment, string tag, params long[] headerIds)
	{
		int num = 1;
		int num2 = num;
		TaskAwaiter<MetadataPublishResult> awaiter = default(TaskAwaiter<MetadataPublishResult>);
		while (true)
		{
			switch (num2)
			{
			default:
				return awaiter.GetResult();
			case 1:
				awaiter = PublishAsync(comment, tag, headerIds).GetAwaiter();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Task<MetadataPublishResult> PublishAsync(string comment, params long[] headerIds)
	{
		return PublishAsync(comment, null, headerIds);
	}

	[AsyncStateMachine(typeof(_003CPublishAsync_003Ed__46))]
	public virtual Task<MetadataPublishResult> PublishAsync(string comment, string tag, params long[] headerIds)
	{
		_003CPublishAsync_003Ed__46 stateMachine = default(_003CPublishAsync_003Ed__46);
		stateMachine._003C_003E4__this = this;
		stateMachine.comment = comment;
		stateMachine.tag = tag;
		stateMachine.headerIds = headerIds;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<MetadataPublishResult>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<MetadataPublishResult> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public IRootMetadata GetSoftPublishedMetadata(Guid metadataUid)
	{
		int num = 1;
		int num2 = num;
		IRootMetadata value = default(IRootMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				softPublishedMetadata.TryGetValue(metadataUid, out value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return value;
			}
		}
	}

	public List<Guid> GetRestartRequiredMetadataUids()
	{
		if (restartNeededMetadataUids == null)
		{
			if (DynamicPublicationService.Enable)
			{
				IQueryOver<AssemblyModelsMetadata, AssemblyModelsMetadata> obj = base.Session.QueryOver<AssemblyModelsMetadata>();
				ParameterExpression parameterExpression = Expression.Parameter(typeof(AssemblyModelsMetadata), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A3AF85));
				IQueryOver<AssemblyModelsMetadata, AssemblyModelsMetadata> obj2 = obj.Where(Expression.Lambda<Func<AssemblyModelsMetadata, bool>>(Expression.AndAlso(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099749581), typeof(string))), Expression.Equal(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(int)), Expression.Constant(2, typeof(int)))), new ParameterExpression[1] { parameterExpression }));
				Expression<Func<AssemblyModelsMetadata, object>>[] array = new Expression<Func<AssemblyModelsMetadata, object>>[1];
				parameterExpression = Expression.Parameter(typeof(AssemblyModelsMetadata), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x4266F989));
				array[0] = Expression.Lambda<Func<AssemblyModelsMetadata, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression });
				using MemoryStream memoryStream = ((IQueryOver<AssemblyModelsMetadata>)(object)obj2.Select(array)).SingleOrDefault<MemoryStream>();
				if (memoryStream != null)
				{
					publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123703440));
					restartNeededMetadataUids = (from md in new AssemblyModelsMetadata
						{
							MetadataStream = memoryStream
						}.RestoreMetadata()
						select _003C_003Ec.JxfJGBC9ZIytorMBdH4y(md)).ToList();
				}
				else
				{
					publishLogger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4EEC89));
					restartNeededMetadataUids = new List<Guid>();
				}
			}
			else if (RuntimeApplication.IsFirstServerInCluster)
			{
				restartNeededMetadataUids = new List<Guid>();
			}
			else
			{
				(List<Guid>, ICollection<IRootMetadata>) result = ActorModelRuntime.GetActor<IRestartRequiredMetadataUidsActor>(Guid.Empty).GetMetadata().GetAwaiter()
					.GetResult();
				(restartNeededMetadataUids, _) = result;
				result.Item2.ForEach(delegate(IRootMetadata m)
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
							softPublishedMetadata[L1dCnJhBkrsMdSMAxBxC(m)] = m;
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
				});
			}
		}
		publishLogger.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420943150), restartNeededMetadataUids.Count, GetHashCode()));
		return restartNeededMetadataUids;
	}

	[Obsolete("Not used", true)]
	public virtual ScriptModule GetModelScriptModule()
	{
		return null;
	}

	public override ExportRuleList ExportRules()
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				type = InterfaceActivator.TypeOf<IMetadataItem>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule exportRule = new ExportRule();
			gqCCy0hFUypETGZ5UV4a(exportRule, type);
			Mtnj97hFc04GtC4HA4Y0(exportRule, awSkQ8hFsFY6iYnV4Dt8(0x7C1EE318 ^ 0x7C1DFD86));
			qk7FXihFzv81eWnjFTpt(exportRule, ExportRuleType.Export);
			exportRuleList.Add(exportRule);
			ExportRule exportRule2 = new ExportRule();
			gqCCy0hFUypETGZ5UV4a(exportRule2, type);
			Mtnj97hFc04GtC4HA4Y0(exportRule2, awSkQ8hFsFY6iYnV4Dt8(0xE1229CF ^ 0xE10DF2D));
			exportRule2.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule2);
			ExportRule obj = new ExportRule
			{
				ParentType = type
			};
			Mtnj97hFc04GtC4HA4Y0(obj, awSkQ8hFsFY6iYnV4Dt8(-1317790512 ^ -1317713538));
			qk7FXihFzv81eWnjFTpt(obj, ExportRuleType.Export);
			exportRuleList.Add(obj);
			ExportRule exportRule3 = new ExportRule();
			gqCCy0hFUypETGZ5UV4a(exportRule3, type);
			exportRule3.PropertyName = (string)awSkQ8hFsFY6iYnV4Dt8(-1822890472 ^ -1822928726);
			qk7FXihFzv81eWnjFTpt(exportRule3, ExportRuleType.Export);
			exportRuleList.Add(exportRule3);
			ExportRule exportRule4 = new ExportRule();
			gqCCy0hFUypETGZ5UV4a(exportRule4, type);
			Mtnj97hFc04GtC4HA4Y0(exportRule4, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921224447));
			qk7FXihFzv81eWnjFTpt(exportRule4, ExportRuleType.Export);
			exportRuleList.Add(exportRule4);
			ExportRule obj2 = new ExportRule
			{
				ParentType = type
			};
			Mtnj97hFc04GtC4HA4Y0(obj2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218433730));
			qk7FXihFzv81eWnjFTpt(obj2, ExportRuleType.Export);
			exportRuleList.Add(obj2);
			ExportRule exportRule5 = new ExportRule();
			gqCCy0hFUypETGZ5UV4a(exportRule5, type);
			Mtnj97hFc04GtC4HA4Y0(exportRule5, awSkQ8hFsFY6iYnV4Dt8(-3333094 ^ -3323000));
			qk7FXihFzv81eWnjFTpt(exportRule5, ExportRuleType.Export);
			exportRuleList.Add(exportRule5);
			return exportRuleList;
		}
	}

	[PublicApiMember]
	public override void Save(IMetadataItem obj)
	{
		//Discarded unreachable code: IL_0147, IL_01ca, IL_020f, IL_023a
		int num = 15;
		NamedMetadata namedMetadata = default(NamedMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IFormDependencyExtension formDependencyExtension = default(IFormDependencyExtension);
		IUser currentUser = default(IUser);
		IGroupedMetadata groupedMetadata = default(IGroupedMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 29:
					((IMetadataItemHeader)jOZ9blhBhB1FZq0OooPS(obj)).DisplayName = (string)fi1L2xhBZ5QHJR4jX2ty(namedMetadata);
					num2 = 11;
					continue;
				case 1:
					namedMetadata = AuGuZxhBbW9PR9VmD94b(obj) as NamedMetadata;
					num2 = 23;
					continue;
				case 11:
					fhPkjNhBuD4bZ4oJScQi(jOZ9blhBhB1FZq0OooPS(obj), true);
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 20;
					}
					continue;
				case 3:
					BrHLjnhBGG3LHwylJxrg(obj, InterfaceActivator.Create<IMetadataItemHeader>());
					num = 2;
					break;
				case 7:
					return;
				case 12:
					entityMetadata = AuGuZxhBbW9PR9VmD94b(obj) as EntityMetadata;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 31;
					}
					continue;
				case 14:
					WlBAL2hBWQiE0bJPKVsT(obj, hiTi1VhBBI29vCcMKQ13());
					num = 21;
					break;
				case 2:
					axmHajhBfRJ2y0CHvXJc(jOZ9blhBhB1FZq0OooPS(obj), kFh1vZhBEkPvg2ho8m3L(obj));
					num2 = 13;
					continue;
				case 33:
					if (obj.Header.Current == obj)
					{
						num = 22;
						break;
					}
					return;
				case 6:
					base.Save(obj);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					if (formDependencyExtension != null)
					{
						num2 = 25;
						continue;
					}
					return;
				case 19:
					MetadataSourceCodeCache.Value.InvalidateCache(FCNqSYhBR6PuxYSk5Gle(jOZ9blhBhB1FZq0OooPS(obj)));
					num2 = 18;
					continue;
				case 26:
					Wvq0oShBvn62d3OFZiFT(jOZ9blhBhB1FZq0OooPS(obj), c0ftXqhBCNaQbBSYXF1I(namedMetadata));
					num2 = 17;
					continue;
				default:
					if (AuGuZxhBbW9PR9VmD94b(obj) is ICodeItemMetadata)
					{
						num2 = 30;
						continue;
					}
					goto case 18;
				case 5:
					DGMB20hBQeeWpxHCM7Iq(obj.Header, obj);
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 32;
					}
					continue;
				case 30:
					if (!TADi1uhBicrEqkIpPVxG(MetadataSourceCodeCache.Value))
					{
						num2 = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 19;
				case 21:
					currentUser = base.AuthenticationService.GetCurrentUser();
					num2 = 9;
					continue;
				case 18:
				case 27:
					if (WorkWithFormDependeciesService.IsActive())
					{
						return;
					}
					num2 = 12;
					continue;
				case 4:
					if (jOZ9blhBhB1FZq0OooPS(obj) == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 32;
				case 10:
					gHu650hBSMFiBdU2IPsk(MetadataItemSaveEventHandler, obj);
					num2 = 6;
					continue;
				case 28:
					return;
				case 25:
					xhBIPshBqUNQdSWexwKB(formDependencyExtension, entityMetadata);
					num2 = 33;
					continue;
				case 20:
					return;
				case 17:
					((IMetadataItemHeader)jOZ9blhBhB1FZq0OooPS(obj)).Name = (string)dCqANEhB8ZbPO9DAja84(namedMetadata);
					num2 = 29;
					continue;
				case 15:
					cIlKsyhBFSMdBVSCjGS0(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195589475));
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 11;
					}
					continue;
				case 32:
					if (namedMetadata != null)
					{
						num2 = 26;
						continue;
					}
					goto case 11;
				case 22:
					KU478NhBXnmuf2ZCq2ND(eAHtLohBKiXlqTCVvIji(), entityMetadata, obj);
					num2 = 20;
					continue;
				case 23:
					groupedMetadata = AuGuZxhBbW9PR9VmD94b(obj) as IGroupedMetadata;
					num2 = 4;
					continue;
				case 31:
					if (entityMetadata != null)
					{
						num2 = 8;
						continue;
					}
					return;
				case 9:
					obj.CreationAuthorId = ((currentUser != null) ? ((long?)tirC6VhBoOsvlHq3a58B(currentUser)) : null);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					((IMetadataItemHeader)jOZ9blhBhB1FZq0OooPS(obj)).CreationAuthorId = ((currentUser != null) ? ((long?)tirC6VhBoOsvlHq3a58B(currentUser)) : null);
					num2 = 5;
					continue;
				case 34:
					cb773ohBVcCNou2bHNr5(jOZ9blhBhB1FZq0OooPS(obj), (groupedMetadata != null && groupedMetadata.GroupId > 0) ? EntityManager<IMetadataItemGroup>.Instance.LoadOrNull(uddN3uhBIrhJbnXI989m(groupedMetadata)) : null);
					num2 = 10;
					continue;
				case 24:
					return;
				case 8:
					formDependencyExtension = FormDependencyExtensions.FirstOrDefault((IFormDependencyExtension q) => q is EntityFormDependencyExtension);
					num2 = 16;
					continue;
				}
				break;
			}
		}
	}

	internal IEnumerable<MetadataItemWithScriptModuleWrapper> GetItemsWithClientScriptModules()
	{
		return base.Session.CreateCriteria(InterfaceActivator.TypeOf<IMetadataItemHeader>()).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8330AA8), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889503170), (JoinType)1).Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A622B0E)))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875996083)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72476D18)).Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575948524)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488852133))
				.Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31317FF0)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307E2913)) })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(MetadataItemWithScriptModuleWrapper)))
			.List<MetadataItemWithScriptModuleWrapper>();
	}

	internal IEnumerable<IMetadataItem> GetItemsWithRuntimeV2()
	{
		return CreateCriteria(FetchOptions.All, base.ImplementationType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979208625)).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A595EC), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335021413), (JoinType)0, (ICriterion)(object)Restrictions.EqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309831512), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63A8BBCE))).Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571E564F))).List<IMetadataItem>();
	}

	[AsyncStateMachine(typeof(_003CPublicationStarted_003Ed__60))]
	internal Task PublicationStarted(MetadataAssemblyPublishResult result, Guid[] softPublished, Guid[] deltaPublished, IRootMetadata[] restartNeeded, Task waitPublicationTask)
	{
		int num = 6;
		int num2 = num;
		_003CPublicationStarted_003Ed__60 stateMachine = default(_003CPublicationStarted_003Ed__60);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 9:
				stateMachine._003C_003Et__builder = qC2b7OhBTGS3gl2HkGXN();
				num2 = 2;
				break;
			case 3:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 8;
				}
				break;
			default:
				return stateMachine._003C_003Et__builder.Task;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				stateMachine.restartNeeded = restartNeeded;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 10;
				}
				break;
			case 10:
				stateMachine.waitPublicationTask = waitPublicationTask;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 9;
				}
				break;
			case 5:
				stateMachine.result = result;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				stateMachine.softPublished = softPublished;
				num2 = 7;
				break;
			case 7:
				stateMachine.deltaPublished = deltaPublished;
				num2 = 4;
				break;
			}
		}
	}

	private void AddCompositeToSoftPublished(ICompositeMetadata compositeMetadata, bool add)
	{
		//Discarded unreachable code: IL_003a, IL_00ea, IL_016d, IL_01bf, IL_0223, IL_0232, IL_0242, IL_0262, IL_0281, IL_0290, IL_02bd, IL_02cc, IL_02dd
		int num = 4;
		int num2 = num;
		IEnumerator<IMetadata> enumerator = default(IEnumerator<IMetadata>);
		ICompositeMetadata compositeMetadata2 = default(ICompositeMetadata);
		IRootMetadata value = default(IRootMetadata);
		IMetadata current = default(IMetadata);
		IEnumerable<IMetadata> enumerable = default(IEnumerable<IMetadata>);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				return;
			case 5:
				try
				{
					while (true)
					{
						IL_01a4:
						int num3;
						if (!kaWC1ChB2EBtc5YfAyKZ(enumerator))
						{
							num3 = 11;
							goto IL_0048;
						}
						goto IL_00a5;
						IL_0048:
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 14:
								AddCompositeToSoftPublished(compositeMetadata2, add);
								num3 = 3;
								continue;
							case 5:
								break;
							default:
								if ((value = current as IRootMetadata) == null)
								{
									num4 = 13;
									goto IL_0044;
								}
								goto case 8;
							case 6:
								if (!publishLogger.IsTraceEnabled())
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 10;
							case 8:
								if (!add)
								{
									num3 = 7;
									continue;
								}
								goto case 12;
							case 1:
							case 13:
							case 15:
								if ((compositeMetadata2 = current as ICompositeMetadata) == null)
								{
									num3 = 2;
									continue;
								}
								goto case 14;
							case 12:
								softPublishedMetadata[L1dCnJhBkrsMdSMAxBxC(current)] = value;
								num4 = 15;
								goto IL_0044;
							case 7:
							case 9:
								softPublishedMetadata.Remove(L1dCnJhBkrsMdSMAxBxC(current));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
							case 3:
								goto IL_01a4;
							case 10:
								zsLDp7hBOUr8XYTwiEvs(publishLogger, gZZrw7hBnYmWqAg5I46J(awSkQ8hFsFY6iYnV4Dt8(-787452571 ^ -787254737), new object[4]
								{
									compositeMetadata.Uid,
									compositeMetadata,
									L1dCnJhBkrsMdSMAxBxC(current),
									current
								}));
								num3 = 4;
								continue;
							case 11:
								return;
								IL_0044:
								num3 = num4;
								continue;
							}
							break;
						}
						goto IL_00a5;
						IL_00a5:
						current = enumerator.Current;
						num3 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num3 = 6;
						}
						goto IL_0048;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 2;
						goto IL_0266;
					}
					goto IL_029b;
					IL_0266:
					switch (num5)
					{
					default:
						goto end_IL_0251;
					case 2:
						goto end_IL_0251;
					case 1:
						break;
					case 0:
						goto end_IL_0251;
					}
					goto IL_029b;
					IL_029b:
					nRMCyhhBekcCu6eeOrfb(enumerator);
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num5 = 0;
					}
					goto IL_0266;
					end_IL_0251:;
				}
			case 3:
				obj = null;
				break;
			case 2:
				if (enumerable == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					continue;
				}
				enumerator = enumerable.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 5;
				}
				continue;
			case 1:
				return;
			case 0:
				return;
			case 4:
				if (compositeMetadata == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				obj = compositeMetadata.GetCompositeParts();
				break;
			}
			enumerable = (IEnumerable<IMetadata>)obj;
			num2 = 2;
		}
	}

	public MetadataItemManager()
	{
		//Discarded unreachable code: IL_003b, IL_0040
		y8d9D0hBPFIUeGBBaaK3();
		softPublishedMetadata = PublishCacheContext.CreateCache<Guid, IRootMetadata>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static MetadataItemManager()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				publishLogger = (ILogger)HVA3ojhB1Ssosc6Xo7px(awSkQ8hFsFY6iYnV4Dt8(-882126494 ^ -882323806));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				y8d9D0hBPFIUeGBBaaK3();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool Q3NCIVhFYbnV3JZ3loBf()
	{
		return WpUPgPhFjOWJxVPVc3V3 == null;
	}

	internal static MetadataItemManager SNEaMkhFLNoJQWMRk5u2()
	{
		return WpUPgPhFjOWJxVPVc3V3;
	}

	internal static void gqCCy0hFUypETGZ5UV4a(object P_0, Type value)
	{
		((ExportRule)P_0).ParentType = value;
	}

	internal static object awSkQ8hFsFY6iYnV4Dt8(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Mtnj97hFc04GtC4HA4Y0(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void qk7FXihFzv81eWnjFTpt(object P_0, ExportRuleType value)
	{
		((ExportRule)P_0).ExportRuleType = value;
	}

	internal static void cIlKsyhBFSMdBVSCjGS0(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static DateTime hiTi1VhBBI29vCcMKQ13()
	{
		return DateTime.Now;
	}

	internal static void WlBAL2hBWQiE0bJPKVsT(object P_0, DateTime value)
	{
		((IMetadataItem)P_0).CreationDate = value;
	}

	internal static object tirC6VhBoOsvlHq3a58B(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object AuGuZxhBbW9PR9VmD94b(object P_0)
	{
		return ((IMetadataItem)P_0).Metadata;
	}

	internal static object jOZ9blhBhB1FZq0OooPS(object P_0)
	{
		return ((IMetadataItem)P_0).Header;
	}

	internal static void BrHLjnhBGG3LHwylJxrg(object P_0, object P_1)
	{
		((IMetadataItem)P_0).Header = (IMetadataItemHeader)P_1;
	}

	internal static DateTime kFh1vZhBEkPvg2ho8m3L(object P_0)
	{
		return ((IMetadataItem)P_0).CreationDate;
	}

	internal static void axmHajhBfRJ2y0CHvXJc(object P_0, DateTime value)
	{
		((IMetadataItemHeader)P_0).CreationDate = value;
	}

	internal static void DGMB20hBQeeWpxHCM7Iq(object P_0, object P_1)
	{
		((IMetadataItemHeader)P_0).Current = (IMetadataItem)P_1;
	}

	internal static Guid c0ftXqhBCNaQbBSYXF1I(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void Wvq0oShBvn62d3OFZiFT(object P_0, Guid value)
	{
		((IMetadataItemHeader)P_0).Uid = value;
	}

	internal static object dCqANEhB8ZbPO9DAja84(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object fi1L2xhBZ5QHJR4jX2ty(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void fhPkjNhBuD4bZ4oJScQi(object P_0, bool value)
	{
		((IMetadataItemHeader)P_0).IsDirtyItem = value;
	}

	internal static long uddN3uhBIrhJbnXI989m(object P_0)
	{
		return ((IGroupedMetadata)P_0).GroupId;
	}

	internal static void cb773ohBVcCNou2bHNr5(object P_0, object P_1)
	{
		((IMetadataItemHeader)P_0).Group = (IMetadataItemGroup)P_1;
	}

	internal static void gHu650hBSMFiBdU2IPsk(object P_0, object P_1)
	{
		((IMetadataItemSaveEventHandler)P_0).BeforeSave((IMetadataItem)P_1);
	}

	internal static bool TADi1uhBicrEqkIpPVxG(object P_0)
	{
		return ((IMetadataSourceCodeCache)P_0).IsGlobalCacheExists();
	}

	internal static Guid FCNqSYhBR6PuxYSk5Gle(object P_0)
	{
		return ((IMetadataItemHeader)P_0).Uid;
	}

	internal static void xhBIPshBqUNQdSWexwKB(object P_0, object P_1)
	{
		((IFormDependencyExtension)P_0).GenerateNewDependencies((IMetadata)P_1);
	}

	internal static object eAHtLohBKiXlqTCVvIji()
	{
		return EntityMetadataDependencyService;
	}

	internal static void KU478NhBXnmuf2ZCq2ND(object P_0, object P_1, object P_2)
	{
		((IEntityMetadataDependencyService)P_0).CollectDependencies((EntityMetadata)P_1, (IMetadataItem)P_2);
	}

	internal static AsyncTaskMethodBuilder qC2b7OhBTGS3gl2HkGXN()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static Guid L1dCnJhBkrsMdSMAxBxC(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static object gZZrw7hBnYmWqAg5I46J(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static void zsLDp7hBOUr8XYTwiEvs(object P_0, object P_1)
	{
		((ILogger)P_0).Trace(P_1);
	}

	internal static bool kaWC1ChB2EBtc5YfAyKZ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void nRMCyhhBekcCu6eeOrfb(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void y8d9D0hBPFIUeGBBaaK3()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object HVA3ojhB1Ssosc6Xo7px(object P_0)
	{
		return EleWise.ELMA.Logging.Logger.GetLogger((string)P_0);
	}
}

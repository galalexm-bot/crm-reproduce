using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Context;

public abstract class ELMAContext : IDisposable
{
	private class ItemsDictionary : Dictionary<string, object>, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		private static object Hib5JxQAinCQJIfyehJ2;

		public object PublishCaches
		{
			[CompilerGenerated]
			get
			{
				return _003CPublishCaches_003Ek__BackingField;
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
						_003CPublishCaches_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
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

		void ICollection<KeyValuePair<string, object>>.Clear()
		{
			int num = 2;
			int num2 = num;
			object obj2 = default(object);
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 5:
				{
					ELMAContext value = CurrentContext.Value;
					if (value == null)
					{
						num2 = 3;
						continue;
					}
					obj = value.KeyObject;
					break;
				}
				case 1:
				case 8:
					Clear();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (obj2 != null)
					{
						num2 = 6;
						continue;
					}
					return;
				case 6:
					CacheGlobal.Remove(obj2);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					threadItems = null;
					num2 = 5;
					continue;
				case 4:
					return;
				case 2:
				{
					EventHandler onClear = ELMAContext.OnClear;
					if (onClear == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						oGxbfVQAXf9bclXsGyfo(onClear, yy1FrxQAKNeG4xAnTNkc(), EventArgs.Empty);
						num2 = 8;
					}
					continue;
				}
				case 3:
					obj = null;
					break;
				}
				obj2 = obj;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 6;
				}
			}
		}

		public ItemsDictionary()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			CXsiAqQATT8LMjGsh3oW();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool zDMAZvQARYvSwdpJiIn7()
		{
			return Hib5JxQAinCQJIfyehJ2 == null;
		}

		internal static ItemsDictionary IEPD28QAqrEW7uW9qkbt()
		{
			return (ItemsDictionary)Hib5JxQAinCQJIfyehJ2;
		}

		internal static object yy1FrxQAKNeG4xAnTNkc()
		{
			return Current;
		}

		internal static void oGxbfVQAXf9bclXsGyfo(object P_0, object P_1, object P_2)
		{
			P_0(P_1, (EventArgs)P_2);
		}

		internal static void CXsiAqQATT8LMjGsh3oW()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private class EmptyDisposable : IDisposable
	{
		internal static object IAtOTuQAkYx6HTgPtgtG;

		void IDisposable.Dispose()
		{
		}

		public EmptyDisposable()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			CFWOocQA2H0bpsupdIlO();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void CFWOocQA2H0bpsupdIlO()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool mnQlsZQAnWrXV1bQQ1jj()
		{
			return IAtOTuQAkYx6HTgPtgtG == null;
		}

		internal static EmptyDisposable JatTLZQAOAJZqQGpQO95()
		{
			return (EmptyDisposable)IAtOTuQAkYx6HTgPtgtG;
		}
	}

	private class SynchronizationContextELMAContext : ELMAContext
	{
		private class InternalSynchronizationContext : SynchronizationContext
		{
			private readonly object taskScheduler;

			private static object JxuVD3Z8qX1wlcRmC6Xc;

			public override void Post(SendOrPostCallback d, object state)
			{
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						if (taskScheduler == TaskScheduler.Default)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num2 = 1;
							}
							break;
						}
						new Task(PostCallback, (d, state)).Start((TaskScheduler)taskScheduler);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						return;
					case 1:
						qIG71lZ8TTX8HQuT9SLl(this, new SendOrPostCallback(PostCallback), (d, state));
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 3;
						}
						break;
					case 0:
						return;
					}
				}
			}

			private void PostCallback(object state)
			{
				int num = 3;
				int num2 = num;
				(SendOrPostCallback, object) tuple = default((SendOrPostCallback, object));
				while (true)
				{
					switch (num2)
					{
					case 3:
						tuple = ((SendOrPostCallback, object))state;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 2;
						}
						break;
					case 1:
						return;
					default:
						Send(tuple.Item1, tuple.Item2);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						VY3KA4Z8kxPZp3jxoYYU(this);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			public InternalSynchronizationContext()
			{
				//Discarded unreachable code: IL_003a, IL_003f
				WZnUb6Z8nBqyrErNArTx();
				taskScheduler = exjakVZ8OakCgvZ1SQ0V();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static void qIG71lZ8TTX8HQuT9SLl(object P_0, object P_1, object P_2)
			{
				((SynchronizationContext)P_0).Post((SendOrPostCallback)P_1, P_2);
			}

			internal static bool FISvQcZ8KfsM2EnBQ2dt()
			{
				return JxuVD3Z8qX1wlcRmC6Xc == null;
			}

			internal static InternalSynchronizationContext YOPsQPZ8XlKpCC4XpfKV()
			{
				return (InternalSynchronizationContext)JxuVD3Z8qX1wlcRmC6Xc;
			}

			internal static void VY3KA4Z8kxPZp3jxoYYU(object P_0)
			{
				SynchronizationContext.SetSynchronizationContext((SynchronizationContext)P_0);
			}

			internal static void WZnUb6Z8nBqyrErNArTx()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static object exjakVZ8OakCgvZ1SQ0V()
			{
				return TaskScheduler.Current;
			}
		}

		private readonly bool clearSynchronizationContext;

		private readonly object parentSynchronizationContext;

		private readonly object currentSynchronizationContext;

		private static object cW5v2oQAeexhxYqDoYcp;

		protected override object KeyObject => GqnNFCQANpFZsH8dl7G9();

		public SynchronizationContextELMAContext(bool isolatedContext)
		{
			//Discarded unreachable code: IL_001b, IL_00be, IL_00cd, IL_0113, IL_0122
			SingletonReader.JJCZtPuTvSt();
			base._002Ector(isolatedContext);
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 4:
				case 7:
					clearSynchronizationContext = true;
					num = 2;
					continue;
				case 3:
				case 6:
					currentSynchronizationContext = GqnNFCQANpFZsH8dl7G9();
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num = 8;
					}
					continue;
				case 2:
				{
					SynchronizationContext.SetSynchronizationContext(new InternalSynchronizationContext());
					int num2 = 3;
					num = num2;
					continue;
				}
				case 5:
					if (!(GqnNFCQANpFZsH8dl7G9() == null || isolatedContext))
					{
						num = 6;
						continue;
					}
					goto case 1;
				case 8:
					return;
				case 1:
					if (!isolatedContext)
					{
						num = 4;
						continue;
					}
					break;
				}
				parentSynchronizationContext = GqnNFCQANpFZsH8dl7G9();
				num = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num = 1;
				}
			}
		}

		public override void Dispose()
		{
			int num = 7;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 5:
					base.Dispose();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return;
				case 6:
					base.Dispose();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 0;
					}
					break;
				default:
					J0ZrgjQA3wbRtQgYOK1s(parentSynchronizationContext);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 3;
					}
					break;
				case 7:
					if (!isolatedContext)
					{
						L9liXnQApHEucZJQrTau(Items);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 6;
					}
					break;
				case 2:
					if (clearSynchronizationContext)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 1:
					J0ZrgjQA3wbRtQgYOK1s(null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 5;
					}
					break;
				}
			}
		}

		protected override void SetAsCurrentInnerLogic()
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
					J0ZrgjQA3wbRtQgYOK1s(currentSynchronizationContext);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static object GqnNFCQANpFZsH8dl7G9()
		{
			return SynchronizationContext.Current;
		}

		internal static bool qBYr0fQAPWLUrScQAtx8()
		{
			return cW5v2oQAeexhxYqDoYcp == null;
		}

		internal static SynchronizationContextELMAContext sebQfQQA1MpiOvigTuPV()
		{
			return (SynchronizationContextELMAContext)cW5v2oQAeexhxYqDoYcp;
		}

		internal static void J0ZrgjQA3wbRtQgYOK1s(object P_0)
		{
			SynchronizationContext.SetSynchronizationContext((SynchronizationContext)P_0);
		}

		internal static void L9liXnQApHEucZJQrTau(object P_0)
		{
			((ICollection<KeyValuePair<string, object>>)P_0).Clear();
		}
	}

	private static readonly ConditionalWeakTable<object, IDictionary<string, object>> CacheGlobal;

	[ThreadStatic]
	private static IDictionary<string, object> threadItems;

	private static readonly AsyncLocal<ELMAContext> CurrentContext;

	private readonly bool isolatedContext;

	private readonly IDictionary<string, object> parentThreadItems;

	private readonly ELMAContext parentContext;

	private static readonly IDisposable emptyDisposable;

	internal static ELMAContext aGSsgPW2AHDQH8D1Th2f;

	protected abstract object KeyObject { get; }

	protected static ELMAContext Current => CurrentContext.Value;

	protected internal static bool Initialized
	{
		get
		{
			int num = 1;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					ELMAContext value = CurrentContext.Value;
					if (value == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = fyg8ULW2MJApwEYIGZ4h(value);
					break;
				}
				default:
					obj = null;
					break;
				}
				break;
			}
			return obj != null;
		}
	}

	protected internal static bool IsIsolated
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					ELMAContext value = CurrentContext.Value;
					if (value == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num2 = 0;
						}
						break;
					}
					return value.isolatedContext;
				}
				default:
					return false;
				}
			}
		}
	}

	protected internal static IDictionary<string, object> Items
	{
		get
		{
			if (threadItems == null)
			{
				object obj = CurrentContext.Value?.KeyObject;
				if (obj == null)
				{
					NullReferenceException ex = new NullReferenceException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103DEE87)));
					Logger.Log.Error(ex.Message + Environment.NewLine + new StackTrace(fNeedFileInfo: true));
					throw ex;
				}
				if (!CacheGlobal.TryGetValue(obj, out threadItems))
				{
					try
					{
						CacheGlobal.Add(obj, threadItems = new ItemsDictionary());
					}
					catch (ArgumentException)
					{
						if (!CacheGlobal.TryGetValue(obj, out threadItems))
						{
							throw;
						}
					}
				}
			}
			return threadItems;
		}
	}

	internal static object PublishCaches
	{
		get
		{
			return eEO3rUW2JaoWRocwEv7b((ItemsDictionary)Items);
		}
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
					kavptLW29ZuqxRiapiaA((ItemsDictionary)Items, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal static event EventHandler OnClear
	{
		[CompilerGenerated]
		add
		{
			int num = 2;
			int num2 = num;
			EventHandler eventHandler2 = default(EventHandler);
			EventHandler eventHandler = default(EventHandler);
			EventHandler value2 = default(EventHandler);
			while (true)
			{
				switch (num2)
				{
				case 2:
					eventHandler2 = ELMAContext.OnClear;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					if ((object)eventHandler2 == eventHandler)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 1;
				case 1:
					eventHandler = eventHandler2;
					num2 = 4;
					break;
				case 4:
					value2 = (EventHandler)Delegate.Combine(eventHandler, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					eventHandler2 = Interlocked.CompareExchange(ref ELMAContext.OnClear, value2, eventHandler);
					num2 = 5;
					break;
				case 3:
					return;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 4;
			int num2 = num;
			EventHandler value2 = default(EventHandler);
			EventHandler eventHandler = default(EventHandler);
			EventHandler eventHandler2 = default(EventHandler);
			while (true)
			{
				switch (num2)
				{
				case 5:
					value2 = (EventHandler)Delegate.Remove(eventHandler, value);
					num2 = 2;
					break;
				case 3:
					eventHandler = eventHandler2;
					num2 = 5;
					break;
				default:
					if ((object)eventHandler2 == eventHandler)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				case 1:
					return;
				case 4:
					eventHandler2 = ELMAContext.OnClear;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					eventHandler2 = Interlocked.CompareExchange(ref ELMAContext.OnClear, value2, eventHandler);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected ELMAContext(bool isolatedContext)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_00e4, IL_00f3
		SAJqDRW20hPB3ClKofGC();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 6:
				parentThreadItems = threadItems;
				num = 3;
				break;
			case 2:
				if (!isolatedContext)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num = 0;
					}
					break;
				}
				goto case 6;
			default:
				CurrentContext.Value = this;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			case 3:
				parentContext = CurrentContext.Value;
				num = 5;
				break;
			case 4:
				this.isolatedContext = isolatedContext;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public virtual void Dispose()
	{
		//Discarded unreachable code: IL_006e, IL_00fa, IL_0109
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 7:
				wpJk6tW2yY1blktFXXLP(this);
				num2 = 9;
				break;
			case 6:
				if (!isolatedContext)
				{
					num2 = 5;
					break;
				}
				goto default;
			case 8:
				CurrentContext.Value = parentContext;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				CurrentContext.Value = null;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 7;
				}
				break;
			case 2:
			case 5:
				if (CurrentContext.Value == this)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			case 9:
				return;
			default:
				XKmcq0W2mOBxwHXPMe4h(threadItems);
				num2 = 8;
				break;
			case 3:
				threadItems = parentThreadItems;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal void SetAsCurrent()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				CurrentContext.Value = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				SetAsCurrentInnerLogic();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (CurrentContext.Value != null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected virtual void SetAsCurrentInnerLogic()
	{
	}

	public static IDisposable Create()
	{
		return (IDisposable)c9pgkTW2dbrT1NwMC4tj(isolatedContext: false);
	}

	public static IDisposable CreateIsolated()
	{
		return (IDisposable)c9pgkTW2dbrT1NwMC4tj(isolatedContext: true);
	}

	internal static IDisposable Create(bool isolatedContext)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 3;
		int num2 = num;
		IDisposable result = default(IDisposable);
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 2:
				result = new SynchronizationContextELMAContext(isolatedContext);
				num2 = 4;
				continue;
			case 4:
				return result;
			case 3:
				if (!Initialized)
				{
					num2 = 2;
					continue;
				}
				break;
			}
			if (!isolatedContext)
			{
				break;
			}
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
			{
				num2 = 1;
			}
		}
		return emptyDisposable;
	}

	static ELMAContext()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					CacheGlobal = new ConditionalWeakTable<object, IDictionary<string, object>>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 1:
					emptyDisposable = new EmptyDisposable();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					CurrentContext = new AsyncLocal<ELMAContext>(delegate
					{
						threadItems = null;
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					break;
				}
				break;
			}
			SAJqDRW20hPB3ClKofGC();
			num = 3;
		}
	}

	internal static void SAJqDRW20hPB3ClKofGC()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool s7R7VRW27tfG2q2xpdqe()
	{
		return aGSsgPW2AHDQH8D1Th2f == null;
	}

	internal static ELMAContext aduUe3W2x4ZiNgeTb9jT()
	{
		return aGSsgPW2AHDQH8D1Th2f;
	}

	internal static void XKmcq0W2mOBxwHXPMe4h(object P_0)
	{
		((ICollection<KeyValuePair<string, object>>)P_0).Clear();
	}

	internal static void wpJk6tW2yY1blktFXXLP(object P_0)
	{
		GC.SuppressFinalize(P_0);
	}

	internal static object fyg8ULW2MJApwEYIGZ4h(object P_0)
	{
		return ((ELMAContext)P_0).KeyObject;
	}

	internal static object eEO3rUW2JaoWRocwEv7b(object P_0)
	{
		return ((ItemsDictionary)P_0).PublishCaches;
	}

	internal static void kavptLW29ZuqxRiapiaA(object P_0, object P_1)
	{
		((ItemsDictionary)P_0).PublishCaches = P_1;
	}

	internal static object c9pgkTW2dbrT1NwMC4tj(bool isolatedContext)
	{
		return Create(isolatedContext);
	}
}

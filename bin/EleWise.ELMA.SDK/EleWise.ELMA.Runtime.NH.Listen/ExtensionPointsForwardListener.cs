using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Runtime.Context;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Event;

namespace EleWise.ELMA.Runtime.NH.Listeners;

[Serializable]
internal class ExtensionPointsForwardListener : IPostInsertEventListener, IPreInsertEventListener, IPostUpdateEventListener, IPreUpdateEventListener, IPostDeleteEventListener, IPreDeleteEventListener, IPreLoadEventListener, IFlushEventListener, IAutoFlushEventListener, IFlushEntityEventListener, IPostCollectionRemoveEventListener, IPostCollectionRecreateEventListener, IPostCollectionUpdateEventListener, IPreCollectionRemoveEventListener, IPreCollectionRecreateEventListener, IPreCollectionUpdateEventListener
{
	[NonSerialized]
	private NestedScopeComponents<IEntityEventsListener> listeners;

	private static ExtensionPointsForwardListener XEQPKxWA3lYxX80yitWO;

	public Task OnAutoFlushAsync(AutoFlushEvent @event, CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}

	[AsyncStateMachine(typeof(_003COnFlushAsync_003Ed__1))]
	public Task OnFlushAsync(FlushEvent @event, CancellationToken cancellationToken)
	{
		int num = 5;
		_003COnFlushAsync_003Ed__1 stateMachine = default(_003COnFlushAsync_003Ed__1);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					stateMachine.cancellationToken = cancellationToken;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					return stateMachine._003C_003Et__builder.Task;
				case 4:
					stateMachine.@event = @event;
					num2 = 2;
					continue;
				case 6:
					break;
				default:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					stateMachine._003C_003E1__state = -1;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					stateMachine._003C_003E4__this = this;
					num2 = 4;
					continue;
				}
				break;
			}
			stateMachine._003C_003Et__builder = pobYAnWADVLpVodsckYD();
			num = 3;
		}
	}

	public Task OnFlushEntityAsync(FlushEntityEvent @event, CancellationToken cancellationToken)
	{
		return (Task)mc0GvmWAtUXKTMpR7yDd();
	}

	[AsyncStateMachine(typeof(_003COnPostDeleteAsync_003Ed__3))]
	public Task OnPostDeleteAsync(PostDeleteEvent @event, CancellationToken cancellationToken)
	{
		int num = 5;
		int num2 = num;
		_003COnPostDeleteAsync_003Ed__3 stateMachine = default(_003COnPostDeleteAsync_003Ed__3);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 7:
				stateMachine._003C_003Et__builder = pobYAnWADVLpVodsckYD();
				num2 = 6;
				break;
			case 3:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				stateMachine.@event = @event;
				num2 = 2;
				break;
			case 2:
				stateMachine.cancellationToken = cancellationToken;
				num2 = 7;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return stateMachine._003C_003Et__builder.Task;
			case 5:
				stateMachine._003C_003E4__this = this;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003COnPostInsertAsync_003Ed__4))]
	public Task OnPostInsertAsync(PostInsertEvent @event, CancellationToken cancellationToken)
	{
		int num = 4;
		_003COnPostInsertAsync_003Ed__4 stateMachine = default(_003COnPostInsertAsync_003Ed__4);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					stateMachine._003C_003Et__builder = pobYAnWADVLpVodsckYD();
					num2 = 7;
					continue;
				case 7:
					stateMachine._003C_003E1__state = -1;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					return stateMachine._003C_003Et__builder.Task;
				case 6:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					stateMachine.@event = @event;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 6;
					continue;
				case 4:
					stateMachine._003C_003E4__this = this;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
			stateMachine.cancellationToken = cancellationToken;
			num = 2;
		}
	}

	[AsyncStateMachine(typeof(_003COnPostRecreateCollectionAsync_003Ed__5))]
	public Task OnPostRecreateCollectionAsync(PostCollectionRecreateEvent @event, CancellationToken cancellationToken)
	{
		int num = 3;
		int num2 = num;
		_003COnPostRecreateCollectionAsync_003Ed__5 stateMachine = default(_003COnPostRecreateCollectionAsync_003Ed__5);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 2:
				stateMachine.@event = @event;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				stateMachine.cancellationToken = cancellationToken;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				stateMachine._003C_003E1__state = -1;
				num2 = 5;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			case 3:
				stateMachine._003C_003E4__this = this;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003COnPostRemoveCollectionAsync_003Ed__6))]
	public Task OnPostRemoveCollectionAsync(PostCollectionRemoveEvent @event, CancellationToken cancellationToken)
	{
		int num = 4;
		_003COnPostRemoveCollectionAsync_003Ed__6 stateMachine = default(_003COnPostRemoveCollectionAsync_003Ed__6);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					stateMachine._003C_003Et__builder = pobYAnWADVLpVodsckYD();
					num2 = 2;
					continue;
				case 1:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					return stateMachine._003C_003Et__builder.Task;
				case 4:
					stateMachine._003C_003E4__this = this;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					stateMachine.@event = @event;
					num2 = 6;
					continue;
				case 6:
					stateMachine.cancellationToken = cancellationToken;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				}
				break;
			}
			stateMachine._003C_003E1__state = -1;
			num = 7;
		}
	}

	[AsyncStateMachine(typeof(_003COnPostUpdateAsync_003Ed__7))]
	public Task OnPostUpdateAsync(PostUpdateEvent @event, CancellationToken cancellationToken)
	{
		int num = 1;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003COnPostUpdateAsync_003Ed__7 stateMachine = default(_003COnPostUpdateAsync_003Ed__7);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 3;
					continue;
				case 1:
					stateMachine._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					stateMachine._003C_003E1__state = -1;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					break;
				case 4:
					stateMachine._003C_003Et__builder = pobYAnWADVLpVodsckYD();
					num2 = 5;
					continue;
				default:
					stateMachine.@event = @event;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					stateMachine.cancellationToken = cancellationToken;
					num2 = 4;
					continue;
				case 7:
					return stateMachine._003C_003Et__builder.Task;
				}
				break;
			}
			_003C_003Et__builder.Start(ref stateMachine);
			num = 7;
		}
	}

	[AsyncStateMachine(typeof(_003COnPostUpdateCollectionAsync_003Ed__8))]
	public Task OnPostUpdateCollectionAsync(PostCollectionUpdateEvent @event, CancellationToken cancellationToken)
	{
		int num = 6;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003COnPostUpdateCollectionAsync_003Ed__8 stateMachine = default(_003COnPostUpdateCollectionAsync_003Ed__8);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				stateMachine.cancellationToken = cancellationToken;
				num2 = 4;
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				num2 = 5;
				break;
			case 5:
				stateMachine.@event = @event;
				num2 = 2;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			case 4:
				stateMachine._003C_003Et__builder = pobYAnWADVLpVodsckYD();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 7;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003COnPreDeleteAsync_003Ed__9))]
	public Task<bool> OnPreDeleteAsync(PreDeleteEvent @event, CancellationToken cancellationToken)
	{
		_003COnPreDeleteAsync_003Ed__9 stateMachine = default(_003COnPreDeleteAsync_003Ed__9);
		stateMachine._003C_003E4__this = this;
		stateMachine.@event = @event;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003COnPreInsertAsync_003Ed__10))]
	public Task<bool> OnPreInsertAsync(PreInsertEvent @event, CancellationToken cancellationToken)
	{
		_003COnPreInsertAsync_003Ed__10 stateMachine = default(_003COnPreInsertAsync_003Ed__10);
		stateMachine._003C_003E4__this = this;
		stateMachine.@event = @event;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public Task OnPreLoadAsync(PreLoadEvent @event, CancellationToken cancellationToken)
	{
		return (Task)mc0GvmWAtUXKTMpR7yDd();
	}

	[AsyncStateMachine(typeof(_003COnPreRecreateCollectionAsync_003Ed__12))]
	public Task OnPreRecreateCollectionAsync(PreCollectionRecreateEvent @event, CancellationToken cancellationToken)
	{
		int num = 5;
		_003COnPreRecreateCollectionAsync_003Ed__12 stateMachine = default(_003COnPreRecreateCollectionAsync_003Ed__12);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return stateMachine._003C_003Et__builder.Task;
				case 4:
					stateMachine.@event = @event;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					stateMachine._003C_003E1__state = -1;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					stateMachine._003C_003Et__builder = pobYAnWADVLpVodsckYD();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 3;
					}
					continue;
				default:
					stateMachine.cancellationToken = cancellationToken;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					break;
				case 3:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			stateMachine._003C_003E4__this = this;
			num = 4;
		}
	}

	[AsyncStateMachine(typeof(_003COnPreRemoveCollectionAsync_003Ed__13))]
	public Task OnPreRemoveCollectionAsync(PreCollectionRemoveEvent @event, CancellationToken cancellationToken)
	{
		int num = 7;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003COnPreRemoveCollectionAsync_003Ed__13 stateMachine = default(_003COnPreRemoveCollectionAsync_003Ed__13);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				case 5:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					stateMachine.@event = @event;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					stateMachine._003C_003E1__state = -1;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					stateMachine.cancellationToken = cancellationToken;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					stateMachine._003C_003E4__this = this;
					num2 = 6;
					continue;
				default:
					return stateMachine._003C_003Et__builder.Task;
				case 3:
					stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					num2 = 2;
					continue;
				}
				break;
			}
			_003C_003Et__builder = stateMachine._003C_003Et__builder;
			num = 5;
		}
	}

	[AsyncStateMachine(typeof(_003COnPreUpdateAsync_003Ed__14))]
	public Task<bool> OnPreUpdateAsync(PreUpdateEvent @event, CancellationToken cancellationToken)
	{
		_003COnPreUpdateAsync_003Ed__14 stateMachine = default(_003COnPreUpdateAsync_003Ed__14);
		stateMachine._003C_003E4__this = this;
		stateMachine.@event = @event;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003COnPreUpdateCollectionAsync_003Ed__15))]
	public Task OnPreUpdateCollectionAsync(PreCollectionUpdateEvent @event, CancellationToken cancellationToken)
	{
		int num = 7;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003COnPreUpdateCollectionAsync_003Ed__15 stateMachine = default(_003COnPreUpdateCollectionAsync_003Ed__15);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 3;
				}
				break;
			default:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				stateMachine.@event = @event;
				num2 = 3;
				break;
			case 1:
				return stateMachine._003C_003Et__builder.Task;
			case 3:
				stateMachine.cancellationToken = cancellationToken;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num2 = 2;
				break;
			case 7:
				stateMachine._003C_003E4__this = this;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private IEnumerable<IEntityEventsListener> EntityEventsListeners()
	{
		if (listeners == null)
		{
			lock (this)
			{
				if (listeners == null)
				{
					listeners = new NestedScopeComponents<IEntityEventsListener>(ServiceScope.Shell);
				}
			}
		}
		if (listeners.Available)
		{
			return listeners.Value;
		}
		return EleWise.ELMA.Helpers.EmptyArray<IEntityEventsListener>.Instance;
	}

	private static NestedSessionScope NestedSession(object session)
	{
		return new NestedSessionScope((ISession)session, "");
	}

	public void OnPreLoad(PreLoadEvent @event)
	{
	}

	public bool OnPreInsert(PreInsertEvent @event)
	{
		//Discarded unreachable code: IL_0089, IL_00c1, IL_00f9
		int num = 4;
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		NestedSessionScope nestedSessionScope = default(NestedSessionScope);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					_003C_003Ec__DisplayClass20_.veto = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					try
					{
						EntityEventsListeners().ForEach(_003C_003Ec__DisplayClass20_._003COnPreInsert_003Eb__0);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					finally
					{
						if (nestedSessionScope != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									((IDisposable)nestedSessionScope).Dispose();
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
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
					goto case 2;
				default:
					nestedSessionScope = (NestedSessionScope)heRTiAWAwLahmturwMLT(((AbstractEvent)_003C_003Ec__DisplayClass20_.@event).get_Session());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return _003C_003Ec__DisplayClass20_.veto;
				case 4:
					_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
					num2 = 3;
					continue;
				case 3:
					break;
				}
				break;
			}
			_003C_003Ec__DisplayClass20_.@event = @event;
			num = 5;
		}
	}

	public bool OnPreUpdate(PreUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00cf, IL_0107, IL_0126, IL_0135, IL_0152
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_0);
		NestedSessionScope nestedSessionScope = default(NestedSessionScope);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
				num2 = 3;
				break;
			case 5:
				_003C_003Ec__DisplayClass21_.veto = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				nestedSessionScope = (NestedSessionScope)heRTiAWAwLahmturwMLT(((AbstractEvent)_003C_003Ec__DisplayClass21_.@event).get_Session());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return _003C_003Ec__DisplayClass21_.veto;
			case 1:
				try
				{
					EntityEventsListeners().ForEach(_003C_003Ec__DisplayClass21_._003COnPreUpdate_003Eb__0);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					int num4;
					if (nestedSessionScope == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num4 = 0;
						}
						goto IL_010b;
					}
					goto IL_0140;
					IL_0140:
					VXU2B2WA4mbbvrl2iXwL(nestedSessionScope);
					num4 = 2;
					goto IL_010b;
					IL_010b:
					switch (num4)
					{
					case 1:
						goto end_IL_00e6;
					case 2:
						goto end_IL_00e6;
					}
					goto IL_0140;
					end_IL_00e6:;
				}
				goto case 2;
			case 3:
				_003C_003Ec__DisplayClass21_.@event = @event;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	public virtual bool OnPreDelete(PreDeleteEvent @event)
	{
		//Discarded unreachable code: IL_008a, IL_00b2, IL_00d1, IL_00e0, IL_010d, IL_011c
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = default(_003C_003Ec__DisplayClass22_0);
		NestedSessionScope nestedSessionScope = default(NestedSessionScope);
		while (true)
		{
			switch (num2)
			{
			case 5:
				_003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
				num2 = 4;
				break;
			case 2:
				_003C_003Ec__DisplayClass22_.veto = false;
				num2 = 3;
				break;
			default:
				try
				{
					EntityEventsListeners().ForEach(_003C_003Ec__DisplayClass22_._003COnPreDelete_003Eb__0);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					int num4;
					if (nestedSessionScope == null)
					{
						num4 = 2;
						goto IL_00b6;
					}
					goto IL_00eb;
					IL_00b6:
					switch (num4)
					{
					default:
						goto end_IL_00a1;
					case 2:
						goto end_IL_00a1;
					case 1:
						break;
					case 0:
						goto end_IL_00a1;
					}
					goto IL_00eb;
					IL_00eb:
					VXU2B2WA4mbbvrl2iXwL(nestedSessionScope);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num4 = 0;
					}
					goto IL_00b6;
					end_IL_00a1:;
				}
				goto case 1;
			case 1:
				return _003C_003Ec__DisplayClass22_.veto;
			case 4:
				_003C_003Ec__DisplayClass22_.@event = @event;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				nestedSessionScope = NestedSession(y6df2aWA66OIejtGAaL1(_003C_003Ec__DisplayClass22_.@event));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_00c4, IL_00fc, IL_0134
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = default(_003C_003Ec__DisplayClass23_0);
		NestedSessionScope nestedSessionScope = default(NestedSessionScope);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass23_.@event = @event;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				nestedSessionScope = (NestedSessionScope)heRTiAWAwLahmturwMLT(y6df2aWA66OIejtGAaL1(_003C_003Ec__DisplayClass23_.@event));
				num2 = 3;
				break;
			case 2:
				_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			case 3:
				try
				{
					EntityEventsListeners().ForEach(_003C_003Ec__DisplayClass23_._003COnPostInsert_003Eb__0);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					if (nestedSessionScope != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								((IDisposable)nestedSessionScope).Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
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
			}
		}
	}

	public virtual void OnPostUpdate(PostUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00b8, IL_00f0, IL_0128, IL_0137
		int num = 2;
		NestedSessionScope nestedSessionScope = default(NestedSessionScope);
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = default(_003C_003Ec__DisplayClass24_0);
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
					break;
				case 3:
					nestedSessionScope = (NestedSessionScope)heRTiAWAwLahmturwMLT(y6df2aWA66OIejtGAaL1(_003C_003Ec__DisplayClass24_.@event));
					num2 = 4;
					continue;
				case 0:
					return;
				case 2:
					_003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					try
					{
						EntityEventsListeners().ForEach(_003C_003Ec__DisplayClass24_._003COnPostUpdate_003Eb__0);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						if (nestedSessionScope != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									VXU2B2WA4mbbvrl2iXwL(nestedSessionScope);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
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
				break;
			}
			_003C_003Ec__DisplayClass24_.@event = @event;
			num = 3;
		}
	}

	public virtual void OnPostDelete(PostDeleteEvent @event)
	{
		//Discarded unreachable code: IL_0064, IL_00d0, IL_00df, IL_00eb, IL_00fa
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = default(_003C_003Ec__DisplayClass25_0);
		NestedSessionScope nestedSessionScope = default(NestedSessionScope);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					EntityEventsListeners().ForEach(_003C_003Ec__DisplayClass25_._003COnPostDelete_003Eb__0);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					int num5;
					if (nestedSessionScope == null)
					{
						int num4 = 2;
						num5 = num4;
						goto IL_0094;
					}
					goto IL_00aa;
					IL_0094:
					switch (num5)
					{
					default:
						goto end_IL_007b;
					case 1:
						break;
					case 2:
						goto end_IL_007b;
					case 0:
						goto end_IL_007b;
					}
					goto IL_00aa;
					IL_00aa:
					VXU2B2WA4mbbvrl2iXwL(nestedSessionScope);
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num5 = 0;
					}
					goto IL_0094;
					end_IL_007b:;
				}
			case 4:
				nestedSessionScope = (NestedSessionScope)heRTiAWAwLahmturwMLT(y6df2aWA66OIejtGAaL1(_003C_003Ec__DisplayClass25_.@event));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass25_.@event = @event;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public void OnFlush(FlushEvent @event)
	{
		//Discarded unreachable code: IL_0064, IL_009c, IL_00d4
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = default(_003C_003Ec__DisplayClass26_0);
		NestedSessionScope nestedSessionScope = default(NestedSessionScope);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 1:
				try
				{
					EntityEventsListeners().ForEach(_003C_003Ec__DisplayClass26_._003COnFlush_003Eb__0);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					if (nestedSessionScope != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								VXU2B2WA4mbbvrl2iXwL(nestedSessionScope);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
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
			case 3:
				_003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
				num2 = 2;
				break;
			default:
				nestedSessionScope = (NestedSessionScope)heRTiAWAwLahmturwMLT(y6df2aWA66OIejtGAaL1(_003C_003Ec__DisplayClass26_.@event));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass26_.@event = @event;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void OnPostRemoveCollection(PostCollectionRemoveEvent @event)
	{
		//Discarded unreachable code: IL_0085, IL_00bd, IL_00f5
		int num = 4;
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = default(_003C_003Ec__DisplayClass27_0);
		NestedSessionScope nestedSessionScope = default(NestedSessionScope);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_003C_003Ec__DisplayClass27_.@event = @event;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					try
					{
						EntityEventsListeners().ForEach(_003C_003Ec__DisplayClass27_._003COnPostRemoveCollection_003Eb__0);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						if (nestedSessionScope != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									VXU2B2WA4mbbvrl2iXwL(nestedSessionScope);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
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
				case 2:
					return;
				case 4:
					break;
				default:
					nestedSessionScope = (NestedSessionScope)heRTiAWAwLahmturwMLT(y6df2aWA66OIejtGAaL1(_003C_003Ec__DisplayClass27_.@event));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
			num = 3;
		}
	}

	public void OnPostRecreateCollection(PostCollectionRecreateEvent @event)
	{
		//Discarded unreachable code: IL_0086, IL_00be, IL_00f6, IL_0105
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = default(_003C_003Ec__DisplayClass28_0);
		NestedSessionScope nestedSessionScope = default(NestedSessionScope);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass28_.@event = @event;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				return;
			case 3:
				try
				{
					EntityEventsListeners().ForEach(_003C_003Ec__DisplayClass28_._003COnPostRecreateCollection_003Eb__0);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					if (nestedSessionScope != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								((IDisposable)nestedSessionScope).Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
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
			case 1:
				_003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				nestedSessionScope = NestedSession(((AbstractEvent)_003C_003Ec__DisplayClass28_.@event).get_Session());
				num2 = 3;
				break;
			}
		}
	}

	public void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
	{
		//Discarded unreachable code: IL_0063, IL_009b, IL_00ba, IL_00e6, IL_00f5
		int num = 4;
		_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = default(_003C_003Ec__DisplayClass29_0);
		NestedSessionScope nestedSessionScope = default(NestedSessionScope);
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
						EntityEventsListeners().ForEach(_003C_003Ec__DisplayClass29_._003COnPostUpdateCollection_003Eb__0);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						int num4;
						if (nestedSessionScope == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
							{
								num4 = 1;
							}
							goto IL_009f;
						}
						goto IL_00c4;
						IL_00c4:
						((IDisposable)nestedSessionScope).Dispose();
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num4 = 0;
						}
						goto IL_009f;
						IL_009f:
						switch (num4)
						{
						default:
							goto end_IL_007a;
						case 1:
							goto end_IL_007a;
						case 2:
							break;
						case 0:
							goto end_IL_007a;
						}
						goto IL_00c4;
						end_IL_007a:;
					}
				case 4:
					_003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
					num2 = 3;
					continue;
				case 0:
					return;
				case 2:
					nestedSessionScope = NestedSession(y6df2aWA66OIejtGAaL1(_003C_003Ec__DisplayClass29_.@event));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					break;
				}
				break;
			}
			_003C_003Ec__DisplayClass29_.@event = @event;
			num = 2;
		}
	}

	public void OnPreRemoveCollection(PreCollectionRemoveEvent @event)
	{
		//Discarded unreachable code: IL_00c4, IL_00ec, IL_012c, IL_013b, IL_0147, IL_0156
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = default(_003C_003Ec__DisplayClass30_0);
		NestedSessionScope nestedSessionScope = default(NestedSessionScope);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				_003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass30_.@event = @event;
				num2 = 4;
				break;
			case 4:
				nestedSessionScope = (NestedSessionScope)heRTiAWAwLahmturwMLT(y6df2aWA66OIejtGAaL1(_003C_003Ec__DisplayClass30_.@event));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				try
				{
					EntityEventsListeners().ForEach(_003C_003Ec__DisplayClass30_._003COnPreRemoveCollection_003Eb__0);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					int num4;
					if (nestedSessionScope == null)
					{
						num4 = 2;
						goto IL_00f0;
					}
					goto IL_0106;
					IL_00f0:
					switch (num4)
					{
					default:
						goto end_IL_00db;
					case 1:
						break;
					case 2:
						goto end_IL_00db;
					case 0:
						goto end_IL_00db;
					}
					goto IL_0106;
					IL_0106:
					((IDisposable)nestedSessionScope).Dispose();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num4 = 0;
					}
					goto IL_00f0;
					end_IL_00db:;
				}
			}
		}
	}

	public void OnPreRecreateCollection(PreCollectionRecreateEvent @event)
	{
		//Discarded unreachable code: IL_0064, IL_009c, IL_00d4, IL_00e3
		int num = 4;
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = default(_003C_003Ec__DisplayClass31_0);
		NestedSessionScope nestedSessionScope = default(NestedSessionScope);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				default:
					try
					{
						EntityEventsListeners().ForEach(_003C_003Ec__DisplayClass31_._003COnPreRecreateCollection_003Eb__0);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						if (nestedSessionScope != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									VXU2B2WA4mbbvrl2iXwL(nestedSessionScope);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
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
				case 3:
					break;
				case 2:
					nestedSessionScope = (NestedSessionScope)heRTiAWAwLahmturwMLT(((AbstractEvent)_003C_003Ec__DisplayClass31_.@event).get_Session());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
					num2 = 3;
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass31_.@event = @event;
			num = 2;
		}
	}

	public void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00b2, IL_00ea, IL_0122
		int num = 1;
		int num2 = num;
		NestedSessionScope nestedSessionScope = default(NestedSessionScope);
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = default(_003C_003Ec__DisplayClass32_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				nestedSessionScope = (NestedSessionScope)heRTiAWAwLahmturwMLT(((AbstractEvent)_003C_003Ec__DisplayClass32_.@event).get_Session());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 3;
				}
				break;
			default:
				_003C_003Ec__DisplayClass32_.@event = @event;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				try
				{
					EntityEventsListeners().ForEach(_003C_003Ec__DisplayClass32_._003COnPreUpdateCollection_003Eb__0);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					if (nestedSessionScope != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								VXU2B2WA4mbbvrl2iXwL(nestedSessionScope);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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
			case 4:
				return;
			case 1:
				_003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void OnAutoFlush(AutoFlushEvent @event)
	{
	}

	public void OnFlushEntity(FlushEntityEvent @event)
	{
	}

	public ExtensionPointsForwardListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kmFQ45WAH00Y1gwdnaHC();
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

	internal static AsyncTaskMethodBuilder pobYAnWADVLpVodsckYD()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static bool Kd8NKvWApP1dTjhGi7h3()
	{
		return XEQPKxWA3lYxX80yitWO == null;
	}

	internal static ExtensionPointsForwardListener Efwd6jWAaJKZna3OuvjM()
	{
		return XEQPKxWA3lYxX80yitWO;
	}

	internal static object mc0GvmWAtUXKTMpR7yDd()
	{
		return Task.CompletedTask;
	}

	internal static object heRTiAWAwLahmturwMLT(object P_0)
	{
		return NestedSession(P_0);
	}

	internal static void VXU2B2WA4mbbvrl2iXwL(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object y6df2aWA66OIejtGAaL1(object P_0)
	{
		return ((AbstractEvent)P_0).get_Session();
	}

	internal static void kmFQ45WAH00Y1gwdnaHC()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

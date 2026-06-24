using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class TaskExtraExtensions
{
	internal static TaskExtraExtensions mdBI3PGpYqbnKQZ5YyG7;

	public static Task IgnoreExceptions(this Task task)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return task;
			case 1:
				task.ContinueWith(delegate(Task t)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							_003C_003Ec.f4NmlS8BSgcPs18b6t18(t);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Current);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static Task<T> IgnoreExceptions<T>(this Task<T> task)
	{
		return (Task<T>)((Task)task).IgnoreExceptions();
	}

	public static void PropagateExceptions(this Task task)
	{
		//Discarded unreachable code: IL_0045, IL_0054
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				task.Wait();
				num2 = 4;
				break;
			case 2:
				throw new InvalidOperationException((string)rOSp8tGpzkpvUh6CgakS(morL7eGpcaIdMcKF19f2(-475857671 ^ -475985349)));
			default:
				if (nGnJ1xGaFqFPlt6Ock6V(task))
				{
					num2 = 3;
					break;
				}
				return;
			case 1:
				if (EJbTGVGpsyeqM2XlYJGL(task))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				return;
			}
		}
	}

	public static void PropagateExceptions(this Task[] tasks)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new InvalidOperationException((string)rOSp8tGpzkpvUh6CgakS(morL7eGpcaIdMcKF19f2(-1837662597 ^ -1837856335)));
			case 2:
				Contract.ArgumentNotNull(tasks, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70207066));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 1:
				Contract.Check<ArgumentException>(tasks.All((Task t) => t != null), (string)morL7eGpcaIdMcKF19f2(--1360331293 ^ 0x5116F589));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				if (!tasks.Any((Task t) => !t.IsCompleted))
				{
					ycpewgGaBfRswHPdDa2x(tasks);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	public static Task Then(this Task task, Action next)
	{
		return (Task)kBq5DgGaovnpLhHc7Anm(task, next, LbTmM1GaW7JZFvDd4nvk());
	}

	public static Task Then(this Task task, Action next, CancellationToken token)
	{
		int num = 1;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return _003C_003Ec__DisplayClass5_.tcs.Task;
				case 3:
					Contract.ArgumentNotNull(_003C_003Ec__DisplayClass5_.next, (string)morL7eGpcaIdMcKF19f2(0x35C0467B ^ 0x35C3BE73));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					break;
				case 4:
					APIKqAGab0DpwlGFnDHy(task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17ACD72E));
					num2 = 3;
					continue;
				case 5:
					task.ContinueWith(_003C_003Ec__DisplayClass5_._003CThen_003Eb__0, token);
					num2 = 6;
					continue;
				case 1:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					_003C_003Ec__DisplayClass5_.next = next;
					num2 = 4;
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass5_.tcs = new TaskCompletionSource<object>(TaskCreationOptions.RunContinuationsAsynchronously);
			num = 5;
		}
	}

	public static Task<TResult> Then<TResult>(this Task task, Func<TResult> next)
	{
		return task.Then(next, CancellationToken.None);
	}

	public static Task<TResult> Then<TResult>(this Task task, Func<TResult> next, CancellationToken token)
	{
		_003C_003Ec__DisplayClass7_0<TResult> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0<TResult>();
		CS_0024_003C_003E8__locals0.next = next;
		Contract.ArgumentNotNull(task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345483726));
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859102295));
		CS_0024_003C_003E8__locals0.tcs = new TaskCompletionSource<TResult>(TaskCreationOptions.RunContinuationsAsynchronously);
		task.ContinueWith(delegate(Task parentTask)
		{
			//Discarded unreachable code: IL_00ad, IL_00bc, IL_010f, IL_016e, IL_01b1, IL_01c0
			int num = 6;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					return;
				case 8:
					return;
				default:
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return;
				case 5:
					if (!parentTask.IsCanceled)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 6:
					if (!parentTask.IsFaulted)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 2;
				case 2:
					CS_0024_003C_003E8__locals0.tcs.TrySetException(parentTask.Exception.InnerExceptions);
					num2 = 4;
					continue;
				case 1:
					try
					{
						TResult result = CS_0024_003C_003E8__locals0.next();
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
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
							case 1:
								CS_0024_003C_003E8__locals0.tcs.TrySetResult(result);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}
					catch (Exception exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return;
							default:
								CS_0024_003C_003E8__locals0.tcs.TrySetException(exception);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num4 = 1;
								}
								break;
							}
						}
					}
				case 3:
					break;
				}
				CS_0024_003C_003E8__locals0.tcs.TrySetCanceled();
				num2 = 8;
			}
		}, token);
		return CS_0024_003C_003E8__locals0.tcs.Task;
	}

	public static Task Then<TResult>(this Task<TResult> task, Action<TResult> next)
	{
		return task.Then(next, CancellationToken.None);
	}

	public static Task Then<TResult>(this Task<TResult> task, Action<TResult> next, CancellationToken token)
	{
		_003C_003Ec__DisplayClass9_0<TResult> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0<TResult>();
		CS_0024_003C_003E8__locals0.next = next;
		Contract.ArgumentNotNull(task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105128940));
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53F54AB));
		CS_0024_003C_003E8__locals0.tcs = new TaskCompletionSource<object>();
		task.ContinueWith(delegate(Task<TResult> parentTask)
		{
			if (parentTask.IsFaulted)
			{
				CS_0024_003C_003E8__locals0.tcs.TrySetException(parentTask.Exception.InnerExceptions);
			}
			else
			{
				if (!parentTask.IsCanceled)
				{
					try
					{
						CS_0024_003C_003E8__locals0.next(parentTask.Result);
						CS_0024_003C_003E8__locals0.tcs.TrySetResult(null);
						return;
					}
					catch (Exception exception)
					{
						CS_0024_003C_003E8__locals0.tcs.TrySetException(exception);
						return;
					}
				}
				CS_0024_003C_003E8__locals0.tcs.TrySetCanceled();
			}
		}, token);
		return CS_0024_003C_003E8__locals0.tcs.Task;
	}

	public static Task<TNewResult> Then<TResult, TNewResult>(this Task<TResult> task, Func<TResult, TNewResult> next)
	{
		return task.Then(next, CancellationToken.None);
	}

	public static Task<TNewResult> Then<TResult, TNewResult>(this Task<TResult> task, Func<TResult, TNewResult> next, CancellationToken token)
	{
		_003C_003Ec__DisplayClass11_0<TResult, TNewResult> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0<TResult, TNewResult>();
		CS_0024_003C_003E8__locals0.next = next;
		Contract.ArgumentNotNull(task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576078766));
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6DA203));
		CS_0024_003C_003E8__locals0.tcs = new TaskCompletionSource<TNewResult>(TaskCreationOptions.RunContinuationsAsynchronously);
		task.ContinueWith(delegate(Task<TResult> parentTask)
		{
			if (parentTask.IsFaulted)
			{
				CS_0024_003C_003E8__locals0.tcs.TrySetException(parentTask.Exception.InnerExceptions);
			}
			else
			{
				if (!parentTask.IsCanceled)
				{
					try
					{
						TNewResult result = CS_0024_003C_003E8__locals0.next(parentTask.Result);
						CS_0024_003C_003E8__locals0.tcs.TrySetResult(result);
						return;
					}
					catch (Exception exception)
					{
						CS_0024_003C_003E8__locals0.tcs.TrySetException(exception);
						return;
					}
				}
				CS_0024_003C_003E8__locals0.tcs.TrySetCanceled();
			}
		}, token);
		return CS_0024_003C_003E8__locals0.tcs.Task;
	}

	public static Task Then(this Task task, Func<Task> next)
	{
		return task.Then(next, CancellationToken.None);
	}

	public static Task Then(this Task task, Func<Task> next, CancellationToken token)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals0.next = next;
		CS_0024_003C_003E8__locals0.token = token;
		Contract.ArgumentNotNull(task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870829119));
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307D67D9));
		CS_0024_003C_003E8__locals0.tcs = new TaskCompletionSource<object>(TaskCreationOptions.RunContinuationsAsynchronously);
		task.ContinueWith(delegate(Task parentTask)
		{
			//Discarded unreachable code: IL_00bd, IL_00f0, IL_0133, IL_0142, IL_0173
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					_003C_003Ec__DisplayClass13_0.mcH0B58BHkqxgtFmyxs0(CS_0024_003C_003E8__locals0.tcs);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					try
					{
						CS_0024_003C_003E8__locals0.next().ContinueWith((Task t) => CS_0024_003C_003E8__locals0.tcs.TrySetFromTask(t), CS_0024_003C_003E8__locals0.token);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
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
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 1:
								_003C_003Ec__DisplayClass13_0.oQSLmy8BAPleIr5WxfCX(CS_0024_003C_003E8__locals0.tcs, ex);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
								{
									num4 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}
				case 2:
					CS_0024_003C_003E8__locals0.tcs.TrySetException(((AggregateException)_003C_003Ec__DisplayClass13_0.X5LbbP8B4Sxqa4AThdUh(parentTask)).InnerExceptions);
					num2 = 6;
					break;
				case 6:
					return;
				case 5:
					return;
				case 1:
					return;
				default:
					num2 = 4;
					break;
				case 3:
					if (_003C_003Ec__DisplayClass13_0.SslZHy8BwEWKSpQTD5X4(parentTask))
					{
						num2 = 2;
						break;
					}
					if (!_003C_003Ec__DisplayClass13_0.k3g4eC8B6BuhhQWQIhau(parentTask))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 7;
				}
			}
		}, CS_0024_003C_003E8__locals0.token);
		return CS_0024_003C_003E8__locals0.tcs.Task;
	}

	public static Task Then<TResult>(this Task<TResult> task, Func<TResult, Task> next)
	{
		return task.Then(next, CancellationToken.None);
	}

	public static Task Then<TResult>(this Task<TResult> task, Func<TResult, Task> next, CancellationToken token)
	{
		_003C_003Ec__DisplayClass15_0<TResult> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0<TResult>();
		CS_0024_003C_003E8__locals0.next = next;
		CS_0024_003C_003E8__locals0.token = token;
		Contract.ArgumentNotNull(task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3391508));
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53C8BE43));
		CS_0024_003C_003E8__locals0.tcs = new TaskCompletionSource<object>(TaskCreationOptions.RunContinuationsAsynchronously);
		task.ContinueWith(delegate(Task<TResult> parentTask)
		{
			if (parentTask.IsFaulted)
			{
				CS_0024_003C_003E8__locals0.tcs.TrySetException(parentTask.Exception.InnerExceptions);
			}
			else
			{
				if (!parentTask.IsCanceled)
				{
					try
					{
						CS_0024_003C_003E8__locals0.next(parentTask.Result).ContinueWith((Task t) => CS_0024_003C_003E8__locals0.tcs.TrySetFromTask(t), CS_0024_003C_003E8__locals0.token);
						return;
					}
					catch (Exception exception)
					{
						CS_0024_003C_003E8__locals0.tcs.TrySetException(exception);
						return;
					}
				}
				CS_0024_003C_003E8__locals0.tcs.TrySetCanceled();
			}
		}, CS_0024_003C_003E8__locals0.token);
		return CS_0024_003C_003E8__locals0.tcs.Task;
	}

	public static Task<TResult> Then<TResult>(this Task task, Func<Task<TResult>> next)
	{
		return task.Then(next, CancellationToken.None);
	}

	public static Task<TResult> Then<TResult>(this Task task, Func<Task<TResult>> next, CancellationToken token)
	{
		_003C_003Ec__DisplayClass17_0<TResult> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0<TResult>();
		CS_0024_003C_003E8__locals0.next = next;
		CS_0024_003C_003E8__locals0.token = token;
		Contract.ArgumentNotNull(task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31337AF0));
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4F8321));
		CS_0024_003C_003E8__locals0.tcs = new TaskCompletionSource<TResult>(TaskCreationOptions.RunContinuationsAsynchronously);
		task.ContinueWith(delegate(Task parentTask)
		{
			//Discarded unreachable code: IL_0092, IL_00c5, IL_0108, IL_01a6
			int num = 7;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					try
					{
						CS_0024_003C_003E8__locals0.next().ContinueWith((Task<TResult> t) => CS_0024_003C_003E8__locals0.tcs.TrySetFromTask(t), CS_0024_003C_003E8__locals0.token);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
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
					catch (Exception exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 1:
								CS_0024_003C_003E8__locals0.tcs.TrySetException(exception);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
								{
									num4 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}
				case 5:
					return;
				case 3:
					CS_0024_003C_003E8__locals0.tcs.TrySetCanceled();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					CS_0024_003C_003E8__locals0.tcs.TrySetException(parentTask.Exception.InnerExceptions);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 7:
					if (!parentTask.IsFaulted)
					{
						num2 = 6;
						break;
					}
					goto case 2;
				case 1:
					return;
				case 6:
					num2 = (parentTask.IsCanceled ? 3 : 4);
					break;
				}
			}
		}, CS_0024_003C_003E8__locals0.token);
		return CS_0024_003C_003E8__locals0.tcs.Task;
	}

	public static Task<TNewResult> Then<TResult, TNewResult>(this Task<TResult> task, Func<TResult, Task<TNewResult>> next)
	{
		return task.Then(next, CancellationToken.None);
	}

	public static Task<TNewResult> Then<TResult, TNewResult>(this Task<TResult> task, Func<TResult, Task<TNewResult>> next, CancellationToken token)
	{
		_003C_003Ec__DisplayClass19_0<TResult, TNewResult> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0<TResult, TNewResult>();
		CS_0024_003C_003E8__locals0.task = task;
		CS_0024_003C_003E8__locals0.next = next;
		CS_0024_003C_003E8__locals0.token = token;
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675446199));
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217533647));
		CS_0024_003C_003E8__locals0.tcs = new TaskCompletionSource<TNewResult>(TaskCreationOptions.RunContinuationsAsynchronously);
		CS_0024_003C_003E8__locals0.task.ContinueWith(delegate(Task<TResult> parentTask)
		{
			if (parentTask.IsFaulted)
			{
				CS_0024_003C_003E8__locals0.tcs.TrySetException(parentTask.Exception.InnerExceptions);
			}
			else
			{
				if (!CS_0024_003C_003E8__locals0.task.IsCanceled)
				{
					try
					{
						CS_0024_003C_003E8__locals0.next(parentTask.Result).ContinueWith((Task<TNewResult> t) => CS_0024_003C_003E8__locals0.tcs.TrySetFromTask(t), CS_0024_003C_003E8__locals0.token);
						return;
					}
					catch (Exception exception)
					{
						CS_0024_003C_003E8__locals0.tcs.TrySetException(exception);
						return;
					}
				}
				CS_0024_003C_003E8__locals0.tcs.TrySetCanceled();
			}
		}, CS_0024_003C_003E8__locals0.token);
		return CS_0024_003C_003E8__locals0.tcs.Task;
	}

	internal static bool jvc7ShGpLLfc16JgHJwv()
	{
		return mdBI3PGpYqbnKQZ5YyG7 == null;
	}

	internal static TaskExtraExtensions b2Sj36GpUWbS0x1VvTtA()
	{
		return mdBI3PGpYqbnKQZ5YyG7;
	}

	internal static bool EJbTGVGpsyeqM2XlYJGL(object P_0)
	{
		return ((Task)P_0).IsCompleted;
	}

	internal static object morL7eGpcaIdMcKF19f2(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object rOSp8tGpzkpvUh6CgakS(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool nGnJ1xGaFqFPlt6Ock6V(object P_0)
	{
		return ((Task)P_0).IsFaulted;
	}

	internal static void ycpewgGaBfRswHPdDa2x(object P_0)
	{
		Task.WaitAll((Task[])P_0);
	}

	internal static CancellationToken LbTmM1GaW7JZFvDd4nvk()
	{
		return CancellationToken.None;
	}

	internal static object kBq5DgGaovnpLhHc7Anm(object P_0, object P_1, CancellationToken token)
	{
		return ((Task)P_0).Then((Action)P_1, token);
	}

	internal static void APIKqAGab0DpwlGFnDHy(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}
}

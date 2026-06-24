using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class TaskFactoryExtensions
{
	internal static TaskFactoryExtensions u6uF3HGpx6vIndwsr78w;

	public static TaskScheduler GetTargetScheduler(this TaskFactory factory)
	{
		int num = 2;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = TjlkkgGpJ2xNIev6uOs5(factory);
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				NXJ5uuGpMoxWJpYhDeQU(factory, Prdn6nGpymd6C9J7dvs0(0x3B36AB09 ^ 0x3B34A375));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				obj = gwRs6JGp93wULZs4bjUu();
				break;
			}
			break;
		}
		return (TaskScheduler)obj;
	}

	public static Task<Task[]> WhenAll(this TaskFactory factory, params Task[] tasks)
	{
		return factory.ContinueWhenAll(tasks, (Task[] completedTasks) => completedTasks);
	}

	public static Task Iterate(this TaskFactory factory, IEnumerable<object> source)
	{
		Contract.ArgumentNotNull(factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398530272));
		return factory.Iterate(source, null, factory.CancellationToken, factory.CreationOptions, factory.GetTargetScheduler());
	}

	public static Task Iterate(this TaskFactory factory, IEnumerable<object> source, CancellationToken cancellationToken)
	{
		Contract.ArgumentNotNull(factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637C21E7));
		return factory.Iterate(source, null, cancellationToken, factory.CreationOptions, factory.GetTargetScheduler());
	}

	public static Task Iterate(this TaskFactory factory, IEnumerable<object> source, TaskCreationOptions creationOptions)
	{
		Contract.ArgumentNotNull(factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637C21E7));
		return factory.Iterate(source, null, factory.CancellationToken, creationOptions, factory.GetTargetScheduler());
	}

	public static Task Iterate(this TaskFactory factory, IEnumerable<object> source, TaskScheduler scheduler)
	{
		Contract.ArgumentNotNull(factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341A5629));
		return factory.Iterate(source, null, factory.CancellationToken, factory.CreationOptions, scheduler);
	}

	public static Task Iterate(this TaskFactory factory, IEnumerable<object> source, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		return factory.Iterate(source, null, cancellationToken, creationOptions, scheduler);
	}

	public static Task Iterate(this TaskFactory factory, IEnumerable<object> source, object state)
	{
		Contract.ArgumentNotNull(factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29125345));
		return factory.Iterate(source, state, factory.CancellationToken, factory.CreationOptions, factory.GetTargetScheduler());
	}

	public static Task Iterate(this TaskFactory factory, IEnumerable<object> source, object state, CancellationToken cancellationToken)
	{
		Contract.ArgumentNotNull(factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978607474));
		return factory.Iterate(source, state, cancellationToken, factory.CreationOptions, factory.GetTargetScheduler());
	}

	public static Task Iterate(this TaskFactory factory, IEnumerable<object> source, object state, TaskCreationOptions creationOptions)
	{
		Contract.ArgumentNotNull(factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72450AF6));
		return factory.Iterate(source, state, factory.CancellationToken, creationOptions, factory.GetTargetScheduler());
	}

	public static Task Iterate(this TaskFactory factory, IEnumerable<object> source, object state, TaskScheduler scheduler)
	{
		Contract.ArgumentNotNull(factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710704458));
		return factory.Iterate(source, state, factory.CancellationToken, factory.CreationOptions, scheduler);
	}

	public static Task Iterate(this TaskFactory factory, IEnumerable<object> source, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0.cancellationToken = cancellationToken;
		Contract.ArgumentNotNull(factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824521247));
		Contract.ArgumentNotNull(source, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561076286));
		Contract.ArgumentNotNull(scheduler, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108820280));
		CS_0024_003C_003E8__locals0.enumerator = source.GetEnumerator();
		if (CS_0024_003C_003E8__locals0.enumerator == null)
		{
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AF1473)));
		}
		CS_0024_003C_003E8__locals0.trs = new TaskCompletionSource<object>(state, creationOptions);
		CS_0024_003C_003E8__locals0.trs.Task.ContinueWith(delegate
		{
			CS_0024_003C_003E8__locals0.enumerator.Dispose();
		});
		CS_0024_003C_003E8__locals0.recursiveBody = null;
		CS_0024_003C_003E8__locals0.recursiveBody = delegate
		{
			//Discarded unreachable code: IL_0050, IL_0093, IL_010a, IL_0133, IL_0142, IL_01b8, IL_027e, IL_028d, IL_0318, IL_0327
			switch (1)
			{
			case 0:
				break;
			case 1:
				try
				{
					int num3;
					if (CS_0024_003C_003E8__locals0.enumerator.MoveNext())
					{
						num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num3 = 0;
						}
						goto IL_0054;
					}
					goto IL_018c;
					IL_018c:
					CS_0024_003C_003E8__locals0.trs.TrySetResult(null);
					num3 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num3 = 8;
					}
					goto IL_0054;
					IL_0054:
					object current = default(object);
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						case 7:
							return;
						case 8:
							return;
						case 10:
							return;
						case 3:
						case 6:
							_003C_003Ec__DisplayClass11_0.P3BwQU8BQ3w66t7RiMS8(CS_0024_003C_003E8__locals0.trs, new InvalidOperationException((string)_003C_003Ec__DisplayClass11_0.tIbqqB8BfiFsVTGjajXq(_003C_003Ec__DisplayClass11_0.ev4K3Y8BE92S87gOWXfi(--1360331293 ^ 0x5110DA65))));
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
							{
								num3 = 2;
							}
							continue;
						case 4:
							current = CS_0024_003C_003E8__locals0.enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							if (current is Task)
							{
								num3 = 11;
								continue;
							}
							goto case 5;
						case 5:
							if (!(current is TaskScheduler))
							{
								num3 = 6;
								continue;
							}
							goto case 9;
						case 11:
						{
							Task obj = (Task)current;
							_003C_003Ec__DisplayClass11_0.H5NlfK8Bb9q2h0kiBbRQ(obj);
							obj.ContinueWith(CS_0024_003C_003E8__locals0.recursiveBody).IgnoreExceptions();
							num3 = 10;
							continue;
						}
						case 9:
							((Task)_003C_003Ec__DisplayClass11_0.zYaa2n8BGipfxfqJaTak(Task.Factory, (Action)delegate
							{
								int num6 = 1;
								int num7 = num6;
								while (true)
								{
									switch (num7)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										CS_0024_003C_003E8__locals0.recursiveBody(null);
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
										{
											num7 = 0;
										}
										break;
									}
								}
							}, _003C_003Ec__DisplayClass11_0.YGh8se8Bh2LsBJpwIiWC(), TaskCreationOptions.None, (TaskScheduler)current)).IgnoreExceptions();
							num3 = 7;
							continue;
						}
						break;
					}
					goto IL_018c;
				}
				catch (Exception ex)
				{
					int num4 = 3;
					int num5 = num4;
					OperationCanceledException ex2 = default(OperationCanceledException);
					while (true)
					{
						switch (num5)
						{
						case 4:
							return;
						case 6:
							return;
						case 1:
							_003C_003Ec__DisplayClass11_0.P3BwQU8BQ3w66t7RiMS8(CS_0024_003C_003E8__locals0.trs, ex);
							num5 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num5 = 1;
							}
							break;
						case 5:
							if (ex2 != null)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
								{
									num5 = 0;
								}
								break;
							}
							goto case 1;
						default:
							if (_003C_003Ec__DisplayClass11_0.GH80Jw8BvqCBql7MX6Q6(_003C_003Ec__DisplayClass11_0.KZaRwu8BCLrDoA33yo3U(ex2), CS_0024_003C_003E8__locals0.cancellationToken))
							{
								num5 = 2;
								break;
							}
							goto case 1;
						case 3:
							ex2 = ex as OperationCanceledException;
							num5 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num5 = 2;
							}
							break;
						case 2:
							_003C_003Ec__DisplayClass11_0.HXgjbF8B8qqJLPaKFUUY(CS_0024_003C_003E8__locals0.trs);
							num5 = 6;
							break;
						}
					}
				}
			}
		};
		factory.StartNew(delegate
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
					CS_0024_003C_003E8__locals0.recursiveBody(null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}, CancellationToken.None, TaskCreationOptions.None, scheduler).IgnoreExceptions();
		return CS_0024_003C_003E8__locals0.trs.Task;
	}

	internal static object Prdn6nGpymd6C9J7dvs0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void NXJ5uuGpMoxWJpYhDeQU(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object TjlkkgGpJ2xNIev6uOs5(object P_0)
	{
		return ((TaskFactory)P_0).Scheduler;
	}

	internal static object gwRs6JGp93wULZs4bjUu()
	{
		return TaskScheduler.Current;
	}

	internal static bool qsi4s6Gp0taemHqyaUbe()
	{
		return u6uF3HGpx6vIndwsr78w == null;
	}

	internal static TaskFactoryExtensions sSuwKcGpmWbGHV8lWWoY()
	{
		return u6uF3HGpx6vIndwsr78w;
	}
}

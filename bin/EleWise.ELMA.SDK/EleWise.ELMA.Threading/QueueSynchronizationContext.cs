using System;
using System.Collections.Generic;
using System.Threading;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Threading;

public class QueueSynchronizationContext : SynchronizationContext
{
	private class WorkItem
	{
		private object callback;

		private object state;

		internal static object ib3woGQC7pTCG8Qt8lnL;

		public WorkItem(SendOrPostCallback callback, object state)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			zfQ4vEQCmmOjqfMhVrhM();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					this.callback = callback;
					num = 2;
					break;
				case 2:
					this.state = state;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public void Invoke()
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
					fR6XQYQCyCcCPhsND4WA(callback, state);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static void zfQ4vEQCmmOjqfMhVrhM()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool QXBPexQCxWLNB3dfJU0U()
		{
			return ib3woGQC7pTCG8Qt8lnL == null;
		}

		internal static WorkItem OdND08QC0MCqclQePGQU()
		{
			return (WorkItem)ib3woGQC7pTCG8Qt8lnL;
		}

		internal static void fR6XQYQCyCcCPhsND4WA(object P_0, object P_1)
		{
			P_0(P_1);
		}
	}

	private Queue<WorkItem> queue;

	private Action afterQueueItemExecuted;

	private static QueueSynchronizationContext aJPAoEBRWU0cPX7HjjHN;

	public QueueSynchronizationContext()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		xiRUaJBRh4vef5OWPRIo();
		queue = new Queue<WorkItem>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public QueueSynchronizationContext(Action afterQueueItemExecuted)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		queue = new Queue<WorkItem>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
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
			this.afterQueueItemExecuted = afterQueueItemExecuted;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
			{
				num = 1;
			}
		}
	}

	public override SynchronizationContext CreateCopy()
	{
		return new QueueSynchronizationContext(afterQueueItemExecuted);
	}

	public override void Post(SendOrPostCallback d, object state)
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
				queue.Enqueue(new WorkItem(d, state));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void Send(SendOrPostCallback d, object state)
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
				eKWvRWBRGPabk3JlDATx(d, state);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ExecuteQueue()
	{
		//Discarded unreachable code: IL_0069, IL_00c7, IL_00d6
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (FcDjgoBRQmeGRMA9C7cX(queue) <= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 1;
			case 5:
				return;
			case 1:
				C6gduYBRERGWAoUX0GbA(queue.Dequeue());
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				kUHpKGBRfKsm8R9KykM6(afterQueueItemExecuted);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (afterQueueItemExecuted == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	internal static void xiRUaJBRh4vef5OWPRIo()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool qWX8IVBRoB3k8VjiT8uY()
	{
		return aJPAoEBRWU0cPX7HjjHN == null;
	}

	internal static QueueSynchronizationContext bbu9dUBRbPdqjk0uNPpm()
	{
		return aJPAoEBRWU0cPX7HjjHN;
	}

	internal static void eKWvRWBRGPabk3JlDATx(object P_0, object P_1)
	{
		P_0(P_1);
	}

	internal static void C6gduYBRERGWAoUX0GbA(object P_0)
	{
		((WorkItem)P_0).Invoke();
	}

	internal static void kUHpKGBRfKsm8R9KykM6(object P_0)
	{
		P_0();
	}

	internal static int FcDjgoBRQmeGRMA9C7cX(object P_0)
	{
		return ((Queue<WorkItem>)P_0).Count;
	}
}

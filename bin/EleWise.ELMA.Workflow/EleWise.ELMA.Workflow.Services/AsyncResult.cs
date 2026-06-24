using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

internal abstract class AsyncResult : IAsyncResult
{
	protected delegate bool AsyncCompletion(IAsyncResult result);

	private static AsyncCallback asyncCompletionWrapperCallback;

	private AsyncCallback callback;

	private bool completedSynchronously;

	private bool endCalled;

	private Exception exception;

	private bool isCompleted;

	private ManualResetEvent manualResetEvent;

	private AsyncCompletion nextAsyncCompletion;

	private object state;

	private object thisLock;

	internal static AsyncResult wTlrpkVe8wfyOIxA8t3;

	public object AsyncState => state;

	public WaitHandle AsyncWaitHandle
	{
		get
		{
			//Discarded unreachable code: IL_0079, IL_0109, IL_0128, IL_0154
			int num = 1;
			int num2 = num;
			object obj = default(object);
			bool lockTaken = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (manualResetEvent != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = ThisLock;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								if (manualResetEvent == null)
								{
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
									{
										num3 = 1;
									}
									continue;
								}
								break;
							case 1:
								manualResetEvent = new ManualResetEvent(isCompleted);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
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
							num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
							{
								num4 = 1;
							}
							goto IL_010d;
						}
						goto IL_0132;
						IL_0132:
						QFkJwKV1SAnlxly9cxi(obj);
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
						{
							num4 = 0;
						}
						goto IL_010d;
						IL_010d:
						switch (num4)
						{
						default:
							goto end_IL_00e8;
						case 1:
							goto end_IL_00e8;
						case 2:
							break;
						case 0:
							goto end_IL_00e8;
						}
						goto IL_0132;
						end_IL_00e8:;
					}
					break;
				default:
					return manualResetEvent;
				case 2:
					lockTaken = false;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					break;
				}
				break;
			}
			return manualResetEvent;
		}
	}

	public bool CompletedSynchronously => completedSynchronously;

	public bool HasCallback => callback != null;

	public bool IsCompleted => isCompleted;

	private object ThisLock => thisLock;

	protected AsyncResult(AsyncCallback callback, object state)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		zgV1W1VSdx1xS90ZQ38();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.state = state;
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				this.callback = callback;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				thisLock = new object();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected void Complete(bool completedSynchronously)
	{
		//Discarded unreachable code: IL_0052, IL_0061, IL_0104, IL_01a4, IL_01dc, IL_01eb, IL_021d, IL_0250, IL_0280, IL_028f
		int num = 5;
		object obj = default(object);
		bool lockTaken = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return;
				case 9:
					isCompleted = true;
					num2 = 2;
					continue;
				case 11:
					if (!completedSynchronously)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 9;
				case 5:
					if (isCompleted)
					{
						num2 = 4;
						continue;
					}
					this.completedSynchronously = completedSynchronously;
					num2 = 11;
					continue;
				case 1:
				case 7:
					obj = ThisLock;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					lockTaken = false;
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
					{
						num2 = 5;
					}
					continue;
				case 10:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num5 = 3;
						while (true)
						{
							switch (num5)
							{
							case 3:
								isCompleted = true;
								num5 = 2;
								continue;
							case 1:
								i77fIdVhTfuy8mUKwvD(manualResetEvent);
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
								{
									num5 = 0;
								}
								continue;
							case 2:
								if (manualResetEvent != null)
								{
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
									{
										num5 = 1;
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
							int num6 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								case 1:
									QFkJwKV1SAnlxly9cxi(obj);
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
									{
										num6 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 2;
				case 8:
					try
					{
						ukfrjiVEl9PF99TkpVa(callback, this);
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
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
					catch (Exception inner)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							throw new InvalidProgramException((string)jsm1pPVwy2JaHFaktE7(-197778752 ^ -197708552), inner);
						}
					}
				case 2:
				case 3:
					if (callback == null)
					{
						return;
					}
					break;
				case 4:
					throw new InvalidProgramException();
				}
				break;
			}
			num = 8;
		}
	}

	protected void Complete(bool completedSynchronously, Exception exception)
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
				this.exception = exception;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				Complete(completedSynchronously);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static void AsyncCompletionWrapperCallback(object result)
	{
		//Discarded unreachable code: IL_005c, IL_006b, IL_00e5, IL_0128, IL_013f, IL_014e
		int num = 4;
		int num2 = num;
		AsyncCompletion nextCompletion = default(AsyncCompletion);
		AsyncResult asyncResult = default(AsyncResult);
		bool flag = default(bool);
		Exception ex = default(Exception);
		while (true)
		{
			switch (num2)
			{
			default:
				nextCompletion = asyncResult.GetNextCompletion();
				num2 = 6;
				break;
			case 1:
				if (flag)
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
					{
						num2 = 5;
					}
					break;
				}
				return;
			case 9:
				return;
			case 2:
				return;
			case 3:
				asyncResult = (AsyncResult)ATU1hrVztqyL6nXjelM(result);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				try
				{
					flag = lEkevHAKbrgqTomB81v(nextCompletion, result);
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex2)
				{
					if (IsFatal(ex2))
					{
						throw;
					}
					flag = true;
					ex = ex2;
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			case 7:
				ex = null;
				num2 = 8;
				break;
			case 6:
				flag = false;
				num2 = 7;
				break;
			case 5:
				a9UeAeAOSAyxrR2GK9x(asyncResult, false, ex);
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (Uy7u0bV4UhlCmRk4ZTR(result))
				{
					return;
				}
				num2 = 3;
				break;
			}
		}
	}

	public static bool IsFatal(Exception exception)
	{
		//Discarded unreachable code: IL_0065, IL_0074, IL_00c2, IL_00d1, IL_011d, IL_012c, IL_0161, IL_0170, IL_01aa, IL_01b9, IL_01cb, IL_01da
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (exception is TargetInvocationException)
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 12:
					if (exception is SEHException)
					{
						num2 = 14;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
						{
							num2 = 9;
						}
						break;
					}
					if (exception is TypeInitializationException)
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 6;
				case 7:
				case 9:
				case 11:
				case 14:
					return true;
				default:
					if (!(exception is OutOfMemoryException))
					{
						num2 = 15;
						break;
					}
					goto case 8;
				case 8:
					if (!(exception is InsufficientMemoryException))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
						{
							num2 = 11;
						}
						break;
					}
					goto case 13;
				case 10:
					if (exception is AccessViolationException)
					{
						num2 = 9;
						break;
					}
					goto case 12;
				case 13:
				case 15:
					if (exception is ThreadAbortException)
					{
						num2 = 7;
						break;
					}
					goto case 10;
				case 3:
					return false;
				case 1:
				case 2:
					if (exception != null)
					{
						num2 = 4;
						break;
					}
					goto case 3;
				case 5:
				case 16:
					exception = (Exception)nj3OuRAZeNcKZjWnMKR(exception);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
					{
						num2 = 2;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	protected AsyncCallback PrepareAsyncCompletion(AsyncCompletion callback)
	{
		//Discarded unreachable code: IL_005c
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
				case 3:
					return asyncCompletionWrapperCallback;
				case 1:
					nextAsyncCompletion = callback;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					break;
				default:
					if (asyncCompletionWrapperCallback == null)
					{
						break;
					}
					goto end_IL_0012;
				}
				asyncCompletionWrapperCallback = AsyncCompletionWrapperCallback;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
				{
					num2 = 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private AsyncCompletion GetNextCompletion()
	{
		AsyncCompletion result = nextAsyncCompletion;
		nextAsyncCompletion = null;
		return result;
	}

	protected static TAsyncResult End<TAsyncResult>(IAsyncResult result) where TAsyncResult : AsyncResult
	{
		if (result == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6C6D3A));
		}
		if (!(result is TAsyncResult val))
		{
			throw new ArgumentException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130036136), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935241945));
		}
		if (val.endCalled)
		{
			throw new InvalidOperationException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708066056));
		}
		val.endCalled = true;
		if (!val.isCompleted)
		{
			val.AsyncWaitHandle.WaitOne();
		}
		if (val.manualResetEvent != null)
		{
			val.manualResetEvent.Close();
		}
		if (val.exception != null)
		{
			throw val.exception;
		}
		return val;
	}

	internal static void zgV1W1VSdx1xS90ZQ38()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool GRii4MVNKCMgvHgKbCJ()
	{
		return wTlrpkVe8wfyOIxA8t3 == null;
	}

	internal static AsyncResult iWrIAQVxTa0wHQHAvJh()
	{
		return wTlrpkVe8wfyOIxA8t3;
	}

	internal static void QFkJwKV1SAnlxly9cxi(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool i77fIdVhTfuy8mUKwvD(object P_0)
	{
		return ((EventWaitHandle)P_0).Set();
	}

	internal static void ukfrjiVEl9PF99TkpVa(object P_0, object P_1)
	{
		P_0((IAsyncResult)P_1);
	}

	internal static object jsm1pPVwy2JaHFaktE7(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Uy7u0bV4UhlCmRk4ZTR(object P_0)
	{
		return ((IAsyncResult)P_0).CompletedSynchronously;
	}

	internal static object ATU1hrVztqyL6nXjelM(object P_0)
	{
		return ((IAsyncResult)P_0).AsyncState;
	}

	internal static bool lEkevHAKbrgqTomB81v(object P_0, object P_1)
	{
		return P_0((IAsyncResult)P_1);
	}

	internal static void a9UeAeAOSAyxrR2GK9x(object P_0, bool completedSynchronously, object P_2)
	{
		((AsyncResult)P_0).Complete(completedSynchronously, (Exception)P_2);
	}

	internal static object nj3OuRAZeNcKZjWnMKR(object P_0)
	{
		return ((Exception)P_0).InnerException;
	}
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Component]
internal class TranslateServiceSaveSweepHandler : ISweepHandler, IThreadPoolContainer
{
	private class PoFilesProcessingResolver
	{
		private readonly object _service;

		private readonly object _op;

		private readonly object _pool;

		internal static object Ey5Di1QnhLw1bytCkk5K;

		public PoFilesProcessingResolver(TranslateService service, LocalizationOperation op, IThreadPool pool)
		{
			//Discarded unreachable code: IL_001a
			KIc5mHQnf3dp5AUDLtV1();
			base._002Ector();
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
				{
					_pool = pool;
					int num2 = 2;
					num = num2;
					break;
				}
				case 2:
					_service = service;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num = 0;
					}
					break;
				case 1:
					return;
				default:
					_op = op;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		public void Send()
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
					AkSe14QnQMxrGhRDibvm(_pool, (ThreadStart)delegate
					{
						//Discarded unreachable code: IL_0097, IL_00db, IL_00ee, IL_00fd
						switch (1)
						{
						case 1:
							try
							{
								new BackgroundTask(delegate
								{
									//Discarded unreachable code: IL_004a, IL_007d, IL_00e4, IL_00f3
									switch (1)
									{
									case 1:
										try
										{
											((LocalizationOperation)_op).Execute();
											int num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
											{
												num5 = 0;
											}
											switch (num5)
											{
											case 0:
												break;
											}
											break;
										}
										catch (Exception exception)
										{
											int num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
											{
												num6 = 0;
											}
											while (true)
											{
												switch (num6)
												{
												default:
													EleWise.ELMA.Logging.Logger.Log.Debug(H6n74UQn86NycnvfPuvK(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -630185376), KC7GjVQnviPv2VuCJ3mp(_op)), exception);
													num6 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
													{
														num6 = 1;
													}
													break;
												case 1:
													return;
												}
											}
										}
									case 0:
										break;
									}
								}, typeof(PoFilesProcessingResolver), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61E97A10), (string)H6n74UQn86NycnvfPuvK(GHWikkQnCx6wCu9Cigwp(0x1DE3DD89 ^ 0x1DE6AB57), KC7GjVQnviPv2VuCJ3mp(_op))).Execute();
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
								break;
							}
							finally
							{
								_processingItems.TryRemove((LocalizationOperation)_op, out var _);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
						case 0:
							break;
						}
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static void KIc5mHQnf3dp5AUDLtV1()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool R9dqIfQnGSvfrIydYRdY()
		{
			return Ey5Di1QnhLw1bytCkk5K == null;
		}

		internal static PoFilesProcessingResolver VrxOSbQnEFGGdOcU5Mdp()
		{
			return (PoFilesProcessingResolver)Ey5Di1QnhLw1bytCkk5K;
		}

		internal static void AkSe14QnQMxrGhRDibvm(object P_0, object P_1)
		{
			((IThreadPool)P_0).Queue((ThreadStart)P_1);
		}

		internal static object GHWikkQnCx6wCu9Cigwp(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object KC7GjVQnviPv2VuCJ3mp(object P_0)
		{
			return ((LocalizationOperation)P_0).Name;
		}

		internal static object H6n74UQn86NycnvfPuvK(object P_0, object P_1)
		{
			return string.Format((string)P_0, P_1);
		}
	}

	private readonly ThreadSubPool _sweepPool;

	private readonly ThreadSubPool _createPool;

	private readonly int _processingCount;

	internal static readonly ConcurrentDictionary<LocalizationOperation, object> _processingItems;

	private static TranslateServiceSaveSweepHandler iVmw9RB7DtoNMoY6wCXl;

	IThreadPool IThreadPoolContainer.Pool => _sweepPool;

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
				case 0:
					return;
				case 1:
					_003CLogger_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TranslateServiceSaveSweepHandler()
	{
		//Discarded unreachable code: IL_001e, IL_00ab, IL_00ba
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					_createPool = new ThreadSubPool((string)eWgF0DB74A3KyxZIOJpL(0x31326106 ^ 0x31333E20), 1);
					num2 = 2;
					continue;
				case 1:
					return;
				case 4:
					return;
				case 2:
					SR.GetSetting((string)eWgF0DB74A3KyxZIOJpL(-345420348 ^ -345501000), 10);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					break;
				case 5:
					_processingCount = 10;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (_processingCount > 0)
					{
						num2 = 4;
						continue;
					}
					goto case 5;
				}
				break;
			}
			_sweepPool = new ThreadSubPool(1);
			num = 6;
		}
	}

	void ISweepHandler.Execute()
	{
		//Discarded unreachable code: IL_007a, IL_0092, IL_00a1, IL_00ac, IL_0180, IL_01b3, IL_01c6, IL_01d5
		int num = 1;
		int num2 = num;
		LocalizationOperation current = default(LocalizationOperation);
		while (true)
		{
			switch (num2)
			{
			case 1:
				d7RFUPB7609LHo4A8vpv(value: false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				List<LocalizationOperation>.Enumerator enumerator = ((TranslateService)Jh5dlbB7H7Ii99Q3j8fe()).GetTopOperations(_processingCount).GetEnumerator();
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					try
					{
						while (true)
						{
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
								{
									num4 = 0;
								}
								goto IL_00b0;
							}
							goto IL_0110;
							IL_0110:
							current = enumerator.Current;
							num4 = 4;
							goto IL_00b0;
							IL_00b0:
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 4:
									if (_processingItems.TryAdd(current, null))
									{
										num4 = 3;
										continue;
									}
									break;
								case 1:
									break;
								case 2:
									goto IL_0110;
								case 3:
									new PoFilesProcessingResolver((TranslateService)Jh5dlbB7H7Ii99Q3j8fe(), current, _createPool).Send();
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
									{
										num4 = 1;
									}
									continue;
								case 0:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				}
			}
			finally
			{
				d7RFUPB7609LHo4A8vpv(value: true);
				int num6 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num6 = 0;
				}
				switch (num6)
				{
				case 0:
					break;
				}
			}
		}
	}

	static TranslateServiceSaveSweepHandler()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				pKkEf3B7AD3H4sdb8n8r();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_processingItems = new ConcurrentDictionary<LocalizationOperation, object>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object eWgF0DB74A3KyxZIOJpL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Dw9NMHB7tFwM36gssVuG()
	{
		return iVmw9RB7DtoNMoY6wCXl == null;
	}

	internal static TranslateServiceSaveSweepHandler rhBt5tB7wxLwpajPaTqs()
	{
		return iVmw9RB7DtoNMoY6wCXl;
	}

	internal static void d7RFUPB7609LHo4A8vpv(bool value)
	{
		EventSettings.Enabled = value;
	}

	internal static object Jh5dlbB7H7Ii99Q3j8fe()
	{
		return TranslateService.Instance;
	}

	internal static void pKkEf3B7AD3H4sdb8n8r()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Providers.Impl;

[Component]
internal class SystemFileEventListener : IUnitOfWorkEventListener
{
	internal static SystemFileEventListener nkny86Wvp8PuVyZPIVrZ;

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
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
				ContextVars.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EDBC23), value: false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
		//Discarded unreachable code: IL_00aa, IL_00b9, IL_00c9, IL_00d8, IL_016a, IL_019a, IL_01a9
		switch (1)
		{
		case 1:
			try
			{
				ContextVars.Set((string)bw27L2WvtkNoNQWy1u5g(-488881205 ^ -488772905), value: true);
				int num = 4;
				BinaryFile binaryFile = default(BinaryFile);
				Dictionary<Guid, BinaryFile> value = default(Dictionary<Guid, BinaryFile>);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 6:
							if (binaryFile != null)
							{
								num2 = 2;
								continue;
							}
							return;
						case 5:
							return;
						case 2:
							Locator.GetServiceNotNull<IFileManager>().SaveFile(binaryFile);
							num2 = 7;
							continue;
						case 4:
							if (!ContextVars.TryGetValue<Dictionary<Guid, BinaryFile>>((string)bw27L2WvtkNoNQWy1u5g(-675505729 ^ -675466815), out value))
							{
								num2 = 5;
								continue;
							}
							break;
						case 7:
							value.Remove(kFtHtkWvw93NDPEhYGsF(binaryFile));
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num2 = 0;
							}
							continue;
						case 3:
							return;
						}
						break;
					}
					binaryFile = value.Values.FirstOrDefault();
					num = 6;
				}
			}
			catch (Exception innerException)
			{
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					throw new TransactionRollbackException((string)bw27L2WvtkNoNQWy1u5g(-1426094279 ^ -1426183697), innerException);
				}
			}
		case 0:
			break;
		}
	}

	public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
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
				ContextVars.Set((string)bw27L2WvtkNoNQWy1u5g(0x4D1C1EE4 ^ 0x4D1DB7F8), value: true);
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

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public SystemFileEventListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Lt5haqWv4vKt54ildTUl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool MdJCvqWvafOxo1aMCHCx()
	{
		return nkny86Wvp8PuVyZPIVrZ == null;
	}

	internal static SystemFileEventListener WcIIMiWvDx7FG7qVFndx()
	{
		return nkny86Wvp8PuVyZPIVrZ;
	}

	internal static object bw27L2WvtkNoNQWy1u5g(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid kFtHtkWvw93NDPEhYGsF(object P_0)
	{
		return ((BinaryFile)P_0).Uid;
	}

	internal static void Lt5haqWv4vKt54ildTUl()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}

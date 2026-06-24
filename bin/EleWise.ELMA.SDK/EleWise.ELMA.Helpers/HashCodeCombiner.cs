using System;
using System.Collections;
using System.Globalization;
using System.IO;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public class HashCodeCombiner
{
	private long combinedHash;

	private static HashCodeCombiner xyXyXdhssTtQq13QLEfc;

	public long CombinedHash => combinedHash;

	public int CombinedHash32 => combinedHash.GetHashCode();

	public string CombinedHashString => combinedHash.ToString((string)f1xbhOhcEM0qaksFT91P(-475857671 ^ -475996727), (IFormatProvider)uayH07hcfVybvCkNJ2aD());

	public HashCodeCombiner()
	{
		//Discarded unreachable code: IL_0030, IL_0035
		LyqkIxhcFJaMN2vxLfKB();
		this._002Ector(5381L);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public HashCodeCombiner(long init)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LyqkIxhcFJaMN2vxLfKB();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
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
				combinedHash = init;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void AddInt(int n)
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
				combinedHash = ((combinedHash << 5) + combinedHash) ^ n;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void AddEnumerable(IEnumerable source)
	{
		//Discarded unreachable code: IL_0036, IL_0040, IL_00d1, IL_012e, IL_013d, IL_0190
		int num = 3;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		object o = default(object);
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
						IL_0093:
						int num3;
						if (!RoA8QIhcoWFwIhpdpC8e(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
							{
								num3 = 0;
							}
							goto IL_0044;
						}
						goto IL_0070;
						IL_0070:
						o = imxw7shcWHckE275mVYj(enumerator);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num3 = 0;
						}
						goto IL_0044;
						IL_0044:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								AddObject(o);
								num3 = 2;
								continue;
							case 3:
								break;
							case 2:
								goto IL_0093;
							case 0:
								return;
							}
							break;
						}
						goto IL_0070;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num4 = 2;
					while (true)
					{
						switch (num4)
						{
						case 2:
							if (disposable != null)
							{
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
								{
									num4 = 1;
								}
								continue;
							}
							break;
						case 1:
							s5RwathcbpesaVuLtkdN(disposable);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
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
			case 0:
				return;
			case 2:
				return;
			case 3:
				if (source == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 4:
				break;
			}
			enumerator = (IEnumerator)qH6l2BhcBMP1pEGSIQnF(source);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
			{
				num2 = 1;
			}
		}
	}

	public void AddObject(object o)
	{
		//Discarded unreachable code: IL_0051, IL_0060
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (o == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 2:
				return;
			case 1:
				break;
			case 0:
				return;
			}
			AddInt(o.GetHashCode());
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
			{
				num2 = 0;
			}
		}
	}

	public void AddDateTime(DateTime dt)
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
				AddInt(dt.GetHashCode());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void AddFile(string fileName)
	{
		//Discarded unreachable code: IL_0032, IL_0041
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
			case 3:
				if (!UlrFvfhchkCE0BP9VCVf(fileName))
				{
					num2 = 2;
					continue;
				}
				break;
			}
			AddExistingFile(fileName);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
			{
				num2 = 1;
			}
		}
	}

	public void AddFile(FileInfo info)
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
			case 3:
				AddExistingFile(info);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (info == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (!l8WiGrhcGHGVdXYdG7Qm(info))
				{
					return;
				}
				num2 = 3;
				break;
			}
		}
	}

	private void AddExistingFile(string fileName)
	{
		int num = 1;
		int num2 = num;
		FileInfo fileInfo = default(FileInfo);
		DateTime dt = default(DateTime);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				AddFileSize(fileInfo.Length);
				num2 = 5;
				break;
			case 1:
				fileInfo = new FileInfo(fileName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				dt = h8WJT5hcQOSGyvmorwat(fileInfo);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				num3 = dt.Second % 2;
				num2 = 4;
				break;
			case 4:
				dt = zEPFN0hcCVoPm8YavSqV(dt.Date, TimeSpan.FromSeconds((int)dt.TimeOfDay.TotalSeconds - num3));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 6;
				}
				break;
			case 5:
				return;
			case 6:
				AddDateTime(dt);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private void AddExistingFile(FileInfo info)
	{
		int num = 4;
		int num2 = num;
		DateTime dt = default(DateTime);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				AddDateTime(dt);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return;
			case 1:
				AddFileSize(info.Length);
				num2 = 5;
				break;
			case 4:
				dt = h8WJT5hcQOSGyvmorwat(info);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				num3 = dt.Second % 2;
				num2 = 2;
				break;
			case 2:
				dt = zEPFN0hcCVoPm8YavSqV(dt.Date, gwSW56hcvhpuXQpOZC21((int)dt.TimeOfDay.TotalSeconds - num3));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void AddFileSize(long fileSize)
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
				AddInt(fileSize.GetHashCode());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void LyqkIxhcFJaMN2vxLfKB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Dw0mW9hscmwyJpmMIqTG()
	{
		return xyXyXdhssTtQq13QLEfc == null;
	}

	internal static HashCodeCombiner n5HYpJhszKtlOr9FFCGf()
	{
		return xyXyXdhssTtQq13QLEfc;
	}

	internal static object qH6l2BhcBMP1pEGSIQnF(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object imxw7shcWHckE275mVYj(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool RoA8QIhcoWFwIhpdpC8e(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void s5RwathcbpesaVuLtkdN(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool UlrFvfhchkCE0BP9VCVf(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static bool l8WiGrhcGHGVdXYdG7Qm(object P_0)
	{
		return ((FileSystemInfo)P_0).Exists;
	}

	internal static object f1xbhOhcEM0qaksFT91P(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object uayH07hcfVybvCkNJ2aD()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static DateTime h8WJT5hcQOSGyvmorwat(object P_0)
	{
		return ((FileSystemInfo)P_0).LastWriteTime;
	}

	internal static DateTime zEPFN0hcCVoPm8YavSqV(DateTime P_0, TimeSpan P_1)
	{
		return P_0 + P_1;
	}

	internal static TimeSpan gwSW56hcvhpuXQpOZC21(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression;
using j3AmrhgkCleVTGdEwA;
using log4net.Appender;
using log4net.Core;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

public class ZipRollingFileAppender : RollingFileAppender
{
	private struct LogFileInfo
	{
		public string FileName;

		public DateTime FileTime;
	}

	private static readonly Type declaringType;

	internal static ZipRollingFileAppender gxp2sihJVEVyLopppoUM;

	public override bool StaticLogFileName
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void RollOverIfDateBoundaryCrossing(string lastFile, DateTime lastDate)
	{
		//Discarded unreachable code: IL_0041, IL_0105
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				base.RollOverIfDateBoundaryCrossing(lastFile, lastDate);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			case 6:
				return;
			case 7:
				ZipFiles(lastFile);
				num2 = 6;
				continue;
			case 5:
				if (lastFile == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			default:
				if (!m_rollDate)
				{
					num2 = 3;
					continue;
				}
				goto case 5;
			case 4:
				break;
			}
			if (lastDate.ToString(base.DatePattern, (IFormatProvider)aFZ1NlhJRE71ZGAqpkWD()).Equals(m_now.ToString(base.DatePattern, (IFormatProvider)aFZ1NlhJRE71ZGAqpkWD())))
			{
				break;
			}
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
			{
				num2 = 7;
			}
		}
	}

	protected override void RollOverTime(bool fileIsOpen)
	{
		//Discarded unreachable code: IL_01f4, IL_0203, IL_0213, IL_0243, IL_027b
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		IDisposable disposable = default(IDisposable);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass5_.fileName = m_scheduledFilename;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass5_._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				disposable = ((SecurityContext)S8RmoThJqnbIRQtnGCWI(this)).Impersonate((object)this);
				num2 = 6;
				break;
			case 1:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return;
			case 6:
				try
				{
					int num3;
					if (!dme6tjhJKHXXSUogwWRn(_003C_003Ec__DisplayClass5_.fileName))
					{
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num3 = 1;
						}
						goto IL_00eb;
					}
					goto IL_01a7;
					IL_013d:
					KAujiNhJO8FDvMaj3LTN(new Action(_003C_003Ec__DisplayClass5_._003CRollOverTime_003Eb__0));
					num3 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num3 = 2;
					}
					goto IL_00eb;
					IL_00eb:
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						case 7:
							return;
						case 8:
						{
							_003C_003Ec__DisplayClass5_.fileName = (string)V7OOlVhJnlkeCIT3or4O(_003C_003Ec__DisplayClass5_.fileName, 0, num4);
							int num5 = 3;
							num3 = num5;
							continue;
						}
						case 3:
						case 4:
							break;
						case 6:
							num4 = utqGjehJkyd6GjqT9MFy(_003C_003Ec__DisplayClass5_.fileName, AjJO3QhJTsei4EMFym7D(-1334993905 ^ -1334999349));
							num3 = 5;
							continue;
						case 1:
							if (!yTg5eshJX4BGrjIxi0Dg(this))
							{
								num3 = 6;
								continue;
							}
							break;
						default:
							goto IL_01a7;
						case 5:
							if (num4 < 0)
							{
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
								{
									num3 = 4;
								}
								continue;
							}
							goto case 8;
						}
						break;
					}
					goto IL_013d;
					IL_01a7:
					if (base.CountDirection >= 0)
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num3 = 1;
						}
						goto IL_00eb;
					}
					goto IL_013d;
				}
				finally
				{
					if (disposable != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								l5R0cIhJ2OlQ2bD8SZSS(disposable);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 2:
				base.RollOverTime(fileIsOpen);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void ZipFiles(string baseFileName)
	{
		//Discarded unreachable code: IL_004b, IL_0129, IL_0133, IL_0196, IL_01c8, IL_01df, IL_01ee, IL_024b, IL_027f, IL_02b7, IL_02c6
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0086: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0;
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		IDisposable disposable = default(IDisposable);
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
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
						{
							FastZip val = new FastZip(new FastZipEvents
							{
								ProcessFile = (ProcessFileHandler)delegate(object s, ScanEventArgs a)
								{
									int num9 = 3;
									int num10 = num9;
									while (true)
									{
										switch (num10)
										{
										default:
											CS_0024_003C_003E8__locals0.filesToRemove.Add((string)_003C_003Ec__DisplayClass6_0.jqSYRav6j7NPZH3MvjNu(a));
											num10 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
											{
												num10 = 1;
											}
											break;
										case 1:
											return;
										case 2:
											if (!_003C_003Ec__DisplayClass6_0.XapsK2v6sFRt9IhVW4Xp(a))
											{
												return;
											}
											num10 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
											{
												num10 = 0;
											}
											break;
										case 3:
											_003C_003Ec__DisplayClass6_0.Y6DvsSv6U1ft8Z2shSFr(a, !_003C_003Ec__DisplayClass6_0.BYKSQav6LU7a8j9YZNSk(_003C_003Ec__DisplayClass6_0.dSxr9uv6Y7UnLmkqnIGx(_003C_003Ec__DisplayClass6_0.jqSYRav6j7NPZH3MvjNu(a)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099694537), StringComparison.OrdinalIgnoreCase));
											num10 = 2;
											break;
										}
									}
								}
							});
							pkecTGhJewCl3Jbsydpt((object)val, (CompressionLevel)9);
							val.CreateZip((string)ikhRpvhJP9a6sinW0Q8T(baseFileName, AjJO3QhJTsei4EMFym7D(0xE1229CF ^ 0xE134AAF)), (string)U3F2tjhJ1ucawpUHRP05(baseFileName), false, (string)ikhRpvhJP9a6sinW0Q8T(MraEEQhJNLqMkOOJuc7q(baseFileName), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824297165)));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num3 = 0;
							}
							break;
						}
						case 1:
							CS_0024_003C_003E8__locals0.filesToRemove = new List<string>();
							num3 = 3;
							break;
						default:
							enumerator = CS_0024_003C_003E8__locals0.filesToRemove.GetEnumerator();
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							try
							{
								while (true)
								{
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
										{
											num4 = 0;
										}
										goto IL_0137;
									}
									goto IL_0151;
									IL_0151:
									current = enumerator.Current;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
									{
										num4 = 0;
									}
									goto IL_0137;
									IL_0137:
									switch (num4)
									{
									case 1:
										return;
									case 2:
										break;
									default:
										try
										{
											MNKHOvhJ3GAYbnuM12mF(current);
											int num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
											{
												num5 = 0;
											}
											switch (num5)
											{
											case 0:
												break;
											}
										}
										catch (IOException)
										{
											int num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
											{
												num6 = 0;
											}
											switch (num6)
											{
											case 0:
												break;
											}
										}
										continue;
									case 3:
										continue;
									}
									goto IL_0151;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
								{
									num7 = 0;
								}
								switch (num7)
								{
								case 0:
									break;
								}
							}
						}
					}
				}
				finally
				{
					if (disposable != null)
					{
						int num8 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							case 1:
								l5R0cIhJ2OlQ2bD8SZSS(disposable);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
								{
									num8 = 0;
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
				disposable = ((SecurityContext)S8RmoThJqnbIRQtnGCWI(this)).Impersonate((object)this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public ZipRollingFileAppender()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LoYtXVhJpso3spFxkXrq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ZipRollingFileAppender()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				declaringType = hA5jc6hJaKPOO10fDvhD(typeof(ZipRollingFileAppender).TypeHandle);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object aFZ1NlhJRE71ZGAqpkWD()
	{
		return DateTimeFormatInfo.InvariantInfo;
	}

	internal static bool DhMxq6hJSIhbsuAvK7lh()
	{
		return gxp2sihJVEVyLopppoUM == null;
	}

	internal static ZipRollingFileAppender jQOUtBhJiw5GkZ3oOSco()
	{
		return gxp2sihJVEVyLopppoUM;
	}

	internal static object S8RmoThJqnbIRQtnGCWI(object P_0)
	{
		return ((FileAppender)P_0).get_SecurityContext();
	}

	internal static bool dme6tjhJKHXXSUogwWRn(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static bool yTg5eshJX4BGrjIxi0Dg(object P_0)
	{
		return ((RollingFileAppender)P_0).StaticLogFileName;
	}

	internal static object AjJO3QhJTsei4EMFym7D(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int utqGjehJkyd6GjqT9MFy(object P_0, object P_1)
	{
		return ((string)P_0).LastIndexOf((string)P_1);
	}

	internal static object V7OOlVhJnlkeCIT3or4O(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object KAujiNhJO8FDvMaj3LTN(object P_0)
	{
		return Task.Run((Action)P_0);
	}

	internal static void l5R0cIhJ2OlQ2bD8SZSS(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void pkecTGhJewCl3Jbsydpt(object P_0, CompressionLevel P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((FastZip)P_0).set_CompressionLevel(P_1);
	}

	internal static object ikhRpvhJP9a6sinW0Q8T(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object U3F2tjhJ1ucawpUHRP05(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object MraEEQhJNLqMkOOJuc7q(object P_0)
	{
		return Path.GetFileName((string)P_0);
	}

	internal static void MNKHOvhJ3GAYbnuM12mF(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static void LoYtXVhJpso3spFxkXrq()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type hA5jc6hJaKPOO10fDvhD(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}

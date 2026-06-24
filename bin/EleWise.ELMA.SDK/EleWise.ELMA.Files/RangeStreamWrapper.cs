using System;
using System.IO;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files;

public class RangeStreamWrapper : Stream
{
	private readonly Stream baseStream;

	private readonly long offsetStart;

	private readonly long offsetEnd;

	private long position;

	private static RangeStreamWrapper YrgCfqGX7ZD88JchgfG2;

	public override bool CanRead => baseStream.CanRead;

	public override bool CanSeek => baseStream.CanSeek;

	public override bool CanWrite => false;

	public override long Length => Sk7BUUGXreMhlDQCE3KJ(0L, offsetEnd - offsetStart + 1);

	public override long Position
	{
		get
		{
			return position;
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
					lp4SC6GXd7Au6pVIMQm5(this, value, SeekOrigin.Begin);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RangeStreamWrapper([NotNull] Stream stream, long offsetStart, long offsetEnd)
	{
		//Discarded unreachable code: IL_002a, IL_00ce
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
		{
			num = 1;
		}
		long num2 = default(long);
		while (true)
		{
			switch (num)
			{
			case 1:
				throw new ArgumentNullException((string)CnnoiRGXmDFTsgB57bu4(-740338220 ^ -740521112));
			case 10:
				return;
			case 5:
				EJeUbCGXJ6BY5Kg9Ojco(this, 0L);
				num = 6;
				break;
			default:
				num2 = os8v7bGXMCs8GoaRxAOJ(stream);
				num = 9;
				break;
			case 8:
				throw new ArgumentException((string)mu7oVBGXyUKysLKZ1MWo(CnnoiRGXmDFTsgB57bu4(0x61EC0CB8 ^ 0x61EFD274)), (string)CnnoiRGXmDFTsgB57bu4(0x269E5FCA ^ 0x269D8176));
			case 12:
				return;
			case 6:
				return;
			case 14:
				if (num2 > offsetEnd)
				{
					int num3 = 11;
					num = num3;
					break;
				}
				EJeUbCGXJ6BY5Kg9Ojco(this, num2 - offsetStart);
				num = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num = 9;
				}
				break;
			case 11:
				Position = offsetEnd - offsetStart;
				num = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num = 12;
				}
				break;
			case 2:
				if (stream != null)
				{
					if (!stream.CanRead)
					{
						num = 8;
						break;
					}
					if (offsetEnd <= offsetStart)
					{
						num = 13;
						break;
					}
					if (offsetEnd >= stream.Length)
					{
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num = 7;
						}
						break;
					}
					baseStream = stream;
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num = 1;
					}
				}
				else
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num = 1;
					}
				}
				break;
			case 4:
				this.offsetStart = offsetStart;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num = 3;
				}
				break;
			case 3:
				this.offsetEnd = offsetEnd;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num = 0;
				}
				break;
			case 9:
				if (num2 >= offsetStart)
				{
					num = 14;
					break;
				}
				goto case 5;
			case 13:
				throw new ArgumentOutOfRangeException((string)mu7oVBGXyUKysLKZ1MWo(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1247C3AC)));
			case 7:
				throw new ArgumentOutOfRangeException((string)mu7oVBGXyUKysLKZ1MWo(CnnoiRGXmDFTsgB57bu4(-951514650 ^ -951396678)));
			}
		}
	}

	public override void Flush()
	{
		throw new NotSupportedException((string)mu7oVBGXyUKysLKZ1MWo(CnnoiRGXmDFTsgB57bu4(-1146510045 ^ -1146455317)));
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		//Discarded unreachable code: IL_017e, IL_018d, IL_01eb, IL_01fa, IL_029b, IL_02dc, IL_030d, IL_0343, IL_03ab, IL_03ba, IL_03ca, IL_03d9
		int num = 22;
		long num5 = default(long);
		long num4 = default(long);
		long num3 = default(long);
		long result = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					num5 = offsetEnd;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
				case 8:
					throw new ArgumentOutOfRangeException((string)CnnoiRGXmDFTsgB57bu4(0x6DC147B0 ^ 0x6DC2A72C));
				case 11:
				case 12:
				case 15:
					position = os8v7bGXMCs8GoaRxAOJ(baseStream) - offsetStart;
					num = 27;
					break;
				case 20:
					if (num5 <= offsetEnd)
					{
						num2 = 6;
						continue;
					}
					goto case 3;
				case 23:
					num5 = offsetStart + offset;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 20;
					}
					continue;
				case 13:
					if (num4 >= offsetStart)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 14;
				case 26:
					if (num3 >= offsetStart)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 10;
				default:
					if (num4 > offsetEnd)
					{
						num2 = 2;
						continue;
					}
					goto case 18;
				case 22:
					if (!rQ4RZJGX9kIRqTF0LyA7(this))
					{
						num2 = 21;
						continue;
					}
					if (origin == SeekOrigin.End)
					{
						num2 = 7;
						continue;
					}
					goto case 17;
				case 10:
					num3 = offsetStart;
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 25;
					}
					continue;
				case 5:
				case 6:
					result = lp4SC6GXd7Au6pVIMQm5(baseStream, num5, SeekOrigin.Begin);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 11;
					}
					continue;
				case 18:
					result = lp4SC6GXd7Au6pVIMQm5(baseStream, num4, SeekOrigin.Begin);
					num2 = 15;
					continue;
				case 16:
					throw new ArgumentException((string)mu7oVBGXyUKysLKZ1MWo(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53F4CF9)), (string)CnnoiRGXmDFTsgB57bu4(-1870892489 ^ -1870687557));
				case 17:
					switch (origin)
					{
					case SeekOrigin.Begin:
						break;
					default:
						goto IL_028c;
					case SeekOrigin.End:
						goto IL_0317;
					case SeekOrigin.Current:
						goto IL_034d;
					}
					goto case 23;
				case 21:
					throw new NotSupportedException(SR.T((string)CnnoiRGXmDFTsgB57bu4(-1765851862 ^ -1766006058)));
				case 2:
					num4 = offsetEnd;
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 10;
					}
					continue;
				case 24:
					goto IL_0317;
				case 27:
					return result;
				case 9:
					goto IL_034d;
				case 7:
					if (offset <= 0)
					{
						num2 = 17;
						continue;
					}
					goto case 16;
				case 19:
				case 25:
					result = lp4SC6GXd7Au6pVIMQm5(baseStream, num3, SeekOrigin.Begin);
					num = 12;
					break;
				case 14:
					{
						num4 = offsetStart;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num2 = 1;
						}
						continue;
					}
					IL_034d:
					num4 = os8v7bGXMCs8GoaRxAOJ(baseStream) + offset;
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 5;
					}
					continue;
					IL_0317:
					num3 = offsetEnd + offset;
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 26;
					}
					continue;
					IL_028c:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException((string)mu7oVBGXyUKysLKZ1MWo(CnnoiRGXmDFTsgB57bu4(0x637E299B ^ 0x637DF653)));
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				count = (int)(H8xIWRGXlOFBhOo9st0G(this) - os8v7bGXMCs8GoaRxAOJ(this));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (os8v7bGXMCs8GoaRxAOJ(this) + count > H8xIWRGXlOFBhOo9st0G(this))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			break;
		}
		int result = baseStream.Read(buffer, offset, count);
		position = os8v7bGXMCs8GoaRxAOJ(baseStream) - offsetStart;
		return result;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException(SR.T((string)CnnoiRGXmDFTsgB57bu4(0x35C0467B ^ 0x35C399B3)));
	}

	public override void Close()
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
				FKT5I2GXgBJUIoHYCwqE(baseStream);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object CnnoiRGXmDFTsgB57bu4(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object mu7oVBGXyUKysLKZ1MWo(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static long os8v7bGXMCs8GoaRxAOJ(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static void EJeUbCGXJ6BY5Kg9Ojco(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static bool j7AvxCGXxwUlYBssCLwy()
	{
		return YrgCfqGX7ZD88JchgfG2 == null;
	}

	internal static RangeStreamWrapper bmOLI9GX0LRYBQ9Pnpwl()
	{
		return YrgCfqGX7ZD88JchgfG2;
	}

	internal static bool rQ4RZJGX9kIRqTF0LyA7(object P_0)
	{
		return ((Stream)P_0).CanSeek;
	}

	internal static long lp4SC6GXd7Au6pVIMQm5(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static long H8xIWRGXlOFBhOo9st0G(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static long Sk7BUUGXreMhlDQCE3KJ(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void FKT5I2GXgBJUIoHYCwqE(object P_0)
	{
		((Stream)P_0).Close();
	}
}

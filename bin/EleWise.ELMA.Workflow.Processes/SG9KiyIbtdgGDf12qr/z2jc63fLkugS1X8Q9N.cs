using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using j3AmrhgkCleVTGdEwA;

namespace SG9KiyIbtdgGDf12qr;

internal class z2jc63fLkugS1X8Q9N
{
	private delegate void uKtvKdkBjv4t3TFQBe(object o);

	internal class NifvdpthXyZS3j8XxE : Attribute
	{
		internal class jsT8Vi1nqW2nM6FKKCJ<T>
		{
			internal static object kL2Ow4i6c5gXDD4eMvt;

			public jsT8Vi1nqW2nM6FKKCJ()
			{
				//Discarded unreachable code: IL_0026, IL_002b
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
				base._002Ector();
				int num = 0;
				if (false)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool UqPK8KiRbpf23SnfXFw()
			{
				return kL2Ow4i6c5gXDD4eMvt == null;
			}

			internal static object uTjLlni0M5AoGyJst3D()
			{
				return kL2Ow4i6c5gXDD4eMvt;
			}
		}

		public NifvdpthXyZS3j8XxE(object _0020)
		{
		}
	}

	internal class CIKBY5Ztq9Gg4oE5VU
	{
		internal static string u4iI94Dy8g(string _0020, string _0020)
		{
			byte[] array = (byte[])cV9WvBiihWyFoak9HLw(yWmZrZie36pVeSeMGMb(), _0020);
			byte[] array2 = new byte[32];
			zl4JnCiuylM2ZhVamx0(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] key = array2;
			byte[] array3 = (byte[])fCUTOwilatn3nq48iyb(cV9WvBiihWyFoak9HLw(yWmZrZie36pVeSeMGMb(), _0020));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm)Ot574sifwKGNH6Va2xj();
			symmetricAlgorithm.Key = key;
			qvLl0xiLJvDsDCAYqVH(symmetricAlgorithm, array3);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)fkCPTPiJfMUAO2MZLeD(symmetricAlgorithm), CryptoStreamMode.Write);
			opgFYwirqCcIDqOyUFy(cryptoStream, array, 0, array.Length);
			rqKrUri7bJMWLHt9QwR(cryptoStream);
			return (string)lxuAhTig7LXt7Vkd2Q5(OSYSDWi5GIQGHFHxXNX(memoryStream));
		}

		internal static object yWmZrZie36pVeSeMGMb()
		{
			return Encoding.Unicode;
		}

		internal static object cV9WvBiihWyFoak9HLw(object P_0, object P_1)
		{
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		internal static void zl4JnCiuylM2ZhVamx0(object P_0, RuntimeFieldHandle P_1)
		{
			RuntimeHelpers.InitializeArray((Array)P_0, P_1);
		}

		internal static object fCUTOwilatn3nq48iyb(object P_0)
		{
			return erhwkCleV((byte[])P_0);
		}

		internal static object Ot574sifwKGNH6Va2xj()
		{
			return Q3ljUyvXm();
		}

		internal static void qvLl0xiLJvDsDCAYqVH(object P_0, object P_1)
		{
			((SymmetricAlgorithm)P_0).IV = (byte[])P_1;
		}

		internal static object fkCPTPiJfMUAO2MZLeD(object P_0)
		{
			return ((SymmetricAlgorithm)P_0).CreateEncryptor();
		}

		internal static void opgFYwirqCcIDqOyUFy(object P_0, object P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		internal static void rqKrUri7bJMWLHt9QwR(object P_0)
		{
			((Stream)P_0).Close();
		}

		internal static object OSYSDWi5GIQGHFHxXNX(object P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		internal static object lxuAhTig7LXt7Vkd2Q5(object P_0)
		{
			return Convert.ToBase64String((byte[])P_0);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint vbhv6YuBLBnZE0HBZU(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr XCB0s87BDH0iQKgJ6X();

	internal struct Hmvyw6OJ2VPZUCVIlU
	{
		internal bool MoXISnUino;

		internal byte[] SvYIkqaRc9;
	}

	internal class fjvIDXoHxLTGxlALSK
	{
		private BinaryReader PTIIvZJmfC;

		public fjvIDXoHxLTGxlALSK(Stream _0020)
		{
			PTIIvZJmfC = new BinaryReader(_0020);
		}

		[SpecialName]
		internal Stream m9OIO8Q0EK()
		{
			return PTIIvZJmfC.BaseStream;
		}

		internal byte[] z47It19xek(int _0020)
		{
			return (byte[])taufgnuXTW5h1A2Lsxh(PTIIvZJmfC, _0020);
		}

		internal int NQ1IZyT0jI(byte[] _0020, int _0020, int _0020)
		{
			return CEyUvQuoWYvijoTA03D(PTIIvZJmfC, _0020, _0020, _0020);
		}

		internal int wgZIumIPsF()
		{
			return XKGwAku3BG8IJOOxgZ8(PTIIvZJmfC);
		}

		internal void V26I7M2UXj()
		{
			uQjG80uhVquvCDMb0Ka(PTIIvZJmfC);
		}

		internal static object taufgnuXTW5h1A2Lsxh(object P_0, int P_1)
		{
			return ((BinaryReader)P_0).ReadBytes(P_1);
		}

		internal static int CEyUvQuoWYvijoTA03D(object P_0, object P_1, int P_2, int P_3)
		{
			return ((BinaryReader)P_0).Read((byte[])P_1, P_2, P_3);
		}

		internal static int XKGwAku3BG8IJOOxgZ8(object P_0)
		{
			return ((BinaryReader)P_0).ReadInt32();
		}

		internal static void uQjG80uhVquvCDMb0Ka(object P_0)
		{
			((BinaryReader)P_0).Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr ioC1YcvbZ2yRGgsOBE(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr qAS8QiRs8nbFaA3e0c(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int XNV0uBNIf0hRGLlTer(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int QRRKfBrNJhQuGAsIhZ(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr IQBZqwbrNiAH0AoMWy(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int BJSCyWPgKUiJQGYihL(IntPtr ptr);

	[Flags]
	private enum v6InYtDFWZApx1JyNL
	{

	}

	private static uint[] U6XE6mvyw;

	private static bool GJ23VPZUC;

	private static bool VIl2UgjvI;

	internal static RSACryptoServiceProvider EXHzxLTGx;

	private static Dictionary<int, int> pAL10SKCoC;

	private static object bYc11bZ2yR;

	private static List<string> RaA1I3e0cE;

	private static bool mhL1hZ6InY;

	private static SortedList uFW1iZApx1;

	private static long X4h1A928yN;

	internal static vbhv6YuBLBnZE0HBZU XBV1llcJHV;

	internal static vbhv6YuBLBnZE0HBZU iBN1U8RgNG;

	private static bool QxN19ECe8h;

	private static bool atZ1SSejVu;

	private static ioC1YcvbZ2yRGgsOBE CHf1uRY5iT;

	private static XNV0uBNIf0hRGLlTer PrY1OKksdd;

	private static int RYG1kecuXB;

	private static IntPtr ueQ1CBZqwr;

	private static string WDJ1r9tJFl;

	private static List<int> BV01muBIf0;

	private static int[] Syr1aJSCyW;

	private static IntPtr WB11tRIZxP;

	private static BJSCyWPgKUiJQGYihL D081RjBZ7X;

	private static int Pgs1HOBEQA;

	internal static Hashtable BSI1ZLPHr8;

	private static object t8Q1fis8nb;

	private static bool uU3JCB0s8;

	private static qAS8QiRs8nbFaA3e0c XJ517srtuJ;

	private static byte[] lRG1gLlTer;

	private static IntPtr hyO1NyyabH;

	private static IQBZqwbrNiAH0AoMWy J8t1vEcUBI;

	private static object BiA1jH0AoM;

	internal static Assembly QDHV0iQKg;

	private static int SDV1d6LAgj;

	private static int VyN15LqlEh;

	private static int fKU1wiJQGY;

	private static byte[] QRR1YKfBNJ;

	private static long CoD1QZV1a1;

	private static IntPtr lQu18GAsIh;

	[NifvdpthXyZS3j8XxE(typeof(NifvdpthXyZS3j8XxE.jsT8Vi1nqW2nM6FKKCJ<object>[]))]
	private static bool firstrundone;

	private static QRRKfBrNJhQuGAsIhZ HqA1otFDcJ;

	static z2jc63fLkugS1X8Q9N()
	{
		uU3JCB0s8 = false;
		QDHV0iQKg = typeof(z2jc63fLkugS1X8Q9N).Assembly;
		U6XE6mvyw = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		GJ23VPZUC = false;
		VIl2UgjvI = false;
		EXHzxLTGx = null;
		pAL10SKCoC = null;
		bYc11bZ2yR = new object();
		Pgs1HOBEQA = 0;
		t8Q1fis8nb = new object();
		RaA1I3e0cE = null;
		BV01muBIf0 = null;
		lRG1gLlTer = new byte[0];
		QRR1YKfBNJ = new byte[0];
		lQu18GAsIh = IntPtr.Zero;
		ueQ1CBZqwr = IntPtr.Zero;
		BiA1jH0AoM = new string[0];
		Syr1aJSCyW = new int[0];
		fKU1wiJQGY = 1;
		mhL1hZ6InY = false;
		uFW1iZApx1 = new SortedList();
		VyN15LqlEh = 0;
		X4h1A928yN = 0L;
		XBV1llcJHV = null;
		iBN1U8RgNG = null;
		CoD1QZV1a1 = 0L;
		SDV1d6LAgj = 0;
		QxN19ECe8h = false;
		atZ1SSejVu = false;
		RYG1kecuXB = 0;
		WB11tRIZxP = IntPtr.Zero;
		firstrundone = false;
		BSI1ZLPHr8 = new Hashtable();
		CHf1uRY5iT = null;
		XJ517srtuJ = null;
		PrY1OKksdd = null;
		HqA1otFDcJ = null;
		J8t1vEcUBI = null;
		D081RjBZ7X = null;
		hyO1NyyabH = IntPtr.Zero;
		WDJ1r9tJFl = Encoding.Unicode.GetString(new byte[8] { 134, 123, 241, 8, 24, 98, 77, 199 });
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void OqxuHgeUHF()
	{
	}

	internal static byte[] HImHehMQs(byte[] _0020)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - _0020.Length * 8 % 512 + 512) % 512);
		if (num == 0)
		{
			num = 512u;
		}
		uint num2 = (uint)(_0020.Length + num / 8u + 8);
		ulong num3 = (ulong)_0020.Length * 8uL;
		byte[] array2 = new byte[num2];
		for (int i = 0; i < _0020.Length; i++)
		{
			array2[i] = _0020[i];
		}
		array2[_0020.Length] |= 128;
		for (int num4 = 8; num4 > 0; num4--)
		{
			array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFF);
		}
		uint num5 = (uint)(array2.Length * 8) / 32u;
		uint num6 = 1732584193u;
		uint num7 = 4023233417u;
		uint num8 = 2562383102u;
		uint num9 = 271733878u;
		for (uint num10 = 0u; num10 < num5 / 16u; num10++)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0u; num12 < 61; num12 += 4)
			{
				array[num12 >> 2] = (uint)((array2[num11 + (num12 + 3)] << 24) | (array2[num11 + (num12 + 2)] << 16) | (array2[num11 + (num12 + 1)] << 8) | array2[num11 + num12]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			OdTftVXgR(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			OdTftVXgR(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			OdTftVXgR(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			OdTftVXgR(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			OdTftVXgR(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			OdTftVXgR(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			OdTftVXgR(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			OdTftVXgR(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			OdTftVXgR(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			OdTftVXgR(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			OdTftVXgR(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			OdTftVXgR(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			OdTftVXgR(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			OdTftVXgR(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			OdTftVXgR(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			OdTftVXgR(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			fBSIsFavs(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			fBSIsFavs(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			fBSIsFavs(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			fBSIsFavs(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			fBSIsFavs(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			fBSIsFavs(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			fBSIsFavs(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			fBSIsFavs(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			fBSIsFavs(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			fBSIsFavs(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			fBSIsFavs(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			fBSIsFavs(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			fBSIsFavs(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			fBSIsFavs(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			fBSIsFavs(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			fBSIsFavs(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			lVvm2jc63(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			lVvm2jc63(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			lVvm2jc63(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			lVvm2jc63(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			lVvm2jc63(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			lVvm2jc63(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			lVvm2jc63(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			lVvm2jc63(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			lVvm2jc63(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			lVvm2jc63(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			lVvm2jc63(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			lVvm2jc63(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			lVvm2jc63(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			lVvm2jc63(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			lVvm2jc63(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			lVvm2jc63(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			QkuggS1X8(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			QkuggS1X8(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			QkuggS1X8(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			QkuggS1X8(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			QkuggS1X8(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			QkuggS1X8(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			QkuggS1X8(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			QkuggS1X8(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			QkuggS1X8(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			QkuggS1X8(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			QkuggS1X8(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			QkuggS1X8(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			QkuggS1X8(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			QkuggS1X8(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			QkuggS1X8(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			QkuggS1X8(ref num7, num8, num9, num6, 9u, 21, 64u, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array3, 12, 4);
		return array3;
	}

	private static void OdTftVXgR(ref uint _0020, uint _0020, uint _0020, uint _0020, uint _0020, ushort _0020, uint _0020, object _0020)
	{
		_0020 += q9NYFG9Ki(_0020 + ((_0020 & _0020) | (~_0020 & _0020)) + ((uint[])_0020)[_0020] + U6XE6mvyw[_0020 - 1], _0020);
	}

	private static void fBSIsFavs(ref uint _0020, uint _0020, uint _0020, uint _0020, uint _0020, ushort _0020, uint _0020, object _0020)
	{
		_0020 += q9NYFG9Ki(_0020 + ((_0020 & _0020) | (_0020 & ~_0020)) + ((uint[])_0020)[_0020] + U6XE6mvyw[_0020 - 1], _0020);
	}

	private static void lVvm2jc63(ref uint _0020, uint _0020, uint _0020, uint _0020, uint _0020, ushort _0020, uint _0020, object _0020)
	{
		_0020 += q9NYFG9Ki(_0020 + (_0020 ^ _0020 ^ _0020) + ((uint[])_0020)[_0020] + U6XE6mvyw[_0020 - 1], _0020);
	}

	private static void QkuggS1X8(ref uint _0020, uint _0020, uint _0020, uint _0020, uint _0020, ushort _0020, uint _0020, object _0020)
	{
		_0020 += q9NYFG9Ki(_0020 + (_0020 ^ (_0020 | ~_0020)) + ((uint[])_0020)[_0020] + U6XE6mvyw[_0020 - 1], _0020);
	}

	private static uint q9NYFG9Ki(uint _0020, ushort _0020)
	{
		return (_0020 >> 32 - _0020) | (_0020 << (int)_0020);
	}

	internal static bool Obt8dgGDf()
	{
		if (!GJ23VPZUC)
		{
			f29ajAj3A();
			GJ23VPZUC = true;
		}
		return VIl2UgjvI;
	}

	internal z2jc63fLkugS1X8Q9N()
	{
	}

	private void b2qCrnKW1(byte[] _0020, byte[] _0020, byte[] _0020)
	{
		int num = _0020.Length % 4;
		int num2 = _0020.Length / 4;
		byte[] array = new byte[_0020.Length];
		int num3 = _0020.Length / 4;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = 0u;
		for (int i = 0; i < num2; i++)
		{
			int num8 = i % num3;
			int num9 = i * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((_0020[num7 + 3] << 24) | (_0020[num7 + 2] << 16) | (_0020[num7 + 1] << 8) | _0020[num7]);
			uint num10 = 255u;
			int num11 = 0;
			if (i == num2 - 1 && num > 0)
			{
				num6 = 0u;
				num4 += num5;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num6 <<= 8;
					}
					num6 |= _0020[_0020.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num5;
				num7 = (uint)num9;
				num6 = (uint)((_0020[num7 + 3] << 24) | (_0020[num7 + 2] << 16) | (_0020[num7 + 1] << 8) | _0020[num7]);
			}
			uint num12 = num4;
			num4 = 0u;
			uint num13 = 1832962346u;
			uint num14 = 109325984u;
			uint num15 = 536468205u;
			uint num16 = num12;
			uint num17 = 1111992918u;
			uint num18 = 1687821375u;
			if ((double)num15 == 0.0)
			{
				num15--;
			}
			uint num19 = (uint)(1961001956.0 / (double)num15 + (double)num15);
			if (num19 == 0)
			{
				num19--;
			}
			num15 = (uint)((uint)((double)(short)num17 + (double)num14) / num19 + (short)num17);
			num17 = 96758114 * (num17 & 0x1F) + (num17 >> 5);
			num15 = 94429065 * (num15 & 0x1F) - (num15 >> 5);
			num14 = 43407 * num14 - num13;
			uint num20 = num14 & 0xF0F0F0Fu;
			uint num21 = num14 & 0xF0F0F0F0u;
			num20 = ((num20 >> 4) | (num21 << 4)) ^ num15;
			num14 = (num14 >> 4) | (num14 << 28);
			num17 = (num15 - 392968057) ^ num15;
			uint num22 = num18 & 0xFF00FFu;
			uint num23 = num18 & 0xFF00FF00u;
			num22 = ((num22 >> 8) | (num23 << 8)) ^ num15;
			num18 = (num18 >> 5) | (num18 << 27);
			num16 ^= num16 >> 28;
			num16 += num14;
			num16 ^= num16 << 3;
			num16 += num17;
			num16 ^= num16 >> 3;
			num16 += num18;
			num16 = (((num17 << 21) - num17) ^ num17) - num16;
			num4 = num12 + (uint)(double)num16;
			if (i == num2 - 1 && num > 0)
			{
				uint num24 = num4 ^ num6;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num9 + k] = (byte)((num24 & num10) >> num11);
				}
			}
			else
			{
				uint num25 = num4 ^ num6;
				array[num9] = (byte)(num25 & 0xFFu);
				array[num9 + 1] = (byte)((num25 & 0xFF00) >> 8);
				array[num9 + 2] = (byte)((num25 & 0xFF0000) >> 16);
				array[num9 + 3] = (byte)((num25 & 0xFF000000u) >> 24);
			}
		}
		lRG1gLlTer = array;
	}

	internal static SymmetricAlgorithm Q3ljUyvXm()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (Obt8dgGDf())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
		}
	}

	internal static void f29ajAj3A()
	{
		try
		{
			VIl2UgjvI = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] erhwkCleV(byte[] _0020)
	{
		if (!Obt8dgGDf())
		{
			return new MD5CryptoServiceProvider().ComputeHash(_0020);
		}
		return HImHehMQs(_0020);
	}

	internal static void IGdhEwAds(HashAlgorithm _0020, Stream _0020, uint _0020, byte[] _0020)
	{
		while (_0020 != 0)
		{
			int num = ((_0020 > (uint)_0020.Length) ? _0020.Length : ((int)_0020));
			_0020.Read(_0020, 0, num);
			W27iiB524(_0020, _0020, 0, num);
			_0020 -= (uint)num;
		}
	}

	internal static void W27iiB524(HashAlgorithm _0020, byte[] _0020, int _0020, int _0020)
	{
		_0020.TransformBlock(_0020, _0020, _0020, _0020, _0020);
	}

	internal static uint u2u5sC5LH(uint _0020, int _0020, long _0020, BinaryReader _0020)
	{
		for (int i = 0; i < _0020; i++)
		{
			_0020.BaseStream.Position = _0020 + (i * 40 + 8);
			uint num = _0020.ReadUInt32();
			uint num2 = _0020.ReadUInt32();
			_0020.ReadUInt32();
			uint num3 = _0020.ReadUInt32();
			if (num2 <= _0020 && _0020 < num2 + num)
			{
				return num3 + _0020 - num2;
			}
		}
		return 0u;
	}

	public static void uu5l0PqDX(RuntimeTypeHandle _0020)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(_0020);
			if (pAL10SKCoC == null)
			{
				lock (bYc11bZ2yR)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(z2jc63fLkugS1X8Q9N).Assembly.GetManifestResourceStream("2jwRvhsc7v4q1bCnCK.ogAmVm2nRUAbSpW0HG"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[array.Length - (1 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							num3 += UyNdJOArH(num3);
							if (i == num2 - 1 && num > 0)
							{
								uint num9 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num9 & num7) >> num8);
								}
							}
							else
							{
								uint num10 = num3 ^ num4;
								array2[num6] = (byte)(num10 & 0xFFu);
								array2[num6 + 1] = (byte)((num10 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num10 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num11 = array.Length / 8;
						fjvIDXoHxLTGxlALSK fjvIDXoHxLTGxlALSK = new fjvIDXoHxLTGxlALSK(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = fjvIDXoHxLTGxlALSK.wgZIumIPsF();
							int value = fjvIDXoHxLTGxlALSK.wgZIumIPsF();
							dictionary.Add(key, value);
						}
						fjvIDXoHxLTGxlALSK.V26I7M2UXj();
					}
					pAL10SKCoC = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = pAL10SKCoC[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)typeof(z2jc63fLkugS1X8Q9N).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
						continue;
					}
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num13 = parameters.Length + 1;
					Type[] array3 = new Type[num13];
					if (methodInfo.DeclaringType.IsValueType)
					{
						array3[0] = methodInfo.DeclaringType.MakeByRefType();
					}
					else
					{
						array3[0] = typeof(object);
					}
					for (int n = 0; n < parameters.Length; n++)
					{
						array3[n + 1] = parameters[n].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					for (int num14 = 0; num14 < num13; num14++)
					{
						switch (num14)
						{
						case 0:
							iLGenerator.Emit(OpCodes.Ldarg_0);
							break;
						case 1:
							iLGenerator.Emit(OpCodes.Ldarg_1);
							break;
						case 2:
							iLGenerator.Emit(OpCodes.Ldarg_2);
							break;
						case 3:
							iLGenerator.Emit(OpCodes.Ldarg_3);
							break;
						default:
							iLGenerator.Emit(OpCodes.Ldarg_S, num14);
							break;
						}
					}
					iLGenerator.Emit(OpCodes.Tailcall);
					iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					iLGenerator.Emit(OpCodes.Ret);
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
				}
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint sFXQYxgj0(uint _0020)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint UyNdJOArH(uint _0020)
	{
		return 0u;
	}

	internal static void rQ19jmJab()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void dr5SSqLSS(object _0020, int _0020)
	{
		//Discarded unreachable code: IL_0708, IL_0717, IL_08b2, IL_08c1, IL_0fc5, IL_0fd4, IL_1900, IL_320b, IL_321a
		int num = 132;
		int num6 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] array6 = default(byte[]);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		int num5 = default(int);
		byte[] array5 = default(byte[]);
		Stream stream = default(Stream);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 378:
					num6 = 233 - 77;
					num = 141;
					break;
				case 258:
					num3 = 44 + 93;
					num2 = 1;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 302;
					}
					continue;
				case 308:
					num4 = 43 + 84;
					num2 = 354;
					continue;
				case 58:
					array2[3] = 46;
					num2 = 148;
					continue;
				case 234:
					array[10] = 158;
					num2 = 13;
					continue;
				case 136:
					num3 = 28 + 106;
					num = 285;
					break;
				case 260:
					num3 = 22 + 111;
					num2 = 147;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 150;
					}
					continue;
				case 276:
					array[9] = (byte)num6;
					num2 = 74;
					continue;
				case 198:
					num3 = 173 - 83;
					num2 = 190;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 97;
					}
					continue;
				case 57:
					array[7] = 166;
					num = 12;
					break;
				case 163:
					num3 = 105 + 52;
					num2 = 359;
					continue;
				case 290:
					array2[19] = (byte)num3;
					num2 = 278;
					continue;
				case 36:
					array2[30] = (byte)num3;
					num = 238;
					break;
				case 296:
					num3 = 115 - 31;
					num2 = 365;
					continue;
				case 96:
					num3 = 225 - 75;
					num2 = 363;
					continue;
				case 119:
					array2[5] = (byte)num3;
					num2 = 95;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 170;
					}
					continue;
				case 89:
					num6 = 115 + 109;
					num2 = 300;
					continue;
				case 331:
				{
					object obj = VpWWhV4bJg3VWkB56w();
					oRcvyd9gj2ryIs574o(obj, CipherMode.CBC);
					transform = (ICryptoTransform)lbjG91TSV6WVGnrBpa(obj, array6, array3);
					num2 = 3;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 39;
					}
					continue;
				}
				case 364:
					array2[15] = (byte)num3;
					num2 = 198;
					continue;
				case 230:
					array3[11] = array4[5];
					num = 317;
					break;
				case 182:
					array[14] = 104;
					num2 = 254;
					continue;
				case 139:
					array2[30] = (byte)num3;
					num2 = 130;
					continue;
				case 243:
					array2[21] = (byte)num3;
					num2 = 214;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 226;
					}
					continue;
				case 209:
					array[15] = 73;
					num2 = 9;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 256;
					}
					continue;
				case 200:
					array2[16] = 116;
					num2 = 51;
					continue;
				case 99:
					array[12] = (byte)num4;
					num2 = 283;
					continue;
				case 135:
					num3 = 181 + 11;
					num2 = 69;
					continue;
				case 338:
					num3 = 68 + 101;
					num2 = 329;
					continue;
				case 23:
					array2[3] = 124;
					num2 = 62;
					continue;
				case 323:
					array2[0] = 87;
					num2 = 150;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 188;
					}
					continue;
				case 280:
					array2[30] = 98;
					num2 = 295;
					continue;
				case 78:
					array2[2] = 164;
					num2 = 55;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 31;
					}
					continue;
				case 300:
					array[3] = (byte)num6;
					num2 = 327;
					continue;
				case 333:
					array2[20] = (byte)num3;
					num2 = 272;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 121;
					}
					continue;
				case 223:
					array2[3] = (byte)num3;
					num2 = 10;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 27;
					}
					continue;
				case 288:
					num6 = 198 - 66;
					num2 = 276;
					continue;
				case 86:
					array2[0] = (byte)num3;
					num2 = 217;
					continue;
				case 325:
					num4 = 243 - 81;
					num2 = 56;
					continue;
				case 90:
					array[2] = (byte)num4;
					num2 = 6;
					continue;
				case 117:
					num3 = 174 - 58;
					num2 = 41;
					continue;
				case 259:
					num3 = 248 - 82;
					num = 239;
					break;
				case 247:
					array2[31] = 137;
					num2 = 88;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 184;
					}
					continue;
				case 303:
					array2[18] = (byte)num3;
					num2 = 48;
					continue;
				case 232:
					array2[2] = (byte)num3;
					num2 = 193;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 150;
					}
					continue;
				case 44:
				case 207:
				case 297:
					num5 = 0;
					num2 = 6;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 352;
					}
					continue;
				case 59:
					array[15] = 43;
					num2 = 71;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 95;
					}
					continue;
				case 112:
					array2[18] = (byte)num3;
					num2 = 337;
					continue;
				case 286:
					num3 = 79 - 60;
					num2 = 294;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 37;
					}
					continue;
				case 52:
					num6 = 74 - 55;
					num2 = 134;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 221;
					}
					continue;
				case 342:
					num3 = 67 + 104;
					num2 = 237;
					continue;
				case 372:
					num3 = 126 - 60;
					num2 = 370;
					continue;
				case 321:
					num3 = 231 - 77;
					num2 = 155;
					continue;
				case 298:
					array3[5] = array4[2];
					num2 = 371;
					continue;
				case 114:
					array2[27] = (byte)num3;
					num2 = 338;
					continue;
				case 291:
					array2[7] = (byte)num3;
					num2 = 68;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 12;
					}
					continue;
				case 270:
					array2[15] = 131;
					num2 = 205;
					continue;
				case 35:
					array2[6] = 108;
					num2 = 81;
					continue;
				case 124:
					array[1] = 157;
					num2 = 215;
					continue;
				case 175:
					array[4] = 70;
					num2 = 262;
					continue;
				case 45:
					array2[22] = (byte)num3;
					num2 = 259;
					continue;
				case 64:
					array2[26] = 97;
					num2 = 339;
					continue;
				case 282:
					num3 = 40 + 97;
					num2 = 246;
					continue;
				case 141:
					array[0] = (byte)num6;
					num2 = 61;
					continue;
				case 351:
					num3 = 28 + 45;
					num2 = 302;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 318;
					}
					continue;
				case 357:
					array2[1] = (byte)num3;
					num2 = 336;
					continue;
				case 233:
					array[12] = (byte)num4;
					num2 = 197;
					continue;
				case 72:
					array = new byte[16];
					num2 = 137;
					continue;
				case 144:
					array2[8] = (byte)num3;
					num2 = 350;
					continue;
				case 328:
					array[2] = 145;
					num2 = 310;
					continue;
				case 293:
					array2[11] = (byte)num3;
					num2 = 66;
					continue;
				case 222:
					num3 = 55 + 91;
					num = 357;
					break;
				case 231:
					array2[13] = (byte)num3;
					num2 = 47;
					continue;
				case 265:
					num3 = 43 + 117;
					num2 = 140;
					continue;
				case 40:
					array[12] = (byte)num4;
					num = 377;
					break;
				case 358:
					num3 = 197 - 65;
					num2 = 187;
					continue;
				case 304:
					array[1] = (byte)num4;
					num2 = 182;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 214;
					}
					continue;
				case 50:
					num6 = 185 - 116;
					num = 176;
					break;
				case 246:
					array2[9] = (byte)num3;
					num2 = 319;
					continue;
				case 273:
					array2[18] = (byte)num3;
					num2 = 2;
					continue;
				case 371:
					array3[7] = array4[3];
					num2 = 164;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 227;
					}
					continue;
				case 116:
					array6 = array2;
					num2 = 72;
					continue;
				case 4:
					num3 = 209 - 69;
					num2 = 129;
					continue;
				case 66:
					num3 = 32 + 15;
					num2 = 71;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 80;
					}
					continue;
				case 227:
					array3[9] = array4[4];
					num2 = 52;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 230;
					}
					continue;
				case 341:
					array2[17] = 103;
					num2 = 361;
					continue;
				case 172:
					if (array4.Length == 0)
					{
						num2 = 205;
						if (Rx4Kp3QFcEobYsaHUH() == null)
						{
							num2 = 207;
						}
						continue;
					}
					goto case 244;
				case 185:
					array2[7] = (byte)num3;
					num2 = 64;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 133;
					}
					continue;
				case 181:
					array2[29] = (byte)num3;
					num2 = 146;
					continue;
				case 196:
					array2[8] = (byte)num3;
					num2 = 340;
					continue;
				case 113:
					num3 = 143 + 100;
					num = 289;
					break;
				case 74:
					num4 = 85 + 14;
					num2 = 212;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 101;
					}
					continue;
				case 152:
					num3 = 49 - 40;
					num2 = 223;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 136;
					}
					continue;
				case 366:
					array2[27] = (byte)num3;
					num = 104;
					break;
				case 2:
					array2[18] = 116;
					num2 = 100;
					continue;
				case 156:
					array2[26] = (byte)num3;
					num2 = 163;
					continue;
				case 157:
					array2[16] = 179;
					num2 = 341;
					continue;
				case 343:
					array[4] = (byte)num4;
					num2 = 175;
					continue;
				case 37:
					array[5] = (byte)num4;
					num2 = 158;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 180;
					}
					continue;
				case 24:
					num3 = 87 + 98;
					num2 = 348;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 166;
					}
					continue;
				case 248:
					array2[24] = 155;
					num2 = 117;
					continue;
				case 332:
					array2[27] = (byte)num3;
					num2 = 46;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 93;
					}
					continue;
				case 164:
					array2[12] = (byte)num3;
					num2 = 98;
					continue;
				case 111:
					array2[23] = (byte)num3;
					num2 = 4;
					continue;
				case 189:
					array2[2] = 120;
					num2 = 65;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 20;
					}
					continue;
				case 103:
					array2[31] = 112;
					num2 = 247;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 175;
					}
					continue;
				case 339:
					array2[26] = 98;
					num2 = 35;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 101;
					}
					continue;
				case 374:
					if (!VBZBocbdbUOZR9WUXn(GVkfyCkuofCFxsuxN9(QDHV0iQKg), null))
					{
						num2 = 307;
						if (Rx4Kp3QFcEobYsaHUH() != null)
						{
							num2 = 276;
						}
						continue;
					}
					goto case 275;
				case 201:
					array[11] = (byte)num6;
					num2 = 22;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 11;
					}
					continue;
				case 215:
					num4 = 156 - 52;
					num2 = 38;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 165;
					}
					continue;
				case 51:
					num3 = 11 + 48;
					num2 = 73;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 33;
					}
					continue;
				case 115:
					array[2] = 140;
					num = 328;
					break;
				case 6:
					num6 = 38 + 47;
					num2 = 263;
					continue;
				case 180:
					num4 = 167 - 55;
					num2 = 128;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 299;
					}
					continue;
				case 226:
					num3 = 180 - 60;
					num2 = 219;
					continue;
				case 176:
					array[13] = (byte)num6;
					num = 182;
					break;
				case 21:
					array[12] = 152;
					num2 = 119;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 168;
					}
					continue;
				case 110:
					if (_0020 == -1)
					{
						num2 = 331;
						continue;
					}
					goto case 374;
				case 347:
					num3 = 168 + 41;
					num2 = 11;
					continue;
				case 77:
					num4 = 30 + 1;
					num2 = 376;
					continue;
				case 121:
				case 345:
					array6[num5] = (byte)(array6[num5] ^ array3[num5]);
					num = 353;
					break;
				case 224:
					array[4] = 146;
					num2 = 216;
					continue;
				case 13:
					num6 = 214 - 71;
					num2 = 3;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 28;
					}
					continue;
				case 344:
					array2[13] = 74;
					num2 = 373;
					continue;
				case 137:
					num4 = 100 + 34;
					num2 = 143;
					continue;
				case 170:
					num3 = 125 - 41;
					num = 142;
					break;
				case 365:
					array2[22] = (byte)num3;
					num2 = 3;
					continue;
				case 68:
					num3 = 128 - 42;
					num2 = 144;
					continue;
				case 160:
					num4 = 108 - 78;
					num2 = 268;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 189;
					}
					continue;
				case 199:
					num3 = 205 - 68;
					num2 = 9;
					continue;
				case 70:
					array[9] = 171;
					num2 = 67;
					continue;
				case 30:
					array2[14] = 120;
					num2 = 95;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 314;
					}
					continue;
				case 108:
					num3 = 201 - 67;
					num2 = 88;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 203;
					}
					continue;
				case 254:
					array[14] = 142;
					num2 = 274;
					continue;
				case 174:
					array[3] = (byte)num6;
					num2 = 1;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 1;
					}
					continue;
				case 67:
					array[9] = 10;
					num = 211;
					break;
				case 287:
					num6 = 251 - 83;
					num2 = 106;
					continue;
				case 91:
					num3 = 163 - 54;
					num2 = 103;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 179;
					}
					continue;
				case 28:
					array[10] = (byte)num6;
					num2 = 7;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 16;
					}
					continue;
				case 319:
					num3 = 124 + 83;
					num2 = 171;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 110;
					}
					continue;
				case 330:
					array[6] = (byte)num4;
					num2 = 57;
					continue;
				case 370:
					array2[26] = (byte)num3;
					num2 = 109;
					continue;
				case 269:
					array2[12] = (byte)num3;
					num2 = 202;
					continue;
				case 83:
					array2[29] = (byte)num3;
					num2 = 280;
					continue;
				case 221:
					array[8] = (byte)num6;
					num2 = 26;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 288;
					}
					continue;
				case 206:
					array2[13] = (byte)num3;
					num2 = 240;
					continue;
				case 237:
					array2[11] = (byte)num3;
					num2 = 334;
					continue;
				case 362:
					array2[1] = 148;
					num2 = 222;
					continue;
				case 123:
					array2[21] = (byte)num3;
					num2 = 79;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 37;
					}
					continue;
				case 264:
					array2[6] = (byte)num3;
					num2 = 35;
					continue;
				case 129:
					array2[23] = (byte)num3;
					num2 = 18;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 108;
					}
					continue;
				case 275:
					Pgs1HOBEQA = 80;
					num2 = 322;
					continue;
				case 80:
					array2[11] = (byte)num3;
					num2 = 342;
					continue;
				case 142:
					array2[5] = (byte)num3;
					num2 = 313;
					continue;
				case 205:
					num3 = 3 + 8;
					num2 = 75;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 50;
					}
					continue;
				case 27:
					array2[4] = 79;
					num2 = 265;
					continue;
				case 131:
					array2 = new byte[32];
					num2 = 323;
					continue;
				case 329:
					array2[27] = (byte)num3;
					num2 = 257;
					continue;
				case 192:
					array2[6] = (byte)num3;
					num2 = 8;
					continue;
				case 134:
					return;
				case 120:
					num6 = 42 + 32;
					num2 = 367;
					continue;
				case 236:
					num3 = 144 - 120;
					num2 = 112;
					continue;
				case 284:
					array4 = (byte[])RdJIiMPgx7n2yjxve3(wdpOQFvtOJfEP7ip3g(QDHV0iQKg));
					num2 = 31;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 122;
					}
					continue;
				case 289:
					array2[28] = (byte)num3;
					num2 = 208;
					continue;
				case 314:
					array2[14] = 172;
					num2 = 128;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 74;
					}
					continue;
				case 76:
					array2[28] = (byte)num3;
					num2 = 113;
					continue;
				case 274:
					array[14] = 203;
					num2 = 209;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 60;
					}
					continue;
				case 34:
					num3 = 13 + 11;
					num2 = 264;
					continue;
				case 147:
					array2[28] = (byte)num3;
					num2 = 29;
					continue;
				case 31:
					array[3] = 100;
					num2 = 89;
					continue;
				case 177:
					array2[2] = (byte)num3;
					num2 = 189;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 50;
					}
					continue;
				case 229:
					array2[10] = 199;
					num2 = 102;
					continue;
				case 149:
					num3 = 108 + 99;
					num2 = 194;
					continue;
				case 56:
					array[15] = (byte)num4;
					num2 = 11;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 59;
					}
					continue;
				case 169:
					array2[17] = (byte)num3;
					num2 = 96;
					continue;
				case 279:
					array[0] = 111;
					num2 = 14;
					continue;
				case 167:
					array2[17] = 145;
					num2 = 355;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 33;
					}
					continue;
				case 367:
					array[4] = (byte)num6;
					num2 = 349;
					continue;
				case 19:
					array3[3] = array4[1];
					num2 = 298;
					continue;
				case 225:
					num3 = 98 + 43;
					num2 = 60;
					continue;
				case 299:
					array[5] = (byte)num4;
					num2 = 308;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 278;
					}
					continue;
				case 249:
					array2[4] = 150;
					num2 = 309;
					continue;
				case 128:
					num3 = 121 + 6;
					num2 = 63;
					continue;
				case 212:
					array[9] = (byte)num4;
					num2 = 153;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 38;
					}
					continue;
				case 191:
					array2[13] = (byte)num3;
					num2 = 173;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 267;
					}
					continue;
				case 29:
					num3 = 125 - 41;
					num2 = 24;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 76;
					}
					continue;
				case 18:
					array2[19] = (byte)num3;
					num2 = 91;
					continue;
				case 92:
					num4 = 80 + 120;
					num2 = 233;
					continue;
				case 214:
					array[1] = 142;
					num2 = 173;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 147;
					}
					continue;
				case 140:
					array2[4] = (byte)num3;
					num2 = 102;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 249;
					}
					continue;
				case 60:
					array2[25] = (byte)num3;
					num2 = 62;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 149;
					}
					continue;
				case 311:
					array[8] = 15;
					num2 = 43;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 241;
					}
					continue;
				case 245:
					array[10] = 110;
					num2 = 234;
					continue;
				case 235:
					array2[26] = 93;
					num = 372;
					break;
				case 361:
					num3 = 110 + 49;
					num2 = 169;
					continue;
				case 75:
					array2[15] = (byte)num3;
					num2 = 315;
					continue;
				case 171:
					array2[9] = (byte)num3;
					num2 = 228;
					continue;
				case 8:
					num3 = 207 - 69;
					num2 = 185;
					continue;
				case 65:
					num3 = 3 + 20;
					num2 = 232;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 30;
					}
					continue;
				case 315:
					array2[15] = 153;
					num2 = 118;
					continue;
				case 15:
					array[9] = (byte)num6;
					num = 70;
					break;
				case 252:
					array2[20] = (byte)num3;
					num2 = 266;
					continue;
				case 158:
					array2[21] = 131;
					num2 = 218;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 183;
					}
					continue;
				case 317:
					array3[13] = array4[6];
					num = 161;
					break;
				case 278:
					num3 = 249 - 83;
					num2 = 333;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 308;
					}
					continue;
				case 375:
					array2[19] = (byte)num3;
					num2 = 168;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 250;
					}
					continue;
				case 377:
					array[13] = 164;
					num = 220;
					break;
				case 127:
					array2[9] = 15;
					num2 = 199;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 23;
					}
					continue;
				case 197:
					num4 = 115 + 2;
					num = 99;
					break;
				case 195:
					num3 = 66 + 62;
					num2 = 60;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 364;
					}
					continue;
				case 216:
					array[4] = 224;
					num2 = 120;
					continue;
				case 165:
					array[1] = (byte)num4;
					num = 277;
					break;
				case 257:
					num3 = 8 + 120;
					num2 = 366;
					continue;
				case 187:
					array2[24] = (byte)num3;
					num2 = 85;
					continue;
				case 359:
					array2[26] = (byte)num3;
					num = 235;
					break;
				case 107:
					array2[11] = 162;
					num2 = 25;
					continue;
				case 356:
					array[3] = 107;
					num2 = 261;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 40;
					}
					continue;
				case 272:
					array2[20] = 155;
					num2 = 33;
					continue;
				case 353:
					num5++;
					num2 = 0;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 0;
					}
					continue;
				case 266:
					num3 = 178 - 59;
					num2 = 123;
					continue;
				case 101:
					num3 = 144 - 48;
					num2 = 4;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 156;
					}
					continue;
				case 38:
					array5 = lRG1gLlTer;
					num2 = 374;
					continue;
				case 295:
					num3 = 144 - 48;
					num2 = 122;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 139;
					}
					continue;
				case 190:
					array2[15] = (byte)num3;
					num2 = 166;
					continue;
				case 179:
					array2[19] = (byte)num3;
					num2 = 14;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 54;
					}
					continue;
				case 85:
					array2[24] = 45;
					num = 258;
					break;
				case 193:
					num3 = 144 + 46;
					num2 = 10;
					continue;
				case 122:
					if (array4 == null)
					{
						num2 = 297;
						continue;
					}
					goto case 172;
				case 133:
					num3 = 77 + 107;
					num2 = 162;
					continue;
				case 14:
					num4 = 146 - 48;
					num2 = 255;
					continue;
				case 126:
					num3 = 60 + 106;
					num2 = 82;
					continue;
				case 11:
					array2[0] = (byte)num3;
					num2 = 362;
					continue;
				case 16:
					num4 = 135 + 90;
					num2 = 301;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 155;
					}
					continue;
				case 194:
					array2[25] = (byte)num3;
					num2 = 64;
					continue;
				case 87:
					array[3] = (byte)num6;
					num2 = 31;
					continue;
				case 250:
					array2[19] = 169;
					num2 = 138;
					continue;
				case 360:
					num3 = 211 - 70;
					num2 = 303;
					continue;
				case 178:
					num6 = 230 + 22;
					num2 = 324;
					continue;
				case 46:
				{
					CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					hAlrxYNdPmRCiYEVyE(cryptoStream, array5, 0, array5.Length);
					um1CNydIBftfEFJfoU(cryptoStream);
					lRG1gLlTer = (byte[])wa3buJj224uuxSe0EZ(stream);
					EDMxUbSJiMu6HsEHBx(stream);
					EDMxUbSJiMu6HsEHBx(cryptoStream);
					num2 = 38;
					continue;
				}
				case 69:
					array2[5] = (byte)num3;
					num2 = 34;
					continue;
				case 55:
					num3 = 240 - 80;
					num2 = 177;
					continue;
				case 173:
					num4 = 241 - 80;
					num2 = 133;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 253;
					}
					continue;
				case 307:
				case 322:
					new z2jc63fLkugS1X8Q9N().b2qCrnKW1(array6, array3, array5);
					num2 = 73;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 134;
					}
					continue;
				case 84:
					num3 = 166 + 83;
					num2 = 332;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 258;
					}
					continue;
				case 49:
					num3 = 167 - 55;
					num2 = 38;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 45;
					}
					continue;
				case 204:
					array[1] = (byte)num4;
					num2 = 147;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 305;
					}
					continue;
				case 154:
					array[6] = 233;
					num2 = 77;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 13;
					}
					continue;
				case 1:
					num6 = 30 + 32;
					num = 87;
					break;
				case 240:
					array2[14] = 116;
					num2 = 22;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 30;
					}
					continue;
				case 93:
					num3 = 35 + 79;
					num2 = 147;
					continue;
				case 363:
					array2[17] = (byte)num3;
					num2 = 167;
					continue;
				case 88:
					num3 = 171 - 81;
					num2 = 290;
					continue;
				case 150:
					array2[9] = (byte)num3;
					num2 = 127;
					continue;
				case 104:
					num3 = 139 - 46;
					num2 = 7;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 7;
					}
					continue;
				case 25:
					num3 = 37 + 17;
					num2 = 269;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 71;
					}
					continue;
				case 327:
					array[3] = 132;
					num2 = 356;
					continue;
				case 268:
					array[11] = (byte)num4;
					num2 = 92;
					continue;
				case 151:
					array2[11] = (byte)num3;
					num2 = 136;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 33;
					}
					continue;
				case 109:
					num3 = 60 + 30;
					num2 = 114;
					continue;
				case 39:
					stream = (Stream)tXaIW8cLFjNuMsiAJG();
					num2 = 46;
					continue;
				case 292:
					num3 = 119 + 31;
					num2 = 181;
					continue;
				case 255:
					array[0] = (byte)num4;
					num = 378;
					break;
				case 97:
					num4 = 112 + 97;
					num2 = 304;
					continue;
				case 218:
					num3 = 231 - 108;
					num2 = 213;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 243;
					}
					continue;
				case 47:
					num3 = 206 - 68;
					num2 = 191;
					continue;
				case 310:
					num6 = 126 - 42;
					num2 = 174;
					continue;
				case 33:
					array2[20] = 116;
					num2 = 183;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 112;
					}
					continue;
				case 183:
					num3 = 142 - 53;
					num2 = 252;
					continue;
				case 355:
					num3 = 38 + 47;
					num2 = 273;
					continue;
				case 213:
					num6 = 59 + 65;
					num2 = 201;
					continue;
				case 340:
					num3 = 109 + 121;
					num2 = 53;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 50;
					}
					continue;
				case 241:
					array[8] = 86;
					num2 = 31;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 52;
					}
					continue;
				case 9:
					array2[10] = (byte)num3;
					num2 = 26;
					continue;
				case 277:
					num4 = 46 - 28;
					num = 204;
					break;
				case 71:
					array2[18] = (byte)num3;
					num2 = 236;
					continue;
				case 346:
					num3 = 144 + 21;
					num2 = 291;
					continue;
				case 42:
					jXGlqfYM6PLneeTPfl(array3);
					num2 = 135;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 284;
					}
					continue;
				case 43:
					array2[12] = 201;
					num = 344;
					break;
				case 238:
					array2[30] = 128;
					num2 = 57;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 186;
					}
					continue;
				case 118:
					array2[15] = 195;
					num2 = 35;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 195;
					}
					continue;
				case 20:
					array[10] = (byte)num6;
					num2 = 245;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 232;
					}
					continue;
				case 210:
					num4 = 85 + 106;
					num = 90;
					break;
				case 98:
					array2[12] = 70;
					num2 = 5;
					continue;
				case 313:
					array2[5] = 129;
					num2 = 135;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 53;
					}
					continue;
				case 79:
					array2[21] = 112;
					num2 = 158;
					continue;
				case 251:
					array2[24] = 161;
					num2 = 248;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 94;
					}
					continue;
				case 217:
					array2[0] = 105;
					num2 = 347;
					continue;
				case 334:
					num3 = 140 - 46;
					num2 = 151;
					continue;
				case 63:
					array2[14] = (byte)num3;
					num2 = 59;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 270;
					}
					continue;
				case 305:
					array[2] = 216;
					num2 = 287;
					continue;
				case 106:
					array[2] = (byte)num6;
					num2 = 210;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 124;
					}
					continue;
				case 146:
					num3 = 37 - 34;
					num2 = 83;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 11;
					}
					continue;
				case 186:
					array2[30] = 86;
					num2 = 125;
					continue;
				case 61:
					array[0] = 159;
					num2 = 3;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 97;
					}
					continue;
				case 368:
					array2[3] = (byte)num3;
					num2 = 152;
					continue;
				case 316:
					array[15] = 131;
					num2 = 325;
					continue;
				case 326:
					array2[31] = (byte)num3;
					num2 = 116;
					continue;
				case 256:
					array[15] = 126;
					num2 = 316;
					continue;
				case 162:
					array2[7] = (byte)num3;
					num2 = 346;
					continue;
				case 138:
					num3 = 55 + 6;
					num2 = 18;
					continue;
				case 369:
					array[8] = 92;
					num2 = 311;
					continue;
				case 208:
					array2[29] = 53;
					num2 = 32;
					continue;
				case 239:
					array2[22] = (byte)num3;
					num2 = 296;
					continue;
				case 348:
					array2[29] = (byte)num3;
					num2 = 62;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 292;
					}
					continue;
				case 324:
					array[7] = (byte)num6;
					num2 = 218;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 271;
					}
					continue;
				case 336:
					array2[1] = 31;
					num = 78;
					break;
				case 53:
					array2[8] = (byte)num3;
					num2 = 145;
					continue;
				case 306:
					num3 = 236 - 78;
					num2 = 164;
					continue;
				case 62:
					array2[3] = 166;
					num2 = 58;
					continue;
				case 32:
					array2[29] = 86;
					num2 = 94;
					continue;
				case 244:
					array3[1] = array4[0];
					num2 = 19;
					continue;
				case 281:
					array[12] = (byte)num6;
					num2 = 21;
					continue;
				case 10:
					array2[2] = (byte)num3;
					num2 = 23;
					continue;
				case 159:
					num4 = 63 + 122;
					num2 = 291;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 320;
					}
					continue;
				case 155:
					array2[5] = (byte)num3;
					num2 = 24;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 335;
					}
					continue;
				case 168:
					num4 = 95 + 93;
					num2 = 40;
					continue;
				case 54:
					num3 = 179 - 59;
					num = 105;
					break;
				case 130:
					num3 = 135 - 45;
					num2 = 36;
					continue;
				case 143:
					array[0] = (byte)num4;
					num2 = 279;
					continue;
				case 3:
					num3 = 114 + 117;
					num2 = 111;
					continue;
				case 283:
					num6 = 154 - 51;
					num2 = 281;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 136;
					}
					continue;
				case 294:
					array2[23] = (byte)num3;
					num2 = 235;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 251;
					}
					continue;
				case 202:
					array2[12] = 137;
					num2 = 306;
					continue;
				case 188:
					num3 = 86 + 110;
					num2 = 86;
					continue;
				case 132:
				{
					fjvIDXoHxLTGxlALSK fjvIDXoHxLTGxlALSK = new fjvIDXoHxLTGxlALSK((Stream)_0020);
					LGeYnVDdT2CivnOLh2(lnXcrNV3C9uXP7EqV4(fjvIDXoHxLTGxlALSK), 0L);
					array5 = (byte[])v6rGUNMeU0gI5UEhUF(fjvIDXoHxLTGxlALSK, (int)dFrFUSKFZ7XHf7iOHi(lnXcrNV3C9uXP7EqV4(fjvIDXoHxLTGxlALSK)));
					Mqj4cQaGTvfNhqY5uJ(fjvIDXoHxLTGxlALSK);
					num2 = 131;
					continue;
				}
				case 350:
					num3 = 53 + 31;
					num2 = 13;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 196;
					}
					continue;
				case 220:
					array[13] = 84;
					num = 50;
					break;
				case 105:
					array2[19] = (byte)num3;
					num2 = 88;
					continue;
				case 228:
					array2[9] = 171;
					num2 = 260;
					continue;
				case 302:
					array2[25] = (byte)num3;
					num2 = 225;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 182;
					}
					continue;
				case 17:
					num4 = 136 + 114;
					num2 = 330;
					continue;
				case 145:
					array2[8] = 229;
					num2 = 42;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 126;
					}
					continue;
				case 41:
					array2[24] = (byte)num3;
					num2 = 288;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 358;
					}
					continue;
				case 12:
					array[7] = 151;
					num2 = 5;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 178;
					}
					continue;
				case 211:
					num6 = 233 - 77;
					num2 = 20;
					continue;
				case 82:
					array2[9] = (byte)num3;
					num2 = 282;
					continue;
				case 349:
					num4 = 69 + 68;
					num = 343;
					break;
				case 263:
					array[2] = (byte)num6;
					num2 = 115;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 28;
					}
					continue;
				case 354:
					array[5] = (byte)num4;
					num2 = 154;
					continue;
				case 267:
					array2[13] = 79;
					num2 = 242;
					continue;
				case 81:
					num3 = 167 - 89;
					num2 = 192;
					continue;
				case 219:
					array2[22] = (byte)num3;
					num2 = 5;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 49;
					}
					continue;
				case 262:
					num4 = 210 - 70;
					num2 = 2;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 37;
					}
					continue;
				case 94:
					array2[29] = 110;
					num2 = 24;
					continue;
				case 95:
					array3 = array;
					num2 = 42;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 13;
					}
					continue;
				case 153:
					num6 = 121 + 65;
					num2 = 15;
					continue;
				case 22:
					num6 = 43 + 56;
					num2 = 312;
					continue;
				case 184:
					num3 = 227 + 3;
					num2 = 326;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 187;
					}
					continue;
				case 373:
					num3 = 131 - 43;
					num2 = 231;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 120;
					}
					continue;
				case 242:
					num3 = 84 - 6;
					num2 = 206;
					continue;
				case 335:
					num3 = 24 + 17;
					num2 = 92;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 119;
					}
					continue;
				case 125:
					array2[30] = 82;
					num2 = 103;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 78;
					}
					continue;
				case 253:
					array[1] = (byte)num4;
					num2 = 12;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 124;
					}
					continue;
				case 73:
					array2[16] = (byte)num3;
					num2 = 157;
					continue;
				case 312:
					array[11] = (byte)num6;
					num2 = 159;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 62;
					}
					continue;
				case 301:
					array[10] = (byte)num4;
					num2 = 213;
					continue;
				case 100:
					array2[18] = 106;
					num2 = 11;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 360;
					}
					continue;
				case 203:
					array2[23] = (byte)num3;
					num2 = 286;
					if (Rx4Kp3QFcEobYsaHUH() != null)
					{
						num2 = 215;
					}
					continue;
				case 376:
					array[6] = (byte)num4;
					num2 = 17;
					continue;
				case 318:
					array2[16] = (byte)num3;
					num2 = 200;
					continue;
				default:
					if (num5 < array3.Length)
					{
						num2 = 345;
						if (Rx4Kp3QFcEobYsaHUH() != null)
						{
							num2 = 50;
						}
						continue;
					}
					goto case 110;
				case 261:
					array[4] = 181;
					num2 = 224;
					continue;
				case 320:
					array[11] = (byte)num4;
					num2 = 160;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 106;
					}
					continue;
				case 166:
					array2[16] = 132;
					num2 = 351;
					continue;
				case 5:
					array2[12] = 170;
					num2 = 43;
					continue;
				case 309:
					array2[4] = 35;
					num2 = 321;
					continue;
				case 161:
					array3[15] = array4[7];
					num2 = 44;
					continue;
				case 102:
					num3 = 231 - 77;
					num2 = 293;
					continue;
				case 337:
					num3 = 200 - 66;
					num2 = 375;
					continue;
				case 26:
					array2[10] = 135;
					num2 = 229;
					if (!J89tl5qtvPHSCjK0kY())
					{
						num2 = 75;
					}
					continue;
				case 7:
					array2[27] = (byte)num3;
					num2 = 68;
					if (J89tl5qtvPHSCjK0kY())
					{
						num2 = 84;
					}
					continue;
				case 48:
					num3 = 175 - 58;
					num = 71;
					break;
				case 148:
					num3 = 58 + 17;
					num2 = 15;
					if (Rx4Kp3QFcEobYsaHUH() == null)
					{
						num2 = 368;
					}
					continue;
				case 285:
					array2[11] = (byte)num3;
					num2 = 107;
					continue;
				case 271:
					array[8] = 92;
					num2 = 369;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string tE1kD1vbB(int _0020)
	{
		if (lRG1gLlTer.Length == 0)
		{
			RaA1I3e0cE = new List<string>();
			BV01muBIf0 = new List<int>();
			dr5SSqLSS(QDHV0iQKg.GetManifestResourceStream("pTwdroCLp97iyoiCdx.bWhauDXjoCgVQi5aZi"), _0020);
		}
		if (Pgs1HOBEQA < 75)
		{
			if (QDHV0iQKg != new StackFrame(1).GetMethod().DeclaringType.Assembly)
			{
				throw new Exception();
			}
			Pgs1HOBEQA++;
		}
		lock (t8Q1fis8nb)
		{
			int num = BitConverter.ToInt32(lRG1gLlTer, _0020);
			if (num < BV01muBIf0.Count && BV01muBIf0[num] == _0020)
			{
				return RaA1I3e0cE[num];
			}
			try
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
				byte[] array = new byte[num];
				Array.Copy(lRG1gLlTer, _0020 + 4, array, 0, num);
				string @string = Encoding.Unicode.GetString(array, 0, array.Length);
				RaA1I3e0cE.Add(@string);
				BV01muBIf0.Add(_0020);
				Array.Copy(BitConverter.GetBytes(RaA1I3e0cE.Count - 1), 0, lRG1gLlTer, _0020, 4);
				return @string;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string kHVtMWjbo(string _0020)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(_0020);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int SmeZwTKOr()
	{
		return 5;
	}

	private static void G7pusoAAO()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate WNn7VtyuI(IntPtr _0020, Type _0020)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { _0020, _0020 });
	}

	internal static object oGhoVyLwi(object _0020)
	{
		try
		{
			if (File.Exists(((Assembly)_0020).Location))
			{
				return ((Assembly)_0020).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)_0020).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)_0020).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(_0020.GetType().GetProperty("Location").GetValue(_0020, new object[0])
				.ToString()))
			{
				return _0020.GetType().GetProperty("Location").GetValue(_0020, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32", EntryPoint = "LoadLibrary")]
	public static extern IntPtr grYvFMse6(string _0020);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr r76RP97uO(IntPtr _0020, string _0020);

	private static IntPtr A8TNGW3oN(IntPtr _0020, object _0020, uint _0020)
	{
		if (CHf1uRY5iT == null)
		{
			CHf1uRY5iT = (ioC1YcvbZ2yRGgsOBE)Marshal.GetDelegateForFunctionPointer(r76RP97uO(pZbnhv6YB(), "Find ".Trim() + "ResourceA"), typeof(ioC1YcvbZ2yRGgsOBE));
		}
		return CHf1uRY5iT(_0020, (string)_0020, _0020);
	}

	private static IntPtr hrKrktdEC(IntPtr _0020, uint _0020, uint _0020, uint _0020)
	{
		if (XJ517srtuJ == null)
		{
			XJ517srtuJ = (qAS8QiRs8nbFaA3e0c)Marshal.GetDelegateForFunctionPointer(r76RP97uO(pZbnhv6YB(), "Virtual ".Trim() + "Alloc"), typeof(qAS8QiRs8nbFaA3e0c));
		}
		return XJ517srtuJ(_0020, _0020, _0020, _0020);
	}

	private static int tdobkFCxq(IntPtr _0020, IntPtr _0020, [In][Out] byte[] _0020, uint _0020, out IntPtr _0020)
	{
		if (PrY1OKksdd == null)
		{
			PrY1OKksdd = (XNV0uBNIf0hRGLlTer)Marshal.GetDelegateForFunctionPointer(r76RP97uO(pZbnhv6YB(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(XNV0uBNIf0hRGLlTer));
		}
		return PrY1OKksdd(_0020, _0020, _0020, _0020, out _0020);
	}

	private static int sHBPFakju(IntPtr _0020, int _0020, int _0020, ref int _0020)
	{
		if (HqA1otFDcJ == null)
		{
			HqA1otFDcJ = (QRRKfBrNJhQuGAsIhZ)Marshal.GetDelegateForFunctionPointer(r76RP97uO(pZbnhv6YB(), "Virtual ".Trim() + "Protect"), typeof(QRRKfBrNJhQuGAsIhZ));
		}
		return HqA1otFDcJ(_0020, _0020, _0020, ref _0020);
	}

	private static IntPtr wOCDlEV0B(uint _0020, int _0020, uint _0020)
	{
		if (J8t1vEcUBI == null)
		{
			J8t1vEcUBI = (IQBZqwbrNiAH0AoMWy)Marshal.GetDelegateForFunctionPointer(r76RP97uO(pZbnhv6YB(), "Open ".Trim() + "Process"), typeof(IQBZqwbrNiAH0AoMWy));
		}
		return J8t1vEcUBI(_0020, _0020, _0020);
	}

	private static int npu4Nxkth(IntPtr _0020)
	{
		if (D081RjBZ7X == null)
		{
			D081RjBZ7X = (BJSCyWPgKUiJQGYihL)Marshal.GetDelegateForFunctionPointer(r76RP97uO(pZbnhv6YB(), "Close ".Trim() + "Handle"), typeof(BJSCyWPgKUiJQGYihL));
		}
		return D081RjBZ7X(_0020);
	}

	[SpecialName]
	private static IntPtr pZbnhv6YB()
	{
		if (hyO1NyyabH == IntPtr.Zero)
		{
			hyO1NyyabH = grYvFMse6("kernel ".Trim() + "32.dll");
		}
		return hyO1NyyabH;
	}

	private static byte[] wvdMNOpNF(object _0020)
	{
		using FileStream fileStream = new FileStream((string)_0020, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		int num2 = (int)fileStream.Length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	internal static Stream lkp69qZGc()
	{
		return new MemoryStream();
	}

	internal static byte[] NiXTA2HX7(Stream _0020)
	{
		return ((MemoryStream)_0020).ToArray();
	}

	private static byte[] s1FeCITDg(object _0020)
	{
		Stream stream = lkp69qZGc();
		SymmetricAlgorithm symmetricAlgorithm = Q3ljUyvXm();
		symmetricAlgorithm.Key = new byte[32]
		{
			10, 40, 64, 119, 98, 86, 217, 105, 150, 50,
			3, 116, 238, 182, 90, 206, 72, 11, 115, 229,
			239, 252, 184, 18, 92, 185, 202, 14, 131, 6,
			142, 220
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			162, 190, 237, 103, 129, 5, 14, 167, 174, 43,
			27, 87, 29, 181, 55, 101
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])_0020, 0, ((Array)_0020).Length);
		cryptoStream.Close();
		byte[] result = NiXTA2HX7(stream);
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		return result;
	}

	private unsafe static int zlXXocCli(object _0020)
	{
		fixed (char* ptr = _0020)
		{
			int num = 5381;
			int num2 = num;
			char* ptr2 = ptr;
			int num3;
			while ((num3 = *ptr2) != 0)
			{
				num = ((num << 5) + num) ^ num3;
				num3 = ptr2[1];
				if (num3 == 0)
				{
					break;
				}
				num2 = ((num2 << 5) + num2) ^ num3;
				ptr2 += 2;
			}
			return num + num2 * 1566083941;
		}
	}

	internal static bool wN1cdRyTS(string _0020, string _0020)
	{
		if (_0020 == _0020)
		{
			return true;
		}
		if (_0020 == null || _0020 == null)
		{
			return false;
		}
		bool flag = false;
		bool flag2 = false;
		int num = 0;
		int num2 = 0;
		if (_0020.StartsWith(WDJ1r9tJFl))
		{
			flag = true;
			num = (int)(_0020[4] | ((uint)_0020[5] << 8) | ((uint)_0020[6] << 16) | ((uint)_0020[7] << 24));
		}
		if (_0020.StartsWith(WDJ1r9tJFl))
		{
			flag2 = true;
			num2 = (int)(_0020[4] | ((uint)_0020[5] << 8) | ((uint)_0020[6] << 16) | ((uint)_0020[7] << 24));
		}
		if (!flag && !flag2)
		{
			return false;
		}
		if (!flag)
		{
			num = zlXXocCli(_0020);
		}
		if (!flag2)
		{
			num2 = zlXXocCli(_0020);
		}
		return num == num2;
	}

	private byte[] MqUKUgjbE()
	{
		return null;
	}

	private byte[] rt6sXXhe1()
	{
		return null;
	}

	private byte[] aDKqxYqZo()
	{
		_ = "{11111-22222-20001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] K4yxLJrtK()
	{
		_ = "{11111-22222-20001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] uvKydBjv4()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] u3TGFQBex()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] mfvBdphXy()
	{
		_ = "{11111-22222-40001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] vS3Lj8XxE()
	{
		_ = "{11111-22222-40001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] CIKFBY5tq()
	{
		_ = "{11111-22222-50001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] rGgW4oE5V()
	{
		_ = "{11111-22222-50001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal static object lnXcrNV3C9uXP7EqV4(object P_0)
	{
		return ((fjvIDXoHxLTGxlALSK)P_0).m9OIO8Q0EK();
	}

	internal static void LGeYnVDdT2CivnOLh2(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long dFrFUSKFZ7XHf7iOHi(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object v6rGUNMeU0gI5UEhUF(object P_0, int _0020)
	{
		return ((fjvIDXoHxLTGxlALSK)P_0).z47It19xek(_0020);
	}

	internal static void Mqj4cQaGTvfNhqY5uJ(object P_0)
	{
		((fjvIDXoHxLTGxlALSK)P_0).V26I7M2UXj();
	}

	internal static void jXGlqfYM6PLneeTPfl(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object wdpOQFvtOJfEP7ip3g(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object RdJIiMPgx7n2yjxve3(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object VpWWhV4bJg3VWkB56w()
	{
		return Q3ljUyvXm();
	}

	internal static void oRcvyd9gj2ryIs574o(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object lbjG91TSV6WVGnrBpa(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object tXaIW8cLFjNuMsiAJG()
	{
		return lkp69qZGc();
	}

	internal static void hAlrxYNdPmRCiYEVyE(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void um1CNydIBftfEFJfoU(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object wa3buJj224uuxSe0EZ(object P_0)
	{
		return NiXTA2HX7((Stream)P_0);
	}

	internal static void EDMxUbSJiMu6HsEHBx(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object GVkfyCkuofCFxsuxN9(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool VBZBocbdbUOZR9WUXn(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool J89tl5qtvPHSCjK0kY()
	{
		return (object)null == null;
	}

	internal static object Rx4Kp3QFcEobYsaHUH()
	{
		return null;
	}
}

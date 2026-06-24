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
			private static object lx9dLFpt0PiTw1LtfAul;

			public jsT8Vi1nqW2nM6FKKCJ()
			{
				//Discarded unreachable code: IL_0026, IL_002b
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
				base._002Ector();
				int num = 0;
				if (1 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool EQy9oKptE1xIGCJEG8fZ()
			{
				return lx9dLFpt0PiTw1LtfAul == null;
			}

			internal static object Il1H4JptDXieXNYFGmDo()
			{
				return lx9dLFpt0PiTw1LtfAul;
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
			byte[] array = (byte[])vnjOMDpt4WvFlZmkmLNh(VDEhdMptIVG4lNZQ9ma9(), _0020);
			byte[] array2 = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] array3 = erhwkCleV((byte[])vnjOMDpt4WvFlZmkmLNh(VDEhdMptIVG4lNZQ9ma9(), _0020));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Q3ljUyvXm();
			noZ072ptV6JgnWvW3H0j(symmetricAlgorithm, array2);
			nokLnjptQ4CUQxaEXYsa(symmetricAlgorithm, array3);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			qwZAhbptdcgnX8iCMdmQ(cryptoStream, array, 0, array.Length);
			vmmEMsptTgiWat34xHZZ(cryptoStream);
			return (string)UvvfRRpt8ufBFfWZtC86(N8FuLnptgwO3GlK23KJm(memoryStream));
		}

		internal static object VDEhdMptIVG4lNZQ9ma9()
		{
			return Encoding.Unicode;
		}

		internal static object vnjOMDpt4WvFlZmkmLNh(object P_0, object P_1)
		{
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		internal static void noZ072ptV6JgnWvW3H0j(object P_0, object P_1)
		{
			((SymmetricAlgorithm)P_0).Key = (byte[])P_1;
		}

		internal static void nokLnjptQ4CUQxaEXYsa(object P_0, object P_1)
		{
			((SymmetricAlgorithm)P_0).IV = (byte[])P_1;
		}

		internal static void qwZAhbptdcgnX8iCMdmQ(object P_0, object P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		internal static void vmmEMsptTgiWat34xHZZ(object P_0)
		{
			((Stream)P_0).Close();
		}

		internal static object N8FuLnptgwO3GlK23KJm(object P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		internal static object UvvfRRpt8ufBFfWZtC86(object P_0)
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
			return (Stream)RyuA8iptf1nIWTfKimAV(PTIIvZJmfC);
		}

		internal byte[] z47It19xek(int _0020)
		{
			return (byte[])MvLHMupt17UiPj2xXy9D(PTIIvZJmfC, _0020);
		}

		internal int NQ1IZyT0jI(byte[] _0020, int _0020, int _0020)
		{
			return PTIIvZJmfC.Read(_0020, _0020, _0020);
		}

		internal int wgZIumIPsF()
		{
			return dhkDa5ptz1Lq9O0lrOkc(PTIIvZJmfC);
		}

		internal void V26I7M2UXj()
		{
			PTIIvZJmfC.Close();
		}

		internal static object RyuA8iptf1nIWTfKimAV(object P_0)
		{
			return ((BinaryReader)P_0).BaseStream;
		}

		internal static object MvLHMupt17UiPj2xXy9D(object P_0, int P_1)
		{
			return ((BinaryReader)P_0).ReadBytes(P_1);
		}

		internal static int dhkDa5ptz1Lq9O0lrOkc(object P_0)
		{
			return ((BinaryReader)P_0).ReadInt32();
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

	private static bool VIl2UgjvI;

	internal static RSACryptoServiceProvider EXHzxLTGx;

	private static List<string> RaA1I3e0cE;

	private static byte[] lRG1gLlTer;

	private static IntPtr lQu18GAsIh;

	private static IntPtr ueQ1CBZqwr;

	private static int fKU1wiJQGY;

	private static bool mhL1hZ6InY;

	private static SortedList uFW1iZApx1;

	private static int VyN15LqlEh;

	private static long X4h1A928yN;

	[NifvdpthXyZS3j8XxE(typeof(NifvdpthXyZS3j8XxE.jsT8Vi1nqW2nM6FKKCJ<object>[]))]
	private static bool firstrundone;

	private static XNV0uBNIf0hRGLlTer PrY1OKksdd;

	private static QRRKfBrNJhQuGAsIhZ HqA1otFDcJ;

	private static BJSCyWPgKUiJQGYihL D081RjBZ7X;

	private static object bYc11bZ2yR;

	private static long CoD1QZV1a1;

	private static Dictionary<int, int> pAL10SKCoC;

	private static int Pgs1HOBEQA;

	private static bool uU3JCB0s8;

	internal static vbhv6YuBLBnZE0HBZU XBV1llcJHV;

	private static bool GJ23VPZUC;

	private static object t8Q1fis8nb;

	private static uint[] U6XE6mvyw;

	private static IntPtr WB11tRIZxP;

	internal static Hashtable BSI1ZLPHr8;

	private static IQBZqwbrNiAH0AoMWy J8t1vEcUBI;

	private static bool atZ1SSejVu;

	private static int[] Syr1aJSCyW;

	internal static vbhv6YuBLBnZE0HBZU iBN1U8RgNG;

	private static object BiA1jH0AoM;

	private static IntPtr hyO1NyyabH;

	internal static Assembly QDHV0iQKg;

	private static qAS8QiRs8nbFaA3e0c XJ517srtuJ;

	private static List<int> BV01muBIf0;

	private static byte[] QRR1YKfBNJ;

	private static int RYG1kecuXB;

	private static bool QxN19ECe8h;

	private static ioC1YcvbZ2yRGgsOBE CHf1uRY5iT;

	private static string WDJ1r9tJFl;

	private static int SDV1d6LAgj;

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

	private void TfUphMEHdET()
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
			uint num13 = 366456142u;
			uint num14 = 1605062706u;
			uint num15 = 1078580066u;
			uint num16 = num12;
			uint num17 = 1581364986u;
			uint num18 = 1885629980u;
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
					BinaryReader binaryReader = new BinaryReader(typeof(z2jc63fLkugS1X8Q9N).Assembly.GetManifestResourceStream("DBSHL2NfcNxRdCxji1.YoIBq5ZO755BJIoFgD"));
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
		//Discarded unreachable code: IL_0732, IL_28aa, IL_28b9, IL_31c9, IL_31d8
		int num = 199;
		byte[] array2 = default(byte[]);
		int num5 = default(int);
		byte[] array = default(byte[]);
		int num3 = default(int);
		byte[] array4 = default(byte[]);
		byte[] array3 = default(byte[]);
		int num4 = default(int);
		byte[] array6 = default(byte[]);
		byte[] array5 = default(byte[]);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 100:
					array2[13] = (byte)num5;
					num2 = 22;
					continue;
				case 236:
					array[19] = (byte)num3;
					num2 = 122;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 103;
					}
					continue;
				case 67:
					if (array4 != null)
					{
						num2 = 41;
						if (yqsXyTB4rJKWP22pRt() == null)
						{
							num2 = 52;
						}
						continue;
					}
					goto case 118;
				case 173:
					array[18] = (byte)num3;
					num = 216;
					break;
				case 294:
					array[24] = 132;
					num2 = 347;
					continue;
				case 247:
					num3 = 95 + 19;
					num2 = 121;
					continue;
				case 243:
					array3[1] = array4[0];
					num2 = 97;
					continue;
				case 13:
					array[2] = 111;
					num2 = 204;
					continue;
				case 336:
					num3 = 131 - 58;
					num2 = 60;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 189;
					}
					continue;
				case 124:
					Pgs1HOBEQA = 80;
					num2 = 46;
					continue;
				case 103:
					array[21] = (byte)num4;
					num2 = 81;
					continue;
				case 69:
					num3 = 237 - 79;
					num2 = 107;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 24;
					}
					continue;
				case 188:
					num4 = 146 - 48;
					num2 = 50;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 99;
					}
					continue;
				case 254:
					pGOytIHUGhivEUMMIw(array3);
					num2 = 78;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 19;
					}
					continue;
				case 39:
					array[26] = 28;
					num2 = 4;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 12;
					}
					continue;
				case 296:
					array2[6] = (byte)num5;
					num2 = 30;
					continue;
				case 327:
					array[1] = 120;
					num2 = 79;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 21;
					}
					continue;
				case 276:
					num4 = 179 - 59;
					num2 = 308;
					continue;
				case 361:
					array2[11] = 183;
					num = 217;
					break;
				case 343:
					array3 = array2;
					num2 = 254;
					continue;
				case 95:
					array[7] = 150;
					num2 = 215;
					continue;
				case 258:
					array[5] = (byte)num4;
					num2 = 68;
					continue;
				case 157:
					array[28] = 120;
					num2 = 360;
					continue;
				case 47:
					array[16] = 143;
					num2 = 180;
					continue;
				case 292:
					num4 = 142 - 47;
					num2 = 161;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 89;
					}
					continue;
				case 352:
					array[10] = 145;
					num2 = 64;
					continue;
				case 217:
					array2[11] = 177;
					num2 = 227;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 31;
					}
					continue;
				case 151:
					num5 = 131 - 14;
					num2 = 87;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 17;
					}
					continue;
				case 65:
					num3 = 247 - 82;
					num2 = 234;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 216;
					}
					continue;
				case 269:
					array[19] = (byte)num4;
					num2 = 252;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 88;
					}
					continue;
				case 29:
					num5 = 60 + 1;
					num2 = 315;
					continue;
				case 280:
					array2[5] = (byte)num5;
					num2 = 89;
					continue;
				case 318:
					array[23] = (byte)num4;
					num2 = 339;
					continue;
				case 107:
					array[30] = (byte)num3;
					num2 = 233;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 80;
					}
					continue;
				case 143:
					num5 = 194 - 64;
					num2 = 212;
					continue;
				case 180:
					num3 = 171 - 57;
					num2 = 301;
					continue;
				case 230:
					array2[6] = (byte)num5;
					num2 = 146;
					continue;
				case 56:
					array[25] = (byte)num4;
					num2 = 180;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 200;
					}
					continue;
				case 341:
					array3[13] = array4[6];
					num2 = 58;
					continue;
				case 338:
					array6 = array;
					num2 = 287;
					continue;
				case 266:
					num5 = 35 + 98;
					num2 = 80;
					continue;
				case 212:
					array2[15] = (byte)num5;
					num2 = 186;
					continue;
				case 168:
					num3 = 199 - 66;
					num2 = 331;
					continue;
				case 134:
					array[17] = 156;
					num2 = 223;
					continue;
				case 355:
					array[18] = 102;
					num2 = 239;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 246;
					}
					continue;
				case 303:
					array2[14] = 218;
					num2 = 203;
					continue;
				case 18:
					array2[11] = (byte)num5;
					num2 = 357;
					continue;
				case 261:
					num4 = 123 - 115;
					num = 74;
					break;
				case 246:
					num4 = 160 - 53;
					num2 = 205;
					continue;
				case 162:
					array3[5] = array4[2];
					num2 = 359;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 77;
					}
					continue;
				case 37:
					array[12] = 173;
					num2 = 354;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 97;
					}
					continue;
				case 351:
					array3[11] = array4[5];
					num2 = 341;
					continue;
				case 202:
					array[29] = 167;
					num = 168;
					break;
				case 61:
					array[8] = (byte)num4;
					num2 = 65;
					continue;
				case 267:
					array2[1] = 99;
					num2 = 350;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 270;
					}
					continue;
				case 94:
					num4 = 80 + 98;
					num = 28;
					break;
				case 30:
					array2[6] = 49;
					num2 = 65;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 178;
					}
					continue;
				case 354:
					num3 = 174 - 58;
					num2 = 106;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 115;
					}
					continue;
				case 156:
					array2[8] = (byte)num5;
					num2 = 279;
					continue;
				case 140:
					num4 = 58 + 92;
					num2 = 60;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 61;
					}
					continue;
				case 175:
					array[6] = 24;
					num2 = 281;
					continue;
				case 19:
					num4 = 213 - 71;
					num2 = 170;
					continue;
				case 77:
					array2[12] = (byte)num5;
					num2 = 123;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 7;
					}
					continue;
				case 121:
					array[8] = (byte)num3;
					num = 111;
					break;
				case 114:
					array2[4] = (byte)num5;
					num2 = 22;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 60;
					}
					continue;
				case 342:
					num3 = 106 + 23;
					num2 = 20;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 63;
					}
					continue;
				case 283:
					array[9] = (byte)num3;
					num2 = 166;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 240;
					}
					continue;
				case 268:
					num5 = 2 + 68;
					num2 = 323;
					continue;
				case 46:
					new z2jc63fLkugS1X8Q9N().b2qCrnKW1(array6, array3, array5);
					num2 = 183;
					continue;
				case 176:
					array2[4] = 108;
					num2 = 23;
					continue;
				case 315:
					array2[4] = (byte)num5;
					num2 = 17;
					continue;
				case 75:
					array[1] = 146;
					num2 = 327;
					continue;
				case 81:
					array[21] = 82;
					num = 82;
					break;
				case 237:
					array2[4] = (byte)num5;
					num2 = 337;
					continue;
				case 291:
					array[0] = 144;
					num2 = 104;
					continue;
				case 275:
					array2[6] = (byte)num5;
					num2 = 181;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 165;
					}
					continue;
				case 244:
					num3 = 79 + 33;
					num2 = 86;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 125;
					}
					continue;
				case 324:
					array[4] = (byte)num3;
					num2 = 321;
					continue;
				case 345:
					array[14] = 114;
					num2 = 82;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 276;
					}
					continue;
				case 144:
					num3 = 220 - 73;
					num2 = 235;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 332;
					}
					continue;
				case 73:
					num5 = 108 + 51;
					num2 = 323;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 340;
					}
					continue;
				case 285:
					array[17] = (byte)num4;
					num2 = 138;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 271;
					}
					continue;
				case 328:
					num5 = 113 + 50;
					num2 = 109;
					continue;
				case 357:
					num5 = 227 - 110;
					num2 = 159;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 85;
					}
					continue;
				case 214:
					array3[9] = array4[4];
					num2 = 70;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 351;
					}
					continue;
				case 193:
					array2[5] = 162;
					num2 = 235;
					continue;
				case 304:
					stream = (Stream)ohJ4AgvSnj9BKPxZRl();
					num2 = 206;
					continue;
				case 227:
					num5 = 63 + 106;
					num2 = 326;
					continue;
				case 128:
					array2[5] = (byte)num5;
					num2 = 55;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 239;
					}
					continue;
				case 250:
					num3 = 102 + 7;
					num2 = 353;
					continue;
				case 329:
					num5 = 122 + 48;
					num = 11;
					break;
				case 5:
					array2[9] = (byte)num5;
					num2 = 207;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 76;
					}
					continue;
				case 15:
					array2[1] = (byte)num5;
					num2 = 267;
					continue;
				case 282:
					num3 = 22 + 18;
					num2 = 150;
					continue;
				case 277:
					array2[8] = (byte)num5;
					num2 = 105;
					continue;
				case 138:
					array[7] = 253;
					num = 335;
					break;
				case 123:
					array2[12] = 123;
					num = 201;
					break;
				case 223:
					num4 = 7 + 121;
					num2 = 285;
					continue;
				case 26:
					num4 = 64 + 58;
					num2 = 251;
					continue;
				case 211:
					num4 = 62 + 110;
					num = 269;
					break;
				case 325:
					array2[3] = 149;
					num2 = 330;
					continue;
				case 331:
					array[29] = (byte)num3;
					num2 = 188;
					continue;
				case 17:
					num5 = 184 - 61;
					num2 = 223;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 237;
					}
					continue;
				case 198:
					array = new byte[32];
					num2 = 185;
					continue;
				case 308:
					array[14] = (byte)num4;
					num2 = 209;
					continue;
				case 22:
					array2[13] = 120;
					num = 268;
					break;
				case 42:
					array[16] = (byte)num4;
					num2 = 336;
					continue;
				case 183:
					return;
				case 20:
					num4 = 4 + 30;
					num2 = 194;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 1;
					}
					continue;
				case 137:
					num3 = 71 + 18;
					num2 = 88;
					continue;
				case 179:
					array[11] = (byte)num3;
					num2 = 314;
					continue;
				case 253:
					array[11] = 109;
					num2 = 274;
					continue;
				case 347:
					array[24] = 124;
					num2 = 2;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 2;
					}
					continue;
				case 161:
					array[30] = (byte)num4;
					num2 = 69;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 46;
					}
					continue;
				case 92:
					num3 = 172 - 57;
					num2 = 76;
					continue;
				case 317:
					array[3] = 189;
					num2 = 5;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 94;
					}
					continue;
				case 353:
					array[5] = (byte)num3;
					num2 = 293;
					continue;
				case 220:
					num4 = 25 + 46;
					num2 = 164;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 35;
					}
					continue;
				case 300:
					array2[2] = 157;
					num2 = 113;
					continue;
				case 86:
					num3 = 92 + 100;
					num2 = 141;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 171;
					}
					continue;
				case 52:
					if (array4.Length == 0)
					{
						num2 = 286;
						continue;
					}
					goto case 243;
				case 101:
					array[0] = 34;
					num2 = 86;
					continue;
				case 320:
					array[28] = 172;
					num2 = 224;
					continue;
				case 226:
					array[4] = (byte)num3;
					num2 = 70;
					continue;
				case 104:
					num4 = 246 - 82;
					num2 = 316;
					continue;
				case 8:
					num3 = 176 + 68;
					num2 = 192;
					continue;
				case 4:
					array[21] = 21;
					num2 = 71;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 144;
					}
					continue;
				case 337:
					num5 = 223 - 74;
					num2 = 43;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 114;
					}
					continue;
				case 273:
					array[23] = 133;
					num2 = 313;
					continue;
				case 348:
					array[16] = (byte)num3;
					num2 = 149;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 0;
					}
					continue;
				case 152:
					array2[10] = 81;
					num2 = 66;
					continue;
				case 43:
					array[29] = 134;
					num2 = 342;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 225;
					}
					continue;
				case 221:
					num4 = 126 - 42;
					num2 = 40;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 56;
					}
					continue;
				case 164:
					array[1] = (byte)num4;
					num2 = 172;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 76;
					}
					continue;
				case 321:
					num3 = 244 - 81;
					num2 = 133;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 92;
					}
					continue;
				case 307:
					num4 = 128 - 42;
					num2 = 318;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 274;
					}
					continue;
				case 83:
					num3 = 14 + 88;
					num2 = 226;
					continue;
				case 210:
					num3 = 139 + 104;
					num2 = 179;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 67;
					}
					continue;
				case 159:
					array2[11] = (byte)num5;
					num2 = 130;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 9;
					}
					continue;
				case 74:
					array[20] = (byte)num4;
					num2 = 92;
					continue;
				case 358:
					num3 = 250 - 83;
					num2 = 90;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 91;
					}
					continue;
				case 91:
					array[10] = (byte)num3;
					num2 = 153;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 103;
					}
					continue;
				case 79:
					array[1] = 144;
					num = 220;
					break;
				case 38:
					array[23] = (byte)num4;
					num2 = 294;
					continue;
				case 332:
					array[22] = (byte)num3;
					num2 = 297;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 239;
					}
					continue;
				case 245:
					array[31] = 158;
					num2 = 25;
					continue;
				case 257:
					array[5] = (byte)num4;
					num2 = 356;
					continue;
				case 191:
					array[8] = (byte)num4;
					num2 = 247;
					continue;
				case 89:
					num5 = 181 - 60;
					num2 = 128;
					continue;
				case 117:
					array[15] = 221;
					num2 = 47;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 16;
					}
					continue;
				case 251:
					array[9] = (byte)num4;
					num2 = 289;
					continue;
				case 10:
					array[13] = 148;
					num2 = 182;
					continue;
				case 131:
					array2[2] = (byte)num5;
					num2 = 140;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 322;
					}
					continue;
				case 132:
					array[18] = 186;
					num2 = 45;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 355;
					}
					continue;
				case 322:
					array2[3] = 138;
					num2 = 329;
					continue;
				case 346:
					array[4] = 92;
					num2 = 83;
					continue;
				case 205:
					array[18] = (byte)num4;
					num = 19;
					break;
				case 297:
					array[22] = 159;
					num2 = 7;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 5;
					}
					continue;
				case 225:
					num5 = 197 - 65;
					num2 = 156;
					continue;
				case 192:
					array[31] = (byte)num3;
					num2 = 338;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 242;
					}
					continue;
				case 293:
					num4 = 70 + 34;
					num2 = 257;
					continue;
				case 249:
					array[29] = (byte)num3;
					num2 = 169;
					continue;
				case 344:
					array2[15] = 113;
					num = 363;
					break;
				case 229:
					array[25] = 171;
					num2 = 39;
					continue;
				case 109:
					array2[13] = (byte)num5;
					num2 = 31;
					continue;
				case 53:
					array[28] = (byte)num3;
					num2 = 157;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 75;
					}
					continue;
				case 213:
					array[23] = (byte)num4;
					num2 = 307;
					continue;
				case 239:
					num5 = 155 + 40;
					num2 = 174;
					continue;
				case 200:
					array[25] = 144;
					num2 = 229;
					continue;
				case 36:
					num4 = 170 - 56;
					num2 = 299;
					continue;
				case 278:
					num4 = 136 - 45;
					num2 = 72;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 213;
					}
					continue;
				case 326:
					array2[11] = (byte)num5;
					num = 147;
					break;
				case 174:
					array2[5] = (byte)num5;
					num2 = 262;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 260;
					}
					continue;
				case 119:
					num3 = 122 - 69;
					num2 = 173;
					continue;
				case 6:
					num5 = 245 - 81;
					num2 = 222;
					continue;
				case 203:
					array2[14] = 90;
					num2 = 65;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 71;
					}
					continue;
				case 323:
					array2[13] = (byte)num5;
					num2 = 45;
					continue;
				case 288:
					num5 = 105 + 100;
					num2 = 277;
					continue;
				case 181:
					num5 = 157 - 52;
					num2 = 309;
					continue;
				case 216:
					array[19] = 93;
					num2 = 211;
					continue;
				case 44:
					array2[2] = 155;
					num2 = 6;
					continue;
				case 260:
					array2[13] = (byte)num5;
					num2 = 303;
					continue;
				case 11:
					array2[3] = (byte)num5;
					num = 325;
					break;
				case 301:
					array[16] = (byte)num3;
					num2 = 129;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 14;
					}
					continue;
				case 299:
					array[20] = (byte)num4;
					num = 261;
					break;
				case 311:
					array[15] = 97;
					num2 = 117;
					continue;
				case 177:
					array[15] = 204;
					num2 = 311;
					continue;
				case 51:
					array[0] = (byte)num3;
					num2 = 75;
					continue;
				case 72:
					array[2] = 196;
					num2 = 317;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 210;
					}
					continue;
				case 187:
					array[27] = (byte)num3;
					num2 = 116;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 4;
					}
					continue;
				case 335:
					num4 = 225 - 75;
					num = 191;
					break;
				case 133:
					array[4] = (byte)num3;
					num2 = 333;
					continue;
				case 256:
					num3 = 48 + 32;
					num2 = 155;
					continue;
				case 126:
					array[7] = 135;
					num2 = 138;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 36;
					}
					continue;
				case 16:
					num5 = 201 - 67;
					num2 = 84;
					continue;
				case 148:
					array2[9] = (byte)num5;
					num2 = 59;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 158;
					}
					continue;
				case 23:
					num5 = 44 + 83;
					num2 = 112;
					continue;
				case 184:
					num3 = 112 - 58;
					num2 = 249;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 24;
					}
					continue;
				case 80:
					array2[1] = (byte)num5;
					num2 = 44;
					continue;
				case 287:
					array2 = new byte[16];
					num = 190;
					break;
				case 305:
					num5 = 190 - 63;
					num2 = 275;
					continue;
				case 222:
					array2[2] = (byte)num5;
					num2 = 16;
					continue;
				case 115:
					array[13] = (byte)num3;
					num2 = 10;
					continue;
				case 264:
				{
					object obj = OXt1q8wjoLaxMCQcHY();
					Hx2mx32i3H6rQ3fMOn(obj, CipherMode.CBC);
					transform = (ICryptoTransform)xfFTuuPTKTGdP2kFkm(obj, array6, array3);
					num2 = 304;
					continue;
				}
				case 186:
					num5 = 246 - 82;
					num2 = 166;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 113;
					}
					continue;
				case 158:
					num5 = 28 + 100;
					num2 = 5;
					continue;
				case 206:
				{
					CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					PoVfhOCJ8D8LBkgR29(cryptoStream, array5, 0, array5.Length);
					sow8F2ULm3pT2IYn8l(cryptoStream);
					lRG1gLlTer = (byte[])CO4heWoaCINoABUpuQ(stream);
					EIw8fDJVJqarlJVmmQ(stream);
					EIw8fDJVJqarlJVmmQ(cryptoStream);
					num2 = 0;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 0;
					}
					continue;
				}
				case 201:
					array2[12] = 162;
					num2 = 151;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 18;
					}
					continue;
				case 12:
					array[26] = 142;
					num2 = 29;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 145;
					}
					continue;
				case 106:
					array[12] = (byte)num3;
					num2 = 334;
					continue;
				case 71:
					array2[14] = 173;
					num2 = 143;
					continue;
				case 228:
					array[2] = 150;
					num2 = 72;
					continue;
				case 21:
					array[3] = 235;
					num2 = 196;
					continue;
				case 204:
					num3 = 14 + 64;
					num2 = 165;
					continue;
				case 125:
					array[25] = (byte)num3;
					num2 = 221;
					continue;
				case 129:
					num3 = 249 - 83;
					num2 = 348;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 81;
					}
					continue;
				case 35:
					num5 = 172 - 57;
					num2 = 218;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 85;
					}
					continue;
				case 259:
					array[10] = 184;
					num = 352;
					break;
				case 54:
					array[6] = (byte)num4;
					num2 = 98;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 102;
					}
					continue;
				case 232:
					array[11] = (byte)num3;
					num2 = 120;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 256;
					}
					continue;
				case 97:
					array3[3] = array4[1];
					num2 = 162;
					continue;
				case 105:
					array2[8] = 101;
					num2 = 225;
					continue;
				case 70:
					num4 = 91 + 48;
					num2 = 197;
					continue;
				case 215:
					array[7] = 84;
					num2 = 42;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 126;
					}
					continue;
				case 209:
					array[14] = 159;
					num2 = 177;
					continue;
				case 34:
					array[6] = 148;
					num2 = 127;
					continue;
				case 190:
					array2[0] = 126;
					num2 = 306;
					continue;
				case 167:
					num5 = 26 + 23;
					num2 = 93;
					continue;
				case 195:
					array[24] = 120;
					num2 = 142;
					continue;
				case 208:
					array[23] = 131;
					num2 = 278;
					continue;
				case 113:
					num5 = 162 + 43;
					num = 131;
					break;
				case 178:
					num5 = 107 + 25;
					num2 = 32;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 33;
					}
					continue;
				case 155:
					array[11] = (byte)num3;
					num2 = 282;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 30;
					}
					continue;
				case 150:
					array[11] = (byte)num3;
					num2 = 253;
					continue;
				case 163:
					array[28] = (byte)num4;
					num2 = 320;
					continue;
				case 130:
					num5 = 99 + 85;
					num2 = 77;
					continue;
				case 90:
					num4 = 200 - 66;
					num2 = 103;
					continue;
				case 284:
					array[4] = (byte)num4;
					num2 = 346;
					continue;
				case 306:
					num5 = 240 - 80;
					num2 = 0;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 1;
					}
					continue;
				case 350:
					array2[1] = 118;
					num2 = 9;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 2;
					}
					continue;
				case 93:
					array2[1] = (byte)num5;
					num2 = 97;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 270;
					}
					continue;
				case 272:
					array2[2] = 84;
					num2 = 300;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 235;
					}
					continue;
				case 194:
					array[31] = (byte)num4;
					num2 = 14;
					continue;
				case 41:
					num5 = 96 + 108;
					num2 = 50;
					continue;
				case 281:
					array[6] = 142;
					num2 = 34;
					continue;
				case 108:
					array[27] = (byte)num3;
					num2 = 302;
					continue;
				case 334:
					array[12] = 89;
					num2 = 263;
					continue;
				case 120:
					array[14] = 115;
					num2 = 345;
					continue;
				case 289:
					num3 = 183 - 61;
					num2 = 171;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 283;
					}
					continue;
				case 185:
					array[0] = 167;
					num2 = 101;
					continue;
				case 349:
					num3 = 164 - 70;
					num2 = 51;
					continue;
				case 166:
					array2[15] = (byte)num5;
					num2 = 344;
					continue;
				case 309:
					array2[6] = (byte)num5;
					num2 = 362;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 352;
					}
					continue;
				case 78:
					array4 = (byte[])SAI8GNRoxZP9rIgT8v(lc6njhadrARBPlcmhM(QDHV0iQKg));
					num2 = 67;
					continue;
				case 207:
					array2[9] = 180;
					num2 = 73;
					continue;
				case 85:
					num4 = 50 - 3;
					num = 62;
					break;
				case 57:
					array[31] = (byte)num4;
					num2 = 20;
					continue;
				case 28:
					array[3] = (byte)num4;
					num2 = 21;
					continue;
				case 99:
					array[29] = (byte)num4;
					num2 = 184;
					continue;
				case 3:
					array[8] = 108;
					num2 = 26;
					continue;
				case 96:
					array[5] = 142;
					num2 = 310;
					continue;
				case 310:
					num4 = 36 + 101;
					num2 = 258;
					continue;
				case 235:
					num5 = 217 - 72;
					num2 = 280;
					continue;
				case 55:
				case 248:
					if (num6 < array3.Length)
					{
						num2 = 135;
						continue;
					}
					goto case 59;
				case 302:
					num4 = 96 + 39;
					num2 = 163;
					continue;
				case 182:
					array[13] = 151;
					num2 = 110;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 120;
					}
					continue;
				case 270:
					num5 = 185 - 61;
					num2 = 15;
					continue;
				case 262:
					num5 = 237 - 79;
					num2 = 230;
					continue;
				case 252:
					num3 = 128 - 42;
					num2 = 110;
					continue;
				case 165:
					array[2] = (byte)num3;
					num2 = 17;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 228;
					}
					continue;
				case 241:
					array[21] = 106;
					num2 = 90;
					continue;
				case 62:
					array[26] = (byte)num4;
					num2 = 137;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 137;
					}
					continue;
				case 136:
					num5 = 178 - 59;
					num = 148;
					break;
				case 50:
					array2[5] = (byte)num5;
					num2 = 193;
					continue;
				case 319:
					num3 = 141 - 66;
					num2 = 108;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 18;
					}
					continue;
				case 63:
					array[29] = (byte)num3;
					num2 = 202;
					continue;
				case 82:
					num4 = 4 + 11;
					num2 = 154;
					continue;
				case 362:
					num5 = 217 - 72;
					num2 = 296;
					continue;
				case 263:
					num4 = 185 - 61;
					num2 = 231;
					continue;
				case 240:
					array[9] = 9;
					num2 = 259;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 80;
					}
					continue;
				case 59:
					if (_0020 == -1)
					{
						num2 = 264;
						continue;
					}
					goto case 298;
				case 68:
					num4 = 63 + 116;
					num2 = 54;
					continue;
				case 265:
					num6++;
					num2 = 248;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 193;
					}
					continue;
				case 189:
					array[16] = (byte)num3;
					num2 = 134;
					continue;
				case 219:
					array[27] = 133;
					num2 = 319;
					continue;
				case 1:
					array2[0] = (byte)num5;
					num2 = 49;
					continue;
				case 111:
					array[8] = 206;
					num2 = 140;
					continue;
				case 330:
					array2[3] = 59;
					num2 = 176;
					continue;
				case 274:
					num4 = 252 - 84;
					num2 = 45;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 141;
					}
					continue;
				case 14:
					array[31] = 158;
					num2 = 8;
					continue;
				case 356:
					num3 = 63 + 4;
					num2 = 238;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 44;
					}
					continue;
				case 9:
					array2[1] = 145;
					num2 = 183;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 266;
					}
					continue;
				case 24:
					array[10] = (byte)num4;
					num2 = 358;
					continue;
				case 146:
					array2[6] = 163;
					num2 = 144;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 305;
					}
					continue;
				case 116:
					array[27] = 67;
					num2 = 142;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 219;
					}
					continue;
				case 233:
					array[30] = 134;
					num2 = 245;
					continue;
				case 170:
					array[18] = (byte)num4;
					num2 = 119;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 104;
					}
					continue;
				case 160:
					array[10] = (byte)num3;
					num2 = 27;
					continue;
				case 313:
					num4 = 115 + 91;
					num2 = 38;
					continue;
				case 171:
					array[0] = (byte)num3;
					num2 = 236;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 291;
					}
					continue;
				case 60:
					array2[4] = 101;
					num2 = 41;
					continue;
				case 142:
					array[24] = 122;
					num2 = 244;
					continue;
				case 110:
					array[19] = (byte)num3;
					num2 = 295;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 87;
					}
					continue;
				case 31:
					num5 = 253 - 84;
					num2 = 100;
					continue;
				case 122:
					array[20] = 120;
					num2 = 36;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 27;
					}
					continue;
				case 255:
					array[28] = (byte)num3;
					num = 43;
					break;
				case 339:
					num3 = 111 + 105;
					num = 40;
					break;
				case 58:
					array3[15] = array4[7];
					num2 = 118;
					continue;
				case 102:
					array[6] = 115;
					num2 = 175;
					continue;
				case 199:
				{
					fjvIDXoHxLTGxlALSK fjvIDXoHxLTGxlALSK = new fjvIDXoHxLTGxlALSK((Stream)_0020);
					r3sESwmnkTthPsx2wR(MJijMOujPekTcJ9HFA(fjvIDXoHxLTGxlALSK), 0L);
					array5 = (byte[])Pd9GORLmgtotmQKuuV(fjvIDXoHxLTGxlALSK, (int)HYZ4kNeoVTZVKgGQ6m(MJijMOujPekTcJ9HFA(fjvIDXoHxLTGxlALSK)));
					uVHSldjgdkBfTAl0vU(fjvIDXoHxLTGxlALSK);
					num2 = 198;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 116;
					}
					continue;
				}
				case 88:
					array[27] = (byte)num3;
					num2 = 48;
					continue;
				case 359:
					array3[7] = array4[3];
					num2 = 214;
					continue;
				case 48:
					num3 = 2 + 27;
					num2 = 187;
					continue;
				case 40:
					array[23] = (byte)num3;
					num2 = 273;
					continue;
				case 196:
					num3 = 111 + 124;
					num2 = 324;
					continue;
				case 112:
					array2[4] = (byte)num5;
					num2 = 29;
					continue;
				case 49:
					array2[0] = 201;
					num2 = 89;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 167;
					}
					continue;
				case 127:
					array[6] = 4;
					num2 = 95;
					continue;
				case 87:
					array2[12] = (byte)num5;
					num = 312;
					break;
				case 340:
					array2[10] = (byte)num5;
					num2 = 152;
					continue;
				case 218:
					array2[7] = (byte)num5;
					num2 = 139;
					continue;
				case 149:
					num4 = 234 - 78;
					num2 = 42;
					continue;
				case 172:
					array[1] = 11;
					num2 = 9;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 13;
					}
					continue;
				case 2:
					array[24] = 40;
					num2 = 129;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 195;
					}
					continue;
				case 141:
					array[11] = (byte)num4;
					num2 = 210;
					continue;
				case 197:
					array[4] = (byte)num4;
					num2 = 22;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 250;
					}
					continue;
				case 312:
					num5 = 223 - 74;
					num2 = 290;
					continue;
				case 7:
					array[22] = 224;
					num2 = 208;
					continue;
				case 298:
					if (dhaK7vtx5HbbxE9wOQ(BPWLMLKK2NANBxKFCQ(QDHV0iQKg), null))
					{
						num2 = 124;
						continue;
					}
					goto case 46;
				case 98:
				case 135:
					array6[num6] = (byte)(array6[num6] ^ array3[num6]);
					num2 = 265;
					continue;
				case 145:
					array[26] = 150;
					num2 = 85;
					if (yqsXyTB4rJKWP22pRt() != null)
					{
						num2 = 39;
					}
					continue;
				case 32:
					array2[15] = 22;
					num2 = 343;
					continue;
				case 224:
					num3 = 100 + 77;
					num2 = 53;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 34;
					}
					continue;
				case 33:
					array2[7] = (byte)num5;
					num2 = 35;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 19;
					}
					continue;
				case 363:
					array2[15] = 161;
					num2 = 32;
					continue;
				case 153:
					num3 = 155 - 95;
					num2 = 160;
					continue;
				case 45:
					num5 = 222 + 16;
					num = 260;
					break;
				case 154:
					array[21] = (byte)num4;
					num2 = 4;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 3;
					}
					continue;
				case 360:
					num3 = 201 + 49;
					num2 = 255;
					continue;
				case 25:
					num4 = 52 + 47;
					num2 = 25;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 57;
					}
					continue;
				case 84:
					array2[2] = (byte)num5;
					num2 = 148;
					if (OsYlAmxtUsMRhIxJwV())
					{
						num2 = 272;
					}
					continue;
				case 333:
					num4 = 121 + 56;
					num2 = 284;
					continue;
				case 118:
				case 286:
					num6 = 0;
					num2 = 55;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 51;
					}
					continue;
				case 271:
					array[17] = 187;
					num2 = 132;
					continue;
				case 314:
					num3 = 164 - 54;
					num = 106;
					break;
				default:
					array5 = lRG1gLlTer;
					num2 = 298;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 2;
					}
					continue;
				case 290:
					array2[13] = (byte)num5;
					num2 = 328;
					continue;
				case 64:
					num4 = 226 - 75;
					num2 = 15;
					if (yqsXyTB4rJKWP22pRt() == null)
					{
						num2 = 24;
					}
					continue;
				case 295:
					num3 = 112 + 45;
					num2 = 236;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 5;
					}
					continue;
				case 279:
					array2[8] = 215;
					num2 = 136;
					continue;
				case 169:
					array[30] = 146;
					num = 292;
					break;
				case 66:
					array2[10] = 63;
					num2 = 361;
					continue;
				case 238:
					array[5] = (byte)num3;
					num2 = 96;
					continue;
				case 242:
					num5 = 201 - 67;
					num2 = 18;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 9;
					}
					continue;
				case 147:
					array2[11] = 157;
					num2 = 242;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 69;
					}
					continue;
				case 139:
					array2[7] = 165;
					num2 = 288;
					continue;
				case 76:
					array[21] = (byte)num3;
					num2 = 241;
					continue;
				case 234:
					array[8] = (byte)num3;
					num2 = 3;
					if (!OsYlAmxtUsMRhIxJwV())
					{
						num2 = 2;
					}
					continue;
				case 316:
					array[0] = (byte)num4;
					num2 = 349;
					continue;
				case 231:
					array[12] = (byte)num4;
					num2 = 37;
					continue;
				case 27:
					num3 = 215 - 71;
					num2 = 232;
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
			dr5SSqLSS(QDHV0iQKg.GetManifestResourceStream("T1bjBGp6nGMVAqN6j9.WSvhk451WbG9ytdt0Z"), _0020);
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
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
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
			140, 78, 187, 158, 25, 45, 62, 8, 109, 117,
			142, 177, 9, 137, 187, 31, 238, 210, 217, 122,
			204, 167, 67, 198, 100, 227, 223, 16, 123, 34,
			101, 13
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			92, 64, 19, 152, 210, 250, 92, 89, 43, 245,
			71, 165, 49, 197, 203, 54
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])_0020, 0, ((Array)_0020).Length);
		cryptoStream.Close();
		byte[] result = NiXTA2HX7(stream);
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
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

	internal static object MJijMOujPekTcJ9HFA(object P_0)
	{
		return ((fjvIDXoHxLTGxlALSK)P_0).m9OIO8Q0EK();
	}

	internal static void r3sESwmnkTthPsx2wR(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long HYZ4kNeoVTZVKgGQ6m(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object Pd9GORLmgtotmQKuuV(object P_0, int _0020)
	{
		return ((fjvIDXoHxLTGxlALSK)P_0).z47It19xek(_0020);
	}

	internal static void uVHSldjgdkBfTAl0vU(object P_0)
	{
		((fjvIDXoHxLTGxlALSK)P_0).V26I7M2UXj();
	}

	internal static void pGOytIHUGhivEUMMIw(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object lc6njhadrARBPlcmhM(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object SAI8GNRoxZP9rIgT8v(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object OXt1q8wjoLaxMCQcHY()
	{
		return Q3ljUyvXm();
	}

	internal static void Hx2mx32i3H6rQ3fMOn(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object xfFTuuPTKTGdP2kFkm(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object ohJ4AgvSnj9BKPxZRl()
	{
		return lkp69qZGc();
	}

	internal static void PoVfhOCJ8D8LBkgR29(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void sow8F2ULm3pT2IYn8l(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object CO4heWoaCINoABUpuQ(object P_0)
	{
		return NiXTA2HX7((Stream)P_0);
	}

	internal static void EIw8fDJVJqarlJVmmQ(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object BPWLMLKK2NANBxKFCQ(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool dhaK7vtx5HbbxE9wOQ(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool OsYlAmxtUsMRhIxJwV()
	{
		return (object)null == null;
	}

	internal static object yqsXyTB4rJKWP22pRt()
	{
		return null;
	}
}

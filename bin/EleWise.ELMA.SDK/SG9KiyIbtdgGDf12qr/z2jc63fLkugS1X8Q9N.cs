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

	internal class ProductEventEntry : Attribute
	{
		internal class ExceptionFilterResolver<T>
		{
			private static object eMoIrBZDk42sEoFkPWgZ;

			public ExceptionFilterResolver()
			{
				//Discarded unreachable code: IL_0026, IL_002b
				SingletonReader.JJCZtPuTvSt();
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

			internal static bool IaXM1kZDn9PqH8GVktSJ()
			{
				return eMoIrBZDk42sEoFkPWgZ == null;
			}

			internal static object c89ncfZDOUbW86qhRUqU()
			{
				return eMoIrBZDk42sEoFkPWgZ;
			}
		}

		public ProductEventEntry(object _0020)
		{
		}
	}

	internal class ParserRequestStrategy
	{
		internal static string Encrypt(string plaintext, string _0020)
		{
			byte[] bytes = ((Encoding)UnicodeEncoding()).GetBytes(plaintext);
			byte[] array = new byte[32];
			InitializeByRuntimeHelper(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] array2 = array;
			byte[] array3 = (byte[])dQY6noZDpeH1RsStKSLR(GetBytesFromEncoding(UnicodeEncoding(), _0020));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm algorithm = (SymmetricAlgorithm)GetAlgorithm();
			SetSymmetricAlgorithmKey(algorithm, array2);
			SetSymmetricAlgorithmIV(algorithm, array3);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)CreateEncryptor(algorithm), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			CloseStream(cryptoStream);
			return (string)ArrayToString(StreamToArray(memoryStream));
		}

		internal static object UnicodeEncoding()
		{
			return Encoding.Unicode;
		}

		internal static void InitializeByRuntimeHelper(object P_0, RuntimeFieldHandle P_1)
		{
			RuntimeHelpers.InitializeArray((Array)P_0, P_1);
		}

		internal static object GetBytesFromEncoding(object P_0, object P_1)
		{
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		internal static object dQY6noZDpeH1RsStKSLR(object P_0)
		{
			return erhwkCleV((byte[])P_0);
		}

		internal static object GetAlgorithm()
		{
			return GetSymmetricAlgorithm();
		}

		internal static void SetSymmetricAlgorithmKey(object P_0, object P_1)
		{
			((SymmetricAlgorithm)P_0).Key = (byte[])P_1;
		}

		internal static void SetSymmetricAlgorithmIV(object P_0, object P_1)
		{
			((SymmetricAlgorithm)P_0).IV = (byte[])P_1;
		}

		internal static object CreateEncryptor(object P_0)
		{
			return ((SymmetricAlgorithm)P_0).CreateEncryptor();
		}

		internal static void CloseStream(object P_0)
		{
			((Stream)P_0).Close();
		}

		internal static object StreamToArray(object P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		internal static object ArrayToString(object P_0)
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
			return (Stream)XSrPevZDMIIc7mJK3ibt(PTIIvZJmfC);
		}

		internal byte[] z47It19xek(int _0020)
		{
			return (byte[])RlI9MhZDJioIEcL2Rgic(PTIIvZJmfC, _0020);
		}

		internal int NQ1IZyT0jI(byte[] _0020, int _0020, int _0020)
		{
			return PTIIvZJmfC.Read(_0020, _0020, _0020);
		}

		internal int wgZIumIPsF()
		{
			return PuqQHXZD9XcXmH2dQAgw(PTIIvZJmfC);
		}

		internal void V26I7M2UXj()
		{
			PTIIvZJmfC.Close();
		}

		internal static object XSrPevZDMIIc7mJK3ibt(object P_0)
		{
			return ((BinaryReader)P_0).BaseStream;
		}

		internal static object RlI9MhZDJioIEcL2Rgic(object P_0, int P_1)
		{
			return ((BinaryReader)P_0).ReadBytes(P_1);
		}

		internal static int PuqQHXZD9XcXmH2dQAgw(object P_0)
		{
			return ((BinaryReader)P_0).ReadInt32();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr FindResource(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr VirtualAlloc(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int VirtualProtect(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int BJSCyWPgKUiJQGYihL(IntPtr ptr);

	[Flags]
	private enum v6InYtDFWZApx1JyNL
	{

	}

	private static bool uU3JCB0s8;

	private static Dictionary<int, int> pAL10SKCoC;

	private static object bYc11bZ2yR;

	private static object t8Q1fis8nb;

	private static byte[] lRG1gLlTer;

	private static IntPtr ueQ1CBZqwr;

	private static int[] Syr1aJSCyW;

	private static int fKU1wiJQGY;

	private static int VyN15LqlEh;

	private static long X4h1A928yN;

	private static long CoD1QZV1a1;

	private static int SDV1d6LAgj;

	private static IntPtr WB11tRIZxP;

	private static FindResource CHf1uRY5iT;

	private static string WDJ1r9tJFl;

	private static uint[] U6XE6mvyw;

	private static bool GJ23VPZUC;

	private static VirtualProtect HqA1otFDcJ;

	internal static Hashtable BSI1ZLPHr8;

	private static OpenProcess J8t1vEcUBI;

	private static int RYG1kecuXB;

	private static BJSCyWPgKUiJQGYihL D081RjBZ7X;

	private static IntPtr hyO1NyyabH;

	private static VirtualAlloc XJ517srtuJ;

	internal static RSACryptoServiceProvider EXHzxLTGx;

	private static bool atZ1SSejVu;

	private static WriteProcessMemory PrY1OKksdd;

	internal static vbhv6YuBLBnZE0HBZU iBN1U8RgNG;

	private static List<string> RaA1I3e0cE;

	private static bool mhL1hZ6InY;

	private static SortedList uFW1iZApx1;

	private static List<int> BV01muBIf0;

	private static int Pgs1HOBEQA;

	private static bool QxN19ECe8h;

	internal static vbhv6YuBLBnZE0HBZU XBV1llcJHV;

	[ProductEventEntry(typeof(ProductEventEntry.ExceptionFilterResolver<object>[]))]
	private static bool firstrundone;

	private static object BiA1jH0AoM;

	private static IntPtr lQu18GAsIh;

	private static bool VIl2UgjvI;

	private static byte[] QRR1YKfBNJ;

	internal static Assembly QDHV0iQKg;

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

	private void cryZteqBvKK()
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
			uint num13 = 597185232u;
			uint num14 = 1656200256u;
			uint num15 = 1211665742u;
			uint num16 = num12;
			uint num17 = 1059298037u;
			uint num18 = 1762991537u;
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

	internal static SymmetricAlgorithm GetSymmetricAlgorithm()
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
					BinaryReader binaryReader = new BinaryReader(typeof(z2jc63fLkugS1X8Q9N).Assembly.GetManifestResourceStream("L84XgvvdxiIKlHnGTN.OerXNQ8UxuLg3XQ91S"));
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
		//Discarded unreachable code: IL_0808, IL_0817, IL_0bdc, IL_202f, IL_203e, IL_20fd
		int num = 127;
		byte[] array4 = default(byte[]);
		int num3 = default(int);
		int num4 = default(int);
		byte[] array = default(byte[]);
		int num5 = default(int);
		byte[] array6 = default(byte[]);
		int num6 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		byte[] array5 = default(byte[]);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 123:
					array4[26] = 219;
					num2 = 83;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 31;
					}
					continue;
				case 178:
					num3 = 165 - 55;
					num = 148;
					break;
				case 225:
					array4[9] = 36;
					num2 = 14;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 4;
					}
					continue;
				case 207:
					num4 = 80 + 1;
					num2 = 217;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 61;
					}
					continue;
				case 26:
					array4[7] = 68;
					num2 = 0;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 4;
					}
					continue;
				case 165:
					array[9] = (byte)num3;
					num2 = 355;
					continue;
				case 156:
					num4 = 251 - 83;
					num2 = 191;
					continue;
				case 38:
					array4[22] = 203;
					num2 = 135;
					continue;
				case 286:
					num5 = 243 - 81;
					num2 = 336;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 278;
					}
					continue;
				case 67:
					array[13] = (byte)num3;
					num2 = 343;
					continue;
				case 126:
					array4 = new byte[32];
					num2 = 157;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 211;
					}
					continue;
				case 346:
					num5 = 37 + 60;
					num2 = 215;
					continue;
				case 5:
					array4[3] = 120;
					num2 = 98;
					continue;
				case 114:
					num4 = 121 - 19;
					num2 = 64;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 121;
					}
					continue;
				case 150:
					num4 = 64 + 5;
					num2 = 275;
					continue;
				case 350:
					array4[17] = (byte)num4;
					num2 = 2;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 22;
					}
					continue;
				case 279:
					num5 = 166 - 55;
					num2 = 23;
					continue;
				case 65:
					array[10] = (byte)num3;
					num2 = 136;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 17;
					}
					continue;
				case 45:
					array4[7] = 149;
					num2 = 26;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 23;
					}
					continue;
				case 181:
					array[6] = (byte)num3;
					num2 = 342;
					continue;
				case 64:
				case 337:
					array6[num6] = (byte)(array6[num6] ^ array2[num6]);
					num2 = 237;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 37;
					}
					continue;
				case 278:
					array4[31] = (byte)num4;
					num2 = 27;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 172;
					}
					continue;
				case 257:
					array[11] = 126;
					num2 = 50;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 140;
					}
					continue;
				case 6:
					array2[7] = array3[3];
					num2 = 110;
					continue;
				case 168:
					num4 = 158 - 52;
					num2 = 187;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 205;
					}
					continue;
				case 14:
					array4[10] = 120;
					num2 = 326;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 212;
					}
					continue;
				case 49:
					array[0] = 166;
					num2 = 262;
					continue;
				case 322:
					array[2] = 71;
					num2 = 179;
					continue;
				case 120:
					num3 = 198 - 123;
					num2 = 118;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 47;
					}
					continue;
				case 311:
					array4[17] = (byte)num5;
					num2 = 269;
					continue;
				case 203:
					array4[26] = 154;
					num2 = 13;
					continue;
				case 228:
					array4[16] = (byte)num4;
					num2 = 45;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 313;
					}
					continue;
				case 309:
					array4[15] = 98;
					num2 = 294;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 92;
					}
					continue;
				case 129:
					array[2] = (byte)num3;
					num2 = 16;
					continue;
				case 36:
					array5 = lRG1gLlTer;
					num2 = 288;
					continue;
				case 324:
					array4[18] = (byte)num5;
					num2 = 339;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 358;
					}
					continue;
				case 146:
					num5 = 210 - 86;
					num2 = 126;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 145;
					}
					continue;
				case 253:
					num5 = 33 + 77;
					num2 = 91;
					continue;
				case 94:
					num3 = 242 + 2;
					num2 = 8;
					continue;
				case 43:
					array4[9] = 167;
					num2 = 125;
					continue;
				case 214:
					array2[5] = array3[2];
					num2 = 4;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 6;
					}
					continue;
				case 343:
					num3 = 164 + 31;
					num2 = 252;
					continue;
				case 263:
					array4[4] = 63;
					num2 = 150;
					continue;
				case 252:
					array[13] = (byte)num3;
					num2 = 116;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 72;
					}
					continue;
				case 31:
					array4[3] = (byte)num4;
					num2 = 5;
					continue;
				case 172:
					array6 = array4;
					num2 = 7;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 80;
					}
					continue;
				case 247:
					array4[15] = 137;
					num2 = 118;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 241;
					}
					continue;
				case 125:
					array4[9] = 97;
					num2 = 113;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 103;
					}
					continue;
				case 122:
					num3 = 142 - 47;
					num2 = 223;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 22;
					}
					continue;
				case 4:
					array4[7] = 44;
					num2 = 299;
					continue;
				case 124:
					array4[29] = 156;
					num2 = 306;
					continue;
				case 130:
					if (_0020 == -1)
					{
						num2 = 208;
						continue;
					}
					goto case 288;
				case 77:
					num4 = 146 + 37;
					num = 115;
					break;
				case 219:
					return;
				case 347:
					array4[1] = (byte)num4;
					num2 = 78;
					continue;
				case 234:
					num3 = 176 - 78;
					num2 = 181;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 6;
					}
					continue;
				case 194:
					array[4] = 90;
					num2 = 220;
					continue;
				case 261:
				{
					CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					C5YSdJ2K03srqOOBuu(cryptoStream, array5, 0, array5.Length);
					tS1Y6rejT9F6aWlPE7(cryptoStream);
					lRG1gLlTer = (byte[])XqPJRlP9aYpHcL6PAh(stream);
					cDvytp1fQsLy0pcpxV(stream);
					cDvytp1fQsLy0pcpxV(cryptoStream);
					num2 = 36;
					continue;
				}
				case 244:
					array4[17] = (byte)num5;
					num2 = 259;
					continue;
				case 164:
					num4 = 68 + 82;
					num2 = 22;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 31;
					}
					continue;
				case 163:
					array4[29] = (byte)num4;
					num2 = 265;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 174;
					}
					continue;
				case 312:
					array[9] = 67;
					num2 = 348;
					continue;
				case 331:
					array4[24] = 84;
					num2 = 300;
					continue;
				case 141:
					array[14] = 155;
					num2 = 117;
					continue;
				case 285:
					num4 = 16 + 53;
					num = 61;
					break;
				case 69:
					num3 = 6 + 89;
					num2 = 219;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 251;
					}
					continue;
				case 162:
					array4[21] = 166;
					num2 = 37;
					continue;
				case 275:
					array4[4] = (byte)num4;
					num2 = 153;
					continue;
				case 215:
					array4[25] = (byte)num5;
					num2 = 109;
					continue;
				case 294:
					array4[15] = 182;
					num2 = 41;
					continue;
				case 295:
					num3 = 148 + 40;
					num2 = 209;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 31;
					}
					continue;
				case 198:
					array4[12] = (byte)num4;
					num2 = 0;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 0;
					}
					continue;
				case 349:
					array4[13] = 54;
					num2 = 230;
					continue;
				case 92:
					array4[1] = (byte)num5;
					num = 268;
					break;
				case 169:
					num3 = 173 - 57;
					num2 = 296;
					continue;
				case 153:
					num5 = 97 + 3;
					num2 = 272;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 130;
					}
					continue;
				case 269:
					array4[17] = 112;
					num = 351;
					break;
				case 205:
					array4[6] = (byte)num4;
					num2 = 84;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 66;
					}
					continue;
				case 291:
					array[9] = (byte)num3;
					num2 = 213;
					continue;
				case 174:
					array[1] = 134;
					num2 = 287;
					continue;
				case 202:
					num4 = 192 - 64;
					num2 = 198;
					continue;
				case 296:
					array[10] = (byte)num3;
					num2 = 200;
					continue;
				case 161:
					num4 = 66 - 20;
					num2 = 157;
					continue;
				case 171:
					array[5] = 112;
					num2 = 52;
					continue;
				case 37:
					num5 = 78 + 66;
					num2 = 222;
					continue;
				case 301:
					num4 = 105 + 47;
					num2 = 236;
					continue;
				case 89:
					num4 = 151 + 57;
					num2 = 350;
					continue;
				case 24:
					num4 = 155 - 51;
					num2 = 55;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 75;
					}
					continue;
				case 246:
					array2[3] = array3[1];
					num2 = 184;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 214;
					}
					continue;
				case 173:
					array4[31] = (byte)num5;
					num2 = 302;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 0;
					}
					continue;
				case 71:
					array4[25] = (byte)num4;
					num2 = 271;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 271;
					}
					continue;
				case 22:
					num5 = 195 - 65;
					num2 = 216;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 324;
					}
					continue;
				case 17:
					array4[24] = (byte)num4;
					num2 = 239;
					continue;
				case 277:
					array4[13] = (byte)num5;
					num2 = 159;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 31;
					}
					continue;
				case 182:
					num5 = 91 + 46;
					num2 = 311;
					continue;
				case 101:
					array[8] = (byte)num3;
					num2 = 51;
					continue;
				case 40:
					array[9] = (byte)num3;
					num2 = 312;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 184;
					}
					continue;
				case 226:
					array4[5] = (byte)num5;
					num2 = 9;
					continue;
				case 271:
					array4[26] = 165;
					num2 = 123;
					continue;
				case 52:
					array[5] = 205;
					num = 69;
					break;
				case 303:
					array4[17] = (byte)num5;
					num2 = 89;
					continue;
				case 293:
					array[11] = (byte)num3;
					num2 = 12;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 35;
					}
					continue;
				case 195:
					array4[27] = 104;
					num2 = 161;
					continue;
				case 262:
					num3 = 121 + 85;
					num2 = 29;
					continue;
				case 290:
					array4[16] = (byte)num5;
					num2 = 182;
					continue;
				case 144:
					array[10] = (byte)num3;
					num2 = 214;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 238;
					}
					continue;
				case 333:
					array4[30] = (byte)num4;
					num2 = 18;
					continue;
				case 305:
					array[11] = (byte)num3;
					num2 = 257;
					continue;
				case 342:
					array[7] = 103;
					num2 = 142;
					continue;
				case 96:
					array4[30] = 97;
					num2 = 216;
					continue;
				case 42:
					array4[20] = 51;
					num2 = 281;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 114;
					}
					continue;
				case 192:
					array4[20] = (byte)num4;
					num2 = 151;
					continue;
				case 62:
					array[14] = (byte)num3;
					num2 = 79;
					continue;
				case 11:
					array4[21] = (byte)num4;
					num2 = 317;
					continue;
				case 59:
					array4[6] = (byte)num5;
					num2 = 73;
					continue;
				case 56:
					array4[28] = 117;
					num2 = 20;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 357;
					}
					continue;
				case 339:
					num3 = 57 + 89;
					num2 = 81;
					continue;
				case 196:
					array4[26] = 166;
					num2 = 203;
					continue;
				case 307:
					num4 = 23 - 5;
					num = 10;
					break;
				case 34:
					array4[3] = (byte)num4;
					num2 = 187;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 218;
					}
					continue;
				case 332:
					array[1] = 124;
					num2 = 174;
					continue;
				case 318:
					num5 = 114 + 76;
					num2 = 197;
					continue;
				case 266:
					num3 = 176 - 112;
					num2 = 1;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 1;
					}
					continue;
				case 33:
					array[8] = (byte)num3;
					num2 = 292;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 181;
					}
					continue;
				case 292:
					num3 = 159 + 77;
					num2 = 101;
					continue;
				case 84:
					num4 = 109 - 2;
					num2 = 124;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 308;
					}
					continue;
				case 186:
					array[15] = (byte)num3;
					num2 = 104;
					continue;
				case 143:
					num5 = 65 + 115;
					num2 = 241;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 244;
					}
					continue;
				case 221:
					array4[5] = (byte)num4;
					num2 = 320;
					continue;
				case 185:
					array4[2] = (byte)num4;
					num2 = 44;
					continue;
				case 218:
					num5 = 147 + 28;
					num = 55;
					break;
				default:
					num5 = 148 + 21;
					num2 = 120;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 329;
					}
					continue;
				case 289:
					array[1] = 147;
					num2 = 344;
					continue;
				case 132:
					if (array3 == null)
					{
						num = 282;
						break;
					}
					goto case 354;
				case 154:
					array4[22] = (byte)num5;
					num2 = 2;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 95;
					}
					continue;
				case 15:
					array[14] = (byte)num3;
					num2 = 141;
					continue;
				case 264:
					array[0] = 3;
					num2 = 49;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 72;
					}
					continue;
				case 197:
					array4[2] = (byte)num5;
					num2 = 256;
					continue;
				case 236:
					array4[25] = (byte)num4;
					num = 346;
					break;
				case 250:
					array[13] = 149;
					num2 = 7;
					continue;
				case 95:
					num4 = 187 - 62;
					num2 = 270;
					continue;
				case 86:
					array[3] = 85;
					num2 = 339;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 150;
					}
					continue;
				case 39:
					num3 = 196 - 65;
					num2 = 353;
					continue;
				case 35:
					num3 = 50 + 25;
					num2 = 54;
					continue;
				case 54:
					array[12] = (byte)num3;
					num = 138;
					break;
				case 68:
					array4[7] = 152;
					num2 = 283;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 106;
					}
					continue;
				case 326:
					num5 = 46 + 80;
					num2 = 327;
					continue;
				case 308:
					array4[6] = (byte)num4;
					num2 = 176;
					continue;
				case 330:
					array3 = (byte[])RrHRjrXAhPrqkcawGK(BymppBKWlaJrrVfKpm(QDHV0iQKg));
					num2 = 132;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 47;
					}
					continue;
				case 20:
					array[15] = (byte)num3;
					num2 = 266;
					continue;
				case 212:
					array[9] = (byte)num3;
					num2 = 111;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 187;
					}
					continue;
				case 113:
					array4[9] = 72;
					num2 = 225;
					continue;
				case 78:
					num5 = 96 + 35;
					num2 = 235;
					continue;
				case 116:
					array[14] = 159;
					num2 = 70;
					continue;
				case 223:
					array[0] = (byte)num3;
					num = 264;
					break;
				case 344:
					num3 = 72 - 17;
					num2 = 88;
					continue;
				case 19:
					stream = (Stream)kpysBYONxnC3kb2mfp();
					num2 = 102;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 261;
					}
					continue;
				case 201:
					array4[28] = 165;
					num2 = 193;
					continue;
				case 235:
					array4[1] = (byte)num5;
					num2 = 318;
					continue;
				case 21:
					array[4] = 172;
					num2 = 15;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 297;
					}
					continue;
				case 76:
					num3 = 2 + 32;
					num2 = 188;
					continue;
				case 317:
					array4[21] = 116;
					num2 = 14;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 38;
					}
					continue;
				case 255:
					num5 = 113 + 65;
					num2 = 46;
					continue;
				case 1:
					array[15] = (byte)num3;
					num2 = 149;
					continue;
				case 282:
				case 321:
					num6 = 0;
					num2 = 52;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 325;
					}
					continue;
				case 99:
					array4[4] = (byte)num4;
					num2 = 232;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 165;
					}
					continue;
				case 209:
					array[2] = (byte)num3;
					num2 = 86;
					continue;
				case 32:
					num5 = 133 - 84;
					num2 = 154;
					continue;
				case 13:
					array4[27] = 122;
					num2 = 195;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 19;
					}
					continue;
				case 28:
					array4[25] = (byte)num5;
					num2 = 242;
					continue;
				case 47:
					array4[31] = 94;
					num2 = 175;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 5;
					}
					continue;
				case 345:
					Pgs1HOBEQA = 80;
					num2 = 248;
					continue;
				case 131:
					num3 = 150 + 104;
					num = 62;
					break;
				case 44:
					num5 = 177 - 59;
					num2 = 258;
					continue;
				case 66:
					num3 = 131 - 43;
					num = 356;
					break;
				case 85:
					num4 = 96 + 16;
					num2 = 347;
					continue;
				case 3:
					array4[29] = (byte)num4;
					num2 = 107;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 133;
					}
					continue;
				case 157:
					array4[27] = (byte)num4;
					num2 = 201;
					continue;
				case 302:
					num4 = 187 + 39;
					num2 = 278;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 209;
					}
					continue;
				case 327:
					array4[10] = (byte)num5;
					num2 = 158;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 139;
					}
					continue;
				case 30:
					num3 = 155 - 51;
					num = 48;
					break;
				case 304:
					array4[23] = (byte)num4;
					num2 = 166;
					continue;
				case 260:
					num4 = 107 + 28;
					num2 = 11;
					continue;
				case 108:
					num4 = 150 - 49;
					num2 = 185;
					continue;
				case 61:
					array4[26] = (byte)num4;
					num2 = 196;
					continue;
				case 328:
					array4[2] = 104;
					num2 = 323;
					continue;
				case 139:
					array4[25] = (byte)num5;
					num2 = 301;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 153;
					}
					continue;
				case 189:
				case 248:
					new z2jc63fLkugS1X8Q9N().b2qCrnKW1(array6, array2, array5);
					num2 = 171;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 219;
					}
					continue;
				case 63:
					num3 = 118 + 115;
					num2 = 25;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 199;
					}
					continue;
				case 338:
					num5 = 7 + 18;
					num2 = 92;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 39;
					}
					continue;
				case 284:
					array4[23] = (byte)num4;
					num2 = 34;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 53;
					}
					continue;
				case 251:
					array[6] = (byte)num3;
					num = 111;
					break;
				case 151:
					array4[21] = 134;
					num2 = 162;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 126;
					}
					continue;
				case 158:
					array4[10] = 75;
					num2 = 279;
					continue;
				case 227:
					array4[24] = (byte)num5;
					num2 = 105;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 331;
					}
					continue;
				case 135:
					array4[22] = 85;
					num2 = 32;
					continue;
				case 341:
					array2[13] = array3[6];
					num2 = 315;
					continue;
				case 254:
					num5 = 36 + 4;
					num2 = 227;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 193;
					}
					continue;
				case 160:
					num5 = 66 + 70;
					num2 = 226;
					continue;
				case 50:
					array4[6] = 114;
					num2 = 168;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 68;
					}
					continue;
				case 93:
					array4[24] = 188;
					num2 = 8;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 254;
					}
					continue;
				case 100:
					num3 = 24 + 54;
					num2 = 177;
					continue;
				case 320:
					array4[5] = 62;
					num2 = 160;
					continue;
				case 112:
					array4[19] = 90;
					num2 = 82;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 17;
					}
					continue;
				case 237:
					num6++;
					num2 = 184;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 159;
					}
					continue;
				case 210:
					array[13] = 124;
					num2 = 250;
					continue;
				case 177:
					array[12] = (byte)num3;
					num2 = 120;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 75;
					}
					continue;
				case 222:
					array4[21] = (byte)num5;
					num2 = 36;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 90;
					}
					continue;
				case 217:
					array4[12] = (byte)num4;
					num2 = 202;
					continue;
				case 267:
					array[6] = 118;
					num2 = 30;
					continue;
				case 329:
					array4[12] = (byte)num5;
					num2 = 183;
					continue;
				case 140:
					num3 = 109 - 27;
					num2 = 293;
					continue;
				case 190:
					array[4] = 164;
					num2 = 194;
					continue;
				case 281:
					num4 = 112 - 67;
					num2 = 192;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 8;
					}
					continue;
				case 355:
					num3 = 153 - 40;
					num2 = 212;
					continue;
				case 249:
					array4[16] = (byte)num4;
					num2 = 229;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 79;
					}
					continue;
				case 288:
					if (!TDnmtB3CLQW16q6vUO(neh49UN6dBqZ5jvM68(QDHV0iQKg), null))
					{
						num2 = 189;
						if (!SCNQAyZeH0hfkkW7kZ())
						{
							num2 = 159;
						}
						continue;
					}
					goto case 345;
				case 105:
					array4[2] = (byte)num5;
					num2 = 328;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 303;
					}
					continue;
				case 313:
					num5 = 126 + 62;
					num = 290;
					break;
				case 256:
					num5 = 221 - 73;
					num2 = 105;
					continue;
				case 23:
					array4[11] = (byte)num5;
					num2 = 286;
					continue;
				case 299:
					num4 = 135 - 45;
					num2 = 170;
					continue;
				case 8:
					array[7] = (byte)num3;
					num2 = 167;
					continue;
				case 60:
					num3 = 203 - 67;
					num2 = 305;
					continue;
				case 188:
					array[3] = (byte)num3;
					num2 = 340;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 182;
					}
					continue;
				case 152:
					array4[20] = 147;
					num2 = 42;
					continue;
				case 258:
					array4[3] = (byte)num5;
					num2 = 164;
					continue;
				case 109:
					num5 = 32 + 65;
					num2 = 1;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 28;
					}
					continue;
				case 81:
					array[3] = (byte)num3;
					num = 276;
					break;
				case 208:
				{
					object obj = oyO2EfTZ3iExJ03GSE();
					eZAcWqkyjh1aWBp0kb(obj, CipherMode.CBC);
					transform = (ICryptoTransform)Rd8WPPnBlVFcWuvbFf(obj, array6, array2);
					num2 = 19;
					continue;
				}
				case 359:
					array4[18] = 98;
					num2 = 84;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 310;
					}
					continue;
				case 265:
					array4[30] = 154;
					num2 = 206;
					continue;
				case 91:
					array4[6] = (byte)num5;
					num2 = 50;
					continue;
				case 199:
					array[0] = (byte)num3;
					num = 49;
					break;
				case 351:
					array4[17] = 102;
					num2 = 143;
					continue;
				case 27:
					num4 = 43 + 28;
					num2 = 32;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 228;
					}
					continue;
				case 90:
					num4 = 251 - 83;
					num2 = 106;
					continue;
				case 82:
					array4[19] = 25;
					num2 = 255;
					continue;
				case 9:
					num5 = 185 - 61;
					num2 = 59;
					continue;
				case 142:
					num3 = 200 - 66;
					num2 = 319;
					continue;
				case 16:
					array[2] = 189;
					num2 = 39;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 19;
					}
					continue;
				case 117:
					array[14] = 134;
					num2 = 231;
					continue;
				case 334:
					array[12] = (byte)num3;
					num2 = 100;
					continue;
				case 356:
					array[11] = (byte)num3;
					num2 = 60;
					continue;
				case 170:
					array4[8] = (byte)num4;
					num2 = 156;
					continue;
				case 179:
					num3 = 14 + 50;
					num2 = 54;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 129;
					}
					continue;
				case 315:
					array2[15] = array3[7];
					num2 = 321;
					continue;
				case 335:
					array[2] = (byte)num3;
					num2 = 295;
					continue;
				case 75:
					array4[18] = (byte)num4;
					num2 = 180;
					continue;
				case 55:
					array4[3] = (byte)num5;
					num = 263;
					break;
				case 357:
					num4 = 198 - 66;
					num2 = 3;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 3;
					}
					continue;
				case 136:
					num3 = 79 + 110;
					num2 = 280;
					continue;
				case 25:
					array4[2] = (byte)num5;
					num2 = 90;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 108;
					}
					continue;
				case 111:
					num3 = 106 + 106;
					num2 = 147;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 13;
					}
					continue;
				case 230:
					num5 = 126 - 42;
					num2 = 107;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 277;
					}
					continue;
				case 83:
					array4[26] = 127;
					num2 = 285;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 193;
					}
					continue;
				case 348:
					num3 = 136 - 45;
					num2 = 291;
					continue;
				case 166:
					num4 = 127 - 69;
					num2 = 108;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 284;
					}
					continue;
				case 316:
					num4 = 168 - 119;
					num2 = 99;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 38;
					}
					continue;
				case 206:
					array4[30] = 36;
					num2 = 45;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 96;
					}
					continue;
				case 51:
					num3 = 81 + 63;
					num = 40;
					break;
				case 300:
					num4 = 198 - 111;
					num2 = 17;
					continue;
				case 176:
					array4[7] = 92;
					num2 = 68;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 4;
					}
					continue;
				case 138:
					array[12] = 159;
					num2 = 4;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 57;
					}
					continue;
				case 57:
					num3 = 43 + 87;
					num2 = 334;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 174;
					}
					continue;
				case 229:
					array4[16] = 62;
					num2 = 27;
					continue;
				case 306:
					array4[29] = 99;
					num2 = 2;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 1;
					}
					continue;
				case 118:
					array[12] = (byte)num3;
					num2 = 12;
					continue;
				case 270:
					array4[23] = (byte)num4;
					num = 274;
					break;
				case 232:
					num4 = 162 - 54;
					num = 221;
					break;
				case 239:
					num5 = 45 + 15;
					num2 = 139;
					continue;
				case 119:
					array4[13] = 53;
					num2 = 349;
					continue;
				case 231:
					array[14] = 151;
					num2 = 131;
					continue;
				case 79:
					num3 = 108 + 76;
					num2 = 186;
					continue;
				case 323:
					num5 = 129 - 43;
					num2 = 18;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 25;
					}
					continue;
				case 2:
					num4 = 195 + 31;
					num2 = 163;
					continue;
				case 167:
					array[8] = 85;
					num = 178;
					break;
				case 107:
					num3 = 136 - 45;
					num2 = 33;
					continue;
				case 276:
					array[3] = 135;
					num2 = 76;
					continue;
				case 145:
					array4[14] = (byte)num5;
					num2 = 309;
					continue;
				case 128:
					array4[14] = 138;
					num2 = 26;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 87;
					}
					continue;
				case 310:
					array4[18] = 83;
					num2 = 243;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 12;
					}
					continue;
				case 41:
					array4[15] = 113;
					num2 = 247;
					continue;
				case 133:
					array4[29] = 99;
					num2 = 124;
					continue;
				case 216:
					num5 = 47 + 60;
					num2 = 58;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 137;
					}
					continue;
				case 193:
					array4[28] = 123;
					num2 = 56;
					continue;
				case 191:
					array4[8] = (byte)num4;
					num2 = 77;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 7;
					}
					continue;
				case 148:
					array[8] = (byte)num3;
					num2 = 107;
					continue;
				case 240:
					num3 = 92 + 103;
					num2 = 208;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 335;
					}
					continue;
				case 268:
					array4[1] = 104;
					num2 = 85;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 34;
					}
					continue;
				case 242:
					num4 = 104 + 108;
					num2 = 71;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 19;
					}
					continue;
				case 283:
					array4[7] = 160;
					num2 = 45;
					continue;
				case 147:
					array[6] = (byte)num3;
					num2 = 267;
					continue;
				case 10:
					array4[0] = (byte)num4;
					num2 = 232;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 338;
					}
					continue;
				case 213:
					num3 = 106 + 30;
					num = 165;
					break;
				case 352:
					array4[0] = 115;
					num2 = 298;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 205;
					}
					continue;
				case 274:
					num4 = 236 - 78;
					num2 = 304;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 245;
					}
					continue;
				case 233:
					array4[12] = 146;
					num2 = 207;
					continue;
				case 137:
					array4[30] = (byte)num5;
					num = 314;
					break;
				case 98:
					num4 = 180 - 60;
					num = 34;
					break;
				case 336:
					array4[11] = (byte)num5;
					num2 = 114;
					continue;
				case 159:
					array4[13] = 24;
					num2 = 103;
					continue;
				case 259:
					num5 = 248 - 82;
					num2 = 303;
					continue;
				case 48:
					array[6] = (byte)num3;
					num2 = 83;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 234;
					}
					continue;
				case 102:
					num3 = 96 + 1;
					num2 = 245;
					continue;
				case 58:
					array4[20] = 96;
					num2 = 152;
					continue;
				case 180:
					array4[18] = 115;
					num2 = 359;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 88;
					}
					continue;
				case 87:
					array4[14] = 91;
					num2 = 146;
					continue;
				case 200:
					num3 = 187 - 62;
					num = 144;
					break;
				case 73:
					array4[6] = 84;
					num2 = 253;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 124;
					}
					continue;
				case 184:
				case 325:
					if (num6 < array2.Length)
					{
						num2 = 337;
						continue;
					}
					goto case 130;
				case 80:
					array = new byte[16];
					num = 273;
					break;
				case 149:
					array2 = array;
					num2 = 97;
					continue;
				case 298:
					num4 = 99 + 8;
					num2 = 45;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 74;
					}
					continue;
				case 110:
					array2[9] = array3[4];
					num2 = 204;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 156;
					}
					continue;
				case 183:
					array4[13] = 99;
					num2 = 84;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 119;
					}
					continue;
				case 314:
					num4 = 206 + 29;
					num = 333;
					break;
				case 353:
					array[2] = (byte)num3;
					num2 = 240;
					continue;
				case 74:
					array4[0] = (byte)num4;
					num2 = 307;
					continue;
				case 220:
					array[4] = 150;
					num2 = 21;
					continue;
				case 53:
					array4[24] = 84;
					num2 = 93;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 60;
					}
					continue;
				case 70:
					num3 = 16 + 89;
					num2 = 15;
					continue;
				case 115:
					array4[8] = (byte)num4;
					num2 = 43;
					continue;
				case 12:
					array[13] = 77;
					num2 = 210;
					continue;
				case 104:
					num3 = 95 + 74;
					num2 = 20;
					continue;
				case 224:
					array4[19] = (byte)num4;
					num2 = 112;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 53;
					}
					continue;
				case 297:
					array[5] = 98;
					num2 = 171;
					continue;
				case 121:
					array4[11] = (byte)num4;
					num2 = 233;
					continue;
				case 280:
					array[10] = (byte)num3;
					num2 = 66;
					continue;
				case 97:
					inHX1XqWpeLJcwLVEG(array2);
					num2 = 95;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 330;
					}
					continue;
				case 187:
					array[10] = 202;
					num2 = 153;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 169;
					}
					continue;
				case 88:
					array[1] = (byte)num3;
					num2 = 111;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 322;
					}
					continue;
				case 273:
					array[0] = 82;
					num = 63;
					break;
				case 29:
					array[0] = (byte)num3;
					num2 = 122;
					continue;
				case 358:
					array4[18] = 149;
					num2 = 19;
					if (SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 24;
					}
					continue;
				case 272:
					array4[4] = (byte)num5;
					num2 = 314;
					if (Rk0LOcufQks7olMhDK() == null)
					{
						num2 = 316;
					}
					continue;
				case 134:
					array[4] = 110;
					num = 190;
					break;
				case 354:
					if (array3.Length != 0)
					{
						num2 = 155;
						if (!SCNQAyZeH0hfkkW7kZ())
						{
							num2 = 107;
						}
						continue;
					}
					goto case 282;
				case 46:
					array4[20] = (byte)num5;
					num2 = 58;
					continue;
				case 340:
					array[3] = 202;
					num = 102;
					break;
				case 106:
					array4[21] = (byte)num4;
					num2 = 260;
					continue;
				case 245:
					array[4] = (byte)num3;
					num2 = 134;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 116;
					}
					continue;
				case 7:
					num3 = 172 - 57;
					num2 = 67;
					continue;
				case 127:
				{
					fjvIDXoHxLTGxlALSK fjvIDXoHxLTGxlALSK = new fjvIDXoHxLTGxlALSK((Stream)_0020);
					jOnhmMVkkGTF5njuD0(IYOaOjIX4DJOU0OhEB(fjvIDXoHxLTGxlALSK), 0L);
					array5 = (byte[])rL0DaiiilRaCKOxKfe(fjvIDXoHxLTGxlALSK, (int)JwPiwDSJfmXoO5y10f(IYOaOjIX4DJOU0OhEB(fjvIDXoHxLTGxlALSK)));
					iYKqniRckqGNDwDnpU(fjvIDXoHxLTGxlALSK);
					num2 = 126;
					if (Rk0LOcufQks7olMhDK() != null)
					{
						num2 = 0;
					}
					continue;
				}
				case 204:
					array2[11] = array3[5];
					num2 = 341;
					continue;
				case 18:
					array4[31] = 162;
					num2 = 47;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 12;
					}
					continue;
				case 175:
					num5 = 194 - 64;
					num2 = 173;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 35;
					}
					continue;
				case 72:
					array[1] = 100;
					num2 = 332;
					if (!SCNQAyZeH0hfkkW7kZ())
					{
						num2 = 135;
					}
					continue;
				case 103:
					array4[14] = 144;
					num2 = 128;
					continue;
				case 238:
					num3 = 213 - 71;
					num = 65;
					break;
				case 211:
					array4[0] = 117;
					num2 = 352;
					continue;
				case 243:
					num4 = 229 - 76;
					num2 = 224;
					continue;
				case 155:
					array2[1] = array3[0];
					num2 = 246;
					continue;
				case 241:
					num4 = 39 + 43;
					num2 = 249;
					continue;
				case 319:
					array[7] = (byte)num3;
					num = 94;
					break;
				case 287:
					array[1] = 133;
					num = 289;
					break;
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
			dr5SSqLSS(QDHV0iQKg.GetManifestResourceStream("0203vEBWP7554R4YVJ.apjhGtWfgnOVBliMOj"), _0020);
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
				SingletonReader.JJCZtPuTvSt();
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
			CHf1uRY5iT = (FindResource)Marshal.GetDelegateForFunctionPointer(r76RP97uO(pZbnhv6YB(), "Find ".Trim() + "ResourceA"), typeof(FindResource));
		}
		return CHf1uRY5iT(_0020, (string)_0020, _0020);
	}

	private static IntPtr hrKrktdEC(IntPtr _0020, uint _0020, uint _0020, uint _0020)
	{
		if (XJ517srtuJ == null)
		{
			XJ517srtuJ = (VirtualAlloc)Marshal.GetDelegateForFunctionPointer(r76RP97uO(pZbnhv6YB(), "Virtual ".Trim() + "Alloc"), typeof(VirtualAlloc));
		}
		return XJ517srtuJ(_0020, _0020, _0020, _0020);
	}

	private static int tdobkFCxq(IntPtr _0020, IntPtr _0020, [In][Out] byte[] _0020, uint _0020, out IntPtr _0020)
	{
		if (PrY1OKksdd == null)
		{
			PrY1OKksdd = (WriteProcessMemory)Marshal.GetDelegateForFunctionPointer(r76RP97uO(pZbnhv6YB(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(WriteProcessMemory));
		}
		return PrY1OKksdd(_0020, _0020, _0020, _0020, out _0020);
	}

	private static int sHBPFakju(IntPtr _0020, int _0020, int _0020, ref int _0020)
	{
		if (HqA1otFDcJ == null)
		{
			HqA1otFDcJ = (VirtualProtect)Marshal.GetDelegateForFunctionPointer(r76RP97uO(pZbnhv6YB(), "Virtual ".Trim() + "Protect"), typeof(VirtualProtect));
		}
		return HqA1otFDcJ(_0020, _0020, _0020, ref _0020);
	}

	private static IntPtr wOCDlEV0B(uint _0020, int _0020, uint _0020)
	{
		if (J8t1vEcUBI == null)
		{
			J8t1vEcUBI = (OpenProcess)Marshal.GetDelegateForFunctionPointer(r76RP97uO(pZbnhv6YB(), "Open ".Trim() + "Process"), typeof(OpenProcess));
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
		SymmetricAlgorithm symmetricAlgorithm = GetSymmetricAlgorithm();
		symmetricAlgorithm.Key = new byte[32]
		{
			8, 65, 245, 156, 60, 186, 31, 254, 206, 59,
			238, 193, 134, 137, 119, 6, 24, 248, 240, 106,
			205, 52, 145, 172, 116, 149, 184, 19, 79, 26,
			173, 91
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			49, 44, 125, 243, 1, 149, 142, 52, 240, 253,
			155, 202, 206, 69, 149, 210
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])_0020, 0, ((Array)_0020).Length);
		cryptoStream.Close();
		byte[] result = NiXTA2HX7(stream);
		SingletonReader.JJCZtPuTvSt();
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

	internal static object IYOaOjIX4DJOU0OhEB(object P_0)
	{
		return ((fjvIDXoHxLTGxlALSK)P_0).m9OIO8Q0EK();
	}

	internal static void jOnhmMVkkGTF5njuD0(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long JwPiwDSJfmXoO5y10f(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object rL0DaiiilRaCKOxKfe(object P_0, int _0020)
	{
		return ((fjvIDXoHxLTGxlALSK)P_0).z47It19xek(_0020);
	}

	internal static void iYKqniRckqGNDwDnpU(object P_0)
	{
		((fjvIDXoHxLTGxlALSK)P_0).V26I7M2UXj();
	}

	internal static void inHX1XqWpeLJcwLVEG(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object BymppBKWlaJrrVfKpm(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object RrHRjrXAhPrqkcawGK(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object oyO2EfTZ3iExJ03GSE()
	{
		return GetSymmetricAlgorithm();
	}

	internal static void eZAcWqkyjh1aWBp0kb(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object Rd8WPPnBlVFcWuvbFf(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object kpysBYONxnC3kb2mfp()
	{
		return lkp69qZGc();
	}

	internal static void C5YSdJ2K03srqOOBuu(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void tS1Y6rejT9F6aWlPE7(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object XqPJRlP9aYpHcL6PAh(object P_0)
	{
		return NiXTA2HX7((Stream)P_0);
	}

	internal static void cDvytp1fQsLy0pcpxV(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object neh49UN6dBqZ5jvM68(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool TDnmtB3CLQW16q6vUO(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool SCNQAyZeH0hfkkW7kZ()
	{
		return (object)null == null;
	}

	internal static object Rk0LOcufQks7olMhDK()
	{
		return null;
	}
}

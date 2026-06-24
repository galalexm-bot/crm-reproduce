using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Packaging;

internal static class PEFile
{
	public struct IMAGE_DOS_HEADER
	{
		public ushort e_cblp;

		public ushort e_cp;

		public ushort e_crlc;

		public ushort e_cparhdr;

		public ushort e_minalloc;

		public ushort e_maxalloc;

		public ushort e_ss;

		public ushort e_sp;

		public ushort e_csum;

		public ushort e_ip;

		public ushort e_cs;

		public ushort e_lfarlc;

		public ushort e_ovno;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public ushort[] e_res1;

		public ushort e_oemid;

		public ushort e_oeminfo;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public ushort[] e_res2;

		public int e_lfanew;
	}

	public struct IMAGE_NT_HEADERS32
	{
		public uint Signature;

		[MarshalAs(UnmanagedType.Struct)]
		public IMAGE_FILE_HEADER FileHeader;

		[MarshalAs(UnmanagedType.Struct)]
		public IMAGE_OPTIONAL_HEADER32 OptionalHeader;
	}

	public struct IMAGE_FILE_HEADER
	{
		public ushort Machine;

		public ushort NumberOfSections;

		public uint TimeDateStamp;

		public uint PointerToSymbolTable;

		public uint NumberOfSymbols;

		public ushort SizeOfOptionalHeader;

		public ushort Characteristics;
	}

	public enum MachineType : ushort
	{
		Native = 0,
		I386 = 332,
		Itanium = 512,
		x64 = 34404
	}

	public enum MagicType : ushort
	{
		IMAGE_NT_OPTIONAL_HDR32_MAGIC = 267,
		IMAGE_NT_OPTIONAL_HDR64_MAGIC = 523
	}

	public enum SubSystemType : ushort
	{
		IMAGE_SUBSYSTEM_UNKNOWN = 0,
		IMAGE_SUBSYSTEM_NATIVE = 1,
		IMAGE_SUBSYSTEM_WINDOWS_GUI = 2,
		IMAGE_SUBSYSTEM_WINDOWS_CUI = 3,
		IMAGE_SUBSYSTEM_POSIX_CUI = 7,
		IMAGE_SUBSYSTEM_WINDOWS_CE_GUI = 9,
		IMAGE_SUBSYSTEM_EFI_APPLICATION = 10,
		IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER = 11,
		IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER = 12,
		IMAGE_SUBSYSTEM_EFI_ROM = 13,
		IMAGE_SUBSYSTEM_XBOX = 14
	}

	public enum DllCharacteristicsType : ushort
	{
		RES_0 = 1,
		RES_1 = 2,
		RES_2 = 4,
		RES_3 = 8,
		IMAGE_DLL_CHARACTERISTICS_DYNAMIC_BASE = 0x40,
		IMAGE_DLL_CHARACTERISTICS_FORCE_INTEGRITY = 0x80,
		IMAGE_DLL_CHARACTERISTICS_NX_COMPAT = 0x100,
		IMAGE_DLLCHARACTERISTICS_NO_ISOLATION = 0x200,
		IMAGE_DLLCHARACTERISTICS_NO_SEH = 0x400,
		IMAGE_DLLCHARACTERISTICS_NO_BIND = 0x800,
		RES_4 = 0x1000,
		IMAGE_DLLCHARACTERISTICS_WDM_DRIVER = 0x2000,
		IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE = 0x8000
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct IMAGE_OPTIONAL_HEADER32
	{
		[FieldOffset(0)]
		public MagicType Magic;

		[FieldOffset(2)]
		public byte MajorLinkerVersion;

		[FieldOffset(3)]
		public byte MinorLinkerVersion;

		[FieldOffset(4)]
		public uint SizeOfCode;

		[FieldOffset(8)]
		public uint SizeOfInitializedData;

		[FieldOffset(12)]
		public uint SizeOfUninitializedData;

		[FieldOffset(16)]
		public uint AddressOfEntryPoint;

		[FieldOffset(20)]
		public uint BaseOfCode;

		[FieldOffset(24)]
		public uint BaseOfData;

		[FieldOffset(28)]
		public uint ImageBase;

		[FieldOffset(32)]
		public uint SectionAlignment;

		[FieldOffset(36)]
		public uint FileAlignment;

		[FieldOffset(40)]
		public ushort MajorOperatingSystemVersion;

		[FieldOffset(42)]
		public ushort MinorOperatingSystemVersion;

		[FieldOffset(44)]
		public ushort MajorImageVersion;

		[FieldOffset(46)]
		public ushort MinorImageVersion;

		[FieldOffset(48)]
		public ushort MajorSubsystemVersion;

		[FieldOffset(50)]
		public ushort MinorSubsystemVersion;

		[FieldOffset(52)]
		public uint Win32VersionValue;

		[FieldOffset(56)]
		public uint SizeOfImage;

		[FieldOffset(60)]
		public uint SizeOfHeaders;

		[FieldOffset(64)]
		public uint CheckSum;

		[FieldOffset(68)]
		public SubSystemType Subsystem;

		[FieldOffset(70)]
		public DllCharacteristicsType DllCharacteristics;

		[FieldOffset(72)]
		public uint SizeOfStackReserve;

		[FieldOffset(76)]
		public uint SizeOfStackCommit;

		[FieldOffset(80)]
		public uint SizeOfHeapReserve;

		[FieldOffset(84)]
		public uint SizeOfHeapCommit;

		[FieldOffset(88)]
		public uint LoaderFlags;

		[FieldOffset(92)]
		public uint NumberOfRvaAndSizes;

		[FieldOffset(96)]
		public IMAGE_DATA_DIRECTORY ExportTable;

		[FieldOffset(104)]
		public IMAGE_DATA_DIRECTORY ImportTable;

		[FieldOffset(112)]
		public IMAGE_DATA_DIRECTORY ResourceTable;

		[FieldOffset(120)]
		public IMAGE_DATA_DIRECTORY ExceptionTable;

		[FieldOffset(128)]
		public IMAGE_DATA_DIRECTORY CertificateTable;

		[FieldOffset(136)]
		public IMAGE_DATA_DIRECTORY BaseRelocationTable;

		[FieldOffset(144)]
		public IMAGE_DATA_DIRECTORY Debug;

		[FieldOffset(152)]
		public IMAGE_DATA_DIRECTORY Architecture;

		[FieldOffset(160)]
		public IMAGE_DATA_DIRECTORY GlobalPtr;

		[FieldOffset(168)]
		public IMAGE_DATA_DIRECTORY TLSTable;

		[FieldOffset(176)]
		public IMAGE_DATA_DIRECTORY LoadConfigTable;

		[FieldOffset(184)]
		public IMAGE_DATA_DIRECTORY BoundImport;

		[FieldOffset(192)]
		public IMAGE_DATA_DIRECTORY IAT;

		[FieldOffset(200)]
		public IMAGE_DATA_DIRECTORY DelayImportDescriptor;

		[FieldOffset(208)]
		public IMAGE_DATA_DIRECTORY CLRRuntimeHeader;

		[FieldOffset(216)]
		public IMAGE_DATA_DIRECTORY Reserved;
	}

	public struct IMAGE_DATA_DIRECTORY
	{
		public uint VirtualAddress;

		public uint Size;
	}

	internal static class NativeMethods
	{
		public struct OFSTRUCT
		{
			public byte cBytes;

			public byte fFixedDisc;

			public ushort nErrCode;

			public ushort Reserved1;

			public ushort Reserved2;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string szPathName;
		}

		[Flags]
		public enum OpenFileStyle : uint
		{
			OF_CANCEL = 0x800u,
			OF_CREATE = 0x1000u,
			OF_DELETE = 0x200u,
			OF_EXIST = 0x4000u,
			OF_PARSE = 0x100u,
			OF_PROMPT = 0x2000u,
			OF_READ = 0u,
			OF_READWRITE = 2u,
			OF_REOPEN = 0x8000u,
			OF_SHARE_COMPAT = 0u,
			OF_SHARE_DENY_NONE = 0x40u,
			OF_SHARE_DENY_READ = 0x30u,
			OF_SHARE_DENY_WRITE = 0x20u,
			OF_SHARE_EXCLUSIVE = 0x10u,
			OF_VERIFY = 0x400u,
			OF_WRITE = 1u
		}

		public enum EMoveMethod : uint
		{
			Begin,
			Current,
			End
		}

		public const uint INVALID_SET_FILE_POINTER = uint.MaxValue;

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern SafeFileHandle CreateFile(string lpFileName, [MarshalAs(UnmanagedType.U4)] FileAccess dwDesiredAccess, [MarshalAs(UnmanagedType.U4)] FileShare dwShareMode, IntPtr lpSecurityAttributes, [MarshalAs(UnmanagedType.U4)] FileMode dwCreationDisposition, [MarshalAs(UnmanagedType.U4)] System.IO.FileAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

		[DllImport("kernel32.dll", BestFitMapping = false, ThrowOnUnmappableChar = true)]
		public static extern IntPtr OpenFile([MarshalAs(UnmanagedType.LPStr)] string lpFileName, out OFSTRUCT lpReOpenBuff, OpenFileStyle uStyle);

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseHandle(IntPtr hObject);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint SetFilePointer(IntPtr hFile, uint lDistanceToMove, IntPtr lpDistanceToMoveHigh, EMoveMethod dwMoveMethod);

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ReadFile(IntPtr handle, byte[] bytes, uint numBytesToRead, out uint numBytesRead, IntPtr overlapped);

		[DllImport("kernel32.dll")]
		public static extern bool WriteFile(IntPtr handle, byte[] bytes, uint numBytesToWrite, out uint numBytesWrote, IntPtr overlapped);
	}

	internal static PEFile pX6EriBepV0MCof8YHc6;

	public static bool AppendAdditionalData(string fileName, byte[] data)
	{
		//Discarded unreachable code: IL_01b6, IL_01c5, IL_01d5, IL_0233, IL_0246, IL_0255, IL_02c6, IL_02f0, IL_036c, IL_03dc, IL_04d7, IL_04e6, IL_04f6, IL_0568, IL_057b, IL_05fe, IL_061e, IL_062d
		int num = 6;
		int num2 = num;
		bool result = default(bool);
		SafeFileHandle safeFileHandle = default(SafeFileHandle);
		uint num4 = default(uint);
		uint num6 = default(uint);
		IMAGE_DATA_DIRECTORY certificateTable = default(IMAGE_DATA_DIRECTORY);
		IMAGE_NT_HEADERS32 headers = default(IMAGE_NT_HEADERS32);
		byte[] array = default(byte[]);
		uint size = default(uint);
		IntPtr destination = default(IntPtr);
		byte[] array3 = default(byte[]);
		uint headersOffset = default(uint);
		byte[] array2 = default(byte[]);
		uint num7 = default(uint);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return result;
			case 2:
				return true;
			case 4:
				safeFileHandle = NativeMethods.CreateFile(fileName, FileAccess.ReadWrite, FileShare.None, IntPtr.Zero, FileMode.Open, System.IO.FileAttributes.Normal, IntPtr.Zero);
				num2 = 7;
				continue;
			case 5:
				throw new ArgumentNullException((string)wkGnfDBetjnWdT8m8dmd(-740338220 ^ -740399068));
			case 6:
				if (data != null)
				{
					if (data.Length != 0)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 5;
				}
				continue;
			case 1:
				return false;
			case 8:
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				if (safeFileHandle != null)
				{
					num2 = 8;
					continue;
				}
				goto case 1;
			}
			try
			{
				IntPtr intPtr = safeFileHandle.DangerousGetHandle();
				int num3 = 12;
				while (true)
				{
					uint numBytesWrote;
					int num8;
					int num5;
					switch (num3)
					{
					case 6:
						return result;
					case 9:
						return result;
					case 19:
						return result;
					case 21:
						return result;
					case 25:
						return result;
					case 26:
						return result;
					case 37:
						return result;
					case 34:
						num4 = num6 % 8u;
						num3 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num3 = 24;
						}
						continue;
					case 16:
						certificateTable = headers.OptionalHeader.CertificateTable;
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num3 = 5;
						}
						continue;
					case 8:
					case 11:
						if (NativeMethods.WriteFile(intPtr, array, (uint)array.Length, out numBytesWrote, IntPtr.Zero))
						{
							num3 = 23;
							continue;
						}
						goto case 4;
					case 33:
						size = certificateTable.Size;
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num3 = 10;
						}
						continue;
					case 31:
					case 35:
						if (NativeMethods.SetFilePointer(intPtr, size + certificateTable.VirtualAddress, IntPtr.Zero, NativeMethods.EMoveMethod.Begin) == uint.MaxValue)
						{
							num3 = 19;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
							{
								num3 = 20;
							}
							continue;
						}
						goto case 36;
					case 17:
						destination = Marshal.UnsafeAddrOfPinnedArrayElement(array, 0);
						num8 = 3;
						goto IL_007d;
					case 5:
						num6 = (uint)(tFntFHBe4HmJA4Wj1Xcj(vONMsABewJ073i9PEe3n(typeof(uint).TypeHandle)) + data.Length);
						num3 = 34;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num3 = 16;
						}
						continue;
					case 18:
						if (NativeMethods.WriteFile(intPtr, array3, (uint)array3.Length, out numBytesWrote, IntPtr.Zero))
						{
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto case 22;
					default:
						result = false;
						num3 = 9;
						continue;
					case 20:
						result = false;
						num3 = 26;
						continue;
					case 27:
						num5 = 0;
						break;
					case 1:
						if (NativeMethods.SetFilePointer(intPtr, headersOffset, IntPtr.Zero, NativeMethods.EMoveMethod.Begin) == uint.MaxValue)
						{
							num3 = 16;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
							{
								num3 = 30;
							}
							continue;
						}
						goto case 33;
					case 30:
						result = false;
						num3 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num3 = 9;
						}
						continue;
					case 3:
						Marshal.Copy(data, 0, destination, data.Length);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num3 = 1;
						}
						continue;
					case 22:
						result = false;
						num3 = 37;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num3 = 33;
						}
						continue;
					case 12:
						if (!GetNTHeaders32(intPtr, out headers, out headersOffset))
						{
							num3 = 15;
							continue;
						}
						goto case 16;
					case 10:
						certificateTable.Size = size + num6;
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num3 = 14;
						}
						continue;
					case 15:
						result = false;
						num8 = 6;
						goto IL_007d;
					case 28:
						if (NativeMethods.WriteFile(intPtr, array2, (uint)array2.Length, out numBytesWrote, IntPtr.Zero))
						{
							num3 = 21;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
							{
								num3 = 31;
							}
							continue;
						}
						goto default;
					case 24:
						if (num4 != 0)
						{
							num3 = 7;
							continue;
						}
						goto case 27;
					case 36:
						array3 = StructToBytes(data.Length);
						num3 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num3 = 3;
						}
						continue;
					case 4:
						result = false;
						num3 = 21;
						continue;
					case 14:
						headers.OptionalHeader.CertificateTable = certificateTable;
						num3 = 29;
						continue;
					case 29:
						array2 = StructToBytes(headers);
						num3 = 28;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num3 = 12;
						}
						continue;
					case 2:
						array = new byte[data.Length + num7];
						num3 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num3 = 12;
						}
						continue;
					case 13:
					case 23:
						result = true;
						num8 = 25;
						goto IL_007d;
					case 32:
						num6 += num7;
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num3 = 0;
						}
						continue;
					case 7:
						{
							num5 = (int)(8 - num4);
							break;
						}
						IL_007d:
						num3 = num8;
						continue;
					}
					num7 = (uint)num5;
					num3 = 32;
				}
			}
			finally
			{
				jeljYTBe6UtLjv03Gsae(safeFileHandle);
				int num9 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num9 = 0;
				}
				switch (num9)
				{
				case 0:
					break;
				}
			}
		}
	}

	internal static bool GetNTHeaders32(IntPtr fileHandle, out IMAGE_NT_HEADERS32 headers, out uint headersOffset)
	{
		//Discarded unreachable code: IL_0084, IL_0093
		int num = 13;
		int num2 = num;
		uint num4 = default(uint);
		uint num3 = default(uint);
		byte[] array = default(byte[]);
		IMAGE_DOS_HEADER iMAGE_DOS_HEADER = default(IMAGE_DOS_HEADER);
		uint numBytesRead = default(uint);
		byte[] array2 = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				num4 = (uint)tFntFHBe4HmJA4Wj1Xcj(vONMsABewJ073i9PEe3n(typeof(IMAGE_NT_HEADERS32).TypeHandle));
				num2 = 15;
				break;
			case 7:
				num3 = (uint)tFntFHBe4HmJA4Wj1Xcj(vONMsABewJ073i9PEe3n(typeof(IMAGE_DOS_HEADER).TypeHandle));
				num2 = 10;
				break;
			case 14:
				array = StructToBytes<IMAGE_DOS_HEADER>();
				num2 = 7;
				break;
			case 4:
				headersOffset = (uint)iMAGE_DOS_HEADER.e_lfanew;
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 5;
				}
				break;
			case 16:
				return false;
			case 3:
				return false;
			case 1:
				return false;
			case 9:
				if (numBytesRead != num4)
				{
					num2 = 8;
					break;
				}
				headers = BytesToStruct<IMAGE_NT_HEADERS32>(array2);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				if (NativeMethods.SetFilePointer(fileHandle, 0u, IntPtr.Zero, NativeMethods.EMoveMethod.Begin) != uint.MaxValue)
				{
					numBytesRead = 0u;
					num2 = 14;
					break;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				return false;
			case 2:
				return true;
			case 17:
				if (NativeMethods.SetFilePointer(fileHandle, headersOffset, IntPtr.Zero, NativeMethods.EMoveMethod.Begin) != uint.MaxValue)
				{
					array2 = StructToBytes<IMAGE_NT_HEADERS32>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 6;
				}
				break;
			case 13:
				headers = default(IMAGE_NT_HEADERS32);
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 7;
				}
				break;
			case 12:
				headersOffset = 0u;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 5;
				}
				break;
			case 8:
				return false;
			case 11:
				return false;
			case 15:
				if (NativeMethods.ReadFile(fileHandle, array2, num4, out numBytesRead, IntPtr.Zero))
				{
					num2 = 9;
					break;
				}
				goto case 1;
			case 10:
				if (NativeMethods.ReadFile(fileHandle, array, num3, out numBytesRead, IntPtr.Zero))
				{
					if (numBytesRead != num3)
					{
						num2 = 11;
						break;
					}
					iMAGE_DOS_HEADER = BytesToStruct<IMAGE_DOS_HEADER>(array);
					num2 = 4;
				}
				else
				{
					num2 = 16;
				}
				break;
			}
		}
	}

	internal static byte[] StructToBytes<TStruct>() where TStruct : struct
	{
		return new byte[Marshal.SizeOf(typeof(TStruct))];
	}

	internal static byte[] StructToBytes<TStruct>(TStruct s) where TStruct : struct
	{
		int num = Marshal.SizeOf(s);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(s, intPtr, fDeleteOld: false);
		for (int i = 0; i < num; i++)
		{
			array[i] = Marshal.ReadByte(intPtr, i);
		}
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	public static TStruct BytesToStruct<TStruct>(byte[] arr) where TStruct : struct
	{
		int num = Marshal.SizeOf(new TStruct());
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		for (int i = 0; i < num; i++)
		{
			Marshal.WriteByte(intPtr, i, arr[i]);
		}
		TStruct result = (TStruct)Marshal.PtrToStructure(intPtr, typeof(TStruct));
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	internal static object wkGnfDBetjnWdT8m8dmd(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type vONMsABewJ073i9PEe3n(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static int tFntFHBe4HmJA4Wj1Xcj(Type P_0)
	{
		return Marshal.SizeOf(P_0);
	}

	internal static void jeljYTBe6UtLjv03Gsae(object P_0)
	{
		((SafeHandle)P_0).Dispose();
	}

	internal static bool u8wIdKBeaGZwlBSdqjSE()
	{
		return pX6EriBepV0MCof8YHc6 == null;
	}

	internal static PEFile aBy1mZBeD6DIZOrEXfyL()
	{
		return pX6EriBepV0MCof8YHc6;
	}
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.PEFile
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Microsoft.Win32.SafeHandles;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Packaging
{
  internal static class PEFile
  {
    internal static PEFile pX6EriBepV0MCof8YHc6;

    public static bool AppendAdditionalData(string fileName, byte[] data)
    {
      int num1 = 6;
      SafeFileHandle file;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_54;
          case 2:
            goto label_3;
          case 3:
            goto label_2;
          case 4:
            file = PEFile.NativeMethods.CreateFile(fileName, FileAccess.ReadWrite, FileShare.None, IntPtr.Zero, FileMode.Open, System.IO.FileAttributes.Normal, IntPtr.Zero);
            num1 = 7;
            continue;
          case 5:
            goto label_49;
          case 6:
            if (data != null)
            {
              if (data.Length != 0)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 4 : 0;
                continue;
              }
              goto label_3;
            }
            else
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 5;
              continue;
            }
          case 7:
            if (file != null)
            {
              num1 = 8;
              continue;
            }
            goto label_54;
          case 8:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      bool flag;
      return flag;
label_3:
      return true;
label_5:
      try
      {
        IntPtr handle = file.DangerousGetHandle();
        int num2 = 12;
        while (true)
        {
          int num3;
          uint num4;
          uint num5;
          PEFile.IMAGE_NT_HEADERS32 headers;
          PEFile.IMAGE_DATA_DIRECTORY certificateTable;
          byte[] numArray;
          uint numBytesWrote;
          uint size;
          IntPtr destination;
          byte[] bytes1;
          uint headersOffset;
          byte[] bytes2;
          uint num6;
          int num7;
          switch (num2)
          {
            case 1:
              if (PEFile.NativeMethods.SetFilePointer(handle, headersOffset, IntPtr.Zero, PEFile.NativeMethods.EMoveMethod.Begin) == uint.MaxValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 16 : 30;
                continue;
              }
              goto case 33;
            case 2:
              numArray = new byte[(long) data.Length + (long) num6];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 17 : 12;
              continue;
            case 3:
              Marshal.Copy(data, 0, destination, data.Length);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
              continue;
            case 4:
              flag = false;
              num2 = 21;
              continue;
            case 5:
              // ISSUE: type reference
              num4 = (uint) (PEFile.tFntFHBe4HmJA4Wj1Xcj(PEFile.vONMsABewJ073i9PEe3n(__typeref (uint))) + data.Length);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 34 : 16;
              continue;
            case 6:
            case 9:
            case 19:
            case 21:
            case 25:
            case 26:
            case 37:
              goto label_2;
            case 7:
              num7 = 8 - (int) num5;
              goto label_44;
            case 8:
            case 11:
              if (PEFile.NativeMethods.WriteFile(handle, numArray, (uint) numArray.Length, out numBytesWrote, IntPtr.Zero))
              {
                num2 = 23;
                continue;
              }
              goto case 4;
            case 10:
              certificateTable.Size = size + num4;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 3 : 14;
              continue;
            case 12:
              if (!PEFile.GetNTHeaders32(handle, out headers, out headersOffset))
              {
                num2 = 15;
                continue;
              }
              goto case 16;
            case 13:
            case 23:
              flag = true;
              num3 = 25;
              break;
            case 14:
              headers.OptionalHeader.CertificateTable = certificateTable;
              num2 = 29;
              continue;
            case 15:
              flag = false;
              num3 = 6;
              break;
            case 16:
              certificateTable = headers.OptionalHeader.CertificateTable;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 2 : 5;
              continue;
            case 17:
              destination = Marshal.UnsafeAddrOfPinnedArrayElement<byte>(numArray, 0);
              num3 = 3;
              break;
            case 18:
              if (PEFile.NativeMethods.WriteFile(handle, bytes1, (uint) bytes1.Length, out numBytesWrote, IntPtr.Zero))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 8 : 3;
                continue;
              }
              goto case 22;
            case 20:
              flag = false;
              num2 = 26;
              continue;
            case 22:
              flag = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 37 : 33;
              continue;
            case 24:
              if (num5 > 0U)
              {
                num2 = 7;
                continue;
              }
              goto case 27;
            case 27:
              num7 = 0;
              goto label_44;
            case 28:
              if (PEFile.NativeMethods.WriteFile(handle, bytes2, (uint) bytes2.Length, out numBytesWrote, IntPtr.Zero))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 21 : 31;
                continue;
              }
              goto default;
            case 29:
              bytes2 = PEFile.StructToBytes<PEFile.IMAGE_NT_HEADERS32>(headers);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 28 : 12;
              continue;
            case 30:
              flag = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 19 : 9;
              continue;
            case 31:
            case 35:
              if (PEFile.NativeMethods.SetFilePointer(handle, size + certificateTable.VirtualAddress, IntPtr.Zero, PEFile.NativeMethods.EMoveMethod.Begin) == uint.MaxValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 19 : 20;
                continue;
              }
              goto case 36;
            case 32:
              num4 += num6;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 0;
              continue;
            case 33:
              size = certificateTable.Size;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 5 : 10;
              continue;
            case 34:
              num5 = num4 % 8U;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 6 : 24;
              continue;
            case 36:
              bytes1 = PEFile.StructToBytes<int>(data.Length);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 18 : 3;
              continue;
            default:
              flag = false;
              num2 = 9;
              continue;
          }
          num2 = num3;
          continue;
label_44:
          num6 = (uint) num7;
          num2 = 32;
        }
      }
      finally
      {
        PEFile.jeljYTBe6UtLjv03Gsae((object) file);
        int num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
          num8 = 0;
        switch (num8)
        {
          default:
        }
      }
label_49:
      throw new ArgumentNullException((string) PEFile.wkGnfDBetjnWdT8m8dmd(-740338220 ^ -740399068));
label_54:
      return false;
    }

    internal static bool GetNTHeaders32(
      IntPtr fileHandle,
      out PEFile.IMAGE_NT_HEADERS32 headers,
      out uint headersOffset)
    {
      int num = 13;
      uint numBytesToRead1;
      uint numBytesToRead2;
      byte[] bytes1;
      PEFile.IMAGE_DOS_HEADER imageDosHeader;
      uint numBytesRead;
      byte[] bytes2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            goto label_18;
          case 3:
            goto label_9;
          case 4:
            headersOffset = (uint) imageDosHeader.e_lfanew;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 17 : 5;
            continue;
          case 5:
            if (PEFile.NativeMethods.SetFilePointer(fileHandle, 0U, IntPtr.Zero, PEFile.NativeMethods.EMoveMethod.Begin) != uint.MaxValue)
            {
              numBytesRead = 0U;
              num = 14;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 3 : 1;
            continue;
          case 6:
            goto label_16;
          case 7:
            // ISSUE: type reference
            numBytesToRead2 = (uint) PEFile.tFntFHBe4HmJA4Wj1Xcj(PEFile.vONMsABewJ073i9PEe3n(__typeref (PEFile.IMAGE_DOS_HEADER)));
            num = 10;
            continue;
          case 8:
            goto label_23;
          case 9:
            if ((int) numBytesRead != (int) numBytesToRead1)
            {
              num = 8;
              continue;
            }
            headers = PEFile.BytesToStruct<PEFile.IMAGE_NT_HEADERS32>(bytes2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 2;
            continue;
          case 10:
            if (PEFile.NativeMethods.ReadFile(fileHandle, bytes1, numBytesToRead2, out numBytesRead, IntPtr.Zero))
            {
              if ((int) numBytesRead != (int) numBytesToRead2)
              {
                num = 11;
                continue;
              }
              imageDosHeader = PEFile.BytesToStruct<PEFile.IMAGE_DOS_HEADER>(bytes1);
              num = 4;
              continue;
            }
            num = 16;
            continue;
          case 11:
            goto label_25;
          case 12:
            headersOffset = 0U;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 5;
            continue;
          case 13:
            headers = new PEFile.IMAGE_NT_HEADERS32();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 12 : 7;
            continue;
          case 14:
            bytes1 = PEFile.StructToBytes<PEFile.IMAGE_DOS_HEADER>();
            num = 7;
            continue;
          case 15:
            if (PEFile.NativeMethods.ReadFile(fileHandle, bytes2, numBytesToRead1, out numBytesRead, IntPtr.Zero))
            {
              num = 9;
              continue;
            }
            goto label_11;
          case 16:
            goto label_6;
          case 17:
            if (PEFile.NativeMethods.SetFilePointer(fileHandle, headersOffset, IntPtr.Zero, PEFile.NativeMethods.EMoveMethod.Begin) != uint.MaxValue)
            {
              bytes2 = PEFile.StructToBytes<PEFile.IMAGE_NT_HEADERS32>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            }
            num = 6;
            continue;
          default:
            // ISSUE: type reference
            numBytesToRead1 = (uint) PEFile.tFntFHBe4HmJA4Wj1Xcj(PEFile.vONMsABewJ073i9PEe3n(__typeref (PEFile.IMAGE_NT_HEADERS32)));
            num = 15;
            continue;
        }
      }
label_6:
      return false;
label_9:
      return false;
label_11:
      return false;
label_16:
      return false;
label_18:
      return true;
label_23:
      return false;
label_25:
      return false;
    }

    internal static byte[] StructToBytes<TStruct>() where TStruct : struct => new byte[Marshal.SizeOf(typeof (TStruct))];

    internal static byte[] StructToBytes<TStruct>(TStruct s) where TStruct : struct
    {
      int cb = Marshal.SizeOf<TStruct>(s);
      byte[] bytes = new byte[cb];
      IntPtr num = Marshal.AllocHGlobal(cb);
      Marshal.StructureToPtr<TStruct>(s, num, false);
      for (int ofs = 0; ofs < cb; ++ofs)
        bytes[ofs] = Marshal.ReadByte(num, ofs);
      Marshal.FreeHGlobal(num);
      return bytes;
    }

    public static TStruct BytesToStruct<TStruct>(byte[] arr) where TStruct : struct
    {
      int cb = Marshal.SizeOf<TStruct>(new TStruct());
      IntPtr num = Marshal.AllocHGlobal(cb);
      for (int ofs = 0; ofs < cb; ++ofs)
        Marshal.WriteByte(num, ofs, arr[ofs]);
      TStruct structure = (TStruct) Marshal.PtrToStructure(num, typeof (TStruct));
      Marshal.FreeHGlobal(num);
      return structure;
    }

    internal static object wkGnfDBetjnWdT8m8dmd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type vONMsABewJ073i9PEe3n([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static int tFntFHBe4HmJA4Wj1Xcj([In] Type obj0) => Marshal.SizeOf(obj0);

    internal static void jeljYTBe6UtLjv03Gsae([In] object obj0) => ((SafeHandle) obj0).Dispose();

    internal static bool u8wIdKBeaGZwlBSdqjSE() => PEFile.pX6EriBepV0MCof8YHc6 == null;

    internal static PEFile aBy1mZBeD6DIZOrEXfyL() => PEFile.pX6EriBepV0MCof8YHc6;

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
      public PEFile.IMAGE_FILE_HEADER FileHeader;
      [MarshalAs(UnmanagedType.Struct)]
      public PEFile.IMAGE_OPTIONAL_HEADER32 OptionalHeader;
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
      I386 = 332, // 0x014C
      Itanium = 512, // 0x0200
      x64 = 34404, // 0x8664
    }

    public enum MagicType : ushort
    {
      IMAGE_NT_OPTIONAL_HDR32_MAGIC = 267, // 0x010B
      IMAGE_NT_OPTIONAL_HDR64_MAGIC = 523, // 0x020B
    }

    public enum SubSystemType : ushort
    {
      IMAGE_SUBSYSTEM_UNKNOWN = 0,
      IMAGE_SUBSYSTEM_NATIVE = 1,
      IMAGE_SUBSYSTEM_WINDOWS_GUI = 2,
      IMAGE_SUBSYSTEM_WINDOWS_CUI = 3,
      IMAGE_SUBSYSTEM_POSIX_CUI = 7,
      IMAGE_SUBSYSTEM_WINDOWS_CE_GUI = 9,
      IMAGE_SUBSYSTEM_EFI_APPLICATION = 10, // 0x000A
      IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER = 11, // 0x000B
      IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER = 12, // 0x000C
      IMAGE_SUBSYSTEM_EFI_ROM = 13, // 0x000D
      IMAGE_SUBSYSTEM_XBOX = 14, // 0x000E
    }

    public enum DllCharacteristicsType : ushort
    {
      RES_0 = 1,
      RES_1 = 2,
      RES_2 = 4,
      RES_3 = 8,
      IMAGE_DLL_CHARACTERISTICS_DYNAMIC_BASE = 64, // 0x0040
      IMAGE_DLL_CHARACTERISTICS_FORCE_INTEGRITY = 128, // 0x0080
      IMAGE_DLL_CHARACTERISTICS_NX_COMPAT = 256, // 0x0100
      IMAGE_DLLCHARACTERISTICS_NO_ISOLATION = 512, // 0x0200
      IMAGE_DLLCHARACTERISTICS_NO_SEH = 1024, // 0x0400
      IMAGE_DLLCHARACTERISTICS_NO_BIND = 2048, // 0x0800
      RES_4 = 4096, // 0x1000
      IMAGE_DLLCHARACTERISTICS_WDM_DRIVER = 8192, // 0x2000
      IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE = 32768, // 0x8000
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct IMAGE_OPTIONAL_HEADER32
    {
      [FieldOffset(0)]
      public PEFile.MagicType Magic;
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
      public PEFile.SubSystemType Subsystem;
      [FieldOffset(70)]
      public PEFile.DllCharacteristicsType DllCharacteristics;
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
      public PEFile.IMAGE_DATA_DIRECTORY ExportTable;
      [FieldOffset(104)]
      public PEFile.IMAGE_DATA_DIRECTORY ImportTable;
      [FieldOffset(112)]
      public PEFile.IMAGE_DATA_DIRECTORY ResourceTable;
      [FieldOffset(120)]
      public PEFile.IMAGE_DATA_DIRECTORY ExceptionTable;
      [FieldOffset(128)]
      public PEFile.IMAGE_DATA_DIRECTORY CertificateTable;
      [FieldOffset(136)]
      public PEFile.IMAGE_DATA_DIRECTORY BaseRelocationTable;
      [FieldOffset(144)]
      public PEFile.IMAGE_DATA_DIRECTORY Debug;
      [FieldOffset(152)]
      public PEFile.IMAGE_DATA_DIRECTORY Architecture;
      [FieldOffset(160)]
      public PEFile.IMAGE_DATA_DIRECTORY GlobalPtr;
      [FieldOffset(168)]
      public PEFile.IMAGE_DATA_DIRECTORY TLSTable;
      [FieldOffset(176)]
      public PEFile.IMAGE_DATA_DIRECTORY LoadConfigTable;
      [FieldOffset(184)]
      public PEFile.IMAGE_DATA_DIRECTORY BoundImport;
      [FieldOffset(192)]
      public PEFile.IMAGE_DATA_DIRECTORY IAT;
      [FieldOffset(200)]
      public PEFile.IMAGE_DATA_DIRECTORY DelayImportDescriptor;
      [FieldOffset(208)]
      public PEFile.IMAGE_DATA_DIRECTORY CLRRuntimeHeader;
      [FieldOffset(216)]
      public PEFile.IMAGE_DATA_DIRECTORY Reserved;
    }

    public struct IMAGE_DATA_DIRECTORY
    {
      public uint VirtualAddress;
      public uint Size;
    }

    internal static class NativeMethods
    {
      public const uint INVALID_SET_FILE_POINTER = 4294967295;

      [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
      public static extern SafeFileHandle CreateFile(
        string lpFileName,
        [MarshalAs(UnmanagedType.U4)] FileAccess dwDesiredAccess,
        [MarshalAs(UnmanagedType.U4)] FileShare dwShareMode,
        IntPtr lpSecurityAttributes,
        [MarshalAs(UnmanagedType.U4)] FileMode dwCreationDisposition,
        [MarshalAs(UnmanagedType.U4)] System.IO.FileAttributes dwFlagsAndAttributes,
        IntPtr hTemplateFile);

      [DllImport("kernel32.dll", ThrowOnUnmappableChar = true, BestFitMapping = false)]
      public static extern IntPtr OpenFile(
        [MarshalAs(UnmanagedType.LPStr)] string lpFileName,
        out PEFile.NativeMethods.OFSTRUCT lpReOpenBuff,
        PEFile.NativeMethods.OpenFileStyle uStyle);

      [DllImport("kernel32.dll", SetLastError = true)]
      [return: MarshalAs(UnmanagedType.Bool)]
      public static extern bool CloseHandle(IntPtr hObject);

      [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
      public static extern uint SetFilePointer(
        IntPtr hFile,
        uint lDistanceToMove,
        IntPtr lpDistanceToMoveHigh,
        PEFile.NativeMethods.EMoveMethod dwMoveMethod);

      [DllImport("kernel32.dll", SetLastError = true)]
      [return: MarshalAs(UnmanagedType.Bool)]
      public static extern bool ReadFile(
        IntPtr handle,
        byte[] bytes,
        uint numBytesToRead,
        out uint numBytesRead,
        IntPtr overlapped);

      [DllImport("kernel32.dll")]
      public static extern bool WriteFile(
        IntPtr handle,
        byte[] bytes,
        uint numBytesToWrite,
        out uint numBytesWrote,
        IntPtr overlapped);

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
        OF_CANCEL = 2048, // 0x00000800
        OF_CREATE = 4096, // 0x00001000
        OF_DELETE = 512, // 0x00000200
        OF_EXIST = 16384, // 0x00004000
        OF_PARSE = 256, // 0x00000100
        OF_PROMPT = 8192, // 0x00002000
        OF_READ = 0,
        OF_READWRITE = 2,
        OF_REOPEN = 32768, // 0x00008000
        OF_SHARE_COMPAT = 0,
        OF_SHARE_DENY_NONE = 64, // 0x00000040
        OF_SHARE_DENY_READ = 48, // 0x00000030
        OF_SHARE_DENY_WRITE = 32, // 0x00000020
        OF_SHARE_EXCLUSIVE = 16, // 0x00000010
        OF_VERIFY = 1024, // 0x00000400
        OF_WRITE = 1,
      }

      public enum EMoveMethod : uint
      {
        Begin,
        Current,
        End,
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Crc32
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace EleWise.ELMA.Files
{
  /// <summary>Класс для вычисления CRC-32 файла</summary>
  public class Crc32 : HashAlgorithm
  {
    public const uint DefaultSeed = 4294967295;
    private static readonly uint[] CrcTable;
    private uint crcValue;
    private static Crc32 n5m0xtGkKEmCigmaVDUT;

    public override void Initialize()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.crcValue = 0U;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected override void HashCore(byte[] buffer, int start, int length)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 3:
            this.crcValue ^= uint.MaxValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 2;
            continue;
          case 4:
            this.crcValue ^= uint.MaxValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
            continue;
          case 5:
          case 6:
            this.crcValue = Crc32.CrcTable[((int) this.crcValue ^ (int) buffer[start++]) & (int) byte.MaxValue] ^ this.crcValue >> 8;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          default:
            if (--length >= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 2 : 5;
              continue;
            }
            goto case 4;
        }
      }
label_6:;
    }

    protected override byte[] HashFinal()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.HashValue = new byte[4]
            {
              (byte) (this.crcValue >> 24 & (uint) byte.MaxValue),
              (byte) (this.crcValue >> 16 & (uint) byte.MaxValue),
              (byte) (this.crcValue >> 8 & (uint) byte.MaxValue),
              (byte) (this.crcValue & (uint) byte.MaxValue)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.HashValue;
    }

    public uint CrcValue => (uint) ((int) this.HashValue[0] << 24 | (int) this.HashValue[1] << 16 | (int) this.HashValue[2] << 8) | (uint) this.HashValue[3];

    public override int HashSize => 32;

    /// <summary>Посчитать CRC-32 у очередного блока контента.</summary>
    /// <param name="buffer">Буфер.</param>
    /// <param name="size">Размер данных.</param>
    public void HashBlock(byte[] buffer, int size)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Crc32.eDsBAPGkkbaTtN4ThikF((object) this, (object) buffer, 0, size);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Посчитать CRC-32 у очередного блока контента.</summary>
    /// <param name="buffer">Буфер.</param>
    /// <param name="offset">Смещение</param>
    /// <param name="size">Размер данных.</param>
    public void HashBlock(byte[] buffer, int offset, int size)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.HashCore(buffer, offset, size);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Завершить вычисление CRC-32.</summary>
    /// <returns>Подсчитанное значение хеша.</returns>
    public byte[] HashFinalBlock() => (byte[]) Crc32.sndRUwGknSgT91MQPRvN((object) this);

    /// <summary>Получить значение CRC-32 из файла.</summary>
    /// <param name="filePath">Полный путь до файла</param>
    /// <returns>CRC-32</returns>
    public static uint GetCrcValue(string filePath)
    {
      int num1 = 5;
      // ISSUE: variable of a compiler-generated type
      Crc32.\u003C\u003Ec__DisplayClass13_0 cDisplayClass130;
      // ISSUE: variable of a compiler-generated type
      Crc32.\u003C\u003Ec__DisplayClass13_1 cDisplayClass131;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_6;
          case 2:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass131.CS\u0024\u003C\u003E8__locals1 = cDisplayClass130;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass131 = new Crc32.\u003C\u003Ec__DisplayClass13_1();
            num1 = 2;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass130.filePath = filePath;
            num1 = 3;
            continue;
          case 5:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass130 = new Crc32.\u003C\u003Ec__DisplayClass13_0();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 3 : 4;
            continue;
          case 6:
            goto label_5;
          default:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass131.crc32 = new Crc32();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
            continue;
        }
      }
label_5:
      uint crcValue;
      return crcValue;
label_6:
      try
      {
        // ISSUE: reference to a compiler-generated method
        Crc32.wiPgPQGk26mF91mOjEwV((object) new System.Action(cDisplayClass131.\u003CGetCrcValue\u003Eb__0), Crc32.EUFL9xGkO53nU9YcYOJm(1.0), 30);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              crcValue = Crc32.hcq9gpGkeldAVkZUkiHi((object) cDisplayClass131.crc32);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (cDisplayClass131.crc32 != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                // ISSUE: reference to a compiler-generated field
                Crc32.DvJH6UGkPqCNSUi0oopX((object) cDisplayClass131.crc32);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    /// <summary>Получить значение CRC-32 из потока.</summary>
    /// <param name="stream">Поток</param>
    /// <returns>CRC-32</returns>
    public static uint GetCrcValue(Stream stream)
    {
      int num1 = 2;
      Crc32 crc32;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            crc32 = new Crc32();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      uint crcValue;
      return crcValue;
label_3:
      try
      {
        Crc32.DJ3WmtGk1i3SLkHpCocy((object) crc32, (object) stream);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              crcValue = Crc32.hcq9gpGkeldAVkZUkiHi((object) crc32);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
      }
      finally
      {
        if (crc32 != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_12;
              default:
                crc32.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_12:;
      }
    }

    /// <summary>Проверить значение CRC-32 для файла</summary>
    /// <param name="filePath">Полный путь до файла</param>
    /// <param name="crcValue">CRC-32</param>
    /// <returns>Верно ли данное значение</returns>
    public static bool CheckCrc(string filePath, uint crcValue) => (int) Crc32.E2TRlyGkNDSqRJhMuWWl((object) filePath) == (int) crcValue;

    public Crc32()
    {
      Crc32.hJMQhvGk3piq1X6UrFK9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static Crc32()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            uint[] numArray = new uint[256];
            // ISSUE: field reference
            Crc32.ScBUuyGkpVx5OV7bbKff((object) numArray, __fieldref (\u003CPrivateImplementationDetails\u003E.\u003373B494F210C656134C5728D551D4C97B013EB33));
            Crc32.CrcTable = numArray;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
            continue;
          case 2:
            Crc32.hJMQhvGk3piq1X6UrFK9();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool zJxOCyGkX8Cn1iYCyyqH() => Crc32.n5m0xtGkKEmCigmaVDUT == null;

    internal static Crc32 XGsuqGGkTOxmw9LhVqus() => Crc32.n5m0xtGkKEmCigmaVDUT;

    internal static void eDsBAPGkkbaTtN4ThikF([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((HashAlgorithm) obj0).HashCore((byte[]) obj1, obj2, obj3);

    internal static object sndRUwGknSgT91MQPRvN([In] object obj0) => (object) ((HashAlgorithm) obj0).HashFinal();

    internal static TimeSpan EUFL9xGkO53nU9YcYOJm([In] double obj0) => TimeSpan.FromSeconds(obj0);

    internal static void wiPgPQGk26mF91mOjEwV([In] object obj0, TimeSpan interval, int attemptCount) => ActionExtensions.ExecuteWithAttempts((System.Action) obj0, interval, attemptCount);

    internal static uint hcq9gpGkeldAVkZUkiHi([In] object obj0) => ((Crc32) obj0).CrcValue;

    internal static void DvJH6UGkPqCNSUi0oopX([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object DJ3WmtGk1i3SLkHpCocy([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((Stream) obj1);

    internal static uint E2TRlyGkNDSqRJhMuWWl([In] object obj0) => Crc32.GetCrcValue((string) obj0);

    internal static void hJMQhvGk3piq1X6UrFK9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void ScBUuyGkpVx5OV7bbKff([In] object obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray((Array) obj0, obj1);
  }
}

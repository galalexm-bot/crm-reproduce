// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.PacketVersionService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.Deploy.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Сервис для работы с версиями пакетов</summary>
  [Service]
  public class PacketVersionService
  {
    private Dictionary<string, List<string>> checkDictionary;
    private Dictionary<string, List<string>> blackDictionary;
    private static PacketVersionService u1ItbnEAn0WtGPMHXpIO;

    /// <summary>
    /// Инициализировать словарь поддерживаемых пар Version-ContentType
    /// </summary>
    private void InitializeCheckDictionary()
    {
      int num1 = 3;
      IEnumerator<KeyValuePair<string, List<string>>> enumerator1;
      IEnumerator<IPacketVersionProcessor> enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_62;
          case 2:
            try
            {
label_52:
              if (PacketVersionService.Ao34gbEADInlWySoiDhQ((object) enumerator2))
                goto label_54;
              else
                goto label_53;
label_22:
              IEnumerator<PacketAttribute> enumerator3;
              int num2;
              switch (num2)
              {
                case 1:
                  goto label_52;
                case 2:
                  goto label_2;
                case 3:
                  goto label_54;
                default:
                  try
                  {
label_40:
                    if (enumerator3.MoveNext())
                      goto label_26;
                    else
                      goto label_41;
label_25:
                    PacketAttribute current;
                    string key;
                    string str;
                    int num3;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          key = (string) PacketVersionService.fH1iCQEAPUL36Qckhh3e((object) current);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 14 : 5;
                          continue;
                        case 2:
                          goto label_52;
                        case 3:
                        case 4:
                          if (!this.blackDictionary.ContainsKey(key))
                          {
                            num3 = 12;
                            continue;
                          }
                          goto case 10;
                        case 5:
                          if (this.checkDictionary.ContainsKey(key))
                          {
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 14 : 15;
                            continue;
                          }
                          goto case 8;
                        case 6:
                          if (!PacketVersionService.QsyPoeEANO74Cs1bEMjM((object) key))
                          {
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                            continue;
                          }
                          goto label_40;
                        case 7:
                          goto label_26;
                        case 8:
                          this.checkDictionary.Add(key, new List<string>());
                          num3 = 13;
                          continue;
                        case 9:
                        case 11:
                          goto label_40;
                        case 10:
                          this.blackDictionary[key].Add(str);
                          num3 = 9;
                          continue;
                        case 12:
                          this.blackDictionary.Add(key, new List<string>());
                          num3 = 10;
                          continue;
                        case 13:
                        case 15:
                          this.checkDictionary[key].Add(str);
                          num3 = 11;
                          continue;
                        case 14:
                          if (PacketVersionService.ehyc7PEA14BL2o9KZG7V((object) current) != 0)
                          {
                            num3 = 6;
                            continue;
                          }
                          goto label_40;
                        case 16:
                          if (!PacketVersionService.huvICaEApuhJIWeZwIPh((object) current))
                          {
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 4 : 4;
                            continue;
                          }
                          goto case 5;
                        default:
                          str = PacketVersionService.SCbnGvEA3XbuHPJU4eR2(1033719030 - 2012070891 ^ -978590379).ToString() + (object) PacketVersionService.ehyc7PEA14BL2o9KZG7V((object) current);
                          num3 = 16;
                          continue;
                      }
                    }
label_26:
                    current = enumerator3.Current;
                    num3 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
                    {
                      num3 = 1;
                      goto label_25;
                    }
                    else
                      goto label_25;
label_41:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 2;
                    goto label_25;
                  }
                  finally
                  {
                    if (enumerator3 != null)
                    {
                      int num4 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                        num4 = 0;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            PacketVersionService.jHl0BJEAaeSItBd8T6wl((object) enumerator3);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_51;
                        }
                      }
                    }
label_51:;
                  }
              }
label_53:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 2;
              goto label_22;
label_54:
              enumerator3 = ((IEnumerable) PacketVersionService.jEr5MxEAeejW8SAwwBve((object) enumerator2.Current.GetType(), false)).OfType<PacketAttribute>().GetEnumerator();
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
              {
                num2 = 0;
                goto label_22;
              }
              else
                goto label_22;
            }
            finally
            {
              int num5;
              if (enumerator2 == null)
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
              else
                goto label_60;
label_58:
              switch (num5)
              {
                case 2:
                  break;
                default:
              }
label_60:
              PacketVersionService.jHl0BJEAaeSItBd8T6wl((object) enumerator2);
              num5 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
              {
                num5 = 1;
                goto label_58;
              }
              else
                goto label_58;
            }
          case 3:
            IEnumerable<IPacketVersionProcessor> extensionPoints = ComponentManager.Current.GetExtensionPoints<IPacketVersionProcessor>();
            this.checkDictionary = new Dictionary<string, List<string>>();
            this.blackDictionary = new Dictionary<string, List<string>>();
            enumerator2 = extensionPoints.GetEnumerator();
            num1 = 2;
            continue;
          case 4:
label_2:
            enumerator1 = this.blackDictionary.Where<KeyValuePair<string, List<string>>>((Func<KeyValuePair<string, List<string>>, bool>) (item => this.checkDictionary.ContainsKey(item.Key))).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_62:
      return;
label_4:
      try
      {
label_8:
        if (enumerator1.MoveNext())
          goto label_12;
        else
          goto label_9;
label_6:
        KeyValuePair<string, List<string>> current;
        int num6;
        while (true)
        {
          switch (num6)
          {
            case 1:
              this.checkDictionary[current.Key] = this.checkDictionary[current.Key].Except<string>((IEnumerable<string>) this.blackDictionary[current.Key]).ToList<string>();
              num6 = 2;
              continue;
            case 2:
              if (this.checkDictionary[current.Key].Any<string>())
              {
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 6;
                continue;
              }
              goto case 4;
            case 3:
              goto label_59;
            case 4:
              this.checkDictionary.Remove(current.Key);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_12;
            default:
              goto label_8;
          }
        }
label_59:
        return;
label_9:
        num6 = 3;
        goto label_6;
label_12:
        current = enumerator1.Current;
        num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        {
          num6 = 1;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num7 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
            num7 = 1;
          while (true)
          {
            switch (num7)
            {
              case 1:
                enumerator1.Dispose();
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                continue;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
    }

    /// <summary>Проверить возможость импорта пакета</summary>
    /// <param name="nodeName"></param>
    /// <param name="contentType"></param>
    /// <returns></returns>
    public bool Check(string nodeName, string contentType)
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 2:
            this.InitializeCheckDictionary();
            num = 3;
            continue;
          case 3:
            if (this.checkDictionary.ContainsKey(contentType))
            {
              num = 7;
              continue;
            }
            goto label_16;
          case 4:
            if (PacketVersionService.QsyPoeEANO74Cs1bEMjM((object) contentType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            }
            if (this.checkDictionary == null)
            {
              num = 2;
              continue;
            }
            goto case 3;
          case 5:
            goto label_4;
          case 6:
            if (PacketVersionService.vHp02hEAtNctWObKAQ5h((object) nodeName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426335403)))
            {
              num = 5;
              continue;
            }
            if (PacketVersionService.QsyPoeEANO74Cs1bEMjM((object) nodeName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
              continue;
            }
            goto case 4;
          case 7:
            goto label_15;
          default:
            goto label_12;
        }
      }
label_4:
      return true;
label_12:
      return false;
label_15:
      return this.checkDictionary[contentType].Contains(nodeName);
label_16:
      return false;
    }

    public PacketVersionService()
    {
      PacketVersionService.W7q2klEAwvJsv9qMiknm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object jEr5MxEAeejW8SAwwBve([In] object obj0, [In] bool obj1) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1);

    internal static object fH1iCQEAPUL36Qckhh3e([In] object obj0) => (object) ((PacketAttribute) obj0).ContentType;

    internal static int ehyc7PEA14BL2o9KZG7V([In] object obj0) => ((PacketAttribute) obj0).Version;

    internal static bool QsyPoeEANO74Cs1bEMjM([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object SCbnGvEA3XbuHPJU4eR2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool huvICaEApuhJIWeZwIPh([In] object obj0) => ((PacketAttribute) obj0).Active;

    internal static void jHl0BJEAaeSItBd8T6wl([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool Ao34gbEADInlWySoiDhQ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool BiuesrEAOtg0CkrhT3sG() => PacketVersionService.u1ItbnEAn0WtGPMHXpIO == null;

    internal static PacketVersionService F1pvu2EA2l6BBv5jgifU() => PacketVersionService.u1ItbnEAn0WtGPMHXpIO;

    internal static bool vHp02hEAtNctWObKAQ5h([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static void W7q2klEAwvJsv9qMiknm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

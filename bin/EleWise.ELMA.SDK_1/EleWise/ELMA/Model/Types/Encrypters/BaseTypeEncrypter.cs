// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.BaseTypeEncrypter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Model.Types.Encrypters
{
  public abstract class BaseTypeEncrypter : ITypeEncrypter
  {
    private static BaseTypeEncrypter Fd3PVSojgJS46TOWSYpx;

    public abstract bool CheckType(object obj, IMetadata propertyMetadata);

    protected abstract object GetObjectFromString(string obj, IMetadata propertyMetadata);

    protected virtual string ObjectToString(object obj, IMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return string.Empty;
label_5:
      return obj.ToString();
    }

    public virtual string Encrypt(
      object obj,
      string password,
      string salt,
      IMetadata propertyMetadata)
    {
      return (string) BaseTypeEncrypter.gm4V2cojYR91SdmgHxAk((object) this.ObjectToString(obj, propertyMetadata), (object) salt, (object) password);
    }

    public virtual object Decrypt(
      string encrypted,
      string password,
      string salt,
      IMetadata propertyMetadata)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) BaseTypeEncrypter.sS9hjbojLBDZpZ0SJmHG((object) encrypted, (object) salt, (object) password);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return BaseTypeEncrypter.bby7Z8ojUuRqmOl64emc((object) this, (object) str, (object) propertyMetadata);
    }

    public virtual object EncryptStub(object obj, IMetadata propertyMetadata) => (object) null;

    protected virtual string GetMaskedVal(object obj, IMetadata propertyMetadata)
    {
      int num1 = 1;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        string str1;
        string str2;
        int num3;
        int num4;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (obj != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 2:
              if (num3 < 4)
              {
                num2 = 3;
                continue;
              }
              goto label_6;
            case 3:
              ++num3;
              num2 = 14;
              continue;
            case 4:
              goto label_22;
            case 5:
              goto label_7;
            case 6:
              goto label_9;
            case 7:
            case 10:
              if (num4 >= BaseTypeEncrypter.g9BXExoYWqw2enyplhDo((object) str2))
              {
                num2 = 8;
                continue;
              }
              goto label_7;
            case 8:
              goto label_6;
            case 9:
              str2 = str1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 4;
              continue;
            case 11:
              goto label_14;
            case 12:
              num3 = 0;
              num2 = 9;
              continue;
            case 13:
              BaseTypeEncrypter.MK6kKtoYB8fbqaAwUQJM((object) stringBuilder, BaseTypeEncrypter.AiywKwojzRc3Qak0E7bJ(572119659 - -337058038 ^ 909156657));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 0;
              continue;
            case 14:
              ++num4;
              num2 = 7;
              continue;
            case 15:
              if (BaseTypeEncrypter.K7Rfp4ojcPr1KPItM0sx((object) str1))
              {
                num2 = 11;
                continue;
              }
              goto label_15;
            default:
              str1 = (string) BaseTypeEncrypter.zcxaTjojsD1vT9OS0XrY((object) this, obj, (object) propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 15 : 2;
              continue;
          }
        }
label_7:
        int num5 = (int) BaseTypeEncrypter.HSwq5BoYF8fjEY9Ao4Sl((object) str2, num4);
        num1 = 13;
        continue;
label_15:
        stringBuilder = new StringBuilder();
        num1 = 12;
        continue;
label_22:
        num4 = 0;
        num1 = 10;
      }
label_6:
      return stringBuilder.ToString();
label_9:
      return (string) null;
label_14:
      return (string) BaseTypeEncrypter.AiywKwojzRc3Qak0E7bJ(-740338220 ^ -740358268);
    }

    protected BaseTypeEncrypter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool xrBbDyoj5ZxelSIqDW5M() => BaseTypeEncrypter.Fd3PVSojgJS46TOWSYpx == null;

    internal static BaseTypeEncrypter hcHRLfojjnR7E9G3hrbs() => BaseTypeEncrypter.Fd3PVSojgJS46TOWSYpx;

    internal static object gm4V2cojYR91SdmgHxAk([In] object obj0, [In] object obj1, [In] object obj2) => (object) EncryptionHelper.Encrypt((string) obj0, (string) obj1, (string) obj2);

    internal static object sS9hjbojLBDZpZ0SJmHG([In] object obj0, [In] object obj1, [In] object obj2) => (object) EncryptionHelper.Decrypt((string) obj0, (string) obj1, (string) obj2);

    internal static object bby7Z8ojUuRqmOl64emc([In] object obj0, [In] object obj1, [In] object obj2) => ((BaseTypeEncrypter) obj0).GetObjectFromString((string) obj1, (IMetadata) obj2);

    internal static object zcxaTjojsD1vT9OS0XrY([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((BaseTypeEncrypter) obj0).ObjectToString(obj1, (IMetadata) obj2);

    internal static bool K7Rfp4ojcPr1KPItM0sx([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object AiywKwojzRc3Qak0E7bJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static char HSwq5BoYF8fjEY9Ao4Sl([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static object MK6kKtoYB8fbqaAwUQJM([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static int g9BXExoYWqw2enyplhDo([In] object obj0) => ((string) obj0).Length;
  }
}

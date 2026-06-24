// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Enums.EnumBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Enums
{
  /// <summary>Базовый класс для наследуемых перечислений</summary>
  [Serializable]
  public abstract class EnumBase : ISerializable
  {
    private readonly Guid _value;
    private readonly string _name;
    internal static EnumBase uXp1gsoEYE2WnElNiAUJ;

    /// <summary>Ctor</summary>
    /// <param name="value">Целочисленное значение</param>
    /// <param name="name">Имя значения</param>
    protected EnumBase(Guid value, string name)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._name = name;
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this._value = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Идентификатор значения</summary>
    public Guid Value => this._value;

    /// <summary>Имя значения</summary>
    public string Name => this._name;

    public override string ToString() => (string) EnumBase.dFs96roEcg4d5G23nRgv((object) new object[4]
    {
      (object) this._name,
      EnumBase.KS3VpRoEs9GHDR7Od2x7(-688192331 - 435440695 ^ -1123637304),
      (object) this._value,
      EnumBase.KS3VpRoEs9GHDR7Od2x7(-1824388195 ^ -1824386015)
    });

    public override bool Equals(object obj) => EnumBase.AemyeYoEzvr8iODbkW0k((object) this, (object) (obj as EnumBase));

    public override int GetHashCode() => EnumBase.NdIxoLofBGubLTCFVFHN((object) EnumBase.ymYlRiofFt1Z1UdaCtti((object) this).FullName, EnumBase.KS3VpRoEs9GHDR7Od2x7(1149433385 + 173655049 ^ 1323086942), (object) this._value).GetHashCode();

    public static implicit operator Guid(EnumBase m)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!EnumBase.sBUdiqofWuVRmPB12j4q((object) m, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return Guid.Empty;
label_3:
      return EnumBase.e7AulhofocK6rPCdMeEb((object) m);
    }

    public static bool operator ==(EnumBase m1, EnumBase m2) => EnumBase.AemyeYoEzvr8iODbkW0k((object) m1, (object) m2);

    public static bool operator !=(EnumBase m1, EnumBase m2) => !EnumBase.AemyeYoEzvr8iODbkW0k((object) m1, (object) m2);

    private static bool IsEqual(object m1, object m2)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (m1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
              continue;
            }
            goto case 8;
          case 2:
            goto label_6;
          case 4:
            goto label_15;
          case 5:
            if (!EnumBase.ayxZMjofbSLw0WZp8RNP(m1.GetType(), m2.GetType()))
            {
              num = 4;
              continue;
            }
            goto label_14;
          case 6:
            if (m2 != null)
            {
              num = 5;
              continue;
            }
            goto label_6;
          case 7:
            goto label_9;
          case 8:
            if (m2 != null)
            {
              num = 3;
              continue;
            }
            goto label_9;
          case 9:
            goto label_14;
          default:
            if (m1 != null)
            {
              num = 6;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      return false;
label_9:
      return true;
label_14:
      return EnumBase.e7AulhofocK6rPCdMeEb(m1) == ((EnumBase) m2).Value;
label_15:
      return false;
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EnumBase.V7gBGGofh16Bg1Q0XjKc((object) info, EnumBase.KS3VpRoEs9GHDR7Od2x7(1232639661 >> 3 ^ 154121345), (object) this._value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          case 2:
            EnumBase.V7gBGGofh16Bg1Q0XjKc((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099764073), (object) this._name);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    protected EnumBase(SerializationInfo info, StreamingContext context)
    {
      EnumBase.fDtxmwofGUrHkf7DU0k5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this._value = (Guid) EnumBase.NU38N8offDiHJirCwbe6((object) info, EnumBase.KS3VpRoEs9GHDR7Od2x7(1021410165 ^ 1021435169), typeof (Guid));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 1;
            continue;
          default:
            this._name = (string) EnumBase.j1psyEofEWTNy5JtpPkZ((object) info, EnumBase.KS3VpRoEs9GHDR7Od2x7(-35995181 ^ -35999213));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 2;
            continue;
        }
      }
label_3:;
    }

    internal static bool WigwTRoELpSWDUBRMsOn() => (object) EnumBase.uXp1gsoEYE2WnElNiAUJ == null;

    internal static EnumBase R5G0IZoEU8Bf0KPA49HW() => EnumBase.uXp1gsoEYE2WnElNiAUJ;

    internal static object KS3VpRoEs9GHDR7Od2x7(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object dFs96roEcg4d5G23nRgv([In] object obj0) => (object) string.Concat((object[]) obj0);

    internal static bool AemyeYoEzvr8iODbkW0k([In] object obj0, [In] object obj1) => EnumBase.IsEqual(obj0, obj1);

    internal static Type ymYlRiofFt1Z1UdaCtti([In] object obj0) => obj0.GetType();

    internal static object NdIxoLofBGubLTCFVFHN([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

    internal static bool sBUdiqofWuVRmPB12j4q([In] object obj0, [In] object obj1) => (EnumBase) obj0 != (EnumBase) obj1;

    internal static Guid e7AulhofocK6rPCdMeEb([In] object obj0) => ((EnumBase) obj0).Value;

    internal static bool ayxZMjofbSLw0WZp8RNP([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static void V7gBGGofh16Bg1Q0XjKc([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static void fDtxmwofGUrHkf7DU0k5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object j1psyEofEWTNy5JtpPkZ([In] object obj0, [In] object obj1) => (object) ((SerializationInfo) obj0).GetString((string) obj1);

    internal static object NU38N8offDiHJirCwbe6([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);
  }
}

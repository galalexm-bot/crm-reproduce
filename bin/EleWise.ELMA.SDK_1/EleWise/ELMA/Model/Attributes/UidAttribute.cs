// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.UidAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут, содержащий Uid элемента</summary>
  /// <remarks>
  /// Элементом, например, может быть класс, свойство, перечисление...
  /// </remarks>
  [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
  public class UidAttribute : Attribute
  {
    private readonly Guid uid;
    private static UidAttribute Gil68JoVVd2h8qyTLkwU;

    /// <summary>Новый атрибут, содержащий Uid элемента</summary>
    /// <param name="uid">Uid элемента</param>
    public UidAttribute(string uid)
    {
      UidAttribute.TIquBjoVRDpFHsro1Sxx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.uid = new Guid(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            UidAttribute.AgNXdnoVKEt2Hyl7OxHe((object) uid, UidAttribute.PaffiHoVqHk6pqKAxCiS(-281842504 ^ -281890962));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Новый атрибут, содержащий Uid элемента</summary>
    /// <param name="uid">Uid элемента</param>
    public UidAttribute(Guid uid)
    {
      UidAttribute.TIquBjoVRDpFHsro1Sxx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.uid = uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Uid элемента</summary>
    public Guid Uid => this.uid;

    internal static void TIquBjoVRDpFHsro1Sxx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object PaffiHoVqHk6pqKAxCiS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void AgNXdnoVKEt2Hyl7OxHe([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool JWu5TEoVSD0rrYNUnk7a() => UidAttribute.Gil68JoVVd2h8qyTLkwU == null;

    internal static UidAttribute gtti37oViIWn6CnYHdTR() => UidAttribute.Gil68JoVVd2h8qyTLkwU;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ImplementationUidAttribute
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
  /// <summary>
  /// Указывает уникальный идентификатор класса, реализующего интерфейс, на который навешивается данный атрибут
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class ImplementationUidAttribute : Attribute
  {
    private Guid uid;
    internal static ImplementationUidAttribute dQdNLJo8tWvZUyVj8pWI;

    /// <summary>Ctor</summary>
    /// <param name="uid">Уникальный идентификатор класса</param>
    public ImplementationUidAttribute(string uid)
    {
      ImplementationUidAttribute.wxKo6Uo86MnP2Mgex49P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            ImplementationUidAttribute.oiO0peo8AC8f0NiWQUFA((object) uid, ImplementationUidAttribute.clTILfo8HBkJJ4vbu3Ff(1574260816 ^ 1574212486));
            num = 2;
            continue;
          case 2:
            this.uid = new Guid(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Новый атрибут, содержащий Uid элемента</summary>
    /// <param name="uid">Uid элемента</param>
    public ImplementationUidAttribute(Guid uid)
    {
      ImplementationUidAttribute.wxKo6Uo86MnP2Mgex49P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.uid = uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    internal static void wxKo6Uo86MnP2Mgex49P() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object clTILfo8HBkJJ4vbu3Ff(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void oiO0peo8AC8f0NiWQUFA([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool AfwRhqo8wCCtCieelqCT() => ImplementationUidAttribute.dQdNLJo8tWvZUyVj8pWI == null;

    internal static ImplementationUidAttribute ik1Vhbo84FAyqmsDL06s() => ImplementationUidAttribute.dQdNLJo8tWvZUyVj8pWI;
  }
}

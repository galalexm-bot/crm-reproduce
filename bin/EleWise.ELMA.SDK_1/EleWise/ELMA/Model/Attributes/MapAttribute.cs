// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.MapAttribute
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
  /// <summary>Мэпинг свойств</summary>
  public class MapAttribute : Attribute
  {
    private readonly Guid propertyUid;
    private readonly Guid _classUid;
    private static MapAttribute w3EgLSouKv6PjifnYXRb;

    /// <summary>Конструктор</summary>
    /// <param name="uid"></param>
    public MapAttribute(string uid, string entityTypeUid)
    {
      MapAttribute.GNH9Oqouk8nymdKWDlTR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this._classUid = new Guid(entityTypeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
            continue;
          case 3:
            MapAttribute.a1quGUounL3gR9Wq08i3((object) uid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021360291));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          default:
            this.propertyUid = new Guid(uid);
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Uid свойства к которому привязывается свойство</summary>
    public Guid PropertyUid => this.propertyUid;

    /// <summary>Uid сущности в которой находится это свойство</summary>
    public Guid ClassTypeUid => this._classUid;

    internal static void GNH9Oqouk8nymdKWDlTR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void a1quGUounL3gR9Wq08i3([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool DNdSpoouXi4Q5j5Hok1B() => MapAttribute.w3EgLSouKv6PjifnYXRb == null;

    internal static MapAttribute ANssFeouTZU0idOhvhNt() => MapAttribute.w3EgLSouKv6PjifnYXRb;
  }
}

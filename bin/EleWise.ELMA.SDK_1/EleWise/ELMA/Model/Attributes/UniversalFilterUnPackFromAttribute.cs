// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
  public class UniversalFilterUnPackFromAttribute : Attribute
  {
    private readonly Guid propertyUid;
    private static UniversalFilterUnPackFromAttribute qB4Qb6ovhRySXnoZU8NA;

    public UniversalFilterUnPackFromAttribute(string propertyUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.propertyUid = new Guid(propertyUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public Guid PropertyUid => this.propertyUid;

    internal static bool UJ3I3aovGRj3QJHX70oU() => UniversalFilterUnPackFromAttribute.qB4Qb6ovhRySXnoZU8NA == null;

    internal static UniversalFilterUnPackFromAttribute fYi6GhovEZ2S9Bqj9AF3() => UniversalFilterUnPackFromAttribute.qB4Qb6ovhRySXnoZU8NA;
  }
}

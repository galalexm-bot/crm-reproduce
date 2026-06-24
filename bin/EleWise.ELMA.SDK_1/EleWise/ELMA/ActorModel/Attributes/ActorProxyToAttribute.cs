// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Attributes.ActorProxyToAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ActorModel.Attributes
{
  /// <summary>
  /// Атрибут, указывающий для какого интерфейса актора данный интерфейс является проксирующим
  /// </summary>
  [AttributeUsage(AttributeTargets.Interface)]
  public sealed class ActorProxyToAttribute : Attribute
  {
    private static ActorProxyToAttribute hAaW9lfDW3GnHDqTnGIS;

    /// <summary>Ctor</summary>
    /// <param name="actorInterfaceType">Тип интерфейса актора</param>
    /// <param name="actorToProxyWrapper">Тип Wrapper-а из интерфейса актора в прокси-интерфейс</param>
    /// <param name="proxyToActorWrapper">Тип Wrapper-а из прокси-интерфейса в интерфейс актора</param>
    public ActorProxyToAttribute(
      Type actorInterfaceType,
      Type actorToProxyWrapper,
      Type proxyToActorWrapper)
    {
      ActorProxyToAttribute.ItfrnkfDhYDldV1CS0s2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ActorInterfaceType = actorInterfaceType;
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.ActorToProxyWrapper = actorToProxyWrapper;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          default:
            this.ProxyToActorWrapper = proxyToActorWrapper;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип интерфейса актора</summary>
    public Type ActorInterfaceType { get; }

    /// <summary>Тип Wrapper-а из интерфейса актора в прокси-интерфейс</summary>
    public Type ActorToProxyWrapper { get; }

    /// <summary>Тип Wrapper-а из прокси-интерфейса в интерфейс актора</summary>
    public Type ProxyToActorWrapper { get; }

    internal static void ItfrnkfDhYDldV1CS0s2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Fnucl9fDo1Mbj6897bxC() => ActorProxyToAttribute.hAaW9lfDW3GnHDqTnGIS == null;

    internal static ActorProxyToAttribute ef3klOfDbWZfP1ATW2rK() => ActorProxyToAttribute.hAaW9lfDW3GnHDqTnGIS;
  }
}

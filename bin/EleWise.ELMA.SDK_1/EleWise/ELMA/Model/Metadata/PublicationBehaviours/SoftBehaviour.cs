// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.PublicationBehaviours.SoftBehaviour
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.PublicationBehaviours
{
  /// <summary>
  /// Расширитеть поведения для <see cref="F:EleWise.ELMA.Model.Enums.PublicationType.Soft" /> публикации
  /// </summary>
  internal sealed class SoftBehaviour : IPublicationBehaviourChecker
  {
    internal static SoftBehaviour lVumQnbrv78KwsyOoZ1R;

    /// <inheritdoc />
    public PublicationType Check(CheckType action, object oldValue, object newValue) => PublicationType.Soft;

    public SoftBehaviour()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool OfBjgCbr8T7jUqpRsZGw() => SoftBehaviour.lVumQnbrv78KwsyOoZ1R == null;

    internal static SoftBehaviour Ka7NFpbrZ7yfkJQygTI7() => SoftBehaviour.lVumQnbrv78KwsyOoZ1R;
  }
}

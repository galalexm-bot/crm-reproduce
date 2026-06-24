// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.PublicationBehaviours.NotValueEqualsBehaviour
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.PublicationBehaviours
{
  /// <summary>
  /// Расширитель поведения публикации, требующий перезапуска если значения отличаются
  /// </summary>
  public sealed class NotValueEqualsBehaviour : IPublicationBehaviourChecker
  {
    private static NotValueEqualsBehaviour a9XSWObrXtnyWEWYowrV;

    /// <inheritdoc />
    public PublicationType Check(CheckType action, object oldValue, object newValue)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (oldValue.Equals(newValue))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return PublicationType.Soft;
label_3:
      return PublicationType.Restart;
    }

    public NotValueEqualsBehaviour()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Ekm94GbrTbUMhEoCXTVJ() => NotValueEqualsBehaviour.a9XSWObrXtnyWEWYowrV == null;

    internal static NotValueEqualsBehaviour NRLA0tbrkwcydflXnOHB() => NotValueEqualsBehaviour.a9XSWObrXtnyWEWYowrV;
  }
}

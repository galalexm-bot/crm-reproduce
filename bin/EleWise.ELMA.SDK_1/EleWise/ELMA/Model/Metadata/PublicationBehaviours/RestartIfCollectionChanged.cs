// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.PublicationBehaviours.RestartIfCollectionChanged
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Metadata.PublicationBehaviours
{
  /// <summary>
  /// Расширитель поведения публикации, требующий перезапуска если коллекция не пустая
  /// </summary>
  internal sealed class RestartIfCollectionChanged : IPublicationBehaviourChecker
  {
    private static RestartIfCollectionChanged lQF3ssbrnEXyrdxWN15V;

    /// <inheritdoc />
    public PublicationType Check(CheckType action, object oldValue, object newValue)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        IEnumerable<object> objects;
        while (true)
        {
          IEnumerable<object> source;
          switch (num2)
          {
            case 1:
            case 5:
              if (!((IEnumerable<object>) newValue).Any<object>())
              {
                num2 = 9;
                continue;
              }
              goto label_17;
            case 2:
              if (action == CheckType.Create)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
                continue;
              }
              break;
            case 3:
              if (source.Count<object>() == objects.Count<object>())
              {
                num2 = 4;
                continue;
              }
              goto label_7;
            case 4:
              if (source.SetEqual<object>(objects))
              {
                num2 = 8;
                continue;
              }
              goto label_7;
            case 6:
              goto label_9;
            case 7:
              goto label_17;
            case 8:
              goto label_8;
            case 9:
              goto label_18;
            case 10:
              goto label_7;
            case 11:
              goto label_12;
          }
          if (action != CheckType.Change)
          {
            num2 = 6;
          }
          else
          {
            source = (IEnumerable<object>) oldValue;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 11 : 8;
          }
        }
label_12:
        objects = (IEnumerable<object>) newValue;
        num1 = 3;
      }
label_7:
      return PublicationType.Restart;
label_8:
      return PublicationType.Soft;
label_9:
      return PublicationType.Restart;
label_17:
      return PublicationType.Restart;
label_18:
      return PublicationType.Delta;
    }

    public RestartIfCollectionChanged()
    {
      RestartIfCollectionChanged.dqUOj7breLjXLoKOrquI();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool rOtmn4brONkxmIwdu6qy() => RestartIfCollectionChanged.lQF3ssbrnEXyrdxWN15V == null;

    internal static RestartIfCollectionChanged hxgfYDbr21eoT3rintGu() => RestartIfCollectionChanged.lQF3ssbrnEXyrdxWN15V;

    internal static void dqUOj7breLjXLoKOrquI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

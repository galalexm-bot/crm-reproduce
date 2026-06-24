// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.TransformationChangeRemoveValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Transformations
{
  [Serializable]
  public class TransformationChangeRemoveValue
  {
    private static TransformationChangeRemoveValue instance;
    internal static TransformationChangeRemoveValue NZ2BSGWUqs4SvSZqGnwO;

    public static TransformationChangeRemoveValue Instance
    {
      get
      {
        int num = 1;
        TransformationChangeRemoveValue instance;
        while (true)
        {
          switch (num)
          {
            case 1:
              instance = TransformationChangeRemoveValue.instance;
              if (instance == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return instance;
label_5:
        return TransformationChangeRemoveValue.instance = new TransformationChangeRemoveValue();
      }
    }

    public TransformationChangeRemoveValue()
    {
      TransformationChangeRemoveValue.tyTfyUWUTOMjNThMrVsa();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool jwvLECWUKsKOp8wtyuQr() => TransformationChangeRemoveValue.NZ2BSGWUqs4SvSZqGnwO == null;

    internal static TransformationChangeRemoveValue g7qWwxWUXnjJQcgiM9VD() => TransformationChangeRemoveValue.NZ2BSGWUqs4SvSZqGnwO;

    internal static void tyTfyUWUTOMjNThMrVsa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

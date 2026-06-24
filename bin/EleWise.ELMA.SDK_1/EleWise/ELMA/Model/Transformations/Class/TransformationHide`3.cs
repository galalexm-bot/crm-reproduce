// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.Class.TransformationHide`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Transformations.Class
{
  [Serializable]
  public class TransformationHide<TItem, TTransformation, TUid> : 
    TransformationHide<TItem, TTransformation, TUid, TUid>
    where TItem : class
    where TTransformation : Transformation<TItem, TTransformation, TUid>, new()
    where TUid : class
  {
    private static object nkI0uZWsCQj4CYXiQJY4;

    public TransformationHide()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool TWwonfWsv12feca7a94q() => TransformationHide<TItem, TTransformation, TUid>.nkI0uZWsCQj4CYXiQJY4 == null;

    internal static object AoUAPoWs8ek28bSULqyZ() => TransformationHide<TItem, TTransformation, TUid>.nkI0uZWsCQj4CYXiQJY4;
  }
}

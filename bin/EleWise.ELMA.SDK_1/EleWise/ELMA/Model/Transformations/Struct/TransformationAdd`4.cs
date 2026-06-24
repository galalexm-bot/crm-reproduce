// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.Struct.TransformationAdd`4
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Transformations.Struct
{
  [Serializable]
  public abstract class TransformationAdd<TItem, TTransformation, TUid, TSaveItem> : 
    TransformationAdd<TItem, TTransformation, TUid, TUid?, TSaveItem>
    where TItem : class
    where TTransformation : Transformation<TItem, TTransformation, TUid>, new()
    where TUid : struct
  {
    private static object BYX3ngWU7TYp3tDqMEDe;

    protected TransformationAdd()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool tTqyE0WUxP3w38w2Byyp() => TransformationAdd<TItem, TTransformation, TUid, TSaveItem>.BYX3ngWU7TYp3tDqMEDe == null;

    internal static object aUOTISWU0vCMuVPtl4Of() => TransformationAdd<TItem, TTransformation, TUid, TSaveItem>.BYX3ngWU7TYp3tDqMEDe;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.Struct.TransformationHide`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Transformations.Struct
{
  [Serializable]
  public class TransformationHide<TItem, TTransformation, TUid> : 
    TransformationHide<TItem, TTransformation, TUid, TUid?>
    where TItem : class
    where TTransformation : Transformation<TItem, TTransformation, TUid>, new()
    where TUid : struct
  {
    private static object sY0xx3WUlnS7JASM9da8;

    public TransformationHide()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool aFVSMQWUr1i2uf7TCXno() => TransformationHide<TItem, TTransformation, TUid>.sY0xx3WUlnS7JASM9da8 == null;

    internal static object hnemIjWUgi80acLFx2AS() => TransformationHide<TItem, TTransformation, TUid>.sY0xx3WUlnS7JASM9da8;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.TransformationAdd`4
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Transformations
{
  [Serializable]
  public class TransformationAdd<TItem, TTransformation, TUid, TNullUid> : 
    TransformationAdd<TItem, TTransformation, TUid, TNullUid, TItem>
    where TItem : class
    where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()
  {
    internal static object Ord40RWUSRusL5jIcnIB;

    /// <summary>Возращается копия объекта</summary>
    protected internal override TItem GetItem() => Transformation<TItem, TTransformation, TUid, TNullUid>.Instance.Clone(this.Item);

    /// <summary>
    /// Устанавливает копию значение для сохраняемого свойства
    /// </summary>
    protected internal override void SetItem(TItem value) => this.Item = Transformation<TItem, TTransformation, TUid, TNullUid>.Instance.CreateCopy(value);

    public TransformationAdd()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool PX5pYPWUiHnH9td2ftGZ() => TransformationAdd<TItem, TTransformation, TUid, TNullUid>.Ord40RWUSRusL5jIcnIB == null;

    internal static object jFxdIKWURANCMQHxF4Cq() => TransformationAdd<TItem, TTransformation, TUid, TNullUid>.Ord40RWUSRusL5jIcnIB;
  }
}

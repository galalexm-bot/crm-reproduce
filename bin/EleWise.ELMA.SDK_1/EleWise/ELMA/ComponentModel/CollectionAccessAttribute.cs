// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.CollectionAccessAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Indicates how method invocation affects content of the collection.
  /// </summary>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class CollectionAccessAttribute : Attribute
  {
    internal static CollectionAccessAttribute KobbdBfC2GgBVieuMpyM;

    public CollectionAccessAttribute(CollectionAccessType collectionAccessType)
    {
      CollectionAccessAttribute.bT9JJcfC1MJioJsOrhTP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.CollectionAccessType = collectionAccessType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public CollectionAccessType CollectionAccessType
    {
      get => this.\u003CCollectionAccessType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CCollectionAccessType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static void bT9JJcfC1MJioJsOrhTP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xRkmWYfCe6wecOFF1sTj() => CollectionAccessAttribute.KobbdBfC2GgBVieuMpyM == null;

    internal static CollectionAccessAttribute Vl4XXZfCP4rXEfRXIc0x() => CollectionAccessAttribute.KobbdBfC2GgBVieuMpyM;
  }
}

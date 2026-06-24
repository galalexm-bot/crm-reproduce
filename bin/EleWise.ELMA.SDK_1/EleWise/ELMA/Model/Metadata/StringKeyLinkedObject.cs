// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.StringKeyLinkedObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Информация об объекте со строковым идентификатором</summary>
  public class StringKeyLinkedObject : MetadataLinkedObject, IStringKeyLinkedObject, ILinkedObject
  {
    private static StringKeyLinkedObject xIyboIb11LTm9CFsxIPy;

    /// <summary>Уникальный строковый идентификатор объекта</summary>
    public string UidStr
    {
      get => this.\u003CUidStr\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CUidStr\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
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

    public StringKeyLinkedObject()
    {
      StringKeyLinkedObject.AdPC5ub1pQoSEQ486eC5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool nPAXHQb1Nrd5OuMsgRtL() => StringKeyLinkedObject.xIyboIb11LTm9CFsxIPy == null;

    internal static StringKeyLinkedObject pnUD8vb1341NV580FdOa() => StringKeyLinkedObject.xIyboIb11LTm9CFsxIPy;

    internal static void AdPC5ub1pQoSEQ486eC5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

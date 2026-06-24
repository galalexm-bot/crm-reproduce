// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.TablePartPublicMetadataFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  [Component]
  internal class TablePartPublicMetadataFilter : IPublicMetadataFilter
  {
    internal static TablePartPublicMetadataFilter LjaIuJbwK8r2bSdJ8JMM;

    /// <summary>Функция фильтрации метаданных</summary>
    public Func<IMetadata, bool> Filter => (Func<IMetadata, bool>) (metadata => !(metadata is TablePartMetadata));

    public TablePartPublicMetadataFilter()
    {
      TablePartPublicMetadataFilter.mC2LwJbwkSNy0gTd3KP7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void mC2LwJbwkSNy0gTd3KP7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool aQe5RAbwXMUZWL8sW27X() => TablePartPublicMetadataFilter.LjaIuJbwK8r2bSdJ8JMM == null;

    internal static TablePartPublicMetadataFilter uWhtcobwTXjM0HORuyh3() => TablePartPublicMetadataFilter.LjaIuJbwK8r2bSdJ8JMM;
  }
}

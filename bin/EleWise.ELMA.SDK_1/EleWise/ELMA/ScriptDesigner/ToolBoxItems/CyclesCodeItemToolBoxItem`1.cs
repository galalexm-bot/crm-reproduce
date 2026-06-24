// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.CyclesCodeItemToolBoxItem`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ScriptDesigner.CodeItems;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  public abstract class CyclesCodeItemToolBoxItem<TCodeItem> : CodeItemToolBoxItem<TCodeItem> where TCodeItem : ICodeItem
  {
    private static object iX1CloI2aKFykj1bO2v;

    public override Guid GroupUid => CyclesCodeItemToolBoxGroup.UID;

    protected CyclesCodeItemToolBoxItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool M3Kip4IeKWRC8BMJeux() => CyclesCodeItemToolBoxItem<TCodeItem>.iX1CloI2aKFykj1bO2v == null;

    internal static object JJ3MfMIPqk49XZW22kf() => CyclesCodeItemToolBoxItem<TCodeItem>.iX1CloI2aKFykj1bO2v;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.VariableCodeItemToolBoxItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Services;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  [Serializable]
  public class VariableCodeItemToolBoxItem : NewCodeItemToolBoxItem<VariableCodeItem>
  {
    private Guid? propertyMetadataUid;
    private static VariableCodeItemToolBoxItem mD37bKV4xrZRxGkT06b;

    public VariableCodeItemToolBoxItem()
    {
      VariableCodeItemToolBoxItem.Ca3eNsVA3eMM4hp3bQ9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.DisplayNames = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.PropertyNames = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public Guid? PropertyMetadataUid
    {
      get => this.propertyMetadataUid;
      set
      {
        if (value.HasValue)
        {
          Guid? nullable = value;
          Guid empty = Guid.Empty;
          if ((nullable.HasValue ? (nullable.HasValue ? (nullable.GetValueOrDefault() != empty ? 1 : 0) : 0) : 1) != 0)
            this.PropertyMetadata = MetadataServiceContext.Service.GetMetadata(value.Value);
        }
        this.propertyMetadataUid = value;
      }
    }

    public override Guid GroupUid => VariablesCodeItemToolBoxGroup.UID;

    internal static void Ca3eNsVA3eMM4hp3bQ9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool v6CA4MV6mOfAIlEYCLR() => VariableCodeItemToolBoxItem.mD37bKV4xrZRxGkT06b == null;

    internal static VariableCodeItemToolBoxItem UH85gNVH9vjepqsHeAU() => VariableCodeItemToolBoxItem.mD37bKV4xrZRxGkT06b;
  }
}

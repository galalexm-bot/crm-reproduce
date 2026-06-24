// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.EntityBAItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.ComponentModel;
using System.Xml.Serialization;

namespace EleWise.ELMA.BPMApps
{
  /// <summary>Описание элемента экспорта сущности</summary>
  public class EntityBAItem : BPMAppManifestItem
  {
    private static EntityBAItem pNc8uufkaTjJlkQOOLem;

    [DefaultValue(false)]
    [XmlElement("ExportData")]
    public bool ExportData
    {
      get => this.\u003CExportData\u003Ek__BackingField;
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
              this.\u003CExportData\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
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

    public EntityBAItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool rx2gTsfkDpLIdX9fbRov() => EntityBAItem.pNc8uufkaTjJlkQOOLem == null;

    internal static EntityBAItem R6C66hfktoRdwKx71JEA() => EntityBAItem.pNc8uufkaTjJlkQOOLem;
  }
}

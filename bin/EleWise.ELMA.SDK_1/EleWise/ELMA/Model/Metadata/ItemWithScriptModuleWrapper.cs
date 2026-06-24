// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ItemWithScriptModuleWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Обертка над сущностью, имеющей скрипт-модуль</summary>
  internal class ItemWithScriptModuleWrapper
  {
    private static ItemWithScriptModuleWrapper NruIn6b1yT82jU2Vqae9;

    /// <summary>
    /// Уникальный идентификатор элеметента метаданных <see cref="T:EleWise.ELMA.Model.Metadata.IMetadataItem" />
    /// </summary>
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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

    /// <summary>Скрипт-модуль</summary>
    public ScriptModule ScriptModule
    {
      get => this.\u003CScriptModule\u003Ek__BackingField;
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
              this.\u003CScriptModule\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
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

    public ItemWithScriptModuleWrapper()
    {
      ItemWithScriptModuleWrapper.KJb1eNb19soWuw7IWFmt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool jfHHJBb1MRJcdgNyw0DC() => ItemWithScriptModuleWrapper.NruIn6b1yT82jU2Vqae9 == null;

    internal static ItemWithScriptModuleWrapper Jx8DfEb1JeBWbqCjhqQA() => ItemWithScriptModuleWrapper.NruIn6b1yT82jU2Vqae9;

    internal static void KJb1eNb19soWuw7IWFmt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

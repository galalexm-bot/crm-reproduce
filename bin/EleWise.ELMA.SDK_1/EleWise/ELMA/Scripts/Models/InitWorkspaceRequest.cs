// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.Models.InitWorkspaceRequest
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Scripts.Models
{
  /// <summary>Запрос на инициализацию рабочего пространства</summary>
  public class InitWorkspaceRequest
  {
    internal static InitWorkspaceRequest otqQE3WWWdVQkA6pNij8;

    /// <summary>Метаданные</summary>
    public NamedMetadata Metadata
    {
      get => this.\u003CMetadata\u003Ek__BackingField;
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
              this.\u003CMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
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

    /// <summary>Список модулей сценариев</summary>
    public List<ScriptModule> ScriptModules { get; set; }

    /// <summary>Тип модуля сценариев</summary>
    public CodeType CodeType
    {
      get => this.\u003CCodeType\u003Ek__BackingField;
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
              this.\u003CCodeType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
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

    /// <summary>Имя открываемого метода</summary>
    public string MethodName
    {
      get => this.\u003CMethodName\u003Ek__BackingField;
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
              this.\u003CMethodName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
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

    public InitWorkspaceRequest()
    {
      InitWorkspaceRequest.pdVxGgWWhaCmasyMmDek();
      // ISSUE: reference to a compiler-generated field
      this.\u003CScriptModules\u003Ek__BackingField = new List<ScriptModule>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool c13qrBWWoFc1PeTKeXlw() => InitWorkspaceRequest.otqQE3WWWdVQkA6pNij8 == null;

    internal static InitWorkspaceRequest sbTZmAWWbTxHyMTXlsn0() => InitWorkspaceRequest.otqQE3WWWdVQkA6pNij8;

    internal static void pdVxGgWWhaCmasyMmDek() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

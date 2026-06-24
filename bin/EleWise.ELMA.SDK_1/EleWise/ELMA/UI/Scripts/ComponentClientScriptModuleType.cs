// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.ComponentClientScriptModuleType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.CodeGeneration;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.UI.Scripts
{
  /// <summary>Тип модуля для клиентских скриптов</summary>
  [Component]
  internal sealed class ComponentClientScriptModuleType : IScriptModuleType
  {
    /// <summary>Уникальный идентификатор типа модуля</summary>
    public static readonly Guid TypeUid;
    private static ComponentClientScriptModuleType WVaBLjgHwSQOHU5G7BQ;

    /// <inheritdoc />
    public Guid Uid => ComponentClientScriptModuleType.TypeUid;

    /// <inheritdoc />
    public string Name => (string) ComponentClientScriptModuleType.KmBxOZg0kEibEf90XHS(ComponentClientScriptModuleType.YPPeSggxwjaIYor1hdG(-787452571 ^ -787437361));

    /// <inheritdoc />
    public string GenerateSourceCode(object parameters)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(parameters is ComponentMetadata componentMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            ComponentClientScriptModuleType.fFPyCdgmk9Dmv5s4pVg(parameters, ComponentClientScriptModuleType.YPPeSggxwjaIYor1hdG(1304605005 ^ 1304589251));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return string.Empty;
label_5:
      return (string) ComponentClientScriptModuleType.cKiS0sgyl0V1xW9hm8o((object) componentMetadata);
    }

    /// <inheritdoc />
    public ScriptCompileResult Compile(ScriptModule module) => throw new NotImplementedException();

    /// <inheritdoc />
    private static string GenerateSourceCode(object metadata)
    {
      int num = 2;
      ICodeGenerator codeGenerator;
      while (true)
      {
        switch (num)
        {
          case 1:
            ComponentClientScriptModuleType.NvQWbngM4iEaqJfLkUa((object) codeGenerator, metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          case 2:
            codeGenerator = (ICodeGenerator) new ComponentClientScriptModuleCodeGenerator();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) ComponentClientScriptModuleType.V214wwgl3qDgBhElp4s(ComponentClientScriptModuleType.W6igUHgJg5sBPBqHOSE(), ComponentClientScriptModuleType.sj7F7Xgdn0pL2thos1g(ComponentClientScriptModuleType.xgcK43g9T2p4jZefn0A((object) codeGenerator)));
    }

    public ComponentClientScriptModuleType()
    {
      ComponentClientScriptModuleType.vxa4dBgrYeEhZYbDuZ3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ComponentClientScriptModuleType()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComponentClientScriptModuleType.TypeUid = ComponentClientScriptModuleTypeConstants.TypeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object YPPeSggxwjaIYor1hdG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object KmBxOZg0kEibEf90XHS([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool Kkv7h4gANYFkvesXx6G() => ComponentClientScriptModuleType.WVaBLjgHwSQOHU5G7BQ == null;

    internal static ComponentClientScriptModuleType xlOCCfg7riaM0GtnbwD() => ComponentClientScriptModuleType.WVaBLjgHwSQOHU5G7BQ;

    internal static void fFPyCdgmk9Dmv5s4pVg([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object cKiS0sgyl0V1xW9hm8o([In] object obj0) => (object) ComponentClientScriptModuleType.GenerateSourceCode(obj0);

    internal static void NvQWbngM4iEaqJfLkUa([In] object obj0, [In] object obj1) => ((ICodeGenerator) obj0).Metadata = (IMetadata) obj1;

    internal static object W6igUHgJg5sBPBqHOSE() => (object) Encoding.UTF8;

    internal static object xgcK43g9T2p4jZefn0A([In] object obj0) => (object) ((ICodeGenerator) obj0).GenerateMainFile();

    internal static object sj7F7Xgdn0pL2thos1g([In] object obj0) => (object) ((GeneratedFileInfo) obj0).Data;

    internal static object V214wwgl3qDgBhElp4s([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);

    internal static void vxa4dBgrYeEhZYbDuZ3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

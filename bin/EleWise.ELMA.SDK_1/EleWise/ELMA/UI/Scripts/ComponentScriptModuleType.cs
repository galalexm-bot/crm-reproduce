// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.ComponentScriptModuleType
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
  /// <summary>Тип модуля скриптов для компонента</summary>
  [Component]
  internal sealed class ComponentScriptModuleType : IScriptModuleType
  {
    /// <summary>Уникальный идентификатор типа модуля</summary>
    public static readonly Guid TypeUid;
    internal static ComponentScriptModuleType yCUdC2j3oaBFOER7mVj;

    /// <inheritdoc />
    public Guid Uid => ComponentScriptModuleType.TypeUid;

    /// <inheritdoc />
    public string Name => EleWise.ELMA.SR.T((string) ComponentScriptModuleType.UaTLj4jDVKNSKoTnIJq(277947046 - -1479185048 ^ 1757117514));

    /// <inheritdoc />
    public string GenerateSourceCode(object parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ComponentScriptModuleType.BPPrtTjt1PKRr6OfNbT(parameters, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583794054));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            if (!(parameters is ComponentMetadata componentMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 2 : 2;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return string.Empty;
label_3:
      return (string) ComponentScriptModuleType.oG9hJvjwdUUrd581uUg((object) componentMetadata);
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
            codeGenerator.Metadata = (IMetadata) metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
            continue;
          case 2:
            codeGenerator = (ICodeGenerator) new ComponentServerScriptModuleCodeGenerator();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) ComponentScriptModuleType.kMZHuQj6dRS1vDHolOu(ComponentScriptModuleType.AU5TiHj4yS0fYclcPyS(), (object) codeGenerator.GenerateMainFile().Data);
    }

    public ComponentScriptModuleType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ComponentScriptModuleType()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComponentScriptModuleType.TypeUid = new Guid((string) ComponentScriptModuleType.UaTLj4jDVKNSKoTnIJq(381945751 ^ 1158627804 ^ 1405849577));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object UaTLj4jDVKNSKoTnIJq(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool bDfsYbjpFjjbW7MduLU() => ComponentScriptModuleType.yCUdC2j3oaBFOER7mVj == null;

    internal static ComponentScriptModuleType BWUEFhjasTjx84n12Im() => ComponentScriptModuleType.yCUdC2j3oaBFOER7mVj;

    internal static void BPPrtTjt1PKRr6OfNbT([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object oG9hJvjwdUUrd581uUg([In] object obj0) => (object) ComponentScriptModuleType.GenerateSourceCode(obj0);

    internal static object AU5TiHj4yS0fYclcPyS() => (object) Encoding.UTF8;

    internal static object kMZHuQj6dRS1vDHolOu([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);
  }
}

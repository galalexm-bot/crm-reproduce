// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.ComponentViewScriptModuleType
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
  /// <summary>Тип модуля для скриптов представления</summary>
  [Component]
  internal sealed class ComponentViewScriptModuleType : IScriptModuleType
  {
    /// <summary>Уникальный идентификатор типа модуля</summary>
    public static readonly Guid TypeUid;
    internal static ComponentViewScriptModuleType vTeUHMlyLQSKXvopHsh;

    /// <inheritdoc />
    public Guid Uid => ComponentViewScriptModuleType.TypeUid;

    /// <inheritdoc />
    public string Name => EleWise.ELMA.SR.T((string) ComponentViewScriptModuleType.kLNu9Al9FOMuEwYyxNV(-630932142 - 1120244082 ^ -1751127638));

    /// <inheritdoc />
    public string GenerateSourceCode(object parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ComponentViewScriptModuleType.SjuD7WldjjSYGIqeVO8(parameters, ComponentViewScriptModuleType.kLNu9Al9FOMuEwYyxNV(-1921202237 ^ -1921252019));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            if (!(parameters is ComponentMetadata metadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 2;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return string.Empty;
label_5:
      return ComponentViewScriptModuleType.GenerateSourceCode((object) metadata);
    }

    /// <inheritdoc />
    public ScriptCompileResult Compile(ScriptModule module) => throw new NotImplementedException();

    /// <inheritdoc />
    private static string GenerateSourceCode(object metadata)
    {
      int num = 1;
      ICodeGenerator codeGenerator;
      while (true)
      {
        switch (num)
        {
          case 1:
            codeGenerator = (ICodeGenerator) new ComponentViewScriptModuleCodeGenerator();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            ComponentViewScriptModuleType.bL7CfSllxl5OgeZTKlv((object) codeGenerator, metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 0;
            continue;
        }
      }
label_3:
      return (string) ComponentViewScriptModuleType.fgIPr2ljtiDFiwD9wut(ComponentViewScriptModuleType.P5ZT8JlrkWmX3L99dM4(), ComponentViewScriptModuleType.eQLF1Zl57yjQUydtk2d(ComponentViewScriptModuleType.qOJNmUlg7s1P1al1tOR((object) codeGenerator)));
    }

    public ComponentViewScriptModuleType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ComponentViewScriptModuleType()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComponentViewScriptModuleType.TypeUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108027208));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object kLNu9Al9FOMuEwYyxNV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool s2ePmFlMnH3m0xeoxJK() => ComponentViewScriptModuleType.vTeUHMlyLQSKXvopHsh == null;

    internal static ComponentViewScriptModuleType rQi5oClJCjfG3jYu7uE() => ComponentViewScriptModuleType.vTeUHMlyLQSKXvopHsh;

    internal static void SjuD7WldjjSYGIqeVO8([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void bL7CfSllxl5OgeZTKlv([In] object obj0, [In] object obj1) => ((ICodeGenerator) obj0).Metadata = (IMetadata) obj1;

    internal static object P5ZT8JlrkWmX3L99dM4() => (object) Encoding.UTF8;

    internal static object qOJNmUlg7s1P1al1tOR([In] object obj0) => (object) ((ICodeGenerator) obj0).GenerateMainFile();

    internal static object eQLF1Zl57yjQUydtk2d([In] object obj0) => (object) ((GeneratedFileInfo) obj0).Data;

    internal static object fgIPr2ljtiDFiwD9wut([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);
  }
}

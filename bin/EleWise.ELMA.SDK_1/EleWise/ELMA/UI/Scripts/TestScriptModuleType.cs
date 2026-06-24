// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.TestScriptModuleType
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
  /// <summary>Тип модуля для тестов клиентских скриптов</summary>
  [Component]
  internal sealed class TestScriptModuleType : IScriptModuleType
  {
    /// <summary>Уникальный идентификатор типа модуля</summary>
    public static readonly Guid TypeUid;
    internal static TestScriptModuleType zNyNrAYcKqdB06S9N1S;

    /// <inheritdoc />
    public Guid Uid => TestScriptModuleType.TypeUid;

    /// <inheritdoc />
    public string Name => (string) TestScriptModuleType.l1q9CLLWompOJNTegIe(TestScriptModuleType.SD81CALBUXJpW7oYvti(-1088304168 ^ -1088354916));

    /// <inheritdoc />
    public string GenerateSourceCode(object parameters)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (parameters is ComponentMetadata componentMetadata)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          case 3:
            Contract.ArgumentNotNull(parameters, (string) TestScriptModuleType.SD81CALBUXJpW7oYvti(--1333735954 ^ 1333784732));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 2;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return string.Empty;
label_5:
      return (string) TestScriptModuleType.XeFYkJLoG7e6tApNKGB((object) componentMetadata);
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
            TestScriptModuleType.PQWigKLbIOEFCwESP4n((object) codeGenerator, metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 2:
            codeGenerator = (ICodeGenerator) new ComponentTestScriptModuleCodeGenerator();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) TestScriptModuleType.EP0UCWLfTvp6GQfmmsR(TestScriptModuleType.Mjf4o2Lhc6IIsBxkqfa(), TestScriptModuleType.sdveyALENsDd4QfBQgD(TestScriptModuleType.qF6BPpLGLWMtn1lHrWj((object) codeGenerator)));
    }

    public TestScriptModuleType()
    {
      TestScriptModuleType.wpK7KeLQuCBUqKd2QFG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TestScriptModuleType()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TestScriptModuleType.wpK7KeLQuCBUqKd2QFG();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TestScriptModuleType.TypeUid = new Guid((string) TestScriptModuleType.SD81CALBUXJpW7oYvti(1597012150 ^ 1597027896));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static object SD81CALBUXJpW7oYvti(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object l1q9CLLWompOJNTegIe([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool YjW9opYzDdMedbecit1() => TestScriptModuleType.zNyNrAYcKqdB06S9N1S == null;

    internal static TestScriptModuleType tet5TiLFN9NyxPLkRsT() => TestScriptModuleType.zNyNrAYcKqdB06S9N1S;

    internal static object XeFYkJLoG7e6tApNKGB([In] object obj0) => (object) TestScriptModuleType.GenerateSourceCode(obj0);

    internal static void PQWigKLbIOEFCwESP4n([In] object obj0, [In] object obj1) => ((ICodeGenerator) obj0).Metadata = (IMetadata) obj1;

    internal static object Mjf4o2Lhc6IIsBxkqfa() => (object) Encoding.UTF8;

    internal static object qF6BPpLGLWMtn1lHrWj([In] object obj0) => (object) ((ICodeGenerator) obj0).GenerateMainFile();

    internal static object sdveyALENsDd4QfBQgD([In] object obj0) => (object) ((GeneratedFileInfo) obj0).Data;

    internal static object EP0UCWLfTvp6GQfmmsR([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);

    internal static void wpK7KeLQuCBUqKd2QFG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

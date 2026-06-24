// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.GlobalScriptModuleType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Templates;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  public class GlobalScriptModuleType : IScriptModuleType
  {
    public const string UID_S = "{3D05C032-4169-41E1-96E6-FD12430EE4C0}";
    public static readonly Guid UID;
    private static GlobalScriptModuleType hmRF4hbSzo3sHBD3bx9D;

    /// <summary>Сгенерировать модуль сценариев для глобального модуля</summary>
    /// <param name="projectItem">Элемент проекта</param>
    /// <returns>Исходные код модуля сценариев</returns>
    public static string GenerateSourceCode(ProjectItem projectItem, string @namespace)
    {
      int num = 2;
      string namespace1;
      ProjectItem projectItem1;
      while (true)
      {
        switch (num)
        {
          case 1:
            namespace1 = @namespace;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_3;
          default:
            projectItem1 = projectItem;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 3 : 3;
            continue;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ResourceTemplateGenerator.GenerateTemplate<GlobalScriptModuleType>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408810576), (Func<string, string>) (s => (string) GlobalScriptModuleType.\u003C\u003Ec__DisplayClass2_0.o1dO71C1fRlq7p31VmQQ(GlobalScriptModuleType.\u003C\u003Ec__DisplayClass2_0.o1dO71C1fRlq7p31VmQQ((object) s, GlobalScriptModuleType.\u003C\u003Ec__DisplayClass2_0.Kka7MgC1EJxrvfwhRUom(-53329496 >> 4 ^ -3281172), (object) namespace1), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239929094), GlobalScriptModuleType.\u003C\u003Ec__DisplayClass2_0.P42J00C1QCu8HGFNnjTE((object) projectItem1))));
    }

    public Guid Uid => GlobalScriptModuleType.UID;

    public string Name => (string) GlobalScriptModuleType.yG1gIEbiof3BMyTuoEYY(GlobalScriptModuleType.G1FMThbiWCm3DwmitAXO(-477139494 ^ -477245422));

    /// <summary>
    /// Сгенерировать начальный исходный код для модуля сценариев
    /// </summary>
    /// <param name="parameters">Параметры</param>
    /// <returns>Исходный код</returns>
    public string GenerateSourceCode(object parameters) => this.GenerateSourceCode(parameters);

    public ScriptCompileResult Compile(ScriptModule module) => throw new NotImplementedException();

    public GlobalScriptModuleType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static GlobalScriptModuleType()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            GlobalScriptModuleType.UID = new Guid((string) GlobalScriptModuleType.G1FMThbiWCm3DwmitAXO(-1638402543 ^ -1638577943));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          case 2:
            GlobalScriptModuleType.TQJTe8bibQTBykcEFr9p();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool tW4J7YbiFeRt9ctwBPIm() => GlobalScriptModuleType.hmRF4hbSzo3sHBD3bx9D == null;

    internal static GlobalScriptModuleType p7emsHbiBpV1o0hN9D00() => GlobalScriptModuleType.hmRF4hbSzo3sHBD3bx9D;

    internal static object G1FMThbiWCm3DwmitAXO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object yG1gIEbiof3BMyTuoEYY([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void TQJTe8bibQTBykcEFr9p() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    public class Parameters
    {
      private static GlobalScriptModuleType.Parameters xfF5ahC1FEojHN8i0m6g;

      public string CustomActivityEntityName
      {
        get => this.\u003CCustomActivityEntityName\u003Ek__BackingField;
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
                this.\u003CCustomActivityEntityName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
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

      public Parameters()
      {
        GlobalScriptModuleType.Parameters.DJTcREC1oIOQZ8Zbm17g();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool wfUP2DC1BrJ2WF0hnju7() => GlobalScriptModuleType.Parameters.xfF5ahC1FEojHN8i0m6g == null;

      internal static GlobalScriptModuleType.Parameters NNCDFjC1WgXxdA9XNCP2() => GlobalScriptModuleType.Parameters.xfF5ahC1FEojHN8i0m6g;

      internal static void DJTcREC1oIOQZ8Zbm17g() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

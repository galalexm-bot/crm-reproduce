// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Entities.EntityScriptModuleType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Templates;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.Entities
{
  /// <summary>Тип модуля сценариев для сущности</summary>
  [Component]
  public class EntityScriptModuleType : IScriptModuleType
  {
    public const string UID_S = "{1E1A9184-9A34-4D26-AF3C-B2E7ABE2954C}";
    public static readonly Guid UID;
    internal static EntityScriptModuleType g588WOb1EnIu9MrWHtdW;

    /// <summary>
    /// Сгенерировать исходный код модуля сценариев для сущности
    /// </summary>
    /// <param name="p">Параметры генерации</param>
    /// <returns>Исходный код модуля сценариев</returns>
    public static string GenerateSourceCode(EntityScriptCodeGenerationParams p)
    {
      int num = 1;
      EntityScriptCodeGenerationParams p1;
      string summary;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            summary = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787314353), (object) ((NamedMetadata) EntityScriptModuleType.qV3Mptb1CTKYxMWaE2uc((object) p1)).DisplayName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 2 : 1;
            continue;
          default:
            p1 = p;
            num = 3;
            continue;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ResourceTemplateGenerator.GenerateTemplate<EntityScriptModuleType>((string) EntityScriptModuleType.PN1aqTb1vCLmA6iEJG6U(-420743386 ^ -420932788), (Func<string, string>) (s => (string) EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.oHYMVvCayVBc4k9Y8idW(EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.oHYMVvCayVBc4k9Y8idW((object) ((string) EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.oHYMVvCayVBc4k9Y8idW(EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.oHYMVvCayVBc4k9Y8idW((object) s, EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.yXKgo5CaxMCYNvY1a1uB(~-306453669 ^ 306295222), EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.eEKtRGCamsG5aPy1N99u(EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.UniGvACa07vFtPK3F9rQ((object) p1))), EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.yXKgo5CaxMCYNvY1a1uB(1253244298 - 1829393894 ^ -575862114), EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.xojF1BCaMXtqWuKTtJkw((object) p1.Metadata))).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312815665), ((ScriptModuleDTO) EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.P0xYS5CaJReYd8PkQ1oH((object) p1)).Namespace), EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.yXKgo5CaxMCYNvY1a1uB(-342626196 - 1290888215 ^ -1633532033), (object) summary), EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.yXKgo5CaxMCYNvY1a1uB(1642859704 ^ 1642702388), EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.kaSYxLCa9rGlJE5bHHjt(EntityScriptModuleType.\u003C\u003Ec__DisplayClass2_0.P0xYS5CaJReYd8PkQ1oH((object) p1)))));
    }

    public Guid Uid => EntityScriptModuleType.UID;

    public string Name => (string) EntityScriptModuleType.b6MSp2b18d2Xhk0cEdhr(EntityScriptModuleType.PN1aqTb1vCLmA6iEJG6U(-630932142 - 1120244082 ^ -1751265456));

    /// <summary>
    /// Сгенерировать начальный исходный код для модуля сценариев
    /// </summary>
    /// <param name="parameters">Параметры</param>
    /// <returns>Исходный код</returns>
    public string GenerateSourceCode(object parameters)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!(parameters is EntityScriptCodeGenerationParamsUI p))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return EntityScriptModuleType.GenerateSourceCode((object) p);
label_3:
      return (string) EntityScriptModuleType.QrtDQ3b1ZSrQGWI7RrDL((object) (EntityScriptCodeGenerationParams) parameters);
    }

    public ScriptCompileResult Compile(ScriptModule module) => throw new NotImplementedException();

    /// <summary>
    /// Сгенерировать начальный исходный код для модуля сценариев
    /// </summary>
    /// <param name="parameters">Параметры</param>
    /// <returns>Исходный код</returns>
    private static string GenerateSourceCode(object p)
    {
      int num = 3;
      EntityScriptCodeGenerationParamsUI p1;
      string summary;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EntityScriptModuleType.BqLpSjb1IYQwl4Ml5sKX((object) p1) == RuntimeVersion.Version2)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            p1 = (EntityScriptCodeGenerationParamsUI) p;
            num = 4;
            continue;
          case 3:
            num = 2;
            continue;
          case 4:
            summary = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853024722), EntityScriptModuleType.kUlefBb1ugmlim4ELYKH((object) p1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ResourceTemplateGenerator.GenerateTemplate<EntityScriptModuleType>((string) EntityScriptModuleType.PN1aqTb1vCLmA6iEJG6U(-1886646897 ^ -1886459541), (Func<string, string>) (s => (string) EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.rjCQtSCaLoC6eEwmh4i5((object) ((string) EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.rjCQtSCaLoC6eEwmh4i5(EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.rjCQtSCaLoC6eEwmh4i5((object) s.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293530102), (string) EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.SPp6yVCa5P0QdFwftiLy((object) p1)), EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.BqRw1sCajsqa0ClQjDkn(~-306453669 ^ 306295198), EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.OFxPffCaY17bC7xsv6pu((object) p1)), EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.BqRw1sCajsqa0ClQjDkn(-740338220 ^ -740319454), EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.C3D0W0CaU9U60vCXSGR0((object) p1))).Replace((string) EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.BqRw1sCajsqa0ClQjDkn(236071375 ^ 236118757), summary), EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.BqRw1sCajsqa0ClQjDkn(-97972138 ^ -97731878), EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.JRyiBsCasfqw4cRPIWZq((object) p1))));
label_5:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ResourceTemplateGenerator.GenerateTemplate<EntityScriptModuleType>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536615936), (Func<string, string>) (s => (string) EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.rjCQtSCaLoC6eEwmh4i5(EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.rjCQtSCaLoC6eEwmh4i5(EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.rjCQtSCaLoC6eEwmh4i5(EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.rjCQtSCaLoC6eEwmh4i5(EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.rjCQtSCaLoC6eEwmh4i5((object) s, EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.BqRw1sCajsqa0ClQjDkn(1574260816 ^ 1573977410), (object) p1.MdNamespace), EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.BqRw1sCajsqa0ClQjDkn(1917256330 ^ 1916972976), (object) p1.MdTypeName), EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.BqRw1sCajsqa0ClQjDkn(-1939377524 ^ -1939359622), EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.C3D0W0CaU9U60vCXSGR0((object) p1)), EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.BqRw1sCajsqa0ClQjDkn(-606654180 ^ -606602698), (object) summary), EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.BqRw1sCajsqa0ClQjDkn(-1598106783 - -968262081 ^ -630128722), EntityScriptModuleType.\u003C\u003Ec__DisplayClass9_0.JRyiBsCasfqw4cRPIWZq((object) p1))));
    }

    public EntityScriptModuleType()
    {
      EntityScriptModuleType.WIggBab1V9aTqxZyZNTE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityScriptModuleType()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EntityScriptModuleType.WIggBab1V9aTqxZyZNTE();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            EntityScriptModuleType.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824461133));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object qV3Mptb1CTKYxMWaE2uc([In] object obj0) => (object) ((EntityScriptCodeGenerationParams) obj0).Metadata;

    internal static object PN1aqTb1vCLmA6iEJG6U(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool s9lNSnb1f0V0AGnXF4WM() => EntityScriptModuleType.g588WOb1EnIu9MrWHtdW == null;

    internal static EntityScriptModuleType pE3tP2b1QtBkuOPP12Wc() => EntityScriptModuleType.g588WOb1EnIu9MrWHtdW;

    internal static object b6MSp2b18d2Xhk0cEdhr([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object QrtDQ3b1ZSrQGWI7RrDL([In] object obj0) => (object) EntityScriptModuleType.GenerateSourceCode((EntityScriptCodeGenerationParams) obj0);

    internal static object kUlefBb1ugmlim4ELYKH([In] object obj0) => (object) ((EntityScriptCodeGenerationParamsUI) obj0).MdDisplayName;

    internal static RuntimeVersion BqLpSjb1IYQwl4Ml5sKX([In] object obj0) => ((EntityScriptCodeGenerationParamsUI) obj0).RuntimeVersion;

    internal static void WIggBab1V9aTqxZyZNTE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ServerBuildResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Результат построения серверной сбоорки</summary>
  public sealed class ServerBuildResult
  {
    internal static ServerBuildResult BlynMeb3KnbjicaUMoAm;

    /// <summary>Ctor</summary>
    /// <param name="assemblyRaw">Скомпилированная .Net сборка</param>
    /// <param name="debugRaw">Скомпилированная JS сборка</param>
    /// <param name="assemblyName">Имя сборки</param>
    /// <param name="documentationRaw">Документация к .NET сборке</param>
    public ServerBuildResult(
      byte[] assemblyRaw,
      byte[] debugRaw,
      string assemblyName,
      byte[] documentationRaw = null)
    {
      ServerBuildResult.xOGEfTb3kk9JixclDZO2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.AssemblyName = assemblyName;
            num = 4;
            continue;
          case 3:
            this.AssemblyRaw = assemblyRaw;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
            continue;
          case 4:
            this.DocumentationRaw = documentationRaw;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 1;
            continue;
          default:
            this.DebugRaw = debugRaw;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Скомпилированный код сборки</summary>
    public byte[] AssemblyRaw { get; }

    /// <summary>PDB-файл сборки</summary>
    public byte[] DebugRaw { get; }

    /// <summary>Имя сборки</summary>
    public string AssemblyName { get; }

    /// <summary>Документация к .NET сборке</summary>
    public byte[] DocumentationRaw { get; }

    internal static void xOGEfTb3kk9JixclDZO2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool I8DOKYb3XfQ9TEautI7o() => ServerBuildResult.BlynMeb3KnbjicaUMoAm == null;

    internal static ServerBuildResult EjjFeab3TaNPuERi2MC3() => ServerBuildResult.BlynMeb3KnbjicaUMoAm;
  }
}

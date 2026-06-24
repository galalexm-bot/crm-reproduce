// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ClientBuildResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Результат построения клиентской сборки</summary>
  public sealed class ClientBuildResult
  {
    private static ClientBuildResult AjZMELb1canb0fBQbsiH;

    /// <summary>Ctor</summary>
    /// <param name="assemblyRaw">Скомпилированная .Net сборка</param>
    /// <param name="jsAssemblyRaw">Скомпилированная JS сборка</param>
    /// <param name="minJsAssemblyRaw">Минифицированная JS сборка</param>
    /// <param name="assemblyName">Имя клиентской сборки</param>
    /// <param name="documentationRaw">Документация к .NET сборке</param>
    public ClientBuildResult(
      byte[] assemblyRaw,
      byte[] jsAssemblyRaw,
      byte[] minJsAssemblyRaw,
      string assemblyName,
      byte[] documentationRaw = null)
    {
      ClientBuildResult.aYgIETbNB8GqbvkZcBEP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.JsAssemblyRaw = jsAssemblyRaw;
            num = 5;
            continue;
          case 3:
            this.AssemblyName = assemblyName;
            num = 4;
            continue;
          case 4:
            this.DocumentationRaw = documentationRaw;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
            continue;
          case 5:
            this.MinJsAssemblyRaw = minJsAssemblyRaw;
            num = 3;
            continue;
          default:
            this.AssemblyRaw = assemblyRaw;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Скомпилированная .Net сборка</summary>
    public byte[] AssemblyRaw { get; }

    /// <summary>Скомпилированная JS сборка</summary>
    public byte[] JsAssemblyRaw { get; }

    /// <summary>Минифицированная JS сборка</summary>
    public byte[] MinJsAssemblyRaw { get; }

    /// <summary>Имя клиентской сборки</summary>
    public string AssemblyName { get; }

    /// <summary>Документация к .NET сборке</summary>
    public byte[] DocumentationRaw { get; }

    internal static void aYgIETbNB8GqbvkZcBEP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool rAadq2b1z6H0ECKUPFC4() => ClientBuildResult.AjZMELb1canb0fBQbsiH == null;

    internal static ClientBuildResult VnaT9ObNFNeiXrXyCuVX() => ClientBuildResult.AjZMELb1canb0fBQbsiH;
  }
}

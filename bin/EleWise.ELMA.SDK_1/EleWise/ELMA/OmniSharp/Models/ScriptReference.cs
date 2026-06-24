// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.Models.ScriptReference
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.OmniSharp.Models
{
  /// <inheritdoc />
  internal sealed class ScriptReference : IScriptReference
  {
    internal static ScriptReference xD0OFJWlMKy3JyKpefiA;

    /// <summary>Ctor</summary>
    /// <param name="name">Имя сборки</param>
    /// <param name="hintPath">Относительный путь до сборки (если это не глобальная сборка)</param>
    /// <param name="assemblyRaw">Raw сборки</param>
    /// <param name="documentationRaw">Raw файла XML-документации</param>
    public ScriptReference(
      string name,
      string hintPath,
      byte[] assemblyRaw,
      byte[] documentationRaw = null)
    {
      ScriptReference.k8xAP7WldQHME8n7RRUd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            byte[] numArray = documentationRaw;
            this.DocumentationRaw = numArray == null ? Array.Empty<byte>() : numArray;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 2:
            this.HintPath = hintPath;
            num = 4;
            continue;
          case 3:
            this.Name = name;
            num = 2;
            continue;
          case 4:
            this.AssemblyRaw = assemblyRaw;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_8:
      return;
label_3:;
    }

    /// <inheritdoc />
    public string Name { get; }

    /// <inheritdoc />
    public string HintPath { get; }

    /// <inheritdoc />
    public byte[] AssemblyRaw { get; }

    /// <inheritdoc />
    public byte[] DocumentationRaw { get; }

    internal static void k8xAP7WldQHME8n7RRUd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool P1nSIFWlJL1d1NlrSHtR() => ScriptReference.xD0OFJWlMKy3JyKpefiA == null;

    internal static ScriptReference Q4DtvbWl9RF1tQpyN9K6() => ScriptReference.xD0OFJWlMKy3JyKpefiA;
  }
}

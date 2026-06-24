// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.Models.ScriptSource
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.OmniSharp.Models
{
  /// <inheritdoc />
  public sealed class ScriptSource : IScriptSource
  {
    private static ScriptSource im2GtZWllxqnuKoK7tBA;

    /// <summary>Ctor</summary>
    /// <param name="name">Имя файла</param>
    /// <param name="content">Содержимое файла</param>
    /// <param name="type">Тип исходника</param>
    public ScriptSource(string name, string content, ScriptSourceType type)
    {
      ScriptSource.ICRnBTWl558jwuD6tB5v();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Name = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          case 2:
            this.Type = type;
            num = 3;
            continue;
          case 3:
            goto label_3;
          default:
            this.Content = content;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public string Name { get; }

    /// <inheritdoc />
    public string Content { get; }

    /// <inheritdoc />
    public ScriptSourceType Type { get; }

    internal static void ICRnBTWl558jwuD6tB5v() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool k3wAyPWlrXWuXEMuqXX0() => ScriptSource.im2GtZWllxqnuKoK7tBA == null;

    internal static ScriptSource DsteykWlgQyKAGhZ78n9() => ScriptSource.im2GtZWllxqnuKoK7tBA;
  }
}

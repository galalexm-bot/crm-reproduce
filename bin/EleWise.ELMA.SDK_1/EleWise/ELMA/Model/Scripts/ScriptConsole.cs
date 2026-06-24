// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ScriptConsole
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>
  /// Стандартная консоль сценариев (записывает результат в свойство Output)
  /// </summary>
  public class ScriptConsole : ScriptConsoleBase
  {
    private string output;
    internal static ScriptConsole IJsDyobikcQlW6SCWMqR;

    public virtual void Clear()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.output = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override void Write(string message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.output = (string) ScriptConsole.DEjbWYbi2gcOl0lY3EJ1((object) this.output, (object) message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public string Output => this.output;

    public ScriptConsole()
    {
      ScriptConsole.Cbb3xRbieHnWSQAMYKhm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Luv9OLbin4ER4CDHonqE() => ScriptConsole.IJsDyobikcQlW6SCWMqR == null;

    internal static ScriptConsole OlgMMobiOWcSn9nq5mDV() => ScriptConsole.IJsDyobikcQlW6SCWMqR;

    internal static object DEjbWYbi2gcOl0lY3EJ1([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void Cbb3xRbieHnWSQAMYKhm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

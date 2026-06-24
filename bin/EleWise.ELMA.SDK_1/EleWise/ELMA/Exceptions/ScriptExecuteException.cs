// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ScriptExecuteException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Exceptions
{
  [Serializable]
  public class ScriptExecuteException : Exception
  {
    internal static ScriptExecuteException B5ciQYGj24DP89Wy1yeF;

    public ScriptExecuteException()
    {
      ScriptExecuteException.wpkxpPGj1AoNBTR4a2ON();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ScriptExecuteException(string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ScriptExecuteException(string message, Exception innerException)
    {
      ScriptExecuteException.wpkxpPGj1AoNBTR4a2ON();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ScriptExecuteException(string message, int codeException)
    {
      ScriptExecuteException.wpkxpPGj1AoNBTR4a2ON();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.CodeException = codeException;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    protected ScriptExecuteException(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public int CodeException
    {
      get => this.\u003CCodeException\u003Ek__BackingField;
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
              this.\u003CCodeException\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    internal static void wpkxpPGj1AoNBTR4a2ON() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ggwrGcGjen6vxfvtRLQF() => ScriptExecuteException.B5ciQYGj24DP89Wy1yeF == null;

    internal static ScriptExecuteException fstfo2GjPETjWbXl2LP0() => ScriptExecuteException.B5ciQYGj24DP89Wy1yeF;
  }
}

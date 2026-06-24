// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.ContextVariableCodeItemToolBoxItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  [Serializable]
  public class ContextVariableCodeItemToolBoxItem : NewCodeItemToolBoxItem<VariableCodeItem>
  {
    internal static ContextVariableCodeItemToolBoxItem yBCwZEIB2SEGE9HpX7f;

    public ContextVariableCodeItemToolBoxItem()
    {
      ContextVariableCodeItemToolBoxItem.KCyo14IbEtbR6MF4unS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.PropertyNames = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          default:
            this.DisplayNames = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
            continue;
        }
      }
label_2:;
    }

    public override string DisplayName
    {
      get
      {
        int num = 1;
        List<string> displayNames;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.DisplayNames != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              this.DisplayNames = new List<string>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 3;
              continue;
            case 4:
              goto label_5;
            default:
              displayNames = this.DisplayNames;
              num = 4;
              continue;
          }
        }
label_5:
        return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397268508), (IEnumerable<string>) displayNames);
      }
      set
      {
      }
    }

    public override string VariableName
    {
      get
      {
        int num1 = 6;
        List<string> values;
        List<string>.Enumerator enumerator;
        while (true)
        {
          switch (num1)
          {
            case 1:
              values = new List<string>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 1;
              continue;
            case 2:
              values.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886631527));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_14;
            case 4:
              goto label_4;
            case 5:
              this.PropertyNames = new List<string>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 1;
              continue;
            case 6:
              if (this.PropertyNames == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 5;
                continue;
              }
              goto case 1;
            default:
              enumerator = this.PropertyNames.GetEnumerator();
              num1 = 4;
              continue;
          }
        }
label_4:
        try
        {
label_7:
          if (enumerator.MoveNext())
            goto label_6;
          else
            goto label_8;
label_5:
          string current;
          int num2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_6;
              case 2:
                goto label_7;
              case 3:
                values.Add((string) ContextVariableCodeItemToolBoxItem.DFj4qxIhAGLu6tnn23H((object) current));
                num2 = 2;
                continue;
              default:
                goto label_14;
            }
          }
label_6:
          current = enumerator.Current;
          num2 = 3;
          goto label_5;
label_8:
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
          goto label_5;
        }
        finally
        {
          enumerator.Dispose();
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
            num3 = 0;
          switch (num3)
          {
            default:
          }
        }
label_14:
        return string.Join((string) ContextVariableCodeItemToolBoxItem.SVYR83IG7BfUWO86Py4(1304605005 ^ 1304603529), (IEnumerable<string>) values);
      }
      set
      {
      }
    }

    public override Guid GroupUid => ContextCodeItemToolBoxGroup.UID;

    internal static void KCyo14IbEtbR6MF4unS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool EaL858IWNfwCZfUPPEl() => ContextVariableCodeItemToolBoxItem.yBCwZEIB2SEGE9HpX7f == null;

    internal static ContextVariableCodeItemToolBoxItem g7DOAaIo9st1YETtMLq() => ContextVariableCodeItemToolBoxItem.yBCwZEIB2SEGE9HpX7f;

    internal static object DFj4qxIhAGLu6tnn23H([In] object obj0) => (object) ((string) obj0).ToTranslit();

    internal static object SVYR83IG7BfUWO86Py4(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}

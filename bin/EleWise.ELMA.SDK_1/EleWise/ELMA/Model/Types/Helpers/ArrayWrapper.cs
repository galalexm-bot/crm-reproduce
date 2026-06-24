// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.ArrayWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System.Collections;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [XmlRoot("ArrayValue")]
  [Component]
  public class ArrayWrapper : IXsiType
  {
    private static ArrayWrapper KyJIRjbhJV2OWREF8j27;

    public ArrayWrapper()
    {
      ArrayWrapper.B9nAv9bhl5GnObbJL6PP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ArrayWrapper(ICollection array)
    {
      ArrayWrapper.B9nAv9bhl5GnObbJL6PP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (array == null)
            {
              num = 4;
              continue;
            }
            break;
          case 2:
            this.ArrayTypeName = array.GetType().AssemblyQualifiedName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 3 : 3;
            continue;
          case 3:
            goto label_4;
          case 4:
            goto label_3;
        }
        this.Value = ClassSerializationHelper.SerializeObjectByJson((object) array);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 2;
      }
label_4:
      return;
label_3:;
    }

    [XmlElement("Value")]
    public string Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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
              this.\u003CValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
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

    [XmlElement("ArrayTypeName")]
    public string ArrayTypeName
    {
      get => this.\u003CArrayTypeName\u003Ek__BackingField;
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
              this.\u003CArrayTypeName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
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

    internal static void B9nAv9bhl5GnObbJL6PP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hQKG2vbh9yexEwBqsIfs() => ArrayWrapper.KyJIRjbhJV2OWREF8j27 == null;

    internal static ArrayWrapper cRV3SwbhdrjcU3wSsljM() => ArrayWrapper.KyJIRjbhJV2OWREF8j27;
  }
}

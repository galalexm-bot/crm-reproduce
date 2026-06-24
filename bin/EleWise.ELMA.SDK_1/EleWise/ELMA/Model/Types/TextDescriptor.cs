// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.TextDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Текст"</summary>
  [Component(Order = 200)]
  public class TextDescriptor : StringDescriptor<TextSettings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{317E3D72-9C47-4B68-926D-BA77A2579BC2}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    internal static TextDescriptor M4dOKcoJIYHA3AndqX1q;

    /// <summary>Uid типа</summary>
    public override Guid Uid => TextDescriptor.UID;

    /// <summary>Имя "Текст"</summary>
    public override string Name => (string) TextDescriptor.CIFy75oJROY5pgPmNq25(TextDescriptor.kGSNLwoJiMHPhs6gTh1X(901793403 ^ 901915793));

    /// <summary>
    /// Можно ли использовать данное описание типа при определении описания типа по Runtime-типу
    /// </summary>
    public override bool IsRuntimeType => false;

    public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
    {
      get
      {
        int num = 1;
        IFullTextPropertyDescriptor propertyDescriptor1;
        IFullTextPropertyDescriptor propertyDescriptor2;
        while (true)
        {
          switch (num)
          {
            case 1:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new TextPropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    public TextDescriptor()
    {
      TextDescriptor.UUhabIoJqTe2WHaL6DW9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TextDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TextDescriptor.UUhabIoJqTe2WHaL6DW9();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TextDescriptor.UID = new Guid((string) TextDescriptor.kGSNLwoJiMHPhs6gTh1X(--1418440330 ^ 1418278686));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object kGSNLwoJiMHPhs6gTh1X(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object CIFy75oJROY5pgPmNq25([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool MUin9joJVrmpc8f5qiKG() => TextDescriptor.M4dOKcoJIYHA3AndqX1q == null;

    internal static TextDescriptor TW6i53oJS3Cgw0r0CgqC() => TextDescriptor.M4dOKcoJIYHA3AndqX1q;

    internal static void UUhabIoJqTe2WHaL6DW9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

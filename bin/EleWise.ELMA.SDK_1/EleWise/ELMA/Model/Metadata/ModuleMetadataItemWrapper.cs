// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ModuleMetadataItemWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Signatures;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Класс-обертка над <see cref="T:EleWise.ELMA.Model.Metadata.ModuleMetadataItem" /> для выборки значений из БД
  /// </summary>
  internal sealed class ModuleMetadataItemWrapper
  {
    internal static ModuleMetadataItemWrapper Ds38xXbNy8jRcKTW3gI2;

    /// <summary>Уникальный идентификатор заголовка</summary>
    public Guid HeaderUid
    {
      get => this.\u003CHeaderUid\u003Ek__BackingField;
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
              this.\u003CHeaderUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор элемента</summary>
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
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

    /// <summary>Сигнатура модуля</summary>
    public ModuleSignature Signature
    {
      get => this.\u003CSignature\u003Ek__BackingField;
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
              this.\u003CSignature\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

    /// <summary>Версия</summary>
    public string Version
    {
      get => this.\u003CVersion\u003Ek__BackingField;
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
              this.\u003CVersion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
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

    public ModuleMetadataItemWrapper()
    {
      ModuleMetadataItemWrapper.iX1GT5bN9wdhwl51KZm1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool abkglDbNMyafXFT0YaGE() => ModuleMetadataItemWrapper.Ds38xXbNy8jRcKTW3gI2 == null;

    internal static ModuleMetadataItemWrapper HnY3iKbNJkUSwLdLMXQD() => ModuleMetadataItemWrapper.Ds38xXbNy8jRcKTW3gI2;

    internal static void iX1GT5bN9wdhwl51KZm1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

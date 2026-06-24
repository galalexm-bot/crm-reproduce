// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.TemplateGenerator.MetadataBasedValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates.TemplateGenerator
{
  /// <summary>Значение с метаданными</summary>
  public class MetadataBasedValue : FormatedValue
  {
    private ClassMetadata containerMetadata;
    private bool containerMetadataEvaluated;
    internal static MetadataBasedValue TASxRHBaKuUhp0RGD6xt;

    /// <summary>Метаданные контейнера</summary>
    public ClassMetadata ContainerMetadata
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.containerMetadata = this.GetContainerMetadata();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
              continue;
            case 2:
              this.containerMetadataEvaluated = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
              continue;
            case 3:
              if (!this.containerMetadataEvaluated)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 1;
                continue;
              }
              goto label_6;
            default:
              goto label_6;
          }
        }
label_6:
        return this.containerMetadata;
      }
    }

    /// <summary>Контейнер</summary>
    public object Container
    {
      get => this.\u003CContainer\u003Ek__BackingField;
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
              this.\u003CContainer\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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

    /// <summary>Имя свойства</summary>
    public string PropertyName
    {
      get => this.\u003CPropertyName\u003Ek__BackingField;
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
              this.\u003CPropertyName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
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

    private ClassMetadata GetContainerMetadata()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            goto label_7;
          case 2:
            if (MetadataBasedValue.bhR78vBak1VFH6djF6RN((object) this) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
              continue;
            }
            break;
          case 3:
            MetadataBasedValue.xM8eHZBaOf8maaa2wot4((object) this, MetadataBasedValue.GUQbRyBanrFL6IUwaHKW(MetadataBasedValue.bhR78vBak1VFH6djF6RN((object) this)));
            num = 2;
            continue;
          case 5:
            goto label_8;
        }
        if (MetadataBasedValue.bhR78vBak1VFH6djF6RN((object) this).GetType().IsClass)
          num = 5;
        else
          break;
      }
label_7:
      return (ClassMetadata) null;
label_8:
      return MetadataLoader.LoadMetadata(MetadataBasedValue.bhR78vBak1VFH6djF6RN((object) this).GetType()) as ClassMetadata;
    }

    public MetadataBasedValue()
    {
      MetadataBasedValue.RNXOUEBa2FJnsubZMgK7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool OZK1hFBaXkHeX52MjWJC() => MetadataBasedValue.TASxRHBaKuUhp0RGD6xt == null;

    internal static MetadataBasedValue l3PRxxBaTiY2ERsvBnfq() => MetadataBasedValue.TASxRHBaKuUhp0RGD6xt;

    internal static object bhR78vBak1VFH6djF6RN([In] object obj0) => ((FormatedValue) obj0).Value;

    internal static object GUQbRyBanrFL6IUwaHKW([In] object obj0) => obj0.CastAsRealType();

    internal static void xM8eHZBaOf8maaa2wot4([In] object obj0, [In] object obj1) => ((FormatedValue) obj0).Value = obj1;

    internal static void RNXOUEBa2FJnsubZMgK7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

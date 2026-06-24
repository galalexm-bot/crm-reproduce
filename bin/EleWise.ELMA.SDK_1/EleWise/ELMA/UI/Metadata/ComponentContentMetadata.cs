// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.ComponentContentMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Метаданные содержимого компонента</summary>
  [DataContract]
  [Serializable]
  public class ComponentContentMetadata : AbstractMetadata
  {
    private static ComponentContentMetadata GDcOs9BGh0omdgHPRimR;

    /// <summary>Метаданные модели</summary>
    public ComponentContextMetadata Context
    {
      get => this.\u003CContext\u003Ek__BackingField;
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
              this.\u003CContext\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
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

    /// <summary>Представление формы</summary>
    public FormViewItem View
    {
      get => this.\u003CView\u003Ek__BackingField;
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
              this.\u003CView\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

    /// <summary>Инициализировать новый объект метаданных</summary>
    public override void InitNew()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              ComponentContextMetadata componentContextMetadata = new ComponentContextMetadata();
              ComponentContentMetadata.iuCucPBGf8rjEx8ULNrN((object) componentContextMetadata, this.ModuleUid);
              ComponentContentMetadata.aBjNSgBGCKCwCgaCERgV((object) componentContextMetadata, ComponentContentMetadata.JHYxAIBGQXQQUSYnd8Dw(87862435 ^ 87834813));
              this.Context = componentContextMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 5 : 1;
              continue;
            case 3:
              goto label_5;
            case 4:
              this.View = new FormViewItem()
              {
                RuntimeVersion = RuntimeVersion.Version2
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            case 5:
              this.Context.InitNew();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 4 : 4;
              continue;
            default:
              ComponentContentMetadata.Q2LL56BGv46vjqlkM4tv((object) this.View, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
              continue;
          }
        }
label_5:
        base.InitNew();
        num1 = 2;
      }
label_3:;
    }

    /// <summary>
    /// Сгенерировать новые идентификаторы для всех составляющих элементов (например, для публикации или копирования)
    /// </summary>
    public virtual void GenerateNewUids()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_3;
          case 2:
            ComponentContextMetadata context = this.Context;
            if (context == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
              continue;
            }
            ComponentContentMetadata.FgfW1YBGu6v3XEdJyVZw((object) context);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
            continue;
          case 3:
            ComponentContentMetadata.DtepjcBGZRvlHXXb6iWx((object) this, ComponentContentMetadata.Qa4Ki2BG8WhAbBEVfupv());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 2;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_3:
      return;
label_8:;
    }

    public ComponentContentMetadata()
    {
      ComponentContentMetadata.IuuKvIBGINgDM1IcJThV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool CpFBRJBGGCkL3mwWbEZm() => ComponentContentMetadata.GDcOs9BGh0omdgHPRimR == null;

    internal static ComponentContentMetadata KfkFr7BGEwVnfI0aC1Ej() => ComponentContentMetadata.GDcOs9BGh0omdgHPRimR;

    internal static void iuCucPBGf8rjEx8ULNrN([In] object obj0, Guid value) => ((AbstractMetadata) obj0).ModuleUid = value;

    internal static object JHYxAIBGQXQQUSYnd8Dw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void aBjNSgBGCKCwCgaCERgV([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).Namespace = (string) obj1;

    internal static void Q2LL56BGv46vjqlkM4tv([In] object obj0, [In] object obj1) => ((ViewItem) obj0).InitNew((ViewItem) obj1);

    internal static Guid Qa4Ki2BG8WhAbBEVfupv() => Guid.NewGuid();

    internal static void DtepjcBGZRvlHXXb6iWx([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static void FgfW1YBGu6v3XEdJyVZw([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static void IuuKvIBGINgDM1IcJThV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

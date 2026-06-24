// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.NewCodeItemToolBoxItem`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  /// <summary>
  /// Элемент кода в панели инструментов на основе заданного типа элемента
  /// </summary>
  [Serializable]
  public abstract class NewCodeItemToolBoxItem<TCodeItem> : NewCodeItemToolBoxItem where TCodeItem : ICodeItem
  {
    internal static object QcWRfWVOlteuRgmkLGB;

    public override string Name
    {
      get
      {
        int num = 5;
        ViewItemTypeInfo viewItemTypeInfo1;
        while (true)
        {
          ViewItemInfoService viewItemInfoService1;
          ViewItemTypeInfo viewItemTypeInfo2;
          ViewItemInfoService viewItemInfoService2;
          switch (num)
          {
            case 1:
              if (viewItemInfoService1 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 2 : 2;
                continue;
              }
              viewItemTypeInfo2 = viewItemInfoService1.GetInfo(typeof (TCodeItem));
              goto label_15;
            case 2:
              viewItemTypeInfo2 = (ViewItemTypeInfo) null;
              goto label_15;
            case 3:
              if (viewItemTypeInfo1 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 4:
              viewItemInfoService2 = (ViewItemInfoService) null;
              break;
            case 5:
              if (!Locator.Initialized)
              {
                num = 4;
                continue;
              }
              viewItemInfoService2 = Locator.GetService<ViewItemInfoService>();
              break;
            default:
              goto label_5;
          }
          viewItemInfoService1 = viewItemInfoService2;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
          continue;
label_15:
          viewItemTypeInfo1 = viewItemTypeInfo2;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 2 : 3;
        }
label_5:
        return string.Empty;
label_6:
        return viewItemTypeInfo1.Name;
      }
      set
      {
      }
    }

    [XmlIgnore]
    public override Type CodeItemType
    {
      get => typeof (TCodeItem);
      set
      {
      }
    }

    public override ICodeItem CreateCodeItem()
    {
      int num = 2;
      TCodeItem instance;
      while (true)
      {
        switch (num)
        {
          case 1:
            instance.InitNew((ICodeItem) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          case 2:
            instance = Activator.CreateInstance<TCodeItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (ICodeItem) instance;
    }

    public override bool IsAvailable(IMetadata metadata) => ViewItemMetadataAttribute.IsAvailable<TCodeItem>(metadata);

    protected NewCodeItemToolBoxItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool p7fcgAV2M31vqc8Z9gj() => NewCodeItemToolBoxItem<TCodeItem>.QcWRfWVOlteuRgmkLGB == null;

    internal static object ds6rM1Ve08EdHZJEWb4() => NewCodeItemToolBoxItem<TCodeItem>.QcWRfWVOlteuRgmkLGB;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.CodeItemToolBoxItem`1
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

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  /// <summary>
  /// Элемент кода в панели инструментов на основе заданного типа элемента
  /// </summary>
  public abstract class CodeItemToolBoxItem<TCodeItem> : CodeItemToolBoxItem where TCodeItem : ICodeItem
  {
    private static object uPepYfucPv1vZKBjnTk;

    public override Type CodeItemType
    {
      get => typeof (TCodeItem);
      set
      {
      }
    }

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
              viewItemTypeInfo2 = (ViewItemTypeInfo) null;
              goto label_15;
            case 2:
              goto label_4;
            case 3:
              if (viewItemTypeInfo1 == null)
              {
                num = 2;
                continue;
              }
              goto label_5;
            case 4:
              viewItemInfoService2 = Locator.GetService<ViewItemInfoService>();
              break;
            case 5:
              if (Locator.Initialized)
              {
                num = 4;
                continue;
              }
              goto case 6;
            case 6:
              viewItemInfoService2 = (ViewItemInfoService) null;
              break;
            default:
              if (viewItemInfoService1 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
                continue;
              }
              viewItemTypeInfo2 = viewItemInfoService1.GetInfo(typeof (TCodeItem));
              goto label_15;
          }
          viewItemInfoService1 = viewItemInfoService2;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
          continue;
label_15:
          viewItemTypeInfo1 = viewItemTypeInfo2;
          num = 3;
        }
label_4:
        return string.Empty;
label_5:
        return viewItemTypeInfo1.Name;
      }
      set
      {
      }
    }

    public override ICodeItem CreateCodeItem()
    {
      int num = 1;
      TCodeItem instance;
      while (true)
      {
        switch (num)
        {
          case 1:
            instance = Activator.CreateInstance<TCodeItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            instance.InitNew((ICodeItem) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return (ICodeItem) instance;
    }

    public override bool IsAvailable(IMetadata metadata) => ViewItemMetadataAttribute.IsAvailable<TCodeItem>(metadata);

    protected CodeItemToolBoxItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ILV7FduzBbn2dBDmvIb() => CodeItemToolBoxItem<TCodeItem>.uPepYfucPv1vZKBjnTk == null;

    internal static object trPS3IIFLcUi8TwiNaO() => CodeItemToolBoxItem<TCodeItem>.uPepYfucPv1vZKBjnTk;
  }
}

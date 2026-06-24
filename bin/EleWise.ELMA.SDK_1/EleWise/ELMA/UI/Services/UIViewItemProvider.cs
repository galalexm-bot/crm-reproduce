// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.UIViewItemProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Services
{
  [Component]
  public abstract class UIViewItemProvider : IObjectViewItemProvider
  {
    internal static UIViewItemProvider EhiHckzGBBBnLuGgD0a;

    /// <summary>Создать идентфикатор элемента представления</summary>
    public static string CreateViewItemId(
      FormDescriptor formDescriptor,
      FormPartMetadata partMetadata)
    {
      UIViewItemParams uiViewItemParams = new UIViewItemParams();
      UIViewItemProvider.s9ZlB8zQ7x6mtHAIsgq((object) uiViewItemParams, (object) formDescriptor, (object) partMetadata);
      return uiViewItemParams.ToString();
    }

    /// <summary>
    /// Инициализировать <paramref name="viewItemParams" /> с помощью остальных параметров
    /// </summary>
    public static void InitViewItemParams(
      UIViewItemParams viewItemParams,
      FormDescriptor formDescriptor,
      FormPartMetadata partMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            UIViewItemProvider.UFX7T2zvXVgQNZBscMC((object) formDescriptor, UIViewItemProvider.K02KPVzC9ofxupayUy8(92412609 - 1050237057 ^ -957845910));
            num = 4;
            continue;
          case 2:
            UIViewItemProvider.UFX7T2zvXVgQNZBscMC((object) viewItemParams, UIViewItemProvider.K02KPVzC9ofxupayUy8(2008901894 << 3 ^ -1108635498));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
            continue;
          case 3:
            UIViewItemProvider.lmAyOYz8vR3q4EBbyCR((object) viewItemParams, (object) formDescriptor);
            num = 5;
            continue;
          case 4:
            UIViewItemProvider.UFX7T2zvXVgQNZBscMC((object) partMetadata, UIViewItemProvider.K02KPVzC9ofxupayUy8(132912447 ^ 132960175));
            num = 3;
            continue;
          case 5:
            viewItemParams.PartMetadata = partMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    /// <summary>Разобрать параметры отображения представления</summary>
    /// <param name="viewItemId">Строка с параметрами (элементы разделяются точкой с запятой)</param>
    /// <returns>Разобранные параметры</returns>
    public static UIViewItemParams ParseViewItemId(string viewItemId) => new UIViewItemParams(viewItemId);

    public abstract Guid ProviderUid { get; }

    public ViewItem GetViewItem(string viewItemId)
    {
      int num = 2;
      UIViewItemParams viewItemParams;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (viewItemParams.PartMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            viewItemParams = this.ParseViewItemParams(viewItemId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (ViewItem) null;
label_3:
      return (ViewItem) UIViewItemProvider.nP68lFzuKgnq6dNWEue(UIViewItemProvider.kXehHGzZHnW8BS6YdZb((object) viewItemParams));
    }

    protected virtual UIViewItemParams ParseViewItemParams(string viewItemId) => (UIViewItemParams) UIViewItemProvider.qg0OyZzIpfDJfZrSlZI((object) viewItemId);

    protected UIViewItemProvider()
    {
      UIViewItemProvider.PPGno4zVMwcuqZWqDmM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void s9ZlB8zQ7x6mtHAIsgq([In] object obj0, [In] object obj1, [In] object obj2) => UIViewItemProvider.InitViewItemParams((UIViewItemParams) obj0, (FormDescriptor) obj1, (FormPartMetadata) obj2);

    internal static bool jU0jnpzEdWPRcIVlJbo() => UIViewItemProvider.EhiHckzGBBBnLuGgD0a == null;

    internal static UIViewItemProvider NXtwL8zfGqRlZ0Zw90G() => UIViewItemProvider.EhiHckzGBBBnLuGgD0a;

    internal static object K02KPVzC9ofxupayUy8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void UFX7T2zvXVgQNZBscMC([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void lmAyOYz8vR3q4EBbyCR([In] object obj0, [In] object obj1) => ((UIViewItemParams) obj0).FormDescriptor = (FormDescriptor) obj1;

    internal static object kXehHGzZHnW8BS6YdZb([In] object obj0) => (object) ((UIViewItemParams) obj0).PartMetadata;

    internal static object nP68lFzuKgnq6dNWEue([In] object obj0) => (object) ((FormPartMetadata) obj0).View;

    internal static object qg0OyZzIpfDJfZrSlZI([In] object obj0) => (object) UIViewItemProvider.ParseViewItemId((string) obj0);

    internal static void PPGno4zVMwcuqZWqDmM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

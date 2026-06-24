// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.UIViewItemParams
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Services
{
  /// <summary>
  /// Параметры представления для провайдеров <see cref="T:EleWise.ELMA.UI.Services.UIDynamicFormProvider" /> и <see cref="T:EleWise.ELMA.UI.Services.UIViewItemProvider" />
  /// </summary>
  public class UIViewItemParams
  {
    private string[] _items;
    internal static UIViewItemParams HCldXZsg9tslInwV2YO;

    public UIViewItemParams()
    {
      UIViewItemParams.Mr74mfsYKGNtGKvCMIT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Разобрать параметры, указанные в <paramref name="viewItemId" />
    /// </summary>
    /// <param name="viewItemId"></param>
    public UIViewItemParams(string viewItemId)
    {
      UIViewItemParams.Mr74mfsYKGNtGKvCMIT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num1 = 0;
      Guid descriptorUid;
      Guid partUid;
      while (true)
      {
        int num2;
        Guid metadataType;
        switch (num1)
        {
          case 1:
            if (this.PartMetadata == null)
            {
              num2 = 10;
              break;
            }
            goto label_6;
          case 2:
            this._items = (string[]) UIViewItemParams.QqLNh4ssPFQDVnJAcmu((object) viewItemId, (object) new char[1]
            {
              ';'
            });
            num2 = 4;
            break;
          case 3:
            partUid = new Guid(this._items[2]);
            num1 = 11;
            continue;
          case 4:
            UIViewItemParams.UnNP6WscwpchGTerX4J(this._items.Length >= 3, (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411248619) + (object) 3));
            num1 = 6;
            continue;
          case 5:
            if (this.FormDescriptor != null)
            {
              num1 = 7;
              continue;
            }
            goto label_4;
          case 6:
            metadataType = new Guid(this._items[0]);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 8 : 5;
            continue;
          case 7:
            this.PartMetadata = (FormPartMetadata) UIViewItemParams.X5S8s0cBdh1UqV8WvuE(UIViewItemParams.tkc4FfcFlohdStQjpEY((object) this.FormDescriptor), partUid);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
            continue;
          case 8:
            descriptorUid = new Guid(this._items[1]);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 2 : 3;
            continue;
          case 9:
            goto label_4;
          case 10:
            goto label_10;
          case 11:
            this.FormDescriptor = Locator.GetServiceNotNull<FormDescriptorProvider>().GetDescriptor(metadataType, descriptorUid);
            num1 = 5;
            continue;
          default:
            UIViewItemParams.RByrQ0sU2nJ1S6lPQuC((object) viewItemId, UIViewItemParams.hTu9lpsL3Zr8qdrm6E1(1461625753 ^ 1461613625));
            num1 = 2;
            continue;
        }
        num1 = num2;
      }
label_4:
      throw new InvalidOperationException((string) UIViewItemParams.MbZlpRszOUM7d06yyZi(UIViewItemParams.hTu9lpsL3Zr8qdrm6E1(647913418 ^ 647923732), (object) descriptorUid));
label_6:
      return;
label_10:
      throw new InvalidOperationException(string.Format((string) UIViewItemParams.hTu9lpsL3Zr8qdrm6E1(-441065788 ^ -2092910478 ^ 1727381126), (object) partUid, UIViewItemParams.nR5SGTcWAoUq51W2PgE(UIViewItemParams.tkc4FfcFlohdStQjpEY((object) this.FormDescriptor))));
    }

    /// <summary>Метаданные формы</summary>
    public FormDescriptor FormDescriptor
    {
      get => this.\u003CFormDescriptor\u003Ek__BackingField;
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
              this.\u003CFormDescriptor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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

    /// <summary>Метаданные части формы</summary>
    public FormPartMetadata PartMetadata
    {
      get => this.\u003CPartMetadata\u003Ek__BackingField;
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
              this.\u003CPartMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
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

    /// <summary>Формирует строковое представление параметров</summary>
    /// <returns></returns>
    public override string ToString()
    {
      int num1 = 2;
      List<object> items;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.AddItems(items);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          case 2:
            items = new List<object>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      object separator = UIViewItemParams.hTu9lpsL3Zr8qdrm6E1(1597012150 ^ 1596992618);
      List<object> source = items;
      // ISSUE: reference to a compiler-generated field
      Func<object, string> func = UIViewItemParams.\u003C\u003Ec.\u003C\u003E9__10_0;
      Func<object, string> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        UIViewItemParams.\u003C\u003Ec.\u003C\u003E9__10_0 = selector = (Func<object, string>) (i =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (i != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
                  continue;
                }
                goto label_2;
              case 2:
                goto label_2;
              default:
                goto label_3;
            }
          }
label_2:
          return "";
label_3:
          return i.ToString();
        });
      }
      else
        goto label_5;
label_7:
      IEnumerable<string> values = source.Select<object, string>(selector);
      return string.Join((string) separator, values);
label_5:
      selector = func;
      goto label_7;
    }

    /// <summary>Разобранные элементы</summary>
    protected string[] Items => this._items;

    /// <summary>
    /// Общее количество параметров, разбираемых текущим классом параметров, а также всех родительских
    /// </summary>
    protected virtual int TotalItemsCount => 3;

    /// <summary>
    /// Добавить в список <paramref name="items" /> параметры, использумые для генерации строкового представления
    /// </summary>
    /// <param name="items"></param>
    protected virtual void AddItems(List<object> items)
    {
      items.Add((object) (this.FormDescriptor != null ? this.FormDescriptor.Metadata.GetTypeUid() : Guid.Empty));
      items.Add((object) (this.FormDescriptor != null ? this.FormDescriptor.Uid : Guid.Empty));
      items.Add((object) (this.PartMetadata != null ? this.PartMetadata.Uid : Guid.Empty));
    }

    internal static void Mr74mfsYKGNtGKvCMIT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool fgGC8ys5jFsGKZoasot() => UIViewItemParams.HCldXZsg9tslInwV2YO == null;

    internal static UIViewItemParams gD1HTYsjOk3QtlLXScp() => UIViewItemParams.HCldXZsg9tslInwV2YO;

    internal static object hTu9lpsL3Zr8qdrm6E1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void RByrQ0sU2nJ1S6lPQuC([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static object QqLNh4ssPFQDVnJAcmu([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static void UnNP6WscwpchGTerX4J(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object MbZlpRszOUM7d06yyZi([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object tkc4FfcFlohdStQjpEY([In] object obj0) => (object) ((FormDescriptor) obj0).Metadata;

    internal static object X5S8s0cBdh1UqV8WvuE([In] object obj0, Guid partUid) => (object) ((FormMetadata) obj0).GetPart(partUid);

    internal static object nR5SGTcWAoUq51W2PgE([In] object obj0) => (object) ((NamedMetadata) obj0).Name;
  }
}

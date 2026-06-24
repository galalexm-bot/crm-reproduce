// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.PortletViewItemParams
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.UI.Services
{
  /// <summary>
  /// Параметры представления портлета для провайдеров <see cref="T:EleWise.ELMA.UI.Services.PortletDynamicFormProvider" /> и <see cref="T:EleWise.ELMA.UI.Services.PortletViewItemProvider" />
  /// </summary>
  public class PortletViewItemParams : UIViewItemParams
  {
    private static PortletViewItemParams DlINjWsA4pwRqGtjB1x;

    public PortletViewItemParams()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public PortletViewItemParams(string viewItemId)
    {
      PortletViewItemParams.DJYQK8s0ICwtb6KvQcE();
      // ISSUE: explicit constructor call
      base.\u002Ector(viewItemId);
      int num1 = 6;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
        num1 = 2;
      int totalItemsCount;
      string str1;
      int num2;
      string str2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            str1 = this.Items[totalItemsCount + 4];
            num1 = 3;
            continue;
          case 2:
            this.InstanceId = new Guid(this.Items[totalItemsCount + 3]);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
            continue;
          case 3:
            this.Path = !PortletViewItemParams.cUXvHxslLpjkou8IVOj((object) str1) ? ((Encoding) PortletViewItemParams.uZpcjBsr8DN6s12RDJe()).GetString((byte[]) PortletViewItemParams.PBwOTEs9lJYDg2EdhfP((object) str1)) : "";
            num1 = 9;
            continue;
          case 4:
            this.PortletId = new Guid(this.Items[totalItemsCount + 2]);
            num1 = 2;
            continue;
          case 5:
            PortletViewItemParams.rn626osMGTMRRkmWhka(this.Items.Length >= num2, PortletViewItemParams.jdvQoDsycD8BZmja8SA(PortletViewItemParams.QDJ62SsmQWNlBTFKOji(381945751 ^ 1158627804 ^ 1405849911), (object) num2));
            num1 = 8;
            continue;
          case 6:
            totalItemsCount = base.TotalItemsCount;
            num1 = 10;
            continue;
          case 7:
            this.PortletManagerPath = string.IsNullOrEmpty(str2) ? "" : (string) PortletViewItemParams.cfvMjSsdRVDWIiJQcJ2((object) Encoding.UTF8, PortletViewItemParams.PBwOTEs9lJYDg2EdhfP((object) str2));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 4 : 2;
            continue;
          case 8:
            PortletViewItemParams.fvBvA8sJZSkT7xlKm5p((object) this.Items[totalItemsCount]);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 9:
            goto label_12;
          case 10:
            num2 = totalItemsCount + 5;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 5;
            continue;
          default:
            str2 = this.Items[totalItemsCount + 1];
            num1 = 7;
            continue;
        }
      }
label_12:;
    }

    /// <summary>
    /// Целочисленное значение перечисления PersonalizationScope
    /// </summary>
    public int PortletManagerScope
    {
      get => this.\u003CPortletManagerScope\u003Ek__BackingField;
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
              this.\u003CPortletManagerScope\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    /// <summary>Параметр 'path' для</summary>
    public string PortletManagerPath
    {
      get => this.\u003CPortletManagerPath\u003Ek__BackingField;
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
              this.\u003CPortletManagerPath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

    /// <summary>Id портлета</summary>
    public Guid PortletId
    {
      get => this.\u003CPortletId\u003Ek__BackingField;
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
              this.\u003CPortletId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
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

    /// <summary>Id экземпляра портлета</summary>
    public Guid InstanceId
    {
      get => this.\u003CInstanceId\u003Ek__BackingField;
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
              this.\u003CInstanceId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
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

    /// <summary>Путь настроек</summary>
    public string Path
    {
      get => this.\u003CPath\u003Ek__BackingField;
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
              this.\u003CPath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
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

    protected override int TotalItemsCount => base.TotalItemsCount;

    protected override void AddItems(List<object> items)
    {
      base.AddItems(items);
      items.Add((object) this.PortletManagerScope);
      items.Add(!string.IsNullOrEmpty(this.PortletManagerPath) ? (object) this.PortletManagerPath.ToBase64String() : (object) "");
      items.Add((object) this.PortletId);
      items.Add((object) this.InstanceId);
      items.Add(!string.IsNullOrEmpty(this.Path) ? (object) this.Path.ToBase64String() : (object) "");
    }

    internal static bool TpR2JDs7WyLRbnkUtmC() => PortletViewItemParams.DlINjWsA4pwRqGtjB1x == null;

    internal static PortletViewItemParams vJV0SXsxqCSgdsa0LHb() => PortletViewItemParams.DlINjWsA4pwRqGtjB1x;

    internal static void DJYQK8s0ICwtb6KvQcE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object QDJ62SsmQWNlBTFKOji(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object jdvQoDsycD8BZmja8SA([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static void rn626osMGTMRRkmWhka(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static int fvBvA8sJZSkT7xlKm5p([In] object obj0) => int.Parse((string) obj0);

    internal static object PBwOTEs9lJYDg2EdhfP([In] object obj0) => (object) Convert.FromBase64String((string) obj0);

    internal static object cfvMjSsdRVDWIiJQcJ2([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);

    internal static bool cUXvHxslLpjkou8IVOj([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object uZpcjBsr8DN6s12RDJe() => (object) Encoding.UTF8;
  }
}

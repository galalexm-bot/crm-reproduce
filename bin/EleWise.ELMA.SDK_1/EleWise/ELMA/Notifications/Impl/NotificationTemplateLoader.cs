// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationTemplateLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Стандартный загрузчик шаблонов оповещений</summary>
  [Component(Order = 100000)]
  public class NotificationTemplateLoader : INotificationTemplateLoader, IInitHandler, IDisposable
  {
    private readonly FileSystemWatcher watcher;
    private string templatesPath;
    private DateTime lastRootLoaded;
    private bool needReloadTemplates;
    private bool initialized;
    private DateTime lastLoaded;
    private Dictionary<string, DateTime> lastTemplateLoaded;
    private Dictionary<string, NotificationTemplateFileInfo> notificationFileInfos;
    private List<NotificationTemplate> templates;
    private List<NotificationPartialExtensionTemplate> extensionTemplates;
    private List<NotificationTemplate> defaultTemplates;
    private List<CustomMessage> customMessages;
    private static NotificationTemplateLoader LS6W7s4hlHMu0BmJCaO;

    /// <summary>Запущенное приложение</summary>
    public IRuntimeApplication RuntimeApplication
    {
      get => this.\u003CRuntimeApplication\u003Ek__BackingField;
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
              this.\u003CRuntimeApplication\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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

    /// <summary>Истчники шаблонов оповещений</summary>
    public IEnumerable<INotificationTemplateDataSource> DataSources { get; set; }

    /// <summary>
    /// Получить шаблоны, которые могут быть использованы для указанного события оповещения.
    /// </summary>
    /// <param name="notification">Оповещение.</param>
    /// <returns>Список шаблонов</returns>
    public virtual IEnumerable<INotificationTemplate> GetTemplates(INotification notification)
    {
      if (!this.initialized)
        return (IEnumerable<INotificationTemplate>) new INotificationTemplate[0];
      this.CheckTemplates();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (IEnumerable<INotificationTemplate>) ((IEnumerable<NotificationTemplate>) ((object) this.templates ?? (object) new NotificationTemplate[0])).Where<NotificationTemplate>((Func<NotificationTemplate, bool>) (t => NotificationTemplateLoader.\u003C\u003Ec.Sj83imflc2ColasxvEZ0(NotificationTemplateLoader.\u003C\u003Ec.uadgc8flsSUH3JUNwEwf((object) t)))).Select<NotificationTemplate, NotificationTemplateBase>((Func<NotificationTemplate, NotificationTemplateBase>) (t => this.CheckTemplate(t, notification))).Where<NotificationTemplateBase>((Func<NotificationTemplateBase, bool>) (t => t != null)).ToList<NotificationTemplateBase>();
    }

    /// <summary>
    /// Получить частичные шаблоны оповещений для зоны расширения в шаблоне
    /// </summary>
    /// <param name="zone">Имя зоны расширения</param>
    /// <returns>Список частичных шаблонов</returns>
    public virtual IEnumerable<INotificationPartialTemplate> GetExtensionTemplates(string zone)
    {
      if (!this.initialized)
        return (IEnumerable<INotificationPartialTemplate>) new INotificationPartialTemplate[0];
      this.CheckTemplates();
      return (IEnumerable<INotificationPartialTemplate>) ((IEnumerable<NotificationPartialExtensionTemplate>) ((object) this.extensionTemplates ?? (object) new NotificationPartialExtensionTemplate[0])).Where<NotificationPartialExtensionTemplate>((Func<NotificationPartialExtensionTemplate, bool>) (t =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (t.Zones == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        return t.Zones.Contains(zone);
label_5:
        return false;
      })).Cast<INotificationPartialTemplate>().ToList<INotificationPartialTemplate>();
    }

    /// <summary>Получить шаблон по умолчанию</summary>
    /// <param name="currentFileInfo">Текущий файл шаблонов</param>
    /// <param name="name">Имя шаблона по умолчанию (если в имени есть слэш, то ищется в указанном файле - например, Tasks.Task/Default)</param>
    /// <returns></returns>
    public virtual NotificationTemplate GetDefaultTemplate(
      NotificationTemplateFileInfo currentFileInfo,
      string name)
    {
      int num1 = 14;
      NotificationTemplateFileInfo templateFileInfo;
      string name1;
      string templateName;
      while (true)
      {
        int num2 = num1;
        int num3;
        string key;
        while (true)
        {
          int num4;
          switch (num2)
          {
            case 1:
            case 11:
              goto label_11;
            case 2:
              if (num3 >= 0)
              {
                if (num3 > 0)
                {
                  num2 = 10;
                  continue;
                }
                goto label_18;
              }
              else
              {
                num2 = 9;
                continue;
              }
            case 3:
              goto label_18;
            case 4:
              if (!NotificationTemplateLoader.gPUbjT4vxK0PKbOkMo8((object) templateName, (object) string.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 11 : 11;
                continue;
              }
              goto case 8;
            case 5:
              templateName = num3 >= NotificationTemplateLoader.Oa5EhP4Q1ZlU1UBINoX((object) name1) - 1 ? "" : (string) NotificationTemplateLoader.dplOjV4CRrLiIub3wpI((object) name1, num3 + 1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            case 6:
              if (name1 == null)
              {
                num2 = 12;
                continue;
              }
              num4 = name1.IndexOf('/');
              break;
            case 7:
              goto label_3;
            case 8:
              templateName = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
              continue;
            case 9:
              if (currentFileInfo == null)
              {
                num2 = 7;
                continue;
              }
              goto label_4;
            case 10:
              goto label_26;
            case 12:
              num4 = -1;
              break;
            case 13:
              name1 = name;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 6 : 1;
              continue;
            case 14:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 10 : 13;
              continue;
            default:
              if (this.notificationFileInfos.TryGetValue(key, out templateFileInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 4;
                continue;
              }
              goto label_12;
          }
          num3 = num4;
          num2 = 2;
        }
label_18:
        object obj = (object) "";
        goto label_27;
label_26:
        obj = NotificationTemplateLoader.gE2rxr4f1VDEH6YnrDP((object) name1, 0, num3);
label_27:
        key = (string) obj;
        num1 = 5;
      }
label_3:
      return (NotificationTemplate) null;
label_4:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return currentFileInfo.DefaultTemplates.FirstOrDefault<NotificationTemplate>((Func<NotificationTemplate, bool>) (dt => NotificationTemplateLoader.\u003C\u003Ec__DisplayClass10_0.SmdGkUfrf4bPuu7eSD9p(NotificationTemplateLoader.\u003C\u003Ec__DisplayClass10_0.e9Y6A1frE54R7JaoejvF((object) dt), (object) name1)));
label_11:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return templateFileInfo.DefaultTemplates.FirstOrDefault<NotificationTemplate>((Func<NotificationTemplate, bool>) (dt => NotificationTemplateLoader.\u003C\u003Ec__DisplayClass10_0.SmdGkUfrf4bPuu7eSD9p(NotificationTemplateLoader.\u003C\u003Ec__DisplayClass10_0.e9Y6A1frE54R7JaoejvF((object) dt), (object) templateName)));
label_12:
      return (NotificationTemplate) null;
    }

    /// <summary>Получить частичный шаблон</summary>
    /// <param name="currentFileInfo">Текущий файл шаблонов</param>
    /// <param name="name">Имя шаблона (если в имени есть слэш, то ищется в указанном файле - например, Tasks.Task/Default)</param>
    /// <returns></returns>
    public virtual NotificationPartialTemplate GetPartialTemplate(
      NotificationTemplateFileInfo currentFileInfo,
      string name)
    {
      int num1 = 3;
      NotificationTemplateFileInfo templateFileInfo;
      string name1;
      string templateName;
      while (true)
      {
        int num2 = num1;
        string key;
        while (true)
        {
          int num3;
          object obj;
          int num4;
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              name1 = name;
              num2 = 15;
              continue;
            case 3:
              num2 = 2;
              continue;
            case 4:
              obj = (object) "";
              goto label_27;
            case 5:
              goto label_11;
            case 6:
              if (currentFileInfo == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 1;
                continue;
              }
              goto label_14;
            case 7:
              goto label_20;
            case 8:
              templateName = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 5 : 7;
              continue;
            case 9:
              num4 = -1;
              break;
            case 10:
              if (num3 <= 0)
                goto case 4;
              else
                goto label_16;
            case 11:
              goto label_21;
            case 12:
              goto label_9;
            case 13:
              obj = NotificationTemplateLoader.gE2rxr4f1VDEH6YnrDP((object) name1, 0, num3);
              goto label_27;
            case 14:
              if (num3 >= 0)
              {
                num2 = 10;
                continue;
              }
              goto case 6;
            case 15:
              if (name1 == null)
              {
                num2 = 9;
                continue;
              }
              num4 = NotificationTemplateLoader.q35Kel48Hc05ZdORl0D((object) name1, '/');
              break;
            default:
              templateName = num3 >= NotificationTemplateLoader.Oa5EhP4Q1ZlU1UBINoX((object) name1) - 1 ? "" : (string) NotificationTemplateLoader.dplOjV4CRrLiIub3wpI((object) name1, num3 + 1);
              num2 = 5;
              continue;
          }
          num3 = num4;
          num2 = 14;
          continue;
label_27:
          key = (string) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
        }
label_9:
        if (NotificationTemplateLoader.gPUbjT4vxK0PKbOkMo8((object) templateName, (object) string.Empty))
        {
          num1 = 8;
          continue;
        }
        goto label_20;
label_11:
        if (!this.notificationFileInfos.TryGetValue(key, out templateFileInfo))
        {
          num1 = 11;
          continue;
        }
        goto label_9;
label_16:
        num1 = 13;
      }
label_13:
      return (NotificationPartialTemplate) null;
label_14:
      // ISSUE: reference to a compiler-generated method
      return currentFileInfo.Partials.FirstOrDefault<NotificationPartialTemplate>((Func<NotificationPartialTemplate, bool>) (dt => NotificationTemplateLoader.\u003C\u003Ec__DisplayClass11_0.Bdxa6xfrZ1Fk9ATNeeWY((object) dt.Name, (object) name1)));
label_20:
      return templateFileInfo.Partials.FirstOrDefault<NotificationPartialTemplate>((Func<NotificationPartialTemplate, bool>) (dt => dt.Name == templateName));
label_21:
      return (NotificationPartialTemplate) null;
    }

    /// <summary>Начало инициализации</summary>
    public void Init()
    {
    }

    /// <summary>
    /// Завершение инициализации - здесь производится копирование шаблонов в файловую систему
    /// </summary>
    public void InitComplete()
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        IEnumerator<INotificationTemplateDataSource> enumerator1;
        string path1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (NotificationTemplateLoader.rEYKQt4ZjViYyWPnbtt((object) this.RuntimeApplication) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                continue;
              }
              goto label_43;
            case 2:
label_56:
              this.watcher.Path = this.templatesPath;
              num2 = 4;
              continue;
            case 3:
            case 12:
              enumerator1 = this.DataSources.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 11;
              continue;
            case 4:
              NotificationTemplateLoader.v204Ho4k2m6WeHc51DR((object) this.watcher, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 14 : 9;
              continue;
            case 5:
              goto label_50;
            case 6:
              if (NotificationTemplateLoader.lOZT7B4SujEYk3NUPiB((object) this.templatesPath))
              {
                num2 = 3;
                continue;
              }
              goto case 15;
            case 7:
              if (this.RuntimeApplication == null)
              {
                num2 = 13;
                continue;
              }
              goto case 1;
            case 8:
              goto label_48;
            case 9:
              goto label_55;
            case 10:
              goto label_51;
            case 11:
              try
              {
label_28:
                if (NotificationTemplateLoader.muyrH94XZyHpov9Xaeu((object) enumerator1))
                  goto label_27;
                else
                  goto label_29;
label_12:
                IEnumerable<NotificationTemplateFileInfo> files;
                IEnumerator<NotificationTemplateFileInfo> enumerator2;
                INotificationTemplateDataSource current1;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_28;
                    case 2:
label_30:
                      if (files != null)
                      {
                        num3 = 3;
                        continue;
                      }
                      goto label_28;
                    case 3:
                      enumerator2 = files.GetEnumerator();
                      num3 = 5;
                      continue;
                    case 4:
                      try
                      {
                        files = current1.GetFiles();
                        int num4 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
                          num4 = 0;
                        switch (num4)
                        {
                          default:
                            goto label_30;
                        }
                      }
                      catch (Exception ex)
                      {
                        int num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
                          num5 = 0;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              goto label_28;
                            default:
                              NotificationTemplateLoader.jQrJAF4qpcddGCXPLgX((object) Logger.Log, NotificationTemplateLoader.ku4Bjy4RBgnKwpEvMIm((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312833799), (object) current1.GetType().FullName), (object) ex);
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
                              continue;
                          }
                        }
                      }
                    case 5:
                      goto label_14;
                    case 6:
                      goto label_56;
                    default:
                      goto label_27;
                  }
                }
label_14:
                try
                {
label_17:
                  if (NotificationTemplateLoader.muyrH94XZyHpov9Xaeu((object) enumerator2))
                    goto label_19;
                  else
                    goto label_18;
label_15:
                  NotificationTemplateFileInfo current2;
                  int num6;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        NotificationTemplateLoader.bL8e3u4K3hmBKn9fQU6((object) this, (object) current2);
                        num6 = 3;
                        continue;
                      case 2:
                        goto label_28;
                      case 3:
                        goto label_17;
                      default:
                        goto label_19;
                    }
                  }
label_18:
                  num6 = 2;
                  goto label_15;
label_19:
                  current2 = enumerator2.Current;
                  num6 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
                  {
                    num6 = 1;
                    goto label_15;
                  }
                  else
                    goto label_15;
                }
                finally
                {
                  if (enumerator2 != null)
                  {
                    int num7 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
                      num7 = 0;
                    while (true)
                    {
                      switch (num7)
                      {
                        case 1:
                          goto label_26;
                        default:
                          NotificationTemplateLoader.XKiUm64Tg0E7qMd6y6U((object) enumerator2);
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 0;
                          continue;
                      }
                    }
                  }
label_26:;
                }
label_27:
                current1 = enumerator1.Current;
                num3 = 4;
                goto label_12;
label_29:
                num3 = 6;
                goto label_12;
              }
              finally
              {
                int num8;
                if (enumerator1 == null)
                  num8 = 2;
                else
                  goto label_44;
label_41:
                switch (num8)
                {
                  case 1:
                  case 2:
                }
label_44:
                NotificationTemplateLoader.XKiUm64Tg0E7qMd6y6U((object) enumerator1);
                num8 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
                {
                  num8 = 1;
                  goto label_41;
                }
                else
                  goto label_41;
              }
            case 13:
              goto label_42;
            case 14:
              this.initialized = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 8 : 10;
              continue;
            case 15:
              NotificationTemplateLoader.FH5Qgp4iRAFZNKVQ5kG((object) this.templatesPath);
              num2 = 12;
              continue;
            default:
              path1 = (string) NotificationTemplateLoader.qVtwgx4Il76svkK8Aw0((object) ((System.Configuration.Configuration) NotificationTemplateLoader.pLugl84uRylQhn84D0F(NotificationTemplateLoader.rEYKQt4ZjViYyWPnbtt((object) this.RuntimeApplication))).FilePath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 9 : 6;
              continue;
          }
        }
label_48:
        if (this.DataSources != null)
        {
          num1 = 7;
          continue;
        }
        goto label_47;
label_55:
        this.templatesPath = Path.Combine(path1, (string) NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(589593376 ^ -1977315327 ^ -1459591549));
        num1 = 6;
      }
label_50:
      return;
label_51:
      return;
label_42:
      return;
label_47:
      return;
label_43:;
    }

    /// <summary>Dispose</summary>
    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            NotificationTemplateLoader.FGYea74nyNOUqy7Z7EJ((object) this.watcher);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Ctor</summary>
    public NotificationTemplateLoader()
    {
      NotificationTemplateLoader.yM8W1m4OFSEj8tUjUe2();
      this.needReloadTemplates = true;
      this.lastLoaded = DateTime.MinValue;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
            NotificationTemplateLoader.eATWvX42g29sKd9aJlv((object) fileSystemWatcher, NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.CreationTime);
            NotificationTemplateLoader.MOhx9G4eXNKPQVhAxxY((object) fileSystemWatcher, NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(-1380439818 << 3 ^ 1841416604));
            fileSystemWatcher.IncludeSubdirectories = true;
            this.watcher = fileSystemWatcher;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 3;
            continue;
          case 2:
            this.watcher.Deleted += new FileSystemEventHandler(this.WatcherOnChanged);
            num = 5;
            continue;
          case 3:
            NotificationTemplateLoader.bOo7v84PFbc8V0E6SRv((object) this.watcher, (object) new FileSystemEventHandler(this.WatcherOnChanged));
            num = 4;
            continue;
          case 4:
            NotificationTemplateLoader.uDJMeD41nwcnONeRyVp((object) this.watcher, (object) new FileSystemEventHandler(this.WatcherOnChanged));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 2 : 1;
            continue;
          case 5:
            NotificationTemplateLoader.p5XDS74NmG8HU0ZySyC((object) this.watcher, (object) new RenamedEventHandler(this.WatcherOnChanged));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:;
    }

    /// <summary>
    /// Проверить, есть ли обновление указанного шаблона. Если есть - сохранить или заменить файл
    /// </summary>
    /// <param name="fileInfo">Информация о файле шаблонов оповещений</param>
    protected virtual void CheckTemplateFileInfo(NotificationTemplateFileInfo fileInfo)
    {
      switch (1)
      {
        case 1:
          try
          {
            int num1;
            if (!NotificationTemplateLoader.lOZT7B4SujEYk3NUPiB((object) this.templatesPath))
              num1 = 11;
            else
              goto label_21;
label_3:
            string path1;
            string path2;
            string str1;
            Version version1;
            string path3;
            Version version2;
            string filename;
            string str2;
            string str3;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  goto label_57;
                case 1:
                case 8:
                  str3 = Path.Combine(this.templatesPath, (string) NotificationTemplateLoader.qMEC6K4po8AI9wBe780((object) fileInfo) + (string) NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(-1146510045 ^ -1146541203));
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 30 : 21;
                  continue;
                case 2:
                  version2 = (Version) null;
                  num1 = 35;
                  continue;
                case 3:
                  goto label_21;
                case 4:
                case 5:
                  path1 = (string) NotificationTemplateLoader.O6sjHa4D5WOAMyvRytj((object) path2, NotificationTemplateLoader.aR2dDi4a19s9qgF6tC1(NotificationTemplateLoader.qMEC6K4po8AI9wBe780((object) fileInfo), NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(-710283084 ^ -537863435 ^ 173646863)));
                  num1 = 23;
                  continue;
                case 6:
                  goto label_50;
                case 7:
                case 24:
                  NotificationTemplateLoader.puYhYO4AJKoRYsp7d07((object) str3, (object) path1);
                  num1 = 20;
                  continue;
                case 9:
                  if (Directory.Exists(path3))
                  {
                    num1 = 34;
                    continue;
                  }
                  goto case 32;
                case 10:
                  NotificationTemplateLoader.FH5Qgp4iRAFZNKVQ5kG((object) str2);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
                  continue;
                case 11:
                  NotificationTemplateLoader.FH5Qgp4iRAFZNKVQ5kG((object) this.templatesPath);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 3;
                  continue;
                case 12:
                  NotificationTemplateLoader.FH5Qgp4iRAFZNKVQ5kG((object) path2);
                  num1 = 4;
                  continue;
                case 13:
                case 34:
                  filename = (string) NotificationTemplateLoader.O6sjHa4D5WOAMyvRytj((object) path3, NotificationTemplateLoader.aR2dDi4a19s9qgF6tC1(NotificationTemplateLoader.qMEC6K4po8AI9wBe780((object) fileInfo), NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(1199946765 ^ 1199911491)));
                  num1 = 36;
                  continue;
                case 14:
                case 33:
                  path2 = (string) NotificationTemplateLoader.O6sjHa4D5WOAMyvRytj((object) str2, NotificationTemplateLoader.HSbQWp4HThcBwBReTMF((object) version2, (object) null) ? (object) version2.ToString() : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672089099));
                  num1 = 28;
                  continue;
                case 15:
                case 21:
                  NotificationTemplateLoader.DdPoUX47S2nLbvggK6U(NotificationTemplateLoader.syFJjB44tEhEWJywNVq((object) fileInfo), (object) str3);
                  num1 = 41;
                  continue;
                case 16:
                  fileInfo.Version = version1;
                  num1 = 29;
                  continue;
                case 17:
                  NotificationTemplateLoader.I7sXvl4wm0Au3Hui6hy((object) filename);
                  num1 = 18;
                  continue;
                case 18:
                case 26:
                  ((XmlDocument) NotificationTemplateLoader.syFJjB44tEhEWJywNVq((object) fileInfo)).Save(filename);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 19 : 17;
                  continue;
                case 19:
                  str2 = (string) NotificationTemplateLoader.O6sjHa4D5WOAMyvRytj((object) this.templatesPath, NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(-342626196 - 1290888215 ^ -1633549809));
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 16 : 31;
                  continue;
                case 20:
                  str1 = (string) NotificationTemplateLoader.O6sjHa4D5WOAMyvRytj((object) this.templatesPath, NotificationTemplateLoader.aR2dDi4a19s9qgF6tC1(NotificationTemplateLoader.qMEC6K4po8AI9wBe780((object) fileInfo), NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(-675505729 ^ -675539109)));
                  num1 = 40;
                  continue;
                case 22:
                  File.Delete(path1);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 24 : 5;
                  continue;
                case 23:
                  if (!NotificationTemplateLoader.F7SpWa4tf1xlR9Vk5gt((object) path1))
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 7 : 2;
                    continue;
                  }
                  goto case 22;
                case 25:
                case 37:
                  NotificationTemplateLoader.DdPoUX47S2nLbvggK6U(NotificationTemplateLoader.syFJjB44tEhEWJywNVq((object) fileInfo), (object) str3);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                  continue;
                case 27:
                  if (version2.Equals(version1))
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 3 : 6;
                    continue;
                  }
                  goto case 14;
                case 28:
                  if (Directory.Exists(path2))
                  {
                    num1 = 5;
                    continue;
                  }
                  goto case 12;
                case 29:
                  path3 = (string) NotificationTemplateLoader.pLso0143vBSMT792mUw((object) this.templatesPath, NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(-1822890472 ^ -1822922718), (object) version1.ToString());
                  num1 = 9;
                  continue;
                case 30:
                  if (!File.Exists(str3))
                  {
                    num1 = 15;
                    continue;
                  }
                  goto case 2;
                case 31:
                  if (NotificationTemplateLoader.lOZT7B4SujEYk3NUPiB((object) str2))
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 8;
                    continue;
                  }
                  goto case 10;
                case 32:
                  NotificationTemplateLoader.FH5Qgp4iRAFZNKVQ5kG((object) path3);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 3 : 13;
                  continue;
                case 35:
                  try
                  {
                    XmlDocument document = new XmlDocument();
                    int num2 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
                      num2 = 1;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 1:
                          document.Load(str3);
                          num2 = 2;
                          continue;
                        case 2:
                          version2 = new NotificationTemplateFileInfo((string) NotificationTemplateLoader.qMEC6K4po8AI9wBe780((object) fileInfo), document).Version;
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_32;
                      }
                    }
                  }
                  catch (Exception ex)
                  {
                    int num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                      num3 = 0;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          goto label_32;
                        default:
                          ((ILogger) NotificationTemplateLoader.G25PIE46HIbxaEMo2PG()).Error(NotificationTemplateLoader.ku4Bjy4RBgnKwpEvMIm(NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(~210725948 ^ -210756185), (object) str3), ex);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
                          continue;
                      }
                    }
                  }
                case 36:
                  if (!NotificationTemplateLoader.F7SpWa4tf1xlR9Vk5gt((object) filename))
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 9 : 26;
                    continue;
                  }
                  goto case 17;
                case 38:
                  NotificationTemplateLoader.I7sXvl4wm0Au3Hui6hy((object) str1);
                  num1 = 37;
                  continue;
                case 39:
label_32:
                  if (version2 == (Version) null)
                  {
                    num1 = 33;
                    continue;
                  }
                  goto case 27;
                case 40:
                  if (!NotificationTemplateLoader.F7SpWa4tf1xlR9Vk5gt((object) str1))
                  {
                    num1 = 25;
                    continue;
                  }
                  goto case 38;
                case 41:
                  goto label_46;
                default:
                  goto label_44;
              }
            }
label_57:
            break;
label_50:
            break;
label_46:
            break;
label_44:
            break;
label_21:
            version1 = VersionInfo.GetVersion<EleWise.ELMA.SR>();
            num1 = 16;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
            {
              num1 = 1;
              goto label_3;
            }
            else
              goto label_3;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_38;
                default:
                  NotificationTemplateLoader.jQrJAF4qpcddGCXPLgX(NotificationTemplateLoader.G25PIE46HIbxaEMo2PG(), NotificationTemplateLoader.ku4Bjy4RBgnKwpEvMIm((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727391814), (object) fileInfo.Name), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
                  continue;
              }
            }
label_38:
            break;
          }
      }
    }

    /// <summary>
    /// Проверить, есть ли изменения в файлах шаблонов. Если есть - перезагрузить.
    /// </summary>
    /// <param name="directory">Папка шаблонов</param>
    protected virtual void CheckFiles(DirectoryInfo directory)
    {
      int num1 = 25;
      Dictionary<NotificationTemplate, List<CustomMessage>>.Enumerator enumerator1;
      while (true)
      {
        int num2 = num1;
        Dictionary<NotificationTemplate, List<CustomMessage>> dictionary;
        IEnumerator<NotificationPartialExtensionTemplate> enumerator2;
        NotificationTemplateFileInfo templateFileInfo1;
        IEnumerator<NotificationTemplate> enumerator3;
        IEnumerator<CustomMessage> enumerator4;
        while (true)
        {
          FileInfo fileInfo;
          string str;
          FileInfo[] fileInfoArray;
          XmlDocument document;
          NotificationTemplateFileInfo templateFileInfo2;
          int index;
          switch (num2)
          {
            case 1:
label_138:
              this.notificationFileInfos.Add(str, templateFileInfo2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 11 : 3;
              continue;
            case 2:
              try
              {
                NotificationTemplateLoader.xiNRsZ4ddtwET8yOuvp((object) templateFileInfo2, (object) this);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_138;
                }
              }
              catch (Exception ex)
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      NotificationTemplateLoader.jQrJAF4qpcddGCXPLgX((object) Logger.Log, NotificationTemplateLoader.ku4Bjy4RBgnKwpEvMIm(NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(1033719030 - 2012070891 ^ -978385189), NotificationTemplateLoader.O7Lk4149UecZWaw9rmU((object) fileInfo)), (object) ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_123;
                  }
                }
              }
            case 3:
label_77:
              enumerator3 = templateFileInfo2.DefaultTemplates.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 9 : 16;
              continue;
            case 4:
label_141:
              num2 = 2;
              continue;
            case 5:
              index = 0;
              num2 = 33;
              continue;
            case 6:
              goto label_16;
            case 7:
              try
              {
label_34:
                if (NotificationTemplateLoader.muyrH94XZyHpov9Xaeu((object) enumerator2))
                  goto label_36;
                else
                  goto label_35;
label_32:
                NotificationPartialExtensionTemplate current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      this.extensionTemplates.Remove(current);
                      num5 = 3;
                      continue;
                    case 2:
                      goto label_36;
                    case 3:
                      goto label_34;
                    default:
                      goto label_172;
                  }
                }
label_35:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
                goto label_32;
label_36:
                current = enumerator2.Current;
                num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
                {
                  num5 = 1;
                  goto label_32;
                }
                else
                  goto label_32;
              }
              finally
              {
                if (enumerator2 != null)
                {
                  int num6 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
                    num6 = 0;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        enumerator2.Dispose();
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_43;
                    }
                  }
                }
label_43:;
              }
            case 8:
              if (this.lastTemplateLoaded.ContainsKey(str))
              {
                num2 = 41;
                continue;
              }
              goto case 20;
            case 9:
              goto label_90;
            case 10:
label_172:
              enumerator3 = templateFileInfo1.DefaultTemplates.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 29 : 29;
              continue;
            case 11:
              enumerator3 = templateFileInfo2.Templates.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 37;
              continue;
            case 13:
            case 33:
              if (index >= fileInfoArray.Length)
              {
                num2 = 36;
                continue;
              }
              goto case 43;
            case 14:
              try
              {
label_164:
                if (NotificationTemplateLoader.muyrH94XZyHpov9Xaeu((object) enumerator4))
                  goto label_163;
                else
                  goto label_165;
label_161:
                CustomMessage current;
                int num7;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_163;
                    case 2:
                      this.customMessages.Remove(current);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 3;
                      continue;
                    case 3:
                      goto label_164;
                    default:
                      goto label_140;
                  }
                }
label_163:
                current = enumerator4.Current;
                num7 = 2;
                goto label_161;
label_165:
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
                goto label_161;
              }
              finally
              {
                int num8;
                if (enumerator4 == null)
                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
                else
                  goto label_169;
label_168:
                switch (num8)
                {
                  case 2:
                    break;
                  default:
                }
label_169:
                enumerator4.Dispose();
                num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
                {
                  num8 = 0;
                  goto label_168;
                }
                else
                  goto label_168;
              }
            case 15:
              dictionary = new Dictionary<NotificationTemplate, List<CustomMessage>>();
              num2 = 30;
              continue;
            case 16:
              try
              {
label_112:
                if (NotificationTemplateLoader.muyrH94XZyHpov9Xaeu((object) enumerator3))
                  goto label_114;
                else
                  goto label_113;
label_111:
                NotificationTemplate current;
                int num9;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      goto label_86;
                    case 2:
                      goto label_112;
                    case 3:
                      goto label_114;
                    default:
                      this.defaultTemplates.Add(current);
                      num9 = 2;
                      continue;
                  }
                }
label_113:
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
                goto label_111;
label_114:
                current = enumerator3.Current;
                num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
                {
                  num9 = 0;
                  goto label_111;
                }
                else
                  goto label_111;
              }
              finally
              {
                int num10;
                if (enumerator3 == null)
                  num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                else
                  goto label_120;
label_119:
                switch (num10)
                {
                  case 1:
                    break;
                  default:
                }
label_120:
                enumerator3.Dispose();
                num10 = 2;
                goto label_119;
              }
            case 17:
label_122:
              enumerator4 = templateFileInfo1.CustomMessages.GetEnumerator();
              num2 = 14;
              continue;
            case 18:
              str = (string) NotificationTemplateLoader.ltFw8x4yyaV0rggrEva(NotificationTemplateLoader.FTXAwJ4mxZ9MvLcoAhB((object) fileInfo));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 7 : 8;
              continue;
            case 19:
label_140:
              this.notificationFileInfos.Remove(str);
              num2 = 27;
              continue;
            case 20:
              this.lastTemplateLoaded[str] = fileInfo.LastWriteTime;
              num2 = 38;
              continue;
            case 21:
              enumerator3 = templateFileInfo1.Templates.GetEnumerator();
              num2 = 26;
              continue;
            case 22:
              goto label_66;
            case 23:
              goto label_65;
            case 24:
              fileInfoArray = (FileInfo[]) NotificationTemplateLoader.lhCATO40AnpPbUgNxVm((object) directory, NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(~-306453669 ^ 306483848));
              num2 = 5;
              continue;
            case 25:
              NotificationTemplateLoader.yQWgaw4x6rMgYrQhp9l((object) directory, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633549461));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 16 : 24;
              continue;
            case 26:
              goto label_145;
            case 27:
              document = new XmlDocument();
              num2 = 39;
              continue;
            case 28:
label_174:
              enumerator2 = templateFileInfo2.ExtensionTemplates.GetEnumerator();
              num2 = 35;
              continue;
            case 29:
              try
              {
label_177:
                if (enumerator3.MoveNext())
                  goto label_179;
                else
                  goto label_178;
label_176:
                NotificationTemplate current;
                int num11;
                while (true)
                {
                  switch (num11)
                  {
                    case 1:
                      goto label_179;
                    case 2:
                      goto label_122;
                    case 3:
                      this.defaultTemplates.Remove(current);
                      num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_177;
                  }
                }
label_178:
                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 2 : 2;
                goto label_176;
label_179:
                current = enumerator3.Current;
                num11 = 3;
                goto label_176;
              }
              finally
              {
                int num12;
                if (enumerator3 == null)
                  num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 2;
                else
                  goto label_187;
label_184:
                switch (num12)
                {
                  case 1:
                  case 2:
                }
label_187:
                NotificationTemplateLoader.XKiUm64Tg0E7qMd6y6U((object) enumerator3);
                num12 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
                {
                  num12 = 0;
                  goto label_184;
                }
                else
                  goto label_184;
              }
            case 30:
              List<CustomMessage> customMessages = this.customMessages;
              // ISSUE: reference to a compiler-generated field
              Func<CustomMessage, bool> func = NotificationTemplateLoader.\u003C\u003Ec.\u003C\u003E9__17_0;
              Func<CustomMessage, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                NotificationTemplateLoader.\u003C\u003Ec.\u003C\u003E9__17_0 = predicate = (Func<CustomMessage, bool>) (cm => cm != null);
              }
              else
                goto label_194;
label_193:
              enumerator4 = customMessages.Where<CustomMessage>(predicate).GetEnumerator();
              num2 = 9;
              continue;
label_194:
              predicate = func;
              goto label_193;
            case 31:
              goto label_191;
            case 32:
label_144:
              num2 = 34;
              continue;
            case 34:
              try
              {
                templateFileInfo2 = new NotificationTemplateFileInfo(str, document);
                int num13 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
                  num13 = 0;
                switch (num13)
                {
                  default:
                    goto label_141;
                }
              }
              catch (Exception ex)
              {
                int num14 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
                  num14 = 0;
                while (true)
                {
                  switch (num14)
                  {
                    case 1:
                      goto label_123;
                    default:
                      NotificationTemplateLoader.jQrJAF4qpcddGCXPLgX(NotificationTemplateLoader.G25PIE46HIbxaEMo2PG(), (object) string.Format((string) NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(-1824388195 ^ -1824357347), NotificationTemplateLoader.O7Lk4149UecZWaw9rmU((object) fileInfo)), (object) ex);
                      num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
            case 35:
              try
              {
label_20:
                if (NotificationTemplateLoader.muyrH94XZyHpov9Xaeu((object) enumerator2))
                  goto label_23;
                else
                  goto label_21;
label_19:
                NotificationPartialExtensionTemplate current;
                int num15;
                while (true)
                {
                  switch (num15)
                  {
                    case 1:
                      goto label_20;
                    case 2:
                      goto label_77;
                    case 3:
                      goto label_23;
                    default:
                      this.extensionTemplates.Add(current);
                      num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
                      continue;
                  }
                }
label_21:
                num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 2;
                goto label_19;
label_23:
                current = enumerator2.Current;
                num15 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
                {
                  num15 = 0;
                  goto label_19;
                }
                else
                  goto label_19;
              }
              finally
              {
                int num16;
                if (enumerator2 == null)
                  num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                else
                  goto label_28;
label_27:
                switch (num16)
                {
                  case 2:
                    break;
                  default:
                }
label_28:
                NotificationTemplateLoader.XKiUm64Tg0E7qMd6y6U((object) enumerator2);
                num16 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
                {
                  num16 = 1;
                  goto label_27;
                }
                else
                  goto label_27;
              }
            case 36:
              if (this.customMessages.Any<CustomMessage>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 15 : 15;
                continue;
              }
              goto label_186;
            case 37:
              try
              {
label_130:
                if (NotificationTemplateLoader.muyrH94XZyHpov9Xaeu((object) enumerator3))
                  goto label_129;
                else
                  goto label_131;
label_127:
                NotificationTemplate current;
                int num17;
                while (true)
                {
                  switch (num17)
                  {
                    case 1:
                      goto label_129;
                    case 2:
                      this.templates.Add(current);
                      num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 3;
                      continue;
                    case 3:
                      goto label_130;
                    default:
                      goto label_174;
                  }
                }
label_129:
                current = enumerator3.Current;
                num17 = 2;
                goto label_127;
label_131:
                num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                goto label_127;
              }
              finally
              {
                if (enumerator3 != null)
                {
                  int num18 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                    num18 = 0;
                  while (true)
                  {
                    switch (num18)
                    {
                      case 1:
                        goto label_137;
                      default:
                        enumerator3.Dispose();
                        num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
                        continue;
                    }
                  }
                }
label_137:;
              }
            case 38:
              if (this.notificationFileInfos.TryGetValue(str, out templateFileInfo1))
              {
                num2 = 21;
                continue;
              }
              goto case 27;
            case 39:
              try
              {
                document.Load((string) NotificationTemplateLoader.O7Lk4149UecZWaw9rmU((object) fileInfo));
                int num19 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
                  num19 = 0;
                switch (num19)
                {
                  default:
                    goto label_144;
                }
              }
              catch (Exception ex)
              {
                int num20 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
                  num20 = 0;
                while (true)
                {
                  switch (num20)
                  {
                    case 1:
                      goto label_123;
                    default:
                      NotificationTemplateLoader.jQrJAF4qpcddGCXPLgX(NotificationTemplateLoader.G25PIE46HIbxaEMo2PG(), NotificationTemplateLoader.ku4Bjy4RBgnKwpEvMIm(NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(516838154 ^ 516873310), NotificationTemplateLoader.O7Lk4149UecZWaw9rmU((object) fileInfo)), (object) ex);
                      num20 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
                      continue;
                  }
                }
              }
            case 40:
label_86:
              enumerator4 = templateFileInfo2.CustomMessages.GetEnumerator();
              num2 = 42;
              continue;
            case 41:
              if (!NotificationTemplateLoader.Cu4bOZ4JGU7v3eFEkki(this.lastTemplateLoaded[str], NotificationTemplateLoader.uTIlgZ4Mkp0P8M3Lxop((object) fileInfo)))
              {
                num2 = 12;
                continue;
              }
              goto case 20;
            case 42:
              try
              {
label_47:
                if (NotificationTemplateLoader.muyrH94XZyHpov9Xaeu((object) enumerator4))
                  goto label_50;
                else
                  goto label_48;
label_46:
                CustomMessage current;
                int num21;
                while (true)
                {
                  switch (num21)
                  {
                    case 1:
                      this.customMessages.Add(current);
                      num21 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_50;
                    case 3:
                      goto label_123;
                    default:
                      goto label_47;
                  }
                }
label_48:
                num21 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 3;
                goto label_46;
label_50:
                current = enumerator4.Current;
                num21 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
                {
                  num21 = 1;
                  goto label_46;
                }
                else
                  goto label_46;
              }
              finally
              {
                if (enumerator4 != null)
                {
                  int num22 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                    num22 = 0;
                  while (true)
                  {
                    switch (num22)
                    {
                      case 1:
                        goto label_57;
                      default:
                        NotificationTemplateLoader.XKiUm64Tg0E7qMd6y6U((object) enumerator4);
                        num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_57:;
              }
            case 43:
              fileInfo = fileInfoArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 6 : 18;
              continue;
          }
label_123:
          ++index;
          num2 = 13;
        }
label_16:
        enumerator1 = dictionary.GetEnumerator();
        num1 = 22;
        continue;
label_65:
        enumerator2 = templateFileInfo1.ExtensionTemplates.GetEnumerator();
        num1 = 7;
        continue;
label_90:
        try
        {
label_99:
          if (enumerator4.MoveNext())
            goto label_94;
          else
            goto label_100;
label_91:
          NotificationTemplate key;
          CustomMessage current;
          int num23;
          CustomMessage message;
          while (true)
          {
            switch (num23)
            {
              case 1:
                goto label_94;
              case 2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                key = this.templates.FirstOrDefault<NotificationTemplate>((Func<NotificationTemplate, bool>) (t => NotificationTemplateLoader.\u003C\u003Ec__DisplayClass17_0.usnZAdfrTvH3J82h6HUg(NotificationTemplateLoader.\u003C\u003Ec__DisplayClass17_0.jbS6XRfrXboOWURBse92(NotificationTemplateLoader.\u003C\u003Ec__DisplayClass17_0.NdZoLcfrRv60sZlCEwbB(NotificationTemplateLoader.\u003C\u003Ec__DisplayClass17_0.vZGpI9friHNjFcZ4SyPq((object) t)), NotificationTemplateLoader.\u003C\u003Ec__DisplayClass17_0.sOlrxTfrqECPcYpfAQHy(1642859704 ^ 1642883304), NotificationTemplateLoader.\u003C\u003Ec__DisplayClass17_0.FuAk1vfrKT8xeIEoaHoA((object) t)), (object) message.Key.First, StringComparison.CurrentCultureIgnoreCase)));
                num23 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 9;
                continue;
              case 4:
                message = current;
                num23 = 2;
                continue;
              case 6:
                dictionary.Add(key, new List<CustomMessage>()
                {
                  current
                });
                num23 = 3;
                continue;
              case 7:
                dictionary[key].Add(current);
                num23 = 5;
                continue;
              case 8:
                if (dictionary.ContainsKey(key))
                {
                  num23 = 7;
                  continue;
                }
                goto case 6;
              case 9:
                if (key == null)
                {
                  num23 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                  continue;
                }
                goto case 8;
              case 10:
                num23 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 4 : 3;
                continue;
              case 11:
                goto label_16;
              default:
                goto label_99;
            }
          }
label_94:
          current = enumerator4.Current;
          num23 = 10;
          goto label_91;
label_100:
          num23 = 11;
          goto label_91;
        }
        finally
        {
          int num24;
          if (enumerator4 == null)
            num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
          else
            goto label_107;
label_106:
          switch (num24)
          {
            case 2:
              break;
            default:
          }
label_107:
          NotificationTemplateLoader.XKiUm64Tg0E7qMd6y6U((object) enumerator4);
          num24 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
          {
            num24 = 0;
            goto label_106;
          }
          else
            goto label_106;
        }
label_145:
        try
        {
label_150:
          if (NotificationTemplateLoader.muyrH94XZyHpov9Xaeu((object) enumerator3))
            goto label_147;
          else
            goto label_151;
label_146:
          NotificationTemplate current;
          int num25;
          while (true)
          {
            switch (num25)
            {
              case 1:
                goto label_150;
              case 2:
                this.templates.Remove(current);
                num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
                continue;
              case 3:
                goto label_147;
              default:
                goto label_65;
            }
          }
label_147:
          current = enumerator3.Current;
          num25 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
          {
            num25 = 2;
            goto label_146;
          }
          else
            goto label_146;
label_151:
          num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
          goto label_146;
        }
        finally
        {
          int num26;
          if (enumerator3 == null)
            num26 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 2;
          else
            goto label_155;
label_154:
          switch (num26)
          {
            case 1:
              break;
            default:
          }
label_155:
          NotificationTemplateLoader.XKiUm64Tg0E7qMd6y6U((object) enumerator3);
          num26 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
          {
            num26 = 0;
            goto label_154;
          }
          else
            goto label_154;
        }
      }
label_191:
      return;
label_186:
      return;
label_66:
      try
      {
label_69:
        if (enumerator1.MoveNext())
          goto label_71;
        else
          goto label_70;
label_67:
        KeyValuePair<NotificationTemplate, List<CustomMessage>> current;
        int num27;
        while (true)
        {
          switch (num27)
          {
            case 0:
              goto label_185;
            case 1:
              goto label_71;
            case 2:
              current.Key.SetCustomMessages((CustomMessage[]) NotificationTemplateLoader.aZujkA4lMI4RRdZ9Naf((object) current.Value));
              num27 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 3 : 2;
              continue;
            case 3:
              goto label_69;
            default:
              goto label_181;
          }
        }
label_185:
        return;
label_181:
        return;
label_70:
        num27 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
        goto label_67;
label_71:
        current = enumerator1.Current;
        num27 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        {
          num27 = 0;
          goto label_67;
        }
        else
          goto label_67;
      }
      finally
      {
        enumerator1.Dispose();
        int num28 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
          num28 = 0;
        switch (num28)
        {
          default:
        }
      }
    }

    /// <summary>Проверить наличие изменений в шаблонах</summary>
    protected virtual void CheckTemplates()
    {
      int num1 = 3;
      NotificationTemplateLoader notificationTemplateLoader;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_33;
          case 3:
            if (this.initialized)
            {
              notificationTemplateLoader = this;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_36;
          default:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 1;
            continue;
        }
      }
label_33:
      return;
label_36:
      return;
label_2:
      try
      {
        Monitor.Enter((object) notificationTemplateLoader, ref lockTaken);
        int num2 = 13;
        DirectoryInfo directoryInfo;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_28;
            case 1:
              this.notificationFileInfos = (Dictionary<string, NotificationTemplateFileInfo>) null;
              num2 = 3;
              continue;
            case 2:
              if (this.lastRootLoaded < NotificationTemplateLoader.uTIlgZ4Mkp0P8M3Lxop((object) directoryInfo))
              {
                num2 = 6;
                continue;
              }
              goto case 10;
            case 3:
              this.templates = (List<NotificationTemplate>) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 9 : 7;
              continue;
            case 4:
              this.lastRootLoaded = NotificationTemplateLoader.uTIlgZ4Mkp0P8M3Lxop((object) directoryInfo);
              num2 = 10;
              continue;
            case 5:
              if (!NotificationTemplateLoader.lOZT7B4SujEYk3NUPiB((object) this.templatesPath))
              {
                num2 = 7;
                continue;
              }
              goto case 16;
            case 6:
              this.lastLoaded = DateTime.MinValue;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 20 : 5;
              continue;
            case 7:
              NotificationTemplateLoader.NqVTiB4r4xT5uEw6UF1((object) this.notificationFileInfos);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 12 : 14;
              continue;
            case 8:
              goto label_13;
            case 9:
              this.extensionTemplates = (List<NotificationPartialExtensionTemplate>) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 11;
              continue;
            case 10:
              NotificationTemplateLoader.waDk8G4jUQGrmd257dU((object) this, (object) directoryInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 8 : 8;
              continue;
            case 11:
              this.defaultTemplates = (List<NotificationTemplate>) null;
              num2 = 4;
              continue;
            case 12:
              goto label_7;
            case 13:
              if (this.needReloadTemplates)
              {
                num2 = 18;
                continue;
              }
              goto label_17;
            case 14:
              NotificationTemplateLoader.YHxZX54gfSDX8mXCXMp((object) this.templates);
              num2 = 15;
              continue;
            case 15:
              NotificationTemplateLoader.Ja9ZYh45R37h4xdCJl5((object) this.extensionTemplates);
              num2 = 17;
              continue;
            case 16:
              directoryInfo = new DirectoryInfo(this.templatesPath);
              num2 = 2;
              continue;
            case 17:
              NotificationTemplateLoader.YHxZX54gfSDX8mXCXMp((object) this.defaultTemplates);
              num2 = 12;
              continue;
            case 18:
            case 19:
              this.needReloadTemplates = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 4 : 5;
              continue;
            case 20:
              this.lastTemplateLoaded = (Dictionary<string, DateTime>) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
              continue;
            default:
              goto label_4;
          }
        }
label_28:
        return;
label_13:
        return;
label_7:
        return;
label_4:
        return;
label_17:;
      }
      finally
      {
        if (lockTaken)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                Monitor.Exit((object) notificationTemplateLoader);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                continue;
              default:
                goto label_35;
            }
          }
        }
label_35:;
      }
    }

    /// <summary>Проверить наличие изменений в шаблонах</summary>
    /// <param name="directory">Папка с шаблонами</param>
    protected virtual void CheckTemplates(DirectoryInfo directory)
    {
      int num1 = 7;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
          case 3:
            this.customMessages = new List<CustomMessage>();
            num1 = 8;
            continue;
          case 2:
label_7:
            if (this.customMessages != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 3 : 5;
              continue;
            }
            goto case 1;
          case 4:
            goto label_20;
          case 5:
          case 8:
            NotificationTemplateLoader.PDX9Dw4LjarbltN14YA((object) this, (object) directory);
            num1 = 4;
            continue;
          case 6:
            goto label_3;
          case 7:
            if (this.initialized)
            {
              if (!NotificationTemplateLoader.H2IPCh4YTUpGpqgcWrq(this.lastLoaded, DateTime.MinValue))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
                continue;
              }
              num2 = 1;
              break;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 6 : 6;
            continue;
          default:
            num2 = NotificationTemplateLoader.Cu4bOZ4JGU7v3eFEkki(this.lastLoaded, NotificationTemplateLoader.uTIlgZ4Mkp0P8M3Lxop((object) directory)) ? 1 : 0;
            break;
        }
        if (num2 != 0 || this.lastTemplateLoaded == null)
          this.lastTemplateLoaded = new Dictionary<string, DateTime>();
        if (num2 != 0 || this.notificationFileInfos == null)
          this.notificationFileInfos = new Dictionary<string, NotificationTemplateFileInfo>();
        if (num2 != 0 || this.templates == null)
          this.templates = new List<NotificationTemplate>();
        if (num2 != 0 || this.extensionTemplates == null)
          this.extensionTemplates = new List<NotificationPartialExtensionTemplate>();
        if (num2 != 0 || this.defaultTemplates == null)
          this.defaultTemplates = new List<NotificationTemplate>();
        if (num2 != 0 || NotificationTemplateLoader.H2IPCh4YTUpGpqgcWrq(this.lastLoaded, DateTime.MinValue))
          this.lastLoaded = directory.LastWriteTime;
        if (num2 != 0)
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 3 : 2;
        else
          goto label_7;
      }
label_20:
      return;
label_3:;
    }

    private void WatcherOnChanged(object sender, FileSystemEventArgs args)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.needReloadTemplates = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private NotificationTemplateBase CheckTemplate(
      NotificationTemplate t,
      INotification notification)
    {
      return this.CheckTemplate((NotificationTemplateBase) t, (NotificationTemplateBase) NotificationTemplateLoader.KbyGlj4U60VIJRJWspe((object) t), notification);
    }

    private NotificationTemplateBase CheckTemplate(
      NotificationTemplateBase t,
      NotificationTemplateBase def,
      INotification notification)
    {
      int num1 = 5;
      NotificationTemplateBase notificationTemplateBase1;
      List<NotificationTemplate>.Enumerator enumerator;
      string name;
      NotificationTemplateBase t2;
      string fullName;
      while (true)
      {
        switch (num1)
        {
          case 1:
            fullName = (string) NotificationTemplateLoader.qMEC6K4po8AI9wBe780(NotificationTemplateLoader.lccpFL4cl053FIJnPPw((object) t2)) + (string) NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(-1255365154 ^ 596875508 ^ -1765844614) + t2.Name;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 3 : 8;
            continue;
          case 2:
            goto label_9;
          case 3:
            goto label_2;
          case 4:
            t2 = t;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          case 5:
            num1 = 4;
            continue;
          case 6:
            if (notificationTemplateBase1 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 7 : 7;
              continue;
            }
            name = (string) (NotificationTemplateLoader.bNE8tq4sdfvRkWcy8MJ((object) t2) ?? (object) string.Empty);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
            continue;
          case 7:
            goto label_24;
          case 8:
            enumerator = ((NotificationTemplateFileInfo) NotificationTemplateLoader.lccpFL4cl053FIJnPPw((object) t2)).Templates.Where<NotificationTemplate>((Func<NotificationTemplate, bool>) (t1 =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (!NotificationTemplateLoader.\u003C\u003Ec__DisplayClass34_0.sERYZffrPFymXQTw1fOx(NotificationTemplateLoader.\u003C\u003Ec__DisplayClass34_0.lu6N7ifreyrQg3WHCRm8((object) t1), (object) name))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_4;
                  case 2:
                    goto label_4;
                  default:
                    goto label_5;
                }
              }
label_4:
              return t1 != t2;
label_5:
              return false;
            })).Union<NotificationTemplate>(this.templates.Where<NotificationTemplate>((Func<NotificationTemplate, bool>) (t1 =>
            {
              int num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (NotificationTemplateLoader.\u003C\u003Ec__DisplayClass34_0.U6lnrAfr1jkxoyV37IO9((object) t1) != NotificationTemplateLoader.\u003C\u003Ec__DisplayClass34_0.U6lnrAfr1jkxoyV37IO9((object) t2))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return NotificationTemplateLoader.\u003C\u003Ec__DisplayClass34_0.sERYZffrPFymXQTw1fOx(NotificationTemplateLoader.\u003C\u003Ec__DisplayClass34_0.lu6N7ifreyrQg3WHCRm8((object) t1), (object) fullName);
label_3:
              return false;
            }))).ToList<NotificationTemplate>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 2;
            continue;
          default:
            notificationTemplateBase1 = this.CheckTemplateWithDefault(t2, def, notification);
            num1 = 6;
            continue;
        }
      }
label_2:
      return notificationTemplateBase1;
label_9:
      NotificationTemplateBase notificationTemplateBase2;
      try
      {
label_11:
        if (enumerator.MoveNext())
          goto label_15;
        else
          goto label_12;
label_10:
        NotificationTemplateWrapper t3;
        int num4;
        while (true)
        {
          NotificationTemplateBase notificationTemplateBase3;
          switch (num4)
          {
            case 1:
              if (notificationTemplateBase3 == null)
              {
                num4 = 4;
                continue;
              }
              break;
            case 2:
            case 4:
              goto label_11;
            case 3:
              goto label_2;
            case 5:
              notificationTemplateBase3 = this.CheckTemplate((NotificationTemplateBase) t3, def, notification);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 1;
              continue;
            case 6:
              goto label_15;
            case 7:
              goto label_3;
          }
          notificationTemplateBase2 = notificationTemplateBase3;
          num4 = 7;
        }
label_12:
        num4 = 3;
        goto label_10;
label_15:
        t3 = new NotificationTemplateWrapper((NotificationTemplateBase) enumerator.Current, t2);
        num4 = 5;
        goto label_10;
      }
      finally
      {
        enumerator.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
label_3:
      return notificationTemplateBase2;
label_24:
      return (NotificationTemplateBase) null;
    }

    private NotificationTemplateBase CheckTemplateWithDefault(
      NotificationTemplateBase t,
      NotificationTemplateBase def,
      INotification notification)
    {
      int num1 = 2;
      NotificationTemplateWrapper notificationTemplateWrapper;
      List<NotificationTemplate>.Enumerator enumerator;
      NotificationTemplateBase def1;
      while (true)
      {
        int num2 = num1;
        string name;
        string fullName;
        while (true)
        {
          switch (num2)
          {
            case 1:
              def1 = def;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_31;
            case 4:
              enumerator = ((NotificationTemplateFileInfo) NotificationTemplateLoader.lccpFL4cl053FIJnPPw((object) def1)).DefaultTemplates.Where<NotificationTemplate>((Func<NotificationTemplate, bool>) (dt =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (NotificationTemplateLoader.\u003C\u003Ec__DisplayClass35_0.ymBviffrDySaZtIf2mQK((object) dt.ParentName, (object) name))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_3;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return dt != def1;
label_3:
                return false;
              })).Union<NotificationTemplate>(this.defaultTemplates.Where<NotificationTemplate>((Func<NotificationTemplate, bool>) (dt =>
              {
                int num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (NotificationTemplateLoader.\u003C\u003Ec__DisplayClass35_0.AvvIZVfrt0Tcau6ktdLs((object) dt) != def1.FileInfo)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_3;
                    default:
                      goto label_2;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return NotificationTemplateLoader.\u003C\u003Ec__DisplayClass35_0.ymBviffrDySaZtIf2mQK(NotificationTemplateLoader.\u003C\u003Ec__DisplayClass35_0.RRkqsJfrwIWM1EkUbSqp((object) dt), (object) fullName);
label_3:
                return false;
              }))).ToList<NotificationTemplate>().GetEnumerator();
              num2 = 5;
              continue;
            case 5:
              goto label_5;
            case 6:
              goto label_29;
            case 7:
              fullName = (string) NotificationTemplateLoader.jbOItX6FwwZ2HoWy8yJ((object) def1.FileInfo.Name, NotificationTemplateLoader.KNLRfh4VHvHHNuvYdpj(-1426456882 ^ 2009939514 ^ -583752540), (object) name);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 4 : 0;
              continue;
            case 8:
              goto label_27;
            case 9:
              if (!NotificationTemplateLoader.XFyDOD4zbpQGTV3wUDT((object) notificationTemplateWrapper, (object) notification))
              {
                num2 = 3;
                continue;
              }
              name = (string) (NotificationTemplateLoader.bNE8tq4sdfvRkWcy8MJ((object) def1) ?? (object) string.Empty);
              num2 = 7;
              continue;
            case 10:
              goto label_25;
            case 11:
              goto label_23;
            default:
              if (def1 != null)
              {
                num2 = 6;
                continue;
              }
              goto label_23;
          }
        }
label_23:
        if (NotificationTemplateLoader.XFyDOD4zbpQGTV3wUDT((object) t, (object) notification))
        {
          num1 = 8;
          continue;
        }
        goto label_28;
label_29:
        notificationTemplateWrapper = new NotificationTemplateWrapper(t, def1);
        num1 = 9;
      }
label_5:
      NotificationTemplateBase notificationTemplateBase1;
      try
      {
label_9:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_10;
label_6:
        NotificationTemplateWrapper def2;
        NotificationTemplateBase notificationTemplateBase2;
        int num5;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_25;
            case 2:
              goto label_7;
            case 3:
              notificationTemplateBase1 = notificationTemplateBase2;
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 3 : 6;
              continue;
            case 4:
              if (notificationTemplateBase2 != null)
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 3 : 1;
                continue;
              }
              goto label_9;
            case 5:
              notificationTemplateBase2 = this.CheckTemplateWithDefault(t, (NotificationTemplateBase) def2, notification);
              num5 = 4;
              continue;
            case 6:
              goto label_26;
            default:
              goto label_9;
          }
        }
label_7:
        def2 = new NotificationTemplateWrapper((NotificationTemplateBase) enumerator.Current, def1);
        num5 = 5;
        goto label_6;
label_10:
        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 1;
        goto label_6;
      }
      finally
      {
        enumerator.Dispose();
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
          num6 = 0;
        switch (num6)
        {
          default:
        }
      }
label_26:
      return notificationTemplateBase1;
label_25:
      return (NotificationTemplateBase) notificationTemplateWrapper;
label_27:
      return t;
label_28:
      return (NotificationTemplateBase) null;
label_31:
      return (NotificationTemplateBase) null;
    }

    internal static bool TrK6we4G5Mqvl8COip8() => NotificationTemplateLoader.LS6W7s4hlHMu0BmJCaO == null;

    internal static NotificationTemplateLoader bnn8Wj4ErpmxG7LNKBS() => NotificationTemplateLoader.LS6W7s4hlHMu0BmJCaO;

    internal static object gE2rxr4f1VDEH6YnrDP([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static int Oa5EhP4Q1ZlU1UBINoX([In] object obj0) => ((string) obj0).Length;

    internal static object dplOjV4CRrLiIub3wpI([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static bool gPUbjT4vxK0PKbOkMo8([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static int q35Kel48Hc05ZdORl0D([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static object rEYKQt4ZjViYyWPnbtt([In] object obj0) => (object) ((IRuntimeApplication) obj0).Configuration;

    internal static object pLugl84uRylQhn84D0F([In] object obj0) => (object) ((RuntimeConfiguration) obj0).Config;

    internal static object qVtwgx4Il76svkK8Aw0([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object KNLRfh4VHvHHNuvYdpj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool lOZT7B4SujEYk3NUPiB([In] object obj0) => Directory.Exists((string) obj0);

    internal static object FH5Qgp4iRAFZNKVQ5kG([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object ku4Bjy4RBgnKwpEvMIm([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void jQrJAF4qpcddGCXPLgX([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void bL8e3u4K3hmBKn9fQU6([In] object obj0, [In] object obj1) => ((NotificationTemplateLoader) obj0).CheckTemplateFileInfo((NotificationTemplateFileInfo) obj1);

    internal static bool muyrH94XZyHpov9Xaeu([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void XKiUm64Tg0E7qMd6y6U([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void v204Ho4k2m6WeHc51DR([In] object obj0, [In] bool obj1) => ((FileSystemWatcher) obj0).EnableRaisingEvents = obj1;

    internal static void FGYea74nyNOUqy7Z7EJ([In] object obj0) => ((Component) obj0).Dispose();

    internal static void yM8W1m4OFSEj8tUjUe2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void eATWvX42g29sKd9aJlv([In] object obj0, [In] NotifyFilters obj1) => ((FileSystemWatcher) obj0).NotifyFilter = obj1;

    internal static void MOhx9G4eXNKPQVhAxxY([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Filter = (string) obj1;

    internal static void bOo7v84PFbc8V0E6SRv([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Changed += (FileSystemEventHandler) obj1;

    internal static void uDJMeD41nwcnONeRyVp([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Created += (FileSystemEventHandler) obj1;

    internal static void p5XDS74NmG8HU0ZySyC([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Renamed += (RenamedEventHandler) obj1;

    internal static object pLso0143vBSMT792mUw([In] object obj0, [In] object obj1, [In] object obj2) => (object) Path.Combine((string) obj0, (string) obj1, (string) obj2);

    internal static object qMEC6K4po8AI9wBe780([In] object obj0) => (object) ((NotificationTemplateFileInfo) obj0).Name;

    internal static object aR2dDi4a19s9qgF6tC1([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object O6sjHa4D5WOAMyvRytj([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool F7SpWa4tf1xlR9Vk5gt([In] object obj0) => File.Exists((string) obj0);

    internal static void I7sXvl4wm0Au3Hui6hy([In] object obj0) => File.Delete((string) obj0);

    internal static object syFJjB44tEhEWJywNVq([In] object obj0) => (object) ((NotificationTemplateFileInfo) obj0).Document;

    internal static object G25PIE46HIbxaEMo2PG() => (object) Logger.Log;

    internal static bool HSbQWp4HThcBwBReTMF([In] object obj0, [In] object obj1) => (Version) obj0 != (Version) obj1;

    internal static void puYhYO4AJKoRYsp7d07([In] object obj0, [In] object obj1) => File.Move((string) obj0, (string) obj1);

    internal static void DdPoUX47S2nLbvggK6U([In] object obj0, [In] object obj1) => ((XmlDocument) obj0).Save((string) obj1);

    internal static void yQWgaw4x6rMgYrQhp9l([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object lhCATO40AnpPbUgNxVm([In] object obj0, [In] object obj1) => (object) ((DirectoryInfo) obj0).GetFiles((string) obj1);

    internal static object FTXAwJ4mxZ9MvLcoAhB([In] object obj0) => (object) ((FileSystemInfo) obj0).Name;

    internal static object ltFw8x4yyaV0rggrEva([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static DateTime uTIlgZ4Mkp0P8M3Lxop([In] object obj0) => ((FileSystemInfo) obj0).LastWriteTime;

    internal static bool Cu4bOZ4JGU7v3eFEkki([In] DateTime obj0, [In] DateTime obj1) => obj0 < obj1;

    internal static object O7Lk4149UecZWaw9rmU([In] object obj0) => (object) ((FileSystemInfo) obj0).FullName;

    internal static void xiNRsZ4ddtwET8yOuvp([In] object obj0, [In] object obj1) => ((NotificationTemplateFileInfo) obj0).LoadTemplates((NotificationTemplateLoader) obj1);

    internal static object aZujkA4lMI4RRdZ9Naf([In] object obj0) => (object) ((List<CustomMessage>) obj0).ToArray();

    internal static void NqVTiB4r4xT5uEw6UF1([In] object obj0) => ((Dictionary<string, NotificationTemplateFileInfo>) obj0).Clear();

    internal static void YHxZX54gfSDX8mXCXMp([In] object obj0) => ((List<NotificationTemplate>) obj0).Clear();

    internal static void Ja9ZYh45R37h4xdCJl5([In] object obj0) => ((List<NotificationPartialExtensionTemplate>) obj0).Clear();

    internal static void waDk8G4jUQGrmd257dU([In] object obj0, [In] object obj1) => ((NotificationTemplateLoader) obj0).CheckTemplates((DirectoryInfo) obj1);

    internal static bool H2IPCh4YTUpGpqgcWrq([In] DateTime obj0, [In] DateTime obj1) => obj0 == obj1;

    internal static void PDX9Dw4LjarbltN14YA([In] object obj0, [In] object obj1) => ((NotificationTemplateLoader) obj0).CheckFiles((DirectoryInfo) obj1);

    internal static object KbyGlj4U60VIJRJWspe([In] object obj0) => (object) ((NotificationTemplate) obj0).Default;

    internal static object bNE8tq4sdfvRkWcy8MJ([In] object obj0) => (object) ((NotificationTemplateBase) obj0).Name;

    internal static object lccpFL4cl053FIJnPPw([In] object obj0) => (object) ((NotificationTemplateBase) obj0).FileInfo;

    internal static bool XFyDOD4zbpQGTV3wUDT([In] object obj0, [In] object obj1) => ((NotificationTemplateBase) obj0).CheckFilter((INotification) obj1);

    internal static object jbOItX6FwwZ2HoWy8yJ([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);
  }
}

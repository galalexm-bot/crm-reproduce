// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationTemplateEmbeddedDataSource
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>
  /// Абстрактный класс источника шаблонов, использующий встроенные ресурсы текущей сборки
  /// </summary>
  [Component]
  public abstract class NotificationTemplateEmbeddedDataSource : INotificationTemplateDataSource
  {
    private static NotificationTemplateEmbeddedDataSource VHVncGwihYWgPQixjOX;

    /// <summary>
    /// Получить список с информацией о файлах шаблонов оповещения
    /// </summary>
    /// <returns>Список с информацией о файлах шаблонов оповещения</returns>
    public IEnumerable<NotificationTemplateFileInfo> GetFiles()
    {
      string ns = this.Namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824386727);
      Assembly assembly = this.GetType().Assembly;
      IEnumerable<string> strings = ((IEnumerable<string>) assembly.GetManifestResourceNames()).Where<string>((Func<string, bool>) (n =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (!n.StartsWith(ns))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return NotificationTemplateEmbeddedDataSource.\u003C\u003Ec__DisplayClass0_0.NjoSKjfl0IliWV7CVUFM((object) n, NotificationTemplateEmbeddedDataSource.\u003C\u003Ec__DisplayClass0_0.IbeegnflxYd26AgccSie(--1360331293 ^ 1360366675));
label_3:
        return false;
      }));
      List<NotificationTemplateFileInfo> files = new List<NotificationTemplateFileInfo>();
      foreach (string name in strings)
      {
        XmlDocument document = new XmlDocument();
        using (Stream manifestResourceStream = assembly.GetManifestResourceStream(name))
        {
          try
          {
            document.Load(manifestResourceStream);
          }
          catch (Exception ex)
          {
            Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883316978), (object) name, (object) assembly.FullName), ex);
            continue;
          }
        }
        string withoutExtension = Path.GetFileNameWithoutExtension(name.Substring(ns.Length));
        try
        {
          NotificationTemplateFileInfo templateFileInfo = new NotificationTemplateFileInfo(withoutExtension, document);
          files.Add(templateFileInfo);
        }
        catch (Exception ex)
        {
          Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583775286), (object) name, (object) assembly.FullName), ex);
        }
      }
      return (IEnumerable<NotificationTemplateFileInfo>) files;
    }

    /// <summary>
    /// Пространство имен, в котором нужно искать ресурсы. По умолчанию используется пространство имен текущего класса.
    /// </summary>
    protected virtual string Namespace => this.GetType().Namespace;

    protected NotificationTemplateEmbeddedDataSource()
    {
      NotificationTemplateEmbeddedDataSource.IFDFDKwK5VvKV06PtE0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool mHLyLiwRRUiU3IaOv7b() => NotificationTemplateEmbeddedDataSource.VHVncGwihYWgPQixjOX == null;

    internal static NotificationTemplateEmbeddedDataSource xS01fVwqtyEQ3VB4y3I() => NotificationTemplateEmbeddedDataSource.VHVncGwihYWgPQixjOX;

    internal static void IFDFDKwK5VvKV06PtE0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

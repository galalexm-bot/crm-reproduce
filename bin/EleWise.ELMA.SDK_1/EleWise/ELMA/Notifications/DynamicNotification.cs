// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.DynamicNotification
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Dynamic;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Notifications
{
  /// <summary>Оповещение с дианмическими данными</summary>
  public class DynamicNotification : INotification, IExtendedPropertiesContainer
  {
    private Dictionary<string, object> data;
    internal static DynamicNotification o78l9saAhScObu9ij37;

    /// <summary>
    /// Имя шаблона оповещения. Может быть не указано. Тогда фильтрация шаблонов будет вестись по фильтру.
    /// </summary>
    public string TemplateName
    {
      get => this.\u003CTemplateName\u003Ek__BackingField;
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
              this.\u003CTemplateName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
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

    /// <summary>Данные по имени</summary>
    /// <param name="name">Имя объекта</param>
    /// <returns>Данные</returns>
    public object this[string name]
    {
      get => this.data[name];
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
              this.data[name] = value;
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

    /// <summary>Именованные объекты</summary>
    public IDictionary<string, object> ExtendedProperties => (IDictionary<string, object>) this.data;

    public DynamicNotification()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.data = new Dictionary<string, object>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool B7L29pa7XrXAXSLLSGS() => DynamicNotification.o78l9saAhScObu9ij37 == null;

    internal static DynamicNotification jLE2braxGc9SvPSJ9yD() => DynamicNotification.o78l9saAhScObu9ij37;
  }
}

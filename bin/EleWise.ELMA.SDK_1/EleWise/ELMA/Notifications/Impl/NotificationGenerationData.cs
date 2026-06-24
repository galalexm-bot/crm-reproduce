// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationGenerationData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Dynamic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Данные для генерации сообщения по оповещению</summary>
  public class NotificationGenerationData : IDynamicObject
  {
    private Dictionary<string, object> namedObjects;
    private static NotificationGenerationData WlaI2ttpauCMg3aDgmA;

    /// <summary>Ctor</summary>
    /// <param name="notification">Оповещение</param>
    public NotificationGenerationData(INotification notification)
    {
      NotificationGenerationData.GR7tAJttxYq6jCmnkuM();
      this.namedObjects = new Dictionary<string, object>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 5;
      PropertyInfo[] properties;
      int index;
      PropertyInfo propertyInfo;
      IExtendedPropertiesContainer propertiesContainer;
      IEnumerator<KeyValuePair<string, object>> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.namedObjects[(string) NotificationGenerationData.GqtsV8tAhdadocNAarF((object) propertyInfo)] = propertyInfo.GetValue((object) notification, (object[]) null);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 4 : 2;
            continue;
          case 2:
            goto label_35;
          case 3:
            index = 0;
            num1 = 10;
            continue;
          case 4:
          case 18:
            ++index;
            num1 = 12;
            continue;
          case 5:
            NotificationGenerationData.wUUx9vt4EC8LvSTVnij((object) notification, NotificationGenerationData.ujP3vJtwA4Edyr9qqSm(-244066886 - -48452443 ^ -195580133));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 9 : 8;
            continue;
          case 6:
            goto label_15;
          case 7:
            propertyInfo = properties[index];
            num1 = 8;
            continue;
          case 8:
            if (NotificationGenerationData.xbmpV7t6YOUv3fClEZE((object) propertyInfo))
            {
              num1 = 13;
              continue;
            }
            goto case 4;
          case 9:
            properties = notification.GetType().GetProperties();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 3;
            continue;
          case 10:
          case 12:
            if (index >= properties.Length)
            {
              num1 = 17;
              continue;
            }
            goto case 7;
          case 11:
            if (propertiesContainer.ExtendedProperties == null)
            {
              num1 = 16;
              continue;
            }
            goto case 15;
          case 13:
            if (NotificationGenerationData.RGki6StHvurkRk2Innt((object) propertyInfo).Length != 0)
            {
              num1 = 18;
              continue;
            }
            goto case 1;
          case 14:
            goto label_31;
          case 15:
            enumerator = propertiesContainer.ExtendedProperties.GetEnumerator();
            num1 = 6;
            continue;
          case 16:
            goto label_27;
          case 17:
            propertiesContainer = notification as IExtendedPropertiesContainer;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          default:
            if (propertiesContainer == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 14 : 11;
              continue;
            }
            goto case 11;
        }
      }
label_35:
      return;
label_31:
      return;
label_27:
      return;
label_15:
      try
      {
label_17:
        if (NotificationGenerationData.oUmtTQt7KofjquAJ2h3((object) enumerator))
          goto label_19;
        else
          goto label_18;
label_16:
        KeyValuePair<string, object> current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_17;
            case 2:
              goto label_19;
            case 3:
              goto label_22;
            default:
              this.namedObjects[current.Key] = current.Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
              continue;
          }
        }
label_22:
        return;
label_18:
        num2 = 3;
        goto label_16;
label_19:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        {
          num2 = 0;
          goto label_16;
        }
        else
          goto label_16;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                NotificationGenerationData.ewAuXUtxttMZ3CyVUOH((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
                continue;
              default:
                goto label_29;
            }
          }
        }
label_29:;
      }
    }

    /// <summary>Получить или установить значение свойства по имени</summary>
    /// <param name="name">Имя свойства</param>
    /// <returns></returns>
    public object this[string name]
    {
      get => this.namedObjects[name];
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
              this.namedObjects[name] = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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

    /// <summary>Содержит ли объект свойство с указанным именем</summary>
    /// <param name="name">Имя свойства</param>
    /// <param name="ignoreCase">Игнорировать регистр букв</param>
    /// <returns>True, если содержит</returns>
    public bool ContainsProperty(string name, bool ignoreCase = false) => this.namedObjects.ContainsKey(name);

    /// <summary>Получить значение свойства</summary>
    /// <param name="name">Имя свойства</param>
    /// <param name="ignoreCase">Игнорировать регистр букв</param>
    /// <returns>Значение свойства</returns>
    public object GetPropertyValue(string name, bool ignoreCase = false)
    {
      int num = 1;
      object propertyValue;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.namedObjects.TryGetValue(name, out propertyValue);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return propertyValue;
    }

    /// <summary>Установить значение свойства</summary>
    /// <param name="name">Имя свойства</param>
    /// <param name="value">Значение свойства</param>
    /// <param name="ignoreCase">Игнорировать регистр букв</param>
    public void SetPropertyValue(string name, object value, bool ignoreCase = false)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.namedObjects[name] = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void GR7tAJttxYq6jCmnkuM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object ujP3vJtwA4Edyr9qqSm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void wUUx9vt4EC8LvSTVnij([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool xbmpV7t6YOUv3fClEZE([In] object obj0) => ((PropertyInfo) obj0).CanRead;

    internal static object RGki6StHvurkRk2Innt([In] object obj0) => (object) ((PropertyInfo) obj0).GetIndexParameters();

    internal static object GqtsV8tAhdadocNAarF([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static bool oUmtTQt7KofjquAJ2h3([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void ewAuXUtxttMZ3CyVUOH([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool AlaWxxta1pSJnHLBG2d() => NotificationGenerationData.WlaI2ttpauCMg3aDgmA == null;

    internal static NotificationGenerationData FYK5HKtDR7wY0SWONYE() => NotificationGenerationData.WlaI2ttpauCMg3aDgmA;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.UserDefinedList.UDLDynamicObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.UserDefinedList
{
  /// <summary>Пользовательский список</summary>
  internal sealed class UDLDynamicObject : DynamicObject
  {
    private readonly Dictionary<string, object> properties;
    internal static UDLDynamicObject kGH9NHbQ4R8lynmDaenl;

    /// <summary>ctor</summary>
    /// <param name="props">Свойства</param>
    public UDLDynamicObject(Dictionary<string, object> props)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.properties = props;
    }

    /// <inheritdoc />
    public override IEnumerable<string> GetDynamicMemberNames() => (IEnumerable<string>) this.properties.Keys;

    /// <summary>Получить значение свойства по имени</summary>
    /// <param name="propertyName">имя свойства</param>
    /// <returns>Значения свойства, если оно существует</returns>
    public object TryGetValue(string propertyName)
    {
      int num1 = 3;
      object obj;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              obj = this.properties[propertyName];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
              continue;
            case 2:
              if (this.properties.ContainsKey(propertyName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
                continue;
              }
              goto label_5;
            case 3:
              goto label_3;
            default:
              goto label_5;
          }
        }
label_3:
        obj = (object) null;
        num1 = 2;
      }
label_5:
      return obj;
    }

    /// <summary>Удалить значение свойства по имени</summary>
    /// <param name="propertyName">имя свойства</param>
    public void RemoveValue(string propertyName)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.properties.Remove(propertyName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            if (this.properties.ContainsKey(propertyName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
              continue;
            }
            goto label_6;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      return;
label_6:;
    }

    /// <inheritdoc />
    public override bool TryGetMember(GetMemberBinder binder, out object result)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            result = this.properties[(string) UDLDynamicObject.BdT5m9bQAFUtHIQscZaH((object) binder)];
            num = 4;
            continue;
          case 2:
            result = (object) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 3:
            if (!this.properties.ContainsKey(binder.Name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 2;
              continue;
            }
            goto case 1;
          case 4:
            goto label_2;
          default:
            goto label_7;
        }
      }
label_2:
      return true;
label_7:
      return false;
    }

    /// <inheritdoc />
    public override bool TrySetMember(SetMemberBinder binder, object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.properties.ContainsKey((string) UDLDynamicObject.UZffKFbQ7NcNsw3YPTfS((object) binder)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_3;
          case 3:
            this.properties[(string) UDLDynamicObject.UZffKFbQ7NcNsw3YPTfS((object) binder)] = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 2;
            continue;
          default:
            goto label_4;
        }
      }
label_3:
      return true;
label_4:
      return false;
    }

    /// <inheritdoc />
    public void AddMember(string name, object value)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            goto label_2;
          case 3:
            if (this.properties.ContainsKey(name))
            {
              num = 2;
              continue;
            }
            break;
        }
        this.properties.Add(name, value);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
      }
label_4:
      return;
label_2:;
    }

    internal static bool oAHJ0ebQ6EKf6W6I4vXL() => UDLDynamicObject.kGH9NHbQ4R8lynmDaenl == null;

    internal static UDLDynamicObject OsvDURbQHOTmLvkRY6vi() => UDLDynamicObject.kGH9NHbQ4R8lynmDaenl;

    internal static object BdT5m9bQAFUtHIQscZaH([In] object obj0) => (object) ((GetMemberBinder) obj0).Name;

    internal static object UZffKFbQ7NcNsw3YPTfS([In] object obj0) => (object) ((SetMemberBinder) obj0).Name;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.LocalizedStringAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут, содержащий локализованную строку какого-либо свойства объекта метаданных
  /// </summary>
  public class LocalizedStringAttribute : System.ComponentModel.DescriptionAttribute
  {
    protected Type staticResourceType;
    protected string propertyName;
    private readonly string value;
    private bool containsKey;
    internal static LocalizedStringAttribute eqBaqioI0IP71LOjRkcB;

    public LocalizedStringAttribute(Type staticResourceType, string propertyName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.propertyName = propertyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
            continue;
          case 2:
            this.staticResourceType = staticResourceType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public LocalizedStringAttribute(string value)
    {
      LocalizedStringAttribute.pwaBDjoIM4k7b8gNa7x1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.containsKey = LocalizedStringAttribute.Rk2mZCoIJ22Yf19I0i25((object) value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 2:
            this.value = value ?? "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Значение для текущей культуры</summary>
    public string Value
    {
      get
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.containsKey)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 5;
                continue;
              }
              goto label_11;
            case 2:
              goto label_11;
            case 3:
              if (LocalizedStringAttribute.fUbOncoI9FeJML1BvYGa(this.staticResourceType, (Type) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                continue;
              }
              break;
            case 4:
              if (this.value == null)
              {
                num = 3;
                continue;
              }
              break;
            case 5:
              goto label_12;
            default:
              goto label_6;
          }
          if (this.value != null)
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
          else
            goto label_13;
        }
label_6:
        throw new NullReferenceException((string) LocalizedStringAttribute.VkJGJwoIdAUK4muTBMFp(2008901894 << 3 ^ -1108799206));
label_11:
        return this.value;
label_12:
        return EleWise.ELMA.SR.T(this.value);
label_13:
        PropertyInfo property = this.staticResourceType.GetProperty(this.propertyName);
        return !LocalizedStringAttribute.BXQj1WoIlV8o77hn0h8j((object) property, (object) null) ? (string) LocalizedStringAttribute.xfraoEoIgiXu3R2yxSgb((object) property, (object) null, (object) null) : throw new NullReferenceException((string) LocalizedStringAttribute.QbniODoIrrjW6rLQ8caR(LocalizedStringAttribute.VkJGJwoIdAUK4muTBMFp(372753449 ^ 372612525), (object) this.propertyName, (object) this.staticResourceType.FullName));
      }
    }

    public override string Description => this.Value;

    /// <summary>Локализуемая строка</summary>
    internal EleWise.ELMA.SR.LocalizableString LocalizedString
    {
      get
      {
        int num = 2;
        PropertyInfo property;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.value == null)
              {
                num = 6;
                continue;
              }
              goto case 5;
            case 2:
              if (this.value != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 0;
                continue;
              }
              goto case 9;
            case 3:
              goto label_16;
            case 4:
              if (!LocalizedStringAttribute.BXQj1WoIlV8o77hn0h8j((object) property, (object) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 8 : 0;
                continue;
              }
              goto label_16;
            case 5:
              if (!this.containsKey)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                continue;
              }
              goto label_12;
            case 6:
              property = this.staticResourceType.GetProperty(this.propertyName);
              num = 4;
              continue;
            case 7:
              goto label_6;
            case 8:
              goto label_17;
            case 9:
              if (LocalizedStringAttribute.fUbOncoI9FeJML1BvYGa(this.staticResourceType, (Type) null))
              {
                num = 7;
                continue;
              }
              goto case 1;
            default:
              goto label_11;
          }
        }
label_6:
        return EleWise.ELMA.SR.LocalizableString.Create((EleWise.ELMA.SR.ILocalizer) new LocalizedStringAttribute.ExceptionLocalizer((Exception) new NullReferenceException((string) LocalizedStringAttribute.VkJGJwoIdAUK4muTBMFp(-812025778 ^ -811916956))));
label_11:
        return (EleWise.ELMA.SR.LocalizableString) LocalizedStringAttribute.nRe6r3oI5Ut6oCAYgRuZ((object) this.value);
label_12:
        return (EleWise.ELMA.SR.LocalizableString) LocalizedStringAttribute.BcLQW1oIYMdaFs73tdGt((object) new EleWise.ELMA.SR.LocalizableString.SRTLocalizer((string) LocalizedStringAttribute.vRGLZToIj3AGOD3mdnxk((object) this.value)));
label_16:
        return (EleWise.ELMA.SR.LocalizableString) LocalizedStringAttribute.BcLQW1oIYMdaFs73tdGt((object) new LocalizedStringAttribute.ExceptionLocalizer((Exception) new NullReferenceException((string) LocalizedStringAttribute.QbniODoIrrjW6rLQ8caR(LocalizedStringAttribute.VkJGJwoIdAUK4muTBMFp(1917256330 ^ 1917147918), (object) this.propertyName, (object) this.staticResourceType.FullName))));
label_17:
        return (EleWise.ELMA.SR.LocalizableString) LocalizedStringAttribute.BcLQW1oIYMdaFs73tdGt((object) new LocalizedStringAttribute.PropertyLocalizer(property));
      }
    }

    internal static bool InyakvoImgqtVXP5kObN() => LocalizedStringAttribute.eqBaqioI0IP71LOjRkcB == null;

    internal static LocalizedStringAttribute i1NOoQoIyE47pC91ycMg() => LocalizedStringAttribute.eqBaqioI0IP71LOjRkcB;

    internal static void pwaBDjoIM4k7b8gNa7x1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Rk2mZCoIJ22Yf19I0i25([In] object obj0) => EleWise.ELMA.SR.ContainsKey((string) obj0);

    internal static bool fUbOncoI9FeJML1BvYGa([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object VkJGJwoIdAUK4muTBMFp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool BXQj1WoIlV8o77hn0h8j([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object QbniODoIrrjW6rLQ8caR([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object xfraoEoIgiXu3R2yxSgb([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static object nRe6r3oI5Ut6oCAYgRuZ([In] object obj0) => (object) (EleWise.ELMA.SR.LocalizableString) (string) obj0;

    internal static object vRGLZToIj3AGOD3mdnxk([In] object obj0) => (object) EleWise.ELMA.SR.ExtractKeyFromString((string) obj0);

    internal static object BcLQW1oIYMdaFs73tdGt([In] object obj0) => (object) EleWise.ELMA.SR.LocalizableString.Create((EleWise.ELMA.SR.ILocalizer) obj0);

    private class PropertyLocalizer : EleWise.ELMA.SR.ILocalizer
    {
      private readonly object propInfo;
      internal static object ndyJSvCGgMBWSds6cjf5;

      public PropertyLocalizer(PropertyInfo propInfo)
      {
        LocalizedStringAttribute.PropertyLocalizer.cn5hnZCGYQcxZqyr1mxj();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.propInfo = (object) propInfo;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      public string Localize() => (string) LocalizedStringAttribute.PropertyLocalizer.DUljbJCGLVnARA2YiLrU(this.propInfo, (object) null, (object) null);

      internal static void cn5hnZCGYQcxZqyr1mxj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool xLTRFGCG5LutMrP5PnIg() => LocalizedStringAttribute.PropertyLocalizer.ndyJSvCGgMBWSds6cjf5 == null;

      internal static LocalizedStringAttribute.PropertyLocalizer w2aLZvCGjDJaTrQ0BYnd() => (LocalizedStringAttribute.PropertyLocalizer) LocalizedStringAttribute.PropertyLocalizer.ndyJSvCGgMBWSds6cjf5;

      internal static object DUljbJCGLVnARA2YiLrU([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);
    }

    private class ExceptionLocalizer : EleWise.ELMA.SR.ILocalizer
    {
      private readonly object exception;
      internal static object AEQDCSCGUhATOnXckymP;

      public ExceptionLocalizer(Exception exception)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.exception = (object) exception;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 1;
              continue;
          }
        }
label_3:;
      }

      public string Localize() => throw this.exception;

      internal static bool qEwRDrCGsyhJXfdGOOyr() => LocalizedStringAttribute.ExceptionLocalizer.AEQDCSCGUhATOnXckymP == null;

      internal static LocalizedStringAttribute.ExceptionLocalizer KdPZOVCGcHXDS0oEHeg6() => (LocalizedStringAttribute.ExceptionLocalizer) LocalizedStringAttribute.ExceptionLocalizer.AEQDCSCGUhATOnXckymP;
    }
  }
}

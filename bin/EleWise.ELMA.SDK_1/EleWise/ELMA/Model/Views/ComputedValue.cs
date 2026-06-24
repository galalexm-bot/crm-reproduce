// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ComputedValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Globalization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <inheritdoc cref="T:EleWise.ELMA.Model.Views.IComputedValue" />
  [XmlInclude(typeof (InputComputedValue))]
  [Serializable]
  public class ComputedValue : IComputedValue, ILocalizable
  {
    private readonly IDictionary<string, PropertyInfo> localizableProperties;
    internal static ComputedValue zqXDZjoqPcWYMr0joL8d;

    /// <summary>Ctor</summary>
    public ComputedValue()
    {
      ComputedValue.sqlUlEoq3RB6tOH3TVG0();
      this.localizableProperties = (IDictionary<string, PropertyInfo>) new Dictionary<string, PropertyInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.PropertyParents = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
            continue;
          case 2:
            this.ComputedValueType = ComputedValueType.Input;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 1;
            continue;
          case 3:
            this.CalculateScript = string.Empty;
            num = 2;
            continue;
          case 4:
            this.MethodName = string.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 3 : 0;
            continue;
          case 5:
            this.Name = string.Empty;
            num = 4;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:;
    }

    /// <inheritdoc />
    [DefaultValue("")]
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
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

    /// <inheritdoc />
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public object Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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
              this.\u003CValue\u003Ek__BackingField = value;
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

    /// <inheritdoc />
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue("")]
    public string MethodName
    {
      get => this.\u003CMethodName\u003Ek__BackingField;
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
              this.\u003CMethodName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    /// <inheritdoc />
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue("")]
    public string CalculateScript
    {
      get => this.\u003CCalculateScript\u003Ek__BackingField;
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
              this.\u003CCalculateScript\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
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

    /// <inheritdoc />
    [DefaultValue(ComputedValueType.Input)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public ComputedValueType ComputedValueType
    {
      get => this.\u003CComputedValueType\u003Ek__BackingField;
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
              this.\u003CComputedValueType\u003Ek__BackingField = value;
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

    /// <inheritdoc />
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(ComputedValueType.Input)]
    public Guid PropertyUid
    {
      get => this.\u003CPropertyUid\u003Ek__BackingField;
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
              this.\u003CPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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

    /// <inheritdoc />
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public List<Guid> PropertyParents { get; set; }

    /// <inheritdoc />
    IDictionary<string, PropertyInfo> ILocalizable.LocalizableProperties => this.localizableProperties;

    /// <inheritdoc />
    IEnumerable<string> ILocalizable.GetStrings(ILocalizable parent)
    {
      string localizableString = this.GetLocalizableString(parent);
      if (localizableString == null)
        return Enumerable.Empty<string>();
      return (IEnumerable<string>) new string[1]
      {
        localizableString
      };
    }

    /// <inheritdoc />
    void ILocalizable.Localize(ILocalizable parent)
    {
      int num = 3;
      string localizableString;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            goto label_2;
          case 2:
            if (localizableString != null)
            {
              this.Value = ComputedValue.tuQR5Poqp71BIajfZXZw((object) localizableString);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          case 3:
            localizableString = this.GetLocalizableString(parent);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 2;
            continue;
          default:
            goto label_8;
        }
      }
label_4:
      return;
label_2:
      return;
label_8:;
    }

    private string GetLocalizableString(ILocalizable parent)
    {
      int num = 4;
      string localizableString;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parent.LocalizableProperties.ContainsKey(this.Name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            if (this.ComputedValueType == ComputedValueType.Input)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
              continue;
            }
            goto label_12;
          case 3:
          case 7:
            goto label_12;
          case 4:
            if (string.IsNullOrWhiteSpace(this.Name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 3 : 2;
              continue;
            }
            goto case 2;
          case 5:
            if (ComputedValue.WNeQKeoqasMsJY1wp1pb((object) localizableString))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 8 : 8;
              continue;
            }
            goto label_5;
          case 6:
            goto label_6;
          case 8:
            goto label_4;
          default:
            localizableString = this.Value as string;
            num = 5;
            continue;
        }
      }
label_4:
      return (string) null;
label_5:
      return localizableString;
label_6:
      return (string) null;
label_12:
      return (string) null;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.ComputedValue.PropertyParents" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePropertyParents()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.PropertyParents != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return this.PropertyParents.Count > 0;
label_5:
      return false;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.ComputedValue.PropertyUid" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializePropertyUid() => ComputedValue.t9rFtmoqD4PgOEBO3vI9(this.PropertyUid, Guid.Empty);

    internal static void sqlUlEoq3RB6tOH3TVG0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool RmRnjJoq1xdEXtWYAshs() => ComputedValue.zqXDZjoqPcWYMr0joL8d == null;

    internal static ComputedValue R1yEmOoqNb7QhL0AB2Te() => ComputedValue.zqXDZjoqPcWYMr0joL8d;

    internal static object tuQR5Poqp71BIajfZXZw([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool WNeQKeoqasMsJY1wp1pb([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static bool t9rFtmoqD4PgOEBO3vI9([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;
  }
}

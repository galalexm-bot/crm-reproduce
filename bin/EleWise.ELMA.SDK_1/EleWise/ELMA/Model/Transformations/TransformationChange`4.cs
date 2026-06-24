// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.TransformationChange`4
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Transformations
{
  [DebuggerDisplay("ItemUid: {Uid}, PropertyName: {PropertyName}, Value: {Value}", Type = "Change")]
  [DebuggerTypeProxy(typeof (TransformationChange<,,,>.DebugView))]
  [XmlInclude(typeof (TransformationChangeRemoveValue))]
  [Serializable]
  public class TransformationChange<TItem, TTransformation, TUid, TNullUid> : 
    BaseTransformation<TItem, TUid>
    where TItem : class
    where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()
  {
    internal static object a7UVZkWUkrB3IKt3U8w7;

    public string PropertyName
    {
      get => this.\u003CPropertyName\u003Ek__BackingField;
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
              this.\u003CPropertyName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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

    [XmlAttribute("Type")]
    [DefaultValue("")]
    public string TypeName
    {
      get => this.\u003CTypeName\u003Ek__BackingField;
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
              this.\u003CTypeName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
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

    /// <summary>Признак, что свойство локализуемое</summary>
    [DefaultValue(false)]
    public bool Localizable
    {
      get => this.\u003CLocalizable\u003Ek__BackingField;
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
              this.\u003CLocalizable\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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

    private static bool CheckProperty(PropertyInfo property, string[] propertyNames)
    {
      int num = 4;
      object[] customAttributes;
      List<string> list;
      string shortPropertyName;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (!((IEnumerable<object>) customAttributes).Any<object>())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 9;
              continue;
            }
            if (propertyNames.Length != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 5 : 7;
              continue;
            }
            goto label_12;
          case 3:
            customAttributes = property.GetCustomAttributes(typeof (ChangeablePropertyAttribute), true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 0;
            continue;
          case 4:
            num = 3;
            continue;
          case 5:
            goto label_5;
          case 6:
            if (!property.PropertyType.IsInheritOrSame<IPropertiesContainer>())
            {
              num = 10;
              continue;
            }
            goto label_12;
          case 7:
            if (propertyNames.Length == 1)
            {
              num = 12;
              continue;
            }
            goto case 6;
          case 9:
            goto label_17;
          case 10:
            shortPropertyName = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536797870), propertyNames);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 11 : 9;
            continue;
          case 11:
            IEnumerable<ChangeablePropertyAttribute> source = customAttributes.Cast<ChangeablePropertyAttribute>().Where<ChangeablePropertyAttribute>((Func<ChangeablePropertyAttribute, bool>) (a => a.SubProperties != null));
            // ISSUE: reference to a compiler-generated field
            Func<ChangeablePropertyAttribute, IEnumerable<string>> func = TransformationChange<TItem, TTransformation, TUid, TNullUid>.\u003C\u003Ec.\u003C\u003E9__17_1;
            Func<ChangeablePropertyAttribute, IEnumerable<string>> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              TransformationChange<TItem, TTransformation, TUid, TNullUid>.\u003C\u003Ec.\u003C\u003E9__17_1 = selector = (Func<ChangeablePropertyAttribute, IEnumerable<string>>) (a => (IEnumerable<string>) a.SubProperties);
            }
            else
              goto label_25;
label_24:
            list = source.SelectMany<ChangeablePropertyAttribute, string>(selector).ToList<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 8 : 13;
            continue;
label_25:
            selector = func;
            goto label_24;
          case 12:
            if (string.IsNullOrEmpty(propertyNames[0]))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 13:
            if (!list.Contains(shortPropertyName))
            {
              shortPropertyName += z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488875761);
              num = 5;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
            continue;
          default:
            goto label_12;
        }
      }
label_5:
      return list.Any<string>((Func<string, bool>) (sp => sp.StartsWith(shortPropertyName)));
label_8:
      return true;
label_12:
      return true;
label_17:
      return false;
    }

    public override void Apply(TItem formViewItem) => this.ApplyReturn(formViewItem);

    public TItem ApplyReturn(TItem rootItem, TTransformation instance = null) => TransformationChange<TItem, TTransformation, TUid, TNullUid>.StaticApply(rootItem, this.Uid, this.PropertyName, this.Value, instance);

    public static TItem StaticApply(
      TItem formViewItem,
      TUid uid,
      string propertyName,
      object value,
      TTransformation instance = null)
    {
      TItem obj1 = (instance ?? Transformation<TItem, TTransformation, TUid, TNullUid>.Instance).FindItem(formViewItem, uid);
      if ((object) obj1 == null)
        return default (TItem);
      string[] source = propertyName.Split('.');
      string name1 = ((IEnumerable<string>) source).FirstOrDefault<string>();
      if (name1 == null)
        return default (TItem);
      PropertyInfo reflectionProperty = obj1.GetType().GetReflectionProperty(name1);
      if (reflectionProperty == (PropertyInfo) null)
        return default (TItem);
      string[] array = ((IEnumerable<string>) source).Skip<string>(1).ToArray<string>();
      if (!TransformationChange<TItem, TTransformation, TUid, TNullUid>.CheckProperty(reflectionProperty, array))
        return default (TItem);
      object obj2 = (object) obj1;
      if (reflectionProperty.GetValue(obj2, (object[]) null) is IPropertiesContainer propertiesContainer && array.Length == 1)
      {
        if (value is TransformationChangeRemoveValue)
          propertiesContainer.RemoveProperty(array[0]);
        else
          propertiesContainer.SetPropertyValue(array[0], (object[]) null, value);
        return obj1;
      }
      foreach (string name2 in array)
      {
        obj2 = reflectionProperty.GetValue(obj2, (object[]) null);
        if (obj2 == null)
          return default (TItem);
        reflectionProperty = obj2.GetType().GetReflectionProperty(name2);
        if (reflectionProperty == (PropertyInfo) null)
          return default (TItem);
      }
      if (!reflectionProperty.PropertyType.IsInstanceOfType(value) && value is IConvertible)
      {
        TypeConverter converter = TypeDescriptor.GetConverter(reflectionProperty.PropertyType);
        if (converter.CanConvertFrom(value.GetType()))
          value = converter.ConvertFrom(value);
      }
      reflectionProperty.SetValue(obj2, value, (object[]) null);
      return obj1;
    }

    /// <summary>
    /// Получить список локализуемых свойств данного элемента и всех внутренних
    /// </summary>
    /// <returns></returns>
    public override IEnumerable<string> GetLocalizableStrings()
    {
      List<string> allStrings = new List<string>();
      IEnumerable<string> localizableStrings = base.GetLocalizableStrings();
      if (localizableStrings != null)
        allStrings.AddRange(localizableStrings);
      TransformationChange<TItem, TTransformation, TUid, TNullUid>.StaticGetLocalizableStrings(allStrings, this.Localizable, this.Value);
      return (IEnumerable<string>) allStrings;
    }

    public static void StaticGetLocalizableStrings(
      List<string> allStrings,
      bool Localizable,
      object Value)
    {
      if (!Localizable || !(Value is string) || string.IsNullOrEmpty((string) Value) || allStrings.Contains((string) Value))
        return;
      allStrings.Add((string) Value);
    }

    /// <summary>Применить текущую локаль к локализуемым свойствам</summary>
    public override void ApplyLocalization()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.ApplyLocalization();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.Value = TransformationChange<TItem, TTransformation, TUid, TNullUid>.StaticApplyLocalization(this.Localizable, this.Value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    public static object StaticApplyLocalization(bool Localizable, object Value)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_8;
          case 2:
            if (Value is string)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 4:
            if (!Localizable)
            {
              num = 3;
              continue;
            }
            goto case 2;
          default:
            if (string.IsNullOrEmpty((string) Value))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
              continue;
            }
            goto label_9;
        }
      }
label_8:
      return Value;
label_9:
      return (object) EleWise.ELMA.SR.T((string) Value);
    }

    public TransformationChange()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ogGv8PWUnbfsCPAwp7XX() => TransformationChange<TItem, TTransformation, TUid, TNullUid>.a7UVZkWUkrB3IKt3U8w7 == null;

    internal static object Lktb02WUOpwQ94TeFfSx() => TransformationChange<TItem, TTransformation, TUid, TNullUid>.a7UVZkWUkrB3IKt3U8w7;

    public sealed class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly TransformationChange<TItem, TTransformation, TUid, TNullUid> transformation;
      private static object Li3df4CB5tlH4m8ZN4bJ;

      public DebugView(
        TransformationChange<TItem, TTransformation, TUid, TNullUid> transformation)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.transformation = transformation;
      }

      public TUid ItemUid => this.transformation.Uid;

      public string PropertyName => this.transformation.PropertyName;

      public object Value => this.transformation.Value;

      internal static bool W3CjLwCBjCkXnAElvIpF() => TransformationChange<TItem, TTransformation, TUid, TNullUid>.DebugView.Li3df4CB5tlH4m8ZN4bJ == null;

      internal static object dE3srpCBYSFKhAnbHMvH() => TransformationChange<TItem, TTransformation, TUid, TNullUid>.DebugView.Li3df4CB5tlH4m8ZN4bJ;
    }
  }
}

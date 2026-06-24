// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.TypeSerializationDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Common
{
  /// <summary>Элемент описания данных</summary>
  [DataContract]
  [Serializable]
  public sealed class TypeSerializationDescriptor : ICloneable
  {
    private string typeName;
    private Type type;
    private static TypeSerializationDescriptor hBy6jZfV14uTvm8Rjjor;

    public TypeSerializationDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.Items = (ICollection<TypeSerializationItemDescriptor>) new SerializableList<TypeSerializationItemDescriptor>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          default:
            this.Description = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Строковое описание данных</summary>
    [DataMember]
    public string Description
    {
      get => this.\u003CDescription\u003Ek__BackingField;
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
              this.\u003CDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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

    /// <summary>Тип данных</summary>
    [IgnoreDataMember]
    public Type Type
    {
      get => this.type;
      set
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (!TypeSerializationDescriptor.oKrAFAfVagMO47AFDWLE((object) this.typeName, (object) value.FullName))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 4 : 2;
                continue;
              }
              goto case 5;
            case 3:
              if (TypeSerializationDescriptor.kHtNjGfVppyqJ1g37tca(value, (Type) null))
              {
                num = 2;
                continue;
              }
              break;
            case 5:
              this.typeName = value.FullName;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
          }
          this.type = value;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
        }
label_2:;
      }
    }

    /// <summary>Имя типа</summary>
    [DataMember]
    public string TypeName
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (TypeSerializationDescriptor.kHtNjGfVppyqJ1g37tca(this.type, (Type) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return this.typeName;
label_3:
        return this.type.FullName;
      }
      set
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 2:
            case 6:
              this.typeName = value;
              num = 5;
              continue;
            case 3:
              if (!TypeSerializationDescriptor.kHtNjGfVppyqJ1g37tca(this.type, (Type) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 2 : 2;
                continue;
              }
              goto case 4;
            case 4:
              if (!(this.type.FullName != value))
              {
                num = 6;
                continue;
              }
              break;
            case 5:
              goto label_4;
          }
          this.type = (Type) null;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
        }
label_4:;
      }
    }

    /// <summary>Признак, является ли значение массивом</summary>
    [DataMember]
    public bool IsArray
    {
      get => this.\u003CIsArray\u003Ek__BackingField;
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
              this.\u003CIsArray\u003Ek__BackingField = value;
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
    }

    /// <summary>Признак, является ли значение необязательным</summary>
    [DataMember]
    public bool IsOptional
    {
      get => this.\u003CIsOptional\u003Ek__BackingField;
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
              this.\u003CIsOptional\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
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

    /// <summary>Признак, является ли элемент устаревшим</summary>
    [DataMember]
    public bool IsObsolete
    {
      get => this.\u003CIsObsolete\u003Ek__BackingField;
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
              this.\u003CIsObsolete\u003Ek__BackingField = value;
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

    /// <summary>
    /// Значение по умолчанию (имеет смысл, если значение необязательное)
    /// </summary>
    [DataMember]
    public object DefaultValue
    {
      get => this.\u003CDefaultValue\u003Ek__BackingField;
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
              this.\u003CDefaultValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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

    /// <summary>
    /// Коллекция вложенных элементов, например свойства или элементы массива
    /// </summary>
    [DataMember]
    public ICollection<TypeSerializationItemDescriptor> Items { get; private set; }

    public override string ToString()
    {
      int num = 2;
      string commaSeparatedString;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Items.Any<TypeSerializationItemDescriptor>())
            {
              num = 5;
              continue;
            }
            goto label_2;
          case 2:
            commaSeparatedString = this.Items.ToCommaSeparatedString<TypeSerializationItemDescriptor>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_9;
          case 4:
            goto label_8;
          case 5:
            if (this.IsArray)
            {
              num = 3;
              continue;
            }
            goto label_8;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) TypeSerializationDescriptor.jVSkXNfVt3Qn5sS7wlJt(TypeSerializationDescriptor.LsUiLHfVDii8TGUqZFn8(-1939377524 ^ -1939519262), (object) this.Description);
label_8:
      return (string) TypeSerializationDescriptor.LsUiLHfVDii8TGUqZFn8(1917256330 ^ 1916945328) + commaSeparatedString + (string) TypeSerializationDescriptor.LsUiLHfVDii8TGUqZFn8(-105199646 ^ -104873824);
label_9:
      return (string) TypeSerializationDescriptor.lmR2UffVwW3ehW6YhNRX((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1787099382), (object) commaSeparatedString, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606965680));
    }

    public TypeSerializationDescriptor Clone() => (TypeSerializationDescriptor) TypeSerializationDescriptor.JOiw7vfV4U9bhZL2gv4H((object) this);

    /// <summary>
    /// Создает новый объект, который является копией текущего экземпляра.
    /// </summary>
    /// <returns>Новый объект, являющийся копией этого экземпляра.</returns>
    /// <filterpriority>2</filterpriority>
    object ICloneable.Clone()
    {
      TypeSerializationDescriptor serializationDescriptor = new TypeSerializationDescriptor();
      TypeSerializationDescriptor.iKUs0XfV6YkSMHrOiefT((object) serializationDescriptor, this.IsArray);
      TypeSerializationDescriptor.bgw8DMfVHQllfjZURBTP((object) serializationDescriptor, (object) this.Description);
      ICollection<TypeSerializationItemDescriptor> items = this.Items;
      // ISSUE: reference to a compiler-generated field
      Func<TypeSerializationItemDescriptor, TypeSerializationItemDescriptor> func = TypeSerializationDescriptor.\u003C\u003Ec.\u003C\u003E9__35_0;
      Func<TypeSerializationItemDescriptor, TypeSerializationItemDescriptor> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        TypeSerializationDescriptor.\u003C\u003Ec.\u003C\u003E9__35_0 = selector = (Func<TypeSerializationItemDescriptor, TypeSerializationItemDescriptor>) (i => (TypeSerializationItemDescriptor) TypeSerializationDescriptor.\u003C\u003Ec.sSQSQ585z89ybaGijH4b((object) i));
      }
      else
        goto label_1;
label_3:
      serializationDescriptor.Items = (ICollection<TypeSerializationItemDescriptor>) new SerializableList<TypeSerializationItemDescriptor>(items.Select<TypeSerializationItemDescriptor, TypeSerializationItemDescriptor>(selector));
      return (object) serializationDescriptor;
label_1:
      selector = func;
      goto label_3;
    }

    internal static bool woBJaqfVNjXjEs5Zw9GO() => TypeSerializationDescriptor.hBy6jZfV14uTvm8Rjjor == null;

    internal static TypeSerializationDescriptor YFWmRDfV3ElRf9d0DcOL() => TypeSerializationDescriptor.hBy6jZfV14uTvm8Rjjor;

    internal static bool kHtNjGfVppyqJ1g37tca([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool oKrAFAfVagMO47AFDWLE([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object LsUiLHfVDii8TGUqZFn8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object jVSkXNfVt3Qn5sS7wlJt([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object lmR2UffVwW3ehW6YhNRX([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object JOiw7vfV4U9bhZL2gv4H([In] object obj0) => ((ICloneable) obj0).Clone();

    internal static void iKUs0XfV6YkSMHrOiefT([In] object obj0, bool value) => ((TypeSerializationDescriptor) obj0).IsArray = value;

    internal static void bgw8DMfVHQllfjZURBTP([In] object obj0, [In] object obj1) => ((TypeSerializationDescriptor) obj0).Description = (string) obj1;
  }
}

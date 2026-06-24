// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.AbstractMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Абстрактный класс метаданных</summary>
  [DataContract]
  [Component]
  [Serializable]
  public abstract class AbstractMetadata : 
    Entity<long>,
    IMetadata,
    IXsiType,
    IUnique,
    ICloneable,
    IXsiRoot
  {
    [NonSerialized]
    private string uidStr;
    private Guid uid;
    /// <summary>Кеш</summary>
    private static ConcurrentDictionary<Type, PropertiesHelper> editableMetadataCache;
    private static AbstractMetadata Rco46nbmae8I2dXA6Sob;

    /// <summary>
    /// Конструктор. Присваивает AccessLevel = MetadataAccessInfo.Level
    /// </summary>
    protected AbstractMetadata()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Клонировать объект</summary>
    /// <returns>Клонированный объект</returns>
    public virtual object Clone()
    {
      AbstractMetadata abstractMetadata = ClassSerializationHelper.CloneObjectByXml<AbstractMetadata>(this);
      abstractMetadata.Uid = AbstractMetadata.JBwvQYbmwwM5dtWn7VXf();
      return (object) abstractMetadata;
    }

    /// <summary>Инициализировать новый объект метаданных</summary>
    public virtual void InitNew()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Uid = AbstractMetadata.JBwvQYbmwwM5dtWn7VXf();
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

    /// <summary>Выполнить действия после загрузки объекта метаданных</summary>
    public virtual void AfterLoad()
    {
    }

    /// <summary>Скопировать свойства</summary>
    /// <param name="source"></param>
    /// <param name="ignoredProperties"></param>
    public virtual void CopyFrom(AbstractMetadata source, params string[] ignoredProperties)
    {
      int num1 = 21;
      while (true)
      {
        int num2 = num1;
        int index;
        while (true)
        {
          PropertyInfo propertyInfo;
          PropertyInfo property;
          object obj1;
          object obj2;
          PropertyInfo[] properties;
          int num3;
          switch (num2)
          {
            case 1:
              AbstractMetadata.LxwXvkbmMagvM3NJ04Lv((object) propertyInfo, (object) this, obj1, (object) null);
              num2 = 3;
              continue;
            case 2:
              property = source.GetType().GetProperty((string) AbstractMetadata.qCrwARbmmvEo4VE9eODI((object) propertyInfo));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 31 : 13;
              continue;
            case 3:
            case 7:
            case 15:
            case 25:
            case 30:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 6;
              continue;
            case 4:
            case 28:
              if (AbstractMetadata.xrdGKLbmAVkA5cLySGud(this.GetType(), source.GetType()))
              {
                num2 = 23;
                continue;
              }
              goto case 2;
            case 5:
            case 24:
              propertyInfo = properties[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
              continue;
            case 6:
            case 12:
              if (index < properties.Length)
              {
                num2 = 24;
                continue;
              }
              goto label_32;
            case 8:
              obj2 = AbstractMetadata.GXQVijbmyCJahg3396AT((object) property, (object) source, (object) null);
              num2 = 9;
              continue;
            case 9:
              AbstractMetadata.LxwXvkbmMagvM3NJ04Lv((object) propertyInfo, (object) this, obj2, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 7;
              continue;
            case 10:
              num3 = 1;
              break;
            case 11:
              if (!this.GetType().IsAssignableFrom(source.GetType()))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 14 : 9;
                continue;
              }
              goto case 10;
            case 13:
              if (ignoredProperties == null)
                goto case 17;
              else
                goto label_12;
            case 14:
              num3 = source.GetType().IsAssignableFrom(AbstractMetadata.qQjU8lbmHHVwZMQW3dw1((object) this)) ? 1 : 0;
              break;
            case 16:
              if (ignoredProperties == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 4 : 0;
                continue;
              }
              goto case 26;
            case 17:
              properties = AbstractMetadata.qQjU8lbmHHVwZMQW3dw1((object) this).GetProperties();
              num2 = 29;
              continue;
            case 18:
              List<string> stringList = new List<string>((IEnumerable<string>) ignoredProperties);
              num2 = 17;
              continue;
            case 19:
              if (ignoredProperties.Length != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 18 : 16;
                continue;
              }
              goto case 17;
            case 20:
              if (AbstractMetadata.xrdGKLbmAVkA5cLySGud(AbstractMetadata.qQjU8lbmHHVwZMQW3dw1((object) this), source.GetType()))
              {
                num2 = 10;
                continue;
              }
              goto case 11;
            case 21:
              AbstractMetadata.T6yHvEbm6dGCQeWmmG03((object) source, AbstractMetadata.sYI9Dhbm4BN9xrNLiDaA(~-306453669 ^ 306451970));
              num2 = 20;
              continue;
            case 22:
              if (!AbstractMetadata.BAou9Tbm0pn7ASxEZuFR((object) propertyInfo))
              {
                num2 = 15;
                continue;
              }
              goto case 16;
            case 23:
              obj1 = AbstractMetadata.GXQVijbmyCJahg3396AT((object) propertyInfo, (object) source, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 1;
              continue;
            case 26:
              if (((IEnumerable<string>) ignoredProperties).Contains<string>((string) AbstractMetadata.qCrwARbmmvEo4VE9eODI((object) propertyInfo)))
              {
                num2 = 30;
                continue;
              }
              goto case 4;
            case 27:
              goto label_33;
            case 29:
              goto label_10;
            case 31:
              if (AbstractMetadata.Oj09AdbmJVpH1jTvCWZ3((object) property, (object) null))
              {
                num2 = 8;
                continue;
              }
              goto case 3;
            default:
              if (!AbstractMetadata.w0OypDbmx59LnMBqXxBS((object) propertyInfo))
              {
                num2 = 25;
                continue;
              }
              goto case 22;
          }
          object obj3 = AbstractMetadata.sYI9Dhbm4BN9xrNLiDaA(323422137 << 2 ^ 1293869644);
          AbstractMetadata.Xmw1qmbm7CXyjElVKPcC(num3 != 0, obj3);
          num2 = 13;
        }
label_10:
        index = 0;
        num1 = 12;
        continue;
label_12:
        num1 = 19;
      }
label_33:
      return;
label_32:;
    }

    /// <summary>Уникальный идентификатор объекта метаданных</summary>
    [EntityProperty]
    [PublicationBehaviour(PublicationType.Restart)]
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    [GuidSettings(FieldName = "Uid")]
    [SystemProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{3508CCB9-AEB6-4AEC-AF21-6A4C8FBEFC53}")]
    [XmlElement("Uid")]
    [DataMember]
    public virtual Guid Uid
    {
      get => this.uid;
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.uidStr = value.ToString();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
              continue;
            case 2:
              this.uid = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }
    }

    /// <summary>Уникальный идентификатор в строковом представлении</summary>
    [XmlIgnore]
    public virtual string UidStr => this.uidStr;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeUid() => AbstractMetadata.POI1y1bmded6FELSorcd(AbstractMetadata.TEJsdIbm9SZ7oKUB5PvL((object) this), Guid.Empty);

    /// <summary>
    /// Идентификатор модуля, к которому принадлежат метаданные
    /// </summary>
    [GuidSettings(FieldName = "ModuleUid")]
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    [XmlElement("ModuleUid")]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{2BF00C87-1D45-4B93-8689-2709BAB4E97A}")]
    [DataMember]
    public virtual Guid ModuleUid
    {
      get => this.\u003CModuleUid\u003Ek__BackingField;
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
              this.\u003CModuleUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
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

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeModuleUid() => AbstractMetadata.POI1y1bmded6FELSorcd(AbstractMetadata.MAFKJ6bmlOyQY0bJukYi((object) this), Guid.Empty);

    /// <summary>Внутренние метаданные модуля</summary>
    [DataMember]
    [EleWise.ELMA.Model.Attributes.Uid("{6A951C1D-446D-45D2-8834-4C2677CF90F3}")]
    [XmlElement("Internal")]
    [DefaultValue(false)]
    [BoolSettings(FieldName = "Internal")]
    [EntityProperty]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    public virtual bool Internal
    {
      get => this.\u003CInternal\u003Ek__BackingField;
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
              this.\u003CInternal\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
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

    public static PropertiesHelper GetInitializerCache(Type type)
    {
      int num = 1;
      Type type1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            type1 = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:
      return AbstractMetadata.editableMetadataCache.GetOrAdd(type1, (Func<Type, PropertiesHelper>) (a =>
      {
        Type type2 = type1;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ParameterExpression parameterExpression = (ParameterExpression) AbstractMetadata.\u003C\u003Ec__DisplayClass23_0.n81tIwCHbQiKqmKn13FH(typeof (PropertyInfo), AbstractMetadata.\u003C\u003Ec__DisplayClass23_0.y41HUvCHodp9k6OcphYD(~289714581 ^ -289480510));
        // ISSUE: method reference
        // ISSUE: reference to a compiler-generated method
        // ISSUE: method reference
        // ISSUE: type reference
        // ISSUE: type reference
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        Expression<Func<PropertyInfo, bool>> propertiesSelectCondition = Expression.Lambda<Func<PropertyInfo, bool>>((Expression) Expression.NotEqual((Expression) AbstractMetadata.\u003C\u003Ec__DisplayClass23_0.BSfTSACHfZp8fXI2GlKO((object) null, (object) (MethodInfo) AbstractMetadata.\u003C\u003Ec__DisplayClass23_0.xMk5YjCHh5rodbO1yITJ(__methodref (Enumerable.FirstOrDefault)), (object) new Expression[1]
        {
          (Expression) AbstractMetadata.\u003C\u003Ec__DisplayClass23_0.BSfTSACHfZp8fXI2GlKO((object) null, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AttributeHelper<EditingExtensibleClassAttribute>.GetAttributes), __typeref (AttributeHelper<EditingExtensibleClassAttribute>)), (object) new Expression[2]
          {
            (Expression) parameterExpression,
            (Expression) AbstractMetadata.\u003C\u003Ec__DisplayClass23_0.yTdsksCHEO7huDoOhQJV((object) true, AbstractMetadata.\u003C\u003Ec__DisplayClass23_0.N1tF5GCHGnEVV5hpv8cV(__typeref (bool)))
          })
        }), (Expression) AbstractMetadata.\u003C\u003Ec__DisplayClass23_0.yTdsksCHEO7huDoOhQJV((object) null, typeof (object))), parameterExpression);
        return new PropertiesHelper(type2, propertiesSelectCondition);
      }));
    }

    public static bool IsEditingProperty(Type type, string name)
    {
      int num = 1;
      Dictionary<string, Func<object, object>> getActions;
      while (true)
      {
        switch (num)
        {
          case 1:
            getActions = ((PropertiesHelper) AbstractMetadata.zfFQwDbmrOFwGsNkbKlB(type)).GetActions;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            if (AbstractMetadata.nn7XU6bmgSGXKZge9phu((object) getActions) <= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 0;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return true;
label_3:
      return getActions.ContainsKey(name);
    }

    /// <summary>Сравнение значений двух объектов метаданных</summary>
    /// <param name="rhs"></param>
    /// <returns></returns>
    public virtual bool Equals(AbstractMetadata rhs)
    {
      int num1 = 5;
      Dictionary<string, Func<object, object>>.Enumerator enumerator;
      bool flag;
      while (true)
      {
        int num2 = num1;
        PropertiesHelper propertiesHelper;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              enumerator = propertiesHelper.GetActions.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
              continue;
            case 4:
              if (propertiesHelper == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                continue;
              }
              goto case 7;
            case 5:
              goto label_21;
            case 6:
              flag = false;
              num2 = 2;
              continue;
            case 7:
              if (AbstractMetadata.qQjU8lbmHHVwZMQW3dw1((object) this) == rhs.GetType())
              {
                num2 = 6;
                continue;
              }
              goto label_24;
            default:
              goto label_24;
          }
        }
label_21:
        propertiesHelper = (PropertiesHelper) AbstractMetadata.zfFQwDbmrOFwGsNkbKlB(rhs.GetType());
        num1 = 4;
      }
label_3:
      try
      {
label_12:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_13;
label_4:
        Func<object, object> func;
        object obj1;
        object obj2;
        KeyValuePair<string, Func<object, object>> current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_7;
            case 2:
              goto label_12;
            case 3:
              flag |= obj1.Equals(obj2);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 2 : 0;
              continue;
            case 4:
              obj2 = func((object) rhs);
              num3 = 3;
              continue;
            case 5:
              obj1 = func((object) this);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 3 : 4;
              continue;
            case 6:
              goto label_24;
            case 7:
              func = current.Value;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            default:
              if (func != null)
              {
                num3 = 5;
                continue;
              }
              goto label_12;
          }
        }
label_7:
        current = enumerator.Current;
        num3 = 7;
        goto label_4;
label_13:
        num3 = 6;
        goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
label_24:
      return false;
    }

    static AbstractMetadata()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AbstractMetadata.cCK0rlbm5O4kUCY6rUDH();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            AbstractMetadata.editableMetadataCache = new ConcurrentDictionary<Type, PropertiesHelper>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool UPFp0FbmD2aDgjIu5oXR() => AbstractMetadata.Rco46nbmae8I2dXA6Sob == null;

    internal static AbstractMetadata IjVIh5bmtr0ahqc0HSUt() => AbstractMetadata.Rco46nbmae8I2dXA6Sob;

    internal static Guid JBwvQYbmwwM5dtWn7VXf() => Guid.NewGuid();

    internal static object sYI9Dhbm4BN9xrNLiDaA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void T6yHvEbm6dGCQeWmmG03([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Type qQjU8lbmHHVwZMQW3dw1([In] object obj0) => obj0.GetType();

    internal static bool xrdGKLbmAVkA5cLySGud([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static void Xmw1qmbm7CXyjElVKPcC(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static bool w0OypDbmx59LnMBqXxBS([In] object obj0) => ((PropertyInfo) obj0).CanRead;

    internal static bool BAou9Tbm0pn7ASxEZuFR([In] object obj0) => ((PropertyInfo) obj0).CanWrite;

    internal static object qCrwARbmmvEo4VE9eODI([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object GXQVijbmyCJahg3396AT([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static void LxwXvkbmMagvM3NJ04Lv([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static bool Oj09AdbmJVpH1jTvCWZ3([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static Guid TEJsdIbm9SZ7oKUB5PvL([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool POI1y1bmded6FELSorcd([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid MAFKJ6bmlOyQY0bJukYi([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static object zfFQwDbmrOFwGsNkbKlB(Type type) => (object) AbstractMetadata.GetInitializerCache(type);

    internal static int nn7XU6bmgSGXKZge9phu([In] object obj0) => ((Dictionary<string, Func<object, object>>) obj0).Count;

    internal static void cCK0rlbm5O4kUCY6rUDH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

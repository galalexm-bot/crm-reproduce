// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.EQL.ParsedQueryParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Managers.EQL
{
  /// <summary>Коллекция распарсенных параметров EQL-запроса</summary>
  public sealed class ParsedQueryParameters : QueryParameters
  {
    internal static ParsedQueryParameters TgsRArhvnH6AMo2xBaWB;

    /// <summary>ctor</summary>
    internal ParsedQueryParameters()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((IDictionary<string, object>) new ParsedQueryParameters.SerializableDictionary());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Заполнить параметры значениями</summary>
    /// <param name="parameters">Значения параметров</param>
    public ParsedQueryParameters FillValues(IDictionary<string, object> parameters)
    {
      foreach (KeyValuePair<string, ParsedQueryParameters.Parameter> keyValuePair in (IEnumerable<KeyValuePair<string, ParsedQueryParameters.Parameter>>) this.Dictionary)
      {
        object o;
        if (parameters.TryGetValue(keyValuePair.Key, out o) && keyValuePair.Value.Type.IsInstanceOfType(o))
          keyValuePair.Value.Value = o;
      }
      return this;
    }

    /// <summary>Получить тип параметра</summary>
    /// <param name="name">Имя параметра</param>
    public Type GetType(string name)
    {
      int num = 1;
      ParsedQueryParameters.Parameter parameter;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.Dictionary.TryGetValue(this.TrimKey(name), out parameter))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (Type) null;
label_3:
      return ParsedQueryParameters.LH5eobhveVEb7PS8kCsy((object) parameter);
    }

    /// <summary>Получить TypeUid параметра</summary>
    /// <param name="name">Имя параметра</param>
    public Guid GetTypeUid(string name)
    {
      int num = 1;
      ParsedQueryParameters.Parameter parameter;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Dictionary.TryGetValue(this.TrimKey(name), out parameter))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
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
      return Guid.Empty;
label_5:
      return ParsedQueryParameters.uVxy1MhvPiCnTKljFkld((object) parameter);
    }

    /// <summary>Получить SubTypeUid параметра</summary>
    /// <param name="name">Имя параметра</param>
    public Guid GetSubTypeUid(string name)
    {
      int num = 2;
      ParsedQueryParameters.Parameter parameter;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (this.Dictionary.TryGetValue(this.TrimKey(name), out parameter))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return Guid.Empty;
label_3:
      return ParsedQueryParameters.lKQnoQhv1W60rJnBq9Dt((object) parameter);
    }

    /// <summary>Получить TypeSettings параметра</summary>
    /// <param name="name">Имя параметра</param>
    public TypeSettings GetTypeSettings(string name)
    {
      int num = 1;
      ParsedQueryParameters.Parameter parameter;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.Dictionary.TryGetValue(this.TrimKey(name), out parameter))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (TypeSettings) null;
label_3:
      return (TypeSettings) ParsedQueryParameters.pqo14IhvNXabpq3mnS7N((object) parameter);
    }

    /// <summary>Проверить тип параметра и получить его значение</summary>
    /// <param name="name">Имя параметра</param>
    /// <param name="parentMetadata">Метаданные класса</param>
    /// <param name="propertyName">Имя свойства</param>
    /// <param name="isCollection">Параметр является коллекцией</param>
    /// <param name="value">Возвращаемое значение параметра</param>
    /// <returns><see langword="true" />, если тип параметра корректный, иначе <see langword="false" /></returns>
    internal bool TryCheckAndGet(
      string name,
      EntityMetadata parentMetadata,
      string propertyName,
      bool isCollection,
      out object value)
    {
      int num1 = 1;
      ParsedQueryParameters.Parameter parameter;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              name = this.TrimKey(name);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            case 2:
              value = ParsedQueryParameters.F72LYlhv3OTa5sAiI4Ds((object) parameter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 3;
              continue;
            case 3:
              goto label_7;
            case 4:
              this.Dictionary[name] = parameter = new ParsedQueryParameters.Parameter(parentMetadata, propertyName, isCollection);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 2;
              continue;
            default:
              if (this.Dictionary.TryGetValue(name, out parameter))
                goto case 2;
              else
                goto label_6;
          }
        }
label_6:
        num1 = 4;
      }
label_7:
      return ParsedQueryParameters.os2Eqjhvp0Q02cGnuZZY((object) parameter, (object) parentMetadata, (object) propertyName, isCollection);
    }

    private IDictionary<string, ParsedQueryParameters.Parameter> Dictionary => (IDictionary<string, ParsedQueryParameters.Parameter>) base.Dictionary;

    internal static bool gOuHDLhvODkiHK5dKaTi() => ParsedQueryParameters.TgsRArhvnH6AMo2xBaWB == null;

    internal static ParsedQueryParameters h9VToQhv2aOF8cRFKLcC() => ParsedQueryParameters.TgsRArhvnH6AMo2xBaWB;

    internal static Type LH5eobhveVEb7PS8kCsy([In] object obj0) => ((ParsedQueryParameters.Parameter) obj0).Type;

    internal static Guid uVxy1MhvPiCnTKljFkld([In] object obj0) => ((ParsedQueryParameters.Parameter) obj0).TypeUid;

    internal static Guid lKQnoQhv1W60rJnBq9Dt([In] object obj0) => ((ParsedQueryParameters.Parameter) obj0).SubTypeUid;

    internal static object pqo14IhvNXabpq3mnS7N([In] object obj0) => (object) ((ParsedQueryParameters.Parameter) obj0).TypeSettings;

    internal static object F72LYlhv3OTa5sAiI4Ds([In] object obj0) => ((ParsedQueryParameters.Parameter) obj0).Value;

    internal static bool os2Eqjhvp0Q02cGnuZZY(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      bool isCollection)
    {
      return ((ParsedQueryParameters.Parameter) obj0).Check((EntityMetadata) obj1, (string) obj2, isCollection);
    }

    private class Parameter
    {
      private readonly bool isCollection;
      private Guid parentTypeUid;
      private object propertyName;
      private object typeSettings;
      private Type propertyType;
      internal static object DYqX9rCY6oSeeBnlwFb4;

      public Parameter(object value)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.Value = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
              continue;
          }
        }
label_3:;
      }

      public Parameter(EntityMetadata parentMetadata, string propertyName, bool isCollection)
      {
        ParsedQueryParameters.Parameter.YnH6QCCY7SHypyVNr73M();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        PropertyMetadata propertyMetadata;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_10;
            case 1:
              this.typeSettings = propertyMetadata == null ? (object) null : ParsedQueryParameters.Parameter.BfMbOyCYy51l52iXTmpi((object) propertyMetadata);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            case 2:
              this.isCollection = isCollection;
              num = 4;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              propertyMetadata = parentMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => ParsedQueryParameters.Parameter.\u003C\u003Ec__DisplayClass6_0.GptwE9ZS2frBg0nLqZEc(ParsedQueryParameters.Parameter.\u003C\u003Ec__DisplayClass6_0.kmpWEjZSOYVV3HpuCosX((object) p), (object) propertyName)));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 6 : 1;
              continue;
            case 4:
              this.parentTypeUid = ParsedQueryParameters.Parameter.FWe2b3CYxSDU2paZMG3s((object) parentMetadata);
              num = 7;
              continue;
            case 5:
              this.SubTypeUid = propertyMetadata != null ? ParsedQueryParameters.Parameter.rCHfu3CYm5sBpjXVPOre((object) propertyMetadata) : Guid.Empty;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
              continue;
            case 6:
              this.TypeUid = propertyMetadata == null ? Guid.Empty : ParsedQueryParameters.Parameter.swlguJCY03VVUOneY02n((object) propertyMetadata);
              num = 5;
              continue;
            case 7:
              this.propertyName = (object) propertyName;
              num = 3;
              continue;
            default:
              goto label_7;
          }
        }
label_10:
        return;
label_7:;
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
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
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

      public bool Check(EntityMetadata parentMetadata, string propertyName, bool isCollection)
      {
        int num1 = 18;
        Type type1;
        Type type2;
        while (true)
        {
          int num2 = num1;
          PropertyMetadata propertyMetadata;
          while (true)
          {
            Type type3;
            string propertyName1;
            switch (num2)
            {
              case 1:
                if (ParsedQueryParameters.Parameter.mUpv5dCYMd2Ra6DeKxfN(this.TypeUid, propertyMetadata == null ? Guid.Empty : ParsedQueryParameters.Parameter.swlguJCY03VVUOneY02n((object) propertyMetadata)))
                {
                  num2 = 11;
                  continue;
                }
                goto case 9;
              case 2:
                type3 = this.Type;
                break;
              case 3:
                type3 = this.Type.GetInterface(TypeOf.IEnumerable.FullName).GetGenericArguments()[0];
                break;
              case 4:
                if (this.isCollection != isCollection)
                {
                  num2 = 8;
                  continue;
                }
                // ISSUE: reference to a compiler-generated method
                propertyMetadata = parentMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => ParsedQueryParameters.Parameter.\u003C\u003Ec__DisplayClass11_0.p1hSpCZS3x6heBuAteaK((object) p.Name, (object) propertyName1)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
                continue;
              case 5:
                this.typeSettings = propertyMetadata != null ? ParsedQueryParameters.Parameter.BfMbOyCYy51l52iXTmpi((object) propertyMetadata) : (object) null;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
                continue;
              case 6:
                this.TypeUid = propertyMetadata == null ? Guid.Empty : ParsedQueryParameters.Parameter.swlguJCY03VVUOneY02n((object) propertyMetadata);
                num2 = 13;
                continue;
              case 7:
                if (!ParsedQueryParameters.Parameter.tQ3uWbCY9ePIVn1Z3U6W(type2, type1))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 6 : 19;
                  continue;
                }
                goto case 14;
              case 8:
                goto label_18;
              case 9:
                if (isCollection)
                {
                  num2 = 3;
                  continue;
                }
                goto case 2;
              case 10:
                this.propertyName = (object) propertyName1;
                num2 = 6;
                continue;
              case 11:
                if (!(this.SubTypeUid == (propertyMetadata != null ? ParsedQueryParameters.Parameter.rCHfu3CYm5sBpjXVPOre((object) propertyMetadata) : Guid.Empty)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 9 : 0;
                  continue;
                }
                goto label_4;
              case 12:
                goto label_4;
              case 13:
                goto label_27;
              case 14:
                this.parentTypeUid = parentMetadata.Uid;
                num2 = 10;
                continue;
              case 15:
                goto label_15;
              case 16:
                type1 = ParsedQueryParameters.Parameter.laMcyBCYJMeyQpfuekHJ(this.parentTypeUid, (object) propertyName1, false);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 6 : 7;
                continue;
              case 17:
                propertyName1 = propertyName;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 4 : 2;
                continue;
              case 18:
                num2 = 17;
                continue;
              case 19:
                goto label_16;
              default:
                this.propertyType = isCollection ? (Type) null : type1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 7 : 15;
                continue;
            }
            type2 = type3;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 16 : 13;
          }
label_27:
          this.SubTypeUid = propertyMetadata == null ? Guid.Empty : propertyMetadata.SubTypeUid;
          num1 = 5;
        }
label_4:
        return true;
label_15:
        return true;
label_16:
        return ParsedQueryParameters.Parameter.tQ3uWbCY9ePIVn1Z3U6W(type1, type2);
label_18:
        return false;
      }

      public Guid TypeUid
      {
        get => this.\u003CTypeUid\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CTypeUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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

      public Guid SubTypeUid
      {
        get => this.\u003CSubTypeUid\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CSubTypeUid\u003Ek__BackingField = value;
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

      public TypeSettings TypeSettings
      {
        get
        {
          int num1 = 3;
          while (true)
          {
            int num2 = num1;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  ParsedQueryParameters.Parameter.rdOWbuCYl7BJf8MnL7uH((object) typeSettings, this.isCollection ? RelationType.ManyToMany : RelationType.OneToOne);
                  num2 = 6;
                  continue;
                case 2:
                case 6:
                  goto label_7;
                case 3:
                  if (!(this.typeSettings is EntitySettings typeSettings))
                  {
                    num2 = 2;
                    continue;
                  }
                  break;
                case 4:
                  goto label_6;
                case 5:
                  typeSettings = (EntitySettings) this.typeSettings;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
                  continue;
              }
              if (this.isCollection == (typeSettings.RelationType == RelationType.OneToOne))
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 4 : 0;
              else
                goto label_7;
            }
label_6:
            this.typeSettings = ParsedQueryParameters.Parameter.qejEfuCYdoBaKaIVC4xY(this.typeSettings);
            num1 = 5;
          }
label_7:
          return (TypeSettings) this.typeSettings;
        }
      }

      public Type Type
      {
        get
        {
          int num = 2;
          Type type;
          Type propertyType;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.propertyType = type = ParsedQueryParameters.Parameter.laMcyBCYJMeyQpfuekHJ(this.parentTypeUid, this.propertyName, this.isCollection);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
                continue;
              case 2:
                propertyType = this.propertyType;
                if ((object) propertyType == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 1;
                  continue;
                }
                goto label_2;
              default:
                goto label_6;
            }
          }
label_2:
          return propertyType;
label_6:
          return type;
        }
      }

      private static Type GetType(Guid parentTypeUid, object propertyName, bool isCollection)
      {
        int num1 = 8;
        Type type1;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            Type type2;
            int num3;
            switch (num2)
            {
              case 1:
                type2 = ParsedQueryParameters.Parameter.uQ8lHeCYYqhprQayFTmA((object) TypeOf.List).MakeGenericType(type1);
                goto label_18;
              case 2:
                goto label_4;
              case 3:
                num3 = type1 != TypeOf<string>.Raw ? 1 : 0;
                break;
              case 4:
                if (isCollection)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                  continue;
                }
                goto case 5;
              case 5:
                type2 = type1.GetInterface((string) ParsedQueryParameters.Parameter.TOYS4rCY53ICS447jodm((object) TypeOf.IEnumerable)).GetGenericArguments()[0];
                goto label_18;
              case 6:
                num3 = 0;
                break;
              case 7:
                if (!ParsedQueryParameters.Parameter.QgS7Z1CYgO86QIM3tZbn(type1))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 6;
                  continue;
                }
                goto case 3;
              case 8:
                goto label_7;
              default:
                // ISSUE: type reference
                if (!ParsedQueryParameters.Parameter.Qg8nYhCYjIV1AJTSYM5G(__typeref (IEntity)).IsAssignableFrom(type1))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
                  continue;
                }
                type2 = ParsedQueryParameters.Parameter.uQ8lHeCYYqhprQayFTmA((object) TypeOf.Iesi_ISet).MakeGenericType(type1);
                goto label_18;
            }
            int num4 = isCollection ? 1 : 0;
            if (num3 != num4)
            {
              num2 = 4;
              continue;
            }
            goto label_4;
label_18:
            type1 = type2;
            num2 = 2;
          }
label_7:
          type1 = ParsedQueryParameters.Parameter.oYtxXFCYrH0a9dJaNriI((object) MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(parentTypeUid).GetProperty((string) propertyName));
          num1 = 7;
        }
label_4:
        return type1;
      }

      internal static bool v9H9gbCYH89FyJOltpxO() => ParsedQueryParameters.Parameter.DYqX9rCY6oSeeBnlwFb4 == null;

      internal static ParsedQueryParameters.Parameter cIlGwKCYAkIHqmmtQQTm() => (ParsedQueryParameters.Parameter) ParsedQueryParameters.Parameter.DYqX9rCY6oSeeBnlwFb4;

      internal static void YnH6QCCY7SHypyVNr73M() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static Guid FWe2b3CYxSDU2paZMG3s([In] object obj0) => ((AbstractMetadata) obj0).Uid;

      internal static Guid swlguJCY03VVUOneY02n([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

      internal static Guid rCHfu3CYm5sBpjXVPOre([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

      internal static object BfMbOyCYy51l52iXTmpi([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

      internal static bool mUpv5dCYMd2Ra6DeKxfN([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

      internal static Type laMcyBCYJMeyQpfuekHJ(Guid parentTypeUid, [In] object obj1, bool isCollection) => ParsedQueryParameters.Parameter.GetType(parentTypeUid, obj1, isCollection);

      internal static bool tQ3uWbCY9ePIVn1Z3U6W(Type source, Type target) => source.IsCompatibleWith(target);

      internal static object qejEfuCYdoBaKaIVC4xY([In] object obj0) => (object) ((TypeSettings) obj0).Clone();

      internal static void rdOWbuCYl7BJf8MnL7uH([In] object obj0, RelationType value) => ((EntitySettings) obj0).RelationType = value;

      internal static Type oYtxXFCYrH0a9dJaNriI([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

      internal static bool QgS7Z1CYgO86QIM3tZbn(Type type) => type.IsEnumerable();

      internal static object TOYS4rCY53ICS447jodm([In] object obj0) => (object) ((RipeType) obj0).FullName;

      internal static Type Qg8nYhCYjIV1AJTSYM5G([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static Type uQ8lHeCYYqhprQayFTmA([In] object obj0) => ((RipeType) obj0).Raw;
    }

    private class SerializableDictionary : 
      EleWise.ELMA.Serialization.SerializableDictionary<string, ParsedQueryParameters.Parameter>,
      IDictionary<string, object>,
      ICollection<KeyValuePair<string, object>>,
      IEnumerable<KeyValuePair<string, object>>,
      IEnumerable
    {
      private object values;
      internal static object idSyOxCYLyx6eFBAyvZf;

      object IDictionary<string, object>.this[string key]
      {
        get => ParsedQueryParameters.SerializableDictionary.xohFbmCYckBIJPutg4ML((object) this[key]);
        set
        {
          int num = 2;
          ParsedQueryParameters.Parameter parameter;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_4;
              case 1:
                parameter.Value = value;
                num = 3;
                continue;
              case 2:
                if (!this.TryGetValue(key, out parameter))
                {
                  this[key] = new ParsedQueryParameters.Parameter(value);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                  continue;
                }
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
                continue;
              case 3:
                goto label_2;
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
      }

      bool ICollection<KeyValuePair<string, object>>.IsReadOnly => false;

      ICollection<string> IDictionary<string, object>.Keys => (ICollection<string>) this.Keys;

      ICollection<object> IDictionary<string, object>.Values => (ICollection<object>) this.values ?? (ICollection<object>) (this.values = (object) new ParsedQueryParameters.SerializableDictionary.ValueCollection((IDictionary<string, ParsedQueryParameters.Parameter>) this));

      void IDictionary<string, object>.Add(string key, object value)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.Add(key, new ParsedQueryParameters.Parameter(value));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> item) => this.Add(item.Key, new ParsedQueryParameters.Parameter(item.Value));

      bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> item)
      {
        ParsedQueryParameters.Parameter parameter;
        return this.TryGetValue(item.Key, out parameter) && parameter.Value == parameter;
      }

      void ICollection<KeyValuePair<string, object>>.CopyTo(
        KeyValuePair<string, object>[] array,
        int arrayIndex)
      {
        int num1 = 7;
        System.Collections.Generic.Dictionary<string, ParsedQueryParameters.Parameter>.Enumerator enumerator;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_24;
            case 1:
              goto label_2;
            case 2:
              goto label_12;
            case 3:
              if (arrayIndex <= array.Length)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 5;
                continue;
              }
              goto label_2;
            case 4:
              goto label_9;
            case 5:
              if (array.Length - arrayIndex < ParsedQueryParameters.SerializableDictionary.aC1GOFCLF9lfsmcrJgac((object) this))
              {
                num1 = 8;
                continue;
              }
              enumerator = this.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 2;
              continue;
            case 6:
              if (arrayIndex >= 0)
              {
                num1 = 3;
                continue;
              }
              goto label_2;
            case 7:
              if (array != null)
              {
                num1 = 6;
                continue;
              }
              goto label_9;
            case 8:
              goto label_26;
            default:
              goto label_20;
          }
        }
label_24:
        return;
label_20:
        return;
label_2:
        throw new ArgumentOutOfRangeException((string) ParsedQueryParameters.SerializableDictionary.m75mi6CYzwkRnkWBsVSS(~210725948 ^ -210425689));
label_9:
        throw new ArgumentNullException((string) ParsedQueryParameters.SerializableDictionary.m75mi6CYzwkRnkWBsVSS(-740338220 ^ -740626814));
label_12:
        try
        {
label_15:
          if (enumerator.MoveNext())
            goto label_18;
          else
            goto label_16;
label_13:
          KeyValuePair<string, ParsedQueryParameters.Parameter> current;
          int num2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_18;
              case 2:
                goto label_14;
              case 3:
                goto label_15;
              default:
                array[arrayIndex++] = new KeyValuePair<string, object>(current.Key, current.Value.Value);
                num2 = 3;
                continue;
            }
          }
label_14:
          return;
label_16:
          num2 = 2;
          goto label_13;
label_18:
          current = enumerator.Current;
          num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
          {
            num2 = 0;
            goto label_13;
          }
          else
            goto label_13;
        }
        finally
        {
          enumerator.Dispose();
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
            num3 = 0;
          switch (num3)
          {
            default:
          }
        }
label_26:
        throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239924956));
      }

      bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> item) => ((ICollection<KeyValuePair<string, object>>) this).Contains(item) && this.Remove(item.Key);

      bool IDictionary<string, object>.TryGetValue(string key, out object value)
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              value = (object) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
              continue;
            case 3:
              ParsedQueryParameters.Parameter parameter;
              if (!this.TryGetValue(key, out parameter))
              {
                num = 2;
                continue;
              }
              value = parameter.Value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return true;
label_5:
        return false;
      }

      IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator() => (IEnumerator<KeyValuePair<string, object>>) new ParsedQueryParameters.SerializableDictionary.Enumerator((IDictionary<string, ParsedQueryParameters.Parameter>) this);

      public SerializableDictionary()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object xohFbmCYckBIJPutg4ML([In] object obj0) => ((ParsedQueryParameters.Parameter) obj0).Value;

      internal static bool Eu8J6BCYUTxweP7R0S2i() => ParsedQueryParameters.SerializableDictionary.idSyOxCYLyx6eFBAyvZf == null;

      internal static ParsedQueryParameters.SerializableDictionary WKbrZaCYsZhBWor6HJaA() => (ParsedQueryParameters.SerializableDictionary) ParsedQueryParameters.SerializableDictionary.idSyOxCYLyx6eFBAyvZf;

      internal static object m75mi6CYzwkRnkWBsVSS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static int aC1GOFCLF9lfsmcrJgac([In] object obj0) => __nonvirtual (((System.Collections.Generic.Dictionary<string, ParsedQueryParameters.Parameter>) obj0).Count);

      [DebuggerDisplay("Count = {Count}")]
      [DebuggerTypeProxy(typeof (ParsedQueryParameters.SerializableDictionary.ValueCollection.CollectionDebugView))]
      [Serializable]
      private new sealed class ValueCollection : 
        ICollection<object>,
        IEnumerable<object>,
        IEnumerable,
        ICollection,
        IReadOnlyCollection<object>
      {
        private IDictionary<string, ParsedQueryParameters.Parameter> dictionary;
        private static object ODHk7mZSp5BGQpYaPaL2;

        public ValueCollection(
          IDictionary<string, ParsedQueryParameters.Parameter> dictionary)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          this.dictionary = dictionary;
        }

        public IEnumerator<object> GetEnumerator() => (IEnumerator<object>) new ParsedQueryParameters.SerializableDictionary.ValueCollection.Enumerator(this.dictionary);

        public void CopyTo(Array array, int index)
        {
          int num1 = 4;
          IEnumerator<object> enumerator;
          while (true)
          {
            int num2 = num1;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  goto label_21;
                case 2:
                  goto label_6;
                case 3:
                  if (index >= 0)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 7 : 2;
                    continue;
                  }
                  goto label_3;
                case 4:
                  if (array != null)
                  {
                    num2 = 3;
                    continue;
                  }
                  goto label_21;
                case 5:
                  goto label_3;
                case 6:
                  goto label_26;
                case 7:
                  if (index <= ParsedQueryParameters.SerializableDictionary.ValueCollection.X6xPEuZSw4kFgyUg1La3((object) array))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                    continue;
                  }
                  goto label_3;
                case 8:
                  goto label_28;
                case 9:
                  goto label_27;
                default:
                  if (ParsedQueryParameters.SerializableDictionary.ValueCollection.X6xPEuZSw4kFgyUg1La3((object) array) - index >= this.dictionary.Count)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 8 : 6;
                    continue;
                  }
                  goto label_27;
              }
            }
label_28:
            enumerator = this.GetEnumerator();
            num1 = 2;
          }
label_26:
          return;
label_3:
          throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921185097));
label_6:
          try
          {
label_10:
            if (ParsedQueryParameters.SerializableDictionary.ValueCollection.YwXjF6ZS6CbbLv2uJLTI((object) enumerator))
              goto label_8;
            else
              goto label_11;
label_7:
            object current;
            int num3;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  ParsedQueryParameters.SerializableDictionary.ValueCollection.X7xliWZS48ZWIk2SyHDO((object) array, current, index++);
                  num3 = 2;
                  continue;
                case 2:
                  goto label_10;
                case 3:
                  goto label_20;
                default:
                  goto label_8;
              }
            }
label_20:
            return;
label_8:
            current = enumerator.Current;
            num3 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
            {
              num3 = 1;
              goto label_7;
            }
            else
              goto label_7;
label_11:
            num3 = 3;
            goto label_7;
          }
          finally
          {
            int num4;
            if (enumerator == null)
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            else
              goto label_16;
label_15:
            switch (num4)
            {
              case 1:
                break;
              default:
            }
label_16:
            enumerator.Dispose();
            num4 = 2;
            goto label_15;
          }
label_21:
          throw new ArgumentNullException((string) ParsedQueryParameters.SerializableDictionary.ValueCollection.MpVQnyZSt5XQMHeInJcx(236071375 ^ 236425881));
label_27:
          throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883124582));
        }

        public int Count => ParsedQueryParameters.SerializableDictionary.ValueCollection.JDjmeBZSHDy4PvAGGtDV((object) this.dictionary);

        bool ICollection<object>.IsReadOnly => true;

        void ICollection<object>.Add(object item) => throw new NotSupportedException();

        bool ICollection<object>.Remove(object item) => throw new NotSupportedException();

        void ICollection<object>.Clear() => throw new NotSupportedException();

        bool ICollection<object>.Contains(object item) => this.Contains<object>(item);

        IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

        void ICollection<object>.CopyTo(object[] array, int index)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.CopyTo((Array) array, index);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        bool ICollection.IsSynchronized => false;

        object ICollection.SyncRoot => ParsedQueryParameters.SerializableDictionary.ValueCollection.YA0JmlZSAIZsgDLBBMES((object) (ICollection) this.dictionary);

        internal static object MpVQnyZSt5XQMHeInJcx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static int X6xPEuZSw4kFgyUg1La3([In] object obj0) => ((Array) obj0).Length;

        internal static void X7xliWZS48ZWIk2SyHDO([In] object obj0, [In] object obj1, [In] int obj2) => ((Array) obj0).SetValue(obj1, obj2);

        internal static bool YwXjF6ZS6CbbLv2uJLTI([In] object obj0) => ((IEnumerator) obj0).MoveNext();

        internal static bool ziSiGKZSaVgGC8BYko1a() => ParsedQueryParameters.SerializableDictionary.ValueCollection.ODHk7mZSp5BGQpYaPaL2 == null;

        internal static ParsedQueryParameters.SerializableDictionary.ValueCollection znVvDTZSDQFV69pvd3qc() => (ParsedQueryParameters.SerializableDictionary.ValueCollection) ParsedQueryParameters.SerializableDictionary.ValueCollection.ODHk7mZSp5BGQpYaPaL2;

        internal static int JDjmeBZSHDy4PvAGGtDV([In] object obj0) => ((ICollection<KeyValuePair<string, ParsedQueryParameters.Parameter>>) obj0).Count;

        internal static object YA0JmlZSAIZsgDLBBMES([In] object obj0) => ((ICollection) obj0).SyncRoot;

        [Serializable]
        private sealed class Enumerator : IEnumerator<object>, IDisposable, IEnumerator
        {
          private readonly IEnumerator<KeyValuePair<string, ParsedQueryParameters.Parameter>> enumerator;
          private static object ej8wGYZpHcx0HJ5lWV5s;

          internal Enumerator(
            IDictionary<string, ParsedQueryParameters.Parameter> dictionary)
          {
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            // ISSUE: explicit constructor call
            base.\u002Ector();
            this.enumerator = dictionary.GetEnumerator();
          }

          public void Dispose()
          {
          }

          public bool MoveNext() => this.enumerator.MoveNext();

          public object Current
          {
            get
            {
              int num = 1;
              KeyValuePair<string, ParsedQueryParameters.Parameter> current;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    current = this.enumerator.Current;
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_3:
              return ParsedQueryParameters.SerializableDictionary.ValueCollection.Enumerator.LLR1QZZpx9E1HsSG2gRp((object) current.Value);
            }
          }

          public void Reset()
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  this.enumerator.Reset();
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }

          internal static bool HT6A6YZpA73IHGKOm1Qo() => ParsedQueryParameters.SerializableDictionary.ValueCollection.Enumerator.ej8wGYZpHcx0HJ5lWV5s == null;

          internal static ParsedQueryParameters.SerializableDictionary.ValueCollection.Enumerator MENtJdZp72dBZhLwuKLQ() => (ParsedQueryParameters.SerializableDictionary.ValueCollection.Enumerator) ParsedQueryParameters.SerializableDictionary.ValueCollection.Enumerator.ej8wGYZpHcx0HJ5lWV5s;

          internal static object LLR1QZZpx9E1HsSG2gRp([In] object obj0) => ((ParsedQueryParameters.Parameter) obj0).Value;
        }

        private sealed class CollectionDebugView
        {
          private ICollection<object> collection;
          internal static object vjFqmQZp0gHuVp5G0Ksm;

          public CollectionDebugView(ICollection<object> collection)
          {
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            // ISSUE: explicit constructor call
            base.\u002Ector();
            this.collection = collection;
          }

          [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
          public object[] Items
          {
            get
            {
              int num = 2;
              object[] array;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    this.collection.CopyTo(array, 0);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    array = new object[ParsedQueryParameters.SerializableDictionary.ValueCollection.CollectionDebugView.g8JaOAZpMVeRlADMVu1M((object) this.collection)];
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_3:
              return array;
            }
          }

          internal static int g8JaOAZpMVeRlADMVu1M([In] object obj0) => ((ICollection<object>) obj0).Count;

          internal static bool pmE5vLZpmvkRyk9FgNL2() => ParsedQueryParameters.SerializableDictionary.ValueCollection.CollectionDebugView.vjFqmQZp0gHuVp5G0Ksm == null;

          internal static ParsedQueryParameters.SerializableDictionary.ValueCollection.CollectionDebugView VroZ2OZpyM2dObEx4hgG() => (ParsedQueryParameters.SerializableDictionary.ValueCollection.CollectionDebugView) ParsedQueryParameters.SerializableDictionary.ValueCollection.CollectionDebugView.vjFqmQZp0gHuVp5G0Ksm;
        }
      }

      [Serializable]
      private new sealed class Enumerator : 
        IEnumerator<KeyValuePair<string, object>>,
        IDisposable,
        IEnumerator,
        IEnumerator<KeyValuePair<string, ParsedQueryParameters.Parameter>>
      {
        private readonly IEnumerator<KeyValuePair<string, ParsedQueryParameters.Parameter>> enumerator;
        private static object FXounwZS7Rnpjpe7ltDX;

        internal Enumerator(
          IDictionary<string, ParsedQueryParameters.Parameter> dictionary)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          this.enumerator = dictionary.GetEnumerator();
        }

        public void Dispose()
        {
        }

        public bool MoveNext() => ParsedQueryParameters.SerializableDictionary.Enumerator.xDE7nKZSmE6TqKBXn8Yh((object) this.enumerator);

        public KeyValuePair<string, object> Current
        {
          get
          {
            KeyValuePair<string, ParsedQueryParameters.Parameter> current = this.enumerator.Current;
            string key = current.Key;
            current = this.enumerator.Current;
            object obj = current.Value.Value;
            return new KeyValuePair<string, object>(key, obj);
          }
        }

        object IEnumerator.Current => (object) this.Current;

        KeyValuePair<string, ParsedQueryParameters.Parameter> IEnumerator<KeyValuePair<string, ParsedQueryParameters.Parameter>>.Current => this.enumerator.Current;

        public void Reset()
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                ParsedQueryParameters.SerializableDictionary.Enumerator.VinpftZSyyu345qq6rYU((object) this.enumerator);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        internal static bool xDE7nKZSmE6TqKBXn8Yh([In] object obj0) => ((IEnumerator) obj0).MoveNext();

        internal static bool wKvI6EZSxJMl5hJiEQCn() => ParsedQueryParameters.SerializableDictionary.Enumerator.FXounwZS7Rnpjpe7ltDX == null;

        internal static ParsedQueryParameters.SerializableDictionary.Enumerator IygWlHZS0n8oiU4SEdX3() => (ParsedQueryParameters.SerializableDictionary.Enumerator) ParsedQueryParameters.SerializableDictionary.Enumerator.FXounwZS7Rnpjpe7ltDX;

        internal static void VinpftZSyyu345qq6rYU([In] object obj0) => ((IEnumerator) obj0).Reset();
      }
    }
  }
}

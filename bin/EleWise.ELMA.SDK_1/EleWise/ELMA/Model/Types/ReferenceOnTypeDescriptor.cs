// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.ReferenceOnTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.References;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Ссылка на тип"</summary>
  public class ReferenceOnTypeDescriptor : 
    CLRTypeDescriptor<ReferenceOnType, ReferenceOnTypeSettings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{70DC1D0B-F44B-44B9-B9E2-DFE9F8B1DBB3}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private static ReferenceOnTypeDescriptor SOijCMom3SBN9v8QsYra;

    /// <inheritdoc />
    public override Guid Uid => ReferenceOnTypeDescriptor.UID;

    /// <inheritdoc />
    public override string Name => (string) ReferenceOnTypeDescriptor.CHyh54omD1NU2OphFpy7((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787284935));

    /// <inheritdoc />
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <inheritdoc />
    public override bool Visible => false;

    /// <inheritdoc />
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return (ColumnType) null;
    }

    /// <inheritdoc />
    public override IDictionary<string, object> Serialize(
      object obj,
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata,
      EntitySerializationSettings settings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867364557));
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107996852));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanRead)
        return (IDictionary<string, object>) null;
      object obj1 = property.GetValue(obj, (object[]) null);
      SerializableDictionary<string, object> serializableDictionary1 = new SerializableDictionary<string, object>();
      if (obj1 != null)
      {
        ReferenceOnType referenceOnType = (ReferenceOnType) obj1;
        SerializableDictionary<string, object> serializableDictionary2 = serializableDictionary1;
        string name = propertyMetadata.Name;
        SerializableDictionary<string, object> serializableDictionary3 = new SerializableDictionary<string, object>();
        serializableDictionary3.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29237503), (object) referenceOnType.TypeUid);
        serializableDictionary3.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70166921), (object) referenceOnType.SubTypeUid);
        serializableDictionary2[name] = (object) serializableDictionary3;
      }
      else
        serializableDictionary1[propertyMetadata.Name] = (object) null;
      return (IDictionary<string, object>) serializableDictionary1;
    }

    /// <inheritdoc />
    public override void Deserialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      IDictionary<string, object> values)
    {
      if (obj == null || values == null)
        return;
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397247974));
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876048387));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      object obj1;
      if (property == (PropertyInfo) null || !property.CanWrite || values.Count == 0 || !values.TryGetValue(propertyMetadata.Name, out obj1))
        return;
      if (obj1 is string json)
        obj1 = (object) new EntityJsonSerializer().DeserializeJson(json);
      Guid result1;
      Guid result2;
      if (!(obj1 is IDictionary<string, object> dictionary) || !Guid.TryParse(dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576133690)].ToString(), out result1) || !Guid.TryParse(dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420911524)].ToString(), out result2))
        return;
      property.SetValue(obj, (object) new ReferenceOnType(result1, result2));
    }

    public ReferenceOnTypeDescriptor()
    {
      ReferenceOnTypeDescriptor.bEypilomt3SKHfdwOKyX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ReferenceOnTypeDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ReferenceOnTypeDescriptor.bEypilomt3SKHfdwOKyX();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ReferenceOnTypeDescriptor.UID = new Guid((string) ReferenceOnTypeDescriptor.qS0ZAiomwfrWx1XcpISN(-244066886 - -48452443 ^ -195708793));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object CHyh54omD1NU2OphFpy7([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool zc8S4SompUny6UkMf0pG() => ReferenceOnTypeDescriptor.SOijCMom3SBN9v8QsYra == null;

    internal static ReferenceOnTypeDescriptor i1GLuIomanOSsH2IoOnx() => ReferenceOnTypeDescriptor.SOijCMom3SBN9v8QsYra;

    internal static void bEypilomt3SKHfdwOKyX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object qS0ZAiomwfrWx1XcpISN(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}

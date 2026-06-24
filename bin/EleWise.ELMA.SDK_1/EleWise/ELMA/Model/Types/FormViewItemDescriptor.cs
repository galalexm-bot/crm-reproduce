// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.FormViewItemDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Text;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Дескриптор для формы</summary>
  public sealed class FormViewItemDescriptor : CLRTypeDescriptor<FormViewItem>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{F2C82E42-2939-4E8B-AC63-5743C41E39E3}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static FormViewItemDescriptor uqCmaUo4jtI01KPj3Mx5;

    /// <inheritdoc />
    public override Guid Uid => FormViewItemDescriptor.UID;

    /// <inheritdoc />
    public override string Name => (string) FormViewItemDescriptor.Y96ZP1o4sP7sIJlZuSdJ(FormViewItemDescriptor.C4VFU5o4Uld4fTBwrCq0(1925118608 << 2 ^ -889615466));

    /// <inheritdoc />
    public override bool Visible => false;

    /// <inheritdoc />
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <inheritdoc />
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return (ColumnType) null;
    }

    /// <inheritdoc />
    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num1 = 8;
      Newtonsoft.Json.JsonSerializer jsonSerializer1;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ((Collection<JsonConverter>) FormViewItemDescriptor.riKgwNo6oVi2xmT3q5K9((object) jsonSerializer1)).Add((JsonConverter) FormViewItemDescriptor.Y6grwIo6GUDNO6WcKpe6());
            num1 = 3;
            continue;
          case 2:
            goto label_2;
          case 3:
            memoryStream = MemoryHelper.GetMemoryStream();
            num1 = 5;
            continue;
          case 4:
            ((Collection<JsonConverter>) FormViewItemDescriptor.riKgwNo6oVi2xmT3q5K9((object) jsonSerializer1)).Add((JsonConverter) FormViewItemDescriptor.Pfk5myo6h9xVNqsBbu1a());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
            continue;
          case 5:
            goto label_4;
          case 6:
            ((Collection<JsonConverter>) FormViewItemDescriptor.riKgwNo6oVi2xmT3q5K9((object) jsonSerializer1)).Add((JsonConverter) ViewItemConverter.Instance);
            num1 = 9;
            continue;
          case 7:
            goto label_33;
          case 8:
            if (value != null)
            {
              Newtonsoft.Json.JsonSerializer jsonSerializer2 = new Newtonsoft.Json.JsonSerializer();
              FormViewItemDescriptor.pgMVCHo4cqAkO17IBXE9((object) jsonSerializer2, TypeNameHandling.Objects);
              FormViewItemDescriptor.AKsio4o4zfZy1HVJ8mNR((object) jsonSerializer2, DateFormatHandling.IsoDateFormat);
              FormViewItemDescriptor.x8jZVYo6FRlfvQ2a8u6O((object) jsonSerializer2, ReferenceLoopHandling.Ignore);
              FormViewItemDescriptor.u6k1h4o6B7G6XAPJp4Vk((object) jsonSerializer2, (object) new XmlContractResolver());
              jsonSerializer1 = jsonSerializer2;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            }
            num1 = 7;
            continue;
          case 9:
            jsonSerializer1.Converters.Add((JsonConverter) FormViewItemDescriptor.q7OwKuo6bvQ7VJeA7Cg2());
            num1 = 4;
            continue;
          default:
            jsonSerializer1.Converters.Add((JsonConverter) FormViewItemDescriptor.sp7uSwo6WtD6emtm3Cvs());
            num1 = 6;
            continue;
        }
      }
label_2:
      object obj;
      return obj;
label_4:
      try
      {
        StreamWriter streamWriter = new StreamWriter((Stream) memoryStream, (Encoding) EncodingCache.UTF8WithoutEmitIdentifier);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              JsonTextWriter jsonTextWriter = new JsonTextWriter((TextWriter) streamWriter);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  try
                  {
                    FormViewItemDescriptor.lsvXRho6EgTqUfpdStWD((object) jsonTextWriter, Formatting.Indented);
                    int num4 = 3;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          obj = FormViewItemDescriptor.QFNbiqo6Qchmjt6StVOQ((object) memoryStream, FormViewItemDescriptor.IJJmovo6fAEVOJQ52XkC());
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                          continue;
                        case 2:
                          streamWriter.Flush();
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 0;
                          continue;
                        case 3:
                          jsonSerializer1.Serialize((JsonWriter) jsonTextWriter, value);
                          num4 = 2;
                          continue;
                        default:
                          goto label_2;
                      }
                    }
                  }
                  finally
                  {
                    if (jsonTextWriter != null)
                    {
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
                        num5 = 0;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            goto label_22;
                          default:
                            FormViewItemDescriptor.XDiPv1o6C74K6YqSqDbY((object) jsonTextWriter);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
                            continue;
                        }
                      }
                    }
label_22:;
                  }
              }
            }
            finally
            {
              int num6;
              if (streamWriter == null)
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 0;
              else
                goto label_26;
label_25:
              switch (num6)
              {
                case 1:
                case 2:
              }
label_26:
              FormViewItemDescriptor.XDiPv1o6C74K6YqSqDbY((object) streamWriter);
              num6 = 2;
              goto label_25;
            }
        }
      }
      finally
      {
        int num7;
        if (memoryStream == null)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
        else
          goto label_31;
label_30:
        switch (num7)
        {
          case 1:
            break;
          default:
        }
label_31:
        FormViewItemDescriptor.XDiPv1o6C74K6YqSqDbY((object) memoryStream);
        num7 = 2;
        goto label_30;
      }
label_33:
      return (object) null;
    }

    /// <inheritdoc />
    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (!(value is string str))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
              continue;
            }
            goto label_8;
          case 3:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 2;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (object) null;
label_7:
      return new EntityJsonSerializer().ConvertFromSerializable((object) new FormViewItem(), (ClassMetadata) MetadataLoader.LoadMetadata(deserializeToType), (IDictionary<string, object>) value, false);
label_8:
      return MemoryHelper.ActionWithMemoryBuffer<byte, (string, Type), object>(FormViewItemDescriptor.OQaSJCo6v0R36XbB3DWN(FormViewItemDescriptor.IJJmovo6fAEVOJQ52XkC(), (object) str), (str, deserializeToType), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (string, Type), object>(this.DeserializeSimpleAction));
    }

    /// <inheritdoc />
    public override IPropertyDefaultValueContainer GetDefaultContainer(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FormViewItemDescriptor.PrktD3o68saPAU4qJvGH((object) propertyMetadata, FormViewItemDescriptor.C4VFU5o4Uld4fTBwrCq0(~1767720452 ^ -1767706455));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<FormViewItem>((FormViewItem) null);
    }

    private object DeserializeSimpleAction(
      byte[] buffer,
      int offset,
      int length,
      (string, Type) param)
    {
      (string s, Type objectType) = param;
      Encoding.UTF8.GetBytes(s, 0, s.Length, buffer, offset);
      using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream(buffer, offset, length, false))
      {
        using (StreamReader reader = new StreamReader((Stream) memoryStream))
        {
          Newtonsoft.Json.JsonSerializer jsonSerializer = new Newtonsoft.Json.JsonSerializer();
          jsonSerializer.TypeNameHandling = TypeNameHandling.Objects;
          jsonSerializer.DateFormatHandling = DateFormatHandling.IsoDateFormat;
          jsonSerializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
          jsonSerializer.ContractResolver = (IContractResolver) new XmlContractResolver();
          jsonSerializer.SerializationBinder = (ISerializationBinder) KnownTypesBinder.Instance;
          jsonSerializer.Converters.Add((JsonConverter) AbstractJsonConverter.Instance);
          jsonSerializer.Converters.Add((JsonConverter) ComputedValueConverter.Instance);
          jsonSerializer.Converters.Add((JsonConverter) PropertiesContainerConverter.Instance);
          return jsonSerializer.Deserialize((TextReader) reader, objectType);
        }
      }
    }

    public FormViewItemDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static FormViewItemDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FormViewItemDescriptor.Qp2B4Uo6ZxPpe2EbnauA();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            FormViewItemDescriptor.UID = new Guid((string) FormViewItemDescriptor.C4VFU5o4Uld4fTBwrCq0(-882126494 ^ -882267416));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object C4VFU5o4Uld4fTBwrCq0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Y96ZP1o4sP7sIJlZuSdJ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool BXaGIuo4YX1LfBVjhiFR() => FormViewItemDescriptor.uqCmaUo4jtI01KPj3Mx5 == null;

    internal static FormViewItemDescriptor SAwiBso4Le71uiXpKIN7() => FormViewItemDescriptor.uqCmaUo4jtI01KPj3Mx5;

    internal static void pgMVCHo4cqAkO17IBXE9([In] object obj0, [In] TypeNameHandling obj1) => ((Newtonsoft.Json.JsonSerializer) obj0).TypeNameHandling = obj1;

    internal static void AKsio4o4zfZy1HVJ8mNR([In] object obj0, [In] DateFormatHandling obj1) => ((Newtonsoft.Json.JsonSerializer) obj0).DateFormatHandling = obj1;

    internal static void x8jZVYo6FRlfvQ2a8u6O([In] object obj0, [In] ReferenceLoopHandling obj1) => ((Newtonsoft.Json.JsonSerializer) obj0).ReferenceLoopHandling = obj1;

    internal static void u6k1h4o6B7G6XAPJp4Vk([In] object obj0, [In] object obj1) => ((Newtonsoft.Json.JsonSerializer) obj0).ContractResolver = (IContractResolver) obj1;

    internal static object sp7uSwo6WtD6emtm3Cvs() => (object) SimpleTypesConverter.Instance;

    internal static object riKgwNo6oVi2xmT3q5K9([In] object obj0) => (object) ((Newtonsoft.Json.JsonSerializer) obj0).Converters;

    internal static object q7OwKuo6bvQ7VJeA7Cg2() => (object) AbstractJsonConverter.Instance;

    internal static object Pfk5myo6h9xVNqsBbu1a() => (object) ComputedValueConverter.Instance;

    internal static object Y6grwIo6GUDNO6WcKpe6() => (object) PropertiesContainerConverter.Instance;

    internal static void lsvXRho6EgTqUfpdStWD([In] object obj0, [In] Formatting obj1) => ((JsonWriter) obj0).Formatting = obj1;

    internal static object IJJmovo6fAEVOJQ52XkC() => (object) Encoding.UTF8;

    internal static object QFNbiqo6Qchmjt6StVOQ([In] object obj0, [In] object obj1) => (object) ((MemoryStream) obj0).AsString((Encoding) obj1);

    internal static void XDiPv1o6C74K6YqSqDbY([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static int OQaSJCo6v0R36XbB3DWN([In] object obj0, [In] object obj1) => ((Encoding) obj0).GetByteCount((string) obj1);

    internal static void PrktD3o68saPAU4qJvGH([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void Qp2B4Uo6ZxPpe2EbnauA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

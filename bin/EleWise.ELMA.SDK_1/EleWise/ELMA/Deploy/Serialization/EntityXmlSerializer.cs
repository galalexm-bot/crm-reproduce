// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Serialization.EntityXmlSerializer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace EleWise.ELMA.Deploy.Serialization
{
  /// <summary>Xml-сериализатор/десериализатор экспорта-импорта</summary>
  internal class EntityXmlSerializer
  {
    /// <summary>
    /// Константа для определения элемента xml, содержащего xml-сериализумый контент
    /// </summary>
    public const string ConstXmlSerialize = "XmlSerialize";
    private List<string> fileUids;
    private static readonly string IdPropertyName;
    internal static EntityXmlSerializer zDYcnpEwfEGtSddPMSkb;

    /// <summary>
    /// Функция, определяющая нужно ли биндить значения свойств сущности
    /// </summary>
    public Func<IEntity, bool> NeedBindProperties { get; set; }

    /// <summary>
    /// Функция определяющая, требуется ли данное свойство при обработке.
    /// Для пропуска свойства необходимо возвращать <c>false</c>
    /// </summary>
    public Func<PropertyMetadata, bool> PropertyFilter { get; set; }

    /// <summary>
    /// Функция определяющая, требуется ли данный блок при обработке
    /// Для пропуска блока необходимо возвращать <c>false</c>
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Свойство устарело, используйте вместо него NeedBindTablePart", true)]
    public Func<TablePartMetadata, bool> TablePartFilter { get; set; }

    /// <summary>
    /// Функция определяющая, требуется ли данный блок при обработке
    /// Для пропуска блока необходимо возвращать <c>false</c>
    /// </summary>
    public Func<ITablePartMetadata, bool> NeedBindTablePart { get; set; }

    private IDictionary<string, object> SpecialListOfSimpleTypeDescriptorSerialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      EntitySerializationSettings settings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218947700));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345439082));
      PropertyInfo reflectionProperty = obj.GetType().GetReflectionProperty(propertyMetadata.Name);
      if (reflectionProperty == (PropertyInfo) null || !reflectionProperty.CanRead)
        return (IDictionary<string, object>) null;
      object obj1 = reflectionProperty.GetValue(obj, (object[]) null);
      SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
      if (obj1 != null)
      {
        string str1 = ClassSerializationHelper.SerializeObjectByXml(obj1);
        using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream())
        {
          using (StreamWriter streamWriter = new StreamWriter((Stream) memoryStream))
          {
            streamWriter.WriteLine(obj1.GetType().AssemblyQualifiedName);
            streamWriter.Write(str1);
            streamWriter.Flush();
            if (memoryStream.Length > 0L)
            {
              memoryStream.Seek(0L, SeekOrigin.Begin);
              string str2 = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int) memoryStream.Length, memoryStream, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, MemoryStream, string>(this.SpecialListOfSimpleTypeDescriptorSerializeAction));
              serializableDictionary[propertyMetadata.Name] = (object) str2;
            }
            else
              serializableDictionary[propertyMetadata.Name] = (object) null;
          }
        }
      }
      return (IDictionary<string, object>) serializableDictionary;
    }

    /// <summary>Сериализовать данные с использованием буфера</summary>
    /// <param name="buffer">Буфер</param>
    /// <param name="offset">Смещение относительно начала буфера</param>
    /// <param name="length">Длина буфера</param>
    /// <param name="memoryStream">Поток в памяти</param>
    /// <returns>Сериализованные данные</returns>
    private string SpecialListOfSimpleTypeDescriptorSerializeAction(
      byte[] buffer,
      int offset,
      int length,
      MemoryStream memoryStream)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EntityXmlSerializer.T2FyQQEwvtCdhsGt2w2q((object) memoryStream, (object) buffer, offset, length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) EntityXmlSerializer.PijegnEwuegmnIg3qU3U(EntityXmlSerializer.lxKJpxEw87ML3nTCDJJZ((object) buffer, offset, length), EntityXmlSerializer.vUM8fsEwZiwH4uU1iFhF(864270449 << 6 ^ -521268692), (object) "");
    }

    public virtual void SpecialListOfSimpleTypeDescriptorDeserialize(
      object obj,
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata,
      IDictionary<string, object> values)
    {
      if (obj == null || values == null)
        return;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1596993928));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360350031));
      PropertyInfo propertyCached = obj.GetType().GetPropertyCached(propertyMetadata.Name);
      if (propertyCached == (PropertyInfo) null || !propertyCached.CanWrite)
        return;
      Type propertyType = propertyCached.PropertyType;
      object obj1;
      if (!values.TryGetValue(propertyMetadata.Name, out obj1))
        return;
      try
      {
        object obj2 = this.SpecialListOfSimpleTypeDescriptorDeserializeSimple(obj1, propertyType);
        propertyCached.SetValue(obj, obj2, (object[]) null);
      }
      catch
      {
      }
    }

    public object SpecialListOfSimpleTypeDescriptorDeserializeSimple(
      object value,
      Type deserializeToType)
    {
      int num = 3;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            Contract.ArgumentNotNull((object) deserializeToType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222144250));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
            continue;
          case 3:
            EntityXmlSerializer.ugh7rFEwIUytycXJwHIJ(value, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309653814));
            num = 2;
            continue;
          default:
            str = value.ToString();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:
      return MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(EntityXmlSerializer.bxIZCSEwVKISouZYKRSy((object) str) >> 1, str, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, string, object>(this.SpecialListOfSimpleTypeDescriptorDeserializeSimpleAction));
    }

    /// <summary>Десериализовать данные с использованием буфера</summary>
    /// <param name="buffer">Буфер</param>
    /// <param name="offset">Смещение относительно начала буфера</param>
    /// <param name="length">Длина буфера</param>
    /// <param name="value">Сериализованное представление данных</param>
    /// <returns>Десериализованые данные</returns>
    private object SpecialListOfSimpleTypeDescriptorDeserializeSimpleAction(
      byte[] buffer,
      int offset,
      int length,
      string value)
    {
      int num1 = 5;
      MemoryStream memoryStream;
      while (true)
      {
        int num2 = num1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              ++num3;
              num2 = 6;
              continue;
            case 3:
              buffer[offset + num3] = EntityXmlSerializer.g30cCOEwSTDdQgQJC3gC((object) value.Substring(num3 << 1, 2), 16);
              num2 = 2;
              continue;
            case 4:
            case 6:
              if (num3 >= length)
              {
                num2 = 7;
                continue;
              }
              goto case 3;
            case 5:
              goto label_36;
            case 7:
              memoryStream = (MemoryStream) EntityXmlSerializer.oyjoxoEwiHptCUlKXBN7((object) buffer, offset, length, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 1;
              continue;
            default:
              goto label_39;
          }
        }
label_36:
        num3 = 0;
        num1 = 4;
      }
label_5:
      object obj;
      try
      {
        StreamReader streamReader = new StreamReader((Stream) memoryStream);
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
          num4 = 0;
        switch (num4)
        {
          default:
            try
            {
              Type tp = EntityXmlSerializer.f4o1gkEwRR7CtUNc8Z0y((object) streamReader.ReadLine());
              int num5 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
                num5 = 0;
              XmlTextReader reader;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    streamReader.CheckAndCorrectInternalBOMSymbols();
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 2;
                    continue;
                  case 2:
                    reader = new XmlTextReader((TextReader) streamReader);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_14;
                }
              }
label_14:
              try
              {
                obj = ClassSerializationHelper.DeserializeObjectByXml(tp, (XmlReader) reader);
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
                  num6 = 0;
                switch (num6)
                {
                }
              }
              finally
              {
                if (reader != null)
                {
                  int num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
                    num7 = 0;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        goto label_23;
                      default:
                        reader.Dispose();
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 0;
                        continue;
                    }
                  }
                }
label_23:;
              }
            }
            finally
            {
              int num8;
              if (streamReader == null)
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              else
                goto label_27;
label_26:
              switch (num8)
              {
                case 1:
                  break;
                default:
              }
label_27:
              streamReader.Dispose();
              num8 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
              {
                num8 = 2;
                goto label_26;
              }
              else
                goto label_26;
            }
            break;
        }
      }
      finally
      {
        if (memoryStream != null)
        {
          int num9 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
            num9 = 1;
          while (true)
          {
            switch (num9)
            {
              case 1:
                EntityXmlSerializer.U13vRcEwqbO12D5U6VOJ((object) memoryStream);
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                continue;
              default:
                goto label_35;
            }
          }
        }
label_35:;
      }
label_39:
      return obj;
    }

    /// <summary>Сериализовать сущность или объект в Xml</summary>
    /// <param name="obj">Сущность или объект</param>
    /// <param name="settings">Настройки сериализации</param>
    /// <returns>Сериализованная сущность</returns>
    public List<string> Serialize(
      object obj,
      XmlWriter writer,
      EntitySerializationSettings settings,
      ExportRuleList rules = null,
      IMetadata metadataTrunc = null)
    {
      Contract.ArgumentNotNull(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475897999));
      this.fileUids = new List<string>();
      this.ConvertToXmlString(obj, writer, settings, rules, metadataTrunc);
      return this.fileUids;
    }

    /// <summary>Сохранить свойства</summary>
    /// <param name="writer">Средство для записи XML</param>
    /// <param name="typeDescriptor">Описание типа</param>
    /// <param name="values">Список значений</param>
    /// <param name="postSerializerPoints">Расширение для подмены элементов в сериализованных объектах</param>
    private void WriteValues(
      XmlWriter writer,
      IDictionary<string, object> values,
      IEnumerable<IPostEntityXmlSerializer> postSerializerPoints,
      ITypeDescriptor typeDescriptor)
    {
      bool flag1 = false;
      bool flag2 = false;
      if (typeDescriptor != null)
      {
        flag1 = typeDescriptor.Uid == BinaryFileDescriptor.UID;
        flag2 = typeDescriptor.Uid == EnumDescriptor.UID;
      }
      if (values == null)
        return;
      foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) values)
      {
        if (keyValuePair.Value is SerializableDictionary<string, object>)
        {
          SerializableDictionary<string, object> serializableDictionary = keyValuePair.Value as SerializableDictionary<string, object>;
          writer.WriteStartElement(keyValuePair.Key);
          writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1871120939), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633511845));
          writer.WriteString(serializableDictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477167032)].ToString());
          writer.WriteEndElement();
          if (flag1 && !this.fileUids.Contains(serializableDictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420767564)].ToString()))
            this.fileUids.Add(serializableDictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218940120)].ToString());
        }
        else if (keyValuePair.Value is SerializableList<object>)
        {
          writer.WriteStartElement(keyValuePair.Key);
          writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44590215), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199941123));
          foreach (object obj in (List<object>) (keyValuePair.Value as SerializableList<object>))
          {
            if (obj is SerializableDictionary<string, object>)
            {
              SerializableDictionary<string, object> serializableDictionary = obj as SerializableDictionary<string, object>;
              writer.WriteElementString(keyValuePair.Key, serializableDictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411205569)].ToString());
            }
          }
          writer.WriteEndElement();
        }
        else if (keyValuePair.Value is byte[])
        {
          string text = BitConverter.ToString(keyValuePair.Value as byte[]).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281845036), "");
          writer.WriteStartElement(keyValuePair.Key);
          if (typeDescriptor is ListOfSimpleTypeDescriptor)
            writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886878307), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479498170));
          else
            writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289927074), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461631383));
          writer.WriteString(text);
          writer.WriteEndElement();
        }
        else
        {
          bool flag3 = typeDescriptor is EntitySubTypeDescriptor<EntityMetadata>;
          if (keyValuePair.Value != null && (flag3 || typeDescriptor is XmlSerializableObjectTypeDescriptor))
          {
            string str = keyValuePair.Value.ToString();
            foreach (IPostEntityXmlSerializer postSerializerPoint in postSerializerPoints)
              str = postSerializerPoint.Replace(str);
            writer.WriteStartElement(keyValuePair.Key);
            writer.WriteAttributeString(flag3 ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539405453) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647948572), z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459556049));
            writer.WriteCData(str);
            writer.WriteEndElement();
          }
          else if (flag2)
          {
            if (keyValuePair.Value != null)
            {
              writer.WriteStartElement(keyValuePair.Key);
              writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104939198), z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521271730));
              writer.WriteString(keyValuePair.Value.ToString());
              writer.WriteEndElement();
            }
          }
          else if (keyValuePair.Value is string)
          {
            try
            {
              writer.WriteElementString(keyValuePair.Key, XmlConvert.VerifyXmlChars(keyValuePair.Value.ToString()));
            }
            catch (Exception ex)
            {
              if (!(ex is XmlException))
                throw ex;
              writer.WriteStartElement(keyValuePair.Key);
              writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1322791424), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889458610));
              string s = keyValuePair.Value.ToString();
              string str = BitConverter.ToString(Encoding.GetEncoding(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633287137)).GetBytes(s)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583741800), "");
              writer.WriteElementString(keyValuePair.Key, str);
              writer.WriteEndElement();
            }
          }
        }
      }
    }

    /// <summary>Сконвертировать сущность в сериализованный объект</summary>
    /// <param name="obj">Сущность или объект</param>
    /// <param name="settings">Настройки</param>
    /// <returns>Сериализуемый объект</returns>
    private void ConvertToXmlString(
      object obj,
      XmlWriter writer,
      EntitySerializationSettings settings,
      ExportRuleList rules = null,
      IMetadata metadataTrunc = null)
    {
      int num1 = 17;
      ClassMetadata classMetadata;
      // ISSUE: variable of a compiler-generated type
      EntityXmlSerializer.\u003C\u003Ec__DisplayClass35_0 cDisplayClass350;
      IExportRulesService serviceNotNull;
      IEntity entity;
      ExportRuleList source;
      ClassMetadata metadata;
      List<PropertyMetadata>.Enumerator enumerator1;
      IEnumerable<IPostEntityXmlSerializer> extensionPoints;
      IMetadataService service;
      IEnumerator<ITablePartMetadata> enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_79;
          case 2:
            goto label_131;
          case 3:
            enumerator2 = ((ITablePartContainer) metadata).TableParts.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
            continue;
          case 4:
          case 8:
          case 23:
            extensionPoints = ComponentManager.Current.GetExtensionPoints<IPostEntityXmlSerializer>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 15 : 9;
            continue;
          case 5:
            if (classMetadata.Properties == null)
            {
              num1 = 23;
              continue;
            }
            goto case 28;
          case 6:
            enumerator1 = metadata.Properties.GetEnumerator();
            num1 = 27;
            continue;
          case 7:
            if (entity == null)
            {
              num1 = 2;
              continue;
            }
            goto case 3;
          case 9:
            source = new ExportRuleList();
            num1 = 14;
            continue;
          case 10:
            goto label_128;
          case 11:
            goto label_115;
          case 12:
            classMetadata = (ClassMetadata) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 13 : 0;
            continue;
          case 13:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass350.legalPropertyUids = new List<Guid>();
            num1 = 19;
            continue;
          case 14:
            if (rules != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 22 : 13;
              continue;
            }
            goto case 12;
          case 15:
            service = MetadataServiceContext.Service;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 2 : 6;
            continue;
          case 16:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass350.obj = obj;
            num1 = 29;
            continue;
          case 17:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass350 = new EntityXmlSerializer.\u003C\u003Ec__DisplayClass35_0();
            num1 = 16;
            continue;
          case 18:
            classMetadata = InterfaceActivator.LoadMetadata(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(EntityXmlSerializer.MoWboyEwXoISnBUGhqwO((object) metadataTrunc), false)) as ClassMetadata;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          case 19:
            if (metadataTrunc == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 9 : 25;
              continue;
            }
            goto case 18;
          case 20:
            // ISSUE: reference to a compiler-generated field
            source.AddRange((IEnumerable<ExportRule>) EntityXmlSerializer.XS63qoEwKOFLbm594r6w((object) serviceNotNull, (object) (cDisplayClass350.obj as IEntity), (object) rules));
            num1 = 12;
            continue;
          case 21:
label_11:
            // ISSUE: reference to a compiler-generated field
            entity = cDisplayClass350.obj as IEntity;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 24 : 21;
            continue;
          case 22:
            serviceNotNull = Locator.GetServiceNotNull<IExportRulesService>();
            num1 = 20;
            continue;
          case 24:
            if (!(metadata is ITablePartContainer))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 2 : 11;
              continue;
            }
            goto case 7;
          case 26:
            // ISSUE: reference to a compiler-generated field
            metadata = (ClassMetadata) MetadataLoader.LoadMetadata(cDisplayClass350.obj.GetType());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 9 : 4;
            continue;
          case 27:
            try
            {
label_30:
              if (enumerator1.MoveNext())
                goto label_43;
              else
                goto label_31;
label_20:
              // ISSUE: variable of a compiler-generated type
              EntityXmlSerializer.\u003C\u003Ec__DisplayClass35_1 cDisplayClass351;
              int num2;
              while (true)
              {
                PropertyInfo propertyCached;
                object obj1;
                ISerializableTypeDescriptor serializableTypeDescriptor;
                ITypeDescriptor typeDescriptor;
                string assemblyQualifiedName;
                string text;
                IDictionary<string, object> values;
                IDictionary<string, object> dictionary;
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (!cDisplayClass351.CS\u0024\u003C\u003E8__locals1.legalPropertyUids.Contains(EntityXmlSerializer.bL9gvEEwTRQ7gkQebnEj((object) cDisplayClass351.propertyMetadata)))
                    {
                      num2 = 20;
                      continue;
                    }
                    goto case 31;
                  case 2:
                    assemblyQualifiedName = obj1.GetType().AssemblyQualifiedName;
                    num2 = 32;
                    continue;
                  case 3:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass351.CS\u0024\u003C\u003E8__locals1 = cDisplayClass350;
                    num2 = 16;
                    continue;
                  case 4:
                    text = ClassSerializationHelper.SerializeObjectByXml(obj1);
                    num2 = 6;
                    continue;
                  case 5:
                    this.WriteValues(writer, values, extensionPoints, typeDescriptor);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 35 : 4;
                    continue;
                  case 6:
                    text = (string) EntityXmlSerializer.fbE4TjEw1tcIbb6weFVj((object) text, 0, EntityXmlSerializer.WCJKclEwPuyhZForHdW8((object) text, EntityXmlSerializer.vUM8fsEwZiwH4uU1iFhF(1051276242 - 990076387 ^ 61184559)) + 1);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 2;
                    continue;
                  case 7:
                  case 8:
                    // ISSUE: reference to a compiler-generated field
                    EntityXmlSerializer.FsmskdEw3wh5DMgJ0AjP((object) writer, EntityXmlSerializer.sl9cHsEwkRVXFdOG4PT1((object) cDisplayClass351.propertyMetadata));
                    num2 = 9;
                    continue;
                  case 9:
                    writer.WriteAttributeString((string) EntityXmlSerializer.vUM8fsEwZiwH4uU1iFhF(333888594 ^ 1075625116 ^ 1408939544), (string) EntityXmlSerializer.vUM8fsEwZiwH4uU1iFhF(1470440286 ^ 1470445904));
                    num2 = 37;
                    continue;
                  case 10:
                    EntityXmlSerializer.AspYVxEwpWNdVKxnTPL7((object) writer);
                    num2 = 29;
                    continue;
                  case 11:
                    goto label_11;
                  case 12:
                  case 15:
                  case 20:
                  case 29:
                  case 35:
                    goto label_30;
                  case 13:
                    typeDescriptor = InterfaceActivator.Create<ITypeDescriptor>();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 4 : 23;
                    continue;
                  case 14:
                    if (classMetadata != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
                      continue;
                    }
                    goto case 31;
                  case 16:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass351.propertyMetadata = enumerator1.Current;
                    num2 = 27;
                    continue;
                  case 17:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    dictionary = serializableTypeDescriptor.Serialize(cDisplayClass351.CS\u0024\u003C\u003E8__locals1.obj, metadata, cDisplayClass351.propertyMetadata, settings);
                    break;
                  case 18:
                    text = (string) EntityXmlSerializer.iO2vdlEwNqU60A1k97Ou((object) assemblyQualifiedName, (object) text);
                    num2 = 7;
                    continue;
                  case 19:
                    if (!(serializableTypeDescriptor is ListOfSimpleTypeDescriptor))
                    {
                      num2 = 17;
                      continue;
                    }
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    dictionary = this.SpecialListOfSimpleTypeDescriptorSerialize(cDisplayClass351.CS\u0024\u003C\u003E8__locals1.obj, metadata, cDisplayClass351.propertyMetadata, settings);
                    break;
                  case 21:
                    serializableTypeDescriptor = typeDescriptor as ISerializableTypeDescriptor;
                    num2 = 26;
                    continue;
                  case 22:
                    goto label_36;
                  case 23:
                    typeDescriptor = (ITypeDescriptor) null;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 7 : 33;
                    continue;
                  case 24:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    obj1 = EntityXmlSerializer.oYqpqQEweUJc7wEv7AEK((object) propertyCached, cDisplayClass351.CS\u0024\u003C\u003E8__locals1.obj, (object) null);
                    num2 = 28;
                    continue;
                  case 25:
label_55:
                    if (typeDescriptor != null)
                    {
                      num2 = 21;
                      continue;
                    }
                    goto label_36;
                  case 26:
                    if (serializableTypeDescriptor != null)
                    {
                      num2 = 19;
                      continue;
                    }
                    goto label_30;
                  case 27:
                    // ISSUE: reference to a compiler-generated method
                    if (source.Any<ExportRule>(new Func<ExportRule, bool>(cDisplayClass351.\u003CConvertToXmlString\u003Eb__1)))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 14 : 15;
                      continue;
                    }
                    goto case 14;
                  case 28:
                    if (obj1 == null)
                    {
                      num2 = 12;
                      continue;
                    }
                    goto case 4;
                  case 30:
                    goto label_43;
                  case 31:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    propertyCached = cDisplayClass351.CS\u0024\u003C\u003E8__locals1.obj.GetType().GetPropertyCached((string) EntityXmlSerializer.sl9cHsEwkRVXFdOG4PT1((object) cDisplayClass351.propertyMetadata));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                    continue;
                  case 32:
                    if (assemblyQualifiedName == null)
                    {
                      num2 = 8;
                      continue;
                    }
                    goto case 18;
                  case 33:
                    try
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      typeDescriptor = (ITypeDescriptor) EntityXmlSerializer.sewialEwtujUYbunh7JE((object) service, EntityXmlSerializer.txSZ1uEwa8ExwTX6BQVF((object) cDisplayClass351.propertyMetadata), EntityXmlSerializer.tZrWIFEwD5gxZEJBG5oO((object) cDisplayClass351.propertyMetadata));
                      int num3 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
                        num3 = 0;
                      switch (num3)
                      {
                        default:
                          goto label_55;
                      }
                    }
                    catch (Exception ex)
                    {
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
                        num4 = 1;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            EntityXmlSerializer.UWDwMxEw4WNU300fKUuH(EntityXmlSerializer.fT1t11EwwjudWsiWsx8Q(), (object) ex);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_55;
                        }
                      }
                    }
                  case 34:
                    if (EntityXmlSerializer.HZmpRFEw2KHUaAqkKduo((object) propertyCached))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 36 : 36;
                      continue;
                    }
                    goto label_30;
                  case 36:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (EntityXmlSerializer.oYqpqQEweUJc7wEv7AEK((object) propertyCached, cDisplayClass351.CS\u0024\u003C\u003E8__locals1.obj, (object) null) != null)
                    {
                      num2 = 24;
                      continue;
                    }
                    goto label_30;
                  case 37:
                    writer.WriteCData(text);
                    num2 = 10;
                    continue;
                  case 38:
                    if (AttributeHelper<XmlExportAttribute>.GetAttribute(EntityXmlSerializer.k5QRREEwOOUPmXqW6BQ5((object) propertyCached), true) != null)
                    {
                      num2 = 34;
                      continue;
                    }
                    goto case 13;
                  default:
                    if (EntityXmlSerializer.Gaw2BAEwnUwoSOJxbSMF((object) propertyCached, (object) null))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 24 : 38;
                      continue;
                    }
                    goto case 13;
                }
                values = dictionary;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 5 : 3;
              }
label_36:
              // ISSUE: reference to a compiler-generated field
              throw new EleWise.ELMA.Model.Metadata.MetadataException(EleWise.ELMA.SR.T((string) EntityXmlSerializer.vUM8fsEwZiwH4uU1iFhF(1581325282 << 3 ^ -234247808), (object) EntityXmlSerializer.txSZ1uEwa8ExwTX6BQVF((object) cDisplayClass351.propertyMetadata)));
label_31:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 11;
              goto label_20;
label_43:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass351 = new EntityXmlSerializer.\u003C\u003Ec__DisplayClass35_1();
              num2 = 3;
              goto label_20;
            }
            finally
            {
              enumerator1.Dispose();
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
          case 28:
            // ISSUE: reference to a compiler-generated method
            classMetadata.Properties.ForEach(new Action<PropertyMetadata>(cDisplayClass350.\u003CConvertToXmlString\u003Eb__0));
            num1 = 8;
            continue;
          case 29:
            // ISSUE: reference to a compiler-generated field
            EntityXmlSerializer.ugh7rFEwIUytycXJwHIJ(cDisplayClass350.obj, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272583421));
            num1 = 26;
            continue;
          default:
            if (classMetadata == null)
            {
              num1 = 4;
              continue;
            }
            goto case 5;
        }
      }
label_131:
      return;
label_128:
      return;
label_115:
      return;
label_79:
      try
      {
label_106:
        if (enumerator2.MoveNext())
          goto label_110;
        else
          goto label_107;
label_80:
        ITablePartMetadata current1;
        IEnumerable enumerable;
        IEnumerator enumerator3;
        int num6;
        while (true)
        {
          switch (num6)
          {
            case 1:
              if (this.NeedBindTablePart == null)
              {
                num6 = 8;
                continue;
              }
              goto case 13;
            case 2:
              EntityXmlSerializer.FsmskdEw3wh5DMgJ0AjP((object) writer, EntityXmlSerializer.v0EMGDEwAUyTDIODA9ar((object) current1));
              num6 = 5;
              continue;
            case 3:
              goto label_116;
            case 4:
              if (enumerable == null)
              {
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 3 : 10;
                continue;
              }
              goto case 2;
            case 5:
              EntityXmlSerializer.YfOPAREw7uHpxKWMFA14((object) writer, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -881895112), EntityXmlSerializer.vUM8fsEwZiwH4uU1iFhF(1251470110 >> 2 ^ 312860873));
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 14 : 11;
              continue;
            case 6:
            case 8:
              enumerable = EntityXmlSerializer.HR4TgUEwH6ZqnXGQJiSv((object) entity, EntityXmlSerializer.F3KTWWEw6bWjQQXWk21M((object) current1)) as IEnumerable;
              num6 = 4;
              continue;
            case 7:
              goto label_110;
            case 9:
label_81:
              EntityXmlSerializer.AspYVxEwpWNdVKxnTPL7((object) writer);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 11;
              continue;
            case 10:
            case 11:
            case 12:
              goto label_106;
            case 13:
              if (!this.NeedBindTablePart(current1))
              {
                num6 = 12;
                continue;
              }
              goto case 6;
            case 14:
              enumerator3 = enumerable.GetEnumerator();
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            default:
              try
              {
label_91:
                if (EntityXmlSerializer.Leai8PEwxDYPKDE4J09S((object) enumerator3))
                  goto label_86;
                else
                  goto label_92;
label_85:
                IEntity current2;
                int num7;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      this.ConvertToXmlString((object) current2, writer, settings);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      EntityXmlSerializer.YfOPAREw7uHpxKWMFA14((object) writer, EntityXmlSerializer.vUM8fsEwZiwH4uU1iFhF(-105199646 ^ -105216640), (object) EntityXmlSerializer.MoWboyEwXoISnBUGhqwO((object) current1).ToString());
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
                      continue;
                    case 3:
                      goto label_81;
                    case 4:
                      goto label_91;
                    case 5:
                      goto label_86;
                    case 6:
                      EntityXmlSerializer.FsmskdEw3wh5DMgJ0AjP((object) writer, EntityXmlSerializer.v0EMGDEwAUyTDIODA9ar((object) current1));
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 2 : 2;
                      continue;
                    default:
                      EntityXmlSerializer.AspYVxEwpWNdVKxnTPL7((object) writer);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 2 : 4;
                      continue;
                  }
                }
label_86:
                current2 = (IEntity) enumerator3.Current;
                num7 = 6;
                goto label_85;
label_92:
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 3 : 2;
                goto label_85;
              }
              finally
              {
                IDisposable disposable = enumerator3 as IDisposable;
                int num8 = 3;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      EntityXmlSerializer.U13vRcEwqbO12D5U6VOJ((object) disposable);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                      continue;
                    case 3:
                      if (disposable == null)
                      {
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 2 : 2;
                        continue;
                      }
                      goto case 1;
                    default:
                      goto label_98;
                  }
                }
label_98:;
              }
          }
        }
label_116:
        return;
label_107:
        num6 = 3;
        goto label_80;
label_110:
        current1 = enumerator2.Current;
        num6 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        {
          num6 = 0;
          goto label_80;
        }
        else
          goto label_80;
      }
      finally
      {
        int num9;
        if (enumerator2 == null)
          num9 = 2;
        else
          goto label_117;
label_114:
        switch (num9)
        {
          case 1:
            break;
          default:
        }
label_117:
        enumerator2.Dispose();
        num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
        {
          num9 = 0;
          goto label_114;
        }
        else
          goto label_114;
      }
    }

    /// <summary>Чтение xml в набор свойств</summary>
    /// <param name="reader">Средство для чтения xml</param>
    /// <param name="propValues">Список свойств</param>
    /// <param name="typeUid">Уникальный идентификатор типа</param>
    /// <returns></returns>
    public Dictionary<string, Dictionary<string, object>> XmlEntityRead(
      XmlReader reader,
      Dictionary<string, Dictionary<string, object>> propValues,
      Guid typeUid)
    {
      return this.XmlEntityRead(reader, propValues, (MergeUidReplace) null, (MergeReplace) null, typeUid);
    }

    /// <summary>Чтение xml в набор свойств</summary>
    /// <param name="reader">Средство для чтения xml</param>
    /// <param name="propValues">Список свойств</param>
    /// <param name="mergeReplace">Cписок заменяемых uid'ов</param>
    /// <param name="typeUid">Уникальный идентификатор типа</param>
    /// <returns></returns>
    public Dictionary<string, Dictionary<string, object>> XmlEntityRead(
      XmlReader reader,
      Dictionary<string, Dictionary<string, object>> propValues,
      MergeReplace mergeReplace,
      Guid typeUid)
    {
      return this.XmlEntityRead(reader, propValues, (MergeUidReplace) null, mergeReplace, typeUid);
    }

    /// <summary>Чтение xml в набор свойств</summary>
    /// <param name="reader">Средство для чтения xml</param>
    /// <param name="propValues">Список свойств</param>
    /// <param name="mergeUidReplace">Список заменяемых уникальных идентификаторов объектов</param>
    /// <param name="mergeReplace">Cписок заменяемых uid'ов</param>
    /// <param name="typeUid">Уникальный идентификатор типа</param>
    /// <returns></returns>
    public Dictionary<string, Dictionary<string, object>> XmlEntityRead(
      XmlReader reader,
      Dictionary<string, Dictionary<string, object>> propValues,
      MergeUidReplace mergeUidReplace,
      MergeReplace mergeReplace,
      Guid typeUid)
    {
      if (mergeUidReplace == null)
        mergeUidReplace = new MergeUidReplace();
      if (mergeReplace == null)
        mergeReplace = new MergeReplace();
      Contract.ArgumentNotNull((object) reader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867153517));
      Contract.ArgumentNotNull((object) propValues, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088076888));
      Contract.ArgumentNotNull((object) propValues[ConfigurationImportExecutor.RegularProperty], z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -542024959));
      Contract.ArgumentNotNull((object) propValues[ConfigurationImportExecutor.XmlProperty], z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672424466));
      IEnumerable<IPostEntityXmlSerializer> extensionPoints = ComponentManager.Current.GetExtensionPoints<IPostEntityXmlSerializer>();
      while (reader.NodeType != XmlNodeType.EndElement)
      {
        string nameReplaceProperty = mergeReplace.GetNameReplaceProperty(typeUid, reader.Name);
        if (!reader.IsEmptyElement)
        {
          if (reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939606162)) != null)
          {
            reader.MoveToElement();
            SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
            serializableDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312841557), (object) this.GetStringMergeUid(typeUid, reader.ReadString(), mergeUidReplace));
            if (!propValues[ConfigurationImportExecutor.RegularProperty].ContainsKey(nameReplaceProperty))
              propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, (object) serializableDictionary);
            reader.Read();
          }
          else if (reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727127884)) != null)
          {
            SerializableList<object> serializableList = new SerializableList<object>();
            reader.Read();
            while (reader.NodeType != XmlNodeType.EndElement)
            {
              reader.MoveToElement();
              SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
              serializableDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459583821), (object) this.GetStringMergeUid(typeUid, reader.ReadElementString(), mergeUidReplace));
              serializableList.Add((object) serializableDictionary);
              reader.Read();
            }
            propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, (object) serializableList);
            reader.Read();
          }
          else if (reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516610896)) != null)
          {
            SerializableList<object> serializableList = new SerializableList<object>();
            reader.Read();
            int content1 = (int) reader.MoveToContent();
            Guid result;
            Guid.TryParse(reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088321094)), out result);
            while (reader.NodeType != XmlNodeType.EndElement)
            {
              Dictionary<string, Dictionary<string, object>> propValues1 = new Dictionary<string, Dictionary<string, object>>();
              propValues1.Add(ConfigurationImportExecutor.RegularProperty, new Dictionary<string, object>());
              propValues1.Add(ConfigurationImportExecutor.XmlProperty, new Dictionary<string, object>());
              reader.Read();
              int content2 = (int) reader.MoveToContent();
              Dictionary<string, Dictionary<string, object>> dictionary = this.XmlEntityRead(reader, propValues1, mergeUidReplace, mergeReplace, result);
              serializableList.Add((object) dictionary[ConfigurationImportExecutor.RegularProperty]);
              reader.Read();
              int content3 = (int) reader.MoveToContent();
            }
            propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, (object) serializableList);
            reader.Read();
          }
          else
          {
            string attribute1 = reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123686838));
            string attribute2 = reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283154121));
            if (attribute1 != null || attribute2 != null)
            {
              reader.MoveToElement();
              string str = reader.ReadString();
              int length = str.Length / 2;
              byte[] numArray = new byte[length];
              for (int index = 0; index < length; ++index)
                numArray[index] = Convert.ToByte(str.Substring(index * 2, 2), 16);
              propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, (object) numArray);
              reader.Read();
            }
            else if (reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921224447)) != null)
            {
              reader.Read();
              reader.MoveToElement();
              string serializedObject = reader.Value;
              foreach (IPostEntityXmlSerializer entityXmlSerializer in extensionPoints)
                serializedObject = entityXmlSerializer.UndoReplace(serializedObject);
              propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, (object) serializedObject);
              reader.Read();
              reader.Read();
            }
            else if (reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740302078)) != null)
            {
              reader.Read();
              reader.MoveToElement();
              string str1 = reader.Value;
              Type type = Type.GetType(str1.Substring(0, str1.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239561292))));
              string str2 = str1.Remove(0, str1.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921218555)));
              StringBuilder stringBuilder = new StringBuilder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921104165));
              stringBuilder.AppendLine(str2);
              string xml = stringBuilder.ToString().Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539392369), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218968814)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606863094), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669368399)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516836526), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3324124));
              propValues[ConfigurationImportExecutor.XmlProperty].Add(nameReplaceProperty, ClassSerializationHelper.DeserializeObjectByXml(type, xml));
              reader.Read();
              reader.Read();
            }
            else if (reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837894071)) != null)
            {
              reader.MoveToElement();
              string str3 = reader.ReadString();
              int length = str3.Length / 2;
              byte[] bytes = new byte[length];
              for (int index = 0; index < length; ++index)
                bytes[index] = Convert.ToByte(str3.Substring(index * 2, 2), 16);
              string str4 = Encoding.GetEncoding(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082106194)).GetString(bytes);
              propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, (object) str4);
              reader.Read();
            }
            else
            {
              reader.MoveToElement();
              string str = reader.ReadString();
              propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, (object) this.GetStringMergeUid(typeUid, str, mergeUidReplace));
              reader.Read();
            }
          }
        }
        else
          reader.Skip();
        int content = (int) reader.MoveToContent();
      }
      return propValues;
    }

    public LinksDictionary Deserialize(object obj, Dictionary<string, object> serObj)
    {
      Contract.ArgumentNotNull(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77711239));
      Contract.ArgumentNotNull((object) serObj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710504374));
      Guid result;
      if (serObj.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360358799)))
        Guid.TryParse(serObj[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574256578)].ToString(), out result);
      else
        result = Guid.Empty;
      Guid baseObjTypeUid = Guid.Empty;
      if (obj is IEntity)
      {
        ClassMetadata classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(obj.CastAsRealType().GetType());
        if (classMetadata != null)
          baseObjTypeUid = classMetadata.Uid;
      }
      return this.ConvertFromSerializable(obj, result, baseObjTypeUid, serObj);
    }

    private LinksDictionary ConvertFromSerializable(
      Dictionary<string, object> serObj,
      Guid baseObjUid,
      Guid baseObjTypeUid,
      Type entityType,
      out IEntity tpItem)
    {
      Contract.ArgumentNotNull((object) serObj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77599375));
      Contract.ArgumentNotNull((object) entityType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477118898));
      object id = this.TryDeserializeEntityId((IDictionary<string, object>) serObj, entityType);
      Guid? nullable = this.TryDeserializeEntityUid((IDictionary<string, object>) serObj, entityType);
      object obj = (object) null;
      IEntityManager entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(entityType);
      if (entityManagerOrNull != null)
      {
        if (id != null)
          obj = entityManagerOrNull.LoadOrNull(id);
        if (obj == null && nullable.HasValue)
          obj = entityManagerOrNull.LoadOrNull(nullable.Value);
      }
      if (obj == null)
        obj = InterfaceActivator.Create(entityType);
      IEntity entity = obj as IEntity;
      tpItem = entity;
      if (id != null && entity != null)
        entity.SetId(id);
      return this.ConvertFromSerializable(obj, baseObjUid, baseObjTypeUid, serObj);
    }

    /// <summary>
    /// Сконвертировать из сериализованного объекта в сущность или объект
    /// </summary>
    /// <param name="obj">Сущность или объект, в который будут записаные десериализованные значения</param>
    /// <param name="serObj">Сериализованный объект</param>
    /// <returns></returns>
    private LinksDictionary ConvertFromSerializable(
      object obj,
      Guid baseObjUid,
      Guid baseObjTypeUid,
      Dictionary<string, object> serObj)
    {
      Contract.ArgumentNotNull(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44843253));
      Contract.ArgumentNotNull((object) serObj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195666027));
      LinksDictionary linksDictionary1 = new LinksDictionary();
      IEntity entity1 = obj as IEntity;
      ClassMetadata metadata = (ClassMetadata) MetadataLoader.LoadMetadata(obj.CastAsRealType().GetType());
      IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
      Dictionary<string, object> values = serObj;
      foreach (PropertyMetadata property in metadata.Properties)
      {
        if (this.PropertyFilter == null || this.PropertyFilter(property))
        {
          ITypeDescriptor typeDescriptor = serviceNotNull.GetTypeDescriptor(property.TypeUid, property.SubTypeUid);
          if (typeDescriptor == null)
            throw new EleWise.ELMA.Model.Metadata.MetadataException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195666043), (object) property.TypeUid));
          if (typeDescriptor is ISerializableTypeDescriptor serializableTypeDescriptor)
          {
            if (serializableTypeDescriptor is ListOfSimpleTypeDescriptor)
              this.SpecialListOfSimpleTypeDescriptorDeserialize(obj, metadata, property, (IDictionary<string, object>) values);
            else
              serializableTypeDescriptor.Deserialize(obj, metadata, property, (IDictionary<string, object>) values);
            if (obj != null && property.Settings is EntitySettings)
            {
              PropertyInfo propertyCached = obj.GetType().GetPropertyCached(property.Name);
              object obj1 = propertyCached.GetValue(obj, (object[]) null);
              if (obj1 is IEntity || obj1 is IEnumerable)
              {
                if (obj1 is IEntity)
                {
                  if (!(obj1 is IEntityMetadata) && ((IEntity) obj1).IsNew())
                  {
                    Guid result;
                    if (values != null && Guid.TryParse(obj1.GetType().GetReflectionProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113873809)).GetValue(obj1, (object[]) null).ToString(), out result))
                      linksDictionary1.AddLink(new LinksDictionaryItem(baseObjUid, baseObjTypeUid, property.Name, result, property.Uid));
                    propertyCached.SetValue(obj, (object) null, (object[]) null);
                  }
                }
                else
                {
                  IEnumerable iSetValue = (IEnumerable) propertyCached.GetValue(obj, (object[]) null);
                  IUntypedCollectionProxy untypedCollectionProxy = (IUntypedCollectionProxy) iSetValue.AsUntypedISet();
                  if (untypedCollectionProxy != null)
                  {
                    List<IEntity> entityList = new List<IEntity>();
                    foreach (IEntity entity2 in iSetValue)
                    {
                      if (entity2.IsNew() && !(entity2 is IEntityMetadata))
                      {
                        Guid result;
                        if (values != null && Guid.TryParse(entity2.GetType().GetReflectionProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137990547)).GetValue((object) entity2, (object[]) null).ToString(), out result))
                          linksDictionary1.AddLink(new LinksDictionaryItem(baseObjUid, baseObjTypeUid, property.Name, result, property.Uid));
                        entityList.Add(entity2);
                      }
                    }
                    foreach (IEntity o in entityList)
                      untypedCollectionProxy.Remove((object) o);
                  }
                }
              }
            }
          }
        }
      }
      if (metadata is ITablePartContainer && entity1 != null)
      {
        foreach (ITablePartMetadata tablePart in (IEnumerable<ITablePartMetadata>) ((ITablePartContainer) metadata).TableParts)
        {
          if (this.NeedBindTablePart == null || this.NeedBindTablePart(tablePart))
          {
            UntypedISetProxy untypedIsetProxy = new UntypedISetProxy(entity1.GetPropertyValue(tablePart.TablePartPropertyUid));
            object obj2;
            if (untypedIsetProxy != null && values != null && values.TryGetValue(tablePart.TablePartPropertyName, out obj2))
            {
              IEnumerable enumerable = obj2 as IEnumerable;
              Type typeByUid = serviceNotNull.GetTypeByUid(tablePart.Uid);
              if (enumerable != null)
              {
                foreach (object obj3 in enumerable)
                {
                  if (obj3 is Dictionary<string, object> serObj1)
                  {
                    IEntity tpItem;
                    LinksDictionary linksDictionary2 = this.ConvertFromSerializable(serObj1, baseObjUid, baseObjTypeUid, typeByUid, out tpItem);
                    if (linksDictionary2 != null && linksDictionary2.Any<ILinksDictionaryItem>())
                    {
                      object obj4;
                      serObj1.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87868209), out obj4);
                      Guid result = Guid.Empty;
                      if (obj4 != null)
                        Guid.TryParse(obj4.ToString(), out result);
                      foreach (LinksDictionaryItem linksDictionaryItem in linksDictionary2.OfType<LinksDictionaryItem>())
                        linksDictionaryItem.TablePartUid = result;
                      linksDictionary1.AddRange((IEnumerable<ILinksDictionaryItem>) linksDictionary2);
                    }
                    tpItem?.SetPropertyValue(tablePart.ParentPropertyUid, (object) entity1);
                    untypedIsetProxy.Add((object) tpItem);
                  }
                }
              }
            }
          }
        }
      }
      return linksDictionary1;
    }

    /// <summary>Попытаться десериализовать идентификатор сущности</summary>
    /// <param name="dictionary">Словарь, который может содержать идентификатор (в ключе Id)</param>
    /// <param name="entityType">Тип сущности</param>
    /// <returns>Идентификатор сущности нужного типа</returns>
    protected virtual object TryDeserializeEntityId(
      IDictionary<string, object> dictionary,
      Type entityType)
    {
      object idValue;
      return dictionary != null && dictionary.TryGetValue(EntityXmlSerializer.IdPropertyName, out idValue) ? ModelHelper.TryConvertEntityId(entityType, idValue) : (object) null;
    }

    /// <summary>
    /// Попытаться десериализовать уникальный идентификатор сущности
    /// </summary>
    /// <param name="dictionary">Словарь, который может содержать идентификатор (в ключе Uid)</param>
    /// <param name="entityType">Тип сущности</param>
    /// <returns>Идентификатор сущности нужного типа</returns>
    protected virtual Guid? TryDeserializeEntityUid(
      IDictionary<string, object> dictionary,
      Type entityType)
    {
      object obj;
      if (dictionary != null && dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867357793), out obj))
      {
        if (obj == null)
          return new Guid?();
        Guid result;
        if (Guid.TryParse(obj.ToString(), out result))
          return new Guid?(result);
      }
      return new Guid?();
    }

    /// <summary>
    /// Проверить строку на равенство и Uid из коллекции замен уникальных идентификаторов
    /// </summary>
    /// <param name="value">Проверяемой значение</param>
    /// <param name="mergeUidReplace">Коллекция уникальных идентификаторов</param>
    /// <returns></returns>
    private string GetStringMergeUid(Guid typeUid, string value, MergeUidReplace mergeUidReplace)
    {
      int num = 1;
      Guid result;
      Guid guid;
      while (true)
      {
        switch (num)
        {
          case 1:
            result = Guid.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            guid = EntityXmlSerializer.ayTpDyEw0ZdqgqvxdHVV((object) mergeUidReplace, result);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 2 : 1;
            continue;
          case 4:
            goto label_2;
          default:
            if (Guid.TryParse(value, out result))
            {
              num = 3;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return value;
label_5:
      return guid.ToString();
    }

    public EntityXmlSerializer()
    {
      EntityXmlSerializer.hNOyZWEwmhXePdwbNDTZ();
      this.fileUids = new List<string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityXmlSerializer()
    {
      int num = 1;
      ParameterExpression parameterExpression;
      while (true)
      {
        switch (num)
        {
          case 1:
            EntityXmlSerializer.hNOyZWEwmhXePdwbNDTZ();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            // ISSUE: method reference
            // ISSUE: type reference
            EntityXmlSerializer.IdPropertyName = LinqUtils.NameOf<IEntity<object>>(Expression.Lambda<Func<IEntity<object>, object>>((Expression) EntityXmlSerializer.cLpvKtEw94aQpKBkrD1g((object) parameterExpression, (object) (MethodInfo) EntityXmlSerializer.HLED49EwJ1BEH72ntwtR(__methodref (IEntity<object>.get_Id), __typeref (IEntity<object>))), parameterExpression));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 2 : 2;
            continue;
          default:
            // ISSUE: type reference
            parameterExpression = (ParameterExpression) EntityXmlSerializer.wHjfYsEwMLOJKLVc8019(EntityXmlSerializer.T9L9vDEwytmIdZIFPEW4(__typeref (IEntity<object>)), EntityXmlSerializer.vUM8fsEwZiwH4uU1iFhF(-882126494 ^ -882157238));
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static int T2FyQQEwvtCdhsGt2w2q([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Read((byte[]) obj1, obj2, obj3);

    internal static object lxKJpxEw87ML3nTCDJJZ([In] object obj0, [In] int obj1, [In] int obj2) => (object) BitConverter.ToString((byte[]) obj0, obj1, obj2);

    internal static object vUM8fsEwZiwH4uU1iFhF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object PijegnEwuegmnIg3qU3U([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static bool BZdW5lEwQf2myOuDcZln() => EntityXmlSerializer.zDYcnpEwfEGtSddPMSkb == null;

    internal static EntityXmlSerializer kJ30mpEwCA1mNp8BgQTR() => EntityXmlSerializer.zDYcnpEwfEGtSddPMSkb;

    internal static void ugh7rFEwIUytycXJwHIJ([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static int bxIZCSEwVKISouZYKRSy([In] object obj0) => ((string) obj0).Length;

    internal static byte g30cCOEwSTDdQgQJC3gC([In] object obj0, [In] int obj1) => Convert.ToByte((string) obj0, obj1);

    internal static object oyjoxoEwiHptCUlKXBN7(
      [In] object obj0,
      int offset,
      int length,
      bool writable)
    {
      return (object) MemoryHelper.GetMemoryStream((byte[]) obj0, offset, length, writable);
    }

    internal static Type f4o1gkEwRR7CtUNc8Z0y([In] object obj0) => Type.GetType((string) obj0);

    internal static void U13vRcEwqbO12D5U6VOJ([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object XS63qoEwKOFLbm594r6w([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IExportRulesService) obj0).BaseMerge((IEntity) obj1, (ExportRuleList) obj2);

    internal static Guid MoWboyEwXoISnBUGhqwO([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static Guid bL9gvEEwTRQ7gkQebnEj([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object sl9cHsEwkRVXFdOG4PT1([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static bool Gaw2BAEwnUwoSOJxbSMF([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static Type k5QRREEwOOUPmXqW6BQ5([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static bool HZmpRFEw2KHUaAqkKduo([In] object obj0) => ((PropertyInfo) obj0).CanRead;

    internal static object oYqpqQEweUJc7wEv7AEK([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static int WCJKclEwPuyhZForHdW8([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    internal static object fbE4TjEw1tcIbb6weFVj([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Remove(obj1, obj2);

    internal static object iO2vdlEwNqU60A1k97Ou([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void FsmskdEw3wh5DMgJ0AjP([In] object obj0, [In] object obj1) => ((XmlWriter) obj0).WriteStartElement((string) obj1);

    internal static void AspYVxEwpWNdVKxnTPL7([In] object obj0) => ((XmlWriter) obj0).WriteEndElement();

    internal static Guid txSZ1uEwa8ExwTX6BQVF([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static Guid tZrWIFEwD5gxZEJBG5oO([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object sewialEwtujUYbunh7JE([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object fT1t11EwwjudWsiWsx8Q() => (object) Logger.Log;

    internal static void UWDwMxEw4WNU300fKUuH([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static Guid F3KTWWEw6bWjQQXWk21M([In] object obj0) => ((ITablePartMetadata) obj0).TablePartPropertyUid;

    internal static object HR4TgUEwH6ZqnXGQJiSv([In] object obj0, Guid propertyUid) => ((IEntity) obj0).GetPropertyValue(propertyUid);

    internal static object v0EMGDEwAUyTDIODA9ar([In] object obj0) => (object) ((ITablePartMetadata) obj0).TablePartPropertyName;

    internal static void YfOPAREw7uHpxKWMFA14([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlWriter) obj0).WriteAttributeString((string) obj1, (string) obj2);

    internal static bool Leai8PEwxDYPKDE4J09S([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static Guid ayTpDyEw0ZdqgqvxdHVV([In] object obj0, Guid uidFrom) => ((MergeUidReplace) obj0).GetUidReplace(uidFrom);

    internal static void hNOyZWEwmhXePdwbNDTZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type T9L9vDEwytmIdZIFPEW4([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object wHjfYsEwMLOJKLVc8019([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object HLED49EwJ1BEH72ntwtR([In] RuntimeMethodHandle obj0, [In] RuntimeTypeHandle obj1) => (object) MethodBase.GetMethodFromHandle(obj0, obj1);

    internal static object cLpvKtEw94aQpKBkrD1g([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);
  }
}

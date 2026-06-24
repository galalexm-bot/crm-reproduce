// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.PropertiesContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EleWise.ELMA.Common
{
  /// <summary>Контейнер для хранения свойств и их значений</summary>
  [Serializable]
  public class PropertiesContainer : IPropertiesContainer, IXmlSerializable
  {
    private readonly Dictionary<string, object> container;
    protected const string KeyName = "key";
    protected const string ItemName = "item";
    internal static PropertiesContainer RJwN8JfVuKGXP2GvKwNs;

    /// <summary>Получить названия свойств</summary>
    /// <returns>Названия свойств</returns>
    public IEnumerable<string> GetProperties() => (IEnumerable<string>) this.container.Keys;

    /// <summary>Получить значение свойства</summary>
    /// <param name="propertyName">Имя свойства</param>
    /// <param name="index"></param>
    /// <returns>Значение свойства</returns>
    public object GetPropertyValue(string propertyName, object[] index)
    {
      int num = 1;
      object propertyValue;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.container.TryGetValue(propertyName, out propertyValue);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return propertyValue;
    }

    /// <summary>Задать значение свойства</summary>
    /// <param name="propertyName">Имя свойства</param>
    /// <param name="index"></param>
    /// <param name="value">Значение свойства</param>
    public void SetPropertyValue(string propertyName, object[] index, object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.container[propertyName] = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Удалить свойство</summary>
    /// <param name="propertyName">Имя свойства</param>
    public void RemoveProperty(string propertyName)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            goto label_2;
          case 3:
            if (!this.container.ContainsKey(propertyName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 2;
              continue;
            }
            break;
        }
        this.container.Remove(propertyName);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
      }
label_6:
      return;
label_2:;
    }

    /// <summary>Контейнер пуст</summary>
    /// <returns></returns>
    public bool IsEmpty() => PropertiesContainer.Chi0tNfVSNLCYngyYH7U((object) this.container) == 0;

    public XmlSchema GetSchema() => (XmlSchema) null;

    public void ReadXml(XmlReader reader)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        XmlSerializer xmlSerializer;
        object obj;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              if (!str.IsNullOrWhiteSpace())
              {
                reader.ReadStartElement((string) PropertiesContainer.amISotfVkYcdI3Dxslqf(1199946765 ^ 1199903859));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 9 : 8;
                continue;
              }
              num2 = 12;
              continue;
            case 3:
              goto label_4;
            case 4:
              goto label_11;
            case 5:
              goto label_10;
            case 6:
              reader.ReadEndElement();
              num2 = 15;
              continue;
            case 7:
              // ISSUE: type reference
              xmlSerializer = new XmlSerializer(PropertiesContainer.iE4fZWfVRmwc12dp2CtP(__typeref (object)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 10 : 0;
              continue;
            case 8:
              if (!PropertiesContainer.LEKk13fVidnRZejeEoPe((object) reader))
              {
                num2 = 7;
                continue;
              }
              goto label_5;
            case 9:
              obj = PropertiesContainer.lpcXIafVnmm1VehGucvM((object) xmlSerializer, (object) reader);
              num2 = 14;
              continue;
            case 10:
              PropertiesContainer.qc9v0XfVqimW2IPgTdBB((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            case 11:
              str = (string) PropertiesContainer.VbvPo4fVXdKqiclJMOQx((object) reader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124560174));
              num2 = 2;
              continue;
            case 12:
              PropertiesContainer.nkRlfCfVTs9YBtvTho8S((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 3;
              continue;
            case 13:
              int num3 = (int) PropertiesContainer.iNNRbvfVKWA8OXsYaqYu((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 6 : 11;
              continue;
            case 14:
              this.container.Add(str, obj);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 6 : 4;
              continue;
            default:
              if (reader.NodeType == XmlNodeType.EndElement)
              {
                num2 = 4;
                continue;
              }
              goto case 13;
          }
        }
label_11:
        PropertiesContainer.nkRlfCfVTs9YBtvTho8S((object) reader);
        num1 = 5;
      }
label_7:
      return;
label_4:
      return;
label_10:
      return;
label_5:;
    }

    public void WriteXml(XmlWriter writer)
    {
      int num1 = 1;
      Dictionary<string, object>.KeyCollection.Enumerator enumerator;
      XmlSerializer xmlSerializer;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            xmlSerializer = new XmlSerializer(PropertiesContainer.iE4fZWfVRmwc12dp2CtP(__typeref (object)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_17;
          case 3:
            goto label_2;
          default:
            enumerator = this.container.Keys.GetEnumerator();
            num1 = 3;
            continue;
        }
      }
label_17:
      return;
label_2:
      try
      {
label_4:
        if (enumerator.MoveNext())
          goto label_9;
        else
          goto label_5;
label_3:
        string current;
        object obj;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              PropertiesContainer.gCtncafV2ArcoWHtk5Rp((object) writer, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236150383), (object) current);
              num2 = 7;
              continue;
            case 3:
              PropertiesContainer.LC5K1jfVPUCYu1P0Q8yU((object) writer);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 1 : 4;
              continue;
            case 4:
              goto label_4;
            case 5:
              goto label_9;
            case 6:
              PropertiesContainer.FYfqVMfVeKt3sHDLpmWL((object) xmlSerializer, (object) writer, obj);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 3;
              continue;
            case 7:
              obj = this.container[current];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 6 : 0;
              continue;
            default:
              PropertiesContainer.nV5sQ3fVOj6t1Bcbbr6N((object) writer, PropertiesContainer.amISotfVkYcdI3Dxslqf(1178210108 ^ 1178249026));
              num2 = 2;
              continue;
          }
        }
label_13:
        return;
label_5:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
        goto label_3;
label_9:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        {
          num2 = 0;
          goto label_3;
        }
        else
          goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public object this[string key]
    {
      get => this.container[key];
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
              this.container[key] = value;
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

    public bool TryGetValue<T>(string key, out T value)
    {
      object obj;
      if (this.container.TryGetValue(key, out obj) && (obj == null && (object) default (T) == null || obj is T))
      {
        value = (T) obj;
        return true;
      }
      value = default (T);
      return false;
    }

    public PropertiesContainer()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.container = new Dictionary<string, object>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool P5JomNfVIrCdFwIirfgO() => PropertiesContainer.RJwN8JfVuKGXP2GvKwNs == null;

    internal static PropertiesContainer u0DguWfVVbjEonBcoIrK() => PropertiesContainer.RJwN8JfVuKGXP2GvKwNs;

    internal static int Chi0tNfVSNLCYngyYH7U([In] object obj0) => ((Dictionary<string, object>) obj0).Count;

    internal static bool LEKk13fVidnRZejeEoPe([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static Type iE4fZWfVRmwc12dp2CtP([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void qc9v0XfVqimW2IPgTdBB([In] object obj0) => ((XmlReader) obj0).ReadStartElement();

    internal static XmlNodeType iNNRbvfVKWA8OXsYaqYu([In] object obj0) => ((XmlReader) obj0).MoveToContent();

    internal static object VbvPo4fVXdKqiclJMOQx([In] object obj0, [In] object obj1) => (object) ((XmlReader) obj0).GetAttribute((string) obj1);

    internal static void nkRlfCfVTs9YBtvTho8S([In] object obj0) => ((XmlReader) obj0).ReadEndElement();

    internal static object amISotfVkYcdI3Dxslqf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object lpcXIafVnmm1VehGucvM([In] object obj0, [In] object obj1) => ((XmlSerializer) obj0).Deserialize((XmlReader) obj1);

    internal static void nV5sQ3fVOj6t1Bcbbr6N([In] object obj0, [In] object obj1) => ((XmlWriter) obj0).WriteStartElement((string) obj1);

    internal static void gCtncafV2ArcoWHtk5Rp([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlWriter) obj0).WriteAttributeString((string) obj1, (string) obj2);

    internal static void FYfqVMfVeKt3sHDLpmWL([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlSerializer) obj0).Serialize((XmlWriter) obj1, obj2);

    internal static void LC5K1jfVPUCYu1P0Q8yU([In] object obj0) => ((XmlWriter) obj0).WriteEndElement();
  }
}

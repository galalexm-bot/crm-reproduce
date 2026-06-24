// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.TableViewsNHType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>Тип NHibernate</summary>
  [Serializable]
  public class TableViewsNHType : XmlSerializableType<List<TableView>>
  {
    private static TableViewsNHType XN1xDkWm37d3QsEG0OEX;

    /// <summary>Загрузить объект из потока</summary>
    /// <param name="stream">Поток</param>
    /// <returns>Объект</returns>
    protected override List<TableView> LoadObjectFromStream(Stream stream)
    {
      using (XmlReader reader = XmlReader.Create(stream))
        return ((TableViewsSerializationContainer) ClassSerializationHelper.DeserializeObjectByXml(TypeOf<TableViewsSerializationContainer>.Raw, reader))?.TableViews;
    }

    /// <summary>Сохранить объект в поток</summary>
    /// <param name="stream">Поток</param>
    /// <param name="obj">Объект</param>
    protected override void SaveObjectToStream(Stream stream, List<TableView> obj)
    {
      if (obj == null)
        return;
      using (XmlWriter writer = XmlWriter.Create(stream))
        ClassSerializationHelper.SerializeObjectByXml((object) new TableViewsSerializationContainer()
        {
          TableViews = obj
        }, writer);
    }

    public TableViewsNHType()
    {
      TableViewsNHType.x7OQZ7WmDsWjRq8GbHK7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void x7OQZ7WmDsWjRq8GbHK7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool uwI04AWmpjDwG1uEAAoT() => TableViewsNHType.XN1xDkWm37d3QsEG0OEX == null;

    internal static TableViewsNHType cHmA47Wma3f3irfE7H48() => TableViewsNHType.XN1xDkWm37d3QsEG0OEX;
  }
}

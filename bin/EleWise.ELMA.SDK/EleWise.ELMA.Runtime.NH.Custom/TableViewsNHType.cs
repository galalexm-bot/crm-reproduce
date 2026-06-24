using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class TableViewsNHType : XmlSerializableType<List<TableView>>
{
	private static TableViewsNHType XN1xDkWm37d3QsEG0OEX;

	protected override List<TableView> LoadObjectFromStream(Stream stream)
	{
		using XmlReader reader = XmlReader.Create(stream);
		return ((TableViewsSerializationContainer)ClassSerializationHelper.DeserializeObjectByXml(TypeOf<TableViewsSerializationContainer>.Raw, reader))?.TableViews;
	}

	protected override void SaveObjectToStream(Stream stream, List<TableView> obj)
	{
		if (obj == null)
		{
			return;
		}
		using XmlWriter writer = XmlWriter.Create(stream);
		ClassSerializationHelper.SerializeObjectByXml(new TableViewsSerializationContainer
		{
			TableViews = obj
		}, writer);
	}

	public TableViewsNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		x7OQZ7WmDsWjRq8GbHK7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void x7OQZ7WmDsWjRq8GbHK7()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool uwI04AWmpjDwG1uEAAoT()
	{
		return XN1xDkWm37d3QsEG0OEX == null;
	}

	internal static TableViewsNHType cHmA47Wma3f3irfE7H48()
	{
		return XN1xDkWm37d3QsEG0OEX;
	}
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.TableViewAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает табличное представление для класса или интерфейса
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
  public class TableViewAttribute : Attribute
  {
    private readonly string serializedView;
    private TableView view;
    internal static TableViewAttribute iXl9imoZtTMerPJKwTfy;

    /// <summary>Ctor</summary>
    /// <param name="serializedView">Представление в XML-сериализованном виде</param>
    public TableViewAttribute(string serializedView)
    {
      TableViewAttribute.nhQJAmoZ6L5swld2o1Gd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.serializedView = serializedView;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Представление</summary>
    public TableView View
    {
      get
      {
        int num = 2;
        TableView view1;
        TableView view2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.view = view1 = ClassSerializationHelper.DeserializeObjectByXml<TableView>(this.serializedView);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
              continue;
            case 2:
              view2 = this.view;
              if (view2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return view2;
label_6:
        return view1;
      }
    }

    internal static void nhQJAmoZ6L5swld2o1Gd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sgJoEkoZwmshu9XMHNyp() => TableViewAttribute.iXl9imoZtTMerPJKwTfy == null;

    internal static TableViewAttribute PpegmQoZ46pR0ble2Hgx() => TableViewAttribute.iXl9imoZtTMerPJKwTfy;
  }
}

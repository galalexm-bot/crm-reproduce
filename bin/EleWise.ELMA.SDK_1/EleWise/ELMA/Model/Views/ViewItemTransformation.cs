// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemTransformation
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Web.Script.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Объект преобразования элемента представления</summary>
  [Component]
  [Serializable]
  public abstract class ViewItemTransformation : BaseTransformation<ViewItem, Guid>, IXsiRoot
  {
    private static ViewItemTransformation b8Oou8o1kOaGsfPXvvaK;

    public string SerializeToJson() => (string) ViewItemTransformation.Kg4P2Ko12pS1I1oyw7u2((object) new ViewItemTransformationSerializer(), (object) this);

    public static ViewItemTransformation DeserializeFromJson(string json) => (ViewItemTransformation) ViewItemTransformation.KqV3eGo1Pqcr0shB6wT3((object) new ViewItemTransformationSerializer(), (object) json, ViewItemTransformation.uBokIfo1efl8qZ6K0DiE(__typeref (ViewItemTransformation)));

    /// <summary>Добавить элемент формы</summary>
    /// <param name="itemUid">Куда</param>
    /// <param name="item">Элемент</param>
    /// <param name="afterItem">После чего вставить</param>
    /// <param name="beforeItem">Перед чем вставить</param>
    /// <returns></returns>
    public static ViewItemTransformationAdd Add(
      Guid itemUid,
      ViewItem item,
      Guid? afterItem = null,
      Guid? beforeItem = null)
    {
      ViewItemTransformationAdd transformationAdd = new ViewItemTransformationAdd();
      transformationAdd.Uid = itemUid;
      transformationAdd.Item = item;
      transformationAdd.AfterItem = afterItem;
      transformationAdd.BeforeItem = beforeItem;
      return transformationAdd;
    }

    /// <summary>Переместить элемент формы</summary>
    /// <param name="itemUid">Куда</param>
    /// <param name="moveItemUid">Что</param>
    /// <param name="afterItem">После чего вставить</param>
    /// <param name="beforeItem">Перед чем вставить</param>
    /// <returns></returns>
    public static ViewItemTransformationMove Move(
      Guid itemUid,
      Guid moveItemUid,
      Guid? afterItem = null,
      Guid? beforeItem = null)
    {
      ViewItemTransformationMove transformationMove = new ViewItemTransformationMove();
      transformationMove.Uid = itemUid;
      transformationMove.MoveItemUid = moveItemUid;
      transformationMove.AfterItem = afterItem;
      transformationMove.BeforeItem = beforeItem;
      return transformationMove;
    }

    /// <summary>Спрятать элемент формы ("удалить")</summary>
    /// <param name="itemUid">Что удалить</param>
    /// <returns></returns>
    public static ViewItemTransformationHide Hide(Guid itemUid)
    {
      ViewItemTransformationHide transformationHide = new ViewItemTransformationHide();
      transformationHide.Uid = itemUid;
      return transformationHide;
    }

    /// <summary>Изменить параметры элемента формы</summary>
    /// <param name="itemUid">Для какого элемента формы менять параметры</param>
    /// <param name="propertyName">Название свойства</param>
    /// <param name="value">Новое значение</param>
    /// <returns></returns>
    public static ViewItemTransformationChange SetPropertyValue(
      Guid itemUid,
      string propertyName,
      object value)
    {
      ViewItemTransformationChange transformationChange = new ViewItemTransformationChange();
      transformationChange.Uid = itemUid;
      transformationChange.PropertyName = propertyName;
      ViewItemTransformation.xFLnSro11tqbxt8LNBR4((object) transformationChange, value);
      return transformationChange;
    }

    protected ViewItemTransformation()
    {
      ViewItemTransformation.oJMWoLo1NjNk3nrtbjj1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object Kg4P2Ko12pS1I1oyw7u2([In] object obj0, [In] object obj1) => (object) ((JavaScriptSerializer) obj0).Serialize(obj1);

    internal static bool ll0m5So1nRDrDusAWh03() => ViewItemTransformation.b8Oou8o1kOaGsfPXvvaK == null;

    internal static ViewItemTransformation i1c8AWo1OBM4PkjQREXS() => ViewItemTransformation.b8Oou8o1kOaGsfPXvvaK;

    internal static Type uBokIfo1efl8qZ6K0DiE([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object KqV3eGo1Pqcr0shB6wT3([In] object obj0, [In] object obj1, [In] Type obj2) => ((JavaScriptSerializer) obj0).Deserialize((string) obj1, obj2);

    internal static void xFLnSro11tqbxt8LNBR4([In] object obj0, [In] object obj1) => ((ViewItemTransformationChange) obj0).Value = obj1;

    internal static void oJMWoLo1NjNk3nrtbjj1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

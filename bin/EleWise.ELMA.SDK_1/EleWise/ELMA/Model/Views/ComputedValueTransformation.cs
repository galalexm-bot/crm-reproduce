// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ComputedValueTransformation
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Transformations.Class;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>
  /// Трансформация для <see cref="T:EleWise.ELMA.Model.Views.ComputedValue" />
  /// </summary>
  [XmlInclude(typeof (ComputedValueTransformationAdd))]
  [XmlInclude(typeof (ComputedValueTransformationHide))]
  [XmlInclude(typeof (ComputedValueTransformationChange))]
  [XmlInclude(typeof (ComputedValueTransformationMove))]
  [Component]
  [Serializable]
  public class ComputedValueTransformation : 
    Transformation<ComputedValue, ComputedValueTransformation, string, ComputedValueTransformationAdd, ComputedValueTransformationMove, ComputedValueTransformationHide, ComputedValueTransformationChange>
  {
    internal static ComputedValueTransformation P07ROOoSv2cq8v3OKKox;

    /// <summary>
    /// Обновить коллекцию <see cref="T:EleWise.ELMA.Model.Views.ComputedValue" />
    /// </summary>
    /// <param name="items">Коллекция <see cref="T:EleWise.ELMA.Model.Views.ComputedValue" /> для изменения</param>
    public void Apply(IList<ComputedValue> items) => this.Apply((ComputedValue) new ComputedValueTransformation.ComputedValueCollectionContainer(items));

    /// <summary>Создать трансформацию</summary>
    /// <param name="items">Новая коллекция <see cref="T:EleWise.ELMA.Model.Views.ComputedValue" /></param>
    /// <param name="originalItems">Оригинальная коллекция <see cref="T:EleWise.ELMA.Model.Views.ComputedValue" /></param>
    /// <returns>Трансформация</returns>
    public static ComputedValueTransformation CreateTransformation(
      IList<ComputedValue> items,
      IList<ComputedValue> originalItems)
    {
      if (items == null)
        return (ComputedValueTransformation) null;
      if (originalItems == null)
        return (ComputedValueTransformation) null;
      if (items.Count == 0 && originalItems.Count == 0)
        return (ComputedValueTransformation) null;
      return items != originalItems ? Transformation<ComputedValue, ComputedValueTransformation, string, string>.CreateTransformation((ComputedValue) new ComputedValueTransformation.ComputedValueCollectionContainer(items), (ComputedValue) new ComputedValueTransformation.ComputedValueCollectionContainer(originalItems)) : (ComputedValueTransformation) null;
    }

    /// <inheritdoc />
    protected internal override IList<ComputedValue> GetSubItems(ComputedValue item) => !(item is ComputedValueTransformation.ComputedValueCollectionContainer collectionContainer) ? (IList<ComputedValue>) new ComputedValue[0] : collectionContainer.Items;

    /// <inheritdoc />
    protected internal override string GetUid(ComputedValue item) => (string) ComputedValueTransformation.G7RKQLoSuPbudq0HMLRC((object) item);

    /// <inheritdoc />
    protected internal override bool IsHide(ComputedValue item) => false;

    /// <inheritdoc />
    protected internal override void SetHide(
      ComputedValue parentItem,
      ComputedValue item,
      bool hide = true)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.RemoveItem(parentItem, item);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    protected internal override ComputedValue CreateCopy(ComputedValue item) => this.Clone(item);

    /// <inheritdoc />
    protected internal override ComputedValue Clone(ComputedValue item) => ClassSerializationHelper.CloneObject<ComputedValue>(item);

    /// <inheritdoc />
    protected override IEnumerable<BaseTransformation<ComputedValue, string>> ChangeTransformations(
      ComputedValue item,
      ComputedValue originalItem,
      ComputedValue originalItemRoot)
    {
      if (item is ComputedValueTransformation.ComputedValueCollectionContainer && originalItem is ComputedValueTransformation.ComputedValueCollectionContainer)
        return base.ChangeTransformations(item, originalItem, originalItemRoot);
      string uid = this.GetUid(item);
      bool flag1 = true;
      List<ComputedValueTransformationChange> transformationChangeList = new List<ComputedValueTransformationChange>();
      bool flag2 = originalItem == null;
      if (flag2 || !object.Equals(item.Value, originalItem.Value))
      {
        transformationChangeList.Add(ComputedValueTransformation.CreateTransformationChange((object) uid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123672534), item.Value));
        if (item.ComputedValueType == ComputedValueType.Input)
        {
          flag1 = false;
          transformationChangeList.Add(ComputedValueTransformation.CreateTransformationChange((object) uid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811916894), (object) item.ComputedValueType));
        }
      }
      if (flag2 || item.MethodName != originalItem.MethodName)
      {
        transformationChangeList.Add(ComputedValueTransformation.CreateTransformationChange((object) uid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138302358), (object) item.MethodName));
        if (item.ComputedValueType == ComputedValueType.Function)
        {
          flag1 = false;
          transformationChangeList.Add(ComputedValueTransformation.CreateTransformationChange((object) uid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153963321), (object) item.ComputedValueType));
        }
      }
      if (flag2 || item.CalculateScript != originalItem.CalculateScript)
      {
        transformationChangeList.Add(ComputedValueTransformation.CreateTransformationChange((object) uid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217639661), (object) item.CalculateScript));
        if (item.ComputedValueType == ComputedValueType.CalculateScript)
        {
          flag1 = false;
          transformationChangeList.Add(ComputedValueTransformation.CreateTransformationChange((object) uid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671978281), (object) item.ComputedValueType));
        }
      }
      if (flag1 && (flag2 || item.ComputedValueType != originalItem.ComputedValueType))
        transformationChangeList.Add(ComputedValueTransformation.CreateTransformationChange((object) uid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137571806), (object) item.ComputedValueType));
      return (IEnumerable<BaseTransformation<ComputedValue, string>>) transformationChangeList;
    }

    private static ComputedValueTransformationChange CreateTransformationChange(
      object uid,
      object propertyName,
      object value)
    {
      ComputedValueTransformationChange transformationChange = new ComputedValueTransformationChange();
      transformationChange.Uid = (string) uid;
      transformationChange.PropertyName = (string) propertyName;
      ComputedValueTransformation.Mo5pnyoSIWJqvj6j36Xu((object) transformationChange, value);
      transformationChange.Localizable = false;
      return transformationChange;
    }

    public ComputedValueTransformation()
    {
      ComputedValueTransformation.Wp1dukoSVR1qs0BlI8ps();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object G7RKQLoSuPbudq0HMLRC([In] object obj0) => (object) ((ComputedValue) obj0).Name;

    internal static bool reVhRmoS8cVsPfPpQEU0() => ComputedValueTransformation.P07ROOoSv2cq8v3OKKox == null;

    internal static ComputedValueTransformation VHxSeloSZ2koNys5EhlA() => ComputedValueTransformation.P07ROOoSv2cq8v3OKKox;

    internal static void Mo5pnyoSIWJqvj6j36Xu([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Model.Transformations.TransformationChange<ComputedValue, ComputedValueTransformation, string, string>) obj0).Value = obj1;

    internal static void Wp1dukoSVR1qs0BlI8ps() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Корневой элемент для трансформации</summary>
    private sealed class ComputedValueCollectionContainer : ComputedValue
    {
      public ComputedValueCollectionContainer(IList<ComputedValue> items)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.Items = (IList<ComputedValue>) ((object) items ?? (object) new ComputedValue[0]);
      }

      public IList<ComputedValue> Items { get; }
    }
  }
}

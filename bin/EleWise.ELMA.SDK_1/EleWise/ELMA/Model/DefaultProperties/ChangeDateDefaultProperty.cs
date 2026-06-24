// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.DefaultProperties.ChangeDateDefaultProperty
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.PropertyHandlers;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.DefaultProperties
{
  /// <summary>Свойство по умолчанию "Дата изменения"</summary>
  [Component(Order = 200)]
  public class ChangeDateDefaultProperty : DefaultProperty
  {
    private readonly Guid changeDateDefaultPropertyUid;
    internal static ChangeDateDefaultProperty Qq1HSsWjNe8iTIExkNPq;

    /// <summary>Имя свойства (для текущей культуры)</summary>
    public override string Name => (string) ChangeDateDefaultProperty.FgmSmYWja62FNxYtWYU8((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309786758));

    /// <summary>Uid свойства</summary>
    public override Guid Uid => this.changeDateDefaultPropertyUid;

    /// <summary>
    /// Включена ли галочка использования данного свойства по умолчанию
    /// </summary>
    public override bool DefaultChecked => true;

    /// <summary>Инициализировать метаданные свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    public override void InitProperty(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.InitProperty(classMetadata, propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 2:
            List<ViewAttribute> attributes1 = propertyMetadata.ViewSettings.Attributes;
            ViewAttribute viewAttribute1 = new ViewAttribute();
            ChangeDateDefaultProperty.yBs1b9Wj4U9xCbVjJf42((object) viewAttribute1, ViewType.List);
            viewAttribute1.Visibility = Visibility.Hidden;
            attributes1.Add(viewAttribute1);
            num = 5;
            continue;
          case 3:
            List<ViewAttribute> attributes2 = ((PropertyViewSettings) ChangeDateDefaultProperty.BpoQfmWjD0E3HWjJ1XNl((object) propertyMetadata)).Attributes;
            ViewAttribute viewAttribute2 = new ViewAttribute();
            viewAttribute2.ViewType = ViewType.Create;
            ChangeDateDefaultProperty.bRBnIdWjwiMxJPeZuMfF((object) viewAttribute2, Visibility.Hidden);
            attributes2.Add(viewAttribute2);
            num = 6;
            continue;
          case 4:
            List<ViewAttribute> attributes3 = propertyMetadata.ViewSettings.Attributes;
            ViewAttribute viewAttribute3 = new ViewAttribute();
            ChangeDateDefaultProperty.yBs1b9Wj4U9xCbVjJf42((object) viewAttribute3, ViewType.Display);
            viewAttribute3.Visibility = Visibility.Visible;
            attributes3.Add(viewAttribute3);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 2;
            continue;
          case 5:
            goto label_2;
          case 6:
            List<ViewAttribute> attributes4 = ((PropertyViewSettings) ChangeDateDefaultProperty.BpoQfmWjD0E3HWjJ1XNl((object) propertyMetadata)).Attributes;
            ViewAttribute viewAttribute4 = new ViewAttribute();
            ChangeDateDefaultProperty.yBs1b9Wj4U9xCbVjJf42((object) viewAttribute4, ViewType.Edit);
            ChangeDateDefaultProperty.bRBnIdWjwiMxJPeZuMfF((object) viewAttribute4, Visibility.Visible);
            viewAttribute4.ReadOnly = true;
            attributes4.Add(viewAttribute4);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 4 : 4;
            continue;
          default:
            ChangeDateDefaultProperty.odMxxvWjtrKHtXx9itu8((object) ((PropertyViewSettings) ChangeDateDefaultProperty.BpoQfmWjD0E3HWjJ1XNl((object) propertyMetadata)).Attributes);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Определяет имя свойства, по которому определяется доступность свойства (в методе IsAvailableFor)
    /// </summary>
    protected override string PropertyName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87390097);

    /// <summary>UID типа данных</summary>
    protected override Guid TypeUid => DateTimeDescriptor.UID;

    /// <summary>Получить настройки типа данных</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Настройки типа данных</returns>
    protected override TypeSettings GetTypeSettings(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata)
    {
      DateTimeSettings typeSettings = new DateTimeSettings();
      ChangeDateDefaultProperty.n3I4woWjHx7CcQb04BoR((object) typeSettings, ChangeDateDefaultProperty.ACB0leWj6cs14gEhkInu((object) this));
      return (TypeSettings) typeSettings;
    }

    /// <summary>Доступно ли свойство для фильтра</summary>
    protected override bool Filterable => true;

    /// <summary>UID обработчика</summary>
    protected override Guid HandlerUid => ChangeDatePropertyHandler.UID;

    public ChangeDateDefaultProperty()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.changeDateDefaultPropertyUid = new Guid((string) ChangeDateDefaultProperty.oI7jjBWjAukSwyJInGHm(-345420348 ^ -345305822));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object FgmSmYWja62FNxYtWYU8([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool L6Ne36Wj3583gGpp13TQ() => ChangeDateDefaultProperty.Qq1HSsWjNe8iTIExkNPq == null;

    internal static ChangeDateDefaultProperty OHR9uJWjp9w2agsZMNt8() => ChangeDateDefaultProperty.Qq1HSsWjNe8iTIExkNPq;

    internal static object BpoQfmWjD0E3HWjJ1XNl([In] object obj0) => (object) ((PropertyMetadata) obj0).ViewSettings;

    internal static void odMxxvWjtrKHtXx9itu8([In] object obj0) => ((List<ViewAttribute>) obj0).Clear();

    internal static void bRBnIdWjwiMxJPeZuMfF([In] object obj0, Visibility value) => ((ViewAttribute) obj0).Visibility = value;

    internal static void yBs1b9Wj4U9xCbVjJf42([In] object obj0, ViewType value) => ((ViewAttribute) obj0).ViewType = value;

    internal static object ACB0leWj6cs14gEhkInu([In] object obj0) => (object) ((DefaultProperty) obj0).PropertyName;

    internal static void n3I4woWjHx7CcQb04BoR([In] object obj0, [In] object obj1) => ((SimpleTypeSettings) obj0).FieldName = (string) obj1;

    internal static object oI7jjBWjAukSwyJInGHm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}

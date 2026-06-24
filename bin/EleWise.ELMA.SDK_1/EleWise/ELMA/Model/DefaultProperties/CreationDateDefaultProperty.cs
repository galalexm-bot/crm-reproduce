// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.DefaultProperties.CreationDateDefaultProperty
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
  /// <summary>Свойство по умолчанию "Дата создания"</summary>
  [Component(Order = 100)]
  public class CreationDateDefaultProperty : DefaultProperty
  {
    private readonly Guid creationDateDefaultPropertyUid;
    internal static CreationDateDefaultProperty QvIrwnWj7ikPUqLwEZTb;

    /// <summary>Имя свойства (для текущей культуры)</summary>
    public override string Name => (string) CreationDateDefaultProperty.cAI4TyWjyZUbFPbHEUiv(CreationDateDefaultProperty.RPLVGOWjmcrqjwOekSFF(-53329496 >> 4 ^ -3292478));

    /// <summary>Uid свойства</summary>
    public override Guid Uid => this.creationDateDefaultPropertyUid;

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
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              List<ViewAttribute> attributes1 = propertyMetadata.ViewSettings.Attributes;
              ViewAttribute viewAttribute1 = new ViewAttribute();
              CreationDateDefaultProperty.TgYQlEWjJNbvTrkXGKZR((object) viewAttribute1, ViewType.List);
              CreationDateDefaultProperty.QC9nNHWj9cyronp7gKDs((object) viewAttribute1, Visibility.Hidden);
              attributes1.Add(viewAttribute1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 2;
              continue;
            case 2:
              goto label_3;
            case 3:
              List<ViewAttribute> attributes2 = ((PropertyViewSettings) CreationDateDefaultProperty.AMH3h4WjMCFkwjHghS5B((object) propertyMetadata)).Attributes;
              ViewAttribute viewAttribute2 = new ViewAttribute();
              CreationDateDefaultProperty.TgYQlEWjJNbvTrkXGKZR((object) viewAttribute2, ViewType.Display);
              CreationDateDefaultProperty.QC9nNHWj9cyronp7gKDs((object) viewAttribute2, Visibility.Visible);
              attributes2.Add(viewAttribute2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
              continue;
            case 4:
              List<ViewAttribute> attributes3 = ((PropertyViewSettings) CreationDateDefaultProperty.AMH3h4WjMCFkwjHghS5B((object) propertyMetadata)).Attributes;
              ViewAttribute viewAttribute3 = new ViewAttribute();
              CreationDateDefaultProperty.TgYQlEWjJNbvTrkXGKZR((object) viewAttribute3, ViewType.Create);
              viewAttribute3.Visibility = Visibility.Hidden;
              attributes3.Add(viewAttribute3);
              num2 = 5;
              continue;
            case 5:
              goto label_5;
            case 6:
              propertyMetadata.Nullable = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
              continue;
            case 7:
              base.InitProperty(classMetadata, propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 6;
              continue;
            default:
              ((PropertyViewSettings) CreationDateDefaultProperty.AMH3h4WjMCFkwjHghS5B((object) propertyMetadata)).Attributes.Clear();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 4;
              continue;
          }
        }
label_5:
        List<ViewAttribute> attributes4 = ((PropertyViewSettings) CreationDateDefaultProperty.AMH3h4WjMCFkwjHghS5B((object) propertyMetadata)).Attributes;
        ViewAttribute viewAttribute4 = new ViewAttribute();
        CreationDateDefaultProperty.TgYQlEWjJNbvTrkXGKZR((object) viewAttribute4, ViewType.Edit);
        CreationDateDefaultProperty.QC9nNHWj9cyronp7gKDs((object) viewAttribute4, Visibility.Visible);
        CreationDateDefaultProperty.SZbGHMWjdLXkIYZH7JZi((object) viewAttribute4, true);
        attributes4.Add(viewAttribute4);
        num1 = 3;
      }
label_3:;
    }

    /// <summary>
    /// Определяет имя свойства, по которому определяется доступность свойства (в методе IsAvailableFor)
    /// </summary>
    protected override string PropertyName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978395995);

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
      typeSettings.FieldName = (string) CreationDateDefaultProperty.CnSHkYWjld2W9UWv7RSt((object) this);
      CreationDateDefaultProperty.GgOHnHWjrsxihn9XcyLp((object) typeSettings, true);
      return (TypeSettings) typeSettings;
    }

    /// <summary>Обязательность заполнения</summary>
    protected override bool Required => true;

    /// <summary>Доступно ли свойство для фильтра</summary>
    protected override bool Filterable => true;

    /// <summary>UID обработчика</summary>
    protected override Guid HandlerUid => CreationDatePropertyHandler.UID;

    public CreationDateDefaultProperty()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.creationDateDefaultPropertyUid = new Guid((string) CreationDateDefaultProperty.RPLVGOWjmcrqjwOekSFF(-2112703338 ^ -2112817760));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object RPLVGOWjmcrqjwOekSFF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object cAI4TyWjyZUbFPbHEUiv([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool icuFXCWjxAWFynndM1L2() => CreationDateDefaultProperty.QvIrwnWj7ikPUqLwEZTb == null;

    internal static CreationDateDefaultProperty PQ5vdpWj0Mnkoe3j9A4N() => CreationDateDefaultProperty.QvIrwnWj7ikPUqLwEZTb;

    internal static object AMH3h4WjMCFkwjHghS5B([In] object obj0) => (object) ((PropertyMetadata) obj0).ViewSettings;

    internal static void TgYQlEWjJNbvTrkXGKZR([In] object obj0, ViewType value) => ((ViewAttribute) obj0).ViewType = value;

    internal static void QC9nNHWj9cyronp7gKDs([In] object obj0, Visibility value) => ((ViewAttribute) obj0).Visibility = value;

    internal static void SZbGHMWjdLXkIYZH7JZi([In] object obj0, bool value) => ((ViewAttribute) obj0).ReadOnly = value;

    internal static object CnSHkYWjld2W9UWv7RSt([In] object obj0) => (object) ((DefaultProperty) obj0).PropertyName;

    internal static void GgOHnHWjrsxihn9XcyLp([In] object obj0, bool value) => ((DateTimeSettings) obj0).SetCurrentDate = value;
  }
}

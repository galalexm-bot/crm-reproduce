// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.DefaultProperties.NameDefaultProperty
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
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
  /// <summary>Свойство по умолчанию "Наименование"</summary>
  [Component(Order = 0)]
  public class NameDefaultProperty : DefaultProperty
  {
    private readonly Guid nameDefaultPropertyUid;
    internal static NameDefaultProperty v6B5SVWYuXWyFRp3OYHj;

    /// <summary>Имя свойства (для текущей культуры)</summary>
    public override string Name => EleWise.ELMA.SR.T((string) NameDefaultProperty.dq2wQxWYSlnL1OjA9TJZ(1242972401 >> 4 ^ 77696377));

    /// <summary>Uid свойства</summary>
    public override Guid Uid => this.nameDefaultPropertyUid;

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
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        EntityPropertyMetadata propertyMetadata1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              List<ViewAttribute> attributes1 = ((PropertyViewSettings) NameDefaultProperty.KGpCc0WYqaHxjciHgEvE((object) propertyMetadata)).Attributes;
              ViewAttribute viewAttribute1 = new ViewAttribute();
              NameDefaultProperty.KatMOoWYXeLX4iKCrGvC((object) viewAttribute1, ViewType.Edit);
              viewAttribute1.Visibility = Visibility.Visible;
              attributes1.Add(viewAttribute1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 4 : 4;
              continue;
            case 2:
              if (propertyMetadata1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 7 : 2;
                continue;
              }
              goto label_16;
            case 3:
              NameDefaultProperty.Scq7aPWYRrwA6vywMQBt((object) propertyMetadata, true);
              num2 = 10;
              continue;
            case 4:
              List<ViewAttribute> attributes2 = propertyMetadata.ViewSettings.Attributes;
              ViewAttribute viewAttribute2 = new ViewAttribute();
              NameDefaultProperty.KatMOoWYXeLX4iKCrGvC((object) viewAttribute2, ViewType.Display);
              NameDefaultProperty.DoiDPPWYTqGGMyqUBPjb((object) viewAttribute2, Visibility.Visible);
              attributes2.Add(viewAttribute2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 6 : 2;
              continue;
            case 5:
              goto label_3;
            case 6:
              List<ViewAttribute> attributes3 = ((PropertyViewSettings) NameDefaultProperty.KGpCc0WYqaHxjciHgEvE((object) propertyMetadata)).Attributes;
              ViewAttribute viewAttribute3 = new ViewAttribute();
              NameDefaultProperty.KatMOoWYXeLX4iKCrGvC((object) viewAttribute3, ViewType.List);
              NameDefaultProperty.DoiDPPWYTqGGMyqUBPjb((object) viewAttribute3, Visibility.Visible);
              attributes3.Add(viewAttribute3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 2 : 11;
              continue;
            case 7:
              propertyMetadata1.InFastSearch = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 5 : 3;
              continue;
            case 8:
              NameDefaultProperty.UTHCKNWYigH6U6uGGsM4((object) classMetadata, propertyMetadata.Uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 3;
              continue;
            case 9:
              base.InitProperty(classMetadata, propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 8 : 1;
              continue;
            case 10:
              NameDefaultProperty.Ca6Py7WYKlfTlUqBlyTc((object) ((PropertyViewSettings) NameDefaultProperty.KGpCc0WYqaHxjciHgEvE((object) propertyMetadata)).Attributes);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            case 11:
              goto label_13;
            default:
              List<ViewAttribute> attributes4 = ((PropertyViewSettings) NameDefaultProperty.KGpCc0WYqaHxjciHgEvE((object) propertyMetadata)).Attributes;
              ViewAttribute viewAttribute4 = new ViewAttribute();
              NameDefaultProperty.KatMOoWYXeLX4iKCrGvC((object) viewAttribute4, ViewType.Create);
              NameDefaultProperty.DoiDPPWYTqGGMyqUBPjb((object) viewAttribute4, Visibility.Visible);
              attributes4.Add(viewAttribute4);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
              continue;
          }
        }
label_13:
        propertyMetadata1 = propertyMetadata as EntityPropertyMetadata;
        num1 = 2;
      }
label_3:
      return;
label_16:;
    }

    /// <summary>
    /// Определяет имя свойства, по которому определяется доступность свойства (в методе IsAvailableFor)
    /// </summary>
    protected override string PropertyName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812053618);

    /// <summary>UID типа данных</summary>
    protected override Guid TypeUid => StringDescriptor.UID;

    /// <summary>Обязательность заполнения</summary>
    protected override bool Required => true;

    /// <summary>Доступно ли свойство для фильтра</summary>
    protected override bool Filterable => true;

    /// <summary>Получить настройки типа данных</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Настройки типа данных</returns>
    protected override TypeSettings GetTypeSettings(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata)
    {
      StringSettings typeSettings = new StringSettings();
      NameDefaultProperty.jVAI9NWYnFXJPtoAZoDB((object) typeSettings, NameDefaultProperty.cgyS3lWYkkFM6pofYuQt((object) this));
      return (TypeSettings) typeSettings;
    }

    public NameDefaultProperty()
    {
      NameDefaultProperty.K8gmpbWYOfA3K0AimTC6();
      this.nameDefaultPropertyUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137573812));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object dq2wQxWYSlnL1OjA9TJZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool qqJoirWYIOpKnVgoexMv() => NameDefaultProperty.v6B5SVWYuXWyFRp3OYHj == null;

    internal static NameDefaultProperty WfQfgkWYVHZoJjvvGG9s() => NameDefaultProperty.v6B5SVWYuXWyFRp3OYHj;

    internal static void UTHCKNWYigH6U6uGGsM4([In] object obj0, Guid value) => ((ClassMetadata) obj0).TitlePropertyUid = value;

    internal static void Scq7aPWYRrwA6vywMQBt([In] object obj0, bool value) => ((PropertyMetadata) obj0).Required = value;

    internal static object KGpCc0WYqaHxjciHgEvE([In] object obj0) => (object) ((PropertyMetadata) obj0).ViewSettings;

    internal static void Ca6Py7WYKlfTlUqBlyTc([In] object obj0) => ((List<ViewAttribute>) obj0).Clear();

    internal static void KatMOoWYXeLX4iKCrGvC([In] object obj0, ViewType value) => ((ViewAttribute) obj0).ViewType = value;

    internal static void DoiDPPWYTqGGMyqUBPjb([In] object obj0, Visibility value) => ((ViewAttribute) obj0).Visibility = value;

    internal static object cgyS3lWYkkFM6pofYuQt([In] object obj0) => (object) ((DefaultProperty) obj0).PropertyName;

    internal static void jVAI9NWYnFXJPtoAZoDB([In] object obj0, [In] object obj1) => ((SimpleTypeSettings) obj0).FieldName = (string) obj1;

    internal static void K8gmpbWYOfA3K0AimTC6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

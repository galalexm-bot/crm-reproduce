// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.RecursiveComponentModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Signatures;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Рекурсивная модель компонента</summary>
  [DataContract]
  public sealed class RecursiveComponentModel : ICloneable
  {
    private static RecursiveComponentModel t1MLmYBW041M197tqhbm;

    /// <summary>Ctor</summary>
    public RecursiveComponentModel()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 8;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.EntityMetadataUids = new HashSet<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          case 2:
            this.EnumDependencies = new List<EnumDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
            continue;
          case 3:
            this.EntityDependencies = new List<EntityDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 0;
            continue;
          case 4:
            this.CustomTypes = new List<CustomTypeModel>();
            num = 3;
            continue;
          case 5:
            goto label_2;
          case 6:
            this.ExtensionPoints = new List<ClientExtensionPointModel>();
            num = 4;
            continue;
          case 7:
            this.Errors = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 3 : 5;
            continue;
          case 8:
            this.ComponentCache = new List<ClientComponentModel>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 6 : 2;
            continue;
          default:
            this.EnumMetadataUids = new HashSet<Guid>();
            num = 7;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Кэш метаданных. Содержит в себе информацию FormMetadataUid-ClientComponentModel
    /// </summary>
    [DataMember]
    public List<ClientComponentModel> ComponentCache { get; set; }

    /// <summary>Модель заголовка компонента</summary>
    [DataMember]
    public ClientComponentModel Header
    {
      get => this.\u003CHeader\u003Ek__BackingField;
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
              this.\u003CHeader\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
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

    /// <summary>
    /// Точки расширения, используемые в загружаемых компонентах
    /// </summary>
    [DataMember]
    public List<ClientExtensionPointModel> ExtensionPoints { get; set; }

    /// <summary>Пользовательские компоненты для типов</summary>
    [DataMember]
    public List<CustomTypeModel> CustomTypes { get; set; }

    /// <summary>Список зависимостей от сущностей</summary>
    [DataMember]
    public List<EntityDependency> EntityDependencies { get; }

    /// <summary>Список зависимостей от перечислений</summary>
    [IgnoreDataMember]
    public List<EnumDependency> EnumDependencies { get; }

    /// <summary>
    /// Список уникальных идентификаторов метаданных сущностей,
    /// использующихся в рантайме
    /// </summary>
    [DataMember]
    public HashSet<Guid> EntityMetadataUids { get; set; }

    /// <summary>
    /// Список уникальных идентификаторов метаданных перечислений,
    /// использующихся в рантайме
    /// </summary>
    [DataMember]
    public HashSet<Guid> EnumMetadataUids { get; set; }

    /// <summary>Ошибки, возникшие при поиске подходящей версии</summary>
    [DataMember]
    public List<string> Errors { get; }

    /// <inheritdoc />
    public object Clone()
    {
      int num = 3;
      RecursiveComponentModel recursiveComponentModel;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 5:
            List<ClientComponentModel> componentCache1 = recursiveComponentModel.ComponentCache;
            List<ClientComponentModel> componentCache2 = this.ComponentCache;
            // ISSUE: reference to a compiler-generated field
            Func<ClientComponentModel, ClientComponentModel> func1 = RecursiveComponentModel.\u003C\u003Ec.\u003C\u003E9__34_0;
            Func<ClientComponentModel, ClientComponentModel> selector1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              RecursiveComponentModel.\u003C\u003Ec.\u003C\u003E9__34_0 = selector1 = (Func<ClientComponentModel, ClientComponentModel>) (c => (ClientComponentModel) RecursiveComponentModel.\u003C\u003Ec.QwN96dQWdu6iTHYXVm26((object) c));
            }
            else
              goto label_19;
label_12:
            IEnumerable<ClientComponentModel> collection1 = componentCache2.Select<ClientComponentModel, ClientComponentModel>(selector1);
            componentCache1.AddRange(collection1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 9;
            continue;
label_19:
            selector1 = func1;
            goto label_12;
          case 2:
            if (this.Header == null)
            {
              num = 5;
              continue;
            }
            break;
          case 3:
            recursiveComponentModel = new RecursiveComponentModel();
            num = 2;
            continue;
          case 4:
            recursiveComponentModel.EnumMetadataUids.AddRange<Guid>((IEnumerable<Guid>) this.EnumMetadataUids);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 3 : 10;
            continue;
          case 6:
            List<EnumDependency> enumDependencies1 = recursiveComponentModel.EnumDependencies;
            List<EnumDependency> enumDependencies2 = this.EnumDependencies;
            // ISSUE: reference to a compiler-generated field
            Func<EnumDependency, EnumDependency> func2 = RecursiveComponentModel.\u003C\u003Ec.\u003C\u003E9__34_4;
            Func<EnumDependency, EnumDependency> selector2;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              RecursiveComponentModel.\u003C\u003Ec.\u003C\u003E9__34_4 = selector2 = (Func<EnumDependency, EnumDependency>) (ed =>
              {
                EnumDependency enumDependency = new EnumDependency();
                // ISSUE: reference to a compiler-generated method
                enumDependency.Name = (string) RecursiveComponentModel.\u003C\u003Ec.j5G4xvQWgmfEdZdIvxrB((object) ed);
                // ISSUE: reference to a compiler-generated method
                enumDependency.DisplayName = (string) RecursiveComponentModel.\u003C\u003Ec.kv1jM0QWjsHwDGGb8ftG((object) ed);
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                RecursiveComponentModel.\u003C\u003Ec.kYuYtjQWUWSScqBRxt0r((object) enumDependency, RecursiveComponentModel.\u003C\u003Ec.De0sB9QWLgx97EJSmufu((object) ed));
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                RecursiveComponentModel.\u003C\u003Ec.SPVmiOQWc6vZwn34qZk7((object) enumDependency, RecursiveComponentModel.\u003C\u003Ec.DQTnX9QWsWwa009EpUQP((object) ed));
                return enumDependency;
              });
            }
            else
              goto label_20;
label_18:
            IEnumerable<EnumDependency> collection2 = enumDependencies2.Select<EnumDependency, EnumDependency>(selector2);
            enumDependencies1.AddRange(collection2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 8 : 1;
            continue;
label_20:
            selector2 = func2;
            goto label_18;
          case 7:
            recursiveComponentModel.EntityDependencies.AddRange(this.EntityDependencies.Select<EntityDependency, EntityDependency>((Func<EntityDependency, EntityDependency>) (ed =>
            {
              EntityDependency entityDependency = new EntityDependency();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              RecursiveComponentModel.\u003C\u003Ec.A9hbRCQW5q8WNlkwKAqs((object) entityDependency, RecursiveComponentModel.\u003C\u003Ec.j5G4xvQWgmfEdZdIvxrB((object) ed));
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              RecursiveComponentModel.\u003C\u003Ec.LoaVt9QWY6ZkOZdQSkr2((object) entityDependency, RecursiveComponentModel.\u003C\u003Ec.kv1jM0QWjsHwDGGb8ftG((object) ed));
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              RecursiveComponentModel.\u003C\u003Ec.kYuYtjQWUWSScqBRxt0r((object) entityDependency, RecursiveComponentModel.\u003C\u003Ec.De0sB9QWLgx97EJSmufu((object) ed));
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              RecursiveComponentModel.\u003C\u003Ec.SPVmiOQWc6vZwn34qZk7((object) entityDependency, RecursiveComponentModel.\u003C\u003Ec.DQTnX9QWsWwa009EpUQP((object) ed));
              entityDependency.Properties.AddRange(ed.Properties.Select<PropertySignature, PropertySignature>((Func<PropertySignature, PropertySignature>) (p =>
              {
                PropertySignature propertySignature = new PropertySignature();
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                RecursiveComponentModel.\u003C\u003Ec.oMuhmKQoFjbGr7IVTulZ((object) propertySignature, RecursiveComponentModel.\u003C\u003Ec.DMPjmbQWzU3sTX2WiYDe((object) p));
                // ISSUE: reference to a compiler-generated method
                RecursiveComponentModel.\u003C\u003Ec.h6Z3dWQoB0HeZUasJeZM((object) propertySignature, (object) p.Name);
                TypeSignature typeSignature = new TypeSignature();
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                typeSignature.Nullable = RecursiveComponentModel.\u003C\u003Ec.InYn1kQooD3nxpbNHjO1(RecursiveComponentModel.\u003C\u003Ec.pEHJ9bQoWNx0DBLOgxnp((object) p));
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                RecursiveComponentModel.\u003C\u003Ec.yPKRccQobP4lWM5wCGp2((object) typeSignature, ((TypeSignature) RecursiveComponentModel.\u003C\u003Ec.pEHJ9bQoWNx0DBLOgxnp((object) p)).RelationType);
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                RecursiveComponentModel.\u003C\u003Ec.uv4ciNQoGTBY1FliefgV((object) typeSignature, RecursiveComponentModel.\u003C\u003Ec.peMUnVQohoRV7SGMkZYK((object) p.Type));
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                RecursiveComponentModel.\u003C\u003Ec.jLZS2CQofmrTm7a9PHyg((object) typeSignature, RecursiveComponentModel.\u003C\u003Ec.NGv7cBQoE7wNilbrMuOL((object) p.Type));
                propertySignature.Type = typeSignature;
                return propertySignature;
              })));
              return entityDependency;
            })));
            num = 6;
            continue;
          case 8:
            recursiveComponentModel.EntityMetadataUids.AddRange<Guid>((IEnumerable<Guid>) this.EntityMetadataUids);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 4 : 1;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated method
            recursiveComponentModel.ExtensionPoints.AddRange(this.ExtensionPoints.Select<ClientExtensionPointModel, ClientExtensionPointModel>((Func<ClientExtensionPointModel, ClientExtensionPointModel>) (e => (ClientExtensionPointModel) RecursiveComponentModel.\u003C\u003Ec.VyGo6kQWl9XAhdorJ2ji((object) e))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 11;
            continue;
          case 10:
            recursiveComponentModel.Errors.AddRange((IEnumerable<string>) this.Errors);
            num = 12;
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated method
            recursiveComponentModel.CustomTypes.AddRange(this.CustomTypes.Select<CustomTypeModel, CustomTypeModel>((Func<CustomTypeModel, CustomTypeModel>) (c => (CustomTypeModel) RecursiveComponentModel.\u003C\u003Ec.dW9OxMQWr9Rh7V1UwytH((object) c))));
            num = 7;
            continue;
          case 12:
            goto label_4;
        }
        recursiveComponentModel.Header = (ClientComponentModel) this.Header.Clone();
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
      }
label_4:
      return (object) recursiveComponentModel;
    }

    internal static bool uWOfWLBWmOnTl9JDhPqN() => RecursiveComponentModel.t1MLmYBW041M197tqhbm == null;

    internal static RecursiveComponentModel nX8hryBWyNGEU1wT7od7() => RecursiveComponentModel.t1MLmYBW041M197tqhbm;
  }
}

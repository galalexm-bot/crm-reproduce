// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.Models.EntityFormView
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Services.Models
{
  /// <summary>Модель формы сущности</summary>
  public sealed class EntityFormView
  {
    internal static EntityFormView RTXucsbZJNYxelGrNHp1;

    /// <summary>Ctor</summary>
    public EntityFormView()
    {
      EntityFormView.w08M0QbZlLUhQn03Uf7Z();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.EnumMetadataUids = new HashSet<Guid>();
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.EntityMetadataUids = new HashSet<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Модель сущности</summary>
    public string Model
    {
      get => this.\u003CModel\u003Ek__BackingField;
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
              this.\u003CModel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
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

    /// <summary>Форма</summary>
    public FormViewItem View
    {
      get => this.\u003CView\u003Ek__BackingField;
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
              this.\u003CView\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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

    /// <summary>Метаданные сущности</summary>
    public IMetadata Metadata
    {
      get => this.\u003CMetadata\u003Ek__BackingField;
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
              this.\u003CMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
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

    /// <summary>Дополнительные метаданные</summary>
    public IEnumerable<IMetadata> AdditionalMetadata { get; set; }

    /// <summary>Информация о построителе представления для модели</summary>
    public FormViewBuilderInfo FormViewBuilderInfo
    {
      get => this.\u003CFormViewBuilderInfo\u003Ek__BackingField;
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
              this.\u003CFormViewBuilderInfo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
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

    /// <summary>Информация о модели</summary>
    public ModelInfo ModelInfo
    {
      get => this.\u003CModelInfo\u003Ek__BackingField;
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
              this.\u003CModelInfo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
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

    /// <summary>Список моделей клиентских скриптов</summary>
    public IEnumerable<ClientScriptModel> ClientScriptModels { get; set; }

    /// <summary>Рекурсивная модель компонента</summary>
    public RecursiveComponentModel RecursiveComponentModel
    {
      get => this.\u003CRecursiveComponentModel\u003Ek__BackingField;
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
              this.\u003CRecursiveComponentModel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
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

    /// <summary>Зависимости от сущностей</summary>
    /// <remarks>
    /// Собираются зависимости только первого уровня, т.е. прямые зависимости сущности
    /// </remarks>
    public IEnumerable<EntityDependency> EntityDependencies { get; set; }

    /// <summary>
    /// Список уникальных идентификаторов метаданных сущностей,
    /// использующихся в рантайме
    /// </summary>
    public HashSet<Guid> EntityMetadataUids { get; set; }

    /// <summary>
    /// Список уникальных идентификаторов метаданных перечислений,
    /// использующихся в рантайме
    /// </summary>
    public HashSet<Guid> EnumMetadataUids { get; set; }

    internal static void w08M0QbZlLUhQn03Uf7Z() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool USD49QbZ9rcg7T0HYDLJ() => EntityFormView.RTXucsbZJNYxelGrNHp1 == null;

    internal static EntityFormView hDptJxbZdZ0KqflyxV9Z() => EntityFormView.RTXucsbZJNYxelGrNHp1;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.FindComponent.ObjectFormFindComponentModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.Services.FindComponent
{
  /// <summary>Модели поиска компонента для формы объекта</summary>
  public sealed class ObjectFormFindComponentModel
  {
    private static ObjectFormFindComponentModel EDo17YBBKf8pSwVdaTIk;

    /// <summary>Отображаемое имя метаданных</summary>
    public string MetadataDisplayName
    {
      get => this.\u003CMetadataDisplayName\u003Ek__BackingField;
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
              this.\u003CMetadataDisplayName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор метаданных</summary>
    public Guid MetadataUid
    {
      get => this.\u003CMetadataUid\u003Ek__BackingField;
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
              this.\u003CMetadataUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор элемента</summary>
    /// <remarks>Для процессов: WorkflowTask.Uid</remarks>
    public Guid ItemUid
    {
      get => this.\u003CItemUid\u003Ek__BackingField;
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
              this.\u003CItemUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
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
    public FormViewItem Form
    {
      get => this.\u003CForm\u003Ek__BackingField;
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
              this.\u003CForm\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
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

    /// <summary>Зависимости от компонентов</summary>
    public List<ComponentDependency> ComponentDependencies { get; }

    /// <summary>Зависимости от функций</summary>
    public List<FunctionDependency> FunctionDependencies { get; }

    /// <summary>Зависимости от датаклассов</summary>
    public List<DataClassDependency> DataClassDependencies { get; }

    public ObjectFormFindComponentModel()
    {
      ObjectFormFindComponentModel.o1KJOVBBkvyd1Hr34GRj();
      this.ComponentDependencies = new List<ComponentDependency>();
      this.FunctionDependencies = new List<FunctionDependency>();
      this.DataClassDependencies = new List<DataClassDependency>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool C3CKIRBBXMqqAinCedGs() => ObjectFormFindComponentModel.EDo17YBBKf8pSwVdaTIk == null;

    internal static ObjectFormFindComponentModel KKsL8gBBTHorTuYB8Z4F() => ObjectFormFindComponentModel.EDo17YBBKf8pSwVdaTIk;

    internal static void o1KJOVBBkvyd1Hr34GRj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

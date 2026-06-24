// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.FormViewItemDependencyContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Dependencies
{
  /// <summary>Контейнер зависимостей для формы</summary>
  public sealed class FormViewItemDependencyContainer : IDependencyContainer
  {
    internal static FormViewItemDependencyContainer DgAaqqhisWTbsB1aPVKj;

    /// <summary>Ctor</summary>
    public FormViewItemDependencyContainer()
    {
      FormViewItemDependencyContainer.NcVsf5hRFiGRNFwi4KQs();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.EnumDependencies = new List<EnumDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 3 : 0;
            continue;
          case 2:
            this.ComponentDependencies = new List<ComponentDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.DataClassDependencies = new List<DataClassDependency>();
            num = 2;
            continue;
          default:
            this.EntityDependencies = new List<EntityDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уникальный идентификатор формы</summary>
    public Guid FormUid
    {
      get => this.\u003CFormUid\u003Ek__BackingField;
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
              this.\u003CFormUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
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

    /// <summary>Зависимости от датаклассов</summary>
    public List<DataClassDependency> DataClassDependencies { get; }

    /// <summary>Зависимости от компонентов</summary>
    public List<ComponentDependency> ComponentDependencies { get; }

    /// <summary>Зависимости от сущностей</summary>
    public List<EntityDependency> EntityDependencies { get; }

    /// <summary>Зависимости от сущностей</summary>
    public List<EnumDependency> EnumDependencies { get; }

    internal static void NcVsf5hRFiGRNFwi4KQs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ypZmSrhicZAmEU3AIVmA() => FormViewItemDependencyContainer.DgAaqqhisWTbsB1aPVKj == null;

    internal static FormViewItemDependencyContainer ajAaHqhizAY8weZPbkwv() => FormViewItemDependencyContainer.DgAaqqhisWTbsB1aPVKj;
  }
}

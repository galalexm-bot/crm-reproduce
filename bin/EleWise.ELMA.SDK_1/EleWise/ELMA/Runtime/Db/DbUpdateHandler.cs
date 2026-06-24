// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.DbUpdateHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>
  /// Базовый класс для обработки действий при преобразовании структуры БД
  /// </summary>
  [Component]
  public abstract class DbUpdateHandler : IDbUpdateHandler, IActionsHolder
  {
    private List<IDbAction> tablesCreatedActions;
    private List<IDbAction> tablesDeletedActions;
    private List<IDbAction> foreignKeysCreatedActions;
    private List<IDbAction> primaryKeysCreatedActions;
    private List<IDbAction> onCompleteActions;
    internal static DbUpdateHandler jPomcwWiO7k5nGxHaT6d;

    /// <summary>
    /// Uid провайдера, для которого предназначается расширение (соответсвует <see cref="P:EleWise.ELMA.IProvider.Uid" />)
    /// </summary>
    /// <remarks>
    /// Если равен Guid.Empty, то применяется для всех провайдеров
    /// </remarks>
    public abstract Guid ProviderUid { get; }

    /// <summary>Создать структуры, необходимые для инициализации</summary>
    public virtual void CreateInitialStructures()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DbUpdateHandler.IMAqYPWi1LVvpWDfqanb((object) this.Transform, DbUpdateHandler.h64QPHWiPVdJjUleALl3(1461825605 - 1531863589 ^ -70060802));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Инициализация (выполняется вне рамок транзакции)</summary>
    public virtual void Init()
    {
    }

    /// <summary>Определяет, есть ли изменения в структуре</summary>
    public abstract bool HasChanges { get; }

    /// <summary>
    /// Нужно ли пересоздавать все ограничения, индексы и внешние ключи
    /// </summary>
    public abstract bool NeedRecreateConstraints { get; }

    /// <summary>Начало преобразования</summary>
    /// <param name="parameters">Параметры</param>
    public virtual void OnStart(DbUpdateParameters parameters)
    {
    }

    /// <summary>Перед удалением триггеров</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnTriggersDeleting(TriggersDeletingEventArgs e)
    {
    }

    /// <summary>После удаления триггеров</summary>
    public virtual void OnTriggersDeleted()
    {
    }

    /// <summary>Перед удалением процедур и функций</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnProceduresDeleting(ProceduresDeletingEventArgs e)
    {
    }

    /// <summary>После удаления процедур и функций</summary>
    public virtual void OnProceduresDeleted()
    {
    }

    /// <summary>Перед удалением представлений</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnViewsDeleting(ViewsDeletingEventArgs e)
    {
    }

    /// <summary>После удаления представлений</summary>
    public virtual void OnViewsDeleted()
    {
    }

    /// <summary>Перед удалением индексов</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnIndexesDeleting(IndexesDeletingEventArgs e)
    {
    }

    /// <summary>После удаления индексов</summary>
    public virtual void OnIndexesDeleted()
    {
    }

    /// <summary>Перед удалением внешних ключей</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnForeignKeysDeleting(ForeginKeysDeletingEventArgs e)
    {
    }

    /// <summary>После удаления внешних ключей</summary>
    public virtual void OnForeignKeysDeleted()
    {
    }

    /// <summary>Перед удалением первичных ключей</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnPrimaryKeysDeleting(PrimaryKeysDeletingEventArgs e)
    {
    }

    /// <summary>
    /// После удаления первичных ключей (только для некоторых баз, например, Оракл)
    /// </summary>
    public virtual void OnPrimaryKeysDeleted()
    {
    }

    /// <summary>Перед созданием/преобразованием таблиц и колонок</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnTablesCreating(TablesCreatingEventArgs e)
    {
    }

    /// <summary>После создания/преобразования таблиц и колонок</summary>
    public virtual void OnTablesCreated()
    {
      int num1 = 1;
      List<IDbAction>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.TablesCreatedActions.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_13:
      return;
label_2:
      try
      {
label_5:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_6;
label_4:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            goto label_7;
          default:
            goto label_5;
        }
label_6:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
        goto label_4;
label_7:
        enumerator.Current.Execute();
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Перед удалением таблиц и колонок</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnTablesDeleting(TablesDeletingEventArgs e)
    {
    }

    /// <summary>После удаления таблиц и колонок</summary>
    public virtual void OnTablesDeleted()
    {
      int num1 = 2;
      List<IDbAction>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
            goto label_2;
          case 2:
            enumerator = this.TablesDeletedActions.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 1;
            continue;
          default:
            goto label_9;
        }
      }
label_13:
      return;
label_9:
      return;
label_2:
      try
      {
label_7:
        if (enumerator.MoveNext())
          goto label_5;
        else
          goto label_8;
label_3:
        int num2;
        switch (num2)
        {
          case 1:
            goto label_7;
          case 2:
            return;
        }
label_5:
        DbUpdateHandler.ahxlIUWiNC6tLHNdLW5x((object) enumerator.Current);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        {
          num2 = 1;
          goto label_3;
        }
        else
          goto label_3;
label_8:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 2;
        goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Перед созданием внешних ключей</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnForeignKeysCreating(ForeignKeysCreatingEventArgs e)
    {
    }

    /// <summary>После создания внешних ключей</summary>
    public virtual void OnForeignKeysCreated()
    {
      int num1 = 1;
      List<IDbAction>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.ForeignKeysCreatedActions.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_14;
          default:
            goto label_3;
        }
      }
label_14:
      return;
label_3:
      try
      {
label_8:
        if (enumerator.MoveNext())
          goto label_6;
        else
          goto label_9;
label_5:
        int num2;
        switch (num2)
        {
          case 1:
            goto label_8;
          case 2:
            return;
        }
label_6:
        DbUpdateHandler.ahxlIUWiNC6tLHNdLW5x((object) enumerator.Current);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        {
          num2 = 1;
          goto label_5;
        }
        else
          goto label_5;
label_9:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 1;
        goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Перед созданием первичных ключей</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnPrimaryKeysCreating(PrimaryKeysCreatingEventArgs e)
    {
    }

    /// <summary>После создания первичных ключей</summary>
    public virtual void OnPrimaryKeysCreated()
    {
      int num1 = 1;
      List<IDbAction>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.PrimaryKeysCreatedActions.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_15;
          default:
            goto label_3;
        }
      }
label_15:
      return;
label_3:
      try
      {
label_9:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_10;
label_5:
        int num2;
        switch (num2)
        {
          case 0:
            return;
          case 1:
            break;
          case 2:
            goto label_9;
          default:
            return;
        }
label_7:
        enumerator.Current.Execute();
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        {
          num2 = 2;
          goto label_5;
        }
        else
          goto label_5;
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
        goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Перед созданием индексов</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnIndexesCreating(IndexesCreatingEventArgs e)
    {
    }

    /// <summary>После создания индексов</summary>
    public virtual void OnIndexesCreated()
    {
    }

    /// <summary>Перед созданием представлений</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnViewsCreating(ViewsCreatingEventArgs e)
    {
    }

    /// <summary>После создания представлений</summary>
    public virtual void OnViewsCreated()
    {
    }

    /// <summary>Перед созданием триггеров</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnTriggersCreating(TriggersCreatingEventArgs e)
    {
    }

    /// <summary>После создания триггеров</summary>
    public virtual void OnTriggersCreated()
    {
    }

    /// <summary>Перед созданием процедур и функций</summary>
    /// <param name="e">Параметры события</param>
    public virtual void OnProceduresCreating(ProceduresCreatingEventArgs e)
    {
    }

    /// <summary>После создания процедур и функций</summary>
    public virtual void OnProceduresCreated()
    {
    }

    /// <summary>Завершение преобразования</summary>
    public virtual void OnComplete()
    {
      int num1 = 2;
      List<IDbAction>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
            goto label_2;
          case 2:
            enumerator = this.OnCompleteActions.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
            continue;
          default:
            goto label_9;
        }
      }
label_13:
      return;
label_9:
      return;
label_2:
      try
      {
label_7:
        if (enumerator.MoveNext())
          goto label_5;
        else
          goto label_8;
label_3:
        int num2;
        switch (num2)
        {
          case 1:
            goto label_7;
          case 2:
            return;
        }
label_5:
        enumerator.Current.Execute();
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        {
          num2 = 1;
          goto label_3;
        }
        else
          goto label_3;
label_8:
        num2 = 2;
        goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Действия после создания таблиц и колонок</summary>
    public List<IDbAction> TablesCreatedActions => this.tablesCreatedActions;

    /// <summary>Действия после удаления таблиц и колонок</summary>
    public List<IDbAction> TablesDeletedActions => this.tablesDeletedActions;

    /// <summary>Действия после создания внешних ключей</summary>
    public List<IDbAction> ForeignKeysCreatedActions => this.foreignKeysCreatedActions;

    /// <summary>Действия после создания первичных ключей</summary>
    public List<IDbAction> PrimaryKeysCreatedActions => this.primaryKeysCreatedActions;

    /// <summary>Действия при завершении обновления</summary>
    public List<IDbAction> OnCompleteActions => this.onCompleteActions;

    /// <summary>Провайдер преобразования БД</summary>
    public ITransformationProvider Transform
    {
      get => this.\u003CTransform\u003Ek__BackingField;
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
              this.\u003CTransform\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
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

    /// <summary>Провайдер сессий</summary>
    public ISessionProvider SessionProvider
    {
      protected get => this.\u003CSessionProvider\u003Ek__BackingField;
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
              this.\u003CSessionProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
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
    /// Сервис, позволяющий получать или ставить метки при обновлении структуры БД
    /// </summary>
    public DbUpdateMarkerService MarkerService
    {
      get => this.\u003CMarkerService\u003Ek__BackingField;
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
              this.\u003CMarkerService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
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

    /// <summary>Есть ли хотя бы одно действие</summary>
    public bool HasActions
    {
      get
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
                if (DbUpdateHandler.gfnlIHWi3TEMb4t593ir((object) this.TablesDeletedActions) <= 0)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                  continue;
                }
                goto label_12;
              case 2:
                if (DbUpdateHandler.gfnlIHWi3TEMb4t593ir((object) this.PrimaryKeysCreatedActions) > 0)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 5 : 5;
                  continue;
                }
                goto label_11;
              case 3:
              case 5:
              case 6:
                goto label_12;
              case 4:
                goto label_11;
              case 7:
                if (DbUpdateHandler.gfnlIHWi3TEMb4t593ir((object) this.TablesCreatedActions) <= 0)
                  goto case 1;
                else
                  goto label_6;
              default:
                if (this.ForeignKeysCreatedActions.Count > 0)
                {
                  num2 = 3;
                  continue;
                }
                goto case 2;
            }
          }
label_6:
          num1 = 6;
        }
label_11:
        return DbUpdateHandler.gfnlIHWi3TEMb4t593ir((object) this.OnCompleteActions) > 0;
label_12:
        return true;
      }
    }

    /// <summary>Проверить все действия</summary>
    public void CheckAllActions()
    {
      int num1 = 6;
      List<IDbAction>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_44;
          case 2:
label_47:
            enumerator = this.ForeignKeysCreatedActions.GetEnumerator();
            num1 = 8;
            continue;
          case 3:
            try
            {
label_14:
              if (enumerator.MoveNext())
                goto label_16;
              else
                goto label_15;
label_13:
              int num2;
              switch (num2)
              {
                case 1:
                  goto label_16;
                case 2:
                  goto label_47;
                default:
                  goto label_14;
              }
label_15:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 2 : 1;
              goto label_13;
label_16:
              DbUpdateHandler.Br5tsUWipqtZJPSnshtq((object) enumerator.Current);
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
              {
                num2 = 0;
                goto label_13;
              }
              else
                goto label_13;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 4:
label_33:
            enumerator = this.TablesDeletedActions.GetEnumerator();
            num1 = 3;
            continue;
          case 5:
            try
            {
label_38:
              if (enumerator.MoveNext())
                goto label_36;
              else
                goto label_39;
label_35:
              int num4;
              switch (num4)
              {
                case 1:
                  break;
                case 2:
                  goto label_33;
                default:
                  goto label_38;
              }
label_36:
              DbUpdateHandler.Br5tsUWipqtZJPSnshtq((object) enumerator.Current);
              num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
              {
                num4 = 0;
                goto label_35;
              }
              else
                goto label_35;
label_39:
              num4 = 2;
              goto label_35;
            }
            finally
            {
              enumerator.Dispose();
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
          case 6:
            enumerator = this.TablesCreatedActions.GetEnumerator();
            num1 = 5;
            continue;
          case 7:
label_46:
            enumerator = this.PrimaryKeysCreatedActions.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 8:
            try
            {
label_5:
              if (enumerator.MoveNext())
                goto label_4;
              else
                goto label_6;
label_3:
              int num6;
              switch (num6)
              {
                case 1:
                  break;
                case 2:
                  goto label_5;
                default:
                  goto label_46;
              }
label_4:
              DbUpdateHandler.Br5tsUWipqtZJPSnshtq((object) enumerator.Current);
              num6 = 2;
              goto label_3;
label_6:
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              goto label_3;
            }
            finally
            {
              enumerator.Dispose();
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
                num7 = 0;
              switch (num7)
              {
                default:
              }
            }
          default:
            goto label_22;
        }
      }
label_44:
      return;
label_22:
      try
      {
label_27:
        if (enumerator.MoveNext())
          goto label_25;
        else
          goto label_28;
label_24:
        int num8;
        switch (num8)
        {
          case 1:
            goto label_27;
          case 2:
            return;
        }
label_25:
        DbUpdateHandler.Br5tsUWipqtZJPSnshtq((object) enumerator.Current);
        num8 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        {
          num8 = 1;
          goto label_24;
        }
        else
          goto label_24;
label_28:
        num8 = 2;
        goto label_24;
      }
      finally
      {
        enumerator.Dispose();
        int num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
          num9 = 0;
        switch (num9)
        {
          default:
        }
      }
    }

    /// <summary>Сессия NHibernate</summary>
    protected ISession Session
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              Contract.NotNull((object) this.SessionProvider, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70074644));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return (ISession) DbUpdateHandler.gmGFiUWiab1KYLCSZnSH((object) this.SessionProvider, (object) "");
      }
    }

    protected DbUpdateHandler()
    {
      DbUpdateHandler.fsaDIGWiDuoJ3cSyNyB2();
      this.tablesCreatedActions = new List<IDbAction>();
      this.tablesDeletedActions = new List<IDbAction>();
      this.foreignKeysCreatedActions = new List<IDbAction>();
      this.primaryKeysCreatedActions = new List<IDbAction>();
      this.onCompleteActions = new List<IDbAction>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object h64QPHWiPVdJjUleALl3(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void IMAqYPWi1LVvpWDfqanb([In] object obj0, [In] object obj1) => Contract.ServiceNotNull(obj0, (string) obj1);

    internal static bool aAjLxOWi2RbkxLkdEZGs() => DbUpdateHandler.jPomcwWiO7k5nGxHaT6d == null;

    internal static DbUpdateHandler itcfXiWie88tQdpDuQhY() => DbUpdateHandler.jPomcwWiO7k5nGxHaT6d;

    internal static void ahxlIUWiNC6tLHNdLW5x([In] object obj0) => ((IDbAction) obj0).Execute();

    internal static int gfnlIHWi3TEMb4t593ir([In] object obj0) => ((List<IDbAction>) obj0).Count;

    internal static void Br5tsUWipqtZJPSnshtq([In] object obj0) => ((IDbAction) obj0).Check();

    internal static object gmGFiUWiab1KYLCSZnSH([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static void fsaDIGWiDuoJ3cSyNyB2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

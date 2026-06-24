// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityModel`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>
  /// Модель для представления, основанного на отображении данных сущности
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class EntityModel<T> where T : class
  {
    private static object Mlkgd9hZHSMUMoDjGEmX;

    /// <summary>Сущность</summary>
    public T Entity { get; set; }

    /// <summary>Конструктор</summary>
    /// <param name="model"></param>
    public EntityModel(T model)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Entity = model;
    }

    /// <summary>Конструктор</summary>
    public EntityModel()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected virtual EntityModel<TFor> CopyAs<TFor>() where TFor : class => new EntityModel<TFor>((object) this.Entity as TFor);

    /// <summary>Получить модель с преобразованой внутренней моделю</summary>
    /// <typeparam name="TFor">Тип к которому надо привести модель</typeparam>
    /// <returns></returns>
    public EntityModel<TFor> As<TFor>() where TFor : class => this.CopyAs<TFor>();

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TMd"></typeparam>
    /// <returns></returns>
    public TMd Metadata<TMd>() where TMd : class, IMetadata => EntityHelper.Metadata<TMd>((object) this.Entity as IEntity);

    protected EntityMetadata GetSuperMD()
    {
      int num1 = 2;
      EntityMetadata superMd;
      IMetadataRuntimeService metadataRuntimeService;
      while (true)
      {
        int num2 = num1;
        IMetadata metadata1;
        while (true)
        {
          IMetadata metadata2;
          switch (num2)
          {
            case 1:
              superMd = this.Metadata<EntityMetadata>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 3 : 1;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
              continue;
            case 3:
              metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_14;
            case 6:
              goto label_13;
            case 7:
              metadata2 = metadata1;
              break;
            default:
              if (superMd.Type != EntityMetadataType.InterfaceImplementation)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 4;
                continue;
              }
              metadata2 = metadataRuntimeService.GetMetadata(superMd.ImplementationUid, false);
              break;
          }
          if (!metadata2.IsSystem())
            num2 = 5;
          else
            goto label_13;
        }
label_3:
        metadata1 = (IMetadata) superMd;
        num1 = 7;
      }
label_13:
      return superMd.ImplementedExtensionUids.Where<Guid>((Func<Guid, bool>) (uid => uid.IsConfigMetadata())).Select<Guid, EntityMetadata>((Func<Guid, EntityMetadata>) (uid => (EntityMetadata) metadataRuntimeService.GetMetadata(uid, false))).FirstOrDefault<EntityMetadata>();
label_14:
      return superMd;
    }

    /// <summary>Имеются ли кастомные представления</summary>
    /// <param name="viewType"></param>
    /// <param name="inTab"></param>
    /// <returns></returns>
    public bool HasCustomFormViews(ViewType viewType, bool? inTab = null) => EntityHelper.HasCustomFormViews((object) this.Entity as IEntity, viewType, inTab);

    /// <summary>Получить кастомные представления</summary>
    /// <param name="viewType"></param>
    /// <param name="inTab"></param>
    /// <returns></returns>
    public FormView GetCustomFormView(ViewType viewType, bool? inTab = null) => EntityHelper.GetCustomFormView((object) this.Entity as IEntity, viewType, inTab);

    /// <summary>Проверить доступность действия для модели</summary>
    /// <typeparam name="TManager"></typeparam>
    /// <param name="expression"></param>
    /// <returns></returns>
    public virtual bool CheckAction<TManager>([NotNull] Expression<Action<TManager>> expression) where TManager : IEntityManager => (bool) this.CheckActionWithResult<TManager>(expression);

    /// <summary>Проверить доступность действия для модели</summary>
    /// <typeparam name="TManager"></typeparam>
    /// <param name="expression"></param>
    /// <returns></returns>
    public virtual ActionCheckResult CheckActionWithResult<TManager>(
      [NotNull] Expression<Action<TManager>> expression)
      where TManager : IEntityManager
    {
      return expression != null ? Locator.GetServiceNotNull<ActionDispatcherService>().CheckActionWithResult<TManager>(expression, this.Entity.CastAsRealType<T>().GetType()) : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909180517));
    }

    internal static bool jSX9dkhZAcffnFtvUfVt() => EntityModel<T>.Mlkgd9hZHSMUMoDjGEmX == null;

    internal static object CP3rWnhZ7ydYjpZvLpdq() => EntityModel<T>.Mlkgd9hZHSMUMoDjGEmX;
  }
}

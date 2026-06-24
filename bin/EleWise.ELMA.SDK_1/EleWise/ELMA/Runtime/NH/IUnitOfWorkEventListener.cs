// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.IUnitOfWorkEventListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Точка расширения для прослушивания событий <see cref="T:EleWise.ELMA.Runtime.NH.IUnitOfWork" />
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IUnitOfWorkEventListener
  {
    /// <summary>Начала единицы работы</summary>
    /// <param name="unitOfWork">Единица работы</param>
    void OnStartUnitofWork(IUnitOfWork unitOfWork);

    /// <summary>
    /// Действие, выполняемое перед выполнением метода <see cref="M:NHibernate.ISession.Flush" />
    /// </summary>
    /// <param name="unitOfWork">Единица работы</param>
    /// <param name="entities">Список сущностей</param>
    void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities);

    /// <summary>
    /// Действие, выполняемое после выполнения метода <see cref="M:NHibernate.ISession.Flush" />
    /// </summary>
    /// <param name="unitOfWork">Единица работы</param>
    void OnPostFlushUnitofWork(IUnitOfWork unitOfWork);

    /// <summary>
    /// Действие, выполняемое перед выполнением метода <see cref="M:NHibernate.ITransaction.Commit" />
    /// </summary>
    /// <param name="unitOfWork">Единица работы</param>
    void OnPreCommitUnitofWork(IUnitOfWork unitOfWork);

    /// <summary>
    /// Действие, выполняемое после выполнения метода <see cref="M:NHibernate.ITransaction.Commit" />
    /// </summary>
    /// <param name="unitOfWork"></param>
    void OnPostCommitUnitofWork(IUnitOfWork unitOfWork);

    /// <summary>
    /// Действие, выполняемое после выполнения метода <see cref="M:NHibernate.ITransaction.Rollback" />
    /// </summary>
    /// <param name="unitOfWork"></param>
    void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork);

    /// <summary>Действие, выполняемое при уничтожении единица работы</summary>
    /// <param name="unitOfWork">Единица работы</param>
    void OnDisposeUnitofWork(IUnitOfWork unitOfWork);
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.IUnitOfWorkEventListenerAsync
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Асинхронная точка расширения для прослушивания событий <see cref="T:EleWise.ELMA.Runtime.NH.IUnitOfWorkAsync" />
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IUnitOfWorkEventListenerAsync : IUnitOfWorkEventListener
  {
    /// <summary>
    /// Действие, выполняемое перед выполнением метода <see cref="M:NHibernate.ISession.FlushAsync(System.Threading.CancellationToken)" />
    /// </summary>
    /// <param name="unitOfWork">Единица работы</param>
    /// <param name="entities">Список сущностей</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPreFlushUnitOfWorkAsync(
      IUnitOfWorkAsync unitOfWork,
      IEnumerable<object> entities,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>
    /// Действие, выполняемое после выполнения метода <see cref="M:NHibernate.ISession.FlushAsync(System.Threading.CancellationToken)" />
    /// </summary>
    /// <param name="unitOfWork">Единица работы</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPostFlushUnitOfWorkAsync(
      IUnitOfWorkAsync unitOfWork,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>
    /// Действие, выполняемое перед выполнением метода <see cref="M:NHibernate.ITransaction.CommitAsync(System.Threading.CancellationToken)" />
    /// </summary>
    /// <param name="unitOfWork">Единица работы</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPreCommitUnitOfWorkAsync(
      IUnitOfWorkAsync unitOfWork,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>
    /// Действие, выполняемое после выполнения метода <see cref="M:NHibernate.ITransaction.CommitAsync(System.Threading.CancellationToken)" />
    /// </summary>
    /// <param name="unitOfWork"></param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPostCommitUnitOfWorkAsync(
      IUnitOfWorkAsync unitOfWork,
      CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>
    /// Действие, выполняемое после выполнения метода <see cref="M:NHibernate.ITransaction.RollbackAsync(System.Threading.CancellationToken)" />
    /// </summary>
    /// <param name="unitOfWork"></param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task OnPostRollbackUnitOfWorkAsync(
      IUnitOfWorkAsync unitOfWork,
      CancellationToken cancellationToken = default (CancellationToken));
  }
}

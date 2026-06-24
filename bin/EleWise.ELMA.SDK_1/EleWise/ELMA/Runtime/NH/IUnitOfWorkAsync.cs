// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.IUnitOfWorkAsync
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>Асинхронная единица работы</summary>
  public interface IUnitOfWorkAsync : IUnitOfWork, IDisposable
  {
    /// <summary>
    /// Были ли произведены изменения в текущей еденице работы
    /// </summary>
    Task<bool> IsDirtyAsync { get; }

    /// <summary>Подтвердить изменения</summary>
    /// <param name="cancellationToken">Токен отмены</param>
    Task CommitAsync(CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>Откат изменений</summary>
    /// <param name="cancellationToken">Токен отмены</param>
    Task RollbackAsync(CancellationToken cancellationToken = default (CancellationToken));
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.UnitOfWork
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Абстрактный класс для реализации единицы работы (асинхронная часть)
  /// </summary>
  /// <summary>Абстрактный класс для реализации единицы работы</summary>
  public abstract class UnitOfWork : IUnitOfWorkAsync, IUnitOfWork, IDisposable
  {
    internal static UnitOfWork fnLVqZW1XVkMraixA0YS;

    /// <inheritdoc />
    public abstract Task<bool> IsDirtyAsync { get; }

    /// <inheritdoc />
    public abstract Task CommitAsync(CancellationToken cancellationToken = default (CancellationToken));

    /// <inheritdoc />
    public abstract Task RollbackAsync(CancellationToken cancellationToken = default (CancellationToken));

    /// <summary>Получить новую единицу работы</summary>
    /// <param name="dbName">Имя базы</param>
    /// <param name="transactional">Транзакционная ли единица работы</param>
    /// <returns>Единица работы</returns>
    public static IUnitOfWork New(string dbName, bool transactional) => Locator.GetServiceNotNull<IUnitOfWorkManager>().Create(dbName, transactional);

    /// <summary>Получить новую единицу работы</summary>
    /// <param name="dbName">Имя базы</param>
    /// <returns>Единица работы</returns>
    public static IUnitOfWork New(string dbName) => (IUnitOfWork) UnitOfWork.q1qHDrW1nyOv9v3b4snv((object) dbName, true);

    /// <inheritdoc />
    public abstract bool IsDirty { get; }

    /// <inheritdoc />
    public abstract void Commit();

    /// <inheritdoc />
    public abstract void Rollback();

    /// <inheritdoc />
    public abstract void Dispose();

    /// <inheritdoc />
    public abstract ISession Session { get; }

    /// <inheritdoc />
    public abstract Guid Uid { get; }

    protected UnitOfWork()
    {
      UnitOfWork.vZ4xlTW1OrVIbQXc7GNX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VyZ5wFW1To8pfr4O9e5g() => UnitOfWork.fnLVqZW1XVkMraixA0YS == null;

    internal static UnitOfWork N8QqRBW1kwei1L031a3O() => UnitOfWork.fnLVqZW1XVkMraixA0YS;

    internal static object q1qHDrW1nyOv9v3b4snv([In] object obj0, bool transactional) => (object) UnitOfWork.New((string) obj0, transactional);

    internal static void vZ4xlTW1OrVIbQXc7GNX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

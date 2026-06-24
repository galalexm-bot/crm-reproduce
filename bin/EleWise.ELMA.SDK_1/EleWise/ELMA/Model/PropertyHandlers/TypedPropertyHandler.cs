// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.PropertyHandlers.TypedPropertyHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.PropertyHandlers
{
  /// <summary>Базовый класс обработчика свойства</summary>
  [Component]
  public abstract class TypedPropertyHandler : IPropertyHandler
  {
    internal static TypedPropertyHandler WDtMFiWcZ3RKvACmKL9J;

    /// <summary>Уникальный идентификатор обработчика</summary>
    public abstract Guid Uid { get; }

    /// <summary>Имя обработчика (для текущей культуры)</summary>
    public abstract string Name { get; }

    /// <summary>Uid типа, для которого предназначен обработчик</summary>
    protected abstract Guid? TypeUid { get; }

    /// <summary>Uid подтипа, для которого предназначен обработчик</summary>
    protected virtual Guid? SubTypeUid => new Guid?(Guid.Empty);

    /// <summary>
    /// Можно ли навешивать несколько обработчиков данного типа (по умолчанию False)
    /// </summary>
    protected virtual bool Multiple => false;

    /// <summary>
    /// Могут ли быть навешены другие обработчики (по умолчанию False)
    /// </summary>
    protected virtual bool AllowOtherHandlers => false;

    /// <summary>Доступен ли обработчик (можно ли добавить)</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства, для которого нужно проверить доступность обработчика</param>
    /// <param name="typeUid">Uid типа данных</param>
    /// <param name="subTypeUid">Uid подтипа данных</param>
    /// <param name="currentHandlers">Список текущих обработчиков</param>
    /// <returns>True, если доступен</returns>
    public virtual bool IsAvailableFor(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      Guid typeUid,
      Guid subTypeUid,
      IEnumerable<PropertyHandlerInfo> currentHandlers)
    {
      Contract.ArgumentNotNull((object) classMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629711930));
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312849301));
      List<PropertyHandlerInfo> source = currentHandlers != null ? currentHandlers.ToList<PropertyHandlerInfo>() : new List<PropertyHandlerInfo>();
      if (!this.Multiple && source.FirstOrDefault<PropertyHandlerInfo>((Func<PropertyHandlerInfo, bool>) (h => TypedPropertyHandler.GpvcsTWcRfqLRHfXk4Q9(TypedPropertyHandler.rwpWeyWcSXKVnBjEZ7El((object) h), TypedPropertyHandler.L0AIrhWciVfjdp8sEFZK((object) this)))) != null || !this.AllowOtherHandlers && source.Count > 0)
        return false;
      Guid? nullable = this.TypeUid;
      if (!nullable.HasValue)
        return true;
      nullable = this.TypeUid;
      if (nullable.Value != typeUid)
        return false;
      nullable = this.SubTypeUid;
      if (!nullable.HasValue)
        return true;
      nullable = this.SubTypeUid;
      return !(nullable.Value != subTypeUid);
    }

    protected TypedPropertyHandler()
    {
      TypedPropertyHandler.fsJr6dWcV7NJ1yPQPjff();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void fsJr6dWcV7NJ1yPQPjff() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool vNgrrVWcukjZPvMqApIW() => TypedPropertyHandler.WDtMFiWcZ3RKvACmKL9J == null;

    internal static TypedPropertyHandler TbUyQGWcIJWRQc7wPjvi() => TypedPropertyHandler.WDtMFiWcZ3RKvACmKL9J;

    internal static Guid rwpWeyWcSXKVnBjEZ7El([In] object obj0) => ((PropertyHandlerInfo) obj0).HandlerUid;

    internal static Guid L0AIrhWciVfjdp8sEFZK([In] object obj0) => ((TypedPropertyHandler) obj0).Uid;

    internal static bool GpvcsTWcRfqLRHfXk4Q9([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}

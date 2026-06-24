// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.AuditDataEventArgs`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Базовый класс события аудита, имеющего типизорованные данные
  /// </summary>
  /// <typeparam name="T">Тип данных</typeparam>
  public abstract class AuditDataEventArgs<T> : AuditEventArgs
  {
    /// <summary>Ctor</summary>
    /// <param name="data">Данные</param>
    protected AuditDataEventArgs(T data)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Data = data;
    }

    /// <summary>Данные</summary>
    public T Data { get; set; }

    /// <summary>Получить словарь свойств расширения объекта</summary>
    public override IDictionary<string, object> ExtendedProperties
    {
      get
      {
        IDictionary<string, object> extendedProperties = base.ExtendedProperties;
        extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082361232)] = (object) this.Data;
        return extendedProperties;
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Impl.SimpleBoundVariableServiceBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services.Impl
{
  /// <summary>
  /// Базовое хранилище данных на основе словаря ключ-значение
  /// </summary>
  public abstract class SimpleBoundVariableServiceBase : 
    IClearableContextBoundVariableService,
    IContextBoundVariableService,
    IAbstractBoundVariableService
  {
    private static SimpleBoundVariableServiceBase f3xSyLBJo1uhCkVrS29M;

    /// <inheritdoc />
    public virtual bool Contains(string name) => this.Dictionary.ContainsKey(name);

    /// <inheritdoc />
    public virtual T Get<T>(string name)
    {
      T obj;
      if (!this.TryGetValue<T>(name, out obj))
        throw new VariableNotFoundException(name);
      return obj;
    }

    /// <inheritdoc />
    public virtual bool TryGetValue<T>(string name, out T value)
    {
      object obj;
      if (this.Dictionary.TryGetValue(name, out obj))
      {
        value = (T) obj;
        return true;
      }
      value = default (T);
      return false;
    }

    /// <inheritdoc />
    public virtual void Set(string name, object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Dictionary[name] = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    [Obsolete("This method is obsolete and throws exception. Use extension method IContextBoundVariableService.ClearFor or IContextBoundVariableService.ClearRegion instead.", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual void Clear() => throw new Exception((string) SimpleBoundVariableServiceBase.MMesXUBJGJSL1KcG6BTg(-2099751081 ^ -2099692149));

    void IClearableContextBoundVariableService.ClearContext() => SimpleBoundVariableServiceBase.Moa3vQBJEHbGbqrWqVId((object) this);

    /// <summary>Очистить все переменные</summary>
    protected virtual void ClearContext()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            SimpleBoundVariableServiceBase.i76H2PBJfbfvmZAs5FsW((object) this.Dictionary);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public virtual void Remove(string key)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Dictionary.Remove(key);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Словарь, хранящий значения, помещаемые в контекст</summary>
    protected abstract IDictionary<string, object> Dictionary { get; }

    protected SimpleBoundVariableServiceBase()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool zoKesWBJbhxptIE2n5wS() => SimpleBoundVariableServiceBase.f3xSyLBJo1uhCkVrS29M == null;

    internal static SimpleBoundVariableServiceBase oHKgovBJhYrP2gCR4CNm() => SimpleBoundVariableServiceBase.f3xSyLBJo1uhCkVrS29M;

    internal static object MMesXUBJGJSL1KcG6BTg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Moa3vQBJEHbGbqrWqVId([In] object obj0) => ((SimpleBoundVariableServiceBase) obj0).ClearContext();

    internal static void i76H2PBJfbfvmZAs5FsW([In] object obj0) => ((ICollection<KeyValuePair<string, object>>) obj0).Clear();
  }
}

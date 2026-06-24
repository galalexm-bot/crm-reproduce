// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DevServer.TypeDescriptors.AbstractSingleTypeDescriptorProvider`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace EleWise.ELMA.DevServer.TypeDescriptors
{
  /// <summary>
  /// Базовая реализация провайдера для единичного тайпдескриптора
  /// </summary>
  /// <typeparam name="TTd">Тайпдескриптор</typeparam>
  public abstract class AbstractSingleTypeDescriptorProvider<TTd> : ITypeDescriptorProvider where TTd : ITypeDescriptor
  {
    internal static object HAUJdgEny1tZpWnOignt;

    /// <summary>Получить тип тайпдескриптора</summary>
    /// <returns></returns>
    public virtual IEnumerable<Type> GetTypeDescriptors() => (IEnumerable<Type>) new Type[1]
    {
      TypeOf<TTd>.Raw
    };

    protected AbstractSingleTypeDescriptorProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool N76VqDEnMNwlS1ioWKbb() => AbstractSingleTypeDescriptorProvider<TTd>.HAUJdgEny1tZpWnOignt == null;

    internal static object kWGivwEnJy5Lix7P7Fbh() => AbstractSingleTypeDescriptorProvider<TTd>.HAUJdgEny1tZpWnOignt;
  }
}

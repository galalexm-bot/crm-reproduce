// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.InstanceCreators.DefaultInstanceCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.InstanceCreators
{
  /// <summary>Базовый класс создателей экземпляров</summary>
  internal class DefaultInstanceCreator : IInstanceCreator
  {
    internal static DefaultInstanceCreator SyhobMh0x7Cf1yGAnw7H;

    /// <inheritdoc />
    public virtual bool CanCreateInstance(Type type) => true;

    /// <inheritdoc />
    public virtual object CreateInstance(DataClass dataClass, Type type) => InterfaceActivator.Create(type);

    public DefaultInstanceCreator()
    {
      DefaultInstanceCreator.YW6fgGh0y5wDMraxcT0T();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void YW6fgGh0y5wDMraxcT0T() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool BxJ9mph00DrF6w2Bh5i0() => DefaultInstanceCreator.SyhobMh0x7Cf1yGAnw7H == null;

    internal static DefaultInstanceCreator mCgNYIh0mOeEnxNbmayE() => DefaultInstanceCreator.SyhobMh0x7Cf1yGAnw7H;
  }
}

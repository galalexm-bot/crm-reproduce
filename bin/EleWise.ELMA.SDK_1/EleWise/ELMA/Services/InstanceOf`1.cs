// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.InstanceOf`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Класс для активации типа через <see cref="T:EleWise.ELMA.Model.Services.InterfaceActivator" />,
  /// для установки свойств можно использовать свойство <see cref="P:EleWise.ELMA.Services.InstanceOf`1.New" />
  /// </summary>
  /// <typeparam name="T">Тип интерфейса или класса</typeparam>
  public class InstanceOf<T>
  {
    private static object qtqDd9BxPDdak7Ny9XDO;

    /// <summary>Экземпляр сущности</summary>
    [NotNull]
    public T New { get; private set; }

    /// <summary>Конструктор</summary>
    public InstanceOf()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.New = InterfaceActivator.Create<T>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private InstanceOf(T instance)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.New = instance;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public static explicit operator T(InstanceOf<T> instance) => instance != null ? instance.New : default (T);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public static explicit operator InstanceOf<T>(T instance) => new InstanceOf<T>(instance);

    internal static bool lhKmZ0Bx1VscullAyvLH() => InstanceOf<T>.qtqDd9BxPDdak7Ny9XDO == null;

    internal static object UHwKZFBxNuk31brSQIAs() => InstanceOf<T>.qtqDd9BxPDdak7Ny9XDO;
  }
}

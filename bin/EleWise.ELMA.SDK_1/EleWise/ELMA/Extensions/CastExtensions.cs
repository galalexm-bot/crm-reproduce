// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.CastExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DataClasses;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширения для приведения типов</summary>
  public static class CastExtensions
  {
    /// <summary>
    /// Приведение объекта <see cref="!:obj" /> к типу <see cref="!:T" />
    /// </summary>
    /// <param name="obj">Объект</param>
    /// <typeparam name="T">Тип, к которому необходимо привести</typeparam>
    /// <returns>Приведенный экземпляр объекта <see cref="!:obj" /> к типу <see cref="!:T" /> или <c>null</c>, если приведение невозможно</returns>
    public static T As<T>(this object obj) where T : class => obj is DataClass dataClass ? (T) dataClass.As(typeof (T)) : obj as T;

    /// <summary>
    /// Проверка является ли объект <see cref="!:obj" /> типом <see cref="!:T" />
    /// </summary>
    /// <param name="obj">Объект</param>
    /// <typeparam name="T">Проверяемый тип</typeparam>
    /// <returns><c>true</c>, если объект <see cref="!:obj" /> является типом <see cref="!:T" /></returns>
    public static bool Is<T>(this object obj) where T : class => obj is DataClass dataClass ? dataClass.Is(typeof (T)) : obj is T;
  }
}

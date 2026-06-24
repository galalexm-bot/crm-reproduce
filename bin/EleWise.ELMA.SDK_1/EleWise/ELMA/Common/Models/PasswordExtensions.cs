// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.Models.PasswordExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Common.Models
{
  /// <summary>Расширения для работы с паролем</summary>
  public static class PasswordExtensions
  {
    internal static PasswordExtensions gD2hNRfSERJ4lXDnLS6K;

    /// <summary>Получить обертку, для работы с паролем</summary>
    /// <param name="info">Контейнер хэша</param>
    /// <param name="settings">Настройки свойства</param>
    /// <returns></returns>
    public static PasswordWrapper ToWrapper(this PasswordInfo info, PasswordSettings settings) => new PasswordWrapper(info, settings);

    /// <summary>Получить обертку, для работы с паролем</summary>
    /// <param name="info">Контейнер хэша</param>
    /// <param name="propertyMetadata">Метаданный свойства</param>
    /// <returns></returns>
    public static PasswordWrapper ToWrapper(
      this PasswordInfo info,
      PropertyMetadata propertyMetadata)
    {
      return (PasswordWrapper) PasswordExtensions.hrXwHafSvOxd61TdL5dw((object) info, (object) (PasswordExtensions.bykqhMfSCHy3CS0WV9wd((object) propertyMetadata) as PasswordSettings));
    }

    /// <summary>Получить обертку, для работы с паролем</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="info">Контейнер хэша</param>
    /// <param name="expr">Экспрешен свойства</param>
    /// <returns></returns>
    public static PasswordWrapper ToWrapper<T>(
      this PasswordInfo info,
      Expression<Func<T, object>> expr)
    {
      PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata<T>(expr);
      return info.ToWrapper(propertyMetadata);
    }

    internal static bool xDLZASfSfoAAQvs2rO0E() => PasswordExtensions.gD2hNRfSERJ4lXDnLS6K == null;

    internal static PasswordExtensions lbQR53fSQdEAHktDHnB4() => PasswordExtensions.gD2hNRfSERJ4lXDnLS6K;

    internal static object bykqhMfSCHy3CS0WV9wd([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object hrXwHafSvOxd61TdL5dw([In] object obj0, [In] object obj1) => (object) ((PasswordInfo) obj0).ToWrapper((PasswordSettings) obj1);
  }
}

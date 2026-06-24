// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IDynamicExpressionPermission
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Интерфейс определения способа доступа к сущности на основе выражений, содержащих значения свойств экземпляров
  /// типа <see cref="T:EleWise.ELMA.Security.IUser" />, <see cref="T:System.Collections.Generic.ICollection`1" />
  /// </summary>
  public interface IDynamicExpressionPermission
  {
    /// <summary>Список выражений для свойств</summary>
    /// <param name="target">Объект вычисления прав</param>
    /// <returns>Возвращает список выражений, сгруппированных по родительским экземплярам</returns>
    IPropertyExpressionDescriptor[] GetPropertyDescriptors(object target);
  }
}

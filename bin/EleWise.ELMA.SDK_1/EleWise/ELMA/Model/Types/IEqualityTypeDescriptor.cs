// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.IEqualityTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Дополнительный интерфейс описания типа, позволяющий проверять на равенство значения данного типа
  /// </summary>
  public interface IEqualityTypeDescriptor
  {
    /// <summary>
    /// Сравнить значения. Если они равны - возвращается True.
    /// </summary>
    /// <param name="v1"></param>
    /// <param name="v2"></param>
    /// <returns></returns>
    bool IsValuesEquals(object v1, object v2);
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IPropertyExpressionDescriptorWithInstanceUid
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Выражение получения значения с уникальным идентификатором
  /// </summary>
  public interface IPropertyExpressionDescriptorWithInstanceUid : IPropertyExpressionDescriptor
  {
    /// <summary>Тип роли, по которой выдается привилегия</summary>
    PermissionRoleType RoleType { get; }

    /// <summary>
    /// Конкатенация выражения получения значения с уникальным идентификатором
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    string GetExpressionName(object obj);
  }
}

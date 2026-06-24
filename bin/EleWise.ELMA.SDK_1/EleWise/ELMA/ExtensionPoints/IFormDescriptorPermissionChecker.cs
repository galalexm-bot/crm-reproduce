// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IFormDescriptorPermissionChecker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.UI.Descriptors;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для проверки прав доступа по дескриптору формы
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IFormDescriptorPermissionChecker
  {
    /// <summary>
    /// Может ли данная точка расширения проверить права доступа по указанному дескриптору формы
    /// </summary>
    bool CanCheckPermission(Permission permission, FormDescriptor descriptor);

    /// <summary>
    /// Проверка права доступа по указанному дескриптору формы
    /// </summary>
    bool HasPermission(Permission permission, FormDescriptor descriptor);
  }
}

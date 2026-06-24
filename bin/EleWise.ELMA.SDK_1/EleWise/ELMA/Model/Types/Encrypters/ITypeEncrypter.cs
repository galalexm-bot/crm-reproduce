// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.ITypeEncrypter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Encrypters
{
  /// <summary>Точка расширения для шифрования типа</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface ITypeEncrypter
  {
    bool CheckType(object obj, IMetadata propertyMetadata);

    string Encrypt(object obj, string password, string salt, IMetadata propertyMetadata);

    object Decrypt(string encrypted, string password, string salt, IMetadata propertyMetadata);

    object EncryptStub(object obj, IMetadata propertyMetadata);
  }
}

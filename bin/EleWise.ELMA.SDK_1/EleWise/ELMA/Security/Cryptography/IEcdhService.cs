// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Cryptography.IEcdhService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Security.Cryptography
{
  /// <summary>Сервис согласования секрета сессии по алгоритму ECDH</summary>
  public interface IEcdhService
  {
    /// <summary>
    /// Получение ключевой пары по присланному другой стороной публичному ключу
    /// </summary>
    /// <param name="externalPublicKey">Публичный ключ</param>
    /// <returns>Ключевую пару: наш_публичный_ключ, shared_secret</returns>
    IEcdhKey DeriveKeyMaterial(byte[] externalPublicKey);

    /// <summary>
    /// Конвертация из формата ключа DotNet CNG в uncompressed format
    /// </summary>
    /// <param name="publicKey">Публичный ключ</param>
    /// <returns>Ключ в формате uncompressed</returns>
    byte[] DotNetToUncompressed(byte[] publicKey);

    /// <summary>
    /// Проверка и, при возможности, восстановление ключа в формате DotNet CNG
    /// </summary>
    /// <param name="publicKey">публичный ключ</param>
    /// <param name="normalizedPublicKey">Ключ в формате DotNet CNG</param>
    /// <returns>Результат проверки/конвертации</returns>
    bool CheckFixPublicKey(byte[] publicKey, out byte[] normalizedPublicKey);
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.FileStoreProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Configuration;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Provider;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Providers
{
  /// <summary>Базовай класс для провайдеров работы с файлами</summary>
  public abstract class FileStoreProvider : ProviderBase, IFileManager
  {
    private static FileStoreProvider nmAAEjWEoVKxa83xNwY3;

    protected FileStoreProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Реконфигурировать провайдер (вызывается при наличии менеджеров с IUpdatableProviderManagers)
    /// </summary>
    public virtual void ReConfigure(RuntimeConfiguration configuration)
    {
    }

    /// <summary>
    /// Получить обертку для файла, реализующую <see cref="T:EleWise.ELMA.Model.Entities.IEntity" />
    /// </summary>
    /// <param name="binaryFile">Файл</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEntity WrapFile(BinaryFile binaryFile) => (IEntity) new FileStoreProvider.BinaryFileWrapper(binaryFile);

    /// <summary>Папка для хранения временных файлов</summary>
    public abstract string TempFilesPath { get; set; }

    /// <summary>Папка для хранения файлов</summary>
    public abstract string FilesPath { get; set; }

    /// <summary>Путь для хранения предпросмотров</summary>
    public abstract string PreviewsPath { get; set; }

    /// <summary>Ключ элемента контекста</summary>
    public abstract string ContextItemsKey { get; }

    /// <summary>Ключ процесса хранения</summary>
    public abstract string ProcessStoreKey { get; }

    /// <summary>Сохранить файл</summary>
    /// <param name="binaryFile">Файл</param>
    /// <returns>Идентификатор в строковом представлении</returns>
    public abstract string SaveFile(BinaryFile binaryFile);

    /// <summary>Загрузить файл</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>Загруженный файл</returns>
    public abstract BinaryFile LoadFile(string id);

    /// <summary>Загрузить файлы</summary>
    /// <param name="idList">Массив идентификаторов файлов</param>
    /// <returns>Загруженные файлы</returns>
    public abstract BinaryFile[] LoadFiles(string[] idList);

    /// <summary>Проверить, существует ли файл в хранилище</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>True, если существует</returns>
    public abstract bool FileExists(string id);

    /// <summary>Получить размер файла из хранилища</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <returns>Размер файла в байтах</returns>
    public abstract long FileSize(string id);

    /// <summary>Переименовать файл в хранилище</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <param name="fileName">Имя файла</param>
    /// <returns>Переименован ли файл</returns>
    public abstract string RenameFile(string id, string fileName);

    /// <summary>Копировать файл</summary>
    /// <param name="sourceBinaryFile">Бинарный файл источник</param>
    public abstract BinaryFile CopyFile(BinaryFile sourceBinaryFile);

    /// <summary>Зашифровать</summary>
    /// <param name="file"></param>
    /// <param name="password"></param>
    /// <param name="salt"></param>
    public abstract void Encrypt(BinaryFile file, string password, string salt);

    /// <summary>
    /// Расшифровать файл (будет создаваться темповый файл на сервере)
    /// </summary>
    /// <param name="file"></param>
    /// <param name="password"></param>
    public abstract BinaryFile Decrypt(BinaryFile file, string password);

    /// <summary>Отмена шифрования для файла</summary>
    /// <param name="file"></param>
    /// <param name="password"></param>
    public abstract void CancelEncrypt(BinaryFile file, string password);

    internal static bool dkTqLKWEbOngFpNChJJt() => FileStoreProvider.nmAAEjWEoVKxa83xNwY3 == null;

    internal static FileStoreProvider QO9h4GWEhloY3i6dA1Fv() => FileStoreProvider.nmAAEjWEoVKxa83xNwY3;

    /// <summary>
    /// Обертку для файла, реализующая <see cref="T:EleWise.ELMA.Model.Entities.IEntity" />
    /// </summary>
    internal class BinaryFileWrapper : IEntity, IIdentified
    {
      internal static FileStoreProvider.BinaryFileWrapper o2JWBMQNVQ8iOMeb1qPV;

      /// <summary>ctor</summary>
      /// <param name="file">Файл</param>
      public BinaryFileWrapper(BinaryFile file)
      {
        FileStoreProvider.BinaryFileWrapper.UWBOegQNRGtlOjRWduIE();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.File = file;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      object IIdentified.GetId() => FileStoreProvider.BinaryFileWrapper.G2g5r0QNqWyQWoGpYhbT((object) this.File);

      /// <summary>Файл</summary>
      public BinaryFile File { get; }

      void IEntity.Delete() => throw new NotImplementedException();

      IEnumerable<IEntity> IEntity.GetContainedEntities() => throw new NotImplementedException();

      Guid[] IEntity.GetDirtyPropertyUids() => throw new NotImplementedException();

      TSettings IEntity.GetPropertySettings<TSettings>(Guid propertyUid) => throw new NotImplementedException();

      TypeSettings IEntity.GetPropertySettings(Guid propertyUid) => throw new NotImplementedException();

      TypeSettings IEntity.GetPropertySettings(Guid propertyUid, TypeSettings defaultSettings) => throw new NotImplementedException();

      object IEntity.GetPropertyValue(Guid propertyUid) => throw new NotImplementedException();

      T IEntity.GetPropertyValue<T>(Guid propertyUid) => throw new NotImplementedException();

      IEntity IEntity.GetRootEntity() => throw new NotImplementedException();

      bool IEntity.IsDirty() => throw new NotImplementedException();

      bool IEntity.IsNew() => throw new NotImplementedException();

      TypeSettings IEntity.LoadPropertyInstanceSettings(Guid propertyUid) => throw new NotImplementedException();

      ITypeSettingsInstanceStore IEntity.LoadSettingsInstanceStore(
        bool createIfNotExists,
        bool loadIfNotLoaded)
      {
        throw new NotImplementedException();
      }

      void IEntity.Refresh() => throw new NotImplementedException();

      void IEntity.Save() => throw new NotImplementedException();

      void IEntity.SavePropertyInstanceSettings(Guid propertyUid, TypeSettings settings) => throw new NotImplementedException();

      void IIdentified.SetId(object id) => throw new NotImplementedException();

      void IEntity.SetPropertyValue(Guid propertyUid, object value) => throw new NotImplementedException();

      string IEntity.ToString(string format) => throw new NotImplementedException();

      internal static void UWBOegQNRGtlOjRWduIE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool SOLsYlQNSyc3siFaaDJt() => FileStoreProvider.BinaryFileWrapper.o2JWBMQNVQ8iOMeb1qPV == null;

      internal static FileStoreProvider.BinaryFileWrapper edNdtMQNicoZS0If4Vm0() => FileStoreProvider.BinaryFileWrapper.o2JWBMQNVQ8iOMeb1qPV;

      internal static object G2g5r0QNqWyQWoGpYhbT([In] object obj0) => (object) ((BinaryFile) obj0).Id;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.SystemFileNHManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace EleWise.ELMA.Files
{
  /// <summary>
  /// Менеджер работы с системными фалами <see cref="T:EleWise.ELMA.Files.SystemFile" />.
  /// Для корректной работы в конфигурации должен быть настроен и подключен провайдер <see cref="T:EleWise.ELMA.Runtime.Providers.Impl.FileSystemFileStoreProvider" />
  /// </summary>
  [Service(Type = ComponentType.Server)]
  public class SystemFileNHManager : NHManager
  {
    internal static SystemFileNHManager JZ85S2GTYOu53EFS9COG;

    /// <summary>Вставить запись о файле в базу</summary>
    /// <param name="binaryFile">Файл</param>
    /// <returns>Идентификатор файла</returns>
    [Transaction]
    public virtual int InsertFile(SystemFile binaryFile)
    {
      int num1;
      switch (1)
      {
        case 1:
          try
          {
            this.InsertFileIntoContext(binaryFile);
            int num2 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
              num2 = 1;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  num1 = (int) SystemFileNHManager.RYGApuGTsM98XwtKNkjK((object) this.Session, (object) binaryFile);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_1;
              }
            }
          }
          catch (Exception ex)
          {
            int num3 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
              num3 = 0;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  goto label_10;
                default:
                  SystemFileNHManager.QPCx25GTzX4jdyXMTX0Z(SystemFileNHManager.tjCrHTGTcSSGPy7tPPJd(), (object) ex);
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 1;
                  continue;
              }
            }
label_10:
            throw;
          }
      }
label_1:
      return num1;
    }

    /// <summary>Переименовать файл</summary>
    /// <param name="id">Идентификатор файла</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">fileName не соответствует допустимому имени файла</exception>
    /// <returns>Файл</returns>
    [Transaction]
    public virtual SystemFile RenameFile(int id, string fileName)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            fileName = SystemFileNHManager.TrimFileNameSpecialChars((object) fileName);
            num1 = 6;
            continue;
          case 2:
            if (!SystemFileNHManager.muPsZBGkFm0fmvkChjbD((object) fileName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
              continue;
            }
            goto label_20;
          case 3:
            goto label_4;
          case 4:
            goto label_2;
          case 5:
            goto label_5;
          case 6:
            if (!string.IsNullOrWhiteSpace(fileName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 7 : 4;
              continue;
            }
            goto label_2;
          case 7:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 5 : 5;
            continue;
          default:
            goto label_20;
        }
      }
label_2:
      throw new ArgumentOutOfRangeException((string) SystemFileNHManager.fOvkjAGkBu4ufEtrg2PV(-1638402543 ^ -1638430709), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882364290));
label_4:
      SystemFile systemFile1;
      return systemFile1;
label_5:
      try
      {
        SystemFile systemFile2 = (SystemFile) SystemFileNHManager.TepYHKGkW8LWDYbt095h((object) this, id);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.Session.Update((object) systemFile2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 3;
              continue;
            case 2:
              goto label_4;
            case 3:
              systemFile1 = systemFile2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 0;
              continue;
            default:
              SystemFileNHManager.TMfQJKGkohQI7l9HtFI0((object) systemFile2, (object) fileName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
              continue;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_15;
            default:
              SystemFileNHManager.QPCx25GTzX4jdyXMTX0Z(SystemFileNHManager.tjCrHTGTcSSGPy7tPPJd(), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
              continue;
          }
        }
label_15:
        throw;
      }
label_20:
      throw new ArgumentOutOfRangeException((string) SystemFileNHManager.fOvkjAGkBu4ufEtrg2PV(1642859704 ^ 1642885794), (string) SystemFileNHManager.fOvkjAGkBu4ufEtrg2PV(-630932142 - 1120244082 ^ -1751332064));
    }

    /// <summary>Переименовать файл</summary>
    /// <param name="uid">Идентификатор файла</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">fileName не соответствует допустимому имени файла</exception>
    /// <returns>Файл</returns>
    [Transaction]
    public virtual SystemFile RenameFile(Guid uid, string fileName)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_22;
          case 2:
            if (SystemFileNHManager.muPsZBGkFm0fmvkChjbD((object) fileName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 1;
              continue;
            }
            fileName = (string) SystemFileNHManager.bYdaGLGkbSFUTG3FCB9f((object) fileName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 4;
            continue;
          case 3:
            goto label_6;
          case 4:
            if (SystemFileNHManager.muPsZBGkFm0fmvkChjbD((object) fileName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 3;
            continue;
          case 5:
            goto label_24;
          default:
            goto label_4;
        }
      }
label_4:
      throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921205799), (string) SystemFileNHManager.fOvkjAGkBu4ufEtrg2PV(1470998129 - 231418599 ^ 1239521942));
label_6:
      SystemFile systemFile1;
      try
      {
        SystemFile systemFile2 = (SystemFile) SystemFileNHManager.q0PNSKGkhQR04W49pdSX((object) this, uid);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
          num2 = 4;
        while (true)
        {
          switch (num2)
          {
            case 1:
              SystemFileNHManager.llqBJ2GkG3ZhW1N0Jcxf((object) this.Session, (object) systemFile2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 2;
              continue;
            case 2:
              systemFile1 = systemFile2;
              num2 = 3;
              continue;
            case 3:
              goto label_24;
            case 4:
              if (systemFile2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                continue;
              }
              SystemFileNHManager.TMfQJKGkohQI7l9HtFI0((object) systemFile2, (object) fileName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        throw new Exception(EleWise.ELMA.SR.T((string) SystemFileNHManager.fOvkjAGkBu4ufEtrg2PV(-1217523399 ^ -1217531835), (object) uid.ToString()));
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              ((ILogger) SystemFileNHManager.tjCrHTGTcSSGPy7tPPJd()).Error((object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            default:
              goto label_19;
          }
        }
label_19:
        throw;
      }
label_22:
      throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87872185), z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767810757));
label_24:
      return systemFile1;
    }

    private static string TrimFileNameSpecialChars(object fileName)
    {
      int num = 2;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            fileName = SystemFileNHManager.oGNV9UGkvAn8N8NxXv0E(fileName, SystemFileNHManager.PCdkNuGkCkOeK90CJIfr((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939363826), SystemFileNHManager.fB4ZRPGkQvdlkYkwgHJu((object) str)), (object) "");
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 2:
            str = (string) SystemFileNHManager.GvV2gYGkflPs81yS1RPH((object) new string((char[]) SystemFileNHManager.NGNPTlGkEZZ659vF6ZhD()), (object) new string(Path.GetInvalidPathChars()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) fileName;
    }

    /// <summary>Загрузить запись о файле из базы</summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Файл</returns>
    public virtual SystemFile LoadFile(int id)
    {
      int num = 2;
      string str;
      SystemFile file;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ContextVars.TryGetValue<SystemFile>(str, out file))
            {
              num = 5;
              continue;
            }
            goto label_7;
          case 2:
            str = (string) SystemFileNHManager.PCdkNuGkCkOeK90CJIfr(SystemFileNHManager.fOvkjAGkBu4ufEtrg2PV(-1852837372 ^ -1853090882), (object) id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.InsertFileIntoContext(file, str);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 3;
            continue;
          case 5:
            file = this.Session.Get<SystemFile>((object) id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 4 : 4;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return file;
label_7:
      return file;
    }

    /// <summary>Загрузить запись о файле из базы</summary>
    /// <param name="uid">Уникальный идентификатор</param>
    /// <returns>Файл</returns>
    public virtual SystemFile LoadFile(Guid uid)
    {
      int num = 3;
      SystemFile file;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.InsertFileIntoContext(file, uidKey: str);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          case 2:
            if (!ContextVars.TryGetValue<SystemFile>(str, out file))
            {
              num = 5;
              continue;
            }
            goto label_2;
          case 3:
            str = (string) SystemFileNHManager.PCdkNuGkCkOeK90CJIfr(SystemFileNHManager.fOvkjAGkBu4ufEtrg2PV(-1638402543 ^ -1638656085), (object) uid);
            num = 2;
            continue;
          case 4:
            goto label_2;
          case 5:
            file = ((ICriteria) SystemFileNHManager.bOjQX8GkuYhtL4AmK6Eu(SystemFileNHManager.ilgmW2GkZ5XbLco1N29r((object) this.Session.CreateCriteria<SystemFile>(), SystemFileNHManager.XXJRi5Gk8gJVwJWfTklM(SystemFileNHManager.fOvkjAGkBu4ufEtrg2PV(277947046 - -1479185048 ^ 1757141676), (object) uid)), 1)).SetCacheable(true).UniqueResult<SystemFile>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return file;
label_5:
      return file;
    }

    /// <summary>Загрузить запись о файле из базы</summary>
    /// <param name="id">Идентификатор файла в строковом виде</param>
    /// <returns>Файл</returns>
    public virtual SystemFile LoadFile(string id)
    {
      int num = 5;
      int result1;
      Guid result2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!int.TryParse(id, out result1))
            {
              num = 3;
              continue;
            }
            goto case 2;
          case 2:
            if (!(result2 != Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 3:
            goto label_8;
          case 4:
            if (Guid.TryParse(id, out result2))
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 5:
            result1 = 0;
            num = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (SystemFile) SystemFileNHManager.TepYHKGkW8LWDYbt095h((object) this, result1);
label_3:
      return this.LoadFile(result2);
label_8:
      throw new ArgumentException((string) SystemFileNHManager.ILG1pjGkIrqZxSN6sBK2(SystemFileNHManager.fOvkjAGkBu4ufEtrg2PV(1917998801 >> 2 ^ 479543110)));
    }

    /// <summary>Загрузить записи о файлах из базы</summary>
    /// <param name="idLong">Идентификаторы</param>
    /// <param name="uids">Уникальные идентификаторы</param>
    /// <returns>Файл</returns>
    public virtual SystemFile[] LoadFiles(long[] idLong, Guid[] uids)
    {
      int num1 = 5;
      ICriteria criteria;
      while (true)
      {
        int num2 = num1;
        AbstractCriterion expression;
        AbstractCriterion abstractCriterion;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (uids.Length == 0)
              {
                num2 = 7;
                continue;
              }
              goto case 8;
            case 2:
              if (idLong.Length == 0)
              {
                num2 = 6;
                continue;
              }
              goto case 9;
            case 4:
              abstractCriterion = (AbstractCriterion) SystemFileNHManager.x6eaFcGkVWB5G9FnS1fJ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824355645), (object) idLong);
              num2 = 14;
              continue;
            case 5:
              goto label_11;
            case 6:
            case 12:
            case 13:
              if (idLong == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                continue;
              }
              goto case 22;
            case 7:
            case 16:
            case 23:
              goto label_13;
            case 8:
              criteria.Add((ICriterion) expression);
              num2 = 17;
              continue;
            case 9:
              if (uids != null)
              {
                num2 = 10;
                continue;
              }
              goto case 6;
            case 10:
              if (uids.Length == 0)
              {
                num2 = 13;
                continue;
              }
              goto case 21;
            case 11:
              if (idLong != null)
              {
                num2 = 2;
                continue;
              }
              goto case 6;
            case 14:
              expression = (AbstractCriterion) SystemFileNHManager.x6eaFcGkVWB5G9FnS1fJ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654288075), (object) uids);
              num2 = 11;
              continue;
            case 17:
            case 19:
            case 20:
              goto label_14;
            case 18:
              SystemFileNHManager.ilgmW2GkZ5XbLco1N29r((object) criteria, (object) abstractCriterion);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 19 : 18;
              continue;
            case 21:
              criteria.Add((ICriterion) SystemFileNHManager.C4tanNGkSU9kyn6PwWn8((object) abstractCriterion, (object) expression));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 5 : 20;
              continue;
            case 22:
              if (idLong.Length == 0)
              {
                num2 = 3;
                continue;
              }
              goto case 18;
            default:
              if (uids == null)
              {
                num2 = 16;
                continue;
              }
              goto case 1;
          }
        }
label_11:
        criteria = this.Session.CreateCriteria<SystemFile>();
        num1 = 4;
      }
label_13:
      return new SystemFile[0];
label_14:
      return criteria.List<SystemFile>().ToArray<SystemFile>();
    }

    /// <summary>Вставить файл в контекстные переменные</summary>
    /// <param name="file">Файл</param>
    /// <param name="idKey">Ключ контекста с идентификатором файла</param>
    /// <param name="uidKey">Ключ контекста с уникальным идентификатором файла</param>
    private void InsertFileIntoContext(SystemFile file, string idKey = null, string uidKey = null)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!string.IsNullOrWhiteSpace(idKey))
                goto case 4;
              else
                goto label_10;
            case 2:
              if (file != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
                continue;
              }
              goto label_14;
            case 3:
              uidKey = (string) SystemFileNHManager.PCdkNuGkCkOeK90CJIfr(SystemFileNHManager.fOvkjAGkBu4ufEtrg2PV(--1418440330 ^ 1418219312), (object) SystemFileNHManager.FPHbbrGkRhfHLI8aV2S9((object) file));
              num2 = 7;
              continue;
            case 4:
              if (SystemFileNHManager.muPsZBGkFm0fmvkChjbD((object) uidKey))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 3 : 3;
                continue;
              }
              goto case 7;
            case 5:
              idKey = (string) SystemFileNHManager.PCdkNuGkCkOeK90CJIfr(SystemFileNHManager.fOvkjAGkBu4ufEtrg2PV(1669371371 ^ 1669559377), (object) SystemFileNHManager.oELs9UGkiDnJTTqBFY4T((object) file));
              num2 = 4;
              continue;
            case 6:
              goto label_3;
            case 7:
              ContextVars.Set<SystemFile>(idKey, file);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
              continue;
            default:
              ContextVars.Set<SystemFile>(uidKey, file);
              num2 = 6;
              continue;
          }
        }
label_10:
        num1 = 5;
      }
label_3:
      return;
label_14:;
    }

    public SystemFileNHManager()
    {
      SystemFileNHManager.gZHkFoGkqXOAjThpTyjM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object RYGApuGTsM98XwtKNkjK([In] object obj0, [In] object obj1) => ((ISession) obj0).Save(obj1);

    internal static object tjCrHTGTcSSGPy7tPPJd() => (object) Logger.Log;

    internal static void QPCx25GTzX4jdyXMTX0Z([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static bool CGKDRQGTLOjTHQ5qK9DZ() => SystemFileNHManager.JZ85S2GTYOu53EFS9COG == null;

    internal static SystemFileNHManager lgL3ssGTUTQ9F02mQBL7() => SystemFileNHManager.JZ85S2GTYOu53EFS9COG;

    internal static bool muPsZBGkFm0fmvkChjbD([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object fOvkjAGkBu4ufEtrg2PV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object TepYHKGkW8LWDYbt095h([In] object obj0, int id) => (object) ((SystemFileNHManager) obj0).LoadFile(id);

    internal static void TMfQJKGkohQI7l9HtFI0([In] object obj0, [In] object obj1) => ((SystemFile) obj0).Name = (string) obj1;

    internal static object bYdaGLGkbSFUTG3FCB9f([In] object obj0) => (object) SystemFileNHManager.TrimFileNameSpecialChars(obj0);

    internal static object q0PNSKGkhQR04W49pdSX([In] object obj0, Guid uid) => (object) ((SystemFileNHManager) obj0).LoadFile(uid);

    internal static void llqBJ2GkG3ZhW1N0Jcxf([In] object obj0, [In] object obj1) => ((ISession) obj0).Update(obj1);

    internal static object NGNPTlGkEZZ659vF6ZhD() => (object) Path.GetInvalidFileNameChars();

    internal static object GvV2gYGkflPs81yS1RPH([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object fB4ZRPGkQvdlkYkwgHJu([In] object obj0) => (object) Regex.Escape((string) obj0);

    internal static object PCdkNuGkCkOeK90CJIfr([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object oGNV9UGkvAn8N8NxXv0E([In] object obj0, [In] object obj1, [In] object obj2) => (object) Regex.Replace((string) obj0, (string) obj1, (string) obj2);

    internal static object XXJRi5Gk8gJVwJWfTklM([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object ilgmW2GkZ5XbLco1N29r([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object bOjQX8GkuYhtL4AmK6Eu([In] object obj0, [In] int obj1) => (object) ((ICriteria) obj0).SetFetchSize(obj1);

    internal static object ILG1pjGkIrqZxSN6sBK2([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object x6eaFcGkVWB5G9FnS1fJ([In] object obj0, [In] object obj1) => (object) Restrictions.In((string) obj0, (ICollection) obj1);

    internal static object C4tanNGkSU9kyn6PwWn8([In] object obj0, [In] object obj1) => (object) Restrictions.Or((ICriterion) obj0, (ICriterion) obj1);

    internal static int oELs9UGkiDnJTTqBFY4T([In] object obj0) => ((SystemFile) obj0).Id;

    internal static Guid FPHbbrGkRhfHLI8aV2S9([In] object obj0) => ((SystemFile) obj0).Uid;

    internal static void gZHkFoGkqXOAjThpTyjM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

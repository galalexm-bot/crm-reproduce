// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.BackupStatus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime
{
  /// <summary>
  /// Класс с данными о состоянии резервного копирования для стартовой формы StartInfo
  /// </summary>
  [Serializable]
  public class BackupStatus
  {
    private readonly string[] ContextDescription;
    private BackupStatus.BackupContext backupStatus;
    internal static BackupStatus b4AxVDWoFXMel7oDD6QV;

    /// <summary>
    /// Получить/установить текущее состояние резервного копирования
    /// </summary>
    public BackupStatus.BackupContext CurrentStatus
    {
      get => this.backupStatus;
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              goto label_2;
            case 2:
              if (this.backupStatus != BackupStatus.BackupContext.Unknown)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
                continue;
              }
              goto case 3;
            case 3:
              this.backupStatus = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            default:
              goto label_7;
          }
        }
label_4:
        return;
label_2:
        return;
label_7:;
      }
    }

    /// <summary>
    /// Получить текущее описание состояния по резервному копированию
    /// </summary>
    public string CurrentDescription => (string) BackupStatus.GdCvh0WobsHctswTrWpM((object) this.ContextDescription[BackupStatus.Uk1spGWoon8oFmikjreK((object) this.backupStatus)]);

    /// <summary>
    /// Выяснить, является ли текущее состояние определённым (Unknown - неопределённое, остальные - определённые).
    /// Используется для назначения цветовой схемы тексту.
    /// </summary>
    public bool IsCurrentStatusDetermined => this.backupStatus != 0;

    /// <summary>
    /// Видимость состояния резервного копирования на стартовой форме StartInfo. Устанавливается извне.
    /// </summary>
    public bool IsVisible
    {
      get => this.\u003CIsVisible\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CIsVisible\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Конструктор по умолчанию</summary>
    public BackupStatus()
    {
      BackupStatus.No1Y94Woh0H4r87qq4jk();
      this.ContextDescription = new string[4]
      {
        (string) BackupStatus.llgWx6WoE0rmmSjVd4jL(BackupStatus.MqHWBoWoG3odvJBgov2R(-441065788 ^ -2092910478 ^ 1727327156)),
        EleWise.ELMA.SR.M((string) BackupStatus.MqHWBoWoG3odvJBgov2R(-680446928 - -370807692 ^ -309671396)),
        (string) BackupStatus.llgWx6WoE0rmmSjVd4jL((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107948562)),
        (string) BackupStatus.llgWx6WoE0rmmSjVd4jL(BackupStatus.MqHWBoWoG3odvJBgov2R(-688192331 - 435440695 ^ -1123600870))
      };
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.backupStatus = BackupStatus.BackupContext.Unknown;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static bool WeFpdCWoBhHqQMrAkSWX() => BackupStatus.b4AxVDWoFXMel7oDD6QV == null;

    internal static BackupStatus BCZmwgWoWIsx8btTmWSZ() => BackupStatus.b4AxVDWoFXMel7oDD6QV;

    internal static int Uk1spGWoon8oFmikjreK([In] object obj0) => Convert.ToInt32(obj0);

    internal static object GdCvh0WobsHctswTrWpM([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void No1Y94Woh0H4r87qq4jk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object MqHWBoWoG3odvJBgov2R(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object llgWx6WoE0rmmSjVd4jL([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    /// <summary>Перечисление возможных состояний бекапа</summary>
    public enum BackupContext
    {
      /// <summary>
      /// Сведений о резервной копии БД ещё нет.
      /// Будет выводиться сообщение о возможной необходимости сделать РК.
      /// </summary>
      Unknown,
      /// <summary>
      /// Резервная копия БД не потребовалась.
      /// Этот код выставляется, когда инициализация прошла обе проверки на изменения с отрицательным результатом.
      /// </summary>
      NotNeeded,
      /// <summary>
      /// Резервная копия БД была сделана в автоматическом режиме.
      /// </summary>
      DoneAutomatically,
      /// <summary>
      /// Резервная копия БД была сделана и подтверждена вручную.
      /// </summary>
      DoneManually,
    }
  }
}

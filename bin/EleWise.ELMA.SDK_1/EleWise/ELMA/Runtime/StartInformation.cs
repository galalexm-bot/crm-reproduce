// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.StartInformation
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime
{
  /// <summary>Информация о запуске приложения</summary>
  [Serializable]
  public class StartInformation : IStartInformation, IDisposable
  {
    private static ILogger logger;
    private static readonly StartInformation root;
    private static IStartInformation current;
    private string _message;
    private readonly BackupStatus backupStatus;
    private static StartInformation jEMaK7Wo00pPVimdQ23p;

    /// <summary>Информация об исполнении текущей операции</summary>
    public static IStartInformation Current
    {
      get => StartInformation.current;
      protected set => StartInformation.current = value;
    }

    /// <summary>Общая информация о запуске приложения</summary>
    public static StartInformation Root => StartInformation.root;

    /// <summary>Создать объект с информацией об исполняемой операции</summary>
    /// <param name="completePercent">Процент выполнения родительской операции после завершения данной операции</param>
    /// <param name="message">Начальное сообщение (должна передаваться помеченной на перевод, через SR.M)</param>
    /// <returns></returns>
    public static IStartInformation Operation(double completePercent, string message) => (IStartInformation) new StartInformation.ChildStartInformation(completePercent, message);

    /// <summary>Статус</summary>
    public StartStatus Status
    {
      get => this.\u003CStatus\u003Ek__BackingField;
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
              this.\u003CStatus\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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

    /// <summary>Тип ошибки (если Status = NotStarted)</summary>
    public StartErrorType ErrorType
    {
      get => this.\u003CErrorType\u003Ek__BackingField;
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
              this.\u003CErrorType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
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

    /// <summary>Сообщение (текущее действие или ошибка)</summary>
    public virtual string Message
    {
      get => EleWise.ELMA.SR.T(this._message);
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
              this._message = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    /// <summary>Описание ошибок</summary>
    public string Errors
    {
      get => this.\u003CErrors\u003Ek__BackingField;
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
              this.\u003CErrors\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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

    /// <summary>Процент запуска (0..100)</summary>
    public double Percent
    {
      get => this.\u003CPercent\u003Ek__BackingField;
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
              this.\u003CPercent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
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

    /// <summary>Были ли ошибки при запуске конфигурации</summary>
    public bool HasErrors
    {
      get => this.\u003CHasErrors\u003Ek__BackingField;
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
              this.\u003CHasErrors\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    /// <summary>С какой версии осуществляется обновление</summary>
    public string UpdateFromVersion
    {
      get => this.\u003CUpdateFromVersion\u003Ek__BackingField;
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
              this.\u003CUpdateFromVersion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
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

    public BackupStatus Backup => this.backupStatus;

    /// <summary>Установить информацию</summary>
    /// <param name="percent">Процент (если текущий процент больше, то не изменяется)</param>
    /// <param name="message">Сообщение (должно передаваться помеченной на перевод, через SR.M)</param>
    public void SetInfo(double percent, string message)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            if (!((string) StartInformation.ptWi2aWoMfqVPRZZR16N((object) this) == message))
            {
              num = 6;
              continue;
            }
            goto label_2;
          case 2:
            if (this.Percent == percent)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 0;
              continue;
            }
            goto case 6;
          case 3:
            goto label_5;
          case 4:
            this.Percent = percent;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 7 : 5;
            continue;
          case 5:
            StartInformation.Log((string) StartInformation.VCLOBsWo9GRWDDV3DGIc(-606654180 ^ -606683544));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 3;
            continue;
          case 6:
            if (percent > this.Percent)
            {
              num = 4;
              continue;
            }
            goto case 7;
          case 7:
            StartInformation.jsCs7eWoJdOy6qAgUJ2y((object) this, (object) message);
            num = 5;
            continue;
          default:
            goto label_14;
        }
      }
label_8:
      return;
label_5:
      return;
label_14:
      return;
label_2:;
    }

    public void StopOperation()
    {
    }

    public override string ToString() => (string) StartInformation.iFPIudWodTdl4RgxmZL8((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121258357), (object) this.Status);

    /// <summary>Логирование</summary>
    /// <param name="operation">Название текущей операции</param>
    /// <param name="level">Уровень вложенности лога (количество пробелов)</param>
    protected static void Log(string operation, string level = "")
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            StartInformation.logger.InfoFormat((string) StartInformation.VCLOBsWo9GRWDDV3DGIc(-1710575414 ^ -1710538920), (object) StartInformation.Root.Percent, (object) operation, (object) level, StartInformation.ptWi2aWoMfqVPRZZR16N(StartInformation.RQtT7bWolfwtfWnauwT1()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    void IDisposable.Dispose()
    {
    }

    public StartInformation()
    {
      StartInformation.CJC20KWor1cKof1GiCKl();
      this.backupStatus = new BackupStatus();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static StartInformation()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            StartInformation.current = (IStartInformation) StartInformation.root;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
            continue;
          case 2:
            StartInformation.root = new StartInformation();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
            continue;
          case 3:
            StartInformation.logger = (ILogger) StartInformation.pHL5LhWogtygIZrJmdst(StartInformation.VCLOBsWo9GRWDDV3DGIc(-1290212282 ^ -644262414 ^ 1786787452));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 0;
            continue;
          case 4:
            StartInformation.CJC20KWor1cKof1GiCKl();
            num = 3;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    internal static bool ObRQ62Womkfgu4iK5OZo() => StartInformation.jEMaK7Wo00pPVimdQ23p == null;

    internal static StartInformation Y5QujrWoyewJYbwQBIdM() => StartInformation.jEMaK7Wo00pPVimdQ23p;

    internal static object ptWi2aWoMfqVPRZZR16N([In] object obj0) => (object) ((StartInformation) obj0).Message;

    internal static void jsCs7eWoJdOy6qAgUJ2y([In] object obj0, [In] object obj1) => ((StartInformation) obj0).Message = (string) obj1;

    internal static object VCLOBsWo9GRWDDV3DGIc(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object iFPIudWodTdl4RgxmZL8([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object RQtT7bWolfwtfWnauwT1() => (object) StartInformation.Root;

    internal static void CJC20KWor1cKof1GiCKl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object pHL5LhWogtygIZrJmdst([In] object obj0) => (object) Logger.GetLogger((string) obj0);

    private class ChildStartInformation : IStartInformation, IDisposable
    {
      private object parent;
      private object startMessage;
      private double startPercent;
      private double completePercent;
      private double deltaPercent;
      private double percent;
      private bool stopped;
      private object level;
      private static object AVRNM0Q1XT7PmohkJodk;

      public ChildStartInformation(double completePercent, string message)
      {
        StartInformation.ChildStartInformation.nWURqNQ1noFfwBhfjVZ0();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 4;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.Message = message;
              num = 2;
              continue;
            case 2:
              StartInformation.current = (IStartInformation) this;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 14 : 10;
              continue;
            case 3:
              this.level = StartInformation.ChildStartInformation.pUJiETQ1eMmFyD6bhXUo(this.level, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124691968));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            case 4:
              this.parent = (object) StartInformation.current;
              num = 11;
              continue;
            case 5:
              goto label_20;
            case 6:
              this.startMessage = StartInformation.ChildStartInformation.KsNPTeQ12Vq7e8ZB5q7i(this.parent);
              num = 12;
              continue;
            case 7:
              StartInformation.Log(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397167516), (string) this.level);
              num = 5;
              continue;
            case 9:
              this.deltaPercent = 0.0;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
              continue;
            case 10:
              this.completePercent = completePercent;
              num = 6;
              continue;
            case 11:
              this.startPercent = StartInformation.ChildStartInformation.SNAMLCQ1OMIRgVNj43uJ(this.parent);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 10 : 4;
              continue;
            case 12:
              this.deltaPercent = completePercent - this.startPercent;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 15 : 13;
              continue;
            case 13:
              if (this.level == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 2 : 16;
                continue;
              }
              goto case 3;
            case 14:
              this.level = !(this.parent is StartInformation.ChildStartInformation parent) ? (object) null : parent.level;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 13 : 3;
              continue;
            case 15:
              if (this.deltaPercent < 0.0)
              {
                num = 9;
                continue;
              }
              goto case 1;
            case 16:
              this.level = (object) "";
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 8 : 4;
              continue;
            default:
              this.stopped = false;
              num = 7;
              continue;
          }
        }
label_20:;
      }

      public double Percent
      {
        get => this.percent;
        set
        {
          int num1 = 3;
          while (true)
          {
            double num2;
            double num3;
            switch (num1)
            {
              case 1:
                goto label_2;
              case 2:
                if (value > 100.0)
                {
                  num3 = 100.0;
                  break;
                }
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                continue;
              case 3:
                if (value >= 0.0)
                {
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 2 : 1;
                  continue;
                }
                num3 = 0.0;
                break;
              case 4:
                StartInformation.ChildStartInformation.U9Bu9hQ1P0XQtPrlg6sP(this.parent, this.startPercent + this.percent * this.deltaPercent / 100.0);
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
                continue;
              case 5:
                this.percent = num2;
                num1 = 4;
                continue;
              default:
                num3 = value;
                break;
            }
            num2 = num3;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 5 : 4;
          }
label_2:;
        }
      }

      public string Message
      {
        get => ((IStartInformation) this.parent).Message;
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
                StartInformation.ChildStartInformation.N7ROehQ110NaBefbJGQO(this.parent, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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

      public void SetInfo(double percent, string message)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.Percent == percent)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 2:
              goto label_3;
            case 3:
              StartInformation.Log((string) StartInformation.ChildStartInformation.MSQpqPQ13Ll3PN1dGrQk(1917998801 >> 2 ^ 479533760), (string) this.level);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 2;
              continue;
            case 4:
              if (percent > this.Percent)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 6;
                continue;
              }
              goto case 7;
            case 5:
              goto label_8;
            case 6:
              this.Percent = percent;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 5 : 7;
              continue;
            case 7:
              this.Message = message;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 3 : 0;
              continue;
            default:
              if (!StartInformation.ChildStartInformation.uYG2xqQ1NRdFINuwebpV((object) this.Message, (object) message))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 4 : 1;
                continue;
              }
              goto label_2;
          }
        }
label_3:
        return;
label_8:
        return;
label_2:;
      }

      public void StopOperation()
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_3;
              case 1:
                goto label_4;
              case 2:
                this.stopped = true;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 1;
                continue;
              case 3:
                StartInformation.ChildStartInformation.d9Ooi0Q1pJeZaXIfU9FB(this.parent);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                continue;
              default:
                goto label_7;
            }
          }
label_4:
          StartInformation.Log((string) StartInformation.ChildStartInformation.MSQpqPQ13Ll3PN1dGrQk(1253244298 - 1829393894 ^ -576118538), (string) this.level);
          num1 = 3;
        }
label_3:
        return;
label_7:;
      }

      public void Dispose()
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              ((IStartInformation) this.parent).Message = (string) this.startMessage;
              num = 7;
              continue;
            case 2:
              StartInformation.current = (IStartInformation) this.parent;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 4 : 4;
              continue;
            case 3:
              if (!this.stopped)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 2;
                continue;
              }
              break;
            case 4:
              StartInformation.ChildStartInformation.U9Bu9hQ1P0XQtPrlg6sP(this.parent, this.completePercent);
              num = 6;
              continue;
            case 5:
              goto label_8;
            case 6:
              StartInformation.Log((string) StartInformation.ChildStartInformation.MSQpqPQ13Ll3PN1dGrQk(-477139494 ^ -477173112), (string) this.level);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
              continue;
            case 7:
              goto label_2;
          }
          StartInformation.current = (IStartInformation) this.parent;
          num = 5;
        }
label_8:
        return;
label_2:;
      }

      internal static void nWURqNQ1noFfwBhfjVZ0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static double SNAMLCQ1OMIRgVNj43uJ([In] object obj0) => ((IStartInformation) obj0).Percent;

      internal static object KsNPTeQ12Vq7e8ZB5q7i([In] object obj0) => (object) ((IStartInformation) obj0).Message;

      internal static object pUJiETQ1eMmFyD6bhXUo([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

      internal static bool TJEovwQ1TkS4Q7rEto6A() => StartInformation.ChildStartInformation.AVRNM0Q1XT7PmohkJodk == null;

      internal static StartInformation.ChildStartInformation W22Lf2Q1kNPwIQkxHaDP() => (StartInformation.ChildStartInformation) StartInformation.ChildStartInformation.AVRNM0Q1XT7PmohkJodk;

      internal static void U9Bu9hQ1P0XQtPrlg6sP([In] object obj0, double value) => ((IStartInformation) obj0).Percent = value;

      internal static void N7ROehQ110NaBefbJGQO([In] object obj0, [In] object obj1) => ((IStartInformation) obj0).Message = (string) obj1;

      internal static bool uYG2xqQ1NRdFINuwebpV([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

      internal static object MSQpqPQ13Ll3PN1dGrQk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void d9Ooi0Q1pJeZaXIfU9FB([In] object obj0) => ((IStartInformation) obj0).StopOperation();
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.DBStartInformation
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime
{
  /// <summary>
  /// Информация о запуске приложения. Стадия преобразования бд
  /// </summary>
  internal class DBStartInformation : StartInformation, IDisposable
  {
    private IStartInformation parent;
    private string startMessage;
    private DatabaseConversionStage сurrentDatabaseConversionStage;
    private readonly string level;
    private static DBStartInformation UZfkUEWWCtFcqj8HpkUn;

    /// <summary>Cтадия преобразования базы данных</summary>
    /// <param name="databaseStage">Стадия преобразования базы данных</param>
    public DBStartInformation(DatabaseConversionStage databaseStage)
    {
      DBStartInformation.XsUY04WWZ6M1Nv4rVwWX();
      this.level = (string) DBStartInformation.mTBREqWWu5Jm5MjA8wTj(1581325282 << 3 ^ -234268636);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
        num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            StartInformation.Log((string) DBStartInformation.mTBREqWWu5Jm5MjA8wTj(-1487388570 ^ -1487288542), this.level);
            num = 2;
            continue;
          case 2:
            goto label_3;
          case 3:
            DBStartInformation.RFCZEuWWRxBI2n7YX8T0((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
            continue;
          case 4:
            this.CurrentDatabaseConversionStage = databaseStage;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 3 : 6;
            continue;
          case 5:
            this.startMessage = (string) DBStartInformation.b5t8Y3WWVLNaDas88id3((object) this.parent);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 6:
            this.parent = (IStartInformation) DBStartInformation.x1tLGbWWI1wLxS0sXixW();
            num = 5;
            continue;
          default:
            DBStartInformation.Su897wWWi8eQJjgMYe9t((object) this, DBStartInformation.FABJEMWWS7m2NHJVDMRa((Enum) databaseStage));
            num = 3;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Текущий статус преобразования базы данных</summary>
    public DatabaseConversionStage CurrentDatabaseConversionStage
    {
      get => this.сurrentDatabaseConversionStage;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.сurrentDatabaseConversionStage = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            case 2:
              parent.сurrentDatabaseConversionStage = value;
              num = 3;
              continue;
            case 3:
              goto label_2;
            default:
              if (this.parent is DBStartInformation parent)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 2 : 2;
                continue;
              }
              goto label_7;
          }
        }
label_2:
        return;
label_7:;
      }
    }

    /// <summary>Название этапа</summary>
    public override string Message
    {
      get => (string) DBStartInformation.b5t8Y3WWVLNaDas88id3((object) this.parent);
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
              DBStartInformation.aldJAVWWqvpaS4NwCT69((object) this.parent, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
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

    /// <summary>Возвращение родителя в текущее состояние</summary>
    public void Dispose()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            StartInformation.Log(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951546188), this.level);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 3 : 2;
            continue;
          case 2:
            StartInformation.Current = this.parent;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 1;
            continue;
          case 3:
            DBStartInformation.Su897wWWi8eQJjgMYe9t((object) this, (object) this.startMessage);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static void XsUY04WWZ6M1Nv4rVwWX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object mTBREqWWu5Jm5MjA8wTj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object x1tLGbWWI1wLxS0sXixW() => (object) StartInformation.Current;

    internal static object b5t8Y3WWVLNaDas88id3([In] object obj0) => (object) ((IStartInformation) obj0).Message;

    internal static object FABJEMWWS7m2NHJVDMRa(Enum enumValue) => (object) enumValue.GetDisplayName();

    internal static void Su897wWWi8eQJjgMYe9t([In] object obj0, [In] object obj1) => ((StartInformation) obj0).Message = (string) obj1;

    internal static void RFCZEuWWRxBI2n7YX8T0([In] object obj0) => StartInformation.Current = (IStartInformation) obj0;

    internal static bool QC0skFWWvufha6bXrwjG() => DBStartInformation.UZfkUEWWCtFcqj8HpkUn == null;

    internal static DBStartInformation jOC63kWW8q0ykJQxVavD() => DBStartInformation.UZfkUEWWCtFcqj8HpkUn;

    internal static void aldJAVWWqvpaS4NwCT69([In] object obj0, [In] object obj1) => ((IStartInformation) obj0).Message = (string) obj1;
  }
}

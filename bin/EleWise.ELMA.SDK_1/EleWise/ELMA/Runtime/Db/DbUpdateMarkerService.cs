// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.DbUpdateMarkerService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>
  /// Сервис, позволяющий получать или ставить метки при обновлении структуры БД
  /// </summary>
  [Service(Type = ComponentType.Server)]
  public class DbUpdateMarkerService
  {
    private ConcurrentDictionary<KeyValuePair<Guid, string>, string> cache;
    private static DbUpdateMarkerService PFrkKoWZ3HyFBZme17SH;

    /// <summary>Провайдер преобразования БД</summary>
    public ITransformationProvider Transform
    {
      get => this.\u003CTransform\u003Ek__BackingField;
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
              this.\u003CTransform\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
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

    /// <summary>Получить значение метки</summary>
    /// <param name="moduleUid">Уникальный идентификатор модуля</param>
    /// <param name="markerName">Имя метки</param>
    /// <returns>Значение (или null, если метка не найдена)</returns>
    public string GetMarker(Guid moduleUid, string markerName)
    {
      int num1 = 5;
      string marker;
      while (true)
      {
        int num2 = num1;
        IDataReader dataReader;
        KeyValuePair<Guid, string> key;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!this.cache.TryGetValue(key, out marker))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                continue;
              }
              goto label_16;
            case 2:
              goto label_14;
            case 3:
              goto label_16;
            case 4:
              key = new KeyValuePair<Guid, string>(moduleUid, markerName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 1;
              continue;
            case 5:
              Contract.ServiceNotNull((object) this.Transform, (string) DbUpdateMarkerService.nSlGLmWZDK6dqOHpaHsR(-342626196 - 1290888215 ^ -1633470837));
              num2 = 4;
              continue;
            case 6:
              dataReader = this.Transform.ExecuteQuery((string) DbUpdateMarkerService.nSlGLmWZDK6dqOHpaHsR(1142330761 ^ 1541959139 ^ 536822430), new Dictionary<string, object>()
              {
                {
                  z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886538207),
                  (object) moduleUid
                },
                {
                  z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852945984),
                  (object) markerName
                }
              });
              num2 = 7;
              continue;
            case 7:
              try
              {
                if (DbUpdateMarkerService.Lr8pS9WZtlnZigjFhICh((object) dataReader))
                {
                  int num3 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
                    num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        marker = (string) DbUpdateMarkerService.dNVlvMWZwOdib8jNsM9e((object) dataReader, 0);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_22;
                    }
                  }
                }
                else
                  goto case 8;
              }
              finally
              {
                if (dataReader != null)
                {
                  int num4 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        dataReader.Dispose();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_13;
                    }
                  }
                }
label_13:;
              }
            case 8:
label_22:
              this.cache[key] = marker;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 2;
              continue;
            default:
              goto label_17;
          }
        }
label_17:
        marker = (string) null;
        num1 = 6;
      }
label_14:
      return marker;
label_16:
      return marker;
    }

    /// <summary>Установить значение метки</summary>
    /// <param name="moduleUid">Уникальный идентификатор модуля</param>
    /// <param name="markerName">Имя метки</param>
    /// <param name="value">Значение метки</param>
    /// <returns>Значение (или null, если метка не найдена)</returns>
    public void SetMarker(Guid moduleUid, string markerName, string value)
    {
      int num = 5;
      KeyValuePair<Guid, string> key;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            this.cache[key] = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          case 2:
          case 3:
            key = new KeyValuePair<Guid, string>(moduleUid, markerName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 0;
            continue;
          case 4:
            if (DbUpdateMarkerService.VvfNbNWZ6xOKwUvk9Zxk(this.Transform.ExecuteScalar((string) DbUpdateMarkerService.nSlGLmWZDK6dqOHpaHsR(-35995181 ^ -35948017), new Dictionary<string, object>()
            {
              {
                (string) DbUpdateMarkerService.nSlGLmWZDK6dqOHpaHsR(-97972138 ^ -97997832),
                (object) moduleUid
              },
              {
                (string) DbUpdateMarkerService.nSlGLmWZDK6dqOHpaHsR(-1638402543 ^ -1638511147),
                (object) markerName
              }
            })) > 0)
            {
              num = 6;
              continue;
            }
            goto case 7;
          case 5:
            DbUpdateMarkerService.UKmRGGWZ4yuNZPdZ7Zuu((object) this.Transform, DbUpdateMarkerService.nSlGLmWZDK6dqOHpaHsR(-1824388195 ^ -1824280253));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 4 : 2;
            continue;
          case 6:
            this.Transform.Update((string) DbUpdateMarkerService.nSlGLmWZDK6dqOHpaHsR(-1204263869 ^ -1341583247 ^ 137414818), new string[1]
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323107988)
            }, new object[1]{ (object) value }, (string) DbUpdateMarkerService.nSlGLmWZDK6dqOHpaHsR(-606654180 ^ -606695972), new Dictionary<string, object>()
            {
              {
                (string) DbUpdateMarkerService.nSlGLmWZDK6dqOHpaHsR(-345420348 ^ -345442710),
                (object) moduleUid
              },
              {
                (string) DbUpdateMarkerService.nSlGLmWZDK6dqOHpaHsR(654297945 ^ 654209181),
                (object) markerName
              }
            });
            num = 3;
            continue;
          case 7:
            this.Transform.Update(z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870803289), new string[1]
            {
              (string) DbUpdateMarkerService.nSlGLmWZDK6dqOHpaHsR(-1255365154 ^ 596875508 ^ -1765899892)
            }, new object[1]{ (object) value }, (string) DbUpdateMarkerService.nSlGLmWZDK6dqOHpaHsR(-675505729 ^ -675469953), new Dictionary<string, object>()
            {
              {
                (string) DbUpdateMarkerService.nSlGLmWZDK6dqOHpaHsR(-477139494 ^ -477178252),
                (object) moduleUid
              },
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979406458),
                (object) markerName
              }
            });
            num = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_5:
      return;
label_2:;
    }

    public DbUpdateMarkerService()
    {
      DbUpdateMarkerService.mTbt6pWZHjwTcmOYf39V();
      this.cache = new ConcurrentDictionary<KeyValuePair<Guid, string>, string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool NR7CbLWZpQMlbDWI92F1() => DbUpdateMarkerService.PFrkKoWZ3HyFBZme17SH == null;

    internal static DbUpdateMarkerService USqaauWZaPRBESgj8lKS() => DbUpdateMarkerService.PFrkKoWZ3HyFBZme17SH;

    internal static object nSlGLmWZDK6dqOHpaHsR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Lr8pS9WZtlnZigjFhICh([In] object obj0) => ((IDataReader) obj0).Read();

    internal static object dNVlvMWZwOdib8jNsM9e([In] object obj0, [In] int obj1) => ((IDataRecord) obj0)[obj1];

    internal static void UKmRGGWZ4yuNZPdZ7Zuu([In] object obj0, [In] object obj1) => Contract.ServiceNotNull(obj0, (string) obj1);

    internal static int VvfNbNWZ6xOKwUvk9Zxk([In] object obj0) => Convert.ToInt32(obj0);

    internal static void mTbt6pWZHjwTcmOYf39V() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Структура таблицы в БД</summary>
    internal static class Structure
    {
      /// <summary>Имя таблицы в БД, в которой хранятся метки</summary>
      public const string TableName = "DB_MARKER";

      /// <summary>Поля</summary>
      public static class Fields
      {
        /// <summary>Уникальный идентификатор модуля</summary>
        public const string ModuleUid = "ModuleUid";
        /// <summary>Имя метки</summary>
        public const string MarkerName = "MarkerName";
        /// <summary>Значение метки</summary>
        public const string MarkerValue = "MarkerValue";
        /// <summary>Дата создания</summary>
        public const string CreationDate = "CreationDate";
        /// <summary>Дата изменения</summary>
        public const string ChangeDate = "ChangeDate";
      }
    }
  }
}

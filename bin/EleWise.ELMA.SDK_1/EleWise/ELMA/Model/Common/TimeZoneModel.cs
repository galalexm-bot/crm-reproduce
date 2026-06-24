// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.TimeZoneModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>Часовой пояс</summary>
  public sealed class TimeZoneModel
  {
    internal static TimeZoneModel jfEcy3hqyZsvoIJ4yimr;

    /// <summary>
    /// НЕ УНИКАЛЕН!
    /// Идентификатор часового пояса Windows
    /// </summary>
    public string TimeZoneId
    {
      get => this.\u003CTimeZoneId\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CTimeZoneId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

    /// <summary>Имя в ключевой локали</summary>
    /// <remarks>
    /// ToString() отображает полное имя часвого пояса в локали пользователя
    /// </remarks>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
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

    /// <summary>
    /// Смещение между временем в текущем часовом поясе и временем в формате UTC в минутах
    /// </summary>
    public int Offset
    {
      get => this.\u003COffset\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003COffset\u003Ek__BackingField = value;
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

    /// <summary>Летнее смещение</summary>
    public bool Dst
    {
      get => this.\u003CDst\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CDst\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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

    /// <summary>Настройки часового пояса</summary>
    [JsonIgnore]
    public TZSettings Settings => new TZSettings(TZSettings.TZType.Custom, this.Offset);

    /// <summary>Ctor</summary>
    /// <param name="timeZoneId">Идентификатор часового пояса Windows</param>
    /// <param name="name">Название часового пояса в ключевой локали</param>
    /// <param name="offset">Смещение в минутах относительно UTC</param>
    /// <param name="dst">Зимнее/летнее смещение</param>
    public TimeZoneModel(string timeZoneId, string name, int offset, bool dst)
    {
      TimeZoneModel.ucuuSThq9Hj8xlCR57uA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.Offset = offset;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          case 3:
            this.Name = name;
            num = 2;
            continue;
          case 4:
            this.TimeZoneId = timeZoneId;
            num = 3;
            continue;
          default:
            this.Dst = dst;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Получить локализованное полное имя часового пояса</summary>
    /// <returns></returns>
    public override string ToString() => (string) TimeZoneModel.BEh10Bhqr1vcTE04WEQB(TimeZoneModel.kv6PMLhqdHRs6jVJBgdU(~-306453669 ^ 306665976), (object) new object[4]
    {
      (object) (this.Offset / 60).ToString((string) TimeZoneModel.kv6PMLhqdHRs6jVJBgdU(-1380439818 << 3 ^ 1841431096)),
      (object) TimeZoneModel.ts6rRQhqlk4DAC8Q74O7(this.Offset % 60).ToString((string) TimeZoneModel.kv6PMLhqdHRs6jVJBgdU(1052221104 - 768835541 ^ 283597633)),
      (object) EleWise.ELMA.SR.T(this.Name),
      this.Dst ? (object) EleWise.ELMA.SR.T((string) TimeZoneModel.kv6PMLhqdHRs6jVJBgdU(372753449 ^ 372539787)) : (object) string.Empty
    });

    /// <summary>Конвертировать в JSON</summary>
    /// <returns></returns>
    public string ToJson() => JsonConvert.SerializeObject((object) this);

    private bool Equals(TimeZoneModel other)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!TimeZoneModel.mco4DZhq5y8r3v14N7Li((object) this.TimeZoneId, TimeZoneModel.byGoUnhqg9HmVtFYvraY((object) other)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            if (string.Equals(this.Name, (string) TimeZoneModel.n3JAJEhqj4PiKRpPErHr((object) other)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 2 : 4;
              continue;
            }
            goto label_5;
          case 3:
            goto label_4;
          case 4:
            if (this.Offset == other.Offset)
            {
              num = 3;
              continue;
            }
            goto label_5;
          default:
            goto label_5;
        }
      }
label_4:
      return this.Dst == TimeZoneModel.KVPR0ihqYuIZrd09v5Px((object) other);
label_5:
      return false;
    }

    public override bool Equals(object obj)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_5;
            case 3:
              if (obj != null)
              {
                if ((object) this == obj)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
                  continue;
                }
                if ((object) (obj as TimeZoneModel) != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                  continue;
                }
                goto label_12;
              }
              else
                goto label_4;
            default:
              goto label_11;
          }
        }
label_4:
        num1 = 2;
      }
label_5:
      return false;
label_8:
      return true;
label_11:
      return this.Equals((TimeZoneModel) obj);
label_12:
      return false;
    }

    public override int GetHashCode()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this.TimeZoneId != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      int num2 = 0;
      goto label_6;
label_5:
      num2 = this.TimeZoneId.GetHashCode();
label_6:
      return ((num2 * 397 ^ (this.Name == null ? 0 : this.Name.GetHashCode())) * 397 ^ this.Offset) * 397 ^ this.Dst.GetHashCode();
    }

    public static bool operator ==(TimeZoneModel left, TimeZoneModel right) => TimeZoneModel.CsI4cqhqLy2vJ6bH2LVm((object) left, (object) right);

    public static bool operator !=(TimeZoneModel left, TimeZoneModel right) => !object.Equals((object) left, (object) right);

    internal static bool d72pGRhqM0xtkeaAuOwI() => (object) TimeZoneModel.jfEcy3hqyZsvoIJ4yimr == null;

    internal static TimeZoneModel ktJ5XThqJFj5wPZcvyBa() => TimeZoneModel.jfEcy3hqyZsvoIJ4yimr;

    internal static void ucuuSThq9Hj8xlCR57uA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object kv6PMLhqdHRs6jVJBgdU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int ts6rRQhqlk4DAC8Q74O7([In] int obj0) => Math.Abs(obj0);

    internal static object BEh10Bhqr1vcTE04WEQB([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object byGoUnhqg9HmVtFYvraY([In] object obj0) => (object) ((TimeZoneModel) obj0).TimeZoneId;

    internal static bool mco4DZhq5y8r3v14N7Li([In] object obj0, [In] object obj1) => string.Equals((string) obj0, (string) obj1);

    internal static object n3JAJEhqj4PiKRpPErHr([In] object obj0) => (object) ((TimeZoneModel) obj0).Name;

    internal static bool KVPR0ihqYuIZrd09v5Px([In] object obj0) => ((TimeZoneModel) obj0).Dst;

    internal static bool CsI4cqhqLy2vJ6bH2LVm([In] object obj0, [In] object obj1) => object.Equals(obj0, obj1);
  }
}

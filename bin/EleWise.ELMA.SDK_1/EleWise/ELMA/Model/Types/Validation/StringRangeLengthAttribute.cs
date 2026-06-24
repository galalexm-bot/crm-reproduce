// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.StringRangeLengthAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Validation
{
  /// <summary>Валидация длинны строки</summary>
  public class StringRangeLengthAttribute : ValidationAttribute
  {
    internal static StringRangeLengthAttribute hmeJlio5Xu76t2AoMuuN;

    public int MinValue
    {
      get => this.\u003CMinValue\u003Ek__BackingField;
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
              this.\u003CMinValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
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

    public string MaxValue
    {
      get => this.\u003CMaxValue\u003Ek__BackingField;
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
              this.\u003CMaxValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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

    public StringRangeLengthAttribute(int minValue, string maxValue)
    {
      StringRangeLengthAttribute.AqMnh2o5nLKKKvvHCPsK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
          case 4:
            StringRangeLengthAttribute.svxdVgo5PllMI02j0ta6((object) this, !string.IsNullOrEmpty(this.MaxValue) ? StringRangeLengthAttribute.t323lao5efDCF8GOXEAD(StringRangeLengthAttribute.fbMdAVo52tUAapbrEYeU(StringRangeLengthAttribute.HiL2Uko5O3MhBLVniTDm(1033719030 - 2012070891 ^ -978342383)), (object) this.MinValue, (object) this.MaxValue) : (object) string.Format((string) StringRangeLengthAttribute.fbMdAVo52tUAapbrEYeU(StringRangeLengthAttribute.HiL2Uko5O3MhBLVniTDm(-1852837372 ^ -1852844590)), (object) this.MinValue));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 2:
            this.MinValue = minValue;
            num = 3;
            continue;
          case 3:
            if (string.IsNullOrEmpty(maxValue))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
              continue;
            }
            goto case 5;
          case 5:
            if (int.TryParse(maxValue, out int _))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 6 : 5;
              continue;
            }
            goto case 1;
          case 6:
            this.MaxValue = maxValue;
            num = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_3:
      return;
label_2:;
    }

    public StringRangeLengthAttribute(int minValue, string maxValue, string message)
    {
      StringRangeLengthAttribute.AqMnh2o5nLKKKvvHCPsK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 1;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 1:
            this.MinValue = minValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 2 : 3;
            continue;
          case 2:
            if (int.TryParse(maxValue, out int _))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 7;
              continue;
            }
            goto case 5;
          case 3:
            if (!StringRangeLengthAttribute.HrKHuJo51IYlhBOMrfJJ((object) maxValue))
            {
              num = 2;
              continue;
            }
            goto case 5;
          case 4:
          case 8:
            StringRangeLengthAttribute.svxdVgo5PllMI02j0ta6((object) this, (object) message);
            num = 9;
            continue;
          case 5:
            if (!StringRangeLengthAttribute.HrKHuJo51IYlhBOMrfJJ((object) message))
            {
              num = 4;
              continue;
            }
            goto case 6;
          case 6:
            if (StringRangeLengthAttribute.HrKHuJo51IYlhBOMrfJJ((object) this.MaxValue))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
              continue;
            }
            obj = StringRangeLengthAttribute.t323lao5efDCF8GOXEAD(StringRangeLengthAttribute.fbMdAVo52tUAapbrEYeU(StringRangeLengthAttribute.HiL2Uko5O3MhBLVniTDm(-680446928 - -370807692 ^ -309632858)), (object) this.MinValue, (object) this.MaxValue);
            break;
          case 7:
            this.MaxValue = maxValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 2 : 5;
            continue;
          case 9:
            goto label_8;
          default:
            obj = StringRangeLengthAttribute.MyxaSdo5NFd0cyhLR3KG(StringRangeLengthAttribute.fbMdAVo52tUAapbrEYeU(StringRangeLengthAttribute.HiL2Uko5O3MhBLVniTDm(-1876063057 ^ -1876055175)), (object) this.MinValue);
            break;
        }
        message = (string) obj;
        num = 8;
      }
label_8:;
    }

    public override bool IsValid(object value)
    {
      int num = 4;
      bool flag;
      string str;
      int result;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!flag)
            {
              num = 7;
              continue;
            }
            goto label_6;
          case 2:
            goto label_12;
          case 3:
            str = (string) value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
            continue;
          case 4:
            if (value != null)
            {
              num = 3;
              continue;
            }
            goto label_12;
          case 5:
            goto label_6;
          case 6:
            if (StringRangeLengthAttribute.zGk6vdo53YMIHn7fQplX((object) str) >= this.MinValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
            }
            goto label_8;
          case 7:
            goto label_7;
          default:
            flag = int.TryParse(this.MaxValue, out result);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 6 : 5;
            continue;
        }
      }
label_6:
      return StringRangeLengthAttribute.zGk6vdo53YMIHn7fQplX((object) str) <= result;
label_7:
      return true;
label_8:
      return false;
label_12:
      return true;
    }

    internal static bool zqDaA1o5TdgkRbuwhxBX() => StringRangeLengthAttribute.hmeJlio5Xu76t2AoMuuN == null;

    internal static StringRangeLengthAttribute YwY4gyo5kcC1woYoDnBT() => StringRangeLengthAttribute.hmeJlio5Xu76t2AoMuuN;

    internal static void AqMnh2o5nLKKKvvHCPsK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object HiL2Uko5O3MhBLVniTDm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object fbMdAVo52tUAapbrEYeU([In] object obj0) => (object) SR.T((string) obj0);

    internal static object t323lao5efDCF8GOXEAD([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void svxdVgo5PllMI02j0ta6([In] object obj0, [In] object obj1) => ((ValidationAttribute) obj0).ErrorMessage = (string) obj1;

    internal static bool HrKHuJo51IYlhBOMrfJJ([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object MyxaSdo5NFd0cyhLR3KG([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static int zGk6vdo53YMIHn7fQplX([In] object obj0) => ((string) obj0).Length;
  }
}

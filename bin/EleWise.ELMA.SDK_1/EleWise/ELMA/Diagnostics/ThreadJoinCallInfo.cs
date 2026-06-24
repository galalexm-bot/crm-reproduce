// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.ThreadJoinCallInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информаия о задаче ожидания завершения потока</summary>
  [Serializable]
  internal sealed class ThreadJoinCallInfo : AbstractCallInfo, IEmptyCallInfo
  {
    private long managedThreadId;
    private string managedThreadName;
    private bool managedThreadIsBackground;
    private static ThreadJoinCallInfo HG18ubGzrR43tbNnMN4t;

    /// <summary>Ctor</summary>
    public ThreadJoinCallInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ThreadJoinCallInfo(Thread thread)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num1 = 0;
      switch (num1)
      {
        case 1:
          break;
        default:
          try
          {
            this.managedThreadId = (long) ThreadJoinCallInfo.OUHXp5Gzjc3nkGIlWkyr((object) thread);
            int num2 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
              num2 = 0;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  goto label_14;
                case 2:
                  this.managedThreadIsBackground = thread.IsBackground;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
                  continue;
                default:
                  this.managedThreadName = (string) ThreadJoinCallInfo.NAnl9fGzYHmmtcDjvqaS((object) thread);
                  num2 = 2;
                  continue;
              }
            }
label_14:
            break;
          }
          catch (ThreadStateException ex)
          {
            int num3 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
              num3 = 0;
            while (true)
            {
              switch (num3)
              {
                case 0:
                  goto label_10;
                case 1:
                  ((ILogger) ThreadJoinCallInfo.LmYunUGzLfwbReWAshL2()).Error(ThreadJoinCallInfo.Wr3FRSGzsLpbbHbqojHa(ThreadJoinCallInfo.c7c7RaGzUtCNqwWYim8F(1505778440 - 1981636111 ^ -475604555)), (Exception) ex);
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_7;
              }
            }
label_10:
            break;
label_7:
            break;
          }
      }
    }

    /// <inheritdoc />
    public override string CallType => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710320266);

    /// <inheritdoc />
    public override string Description => (string) ThreadJoinCallInfo.QBT8poGzc0Bqovus2tym((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281589404), (object) this.managedThreadId, (object) this.managedThreadName, (object) this.managedThreadIsBackground);

    /// <inheritdoc />
    public bool IsEmpty
    {
      get => this.\u003CIsEmpty\u003Ek__BackingField;
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
              this.\u003CIsEmpty\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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

    protected override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
    }

    internal static bool mQSdrJGzgOuKAAxnifPD() => ThreadJoinCallInfo.HG18ubGzrR43tbNnMN4t == null;

    internal static ThreadJoinCallInfo aZR8a5Gz5HbYwtZOl7Ai() => ThreadJoinCallInfo.HG18ubGzrR43tbNnMN4t;

    internal static int OUHXp5Gzjc3nkGIlWkyr([In] object obj0) => ((Thread) obj0).ManagedThreadId;

    internal static object NAnl9fGzYHmmtcDjvqaS([In] object obj0) => (object) ((Thread) obj0).Name;

    internal static object LmYunUGzLfwbReWAshL2() => (object) Logger.Log;

    internal static object c7c7RaGzUtCNqwWYim8F(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Wr3FRSGzsLpbbHbqojHa([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object QBT8poGzc0Bqovus2tym(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }
  }
}

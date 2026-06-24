// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.Event
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Внутренний клас, для безопасной обработки статических событий
  /// </summary>
  internal class Event
  {
    internal static Event HDajEdG7GFiQgOneJLTN;

    /// <summary>Текущий делегат</summary>
    public Delegate EventDelegate
    {
      get => this.\u003CEventDelegate\u003Ek__BackingField;
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
              this.\u003CEventDelegate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
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

    /// <summary>Конструктор</summary>
    /// <param name="evt">Делегат для вызова</param>
    public Event(Delegate evt)
    {
      Event.etNOPeG7Qyn2ZB1QmjKE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.EventDelegate = evt;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Обработать текущий делегат</summary>
    public void Raise(object sender, object eventArgObject)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Raise(new object[2]
            {
              sender,
              eventArgObject
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Обработать текущий делегат</summary>
    public void Raise(object[] args)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        Delegate @delegate;
        bool flag;
        int index;
        Delegate[] delegateArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_25;
            case 3:
            case 5:
              @delegate = delegateArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 7;
              continue;
            case 4:
              try
              {
                ISynchronizeInvoke target = @delegate.Target as ISynchronizeInvoke;
                int num3 = 5;
                while (true)
                {
                  switch (num3)
                  {
                    case 2:
                      Event.ynIp33G78mc1efZ3WJeA((object) target, (object) @delegate, (object) args);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
                      continue;
                    case 3:
                      if (Event.oSCQruG7vpsoiBwF4wVO((object) target))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 6 : 5;
                        continue;
                      }
                      goto case 4;
                    case 4:
                      flag = true;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 2 : 7;
                      continue;
                    case 5:
                      if (target != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 3 : 1;
                        continue;
                      }
                      goto case 4;
                    case 6:
                      flag = true;
                      num3 = 2;
                      continue;
                    case 7:
                      Event.xgcCpTG7ZFE3Y9J0DSZw((object) @delegate, (object) args);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_19;
                  }
                }
              }
              catch
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      Event.xgcCpTG7ZFE3Y9J0DSZw((object) @delegate, (object) args);
                      num4 = 2;
                      continue;
                    case 2:
                      goto label_19;
                    default:
                      if (!flag)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
                        continue;
                      }
                      goto label_19;
                  }
                }
              }
            case 6:
label_19:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 10 : 5;
              continue;
            case 7:
              goto label_22;
            case 8:
              goto label_30;
            case 9:
              if ((object) this.EventDelegate != null)
              {
                delegateArray = (Delegate[]) Event.CmvLJfG7CSvybQxpDWZy((object) this.EventDelegate);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
                continue;
              }
              num2 = 8;
              continue;
            default:
              if (index < delegateArray.Length)
              {
                num2 = 5;
                continue;
              }
              goto label_29;
          }
        }
label_22:
        flag = false;
        num1 = 4;
      }
label_25:
      return;
label_30:
      return;
label_29:;
    }

    internal static bool tUtjHwG7EeLItd6ohahm() => Event.HDajEdG7GFiQgOneJLTN == null;

    internal static Event D8bgHkG7f0s14UgrJotG() => Event.HDajEdG7GFiQgOneJLTN;

    internal static void etNOPeG7Qyn2ZB1QmjKE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object CmvLJfG7CSvybQxpDWZy([In] object obj0) => (object) ((Delegate) obj0).GetInvocationList();

    internal static bool oSCQruG7vpsoiBwF4wVO([In] object obj0) => ((ISynchronizeInvoke) obj0).InvokeRequired;

    internal static object ynIp33G78mc1efZ3WJeA([In] object obj0, [In] object obj1, [In] object obj2) => ((ISynchronizeInvoke) obj0).Invoke((Delegate) obj1, (object[]) obj2);

    internal static object xgcCpTG7ZFE3Y9J0DSZw([In] object obj0, [In] object obj1) => ((Delegate) obj0).DynamicInvoke((object[]) obj1);
  }
}

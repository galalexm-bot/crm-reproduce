// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.LazyHashedSet`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EleWise.ELMA.Collections
{
  public class LazyHashedSet<T> : HashedSet<T>
  {
    protected Func<ICollection<object>> CalcFunc;
    private bool initialized;
    private object lockObj;
    private static object mLSZVfm2wlbLyyx5vUE;

    public LazyHashedSet(Func<ICollection<object>> calcFunc)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.lockObj = new object();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.CalcFunc = calcFunc;
    }

    protected void InitCollection()
    {
      int num1 = 1;
      object lockObj;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_20;
          case 1:
            if (this.initialized)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            goto label_2;
          case 3:
            goto label_6;
          case 4:
            lockObj = this.lockObj;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 5 : 4;
            continue;
          case 5:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 2;
            continue;
          default:
            goto label_5;
        }
      }
label_20:
      return;
label_6:
      return;
label_5:
      return;
label_2:
      try
      {
        Monitor.Enter(lockObj, ref lockTaken);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
          num2 = 0;
        List<T> list;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.AddAll((ICollection) list);
              num2 = 5;
              continue;
            case 2:
              goto label_17;
            case 3:
              list = this.CalcFunc().Cast<T>().ToList<T>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
              continue;
            case 4:
              this.initialized = true;
              num2 = 3;
              continue;
            case 5:
              goto label_12;
            default:
              if (this.initialized)
              {
                num2 = 2;
                continue;
              }
              goto case 4;
          }
        }
label_17:
        return;
label_12:;
      }
      finally
      {
        if (lockTaken)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                Monitor.Exit(lockObj);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
    }

    public override IEnumerator<T> GetEnumerator()
    {
      this.InitCollection();
      return base.GetEnumerator();
    }

    public override bool Equals(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.InitCollection();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return base.Equals(obj);
    }

    public override bool ContainsAll(ICollection c)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.InitCollection();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return base.ContainsAll(c);
    }

    public override bool IsEmpty
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.InitCollection();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return base.IsEmpty;
      }
    }

    public override bool RemoveAll(ICollection c)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.InitCollection();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return base.RemoveAll(c);
    }

    internal static bool X7cWIsmenfk0ZWDOuZK() => LazyHashedSet<T>.mLSZVfm2wlbLyyx5vUE == null;

    internal static object hECT1smPD2dgHbO6vLO() => LazyHashedSet<T>.mLSZVfm2wlbLyyx5vUE;
  }
}

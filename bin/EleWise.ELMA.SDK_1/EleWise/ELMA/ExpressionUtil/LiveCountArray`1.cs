// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExpressionUtil.LiveCountArray`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ExpressionUtil
{
  internal struct LiveCountArray<T>
  {
    public int Count;
    public T[] Items;

    public LiveCountArray(T[] items)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Count = items.Length;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          case 2:
            this.Items = items;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public ref T PushSlot()
    {
      int num1 = 3;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_6;
          case 2:
            if (num2 > this.Items.Length)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 3:
            num2 = ++this.Count;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 2;
            continue;
          default:
            this.Items = LiveCountArray<T>.Expand(this.Items);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 0;
            continue;
        }
      }
label_6:
      return ref this.Items[this.Count - 1];
    }

    public void PushSlot(T item)
    {
      if (++this.Count > this.Items.Length)
        this.Items = LiveCountArray<T>.Expand(this.Items);
      this.Items[this.Count - 1] = item;
    }

    public void Pop()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            --this.Count;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static T[] Expand(T[] items)
    {
      int num = 3;
      T[] destinationArray;
      int length;
      while (true)
      {
        switch (num)
        {
          case 1:
            Array.Copy((Array) items, 0, (Array) destinationArray, 0, length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 4 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            if (items.Length == 0)
            {
              num = 2;
              continue;
            }
            length = items.Length;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_4;
          default:
            destinationArray = new T[length << 1];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 1;
            continue;
        }
      }
label_4:
      return destinationArray;
label_7:
      return new T[4];
    }

    internal static bool F8tdaMGrpWgimBlZEV8B() => true;

    internal static object E9eOgEGraX4Ekj2IoPei() => (object) null;
  }
}

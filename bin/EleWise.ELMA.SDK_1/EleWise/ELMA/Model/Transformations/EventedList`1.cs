// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.EventedList`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Transformations
{
  [DebuggerDisplay("Count = {Count}")]
  [DebuggerTypeProxy(typeof (CollectionDebugView<>))]
  [DataContract]
  [Serializable]
  public abstract class EventedList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : class
  {
    public EventHandler<EventedListEventArgs<T>> AddingItem;
    public EventHandler<EventedListEventArgs<T>> AddedItem;
    public EventHandler<EventedListEventArgs<T>> RemovingItem;
    public EventHandler<EventedListEventArgs<T>> RemovedItem;
    public EventHandler ClearingItems;
    public EventHandler ClearedItems;
    private readonly T parent;
    internal readonly List<T> items;
    private static object rTf4tyWLUCc7FRuiGdO7;

    protected abstract Exception ListAddingException(T parent, T item);

    protected abstract T GetParent(T item);

    protected abstract void SetParent(T item, T parent);

    protected abstract void RemoveFromParent(T item);

    protected EventedList(T parent)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.items = new List<T>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.parent = parent;
    }

    private bool IsParent(T parent, T item)
    {
      if ((object) item == (object) parent)
        return true;
      T parent1;
      return (object) (parent1 = this.GetParent(item)) != null && this.IsParent(parent, parent1);
    }

    public IEnumerator<T> GetEnumerator() => (IEnumerator<T>) this.items.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    public void Add(T item)
    {
      if (this.IsParent(item, this.parent))
        throw this.ListAddingException(this.parent, item);
      if (this.AddingItem != null)
        this.AddingItem((object) this, new EventedListEventArgs<T>()
        {
          Item = item
        });
      this.RemoveFromParent(item);
      this.items.Add(item);
      this.SetParent(item, this.parent);
      if (this.AddedItem == null)
        return;
      this.AddedItem((object) this, new EventedListEventArgs<T>()
      {
        Item = item
      });
    }

    public void Clear()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_12;
          case 1:
          case 5:
            this.items.ForEach((Action<T>) (i => this.SetParent(i, default (T))));
            num = 3;
            continue;
          case 2:
            if (this.ClearingItems == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 1;
              continue;
            }
            goto case 6;
          case 3:
            this.items.Clear();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 7 : 7;
            continue;
          case 4:
            this.ClearedItems((object) this, new EventArgs());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 6:
            this.ClearingItems((object) this, new EventArgs());
            num = 5;
            continue;
          case 7:
            if (this.ClearedItems == null)
            {
              num = 8;
              continue;
            }
            goto case 4;
          case 8:
            goto label_10;
          default:
            goto label_2;
        }
      }
label_12:
      return;
label_10:
      return;
label_2:;
    }

    public bool Contains(T item) => this.items.Contains(item);

    public void CopyTo(T[] array, int arrayIndex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.items.CopyTo(array, arrayIndex);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public bool Remove(T item)
    {
      if (this.RemovingItem != null)
        this.RemovingItem((object) this, new EventedListEventArgs<T>()
        {
          Item = item
        });
      int num = this.items.Remove(item) ? 1 : 0;
      if (num != 0)
        this.SetParent(item, default (T));
      if (this.RemovedItem == null)
        return num != 0;
      this.RemovedItem((object) this, new EventedListEventArgs<T>()
      {
        Item = item
      });
      return num != 0;
    }

    public int Count => this.items.Count;

    public bool IsReadOnly => false;

    public int IndexOf(T item) => this.items.IndexOf(item);

    public void Insert(int index, T item)
    {
      if (this.IsParent(item, this.parent))
        throw this.ListAddingException(this.parent, item);
      if ((object) this.GetParent(item) == (object) this.parent)
      {
        int num = this.items.IndexOf(item);
        if (num == index)
          return;
        if (num < index)
          --index;
      }
      if (this.AddingItem != null)
        this.AddingItem((object) this, new EventedListEventArgs<T>()
        {
          Item = item
        });
      this.RemoveFromParent(item);
      this.items.Insert(index, item);
      this.SetParent(item, this.parent);
      if (this.AddedItem == null)
        return;
      this.AddedItem((object) this, new EventedListEventArgs<T>()
      {
        Item = item
      });
    }

    public void RemoveAt(int index)
    {
      int num = 7;
      T obj;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.SetParent(obj, default (T));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.RemovingItem((object) this, new EventedListEventArgs<T>()
            {
              Item = obj
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
            continue;
          case 4:
            this.RemovedItem((object) this, new EventedListEventArgs<T>()
            {
              Item = obj
            });
            num = 2;
            continue;
          case 5:
            if (this.RemovedItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 4 : 3;
              continue;
            }
            goto label_12;
          case 6:
            if (this.RemovingItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 3 : 3;
              continue;
            }
            goto case 1;
          case 7:
            obj = this.items[index];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 6;
            continue;
          default:
            this.items.RemoveAt(index);
            num = 5;
            continue;
        }
      }
label_2:
      return;
label_12:;
    }

    public T this[int index]
    {
      get => this.items[index];
      set
      {
        if ((object) this.items[index] == (object) value)
          return;
        T obj = this.items[index];
        if (this.RemovingItem != null)
          this.RemovingItem((object) this, new EventedListEventArgs<T>()
          {
            Item = obj
          });
        if (this.AddingItem != null)
          this.AddingItem((object) this, new EventedListEventArgs<T>()
          {
            Item = value
          });
        this.SetParent(obj, default (T));
        this.items[index] = value;
        this.SetParent(value, this.parent);
        if (this.RemovedItem != null)
          this.RemovedItem((object) this, new EventedListEventArgs<T>()
          {
            Item = obj
          });
        if (this.AddedItem == null)
          return;
        this.AddedItem((object) this, new EventedListEventArgs<T>()
        {
          Item = value
        });
      }
    }

    internal static bool PfLwvKWLsfaGqqeDqQ2f() => EventedList<T>.rTf4tyWLUCc7FRuiGdO7 == null;

    internal static object LQbEqfWLcN11DlCrS3SS() => EventedList<T>.rTf4tyWLUCc7FRuiGdO7;
  }
}

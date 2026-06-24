// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbar.RootToolbarItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views.Toolbar
{
  /// <summary>Корневой элемент toolbar-а</summary>
  [Serializable]
  public class RootToolbarItem : ToolbarItem
  {
    private ToolbarItemList items;
    /// <summary>Используется только для события items.ClearedItems</summary>
    private IEnumerable<ToolbarItem> oldItems;
    private static RootToolbarItem dl1MMNot4SKiEoVh8TrE;

    /// <summary>Элементы представления</summary>
    [XmlArrayItem("RootViewItem", typeof (RootToolbarItem))]
    [NotNull]
    [XmlArrayItem("ViewItem")]
    public ToolbarItemList Items => this.items;

    protected RootToolbarItem()
    {
      RootToolbarItem.r263lwotAKkJ5gQ4OkSy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            ToolbarItemList toolbarItemList = new ToolbarItemList((ToolbarItem) this);
            toolbarItemList.ClearingItems = new EventHandler(this.ClearingItems);
            toolbarItemList.ClearedItems = new EventHandler(this.ClearedItems);
            toolbarItemList.AddingItem = new EventHandler<EventedListEventArgs<ToolbarItem>>(this.AddingItem);
            toolbarItemList.AddedItem = new EventHandler<EventedListEventArgs<ToolbarItem>>(this.AddedItem);
            toolbarItemList.RemovingItem = new EventHandler<EventedListEventArgs<ToolbarItem>>(this.RemovingItem);
            toolbarItemList.RemovedItem = new EventHandler<EventedListEventArgs<ToolbarItem>>(this.RemovedItem);
            this.items = toolbarItemList;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    ~RootToolbarItem()
    {
      switch (1)
      {
        case 1:
          try
          {
            ToolbarItemList items1 = this.items;
            // ISSUE: reference to a compiler-generated field
            EventHandler eventHandler1 = RootToolbarItem.\u003C\u003Ec.\u003C\u003E9__4_0;
            EventHandler eventHandler2;
            if (eventHandler1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              RootToolbarItem.\u003C\u003Ec.\u003C\u003E9__4_0 = eventHandler2 = (EventHandler) ((_param1, _param2) => { });
            }
            else
              goto label_24;
label_4:
            items1.ClearingItems = eventHandler2;
            int num = 3;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
              num = 2;
            while (true)
            {
              switch (num)
              {
                case 1:
                  this.items.RemovingItem = (EventHandler<EventedListEventArgs<ToolbarItem>>) ((_param1, _param2) => { });
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 2;
                  continue;
                case 2:
                  ToolbarItemList items2 = this.items;
                  // ISSUE: reference to a compiler-generated field
                  EventHandler<EventedListEventArgs<ToolbarItem>> eventHandler3 = RootToolbarItem.\u003C\u003Ec.\u003C\u003E9__4_5;
                  EventHandler<EventedListEventArgs<ToolbarItem>> eventHandler4;
                  if (eventHandler3 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    RootToolbarItem.\u003C\u003Ec.\u003C\u003E9__4_5 = eventHandler4 = (EventHandler<EventedListEventArgs<ToolbarItem>>) ((_param1, _param2) => { });
                  }
                  else
                    goto label_23;
label_16:
                  items2.RemovedItem = eventHandler4;
                  num = 4;
                  continue;
label_23:
                  eventHandler4 = eventHandler3;
                  goto label_16;
                case 3:
                  this.items.ClearedItems = (EventHandler) ((_param1, _param2) => { });
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                  continue;
                case 4:
                  goto label_14;
                case 5:
                  this.items.AddedItem = (EventHandler<EventedListEventArgs<ToolbarItem>>) ((_param1, _param2) => { });
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
                  continue;
                default:
                  ToolbarItemList items3 = this.items;
                  // ISSUE: reference to a compiler-generated field
                  EventHandler<EventedListEventArgs<ToolbarItem>> eventHandler5 = RootToolbarItem.\u003C\u003Ec.\u003C\u003E9__4_2;
                  EventHandler<EventedListEventArgs<ToolbarItem>> eventHandler6;
                  if (eventHandler5 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    RootToolbarItem.\u003C\u003Ec.\u003C\u003E9__4_2 = eventHandler6 = (EventHandler<EventedListEventArgs<ToolbarItem>>) ((_param1, _param2) => { });
                  }
                  else
                    goto label_2;
label_10:
                  items3.AddingItem = eventHandler6;
                  num = 5;
                  continue;
label_2:
                  eventHandler6 = eventHandler5;
                  goto label_10;
              }
            }
label_14:
            break;
label_24:
            eventHandler2 = eventHandler1;
            goto label_4;
          }
          finally
          {
            RootToolbarItem.JHX4Jbot7SKTjIEi3QUn((object) this);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
              num = 0;
            switch (num)
            {
              default:
            }
          }
      }
    }

    private void ClearingItems(object sender, EventArgs eventArgs)
    {
      int num1 = 3;
      IEnumerator<ToolbarItem> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
label_2:
            this.oldItems = (IEnumerable<ToolbarItem>) this.items.ToArray<ToolbarItem>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 2:
            try
            {
label_7:
              if (enumerator.MoveNext())
                goto label_5;
              else
                goto label_8;
label_4:
              int num2;
              switch (num2)
              {
                case 1:
                  goto label_2;
                case 2:
                  goto label_7;
              }
label_5:
              RootToolbarItem.uRkeQBotx1CKR9vvnxeJ((object) enumerator.Current, (object) this);
              num2 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
              {
                num2 = 2;
                goto label_4;
              }
              else
                goto label_4;
label_8:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
              goto label_4;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 2;
              else
                goto label_14;
label_11:
              switch (num3)
              {
                case 1:
                  break;
                default:
              }
label_14:
              RootToolbarItem.spOtaNot0ivGWmOhYhfY((object) enumerator);
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
              {
                num3 = 0;
                goto label_11;
              }
              else
                goto label_11;
            }
          case 3:
            enumerator = this.Items.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 2;
            continue;
          default:
            goto label_12;
        }
      }
label_13:
      return;
label_12:;
    }

    private void ClearedItems(object sender, EventArgs eventArgs)
    {
      int num1 = 1;
      IEnumerator<ToolbarItem> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.oldItems.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_13:
      return;
label_2:
      try
      {
label_6:
        if (enumerator.MoveNext())
          goto label_5;
        else
          goto label_7;
label_4:
        int num2;
        switch (num2)
        {
          case 0:
            return;
          case 1:
            break;
          case 2:
            goto label_6;
          default:
            return;
        }
label_5:
        RootToolbarItem.dTgjlZotmWryBfwDUQ33((object) enumerator.Current, (object) this);
        num2 = 2;
        goto label_4;
label_7:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
        goto label_4;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = 2;
        else
          goto label_14;
label_11:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_14:
        enumerator.Dispose();
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        {
          num3 = 0;
          goto label_11;
        }
        else
          goto label_11;
      }
    }

    private void AddingItem(
      object sender,
      EventedListEventArgs<ToolbarItem> listViewItemEventArgs)
    {
      listViewItemEventArgs.Item.OnAdding(this);
    }

    private void AddedItem(
      object sender,
      EventedListEventArgs<ToolbarItem> listViewItemEventArgs)
    {
      listViewItemEventArgs.Item.OnAdded(this);
    }

    private void RemovingItem(
      object sender,
      EventedListEventArgs<ToolbarItem> listViewItemEventArgs)
    {
      listViewItemEventArgs.Item.OnRemoving(this);
    }

    private void RemovedItem(
      object sender,
      EventedListEventArgs<ToolbarItem> listViewItemEventArgs)
    {
      listViewItemEventArgs.Item.OnRemoved(this);
    }

    public override void OnAdding(RootToolbarItem parent)
    {
      int num1 = 1;
      IEnumerator<ToolbarItem> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            base.OnAdding(parent);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_15;
          case 3:
            goto label_4;
          default:
            enumerator = this.Items.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 2 : 3;
            continue;
        }
      }
label_15:
      return;
label_4:
      try
      {
label_8:
        if (enumerator.MoveNext())
          goto label_6;
        else
          goto label_9;
label_5:
        int num2;
        switch (num2)
        {
          case 1:
            break;
          case 2:
            return;
          default:
            goto label_8;
        }
label_6:
        RootToolbarItem.DUlPOfotyMeeHnmpqa0a((object) enumerator.Current, (object) parent);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
        {
          num2 = 0;
          goto label_5;
        }
        else
          goto label_5;
label_9:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 2;
        goto label_5;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                RootToolbarItem.spOtaNot0ivGWmOhYhfY((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
    }

    public override void OnAdded(RootToolbarItem parent)
    {
      int num1 = 2;
      IEnumerator<ToolbarItem> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
            enumerator = this.Items.GetEnumerator();
            num1 = 3;
            continue;
          case 2:
            base.OnAdded(parent);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_12;
        }
      }
label_13:
      return;
label_12:
      return;
label_2:
      try
      {
label_6:
        if (enumerator.MoveNext())
          goto label_4;
        else
          goto label_7;
label_3:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            break;
          default:
            goto label_6;
        }
label_4:
        RootToolbarItem.BPwKAfotMbe5NJU2X3uQ((object) enumerator.Current, (object) parent);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        {
          num2 = 0;
          goto label_3;
        }
        else
          goto label_3;
label_7:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 1;
        goto label_3;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 2;
        else
          goto label_14;
label_11:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_14:
        enumerator.Dispose();
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        {
          num3 = 0;
          goto label_11;
        }
        else
          goto label_11;
      }
    }

    public override void OnRemoving(RootToolbarItem parent)
    {
      int num1 = 3;
      while (true)
      {
        IEnumerator<ToolbarItem> enumerator;
        switch (num1)
        {
          case 1:
            goto label_13;
          case 2:
            try
            {
label_7:
              if (enumerator.MoveNext())
                goto label_5;
              else
                goto label_8;
label_4:
              int num2;
              switch (num2)
              {
                case 1:
                  goto label_7;
                case 2:
                  break;
                default:
                  goto label_16;
              }
label_5:
              RootToolbarItem.uRkeQBotx1CKR9vvnxeJ((object) enumerator.Current, (object) parent);
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
              {
                num2 = 1;
                goto label_4;
              }
              else
                goto label_4;
label_8:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              goto label_4;
            }
            finally
            {
              if (enumerator != null)
              {
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                  num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      enumerator.Dispose();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_15;
                  }
                }
              }
label_15:;
            }
          case 3:
            enumerator = this.Items.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 2;
            continue;
        }
label_16:
        base.OnRemoving(parent);
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 1;
      }
label_13:;
    }

    public override void OnRemoved(RootToolbarItem parent)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        IEnumerator<ToolbarItem> enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              enumerator = this.Items.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_13;
            default:
              goto label_4;
          }
        }
label_3:
        base.OnRemoved(parent);
        num1 = 3;
        continue;
label_4:
        try
        {
label_8:
          if (RootToolbarItem.DTEJvQotJQvYQ9jSvRte((object) enumerator))
            goto label_7;
          else
            goto label_9;
label_6:
          int num3;
          switch (num3)
          {
            case 1:
              goto label_3;
            case 2:
              goto label_8;
          }
label_7:
          RootToolbarItem.dTgjlZotmWryBfwDUQ33((object) enumerator.Current, (object) parent);
          num3 = 2;
          goto label_6;
label_9:
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
          goto label_6;
        }
        finally
        {
          int num4;
          if (enumerator == null)
            num4 = 2;
          else
            goto label_14;
label_12:
          switch (num4)
          {
            case 1:
              break;
            default:
          }
label_14:
          RootToolbarItem.spOtaNot0ivGWmOhYhfY((object) enumerator);
          num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
          {
            num4 = 0;
            goto label_12;
          }
          else
            goto label_12;
        }
      }
label_13:;
    }

    public RootToolbarItem CreateCopy()
    {
      int num = 2;
      ToolbarItemList items;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.items = (ToolbarItemList) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 2:
            items = this.items;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      RootToolbarItem copy = ClassSerializationHelper.CloneObjectByXml<RootToolbarItem>(this);
      this.items = items;
      return copy;
    }

    /// <summary>Получить все вложенные элементы</summary>
    /// <param name="ignoreHide">Игнорировать скрытые</param>
    /// <returns>Вложенные элементы</returns>
    public IEnumerable<ToolbarItem> GetAllItems(bool ignoreHide = true) => RootToolbarItem.FindItems((object) this, ignoreHide, (Func<ToolbarItem, bool>) null, (Func<ToolbarItem, bool>) null);

    private static IEnumerable<ToolbarItem> FindItems(
      object toolbarItem,
      bool ignoreHide,
      Func<ToolbarItem, bool> itemCondition,
      Func<ToolbarItem, bool> deepCondition)
    {
      return !(toolbarItem is RootToolbarItem rootToolbarItem) ? (IEnumerable<ToolbarItem>) new ToolbarItem[0] : rootToolbarItem.Items.Where<ToolbarItem>((Func<ToolbarItem, bool>) (item =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (ignoreHide)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return RootToolbarItem.\u003C\u003Ec__DisplayClass18_0.W25WQeCZeVyV500JBtq6((object) item);
label_3:
        return true;
      })).SelectMany<ToolbarItem, ToolbarItem>((Func<ToolbarItem, IEnumerable<ToolbarItem>>) (item => Enumerable.Empty<ToolbarItem>().If<ToolbarItem>(itemCondition == null || itemCondition(item), (Func<IEnumerable<ToolbarItem>, IEnumerable<ToolbarItem>>) (enumerable => enumerable.Concat<ToolbarItem>((IEnumerable<ToolbarItem>) new ToolbarItem[1]
      {
        item
      }))).If<ToolbarItem>(deepCondition == null || deepCondition(item), (Func<IEnumerable<ToolbarItem>, IEnumerable<ToolbarItem>>) (enumerable => enumerable.Concat<ToolbarItem>(RootToolbarItem.FindItems((object) item, ignoreHide, itemCondition, deepCondition))))));
    }

    internal static void r263lwotAKkJ5gQ4OkSy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hY06kBot6a8oLP6kPLUl() => RootToolbarItem.dl1MMNot4SKiEoVh8TrE == null;

    internal static RootToolbarItem kZvdOkotHt352hop6jYW() => RootToolbarItem.dl1MMNot4SKiEoVh8TrE;

    internal static void JHX4Jbot7SKTjIEi3QUn([In] object obj0) => __nonvirtual (obj0.Finalize());

    internal static void uRkeQBotx1CKR9vvnxeJ([In] object obj0, [In] object obj1) => ((ToolbarItem) obj0).OnRemoving((RootToolbarItem) obj1);

    internal static void spOtaNot0ivGWmOhYhfY([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void dTgjlZotmWryBfwDUQ33([In] object obj0, [In] object obj1) => ((ToolbarItem) obj0).OnRemoved((RootToolbarItem) obj1);

    internal static void DUlPOfotyMeeHnmpqa0a([In] object obj0, [In] object obj1) => ((ToolbarItem) obj0).OnAdding((RootToolbarItem) obj1);

    internal static void BPwKAfotMbe5NJU2X3uQ([In] object obj0, [In] object obj1) => ((ToolbarItem) obj0).OnAdded((RootToolbarItem) obj1);

    internal static bool DTEJvQotJQvYQ9jSvRte([In] object obj0) => ((IEnumerator) obj0).MoveNext();
  }
}

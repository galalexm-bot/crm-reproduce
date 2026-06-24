// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.PostFlushEventForwarder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.Listeners
{
  [Component]
  internal class PostFlushEventForwarder : EntityEventsListener, IUnitOfWorkEventListener
  {
    private readonly IContextBoundVariableService contextBoundVariableService;
    private readonly IEnumerable<IPostFlushEventListener> listeners;
    private readonly ITransformationProvider transform;
    private static PostFlushEventForwarder oP1XF5WAUfnaPtCWXYq7;

    /// <summary>Ctor</summary>
    /// <param name="contextBoundVariableService">Интерфейс сервиса работы со значениями переменных в рамках контекста</param>
    /// <param name="listeners">Точки расширений для прослушивания событий NHibernate после их выполнения</param>
    /// <param name="transform">Интерфейс провайдера преобразования БД</param>
    public PostFlushEventForwarder(
      IContextBoundVariableService contextBoundVariableService,
      IEnumerable<IPostFlushEventListener> listeners,
      ITransformationProvider transform)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.contextBoundVariableService = contextBoundVariableService;
      this.listeners = listeners;
      this.transform = transform;
    }

    public void OnStartUnitofWork(IUnitOfWork unitOfWork)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PostFlushEventForwarder.uupHhmW7FrU6jfjhCWog((object) this.contextBoundVariableService, PostFlushEventForwarder.Ukf4DuWAz0G0GP7bpecS(-1978478350 ^ -1978599862), (object) new PostFlushEventForwarder.Holder());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
    {
    }

    public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
    {
      int num1 = 1;
      string str1;
      while (true)
      {
        int num2 = num1;
        PostFlushEventForwarder.Holder holder;
        HashSet<string> hashSet;
        IEnumerator<IPostFlushEventListener> enumerator1;
        ISession session;
        int num3;
        int num4;
        List<PostInsertEvent> list1;
        List<PostUpdateEvent> list2;
        Func<object, string> entityKey;
        HashSet<string> deleted;
        Func<object, bool> isDeleteEntity;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            case 2:
label_87:
              if (!session.IsDirty())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 16 : 17;
                continue;
              }
              goto case 8;
            case 3:
              num3 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 9 : 12;
              continue;
            case 4:
              enumerator1 = this.listeners.GetEnumerator();
              num2 = 5;
              continue;
            case 5:
              try
              {
label_16:
                if (PostFlushEventForwarder.wSpIIxW7GpTVmFKyClyr((object) enumerator1))
                  goto label_75;
                else
                  goto label_17;
label_15:
                IPostFlushEventListener current1;
                int num5;
                switch (num5)
                {
                  case 1:
                    goto label_87;
                  case 2:
                    goto label_16;
                  case 3:
                    try
                    {
                      List<PostInsertEvent>.Enumerator enumerator2 = list1.GetEnumerator();
                      int num6 = 5;
                      List<PostCollectionUpdateEvent>.Enumerator enumerator3;
                      while (true)
                      {
                        List<PostDeleteEvent>.Enumerator enumerator4;
                        List<PostUpdateEvent>.Enumerator enumerator5;
                        switch (num6)
                        {
                          case 1:
label_20:
                            enumerator4 = holder.deleteEvents.GetEnumerator();
                            num6 = 4;
                            continue;
                          case 2:
                            goto label_32;
                          case 3:
                            goto label_16;
                          case 4:
                            try
                            {
label_45:
                              if (enumerator4.MoveNext())
                                goto label_48;
                              else
                                goto label_46;
label_44:
                              PostDeleteEvent current2;
                              int num7;
                              while (true)
                              {
                                switch (num7)
                                {
                                  case 1:
                                    goto label_45;
                                  case 2:
                                    goto label_48;
                                  case 3:
                                    current1.OnPostDelete(current2);
                                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
                                    continue;
                                  default:
                                    goto label_54;
                                }
                              }
label_46:
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                              goto label_44;
label_48:
                              current2 = enumerator4.Current;
                              num7 = 3;
                              goto label_44;
                            }
                            finally
                            {
                              enumerator4.Dispose();
                              int num8 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
                                num8 = 0;
                              switch (num8)
                              {
                                default:
                              }
                            }
                          case 5:
                            try
                            {
label_26:
                              if (enumerator2.MoveNext())
                                goto label_23;
                              else
                                goto label_27;
label_22:
                              PostInsertEvent current3;
                              int num9;
                              while (true)
                              {
                                switch (num9)
                                {
                                  case 1:
                                    current1.OnPostInsert(current3);
                                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                                    continue;
                                  case 2:
                                    goto label_23;
                                  case 3:
                                    goto label_53;
                                  default:
                                    goto label_26;
                                }
                              }
label_23:
                              current3 = enumerator2.Current;
                              num9 = 1;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
                              {
                                num9 = 1;
                                goto label_22;
                              }
                              else
                                goto label_22;
label_27:
                              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 3;
                              goto label_22;
                            }
                            finally
                            {
                              enumerator2.Dispose();
                              int num10 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                                num10 = 0;
                              switch (num10)
                              {
                                default:
                              }
                            }
                          case 6:
                            try
                            {
label_58:
                              if (enumerator5.MoveNext())
                                goto label_60;
                              else
                                goto label_59;
label_56:
                              PostUpdateEvent current4;
                              int num11;
                              while (true)
                              {
                                switch (num11)
                                {
                                  case 1:
                                    goto label_58;
                                  case 2:
                                    goto label_20;
                                  case 3:
                                    PostFlushEventForwarder.vAYjacW7WGWaaCCaXP5P((object) current1, (object) current4);
                                    num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
                                    continue;
                                  default:
                                    goto label_60;
                                }
                              }
label_59:
                              num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 2;
                              goto label_56;
label_60:
                              current4 = enumerator5.Current;
                              num11 = 3;
                              goto label_56;
                            }
                            finally
                            {
                              enumerator5.Dispose();
                              int num12 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
                                num12 = 0;
                              switch (num12)
                              {
                                default:
                              }
                            }
                          case 7:
label_54:
                            enumerator3 = holder.updateCollectionsEvents.GetEnumerator();
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 2;
                            continue;
                        }
label_53:
                        enumerator5 = list2.GetEnumerator();
                        num6 = 6;
                      }
label_32:
                      try
                      {
label_35:
                        if (enumerator3.MoveNext())
                          goto label_37;
                        else
                          goto label_36;
label_33:
                        PostCollectionUpdateEvent current5;
                        int num13;
                        while (true)
                        {
                          switch (num13)
                          {
                            case 1:
                              goto label_37;
                            case 2:
                              PostFlushEventForwarder.uhUssiW7oA5Bglnd6v7e((object) current1, (object) current5);
                              num13 = 3;
                              continue;
                            case 3:
                              goto label_35;
                            default:
                              goto label_16;
                          }
                        }
label_36:
                        num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                        goto label_33;
label_37:
                        current5 = enumerator3.Current;
                        num13 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                        {
                          num13 = 2;
                          goto label_33;
                        }
                        else
                          goto label_33;
                      }
                      finally
                      {
                        enumerator3.Dispose();
                        int num14 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
                          num14 = 0;
                        switch (num14)
                        {
                          default:
                        }
                      }
                    }
                    catch (TransactionRollbackException ex)
                    {
                      int num15 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
                        num15 = 0;
                      switch (num15)
                      {
                        default:
                          throw;
                      }
                    }
                    catch (Exception ex)
                    {
                      int num16 = 2;
                      while (true)
                      {
                        switch (num16)
                        {
                          case 1:
                            if (PostFlushEventForwarder.gryv09W7hxsyOwMqtbWp((object) this.transform, (object) ex))
                            {
                              num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                              continue;
                            }
                            goto label_16;
                          case 2:
                            PostFlushEventForwarder.zGfIYTW7bKuBJIb9Xhks((object) Logger.Log, (object) ex);
                            num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
                            continue;
                          default:
                            goto label_74;
                        }
                      }
label_74:
                      throw;
                    }
                  default:
                    goto label_75;
                }
label_17:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
                goto label_15;
label_75:
                current1 = enumerator1.Current;
                num5 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
                {
                  num5 = 2;
                  goto label_15;
                }
                else
                  goto label_15;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num17 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
                    num17 = 0;
                  while (true)
                  {
                    switch (num17)
                    {
                      case 1:
                        goto label_82;
                      default:
                        enumerator1.Dispose();
                        num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_82:;
              }
            case 6:
            case 19:
              if (PostFlushEventForwarder.HR4NDKW7CfM9LyUyT6Ps((object) holder))
              {
                num2 = 18;
                continue;
              }
              goto case 11;
            case 7:
              num4 = 20;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 3 : 3;
              continue;
            case 8:
              PostFlushEventForwarder.TFZqTcW7EWLf28eXvaa7((object) session);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 13 : 24;
              continue;
            case 9:
              goto label_8;
            case 10:
              // ISSUE: reference to a compiler-generated method
              hashSet = holder.deleteEvents.Select<PostDeleteEvent, string>((Func<PostDeleteEvent, string>) (postDeleteEvent => entityKey(PostFlushEventForwarder.\u003C\u003Ec__DisplayClass8_0.SxZDrgQjdbvGfyT5Q6uc((object) postDeleteEvent)))).Where<string>((Func<string, bool>) (d =>
              {
                int num18 = 2;
                while (true)
                {
                  switch (num18)
                  {
                    case 1:
                      goto label_3;
                    case 2:
                      if (d == null)
                      {
                        num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_2;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return !deleted.Contains(d);
label_3:
                return false;
              })).Distinct<string>().ToHashSet<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 13 : 3;
              continue;
            case 11:
              this.contextBoundVariableService.Set((string) PostFlushEventForwarder.Ukf4DuWAz0G0GP7bpecS(-342626196 - 1290888215 ^ -1633637651), (object) new PostFlushEventForwarder.Holder());
              num2 = 10;
              continue;
            case 12:
              goto label_84;
            case 13:
              if (hashSet.Any<string>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 23 : 4;
                continue;
              }
              goto case 22;
            case 14:
              isDeleteEntity = (Func<object, bool>) (obj =>
              {
                int num19 = 2;
                string str2;
                while (true)
                {
                  switch (num19)
                  {
                    case 1:
                      if (str2 == null)
                      {
                        num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_6;
                    case 2:
                      str2 = entityKey(obj);
                      num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
                      continue;
                    default:
                      goto label_5;
                  }
                }
label_5:
                return false;
label_6:
                return deleted.Contains(str2);
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 19 : 16;
              continue;
            case 15:
              session = (ISession) PostFlushEventForwarder.G2F27YW7BXpRyip0hiKb((object) this.SessionProvider, (object) "");
              num2 = 7;
              continue;
            case 16:
              // ISSUE: reference to a compiler-generated field
              Func<object, string> func1 = PostFlushEventForwarder.\u003C\u003Ec.\u003C\u003E9__8_0;
              Func<object, string> func2;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                PostFlushEventForwarder.\u003C\u003Ec.\u003C\u003E9__8_0 = func2 = (Func<object, string>) (obj =>
                {
                  int num20 = 3;
                  Type typeWithoutProxy;
                  IEntity entity;
                  while (true)
                  {
                    switch (num20)
                    {
                      case 1:
                        goto label_9;
                      case 2:
                        if (entity != null)
                        {
                          typeWithoutProxy = entity.GetType().GetTypeWithoutProxy();
                          num20 = 4;
                          continue;
                        }
                        num20 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
                        continue;
                      case 3:
                        entity = obj as IEntity;
                        num20 = 2;
                        continue;
                      case 4:
                        // ISSUE: reference to a compiler-generated method
                        if (!PostFlushEventForwarder.\u003C\u003Ec.nLX56fQYWYxcZ8wY8OBN(typeWithoutProxy, (Type) null))
                        {
                          num20 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
                          continue;
                        }
                        goto label_10;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  return (string) null;
label_9:
                  return (string) null;
label_10:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  return (string) PostFlushEventForwarder.\u003C\u003Ec.EpTKDAQYb0kbfi28ivdL((object) typeWithoutProxy.FullName, (object) PostFlushEventForwarder.\u003C\u003Ec.iV1D3EQYo5QVWXcCVfRl((object) entity).ToString());
                });
              }
              else
                goto label_107;
label_95:
              entityKey = func2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 14 : 2;
              continue;
label_107:
              func2 = func1;
              goto label_95;
            case 17:
            case 24:
              if (++num3 <= num4)
              {
                num2 = 20;
                continue;
              }
              goto case 21;
            case 18:
              goto label_104;
            case 20:
              holder = this.GetHolder();
              num2 = 6;
              continue;
            case 21:
              object separator = PostFlushEventForwarder.Ukf4DuWAz0G0GP7bpecS(322893104 - -1992822529 ^ -1979230527);
              List<PostInsertEvent> insertEvents = holder.insertEvents;
              // ISSUE: reference to a compiler-generated field
              Func<PostInsertEvent, string> func3 = PostFlushEventForwarder.\u003C\u003Ec.\u003C\u003E9__8_6;
              Func<PostInsertEvent, string> selector1;
              if (func3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                PostFlushEventForwarder.\u003C\u003Ec.\u003C\u003E9__8_6 = selector1 = (Func<PostInsertEvent, string>) (e => (string) PostFlushEventForwarder.\u003C\u003Ec.xtRNKZQYEZJ9OcqlwalQ((object) new object[4]
                {
                  (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536573190),
                  (object) ((IEntityPersister) PostFlushEventForwarder.\u003C\u003Ec.tZGp64QYh4G9LOeHPgdy((object) e)).EntityName,
                  PostFlushEventForwarder.\u003C\u003Ec.ilo3iUQYGU0uo34RqWYc(~-306453669 ^ 306531814),
                  e.Id
                }));
              }
              else
                goto label_110;
label_101:
              IEnumerable<string> first1 = insertEvents.Select<PostInsertEvent, string>(selector1);
              List<PostUpdateEvent> updateEvents1 = holder.updateEvents;
              // ISSUE: reference to a compiler-generated field
              Func<PostUpdateEvent, string> func4 = PostFlushEventForwarder.\u003C\u003Ec.\u003C\u003E9__8_7;
              Func<PostUpdateEvent, string> selector2;
              if (func4 == null)
              {
                // ISSUE: reference to a compiler-generated field
                PostFlushEventForwarder.\u003C\u003Ec.\u003C\u003E9__8_7 = selector2 = (Func<PostUpdateEvent, string>) (e =>
                {
                  int num21 = 3;
                  int[] source;
                  PostUpdateEvent e1;
                  while (true)
                  {
                    int num22 = num21;
                    while (true)
                    {
                      switch (num22)
                      {
                        case 1:
                          goto label_5;
                        case 2:
                          goto label_7;
                        case 3:
                          num22 = 2;
                          continue;
                        case 4:
                          source = new int[0];
                          num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
                          continue;
                        case 5:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          source = (int[]) PostFlushEventForwarder.\u003C\u003Ec.nhhapnQYC4ns4OQmSV1n(PostFlushEventForwarder.\u003C\u003Ec.tZGp64QYh4G9LOeHPgdy((object) e1), (object) e1.State, PostFlushEventForwarder.\u003C\u003Ec.giGvJrQYffhGrYe9TZ96((object) e1), e1.Entity, PostFlushEventForwarder.\u003C\u003Ec.dpsv99QYQELdF8w4nox7((object) e1));
                          num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_3;
                      }
                    }
label_3:
                    if (source == null)
                    {
                      num21 = 4;
                      continue;
                    }
                    break;
label_7:
                    e1 = e;
                    num21 = 5;
                  }
label_5:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  return (string) PostFlushEventForwarder.\u003C\u003Ec.xtRNKZQYEZJ9OcqlwalQ((object) new object[7]
                  {
                    PostFlushEventForwarder.\u003C\u003Ec.ilo3iUQYGU0uo34RqWYc(864270449 << 6 ^ -521391818),
                    (object) ((IEntityPersister) PostFlushEventForwarder.\u003C\u003Ec.tZGp64QYh4G9LOeHPgdy((object) e1)).EntityName,
                    PostFlushEventForwarder.\u003C\u003Ec.ilo3iUQYGU0uo34RqWYc(-1872275253 >> 6 ^ -29307871),
                    e1.Id,
                    PostFlushEventForwarder.\u003C\u003Ec.ilo3iUQYGU0uo34RqWYc(-420743386 ^ -420578728),
                    (object) string.Join((string) PostFlushEventForwarder.\u003C\u003Ec.ilo3iUQYGU0uo34RqWYc(-867826612 ^ -867825586), ((IEnumerable<int>) source).Select<int, string>((Func<int, string>) (idx => (string) PostFlushEventForwarder.\u003C\u003Ec__DisplayClass8_1.h1J3QyQjsSSkUZb7yveS((object) new object[6]
                    {
                      PostFlushEventForwarder.\u003C\u003Ec__DisplayClass8_1.RaSOnoQjj3AFXNZ2RBSf(-1598106783 - -968262081 ^ -630138782),
                      PostFlushEventForwarder.\u003C\u003Ec__DisplayClass8_1.qOZ6twQjLdlvsUXo9NJi(PostFlushEventForwarder.\u003C\u003Ec__DisplayClass8_1.XCEMYcQjY5AtKAcilGvo((object) e1))[idx],
                      PostFlushEventForwarder.\u003C\u003Ec__DisplayClass8_1.RaSOnoQjj3AFXNZ2RBSf(1319452732 ^ 1319161202),
                      PostFlushEventForwarder.\u003C\u003Ec__DisplayClass8_1.zgMoYRQjUDUT5Jyi9Zrb((object) e1)[idx],
                      PostFlushEventForwarder.\u003C\u003Ec__DisplayClass8_1.RaSOnoQjj3AFXNZ2RBSf(1242972401 >> 4 ^ 77916497),
                      e1.State[idx]
                    }))).ToArray<string>()),
                    (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710602718)
                  });
                });
              }
              else
                goto label_109;
label_103:
              IEnumerable<string> first2 = updateEvents1.Select<PostUpdateEvent, string>(selector2);
              List<PostDeleteEvent> deleteEvents = holder.deleteEvents;
              // ISSUE: reference to a compiler-generated field
              Func<PostDeleteEvent, string> func5 = PostFlushEventForwarder.\u003C\u003Ec.\u003C\u003E9__8_8;
              Func<PostDeleteEvent, string> selector3;
              if (func5 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                PostFlushEventForwarder.\u003C\u003Ec.\u003C\u003E9__8_8 = selector3 = (Func<PostDeleteEvent, string>) (e => (string) PostFlushEventForwarder.\u003C\u003Ec.xtRNKZQYEZJ9OcqlwalQ((object) new object[4]
                {
                  PostFlushEventForwarder.\u003C\u003Ec.ilo3iUQYGU0uo34RqWYc(-16752921 ^ -16395445),
                  PostFlushEventForwarder.\u003C\u003Ec.fONgLyQYvQofsVQwN0f0(PostFlushEventForwarder.\u003C\u003Ec.tZGp64QYh4G9LOeHPgdy((object) e)),
                  PostFlushEventForwarder.\u003C\u003Ec.ilo3iUQYGU0uo34RqWYc(-675505729 ^ -675428099),
                  PostFlushEventForwarder.\u003C\u003Ec.uQV33dQY896LTPhLemwy((object) e)
                }));
              }
              else
                goto label_108;
label_106:
              IEnumerable<string> second = deleteEvents.Select<PostDeleteEvent, string>(selector3);
              string[] array = first2.Union<string>(second).ToArray<string>();
              IEnumerable<string> values = first1.Union<string>((IEnumerable<string>) array);
              str1 = string.Join((string) separator, values);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 6 : 9;
              continue;
label_108:
              selector3 = func5;
              goto label_106;
label_109:
              selector2 = func4;
              goto label_103;
label_110:
              selector1 = func3;
              goto label_101;
            case 22:
              list1 = holder.insertEvents.Where<PostInsertEvent>((Func<PostInsertEvent, bool>) (postInsertEvent => !isDeleteEntity(postInsertEvent.Entity))).ToList<PostInsertEvent>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 25 : 24;
              continue;
            case 23:
              deleted.UnionWith((IEnumerable<string>) hashSet);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 22 : 17;
              continue;
            case 25:
              goto label_98;
            default:
              holder = this.GetHolder();
              num2 = 15;
              continue;
          }
        }
label_84:
        deleted = new HashSet<string>();
        num1 = 16;
        continue;
label_98:
        List<PostUpdateEvent> updateEvents2 = holder.updateEvents;
        Func<PostUpdateEvent, bool> func;
        Func<PostUpdateEvent, bool> func6 = func;
        // ISSUE: reference to a compiler-generated method
        Func<PostUpdateEvent, bool> predicate = func6 == null ? (func = (Func<PostUpdateEvent, bool>) (postUpdateEvent => !isDeleteEntity(PostFlushEventForwarder.\u003C\u003Ec__DisplayClass8_0.SxZDrgQjdbvGfyT5Q6uc((object) postUpdateEvent)))) : func6;
        list2 = updateEvents2.Where<PostUpdateEvent>(predicate).ToList<PostUpdateEvent>();
        num1 = 4;
      }
label_104:
      return;
label_8:
      throw new InvalidOperationException((string) PostFlushEventForwarder.JBvoviW7QR67MFCq9nLI(PostFlushEventForwarder.FW8vk6W7fD4T6EaTw3it(PostFlushEventForwarder.Ukf4DuWAz0G0GP7bpecS(~1767720452 ^ -1767858489)), (object) str1));
    }

    public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PostFlushEventForwarder.uupHhmW7FrU6jfjhCWog((object) this.contextBoundVariableService, PostFlushEventForwarder.Ukf4DuWAz0G0GP7bpecS(1654249598 >> 2 ^ 413421735), (object) new PostFlushEventForwarder.Holder());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private PostFlushEventForwarder.Holder GetHolder()
    {
      IContextBoundVariableService boundVariableService = this.contextBoundVariableService;
      object name = PostFlushEventForwarder.Ukf4DuWAz0G0GP7bpecS(-1822890472 ^ -1822768992);
      // ISSUE: reference to a compiler-generated field
      Func<PostFlushEventForwarder.Holder> func = PostFlushEventForwarder.\u003C\u003Ec.\u003C\u003E9__12_0;
      Func<PostFlushEventForwarder.Holder> factory;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        PostFlushEventForwarder.\u003C\u003Ec.\u003C\u003E9__12_0 = factory = (Func<PostFlushEventForwarder.Holder>) (() => new PostFlushEventForwarder.Holder());
      }
      else
        goto label_1;
label_3:
      return boundVariableService.GetOrAdd<PostFlushEventForwarder.Holder>((string) name, factory);
label_1:
      factory = func;
      goto label_3;
    }

    public override void OnPostUpdate(PostUpdateEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.GetHolder().updateEvents.Add(@event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override void OnPostDelete(PostDeleteEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.GetHolder().deleteEvents.Add(@event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override void OnPostInsert(PostInsertEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.GetHolder().insertEvents.Add(@event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.GetHolder().updateCollectionsEvents.Add(@event);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    internal static object Ukf4DuWAz0G0GP7bpecS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void uupHhmW7FrU6jfjhCWog([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);

    internal static bool XmGeveWAsTATI4ZjBw6m() => PostFlushEventForwarder.oP1XF5WAUfnaPtCWXYq7 == null;

    internal static PostFlushEventForwarder UBI4TpWAcdsXYINv9NE4() => PostFlushEventForwarder.oP1XF5WAUfnaPtCWXYq7;

    internal static object G2F27YW7BXpRyip0hiKb([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static void vAYjacW7WGWaaCCaXP5P([In] object obj0, [In] object obj1) => ((IPostFlushEventListener) obj0).OnPostUpdate((PostUpdateEvent) obj1);

    internal static void uhUssiW7oA5Bglnd6v7e([In] object obj0, [In] object obj1) => ((IPostFlushEventListener) obj0).OnPostUpdateCollection((PostCollectionUpdateEvent) obj1);

    internal static void zGfIYTW7bKuBJIb9Xhks([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static bool gryv09W7hxsyOwMqtbWp([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).IsUnrecoverableException((Exception) obj1);

    internal static bool wSpIIxW7GpTVmFKyClyr([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void TFZqTcW7EWLf28eXvaa7([In] object obj0) => ((ISession) obj0).Flush();

    internal static object FW8vk6W7fD4T6EaTw3it([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object JBvoviW7QR67MFCq9nLI([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool HR4NDKW7CfM9LyUyT6Ps([In] object obj0) => ((PostFlushEventForwarder.Holder) obj0).IsEmpty();

    private class Holder
    {
      public readonly List<PostInsertEvent> insertEvents;
      public readonly List<PostUpdateEvent> updateEvents;
      public readonly List<PostDeleteEvent> deleteEvents;
      public readonly List<PostCollectionUpdateEvent> updateCollectionsEvents;
      internal static object Dgl5YkQjHwomlGvY95S2;

      public bool IsEmpty()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (PostFlushEventForwarder.Holder.pe9sKtQjx8WBgSA8gsSy((object) this.insertEvents) == 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 2:
              goto label_6;
            case 3:
              goto label_7;
            case 4:
              if (this.deleteEvents.Count != 0)
              {
                num = 3;
                continue;
              }
              goto label_6;
            default:
              if (PostFlushEventForwarder.Holder.GmexQbQj0P7TAcZw9SjT((object) this.updateEvents) == 0)
              {
                num = 4;
                continue;
              }
              goto label_7;
          }
        }
label_6:
        return PostFlushEventForwarder.Holder.ClKkg1QjmFv3jrcZqp7J((object) this.updateCollectionsEvents) == 0;
label_7:
        return false;
      }

      public Holder()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.insertEvents = new List<PostInsertEvent>();
        this.updateEvents = new List<PostUpdateEvent>();
        this.deleteEvents = new List<PostDeleteEvent>();
        this.updateCollectionsEvents = new List<PostCollectionUpdateEvent>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static int pe9sKtQjx8WBgSA8gsSy([In] object obj0) => ((List<PostInsertEvent>) obj0).Count;

      internal static int GmexQbQj0P7TAcZw9SjT([In] object obj0) => ((List<PostUpdateEvent>) obj0).Count;

      internal static int ClKkg1QjmFv3jrcZqp7J([In] object obj0) => ((List<PostCollectionUpdateEvent>) obj0).Count;

      internal static bool H21SP5QjAlhiovFgZ6Lq() => PostFlushEventForwarder.Holder.Dgl5YkQjHwomlGvY95S2 == null;

      internal static PostFlushEventForwarder.Holder wR0Bd9Qj70ADyDiOhMS9() => (PostFlushEventForwarder.Holder) PostFlushEventForwarder.Holder.Dgl5YkQjHwomlGvY95S2;
    }
  }
}

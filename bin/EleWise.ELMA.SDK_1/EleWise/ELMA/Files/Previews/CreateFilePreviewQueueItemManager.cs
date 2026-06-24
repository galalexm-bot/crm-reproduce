// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.CreateFilePreviewQueueItemManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Работа очереди создания превью для файла</summary>
  public class CreateFilePreviewQueueItemManager : EntityManager<ICreateFilePreviewQueueItem, long>
  {
    /// <summary>
    /// Максимальное количество попыток генерации файла предпросмотра
    /// </summary>
    public const long MaxAttemptsCount = 8;
    private static readonly string LockName;
    private static CreateFilePreviewQueueItemManager yvYVUvGexp0yv9DlSI7W;

    /// <summary>Экземпляр менеджера</summary>
    public static CreateFilePreviewQueueItemManager Instance => Locator.GetServiceNotNull<CreateFilePreviewQueueItemManager>();

    /// <summary>Сервис блокировок</summary>
    public ILockService LockService
    {
      get => this.\u003CLockService\u003Ek__BackingField;
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
              this.\u003CLockService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
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

    /// <summary>Управление превью</summary>
    public IFilePreviewService DocumentPreviewService
    {
      get => this.\u003CDocumentPreviewService\u003Ek__BackingField;
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
              this.\u003CDocumentPreviewService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
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

    /// <summary>Провайдер преобразования БД</summary>
    public ITransformationProvider TransformationProvider
    {
      get => this.\u003CTransformationProvider\u003Ek__BackingField;
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
              this.\u003CTransformationProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
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

    /// <summary>Получить элементы для обработки</summary>
    /// <param name="top">Количество элементов</param>
    /// <returns>Идентификаторы элементов в очереди</returns>
    [Transaction]
    public virtual long[] GetTopElemets(int top)
    {
      int num1 = 2;
      long[] source1;
      ILock @lock;
      while (true)
      {
        switch (num1)
        {
          case 1:
            @lock = (ILock) CreateFilePreviewQueueItemManager.nCqU0IGeywuDLmTt5bNy((object) this.LockService, (object) CreateFilePreviewQueueItemManager.LockName);
            num1 = 3;
            continue;
          case 2:
            source1 = (long[]) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return source1;
label_3:
      try
      {
        IList<IList> source2 = ((ICriteria) CreateFilePreviewQueueItemManager.mYV03aGeLqKkXL06hcUk(CreateFilePreviewQueueItemManager.WpP51BGejCalvLcc2YjE(CreateFilePreviewQueueItemManager.WpP51BGejCalvLcc2YjE(CreateFilePreviewQueueItemManager.NA0cwFGegaLSNrmqRO77(CreateFilePreviewQueueItemManager.QdG5ptGeduOCObaibOXC(CreateFilePreviewQueueItemManager.GQ89MTGeMNCaw6J1FTWt((object) this, (object) null), CreateFilePreviewQueueItemManager.NxnkxnGe9lk7jlP66ZZ7(CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(-1824388195 ^ -1824355813), (object) PreviewWorkStatus.None)), (object) new IProjection[3]
        {
          (IProjection) CreateFilePreviewQueueItemManager.aydncPGer74fC1Ukgb9w(CreateFilePreviewQueueItemManager.byXRvdGelgysROeZRN42(CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(-97972138 ^ -97939192)), CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(1218962250 ^ 1218710316)),
          (IProjection) CreateFilePreviewQueueItemManager.aydncPGer74fC1Ukgb9w((object) Projections.Max((string) CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(-1978478350 ^ -1978582884)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77779525)),
          (IProjection) Projections.GroupProperty((string) CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(-1120607109 - 305487170 ^ -1426296901))
        }), CreateFilePreviewQueueItemManager.WhUF2cGe5rTcEV2iuGRq(CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(694673736 ^ -23604109 ^ -671906959))), CreateFilePreviewQueueItemManager.Kbg9BJGeYAsww7UL1sMq((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105304188))), top)).List<IList>();
        // ISSUE: reference to a compiler-generated field
        Func<IList, long> func = CreateFilePreviewQueueItemManager.\u003C\u003Ec.\u003C\u003E9__16_0;
        Func<IList, long> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          CreateFilePreviewQueueItemManager.\u003C\u003Ec.\u003C\u003E9__16_0 = selector = (Func<IList, long>) (l => (long) CreateFilePreviewQueueItemManager.\u003C\u003Ec.AWM97RvzpBl7XlZTgrRS((object) l, 0));
        }
        else
          goto label_27;
label_5:
        source1 = source2.Select<IList, long>(selector).ToArray<long>();
        int num2 = 6;
        string sql;
        Dictionary<string, object> paramValues;
        string str;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 3 : 4;
              continue;
            case 2:
            case 7:
              goto label_2;
            case 4:
            case 12:
              if (index < source1.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                continue;
              }
              goto case 11;
            case 5:
              this.Session.CleanUpCache(TypeOf<ICreateFilePreviewQueueItem>.Raw);
              num2 = 2;
              continue;
            case 6:
              if (source1.Length == 0)
              {
                num2 = 7;
                continue;
              }
              goto case 13;
            case 8:
              index = 0;
              num2 = 12;
              continue;
            case 9:
              paramValues = new Dictionary<string, object>()
              {
                {
                  (string) CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(1142330761 ^ 1541959139 ^ 536678648),
                  (object) 0
                }
              };
              num2 = 8;
              continue;
            case 10:
              this.TransformationProvider.ExecuteQuery(sql, paramValues);
              num2 = 5;
              continue;
            case 11:
              sql = (string) CreateFilePreviewQueueItemManager.fjp7peGPFB6A8IYT66Od(CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(-488881205 ^ -488658169), (object) new object[5]
              {
                CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(1304605005 ^ 1304516629),
                CreateFilePreviewQueueItemManager.lP3YbdGec1BFxSmOEUcG(CreateFilePreviewQueueItemManager.IMBti0GesiEry6sM9ufM((object) this.TransformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199985763)),
                CreateFilePreviewQueueItemManager.Wr1OIhGezVCBDkckDJ5P((object) this.TransformationProvider),
                CreateFilePreviewQueueItemManager.lP3YbdGec1BFxSmOEUcG(CreateFilePreviewQueueItemManager.IMBti0GesiEry6sM9ufM((object) this.TransformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461592775)),
                (object) str
              });
              num2 = 10;
              continue;
            case 13:
              str = string.Join((string) CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(132912447 ^ 132925391), ((IEnumerable<long>) source1).Select<long, string>((Func<long, int, string>) ((item, i) => (string) CreateFilePreviewQueueItemManager.YTEoMmGPZcMBHn5OWfrc(CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(--1867379187 ^ 1867389759), (object) this.TransformationProvider.ParameterSeparator, (object) i))));
              num2 = 9;
              continue;
            default:
              paramValues.Add((string) CreateFilePreviewQueueItemManager.xokgJVGeUfyGRwuUClY1((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29215809), (object) index), (object) source1[index]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
              continue;
          }
        }
label_27:
        selector = func;
        goto label_5;
      }
      finally
      {
        if (@lock != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_24;
              default:
                CreateFilePreviewQueueItemManager.JEJSZRGPBOA215OcM3JI((object) @lock);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_24:;
      }
    }

    /// <summary>Получить элементы для обработки</summary>
    /// <returns>Идентификаторы элементов в очереди</returns>
    public IList<ICreateFilePreviewQueueItem> GetNewElements() => this.CreateCriteria().Add((ICriterion) Restrictions.Or((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70039925), (object) PreviewWorkStatus.None), (ICriterion) Restrictions.Conjunction().Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29287195), (object) PreviewWorkStatus.Fail)).Add((ICriterion) Restrictions.Lt(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124654082), (object) 8L)).Add((ICriterion) Restrictions.Le(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837852693), (object) DateTime.Now)))).AddOrder(Order.Desc(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811954144))).AddOrder(Order.Asc(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217490841))).List<ICreateFilePreviewQueueItem>();

    /// <summary>Удалить из очереди выполненные задачи</summary>
    public void DeleteExecuted()
    {
      switch (1)
      {
        case 1:
          try
          {
            IEnumerator<long> enumerator = ((ICriteria) CreateFilePreviewQueueItemManager.QdG5ptGeduOCObaibOXC(CreateFilePreviewQueueItemManager.GQ89MTGeMNCaw6J1FTWt((object) this, (object) null), CreateFilePreviewQueueItemManager.dNQUbBGPWhtaB4YJGoYn(CreateFilePreviewQueueItemManager.NxnkxnGe9lk7jlP66ZZ7(CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(-420743386 ^ -420776288), (object) PreviewWorkStatus.Completed), CreateFilePreviewQueueItemManager.Hgyx5KGPoVbEXjFcjaZY((object) Restrictions.Conjunction().Add((ICriterion) CreateFilePreviewQueueItemManager.NxnkxnGe9lk7jlP66ZZ7((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858920409), (object) PreviewWorkStatus.Fail)), CreateFilePreviewQueueItemManager.dNQUbBGPWhtaB4YJGoYn((object) Restrictions.IsNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222177778)), (object) Restrictions.Ge((string) CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(-1204263869 ^ -1341583247 ^ 137540286), (object) 8L)))))).SetProjection((IProjection) CreateFilePreviewQueueItemManager.ItnsBDGPbYIvUkYpLl3y(CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(~-122002947 ^ 121970524))).List<long>().GetEnumerator();
            int num1 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
              num1 = 0;
            switch (num1)
            {
              default:
                try
                {
label_19:
                  if (CreateFilePreviewQueueItemManager.IWOdRoGPf44N637vsy1x((object) enumerator))
                    goto label_8;
                  else
                    goto label_20;
label_6:
                  int num2;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 1:
                        goto label_8;
                      case 2:
                        CreateFilePreviewQueueItemManager.WdGt6ZGPhvwVdtHB9ZBC((object) this.Session);
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 4 : 4;
                        continue;
                      case 3:
                        goto label_21;
                      case 4:
                        goto label_9;
                      default:
                        goto label_19;
                    }
                  }
label_21:
                  return;
label_9:
                  long current;
                  try
                  {
                    ICreateFilePreviewQueueItem previewQueueItem = this.LoadOrNull(current);
                    int num3 = 3;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
                      num3 = 3;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                        case 2:
                          goto label_19;
                        case 3:
                          if (previewQueueItem == null)
                          {
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
                            continue;
                          }
                          break;
                      }
                      this.TryDeleteItem(previewQueueItem);
                      num3 = 2;
                    }
                  }
                  catch (Exception ex)
                  {
                    int num4 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
                      num4 = 1;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          CreateFilePreviewQueueItemManager.Eu4nVhGPEQmiVItCl9Wk(CreateFilePreviewQueueItemManager.HLCKrLGPG6esvMc1aWFg((object) this), CreateFilePreviewQueueItemManager.xokgJVGeUfyGRwuUClY1((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309809650), (object) current), (object) ex);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_19;
                      }
                    }
                  }
label_8:
                  current = enumerator.Current;
                  num2 = 2;
                  goto label_6;
label_20:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 3;
                  goto label_6;
                }
                finally
                {
                  if (enumerator != null)
                  {
                    int num5 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
                      num5 = 0;
                    while (true)
                    {
                      switch (num5)
                      {
                        case 1:
                          goto label_28;
                        default:
                          CreateFilePreviewQueueItemManager.JEJSZRGPBOA215OcM3JI((object) enumerator);
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 1;
                          continue;
                      }
                    }
                  }
label_28:;
                }
            }
          }
          finally
          {
            CreateFilePreviewQueueItemManager.WdGt6ZGPhvwVdtHB9ZBC((object) this.Session);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
              num = 0;
            switch (num)
            {
              default:
            }
          }
      }
    }

    /// <summary>Удалить элемент очереди</summary>
    /// <param name="item">Элемент очереди</param>
    [Transaction]
    public virtual void TryDeleteItem(ICreateFilePreviewQueueItem item)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (!this.LockForCreatePreview(item))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            }
            item.Delete();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 1;
            continue;
          case 2:
            goto label_5;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_5:
      return;
label_7:;
    }

    /// <summary>Блокировать элемент очереди для создания превью</summary>
    /// <param name="item"></param>
    /// <returns>True, если все нормально</returns>
    protected bool LockForCreatePreview(ICreateFilePreviewQueueItem item)
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_8;
          case 2:
            goto label_4;
          case 3:
            if (item == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 2;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_4:
      throw new ArgumentNullException((string) CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(-1638402543 ^ -1638441361));
label_6:
      return true;
label_8:
      bool preview;
      try
      {
        int timeout = EleWise.ELMA.SR.GetSetting<int>((string) CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(-1317790512 ^ -1317538088), 1);
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              if (timeout > 0)
              {
                num2 = 4;
                continue;
              }
              goto case 5;
            case 3:
              this.Refresh(item);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 0;
              continue;
            case 5:
              timeout = 1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            default:
              CreateFilePreviewQueueItemManager.jymirpGPQmCEvB2tG4HL((object) this.Session, (object) item, timeout);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 3 : 3;
              continue;
          }
        }
      }
      catch
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              CreateFilePreviewQueueItemManager.Ol0XqxGPCDyU8yK209QD(CreateFilePreviewQueueItemManager.HLCKrLGPG6esvMc1aWFg((object) this), (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740507758) + (object) item.Id));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_7;
            default:
              preview = false;
              num3 = 2;
              continue;
          }
        }
      }
label_7:
      return preview;
    }

    /// <summary>Найти элемент в очереди</summary>
    /// <param name="fileId">Идентификатор файла</param>
    /// <returns>Элемент очереди</returns>
    public ICreateFilePreviewQueueItem FindItemById(string fileId)
    {
      int num = 1;
      Filter filter;
      while (true)
      {
        switch (num)
        {
          case 1:
            filter = new Filter()
            {
              Query = (string) CreateFilePreviewQueueItemManager.p8bbXlGPv4Y57NMRAUbf((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837853455), (object) fileId)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.Find((IEntityFilter) filter, new FetchOptions(0, 1)).FirstOrDefault<ICreateFilePreviewQueueItem>();
    }

    public CreateFilePreviewQueueItemManager()
    {
      CreateFilePreviewQueueItemManager.hU490pGP8qMh5x1ndPmW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static CreateFilePreviewQueueItemManager()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            CreateFilePreviewQueueItemManager.LockName = (string) CreateFilePreviewQueueItemManager.LKlGWCGeJ6o2SeiJMCjF(-1837662597 ^ -1837853475);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static bool YVLitxGe0i806pbwZVso() => CreateFilePreviewQueueItemManager.yvYVUvGexp0yv9DlSI7W == null;

    internal static CreateFilePreviewQueueItemManager eGyTDlGemapouVGqyCpu() => CreateFilePreviewQueueItemManager.yvYVUvGexp0yv9DlSI7W;

    internal static object nCqU0IGeywuDLmTt5bNy([In] object obj0, [In] object obj1) => (object) ((ILockService) obj0).AcquireLock((string) obj1);

    internal static object GQ89MTGeMNCaw6J1FTWt([In] object obj0, [In] object obj1) => (object) ((EntityManager<ICreateFilePreviewQueueItem, long>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object LKlGWCGeJ6o2SeiJMCjF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object NxnkxnGe9lk7jlP66ZZ7([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object QdG5ptGeduOCObaibOXC([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object byXRvdGelgysROeZRN42([In] object obj0) => (object) Projections.Max((string) obj0);

    internal static object aydncPGer74fC1Ukgb9w([In] object obj0, [In] object obj1) => (object) Projections.Alias((IProjection) obj0, (string) obj1);

    internal static object NA0cwFGegaLSNrmqRO77([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetProjection((IProjection[]) obj1);

    internal static object WhUF2cGe5rTcEV2iuGRq([In] object obj0) => (object) Order.Desc((string) obj0);

    internal static object WpP51BGejCalvLcc2YjE([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).AddOrder((Order) obj1);

    internal static object Kbg9BJGeYAsww7UL1sMq([In] object obj0) => (object) Order.Asc((string) obj0);

    internal static object mYV03aGeLqKkXL06hcUk([In] object obj0, [In] int obj1) => (object) ((ICriteria) obj0).SetMaxResults(obj1);

    internal static object xokgJVGeUfyGRwuUClY1([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object IMBti0GesiEry6sM9ufM([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object lP3YbdGec1BFxSmOEUcG([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object Wr1OIhGezVCBDkckDJ5P([In] object obj0) => (object) ((ITransformationProvider) obj0).ParameterSeparator;

    internal static object fjp7peGPFB6A8IYT66Od([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static void JEJSZRGPBOA215OcM3JI([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object dNQUbBGPWhtaB4YJGoYn([In] object obj0, [In] object obj1) => (object) Restrictions.Or((ICriterion) obj0, (ICriterion) obj1);

    internal static object Hgyx5KGPoVbEXjFcjaZY([In] object obj0, [In] object obj1) => (object) ((Junction) obj0).Add((ICriterion) obj1);

    internal static object ItnsBDGPbYIvUkYpLl3y([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static void WdGt6ZGPhvwVdtHB9ZBC([In] object obj0) => ((ISession) obj0).Clear();

    internal static object HLCKrLGPG6esvMc1aWFg([In] object obj0) => (object) ((EntityManager<ICreateFilePreviewQueueItem, long>) obj0).Logger;

    internal static void Eu4nVhGPEQmiVItCl9Wk([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static bool IWOdRoGPf44N637vsy1x([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void jymirpGPQmCEvB2tG4HL([In] object obj0, [In] object obj1, int timeout) => ((ISession) obj0).LockWithWait(obj1, timeout);

    internal static void Ol0XqxGPCDyU8yK209QD([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static object p8bbXlGPv4Y57NMRAUbf([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void hU490pGP8qMh5x1ndPmW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object YTEoMmGPZcMBHn5OWfrc([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemInfoService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>
  /// Сервис для получения данных о доступных типах элементов представлений
  /// </summary>
  [Service]
  public class ViewItemInfoService : IInitHandler
  {
    private List<ViewItemTypeInfo> viewItemTypes;
    private static ViewItemInfoService l6vkL3oPCseeyMcCyOkp;

    /// <summary>Информация о типах элементов представления</summary>
    public IEnumerable<ViewItemTypeInfo> ViewItemTypes => (IEnumerable<ViewItemTypeInfo>) this.viewItemTypes;

    /// <summary>Получить информацию о типе элемента представления</summary>
    /// <param name="viewItemType"></param>
    /// <returns></returns>
    public ViewItemTypeInfo GetInfo(Type viewItemType)
    {
      int num1 = 8;
      ViewItemTypeInfo info;
      List<ViewItemTypeInfo> viewItemTypes;
      bool lockTaken;
      Type viewItemType1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            viewItemTypes = this.viewItemTypes;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 2 : 2;
            continue;
          case 2:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 4;
            continue;
          case 3:
            if (info != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 4 : 5;
              continue;
            }
            goto case 1;
          case 4:
            goto label_7;
          case 6:
            info = this.viewItemTypes.FirstOrDefault<ViewItemTypeInfo>((Func<ViewItemTypeInfo, bool>) (i => i.ViewItemType == viewItemType1));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 3 : 2;
            continue;
          case 7:
            viewItemType1 = viewItemType;
            num1 = 6;
            continue;
          case 8:
            num1 = 7;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return info;
label_7:
      try
      {
        Monitor.Enter((object) viewItemTypes, ref lockTaken);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              this.viewItemTypes.Add(info);
              num2 = 3;
              continue;
            case 3:
              this.UpdateInfos();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
              continue;
            default:
              info = new ViewItemTypeInfo(viewItemType1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 2;
              continue;
          }
        }
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
        else
          goto label_16;
label_15:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_16:
        ViewItemInfoService.DGkwawoPZBcbbRrvGAfL((object) viewItemTypes);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        {
          num3 = 2;
          goto label_15;
        }
        else
          goto label_15;
      }
    }

    private void UpdateInfos()
    {
      int num1 = 4;
      while (true)
      {
        IEnumerator<ViewItemTypeInfo> enumerator;
        IEnumerable<ViewItemTypeInfo> source1;
        switch (num1)
        {
          case 1:
            goto label_23;
          case 2:
            try
            {
label_4:
              if (ViewItemInfoService.YOqrohoPSuZioPDoNSIm((object) enumerator))
                goto label_6;
              else
                goto label_5;
label_3:
              ViewItemTypeInfo current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_6;
                  case 2:
                    goto label_22;
                  case 3:
                    current.name = source1.Contains<ViewItemTypeInfo>(current) ? (string) ViewItemInfoService.ikGe5IoPV8A3qua8yeui((object) current.originalName, ViewItemInfoService.xJ6LQmoPuBhZrpr1pj5E(-1998538950 ^ -1998532592), ViewItemInfoService.Fj8LtqoPIo7RyYq8bAfj((object) current.ViewItemType), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312862075)) : current.originalName;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_5:
              num2 = 2;
              goto label_3;
label_6:
              current = enumerator.Current;
              num2 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
              {
                num2 = 3;
                goto label_3;
              }
              else
                goto label_3;
            }
            finally
            {
              if (enumerator != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
                  num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      ViewItemInfoService.w2869KoPib3Bm6D8XFqG((object) enumerator);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_14;
                  }
                }
              }
label_14:;
            }
          case 3:
            enumerator = source1.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 0;
            continue;
          case 4:
            List<ViewItemTypeInfo> viewItemTypes1 = this.viewItemTypes;
            // ISSUE: reference to a compiler-generated field
            Func<ViewItemTypeInfo, string> func1 = ViewItemInfoService.\u003C\u003Ec.\u003C\u003E9__4_0;
            Func<ViewItemTypeInfo, string> keySelector1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ViewItemInfoService.\u003C\u003Ec.\u003C\u003E9__4_0 = keySelector1 = (Func<ViewItemTypeInfo, string>) (i => i.originalName);
            }
            else
              goto label_27;
label_19:
            IEnumerable<IGrouping<string, ViewItemTypeInfo>> source2 = viewItemTypes1.GroupBy<ViewItemTypeInfo, string>(keySelector1);
            // ISSUE: reference to a compiler-generated field
            Func<IGrouping<string, ViewItemTypeInfo>, bool> func2 = ViewItemInfoService.\u003C\u003Ec.\u003C\u003E9__4_1;
            Func<IGrouping<string, ViewItemTypeInfo>, bool> predicate;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ViewItemInfoService.\u003C\u003Ec.\u003C\u003E9__4_1 = predicate = (Func<IGrouping<string, ViewItemTypeInfo>, bool>) (g => g.Count<ViewItemTypeInfo>() > 1);
            }
            else
              goto label_26;
label_21:
            source1 = source2.Where<IGrouping<string, ViewItemTypeInfo>>(predicate).SelectMany<IGrouping<string, ViewItemTypeInfo>, ViewItemTypeInfo>((Func<IGrouping<string, ViewItemTypeInfo>, IEnumerable<ViewItemTypeInfo>>) (g => (IEnumerable<ViewItemTypeInfo>) g));
            num1 = 3;
            continue;
label_26:
            predicate = func2;
            goto label_21;
label_27:
            keySelector1 = func1;
            goto label_19;
        }
label_22:
        List<ViewItemTypeInfo> viewItemTypes2 = this.viewItemTypes;
        // ISSUE: reference to a compiler-generated field
        Func<ViewItemTypeInfo, string> func3 = ViewItemInfoService.\u003C\u003Ec.\u003C\u003E9__4_3;
        Func<ViewItemTypeInfo, string> keySelector2;
        if (func3 == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          ViewItemInfoService.\u003C\u003Ec.\u003C\u003E9__4_3 = keySelector2 = (Func<ViewItemTypeInfo, string>) (i => (string) ViewItemInfoService.\u003C\u003Ec.L34fOMCQ9Iu70a99eflD((object) i));
        }
        else
          goto label_17;
label_25:
        this.viewItemTypes = viewItemTypes2.OrderBy<ViewItemTypeInfo, string>(keySelector2).ToList<ViewItemTypeInfo>();
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
        continue;
label_17:
        keySelector2 = func3;
        goto label_25;
      }
label_23:;
    }

    void IInitHandler.Init()
    {
    }

    void IInitHandler.InitComplete()
    {
      int num1 = 1;
      List<ViewItemTypeInfo> viewItemTypes;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            viewItemTypes = this.viewItemTypes;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_27;
          case 3:
            goto label_2;
          default:
            lockTaken = false;
            num1 = 3;
            continue;
        }
      }
label_27:
      return;
label_2:
      try
      {
        Monitor.Enter((object) viewItemTypes, ref lockTaken);
        int num2 = 2;
        IEnumerator<Type> enumerator;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_22;
            case 1:
label_4:
              this.UpdateInfos();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            case 2:
              Type[] xsiTypes = ComponentManager.Current.GetXsiTypes();
              // ISSUE: reference to a compiler-generated field
              Func<Type, bool> func = ViewItemInfoService.\u003C\u003Ec.\u003C\u003E9__6_0;
              Func<Type, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                ViewItemInfoService.\u003C\u003Ec.\u003C\u003E9__6_0 = predicate = (Func<Type, bool>) (t =>
                {
                  int num3 = 2;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 2:
                        // ISSUE: type reference
                        // ISSUE: reference to a compiler-generated method
                        if (!ViewItemInfoService.\u003C\u003Ec.vTnanXCQdyAiFsvFdrMp(__typeref (ViewItem)).IsAssignableFrom(t))
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
                          continue;
                        }
                        goto case 4;
                      case 3:
                        goto label_2;
                      case 4:
                        if (t.IsAbstract)
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                          continue;
                        }
                        goto label_2;
                      default:
                        goto label_3;
                    }
                  }
label_2:
                  return !t.IsGenericTypeDefinition;
label_3:
                  return false;
                });
              }
              else
                goto label_32;
label_21:
              enumerator = ((IEnumerable<Type>) xsiTypes).Where<Type>(predicate).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 3 : 3;
              continue;
label_32:
              predicate = func;
              goto label_21;
            case 3:
              try
              {
label_8:
                if (ViewItemInfoService.YOqrohoPSuZioPDoNSIm((object) enumerator))
                  goto label_10;
                else
                  goto label_9;
label_6:
                Type current;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      this.viewItemTypes.Add(new ViewItemTypeInfo(current));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 2;
                      continue;
                    case 2:
                      goto label_8;
                    case 3:
                      goto label_4;
                    default:
                      goto label_10;
                  }
                }
label_9:
                num4 = 3;
                goto label_6;
label_10:
                current = enumerator.Current;
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
                {
                  num4 = 1;
                  goto label_6;
                }
                else
                  goto label_6;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num5 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
                    num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        ViewItemInfoService.w2869KoPib3Bm6D8XFqG((object) enumerator);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_17;
                    }
                  }
                }
label_17:;
              }
            default:
              goto label_19;
          }
        }
label_22:
        return;
label_19:;
      }
      finally
      {
        if (lockTaken)
        {
          int num6 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 1:
                ViewItemInfoService.DGkwawoPZBcbbRrvGAfL((object) viewItemTypes);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                continue;
              default:
                goto label_29;
            }
          }
        }
label_29:;
      }
    }

    public ViewItemInfoService()
    {
      ViewItemInfoService.JvC19RoPR2NTMCXuFSn8();
      this.viewItemTypes = new List<ViewItemTypeInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void DGkwawoPZBcbbRrvGAfL([In] object obj0) => Monitor.Exit(obj0);

    internal static bool R1xaw7oPvmuc6qJE5Iya() => ViewItemInfoService.l6vkL3oPCseeyMcCyOkp == null;

    internal static ViewItemInfoService M5nxc9oP86HDOnFTtwQ5() => ViewItemInfoService.l6vkL3oPCseeyMcCyOkp;

    internal static object xJ6LQmoPuBhZrpr1pj5E(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Fj8LtqoPIo7RyYq8bAfj([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object ikGe5IoPV8A3qua8yeui(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static bool YOqrohoPSuZioPDoNSIm([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void w2869KoPib3Bm6D8XFqG([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void JvC19RoPR2NTMCXuFSn8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.PlatformTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Вспомогательная группа типов "Объекты платформы"</summary>
  [Component(Order = 300)]
  public class PlatformTypeDescriptor : EntityDescriptor
  {
    /// <summary>Uid типа</summary>
    public new const string UID_S = "{853FA699-2756-49AD-A621-EC8158A565B0}";
    /// <summary>Uid типа</summary>
    public new static readonly Guid UID;
    internal static PlatformTypeDescriptor orsHfRoMcopJEALYYkDC;

    /// <summary>Uid типа данных или группы типов</summary>
    public override Guid Uid => PlatformTypeDescriptor.UID;

    /// <summary>Имя "Объект"</summary>
    public override string Name => (string) PlatformTypeDescriptor.ffDocvoJW5bBoSgSymHu(PlatformTypeDescriptor.UOdJLJoJBSa6NjqXpBPL(-1217523399 ^ -1217624025));

    /// <summary>Uid родительской группы типов данных - корневая папка</summary>
    public override Guid ParentUid => Guid.Empty;

    /// <summary>
    /// Получить список подтипов - список типов объектов, разбитых по папкам
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <returns>Список подтипов</returns>
    public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata)
    {
      IEnumerable<IPlatformTypeDescriptorProvider> service = Locator.GetService<IEnumerable<IPlatformTypeDescriptorProvider>>();
      // ISSUE: reference to a compiler-generated method
      return service != null ? (IEnumerable<ITypeDescriptor>) service.SelectMany<IPlatformTypeDescriptorProvider, ITypeDescriptor>((Func<IPlatformTypeDescriptorProvider, IEnumerable<ITypeDescriptor>>) (p => p.GetTypeDescriptors())).Where<ITypeDescriptor>((Func<ITypeDescriptor, bool>) (t => t != null)).OrderBy<ITypeDescriptor, string>((Func<ITypeDescriptor, string>) (t => (string) PlatformTypeDescriptor.\u003C\u003Ec.lxGOtVCVrRt5sgo5qMH9((object) t))) : (IEnumerable<ITypeDescriptor>) new ITypeDescriptor[0];
    }

    public PlatformTypeDescriptor()
    {
      PlatformTypeDescriptor.mnSsAQoJoSDHXUKRTg88();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PlatformTypeDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PlatformTypeDescriptor.UID = new Guid((string) PlatformTypeDescriptor.UOdJLJoJBSa6NjqXpBPL(-1824388195 ^ -1824484647));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 2:
            PlatformTypeDescriptor.mnSsAQoJoSDHXUKRTg88();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object UOdJLJoJBSa6NjqXpBPL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object ffDocvoJW5bBoSgSymHu([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool YUyulNoMznvxpO5PDaQ6() => PlatformTypeDescriptor.orsHfRoMcopJEALYYkDC == null;

    internal static PlatformTypeDescriptor FfvHvIoJFLGYIpO8pT2e() => PlatformTypeDescriptor.orsHfRoMcopJEALYYkDC;

    internal static void mnSsAQoJoSDHXUKRTg88() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

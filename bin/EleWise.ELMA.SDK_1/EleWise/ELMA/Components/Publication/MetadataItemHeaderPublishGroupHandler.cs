// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.Publication.MetadataItemHeaderPublishGroupHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints.Publication;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Publication;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components.Publication
{
  /// <summary>
  /// Сервис для публикации объектов, метаданные которых хранятся в MetadataItemHeader
  /// </summary>
  [Component(Type = ComponentType.Server, Order = 100)]
  internal class MetadataItemHeaderPublishGroupHandler : IPublishGroupHandler
  {
    private readonly MetadataItemManager metadataItemManager;
    private static MetadataItemHeaderPublishGroupHandler P2VjVAfEbyjdCfIKhTfD;

    /// <summary>Ctor</summary>
    /// <param name="metadataItemManager">Менеджер элементов метаданных</param>
    public MetadataItemHeaderPublishGroupHandler(MetadataItemManager metadataItemManager)
    {
      MetadataItemHeaderPublishGroupHandler.pEnbBHfEEefKUvbdUOyP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.metadataItemManager = metadataItemManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>
    /// <inheritdoc />
    /// </summary>
    public PublishDataResult Publish(ReferenceOnEntity[] data, string comment)
    {
      int num1 = 6;
      long[] array;
      IEnumerable<ReferenceOnEntity> source;
      Guid metadataItemHeaderTypeUid;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_14;
          case 2:
            num1 = 8;
            continue;
          case 3:
            if (array.Length != 0)
            {
              num1 = 2;
              continue;
            }
            goto label_14;
          case 4:
            // ISSUE: reference to a compiler-generated method
            source = ((IEnumerable<ReferenceOnEntity>) data).Where<ReferenceOnEntity>((Func<ReferenceOnEntity, bool>) (x => MetadataItemHeaderPublishGroupHandler.\u003C\u003Ec__DisplayClass2_0.KNlJHW8lngZ0I0hsgFLF((object) x) == metadataItemHeaderTypeUid));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 7 : 6;
            continue;
          case 5:
            metadataItemHeaderTypeUid = InterfaceActivator.UID<IMetadataItemHeader>();
            num1 = 4;
            continue;
          case 6:
            num1 = 5;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated method
            array = source.Select<ReferenceOnEntity, long>((Func<ReferenceOnEntity, long>) (x => MetadataItemHeaderPublishGroupHandler.\u003C\u003Ec.STEAkw8l1V6tjeQbIhD2((object) x))).ToArray<long>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 3 : 3;
            continue;
          case 8:
            goto label_2;
          default:
            goto label_12;
        }
      }
label_2:
      PublishDataResult publishDataResult1;
      try
      {
        MetadataPublishResult metadataPublishResult = this.metadataItemManager.Publish(comment, array);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              PublishDataResult publishDataResult2 = new PublishDataResult((IList<ReferenceOnEntity>) source.ToList<ReferenceOnEntity>());
              MetadataItemHeaderPublishGroupHandler.FQK8VKfEQEH4kWmfsV6E((object) publishDataResult2, true);
              publishDataResult2.NeedRestart = MetadataItemHeaderPublishGroupHandler.L2lMyZfEC9tj37ITJ2CB((object) metadataPublishResult);
              publishDataResult1 = publishDataResult2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            default:
              goto label_12;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              MetadataItemHeaderPublishGroupHandler.Cyn5PmfEulHogFZmZF4R(MetadataItemHeaderPublishGroupHandler.BP6gLgfEvOudqDBH09Ac(), MetadataItemHeaderPublishGroupHandler.qoYqL3fEZVgeCSLk19nF(MetadataItemHeaderPublishGroupHandler.PDBMTJfE8QhNg97YNaBd(-53329496 >> 4 ^ -3669730)), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_12;
            default:
              List<string> errorMessages = new List<string>();
              object obj1 = MetadataItemHeaderPublishGroupHandler.esEpqrfEId30Qb5XUwgL((object) ex);
              object obj2 = MetadataItemHeaderPublishGroupHandler.PDBMTJfE8QhNg97YNaBd(1597012150 ^ 1596993940);
              object obj3 = MetadataItemHeaderPublishGroupHandler.s8VNCPfEVCMB1sdYPQH9((object) ex);
              object obj4 = obj3 != null ? MetadataItemHeaderPublishGroupHandler.esEpqrfEId30Qb5XUwgL(obj3) : (object) null;
              errorMessages.Add((string) obj1 + (string) obj2 + (string) obj4);
              PublishDataResult publishDataResult3 = new PublishDataResult(errorMessages: (IList<string>) errorMessages);
              MetadataItemHeaderPublishGroupHandler.FQK8VKfEQEH4kWmfsV6E((object) publishDataResult3, false);
              publishDataResult1 = publishDataResult3;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 2;
              continue;
          }
        }
      }
label_12:
      return publishDataResult1;
label_14:
      PublishDataResult publishDataResult4 = new PublishDataResult();
      publishDataResult4.IsSuccess = true;
      MetadataItemHeaderPublishGroupHandler.Ifdp4hfEfMOOhWoMtEKi((object) publishDataResult4, false);
      return publishDataResult4;
    }

    internal static void pEnbBHfEEefKUvbdUOyP() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool M9mjDWfEhEURiRYuZU5P() => MetadataItemHeaderPublishGroupHandler.P2VjVAfEbyjdCfIKhTfD == null;

    internal static MetadataItemHeaderPublishGroupHandler LLyQ99fEGCqNEJtlDS1M() => MetadataItemHeaderPublishGroupHandler.P2VjVAfEbyjdCfIKhTfD;

    internal static void Ifdp4hfEfMOOhWoMtEKi([In] object obj0, bool value) => ((PublishDataResult) obj0).NeedRestart = value;

    internal static void FQK8VKfEQEH4kWmfsV6E([In] object obj0, bool value) => ((PublishDataResult) obj0).IsSuccess = value;

    internal static bool L2lMyZfEC9tj37ITJ2CB([In] object obj0) => ((MetadataPublishResult) obj0).NeedRestart;

    internal static object BP6gLgfEvOudqDBH09Ac() => (object) Logger.Log;

    internal static object PDBMTJfE8QhNg97YNaBd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object qoYqL3fEZVgeCSLk19nF([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void Cyn5PmfEulHogFZmZF4R([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object esEpqrfEId30Qb5XUwgL([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static object s8VNCPfEVCMB1sdYPQH9([In] object obj0) => (object) ((Exception) obj0).InnerException;
  }
}

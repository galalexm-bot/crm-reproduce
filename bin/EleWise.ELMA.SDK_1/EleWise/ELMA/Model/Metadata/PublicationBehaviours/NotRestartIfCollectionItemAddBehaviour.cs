// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.PublicationBehaviours.NotRestartIfCollectionItemAddBehaviour
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.PublicationBehaviours
{
  /// <summary>
  /// Расширитель поведения публикации, не требующий перезапуска при добавлении элемента в коллекцию метаданных
  /// </summary>
  public sealed class NotRestartIfCollectionItemAddBehaviour : IPublicationBehaviourChecker
  {
    internal static NotRestartIfCollectionItemAddBehaviour xOpmR0bru6yG83o5iuU2;

    /// <inheritdoc />
    public PublicationType Check(CheckType action, object oldValue, object newValue)
    {
      int num1 = 3;
      Dictionary<Guid, IMetadata> dictionary1;
      Dictionary<Guid, IMetadata>.Enumerator enumerator;
      Type type;
      PublicationType publicationType1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_11;
          case 2:
            if (action == CheckType.Change)
            {
              // ISSUE: type reference
              type = oldValue.GetType().GetInterface(NotRestartIfCollectionItemAddBehaviour.S9cbOWbrSCp9FhlMGUuc(__typeref (IList<>)).FullName);
              num1 = 12;
              continue;
            }
            num1 = 9;
            continue;
          case 3:
            if (action != CheckType.Create)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 2;
              continue;
            }
            goto label_9;
          case 4:
            Dictionary<Guid, IMetadata> dictionary2 = list1.OfType<IMetadata>().ToDictionary<IMetadata, Guid>(new Func<IMetadata, Guid>(MetadataSoftPublishHelper.GetMetadataUid));
            dictionary1 = list2.OfType<IMetadata>().ToDictionary<IMetadata, Guid>(new Func<IMetadata, Guid>(MetadataSoftPublishHelper.GetMetadataUid));
            enumerator = dictionary2.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 4 : 7;
            continue;
          case 5:
          case 8:
          case 9:
          case 14:
            goto label_12;
          case 6:
            if (!(oldValue is IList list1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 4 : 14;
              continue;
            }
            goto case 10;
          case 7:
            try
            {
label_31:
              if (enumerator.MoveNext())
                goto label_40;
              else
                goto label_32;
label_27:
              KeyValuePair<Guid, IMetadata> current;
              int num2;
              while (true)
              {
                IMetadata metadata;
                PublicationType publicationType2;
                switch (num2)
                {
                  case 1:
                    publicationType1 = PublicationType.Restart;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 8;
                    continue;
                  case 2:
                    publicationType1 = PublicationType.Delta;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 11 : 0;
                    continue;
                  case 3:
                    if (!dictionary1.TryGetValue(current.Key, out metadata))
                    {
                      num2 = 4;
                      continue;
                    }
                    goto case 7;
                  case 4:
                  case 5:
                    publicationType1 = PublicationType.Restart;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 12 : 6;
                    continue;
                  case 6:
                    goto label_40;
                  case 7:
                    publicationType2 = NotRestartIfCollectionItemAddBehaviour.i8STyibrRFa4K5qIj5t5((object) current.Value, (object) metadata);
                    num2 = 13;
                    continue;
                  case 8:
                  case 11:
                  case 12:
                    goto label_13;
                  case 9:
                    goto label_3;
                  case 10:
                    goto label_31;
                  case 13:
                    if (publicationType2 == PublicationType.Restart)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 1;
                      continue;
                    }
                    break;
                }
                if (publicationType2 == PublicationType.Delta)
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 1;
                else
                  goto label_31;
              }
label_32:
              num2 = 9;
              goto label_27;
label_40:
              current = enumerator.Current;
              num2 = 3;
              goto label_27;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 10:
            if (newValue is IList list2)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            }
            goto label_12;
          case 11:
label_3:
            if (NotRestartIfCollectionItemAddBehaviour.qA96axbrqiZNNi5B7Rku((object) list2) != NotRestartIfCollectionItemAddBehaviour.qA96axbrqiZNNi5B7Rku((object) list1))
            {
              num1 = 16;
              continue;
            }
            goto label_17;
          case 12:
            if (!NotRestartIfCollectionItemAddBehaviour.iCbalnbriyjVUUQvCRFh(type, (Type) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 3 : 8;
              continue;
            }
            goto case 6;
          case 13:
            goto label_9;
          case 15:
            if (!((IEnumerable<object>) list1).SequenceEqual<object>((IEnumerable<object>) list2))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 5 : 4;
              continue;
            }
            goto label_11;
          case 16:
            goto label_16;
          default:
            if (!typeof (IMetadata).IsAssignableFrom(type.GetGenericArguments()[0]))
            {
              num1 = 15;
              continue;
            }
            goto case 4;
        }
      }
label_9:
      return PublicationType.Delta;
label_11:
      return PublicationType.Soft;
label_12:
      return PublicationType.Restart;
label_13:
      return publicationType1;
label_16:
      return PublicationType.Delta;
label_17:
      return PublicationType.Soft;
    }

    public NotRestartIfCollectionItemAddBehaviour()
    {
      NotRestartIfCollectionItemAddBehaviour.UU8rrEbrKsdvcq6H8XDC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type S9cbOWbrSCp9FhlMGUuc([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool iCbalnbriyjVUUQvCRFh([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static PublicationType i8STyibrRFa4K5qIj5t5([In] object obj0, [In] object obj1) => MetadataSoftPublishHelper.IsEqualsObject(obj0, obj1);

    internal static int qA96axbrqiZNNi5B7Rku([In] object obj0) => ((ICollection) obj0).Count;

    internal static bool w7WoT4brIMCm92Veybba() => NotRestartIfCollectionItemAddBehaviour.xOpmR0bru6yG83o5iuU2 == null;

    internal static NotRestartIfCollectionItemAddBehaviour wMVYyYbrVn3FUPmtg88k() => NotRestartIfCollectionItemAddBehaviour.xOpmR0bru6yG83o5iuU2;

    internal static void UU8rrEbrKsdvcq6H8XDC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

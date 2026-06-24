// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.AbstractPersistentCollectionExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Collection;
using System.Collections;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components
{
  /// <summary>
  /// Точка расширения для полчения оригинальной коллекции из AbstractPersistentCollection
  /// </summary>
  [Component]
  internal class AbstractPersistentCollectionExtension : IOriginalCollectionExtension
  {
    private static AbstractPersistentCollectionExtension G02UN2fGluJHyva6g2De;

    /// <inheritdoc />
    public bool Can(object obj) => this.GetCollection(obj) != null;

    /// <inheritdoc />
    public IEnumerable OriginalItems(object obj) => this.GetCollection(obj);

    private IEnumerable GetCollection(object obj)
    {
      int num = 1;
      IEnumerable storedSnapshot;
      IInheritedSet inheritedSet;
      AbstractPersistentCollection persistentCollection;
      while (true)
      {
        switch (num)
        {
          case 1:
            persistentCollection = obj as AbstractPersistentCollection;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            if (inheritedSet != null)
            {
              num = 5;
              continue;
            }
            goto case 6;
          case 4:
            storedSnapshot = persistentCollection.StoredSnapshot as IEnumerable;
            num = 9;
            continue;
          case 5:
            persistentCollection = AbstractPersistentCollectionExtension.PRIoRHfG5aVinBkGeIxG((object) inheritedSet) as AbstractPersistentCollection;
            num = 7;
            continue;
          case 6:
          case 7:
            if (persistentCollection == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 2;
              continue;
            }
            goto case 4;
          case 8:
            goto label_2;
          case 9:
            if (storedSnapshot != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 8 : 8;
              continue;
            }
            goto label_3;
          case 10:
            inheritedSet = obj as IInheritedSet;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 3;
            continue;
          default:
            if (persistentCollection != null)
            {
              num = 6;
              continue;
            }
            goto case 10;
        }
      }
label_2:
      return storedSnapshot;
label_3:
      return (IEnumerable) null;
    }

    public AbstractPersistentCollectionExtension()
    {
      AbstractPersistentCollectionExtension.p8I7JZfGjNxxdJ5V4JbK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool OpKaFyfGrCbPnPpI5hCH() => AbstractPersistentCollectionExtension.G02UN2fGluJHyva6g2De == null;

    internal static AbstractPersistentCollectionExtension UQXH8tfGgq8A5Cm7WjPt() => AbstractPersistentCollectionExtension.G02UN2fGluJHyva6g2De;

    internal static object PRIoRHfG5aVinBkGeIxG([In] object obj0) => (object) ((IInheritedSet) obj0).GetSourceSet();

    internal static void p8I7JZfGjNxxdJ5V4JbK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

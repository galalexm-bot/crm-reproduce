// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.CollectionDebugView`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EleWise.ELMA.Model.Transformations
{
  internal sealed class CollectionDebugView<T> where T : class
  {
    private ICollection<T> collection;
    internal static object aUjbZeWLrhddGpDYRi5t;

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public T[] Items
    {
      get
      {
        int num = 1;
        T[] array;
        while (true)
        {
          switch (num)
          {
            case 1:
              array = new T[this.collection.Count];
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            default:
              this.collection.CopyTo(array, 0);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 2;
              continue;
          }
        }
label_4:
        return array;
      }
    }

    public CollectionDebugView(ICollection<T> collection)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.collection = collection != null ? collection : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317749368));
    }

    internal static bool HS8as1WLgjVgXkLldejZ() => CollectionDebugView<T>.aUjbZeWLrhddGpDYRi5t == null;

    internal static object Uv74ufWL53a2V4LdD4tN() => CollectionDebugView<T>.aUjbZeWLrhddGpDYRi5t;
  }
}

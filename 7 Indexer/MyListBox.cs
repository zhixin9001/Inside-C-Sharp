using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Indexer
{
  class MyListBox
  {
    protected ArrayList data = new ArrayList();

    public object this[int idx]
    {
      get
      {
        if(idx>-1&&idx<data.Count)
        {
          return (data[idx]);
        }else
        {
          return null;
        }
      }
      set
      {
        if(idx>-1&&idx<data.Count)
        {
          data[idx] = value;
        }
        else  if(idx==data.Count)
        {
          data.Add(value);
        }
        else
        {

        }
      }
    }
  }
}

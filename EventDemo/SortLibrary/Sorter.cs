using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLibrary
{
    //public delegate bool Swapable(int i, int j);

    public class Sorter
    {
        public void Sort(int[] ar, Func<int, int, bool> swapable)
        {
            for (int i = 0; i < ar.Length - 1; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    //if (ar[i] > ar[j])
                    if (swapable(ar[i], ar[j]))
                    {
                        int t = ar[i];
                        ar[i] = ar[j];
                        ar[j] = t;
                    }
                }

                OnInnerEndReached(i);
            }
        }

        #region InnerEndReached event things for C# 3.0
public event EventHandler<InnerEndReachedEventArgs> InnerEndReached;

protected virtual void OnInnerEndReached(InnerEndReachedEventArgs e)
{
	if (InnerEndReached != null)
		InnerEndReached(this, e);
}

private InnerEndReachedEventArgs OnInnerEndReached(int i )
{
	InnerEndReachedEventArgs args = new InnerEndReachedEventArgs(i );
    OnInnerEndReached(args);

    return args;
}

private InnerEndReachedEventArgs OnInnerEndReachedForOut()
{
	InnerEndReachedEventArgs args = new InnerEndReachedEventArgs();
    OnInnerEndReached(args);

    return args;
}

public class InnerEndReachedEventArgs : EventArgs
{
	public int I { get; set;} 

	public InnerEndReachedEventArgs()
    {
	}
	
	public InnerEndReachedEventArgs(int i )
    {
		I = i; 
	}
}
#endregion

    }
}

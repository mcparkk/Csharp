using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleLibrary
{
    public class Person
    {
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public void IncreaseAge()
        {
            int oldAge = Age;

            AgeChangingEventArgs args = new AgeChangingEventArgs();
            args.CurrentAge = Age;
            args.NewAge = Age + 1;
            OnAgeChanging(args);
            if (args.Cancel)
                return;

            Age++;

            OnAgeChanged(oldAge, Age);
        }

        #region AgeChanged event things for C# 3.0
        public event EventHandler<AgeChangedEventArgs> AgeChanged;

        protected virtual void OnAgeChanged(AgeChangedEventArgs e)
        {
            if (AgeChanged != null)
                AgeChanged(this, e);
        }

        private AgeChangedEventArgs OnAgeChanged(int oldAge, int newAge)
        {
            AgeChangedEventArgs args = new AgeChangedEventArgs(oldAge, newAge);
            OnAgeChanged(args);

            return args;
        }

        private AgeChangedEventArgs OnAgeChangedForOut()
        {
            AgeChangedEventArgs args = new AgeChangedEventArgs();
            OnAgeChanged(args);

            return args;
        }

        public class AgeChangedEventArgs : EventArgs
        {
            public int OldAge { get; set; }
            public int NewAge { get; set; }

            public AgeChangedEventArgs()
            {
            }

            public AgeChangedEventArgs(int oldAge, int newAge)
            {
                OldAge = oldAge;
                NewAge = newAge;
            }
        }
        #endregion

        #region AgeChanging event things for C# 3.0
public event EventHandler<AgeChangingEventArgs> AgeChanging;

protected virtual void OnAgeChanging(AgeChangingEventArgs e)
{
	if (AgeChanging != null)
		AgeChanging(this, e);
}

private AgeChangingEventArgs OnAgeChanging(int currentAge  , int newAge  , bool cancel )
{
	AgeChangingEventArgs args = new AgeChangingEventArgs(currentAge  , newAge  , cancel );
    OnAgeChanging(args);

    return args;
}

private AgeChangingEventArgs OnAgeChangingForOut()
{
	AgeChangingEventArgs args = new AgeChangingEventArgs();
    OnAgeChanging(args);

    return args;
}

public class AgeChangingEventArgs : EventArgs
{
	public int CurrentAge { get; set;}  
public int NewAge { get; set;}  
public bool Cancel { get; set;} 

	public AgeChangingEventArgs()
    {
	}
	
	public AgeChangingEventArgs(int currentAge  , int newAge  , bool cancel )
    {
		CurrentAge = currentAge;  
NewAge = newAge;  
Cancel = cancel; 
	}
}
#endregion
    }
}

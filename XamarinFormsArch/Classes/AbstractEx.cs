using System;
namespace XamarinFormsArch.Classes
{
    public class AbstractEx
    {
        public class ConsumerClass : DoSomething
        {
            public override void ImportantMethod()
            {
                throw new NotImplementedException();
            }

            public override void ImportantMethos()
            {
                throw new NotImplementedException();
            }


        }


        public interface IProvider
        {
            void GetSomething();
            void GetSomeOtherThins();
        }

        public abstract class DoSomething
        {
            public void DoNothing()
            {
                //business logic
            }

            public abstract void ImportantMethos();
            public abstract void ImportantMethod(); 
        }
    }
}

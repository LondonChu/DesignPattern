namespace DesignPattern
{
    class Pattern_Singleton_單例模式
    {
        public class Singleton
        {
            private static volatile Singleton INSTANCE = null;

            // Private constructor suppresses 
            // default public constructor
            private Singleton() 
            { 
            
            }

            //Thread safe and performance  promote 線程安全和性能提升
            public static Singleton GetInstance()
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new Singleton();
                }
                return INSTANCE;
            }
        }
    }
}

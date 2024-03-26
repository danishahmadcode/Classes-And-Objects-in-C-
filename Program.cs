namespace classAndObject{
    class RegularClass{
        public RegularClass(int x,int y){
            Console.WriteLine(x+y);
        }
    }

    abstract class AbstractExample{
        abstract public void force();
    }
    partial class PartialExample : AbstractExample{
        public override void force(){
            Console.WriteLine("Abstract method inside ParExample class");
            }
            public void firstPar(){
                Console.WriteLine("From 1st partial method");
            }
    }
    partial class PartialExample{
        public void secondPar(){
            Console.WriteLine("From wnd partial method");
        }
    }
    sealed class SealedExample : AbstractExample{
        public override void force(){
            Console.WriteLine("Abstract method inside SealedExample class");
        }
        public void message(){
            Console.WriteLine("Method from SealedExample class");
        }
    }
    static class StaticExample{
        public static void message(){
            Console.WriteLine("Method from StaticExample class");
        }
    }
    class MainClass{
        static void Main(){
            StaticExample.message();
            RegularClass regularClassObj = new RegularClass(10,40);
            PartialExample partialClassObj = new PartialExample();
            partialClassObj.force();
            partialClassObj.firstPar();
            partialClassObj.secondPar();
            SealedExample sealedClassObj = new SealedExample();
            sealedClassObj.force();
            sealedClassObj.message();
            
        }
    }
}
using System;
using static DesignPattern.Pattern_Adapter_轉接器模式;
using static DesignPattern.Pattern_Decorator_裝飾模式;
using static DesignPattern.Pattern_Observer_觀察者模式;
using static DesignPattern.Pattern_Adapter_轉接器模式;
using static DesignPattern.ConnectAdapter;

namespace DesignPattern_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pattern_Observer_觀察者模式
            //Console.WriteLine("Hello World!");
            //Subject mySubject = new Subject();
            //IObserver myObserver1 = new Observer1();
            //IObserver myObserver2 = new Observer2();

            //// register observers
            //mySubject.Register(myObserver1);
            //mySubject.Register(myObserver2);

            //mySubject.Notify("message 1");
            //mySubject.Notify("message 2");
            #endregion

            #region Pattern_Decorator_裝飾模式
            //// 情境: 每個玩家都有作業的方法, 但此時需要在此方法加工. 但加工的方法很沒有規則性

            //// 創建玩家
            //IComponet player1 = new Player1();
            //IComponet player2 = new Player2();
            //// 原目的
            //player1.Operation();
            //player2.Operation();

            //// 玩家修飾各種裝備
            //DecoratorObject decorator = new Decorator1ForPlayer(player1);
            //DecoratorObject decorator2 = new Decorator2ForPlayer(player1);

            //decorator.Operation(); // 玩家一 搜秀
            //decorator2.Operation(); // 玩家二 搜秀

            //Console.Read();
            #endregion

            #region Pattern_Adapter_轉接器模式

            /// <summary>
            /// 客户端，客户想要把2个孔的插头 转变成三个孔的插头，这个转变交给适配器就好
            /// 既然适配器需要完成这个功能，所以它必须同时具体2个孔插头和三个孔插头的特征
            /// </summary>

            // 现在客户端可以通过电适配要使用2个孔的插头了
            //IThreeHole threehole = new PowerAdapter();
            //threehole.Request();
            //Console.ReadLine();

            //Player a = new Forwards("a");
            //a.Attack();
            //Player c = new Guards("c");
            //c.Attack();

            ////Player b = new Center("b");
            //Player b = new TranslatorAdapter("b");
            //b.Attack();
            //b.Defense();

            //Device
            //Device device = new RS232("device");
            //device.Connect();
            //Device deviceSpecial = new Adapter("deviceSpecial");
            //deviceSpecial.Connect();
            //Console.Read();
            #endregion
        }
    }
}

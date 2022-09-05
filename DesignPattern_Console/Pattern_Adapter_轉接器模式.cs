using System;

namespace DesignPattern
{
    class Pattern_Adapter_轉接器模式
    {
        public abstract class Player
        {
            protected string name;
            public Player(string name)
            {
                this.name = name;
            }

            public abstract void Attack();
            public abstract void Defense();
        }

        public class Forwards : Player
        {
            public Forwards(string name) : base(name)
            {
            
            }

            public override void Attack()
            {
                Console.WriteLine($"Forwards {name} Attack");
            }

            public override void Defense()
            {
                Console.WriteLine($"Forwards {name} Defense");
            }
        }

        public class Center: Player
        {
            public Center(string name) : base(name)
            {

            }

            public override void Attack()
            {
                Console.WriteLine($"Center {name} Attack");
            }

            public override void Defense()
            {
                Console.WriteLine($"Center {name} Defense");
            }
        }

        public class Guards : Player
        {
            public Guards(string name) : base(name)
            {

            }

            public override void Attack()
            {
                Console.WriteLine($"Guards {name} Attack");
            }

            public override void Defense()
            {
                Console.WriteLine($"Guards {name} Defense");
            }
        }

        public class ForeignCenter
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public void 進攻()
            {
                Console.WriteLine($"外籍中鋒{name}進攻");
            }

            public void 防守()
            {
                Console.WriteLine($"外籍中鋒{name}防守");
            }
        }

        //Adapter
        public class TranslatorAdapter : Player
        {
            private ForeignCenter foreignCenter = new ForeignCenter();
            
            public TranslatorAdapter(string name) : base(name)
            {
                foreignCenter.Name = name;
            }

            public override void Attack()
            {
                foreignCenter.進攻();
            }

            public override void Defense()
            {
                foreignCenter.防守();
            }
        }


        ///// 这里以插座和插头的例子来诠释适配器模式
        ///// 现在我们买的电器插头是2个孔，但是我们买的插座只有3个孔的
        ///// 这是我们想把电器插在插座上的话就需要一个电适配器

        ///// <summary>
        ///// 三个孔的插头，也就是适配器模式中的目标角色
        ///// </summary>
        //public interface IThreeHole
        //{
        //    void Request();
        //}

        ///// <summary>
        ///// 两个孔的插头，源角色——需要适配的类
        ///// </summary>
        //public abstract class TwoHole
        //{
        //    public void SpecificRequest()
        //    {
        //        Console.WriteLine("我是兩個孔的插頭");
        //    }
        //}

        ///// <summary>
        ///// 适配器类，接口要放在类的后面
        ///// 适配器类提供了三个孔插头的行为，但其本质是调用两个孔插头的方法
        ///// </summary>
        //public class PowerAdapter : TwoHole, IThreeHole
        //{
        //    /// <summary>
        //    /// 实现三个孔插头接口方法
        //    /// </summary>
        //    public void Request()
        //    {
        //        // 调用两个孔插头方法
        //        this.SpecificRequest();
        //    }
        //}
    }

    public class ConnectAdapter
    {
        public abstract class Device
        {
            protected string name;
            public Device(string name)
            {
                this.name = name;
            }

            public abstract void Connect();
            public abstract void Disconnect();
        }

        public class RS232 : Device
        {
            public RS232(string name) : base(name)
            {

            }

            public override void Connect()
            {
                Console.WriteLine($"RS232 {name} Connect");
            }

            public override void Disconnect()
            {
                Console.WriteLine($"RS232 {name} Disconnect");
            }
        }

        public class Socket 
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public void 連線()
            {
                Console.WriteLine($"Socket{name}連線");
            }

            public void 斷線()
            {
                Console.WriteLine($"Socket{name}斷線");
            }
        }

        //Adapter
        public class Adapter : Device
        {
            private Socket socket = new Socket();

            public Adapter(string name) : base(name)
            {
                socket.Name = name;
            }

            public override void Connect()
            {
                socket.連線();
            }

            public override void Disconnect()
            {
                socket.斷線();
            }
        }
    }
}

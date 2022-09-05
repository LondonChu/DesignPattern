using System;

namespace DesignPattern
{
    class Pattern_Strategy_策略模式
    {
        //Ref : https://blog.csdn.net/BraveRunTo/article/details/119062572
        //1. Context（環境類）：環境類是使用演算法的角色，他在解決某個問題是可以採用多種策略。 在環境類中維持一個對抽象策略類的引用，用於定義所採用的策略。
        //2. Strategy（抽象策略類）：抽象策略類為所支持的演算法聲明了抽象方法，是所有策略類的父類，他可以是抽象類或者具體類，也可以是介面。
        //3. ConcreteStrategy（具體策略類）：具體抽象類實現了在抽象策略類中聲明的演算法，在運行時，具體策略類對象將覆蓋在環境類中定義的抽象策略類物件，使用一種具體的演算法實現某個業務的功能。
    }

    #region 1. 環境類 : 電影票類
    public class MovieTicket
    {
        private int _ticketMoney;
        private Discount _discount;
        public MovieTicket(int money)
        {
            _ticketMoney = money;
        }
        public void SetDiscount(string name)
        {
            Type type = Type.GetType($"DesignPattern.{name}");
            _discount = type == null? null:Activator.CreateInstance(type) as Discount;
        }
        public float Calculate()
        {
            return _discount.Calculate(_ticketMoney);
        }
    }
    #endregion

    #region 2. 抽象策略類 : 打折
    public abstract class Discount
    {
        public const string Name = "";
        public abstract float Calculate(int money);
    }
    #endregion

    #region 3. 具體策略類 : 兒童折扣10元、學生8折、VIP半折
    /// <summary>
    /// 兒童折扣10元
    /// </summary>
    public class ChildDiscount : Discount
    {
        public new const string Name = "ChildDiscount";
        public override float Calculate(int money)
        {
            if (money >= 20)
            {
                return money - 10;
            }
            return money;
        }
    }
    /// <summary>
    /// 學生8折
    /// </summary>
    public class StudentDiscount : Discount
    {
        public new const string Name = "StudentDiscount";
        public override float Calculate(int money)
        {
            return money * 0.8f;
        }
    }
    /// <summary>
    /// VIP半折
    /// </summary>
    public class VIPDiscount : Discount
    {
        public new const string Name = "VIPDiscount";
        public override float Calculate(int money)
        {
            return money * 0.5f;
        }
    }
    #endregion
}

using System;

namespace DesignPattern
{
    class Pattern_Decorator_裝飾模式
    {
		//interface IWindowObject
		//{
		//	void Draw(); // draws the object
		//	string GetDescription(); // returns a description of the object
		//}

		//class ControlComponent : IWindowObject
		//{
		//	public ControlComponent()
		//	{
		//	}

		//	public void Draw() // draws the object
		//	{
		//		Console.WriteLine("ControlComponent::draw()");
		//	}

		//	public string GetDescription() // returns a description of the object
		//	{
		//		return "ControlComponent::getDescription()";
		//	}
		//}

		//abstract class Decorator : IWindowObject
		//{
		//	protected IWindowObject _decoratedWindow = null; // the object being decorated

		//	public Decorator(IWindowObject decoratedWindow)
		//	{
		//		_decoratedWindow = decoratedWindow;
		//	}

		//	public virtual void Draw()
		//	{
		//		_decoratedWindow.Draw();
		//		Console.WriteLine("\tDecorator::draw() ");
		//	}

		//	public virtual string GetDescription() // returns a description of the object
		//	{
		//		return _decoratedWindow.GetDescription() + "\n\t" + "Decorator::getDescription() ";
		//	}
		//}

		//// the first decorator 
		//class DecorationA : Decorator
		//{
		//	public DecorationA(IWindowObject decoratedWindow) : base(decoratedWindow)
		//	{
		//	}

		//	public override void Draw()
		//	{
		//		base.Draw();
		//		DecorationAStuff();
		//	}

		//	private void DecorationAStuff()
		//	{
		//		Console.WriteLine("\t\tdoing DecorationA things");
		//	}

		//	public override string GetDescription()
		//	{
		//		return base.GetDescription() + "\n\t\tincluding " + this.ToString();
		//	}

		//}// end  class ConcreteDecoratorA : Decorator

		//class DecorationB : Decorator
		//{
		//	public DecorationB(IWindowObject decoratedWindow) : base(decoratedWindow)
		//	{
		//	}

		//	public override void Draw()
		//	{
		//		base.Draw();
		//		DecorationBStuff();
		//	}

		//	private void DecorationBStuff()
		//	{
		//		Console.WriteLine("\t\tdoing DecorationB things");
		//	}

		//	public override string GetDescription()
		//	{
		//		return base.GetDescription() + "\n\t\tincluding " + this.ToString();
		//	}

		//}// end  class DecorationB : Decorator

		//class DecorationC : Decorator
		//{
		//	public DecorationC(IWindowObject decoratedWindow) : base(decoratedWindow)
		//	{
		//	}

		//	public override void Draw()
		//	{
		//		base.Draw();
		//		DecorationCStuff();
		//	}

		//	private void DecorationCStuff()
		//	{
		//		Console.WriteLine("\t\tdoing DecorationC things");
		//	}

		//	public override string GetDescription()
		//	{
		//		return base.GetDescription() + "\n\t\tincluding " + this.ToString();
		//	}

		//}// end  class DecorationC : Decorator

		#region 1. 原服務 - 介面
		public interface IComponet //裝備
		{
			void Operation();
		}
		#endregion

		#region 2. 原服務 - 實作 :
		public class Player1 : IComponet
		{
			public void Operation()
			{
				Console.WriteLine("玩家一");
			}
		}

		public class Player2 : IComponet
		{
			public void Operation()
			{
				Console.WriteLine("玩家二");
			}
		}
		#endregion

		#region 3. 裝飾模組 - 抽象類 :
		public abstract class DecoratorObject : IComponet
		{
			protected IComponet _componet;

			public DecoratorObject(IComponet player)
			{
				this._componet = player;
			}

			// 讓外部可設置玩家
			abstract public void SetPlayer(IComponet setPlayer);

			public abstract void Operation();
		}
		#endregion

		#region 4. 裝飾模組 - 實作類 :
		public class Decorator1ForPlayer : DecoratorObject
		{

			public Decorator1ForPlayer(IComponet player) : base(player)
			{
			}

			public override void SetPlayer(IComponet setPlayer)
			{
				base._componet = setPlayer;
			}

			public override void Operation() // 使用同方法, 卻額外加工行為
			{
				Console.WriteLine("修飾裝備1: 手套+攻擊");
			}
		}

		public class Decorator2ForPlayer : DecoratorObject
		{

			public Decorator2ForPlayer(IComponet player) : base(player)
			{
			}

			public override void SetPlayer(IComponet setPlayer)
			{
				base._componet = setPlayer;
			}

			public override void Operation() // 使用同方法, 卻額外加工行為
			{
				Console.WriteLine("修飾裝備2: 行動速度+10");
			}
		}
		#endregion
	}
}

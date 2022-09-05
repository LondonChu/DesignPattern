using System;
using System.Collections;

namespace DesignPattern
{
    class Pattern_Observer_觀察者模式
    {
		// 1. 主題（Subject）： Subject 類提供了掛上和拆卸觀察者的介面，並且持有一序列的觀察者，還有如下函數：
		//(1) Attach - 增加一個新的觀察者到觀察者序列
		//(2) Detach - 從觀察者序列中刪除一個觀察者
		//(3) Notify - 當發生變化時，調用每一個觀察者的 Update 函數來通知它們。

		// 2. 觀察者（Observer）： Observer 類為所有的觀察者定義了一個更新介面，用以接收來自主題的更新通知，它是一個抽象類別，可以派生具體的觀察者：
		//(1) Update - 這是一個抽象函數，具體的觀察者會重載這個函數。

		// 實作上可能會用在儀器的連線清單，
		// 有連線就 Attach 到 List，
		// 沒有連線就從 List 中 Detach，
		// 若有訊息需發送至所有儀器，就可發 Notify Update 至所有觀察者資訊

		// IObserver --> interface for the observer
		public interface IObserver
		{
			// called by the subject to update the observer of any change
			// The method parameters can be modified to fit certain criteria
			void Update(string message);
		}

		// Observer1 --> Implements the IObserver
		public class Observer1 : IObserver
		{
			public void Update(string message)
			{
				Console.WriteLine("Observer1:" + message);
			}
		}

		// Observer2 --> Implements the IObserver
		public class Observer2 : IObserver
		{
			public void Update(string message)
			{
				Console.WriteLine("Observer2:" + message);
			}
		}

		public class Subject
		{
			// use array list implementation for collection of observers
			private ArrayList observers;

			// constructor
			public Subject()
			{
				observers = new ArrayList();
			}

			public void Register(IObserver observer)//註冊(Attach)
			{
				// if list does not contain observer, add
				if (!observers.Contains(observer))
				{
					observers.Add(observer);
				}
			}

			public void Deregister(IObserver observer)//解註冊(Detach)
			{
				// if observer is in the list, remove
				if (observers.Contains(observer))
				{
					observers.Remove(observer);
				}
			}

			public void Notify(string message)//廣播
			{
				// call update method for every observer
				foreach (IObserver observer in observers)
				{
					observer.Update(message);
				}
			}
		}

		// Test class
		//public class ObserverTester
		//{
		//	[STAThread]
		//	public static void Main()
		//	{
		//		Subject mySubject = new Subject();
		//		IObserver myObserver1 = new Observer1();
		//		IObserver myObserver2 = new Observer2();

		//		// register observers
		//		mySubject.Register(myObserver1);
		//		mySubject.Register(myObserver2);

		//		mySubject.Notify("message 1");
		//		mySubject.Notify("message 2");
		//	}
		//}

	}
}

 using System;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            new Control(new View(), new Model());
        }

        public class Model
        {
            public string Name { get; set; }
            public string Sex { get; set; }
            public int Age { get; set; }
            public double Height { get; set; }
            public double Weight { get; set; }
            public DateTime RecordTime { get; set; }
            public double BMI { get; set; }
        }

        public class View
        {
            public string Name => Console.ReadLine();
            public string Sex => Console.ReadLine();
            public int Age => int.Parse(Console.ReadLine());
            public double Height => double.Parse(Console.ReadLine());
            public double Weight => double.Parse(Console.ReadLine());
            public DateTime RecordTime { get; set; } = DateTime.Now;
            public Control Control { get; set; }
            public void ShowChartBMI()
            {
                Control.ShowChartBMI();
            }
        }

        public class Control
        {
            private View _view;
            private Model _model;

            public Control(View view, Model model)
            {
                _view = view;
                _view.Control = this;
                _model = model;

                WaitUserEnter();
                _view.ShowChartBMI();
            }

            public void WaitUserEnter()
            {
                Console.Write("請輸入姓名：");
                _model.Name = _view.Name;
                Console.Write("請輸入性別：");
                _model.Sex = _view.Sex;
                Console.Write("請輸入年齡：");
                _model.Age = _view.Age;
                Console.Write("請輸入身高(cm)：");
                _model.Height = _view.Height;
                Console.Write("請輸入體重(kg)：");
                _model.Weight = _view.Weight;
                _model.RecordTime = _view.RecordTime;
                _model.BMI = _model.Weight / Math.Pow(_model.Height / 100, 2);
            }

            public void ShowChartBMI()
            {
                Console.WriteLine($"{_model.RecordTime} {_model.Name}的BMI為：{ _model.BMI}");
                if (_model.Sex == "girl")
                {
                    Function(18.5, 24, 27);
                }
                else
                {
                    Function(17, 24, 27);
                }
            }
            public void Function(double l, double c, double u)
            {
                if (_model.BMI < l)
                {
                    Console.WriteLine("過輕");
                }
                else if (l <= _model.BMI && _model.BMI < c)
                {
                    Console.WriteLine("正常");
                }
                else if (c <= _model.BMI && _model.BMI < u)
                {
                    Console.WriteLine("過重");
                }
                else
                {
                    Console.WriteLine("肥胖");
                }
            }
        }
    }
}

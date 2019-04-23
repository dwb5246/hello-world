using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {

            Decimal a = 123m;

            Console.WriteLine(a.ToString("0.##"));
            //strutc.StructTestFun();

            //Event作用：只是管理了权限，保证外部不能直接调用
            //委托是一种类型，事件是委托的实例，不可以被外部调用
            //{
            //    Cat cat = new Cat();
            //    cat.CatMiaoDeletage += new Dog().wang;
            //    cat.CatMiaoDeletage += new Child().cry;

            //    cat.CatMiaoDeletage += null ;//可以为空
            //    cat.CatMiaoDeletage.Invoke();//可以直接被外部调用
            //    cat.MiaoDeletage();
            //}

            //{
            //    Cat cat = new Cat();
            //    cat.CatMiaoEvent += new Dog().wang;
            //    cat.CatMiaoEvent += new Child().cry;
            //    //cat.CatMiaoEvent = null;//事件不可以为空
            //    //cat.CatMiaoEvent.Invoke();//不可以被外部调用
            //    cat.MiaoDeletage();
            //}


            Console.WriteLine("按任意键可退出！");
            Console.ReadKey();
        }
    }
}

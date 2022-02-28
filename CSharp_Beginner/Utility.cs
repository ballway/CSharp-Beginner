using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Beginner
{
    partial class MyClass
    {
        public void Method_01_SayHello()
        {
            MessageBox.Show("安安");
            Method_02_SayPrivate();
        }

        private void Method_02_SayPrivate()
        {
            MessageBox.Show("我是private方法，安安");
        }
    }

    class my_Static_Test
    {
        static public int StaticVar;        //  static 變數，其他form可直接存取，本來就有實體所以不用new
        public int NonStaticVar;           // 非static變數，其他form需要先new才可存取，要注意變數生命週期
    }

     class Member
    {
        public string name;
        public int age;
    }

    public enum Calculaor_Action
    {
        //  初始狀態
        ClearUp =0,

        //  運算子
        Operator_Add = 11,                    // 加
        Operator_Substract = 12,          // 減
        Operator_Multiply = 13,            // 乘
        Operator_Divide = 14,               // 除
        Operator_Remainder = 15,      // 餘

        //  進行運算
        Equal = 20
    }

    struct Student_Grade
    {
        public string Name;                // 姓名
        public double Chinese;          // 國文
        public double English;           // 英文
        public double Math;              // 數學

        public double Avg;                 // 平均分數
    }

    struct Employee
    {
        public string name;
        public int age;
    }

    public static class Guess
    {
        internal static Frm13_1_GuessForm Main_Guess_Form;

        public static int ans;
        public static int try_guess;
        public static string show_result = "";
    }

    public static class Compound
    {
        public static string start_money="";
        public static string rate="";
        public static string times = "";
        public static string total_return = "";
    }

}

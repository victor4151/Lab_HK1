using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_HkHello
{
    internal class Utility
    {
        public struct Student
        {
            //結構欄位不用new
            // public string Name;
            //  public int Age;

            //有屬性關係所以在使用時需要建立實體
            //資料型態
            public string Name { get; set; }
            public int Chi { get; set; }
            public int Eng { get; set; }
            public int Mat { get; set; }


            //下方計算方式類似方法
            //欄位名稱
            public Student(string StudentName, int StudentChi, int StudentEng, int StudentMat)
            {
                Name = StudentName;
                Chi = StudentChi;
                Eng = StudentEng;
                Mat = StudentMat;
            }
            public enum UserRode //M18列舉
            {
                Admin = 1, //設定列舉成員都使用逗號區分
                User = 2,
            }
        }
        //public struct Score
        //{
        //    public string Name;
        //    public decimal Price;

        //}

    }
}

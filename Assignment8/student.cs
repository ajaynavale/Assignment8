﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment8
{
    public class student
    {
        private int rollno;
        private string name;
        private static int count;
        private int s1, s2, s3,Total,percentage;
        
        public student(string name, int s1, int s2, int s3)
        {
            count++;
            this.rollno = count;
            this.name = name;
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }
        public static string TotalCount()
        {
            return $"Total Count {count}";
        }

        public void Calculate()
        {
            Total = s1 + s2 + s3;
            percentage =Total/3;
        }
        public override string ToString()
        {
            return $"Roll no :{rollno} Name :{name} Total : {Total} Percentage : {percentage}";
        }
    }
}

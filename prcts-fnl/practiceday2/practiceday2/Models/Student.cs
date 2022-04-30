﻿using System;
using System.Collections.Generic;
using System.Text;

namespace practiceday2.Models
{
    class Student
    {
        private int _id;
        private double _point;
        public int Id { get; }
        public string Fullname { get; set; }
        public double Point 
        {
            get => _point;
            set
            {
                if (value>=0 && value<=100)
                {
                    _point = value;
                }
            }
        }
        public Student(string fullname, double point)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($" Id: {Id}\n Fullname: {Fullname}\n Point: {Point}");
        }

    }
}

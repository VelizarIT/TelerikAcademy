﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        //Field
        private string lab;

        //Constructor
        public LocalCourse(string name, string teacherName = null, IList<string> students = null, string lab = null)
            : base(name, teacherName, students)
        {
            this.Lab = lab;
        }

        //Property
        public string Lab
        {
            get { return this.lab; }
            set { this.lab = value; }
        }

        //Method
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { ");
            result.Append(base.ToString());

            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}

using System;

namespace SolidPrinciples.NoOpenClosed
{
    public class Principal
    {
        public string WhatToDo()
        {
            var todo = "Call You? ";
            var secondary = new Secondary();
            var answer = secondary.MyAnswer();
            return todo + answer;
        }
    }
}


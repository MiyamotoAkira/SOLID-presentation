﻿using System;

namespace SolidPrinciples.OpenClosed
{
    public class Terciary
    {
        public string WhatToDo()
        {
            var todo = "Give me your number: ";
            var secondary = new Secondary();
            var answer = secondary.MyAnswer();
            return todo + answer;
        }
    }
}


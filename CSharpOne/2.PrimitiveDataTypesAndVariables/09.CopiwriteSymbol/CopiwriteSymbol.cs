﻿using System;

// Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
// Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

class CopiwriteSymbol
{
    static void Main(string[] args)
    {
        char copyRight = (char)169; //the copyright symbol
        Console.OutputEncoding = Encoding.UTF8; //switch to UTF8 encoding
        byte space = 3; //begin with 3 spaces
        for (int i = 0; i < 3; i++)
        {
            //spaces on the left
            for (int spacesLeft = 0; spacesLeft < space; spacesLeft++)
            {
                Console.Write(" ");
            }
            //print the symbol
            for (int printCR = 0; printCR <= i; printCR++)
            {
                Console.Write(copyRight);
            }
            //spaces on the right
            for (int spacesRight = 0; spacesRight < i; spacesRight++)
            {
                Console.Write(copyRight);
            }
            Console.WriteLine();
            space--;
        }
    }
}

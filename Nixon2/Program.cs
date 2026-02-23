/********************************************************************
*** NAME : Tyler Nixon
*** CLASS : CSc 346 – Object Oriented Programming
*** ASSIGNMENT : Assignment 2
*** DUE DATE : 02/23/2026
*** INSTRUCTOR : GAMRADT
*********************************************************************
*** DESCRIPTION : This file contains a simple test driver for the
***               Viking ADT. It demonstrates creating Viking objects
***               using default values, full argument values, and the
***               copy constructor. It also demonstrates the required
***               horizontal and vertical display methods. The
***               instructor will replace this file with a grading test
***               program during evaluation.
********************************************************************/
using VikingNS;

namespace VikingNS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Viking v1 = new Viking();
            v1.ViewH();

            Console.WriteLine();

            Viking v2 = new Viking("Ragnar", Global.Status.JARL, 250, Global.Weapon.SWORD, true);
            v2.ViewV();

            Console.WriteLine();

            Viking v3 = new Viking(v2);
            v3.ViewH();
        }
    }
}
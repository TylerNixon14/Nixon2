/********************************************************************
*** NAME : Tyler Nixon
*** CLASS : CSc 346 – Object Oriented Programming
*** ASSIGNMENT : Assignment 2
*** DUE DATE : 02/23/2026
*** INSTRUCTOR : GAMRADT
*********************************************************************
*** DESCRIPTION : Test driver for the Viking ADT. This program
***               creates a single Viking object using the
***               parameterized constructor and displays the object
***               using the vertical view method.
********************************************************************/
using VikingNS;

namespace VikingNS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Viking v = new Viking(
                "Ragnar",
                Global.Status.JARL,
                250,
                Global.Weapon.SWORD,
                true);

            v.ViewV();
        }
    }
}
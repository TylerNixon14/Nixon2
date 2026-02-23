/********************************************************************
*** NAME : Tyler Nixon
*** CLASS : CSc 346 – Object Oriented Programming
*** ASSIGNMENT : Assignment 2
*** DUE DATE : 02/23/2026
*** INSTRUCTOR : GAMRADT
*********************************************************************
*** DESCRIPTION : This file defines the Global static class used by
***               the Viking ADT. It contains enumerations for Viking
***               status and weapon types. These enumerations provide
***               controlled value sets used by the Viking class.
********************************************************************/
namespace VikingNS
{
    public static class Global
    {
        public enum Status
        {
            JARL,
            KARL,
            THRALL
        }

        public enum Weapon
        {
            AXE,
            SWORD
        }
    }
}


/********************************************************************
*** NAME : Tyler Nixon
*** CLASS : CSc 346 – Object Oriented Programming
*** ASSIGNMENT : Assignment 2
*** DUE DATE : 02/23/2026
*** INSTRUCTOR : GAMRADT
*********************************************************************
*** DESCRIPTION : This file defines the Viking Abstract Data Type
***               (ADT). The Viking class models a Viking warrior with
***               a Name, Status, Health, Weapon, and Shield. The class
***               implements the IView interface and provides both
***               horizontal and vertical output views. The class
***               supports default/parameterized construction using
***               default argument values and supports copying using a
***               copy constructor.
********************************************************************/
using System;

namespace VikingNS
{
    public class Viking : IView
    {
        public string Name { get; set; }
        public Global.Status Status { get; set; }
        public short Health { get; set; }
        public Global.Weapon Weapon { get; set; }
        public bool Shield { get; set; }

        /********************************************************************
        *** METHOD Viking
        *********************************************************************
        *** DESCRIPTION : Initializes a Viking object using either default
        ***               argument values or values passed by the caller.
        ***               This single constructor supports default,
        ***               parameterized, and full-property initialization.
        *** INPUT ARGS : name, status, health, weapon, shield
        *** OUTPUT ARGS : none
        *** IN/OUT ARGS : none
        *** RETURN : none (constructor)
        ********************************************************************/
        public Viking(
            string name = "Bjorn",
            Global.Status status = Global.Status.KARL,
            short health = 150,
            Global.Weapon weapon = Global.Weapon.AXE,
            bool shield = false)
        {
            Name = name;
            Status = status;
            Health = health;
            Weapon = weapon;
            Shield = shield;
        }

        /********************************************************************
        *** METHOD Viking
        *********************************************************************
        *** DESCRIPTION : Copy constructor. Creates a new Viking object
        ***               that is an exact copy of the original Viking.
        *** INPUT ARGS : original
        *** OUTPUT ARGS : none
        *** IN/OUT ARGS : none
        *** RETURN : none (constructor)
        ********************************************************************/
        public Viking(Viking original)
            : this(original.Name, original.Status, original.Health, original.Weapon, original.Shield)
        {
        }

        /********************************************************************
        *** METHOD ToTitleCase
        *********************************************************************
        *** DESCRIPTION : Converts an enum name string (e.g., "KARL") into
        ***               Title Case form (e.g., "Karl") for display output.
        *** INPUT ARGS : value
        *** OUTPUT ARGS : none
        *** IN/OUT ARGS : none
        *** RETURN : string titleValue
        ********************************************************************/
        private static string ToTitleCase(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return value;
            value = value.ToLowerInvariant();
            return char.ToUpperInvariant(value[0]) + value.Substring(1);
        }

        /********************************************************************
        *** METHOD ViewH
        *********************************************************************
        *** DESCRIPTION : Displays the Viking object information in a
        ***               horizontal, single-line format.
        *** INPUT ARGS : none
        *** OUTPUT ARGS : none
        *** IN/OUT ARGS : none
        *** RETURN : void
        ********************************************************************/
        public void ViewH()
        {
            Console.WriteLine("Name  Status  Health  Weapon Shield");
            Console.WriteLine($"{Name}  {ToTitleCase(Status.ToString())}  {Health}  {ToTitleCase(Weapon.ToString())}  {Shield}");
        }

        /********************************************************************
        *** METHOD ViewV
        *********************************************************************
        *** DESCRIPTION : Displays the Viking object information in a
        ***               vertical, multi-line format.
        *** INPUT ARGS : none
        *** OUTPUT ARGS : none
        *** IN/OUT ARGS : none
        *** RETURN : void
        ********************************************************************/
        public void ViewV()
        {
            Console.WriteLine($"Name:  {Name}");
            Console.WriteLine($"Status:  {ToTitleCase(Status.ToString())}");
            Console.WriteLine($"Health:  {Health}");
            Console.WriteLine($"Weapon:  {ToTitleCase(Weapon.ToString())}");
            Console.WriteLine($"Shield:  {Shield}");
        }
    }
}
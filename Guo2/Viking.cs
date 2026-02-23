using System;
using System.Net;
using System.Reflection.Metadata;


namespace VikingNS
{
    public class Viking : IView
    {
        public string Name { get; set; }
        public Global.Status Status { get; set; }
        public short Health { get; set; }
        public Global.Weapon Weapon { get; set; }
        public bool Shield { get; set; }

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

        public Viking(Viking original)
            : this(original.Name, original.Status, original.Health, original.Weapon, original.Shield)
        { }

        public void ViewH() { /* your print */ }
        public void ViewV() { /* your print */ }
    }
}
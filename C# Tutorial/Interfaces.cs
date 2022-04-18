using System;

namespace CsharpTutorial {
  public class Interfaces {
    interface Iitem {
      string name {get; set;}
      int price {get; set;}

      void EquipItem();
      void SellItem();
    }

    interface Idamagable {
      int durability {get; set;}

      void TakeDamage(int damageTaken);
    }

    interface IpartOfQuest {
      void TurnInItem();
    }

    class Sword : Iitem, Idamagable, IpartOfQuest {
      public string name {get; set;}
      public int price {get; set;}
      public int durability {get; set;}

      public Sword (string name) {
        this.name = name;
        this.price = 100;
        this.durability = 100;
      }

      public void EquipItem() {
        Console.WriteLine(this.name + " equipped!");
      }

      public void SellItem() {
        Console.WriteLine(this.name + " sold for " + price);
      }

      public void TakeDamage(int damageTaken) {
        this.durability -= damageTaken;
        Console.WriteLine(this.name + " damaged by " + damageTaken + "\nIt now has a durability of " + this.durability);
      }

      public void TurnInItem() {
        Console.WriteLine(name + " turned in.");
      }
    }

    class Axe : Iitem, Idamagable {
      public string name {get; set;}
      public int price {get; set;}
      public int durability {get; set;}

      public Axe (string name) {
        this.name = name;
        this.price = 60;
        this.durability = 70;
      }

      public void EquipItem() {
        Console.WriteLine(this.name + " equipped!");
      }

      public void SellItem() {
        Console.WriteLine(this.name + " sold for " + price);
      }

      public void TakeDamage(int damageTaken) {
        this.durability -= damageTaken;
        Console.WriteLine(this.name + " damaged by " + damageTaken + "\nIt now has a durability of " + this.durability);
      }
    }

    public static void Main(string[] args) {
      Sword firstSword = new Sword("Divine Rapier");
      Sword secondSword = new Sword("Daedalus");
      Axe firstAxe = new Axe("Viking Axe");

      // Create an Inventory
      // Sword[] inventory = new Sword[2];
      Iitem[] inventory = new Iitem[3];
      inventory[0] = firstSword;
      inventory[1] = secondSword;
      inventory[2] = firstAxe;

      for(int i = 0; i < inventory.Length; i++) {
        // inventory[i].TurnInItem();
        IpartOfQuest questItem = inventory[i] as IpartOfQuest;
        if(questItem != null) {
          questItem.TurnInItem();
        }
      }

      Console.WriteLine();

      firstSword.EquipItem();
      firstSword.TakeDamage(70);
      firstSword.SellItem();

      Console.WriteLine();

      secondSword.EquipItem();
      secondSword.TakeDamage(20);
      secondSword.SellItem();
    }
  }
}

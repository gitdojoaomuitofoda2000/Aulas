using UnityEngine;

public enum ItemType
{
    Weapon,
    Armor,
    Potion,
    Miscellaneous
};

public struct InventoryItems
{
    public string Name;
    public float price;
    public float weight;
    public int amount;
    public Sprite image;
    public ItemType itemType;
};

public class Variables : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InventoryItems ironSword = new InventoryItems();
        ironSword.Name = "Iron Sword";
        ironSword.price = 100.0f;
        ironSword.weight = 1.0f;
        ironSword.amount = 1;
        ironSword.image = null;
        ironSword.itemType = ItemType.Weapon;

        InventoryItems[] inventory = new InventoryItems[10];
        inventory[0] = ironSword;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

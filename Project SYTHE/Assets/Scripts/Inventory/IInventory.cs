using UnityEngine;

public interface IInventory {

    GameObject[] Items { get; }
    InventorySlot[] Slots { set; }

    void AddItem(GameObject item);

    void RemoveItem(GameObject item);
}

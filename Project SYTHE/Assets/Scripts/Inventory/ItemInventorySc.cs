using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInventorySc : MonoBehaviour, IInventory
{
    [SerializeField]
    private const int INVENTORY_SIZE = 16;

    public GameObject[] Items { get; private set; }

    public InventorySlot[] Slots { private get; set; }

    private void Awake()
    {
        Items = new GameObject[INVENTORY_SIZE];
        Slots = new InventorySlot[INVENTORY_SIZE];
    }


    public void AddItem(GameObject item)
    {
        for (int index = 0; index < Slots.Length; index++)
        {
            if (Slots[index] == null)
            {
                Slots[index].SlotImage = item.transform.GetComponent<IItem>().Sprite;
                Items[index] = item;
            }
        }
    }

    public void RemoveItem(GameObject item)
    {
        throw new System.NotImplementedException();
    }
}

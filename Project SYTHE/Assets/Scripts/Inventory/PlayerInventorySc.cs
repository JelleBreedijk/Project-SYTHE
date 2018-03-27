using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerInventorySc : MonoBehaviour, IInventory
{
    public GameObject[] Items { get; private set; }

    public InventorySlot[] Slots { private get; set; }


    public void AddItem(GameObject item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveItem(GameObject item)
    {
        throw new System.NotImplementedException();
    }
}

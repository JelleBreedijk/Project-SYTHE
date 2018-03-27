using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ItemFactory {

    private Dictionary<ItemName, GameObject> _allItems;

    public ItemFactory() {
        _allItems = new Dictionary<ItemName, GameObject>();
        foreach (GameObject item in Resources.LoadAll("ItemPrefabs", typeof(GameObject)))
        {
            _allItems.Add(item.GetComponent<IItem>().Name, item);
        }        

    }

    public GameObject CreateItem(ItemName name)
    {
        switch (name)
        {
            case ItemName.PICKAXE:
                return null;
            case ItemName.SWORD:
                return Clone(name);
            case ItemName.DIRT:
                return Clone(name);
            case ItemName.SHOVEL:
                return null;
            case ItemName.APPLE:
                return null;
            case ItemName.WORKBENCH:
                return null;
            case ItemName.CHEST:
                return Clone(name);
            default:
                return null;
        }
    }

    private GameObject Clone(ItemName name)
    {
        GameObject gameItem;
        if (_allItems.TryGetValue(name, out gameItem))
        {
            gameItem = UnityEngine.Object.Instantiate(gameItem);
        }
        return gameItem;
    }
}

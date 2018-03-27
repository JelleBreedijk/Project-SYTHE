using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSc : MonoBehaviour, IContainableItem {

    #region Base.Base Properties

    public ItemName Name { get { return _name; } private set { _name = value; } }
    public Sprite Sprite { get { return _sprite; } private set { _sprite = value; } }
    public GameObject ParentObject { get { return _parent; } set { _parent = value; } }

    [SerializeField]
    private ItemName _name;
    [SerializeField]
    private Sprite _sprite;
    [SerializeField]
    private GameObject _parent;

    #endregion

    #region Base Properties

    [SerializeField]
    private ItemInventorySc _itemInventory;

    public ItemInventorySc Inventory { get { return _itemInventory; } private set { _itemInventory = value; } }

    #endregion



    private void OnMouseUp()
    {
        PrimaryAction();
    }

    public void PrimaryAction()
    {
        // Open chest.
        Debug.Log("This chest contains Items.");
    }
}

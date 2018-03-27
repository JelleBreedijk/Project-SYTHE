using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Make check for tools in hand


    private GameObject RightHand { get; set; }
    private GameObject LeftHand { get; set; }
    private GameObject Head { get; set; }
    private GameObject Body { get; set; }
    private GameObject Legs { get; set; }
    private GameObject Feet { get; set; }
    private ItemFactory factory;
    private PlayerInventorySc _inventory;
    private MouseInteraction _action;


    void Awake()
    {
        _inventory = GetComponent<PlayerInventorySc>();
        _action = GetComponent<MouseInteraction>();
        factory = new ItemFactory();
        factory.CreateItem(ItemName.CHEST);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
            Interaction(Button.LEFTCLICK);
        if (Input.GetKeyUp(KeyCode.Mouse1))
            Interaction(Button.RIGHTCLICK);
        if (Input.GetKeyUp(KeyCode.Alpha1))
            Interaction(Button.NUM1);
    }

    private void Interaction(Button key)
    {
        GameObject item = _action.Click();
        if (item == null)
        {
            return;
        }
        ItemInventorySc itemInventory = item.transform.GetComponent<ItemInventorySc>();

        switch (key)
        {
            case Button.LEFTCLICK:
                if (item.GetComponent<ItemInventorySc>())
                {
                    return;
                }
                break;
            case Button.RIGHTCLICK:
                if (item.GetType() == typeof(IContainableItem))
                {
                    return;
                }
                break;
            case Button.NUM1:
                break;
            case Button.NUM2:
                break;
            case Button.NUM3:
                break;
            default:
                break;
        }
    }

    private void Equip()
    {
        RightHand = null;

        if (Input.GetKey("1"))
        {
            RightHand = _inventory.Items[0];
        }
        else if (Input.GetKey("2"))
        {
            RightHand = _inventory.Items[1];
        }
        else if (Input.GetKey("3"))
        {
            RightHand = _inventory.Items[2];
        }
        else if (Input.GetKey("4"))
        {
            RightHand = _inventory.Items[3];
        }
        else if (Input.GetKey("5"))
        {
            RightHand = _inventory.Items[4];
        }
        else if (Input.GetKey("6"))
        {
            RightHand = _inventory.Items[5];
        }
        else if (Input.GetKey("7"))
        {
            RightHand = _inventory.Items[6];
        }
        else if (Input.GetKey("8"))
        {
            RightHand = _inventory.Items[7];
        }
        else if (Input.GetKey("9"))
        {
            RightHand = _inventory.Items[8];
        }
    }
}

public enum Button
{
    LEFTCLICK,
    RIGHTCLICK,
    NUM1,
    NUM2,
    NUM3,
}

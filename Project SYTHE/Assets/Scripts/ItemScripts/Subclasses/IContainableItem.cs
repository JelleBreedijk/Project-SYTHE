using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IContainableItem : IItem
{
    ItemInventorySc Inventory { get; }
}

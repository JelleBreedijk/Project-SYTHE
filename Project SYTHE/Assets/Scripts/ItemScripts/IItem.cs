using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;

public interface IItem
{
    ItemName Name { get; }

    Sprite Sprite { get; }

    GameObject ParentObject { get; set; }

    void PrimaryAction();
}

public enum ItemName
{
    NONE,
    PICKAXE,
    SWORD,
    DIRT,
    SHOVEL,
    APPLE,
    WORKBENCH,
    CHEST
};
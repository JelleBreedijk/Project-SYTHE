using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;

public class SwordSc : MonoBehaviour, IWeaponItem
{

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

    public int Durability { get { return _durability; } set { _durability = value; } }
    public int MaxDurability { get { return _maxDurability; } private set { _maxDurability = value; } }

    [SerializeField]
    private int _maxDurability;
    [SerializeField]
    private int _durability;

    #endregion





   

    public void PrimaryAction()
    {
        throw new NotImplementedException();
    }

    public void SecondaryAction()
    {
        throw new System.NotImplementedException();
    }
}

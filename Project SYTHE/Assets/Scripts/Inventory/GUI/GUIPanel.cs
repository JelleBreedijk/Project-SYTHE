using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIPanel : MonoBehaviour {

    private float _offsetW = Screen.width / 4;
    private float _offsetH = Screen.height / 4;
    private float _inventoryWindowHeight = Screen.height / 2;
    private float _inventoryWindowWidth = Screen.width / 2;

    private float _inventoryWidowXAnchor = Screen.width / 2;
    private float _inventoryWindowYAnchor = Screen.height / 2;
    private const int INVENTORY_WINDOW_ID = 0;
    private Rect _inventoryWindowRect = new Rect(0, 0, 0, 0);
    public Sprite EmptyItemSlot;
    public GUIStyle Style;
    public GUIContent Content;
    public GUISkin _skin;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //void OnGUI()
    //{
    //    GUI.skin = _skin;
    //    _inventoryWindowRect = GUI.Window(INVENTORY_WINDOW_ID, new Rect(_inventoryWidowXAnchor - _offsetW, _inventoryWindowYAnchor - _offsetH, _inventoryWindowWidth, _inventoryWindowHeight), InventoryWindow, "Inventory Window", _skin.GetStyle("Slot"));
    //}

    private void InventoryWindow(int id)
    {

    }
}

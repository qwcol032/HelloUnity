using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemGos;

    private void Awake()
    {
        foreach (GameObject itemGo in itemGos)
        {
            Item item = itemGo.GetComponent<Item>();
            Debug.Log($"<color=yellow>{item.itemName}</color>");
        }
        
    }

}

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Item : MonoBehaviour
{
    //��� ���� ����
    public string itemName;
    public int damage;
    public float attackSpeed;
    public bool isBroken;

    private void Awake()
    {
        //Debug.Log("Awake�޼��� ȣ���");
        //Debug.Log($"�̸� : {this.itemName}");
        //Debug.Log($"���ݷ� : {this.damage}");
        //Debug.Log($"���ݼӵ� : {this.attackSpeed}");
        //Debug.Log($"�ı����� : {this.isBroken}");

        //Debug.LogFormat("���ݷ� : {0}", this.damage);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start�޼��� ȣ���");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyTest : MonoBehaviour {
    private Rigidbody cube1Rigidbody;
    // Use this for initialization
    void Start () {
        cube1Rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //1.AddForce()方法
        cube1Rigidbody.AddForce(Vector3.forward * 10, ForceMode.Force); //给刚体施加一个力，让刚体按“世界坐标系”运动

        //2.AddRelativeForce()方法：
        if (Input.GetKeyDown(KeyCode.A))
        {
            cube1Rigidbody.AddRelativeForce(Vector3.forward * 1000, ForceMode.Force);//给刚体施加一个相对力，让刚体按“自身坐标系”进行运动。
        }
        //3.AddExplosionForce施加爆炸力
        if (Input.GetKeyDown(KeyCode.B))
        {
            cube1Rigidbody.AddExplosionForce(19.0f, transform.position, 10, 1.5f, ForceMode.Force);
        }
        //4.AddTorque方法施加力矩
        if (Input.GetKeyDown(KeyCode.C))
        {
            cube1Rigidbody.AddTorque(-Vector3.right * 70, ForceMode.Force);
        }
        //5.AddRelativeTorque施加相对力矩
        if (Input.GetKeyDown(KeyCode.D))
        {
            cube1Rigidbody.AddRelativeTorque(-Vector3.right * 70, ForceMode.Force);
        }
        //6.在指定点施加力
        if (Input.GetKeyDown(KeyCode.F))
        {
            cube1Rigidbody.AddForceAtPosition(Vector3.up, transform.position, ForceMode.Force);
        }
    }
    //7. FixedUpdate()方法：固定更新。 
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.G))
        {
            cube1Rigidbody.MovePosition(transform.position += transform.up * Time.deltaTime * 5);//移动刚体，参数为移动目的地址
        }
    }
}

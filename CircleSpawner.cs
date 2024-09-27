using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // Đối tượng 3D bạn muốn nhân bản
    public int numberOfObjects = 10; // Số lượng đối tượng cần tạo
    public float radius = 5f; // Bán kính vòng tròn

    void Start()
    {
        SpawnObjectsInCircle();
    }

    void SpawnObjectsInCircle()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // Tính toán góc
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            // Tính toán vị trí mới
            Vector3 newPosition = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
            // Nhân bản đối tượng
            Instantiate(objectToSpawn, newPosition, Quaternion.identity);
        }
    }
}

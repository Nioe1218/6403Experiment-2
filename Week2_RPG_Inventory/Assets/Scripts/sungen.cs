using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sungen : MonoBehaviour
{
    public int maxCount = 10;
    public int count = 0;
    public GameObject[] StarArray;
    public float timer = 10;
    private float timerInvertal = 5f;

    void Update()
    {
        CreatStar();
    }
    void CreatStar()
    {
        if (count >= maxCount)
        {
            return;
        }
        timer += Time.deltaTime;
        if (timer >= timerInvertal)
        {
            timer -= timerInvertal;
            count++;
            GameObject StarPrefabs = StarArray[Random.Range(0, StarArray.Length)];
            Vector3 StarLoadPos = new Vector3(Random.value, Random.value, -Camera.main.transform.position.z);
            Vector3 StarWorldPos = Camera.main.ViewportToWorldPoint(StarLoadPos);
            GameObject.Instantiate(StarPrefabs, StarWorldPos, StarPrefabs.transform.rotation); ;
        }
    }

}

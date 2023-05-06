using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject target;
    public float difficulty = 40f;

    // Update is called once per frame
    void Update()
    {
        int spawnCount = (int) (difficulty * Time.deltaTime);
        difficulty = Time.deltaTime * 4f;

        while (spawnCount > 0) {
          Vector3 position = transform.position + new Vector3(Random.value * 40f - 20f, 0f, Random.value * 40f - 20f);
          Quaternion rotation = Quaternion.Euler(0f, Random.value * 360f, Random.value * 30f);
          Instantiate(target, position, rotation);

          spawnCount--;
        }
    }
}

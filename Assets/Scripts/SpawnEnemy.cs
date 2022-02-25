using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //variable region
    [SerializeField]
    private float minX = 0.0f;
    [SerializeField]
    private float maxX = 0.0f;
    [SerializeField]
    private int minEnemy = 1;
    [SerializeField]
    private int maxEnemy = 6;
    [SerializeField]
    private GameObject[] spawnEnemy; // potential array of Enemy
    [SerializeField]
    private float timeBetweenSpawn = 0.0f;
    private bool canSpawn = false;
    private int amountOfEnemyToSpawn = 0;
    private int enemyToSpawn = 0;
    //private int enemySpawnCapacity = 8;
    private UIScript uiFunction;
    //variable region end

    // Use this for initialization
    void Start()
    {
        uiFunction = GameObject.FindGameObjectWithTag("GameManager").GetComponent<UIScript>();
        canSpawn = true;
    }
	
	// Update is called once per frame
	void Update()
    {
        if (canSpawn == true && uiFunction.gameStarted == true)
        {
            StartCoroutine("GenerateSpawn");
        }
	}

    private IEnumerator GenerateSpawn()
    {
        canSpawn = false;
        timeBetweenSpawn = Random.Range(0.5f, 2.0f);
        amountOfEnemyToSpawn = Random.Range(minEnemy, maxEnemy);
        for(int i = 0; i < amountOfEnemyToSpawn; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), Random.Range(8.0f, 15.0f), 0.0f); //Enemy spawn position
            Instantiate(spawnEnemy[enemyToSpawn], spawnPosition, Quaternion.identity); // spawn Enemy
        }
        yield return new WaitForSeconds(timeBetweenSpawn);
        canSpawn = true;
    }
}

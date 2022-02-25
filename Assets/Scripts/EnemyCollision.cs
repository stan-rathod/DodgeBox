using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{
    //[SerializeField]
    //private ParticleSystem enemyDustParticle;
    private UIScript uiFunction;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            //Destroy(Instantiate(enemyDustParticle.gameObject, transform.position, Quaternion.identity), enemyDustParticle.startLifetime);
            this.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Player")
        {
            //uiFunction.gameStarted = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

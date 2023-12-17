using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorDeNiveles : MonoBehaviour
{
    public string sceneToLoad;
    //private string sceneToReturn;
    public Vector3 spawnPoint;

    public void CargarSiguienteNivel()
    {
      int escenaActualIndice =  SceneManager.GetActiveScene().buildIndex;
      int siguienteEscenaIndice = escenaActualIndice++;
        // SceneManager.LoadScene(siguienteEscenaIndice);
        SceneManager.LoadScene(escenaActualIndice);
    }

    public void CargarAnteriorNivel()
    {
        int escenaActualIndice = SceneManager.GetActiveScene().buildIndex;
        int siguienteEscenaIndice = escenaActualIndice--;
        // SceneManager.LoadScene(siguienteEscenaIndice);
        SceneManager.LoadScene(escenaActualIndice);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            SceneManager.LoadScene(sceneToLoad);
            player.transform.position = spawnPoint;
        }
    }
}

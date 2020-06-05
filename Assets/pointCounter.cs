 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pointCounter : MonoBehaviour
{
    public Text pointText;
    private int points = 0;

    // Start is called before the first frame update
    void Update()
    {
        pointText.text = "score :" + points.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "box")
        {
            points += 1;
            Destroy(other.gameObject);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad;
    public Animator fadeAnim;
    private Transform player;
    public Vector2 newPlayerPosition;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player = collision.transform;
            fadeAnim.Play("FadeToBlack");
            StartCoroutine(DelayFade());
        }
    }


    IEnumerator DelayFade()
    {
        yield return new WaitForSeconds(1);
        player.position = newPlayerPosition;
        SceneManager.LoadScene(sceneToLoad);
    }
}

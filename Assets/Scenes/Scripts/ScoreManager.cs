using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    [Header("Score SFX")]
    [SerializeField] private AudioClip ScoreSound;

    [SerializeField] private int scorevalue;

    [SerializeField] Text ScoreText;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            SoundManager.instance.PlaySound(ScoreSound);
            Destroy(collision.gameObject);
            scorevalue++;
            ScoreText.text = "SCORE:" + scorevalue;
        }


    }




}

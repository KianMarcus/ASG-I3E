using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;
    private AudioSource collectibleAudio;

    void Start()
    {
        collectibleAudio = GetComponent<AudioSource>();
    }

    public void Collect()
    {
        ScoreManager.Instance.score += value;
        CollectibleUI.Instance.AddCoin();
        Debug.Log("Score: " + ScoreManager.Instance.score);

        if (collectibleAudio != null)
        {
            AudioSource.PlayClipAtPoint(collectibleAudio.clip, transform.position);
        }

        Destroy(gameObject);
    }
}
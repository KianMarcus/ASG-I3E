using UnityEngine;
using TMPro;
public class CollectibleUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    public static CollectibleUI Instance;
 
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI statueText;
 
    public int totalCoins = 4;
    public int totalStatues = 2;
 
    private int coinsCollected = 0;
    private int statuesCollected = 0;
 
    void Awake()
    {
        Instance = this;
        UpdateUI();
    }
 
    public void AddCoin()
    {
        coinsCollected++;
        UpdateUI();
    }
 
    public void AddStatue()
    {
        statuesCollected++;
        UpdateUI();
    }
 
    void UpdateUI()
    {
        coinText.text = "Coins: " + coinsCollected + "/" + totalCoins;
        statueText.text = "Statues: " + statuesCollected + "/" + totalStatues;
    }  
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

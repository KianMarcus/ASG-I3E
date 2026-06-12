using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    public Image fillImage;
 
    void Update()
    {
        fillImage.fillAmount = (float)PlayerHealth.Instance.currentHealth / PlayerHealth.Instance.maxHealth;
    }
}

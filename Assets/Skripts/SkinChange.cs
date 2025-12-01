using UnityEngine;

public class SkinChange : MonoBehaviour
{
    public Sprite[] skins;
    
    private SpriteRenderer sr;
    private int currentSkin = 0;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        currentSkin = PlayerPrefs.GetInt("PlayerSkin", 0);
        ApplySkin();
    }

    public void nextSkin()
    {
        currentSkin++;
        if (currentSkin >= skins.Length)
        {
            currentSkin = 0;
        }
        ApplySkin();
        PlayerPrefs.SetInt("PlayerSkin", currentSkin);
    }
    private void ApplySkin()
    {
        if (skins.Length == 0)
        {
            Debug.LogWarning("Немає скінів");
            return;
        }
        sr.sprite = skins[currentSkin];
    }
}

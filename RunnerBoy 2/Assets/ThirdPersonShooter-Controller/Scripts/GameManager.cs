using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instace;

    public bool mobileControl;

    private GameObject mobileCanvas;
    public TextMeshProUGUI display_Text;
    public GameObject menu;
    public Transform respawnP;
    public Animator anim;


    private void Awake()
    {
        if (instace == null)
        {
            instace = this;
        }
        else
        {
            Destroy(gameObject);
        }
        mobileCanvas = GameObject.Find("MobileInput");
        if (!mobileControl) Cursor.lockState = CursorLockMode.Locked;
        mobileCanvas.SetActive(mobileControl);
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        float current = 0;
        current = Time.frameCount / Time.time;
        var avgFrameRate = (int)current;
        if (display_Text != null)
            display_Text.text = avgFrameRate.ToString() + " FPS";
    }

    public void Play()
    {
        menu.SetActive(false);
        GetComponent<Interstitial>().ShowAd();

    }
    public void Retry()
    {
        GetComponent<Rewarded>().ShowRewardedAd();
        GameObject h = FindObjectOfType<WeirdBrothers.PlayerController>().gameObject;
        h.GetComponent<Health>().CurrrentHealth = 100;
        h.GetComponent<Health>()._healthUI.fillAmount = h.GetComponent<Health>().CurrrentHealth / h.GetComponent<Health>()._maxHealth;
        anim.Play("Movement");
        h.GetComponent<Health>().FinishScene.SetActive(false);
        h.transform.position = respawnP.transform.position;
    }
}

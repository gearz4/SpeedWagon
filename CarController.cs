using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour {

    [HideInInspector]
    public float fuel = 1;
    public float fuelconsumption = 0.1f;
    public Rigidbody2D carRigidbody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed = 20;
    public float carTorque = 10;
    public float movement;
    public UnityEngine.UI.Image image;
    public UnityEngine.UI.Image image1;
    public UIManager uiManager;
    public Button yourButton;

    public float Slow;
    public float normalDrag;

    public static CarController instance;
    public AudioSource getPoint;
    public GameObject CountAni;
    static public int scoreMax11;
    
   

    // Use this for initialization
    void Start () {
        instance = this;
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
        //movement = Input.GetAxis("Horizontal");  //0 a=-1 d=1

        image.fillAmount = fuel;
        image1.fillAmount = fuel;
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Points"))
        {
            getPoint.Play();

            Destroy(other.gameObject);
        }
    }
    private void FixedUpdate()
    {
        if (fuel > 0)
        {
            StopAllCoroutines();
            backTire.AddTorque(-movement * speed  *1.1f*Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            carRigidbody.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
            CountAni.SetActive(false);

        }
        if (fuel <= 0)
        {
            StartCoroutine(DelayToStopTime());
            CountAni.SetActive(true);
        

            scoreMax11 = FindObjectOfType<ScoreManager>().score;


          
        }

        fuel -= fuelconsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
    }

    public void MoveForward()
    {
        movement = 1;
    }

    public void StopMoveForward()
    {
        movement = 0;
    }

    public void MoveBack()
    {
        movement = -1;
    }

    public void StopMoveBack()
    {
        movement = 0;
    }

    public IEnumerator DelayToStopTime()
    {
         yield return new WaitForSeconds(3f);
         Time.timeScale = 0;
        CountAni.SetActive(false);
        uiManager.OpenScoreMenu();
        

    }

    public void CarSlow()
    {
        backTire.drag = Slow;
        frontTire.drag = Slow;
    }

    public void CarNotSlow()
    {
        backTire.drag = normalDrag;
        frontTire.drag = normalDrag;
    }


}

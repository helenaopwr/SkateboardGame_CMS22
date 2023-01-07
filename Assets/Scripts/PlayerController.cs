using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//using TMPro;
//using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;

    public AudioClip collectSound;
    public AudioClip deathSound;

    public AudioSource backgroundMusic;

    //public TextMeshProUGUI countText;
    //public TextMeshProUGUI winLooseText;

    private Rigidbody rb;

    private float movementX;
    private float movementY;

    //private AudioSource audioSource;

    //private int count = 0;
    //private int maxCount = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // apply physical forces
        //audioSource = GetComponent<AudioSource>();

        //count = 0;
        //maxCount = GameObject.FindGameObjectsWithTag("Diamond").Length;
        //SetCountText();
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0f, movementY);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        // currently every collision will write a message to the console
        Debug.Log("collision");

        /*
        if (other.gameObject.CompareTag("Diamond"))
        {
            audioSource.PlayOneShot(collectSound);

            other.gameObject.SetActive(false);

            count = count + 1;
            //count += 1;
            //count++;

            SetCountText();

            if (count >= maxCount)
            {
                winLooseText.text = "Y I P P I E   Y E I H   Y E H ! ! !";

                Invoke("BackToMenu", 5.0f);
            }
        }
        
        else if (other.gameObject.CompareTag("Enemy"))
        {
            backgroundMusic.Stop();
            audioSource.PlayOneShot(deathSound);

            winLooseText.text = "G A M E  O V E R";

            rb.isKinematic = true;

            Invoke("BackToMenu", 5.0f);
        }
        */
    }

    /*
    private void SetCountText()
    {
        countText.text = "Count: " + count.ToString() + " | " + maxCount.ToString();
    }

    private void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    */
}

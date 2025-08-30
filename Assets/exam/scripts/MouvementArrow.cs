using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MouvementArrow : MonoBehaviour
{
    public float vitesse; //vitesse à appliquer au Joueur est //déclarée public
    private Rigidbody rb; //pour pouvoir appliquer une force

    public TMP_Text countText;

    private int count;

    void Start () {
        rb = GetComponent <Rigidbody> ();
        count = 0;
        SetCountText ();
    }

    void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal"); //This line gets the horizontal input value, which is controlled by the left and right arrow keys (or the 'A' and 'D' keys). The value ranges from -1 (full left) to 1 (full right)
        float moveVertical = Input.GetAxis("Vertical"); //This line gets the vertical input value, which is controlled by the up and down arrow keys (or the 'W' and 'S' keys). The value ranges from -1 (full down) to 1 (full up)
        
        Vector3 mouvement = new Vector3(moveHorizontal, 0.0f, moveVertical) ; //le joueur va se déplacer //uniquement sur les axes X et Z
        rb.AddForce (mouvement * vitesse) ; //on applique //une force sur le rigidbody
        // transform.Translate(mouvement * vitesse * Time.deltaTime); //on applique //un mouvement basé sur le temps
        }

    public void OnTriggerEnter (Collider other) {
         if (other.gameObject.CompareTag ("Cible")) {
            other.gameObject.SetActive (false) ;
            count = count + 1;
            SetCountText ();
            }
        }

    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString ();
        if (count >= 4)
        {
            countText.text = "You Win!";
        }
    }
}
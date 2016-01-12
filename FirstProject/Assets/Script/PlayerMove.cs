using UnityEngine; // comme include en C (de base)
using System.Collections;

public class PlayerMove : MonoBehaviour { // creer une nouvelle classe = nouveau composant

    public float speed = 42;
    Rigidbody rigidbody; 

	// Use this for initialization
	void Start () { // des que l'objt apparait sur la scène, start est appele
        rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalAxis = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // renvoie une val entre -1 et 1 en fonction des touches sur lesquelles on appuie (ex : fleche droite = 1, fleche gauche = -1)
        float verticalAxis = Input.GetAxis("Vertical") * speed * Time.deltaTime;  // deltaTime : temps qui s'est écoulé entre la frame precedente et l'actuelle
        // speed * temps = distance sur laquelle deplacer le cube (degre de deplacement a avoir)

        // Debug.Log(horizontalAxis); // sert a afficher les valeurs
        
        // transform.position donne le vecteur position de l'objt, et new Vector3 permet de donner un nouveau vecteur position
        Vector3 newPosition = transform.position + new Vector3(horizontalAxis, 0, verticalAxis);
        rigidbody.MovePosition(newPosition);
	}
}

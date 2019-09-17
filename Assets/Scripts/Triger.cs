using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Triger : MonoBehaviour
{
    // Start is called before the first frame update
    List<string> obtained = new List<string>();
    List<string> keyB = new List<string> { "Red", "Green", "Black", "Yellow", "Blue"};
    List<string> keyA = new List<string> { "Green", "Black", "Yellow", "Red", "Blue" };
    List<string> keyC = new List<string> { "Yellow", "Blue", "Red", "Green", "Black" };
    string text;
    public GameObject restarter, buttons, Yellow, Green, Black, Red, Blue, randomizer;
    void Start()
    {
        restarter.SetActive(false);
        //set starting random card
    }

    // Update is called once per frame
    void Update()
    {
        if (obtained.Count == 5)
        {
            if (obtained.SequenceEqual(keyB))
            {
                text = "Has ganado el juego, ve a la esfera si quieres intentarlo de nuevo.";
            }
            if (obtained.SequenceEqual(keyA))
            {
                text = "Has ganado el juego, ve a la esfera si quieres intentarlo de nuevo.";
            }
            if (obtained.SequenceEqual(keyC))
            {
                text = "Has ganado el juego, ve a la esfera si quieres intentarlo de nuevo.";
            }
            else
            {
                text = "Has perdido el juego, ve a la esfera si quieres intentarlo de nuevo.";
            }
            restarter.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("restart"))
        {
            Debug.Log("Se ha tomado la carta color " + other.gameObject.name);
            obtained.Add(other.gameObject.name);
        }
        other.gameObject.SetActive(false);
        if (other.gameObject.CompareTag("restart")){
            buttons.SetActive(true);
            Yellow.SetActive(true);
            Red.SetActive(true);
            Green.SetActive(true);
            Black.SetActive(true);
            Blue.SetActive(true);
            obtained.Clear();
            text = "";
            //set random card again
        }
    }

    void OnGUI()
    {
        GUILayout.Box(text);
    }

}

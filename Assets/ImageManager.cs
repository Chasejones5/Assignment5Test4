using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{
    public Image animalImage;
    private Dictionary<string, Sprite> animalSprites = new Dictionary<string, Sprite>();

    void Start()
    {
        LoadAnimalSprites();
    }

    void LoadAnimalSprites()
    {
        // Replace these file paths with the actual paths to your sprite files
        string whalePath = "Assets/Resources/Animals/whale.png";
        string sharkPath = "Assets/Resources/Animals/shark.png";
        string sealPath = "Assets/Resources/Animals/seal.png";
        string seaturtlePath = "Assets/Resources/Animals/seaturtle.png";
        string squidPath = "Assets/Resources/Animals/squid.png";
        string swordfishPath = "Assets/Resources/Animals/swordfish.png";
        string planktonPath = "Assets/Resources/Animals/plankton.png";
        string dolphinPath = "Assets/Resources/Animals/dolphin.png";
        string jellyfishPath = "Assets/Resources/Animals/jellyfish.png";
        string octopusPath = "Assets/Resources/Animals/octopus.png";

        Sprite whaleSprite = AssetDatabase.LoadAssetAtPath<Sprite>(whalePath);
        if (whaleSprite != null)
        {
            animalSprites.Add("whale", whaleSprite);
            Debug.Log("Loaded sprite: " + whaleSprite.name);
        }
        else
        {
            Debug.LogError("Failed to load sprite at path: " + whalePath);
        }

        Sprite sharkSprite = AssetDatabase.LoadAssetAtPath<Sprite>(sharkPath);
        if (sharkSprite != null)
        {
            animalSprites.Add("shark", sharkSprite);
            Debug.Log("Loaded sprite: " + sharkSprite.name);
        }
        else
        {
            Debug.LogError("Failed to load sprite at path: " + sharkPath);
        }
        Sprite sealSprite = AssetDatabase.LoadAssetAtPath<Sprite>(sealPath);
        if (sealSprite != null)
        {
            animalSprites.Add("seal", sealSprite);
            Debug.Log("Loaded sprite: " + sealSprite.name);
        }
        else
        {
            Debug.LogError("Failed to load sprite at path: " + sealPath);
        }
        Sprite squidSprite = AssetDatabase.LoadAssetAtPath<Sprite>(squidPath);
        if (squidSprite != null)
        {
            animalSprites.Add("squid", squidSprite);
            Debug.Log("Loaded sprite: " + squidSprite.name);
        }
        else
        {
            Debug.LogError("Failed to load sprite at path: " + squidPath);
        }
        Sprite swordfishSprite = AssetDatabase.LoadAssetAtPath<Sprite>(swordfishPath);
        if (swordfishSprite != null)
        {
            animalSprites.Add("swordfish", swordfishSprite);
            Debug.Log("Loaded sprite: " + swordfishSprite.name);
        }
        else
        {
            Debug.LogError("Failed to load sprite at path: " + swordfishPath);
        }
        Sprite seaturtleSprite = AssetDatabase.LoadAssetAtPath<Sprite>(seaturtlePath);
        if (seaturtleSprite != null)
        {
            animalSprites.Add("seaturtle", seaturtleSprite);
            Debug.Log("Loaded sprite: " + seaturtleSprite.name);
        }
        else
        {
            Debug.LogError("Failed to load sprite at path: " + seaturtlePath);
        }
        Sprite planktonSprite = AssetDatabase.LoadAssetAtPath<Sprite>(planktonPath);
        if (planktonSprite != null)
        {
            animalSprites.Add("plankton", planktonSprite);
            Debug.Log("Loaded sprite: " + planktonSprite.name);
        }
        else
        {
            Debug.LogError("Failed to load sprite at path: " + planktonPath);
        }
        Sprite octopusSprite = AssetDatabase.LoadAssetAtPath<Sprite>(octopusPath);
        if (octopusSprite != null)
        {
            animalSprites.Add("octopus", octopusSprite);
            Debug.Log("Loaded sprite: " + octopusSprite.name);
        }
        else
        {
            Debug.LogError("Failed to load sprite at path: " + octopusPath);
        }
        Sprite jellyfishSprite = AssetDatabase.LoadAssetAtPath<Sprite>(jellyfishPath);
        if (jellyfishSprite != null)
        {
            animalSprites.Add("jellyfish", jellyfishSprite);
            Debug.Log("Loaded sprite: " + jellyfishSprite.name);
        }
        else
        {
            Debug.LogError("Failed to load sprite at path: " + jellyfishPath);
        }
        Sprite dolphinSprite = AssetDatabase.LoadAssetAtPath<Sprite>(dolphinPath);
        if (dolphinSprite != null)
        {
            animalSprites.Add("dolphin", dolphinSprite);
            Debug.Log("Loaded sprite: " + dolphinSprite.name);
        }
        else
        {
            Debug.LogError("Failed to load sprite at path: " + dolphinPath);
        }


        // Add code to load other animal sprites here
    }

    public void DisplayAnimalImage(string animalName)
    {
        if (animalSprites.ContainsKey(animalName))
        {
            animalImage.sprite = animalSprites[animalName];
            animalImage.gameObject.SetActive(true);

            Canvas animalImageCanvas = animalImage.GetComponentInParent<Canvas>();
            if (animalImageCanvas != null)
            {
                animalImageCanvas.sortingOrder = 10; // Adjust this value as needed
            }

            // Find the Canvas component of the guessed word text
            GameObject guessedWordTextObject = GameObject.Find("GuessedWordText");
            if (guessedWordTextObject != null)
            {
                Canvas guessedWordCanvas = guessedWordTextObject.GetComponentInParent<Canvas>();
                if (guessedWordCanvas != null)
                {
                    guessedWordCanvas.sortingOrder = 5; // Adjust this value as needed, but make it lower than the animal image's Canvas
                }
            }
        }
    }


    public void HideAnimalImage()
    {
        animalImage.gameObject.SetActive(false);
    }
}
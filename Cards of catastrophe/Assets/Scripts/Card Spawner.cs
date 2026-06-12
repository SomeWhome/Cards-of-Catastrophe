using UnityEditor.Experimental.GraphView;
using UnityEngine;
public class CardSpawner : MonoBehaviour
{

    public GameObject[] Cards;
    public bool[] Delt;
    public bool PlayerGo = true;
    private int CollectiveScore = 0;
    private bool AllCardPicked = false;
    private bool delt;
    private int cardsinhand = 0;
    private Animator animator;
    public GameObject[] SpawnedCards;
    public int E = 0;

    public int AmmountofCardsSpawned = 0;
    public Vector3 spawnPosition = Vector3.zero;
    public Vector3 positionRange = new Vector3(5f, 0f, 5f);
    public void Hit()
    {
        if (PlayerGo && CollectiveScore <= 21)
        {
            if (!AllCardPicked)
            {
                
                SpawnRandomCard();
            }
        }
    }

    public void SpawnRandomCard()
    {
        if (Cards == null || Cards.Length == 0)
        {
            Debug.LogError("No prefabs assighned in the inspector!");
            return;
        }
        if (cardsinhand == 0)
        {

            CardValues CardAnimation = SpawnedCards[0].GetComponent<CardValues>();
            CardAnimation.doaflip();
            cardsinhand += 1;
        }




        if (AmmountofCardsSpawned != 11)
        {
            int randomIndex = Random.Range(0, Cards.Length);
            if (Delt[randomIndex])
            {
                while (Delt[randomIndex])
                {
                    int randomIndex1 = Random.Range(0, Cards.Length);
                    randomIndex = randomIndex1;
                }
                Delt[randomIndex] = true;
            }
            else
            {
                Delt[randomIndex] = true;
            }


            if (Cards[randomIndex] == null)
            {
                Debug.LogError($"prefab at index {randomIndex} is null");
                return;
            }
            Vector3 finalposition = spawnPosition;
            Instantiate(Cards[randomIndex], finalposition, Quaternion.identity);
            AmmountofCardsSpawned += 1;
            SpawnedCards[E] = Cards[randomIndex];
            E += 1;
        }
    }
}

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

    public CardValues CardValues;
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
            GameObject cardStore = Instantiate(Cards[randomIndex], finalposition, Quaternion.identity);
            CollectiveScore += cardStore.GetComponent<CardValues>().cardValue;
            AmmountofCardsSpawned += 1;
            Debug.Log(CollectiveScore);
            PlayerGo = false;

        }
    }
}

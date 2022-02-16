using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public GameObject Screen;

    GameObject cRow;

    GameObject cBlock;

    InputManager iManager;

    int rowIndex = 0;

    int blockIndex = 0;

    string word = "SHARD";

    string[] words ={"Abuse",
                    "Adult",
                    "Agent",
                    "Anger",
                    "Apple",
                    "Award",
                    "Basis",
                    "Beach",
                    "Birth",
                    "Block",
                    "Blood",
                    "Board",
                    "Brain",
                    "Bread",
                    "Break",
                    "Brown",
                    "Buyer",
                    "Cause",
                    "Chain",
                    "Chair",
                    "Chest",
                    "Chief",
                    "Child",
                    "China",
                    "Claim",
                    "Class",
                    "Clock",
                    "Coach",
                    "Coast",
                    "Court",
                    "Cover",
                    "Cream",
                    "Crime",
                    "Cross",
                    "Crowd",
                    "Crown",
                    "Cycle",
                    "Dance",
                    "Death",
                    "Depth",
                    "Doubt",
                    "Draft",
                    "Drama",
                    "Dream",
                    "Dress",
                    "Drink",
                    "Drive",
                    "Earth",
                    "Enemy",
                    "Entry",
                    "Error",
                    "Event",
                    "Faith",
                    "Fault",
                    "Field",
                    "Fight",
                    "Final",
                    "Floor",
                    "Focus",
                    "Force",
                    "Frame",
                    "Frank",
                    "Front",
                    "Fruit",
                    "Glass",
                    "Grant",
                    "Grass",
                    "Green",
                    "Group",
                    "Guide",
                    "Heart",
                    "Henry",
                    "Horse",
                    "Hotel",
                    "House",
                    "Image",
                    "Index",
                    "Input",
                    "Issue",
                    "Japan",
                    "Jones",
                    "Judge",
                    "Knife",
                    "Laura",
                    "Layer",
                    "Level",
                    "Lewis",
                    "Light",
                    "Limit",
                    "Lunch",
                    "Major",
                    "March",
                    "Match",
                    "Metal",
                    "Model",
                    "Money",
                    "Month",
                    "Motor",
                    "Mouth",
                    "Music",
                    "Night",
                    "Noise",
                    "North",
                    "Novel",
                    "Nurse",
                    "Offer",
                    "Order",
                    "Other",
                    "Owner",
                    "Panel",
                    "Paper",
                    "Party",
                    "Peace",
                    "Peter",
                    "Phase",
                    "Phone",
                    "Piece",
                    "Pilot",
                    "Pitch",
                    "Place",
                    "Plane",
                    "Plant",
                    "Plate",
                    "Point",
                    "Pound",
                    "Power",
                    "Press",
                    "Price",
                    "Pride",
                    "Prize",
                    "Proof",
                    "Queen",
                    "Radio",
                    "Range",
                    "Ratio",
                    "Reply",
                    "Right",
                    "River",
                    "Round",
                    "Route",
                    "Rugby",
                    "Scale",
                    "Scene",
                    "Scope",
                    "Score",
                    "Sense",
                    "Shape",
                    "Share",
                    "Sheep",
                    "Sheet",
                    "Shift",
                    "Shirt",
                    "Shock",
                    "Sight",
                    "Simon",
                    "Skill",
                    "Sleep",
                    "Smile",
                    "Smith",
                    "Smoke",
                    "Sound",
                    "South",
                    "Space",
                    "Speed",
                    "Spite",
                    "Sport",
                    "Squad",
                    "Staff",
                    "Stage",
                    "Start",
                    "State",
                    "Steam",
                    "Steel",
                    "Stock",
                    "Stone",
                    "Store",
                    "Study",
                    "Stuff",
                    "Style",
                    "Sugar",
                    "Table",
                    "Taste",
                    "Terry",
                    "Theme",
                    "Thing",
                    "Title",
                    "Total",
                    "Touch",
                    "Tower",
                    "Track",
                    "Trade",
                    "Train",
                    "Trend",
                    "Trial",
                    "Trust",
                    "Truth",
                    "Uncle",
                    "Union",
                    "Unity",
                    "Value",
                    "Video",
                    "Visit",
                    "Voice",
                    "Waste",
                    "Watch",
                    "Water",
                    "While",
                    "White",
                    "Whole",
                    "Woman",
                    "World",
                    "Youth"};

    void Start()
    {
        word = words[Random.Range(0, words.GetLength(0))].ToUpper();
        // Debug.Log(word);
        iManager = GetComponent<InputManager>();
        cRow = Screen.transform.GetChild(0).transform.GetChild(rowIndex).gameObject;
        cBlock = cRow.transform.GetChild(blockIndex).gameObject;
        HighlightBlock(Color.cyan);
    }

    void RefreshBlock()
    {
        cRow = Screen.transform.GetChild(0).transform.GetChild(rowIndex).gameObject;
        HighlightBlock(Color.black);
        cBlock = cRow.transform.GetChild(blockIndex).gameObject;
        HighlightBlock(Color.cyan);
    }

    void HighlightBlock(Color col)
    {
        cBlock.transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().color = col;
    }

    public GameObject GetLetterTextBox()
    {
        return cBlock.transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).gameObject;
    }

    void Update()
    {
        char l = iManager.CheckInput();
        if (l != '0')
        {
            GetLetterTextBox().GetComponent<TextMeshProUGUI>().text = l.ToString();
            cBlock.GetComponent<LetterBlock>().letter = l;
            if (blockIndex < 4)
            {
                blockIndex++;
            }
            RefreshBlock();
        }
    }

    public void NewRow()
    {
        if (blockIndex == 4)
        {
            CheckRow();
            if (rowIndex < 4)
            {
                rowIndex++;
                blockIndex = 0;
            }
            else
            {
                iManager.SetStatus(false);
            }
        }
        RefreshBlock();
    }

    void CheckRow()
    {
        GameObject row = Screen.transform.GetChild(0).transform.GetChild(rowIndex).gameObject;
        for (int i = 0; i < 5; i++)
        {
            GameObject block = row.transform.GetChild(i).gameObject;
            // Debug.Log(i + " " + block.GetComponent<LetterBlock>().letter + " " + word[i]);
            if (block.GetComponent<LetterBlock>().letter == word[i])
            {
                block.transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().color = Color.green;
            }
            else if (word.Contains(block.GetComponent<LetterBlock>().letter.ToString()))
            {
                block.transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().color = Color.yellow;
            }
            else
            {
                block.transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().color = Color.grey;
            }
        }
    }

    public void Delete()
    {
        if (blockIndex == 4)
        {
            GetLetterTextBox().GetComponent<TextMeshProUGUI>().text = " ";
            cBlock.GetComponent<LetterBlock>().letter = ' ';
        }
        if (blockIndex > 0)
        {
            blockIndex--;
        }
        RefreshBlock();
        GetLetterTextBox().GetComponent<TextMeshProUGUI>().text = " ";
        cBlock.GetComponent<LetterBlock>().letter = ' ';
    }
}

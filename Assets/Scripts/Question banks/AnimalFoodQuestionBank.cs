using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AnimalFoodQuestionBank : SimpleQuestion
{
    public static List<SimpleQuestion> questions = new List<SimpleQuestion>();
    public static SimpleQuestion animalFood001 = new SimpleQuestion();
    public static SimpleQuestion animalFood002 = new SimpleQuestion();
    public static SimpleQuestion animalFood003 = new SimpleQuestion();
    public static SimpleQuestion animalFood004 = new SimpleQuestion();
    public static SimpleQuestion animalFood005 = new SimpleQuestion();
    public static SimpleQuestion animalFood006 = new SimpleQuestion();
    private Sprite dogSprite,
                    horseSprite,
                    catSprite,
                    rabbitSprite,
                    frogSprite,
                    lionSprite,
                    tigerSprite,
                    zebraSprite,
                    elephantSprite,
                    monkeySprite,
                    chickenSprite,
                    parrotSprite,
                    cowSprite;

    void Start()
    {
        // sprites
        dogSprite = Resources.Load<Sprite>("Questions/Animals/Dog");
        horseSprite = Resources.Load<Sprite>("Questions/Animals/Horse");
        catSprite = Resources.Load<Sprite>("Questions/Animals/Cat");
        rabbitSprite = Resources.Load<Sprite>("Questions/Animals/Rabbit");
        frogSprite = Resources.Load<Sprite>("Questions/Animals/Frog");
        lionSprite = Resources.Load<Sprite>("Questions/Animals/Lion");
        tigerSprite = Resources.Load<Sprite>("Questions/Animals/Tiger");
        zebraSprite = Resources.Load<Sprite>("Questions/Animals/Zebra");
        elephantSprite = Resources.Load<Sprite>("Questions/Animals/Elephant");
        monkeySprite = Resources.Load<Sprite>("Questions/Animals/Monkey");
        chickenSprite = Resources.Load<Sprite>("Questions/Animals/Chicken");
        parrotSprite = Resources.Load<Sprite>("Questions/Animals/Parrot");
        cowSprite = Resources.Load<Sprite>("Questions/Animals/Cow");

        animalFood001 = new SimpleQuestion()
        {
            number = 1,
            questionName = "carrots",
            answer = "horse",
            answerOptionsSprites = new List<Sprite>()
            {
                dogSprite,
                horseSprite,
                catSprite,
                rabbitSprite
            },
            answerOptions = new List<string>()
            {
                "dog",
                "horse",
                "cat",
                "rabbit"
            },
            tags = new List<string>()
            {
            "animals", "food"
            },
            size = 1
        };

        animalFood002 = new SimpleQuestion()
        {
            number = 2,
            questionName = "meat",
            answer = "tiger",
            answerOptionsSprites = new List<Sprite>()
        {
                frogSprite,
                lionSprite,
                rabbitSprite,
                tigerSprite
        },
            answerOptions = new List<string>()
        {
            "frog",
            "lion",
            "rabbit",
            "tiger"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };

        animalFood003 = new SimpleQuestion()
        {
            number = 3,
            questionName = "cheese",
            answer = "mouse",
            answerOptionsSprites = new List<Sprite>()
        {
                null,
                null,
                catSprite,
                parrotSprite
        },
            answerOptions = new List<string>()
        {
            "mouse",
            "dolphin",
            "cat",
            "parrot"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };

        animalFood004 = new SimpleQuestion()
        {
            number = 4,
            questionName = "grass",
            answer = "cow",
            answerOptionsSprites = new List<Sprite>()
        {
                zebraSprite,
                parrotSprite,
                cowSprite,
                dogSprite
        },
            answerOptions = new List<string>()
        {
            "zebra",
            "parrot",
            "cow",
            "dog"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };


        animalFood005 = new SimpleQuestion()
        {
            number = 5,
            questionName = "banana",
            answer = "monkey",
            answerOptionsSprites = new List<Sprite>()
        {
                elephantSprite,
                chickenSprite,
                null,
                monkeySprite
        },
            answerOptions = new List<string>()
        {
            "elephant",
            "chicken",
            "mouse",
            "monkey"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };

        animalFood006 = new SimpleQuestion()
        {
            number = 6,
            questionName = "bone",
            answer = "dog",
            answerOptionsSprites = new List<Sprite>()
        {
                lionSprite,
                dogSprite,
                null,
                monkeySprite
        },
            answerOptions = new List<string>()
        {
            "lion",
            "dog",
            "mouse",
            "monkey"
        },
            tags = new List<string>()
        {
            "animals", "food"
        },
            size = 1
        };
    }
    public static void LoadQuestionList()
    {
        // if (GameControl.animalFood001known == false)
        questions.Add(animalFood001);
        questions.Add(animalFood002);
        questions.Add(animalFood003);
        questions.Add(animalFood004);
        questions.Add(animalFood005);
        questions.Add(animalFood006);
        // questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();
    }
}
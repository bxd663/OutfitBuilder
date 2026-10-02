using UnityEngine;
using UnityEngine.UI;

public class OutfitBuilderManager : MonoBehaviour
{
    public Image topImage;
    public Image bottomImage;
    public Image shoesImage;
    public Image accessoryImage;

    public GameObject selectionScreen;
    public GameObject resultsScreen;

    public Sprite normalButton;
    public Sprite selectedButton;

    public Button[] occasionButtons;
    public Button[] weatherButtons;
    public Button[] styleButtons;
    public Sprite whiteTank;
    public Sprite pinkBlouse;
    public Sprite sweater;
    public Sprite blazer;

    public Sprite denimSkirt;
    public Sprite jeans;
    public Sprite trousers;
    public Sprite athleticShorts;

    public Sprite sneakers;
    public Sprite loafers;
    public Sprite boots;
    public Sprite heels;

    public Sprite handbag;
    public Sprite toteBag;
    public Sprite umbrella;
    public Sprite structuredBag;    

    string occasion;
    string weather;
    string style;

    public void PickOccasion(int choice)
    {
        for (int i = 0; i < occasionButtons.Length; i++)
        {
            occasionButtons[i].image.sprite = normalButton;
        }

        occasionButtons[choice].image.sprite = selectedButton;

        if (choice == 0)
            occasion = "Class";
        if (choice == 1)
            occasion = "Work";
        if (choice == 2)
            occasion = "Errands";
        if (choice == 3)
            occasion = "Going Out";

        Debug.Log("Occasion: " + occasion);
    }

    public void PickWeather(int choice)
    {
        for (int i = 0; i < weatherButtons.Length; i++)
        {
            weatherButtons[i].image.sprite = normalButton;
        }

        weatherButtons[choice].image.sprite = selectedButton;

        if (choice == 0)
            weather = "Hot";
        if (choice == 1)
            weather = "Cool";
        if (choice == 2)
            weather = "Cold";
        if (choice == 3)
            weather = "Rainy";

        Debug.Log("Weather: " + weather);
    }

    public void PickStyle(int choice)
    {
        for (int i = 0; i < styleButtons.Length; i++)
        {
            styleButtons[i].image.sprite = normalButton;
        }

        styleButtons[choice].image.sprite = selectedButton;

        if (choice == 0)
            style = "Comfortable";
        if (choice == 1)
            style = "Sporty";
        if (choice == 2)
            style = "Casual";
        if (choice == 3)
            style = "Formal";

        Debug.Log("Style: " + style);
    }
    public void ChooseOutfit()
{
 
    if (style == "Comfortable")
        topImage.sprite = sweater;

    if (style == "Sporty")
        topImage.sprite = whiteTank;

    if (style == "Casual")
        topImage.sprite = pinkBlouse;

    if (style == "Formal")
        topImage.sprite = blazer;


  
    if (occasion == "Class")
        bottomImage.sprite = jeans;

    if (occasion == "Work")
        bottomImage.sprite = trousers;

    if (occasion == "Errands")
        bottomImage.sprite = athleticShorts;

    if (occasion == "Going Out")
        bottomImage.sprite = denimSkirt;


    // Choose shoes
    if (style == "Comfortable")
        shoesImage.sprite = sneakers;

    if (style == "Sporty")
        shoesImage.sprite = sneakers;

    if (style == "Casual")
        shoesImage.sprite = loafers;

    if (style == "Formal")
        shoesImage.sprite = heels;



    if (weather == "Rainy")
        accessoryImage.sprite = umbrella;

    if (weather == "Hot")
        accessoryImage.sprite = toteBag;

    if (weather == "Cool")
        accessoryImage.sprite = handbag;

    if (weather == "Cold")
        accessoryImage.sprite = structuredBag;

    selectionScreen.SetActive(false);
    resultsScreen.SetActive(true);

    Debug.Log("Outfit Created!");
}
public void TryAgain()
{
    resultsScreen.SetActive(false);
    selectionScreen.SetActive(true);
}

}
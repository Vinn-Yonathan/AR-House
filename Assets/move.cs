using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    // AR Menu
    public void arMenu(string arMenu){
        SceneManager.LoadScene("arMenu");
    }

    // Video AR Camera
    public void videoAr(string videoAr){
        SceneManager.LoadScene("videoAr");
    }

    // Credit Scene
    public void creditScene(string creditScene){
        SceneManager.LoadScene("creditScene");
    }
    // Furniture Menu Scene
    public void furnitureMenu(string furnitureMenu){
        SceneManager.LoadScene("furnitureMenu");
    }
    // Sofa AR Scene
    public void sofaCamera(string sofaCamera){
        SceneManager.LoadScene("sofaCamera");
    }
    // Table AR Scene
    public void tableCamera(string tableCamera){
        SceneManager.LoadScene("tableCamera");
    }
    // House Menu Scene
    public void houseMenu(string houseMenu){
        SceneManager.LoadScene("houseMenu");
    }
    // Main Menu Scene
    public void mainMenu(string mainMenu){
        SceneManager.LoadScene("mainMenu");
    }
    // Luxury AR Camera
    public void luxuryCamera(string luxuryCamera){
        SceneManager.LoadScene("luxuryCamera");
    }
    public void downloadLuxury(){
        Application.OpenURL("https://drive.google.com/file/d/1KvacqbnZWttkDuPECo_NMYio5mrKAhEo/view?usp=sharing");
    }
    // British AR Camera
    public void britishCamera(string britishCamera){
        SceneManager.LoadScene("britishCamera");
    }
    public void downloadBritish(){
          Application.OpenURL("https://drive.google.com/file/d/1STy1ylNSGrqFbw8TXU7_2M6eTFQy5W0h/view?usp=sharing");
    }
    public void downloadVideo(){
          Application.OpenURL("https://drive.google.com/file/d/1MG5pnIRHXJ8sdIYDQlSdh59iMGfeBoYx/view?usp=sharing");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumberGame : MonoBehaviour {


    public InputField input;
    public Text infoText;

    private int guessNumber;
    private int userGuess;

	// Use this for initialization
	void Start () {

        // สุ่มตัวเลขขึ้นมา 1 ตัว ระหว่าง 0-100
        guessNumber = Random.Range(0, 100);
		
	}

    public void CheckGuess(){

        // รับค่าจากผู้เล่นในช่องทายตัวเลข แปลงค่า text เป็น int
        userGuess = int.Parse(input.text);

        // ใช้ if else เช็คตัวเลข
        if(userGuess == guessNumber){
            infoText.text = "ถูกต้องนะคร๊าบบบบบ" ;
        } else if (userGuess > guessNumber) {
            infoText.text = "ตัวเลขยังมากกว่า" ;
        } else if (userGuess < guessNumber) {
            infoText.text = "ตัวเลขยังน้อยกว่า";
        }

        input.text = "";
    }
	
}

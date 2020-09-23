using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour {

    private int count1;
	private int count2;

	public Text scoreTeam1;
	public Text scoreTeam2;
	public Text quiz;

	private enum States {vraag_1, antwoord_1, vraag_2, antwoord_2, vraag_3, antwoord_3, vraag_4, antwoord_4, vraag_5, antwoord_5, 
						vraag_6, antwoord_6,vraag_7, antwoord_7, vraag_8, antwoord_8, vraag_9, antwoord_9, vraag_10, antwoord_10, 
						vraag_11, antwoord_11, vraag_12, antwoord_12, vraag_13, antwoord_13, vraag_14, antwoord_14, vraag_15, antwoord_15,
						vraag_16, antwoord_16, vraag_17, antwoord_17, vraag_18, antwoord_18, vraag_19, antwoord_19, vraag_20, antwoord_20, eind};
	private States myState;

	void Start () {
		count1 = 0;	
		count2 = 0;
		scoreTeam1.text = "Team 1: " + count1.ToString ();
		scoreTeam2.text = "Team 2: " + count2.ToString ();
		myState = States.vraag_1;
	}

	void Update (){

		if (myState == States.antwoord_1) {state_antwoord_1 ();}
		else if (myState == States.antwoord_2) {state_antwoord_2 ();}
		else if (myState == States.antwoord_3) {state_antwoord_3 ();}
		else if (myState == States.antwoord_4) {state_antwoord_4 ();}
		else if (myState == States.antwoord_5) {state_antwoord_5 ();}
		else if (myState == States.antwoord_6) {state_antwoord_6 ();}
		else if (myState == States.antwoord_7) {state_antwoord_7 ();}
		else if (myState == States.antwoord_8) {state_antwoord_8 ();}
		else if (myState == States.antwoord_9) {state_antwoord_9 ();}
		else if (myState == States.antwoord_10) {state_antwoord_10 ();}
		else if (myState == States.antwoord_11) {state_antwoord_11 ();}
		else if (myState == States.antwoord_12) {state_antwoord_12 ();}
		else if (myState == States.antwoord_13) {state_antwoord_13 ();}
		else if (myState == States.antwoord_14) {state_antwoord_14 ();}
		else if (myState == States.antwoord_15) {state_antwoord_15 ();}
		else if (myState == States.antwoord_16) {state_antwoord_16 ();}
		else if (myState == States.antwoord_17) {state_antwoord_17 ();}
		else if (myState == States.antwoord_18) {state_antwoord_18 ();}
		else if (myState == States.antwoord_19) {state_antwoord_19 ();}
		else if (myState == States.antwoord_20) {state_antwoord_20 ();}
		else if (myState == States.vraag_1) {state_vraag_1 ();}
		else if (myState == States.vraag_2) {state_vraag_2 ();}
		else if (myState == States.vraag_3) {state_vraag_3 ();}
		else if (myState == States.vraag_4) {state_vraag_4 ();}
		else if (myState == States.vraag_5) {state_vraag_5 ();}
		else if (myState == States.vraag_6) {state_vraag_6 ();}
		else if (myState == States.vraag_7) {state_vraag_7 ();}
		else if (myState == States.vraag_8) {state_vraag_8 ();}
		else if (myState == States.vraag_9) {state_vraag_9 ();}
		else if (myState == States.vraag_10) {state_vraag_10 ();}
		else if (myState == States.vraag_11) {state_vraag_11 ();}
		else if (myState == States.vraag_12) {state_vraag_12 ();}
		else if (myState == States.vraag_13) {state_vraag_13 ();}
		else if (myState == States.vraag_14) {state_vraag_14 ();}
		else if (myState == States.vraag_15) {state_vraag_15 ();}
		else if (myState == States.vraag_16) {state_vraag_16 ();}
		else if (myState == States.vraag_17) {state_vraag_17 ();}
		else if (myState == States.vraag_18) {state_vraag_18 ();}
		else if (myState == States.vraag_19) {state_vraag_19 ();}
		else if (myState == States.vraag_20) {state_vraag_20 ();}
		else if (myState == States.eind) {state_eind ();}

	}



	void ScoreTeam1 (){
		count1 = count1 + 1;
		scoreTeam1.text = "Team 1: " + count1.ToString ();
	}
	void ScoreTeam2 (){
		count2 = count2 + 1;
		scoreTeam2.text = "Team 2: " + count2.ToString ();
	}

	void state_vraag_1 (){
		quiz.text = "1. Welke twee kleuren staan op de Marrokaanse vlag?\n\n" +
		"Rood en groen\n\n" +
		"Blauw en groen\n\n" +
		"Paars en rood\n\n" +
		"Oranje en paars";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {myState = States.antwoord_1;}
		if (Input.GetKeyDown (KeyCode.Alpha1))	ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.Q)) {myState = States.antwoord_1;}
		if (Input.GetKeyDown (KeyCode.Q))ScoreTeam2 ();	
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_1;}
	}

	void state_antwoord_1 (){
		quiz.text = "\n\n\n Rood en groen";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_2;
		}
	}


	void state_vraag_2 (){
		quiz.text = "2. Wie was de god of godin van de liefde?\n\n" +
		"Zeus\n\n" +
		"Pan\n\n" +
		"Aphrodite\n\n" +
		"Poseidon";
	

		if (Input.GetKeyDown (KeyCode.Alpha3)) {myState = States.antwoord_2;}
		if (Input.GetKeyDown (KeyCode.Alpha3))	ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.antwoord_2;}
		if (Input.GetKeyDown (KeyCode.E))ScoreTeam2 ();	
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_2;}
	}
		
	void state_antwoord_2 (){
		quiz.text = "\n\n\nAphrodite";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_3;
		}
	}
	void state_vraag_3 (){
		quiz.text = "3. Wie heeft de Italiaanse vlag ontworpen?\n\n" +
		"Michelangelo\n\n" +
		"Napoleon\n\n" +
		"Leonardo Da Vinci\n\n" +
		"Picasso\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha2)) {myState = States.antwoord_3;}
		if (Input.GetKeyDown (KeyCode.Alpha2))	ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.W)) {myState = States.antwoord_3;}
		if (Input.GetKeyDown (KeyCode.W))ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_3;}

	}
	void state_antwoord_3 (){
		quiz.text = "\n\n\nNapoleon";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_4;
		}
	}

	void state_vraag_4 (){
		quiz.text = "4. Wat voor uil is de uil van Harry Potter?\n\n" +
			"Ransuil\n\n" +
			"Sneeuwuil\n\n" +
			"Bosuil\n\n" +
			"Kerkuil";

		if (Input.GetKeyDown (KeyCode.Alpha2)) {myState = States.antwoord_4;}
		if (Input.GetKeyDown (KeyCode.Alpha2))	ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.W)) {myState = States.antwoord_4;}
		if (Input.GetKeyDown (KeyCode.W))ScoreTeam2 ();	
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_4;}
	}
	void state_antwoord_4 (){
		quiz.text = "\n\n\nSneeuwuil";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_5;
		}
	}
	void state_vraag_5 (){
		quiz.text = "5. Hoeveel erkende hondenrassen zijn er?\n\n" +
			"356\n\n" +
			"365\n\n" +
			"465\n\n" +
			"456";

		if (Input.GetKeyDown (KeyCode.Alpha2)) {myState = States.antwoord_5;}
		if (Input.GetKeyDown (KeyCode.Alpha2))	ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.W)) {myState = States.antwoord_5;}
		if (Input.GetKeyDown (KeyCode.W))ScoreTeam2 ();	
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_5;}
	}
	void state_antwoord_5 (){
		quiz.text = "\n\n\n365";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_6;
		}
	}
	void state_vraag_6 (){
		quiz.text = "6. Welk land produceert na Nederland de meeste drop?\n\n" +
			"Duitsland\n\n" +
			"Frankrijk\n\n" +
			"Griekenland\n\n" +
			"Spanje\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha4)) {myState = States.antwoord_6;}
		if (Input.GetKeyDown (KeyCode.Alpha4))	ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.R)) {myState = States.antwoord_6;}
		if (Input.GetKeyDown (KeyCode.R))ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_6;}

	}

	void state_antwoord_6 (){
		quiz.text = "\n\n\nSpanje";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_7;
		}
	}

	void state_vraag_7 (){
		quiz.text = "7. In welk jaar werd Google gelanceerd op het internet?\n\n" +
			"1898\n\n" +
			"1635\n\n" +
			"1998\n\n" +
			"2000\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha3)) {myState = States.antwoord_7;}
		if (Input.GetKeyDown (KeyCode.Alpha3))	ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.antwoord_7;}
		if (Input.GetKeyDown (KeyCode.E))ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_7;}
	}
	void state_antwoord_7 (){
		quiz.text = "\n\n\n1998";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_8;
		}
	}
	void state_vraag_8 (){
		quiz.text = "8. Hoeveel snaren heeft een mandoline?\n\n" +
		"4\n\n" +
		"8\n\n" +
		"12\n\n" +
		"16\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha2)) {myState = States.antwoord_8;	}
		if (Input.GetKeyDown (KeyCode.Alpha2))	ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.W)) {myState = States.antwoord_8;}
		if (Input.GetKeyDown (KeyCode.W)) ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_8;}
	}

	void state_antwoord_8 (){
		quiz.text = "\n\n\n4";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_9;
		}
	}
	void state_vraag_9 (){
		quiz.text = "9. Wat voor dieren zijn Fokke en Sukke?\n\n" +
		"Een eend en een kanarie\n\n" +
		"Twee eenden\n\n" +
		"Twee hanen\n\n" +
		"Een kip en een haan\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {myState = States.antwoord_9;}
		if (Input.GetKeyDown (KeyCode.Alpha1))ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.Q)) {myState = States.antwoord_9;}
		if (Input.GetKeyDown (KeyCode.Q)) ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_9;}
	}
	void state_antwoord_9 (){
		quiz.text = "\n\n\nEen eend en een kanarie";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_10;
		}
	}
	void state_vraag_10 (){
		quiz.text = "10. Welke planeet staat tussen Jupiter en Uranus?\n\n" +
			"Mercurius\n\n" +
			"Aarde\n\n" +
			"Saturnus\n\n" +
			"Mars\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha3)) {myState = States.antwoord_10;}
		if (Input.GetKeyDown (KeyCode.Alpha3))ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.antwoord_10;}
		if (Input.GetKeyDown (KeyCode.E)) ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_10;}
	}
	void state_antwoord_10(){
		quiz.text = "\n\n\nSaturnus";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_11;
		}
	}
		
	void state_vraag_11 (){
		quiz.text = "11. Wat is stoplicht in het Spaans?\n\n\n" +
		"Semáforo\n\n" +
		"Stoplicht\n\n" +
		"Luz\n\n" +
		"Panqueue\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {myState = States.antwoord_11;}
		if (Input.GetKeyDown (KeyCode.Alpha1))ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.Q)) {myState = States.antwoord_11;}
		if (Input.GetKeyDown (KeyCode.Q)) ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_11;}
	}

	void state_antwoord_11(){
		quiz.text = "\n\n\nSemáforo";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_12;
		}
	}

	void state_vraag_12 (){
		quiz.text = "12. Welke diersoort heeft het dodelijkste gif ter wereld?\n\n" +
		"Slang\n\n" +
		"Kwal\n\n" +
		"Spin\n\n" +
		"Kikker\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha2)) {myState = States.antwoord_12;}
		if (Input.GetKeyDown (KeyCode.Alpha2))ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.W)) {myState = States.antwoord_12;}
		if (Input.GetKeyDown (KeyCode.W)) ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_12;}
	}

	void state_antwoord_12(){
		quiz.text = "\n\n\nKwal";
		if (Input.GetKeyDown (KeyCode.Return)) {
		myState = States.vraag_13;
		}
	}

	void state_vraag_13 (){
		quiz.text = "13. Hoeveel uur besteed een Reuzenpanda per dag aan eten?\n\n" +
			"10 uur\n\n" +
			"12 uur\n\n" +
			"14 uur\n\n" +
			"16 uur\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha4)) {myState = States.antwoord_13;}
		if (Input.GetKeyDown (KeyCode.Alpha4)) ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.R)) {myState = States.antwoord_13;}
		if (Input.GetKeyDown (KeyCode.R)) ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_13;}
	}

	void state_antwoord_13(){
		quiz.text = "\n\n\n16 uur";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_14;
		}
	}


	void state_vraag_14 (){
		quiz.text = "14. Van hoeveel landen op de wereld is Spaans de moedertaal?\n\n" +
			"23\n\n" +
			"34\n\n" +
			"45\n\n" +
			"54\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {myState = States.antwoord_14;}
		if (Input.GetKeyDown (KeyCode.Alpha1))ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.Q)) {myState = States.antwoord_14;}
		if (Input.GetKeyDown (KeyCode.Q)) ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_14;}
	}

	void state_antwoord_14(){
		quiz.text = "\n\n\n23";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_15;
		}
	}
		
	void state_vraag_15 (){
		quiz.text = "15. In welk werelddeel komt het vogelbekdier voor?\n\n" +
			"Noord-Amerika\n\n" +
			"Australië\n\n" +
			"Azië\n\n" +
			"Afrika\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha2)) {myState = States.antwoord_15;}
		if (Input.GetKeyDown (KeyCode.Alpha2))ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.W)) {myState = States.antwoord_15;}
		if (Input.GetKeyDown (KeyCode.W)) ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_15;}
	}

	void state_antwoord_15(){
		quiz.text = "\n\n\nAustralië";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_16;
		}
	}

	void state_vraag_16 (){
		quiz.text = "Op welk eiland bestel je een 'Pia' als je een biertje wil?\n\n" +
			"Hawaï\n\n" +
			"Cuba\n\n" +
			"Nieuw-Zeeland\n\n" +
			"Malta\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {myState = States.antwoord_16;}
		if (Input.GetKeyDown (KeyCode.Alpha1))ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.Q)) {myState = States.antwoord_16;}
		if (Input.GetKeyDown (KeyCode.Q)) ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_16;}
	}

	void state_antwoord_16(){
		quiz.text = "\n\n\nHawaï";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_17;
		}
	}

	void state_vraag_17 (){
		quiz.text = "17. Hoe heet het hol van een vos?\n\n\n" +
			"Vossenhol\n\n" +
			"Burcht\n\n" +
			"Grot\n\n" +
			"Felix\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha2)) {myState = States.antwoord_17;}
		if (Input.GetKeyDown (KeyCode.Alpha2))ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.W)) {myState = States.antwoord_17;}
		if (Input.GetKeyDown (KeyCode.W)) ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_17;}
	}

	void state_antwoord_17(){
		quiz.text = "\n\n\nBurcht";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_18;
		}
	}


	void state_vraag_18 (){
		quiz.text = "18. Op hoeveel meter staat het wereldrecord verspringen?\n\n" +
			"7,45 meter\n\n" +
			"7,96 meter\n\n" +
			"8,63 meter\n\n" +
			"8,95 meter\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha4)) {myState = States.antwoord_18;}
		if (Input.GetKeyDown (KeyCode.Alpha4))ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.R)) {myState = States.antwoord_18;}
		if (Input.GetKeyDown (KeyCode.R)) ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_18;}
	}

	void state_antwoord_18(){
		quiz.text = "\n\n\n8,95 meter";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_19;
		}
	}


	void state_vraag_19 (){
		quiz.text = "19. In welk jaar was de eerste aflevering van het klokhuis?\n\n" +
			"1946\n\n" +
			"1968\n\n" +
			"1988\n\n" +
			"2000\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha3)) {myState = States.antwoord_19;}
		if (Input.GetKeyDown (KeyCode.Alpha3))ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.antwoord_19;}
		if (Input.GetKeyDown (KeyCode.E)) ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_19;}
	}

	void state_antwoord_19(){
		quiz.text = "\n\n\n1988";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_20;
		}
	}

	void state_vraag_20 (){
		quiz.text = "20.Hoeveel nanometer is 1 meter?\n\n\n" +
			"1.000\n\n" +
			"1.000.000\n\n" +
			"1.000.000.000\n\n" +
			"1.000.000.000.000\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha3)) {myState = States.antwoord_20;}
		if (Input.GetKeyDown (KeyCode.Alpha3))ScoreTeam1 ();
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.antwoord_20;}
		if (Input.GetKeyDown (KeyCode.E)) ScoreTeam2 ();
		if (Input.GetKeyDown (KeyCode.Return)) {myState = States.antwoord_20;}
	}

	void state_antwoord_20(){
		quiz.text = "\n\n\n1.000.000.000";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.eind;

		}
	}

	void state_eind(){
		quiz.text = "Dit is het einde van de Kwikkest Kwis \n\n" +
			"Druk op enter om opnieuw te beginnen";
		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.vraag_1;

		}
	}
}

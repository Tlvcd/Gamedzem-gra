using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorPicker
{
    public static Color[] koloryKwadratow = new Color[64]; //<- zmień tą tablicę, na tablicę naszych kwadratów i wszędzie w skrypcie to pozmieniaj
    public static Color[] Kolorki = new Color[8]
    {
        new Color(1,0,0,1),
        new Color(1, 0.647f, 0,1),
        new Color(0,1,1,1),
        new Color(1,0,1,1),
        new Color(0,0,1,1),
        new Color(0.313f, 0.313f, 0.313f,1),
        new Color(0,1,0,1),
        new Color(1,1,0,1)
    };
    static Color prevColor= Color.black;
    // Start is called before the first frame update
    public static Color GenColor()
    {
        Color currColor = Kolorki[Random.Range(0, 7)];
        Debug.Log(currColor+" "+ Random.Range(0, 7));
        return currColor;
    }

    /*public static void losowanieKolorow()
    {
        int wylosowanyKolor;
        for (int x = 0; x < koloryKwadratow.Length; x++)
        {
            do
            {
                wylosowanyKolor = Random.Range(0, 8);
            }
            while (Kolorki[wylosowanyKolor].iloscUzyc >= 8);
            Kolorki[wylosowanyKolor].iloscUzyc++;
            koloryKwadratow[x] = Kolorki[wylosowanyKolor]; //<- losowanie koloru do kwadratu
        }
        foreach (Kolorek col in Kolorki)
        {
            col.iloscUzyc = 0;
        }
    }*/

    internal static void wybielanieKwadratow()
    {
        for (int x = 0; x < koloryKwadratow.Length; x++)
        {
            koloryKwadratow[x] = Color.white; //<- wybielanie kwadratów
        }
    }
}

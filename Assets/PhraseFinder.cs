using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KModkit;
using rnd = UnityEngine.Random;
public class PhraseFinder : MonoBehaviour {
    public KMSelectable button;
    public TextMesh text;
    public MeshRenderer[] leds;
    public Material[] ledStates;
    string[] table = new string[] {
"SCZ09ZVUNKGDWDY7LDNJCTRT6Z2DPR56JLDQR7KNXX80J8CHRQSU70LJGKAVFYM0KPBT0U",
"3HWFQONMW68MI4Y25GNAI3E5JYCH3UK9MW7ZSFA8SJR80QJ1P8DXNIBT0XAPBMQEKWBGL8",
"5ICZD1MT5XVZZIXZPCL2Y2GPMFBMUXQJD2P7547I0IL8TUUHHC7GEMGUP7BIJUGCZVY3JK",
"LDRY7CLWGS4BUTFOVG6AIOYP2STRL6S3JKV6YCA4S8Q5ORXVLLUH8RD7A1PMKK9EURWPP2",
"MTBAELPY0ZU9VL7ASVJAF0W2VCL4UOVHM5G5M1LRDS2O1N1LBOGSI3VNFYW4T2DZ794O4N",
"277QVAJZP45EBKQ808GUBCPRMCJ3LAB1WJS5ABIH1SEHSYL15QMLE8P9WVJ0XOSWFDYCKT",
"3K3YSSK2NED30YOCSIB1AJOGWW27KV9POZ8DS6M5QPHK8JH6SXLQYHLROX74ZGPPSPB26I",
"X9IQYXHFV8C8768V8YPCTETWPM3EDX3MYZIGJ8UY4VMHXPS969X5RU7UULLGS8CY9CDSKC",
"0ZGTEQ5DCLVQCAUA1DM87DPZON8721RHGN61Q0U5VBMNXB8RAMIQEDX025MPBPJR42RIF4",
"ZZYHRFAPVG9KS2EZ3XL8Y9LG5KZS90VU6E5ETAKFJ8WY2KGT9HUPZQFW84HBOPRMCSCGVB",
"XYNETTDECVOOVNF0OOLUQM7WLFRB7XS3KT5HE2IH5FCRQCCFOWKGXVDDBSEGFPGDS5NK3T",
"0DLAUFUUJHIUUCSKOOO13FNUJCSMRLXL19FUA7OVIU8NKXK96T52G4G6J2J65NUFIBBXN6",
"KS3DI5FC9511YZF661T3UTOQAWTPBZOMB9KIWOO0A2B62CAA16320VDX0IM8XV9NTKK02A",
"C76590IINKTI3GXFIOACIAYJFVE5T6609FFXM73MBJ51IVJKWBOFXX8A1XFKR8RJLCFQJP",
"092Z0E4U1X02DBCHEORZP2H6IV1X4Y74FACROSQG55RHI45C175JAADUCBPQOXAST5ZIPE",
"SZA2B72UZORCMI2F43V3O0TZGIX262XOXI7RFLRH28AE1SZ62SLHIRNQNHB1TXP0ILAGE9",
"CNMZCHXICXMO5KS7PAAARI8NV86EYS5OTPOMAZZYAFHUVOR1T8NNMNSCNIM8HRGITBIKYD",
"LNXYF4OMI0PUOWQ1RINEHIS7QMBT8B6K5N760772Q226LP5JFRR974XVU34YY5T7YA1E94",
"JWFNJ4MQS5VI0PUJ7QLVSKNJZMYV1SCOV9OZ3E4XS4798MZPTNKO2HWFACX7XUWOC8RKKC",
"A0GUHAZO303EXHMRCPE92KVGSDXTIGDY6IENCWOT0DLQ5S38D68XCDWA7FQOGTIK5WCDYU",
"APNU5XJ8Q3U8RI9GYOC5UTR69KRLS7MV2CVAI5AD5BT7EQS7081JDD15Y3IWAZYQF79R5D",
"W9WTEMHG28SM5VUV86FOZOW8R6AEP26TQERL2BSVAIGYL4VFG1EXVW52AVFF2FGULCUOXC",
"XNG3ZOT8KL5SCS4Q2BCQIF68WN4RJKYRT9VF9EN7W5V2DMIR7472HHVLIJ67IB9NRZ9JPI",
"LAUUH8VTHG4DQ8IURIYJ14HXNOGPNOGJL58VRJROGJ47MVWQYMI2U3K97UGCX89J4KEDR2",
"NEX228R9JM4FKIVNBM846CSD7E4J1YKO7NF7C3LJ2H45T7PN3LA6UDDHTOXKT17F4KI6I9",
"18FB80879JDDRZG9ES82RAFPY95TXQJZR6E7HVY1C4FHDYQKHEXKLA5RUN8XNLUR8OX7LT",
"0ROEUGSMEQNSHHHC4WP6WAXWNXK14ORCZZW6D8TPUK6Y6Z7JK5PV5SN9C9Q5L6SMRQM6FS",
"E7017N8LO0DST54K22T2OGL4ORS8QQVIKDG64TC8FZIOBAGTLKVFXAVOQ331ZOJY5R9KHS",
"XTSKLGMME6YMS03G0WSMF58PLX0R3P8ASDN5WEFGJZQDA20ARHWCFUAUH3Q2Z27NTF9IK1",
"WW5K5YVY1Y2L04VE8QOH3HTJU9OI9RLE7ML0AEMP16KJQOOTPN5JLZ2FBY3O616T3G3IM7",
"PPQKQKHR48IGZT01D51K8K8BMA4ZGLXW2ZY7JRKZOMZ81E1HHTXA275PM89YNKQAKWE01M",
"5S0RQRJGYGSKF049E1YU5A9EL2ETDBGMKI25YDGW7AXXMPA1JZCPOCW2BHY3EJ5FYIY7CW",
"U0K9BGTRG4X31JWIDF4DS1JFLRTKKY5CY6EG0N4FTZBFLB6OH3YZ301TW98315B5QKSSB6",
"MTEFPS2K5PQR7V7H9EK0P3B9KMGNJEP7GAL5LK66A9H7FOKDVQ8991YCA42JHJWR183JX1",
"GMJC5A14VFEUEXM368VYE6A3SJO45H7XKW3V8PB6UKCUXH554SKAR4R37ZKZ3EDZU5920W",
"R0XQ0BT6UPY1GOQN6HVM324OGHL4CWHNS44FXJQ2JDFV5U4YRGSW2X905JQLHS3YDKFNK8",
"ZNTJHUQ4REHZNG4BKQ74UO9BYNEB7ZF1ICK24JKHXVJ7PLO2P1X9JEJ962CM9PX3J9COBY",
"BS2LGTJ4GIJZA3NUUM7ASE5QYJUZPA5ZBE03XXFQTVBTW815C3H1JD1XDHRVK2IAN2CVT8",
"N8S0HBIAZ5NMZ2YN8AUQAPIA5658GXE0G9GZP2VYWT3N9QXNADQ61IPNQU4XT3D8EKJK61",
"FW2PKFWYN66K60DNPGZJY6DV2P723RPORL3U9P4T49PZSKL5EXMC0UJIKHXYLKBKR3LYY6"};
    int[] rowNumbers = new int[] {2,3,5,7,4,8,2,6,4,8,3,1,8,9,6,5,0,1,9,0,1,5,2,8,1,6,7,3,0,7,7,0,4,5,2,3,1,9,5,2};
    int[] colNumbers = new int[] {7,6,2,9,4,7,1,0,9,4,6,4,2,7,4,8,5,9,6,0,1,5,2,8,5,8,3,6,5,4,2,0,6,7,3,9,1,0,1,1,7,2,8,9,3,3,0,4,4,9,8,8,2,0,1,0,5,0,0,3,7,9,9,1,6,4,2,5,3,8};
    int[] startingPos = new int[2];
    int[] endingPos = new int[2];
    int[] validTimes = new int[2];
    int stage;
    public KMBombModule module;
    public KMBombInfo bomb;
    public KMAudio sound;
    int moduleId;
    static int moduleIdCounter = 1;
    bool solved;
    // Use this for initialization
    void Awake () {
        moduleId = moduleIdCounter++;
        button.OnInteract += delegate { PressButton(); return false; };
        module.OnActivate += delegate { GeneratePhrase(); GenerateValidTimes(); };
        Debug.Log(table[0].Length);
	}

	void GeneratePhrase()
    {
        StringBuilder phrase = new StringBuilder("      ");
        int a1;
        int a2;
        int b1;
        int b2;
        int rowIncrement;
        int columnIncrement;
        int readingMethod = rnd.Range(0, 4);
        int reversed = rnd.Range(0, 2);
        switch (readingMethod)
        {
            case 0:
                a1 = rnd.Range(0, 40);
                a2 = rnd.Range(0, 64);
                b1 = a1;
                b2 = a2 + 6;
                rowIncrement = 0;
                columnIncrement = 1;
                break;
            case 1:
                a1 = rnd.Range(0, 34);
                a2 = rnd.Range(0, 70);
                b1 = a1 + 6;
                b2 = a2;
                rowIncrement = 1;
                columnIncrement = 0;
                break;
            case 2:
                a1 = rnd.Range(0, 34);
                a2 = rnd.Range(0, 64);
                b1 = a1 + 6;
                b2 = a2 + 6;
                rowIncrement = 1;
                columnIncrement = 1;
                break;
            default:
                a1 = rnd.Range(0, 34);
                a2 = rnd.Range(6, 70);
                b1 = a1 + 6;
                b2 = a2 - 6;
                rowIncrement = 1;
                columnIncrement = -1;
                break;
        }
        int temp1 = a1;
        int temp2 = a2;
        for (int i = 0; i < 6; i++)
        {
            phrase[i] = table[temp1][temp2];
            temp1 += rowIncrement;
            temp2 += columnIncrement;
        }
        text.text = phrase.ToString();
        if (reversed == 1)
        {
            List<char> hmm = text.text.ToList();
            hmm.Reverse();
            text.text = hmm.Join("");
            startingPos[0] = b1;
            startingPos[1] = b2;
            endingPos[0] = a1;
            endingPos[1] = a2;
        }
        else
        {
            startingPos[0] = a1;
            startingPos[1] = a2;
            endingPos[0] = b1;
            endingPos[1] = b2;
        }
        Debug.LogFormat("[Phrase Finder #{0}] The phrase on the module is {1}, which starts at ({2}) and ends at ({3})", moduleId, text.text, startingPos.Join(","), endingPos.Join(","));
    }
    void GenerateValidTimes()
    {
        bool digitMapping = bomb.GetIndicators().Count() % 2 == 0;
        if (digitMapping)
        {
            validTimes[0] = 10 * (startingPos[0] % 6) + startingPos[1];
            validTimes[1] = 10 * (endingPos[0] % 6) + endingPos[1];
        }
        else
        {
            validTimes[0] = 10 * (startingPos[1] % 6) + startingPos[0];
            validTimes[1] = 10 * (endingPos[1] % 6) + endingPos[0];
        }
        Debug.LogFormat("[Phrase Finder #{0}] The button should be pressed when the seconds digits are {1}, in order.", moduleId, validTimes.Join(" and "));
    }
	// Update is called once per frame
	void PressButton () {
		if (!solved)
        {
            button.AddInteractionPunch();
            Debug.LogFormat("[Phrase Finder #{0}] You pressed the button at {1}.", moduleId, bomb.GetFormattedTime());
            if ((int)bomb.GetTime() % 60 == validTimes[stage])
            {
                Debug.LogFormat("[Phrase Finder #{0}] That was correct.", moduleId);
                leds[stage].material = ledStates[1];
                stage++;
                sound.PlaySoundAtTransform("Spacey Sound ;)", transform);
                if (stage == 2)
                {
                    module.HandlePass();
                    Debug.LogFormat("[Phrase Finder #{0}] Module solved.", moduleId);
                    solved = true;
                }
            }
            else StartCoroutine(StrikeFlash());
        }
	}
    IEnumerator StrikeFlash()
    {
        int count = 0;
        while (count < 3)
        {
            yield return new WaitForSeconds(0.1f);
            leds[stage].material = ledStates[2];
            yield return new WaitForSeconds(0.1f);
            leds[stage].material = ledStates[0];
            count++;
        }
        Debug.LogFormat("[PhraseFinder #{0}] That was incorrect. Strike!", moduleId);
        module.HandleStrike();
        yield break;
    }
}

# 🎓 Examenoefening: Typewriter Art (Recept naar ASCII-afbeelding)

## 🧩 Probleemstelling
Vroeger maakten mensen creatieve ASCII-afbeeldingen met een typemachine, waarbij ze eenvoudige "recepten" gebruikten die bij het uittypen een afbeelding onthulden.

In deze oefening krijg je zo’n recept. Je taak is om dit recept om te zetten naar een herkenbare ASCII-afbeelding, lijn per lijn opgebouwd.

---

## 📥 Invoer

Je moet onderstaande methode schrijven:

```csharp
private static string DoConvert(string inp)
```
### Parameter:
- string inp: een string bestaande uit instructies, gescheiden door spaties. Elke instructie (ook wel "chunk" genoemd) bepaalt wat er op het scherm komt.


## 🔧 Betekenis van de instructies
Elke chunk in het recept geeft aan wat er getoond moet worden:

### Soorten chunks
- nl: een nieuwe lijn (new line / carriage return)
- getal + afkorting/karakter: herhaal het karakter zoveel keer
- getal zonder expliciet karakter: herhaal de laatste cijfer zoveel keer

### Voorbeelden
|Chunk|	Betekenis|	Resultaat|
|:---:|:---:|:--:|
|4z	|4 keer 'z'	|zzzz|
|10=|	10 keer '='|	==========|
|1{	|1 keer '{'	|{|
|2sp|	2 spaties|	|
|3bS|	3 keer backslash (\)|	\\\\\\\\ |
|4sQ|	4 keer '	|''''|
|123|	12 keer '3'|	333333333333|

### Afkortingen:
|Afkorting	|Karakter|
|:---:|:---:|
|sp|	spatie|
|bS|	\\ |
|sQ|	' |
|nl|	nieuwe regel (\r\n)|

## 📤 Verwachte uitvoer
Je methode geeft één string terug bestaande uit meerdere regels (\r\n), die samen een ASCII-afbeelding vormen.

## 📌 Voorbeeld
#### Invoer
```
string inp = "1sp 1/ 1bS 1_ 1/ 1bS nl 1( 1sp 1o 1. 1o 1sp 1) nl 1sp 1> 1sp 1^ 1sp 1< nl 2sp 3|";
```
#### Verwachte uitvoer
```
/\_/\
( o.o )
 > ^ <
  |||
```
Let op: de string bevat \r\n voor nieuwe regels. Er mogen geen extra spaties of lege regels zijn aan het einde.

## ✅ Evaluatiecriteria
- Correcte parsing van de chunks (inclusief afkortingen).
- Juiste verwerking van getallen zonder expliciet karakter (laatste cijfer gebruiken).
- Correcte verwerking van nl als nieuwe regel (\n).
- Alle regels zijn correct opgebouwd volgens het recept.
- Methode retourneert één string met correcte opmaak (inclusief line breaks, zonder gebruik van Console.WriteLine).

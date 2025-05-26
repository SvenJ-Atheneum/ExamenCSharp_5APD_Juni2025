# 🎓 Examenoefening: Ghost Legs (Spooktrappen)

## 🧩 Probleemstelling
In deze oefening ga je een **Ghost Legs**-diagram analyseren. Dit is een type doolhof dat bestaat uit verticale lijnen met willekeurige horizontale verbindingen ertussen. Een pad begint bij een bovenste label en volgt de lijnen naar beneden, waarbij horizontale lijnen het pad naar links of rechts leiden.

Je taak is om alle koppelingen tussen de bovenste en onderste labels te bepalen.

---

## 📥 Invoer

Je krijgt de volgende parameters via een methode:

```csharp
static string CreateAnswer(int W, int H, string[] lines)
```

### Parameters:
int W: de breedte van het diagram (aantal kolommen in de string).
int H: de hoogte van het diagram (aantal regels).
string[] lines: een array met H strings van elk W tekens die het hele Ghost Legs-diagram voorstellen.

### Structuur van lines:
lines[0]: de bovenste labels (1 teken per kolom).
lines[H - 1]: de onderste labels (1 teken per kolom).

De regels daartussen bestaan uit:
* verticale lijnen | (deze geven de kolommen aan waar het pad naar beneden loopt),
* horizontale lijnen - (deze verbinden twee verticale lijnen),
* spaties (zonder betekenis).

## 🎯 Doel
Bepaal voor elke bovenste label via het pad naar beneden de bijbehorende onderste label, en geef de bijhorende paren weer.
De output is één string met alle paren aan elkaar geplakt, in de volgorde van de bovenste labels van links naar rechts.

## 📤 Verwachte uitvoer
Je methode geeft een string terug waarin elke combinatie van bovenste en onderste label wordt weergegeven, zonder spaties of nieuwe regels.
__Voorbeeldinvoer__
```
int W = 7;
int H = 7;
string[] lines = new string[]
{
    "A  B  C",
    "|  |  |",
    "|--|  |",
    "|  |--|",
    "|  |--|",
    "|  |  |",
    "1  2  3"
};
```
__Verwachte uitvoer__
```
"A2B1C3"
```
## ✅ Evaluatiecriteria
* Correcte verwerking van het pad: bij elke horizontale lijn moet het pad van kolom wisselen.
* Juiste mapping tussen bovenste en onderste labels.
* Output is één string met alle paren in de juiste volgorde.
* De methode heeft exact de signatuur zoals opgegeven.
* Geen gebruik van console-invoer/-uitvoer in de methode zelf.

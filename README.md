# 🧱 BLOC1.PA03 - CODEQUEST DLC

## ⚙️ Requisits del Proyecte
- Tots els codis tenen que incluir **control d'errors**
- La codificació ha de estar en **anglés** (missatges, comentaris, variables, constants)
- Cada capitul ha de definir un **joc de proves** per al debug
- S'ha de gestionar **issues** i **Pull Requests (PR)** per cada capitol
- El repositori ha d'incluir un **README amb Markdown** que descriura el proyecte i el joc de proves

# ACTIVITAT: CODEQUEST - JOC DE ROL PER CONSOLA
  
## 📜 Descripció General
**CodeQuest** és un RPG de consola desenvolupat en **C#**, on el jugador controla un mag capaç de:
- Entrenar per augmentar el seu nivell
- Combatre monstres i guanyar experiència
- Minar recursos (*bits*, la moneda del joc)
- Comprar objectes per millorar el seu inventari
- Descobrir i resoldre pergamins antics
  
El joc compta amb un **menú principal de 7 opcions** + l’opció de sortir.  
Cada capítol està implementat en una branca específica:
- `chapter/trainwizard`
- `chapter/increaselvl`
- `chapter/lootthemine`
- `chapter/showinventory`
- `chapter/buyitems`
- `chapter/showattacks`
- `chapter/decodescroll`

## 🕹️ Menú Principal
El menu es mostrara repetidament fins que l'usuari escull sortir:  

===== MAIN MENU - CODEQUEST =====  
===== Welcome, [NOM] the [TÍTOL] with level [NIVELL] =====  
Train your wizard - Entrenar el mag  
Increase LVL - Combatre i pujar de nivell  
Loot the mine - Minar per aconseguir bits (moneda del joc)  
Show inventory - Mostrar inventari  
Buy items - Comprar objectes  
Show attacks by LVL - Veure atacs disponibles segons el nivell  
Decode ancient Scroll - Desxifrar pergamins màgics  
Exit game - Sortir  


## 🔧 Funcionalitats per Opció

### 0️⃣ Cas Main Joc de Proves
|#|Categoria|Entrada (op)|Variables Clau (Abans)|Condició/Lògica|Variables Clau (Després)|Resultat Esperat|
|:----|:----|:----|:----|:----|:----|:----|
|1|Normal|1 (Train wizard)|op=0, validInput=true|try-catch és reeixit. switch executa case 1.|op=1, validInput=true|Executa el cas 1 (Entrenament). El bucle continua.|
|2|Normal|4 (Show inventory)|op=1, validInput=true|try-catch és reeixit. switch executa case 4.|op=4, validInput=true|Executa el cas 4 (Inventari). El bucle continua.|
|3|Normal|7 (Decode Scroll)|op=4, validInput=true|try-catch és reeixit. switch executa case 7.|op=7, validInput=true|Executa el cas 7 (Descodificació). El bucle continua.|
|---|---|---|---|---|---|---|
|4|Límit (Sortida)|0 (Exit Game)|op=7, validInput=true|try-catch és reeixit. switch executa case 0. Condició op != 0 és FALSE.|op=0, validInput=true|El joc surt del bucle principal (do-while).|
|5|Límit (Superior)|7|op=0, validInput=true|try-catch és reeixit. switch executa case 7.|op=7, validInput=true|Executa el cas 7. El bucle continua.|
|---|---|---|---|---|---|---|
|6|Error (Fora de Rang Alt)|8|op=7, validInput=true|try-catch és reeixit. switch executa el default (implícit).|op=8, validInput=true|Repeteix el menú sense executar cap acció, ja que op != 0 és TRUE.|
|7|Error (Format - Text)|"A"|op=8, validInput=true|Falla a Convert.ToInt32 (FormatException). S'atrapa l'error, s'imprimeix ChooseOptionError i s'estableix validInput = false.|op=8 (manté valor anterior), validInput=false|Imprimeix el missatge d'error i repeteix el menú.|
|8|Error (Format - Decimal)|3.5|op=8, validInput=false|Falla a Convert.ToInt32 (FormatException). S'atrapa l'error i s'estableix validInput = false.|op=8 (manté valor anterior), validInput=false|Imprimeix el missatge d'error i repeteix el menú.|


### 1️⃣ Train your wizard
- Demana el **nom del mag** i el capitalitza.
- Simula **5 dies d’entrenament** generant:
  - Hores d’entrenament (1–24)
  - Punts de poder (1–10)
- Segons el total acumulat, assigna un **títol**:

| Punts de Poder | Títol | Missatge |
|----------------|-------|----------|
| < 20 | Raoden el Elantrí | Repeteixes a 2a convocatòria. |
| 20-29 | Zyn el Buguejat | Encara confons la vareta amb una cullera. |
| 30-34 | Arka Nullpointer | Ets un Invocador de Brises Màgiques. |
| 35-39 | Elarion de les Brases | Uau! Pots invocar dracs sense cremar el laboratori! |
| ≥ 40 | ITB-Wizard el Gris | Has assolit el rang de Mestre dels Arcans! |

---

### 2️⃣ Increase LVL (Combat amb daus)
- Apareix un **monstre aleatori** amb HP específics.
- El jugador tira un dau (1–6) amb ASCII art.
- El resultat = dany infligit al monstre.
- Si el monstre arriba a 0 HP → **el jugador puja de nivell** (fins a 5).

| Monstre | HP |
|---------|----|
| Wandering Skeleton 💀 | 3 |
| Forest Goblin 👹 | 5 |
| Green Slime 🟢 | 10 |
| Ember Wolf 🐺 | 11 |
| Giant Spider 🕷️ | 18 |
| Iron Golem 🤖 | 15 |
| Lost Necromancer 🧝‍♂️ | 20 |
| Ancient Dragon 🐉 | 50 |

---

### 3️⃣ Loot the mine (Mineria)
- Matriu **5x5** inicialment buida.
- Jugador amb **5 intents**.
- Introducció de coordenades X i Y.
- Si encerta una posició amb moneda: → guanya entre **5 i 50 bits**.
  - `➖` = No excavat  
  - `🪙` = Moneda trobada  
  - `❌` = Excavació sense èxit

---

### 4️⃣ Show inventory
- Mostra els objectes comprats.
- Si està buit → informa l’usuari.

---

### 5️⃣ Buy items
- Mostra objectes disponibles i preus.  
- Compra si té prou bits i s’actualitza l’inventari.

| Objecte | Preu (bits) |
|---------|-------------|
| Iron Dagger 🗡️ | 30 |
| Healing Potion ⚗️ | 10 |
| Ancient Key 🗝️ | 50 |
| Crossbow 🏹 | 40 |
| Metal Shield 🛡️ | 20 |

- Si el jugador té prou bits:
  - es descompta el preu
  - s’afegeix el producte a l’inventari (array ampliable)

 ---

### 6️⃣ Show attacks by LVL
- Mostra els atacs disponibles segons el nivell del mag:

| Nivell | Atacs |
|--------|-------|
| 1 | Magic Spark 💫 |
| 2 | Fireball 🔥, Ice Ray 🥏, Arcane Shield ⚕️ |
| 3 | Meteor ☄️, Pure Energy Explosion 💥, Minor Charm 🎭, Air Strike 🍃 |
| 4 | Wave of Light ⚜️, Storm of Wings 🐦 |
| 5 | Cataclysm 🌋, Portal of Chaos 🌀, Arcane Blood Pact 🩸, Elemental Storm ⛈️ |

---

### 7️⃣ Decode ancient Scroll
- Tres sub-opcions:
  1. Eliminar espais del primer pergamí
  2. Comptar vocals (incloses accentuades) del segon pergamí
  3. Extreure números del tercer pergamí
- Quan es completen, mostra missatge d’èxit.

---

## 📦 Arrays Fixos
- **Objectes per comprar:** Iron Dagger 🗡️, Healing Potion ⚗️, Ancient Key 🗝️, Crossbow 🏹, Metal Shield 🛡️  
- **Monstres:** Wandering Skeleton 💀, Forest Goblin 👹, Green Slime 🟢, Ember Wolf 🐺, Giant Spider 🕷️, Iron Golem 🤖, Lost Necromancer 🧝‍♂️, Ancient Dragon 🐉  
- **Atacs per nivell:** veure taula de l’opció 6.
  
## 🧩 Reptes Opcionals
- Guardar i carregar partides utilitzant fitxers.
- Sistema de combat més complex: el monstre també ataca, els atacs tenen cost de poder.
- Objectes amb efecte al combat.
- Botiga amb objectes variables segons el nivell del mag.
- Ús de colors a la consola.
- Sistema de missions amb recompenses.

## ✨ Conclusió
**CodeQuest** és un projecte complet que combina estructures de control, arrays, validació d’errors, i organització per branques, tot dins d’un joc de consola entretingut i ampliable.





# BLOC1.PA03 - CODEQUEST DLC

## ⚙️ Requisits del Proyecte
- Tots els codis tenen que incluir **control d'errors**
- La codificació ha de estar en **anglés** (missatges, comentaris, variables, constants)
- Cada capitul ha de definir un **joc de proves** per al debug
- S'ha de gestionar **issues** i **Pull Requests (PR)** per cada capitol
- El repositori ha d'incluir un **README amb Markdown** que descriura el proyecte i el joc de proves

# ACTIVITAT: CODEQUEST - JOC DE ROL PER CONSOLA
  
## 📜 Descripció General
**CodeQuest** es un joc de rol (RPG) per consola desarollat en **C#**, on el jugador controlar el que un mag pot fer: 
- Entrenar i aumentar el seu nivell
- Conseguir recursos(bits, la moneda del joc)
- Comprar objectes i millorar el seu inventari
- Descifrar pergamins antics
  
El joc inclueix un **menu principals amb 7 opcions funcionals** mes la opcio de sortir. Cada capitol es tindra que organitzar en rames especifiques, d'aquesta manera:
- chapter/trainwizard
- chapter/increaselvl
- chapter/lootthemine
- chapter/showinventory
- chapter/buyitems
- chapter/showattacks
- chapter/decodescroll

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

### 1️⃣ Train your wizard
- Demana el nom del mag i el capitalitza correctament.
- Simula **5 dies d’entrenament**, generant aleatòriament hores d’entrenament i punts de poder.
- Assigna un **títol/rang** segons els punts de poder acumulats:

| Punts de Poder | Títol | Missatge |
|----------------|-------|----------|
| < 20 | Raoden el Elantrí | Repeteixes a 2a convocatòria. |
| 20-29 | Zyn el Buguejat | Encara confons la vareta amb una cullera. |
| 30-34 | Arka Nullpointer | Ets un Invocador de Brises Màgiques. |
| 35-39 | Elarion de les Brases | Uau! Pots invocar dracs sense cremar el laboratori! |
| ≥ 40 | ITB-Wizard el Gris | Has assolit el rang de Mestre dels Arcans! |

### 2️⃣ Increase LVL (Combat amb daus)
- Apareix un **monstre aleatori** amb punts de vida (HP).
- El jugador tira un dau (1–6) per atacar, mostrant l’ASCII art del dau.
- Quan el HP del monstre arriba a 0, el jugador puja de nivell (màx. 5).

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

### 3️⃣ Loot the mine (Mineria)
- Matriu 5x5 inicial buida, amb **5 intents de mineria**.
- L’usuari introdueix coordenades X, Y.
- Monedes aleatòries: si encerta, guanya entre 5 i 50 bits.
- Símbols a la matriu:  
  - `➖` = No excavat  
  - `🪙` = Moneda trobada  
  - `❌` = Excavació sense èxit

### 4️⃣ Show inventory
- Mostra els objectes comprats.
- Indica si l’inventari està buit.

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

### 6️⃣ Show attacks by LVL
- Mostra els atacs disponibles segons el nivell del mag:

| Nivell | Atacs |
|--------|-------|
| 1 | Magic Spark 💫 |
| 2 | Fireball 🔥, Ice Ray 🥏, Arcane Shield ⚕️ |
| 3 | Meteor ☄️, Pure Energy Explosion 💥, Minor Charm 🎭, Air Strike 🍃 |
| 4 | Wave of Light ⚜️, Storm of Wings 🐦 |
| 5 | Cataclysm 🌋, Portal of Chaos 🌀, Arcane Blood Pact 🩸, Elemental Storm ⛈️ |

### 7️⃣ Decode ancient Scroll
- Tres sub-opcions:
  1. Eliminar espais del primer pergamí
  2. Comptar vocals (incloses accentuades) del segon pergamí
  3. Extreure números del tercer pergamí
- Quan es completen, mostra missatge d’èxit.

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




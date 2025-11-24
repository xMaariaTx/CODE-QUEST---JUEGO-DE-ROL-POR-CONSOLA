## Capítol 4️⃣ - Show Inventory
**Resum de l’enunciat:**  
- Mostra tots els objectes comprats.  
- Si l’inventari està buit, mostra missatge indicatiu.

**Implementació al codi:**  
- Comprova la longitud de `inventory`.  
- Si està buit → `MessageEmptyInventory`.  
- Si té elements → llista tots els objectes.

**Joc de proves**
|#|Categoria|Variables Clau Internes|Condició/Lògica Provada|Variables Clau (Després)|Resultat Esperat|
|:----|:----|:----|:----|:----|:----|
|1|Normal (Buit)|inventory = new string[0]|La condició inventory.Length == 0 és TRUE.|Sense canvis.|S'imprimeix el missatge: "Your inventory is empty" (MessageEmptyInventory).|
|2|Normal (Ple)|inventory = {"Dagger 🗡️", "Potion ⚗️"}|La condició inventory.Length == 0 és FALSE.|Sense canvis.|S'imprimeix el missatge de capçalera (MessageInventory) i es llisten correctament tots els elements de l'array.|
|---|---|---|---|---|---|
|3|Límit (Mínim)|inventory = {"Key 🗝️"}|La longitud és 1. La condició és FALSE.|Sense canvis.|S'imprimeix el missatge de capçalera i l'únic element de l'inventari.|
|4|Límit (Màxim)|inventory conté el màxim d'elements que el sistema permet (depèn de la memòria, però aquí se simula una llista gran).|La condició és FALSE.|Sense canvis.|S'imprimeixen correctament tots els elements sense errors d'índex.|
|---|---|---|---|---|---|
|5|Error (Nul)|inventory = null|S'intenta accedir a inventory.Length sobre una variable nul·la.|Error d'Execució.|Resultat real: El programa crashtja amb una NullReferenceException perquè intenta accedir a la propietat .Length d'un objecte que no existeix. (Això només passaria si una altra part del codi assignés null a inventory, cosa que no passa al codi proporcionat, ja que s'inicialitza com a new string[0]).|

## Capítol 5️⃣ - Buy Items
**Resum de l’enunciat:**  
- Mostra objectes disponibles amb preus.  
- Permet comprar si hi ha prou bits.  
- Actualitza inventari i resta bits.

**Implementació al codi:**  
- Mostra llista d’objectes i bits disponibles.  
- Llegeix selecció amb validació.  
- Comprova si hi ha suficients bits:  
  - Si sí, resta bits i afegeix l’objecte a `inventory` expandint l’array.  
  - Si no, mostra missatge d’error.

**Joc de proves**
|#|Categoria|Variables Clau (Abans)|Entrada (userSelection)|Lògica de Validació|Variables Clau (Després)|Resultat Esperat|
|:----|:----|:----|:----|:----|:----|:----|
|1|Normal (Compra Èxit)|bitsUsers = 100|1 (Daga, preu 30)|Entrada vàlida. bitsUsers >= objectsPrice[0] (100 >= 30) és TRUE.|bitsUsers = 70. inventory.Length augmenta en 1.|Compra exitosa. S'afegeix l'ítem i es descompten els bits.|
|2|Normal (Sortida)|bitsUsers = 50|0 (Sortir)|Entrada vàlida. userSelection == 0 és TRUE.|bitsUsers = 50 (sense canvis).|S'imprimeix MessageExitShop i se surt del bucle while de compra.|
|3|Límit (Manca de Bits)|bitsUsers = 5|1 (Daga, preu 30)|Entrada vàlida. bitsUsers < objectsPrice[0] (5 < 30) és FALSE.|bitsUsers = 5 (sense canvis).|S'imprimeix: "You do not have enough bits to purchase this item." (MessageNoBits).|
|4|Límit (Opció 5)|bitsUsers = 100|5 (Escut Metàl·lic, preu 20)|Límit superior de compra (opció 5). Compra exitosa.|bitsUsers = 80. inventory.Length augmenta en 1.|Compra exitosa.|
|---|---|---|---|---|---|---|
|5|Error (Format)|validInputFive = false|"Bossa"|Falla en Convert.ToInt32 (FormatException). Es captura, s'imprimeix ChooseOptionError.|validInputFive = false|Imprimeix error de format i el bucle while es repeteix, sol·licitant l'entrada de nou.|
|6|Error (Rang Alt)|validInputFive = false|6|Falla la validació (`if (userSelection < 0| |userSelection > 5)). S'imprimeix MessageInputError`.|
|7|Error (Rang Baix)|validInputFive = false|-1|Falla la validació (`if (userSelection < 0| |userSelection > 5)). S'imprimeix MessageInputError`.|

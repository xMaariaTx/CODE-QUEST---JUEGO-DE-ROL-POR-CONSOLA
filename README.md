## Capítol 3️⃣ - Loot the Mine (Mineria)

**Objectiu:** Permetre al jugador buscar monedes a una matriu 5x5.  

**Funcionament:**
- Matriu visible (`matrixVisble`) buida i matriu oculta (`matrixVisbleThings`) amb monedes.  
- Col·loca aleatòriament `coinNumber = 8` monedes.  
- L’usuari té 5 intents per introduir coordenades (X,Y).  
- Si troba moneda, guanya entre 5–50 bits.  
- Mostra matriu després de cada intent:  
  - `➖` no excavat  
  - `🪙` moneda trobada  
  - `❌` sense èxit

**Implementació al codi:**  
- Inicialitza matrius i col·loca monedes amb bucle `for`.  
- Bucle principal d’intents amb validació de coordenades.  
- Actualitza matriu visible i suma bits segons resultat.

**Joc de proves**
|#|Categoria|Entrada X|Entrada Y|Lògica de Validació|Variables Clau (Després)|Resultat Esperat|
|:----|:----|:----|:----|:----|:----|:----|
|1|Normal|2|3|Ambdues entrades numèriques són vàlides (0≤x≤4, 0≤y≤4). validRowInput i validColInput són TRUE.|x=2, y=3, validRowInput=true, validColInput=true|Es realitza l'acció de mineria a la posició [2, 3] (es busca 🪙 i s'actualitza matrixVisible).|
|2|Límit (Baix)|0|0|Coordenades al límit inferior. Ambdues són vàlides.|x=0, y=0, validRowInput=true, validColInput=true|Es realitza l'acció de mineria a la cantonada [0, 0].|
|3|Límit (Alt)|4|4|Coordenades al límit superior. Ambdues són vàlides.|x=4, y=4, validRowInput=true, validColInput=true|Es realitza l'acció de mineria a la cantonada [4, 4].|
|---|---|---|---|---|---|---|
|4|Error (X Fora de Rang Alt)|5|2|X falla la validació inicial (if (x < 0 \|\| x > 4)). S'imprimeix MessageInvalidRow. El bucle while (!validRowInput) es repeteix.|x=5 (temporal), y=2 (temporal), validRowInput=false|Es mostra l'error de fila i es sol·licita X novament.|
|5|Error (Y Fora de Rang Baix)|1|-1|X ja va ser validada. Y falla la validació inicial (if (y < 0 \|\| y > 4)). S'imprimeix MessageInvalidCol. El bucle while (!validColInput) es repeteix.|x=1 (validat), y=-1 (temporal), validColInput=false|Es mostra l'error de columna i se sol·licita Y novament.|
|6|Error (Format X)|"A"|(No s'hi arriba)|X falla a Convert.ToInt32 (FormatException). S'atrapa, s'imprimeix ChooseOptionError. El bucle while (!validRowInput) es repeteix.|x=0, y=0 (sense canvi), validRowInput=false|S'imprimeix l'error de format i se sol·licita X novament.|
|7|Error (Format Y)|3|"@"|X ja va ser validada. Y falla a Convert.ToInt32 (FormatException). S'atrapa, s'imprimeix ChooseOptionError. El bucle while (!validColInput) es repeteix.|x=3, y=0 (sense canvi), validColInput=false|S'imprimeix l'error de format i se sol·licita Y novament.|
|---|---|---|---|---|---|---|
|8|Error (Rang en Lògica)|-1|-1|Cas de protecció fallida: Si l'usuari aconsegueix sortir dels bucles while amb valors invàlids (improbable), la lògica final els detecta: if (x < 0 \|\| x >= 5 \|\| y < 0 \|\| y >= 5).|x=-1, y=-1, validRowInput=true, validColInput=true (Assumint sortida de bucle)|El codi principal detecta la coordenada no vàlida i es produeix un IndexOutOfRangeException en intentar accedir a matrixVisible[x, y].|

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

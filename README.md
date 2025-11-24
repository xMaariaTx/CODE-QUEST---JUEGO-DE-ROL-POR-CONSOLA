## Capítol 2️⃣ - Increase LVL (Combat amb daus)

**Objectiu:** Combatir un monstre per pujar de nivell.  

**Funcionament:**
- Apareix un monstre aleatori amb HP determinat.  
- El jugador tira un dau (1–6) per atacar.
- Cada tirada resta HP al monstre i mostra un ASCII art del dau.
- Quan HP = 0, el jugador puja de nivell (màx. 5).

**Implementació al codi:**  
- Selecció aleatòria del monstre i HP amb `Random.Next()`.  
- Bucle `while` fins a que `liveMonsters` = 0:  
  - Tirada de dau aleatòria (`Random.Next(0,6)`)  
  - Mostra ASCII art corresponent (`rollDice[dice]`)  
  - Resta HP del monstre i mostra missatge  
  - `Console.ReadKey()` per pausar entre tirades  
- Quan el monstre és derrotat, incrementa `levelWizard`.

**Joc de proves**
|#|Categoria|Variables Clau Internes|Lògica/Condició Provada|Variables Clau (Després)|Resultat Esperat|
|:----|:----|:----|:----|:----|:----|
|1|Normal (Batalla)|liveMonsters (qualsevol valor inicial), Es prem una tecla.|S'inicialitza el combat. El bucle while (liveMonsters > 0) s'executa fins que la vida arriba a zero.|liveMonsters = 0, levelWizard (augmenta en 1)|Combat reeixit. El mag puja un nivell. El bucle acaba i s'imprimeix el missatge de victòria.|
|2|Normal (Dany Mínim)|liveMonsters = 5. dice + 1 = 1 (dany mínim).|El dany aplicat és 1. El bucle es repeteix almenys 5 vegades.|liveMonsters = 0, levelWizard (augmenta en 1)|Combat reeixit però prolongat. El nivell augmenta.|
|3|Normal (Dany Màxim)|liveMonsters = 5. dice + 1 = 6 (dany màxim).|El dany aplicat és 6. La condició liveMonsters < 0 s'activa, forçant liveMonsters = 0.|liveMonsters = 0, levelWizard (augmenta en 1)|Combat reeixit i ràpid. El nivell augmenta.|
|---|---|---|:---:|:---:|:---:|
|4|Límit (Límit Superior Nivell)|levelWizard = 5 (valor màxim inicial).|La condició if (levelWizard < 5) s'avalua com a FALSE.|liveMonsters = 0, levelWizard = 5 (sense canvi)|Combat reeixit, però el nivell no augmenta.|
|5|Límit (Límit Inferior Nivell)|levelWizard = 1 (valor inicial).|La condició if (levelWizard < 5) s'avalua com a TRUE.|liveMonsters = 0, levelWizard = 2|Combat reeixit. El nivell augmenta d'1 a 2.|
|---|---|---|:---:|:---:|:---:|
|6|Error (Vida inicial 0)|liveMonsters = 0 (encara que és poc probable per hpMonsters).|La condició while (liveMonsters > 0) s'avalua com a FALSE immediatament.|liveMonsters = 0, levelWizard (augmenta en 1)|El combat se salta. S'imprimeix el missatge de derrota (MessageDefeated) i el nivell augmenta (si levelWizard < 5).|
|7|Error (Lògica: Dany Negatiu)|liveMonsters = 5. dany = 6.|La vida cau a -1. El codi corregeix a if (liveMonsters < 0) { liveMonsters = 0; }.|liveMonsters = 0, levelWizard (augmenta en 1)|La lògica de combat funciona correctament, assegurant que la vida no es mostri com a negativa.|
